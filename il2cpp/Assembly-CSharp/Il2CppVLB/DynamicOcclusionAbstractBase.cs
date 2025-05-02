using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x020000A8 RID: 168
	public class DynamicOcclusionAbstractBase : MonoBehaviour
	{
		// Token: 0x06000B89 RID: 2953 RVA: 0x0009560C File Offset: 0x0009380C
		// Note: this type is marked as 'beforefieldinit'.
		static DynamicOcclusionAbstractBase()
		{
			Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "DynamicOcclusionAbstractBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr);
			DynamicOcclusionAbstractBase.NativeFieldInfoPtr_ClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, "ClassName");
			DynamicOcclusionAbstractBase.NativeFieldInfoPtr_updateRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, "updateRate");
			DynamicOcclusionAbstractBase.NativeFieldInfoPtr_waitXFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, "waitXFrames");
			DynamicOcclusionAbstractBase.NativeFieldInfoPtr_onOcclusionProcessed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, "onOcclusionProcessed");
			DynamicOcclusionAbstractBase.NativeFieldInfoPtr__INTERNAL_ApplyRandomFrameOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, "_INTERNAL_ApplyRandomFrameOffset");
			DynamicOcclusionAbstractBase.NativeFieldInfoPtr_m_TransformPacked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, "m_TransformPacked");
			DynamicOcclusionAbstractBase.NativeFieldInfoPtr_m_LastFrameRendered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, "m_LastFrameRendered");
			DynamicOcclusionAbstractBase.NativeFieldInfoPtr_m_Master = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, "m_Master");
			DynamicOcclusionAbstractBase.NativeFieldInfoPtr_m_MaterialModifierCallbackCached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, "m_MaterialModifierCallbackCached");
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_ProcessOcclusionManually_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664696);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_add_onOcclusionProcessed_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664697);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_remove_onOcclusionProcessed_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664698);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_ProcessOcclusion_Protected_Void_ProcessOcclusionSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664699);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_get__INTERNAL_LastFrameRendered_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664700);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_GetShaderKeyword_Protected_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664701);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_GetDynamicOcclusionMode_Protected_Abstract_Virtual_New_DynamicOcclusion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664702);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnProcessOcclusion_Protected_Abstract_Virtual_New_Boolean_ProcessOcclusionSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664703);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnModifyMaterialCallback_Protected_Abstract_Virtual_New_Void_Interface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664704);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnEnablePostValidate_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664705);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnValidateProperties_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664706);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664707);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664708);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664709);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664710);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnWillCameraRender_Private_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664711);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_DisableOcclusion_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664712);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664713);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr__OnEnable_b__24_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664715);
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x0009586C File Offset: 0x00093A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83354, XrefRangeEnd = 83355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessOcclusionManually()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionAbstractBase.NativeMethodInfoPtr_ProcessOcclusionManually_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x000958A0 File Offset: 0x00093AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83355, XrefRangeEnd = 83359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_onOcclusionProcessed(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionAbstractBase.NativeMethodInfoPtr_add_onOcclusionProcessed_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x000958E4 File Offset: 0x00093AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83359, XrefRangeEnd = 83363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_onOcclusionProcessed(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionAbstractBase.NativeMethodInfoPtr_remove_onOcclusionProcessed_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x00095928 File Offset: 0x00093B28
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 83385, RefRangeEnd = 83388, XrefRangeStart = 83363, XrefRangeEnd = 83385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessOcclusion(DynamicOcclusionAbstractBase.ProcessOcclusionSource source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref source;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionAbstractBase.NativeMethodInfoPtr_ProcessOcclusion_Protected_Void_ProcessOcclusionSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000B8E RID: 2958 RVA: 0x00095968 File Offset: 0x00093B68
		public unsafe int _INTERNAL_LastFrameRendered
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 47051, RefRangeEnd = 47054, XrefRangeStart = 47051, XrefRangeEnd = 47054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionAbstractBase.NativeMethodInfoPtr_get__INTERNAL_LastFrameRendered_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x000959A4 File Offset: 0x00093BA4
		[CallerCount(0)]
		public unsafe virtual string GetShaderKeyword()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionAbstractBase.NativeMethodInfoPtr_GetShaderKeyword_Protected_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x000959E8 File Offset: 0x00093BE8
		[CallerCount(0)]
		public unsafe virtual MaterialManager.SD.DynamicOcclusion GetDynamicOcclusionMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionAbstractBase.NativeMethodInfoPtr_GetDynamicOcclusionMode_Protected_Abstract_Virtual_New_DynamicOcclusion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x00095A30 File Offset: 0x00093C30
		[CallerCount(0)]
		public unsafe virtual bool OnProcessOcclusion(DynamicOcclusionAbstractBase.ProcessOcclusionSource source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref source;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnProcessOcclusion_Protected_Abstract_Virtual_New_Boolean_ProcessOcclusionSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x00095A84 File Offset: 0x00093C84
		[CallerCount(0)]
		public unsafe virtual void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnModifyMaterialCallback_Protected_Abstract_Virtual_New_Void_Interface_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x00095AD4 File Offset: 0x00093CD4
		[CallerCount(0)]
		public unsafe virtual void OnEnablePostValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnEnablePostValidate_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x00095B10 File Offset: 0x00093D10
		[CallerCount(0)]
		public unsafe virtual void OnValidateProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnValidateProperties_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x00095B4C File Offset: 0x00093D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83388, XrefRangeEnd = 83392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionAbstractBase.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x00095B88 File Offset: 0x00093D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83392, XrefRangeEnd = 83394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x00095BC4 File Offset: 0x00093DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83394, XrefRangeEnd = 83441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x00095C00 File Offset: 0x00093E00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 83457, RefRangeEnd = 83459, XrefRangeStart = 83441, XrefRangeEnd = 83457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x00095C3C File Offset: 0x00093E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83459, XrefRangeEnd = 83469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnWillCameraRender(Camera cam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnWillCameraRender_Private_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x00095C80 File Offset: 0x00093E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83469, XrefRangeEnd = 83471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableOcclusion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionAbstractBase.NativeMethodInfoPtr_DisableOcclusion_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x00095CB4 File Offset: 0x00093EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83471, XrefRangeEnd = 83472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicOcclusionAbstractBase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionAbstractBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x00095CF0 File Offset: 0x00093EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83472, XrefRangeEnd = 83475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnEnable_b__24_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionAbstractBase.NativeMethodInfoPtr__OnEnable_b__24_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x00007C87 File Offset: 0x00005E87
		public DynamicOcclusionAbstractBase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000B9E RID: 2974 RVA: 0x00095D24 File Offset: 0x00093F24
		// (set) Token: 0x06000B9F RID: 2975 RVA: 0x00007C90 File Offset: 0x00005E90
		public unsafe static string ClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_ClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_ClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000BA0 RID: 2976 RVA: 0x00095D44 File Offset: 0x00093F44
		// (set) Token: 0x06000BA1 RID: 2977 RVA: 0x00007CA2 File Offset: 0x00005EA2
		public unsafe DynamicOcclusionUpdateRate updateRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_updateRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_updateRate)) = value;
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000BA2 RID: 2978 RVA: 0x00095D6C File Offset: 0x00093F6C
		// (set) Token: 0x06000BA3 RID: 2979 RVA: 0x00007CBD File Offset: 0x00005EBD
		public unsafe int waitXFrames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_waitXFrames);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_waitXFrames)) = value;
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000BA4 RID: 2980 RVA: 0x00095D94 File Offset: 0x00093F94
		// (set) Token: 0x06000BA5 RID: 2981 RVA: 0x00007CD8 File Offset: 0x00005ED8
		public unsafe Action onOcclusionProcessed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_onOcclusionProcessed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_onOcclusionProcessed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000BA6 RID: 2982 RVA: 0x00095DC4 File Offset: 0x00093FC4
		// (set) Token: 0x06000BA7 RID: 2983 RVA: 0x00007CF7 File Offset: 0x00005EF7
		public unsafe static bool _INTERNAL_ApplyRandomFrameOffset
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(DynamicOcclusionAbstractBase.NativeFieldInfoPtr__INTERNAL_ApplyRandomFrameOffset, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DynamicOcclusionAbstractBase.NativeFieldInfoPtr__INTERNAL_ApplyRandomFrameOffset, (void*)(&value));
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000BA8 RID: 2984 RVA: 0x00095DE0 File Offset: 0x00093FE0
		// (set) Token: 0x06000BA9 RID: 2985 RVA: 0x00007D05 File Offset: 0x00005F05
		public unsafe TransformUtils.Packed m_TransformPacked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_m_TransformPacked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_m_TransformPacked)) = value;
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000BAA RID: 2986 RVA: 0x00095E08 File Offset: 0x00094008
		// (set) Token: 0x06000BAB RID: 2987 RVA: 0x00007D20 File Offset: 0x00005F20
		public unsafe int m_LastFrameRendered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_m_LastFrameRendered);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_m_LastFrameRendered)) = value;
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000BAC RID: 2988 RVA: 0x00095E30 File Offset: 0x00094030
		// (set) Token: 0x06000BAD RID: 2989 RVA: 0x00007D3B File Offset: 0x00005F3B
		public unsafe VolumetricLightBeamSD m_Master
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_m_Master);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricLightBeamSD>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_m_Master), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000BAE RID: 2990 RVA: 0x00095E60 File Offset: 0x00094060
		// (set) Token: 0x06000BAF RID: 2991 RVA: 0x00007D5A File Offset: 0x00005F5A
		public unsafe MaterialModifier.Callback m_MaterialModifierCallbackCached
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_m_MaterialModifierCallbackCached);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaterialModifier.Callback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_m_MaterialModifierCallbackCached), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007BB RID: 1979
		private static readonly IntPtr NativeFieldInfoPtr_ClassName;

		// Token: 0x040007BC RID: 1980
		private static readonly IntPtr NativeFieldInfoPtr_updateRate;

		// Token: 0x040007BD RID: 1981
		private static readonly IntPtr NativeFieldInfoPtr_waitXFrames;

		// Token: 0x040007BE RID: 1982
		private static readonly IntPtr NativeFieldInfoPtr_onOcclusionProcessed;

		// Token: 0x040007BF RID: 1983
		private static readonly IntPtr NativeFieldInfoPtr__INTERNAL_ApplyRandomFrameOffset;

		// Token: 0x040007C0 RID: 1984
		private static readonly IntPtr NativeFieldInfoPtr_m_TransformPacked;

		// Token: 0x040007C1 RID: 1985
		private static readonly IntPtr NativeFieldInfoPtr_m_LastFrameRendered;

		// Token: 0x040007C2 RID: 1986
		private static readonly IntPtr NativeFieldInfoPtr_m_Master;

		// Token: 0x040007C3 RID: 1987
		private static readonly IntPtr NativeFieldInfoPtr_m_MaterialModifierCallbackCached;

		// Token: 0x040007C4 RID: 1988
		private static readonly IntPtr NativeMethodInfoPtr_ProcessOcclusionManually_Public_Void_0;

		// Token: 0x040007C5 RID: 1989
		private static readonly IntPtr NativeMethodInfoPtr_add_onOcclusionProcessed_Public_add_Void_Action_0;

		// Token: 0x040007C6 RID: 1990
		private static readonly IntPtr NativeMethodInfoPtr_remove_onOcclusionProcessed_Public_rem_Void_Action_0;

		// Token: 0x040007C7 RID: 1991
		private static readonly IntPtr NativeMethodInfoPtr_ProcessOcclusion_Protected_Void_ProcessOcclusionSource_0;

		// Token: 0x040007C8 RID: 1992
		private static readonly IntPtr NativeMethodInfoPtr_get__INTERNAL_LastFrameRendered_Public_get_Int32_0;

		// Token: 0x040007C9 RID: 1993
		private static readonly IntPtr NativeMethodInfoPtr_GetShaderKeyword_Protected_Abstract_Virtual_New_String_0;

		// Token: 0x040007CA RID: 1994
		private static readonly IntPtr NativeMethodInfoPtr_GetDynamicOcclusionMode_Protected_Abstract_Virtual_New_DynamicOcclusion_0;

		// Token: 0x040007CB RID: 1995
		private static readonly IntPtr NativeMethodInfoPtr_OnProcessOcclusion_Protected_Abstract_Virtual_New_Boolean_ProcessOcclusionSource_0;

		// Token: 0x040007CC RID: 1996
		private static readonly IntPtr NativeMethodInfoPtr_OnModifyMaterialCallback_Protected_Abstract_Virtual_New_Void_Interface_0;

		// Token: 0x040007CD RID: 1997
		private static readonly IntPtr NativeMethodInfoPtr_OnEnablePostValidate_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x040007CE RID: 1998
		private static readonly IntPtr NativeMethodInfoPtr_OnValidateProperties_Protected_Virtual_New_Void_0;

		// Token: 0x040007CF RID: 1999
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040007D0 RID: 2000
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0;

		// Token: 0x040007D1 RID: 2001
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0;

		// Token: 0x040007D2 RID: 2002
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0;

		// Token: 0x040007D3 RID: 2003
		private static readonly IntPtr NativeMethodInfoPtr_OnWillCameraRender_Private_Void_Camera_0;

		// Token: 0x040007D4 RID: 2004
		private static readonly IntPtr NativeMethodInfoPtr_DisableOcclusion_Private_Void_0;

		// Token: 0x040007D5 RID: 2005
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040007D6 RID: 2006
		private static readonly IntPtr NativeMethodInfoPtr__OnEnable_b__24_0_Private_Void_0;

		// Token: 0x02000830 RID: 2096
		[OriginalName("Assembly-CSharp.dll", "", "ProcessOcclusionSource")]
		public enum ProcessOcclusionSource
		{
			// Token: 0x04008161 RID: 33121
			RenderLoop,
			// Token: 0x04008162 RID: 33122
			OnEnable,
			// Token: 0x04008163 RID: 33123
			EditorUpdate,
			// Token: 0x04008164 RID: 33124
			User
		}
	}
}
