using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200006E RID: 110
	public class PostProcessingComponentBase : Object
	{
		// Token: 0x060007FD RID: 2045 RVA: 0x00088CD0 File Offset: 0x00086ED0
		// Note: this type is marked as 'beforefieldinit'.
		static PostProcessingComponentBase()
		{
			Il2CppClassPointerStore<PostProcessingComponentBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "PostProcessingComponentBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessingComponentBase>.NativeClassPtr);
			PostProcessingComponentBase.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingComponentBase>.NativeClassPtr, "context");
			PostProcessingComponentBase.NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_New_DepthTextureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingComponentBase>.NativeClassPtr, 100664150);
			PostProcessingComponentBase.NativeMethodInfoPtr_get_active_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingComponentBase>.NativeClassPtr, 100664151);
			PostProcessingComponentBase.NativeMethodInfoPtr_OnEnable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingComponentBase>.NativeClassPtr, 100664152);
			PostProcessingComponentBase.NativeMethodInfoPtr_OnDisable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingComponentBase>.NativeClassPtr, 100664153);
			PostProcessingComponentBase.NativeMethodInfoPtr_GetModel_Public_Abstract_Virtual_New_PostProcessingModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingComponentBase>.NativeClassPtr, 100664154);
			PostProcessingComponentBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingComponentBase>.NativeClassPtr, 100664155);
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x00088D8C File Offset: 0x00086F8C
		[CallerCount(65)]
		[CachedScanResults(RefRangeStart = 31227, RefRangeEnd = 31292, XrefRangeStart = 31227, XrefRangeEnd = 31292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DepthTextureMode GetCameraFlags()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PostProcessingComponentBase.NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_New_DepthTextureMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x060007FF RID: 2047 RVA: 0x00088DD4 File Offset: 0x00086FD4
		public unsafe virtual bool active
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PostProcessingComponentBase.NativeMethodInfoPtr_get_active_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x00088E1C File Offset: 0x0008701C
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PostProcessingComponentBase.NativeMethodInfoPtr_OnEnable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x00088E58 File Offset: 0x00087058
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PostProcessingComponentBase.NativeMethodInfoPtr_OnDisable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x00088E94 File Offset: 0x00087094
		[CallerCount(0)]
		public unsafe virtual PostProcessingModel GetModel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PostProcessingComponentBase.NativeMethodInfoPtr_GetModel_Public_Abstract_Virtual_New_PostProcessingModel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PostProcessingModel>(intPtr3) : null;
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00088EE0 File Offset: 0x000870E0
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PostProcessingComponentBase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessingComponentBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingComponentBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x000065F5 File Offset: 0x000047F5
		public PostProcessingComponentBase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000805 RID: 2053 RVA: 0x00088F1C File Offset: 0x0008711C
		// (set) Token: 0x06000806 RID: 2054 RVA: 0x000065FE File Offset: 0x000047FE
		public unsafe PostProcessingContext context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingComponentBase.NativeFieldInfoPtr_context);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessingContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingComponentBase.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004DA RID: 1242
		private static readonly IntPtr NativeFieldInfoPtr_context;

		// Token: 0x040004DB RID: 1243
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_New_DepthTextureMode_0;

		// Token: 0x040004DC RID: 1244
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040004DD RID: 1245
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Virtual_New_Void_0;

		// Token: 0x040004DE RID: 1246
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Public_Virtual_New_Void_0;

		// Token: 0x040004DF RID: 1247
		private static readonly IntPtr NativeMethodInfoPtr_GetModel_Public_Abstract_Virtual_New_PostProcessingModel_0;

		// Token: 0x040004E0 RID: 1248
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
