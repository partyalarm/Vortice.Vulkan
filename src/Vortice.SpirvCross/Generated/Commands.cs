// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Vortice.SPIRV;

namespace Vortice.SpirvCross;

unsafe partial class SpirvCrossApi
{
	[LibraryImport(LibName, EntryPoint = "spvc_get_version")]
	public static partial void spvc_get_version(uint* major, uint* minor, uint* patch);

	[LibraryImport(LibName, EntryPoint = "spvc_get_commit_revision_and_timestamp")]
	public static partial sbyte* spvc_get_commit_revision_and_timestamp();

	[LibraryImport(LibName, EntryPoint = "spvc_msl_vertex_attribute_init")]
	public static partial void spvc_msl_vertex_attribute_init(spvc_msl_vertex_attribute* attr);

	[LibraryImport(LibName, EntryPoint = "spvc_msl_shader_interface_var_init")]
	public static partial void spvc_msl_shader_interface_var_init(spvc_msl_shader_interface_var* var);

	[LibraryImport(LibName, EntryPoint = "spvc_msl_shader_input_init")]
	public static partial void spvc_msl_shader_input_init(spvc_msl_shader_interface_var* input);

	[LibraryImport(LibName, EntryPoint = "spvc_msl_shader_interface_var_init_2")]
	public static partial void spvc_msl_shader_interface_var_init_2(spvc_msl_shader_interface_var_2* var);

	[LibraryImport(LibName, EntryPoint = "spvc_msl_resource_binding_init")]
	public static partial void spvc_msl_resource_binding_init(spvc_msl_resource_binding* binding);

	[LibraryImport(LibName, EntryPoint = "spvc_msl_get_aux_buffer_struct_version")]
	public static partial uint spvc_msl_get_aux_buffer_struct_version();

	[LibraryImport(LibName, EntryPoint = "spvc_msl_constexpr_sampler_init")]
	public static partial void spvc_msl_constexpr_sampler_init(spvc_msl_constexpr_sampler* sampler);

	[LibraryImport(LibName, EntryPoint = "spvc_msl_sampler_ycbcr_conversion_init")]
	public static partial void spvc_msl_sampler_ycbcr_conversion_init(spvc_msl_sampler_ycbcr_conversion* conv);

	[LibraryImport(LibName, EntryPoint = "spvc_hlsl_resource_binding_init")]
	public static partial void spvc_hlsl_resource_binding_init(spvc_hlsl_resource_binding* binding);

	[LibraryImport(LibName, EntryPoint = "spvc_context_create")]
	public static partial spvc_result spvc_context_create(spvc_context* context);

	[LibraryImport(LibName, EntryPoint = "spvc_context_create")]
	public static partial spvc_result spvc_context_create(out spvc_context context);

	[LibraryImport(LibName, EntryPoint = "spvc_context_destroy")]
	public static partial void spvc_context_destroy(spvc_context context);

	[LibraryImport(LibName, EntryPoint = "spvc_context_release_allocations")]
	public static partial void spvc_context_release_allocations(spvc_context context);

	[LibraryImport(LibName, EntryPoint = "spvc_context_get_last_error_string")]
	private static partial sbyte* spvc_context_get_last_error_stringPrivate(spvc_context context);

	[LibraryImport(LibName, EntryPoint = "spvc_context_parse_spirv")]
	public static partial spvc_result spvc_context_parse_spirv(spvc_context context, uint* spirv, nuint word_count, spvc_parsed_ir* parsed_ir);

	[LibraryImport(LibName, EntryPoint = "spvc_context_parse_spirv")]
	public static partial spvc_result spvc_context_parse_spirv(spvc_context context, uint* spirv, nuint word_count, out spvc_parsed_ir parsed_ir);

	[LibraryImport(LibName, EntryPoint = "spvc_context_create_compiler")]
	public static partial spvc_result spvc_context_create_compiler(spvc_context context, spvc_backend backend, spvc_parsed_ir parsed_ir, spvc_capture_mode mode, spvc_compiler* compiler);

