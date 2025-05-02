using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000071 RID: 113
	public class PostProcessingComponentRenderTexture<T> : PostProcessingComponent<T> where T : PostProcessingModel
	{
		// Token: 0x06000816 RID: 2070 RVA: 0x000894D4 File Offset: 0x000876D4
		// Note: this type is marked as 'beforefieldinit'.
		static PostProcessingComponentRenderTexture()
		{
			Il2CppClassPointerStore<PostProcessingComponentRenderTexture<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "PostProcessingComponentRenderTexture`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessingComponentRenderTexture<T>>.NativeClassPtr);
			PostProcessingComponentRenderTexture<T>.NativeMethodInfoPtr_Prepare_Public_Virtual_New_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingComponentRenderTexture<T>>.NativeClassPtr, 100664165);
			PostProcessingComponentRenderTexture<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingComponentRenderTexture<T>>.NativeClassPtr, 100664166);
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x00089568 File Offset: 0x00087768
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Prepare(Material material)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PostProcessingComponentRenderTexture<T>.NativeMethodInfoPtr_Prepare_Public_Virtual_New_Void_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x000895B8 File Offset: 0x000877B8
		[CallerCount(263)]
		[CachedScanResults(RefRangeStart = 78516, RefRangeEnd = 78779, XrefRangeStart = 78516, XrefRangeEnd = 78779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PostProcessingComponentRenderTexture() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessingComponentRenderTexture<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingComponentRenderTexture<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x0000662F File Offset: 0x0000482F
		public PostProcessingComponentRenderTexture(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040004EB RID: 1259
		private static readonly IntPtr NativeMethodInfoPtr_Prepare_Public_Virtual_New_Void_Material_0;

		// Token: 0x040004EC RID: 1260
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
