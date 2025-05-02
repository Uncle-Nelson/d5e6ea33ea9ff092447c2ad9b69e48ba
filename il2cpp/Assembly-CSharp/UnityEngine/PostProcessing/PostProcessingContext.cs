using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000072 RID: 114
	public class PostProcessingContext : Object
	{
		// Token: 0x0600081A RID: 2074 RVA: 0x000895F4 File Offset: 0x000877F4
		// Note: this type is marked as 'beforefieldinit'.
		static PostProcessingContext()
		{
			Il2CppClassPointerStore<PostProcessingContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "PostProcessingContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessingContext>.NativeClassPtr);
			PostProcessingContext.NativeFieldInfoPtr_profile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingContext>.NativeClassPtr, "profile");
			PostProcessingContext.NativeFieldInfoPtr_camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingContext>.NativeClassPtr, "camera");
			PostProcessingContext.NativeFieldInfoPtr_materialFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingContext>.NativeClassPtr, "materialFactory");
			PostProcessingContext.NativeFieldInfoPtr_renderTextureFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingContext>.NativeClassPtr, "renderTextureFactory");
			PostProcessingContext.NativeFieldInfoPtr__interrupted_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingContext>.NativeClassPtr, "<interrupted>k__BackingField");
			PostProcessingContext.NativeMethodInfoPtr_get_interrupted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingContext>.NativeClassPtr, 100664167);
			PostProcessingContext.NativeMethodInfoPtr_set_interrupted_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingContext>.NativeClassPtr, 100664168);
			PostProcessingContext.NativeMethodInfoPtr_Interrupt_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingContext>.NativeClassPtr, 100664169);
			PostProcessingContext.NativeMethodInfoPtr_Reset_Public_PostProcessingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingContext>.NativeClassPtr, 100664170);
			PostProcessingContext.NativeMethodInfoPtr_get_isGBufferAvailable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingContext>.NativeClassPtr, 100664171);
			PostProcessingContext.NativeMethodInfoPtr_get_isHdr_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingContext>.NativeClassPtr, 100664172);
			PostProcessingContext.NativeMethodInfoPtr_get_width_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingContext>.NativeClassPtr, 100664173);
			PostProcessingContext.NativeMethodInfoPtr_get_height_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingContext>.NativeClassPtr, 100664174);
			PostProcessingContext.NativeMethodInfoPtr_get_viewport_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingContext>.NativeClassPtr, 100664175);
			PostProcessingContext.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingContext>.NativeClassPtr, 100664176);
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x0600081B RID: 2075 RVA: 0x00089750 File Offset: 0x00087950
		// (set) Token: 0x0600081C RID: 2076 RVA: 0x0008978C File Offset: 0x0008798C
		public unsafe bool interrupted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingContext.NativeMethodInfoPtr_get_interrupted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingContext.NativeMethodInfoPtr_set_interrupted_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x000897CC File Offset: 0x000879CC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 77284, RefRangeEnd = 77293, XrefRangeStart = 77284, XrefRangeEnd = 77293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interrupt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingContext.NativeMethodInfoPtr_Interrupt_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x00089800 File Offset: 0x00087A00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78779, XrefRangeEnd = 78783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PostProcessingContext Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingContext.NativeMethodInfoPtr_Reset_Public_PostProcessingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PostProcessingContext>(intPtr3) : null;
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x0600081F RID: 2079 RVA: 0x00089840 File Offset: 0x00087A40
		public unsafe bool isGBufferAvailable
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 78784, RefRangeEnd = 78788, XrefRangeStart = 78783, XrefRangeEnd = 78784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingContext.NativeMethodInfoPtr_get_isGBufferAvailable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000820 RID: 2080 RVA: 0x0008987C File Offset: 0x00087A7C
		public unsafe bool isHdr
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 78790, RefRangeEnd = 78792, XrefRangeStart = 78788, XrefRangeEnd = 78790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingContext.NativeMethodInfoPtr_get_isHdr_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000821 RID: 2081 RVA: 0x000898B8 File Offset: 0x00087AB8
		public unsafe int width
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 78794, RefRangeEnd = 78808, XrefRangeStart = 78792, XrefRangeEnd = 78794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingContext.NativeMethodInfoPtr_get_width_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000822 RID: 2082 RVA: 0x000898F4 File Offset: 0x00087AF4
		public unsafe int height
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 78810, RefRangeEnd = 78824, XrefRangeStart = 78808, XrefRangeEnd = 78810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingContext.NativeMethodInfoPtr_get_height_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000823 RID: 2083 RVA: 0x00089930 File Offset: 0x00087B30
		public unsafe Rect viewport
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 78825, RefRangeEnd = 78827, XrefRangeStart = 78824, XrefRangeEnd = 78825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingContext.NativeMethodInfoPtr_get_viewport_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x0008996C File Offset: 0x00087B6C
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PostProcessingContext() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessingContext>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingContext.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x00006638 File Offset: 0x00004838
		public PostProcessingContext(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000826 RID: 2086 RVA: 0x000899A8 File Offset: 0x00087BA8
		// (set) Token: 0x06000827 RID: 2087 RVA: 0x00006641 File Offset: 0x00004841
		public unsafe PostProcessingProfile profile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingContext.NativeFieldInfoPtr_profile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessingProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingContext.NativeFieldInfoPtr_profile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000828 RID: 2088 RVA: 0x000899D8 File Offset: 0x00087BD8
		// (set) Token: 0x06000829 RID: 2089 RVA: 0x00006660 File Offset: 0x00004860
		public unsafe Camera camera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingContext.NativeFieldInfoPtr_camera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingContext.NativeFieldInfoPtr_camera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x0600082A RID: 2090 RVA: 0x00089A08 File Offset: 0x00087C08
		// (set) Token: 0x0600082B RID: 2091 RVA: 0x0000667F File Offset: 0x0000487F
		public unsafe MaterialFactory materialFactory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingContext.NativeFieldInfoPtr_materialFactory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaterialFactory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingContext.NativeFieldInfoPtr_materialFactory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x0600082C RID: 2092 RVA: 0x00089A38 File Offset: 0x00087C38
		// (set) Token: 0x0600082D RID: 2093 RVA: 0x0000669E File Offset: 0x0000489E
		public unsafe RenderTextureFactory renderTextureFactory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingContext.NativeFieldInfoPtr_renderTextureFactory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTextureFactory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingContext.NativeFieldInfoPtr_renderTextureFactory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x0600082E RID: 2094 RVA: 0x00089A68 File Offset: 0x00087C68
		// (set) Token: 0x0600082F RID: 2095 RVA: 0x000066BD File Offset: 0x000048BD
		public unsafe bool _interrupted_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingContext.NativeFieldInfoPtr__interrupted_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingContext.NativeFieldInfoPtr__interrupted_k__BackingField)) = value;
			}
		}

		// Token: 0x040004ED RID: 1261
		private static readonly IntPtr NativeFieldInfoPtr_profile;

		// Token: 0x040004EE RID: 1262
		private static readonly IntPtr NativeFieldInfoPtr_camera;

		// Token: 0x040004EF RID: 1263
		private static readonly IntPtr NativeFieldInfoPtr_materialFactory;

		// Token: 0x040004F0 RID: 1264
		private static readonly IntPtr NativeFieldInfoPtr_renderTextureFactory;

		// Token: 0x040004F1 RID: 1265
		private static readonly IntPtr NativeFieldInfoPtr__interrupted_k__BackingField;

		// Token: 0x040004F2 RID: 1266
		private static readonly IntPtr NativeMethodInfoPtr_get_interrupted_Public_get_Boolean_0;

		// Token: 0x040004F3 RID: 1267
		private static readonly IntPtr NativeMethodInfoPtr_set_interrupted_Private_set_Void_Boolean_0;

		// Token: 0x040004F4 RID: 1268
		private static readonly IntPtr NativeMethodInfoPtr_Interrupt_Public_Void_0;

		// Token: 0x040004F5 RID: 1269
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_PostProcessingContext_0;

		// Token: 0x040004F6 RID: 1270
		private static readonly IntPtr NativeMethodInfoPtr_get_isGBufferAvailable_Public_get_Boolean_0;

		// Token: 0x040004F7 RID: 1271
		private static readonly IntPtr NativeMethodInfoPtr_get_isHdr_Public_get_Boolean_0;

		// Token: 0x040004F8 RID: 1272
		private static readonly IntPtr NativeMethodInfoPtr_get_width_Public_get_Int32_0;

		// Token: 0x040004F9 RID: 1273
		private static readonly IntPtr NativeMethodInfoPtr_get_height_Public_get_Int32_0;

		// Token: 0x040004FA RID: 1274
		private static readonly IntPtr NativeMethodInfoPtr_get_viewport_Public_get_Rect_0;

		// Token: 0x040004FB RID: 1275
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