	[LibraryImport(LibName, EntryPoint = "spvc_context_create_compiler")]
	public static partial spvc_result spvc_context_create_compiler(spvc_context context, spvc_backend backend, spvc_parsed_ir parsed_ir, spvc_capture_mode mode, out spvc_compiler compiler);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_get_current_id_bound")]
	public static partial uint spvc_compiler_get_current_id_bound(spvc_compiler compiler);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_create_compiler_options")]
	public static partial spvc_result spvc_compiler_create_compiler_options(spvc_compiler compiler, spvc_compiler_options* options);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_create_compiler_options")]
	public static partial spvc_result spvc_compiler_create_compiler_options(spvc_compiler compiler, out spvc_compiler_options options);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_options_set_bool")]
	public static partial spvc_result spvc_compiler_options_set_bool(spvc_compiler_options options, spvc_compiler_option option, SpvcBool value);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_options_set_uint")]
	public static partial spvc_result spvc_compiler_options_set_uint(spvc_compiler_options options, spvc_compiler_option option, uint value);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_install_compiler_options")]
	public static partial spvc_result spvc_compiler_install_compiler_options(spvc_compiler compiler, spvc_compiler_options options);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_compile")]
	public static partial spvc_result spvc_compiler_compile(spvc_compiler compiler, sbyte* source);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_add_header_line")]
	public static partial spvc_result spvc_compiler_add_header_line(spvc_compiler compiler, sbyte* line);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_require_extension")]
	public static partial spvc_result spvc_compiler_require_extension(spvc_compiler compiler, sbyte* ext);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_get_num_required_extensions")]
	public static partial nuint spvc_compiler_get_num_required_extensions(spvc_compiler compiler);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_get_required_extension")]
	public static partial sbyte* spvc_compiler_get_required_extension(spvc_compiler compiler, nuint index);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_flatten_buffer_block")]
	public static partial spvc_result spvc_compiler_flatten_buffer_block(spvc_compiler compiler, uint id);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_variable_is_depth_or_compare")]
	public static partial SpvcBool spvc_compiler_variable_is_depth_or_compare(spvc_compiler compiler, uint id);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_mask_stage_output_by_location")]
	public static partial spvc_result spvc_compiler_mask_stage_output_by_location(spvc_compiler compiler, uint location, uint component);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_mask_stage_output_by_builtin")]
	public static partial spvc_result spvc_compiler_mask_stage_output_by_builtin(spvc_compiler compiler, SpvBuiltIn builtin);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_hlsl_set_root_constants_layout")]
	public static partial spvc_result spvc_compiler_hlsl_set_root_constants_layout(spvc_compiler compiler, spvc_hlsl_root_constants* constant_info, nuint count);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_hlsl_add_vertex_attribute_remap")]
	public static partial spvc_result spvc_compiler_hlsl_add_vertex_attribute_remap(spvc_compiler compiler, spvc_hlsl_vertex_attribute_remap* remap, nuint remaps);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_hlsl_remap_num_workgroups_builtin")]
	public static partial uint spvc_compiler_hlsl_remap_num_workgroups_builtin(spvc_compiler compiler);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_hlsl_set_resource_binding_flags")]
	public static partial spvc_result spvc_compiler_hlsl_set_resource_binding_flags(spvc_compiler compiler, spvc_hlsl_binding_flags flags);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_hlsl_add_resource_binding")]
	public static partial spvc_result spvc_compiler_hlsl_add_resource_binding(spvc_compiler compiler, spvc_hlsl_resource_binding* binding);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_hlsl_is_resource_used")]
	public static partial SpvcBool spvc_compiler_hlsl_is_resource_used(spvc_compiler compiler, SpvExecutionModel model, uint set, uint binding);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_msl_is_rasterization_disabled")]
	public static partial SpvcBool spvc_compiler_msl_is_rasterization_disabled(spvc_compiler compiler);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_msl_needs_aux_buffer")]
	public static partial SpvcBool spvc_compiler_msl_needs_aux_buffer(spvc_compiler compiler);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_msl_needs_swizzle_buffer")]
	public static partial SpvcBool spvc_compiler_msl_needs_swizzle_buffer(spvc_compiler compiler);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_msl_needs_buffer_size_buffer")]
	public static partial SpvcBool spvc_compiler_msl_needs_buffer_size_buffer(spvc_compiler compiler);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_msl_needs_output_buffer")]
	public static partial SpvcBool spvc_compiler_msl_needs_output_buffer(spvc_compiler compiler);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_msl_needs_patch_output_buffer")]
	public static partial SpvcBool spvc_compiler_msl_needs_patch_output_buffer(spvc_compiler compiler);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_msl_needs_input_threadgroup_mem")]
	public static partial SpvcBool spvc_compiler_msl_needs_input_threadgroup_mem(spvc_compiler compiler);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_msl_add_vertex_attribute")]
	public static partial spvc_result spvc_compiler_msl_add_vertex_attribute(spvc_compiler compiler, spvc_msl_vertex_attribute* attrs);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_msl_add_resource_binding")]
	public static partial spvc_result spvc_compiler_msl_add_resource_binding(spvc_compiler compiler, spvc_msl_resource_binding* binding);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_msl_add_shader_input")]
	public static partial spvc_result spvc_compiler_msl_add_shader_input(spvc_compiler compiler, spvc_msl_shader_interface_var* input);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_msl_add_shader_input_2")]
	public static partial spvc_result spvc_compiler_msl_add_shader_input_2(spvc_compiler compiler, spvc_msl_shader_interface_var_2* input);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_msl_add_shader_output")]
	public static partial spvc_result spvc_compiler_msl_add_shader_output(spvc_compiler compiler, spvc_msl_shader_interface_var* output);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_msl_add_shader_output_2")]
	public static partial spvc_result spvc_compiler_msl_add_shader_output_2(spvc_compiler compiler, spvc_msl_shader_interface_var_2* output);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_msl_add_discrete_descriptor_set")]
	public static partial spvc_result spvc_compiler_msl_add_discrete_descriptor_set(spvc_compiler compiler, uint desc_set);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_msl_set_argument_buffer_device_address_space")]
	public static partial spvc_result spvc_compiler_msl_set_argument_buffer_device_address_space(spvc_compiler compiler, uint desc_set, SpvcBool device_address);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_msl_is_vertex_attribute_used")]
	public static partial SpvcBool spvc_compiler_msl_is_vertex_attribute_used(spvc_compiler compiler, uint location);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_msl_is_shader_input_used")]
	public static partial SpvcBool spvc_compiler_msl_is_shader_input_used(spvc_compiler compiler, uint location);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_msl_is_shader_output_used")]
	public static partial SpvcBool spvc_compiler_msl_is_shader_output_used(spvc_compiler compiler, uint location);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_msl_is_resource_used")]
	public static partial SpvcBool spvc_compiler_msl_is_resource_used(spvc_compiler compiler, SpvExecutionModel model, uint set, uint binding);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_msl_remap_constexpr_sampler")]
	public static partial spvc_result spvc_compiler_msl_remap_constexpr_sampler(spvc_compiler compiler, uint id, spvc_msl_constexpr_sampler* sampler);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_msl_remap_constexpr_sampler_by_binding")]
	public static partial spvc_result spvc_compiler_msl_remap_constexpr_sampler_by_binding(spvc_compiler compiler, uint desc_set, uint binding, spvc_msl_constexpr_sampler* sampler);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_msl_remap_constexpr_sampler_ycbcr")]
	public static partial spvc_result spvc_compiler_msl_remap_constexpr_sampler_ycbcr(spvc_compiler compiler, uint id, spvc_msl_constexpr_sampler* sampler, spvc_msl_sampler_ycbcr_conversion* conv);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_msl_remap_constexpr_sampler_by_binding_ycbcr")]
	public static partial spvc_result spvc_compiler_msl_remap_constexpr_sampler_by_binding_ycbcr(spvc_compiler compiler, uint desc_set, uint binding, spvc_msl_constexpr_sampler* sampler, spvc_msl_sampler_ycbcr_conversion* conv);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_msl_set_fragment_output_components")]
	public static partial spvc_result spvc_compiler_msl_set_fragment_output_components(spvc_compiler compiler, uint location, uint components);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_msl_get_automatic_resource_binding")]
	public static partial uint spvc_compiler_msl_get_automatic_resource_binding(spvc_compiler compiler, uint id);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_msl_get_automatic_resource_binding_secondary")]
	public static partial uint spvc_compiler_msl_get_automatic_resource_binding_secondary(spvc_compiler compiler, uint id);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_msl_add_dynamic_buffer")]
	public static partial spvc_result spvc_compiler_msl_add_dynamic_buffer(spvc_compiler compiler, uint desc_set, uint binding, uint index);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_msl_add_inline_uniform_block")]
	public static partial spvc_result spvc_compiler_msl_add_inline_uniform_block(spvc_compiler compiler, uint desc_set, uint binding);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_msl_set_combined_sampler_suffix")]
	public static partial spvc_result spvc_compiler_msl_set_combined_sampler_suffix(spvc_compiler compiler, sbyte* suffix);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_msl_get_combined_sampler_suffix")]
	public static partial sbyte* spvc_compiler_msl_get_combined_sampler_suffix(spvc_compiler compiler);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_get_active_interface_variables")]
	public static partial spvc_result spvc_compiler_get_active_interface_variables(spvc_compiler compiler, spvc_set* set);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_set_enabled_interface_variables")]
	public static partial spvc_result spvc_compiler_set_enabled_interface_variables(spvc_compiler compiler, spvc_set set);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_create_shader_resources")]
	public static partial spvc_result spvc_compiler_create_shader_resources(spvc_compiler compiler, spvc_resources* resources);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_create_shader_resources")]
	public static partial spvc_result spvc_compiler_create_shader_resources(spvc_compiler compiler, out spvc_resources resources);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_create_shader_resources_for_active_variables")]
	public static partial spvc_result spvc_compiler_create_shader_resources_for_active_variables(spvc_compiler compiler, spvc_resources* resources, spvc_set active);

