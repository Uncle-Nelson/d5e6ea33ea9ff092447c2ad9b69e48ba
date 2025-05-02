using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000070 RID: 112
	public class PostProcessingComponentCommandBuffer<T> : PostProcessingComponent<T> where T : PostProcessingModel
	{
		// Token: 0x06000810 RID: 2064 RVA: 0x00089300 File Offset: 0x00087500
		// Note: this type is marked as 'beforefieldinit'.
		static PostProcessingComponentCommandBuffer()
		{
			Il2CppClassPointerStore<PostProcessingComponentCommandBuffer<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "PostProcessingComponentCommandBuffer`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessingComponentCommandBuffer<T>>.NativeClassPtr);
			PostProcessingComponentCommandBuffer<T>.NativeMethodInfoPtr_GetCameraEvent_Public_Abstract_Virtual_New_CameraEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingComponentCommandBuffer<T>>.NativeClassPtr, 100664161);
			PostProcessingComponentCommandBuffer<T>.NativeMethodInfoPtr_GetName_Public_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingComponentCommandBuffer<T>>.NativeClassPtr, 100664162);
			PostProcessingComponentCommandBuffer<T>.NativeMethodInfoPtr_PopulateCommandBuffer_Public_Abstract_Virtual_New_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingComponentCommandBuffer<T>>.NativeClassPtr, 100664163);
			PostProcessingComponentCommandBuffer<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingComponentCommandBuffer<T>>.NativeClassPtr, 100664164);
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x000893BC File Offset: 0x000875BC
		[CallerCount(0)]
		public unsafe virtual CameraEvent GetCameraEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PostProcessingComponentCommandBuffer<T>.NativeMethodInfoPtr_GetCameraEvent_Public_Abstract_Virtual_New_CameraEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00089404 File Offset: 0x00087604
		[CallerCount(0)]
		public unsafe virtual string GetName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PostProcessingComponentCommandBuffer<T>.NativeMethodInfoPtr_GetName_Public_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x00089448 File Offset: 0x00087648
		[CallerCount(0)]
		public unsafe virtual void PopulateCommandBuffer(CommandBuffer cb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PostProcessingComponentCommandBuffer<T>.NativeMethodInfoPtr_PopulateCommandBuffer_Public_Abstract_Virtual_New_Void_CommandBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x00089498 File Offset: 0x00087698
		[CallerCount(263)]
		[CachedScanResults(RefRangeStart = 78516, RefRangeEnd = 78779, XrefRangeStart = 78516, XrefRangeEnd = 78779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PostProcessingComponentCommandBuffer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessingComponentCommandBuffer<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingComponentCommandBuffer<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x00006626 File Offset: 0x00004826
		public PostProcessingComponentCommandBuffer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040004E7 RID: 1255
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraEvent_Public_Abstract_Virtual_New_CameraEvent_0;

		// Token: 0x040004E8 RID: 1256
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Abstract_Virtual_New_String_0;

		// Token: 0x040004E9 RID: 1257
		private static readonly IntPtr NativeMethodInfoPtr_PopulateCommandBuffer_Public_Abstract_Virtual_New_Void_CommandBuffer_0;

		// Token: 0x040004EA RID: 1258
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
