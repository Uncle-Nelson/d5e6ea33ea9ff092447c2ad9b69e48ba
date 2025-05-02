using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRootMotion.FinalIK;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Animation
{
	// Token: 0x0200060C RID: 1548
	public class AvatarIKController : MonoBehaviour
	{
		// Token: 0x060088DF RID: 35039 RVA: 0x0023FFFC File Offset: 0x0023E1FC
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarIKController()
		{
			Il2CppClassPointerStore<AvatarIKController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Animation", "AvatarIKController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarIKController>.NativeClassPtr);
			AvatarIKController.NativeFieldInfoPtr_BodyIK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarIKController>.NativeClassPtr, "BodyIK");
			AvatarIKController.NativeFieldInfoPtr_defaultLeftLegBendTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarIKController>.NativeClassPtr, "defaultLeftLegBendTarget");
			AvatarIKController.NativeFieldInfoPtr_defaultRightLegBendTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarIKController>.NativeClassPtr, "defaultRightLegBendTarget");
			AvatarIKController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarIKController>.NativeClassPtr, 100680356);
			AvatarIKController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarIKController>.NativeClassPtr, 100680357);
			AvatarIKController.NativeMethodInfoPtr_SetIKActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarIKController>.NativeClassPtr, 100680358);
			AvatarIKController.NativeMethodInfoPtr_OverrideLegBendTargets_Public_Void_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarIKController>.NativeClassPtr, 100680359);
			AvatarIKController.NativeMethodInfoPtr_ResetLegBendTargets_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarIKController>.NativeClassPtr, 100680360);
			AvatarIKController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarIKController>.NativeClassPtr, 100680361);
		}

		// Token: 0x060088E0 RID: 35040 RVA: 0x002400E0 File Offset: 0x0023E2E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253175, XrefRangeEnd = 253179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarIKController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088E1 RID: 35041 RVA: 0x00240114 File Offset: 0x0023E314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253179, XrefRangeEnd = 253181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarIKController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088E2 RID: 35042 RVA: 0x00240148 File Offset: 0x0023E348
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 253183, RefRangeEnd = 253185, XrefRangeStart = 253181, XrefRangeEnd = 253183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIKActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarIKController.NativeMethodInfoPtr_SetIKActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088E3 RID: 35043 RVA: 0x00240188 File Offset: 0x0023E388
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 253188, RefRangeEnd = 253189, XrefRangeStart = 253185, XrefRangeEnd = 253188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideLegBendTargets(Transform leftLegTarget, Transform rightLegTarget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(leftLegTarget);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rightLegTarget);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarIKController.NativeMethodInfoPtr_OverrideLegBendTargets_Public_Void_Transform_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088E4 RID: 35044 RVA: 0x002401DC File Offset: 0x0023E3DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 253192, RefRangeEnd = 253193, XrefRangeStart = 253189, XrefRangeEnd = 253192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetLegBendTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarIKController.NativeMethodInfoPtr_ResetLegBendTargets_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088E5 RID: 35045 RVA: 0x00240210 File Offset: 0x0023E410
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarIKController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarIKController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarIKController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088E6 RID: 35046 RVA: 0x000414F0 File Offset: 0x0003F6F0
		public AvatarIKController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170029B4 RID: 10676
		// (get) Token: 0x060088E7 RID: 35047 RVA: 0x0024024C File Offset: 0x0023E44C
		// (set) Token: 0x060088E8 RID: 35048 RVA: 0x000414F9 File Offset: 0x0003F6F9
		public unsafe BipedIK BodyIK
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarIKController.NativeFieldInfoPtr_BodyIK);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BipedIK>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarIKController.NativeFieldInfoPtr_BodyIK), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029B5 RID: 10677
		// (get) Token: 0x060088E9 RID: 35049 RVA: 0x0024027C File Offset: 0x0023E47C
		// (set) Token: 0x060088EA RID: 35050 RVA: 0x00041518 File Offset: 0x0003F718
		public unsafe Transform defaultLeftLegBendTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarIKController.NativeFieldInfoPtr_defaultLeftLegBendTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarIKController.NativeFieldInfoPtr_defaultLeftLegBendTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029B6 RID: 10678
		// (get) Token: 0x060088EB RID: 35051 RVA: 0x002402AC File Offset: 0x0023E4AC
		// (set) Token: 0x060088EC RID: 35052 RVA: 0x00041537 File Offset: 0x0003F737
		public unsafe Transform defaultRightLegBendTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarIKController.NativeFieldInfoPtr_defaultRightLegBendTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarIKController.NativeFieldInfoPtr_defaultRightLegBendTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005CFD RID: 23805
		private static readonly IntPtr NativeFieldInfoPtr_BodyIK;

		// Token: 0x04005CFE RID: 23806
		private static readonly IntPtr NativeFieldInfoPtr_defaultLeftLegBendTarget;

		// Token: 0x04005CFF RID: 23807
		private static readonly IntPtr NativeFieldInfoPtr_defaultRightLegBendTarget;

		// Token: 0x04005D00 RID: 23808
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005D01 RID: 23809
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04005D02 RID: 23810
		private static readonly IntPtr NativeMethodInfoPtr_SetIKActive_Public_Void_Boolean_0;

		// Token: 0x04005D03 RID: 23811
		private static readonly IntPtr NativeMethodInfoPtr_OverrideLegBendTargets_Public_Void_Transform_Transform_0;

		// Token: 0x04005D04 RID: 23812
		private static readonly IntPtr NativeMethodInfoPtr_ResetLegBendTargets_Public_Void_0;

		// Token: 0x04005D05 RID: 23813
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