	[LibraryImport(LibName, EntryPoint = "spvc_resources_get_resource_list_for_type")]
	public static partial spvc_result spvc_resources_get_resource_list_for_type(spvc_resources resources, spvc_resource_type type, spvc_reflected_resource* resource_list, nuint* resource_size);

	[LibraryImport(LibName, EntryPoint = "spvc_resources_get_builtin_resource_list_for_type")]
	public static partial spvc_result spvc_resources_get_builtin_resource_list_for_type(spvc_resources resources, spvc_builtin_resource_type type, spvc_reflected_builtin_resource* resource_list, nuint* resource_size);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_set_decoration")]
	public static partial void spvc_compiler_set_decoration(spvc_compiler compiler, uint id, SpvDecoration decoration, uint argument);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_set_decoration_string")]
	public static partial void spvc_compiler_set_decoration_string(spvc_compiler compiler, uint id, SpvDecoration decoration, sbyte* argument);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_set_name")]
	public static partial void spvc_compiler_set_name(spvc_compiler compiler, uint id, sbyte* argument);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_set_member_decoration")]
	public static partial void spvc_compiler_set_member_decoration(spvc_compiler compiler, uint id, uint member_index, SpvDecoration decoration, uint argument);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_set_member_decoration_string")]
	public static partial void spvc_compiler_set_member_decoration_string(spvc_compiler compiler, uint id, uint member_index, SpvDecoration decoration, sbyte* argument);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_set_member_name")]
	public static partial void spvc_compiler_set_member_name(spvc_compiler compiler, uint id, uint member_index, sbyte* argument);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_unset_decoration")]
	public static partial void spvc_compiler_unset_decoration(spvc_compiler compiler, uint id, SpvDecoration decoration);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_unset_member_decoration")]
	public static partial void spvc_compiler_unset_member_decoration(spvc_compiler compiler, uint id, uint member_index, SpvDecoration decoration);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_has_decoration")]
	public static partial SpvcBool spvc_compiler_has_decoration(spvc_compiler compiler, uint id, SpvDecoration decoration);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_has_member_decoration")]
	public static partial SpvcBool spvc_compiler_has_member_decoration(spvc_compiler compiler, uint id, uint member_index, SpvDecoration decoration);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_get_name")]
	private static partial sbyte* spvc_compiler_get_namePrivate(spvc_compiler compiler, uint id);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_get_decoration")]
	public static partial uint spvc_compiler_get_decoration(spvc_compiler compiler, uint id, SpvDecoration decoration);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_get_decoration_string")]
	public static partial sbyte* spvc_compiler_get_decoration_string(spvc_compiler compiler, uint id, SpvDecoration decoration);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_get_member_decoration")]
	public static partial uint spvc_compiler_get_member_decoration(spvc_compiler compiler, uint id, uint member_index, SpvDecoration decoration);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_get_member_decoration_string")]
	public static partial sbyte* spvc_compiler_get_member_decoration_string(spvc_compiler compiler, uint id, uint member_index, SpvDecoration decoration);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_get_member_name")]
	public static partial sbyte* spvc_compiler_get_member_name(spvc_compiler compiler, uint id, uint member_index);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_get_entry_points")]
	public static partial spvc_result spvc_compiler_get_entry_points(spvc_compiler compiler, spvc_entry_point* entry_points, nuint* num_entry_points);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_set_entry_point")]
	public static partial spvc_result spvc_compiler_set_entry_point(spvc_compiler compiler, sbyte* name, SpvExecutionModel model);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_rename_entry_point")]
	public static partial spvc_result spvc_compiler_rename_entry_point(spvc_compiler compiler, sbyte* old_name, sbyte* new_name, SpvExecutionModel model);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_get_cleansed_entry_point_name")]
	public static partial sbyte* spvc_compiler_get_cleansed_entry_point_name(spvc_compiler compiler, sbyte* name, SpvExecutionModel model);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_set_execution_mode")]
	public static partial void spvc_compiler_set_execution_mode(spvc_compiler compiler, SpvExecutionMode mode);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_unset_execution_mode")]
	public static partial void spvc_compiler_unset_execution_mode(spvc_compiler compiler, SpvExecutionMode mode);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_set_execution_mode_with_arguments")]
	public static partial void spvc_compiler_set_execution_mode_with_arguments(spvc_compiler compiler, SpvExecutionMode mode, uint arg0, uint arg1, uint arg2);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_get_execution_modes")]
	public static partial spvc_result spvc_compiler_get_execution_modes(spvc_compiler compiler, SpvExecutionMode* modes, nuint* num_modes);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_get_execution_mode_argument")]
	public static partial uint spvc_compiler_get_execution_mode_argument(spvc_compiler compiler, SpvExecutionMode mode);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_get_execution_mode_argument_by_index")]
	public static partial uint spvc_compiler_get_execution_mode_argument_by_index(spvc_compiler compiler, SpvExecutionMode mode, uint index);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_get_execution_model")]
	public static partial SpvExecutionModel spvc_compiler_get_execution_model(spvc_compiler compiler);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_update_active_builtins")]
	public static partial void spvc_compiler_update_active_builtins(spvc_compiler compiler);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_has_active_builtin")]
	public static partial SpvcBool spvc_compiler_has_active_builtin(spvc_compiler compiler, SpvBuiltIn builtin, SpvStorageClass storage);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_get_type_handle")]
	public static partial spvc_type spvc_compiler_get_type_handle(spvc_compiler compiler, uint id);

