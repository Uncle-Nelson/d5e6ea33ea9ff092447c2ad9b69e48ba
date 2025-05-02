using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x020000AA RID: 170
	public class DynamicOcclusionRaycasting : DynamicOcclusionAbstractBase
	{
		// Token: 0x06000BD0 RID: 3024 RVA: 0x0009657C File Offset: 0x0009477C
		// Note: this type is marked as 'beforefieldinit'.
		static DynamicOcclusionRaycasting()
		{
			Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "DynamicOcclusionRaycasting");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr);
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_ClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "ClassName");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_dimensions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "dimensions");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_layerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "layerMask");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_considerTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "considerTriggers");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_minOccluderArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "minOccluderArea");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_minSurfaceRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "minSurfaceRatio");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_maxSurfaceDot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "maxSurfaceDot");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_planeAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "planeAlignment");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_planeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "planeOffset");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_fadeDistanceToSurface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "fadeDistanceToSurface");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_m_CurrentHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "m_CurrentHit");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_m_RangeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "m_RangeMultiplier");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr__planeEquationWS_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "<planeEquationWS>k__BackingField");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_m_PrevNonSubHitDirectionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "m_PrevNonSubHitDirectionId");
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_get_fadeDistanceToPlane_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664735);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_set_fadeDistanceToPlane_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664736);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_IsColliderHiddenByDynamicOccluder_Public_Boolean_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664737);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetShaderKeyword_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664738);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetDynamicOcclusionMode_Protected_Virtual_DynamicOcclusion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664739);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_get_planeEquationWS_Public_get_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664740);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_set_planeEquationWS_Private_set_Void_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664741);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_OnValidateProperties_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664742);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_OnEnablePostValidate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664743);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664744);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664745);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetRandomVectorAround_Private_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664746);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_get_queryTriggerInteraction_Private_get_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664747);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_get_raycastMaxDistance_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664748);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetBestHit_Private_HitResult_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664749);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetBestHit3D_Private_HitResult_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664750);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetBestHit2D_Private_HitResult_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664751);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetDirectionCount_Private_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664752);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetDirection_Private_Vector3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664753);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_IsHitValid_Private_Boolean_byref_HitResult_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664754);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_OnProcessOcclusion_Protected_Virtual_Boolean_ProcessOcclusionSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664755);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_SetHit_Private_Void_byref_HitResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664756);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_SetHitNull_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664757);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_OnModifyMaterialCallback_Protected_Virtual_Void_Interface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664758);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_SetClippingPlane_Private_Void_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664759);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_SetClippingPlaneOff_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664760);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_SetPlaneWS_Private_Void_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664761);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664762);
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000BD1 RID: 3025 RVA: 0x000968F4 File Offset: 0x00094AF4
		// (set) Token: 0x06000BD2 RID: 3026 RVA: 0x00096930 File Offset: 0x00094B30
		public unsafe float fadeDistanceToPlane
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_get_fadeDistanceToPlane_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_set_fadeDistanceToPlane_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x00096970 File Offset: 0x00094B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83686, XrefRangeEnd = 83691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsColliderHiddenByDynamicOccluder(Collider collider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_IsColliderHiddenByDynamicOccluder_Public_Boolean_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x000969C0 File Offset: 0x00094BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83691, XrefRangeEnd = 83693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetShaderKeyword()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetShaderKeyword_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x00096A04 File Offset: 0x00094C04
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 76505, RefRangeEnd = 76509, XrefRangeStart = 76505, XrefRangeEnd = 76509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MaterialManager.SD.DynamicOcclusion GetDynamicOcclusionMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetDynamicOcclusionMode_Protected_Virtual_DynamicOcclusion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000BD6 RID: 3030 RVA: 0x00096A4C File Offset: 0x00094C4C
		// (set) Token: 0x06000BD7 RID: 3031 RVA: 0x00096A88 File Offset: 0x00094C88
		public unsafe Plane planeEquationWS
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_get_planeEquationWS_Public_get_Plane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_set_planeEquationWS_Private_set_Void_Plane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x00096AC8 File Offset: 0x00094CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83693, XrefRangeEnd = 83694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValidateProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionRaycasting.NativeMethodInfoPtr_OnValidateProperties_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x00096B04 File Offset: 0x00094D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83694, XrefRangeEnd = 83696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnablePostValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionRaycasting.NativeMethodInfoPtr_OnEnablePostValidate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x00096B40 File Offset: 0x00094D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83696, XrefRangeEnd = 83698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionRaycasting.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x00096B7C File Offset: 0x00094D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83698, XrefRangeEnd = 83709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x00096BB0 File Offset: 0x00094DB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83709, XrefRangeEnd = 83714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref direction;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angleDiff;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetRandomVectorAround_Private_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000BDD RID: 3037 RVA: 0x00096C08 File Offset: 0x00094E08
		public unsafe QueryTriggerInteraction queryTriggerInteraction
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_get_queryTriggerInteraction_Private_get_QueryTriggerInteraction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000BDE RID: 3038 RVA: 0x00096C44 File Offset: 0x00094E44
		public unsafe float raycastMaxDistance
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 83715, RefRangeEnd = 83717, XrefRangeStart = 83714, XrefRangeEnd = 83715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_get_raycastMaxDistance_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x00096C80 File Offset: 0x00094E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83717, XrefRangeEnd = 83720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicOcclusionRaycasting.HitResult GetBestHit(Vector3 rayPos, Vector3 rayDir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rayPos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rayDir;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetBestHit_Private_HitResult_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new DynamicOcclusionRaycasting.HitResult(pointer);
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x00096CD4 File Offset: 0x00094ED4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 83738, RefRangeEnd = 83741, XrefRangeStart = 83720, XrefRangeEnd = 83738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicOcclusionRaycasting.HitResult GetBestHit3D(Vector3 rayPos, Vector3 rayDir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rayPos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rayDir;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetBestHit3D_Private_HitResult_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new DynamicOcclusionRaycasting.HitResult(pointer);
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x00096D28 File Offset: 0x00094F28
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 83761, RefRangeEnd = 83764, XrefRangeStart = 83741, XrefRangeEnd = 83761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicOcclusionRaycasting.HitResult GetBestHit2D(Vector3 rayPos, Vector3 rayDir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rayPos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rayDir;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetBestHit2D_Private_HitResult_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new DynamicOcclusionRaycasting.HitResult(pointer);
		}

		// Token: 0x06000BE2 RID: 3042 RVA: 0x00096D7C File Offset: 0x00094F7C
		[CallerCount(0)]
		public unsafe uint GetDirectionCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetDirectionCount_Private_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x00096DB8 File Offset: 0x00094FB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 83776, RefRangeEnd = 83777, XrefRangeStart = 83764, XrefRangeEnd = 83776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetDirection(uint dirInt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dirInt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetDirection_Private_Vector3_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x00096E04 File Offset: 0x00095004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83777, XrefRangeEnd = 83778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsHitValid(ref DynamicOcclusionRaycasting.HitResult hit, Vector3 forwardVec)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(hit);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forwardVec;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_IsHitValid_Private_Boolean_byref_HitResult_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BE5 RID: 3045 RVA: 0x00096E60 File Offset: 0x00095060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83778, XrefRangeEnd = 83812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool OnProcessOcclusion(DynamicOcclusionAbstractBase.ProcessOcclusionSource source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref source;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionRaycasting.NativeMethodInfoPtr_OnProcessOcclusion_Protected_Virtual_Boolean_ProcessOcclusionSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x00096EB4 File Offset: 0x000950B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 83827, RefRangeEnd = 83828, XrefRangeStart = 83812, XrefRangeEnd = 83827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHit(ref DynamicOcclusionRaycasting.HitResult hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(hit);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_SetHit_Private_Void_byref_HitResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x00096EF8 File Offset: 0x000950F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 83832, RefRangeEnd = 83834, XrefRangeStart = 83828, XrefRangeEnd = 83832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHitNull()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_SetHitNull_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x00096F2C File Offset: 0x0009512C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83834, XrefRangeEnd = 83847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionRaycasting.NativeMethodInfoPtr_OnModifyMaterialCallback_Protected_Virtual_Void_Interface_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x00096F7C File Offset: 0x0009517C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 83855, RefRangeEnd = 83857, XrefRangeStart = 83847, XrefRangeEnd = 83855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetClippingPlane(Plane planeWS)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref planeWS;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_SetClippingPlane_Private_Void_Plane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BEA RID: 3050 RVA: 0x00096FBC File Offset: 0x000951BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83857, XrefRangeEnd = 83859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetClippingPlaneOff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_SetClippingPlaneOff_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x00096FF0 File Offset: 0x000951F0
		[CallerCount(0)]
		public unsafe void SetPlaneWS(Plane planeWS)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref planeWS;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_SetPlaneWS_Private_Void_Plane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x00097030 File Offset: 0x00095230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83859, XrefRangeEnd = 83867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicOcclusionRaycasting() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x00007E3A File Offset: 0x0000603A
		public DynamicOcclusionRaycasting(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000BEE RID: 3054 RVA: 0x0009706C File Offset: 0x0009526C
		// (set) Token: 0x06000BEF RID: 3055 RVA: 0x00007E43 File Offset: 0x00006043
		public new unsafe static string ClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DynamicOcclusionRaycasting.NativeFieldInfoPtr_ClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DynamicOcclusionRaycasting.NativeFieldInfoPtr_ClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000BF0 RID: 3056 RVA: 0x0009708C File Offset: 0x0009528C
		// (set) Token: 0x06000BF1 RID: 3057 RVA: 0x00007E55 File Offset: 0x00006055
		public unsafe Dimensions dimensions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_dimensions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_dimensions)) = value;
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000BF2 RID: 3058 RVA: 0x000970B4 File Offset: 0x000952B4
		// (set) Token: 0x06000BF3 RID: 3059 RVA: 0x00007E70 File Offset: 0x00006070
		public unsafe LayerMask layerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_layerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_layerMask)) = value;
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000BF4 RID: 3060 RVA: 0x000970DC File Offset: 0x000952DC
		// (set) Token: 0x06000BF5 RID: 3061 RVA: 0x00007E8B File Offset: 0x0000608B
		public unsafe bool considerTriggers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_considerTriggers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_considerTriggers)) = value;
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000BF6 RID: 3062 RVA: 0x00097104 File Offset: 0x00095304
		// (set) Token: 0x06000BF7 RID: 3063 RVA: 0x00007EA6 File Offset: 0x000060A6
		public unsafe float minOccluderArea
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_minOccluderArea);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_minOccluderArea)) = value;
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000BF8 RID: 3064 RVA: 0x0009712C File Offset: 0x0009532C
		// (set) Token: 0x06000BF9 RID: 3065 RVA: 0x00007EC1 File Offset: 0x000060C1
		public unsafe float minSurfaceRatio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_minSurfaceRatio);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_minSurfaceRatio)) = value;
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000BFA RID: 3066 RVA: 0x00097154 File Offset: 0x00095354
		// (set) Token: 0x06000BFB RID: 3067 RVA: 0x00007EDC File Offset: 0x000060DC
		public unsafe float maxSurfaceDot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_maxSurfaceDot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_maxSurfaceDot)) = value;
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000BFC RID: 3068 RVA: 0x0009717C File Offset: 0x0009537C
		// (set) Token: 0x06000BFD RID: 3069 RVA: 0x00007EF7 File Offset: 0x000060F7
		public unsafe PlaneAlignment planeAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_planeAlignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_planeAlignment)) = value;
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000BFE RID: 3070 RVA: 0x000971A4 File Offset: 0x000953A4
		// (set) Token: 0x06000BFF RID: 3071 RVA: 0x00007F12 File Offset: 0x00006112
		public unsafe float planeOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_planeOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_planeOffset)) = value;
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000C00 RID: 3072 RVA: 0x000971CC File Offset: 0x000953CC
		// (set) Token: 0x06000C01 RID: 3073 RVA: 0x00007F2D File Offset: 0x0000612D
		public unsafe float fadeDistanceToSurface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_fadeDistanceToSurface);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_fadeDistanceToSurface)) = value;
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000C02 RID: 3074 RVA: 0x000971F4 File Offset: 0x000953F4
		// (set) Token: 0x06000C03 RID: 3075 RVA: 0x00007F48 File Offset: 0x00006148
		public DynamicOcclusionRaycasting.HitResult m_CurrentHit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_m_CurrentHit);
				return new DynamicOcclusionRaycasting.HitResult(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_m_CurrentHit), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000C04 RID: 3076 RVA: 0x00097224 File Offset: 0x00095424
		// (set) Token: 0x06000C05 RID: 3077 RVA: 0x00007F76 File Offset: 0x00006176
		public unsafe float m_RangeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_m_RangeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_m_RangeMultiplier)) = value;
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000C06 RID: 3078 RVA: 0x0009724C File Offset: 0x0009544C
		// (set) Token: 0x06000C07 RID: 3079 RVA: 0x00007F91 File Offset: 0x00006191
		public unsafe Plane _planeEquationWS_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr__planeEquationWS_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr__planeEquationWS_k__BackingField)) = value;
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000C08 RID: 3080 RVA: 0x00097274 File Offset: 0x00095474
		// (set) Token: 0x06000C09 RID: 3081 RVA: 0x00007FAC File Offset: 0x000061AC
		public unsafe uint m_PrevNonSubHitDirectionId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_m_PrevNonSubHitDirectionId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_m_PrevNonSubHitDirectionId)) = value;
			}
		}

		// Token: 0x040007EE RID: 2030
		private static readonly IntPtr NativeFieldInfoPtr_ClassName;

		// Token: 0x040007EF RID: 2031
		private static readonly IntPtr NativeFieldInfoPtr_dimensions;

		// Token: 0x040007F0 RID: 2032
		private static readonly IntPtr NativeFieldInfoPtr_layerMask;

		// Token: 0x040007F1 RID: 2033
		private static readonly IntPtr NativeFieldInfoPtr_considerTriggers;

		// Token: 0x040007F2 RID: 2034
		private static readonly IntPtr NativeFieldInfoPtr_minOccluderArea;

		// Token: 0x040007F3 RID: 2035
		private static readonly IntPtr NativeFieldInfoPtr_minSurfaceRatio;

		// Token: 0x040007F4 RID: 2036
		private static readonly IntPtr NativeFieldInfoPtr_maxSurfaceDot;

		// Token: 0x040007F5 RID: 2037
		private static readonly IntPtr NativeFieldInfoPtr_planeAlignment;

		// Token: 0x040007F6 RID: 2038
		private static readonly IntPtr NativeFieldInfoPtr_planeOffset;

		// Token: 0x040007F7 RID: 2039
		private static readonly IntPtr NativeFieldInfoPtr_fadeDistanceToSurface;

		// Token: 0x040007F8 RID: 2040
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentHit;

		// Token: 0x040007F9 RID: 2041
		private static readonly IntPtr NativeFieldInfoPtr_m_RangeMultiplier;

		// Token: 0x040007FA RID: 2042
		private static readonly IntPtr NativeFieldInfoPtr__planeEquationWS_k__BackingField;

		// Token: 0x040007FB RID: 2043
		private static readonly IntPtr NativeFieldInfoPtr_m_PrevNonSubHitDirectionId;

		// Token: 0x040007FC RID: 2044
		private static readonly IntPtr NativeMethodInfoPtr_get_fadeDistanceToPlane_Public_get_Single_0;

		// Token: 0x040007FD RID: 2045
		private static readonly IntPtr NativeMethodInfoPtr_set_fadeDistanceToPlane_Public_set_Void_Single_0;

		// Token: 0x040007FE RID: 2046
		private static readonly IntPtr NativeMethodInfoPtr_IsColliderHiddenByDynamicOccluder_Public_Boolean_Collider_0;

		// Token: 0x040007FF RID: 2047
		private static readonly IntPtr NativeMethodInfoPtr_GetShaderKeyword_Protected_Virtual_String_0;

		// Token: 0x04000800 RID: 2048
		private static readonly IntPtr NativeMethodInfoPtr_GetDynamicOcclusionMode_Protected_Virtual_DynamicOcclusion_0;

		// Token: 0x04000801 RID: 2049
		private static readonly IntPtr NativeMethodInfoPtr_get_planeEquationWS_Public_get_Plane_0;

		// Token: 0x04000802 RID: 2050
		private static readonly IntPtr NativeMethodInfoPtr_set_planeEquationWS_Private_set_Void_Plane_0;

		// Token: 0x04000803 RID: 2051
		private static readonly IntPtr NativeMethodInfoPtr_OnValidateProperties_Protected_Virtual_Void_0;

		// Token: 0x04000804 RID: 2052
		private static readonly IntPtr NativeMethodInfoPtr_OnEnablePostValidate_Protected_Virtual_Void_0;

		// Token: 0x04000805 RID: 2053
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x04000806 RID: 2054
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000807 RID: 2055
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomVectorAround_Private_Vector3_Vector3_Single_0;

		// Token: 0x04000808 RID: 2056
		private static readonly IntPtr NativeMethodInfoPtr_get_queryTriggerInteraction_Private_get_QueryTriggerInteraction_0;

		// Token: 0x04000809 RID: 2057
		private static readonly IntPtr NativeMethodInfoPtr_get_raycastMaxDistance_Private_get_Single_0;

		// Token: 0x0400080A RID: 2058
		private static readonly IntPtr NativeMethodInfoPtr_GetBestHit_Private_HitResult_Vector3_Vector3_0;

		// Token: 0x0400080B RID: 2059
		private static readonly IntPtr NativeMethodInfoPtr_GetBestHit3D_Private_HitResult_Vector3_Vector3_0;

		// Token: 0x0400080C RID: 2060
		private static readonly IntPtr NativeMethodInfoPtr_GetBestHit2D_Private_HitResult_Vector3_Vector3_0;

		// Token: 0x0400080D RID: 2061
		private static readonly IntPtr NativeMethodInfoPtr_GetDirectionCount_Private_UInt32_0;

		// Token: 0x0400080E RID: 2062
		private static readonly IntPtr NativeMethodInfoPtr_GetDirection_Private_Vector3_UInt32_0;

		// Token: 0x0400080F RID: 2063
		private static readonly IntPtr NativeMethodInfoPtr_IsHitValid_Private_Boolean_byref_HitResult_Vector3_0;

		// Token: 0x04000810 RID: 2064
		private static readonly IntPtr NativeMethodInfoPtr_OnProcessOcclusion_Protected_Virtual_Boolean_ProcessOcclusionSource_0;

		// Token: 0x04000811 RID: 2065
		private static readonly IntPtr NativeMethodInfoPtr_SetHit_Private_Void_byref_HitResult_0;

		// Token: 0x04000812 RID: 2066
		private static readonly IntPtr NativeMethodInfoPtr_SetHitNull_Private_Void_0;

		// Token: 0x04000813 RID: 2067
		private static readonly IntPtr NativeMethodInfoPtr_OnModifyMaterialCallback_Protected_Virtual_Void_Interface_0;

		// Token: 0x04000814 RID: 2068
		private static readonly IntPtr NativeMethodInfoPtr_SetClippingPlane_Private_Void_Plane_0;

		// Token: 0x04000815 RID: 2069
		private static readonly IntPtr NativeMethodInfoPtr_SetClippingPlaneOff_Private_Void_0;

		// Token: 0x04000816 RID: 2070
		private static readonly IntPtr NativeMethodInfoPtr_SetPlaneWS_Private_Void_Plane_0;

		// Token: 0x04000817 RID: 2071
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000832 RID: 2098
		public sealed class HitResult : ValueType
		{
			// Token: 0x0600BEF2 RID: 48882 RVA: 0x002ED954 File Offset: 0x002EBB54
			// Note: this type is marked as 'beforefieldinit'.
			static HitResult()
			{
				Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "HitResult");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr);
				DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, "point");
				DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, "normal");
				DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, "distance");
				DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_collider2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, "collider2D");
				DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_collider3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, "collider3D");
				DynamicOcclusionRaycasting.HitResult.NativeMethodInfoPtr__ctor_Public_Void_byref_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, 100664763);
				DynamicOcclusionRaycasting.HitResult.NativeMethodInfoPtr__ctor_Public_Void_byref_RaycastHit2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, 100664764);
				DynamicOcclusionRaycasting.HitResult.NativeMethodInfoPtr_get_hasCollider_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, 100664765);
				DynamicOcclusionRaycasting.HitResult.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, 100664766);
				DynamicOcclusionRaycasting.HitResult.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, 100664767);
				DynamicOcclusionRaycasting.HitResult.NativeMethodInfoPtr_SetNull_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, 100664768);
			}

			// Token: 0x0600BEF3 RID: 48883 RVA: 0x002EDA5C File Offset: 0x002EBC5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83648, XrefRangeEnd = 83654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HitResult(ref RaycastHit hit3D) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = &hit3D;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.HitResult.NativeMethodInfoPtr__ctor_Public_Void_byref_RaycastHit_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BEF4 RID: 48884 RVA: 0x002EDAA8 File Offset: 0x002EBCA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83654, XrefRangeEnd = 83660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HitResult(ref RaycastHit2D hit2D) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = &hit2D;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.HitResult.NativeMethodInfoPtr__ctor_Public_Void_byref_RaycastHit2D_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003B62 RID: 15202
			// (get) Token: 0x0600BEF5 RID: 48885 RVA: 0x002EDAF4 File Offset: 0x002EBCF4
			public unsafe bool hasCollider
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 83664, RefRangeEnd = 83668, XrefRangeStart = 83660, XrefRangeEnd = 83664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.HitResult.NativeMethodInfoPtr_get_hasCollider_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003B63 RID: 15203
			// (get) Token: 0x0600BEF6 RID: 48886 RVA: 0x002EDB38 File Offset: 0x002EBD38
			public unsafe string name
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83668, XrefRangeEnd = 83677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.HitResult.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003B64 RID: 15204
			// (get) Token: 0x0600BEF7 RID: 48887 RVA: 0x002EDB74 File Offset: 0x002EBD74
			public unsafe Bounds bounds
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83677, XrefRangeEnd = 83684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.HitResult.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BEF8 RID: 48888 RVA: 0x002EDBB8 File Offset: 0x002EBDB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83684, XrefRangeEnd = 83686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetNull()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.HitResult.NativeMethodInfoPtr_SetNull_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BEF9 RID: 48889 RVA: 0x0005D57C File Offset: 0x0005B77C
			public HitResult(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600BEFA RID: 48890 RVA: 0x0005D585 File Offset: 0x0005B785
			public HitResult() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr))
			{
			}

			// Token: 0x17003B5D RID: 15197
			// (get) Token: 0x0600BEFB RID: 48891 RVA: 0x002EDBF0 File Offset: 0x002EBDF0
			// (set) Token: 0x0600BEFC RID: 48892 RVA: 0x0005D597 File Offset: 0x0005B797
			public unsafe Vector3 point
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_point);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_point)) = value;
				}
			}

			// Token: 0x17003B5E RID: 15198
			// (get) Token: 0x0600BEFD RID: 48893 RVA: 0x002EDC18 File Offset: 0x002EBE18
			// (set) Token: 0x0600BEFE RID: 48894 RVA: 0x0005D5B2 File Offset: 0x0005B7B2
			public unsafe Vector3 normal
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_normal);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_normal)) = value;
				}
			}

			// Token: 0x17003B5F RID: 15199
			// (get) Token: 0x0600BEFF RID: 48895 RVA: 0x002EDC40 File Offset: 0x002EBE40
			// (set) Token: 0x0600BF00 RID: 48896 RVA: 0x0005D5CD File Offset: 0x0005B7CD
			public unsafe float distance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_distance);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_distance)) = value;
				}
			}

			// Token: 0x17003B60 RID: 15200
			// (get) Token: 0x0600BF01 RID: 48897 RVA: 0x002EDC68 File Offset: 0x002EBE68
			// (set) Token: 0x0600BF02 RID: 48898 RVA: 0x0005D5E8 File Offset: 0x0005B7E8
			public unsafe Collider2D collider2D
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_collider2D);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider2D>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_collider2D), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B61 RID: 15201
			// (get) Token: 0x0600BF03 RID: 48899 RVA: 0x002EDC98 File Offset: 0x002EBE98
			// (set) Token: 0x0600BF04 RID: 48900 RVA: 0x0005D607 File Offset: 0x0005B807
			public unsafe Collider collider3D
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_collider3D);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_collider3D), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008169 RID: 33129
			private static readonly IntPtr NativeFieldInfoPtr_point;

			// Token: 0x0400816A RID: 33130
			private static readonly IntPtr NativeFieldInfoPtr_normal;

			// Token: 0x0400816B RID: 33131
			private static readonly IntPtr NativeFieldInfoPtr_distance;

			// Token: 0x0400816C RID: 33132
			private static readonly IntPtr NativeFieldInfoPtr_collider2D;

			// Token: 0x0400816D RID: 33133
			private static readonly IntPtr NativeFieldInfoPtr_collider3D;

			// Token: 0x0400816E RID: 33134
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_RaycastHit_0;

			// Token: 0x0400816F RID: 33135
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_RaycastHit2D_0;

			// Token: 0x04008170 RID: 33136
			private static readonly IntPtr NativeMethodInfoPtr_get_hasCollider_Public_get_Boolean_0;

			// Token: 0x04008171 RID: 33137
			private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

			// Token: 0x04008172 RID: 33138
			private static readonly IntPtr NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0;

			// Token: 0x04008173 RID: 33139
			private static readonly IntPtr NativeMethodInfoPtr_SetNull_Public_Void_0;
		}

		// Token: 0x02000833 RID: 2099
		[OriginalName("Assembly-CSharp.dll", "", "Direction")]
		public enum Direction
		{
			// Token: 0x04008175 RID: 33141
			Up,
			// Token: 0x04008176 RID: 33142
			Down,
			// Token: 0x04008177 RID: 33143
			Left,
			// Token: 0x04008178 RID: 33144
			Right,
			// Token: 0x04008179 RID: 33145
			Max2D = 1,
			// Token: 0x0400817A RID: 33146
			Max3D = 3
		}
	}
}
