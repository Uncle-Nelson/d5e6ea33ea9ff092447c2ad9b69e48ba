using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x020003E6 RID: 998
	public class PlayerEnergy : MonoBehaviour
	{
		// Token: 0x060050BF RID: 20671 RVA: 0x00180EFC File Offset: 0x0017F0FC
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerEnergy()
		{
			Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "PlayerEnergy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr);
			PlayerEnergy.NativeFieldInfoPtr_CRITICAL_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, "CRITICAL_THRESHOLD");
			PlayerEnergy.NativeFieldInfoPtr_MAX_ENERGY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, "MAX_ENERGY");
			PlayerEnergy.NativeFieldInfoPtr_SPRINT_DRAIN_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, "SPRINT_DRAIN_MULTIPLIER");
			PlayerEnergy.NativeFieldInfoPtr__CurrentEnergy_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, "<CurrentEnergy>k__BackingField");
			PlayerEnergy.NativeFieldInfoPtr__EnergyDrinksConsumed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, "<EnergyDrinksConsumed>k__BackingField");
			PlayerEnergy.NativeFieldInfoPtr_DEBUG_DISABLE_ENERGY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, "DEBUG_DISABLE_ENERGY");
			PlayerEnergy.NativeFieldInfoPtr_EnergyDuration_Hours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, "EnergyDuration_Hours");
			PlayerEnergy.NativeFieldInfoPtr_EnergyRechargeTime_Hours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, "EnergyRechargeTime_Hours");
			PlayerEnergy.NativeFieldInfoPtr_onEnergyChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, "onEnergyChanged");
			PlayerEnergy.NativeFieldInfoPtr_onEnergyDepleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, "onEnergyDepleted");
			PlayerEnergy.NativeMethodInfoPtr_get_CurrentEnergy_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, 100673431);
			PlayerEnergy.NativeMethodInfoPtr_set_CurrentEnergy_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, 100673432);
			PlayerEnergy.NativeMethodInfoPtr_get_EnergyDrinksConsumed_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, 100673433);
			PlayerEnergy.NativeMethodInfoPtr_set_EnergyDrinksConsumed_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, 100673434);
			PlayerEnergy.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, 100673435);
			PlayerEnergy.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, 100673436);
			PlayerEnergy.NativeMethodInfoPtr_ChangeEnergy_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, 100673437);
			PlayerEnergy.NativeMethodInfoPtr_SetEnergy_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, 100673438);
			PlayerEnergy.NativeMethodInfoPtr_RestoreEnergy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, 100673439);
			PlayerEnergy.NativeMethodInfoPtr_SleepEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, 100673440);
			PlayerEnergy.NativeMethodInfoPtr_IncrementEnergyDrinks_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, 100673441);
			PlayerEnergy.NativeMethodInfoPtr_ResetEnergyDrinks_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, 100673442);
			PlayerEnergy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr, 100673443);
		}

		// Token: 0x17001836 RID: 6198
		// (get) Token: 0x060050C0 RID: 20672 RVA: 0x001810F8 File Offset: 0x0017F2F8
		// (set) Token: 0x060050C1 RID: 20673 RVA: 0x00181134 File Offset: 0x0017F334
		public unsafe float CurrentEnergy
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEnergy.NativeMethodInfoPtr_get_CurrentEnergy_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29962, RefRangeEnd = 29963, XrefRangeStart = 29962, XrefRangeEnd = 29963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEnergy.NativeMethodInfoPtr_set_CurrentEnergy_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001837 RID: 6199
		// (get) Token: 0x060050C2 RID: 20674 RVA: 0x00181174 File Offset: 0x0017F374
		// (set) Token: 0x060050C3 RID: 20675 RVA: 0x001811B0 File Offset: 0x0017F3B0
		public unsafe int EnergyDrinksConsumed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEnergy.NativeMethodInfoPtr_get_EnergyDrinksConsumed_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEnergy.NativeMethodInfoPtr_set_EnergyDrinksConsumed_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060050C4 RID: 20676 RVA: 0x001811F0 File Offset: 0x0017F3F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175415, XrefRangeEnd = 175453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerEnergy.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050C5 RID: 20677 RVA: 0x0018122C File Offset: 0x0017F42C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175453, XrefRangeEnd = 175468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEnergy.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050C6 RID: 20678 RVA: 0x00181260 File Offset: 0x0017F460
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeEnergy(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEnergy.NativeMethodInfoPtr_ChangeEnergy_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050C7 RID: 20679 RVA: 0x001812A0 File Offset: 0x0017F4A0
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEnergy(float newEnergy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newEnergy;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEnergy.NativeMethodInfoPtr_SetEnergy_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050C8 RID: 20680 RVA: 0x001812E0 File Offset: 0x0017F4E0
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RestoreEnergy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEnergy.NativeMethodInfoPtr_RestoreEnergy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050C9 RID: 20681 RVA: 0x00181314 File Offset: 0x0017F514
		[CallerCount(0)]
		public unsafe void SleepEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEnergy.NativeMethodInfoPtr_SleepEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050CA RID: 20682 RVA: 0x00181348 File Offset: 0x0017F548
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 175468, RefRangeEnd = 175469, XrefRangeStart = 175468, XrefRangeEnd = 175468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IncrementEnergyDrinks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEnergy.NativeMethodInfoPtr_IncrementEnergyDrinks_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050CB RID: 20683 RVA: 0x0018137C File Offset: 0x0017F57C
		[CallerCount(0)]
		public unsafe void ResetEnergyDrinks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEnergy.NativeMethodInfoPtr_ResetEnergyDrinks_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050CC RID: 20684 RVA: 0x001813B0 File Offset: 0x0017F5B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175469, XrefRangeEnd = 175470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerEnergy() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerEnergy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEnergy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050CD RID: 20685 RVA: 0x0002666E File Offset: 0x0002486E
		public PlayerEnergy(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700182C RID: 6188
		// (get) Token: 0x060050CE RID: 20686 RVA: 0x001813EC File Offset: 0x0017F5EC
		// (set) Token: 0x060050CF RID: 20687 RVA: 0x00026677 File Offset: 0x00024877
		public unsafe static float CRITICAL_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerEnergy.NativeFieldInfoPtr_CRITICAL_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerEnergy.NativeFieldInfoPtr_CRITICAL_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x1700182D RID: 6189
		// (get) Token: 0x060050D0 RID: 20688 RVA: 0x00181408 File Offset: 0x0017F608
		// (set) Token: 0x060050D1 RID: 20689 RVA: 0x00026685 File Offset: 0x00024885
		public unsafe static float MAX_ENERGY
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerEnergy.NativeFieldInfoPtr_MAX_ENERGY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerEnergy.NativeFieldInfoPtr_MAX_ENERGY, (void*)(&value));
			}
		}

		// Token: 0x1700182E RID: 6190
		// (get) Token: 0x060050D2 RID: 20690 RVA: 0x00181424 File Offset: 0x0017F624
		// (set) Token: 0x060050D3 RID: 20691 RVA: 0x00026693 File Offset: 0x00024893
		public unsafe static float SPRINT_DRAIN_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerEnergy.NativeFieldInfoPtr_SPRINT_DRAIN_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerEnergy.NativeFieldInfoPtr_SPRINT_DRAIN_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x1700182F RID: 6191
		// (get) Token: 0x060050D4 RID: 20692 RVA: 0x00181440 File Offset: 0x0017F640
		// (set) Token: 0x060050D5 RID: 20693 RVA: 0x000266A1 File Offset: 0x000248A1
		public unsafe float _CurrentEnergy_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergy.NativeFieldInfoPtr__CurrentEnergy_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergy.NativeFieldInfoPtr__CurrentEnergy_k__BackingField)) = value;
			}
		}

		// Token: 0x17001830 RID: 6192
		// (get) Token: 0x060050D6 RID: 20694 RVA: 0x00181468 File Offset: 0x0017F668
		// (set) Token: 0x060050D7 RID: 20695 RVA: 0x000266BC File Offset: 0x000248BC
		public unsafe int _EnergyDrinksConsumed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergy.NativeFieldInfoPtr__EnergyDrinksConsumed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergy.NativeFieldInfoPtr__EnergyDrinksConsumed_k__BackingField)) = value;
			}
		}

		// Token: 0x17001831 RID: 6193
		// (get) Token: 0x060050D8 RID: 20696 RVA: 0x00181490 File Offset: 0x0017F690
		// (set) Token: 0x060050D9 RID: 20697 RVA: 0x000266D7 File Offset: 0x000248D7
		public unsafe bool DEBUG_DISABLE_ENERGY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergy.NativeFieldInfoPtr_DEBUG_DISABLE_ENERGY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergy.NativeFieldInfoPtr_DEBUG_DISABLE_ENERGY)) = value;
			}
		}

		// Token: 0x17001832 RID: 6194
		// (get) Token: 0x060050DA RID: 20698 RVA: 0x001814B8 File Offset: 0x0017F6B8
		// (set) Token: 0x060050DB RID: 20699 RVA: 0x000266F2 File Offset: 0x000248F2
		public unsafe float EnergyDuration_Hours
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergy.NativeFieldInfoPtr_EnergyDuration_Hours);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergy.NativeFieldInfoPtr_EnergyDuration_Hours)) = value;
			}
		}

		// Token: 0x17001833 RID: 6195
		// (get) Token: 0x060050DC RID: 20700 RVA: 0x001814E0 File Offset: 0x0017F6E0
		// (set) Token: 0x060050DD RID: 20701 RVA: 0x0002670D File Offset: 0x0002490D
		public unsafe float EnergyRechargeTime_Hours
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergy.NativeFieldInfoPtr_EnergyRechargeTime_Hours);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergy.NativeFieldInfoPtr_EnergyRechargeTime_Hours)) = value;
			}
		}

		// Token: 0x17001834 RID: 6196
		// (get) Token: 0x060050DE RID: 20702 RVA: 0x00181508 File Offset: 0x0017F708
		// (set) Token: 0x060050DF RID: 20703 RVA: 0x00026728 File Offset: 0x00024928
		public unsafe UnityEvent onEnergyChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergy.NativeFieldInfoPtr_onEnergyChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergy.NativeFieldInfoPtr_onEnergyChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001835 RID: 6197
		// (get) Token: 0x060050E0 RID: 20704 RVA: 0x00181538 File Offset: 0x0017F738
		// (set) Token: 0x060050E1 RID: 20705 RVA: 0x00026747 File Offset: 0x00024947
		public unsafe UnityEvent onEnergyDepleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergy.NativeFieldInfoPtr_onEnergyDepleted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEnergy.NativeFieldInfoPtr_onEnergyDepleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040036CB RID: 14027
		private static readonly IntPtr NativeFieldInfoPtr_CRITICAL_THRESHOLD;

		// Token: 0x040036CC RID: 14028
		private static readonly IntPtr NativeFieldInfoPtr_MAX_ENERGY;

		// Token: 0x040036CD RID: 14029
		private static readonly IntPtr NativeFieldInfoPtr_SPRINT_DRAIN_MULTIPLIER;

		// Token: 0x040036CE RID: 14030
		private static readonly IntPtr NativeFieldInfoPtr__CurrentEnergy_k__BackingField;

		// Token: 0x040036CF RID: 14031
		private static readonly IntPtr NativeFieldInfoPtr__EnergyDrinksConsumed_k__BackingField;

		// Token: 0x040036D0 RID: 14032
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG_DISABLE_ENERGY;

		// Token: 0x040036D1 RID: 14033
		private static readonly IntPtr NativeFieldInfoPtr_EnergyDuration_Hours;

		// Token: 0x040036D2 RID: 14034
		private static readonly IntPtr NativeFieldInfoPtr_EnergyRechargeTime_Hours;

		// Token: 0x040036D3 RID: 14035
		private static readonly IntPtr NativeFieldInfoPtr_onEnergyChanged;

		// Token: 0x040036D4 RID: 14036
		private static readonly IntPtr NativeFieldInfoPtr_onEnergyDepleted;

		// Token: 0x040036D5 RID: 14037
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentEnergy_Public_get_Single_0;

		// Token: 0x040036D6 RID: 14038
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentEnergy_Protected_set_Void_Single_0;

		// Token: 0x040036D7 RID: 14039
		private static readonly IntPtr NativeMethodInfoPtr_get_EnergyDrinksConsumed_Public_get_Int32_0;

		// Token: 0x040036D8 RID: 14040
		private static readonly IntPtr NativeMethodInfoPtr_set_EnergyDrinksConsumed_Protected_set_Void_Int32_0;

		// Token: 0x040036D9 RID: 14041
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x040036DA RID: 14042
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x040036DB RID: 14043
		private static readonly IntPtr NativeMethodInfoPtr_ChangeEnergy_Private_Void_Single_0;

		// Token: 0x040036DC RID: 14044
		private static readonly IntPtr NativeMethodInfoPtr_SetEnergy_Public_Void_Single_0;

		// Token: 0x040036DD RID: 14045
		private static readonly IntPtr NativeMethodInfoPtr_RestoreEnergy_Public_Void_0;

		// Token: 0x040036DE RID: 14046
		private static readonly IntPtr NativeMethodInfoPtr_SleepEnd_Private_Void_0;

		// Token: 0x040036DF RID: 14047
		private static readonly IntPtr NativeMethodInfoPtr_IncrementEnergyDrinks_Public_Void_0;

		// Token: 0x040036E0 RID: 14048
		private static readonly IntPtr NativeMethodInfoPtr_ResetEnergyDrinks_Private_Void_0;

		// Token: 0x040036E1 RID: 14049
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