	[LibraryImport(LibName, EntryPoint = "spvc_type_get_base_type_id")]
	public static partial uint spvc_type_get_base_type_id(spvc_type type);

	[LibraryImport(LibName, EntryPoint = "spvc_type_get_basetype")]
	public static partial spvc_basetype spvc_type_get_basetype(spvc_type type);

	[LibraryImport(LibName, EntryPoint = "spvc_type_get_bit_width")]
	public static partial uint spvc_type_get_bit_width(spvc_type type);

	[LibraryImport(LibName, EntryPoint = "spvc_type_get_vector_size")]
	public static partial uint spvc_type_get_vector_size(spvc_type type);

	[LibraryImport(LibName, EntryPoint = "spvc_type_get_columns")]
	public static partial uint spvc_type_get_columns(spvc_type type);

	[LibraryImport(LibName, EntryPoint = "spvc_type_get_num_array_dimensions")]
	public static partial uint spvc_type_get_num_array_dimensions(spvc_type type);

	[LibraryImport(LibName, EntryPoint = "spvc_type_array_dimension_is_literal")]
	public static partial SpvcBool spvc_type_array_dimension_is_literal(spvc_type type, uint dimension);

	[LibraryImport(LibName, EntryPoint = "spvc_type_get_array_dimension")]
	public static partial uint spvc_type_get_array_dimension(spvc_type type, uint dimension);

