// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Text;
using CppAst;

namespace Generator;

public static partial class CsCodeGenerator
{
    private static readonly HashSet<string> s_instanceFunctions =
    [
        "vkGetDeviceProcAddr",
        "vkCmdBeginDebugUtilsLabelEXT",
        "vkCmdEndDebugUtilsLabelEXT",
        "vkCmdInsertDebugUtilsLabelEXT",
        "vkCreateDebugUtilsMessengerEXT",
        "vkDestroyDebugUtilsMessengerEXT",
        "vkQueueBeginDebugUtilsLabelEXT",
        "vkQueueEndDebugUtilsLabelEXT",
        "vkQueueInsertDebugUtilsLabelEXT",
        "vkSetDebugUtilsObjectNameEXT",
        "vkSetDebugUtilsObjectTagEXT",
        "vkSubmitDebugUtilsMessageEXT"
    ];

    private static readonly HashSet<string> s_outReturnFunctions =
    [
        "vkCreateInstance",
        "vkCreateDevice",
        "vkGetPhysicalDeviceFeatures",
        "vkGetPhysicalDeviceFormatProperties",
        "vkGetPhysicalDeviceImageFormatProperties",
        "vkGetPhysicalDeviceProperties",
        "vkGetPhysicalDeviceMemoryProperties",
        "vkGetDeviceQueue",
        "vkGetDeviceMemoryCommitment",
        "vkGetBufferMemoryRequirements",
        "vkGetImageMemoryRequirements",
        "vkAllocateMemory",
        "vkCreateAndroidSurfaceKHR",
        "vkCreateWin32SurfaceKHR",
        "vkCreateXlibSurfaceKHR",
        "vkCreateWaylandSurfaceKHR",
        "vkCreateMetalSurfaceEXT",
        "vkCreateIOSSurfaceMVK",
        "vkCreateMacOSSurfaceMVK",
        "vkCreateFence",
        "vkCreateSemaphore",
        "vkCreateEvent",
        "vkCreateQueryPool",
        "vkCreateBuffer",
        "vkCreateBufferView",
        "vkCreateImage",
        "vkGetImageSubresourceLayout",
        "vkCreateImageView",
        "vkCreateShaderModule",
        "vkCreatePipelineCache",
        //"vkCreateGraphicsPipelines",
        //"vkCreateComputePipelines",
        "vkCreatePipelineLayout",
        "vkCreateSampler",
        "vkCreateDescriptorSetLayout",
        "vkCreateDescriptorPool",
        //"vkAllocateDescriptorSets",
        "vkCreateFramebuffer",
        "vkCreateRenderPass",
        "vkGetRenderAreaGranularity",
        "vkCreateCommandPool",
        //"vkAllocateCommandBuffers",

        "vkGetDeviceGroupPeerMemoryFeaturesKHR",
        "vkGetDeviceQueue2",
        "vkCreateSamplerYcbcrConversion",
        "vkCreateDescriptorUpdateTemplate",
        "vkCreateRenderPass2",
        "vkGetPhysicalDeviceSurfaceSupportKHR",
        "vkGetPhysicalDeviceSurfaceCapabilitiesKHR",

        "vkCreateSwapchainKHR",
        "vkAcquireNextImageKHR",
        "vkGetDeviceGroupSurfacePresentModesKHR",
        "vkAcquireNextImage2KHR",

        "vkCreateDisplayModeKHR",
        "vkGetDisplayPlaneCapabilitiesKHR",
        "vkCreateDisplayPlaneSurfaceKHR",
        "vkCreateSharedSwapchainsKHR",

        "vkCreateDebugUtilsMessengerEXT",

        // vma
        "vmaCreateAllocator",
        "vmaGetAllocatorInfo",
        "vmaGetPhysicalDeviceProperties",
        "vmaGetMemoryProperties",
        "vmaGetMemoryTypeProperties",
        "vmaCalculateStatistics",
        "vmaGetHeapBudgets",
        "vmaCreatePool",
        "vmaGetPoolStatistics",
        "vmaCalculatePoolStatistics",
        "vmaAllocateMemory",
        "vmaAllocateMemoryForBuffer",
        "vmaAllocateMemoryForImage",
        "vmaCreateBuffer",
        "vmaCreateBufferWithAlignment",
        "vmaCreateAliasingBuffer",
        "vmaCreateAliasingBuffer2",
        "vmaCreateImage",
        "vmaCreateAliasingImage",
        "vmaCreateAliasingImage2",
        "vmaCreateVirtualBlock",
        "vmaGetVirtualAllocationInfo",
        "vmaGetVirtualBlockStatistics",
        "vmaCalculateVirtualBlockStatistics",

        // spvc
        "spvc_context_create",
        "spvc_compiler_create_compiler_options",
        "spvc_compiler_create_shader_resources",
        "spvc_context_create_compiler",
        "spvc_context_parse_spirv",
    ];

