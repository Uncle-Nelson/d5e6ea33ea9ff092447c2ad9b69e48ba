using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x020000B8 RID: 184
	public class VolumetricLightBeamAbstractBase : MonoBehaviour
	{
		// Token: 0x06000DDB RID: 3547 RVA: 0x0009D244 File Offset: 0x0009B444
		// Note: this type is marked as 'beforefieldinit'.
		static VolumetricLightBeamAbstractBase()
		{
			Il2CppClassPointerStore<VolumetricLightBeamAbstractBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "VolumetricLightBeamAbstractBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumetricLightBeamAbstractBase>.NativeClassPtr);
			VolumetricLightBeamAbstractBase.NativeFieldInfoPtr_ClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamAbstractBase>.NativeClassPtr, "ClassName");
			VolumetricLightBeamAbstractBase.NativeFieldInfoPtr_pluginVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamAbstractBase>.NativeClassPtr, "pluginVersion");
			VolumetricLightBeamAbstractBase.NativeFieldInfoPtr_m_CachedLightSpot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamAbstractBase>.NativeClassPtr, "m_CachedLightSpot");
			VolumetricLightBeamAbstractBase.NativeMethodInfoPtr_GetBeamGeometry_Public_Abstract_Virtual_New_BeamGeometryAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamAbstractBase>.NativeClassPtr, 100665002);
			VolumetricLightBeamAbstractBase.NativeMethodInfoPtr_SetBeamGeometryNull_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamAbstractBase>.NativeClassPtr, 100665003);
			VolumetricLightBeamAbstractBase.NativeMethodInfoPtr_get_hasGeometry_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamAbstractBase>.NativeClassPtr, 100665004);
			VolumetricLightBeamAbstractBase.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamAbstractBase>.NativeClassPtr, 100665005);
			VolumetricLightBeamAbstractBase.NativeMethodInfoPtr_IsScalable_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamAbstractBase>.NativeClassPtr, 100665006);
			VolumetricLightBeamAbstractBase.NativeMethodInfoPtr_GetLossyScale_Public_Abstract_Virtual_New_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamAbstractBase>.NativeClassPtr, 100665007);
			VolumetricLightBeamAbstractBase.NativeMethodInfoPtr_get__INTERNAL_pluginVersion_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamAbstractBase>.NativeClassPtr, 100665008);
			VolumetricLightBeamAbstractBase.NativeMethodInfoPtr_GetLightSpotAttachedSlow_Public_Light_byref_AttachedLightType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamAbstractBase>.NativeClassPtr, 100665009);
			VolumetricLightBeamAbstractBase.NativeMethodInfoPtr_get_lightSpotAttached_Public_get_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamAbstractBase>.NativeClassPtr, 100665010);
			VolumetricLightBeamAbstractBase.NativeMethodInfoPtr_InitLightSpotAttachedCached_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamAbstractBase>.NativeClassPtr, 100665011);
			VolumetricLightBeamAbstractBase.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamAbstractBase>.NativeClassPtr, 100665012);
			VolumetricLightBeamAbstractBase.NativeMethodInfoPtr_DestroyBeam_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamAbstractBase>.NativeClassPtr, 100665013);
			VolumetricLightBeamAbstractBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamAbstractBase>.NativeClassPtr, 100665014);
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x0009D3B4 File Offset: 0x0009B5B4
		[CallerCount(0)]
		public unsafe virtual BeamGeometryAbstractBase GetBeamGeometry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumetricLightBeamAbstractBase.NativeMethodInfoPtr_GetBeamGeometry_Public_Abstract_Virtual_New_BeamGeometryAbstractBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BeamGeometryAbstractBase>(intPtr3) : null;
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x0009D400 File Offset: 0x0009B600
		[CallerCount(0)]
		public unsafe virtual void SetBeamGeometryNull()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumetricLightBeamAbstractBase.NativeMethodInfoPtr_SetBeamGeometryNull_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06000DDE RID: 3550 RVA: 0x0009D43C File Offset: 0x0009B63C
		public unsafe bool hasGeometry
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 85443, RefRangeEnd = 85444, XrefRangeStart = 85431, XrefRangeEnd = 85443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamAbstractBase.NativeMethodInfoPtr_get_hasGeometry_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06000DDF RID: 3551 RVA: 0x0009D478 File Offset: 0x0009B678
		public unsafe Bounds bounds
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 85449, RefRangeEnd = 85450, XrefRangeStart = 85444, XrefRangeEnd = 85449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamAbstractBase.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x0009D4B4 File Offset: 0x0009B6B4
		[CallerCount(0)]
		public unsafe virtual bool IsScalable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumetricLightBeamAbstractBase.NativeMethodInfoPtr_IsScalable_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x0009D4FC File Offset: 0x0009B6FC
		[CallerCount(0)]
		public unsafe virtual Vector3 GetLossyScale()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumetricLightBeamAbstractBase.NativeMethodInfoPtr_GetLossyScale_Public_Abstract_Virtual_New_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06000DE2 RID: 3554 RVA: 0x0009D544 File Offset: 0x0009B744
		public unsafe int _INTERNAL_pluginVersion
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20564, RefRangeEnd = 20565, XrefRangeStart = 20564, XrefRangeEnd = 20565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamAbstractBase.NativeMethodInfoPtr_get__INTERNAL_pluginVersion_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x0009D580 File Offset: 0x0009B780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85450, XrefRangeEnd = 85457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Light GetLightSpotAttachedSlow(out VolumetricLightBeamAbstractBase.AttachedLightType lightType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &lightType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamAbstractBase.NativeMethodInfoPtr_GetLightSpotAttachedSlow_Public_Light_byref_AttachedLightType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Light>(intPtr3) : null;
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06000DE4 RID: 3556 RVA: 0x0009D5CC File Offset: 0x0009B7CC
		public unsafe Light lightSpotAttached
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19637, RefRangeEnd = 19640, XrefRangeStart = 19637, XrefRangeEnd = 19640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamAbstractBase.NativeMethodInfoPtr_get_lightSpotAttached_Public_get_Light_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Light>(intPtr3) : null;
			}
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x0009D60C File Offset: 0x0009B80C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 85468, RefRangeEnd = 85470, XrefRangeStart = 85457, XrefRangeEnd = 85468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitLightSpotAttachedCached()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamAbstractBase.NativeMethodInfoPtr_InitLightSpotAttachedCached_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x0009D640 File Offset: 0x0009B840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85470, XrefRangeEnd = 85475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamAbstractBase.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x0009D674 File Offset: 0x0009B874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyBeam()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamAbstractBase.NativeMethodInfoPtr_DestroyBeam_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x0009D6A8 File Offset: 0x0009B8A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 85476, RefRangeEnd = 85479, XrefRangeStart = 85475, XrefRangeEnd = 85476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumetricLightBeamAbstractBase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumetricLightBeamAbstractBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamAbstractBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x00008B42 File Offset: 0x00006D42
		public VolumetricLightBeamAbstractBase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06000DEA RID: 3562 RVA: 0x0009D6E4 File Offset: 0x0009B8E4
		// (set) Token: 0x06000DEB RID: 3563 RVA: 0x00008B4B File Offset: 0x00006D4B
		public unsafe static string ClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VolumetricLightBeamAbstractBase.NativeFieldInfoPtr_ClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VolumetricLightBeamAbstractBase.NativeFieldInfoPtr_ClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06000DEC RID: 3564 RVA: 0x0009D704 File Offset: 0x0009B904
		// (set) Token: 0x06000DED RID: 3565 RVA: 0x00008B5D File Offset: 0x00006D5D
		public unsafe int pluginVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamAbstractBase.NativeFieldInfoPtr_pluginVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamAbstractBase.NativeFieldInfoPtr_pluginVersion)) = value;
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06000DEE RID: 3566 RVA: 0x0009D72C File Offset: 0x0009B92C
		// (set) Token: 0x06000DEF RID: 3567 RVA: 0x00008B78 File Offset: 0x00006D78
		public unsafe Light m_CachedLightSpot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamAbstractBase.NativeFieldInfoPtr_m_CachedLightSpot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamAbstractBase.NativeFieldInfoPtr_m_CachedLightSpot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400095A RID: 2394
		private static readonly IntPtr NativeFieldInfoPtr_ClassName;

		// Token: 0x0400095B RID: 2395
		private static readonly IntPtr NativeFieldInfoPtr_pluginVersion;

		// Token: 0x0400095C RID: 2396
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedLightSpot;

		// Token: 0x0400095D RID: 2397
		private static readonly IntPtr NativeMethodInfoPtr_GetBeamGeometry_Public_Abstract_Virtual_New_BeamGeometryAbstractBase_0;

		// Token: 0x0400095E RID: 2398
		private static readonly IntPtr NativeMethodInfoPtr_SetBeamGeometryNull_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x0400095F RID: 2399
		private static readonly IntPtr NativeMethodInfoPtr_get_hasGeometry_Public_get_Boolean_0;

		// Token: 0x04000960 RID: 2400
		private static readonly IntPtr NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0;

		// Token: 0x04000961 RID: 2401
		private static readonly IntPtr NativeMethodInfoPtr_IsScalable_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04000962 RID: 2402
		private static readonly IntPtr NativeMethodInfoPtr_GetLossyScale_Public_Abstract_Virtual_New_Vector3_0;

		// Token: 0x04000963 RID: 2403
		private static readonly IntPtr NativeMethodInfoPtr_get__INTERNAL_pluginVersion_Public_get_Int32_0;

		// Token: 0x04000964 RID: 2404
		private static readonly IntPtr NativeMethodInfoPtr_GetLightSpotAttachedSlow_Public_Light_byref_AttachedLightType_0;

		// Token: 0x04000965 RID: 2405
		private static readonly IntPtr NativeMethodInfoPtr_get_lightSpotAttached_Public_get_Light_0;

		// Token: 0x04000966 RID: 2406
		private static readonly IntPtr NativeMethodInfoPtr_InitLightSpotAttachedCached_Protected_Void_0;

		// Token: 0x04000967 RID: 2407
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000968 RID: 2408
		private static readonly IntPtr NativeMethodInfoPtr_DestroyBeam_Protected_Void_0;

		// Token: 0x04000969 RID: 2409
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000846 RID: 2118
		[OriginalName("Assembly-CSharp.dll", "", "AttachedLightType")]
		public enum AttachedLightType
		{
			// Token: 0x040081DA RID: 33242
			NoLight,
			// Token: 0x040081DB RID: 33243
			OtherLight,
			// Token: 0x040081DC RID: 33244
			SpotLight
		}
	}
}