	[LibraryImport(LibName, EntryPoint = "spvc_type_get_num_member_types")]
	public static partial uint spvc_type_get_num_member_types(spvc_type type);

	[LibraryImport(LibName, EntryPoint = "spvc_type_get_member_type")]
	public static partial uint spvc_type_get_member_type(spvc_type type, uint index);

	[LibraryImport(LibName, EntryPoint = "spvc_type_get_storage_class")]
	public static partial SpvStorageClass spvc_type_get_storage_class(spvc_type type);

	[LibraryImport(LibName, EntryPoint = "spvc_type_get_image_sampled_type")]
	public static partial uint spvc_type_get_image_sampled_type(spvc_type type);

	[LibraryImport(LibName, EntryPoint = "spvc_type_get_image_dimension")]
	public static partial SpvDim spvc_type_get_image_dimension(spvc_type type);

	[LibraryImport(LibName, EntryPoint = "spvc_type_get_image_is_depth")]
	public static partial SpvcBool spvc_type_get_image_is_depth(spvc_type type);

	[LibraryImport(LibName, EntryPoint = "spvc_type_get_image_arrayed")]
	public static partial SpvcBool spvc_type_get_image_arrayed(spvc_type type);

	[LibraryImport(LibName, EntryPoint = "spvc_type_get_image_multisampled")]
	public static partial SpvcBool spvc_type_get_image_multisampled(spvc_type type);

