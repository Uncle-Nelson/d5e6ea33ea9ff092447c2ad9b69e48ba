using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerTasks;
using UnityEngine;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x02000590 RID: 1424
	public class PourableAngleLimit : MonoBehaviour
	{
		// Token: 0x06007D35 RID: 32053 RVA: 0x00219314 File Offset: 0x00217514
		// Note: this type is marked as 'beforefieldinit'.
		static PourableAngleLimit()
		{
			Il2CppClassPointerStore<PourableAngleLimit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "PourableAngleLimit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PourableAngleLimit>.NativeClassPtr);
			PourableAngleLimit.NativeFieldInfoPtr_Pourable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableAngleLimit>.NativeClassPtr, "Pourable");
			PourableAngleLimit.NativeFieldInfoPtr_Constraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableAngleLimit>.NativeClassPtr, "Constraint");
			PourableAngleLimit.NativeFieldInfoPtr_AngleAtMaxFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableAngleLimit>.NativeClassPtr, "AngleAtMaxFill");
			PourableAngleLimit.NativeFieldInfoPtr_AngleAtMinFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableAngleLimit>.NativeClassPtr, "AngleAtMinFill");
			PourableAngleLimit.NativeFieldInfoPtr_PourAngleMaxFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableAngleLimit>.NativeClassPtr, "PourAngleMaxFill");
			PourableAngleLimit.NativeFieldInfoPtr_PourAngleMinFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableAngleLimit>.NativeClassPtr, "PourAngleMinFill");
			PourableAngleLimit.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableAngleLimit>.NativeClassPtr, 100678971);
			PourableAngleLimit.NativeMethodInfoPtr_FixedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableAngleLimit>.NativeClassPtr, 100678972);
			PourableAngleLimit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableAngleLimit>.NativeClassPtr, 100678973);
		}

		// Token: 0x06007D36 RID: 32054 RVA: 0x002193F8 File Offset: 0x002175F8
		[CallerCount(0)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableAngleLimit.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D37 RID: 32055 RVA: 0x0021942C File Offset: 0x0021762C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237932, XrefRangeEnd = 237934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableAngleLimit.NativeMethodInfoPtr_FixedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D38 RID: 32056 RVA: 0x00219460 File Offset: 0x00217660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237934, XrefRangeEnd = 237935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PourableAngleLimit() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PourableAngleLimit>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableAngleLimit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D39 RID: 32057 RVA: 0x0003B76F File Offset: 0x0003996F
		public PourableAngleLimit(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170025DF RID: 9695
		// (get) Token: 0x06007D3A RID: 32058 RVA: 0x0021949C File Offset: 0x0021769C
		// (set) Token: 0x06007D3B RID: 32059 RVA: 0x0003B778 File Offset: 0x00039978
		public unsafe PourableModule Pourable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAngleLimit.NativeFieldInfoPtr_Pourable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PourableModule>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAngleLimit.NativeFieldInfoPtr_Pourable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025E0 RID: 9696
		// (get) Token: 0x06007D3C RID: 32060 RVA: 0x002194CC File Offset: 0x002176CC
		// (set) Token: 0x06007D3D RID: 32061 RVA: 0x0003B797 File Offset: 0x00039997
		public unsafe DraggableConstraint Constraint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAngleLimit.NativeFieldInfoPtr_Constraint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DraggableConstraint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAngleLimit.NativeFieldInfoPtr_Constraint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025E1 RID: 9697
		// (get) Token: 0x06007D3E RID: 32062 RVA: 0x002194FC File Offset: 0x002176FC
		// (set) Token: 0x06007D3F RID: 32063 RVA: 0x0003B7B6 File Offset: 0x000399B6
		public unsafe float AngleAtMaxFill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAngleLimit.NativeFieldInfoPtr_AngleAtMaxFill);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAngleLimit.NativeFieldInfoPtr_AngleAtMaxFill)) = value;
			}
		}

		// Token: 0x170025E2 RID: 9698
		// (get) Token: 0x06007D40 RID: 32064 RVA: 0x00219524 File Offset: 0x00217724
		// (set) Token: 0x06007D41 RID: 32065 RVA: 0x0003B7D1 File Offset: 0x000399D1
		public unsafe float AngleAtMinFill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAngleLimit.NativeFieldInfoPtr_AngleAtMinFill);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAngleLimit.NativeFieldInfoPtr_AngleAtMinFill)) = value;
			}
		}

		// Token: 0x170025E3 RID: 9699
		// (get) Token: 0x06007D42 RID: 32066 RVA: 0x0021954C File Offset: 0x0021774C
		// (set) Token: 0x06007D43 RID: 32067 RVA: 0x0003B7EC File Offset: 0x000399EC
		public unsafe float PourAngleMaxFill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAngleLimit.NativeFieldInfoPtr_PourAngleMaxFill);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAngleLimit.NativeFieldInfoPtr_PourAngleMaxFill)) = value;
			}
		}

		// Token: 0x170025E4 RID: 9700
		// (get) Token: 0x06007D44 RID: 32068 RVA: 0x00219574 File Offset: 0x00217774
		// (set) Token: 0x06007D45 RID: 32069 RVA: 0x0003B807 File Offset: 0x00039A07
		public unsafe float PourAngleMinFill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAngleLimit.NativeFieldInfoPtr_PourAngleMinFill);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAngleLimit.NativeFieldInfoPtr_PourAngleMinFill)) = value;
			}
		}

		// Token: 0x04005532 RID: 21810
		private static readonly IntPtr NativeFieldInfoPtr_Pourable;

		// Token: 0x04005533 RID: 21811
		private static readonly IntPtr NativeFieldInfoPtr_Constraint;

		// Token: 0x04005534 RID: 21812
		private static readonly IntPtr NativeFieldInfoPtr_AngleAtMaxFill;

		// Token: 0x04005535 RID: 21813
		private static readonly IntPtr NativeFieldInfoPtr_AngleAtMinFill;

		// Token: 0x04005536 RID: 21814
		private static readonly IntPtr NativeFieldInfoPtr_PourAngleMaxFill;

		// Token: 0x04005537 RID: 21815
		private static readonly IntPtr NativeFieldInfoPtr_PourAngleMinFill;

		// Token: 0x04005538 RID: 21816
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005539 RID: 21817
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Public_Void_0;

		// Token: 0x0400553A RID: 21818
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
