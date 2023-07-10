// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Vortice.SpirvCross;

public static partial class SpirvCrossApi
{
	/// <unmanaged>SPVC_C_API_VERSION_MAJOR</unmanaged>
	public const uint SPVC_C_API_VERSION_MAJOR = 0;
	/// <unmanaged>SPVC_C_API_VERSION_MINOR</unmanaged>
	public const uint SPVC_C_API_VERSION_MINOR = 57;
	/// <unmanaged>SPVC_C_API_VERSION_PATCH</unmanaged>
	public const uint SPVC_C_API_VERSION_PATCH = 0;
	public static SpvcBool SPVC_TRUE => new (1);
	public static SpvcBool SPVC_FALSE => new (0);
	/// <unmanaged>SPVC_COMPILER_OPTION_COMMON_BIT</unmanaged>
	public const uint SPVC_COMPILER_OPTION_COMMON_BIT = 0x1000000;
	/// <unmanaged>SPVC_COMPILER_OPTION_GLSL_BIT</unmanaged>
	public const uint SPVC_COMPILER_OPTION_GLSL_BIT = 0x2000000;
	/// <unmanaged>SPVC_COMPILER_OPTION_HLSL_BIT</unmanaged>
	public const uint SPVC_COMPILER_OPTION_HLSL_BIT = 0x4000000;
	/// <unmanaged>SPVC_COMPILER_OPTION_MSL_BIT</unmanaged>
	public const uint SPVC_COMPILER_OPTION_MSL_BIT = 0x8000000;
	/// <unmanaged>SPVC_COMPILER_OPTION_LANG_BITS</unmanaged>
	public const uint SPVC_COMPILER_OPTION_LANG_BITS = 0x0f000000;
	/// <unmanaged>SPVC_COMPILER_OPTION_ENUM_BITS</unmanaged>
	public const float SPVC_COMPILER_OPTION_ENUM_BITS = 0xffffff;
	/// <unmanaged>SPVC_MSL_PUSH_CONSTANT_DESC_SET</unmanaged>
	public const uint SPVC_MSL_PUSH_CONSTANT_DESC_SET = ~0u;
	/// <unmanaged>SPVC_MSL_PUSH_CONSTANT_BINDING</unmanaged>
	public const uint SPVC_MSL_PUSH_CONSTANT_BINDING = 0;
	/// <unmanaged>SPVC_MSL_SWIZZLE_BUFFER_BINDING</unmanaged>
	public const uint SPVC_MSL_SWIZZLE_BUFFER_BINDING = ~1u;
	/// <unmanaged>SPVC_MSL_BUFFER_SIZE_BUFFER_BINDING</unmanaged>
	public const uint SPVC_MSL_BUFFER_SIZE_BUFFER_BINDING = ~2u;
	/// <unmanaged>SPVC_MSL_ARGUMENT_BUFFER_BINDING</unmanaged>
	public const uint SPVC_MSL_ARGUMENT_BUFFER_BINDING = ~3u;
	/// <unmanaged>SPVC_MSL_AUX_BUFFER_STRUCT_VERSION</unmanaged>
	public const uint SPVC_MSL_AUX_BUFFER_STRUCT_VERSION = 1;
	/// <unmanaged>SPVC_HLSL_PUSH_CONSTANT_DESC_SET</unmanaged>
	public const uint SPVC_HLSL_PUSH_CONSTANT_DESC_SET = ~0u;
	/// <unmanaged>SPVC_HLSL_PUSH_CONSTANT_BINDING</unmanaged>
	public const uint SPVC_HLSL_PUSH_CONSTANT_BINDING = 0;
}