	[LibraryImport(LibName, EntryPoint = "spvc_type_get_image_is_storage")]
	public static partial SpvcBool spvc_type_get_image_is_storage(spvc_type type);

	[LibraryImport(LibName, EntryPoint = "spvc_type_get_image_storage_format")]
	public static partial SpvImageFormat spvc_type_get_image_storage_format(spvc_type type);

	[LibraryImport(LibName, EntryPoint = "spvc_type_get_image_access_qualifier")]
	public static partial SpvAccessQualifier spvc_type_get_image_access_qualifier(spvc_type type);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_get_declared_struct_size")]
	public static partial spvc_result spvc_compiler_get_declared_struct_size(spvc_compiler compiler, spvc_type struct_type, nuint* size);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_get_declared_struct_size_runtime_array")]
	public static partial spvc_result spvc_compiler_get_declared_struct_size_runtime_array(spvc_compiler compiler, spvc_type struct_type, nuint array_size, nuint* size);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_get_declared_struct_member_size")]
	public static partial spvc_result spvc_compiler_get_declared_struct_member_size(spvc_compiler compiler, spvc_type type, uint index, nuint* size);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_type_struct_member_offset")]
	public static partial spvc_result spvc_compiler_type_struct_member_offset(spvc_compiler compiler, spvc_type type, uint index, uint* offset);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_type_struct_member_array_stride")]
	public static partial spvc_result spvc_compiler_type_struct_member_array_stride(spvc_compiler compiler, spvc_type type, uint index, uint* stride);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_type_struct_member_matrix_stride")]
	public static partial spvc_result spvc_compiler_type_struct_member_matrix_stride(spvc_compiler compiler, spvc_type type, uint index, uint* stride);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_build_dummy_sampler_for_combined_images")]
	public static partial spvc_result spvc_compiler_build_dummy_sampler_for_combined_images(spvc_compiler compiler, uint* id);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_build_combined_image_samplers")]
	public static partial spvc_result spvc_compiler_build_combined_image_samplers(spvc_compiler compiler);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_get_combined_image_samplers")]
	public static partial spvc_result spvc_compiler_get_combined_image_samplers(spvc_compiler compiler, spvc_combined_image_sampler* samplers, nuint* num_samplers);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_get_specialization_constants")]
	public static partial spvc_result spvc_compiler_get_specialization_constants(spvc_compiler compiler, spvc_specialization_constant* constants, nuint* num_constants);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_get_constant_handle")]
	public static partial spvc_constant spvc_compiler_get_constant_handle(spvc_compiler compiler, uint id);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_get_work_group_size_specialization_constants")]
	public static partial uint spvc_compiler_get_work_group_size_specialization_constants(spvc_compiler compiler, spvc_specialization_constant* x, spvc_specialization_constant* y, spvc_specialization_constant* z);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_get_active_buffer_ranges")]
	public static partial spvc_result spvc_compiler_get_active_buffer_ranges(spvc_compiler compiler, uint id, spvc_buffer_range* ranges, nuint* num_ranges);

