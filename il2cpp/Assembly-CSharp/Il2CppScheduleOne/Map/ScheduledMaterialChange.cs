using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x02000786 RID: 1926
	public class ScheduledMaterialChange : MonoBehaviour
	{
		// Token: 0x0600B656 RID: 46678 RVA: 0x002D49DC File Offset: 0x002D2BDC
		// Note: this type is marked as 'beforefieldinit'.
		static ScheduledMaterialChange()
		{
			Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "ScheduledMaterialChange");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr);
			ScheduledMaterialChange.NativeFieldInfoPtr_Renderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "Renderers");
			ScheduledMaterialChange.NativeFieldInfoPtr_MaterialIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "MaterialIndex");
			ScheduledMaterialChange.NativeFieldInfoPtr_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "Enabled");
			ScheduledMaterialChange.NativeFieldInfoPtr_OutsideTimeRangeMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "OutsideTimeRangeMaterial");
			ScheduledMaterialChange.NativeFieldInfoPtr_InsideTimeRangeMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "InsideTimeRangeMaterial");
			ScheduledMaterialChange.NativeFieldInfoPtr_TimeRangeMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "TimeRangeMin");
			ScheduledMaterialChange.NativeFieldInfoPtr_TimeRangeMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "TimeRangeMax");
			ScheduledMaterialChange.NativeFieldInfoPtr_TimeRangeShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "TimeRangeShift");
			ScheduledMaterialChange.NativeFieldInfoPtr_TimeRangeRandomization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "TimeRangeRandomization");
			ScheduledMaterialChange.NativeFieldInfoPtr_TurnOnChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "TurnOnChance");
			ScheduledMaterialChange.NativeFieldInfoPtr_appliedInsideTimeRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "appliedInsideTimeRange");
			ScheduledMaterialChange.NativeFieldInfoPtr_onState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "onState");
			ScheduledMaterialChange.NativeFieldInfoPtr_randomShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "randomShift");
			ScheduledMaterialChange.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, 100685718);
			ScheduledMaterialChange.NativeMethodInfoPtr_Tick_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, 100685719);
			ScheduledMaterialChange.NativeMethodInfoPtr_SetMaterial_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, 100685720);
			ScheduledMaterialChange.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, 100685721);
		}

		// Token: 0x0600B657 RID: 46679 RVA: 0x002D4B60 File Offset: 0x002D2D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311422, XrefRangeEnd = 311440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScheduledMaterialChange.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B658 RID: 46680 RVA: 0x002D4B9C File Offset: 0x002D2D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311440, XrefRangeEnd = 311455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Tick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScheduledMaterialChange.NativeMethodInfoPtr_Tick_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B659 RID: 46681 RVA: 0x002D4BD8 File Offset: 0x002D2DD8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 311462, RefRangeEnd = 311465, XrefRangeStart = 311455, XrefRangeEnd = 311462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaterial(bool insideTimeRange)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref insideTimeRange;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScheduledMaterialChange.NativeMethodInfoPtr_SetMaterial_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B65A RID: 46682 RVA: 0x002D4C18 File Offset: 0x002D2E18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311465, XrefRangeEnd = 311466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScheduledMaterialChange() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScheduledMaterialChange.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B65B RID: 46683 RVA: 0x00059830 File Offset: 0x00057A30
		public ScheduledMaterialChange(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003888 RID: 14472
		// (get) Token: 0x0600B65C RID: 46684 RVA: 0x002D4C54 File Offset: 0x002D2E54
		// (set) Token: 0x0600B65D RID: 46685 RVA: 0x00059839 File Offset: 0x00057A39
		public unsafe Il2CppReferenceArray<MeshRenderer> Renderers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_Renderers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_Renderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003889 RID: 14473
		// (get) Token: 0x0600B65E RID: 46686 RVA: 0x002D4C84 File Offset: 0x002D2E84
		// (set) Token: 0x0600B65F RID: 46687 RVA: 0x00059858 File Offset: 0x00057A58
		public unsafe int MaterialIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_MaterialIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_MaterialIndex)) = value;
			}
		}

		// Token: 0x1700388A RID: 14474
		// (get) Token: 0x0600B660 RID: 46688 RVA: 0x002D4CAC File Offset: 0x002D2EAC
		// (set) Token: 0x0600B661 RID: 46689 RVA: 0x00059873 File Offset: 0x00057A73
		public unsafe bool Enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_Enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_Enabled)) = value;
			}
		}

		// Token: 0x1700388B RID: 14475
		// (get) Token: 0x0600B662 RID: 46690 RVA: 0x002D4CD4 File Offset: 0x002D2ED4
		// (set) Token: 0x0600B663 RID: 46691 RVA: 0x0005988E File Offset: 0x00057A8E
		public unsafe Material OutsideTimeRangeMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_OutsideTimeRangeMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_OutsideTimeRangeMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700388C RID: 14476
		// (get) Token: 0x0600B664 RID: 46692 RVA: 0x002D4D04 File Offset: 0x002D2F04
		// (set) Token: 0x0600B665 RID: 46693 RVA: 0x000598AD File Offset: 0x00057AAD
		public unsafe Material InsideTimeRangeMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_InsideTimeRangeMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_InsideTimeRangeMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700388D RID: 14477
		// (get) Token: 0x0600B666 RID: 46694 RVA: 0x002D4D34 File Offset: 0x002D2F34
		// (set) Token: 0x0600B667 RID: 46695 RVA: 0x000598CC File Offset: 0x00057ACC
		public unsafe int TimeRangeMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_TimeRangeMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_TimeRangeMin)) = value;
			}
		}

		// Token: 0x1700388E RID: 14478
		// (get) Token: 0x0600B668 RID: 46696 RVA: 0x002D4D5C File Offset: 0x002D2F5C
		// (set) Token: 0x0600B669 RID: 46697 RVA: 0x000598E7 File Offset: 0x00057AE7
		public unsafe int TimeRangeMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_TimeRangeMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_TimeRangeMax)) = value;
			}
		}

		// Token: 0x1700388F RID: 14479
		// (get) Token: 0x0600B66A RID: 46698 RVA: 0x002D4D84 File Offset: 0x002D2F84
		// (set) Token: 0x0600B66B RID: 46699 RVA: 0x00059902 File Offset: 0x00057B02
		public unsafe int TimeRangeShift
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_TimeRangeShift);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_TimeRangeShift)) = value;
			}
		}

		// Token: 0x17003890 RID: 14480
		// (get) Token: 0x0600B66C RID: 46700 RVA: 0x002D4DAC File Offset: 0x002D2FAC
		// (set) Token: 0x0600B66D RID: 46701 RVA: 0x0005991D File Offset: 0x00057B1D
		public unsafe int TimeRangeRandomization
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_TimeRangeRandomization);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_TimeRangeRandomization)) = value;
			}
		}

		// Token: 0x17003891 RID: 14481
		// (get) Token: 0x0600B66E RID: 46702 RVA: 0x002D4DD4 File Offset: 0x002D2FD4
		// (set) Token: 0x0600B66F RID: 46703 RVA: 0x00059938 File Offset: 0x00057B38
		public unsafe float TurnOnChance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_TurnOnChance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_TurnOnChance)) = value;
			}
		}

		// Token: 0x17003892 RID: 14482
		// (get) Token: 0x0600B670 RID: 46704 RVA: 0x002D4DFC File Offset: 0x002D2FFC
		// (set) Token: 0x0600B671 RID: 46705 RVA: 0x00059953 File Offset: 0x00057B53
		public unsafe bool appliedInsideTimeRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_appliedInsideTimeRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_appliedInsideTimeRange)) = value;
			}
		}

		// Token: 0x17003893 RID: 14483
		// (get) Token: 0x0600B672 RID: 46706 RVA: 0x002D4E24 File Offset: 0x002D3024
		// (set) Token: 0x0600B673 RID: 46707 RVA: 0x0005996E File Offset: 0x00057B6E
		public unsafe ScheduledMaterialChange.EOnState onState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_onState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_onState)) = value;
			}
		}

		// Token: 0x17003894 RID: 14484
		// (get) Token: 0x0600B674 RID: 46708 RVA: 0x002D4E4C File Offset: 0x002D304C
		// (set) Token: 0x0600B675 RID: 46709 RVA: 0x00059989 File Offset: 0x00057B89
		public unsafe int randomShift
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_randomShift);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_randomShift)) = value;
			}
		}

		// Token: 0x04007AD8 RID: 31448
		private static readonly IntPtr NativeFieldInfoPtr_Renderers;

		// Token: 0x04007AD9 RID: 31449
		private static readonly IntPtr NativeFieldInfoPtr_MaterialIndex;

		// Token: 0x04007ADA RID: 31450
		private static readonly IntPtr NativeFieldInfoPtr_Enabled;

		// Token: 0x04007ADB RID: 31451
		private static readonly IntPtr NativeFieldInfoPtr_OutsideTimeRangeMaterial;

		// Token: 0x04007ADC RID: 31452
		private static readonly IntPtr NativeFieldInfoPtr_InsideTimeRangeMaterial;

		// Token: 0x04007ADD RID: 31453
		private static readonly IntPtr NativeFieldInfoPtr_TimeRangeMin;

		// Token: 0x04007ADE RID: 31454
		private static readonly IntPtr NativeFieldInfoPtr_TimeRangeMax;

		// Token: 0x04007ADF RID: 31455
		private static readonly IntPtr NativeFieldInfoPtr_TimeRangeShift;

		// Token: 0x04007AE0 RID: 31456
		private static readonly IntPtr NativeFieldInfoPtr_TimeRangeRandomization;

		// Token: 0x04007AE1 RID: 31457
		private static readonly IntPtr NativeFieldInfoPtr_TurnOnChance;

		// Token: 0x04007AE2 RID: 31458
		private static readonly IntPtr NativeFieldInfoPtr_appliedInsideTimeRange;

		// Token: 0x04007AE3 RID: 31459
		private static readonly IntPtr NativeFieldInfoPtr_onState;

		// Token: 0x04007AE4 RID: 31460
		private static readonly IntPtr NativeFieldInfoPtr_randomShift;

		// Token: 0x04007AE5 RID: 31461
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04007AE6 RID: 31462
		private static readonly IntPtr NativeMethodInfoPtr_Tick_Protected_Virtual_New_Void_0;

		// Token: 0x04007AE7 RID: 31463
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterial_Private_Void_Boolean_0;

		// Token: 0x04007AE8 RID: 31464
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C06 RID: 3078
		[OriginalName("Assembly-CSharp.dll", "", "EOnState")]
		public enum EOnState
		{
			// Token: 0x04009628 RID: 38440
			Undecided,
			// Token: 0x04009629 RID: 38441
			On,
			// Token: 0x0400962A RID: 38442
			Off
		}
	}
}