    private static string GetFunctionPointerSignature(CppFunction function, bool canUseOut, bool allowNonBlittable = true)
    {
        StringBuilder builder = new();
        foreach (CppParameter parameter in function.Parameters)
        {
            string paramCsType = GetCsTypeName(parameter.Type, false);

            if (canUseOut &&
                CanBeUsedAsOutput(parameter.Type, out CppType? cppTypeDeclaration))
            {
                builder.Append("out ");
                paramCsType = GetCsTypeName(cppTypeDeclaration, false);
            }

            builder.Append(paramCsType).Append(", ");
        }

        string returnCsName = GetCsTypeName(function.ReturnType, false);
        if (!allowNonBlittable)
        {
            // Otherwise we get interop issues with non blittable types
            if (returnCsName == "VkBool32")
                returnCsName = "uint";
        }

        builder.Append(returnCsName);

        return $"delegate* unmanaged<{builder}>";
    }

    private static void GenerateCommands(CppCompilation compilation)
    {
        Dictionary<string, CppFunction> commands = new();
        Dictionary<string, CppFunction> instanceCommands = new();
        Dictionary<string, CppFunction> deviceCommands = new();
        foreach (CppFunction? cppFunction in compilation.Functions)
        {
            if (cppFunction.Name == "spvc_context_set_error_callback")
                continue;

            string? csName = cppFunction.Name;

            commands.Add(csName, cppFunction);

            if (cppFunction.Parameters.Count > 0)
            {
                var firstParameter = cppFunction.Parameters[0];
                if (firstParameter.Type is CppTypedef typedef)
                {
                    if (typedef.Name == "VkInstance" ||
                        typedef.Name == "VkPhysicalDevice" ||
                        IsInstanceFunction(cppFunction.Name))
                    {
                        instanceCommands.Add(csName, cppFunction);
                    }
                    else
                    {
                        deviceCommands.Add(csName, cppFunction);
                    }
                }
            }
        }

        if (commands.Count == 0)
            return;

        // Generate Functions
        List<string> usings = new()
        {
            "System",
            "System.Runtime.InteropServices"
        };
        if (_options.ExtraUsings.Count > 0)
        {
            usings.AddRange(_options.ExtraUsings);
        }
        using CodeWriter writer = new(Path.Combine(_options.OutputPath, "Commands.cs"),
            false,
            _options.Namespace,
            usings.ToArray()
            );

        using (writer.PushBlock($"unsafe partial class {_options.ClassName}"))
        {
            foreach (KeyValuePair<string, CppFunction> command in commands)
            {
                CppFunction cppFunction = command.Value;

                if (cppFunction.Name == "vkGetInstanceProcAddr" ||
                    cppFunction.Name == "vkGetDeviceProcAddr")
                {
                    continue;
                }

                bool canUseOut = s_outReturnFunctions.Contains(cppFunction.Name);
                string functionPointerSignature = GetFunctionPointerSignature(cppFunction, false);
                string modifier = "private";

                // Used by VulkanMemoryAllocator
                if (command.Key == "vkGetPhysicalDeviceProperties" ||
                    command.Key == "vkGetBufferMemoryRequirements2KHR" ||
                    command.Key == "vkGetBufferMemoryRequirements2" ||
                    command.Key == "vkGetImageMemoryRequirements2KHR" ||
                    command.Key == "vkGetImageMemoryRequirements2" ||
                    command.Key == "vkBindBufferMemory2KHR" ||
                    command.Key == "vkBindBufferMemory2" ||
                    command.Key == "vkBindImageMemory2KHR" ||
                    command.Key == "vkBindImageMemory2" ||
                    command.Key == "vkGetPhysicalDeviceMemoryProperties2KHR" ||
                    command.Key == "vkGetDeviceImageMemoryRequirements" ||
                    command.Key == "vkGetDeviceBufferMemoryRequirements")
                {
                    modifier = "internal";
                }

                if (_options.GenerateFunctionPointers)
                {
                    writer.WriteLine($"{modifier} static {functionPointerSignature} {command.Key}_ptr;");
                }

                WriteFunctionInvocation(writer, cppFunction, false);

                if (canUseOut)
                {
                    if (_options.GenerateFunctionPointers)
                    {
                        functionPointerSignature = GetFunctionPointerSignature(cppFunction, true);
                        writer.WriteLine($"private static {functionPointerSignature} {command.Key}_out_ptr;");
                    }

                    WriteFunctionInvocation(writer, cppFunction, true);
                }
            }

            if (_options.GenerateFunctionPointers)
            {
                WriteCommands(writer, "GenLoadInstance", instanceCommands);
                WriteCommands(writer, "GenLoadDevice", deviceCommands);
            }
        }
    }