	[LibraryImport(LibName, EntryPoint = "spvc_constant_get_scalar_fp16")]
	public static partial float spvc_constant_get_scalar_fp16(spvc_constant constant, uint column, uint row);

	[LibraryImport(LibName, EntryPoint = "spvc_constant_get_scalar_fp32")]
	public static partial float spvc_constant_get_scalar_fp32(spvc_constant constant, uint column, uint row);

	[LibraryImport(LibName, EntryPoint = "spvc_constant_get_scalar_fp64")]
	public static partial double spvc_constant_get_scalar_fp64(spvc_constant constant, uint column, uint row);

	[LibraryImport(LibName, EntryPoint = "spvc_constant_get_scalar_u32")]
	public static partial uint spvc_constant_get_scalar_u32(spvc_constant constant, uint column, uint row);

	[LibraryImport(LibName, EntryPoint = "spvc_constant_get_scalar_i32")]
	public static partial int spvc_constant_get_scalar_i32(spvc_constant constant, uint column, uint row);

	[LibraryImport(LibName, EntryPoint = "spvc_constant_get_scalar_u16")]
	public static partial uint spvc_constant_get_scalar_u16(spvc_constant constant, uint column, uint row);

	[LibraryImport(LibName, EntryPoint = "spvc_constant_get_scalar_i16")]
	public static partial int spvc_constant_get_scalar_i16(spvc_constant constant, uint column, uint row);

	[LibraryImport(LibName, EntryPoint = "spvc_constant_get_scalar_u8")]
	public static partial uint spvc_constant_get_scalar_u8(spvc_constant constant, uint column, uint row);

	[LibraryImport(LibName, EntryPoint = "spvc_constant_get_scalar_i8")]
	public static partial int spvc_constant_get_scalar_i8(spvc_constant constant, uint column, uint row);

	[LibraryImport(LibName, EntryPoint = "spvc_constant_get_subconstants")]
	public static partial void spvc_constant_get_subconstants(spvc_constant constant, uint* constituents, nuint* count);

	[LibraryImport(LibName, EntryPoint = "spvc_constant_get_scalar_u64")]
	public static partial ulong spvc_constant_get_scalar_u64(spvc_constant constant, uint column, uint row);

	[LibraryImport(LibName, EntryPoint = "spvc_constant_get_scalar_i64")]
	public static partial long spvc_constant_get_scalar_i64(spvc_constant constant, uint column, uint row);

