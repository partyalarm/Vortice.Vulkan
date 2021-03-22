﻿// Copyright (c) Amer Koleci and contributors.
// Distributed under the MIT license. See the LICENSE file in the project root for more information.

using System;
using System.Runtime.InteropServices;

namespace Vortice.ShaderCompiler
{
    internal static unsafe class Native
    {
        private static readonly IntPtr s_NativeLibrary = LoadNativeLibrary();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr PFN_InitializeFunc();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFN_ReleaseFunc(IntPtr handle);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr PFN_CloneFunc(IntPtr handle);

        private static PFN_InitializeFunc shaderc_compiler_initialize_ = LoadFunction<PFN_InitializeFunc>(nameof(shaderc_compiler_initialize));
        public static IntPtr shaderc_compiler_initialize() => shaderc_compiler_initialize_();

        private static readonly PFN_ReleaseFunc shaderc_compiler_release_ = LoadFunction<PFN_ReleaseFunc>(nameof(shaderc_compiler_release));
        public static void shaderc_compiler_release(IntPtr handle) => shaderc_compiler_release_(handle);

        // Options
        private static PFN_InitializeFunc shaderc_compile_options_initialize_ = LoadFunction<PFN_InitializeFunc>(nameof(shaderc_compile_options_initialize));
        public static IntPtr shaderc_compile_options_initialize() => shaderc_compile_options_initialize_();

        private static readonly PFN_CloneFunc shaderc_compile_options_clone_ = LoadFunction<PFN_CloneFunc>(nameof(shaderc_compile_options_clone));
        public static IntPtr shaderc_compile_options_clone(IntPtr handle) => shaderc_compile_options_clone_(handle);