    private static void WriteCommands(CodeWriter writer, string name, Dictionary<string, CppFunction> commands)
    {
        using (writer.PushBlock($"private static void {name}(IntPtr context, LoadFunction load)"))
        {
            foreach (KeyValuePair<string, CppFunction> instanceCommand in commands)
            {
                string commandName = instanceCommand.Key;
                if (commandName == "vkGetInstanceProcAddr" ||
                    commandName == "vkGetDeviceProcAddr")
                {
                    continue;
                }

                bool canUseOut = s_outReturnFunctions.Contains(instanceCommand.Value.Name);
                string functionPointerSignature = GetFunctionPointerSignature(instanceCommand.Value, false);
                writer.WriteLine($"{commandName}_ptr = ({functionPointerSignature}) load(context, nameof({commandName}));");

                if (canUseOut)
                {
                    functionPointerSignature = GetFunctionPointerSignature(instanceCommand.Value, true);
                    writer.WriteLine($"{commandName}_out_ptr = ({functionPointerSignature}) load(context, nameof({commandName}));");
                }
            }
        }
    }

    private static void WriteFunctionInvocation(CodeWriter writer, CppFunction cppFunction, bool canUseOut)
    {
        string returnCsName = GetCsTypeName(cppFunction.ReturnType, false);
        string argumentsString = GetParameterSignature(cppFunction, canUseOut);
        string modifier = "public static";
        string functionName = cppFunction.Name;

        if (cppFunction.Name == "vmaCreateAllocator" ||
            cppFunction.Name == "spvc_context_get_last_error_string" ||
            cppFunction.Name == "spvc_compiler_get_name")
        {
            modifier = "private static";
            functionName += "Private";
        }

        if (!_options.GenerateFunctionPointers)
        {
            modifier += " partial";
            writer.WriteLine($"[LibraryImport(LibName, EntryPoint = \"{cppFunction.Name}\")]");
            writer.WriteLine($"{modifier} {returnCsName} {functionName}({argumentsString});");
        }
        else
        {
            using (writer.PushBlock($"{modifier} {returnCsName} {functionName}({argumentsString})"))
            {
                if (returnCsName != "void")
                {
                    writer.Write("return ");
                }

                if (canUseOut)
                {
                    writer.Write($"{cppFunction.Name}_out_ptr(");
                }
                else
                {
                    writer.Write($"{cppFunction.Name}_ptr(");
                }

                int index = 0;
                foreach (CppParameter cppParameter in cppFunction.Parameters)
                {
                    string paramCsName = GetParameterName(cppParameter.Name);

                    if (canUseOut && CanBeUsedAsOutput(cppParameter.Type, out _))
                    {
                        writer.Write("out ");
                    }

                    writer.Write($"{paramCsName}");

                    if (index < cppFunction.Parameters.Count - 1)
                    {
                        writer.Write(", ");
                    }

                    index++;
                }

                writer.WriteLine(");");
            }
        }

        writer.WriteLine();
    }