	[LibraryImport(LibName, EntryPoint = "spvc_constant_get_type")]
	public static partial uint spvc_constant_get_type(spvc_constant constant);

	[LibraryImport(LibName, EntryPoint = "spvc_constant_set_scalar_fp16")]
	public static partial void spvc_constant_set_scalar_fp16(spvc_constant constant, uint column, uint row, ushort value);

	[LibraryImport(LibName, EntryPoint = "spvc_constant_set_scalar_fp32")]
	public static partial void spvc_constant_set_scalar_fp32(spvc_constant constant, uint column, uint row, float value);

	[LibraryImport(LibName, EntryPoint = "spvc_constant_set_scalar_fp64")]
	public static partial void spvc_constant_set_scalar_fp64(spvc_constant constant, uint column, uint row, double value);

	[LibraryImport(LibName, EntryPoint = "spvc_constant_set_scalar_u32")]
	public static partial void spvc_constant_set_scalar_u32(spvc_constant constant, uint column, uint row, uint value);

	[LibraryImport(LibName, EntryPoint = "spvc_constant_set_scalar_i32")]
	public static partial void spvc_constant_set_scalar_i32(spvc_constant constant, uint column, uint row, int value);

	[LibraryImport(LibName, EntryPoint = "spvc_constant_set_scalar_u64")]
	public static partial void spvc_constant_set_scalar_u64(spvc_constant constant, uint column, uint row, ulong value);

	[LibraryImport(LibName, EntryPoint = "spvc_constant_set_scalar_i64")]
	public static partial void spvc_constant_set_scalar_i64(spvc_constant constant, uint column, uint row, long value);

	[LibraryImport(LibName, EntryPoint = "spvc_constant_set_scalar_u16")]
	public static partial void spvc_constant_set_scalar_u16(spvc_constant constant, uint column, uint row, ushort value);

	[LibraryImport(LibName, EntryPoint = "spvc_constant_set_scalar_i16")]
	public static partial void spvc_constant_set_scalar_i16(spvc_constant constant, uint column, uint row, short value);

	[LibraryImport(LibName, EntryPoint = "spvc_constant_set_scalar_u8")]
	public static partial void spvc_constant_set_scalar_u8(spvc_constant constant, uint column, uint row, byte value);

	[LibraryImport(LibName, EntryPoint = "spvc_constant_set_scalar_i8")]
	public static partial void spvc_constant_set_scalar_i8(spvc_constant constant, uint column, uint row, sbyte value);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_get_binary_offset_for_decoration")]
	public static partial SpvcBool spvc_compiler_get_binary_offset_for_decoration(spvc_compiler compiler, uint id, SpvDecoration decoration, uint* word_offset);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_buffer_is_hlsl_counter_buffer")]
	public static partial SpvcBool spvc_compiler_buffer_is_hlsl_counter_buffer(spvc_compiler compiler, uint id);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_buffer_get_hlsl_counter_buffer")]
	public static partial SpvcBool spvc_compiler_buffer_get_hlsl_counter_buffer(spvc_compiler compiler, uint id, uint* counter_id);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_get_declared_capabilities")]
	public static partial spvc_result spvc_compiler_get_declared_capabilities(spvc_compiler compiler, SpvCapability* capabilities, nuint* num_capabilities);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_get_declared_extensions")]
	public static partial spvc_result spvc_compiler_get_declared_extensions(spvc_compiler compiler, sbyte* extensions, nuint* num_extensions);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_get_remapped_declared_block_name")]
	public static partial sbyte* spvc_compiler_get_remapped_declared_block_name(spvc_compiler compiler, uint id);

	[LibraryImport(LibName, EntryPoint = "spvc_compiler_get_buffer_block_decorations")]
	public static partial spvc_result spvc_compiler_get_buffer_block_decorations(spvc_compiler compiler, uint id, SpvDecoration* decorations, nuint* num_decorations);

}
