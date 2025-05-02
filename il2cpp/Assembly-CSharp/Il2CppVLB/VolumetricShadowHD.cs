using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x0200009D RID: 157
	public class VolumetricShadowHD : MonoBehaviour
	{
		// Token: 0x06000AB8 RID: 2744 RVA: 0x0009238C File Offset: 0x0009058C
		// Note: this type is marked as 'beforefieldinit'.
		static VolumetricShadowHD()
		{
			Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "VolumetricShadowHD");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr);
			VolumetricShadowHD.NativeFieldInfoPtr_ClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, "ClassName");
			VolumetricShadowHD.NativeFieldInfoPtr_m_Strength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, "m_Strength");
			VolumetricShadowHD.NativeFieldInfoPtr_m_UpdateRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, "m_UpdateRate");
			VolumetricShadowHD.NativeFieldInfoPtr_m_WaitXFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, "m_WaitXFrames");
			VolumetricShadowHD.NativeFieldInfoPtr_m_LayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, "m_LayerMask");
			VolumetricShadowHD.NativeFieldInfoPtr_m_UseOcclusionCulling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, "m_UseOcclusionCulling");
			VolumetricShadowHD.NativeFieldInfoPtr_m_DepthMapResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, "m_DepthMapResolution");
			VolumetricShadowHD.NativeFieldInfoPtr_m_Master = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, "m_Master");
			VolumetricShadowHD.NativeFieldInfoPtr_m_TransformPacked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, "m_TransformPacked");
			VolumetricShadowHD.NativeFieldInfoPtr_m_LastFrameRendered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, "m_LastFrameRendered");
			VolumetricShadowHD.NativeFieldInfoPtr_m_DepthCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, "m_DepthCamera");
			VolumetricShadowHD.NativeFieldInfoPtr_m_NeedToUpdateOcclusionNextFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, "m_NeedToUpdateOcclusionNextFrame");
			VolumetricShadowHD.NativeFieldInfoPtr__INTERNAL_ApplyRandomFrameOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, "_INTERNAL_ApplyRandomFrameOffset");
			VolumetricShadowHD.NativeMethodInfoPtr_get_strength_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664508);
			VolumetricShadowHD.NativeMethodInfoPtr_set_strength_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664509);
			VolumetricShadowHD.NativeMethodInfoPtr_get_updateRate_Public_get_ShadowUpdateRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664510);
			VolumetricShadowHD.NativeMethodInfoPtr_set_updateRate_Public_set_Void_ShadowUpdateRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664511);
			VolumetricShadowHD.NativeMethodInfoPtr_get_waitXFrames_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664512);
			VolumetricShadowHD.NativeMethodInfoPtr_set_waitXFrames_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664513);
			VolumetricShadowHD.NativeMethodInfoPtr_get_layerMask_Public_get_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664514);
			VolumetricShadowHD.NativeMethodInfoPtr_set_layerMask_Public_set_Void_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664515);
			VolumetricShadowHD.NativeMethodInfoPtr_get_useOcclusionCulling_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664516);
			VolumetricShadowHD.NativeMethodInfoPtr_set_useOcclusionCulling_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664517);
			VolumetricShadowHD.NativeMethodInfoPtr_get_depthMapResolution_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664518);
			VolumetricShadowHD.NativeMethodInfoPtr_set_depthMapResolution_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664519);
			VolumetricShadowHD.NativeMethodInfoPtr_ProcessOcclusionManually_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664520);
			VolumetricShadowHD.NativeMethodInfoPtr_UpdateDepthCameraProperties_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664521);
			VolumetricShadowHD.NativeMethodInfoPtr_ProcessOcclusion_Private_Void_ProcessOcclusionSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664522);
			VolumetricShadowHD.NativeMethodInfoPtr_ApplyMaterialProperties_Public_Static_Void_VolumetricShadowHD_BeamGeometryHD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664523);
			VolumetricShadowHD.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664524);
			VolumetricShadowHD.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664525);
			VolumetricShadowHD.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664526);
			VolumetricShadowHD.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664527);
			VolumetricShadowHD.NativeMethodInfoPtr_ProcessOcclusionInternal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664528);
			VolumetricShadowHD.NativeMethodInfoPtr_OnBeamEnabled_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664529);
			VolumetricShadowHD.NativeMethodInfoPtr_OnWillCameraRenderThisBeam_Public_Void_Camera_BeamGeometryHD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664530);
			VolumetricShadowHD.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664531);
			VolumetricShadowHD.NativeMethodInfoPtr_UpdateDepthCameraPropertiesAccordingToBeam_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664532);
			VolumetricShadowHD.NativeMethodInfoPtr_InstantiateOrActivateDepthCamera_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664533);
			VolumetricShadowHD.NativeMethodInfoPtr_DestroyDepthCamera_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664534);
			VolumetricShadowHD.NativeMethodInfoPtr_OnValidateProperties_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664535);
			VolumetricShadowHD.NativeMethodInfoPtr_SetDirty_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664536);
			VolumetricShadowHD.NativeMethodInfoPtr_get__INTERNAL_LastFrameRendered_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664537);
			VolumetricShadowHD.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100664538);
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x0009272C File Offset: 0x0009092C
		// (set) Token: 0x06000ABA RID: 2746 RVA: 0x00092768 File Offset: 0x00090968
		public unsafe float strength
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_get_strength_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81353, XrefRangeEnd = 81354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_set_strength_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000ABB RID: 2747 RVA: 0x000927A8 File Offset: 0x000909A8
		// (set) Token: 0x06000ABC RID: 2748 RVA: 0x000927E4 File Offset: 0x000909E4
		public unsafe ShadowUpdateRate updateRate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_get_updateRate_Public_get_ShadowUpdateRate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29963, RefRangeEnd = 29964, XrefRangeStart = 29963, XrefRangeEnd = 29964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_set_updateRate_Public_set_Void_ShadowUpdateRate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000ABD RID: 2749 RVA: 0x00092824 File Offset: 0x00090A24
		// (set) Token: 0x06000ABE RID: 2750 RVA: 0x00092860 File Offset: 0x00090A60
		public unsafe int waitXFrames
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29988, RefRangeEnd = 29989, XrefRangeStart = 29988, XrefRangeEnd = 29989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_get_waitXFrames_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29989, RefRangeEnd = 29990, XrefRangeStart = 29989, XrefRangeEnd = 29990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_set_waitXFrames_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000ABF RID: 2751 RVA: 0x000928A0 File Offset: 0x00090AA0
		// (set) Token: 0x06000AC0 RID: 2752 RVA: 0x000928DC File Offset: 0x00090ADC
		public unsafe LayerMask layerMask
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_get_layerMask_Public_get_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81354, XrefRangeEnd = 81355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_set_layerMask_Public_set_Void_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x0009291C File Offset: 0x00090B1C
		// (set) Token: 0x06000AC2 RID: 2754 RVA: 0x00092958 File Offset: 0x00090B58
		public unsafe bool useOcclusionCulling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_get_useOcclusionCulling_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81355, XrefRangeEnd = 81360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_set_useOcclusionCulling_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x00092998 File Offset: 0x00090B98
		// (set) Token: 0x06000AC4 RID: 2756 RVA: 0x000929D4 File Offset: 0x00090BD4
		public unsafe int depthMapResolution
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 45639, RefRangeEnd = 45640, XrefRangeStart = 45639, XrefRangeEnd = 45640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_get_depthMapResolution_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81360, XrefRangeEnd = 81379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_set_depthMapResolution_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x00092A14 File Offset: 0x00090C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81379, XrefRangeEnd = 81380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessOcclusionManually()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_ProcessOcclusionManually_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x00092A48 File Offset: 0x00090C48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 81387, RefRangeEnd = 81390, XrefRangeStart = 81380, XrefRangeEnd = 81387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDepthCameraProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_UpdateDepthCameraProperties_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x00092A7C File Offset: 0x00090C7C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 81411, RefRangeEnd = 81415, XrefRangeStart = 81390, XrefRangeEnd = 81411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessOcclusion(VolumetricShadowHD.ProcessOcclusionSource source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref source;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_ProcessOcclusion_Private_Void_ProcessOcclusionSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x00092ABC File Offset: 0x00090CBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81436, RefRangeEnd = 81437, XrefRangeStart = 81415, XrefRangeEnd = 81436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ApplyMaterialProperties(VolumetricShadowHD instance, BeamGeometryHD geom)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(geom);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_ApplyMaterialProperties_Public_Static_Void_VolumetricShadowHD_BeamGeometryHD_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x00092B04 File Offset: 0x00090D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81437, XrefRangeEnd = 81441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x00092B38 File Offset: 0x00090D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81441, XrefRangeEnd = 81447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x00092B6C File Offset: 0x00090D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81447, XrefRangeEnd = 81455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x00092BA0 File Offset: 0x00090DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81455, XrefRangeEnd = 81475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x00092BD4 File Offset: 0x00090DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81475, XrefRangeEnd = 81478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessOcclusionInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_ProcessOcclusionInternal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x00092C08 File Offset: 0x00090E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81478, XrefRangeEnd = 81480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBeamEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_OnBeamEnabled_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x00092C3C File Offset: 0x00090E3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 81491, RefRangeEnd = 81493, XrefRangeStart = 81480, XrefRangeEnd = 81491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnWillCameraRenderThisBeam(Camera cam, BeamGeometryHD beamGeom)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(beamGeom);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_OnWillCameraRenderThisBeam_Public_Void_Camera_BeamGeometryHD_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x00092C90 File Offset: 0x00090E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81493, XrefRangeEnd = 81503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x00092CC4 File Offset: 0x00090EC4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 81512, RefRangeEnd = 81516, XrefRangeStart = 81503, XrefRangeEnd = 81512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDepthCameraPropertiesAccordingToBeam()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_UpdateDepthCameraPropertiesAccordingToBeam_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x00092CF8 File Offset: 0x00090EF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81573, RefRangeEnd = 81574, XrefRangeStart = 81516, XrefRangeEnd = 81573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InstantiateOrActivateDepthCamera()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_InstantiateOrActivateDepthCamera_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x00092D2C File Offset: 0x00090F2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyDepthCamera()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_DestroyDepthCamera_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x00092D60 File Offset: 0x00090F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81574, XrefRangeEnd = 81576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidateProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_OnValidateProperties_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x00092D94 File Offset: 0x00090F94
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 81581, RefRangeEnd = 81584, XrefRangeStart = 81576, XrefRangeEnd = 81581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_SetDirty_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000AD6 RID: 2774 RVA: 0x00092DC8 File Offset: 0x00090FC8
		public unsafe int _INTERNAL_LastFrameRendered
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_get__INTERNAL_LastFrameRendered_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x00092E04 File Offset: 0x00091004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81584, XrefRangeEnd = 81589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumetricShadowHD() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x000078B0 File Offset: 0x00005AB0
		public VolumetricShadowHD(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x00092E40 File Offset: 0x00091040
		// (set) Token: 0x06000ADA RID: 2778 RVA: 0x000078B9 File Offset: 0x00005AB9
		public unsafe static string ClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VolumetricShadowHD.NativeFieldInfoPtr_ClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VolumetricShadowHD.NativeFieldInfoPtr_ClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000ADB RID: 2779 RVA: 0x00092E60 File Offset: 0x00091060
		// (set) Token: 0x06000ADC RID: 2780 RVA: 0x000078CB File Offset: 0x00005ACB
		public unsafe float m_Strength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_Strength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_Strength)) = value;
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000ADD RID: 2781 RVA: 0x00092E88 File Offset: 0x00091088
		// (set) Token: 0x06000ADE RID: 2782 RVA: 0x000078E6 File Offset: 0x00005AE6
		public unsafe ShadowUpdateRate m_UpdateRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_UpdateRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_UpdateRate)) = value;
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000ADF RID: 2783 RVA: 0x00092EB0 File Offset: 0x000910B0
		// (set) Token: 0x06000AE0 RID: 2784 RVA: 0x00007901 File Offset: 0x00005B01
		public unsafe int m_WaitXFrames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_WaitXFrames);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_WaitXFrames)) = value;
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000AE1 RID: 2785 RVA: 0x00092ED8 File Offset: 0x000910D8
		// (set) Token: 0x06000AE2 RID: 2786 RVA: 0x0000791C File Offset: 0x00005B1C
		public unsafe LayerMask m_LayerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_LayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_LayerMask)) = value;
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000AE3 RID: 2787 RVA: 0x00092F00 File Offset: 0x00091100
		// (set) Token: 0x06000AE4 RID: 2788 RVA: 0x00007937 File Offset: 0x00005B37
		public unsafe bool m_UseOcclusionCulling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_UseOcclusionCulling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_UseOcclusionCulling)) = value;
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000AE5 RID: 2789 RVA: 0x00092F28 File Offset: 0x00091128
		// (set) Token: 0x06000AE6 RID: 2790 RVA: 0x00007952 File Offset: 0x00005B52
		public unsafe int m_DepthMapResolution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_DepthMapResolution);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_DepthMapResolution)) = value;
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000AE7 RID: 2791 RVA: 0x00092F50 File Offset: 0x00091150
		// (set) Token: 0x06000AE8 RID: 2792 RVA: 0x0000796D File Offset: 0x00005B6D
		public unsafe VolumetricLightBeamHD m_Master
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_Master);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricLightBeamHD>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_Master), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000AE9 RID: 2793 RVA: 0x00092F80 File Offset: 0x00091180
		// (set) Token: 0x06000AEA RID: 2794 RVA: 0x0000798C File Offset: 0x00005B8C
		public unsafe TransformUtils.Packed m_TransformPacked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_TransformPacked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_TransformPacked)) = value;
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000AEB RID: 2795 RVA: 0x00092FA8 File Offset: 0x000911A8
		// (set) Token: 0x06000AEC RID: 2796 RVA: 0x000079A7 File Offset: 0x00005BA7
		public unsafe int m_LastFrameRendered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_LastFrameRendered);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_LastFrameRendered)) = value;
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000AED RID: 2797 RVA: 0x00092FD0 File Offset: 0x000911D0
		// (set) Token: 0x06000AEE RID: 2798 RVA: 0x000079C2 File Offset: 0x00005BC2
		public unsafe Camera m_DepthCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_DepthCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_DepthCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000AEF RID: 2799 RVA: 0x00093000 File Offset: 0x00091200
		// (set) Token: 0x06000AF0 RID: 2800 RVA: 0x000079E1 File Offset: 0x00005BE1
		public unsafe bool m_NeedToUpdateOcclusionNextFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_NeedToUpdateOcclusionNextFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_NeedToUpdateOcclusionNextFrame)) = value;
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000AF1 RID: 2801 RVA: 0x00093028 File Offset: 0x00091228
		// (set) Token: 0x06000AF2 RID: 2802 RVA: 0x000079FC File Offset: 0x00005BFC
		public unsafe static bool _INTERNAL_ApplyRandomFrameOffset
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(VolumetricShadowHD.NativeFieldInfoPtr__INTERNAL_ApplyRandomFrameOffset, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VolumetricShadowHD.NativeFieldInfoPtr__INTERNAL_ApplyRandomFrameOffset, (void*)(&value));
			}
		}

		// Token: 0x0400071B RID: 1819
		private static readonly IntPtr NativeFieldInfoPtr_ClassName;

		// Token: 0x0400071C RID: 1820
		private static readonly IntPtr NativeFieldInfoPtr_m_Strength;

		// Token: 0x0400071D RID: 1821
		private static readonly IntPtr NativeFieldInfoPtr_m_UpdateRate;

		// Token: 0x0400071E RID: 1822
		private static readonly IntPtr NativeFieldInfoPtr_m_WaitXFrames;

		// Token: 0x0400071F RID: 1823
		private static readonly IntPtr NativeFieldInfoPtr_m_LayerMask;

		// Token: 0x04000720 RID: 1824
		private static readonly IntPtr NativeFieldInfoPtr_m_UseOcclusionCulling;

		// Token: 0x04000721 RID: 1825
		private static readonly IntPtr NativeFieldInfoPtr_m_DepthMapResolution;

		// Token: 0x04000722 RID: 1826
		private static readonly IntPtr NativeFieldInfoPtr_m_Master;

		// Token: 0x04000723 RID: 1827
		private static readonly IntPtr NativeFieldInfoPtr_m_TransformPacked;

		// Token: 0x04000724 RID: 1828
		private static readonly IntPtr NativeFieldInfoPtr_m_LastFrameRendered;

		// Token: 0x04000725 RID: 1829
		private static readonly IntPtr NativeFieldInfoPtr_m_DepthCamera;

		// Token: 0x04000726 RID: 1830
		private static readonly IntPtr NativeFieldInfoPtr_m_NeedToUpdateOcclusionNextFrame;

		// Token: 0x04000727 RID: 1831
		private static readonly IntPtr NativeFieldInfoPtr__INTERNAL_ApplyRandomFrameOffset;

		// Token: 0x04000728 RID: 1832
		private static readonly IntPtr NativeMethodInfoPtr_get_strength_Public_get_Single_0;

		// Token: 0x04000729 RID: 1833
		private static readonly IntPtr NativeMethodInfoPtr_set_strength_Public_set_Void_Single_0;

		// Token: 0x0400072A RID: 1834
		private static readonly IntPtr NativeMethodInfoPtr_get_updateRate_Public_get_ShadowUpdateRate_0;

		// Token: 0x0400072B RID: 1835
		private static readonly IntPtr NativeMethodInfoPtr_set_updateRate_Public_set_Void_ShadowUpdateRate_0;

		// Token: 0x0400072C RID: 1836
		private static readonly IntPtr NativeMethodInfoPtr_get_waitXFrames_Public_get_Int32_0;

		// Token: 0x0400072D RID: 1837
		private static readonly IntPtr NativeMethodInfoPtr_set_waitXFrames_Public_set_Void_Int32_0;

		// Token: 0x0400072E RID: 1838
		private static readonly IntPtr NativeMethodInfoPtr_get_layerMask_Public_get_LayerMask_0;

		// Token: 0x0400072F RID: 1839
		private static readonly IntPtr NativeMethodInfoPtr_set_layerMask_Public_set_Void_LayerMask_0;

		// Token: 0x04000730 RID: 1840
		private static readonly IntPtr NativeMethodInfoPtr_get_useOcclusionCulling_Public_get_Boolean_0;

		// Token: 0x04000731 RID: 1841
		private static readonly IntPtr NativeMethodInfoPtr_set_useOcclusionCulling_Public_set_Void_Boolean_0;

		// Token: 0x04000732 RID: 1842
		private static readonly IntPtr NativeMethodInfoPtr_get_depthMapResolution_Public_get_Int32_0;

		// Token: 0x04000733 RID: 1843
		private static readonly IntPtr NativeMethodInfoPtr_set_depthMapResolution_Public_set_Void_Int32_0;

		// Token: 0x04000734 RID: 1844
		private static readonly IntPtr NativeMethodInfoPtr_ProcessOcclusionManually_Public_Void_0;

		// Token: 0x04000735 RID: 1845
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDepthCameraProperties_Public_Void_0;

		// Token: 0x04000736 RID: 1846
		private static readonly IntPtr NativeMethodInfoPtr_ProcessOcclusion_Private_Void_ProcessOcclusionSource_0;

		// Token: 0x04000737 RID: 1847
		private static readonly IntPtr NativeMethodInfoPtr_ApplyMaterialProperties_Public_Static_Void_VolumetricShadowHD_BeamGeometryHD_0;

		// Token: 0x04000738 RID: 1848
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000739 RID: 1849
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400073A RID: 1850
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x0400073B RID: 1851
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400073C RID: 1852
		private static readonly IntPtr NativeMethodInfoPtr_ProcessOcclusionInternal_Private_Void_0;

		// Token: 0x0400073D RID: 1853
		private static readonly IntPtr NativeMethodInfoPtr_OnBeamEnabled_Private_Void_0;

		// Token: 0x0400073E RID: 1854
		private static readonly IntPtr NativeMethodInfoPtr_OnWillCameraRenderThisBeam_Public_Void_Camera_BeamGeometryHD_0;

		// Token: 0x0400073F RID: 1855
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000740 RID: 1856
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDepthCameraPropertiesAccordingToBeam_Private_Void_0;

		// Token: 0x04000741 RID: 1857
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateOrActivateDepthCamera_Private_Void_0;

		// Token: 0x04000742 RID: 1858
		private static readonly IntPtr NativeMethodInfoPtr_DestroyDepthCamera_Private_Void_0;

		// Token: 0x04000743 RID: 1859
		private static readonly IntPtr NativeMethodInfoPtr_OnValidateProperties_Private_Void_0;

		// Token: 0x04000744 RID: 1860
		private static readonly IntPtr NativeMethodInfoPtr_SetDirty_Private_Void_0;

		// Token: 0x04000745 RID: 1861
		private static readonly IntPtr NativeMethodInfoPtr_get__INTERNAL_LastFrameRendered_Public_get_Int32_0;

		// Token: 0x04000746 RID: 1862
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200081D RID: 2077
		[OriginalName("Assembly-CSharp.dll", "", "ProcessOcclusionSource")]
		public enum ProcessOcclusionSource
		{
			// Token: 0x040080DC RID: 32988
			RenderLoop,
			// Token: 0x040080DD RID: 32989
			OnEnable,
			// Token: 0x040080DE RID: 32990
			EditorUpdate,
			// Token: 0x040080DF RID: 32991
			User
		}

		// Token: 0x0200081E RID: 2078
		[ObfuscatedName("VLB.VolumetricShadowHD+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600BE77 RID: 48759 RVA: 0x002EBE70 File Offset: 0x002EA070
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<VolumetricShadowHD.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumetricShadowHD.__c>.NativeClassPtr);
				VolumetricShadowHD.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricShadowHD.__c>.NativeClassPtr, "<>9");
				VolumetricShadowHD.__c.NativeFieldInfoPtr___9__39_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricShadowHD.__c>.NativeClassPtr, "<>9__39_0");
				VolumetricShadowHD.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD.__c>.NativeClassPtr, 100664541);
				VolumetricShadowHD.__c.NativeMethodInfoPtr__InstantiateOrActivateDepthCamera_b__39_0_Internal_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD.__c>.NativeClassPtr, 100664542);
			}

			// Token: 0x0600BE78 RID: 48760 RVA: 0x002EBEEC File Offset: 0x002EA0EC
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumetricShadowHD.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BE79 RID: 48761 RVA: 0x002EBF28 File Offset: 0x002EA128
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81347, XrefRangeEnd = 81353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstantiateOrActivateDepthCamera_b__39_0(Camera cam)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.__c.NativeMethodInfoPtr__InstantiateOrActivateDepthCamera_b__39_0_Internal_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BE7A RID: 48762 RVA: 0x0005D2EF File Offset: 0x0005B4EF
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003B3C RID: 15164
			// (get) Token: 0x0600BE7B RID: 48763 RVA: 0x002EBF6C File Offset: 0x002EA16C
			// (set) Token: 0x0600BE7C RID: 48764 RVA: 0x0005D2F8 File Offset: 0x0005B4F8
			public unsafe static VolumetricShadowHD.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumetricShadowHD.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricShadowHD.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumetricShadowHD.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B3D RID: 15165
			// (get) Token: 0x0600BE7D RID: 48765 RVA: 0x002EBF94 File Offset: 0x002EA194
			// (set) Token: 0x0600BE7E RID: 48766 RVA: 0x0005D30A File Offset: 0x0005B50A
			public unsafe static Action<Camera> __9__39_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumetricShadowHD.__c.NativeFieldInfoPtr___9__39_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Camera>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumetricShadowHD.__c.NativeFieldInfoPtr___9__39_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040080E0 RID: 32992
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040080E1 RID: 32993
			private static readonly IntPtr NativeFieldInfoPtr___9__39_0;

			// Token: 0x040080E2 RID: 32994
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040080E3 RID: 32995
			private static readonly IntPtr NativeMethodInfoPtr__InstantiateOrActivateDepthCamera_b__39_0_Internal_Void_Camera_0;
		}
	}
}