    private static void EmitInvoke(CodeWriter writer, CppFunction function, List<string> parameters, bool handleCheckResult = true)
    {
        var postCall = string.Empty;
        if (handleCheckResult)
        {
            var hasResultReturn = GetCsTypeName(function.ReturnType) == "VkResult";
            if (hasResultReturn)
            {
                postCall = ".CheckResult()";
            }
        }

        int index = 0;
        var callArgumentStringBuilder = new StringBuilder();
        foreach (string? parameterName in parameters)
        {
            callArgumentStringBuilder.Append(parameterName);

            if (index < parameters.Count - 1)
            {
                callArgumentStringBuilder.Append(", ");
            }

            index++;
        }

        string callArgumentString = callArgumentStringBuilder.ToString();
        writer.WriteLine($"{function.Name}_ptr({callArgumentString}){postCall};");
    }

    private static bool IsInstanceFunction(string name)
    {
        return s_instanceFunctions.Contains(name);
    }

    public static string GetParameterSignature(CppFunction cppFunction, bool canUseOut)
    {
        return GetParameterSignature(cppFunction.Parameters, canUseOut);
    }

    private static string GetParameterSignature(IList<CppParameter> parameters, bool canUseOut)
    {
        var argumentBuilder = new StringBuilder();
        int index = 0;

        foreach (CppParameter cppParameter in parameters)
        {
            string direction = string.Empty;
            string paramCsTypeName = GetCsTypeName(cppParameter.Type, false);
            string paramCsName = GetParameterName(cppParameter.Name);

            if (canUseOut && CanBeUsedAsOutput(cppParameter.Type, out CppType? cppTypeDeclaration))
            {
                argumentBuilder.Append("out ");
                paramCsTypeName = GetCsTypeName(cppTypeDeclaration, false);
            }

            argumentBuilder.Append(paramCsTypeName).Append(' ').Append(paramCsName);
            if (index < parameters.Count - 1)
            {
                argumentBuilder.Append(", ");
            }
            else
            {
                if (paramCsTypeName == "VkAllocationCallbacks*")
                {
                    argumentBuilder.Append(" = default");
                }
            }

            index++;
        }

        return argumentBuilder.ToString();
    }

    private static string GetParameterName(string name)
    {
        if (name == "event")
            return "@event";

        if (name == "object")
            return "@object";

        if (name.StartsWith('p')
            && char.IsUpper(name[1]))
        {
            name = char.ToLower(name[1]) + name.Substring(2);
            return GetParameterName(name);
        }

        if (name.StartsWith("pp")
            && char.IsUpper(name[2]))
        {
            name = char.ToLower(name[2]) + name.Substring(3);
            return GetParameterName(name);
        }

        return name;
    }

    private static bool CanBeUsedAsOutput(CppType type, out CppType? elementTypeDeclaration)
    {
        if (type is CppPointerType pointerType)
        {
            if (pointerType.ElementType is CppTypedef typedef)
            {
                elementTypeDeclaration = typedef;
                return true;
            }
            else if (pointerType.ElementType is CppClass @class
                && @class.ClassKind != CppClassKind.Class
                && @class.SizeOf > 0)
            {
                elementTypeDeclaration = @class;
                return true;
            }
            else if (pointerType.ElementType is CppEnum @enum
                && @enum.SizeOf > 0)
            {
                elementTypeDeclaration = @enum;
                return true;
            }
            else if (pointerType.ElementType is CppPointerType cppElementPointerType
                && cppElementPointerType.SizeOf > 0)
            {
                elementTypeDeclaration = cppElementPointerType.ElementType;
                return true;
            }
        }

        elementTypeDeclaration = null;
        return false;
    }
}