        private static readonly PFN_ReleaseFunc shaderc_compile_options_release_ = LoadFunction<PFN_ReleaseFunc>(nameof(shaderc_compile_options_release));
        public static void shaderc_compile_options_release(IntPtr handle) => shaderc_compile_options_release_(handle);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFN_shaderc_compile_options_add_macro_definition(IntPtr options, string name, nuint name_length, string? value, nuint value_length);
        private static readonly PFN_shaderc_compile_options_add_macro_definition shaderc_compile_options_add_macro_definition_ = LoadFunction<PFN_shaderc_compile_options_add_macro_definition>(nameof(shaderc_compile_options_add_macro_definition));
        public static void shaderc_compile_options_add_macro_definition(IntPtr options, string name, nuint name_length, string? value, nuint value_length)
        {
            shaderc_compile_options_add_macro_definition_(options, name, name_length, value, value_length);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr PFN_shaderc_compile_options_set_source_language(IntPtr options, SourceLanguage lang);
        private static readonly PFN_shaderc_compile_options_set_source_language shaderc_compile_options_set_source_language_ = LoadFunction<PFN_shaderc_compile_options_set_source_language>("shaderc_compile_options_set_source_language");
        public static void shaderc_compile_options_set_source_language(IntPtr options, SourceLanguage lang) => shaderc_compile_options_set_source_language_(options, lang);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr PFN_shaderc_compile_options_set_generate_debug_info(IntPtr options);
        private static readonly PFN_shaderc_compile_options_set_generate_debug_info shaderc_compile_options_set_generate_debug_info_ = LoadFunction<PFN_shaderc_compile_options_set_generate_debug_info>("shaderc_compile_options_set_generate_debug_info");
        public static void shaderc_compile_options_set_generate_debug_info(IntPtr options)
        {
            shaderc_compile_options_set_generate_debug_info_(options);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr PFN_shaderc_compile_options_set_optimization_level(IntPtr options, OptimizationLevel level);
        private static readonly PFN_shaderc_compile_options_set_optimization_level shaderc_compile_options_set_optimization_level_ = LoadFunction<PFN_shaderc_compile_options_set_optimization_level>("shaderc_compile_options_set_optimization_level");
        public static void shaderc_compile_options_set_optimization_level(IntPtr options, OptimizationLevel level)
        {
            shaderc_compile_options_set_optimization_level_(options, level);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate IntPtr PFN_shaderc_compile_into_spv(IntPtr compiler, string source, nuint source_size, int shader_kind, string input_file, string entry_point, IntPtr additional_options);

        private static readonly PFN_shaderc_compile_into_spv shaderc_compile_into_spv_ = LoadFunction<PFN_shaderc_compile_into_spv>(nameof(shaderc_compile_into_spv));
        public static IntPtr shaderc_compile_into_spv(IntPtr compiler, string source, nuint source_size, int shader_kind, string input_file, string entry_point, IntPtr additional_options)
        {
            return shaderc_compile_into_spv_(compiler, source, source_size, shader_kind, input_file, entry_point, additional_options);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFN_shaderc_compile_options_set_forced_version_profile(IntPtr options, int version, Profile profile);
        private static readonly PFN_shaderc_compile_options_set_forced_version_profile shaderc_compile_options_set_forced_version_profile_ = LoadFunction<PFN_shaderc_compile_options_set_forced_version_profile>("shaderc_compile_options_set_forced_version_profile");
        public static void shaderc_compile_options_set_forced_version_profile(IntPtr options, int version, Profile profile)
        {
            shaderc_compile_options_set_forced_version_profile_(options, version, profile);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr PFN_shaderc_compile_options_set_suppress_warnings(IntPtr options);
        private static readonly PFN_shaderc_compile_options_set_suppress_warnings shaderc_compile_options_set_suppress_warnings_ = LoadFunction<PFN_shaderc_compile_options_set_suppress_warnings>("shaderc_compile_options_set_suppress_warnings");
        public static void shaderc_compile_options_set_suppress_warnings(IntPtr options) => shaderc_compile_options_set_suppress_warnings_(options);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFN_shaderc_compile_options_set_target_env(IntPtr options, TargetEnvironment target, uint version);
        private static readonly PFN_shaderc_compile_options_set_target_env shaderc_compile_options_set_target_env_ = LoadFunction<PFN_shaderc_compile_options_set_target_env>("shaderc_compile_options_set_target_env");
        public static void shaderc_compile_options_set_target_env(IntPtr options, TargetEnvironment target, uint version)
        {
            shaderc_compile_options_set_target_env_(options, target, version);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFN_shaderc_compile_options_set_target_spirv(IntPtr options, SpirVVersion version);
        private static readonly PFN_shaderc_compile_options_set_target_spirv shaderc_compile_options_set_target_spirv_ = LoadFunction<PFN_shaderc_compile_options_set_target_spirv>("shaderc_compile_options_set_target_spirv");
        public static void shaderc_compile_options_set_target_spirv(IntPtr options, SpirVVersion version)
        {
            shaderc_compile_options_set_target_spirv_(options, version);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFN_shaderc_compile_options_set_warnings_as_errors(IntPtr option);
        private static readonly PFN_shaderc_compile_options_set_warnings_as_errors shaderc_compile_options_set_warnings_as_errors_ = LoadFunction<PFN_shaderc_compile_options_set_warnings_as_errors>("shaderc_compile_options_set_warnings_as_errors");
        public static void shaderc_compile_options_set_warnings_as_errors(IntPtr options)
        {
            shaderc_compile_options_set_warnings_as_errors_(options);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr PFN_shaderc_compile_options_set_limit(IntPtr options, Limit limit, int value);
        private static readonly PFN_shaderc_compile_options_set_limit shaderc_compile_options_set_limit_ = LoadFunction<PFN_shaderc_compile_options_set_limit>("shaderc_compile_options_set_limit");
        public static void shaderc_compile_options_set_limit(IntPtr options, Limit limit, int value)
        {
            shaderc_compile_options_set_limit_(options, limit, value);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFN_shaderc_compile_options_set_auto_bind_uniforms(IntPtr options, bool auto_bind);
        private static readonly PFN_shaderc_compile_options_set_auto_bind_uniforms shaderc_compile_options_set_auto_bind_uniforms_ = LoadFunction<PFN_shaderc_compile_options_set_auto_bind_uniforms>("shaderc_compile_options_set_auto_bind_uniforms");
        public static void shaderc_compile_options_set_auto_bind_uniforms(IntPtr options, bool auto_bind)
        {
            shaderc_compile_options_set_auto_bind_uniforms_(options, auto_bind);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFN_shaderc_compile_options_set_hlsl_io_mapping(IntPtr options, bool hlsl_iomap);
        private static readonly PFN_shaderc_compile_options_set_hlsl_io_mapping shaderc_compile_options_set_hlsl_io_mapping_ = LoadFunction<PFN_shaderc_compile_options_set_hlsl_io_mapping>("shaderc_compile_options_set_hlsl_io_mapping");
        public static void shaderc_compile_options_set_hlsl_io_mapping(IntPtr options, bool hlsl_iomap)
        {
            shaderc_compile_options_set_hlsl_io_mapping_(options, hlsl_iomap);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFN_shaderc_compile_options_set_hlsl_offsets(IntPtr options, bool hlsl_offsets);
        private static readonly PFN_shaderc_compile_options_set_hlsl_offsets shaderc_compile_options_set_hlsl_offsets_ = LoadFunction<PFN_shaderc_compile_options_set_hlsl_offsets>("shaderc_compile_options_set_hlsl_offsets");
        public static void shaderc_compile_options_set_hlsl_offsets(IntPtr options, bool hlsl_offsets)
        {
            shaderc_compile_options_set_hlsl_offsets_(options, hlsl_offsets);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFN_shaderc_compile_options_set_binding_base(IntPtr options, UniformKind kind, uint _base);
        private static readonly PFN_shaderc_compile_options_set_binding_base shaderc_compile_options_set_binding_base_ = LoadFunction<PFN_shaderc_compile_options_set_binding_base>("shaderc_compile_options_set_binding_base");
        public static void shaderc_compile_options_set_binding_base(IntPtr options, UniformKind kind, uint _base)
        {
            shaderc_compile_options_set_binding_base_(options, kind, _base);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFN_shaderc_compile_options_set_binding_base_for_stage(IntPtr options, ShaderKind shader_kind, UniformKind kind, uint _base);
        private static readonly PFN_shaderc_compile_options_set_binding_base_for_stage shaderc_compile_options_set_binding_base_for_stage_ = LoadFunction<PFN_shaderc_compile_options_set_binding_base_for_stage>("shaderc_compile_options_set_binding_base_for_stage");
        public static void shaderc_compile_options_set_binding_base_for_stage(IntPtr options, ShaderKind shader_kind, UniformKind kind, uint _base)
        {
            shaderc_compile_options_set_binding_base_for_stage_(options, shader_kind, kind, _base);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFN_shaderc_compile_options_set_auto_map_locations(IntPtr options, bool auto_map);
        private static readonly PFN_shaderc_compile_options_set_auto_map_locations shaderc_compile_options_set_auto_map_locations_ = LoadFunction<PFN_shaderc_compile_options_set_auto_map_locations>("shaderc_compile_options_set_auto_map_locations");
        public static void shaderc_compile_options_set_auto_map_locations(IntPtr options, bool auto_map)
        {
            shaderc_compile_options_set_auto_map_locations_(options, auto_map);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFN_shaderc_compile_options_set_hlsl_register_set_and_binding_for_stage(IntPtr options, ShaderKind shader_kind, string reg, string set, string binding);
        private static readonly PFN_shaderc_compile_options_set_hlsl_register_set_and_binding_for_stage shaderc_compile_options_set_hlsl_register_set_and_binding_for_stage_ = LoadFunction<PFN_shaderc_compile_options_set_hlsl_register_set_and_binding_for_stage>("shaderc_compile_options_set_hlsl_register_set_and_binding_for_stage");
        public static void shaderc_compile_options_set_hlsl_register_set_and_binding_for_stage(IntPtr options, ShaderKind shader_kind, string reg, string set, string binding)
        {
            shaderc_compile_options_set_hlsl_register_set_and_binding_for_stage_(options, shader_kind, reg, set, binding);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFN_shaderc_compile_options_set_hlsl_register_set_and_binding(IntPtr options, string reg, string set, string binding);
        private static readonly PFN_shaderc_compile_options_set_hlsl_register_set_and_binding shaderc_compile_options_set_hlsl_register_set_and_binding_ = LoadFunction<PFN_shaderc_compile_options_set_hlsl_register_set_and_binding>("shaderc_compile_options_set_hlsl_register_set_and_binding");
        public static void shaderc_compile_options_set_hlsl_register_set_and_binding(IntPtr options, string reg, string set, string binding)
        {
            shaderc_compile_options_set_hlsl_register_set_and_binding_(options, reg, set, binding);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFN_shaderc_compile_options_set_hlsl_functionality1(IntPtr options, bool enable);
        private static readonly PFN_shaderc_compile_options_set_hlsl_functionality1 shaderc_compile_options_set_hlsl_functionality1_ = LoadFunction<PFN_shaderc_compile_options_set_hlsl_functionality1>("shaderc_compile_options_set_hlsl_functionality1");
        public static void shaderc_compile_options_set_hlsl_functionality1(IntPtr options, bool enable)
        {
            shaderc_compile_options_set_hlsl_functionality1_(options, enable);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFN_shaderc_compile_options_set_invert_y(IntPtr options, bool enable);
        private static readonly PFN_shaderc_compile_options_set_invert_y shaderc_compile_options_set_invert_y_ = LoadFunction<PFN_shaderc_compile_options_set_invert_y>("shaderc_compile_options_set_invert_y");
        public static void shaderc_compile_options_set_invert_y(IntPtr options, bool enable)
        {
            shaderc_compile_options_set_invert_y_(options, enable);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFN_shaderc_compile_options_set_nan_clamp(IntPtr options, bool enable);
        private static readonly PFN_shaderc_compile_options_set_nan_clamp shaderc_compile_options_set_nan_clamp_ = LoadFunction<PFN_shaderc_compile_options_set_nan_clamp>("shaderc_compile_options_set_nan_clamp");
        public static void shaderc_compile_options_set_nan_clamp(IntPtr options, bool enable)
        {
            shaderc_compile_options_set_nan_clamp_(options, enable);
        }

        // Result
        private static readonly PFN_ReleaseFunc shaderc_result_release_ = LoadFunction<PFN_ReleaseFunc>(nameof(shaderc_result_release));
        public static void shaderc_result_release(IntPtr handle) => shaderc_result_release_(handle);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate nuint PFN_shaderc_result_get_length(IntPtr result);
        private static readonly PFN_shaderc_result_get_length shaderc_result_get_length_ = LoadFunction<PFN_shaderc_result_get_length>(nameof(shaderc_result_get_length));
        public static nuint shaderc_result_get_length(IntPtr result) => shaderc_result_get_length_(result);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate nuint PFN_shaderc_result_get_num_warnings(IntPtr result);
        private static readonly PFN_shaderc_result_get_num_warnings shaderc_result_get_num_warnings_ = LoadFunction<PFN_shaderc_result_get_num_warnings>(nameof(shaderc_result_get_num_warnings));
        public static nuint shaderc_result_get_num_warnings(IntPtr result) => shaderc_result_get_num_warnings_(result);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate nuint PFN_shaderc_result_get_num_errors(IntPtr result);
        private static readonly PFN_shaderc_result_get_num_errors shaderc_result_get_num_errors_ = LoadFunction<PFN_shaderc_result_get_num_errors>(nameof(shaderc_result_get_num_errors));
        public static nuint shaderc_result_get_num_errors(IntPtr result) => shaderc_result_get_num_errors_(result);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate CompilationStatus PFN_shaderc_result_get_compilation_status(IntPtr result);
        private static readonly PFN_shaderc_result_get_compilation_status shaderc_result_get_compilation_status_ = LoadFunction<PFN_shaderc_result_get_compilation_status>(nameof(shaderc_result_get_compilation_status));
        public static CompilationStatus shaderc_result_get_compilation_status(IntPtr result) => shaderc_result_get_compilation_status_(result);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate byte* PFN_shaderc_result_get_bytes(IntPtr result);
        private static readonly PFN_shaderc_result_get_bytes shaderc_result_get_bytes_ = LoadFunction<PFN_shaderc_result_get_bytes>(nameof(shaderc_result_get_bytes));
        public static byte* shaderc_result_get_bytes(IntPtr result) => shaderc_result_get_bytes_(result);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr PFN_shaderc_result_get_error_message(IntPtr result);
        private static readonly PFN_shaderc_result_get_error_message shaderc_result_get_error_message_ = LoadFunction<PFN_shaderc_result_get_error_message>(nameof(shaderc_result_get_error_message));
        public static IntPtr shaderc_result_get_error_message(IntPtr result) => shaderc_result_get_error_message_(result);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFN_shaderc_get_spv_version(out uint version, out uint revision);
        private static readonly PFN_shaderc_get_spv_version shaderc_get_spv_version_ = LoadFunction<PFN_shaderc_get_spv_version>(nameof(shaderc_get_spv_version));
        public static void shaderc_get_spv_version(out uint version, out uint revision) => shaderc_get_spv_version_(out version, out revision);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate uint PFN_shaderc_parse_version_profile(string str, int* version, Profile* profile);
        private static readonly PFN_shaderc_parse_version_profile shaderc_parse_version_profile_ = LoadFunction<PFN_shaderc_parse_version_profile>("shaderc_parse_version_profile");
        public static bool shaderc_parse_version_profile(string str, int* version, Profile* profile) => shaderc_parse_version_profile_(str, version, profile) == 1;

        #region NativeLibrary Logic
        private static IntPtr LoadNativeLibrary()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return NativeLibrary.Load("shaderc_shared.dll");
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                return NativeLibrary.Load("libshaderc_shared.so");
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                return NativeLibrary.Load("libshaderc_shared.dylib");
            }
            else
            {
                return NativeLibrary.Load("shaderc_shared");
            }
        }

        private static T LoadFunction<T>(string function)
        {
            IntPtr handle = NativeLibrary.GetExport(s_NativeLibrary, function);

            if (handle == IntPtr.Zero)
            {
                throw new EntryPointNotFoundException(function);
            }

            return Marshal.GetDelegateForFunctionPointer<T>(handle);
        }
        #endregion
    }
}
