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

namespace Vortice.Vulkan;

unsafe partial class Vma
{
	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaCreateAllocator")]
	private static extern VkResult vmaCreateAllocatorPrivate(VmaAllocatorCreateInfo* createInfo, VmaAllocator* allocator);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaCreateAllocator")]
	private static extern VkResult vmaCreateAllocatorPrivate(VmaAllocatorCreateInfo* createInfo, out VmaAllocator allocator);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaDestroyAllocator")]
	public static extern void vmaDestroyAllocator(VmaAllocator allocator);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaGetAllocatorInfo")]
	public static extern void vmaGetAllocatorInfo(VmaAllocator allocator, VmaAllocatorInfo* allocatorInfo);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaGetAllocatorInfo")]
	public static extern void vmaGetAllocatorInfo(VmaAllocator allocator, out VmaAllocatorInfo allocatorInfo);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaGetPhysicalDeviceProperties")]
	public static extern void vmaGetPhysicalDeviceProperties(VmaAllocator allocator, VkPhysicalDeviceProperties* physicalDeviceProperties);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaGetPhysicalDeviceProperties")]
	public static extern void vmaGetPhysicalDeviceProperties(VmaAllocator allocator, out VkPhysicalDeviceProperties physicalDeviceProperties);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaGetMemoryProperties")]
	public static extern void vmaGetMemoryProperties(VmaAllocator allocator, VkPhysicalDeviceMemoryProperties* physicalDeviceMemoryProperties);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaGetMemoryProperties")]
	public static extern void vmaGetMemoryProperties(VmaAllocator allocator, out VkPhysicalDeviceMemoryProperties physicalDeviceMemoryProperties);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaGetMemoryTypeProperties")]
	public static extern void vmaGetMemoryTypeProperties(VmaAllocator allocator, uint memoryTypeIndex, VkMemoryPropertyFlags* flags);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaGetMemoryTypeProperties")]
	public static extern void vmaGetMemoryTypeProperties(VmaAllocator allocator, uint memoryTypeIndex, out VkMemoryPropertyFlags flags);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaSetCurrentFrameIndex")]
	public static extern void vmaSetCurrentFrameIndex(VmaAllocator allocator, uint frameIndex);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaCalculateStatistics")]
	public static extern void vmaCalculateStatistics(VmaAllocator allocator, VmaTotalStatistics* stats);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaCalculateStatistics")]
	public static extern void vmaCalculateStatistics(VmaAllocator allocator, out VmaTotalStatistics stats);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaGetHeapBudgets")]
	public static extern void vmaGetHeapBudgets(VmaAllocator allocator, VmaBudget* budgets);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaGetHeapBudgets")]
	public static extern void vmaGetHeapBudgets(VmaAllocator allocator, out VmaBudget budgets);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaFindMemoryTypeIndex")]
	public static extern VkResult vmaFindMemoryTypeIndex(VmaAllocator allocator, uint memoryTypeBits, VmaAllocationCreateInfo* allocationCreateInfo, uint* memoryTypeIndex);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaFindMemoryTypeIndexForBufferInfo")]
	public static extern VkResult vmaFindMemoryTypeIndexForBufferInfo(VmaAllocator allocator, VkBufferCreateInfo* bufferCreateInfo, VmaAllocationCreateInfo* allocationCreateInfo, uint* memoryTypeIndex);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaFindMemoryTypeIndexForImageInfo")]
	public static extern VkResult vmaFindMemoryTypeIndexForImageInfo(VmaAllocator allocator, VkImageCreateInfo* imageCreateInfo, VmaAllocationCreateInfo* allocationCreateInfo, uint* memoryTypeIndex);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaCreatePool")]
	public static extern VkResult vmaCreatePool(VmaAllocator allocator, VmaPoolCreateInfo* createInfo, VmaPool* pool);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaCreatePool")]
	public static extern VkResult vmaCreatePool(VmaAllocator allocator, VmaPoolCreateInfo* createInfo, out VmaPool pool);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaDestroyPool")]
	public static extern void vmaDestroyPool(VmaAllocator allocator, VmaPool pool);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaGetPoolStatistics")]
	public static extern void vmaGetPoolStatistics(VmaAllocator allocator, VmaPool pool, VmaStatistics* poolStats);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaGetPoolStatistics")]
	public static extern void vmaGetPoolStatistics(VmaAllocator allocator, VmaPool pool, out VmaStatistics poolStats);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaCalculatePoolStatistics")]
	public static extern void vmaCalculatePoolStatistics(VmaAllocator allocator, VmaPool pool, VmaDetailedStatistics* poolStats);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaCalculatePoolStatistics")]
	public static extern void vmaCalculatePoolStatistics(VmaAllocator allocator, VmaPool pool, out VmaDetailedStatistics poolStats);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaCheckPoolCorruption")]
	public static extern VkResult vmaCheckPoolCorruption(VmaAllocator allocator, VmaPool pool);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaGetPoolName")]
	public static extern void vmaGetPoolName(VmaAllocator allocator, VmaPool pool, sbyte* name);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaSetPoolName")]
	public static extern void vmaSetPoolName(VmaAllocator allocator, VmaPool pool, sbyte* name);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaAllocateMemory")]
	public static extern VkResult vmaAllocateMemory(VmaAllocator allocator, VkMemoryRequirements* vkMemoryRequirements, VmaAllocationCreateInfo* createInfo, VmaAllocation* allocation, VmaAllocationInfo* allocationInfo);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaAllocateMemory")]
	public static extern VkResult vmaAllocateMemory(VmaAllocator allocator, VkMemoryRequirements* vkMemoryRequirements, VmaAllocationCreateInfo* createInfo, out VmaAllocation allocation, out VmaAllocationInfo allocationInfo);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaAllocateMemoryPages")]
	public static extern VkResult vmaAllocateMemoryPages(VmaAllocator allocator, VkMemoryRequirements* vkMemoryRequirements, VmaAllocationCreateInfo* createInfo, nuint allocationCount, VmaAllocation* allocations, VmaAllocationInfo* allocationInfo);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaAllocateMemoryForBuffer")]
	public static extern VkResult vmaAllocateMemoryForBuffer(VmaAllocator allocator, VkBuffer buffer, VmaAllocationCreateInfo* createInfo, VmaAllocation* allocation, VmaAllocationInfo* allocationInfo);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaAllocateMemoryForBuffer")]
	public static extern VkResult vmaAllocateMemoryForBuffer(VmaAllocator allocator, VkBuffer buffer, VmaAllocationCreateInfo* createInfo, out VmaAllocation allocation, out VmaAllocationInfo allocationInfo);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaAllocateMemoryForImage")]
	public static extern VkResult vmaAllocateMemoryForImage(VmaAllocator allocator, VkImage image, VmaAllocationCreateInfo* createInfo, VmaAllocation* allocation, VmaAllocationInfo* allocationInfo);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaAllocateMemoryForImage")]
	public static extern VkResult vmaAllocateMemoryForImage(VmaAllocator allocator, VkImage image, VmaAllocationCreateInfo* createInfo, out VmaAllocation allocation, out VmaAllocationInfo allocationInfo);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaFreeMemory")]
	public static extern void vmaFreeMemory(VmaAllocator allocator, VmaAllocation allocation);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaFreeMemoryPages")]
	public static extern void vmaFreeMemoryPages(VmaAllocator allocator, nuint allocationCount, VmaAllocation* allocations);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaGetAllocationInfo")]
	public static extern void vmaGetAllocationInfo(VmaAllocator allocator, VmaAllocation allocation, VmaAllocationInfo* allocationInfo);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaSetAllocationUserData")]
	public static extern void vmaSetAllocationUserData(VmaAllocator allocator, VmaAllocation allocation, void* userData);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaSetAllocationName")]
	public static extern void vmaSetAllocationName(VmaAllocator allocator, VmaAllocation allocation, sbyte* name);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaGetAllocationMemoryProperties")]
	public static extern void vmaGetAllocationMemoryProperties(VmaAllocator allocator, VmaAllocation allocation, VkMemoryPropertyFlags* flags);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaMapMemory")]
	public static extern VkResult vmaMapMemory(VmaAllocator allocator, VmaAllocation allocation, void* data);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaUnmapMemory")]
	public static extern void vmaUnmapMemory(VmaAllocator allocator, VmaAllocation allocation);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaFlushAllocation")]
	public static extern VkResult vmaFlushAllocation(VmaAllocator allocator, VmaAllocation allocation, ulong offset, ulong size);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaInvalidateAllocation")]
	public static extern VkResult vmaInvalidateAllocation(VmaAllocator allocator, VmaAllocation allocation, ulong offset, ulong size);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaFlushAllocations")]
	public static extern VkResult vmaFlushAllocations(VmaAllocator allocator, uint allocationCount, VmaAllocation* allocations, ulong* offsets, ulong* sizes);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaInvalidateAllocations")]
	public static extern VkResult vmaInvalidateAllocations(VmaAllocator allocator, uint allocationCount, VmaAllocation* allocations, ulong* offsets, ulong* sizes);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaCheckCorruption")]
	public static extern VkResult vmaCheckCorruption(VmaAllocator allocator, uint memoryTypeBits);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaBeginDefragmentation")]
	public static extern VkResult vmaBeginDefragmentation(VmaAllocator allocator, VmaDefragmentationInfo* info, VmaDefragmentationContext* context);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaEndDefragmentation")]
	public static extern void vmaEndDefragmentation(VmaAllocator allocator, VmaDefragmentationContext context, VmaDefragmentationStats* stats);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaBeginDefragmentationPass")]
	public static extern VkResult vmaBeginDefragmentationPass(VmaAllocator allocator, VmaDefragmentationContext context, VmaDefragmentationPassMoveInfo* passInfo);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaEndDefragmentationPass")]
	public static extern VkResult vmaEndDefragmentationPass(VmaAllocator allocator, VmaDefragmentationContext context, VmaDefragmentationPassMoveInfo* passInfo);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaBindBufferMemory")]
	public static extern VkResult vmaBindBufferMemory(VmaAllocator allocator, VmaAllocation allocation, VkBuffer buffer);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaBindBufferMemory2")]
	public static extern VkResult vmaBindBufferMemory2(VmaAllocator allocator, VmaAllocation allocation, ulong allocationLocalOffset, VkBuffer buffer, void* next);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaBindImageMemory")]
	public static extern VkResult vmaBindImageMemory(VmaAllocator allocator, VmaAllocation allocation, VkImage image);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaBindImageMemory2")]
	public static extern VkResult vmaBindImageMemory2(VmaAllocator allocator, VmaAllocation allocation, ulong allocationLocalOffset, VkImage image, void* next);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaCreateBuffer")]
	public static extern VkResult vmaCreateBuffer(VmaAllocator allocator, VkBufferCreateInfo* bufferCreateInfo, VmaAllocationCreateInfo* allocationCreateInfo, VkBuffer* buffer, VmaAllocation* allocation, VmaAllocationInfo* allocationInfo);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaCreateBuffer")]
	public static extern VkResult vmaCreateBuffer(VmaAllocator allocator, VkBufferCreateInfo* bufferCreateInfo, VmaAllocationCreateInfo* allocationCreateInfo, out VkBuffer buffer, out VmaAllocation allocation, out VmaAllocationInfo allocationInfo);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaCreateBufferWithAlignment")]
	public static extern VkResult vmaCreateBufferWithAlignment(VmaAllocator allocator, VkBufferCreateInfo* bufferCreateInfo, VmaAllocationCreateInfo* allocationCreateInfo, ulong minAlignment, VkBuffer* buffer, VmaAllocation* allocation, VmaAllocationInfo* allocationInfo);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaCreateBufferWithAlignment")]
	public static extern VkResult vmaCreateBufferWithAlignment(VmaAllocator allocator, VkBufferCreateInfo* bufferCreateInfo, VmaAllocationCreateInfo* allocationCreateInfo, ulong minAlignment, out VkBuffer buffer, out VmaAllocation allocation, out VmaAllocationInfo allocationInfo);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaCreateAliasingBuffer")]
	public static extern VkResult vmaCreateAliasingBuffer(VmaAllocator allocator, VmaAllocation allocation, VkBufferCreateInfo* bufferCreateInfo, VkBuffer* buffer);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaCreateAliasingBuffer")]
	public static extern VkResult vmaCreateAliasingBuffer(VmaAllocator allocator, VmaAllocation allocation, VkBufferCreateInfo* bufferCreateInfo, out VkBuffer buffer);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaCreateAliasingBuffer2")]
	public static extern VkResult vmaCreateAliasingBuffer2(VmaAllocator allocator, VmaAllocation allocation, ulong allocationLocalOffset, VkBufferCreateInfo* bufferCreateInfo, VkBuffer* buffer);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaCreateAliasingBuffer2")]
	public static extern VkResult vmaCreateAliasingBuffer2(VmaAllocator allocator, VmaAllocation allocation, ulong allocationLocalOffset, VkBufferCreateInfo* bufferCreateInfo, out VkBuffer buffer);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaDestroyBuffer")]
	public static extern void vmaDestroyBuffer(VmaAllocator allocator, VkBuffer buffer, VmaAllocation allocation);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaCreateImage")]
	public static extern VkResult vmaCreateImage(VmaAllocator allocator, VkImageCreateInfo* imageCreateInfo, VmaAllocationCreateInfo* allocationCreateInfo, VkImage* image, VmaAllocation* allocation, VmaAllocationInfo* allocationInfo);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaCreateImage")]
	public static extern VkResult vmaCreateImage(VmaAllocator allocator, VkImageCreateInfo* imageCreateInfo, VmaAllocationCreateInfo* allocationCreateInfo, out VkImage image, out VmaAllocation allocation, out VmaAllocationInfo allocationInfo);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaCreateAliasingImage")]
	public static extern VkResult vmaCreateAliasingImage(VmaAllocator allocator, VmaAllocation allocation, VkImageCreateInfo* imageCreateInfo, VkImage* image);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaCreateAliasingImage")]
	public static extern VkResult vmaCreateAliasingImage(VmaAllocator allocator, VmaAllocation allocation, VkImageCreateInfo* imageCreateInfo, out VkImage image);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaCreateAliasingImage2")]
	public static extern VkResult vmaCreateAliasingImage2(VmaAllocator allocator, VmaAllocation allocation, ulong allocationLocalOffset, VkImageCreateInfo* imageCreateInfo, VkImage* image);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaCreateAliasingImage2")]
	public static extern VkResult vmaCreateAliasingImage2(VmaAllocator allocator, VmaAllocation allocation, ulong allocationLocalOffset, VkImageCreateInfo* imageCreateInfo, out VkImage image);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaDestroyImage")]
	public static extern void vmaDestroyImage(VmaAllocator allocator, VkImage image, VmaAllocation allocation);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaCreateVirtualBlock")]
	public static extern VkResult vmaCreateVirtualBlock(VmaVirtualBlockCreateInfo* createInfo, VmaVirtualBlock* virtualBlock);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaCreateVirtualBlock")]
	public static extern VkResult vmaCreateVirtualBlock(VmaVirtualBlockCreateInfo* createInfo, out VmaVirtualBlock virtualBlock);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaDestroyVirtualBlock")]
	public static extern void vmaDestroyVirtualBlock(VmaVirtualBlock virtualBlock);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaIsVirtualBlockEmpty")]
	public static extern VkBool32 vmaIsVirtualBlockEmpty(VmaVirtualBlock virtualBlock);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaGetVirtualAllocationInfo")]
	public static extern void vmaGetVirtualAllocationInfo(VmaVirtualBlock virtualBlock, VmaVirtualAllocation allocation, VmaVirtualAllocationInfo* virtualAllocInfo);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaGetVirtualAllocationInfo")]
	public static extern void vmaGetVirtualAllocationInfo(VmaVirtualBlock virtualBlock, VmaVirtualAllocation allocation, out VmaVirtualAllocationInfo virtualAllocInfo);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaVirtualAllocate")]
	public static extern VkResult vmaVirtualAllocate(VmaVirtualBlock virtualBlock, VmaVirtualAllocationCreateInfo* createInfo, VmaVirtualAllocation* allocation, ulong* offset);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaVirtualFree")]
	public static extern void vmaVirtualFree(VmaVirtualBlock virtualBlock, VmaVirtualAllocation allocation);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaClearVirtualBlock")]
	public static extern void vmaClearVirtualBlock(VmaVirtualBlock virtualBlock);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaSetVirtualAllocationUserData")]
	public static extern void vmaSetVirtualAllocationUserData(VmaVirtualBlock virtualBlock, VmaVirtualAllocation allocation, void* userData);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaGetVirtualBlockStatistics")]
	public static extern void vmaGetVirtualBlockStatistics(VmaVirtualBlock virtualBlock, VmaStatistics* stats);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaGetVirtualBlockStatistics")]
	public static extern void vmaGetVirtualBlockStatistics(VmaVirtualBlock virtualBlock, out VmaStatistics stats);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaCalculateVirtualBlockStatistics")]
	public static extern void vmaCalculateVirtualBlockStatistics(VmaVirtualBlock virtualBlock, VmaDetailedStatistics* stats);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaCalculateVirtualBlockStatistics")]
	public static extern void vmaCalculateVirtualBlockStatistics(VmaVirtualBlock virtualBlock, out VmaDetailedStatistics stats);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaBuildVirtualBlockStatsString")]
	public static extern void vmaBuildVirtualBlockStatsString(VmaVirtualBlock virtualBlock, sbyte* statsString, VkBool32 detailedMap);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaFreeVirtualBlockStatsString")]
	public static extern void vmaFreeVirtualBlockStatsString(VmaVirtualBlock virtualBlock, sbyte* statsString);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaBuildStatsString")]
	public static extern void vmaBuildStatsString(VmaAllocator allocator, sbyte* statsString, VkBool32 detailedMap);

	[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "vmaFreeStatsString")]
	public static extern void vmaFreeStatsString(VmaAllocator allocator, sbyte* statsString);

}
