using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000625 RID: 1573
	public class BalanceDisplay : MonoBehaviour
	{
		// Token: 0x06008A99 RID: 35481 RVA: 0x002451C4 File Offset: 0x002433C4
		// Note: this type is marked as 'beforefieldinit'.
		static BalanceDisplay()
		{
			Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "BalanceDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr);
			BalanceDisplay.NativeFieldInfoPtr_RESIDUAL_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr, "RESIDUAL_TIME");
			BalanceDisplay.NativeFieldInfoPtr_FADE_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr, "FADE_TIME");
			BalanceDisplay.NativeFieldInfoPtr_Group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr, "Group");
			BalanceDisplay.NativeFieldInfoPtr_BalanceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr, "BalanceLabel");
			BalanceDisplay.NativeFieldInfoPtr__active_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr, "<active>k__BackingField");
			BalanceDisplay.NativeFieldInfoPtr__timeSinceActiveSet_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr, "<timeSinceActiveSet>k__BackingField");
			BalanceDisplay.NativeMethodInfoPtr_get_active_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr, 100680517);
			BalanceDisplay.NativeMethodInfoPtr_set_active_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr, 100680518);
			BalanceDisplay.NativeMethodInfoPtr_get_timeSinceActiveSet_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr, 100680519);
			BalanceDisplay.NativeMethodInfoPtr_set_timeSinceActiveSet_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr, 100680520);
			BalanceDisplay.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr, 100680521);
			BalanceDisplay.NativeMethodInfoPtr_SetBalance_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr, 100680522);
			BalanceDisplay.NativeMethodInfoPtr_Show_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr, 100680523);
			BalanceDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr, 100680524);
		}

		// Token: 0x17002A3E RID: 10814
		// (get) Token: 0x06008A9A RID: 35482 RVA: 0x0024530C File Offset: 0x0024350C
		// (set) Token: 0x06008A9B RID: 35483 RVA: 0x00245348 File Offset: 0x00243548
		public unsafe bool active
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BalanceDisplay.NativeMethodInfoPtr_get_active_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BalanceDisplay.NativeMethodInfoPtr_set_active_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002A3F RID: 10815
		// (get) Token: 0x06008A9C RID: 35484 RVA: 0x00245388 File Offset: 0x00243588
		// (set) Token: 0x06008A9D RID: 35485 RVA: 0x002453C4 File Offset: 0x002435C4
		public unsafe float timeSinceActiveSet
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BalanceDisplay.NativeMethodInfoPtr_get_timeSinceActiveSet_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BalanceDisplay.NativeMethodInfoPtr_set_timeSinceActiveSet_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008A9E RID: 35486 RVA: 0x00245404 File Offset: 0x00243604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254540, XrefRangeEnd = 254550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BalanceDisplay.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A9F RID: 35487 RVA: 0x00245440 File Offset: 0x00243640
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 254552, RefRangeEnd = 254558, XrefRangeStart = 254550, XrefRangeEnd = 254552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBalance(float balance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref balance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BalanceDisplay.NativeMethodInfoPtr_SetBalance_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008AA0 RID: 35488 RVA: 0x00245480 File Offset: 0x00243680
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 254558, RefRangeEnd = 254562, XrefRangeStart = 254558, XrefRangeEnd = 254558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Show()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BalanceDisplay.NativeMethodInfoPtr_Show_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008AA1 RID: 35489 RVA: 0x002454B4 File Offset: 0x002436B4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BalanceDisplay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BalanceDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008AA2 RID: 35490 RVA: 0x00042496 File Offset: 0x00040696
		public BalanceDisplay(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A38 RID: 10808
		// (get) Token: 0x06008AA3 RID: 35491 RVA: 0x002454F0 File Offset: 0x002436F0
		// (set) Token: 0x06008AA4 RID: 35492 RVA: 0x0004249F File Offset: 0x0004069F
		public unsafe static float RESIDUAL_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BalanceDisplay.NativeFieldInfoPtr_RESIDUAL_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BalanceDisplay.NativeFieldInfoPtr_RESIDUAL_TIME, (void*)(&value));
			}
		}

		// Token: 0x17002A39 RID: 10809
		// (get) Token: 0x06008AA5 RID: 35493 RVA: 0x0024550C File Offset: 0x0024370C
		// (set) Token: 0x06008AA6 RID: 35494 RVA: 0x000424AD File Offset: 0x000406AD
		public unsafe static float FADE_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BalanceDisplay.NativeFieldInfoPtr_FADE_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BalanceDisplay.NativeFieldInfoPtr_FADE_TIME, (void*)(&value));
			}
		}

		// Token: 0x17002A3A RID: 10810
		// (get) Token: 0x06008AA7 RID: 35495 RVA: 0x00245528 File Offset: 0x00243728
		// (set) Token: 0x06008AA8 RID: 35496 RVA: 0x000424BB File Offset: 0x000406BB
		public unsafe CanvasGroup Group
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BalanceDisplay.NativeFieldInfoPtr_Group);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BalanceDisplay.NativeFieldInfoPtr_Group), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A3B RID: 10811
		// (get) Token: 0x06008AA9 RID: 35497 RVA: 0x00245558 File Offset: 0x00243758
		// (set) Token: 0x06008AAA RID: 35498 RVA: 0x000424DA File Offset: 0x000406DA
		public unsafe TextMeshProUGUI BalanceLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BalanceDisplay.NativeFieldInfoPtr_BalanceLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BalanceDisplay.NativeFieldInfoPtr_BalanceLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A3C RID: 10812
		// (get) Token: 0x06008AAB RID: 35499 RVA: 0x00245588 File Offset: 0x00243788
		// (set) Token: 0x06008AAC RID: 35500 RVA: 0x000424F9 File Offset: 0x000406F9
		public unsafe bool _active_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BalanceDisplay.NativeFieldInfoPtr__active_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BalanceDisplay.NativeFieldInfoPtr__active_k__BackingField)) = value;
			}
		}

		// Token: 0x17002A3D RID: 10813
		// (get) Token: 0x06008AAD RID: 35501 RVA: 0x002455B0 File Offset: 0x002437B0
		// (set) Token: 0x06008AAE RID: 35502 RVA: 0x00042514 File Offset: 0x00040714
		public unsafe float _timeSinceActiveSet_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BalanceDisplay.NativeFieldInfoPtr__timeSinceActiveSet_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BalanceDisplay.NativeFieldInfoPtr__timeSinceActiveSet_k__BackingField)) = value;
			}
		}

		// Token: 0x04005E06 RID: 24070
		private static readonly IntPtr NativeFieldInfoPtr_RESIDUAL_TIME;

		// Token: 0x04005E07 RID: 24071
		private static readonly IntPtr NativeFieldInfoPtr_FADE_TIME;

		// Token: 0x04005E08 RID: 24072
		private static readonly IntPtr NativeFieldInfoPtr_Group;

		// Token: 0x04005E09 RID: 24073
		private static readonly IntPtr NativeFieldInfoPtr_BalanceLabel;

		// Token: 0x04005E0A RID: 24074
		private static readonly IntPtr NativeFieldInfoPtr__active_k__BackingField;

		// Token: 0x04005E0B RID: 24075
		private static readonly IntPtr NativeFieldInfoPtr__timeSinceActiveSet_k__BackingField;

		// Token: 0x04005E0C RID: 24076
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_get_Boolean_0;

		// Token: 0x04005E0D RID: 24077
		private static readonly IntPtr NativeMethodInfoPtr_set_active_Protected_set_Void_Boolean_0;

		// Token: 0x04005E0E RID: 24078
		private static readonly IntPtr NativeMethodInfoPtr_get_timeSinceActiveSet_Public_get_Single_0;

		// Token: 0x04005E0F RID: 24079
		private static readonly IntPtr NativeMethodInfoPtr_set_timeSinceActiveSet_Protected_set_Void_Single_0;

		// Token: 0x04005E10 RID: 24080
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04005E11 RID: 24081
		private static readonly IntPtr NativeMethodInfoPtr_SetBalance_Public_Void_Single_0;

		// Token: 0x04005E12 RID: 24082
		private static readonly IntPtr NativeMethodInfoPtr_Show_Public_Void_0;

		// Token: 0x04005E13 RID: 24083
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
