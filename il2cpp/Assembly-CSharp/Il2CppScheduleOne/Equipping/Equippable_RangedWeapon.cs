using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Storage;
using Il2CppScheduleOne.Trash;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005C4 RID: 1476
	public class Equippable_RangedWeapon : Equippable_AvatarViewmodel
	{
		// Token: 0x06008170 RID: 33136 RVA: 0x002285F8 File Offset: 0x002267F8
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_RangedWeapon()
		{
			Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_RangedWeapon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr);
			Equippable_RangedWeapon.NativeFieldInfoPtr_NPC_AIM_DETECTION_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "NPC_AIM_DETECTION_RANGE");
			Equippable_RangedWeapon.NativeFieldInfoPtr__Aim_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "<Aim>k__BackingField");
			Equippable_RangedWeapon.NativeFieldInfoPtr__Accuracy_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "<Accuracy>k__BackingField");
			Equippable_RangedWeapon.NativeFieldInfoPtr__TimeSinceFire_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "<TimeSinceFire>k__BackingField");
			Equippable_RangedWeapon.NativeFieldInfoPtr__IsReloading_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "<IsReloading>k__BackingField");
			Equippable_RangedWeapon.NativeFieldInfoPtr__IsCocked_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "<IsCocked>k__BackingField");
			Equippable_RangedWeapon.NativeFieldInfoPtr__IsCocking_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "<IsCocking>k__BackingField");
			Equippable_RangedWeapon.NativeFieldInfoPtr_MagazineSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "MagazineSize");
			Equippable_RangedWeapon.NativeFieldInfoPtr_AimDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "AimDuration");
			Equippable_RangedWeapon.NativeFieldInfoPtr_AimFOVReduction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "AimFOVReduction");
			Equippable_RangedWeapon.NativeFieldInfoPtr_FOVChangeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "FOVChangeDuration");
			Equippable_RangedWeapon.NativeFieldInfoPtr_FireSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "FireSound");
			Equippable_RangedWeapon.NativeFieldInfoPtr_EmptySound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "EmptySound");
			Equippable_RangedWeapon.NativeFieldInfoPtr_FireCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "FireCooldown");
			Equippable_RangedWeapon.NativeFieldInfoPtr_FireAnimTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "FireAnimTriggers");
			Equippable_RangedWeapon.NativeFieldInfoPtr_AccuracyChangeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "AccuracyChangeDuration");
			Equippable_RangedWeapon.NativeFieldInfoPtr_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "Range");
			Equippable_RangedWeapon.NativeFieldInfoPtr_RayRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "RayRadius");
			Equippable_RangedWeapon.NativeFieldInfoPtr_MinSpread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "MinSpread");
			Equippable_RangedWeapon.NativeFieldInfoPtr_MaxSpread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "MaxSpread");
			Equippable_RangedWeapon.NativeFieldInfoPtr_Damage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "Damage");
			Equippable_RangedWeapon.NativeFieldInfoPtr_ImpactForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "ImpactForce");
			Equippable_RangedWeapon.NativeFieldInfoPtr_CanReload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "CanReload");
			Equippable_RangedWeapon.NativeFieldInfoPtr_IncrementalReload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "IncrementalReload");
			Equippable_RangedWeapon.NativeFieldInfoPtr_Magazine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "Magazine");
			Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "ReloadStartTime");
			Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadIndividalTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "ReloadIndividalTime");
			Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadEndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "ReloadEndTime");
			Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadStartAnimTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "ReloadStartAnimTrigger");
			Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadIndividualAnimTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "ReloadIndividualAnimTrigger");
			Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadEndAnimTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "ReloadEndAnimTrigger");
			Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadTrash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "ReloadTrash");
			Equippable_RangedWeapon.NativeFieldInfoPtr_MustBeCocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "MustBeCocked");
			Equippable_RangedWeapon.NativeFieldInfoPtr_CockTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "CockTime");
			Equippable_RangedWeapon.NativeFieldInfoPtr_CockAnimTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "CockAnimTrigger");
			Equippable_RangedWeapon.NativeFieldInfoPtr_TracerSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "TracerSpeed");
			Equippable_RangedWeapon.NativeFieldInfoPtr_onFire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "onFire");
			Equippable_RangedWeapon.NativeFieldInfoPtr_onReloadStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "onReloadStart");
			Equippable_RangedWeapon.NativeFieldInfoPtr_onReloadIndividual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "onReloadIndividual");
			Equippable_RangedWeapon.NativeFieldInfoPtr_onReloadEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "onReloadEnd");
			Equippable_RangedWeapon.NativeFieldInfoPtr_onCockStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "onCockStart");
			Equippable_RangedWeapon.NativeFieldInfoPtr_weaponItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "weaponItem");
			Equippable_RangedWeapon.NativeFieldInfoPtr_fovOverridden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "fovOverridden");
			Equippable_RangedWeapon.NativeFieldInfoPtr_aimVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "aimVelocity");
			Equippable_RangedWeapon.NativeFieldInfoPtr_reloadRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "reloadRoutine");
			Equippable_RangedWeapon.NativeFieldInfoPtr_shotQueued = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "shotQueued");
			Equippable_RangedWeapon.NativeFieldInfoPtr_reloadQueued = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "reloadQueued");
			Equippable_RangedWeapon.NativeFieldInfoPtr_timeSincePrimaryClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "timeSincePrimaryClick");
			Equippable_RangedWeapon.NativeMethodInfoPtr_get_Aim_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679509);
			Equippable_RangedWeapon.NativeMethodInfoPtr_set_Aim_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679510);
			Equippable_RangedWeapon.NativeMethodInfoPtr_get_Accuracy_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679511);
			Equippable_RangedWeapon.NativeMethodInfoPtr_set_Accuracy_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679512);
			Equippable_RangedWeapon.NativeMethodInfoPtr_get_TimeSinceFire_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679513);
			Equippable_RangedWeapon.NativeMethodInfoPtr_set_TimeSinceFire_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679514);
			Equippable_RangedWeapon.NativeMethodInfoPtr_get_IsReloading_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679515);
			Equippable_RangedWeapon.NativeMethodInfoPtr_set_IsReloading_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679516);
			Equippable_RangedWeapon.NativeMethodInfoPtr_get_IsCocked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679517);
			Equippable_RangedWeapon.NativeMethodInfoPtr_set_IsCocked_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679518);
			Equippable_RangedWeapon.NativeMethodInfoPtr_get_IsCocking_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679519);
			Equippable_RangedWeapon.NativeMethodInfoPtr_set_IsCocking_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679520);
			Equippable_RangedWeapon.NativeMethodInfoPtr_get_Ammo_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679521);
			Equippable_RangedWeapon.NativeMethodInfoPtr_get_aimFov_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679522);
			Equippable_RangedWeapon.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679523);
			Equippable_RangedWeapon.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679524);
			Equippable_RangedWeapon.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679525);
			Equippable_RangedWeapon.NativeMethodInfoPtr_UpdateInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679526);
			Equippable_RangedWeapon.NativeMethodInfoPtr_UpdateAnim_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679527);
			Equippable_RangedWeapon.NativeMethodInfoPtr_CanAim_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679528);
			Equippable_RangedWeapon.NativeMethodInfoPtr_Fire_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679529);
			Equippable_RangedWeapon.NativeMethodInfoPtr_Reload_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679530);
			Equippable_RangedWeapon.NativeMethodInfoPtr_NotifyIncrementalReload_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679531);
			Equippable_RangedWeapon.NativeMethodInfoPtr_IsReloadReady_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679532);
			Equippable_RangedWeapon.NativeMethodInfoPtr_GetMagazine_Protected_Virtual_New_Boolean_byref_StorableItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679533);
			Equippable_RangedWeapon.NativeMethodInfoPtr_CanFire_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679534);
			Equippable_RangedWeapon.NativeMethodInfoPtr_CanCock_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679535);
			Equippable_RangedWeapon.NativeMethodInfoPtr_Cock_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679536);
			Equippable_RangedWeapon.NativeMethodInfoPtr_GetSpread_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679537);
			Equippable_RangedWeapon.NativeMethodInfoPtr_CheckAimingAtNPC_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679538);
			Equippable_RangedWeapon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679539);
			Equippable_RangedWeapon.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679540);
			Equippable_RangedWeapon.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679541);
		}

		// Token: 0x17002751 RID: 10065
		// (get) Token: 0x06008171 RID: 33137 RVA: 0x00228C7C File Offset: 0x00226E7C
		// (set) Token: 0x06008172 RID: 33138 RVA: 0x00228CB8 File Offset: 0x00226EB8
		public unsafe float Aim
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_get_Aim_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_set_Aim_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002752 RID: 10066
		// (get) Token: 0x06008173 RID: 33139 RVA: 0x00228CF8 File Offset: 0x00226EF8
		// (set) Token: 0x06008174 RID: 33140 RVA: 0x00228D34 File Offset: 0x00226F34
		public unsafe float Accuracy
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_get_Accuracy_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_set_Accuracy_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002753 RID: 10067
		// (get) Token: 0x06008175 RID: 33141 RVA: 0x00228D74 File Offset: 0x00226F74
		// (set) Token: 0x06008176 RID: 33142 RVA: 0x00228DB0 File Offset: 0x00226FB0
		public unsafe float TimeSinceFire
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_get_TimeSinceFire_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_set_TimeSinceFire_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002754 RID: 10068
		// (get) Token: 0x06008177 RID: 33143 RVA: 0x00228DF0 File Offset: 0x00226FF0
		// (set) Token: 0x06008178 RID: 33144 RVA: 0x00228E2C File Offset: 0x0022702C
		public unsafe bool IsReloading
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 245476, RefRangeEnd = 245477, XrefRangeStart = 245476, XrefRangeEnd = 245476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_get_IsReloading_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_set_IsReloading_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002755 RID: 10069
		// (get) Token: 0x06008179 RID: 33145 RVA: 0x00228E6C File Offset: 0x0022706C
		// (set) Token: 0x0600817A RID: 33146 RVA: 0x00228EA8 File Offset: 0x002270A8
		public unsafe bool IsCocked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_get_IsCocked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_set_IsCocked_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002756 RID: 10070
		// (get) Token: 0x0600817B RID: 33147 RVA: 0x00228EE8 File Offset: 0x002270E8
		// (set) Token: 0x0600817C RID: 33148 RVA: 0x00228F24 File Offset: 0x00227124
		public unsafe bool IsCocking
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_get_IsCocking_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_set_IsCocking_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002757 RID: 10071
		// (get) Token: 0x0600817D RID: 33149 RVA: 0x00228F64 File Offset: 0x00227164
		public unsafe int Ammo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_get_Ammo_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002758 RID: 10072
		// (get) Token: 0x0600817E RID: 33150 RVA: 0x00228FA0 File Offset: 0x002271A0
		public unsafe float aimFov
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245477, XrefRangeEnd = 245481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_get_aimFov_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600817F RID: 33151 RVA: 0x00228FDC File Offset: 0x002271DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 245504, RefRangeEnd = 245505, XrefRangeStart = 245481, XrefRangeEnd = 245504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_RangedWeapon.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008180 RID: 33152 RVA: 0x0022902C File Offset: 0x0022722C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245505, XrefRangeEnd = 245529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_RangedWeapon.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008181 RID: 33153 RVA: 0x00229068 File Offset: 0x00227268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245529, XrefRangeEnd = 245544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_RangedWeapon.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008182 RID: 33154 RVA: 0x002290A4 File Offset: 0x002272A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 245646, RefRangeEnd = 245647, XrefRangeStart = 245544, XrefRangeEnd = 245646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_UpdateInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008183 RID: 33155 RVA: 0x002290D8 File Offset: 0x002272D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245647, XrefRangeEnd = 245655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAnim()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_UpdateAnim_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008184 RID: 33156 RVA: 0x0022910C File Offset: 0x0022730C
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 30138, RefRangeEnd = 30158, XrefRangeStart = 30138, XrefRangeEnd = 30158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanAim()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_CanAim_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008185 RID: 33157 RVA: 0x00229148 File Offset: 0x00227348
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 245792, RefRangeEnd = 245793, XrefRangeStart = 245655, XrefRangeEnd = 245792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Fire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_RangedWeapon.NativeMethodInfoPtr_Fire_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008186 RID: 33158 RVA: 0x00229184 File Offset: 0x00227384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245793, XrefRangeEnd = 245806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Reload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_RangedWeapon.NativeMethodInfoPtr_Reload_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008187 RID: 33159 RVA: 0x002291C0 File Offset: 0x002273C0
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NotifyIncrementalReload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_RangedWeapon.NativeMethodInfoPtr_NotifyIncrementalReload_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008188 RID: 33160 RVA: 0x002291FC File Offset: 0x002273FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 245806, RefRangeEnd = 245807, XrefRangeStart = 245806, XrefRangeEnd = 245806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsReloadReady(bool ignoreTiming)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref ignoreTiming;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_IsReloadReady_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008189 RID: 33161 RVA: 0x00229248 File Offset: 0x00227448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245807, XrefRangeEnd = 245837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetMagazine(out StorableItemInstance mag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_RangedWeapon.NativeMethodInfoPtr_GetMagazine_Protected_Virtual_New_Boolean_byref_StorableItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			mag = ((intPtr4 == 0) ? null : new StorableItemInstance(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600818A RID: 33162 RVA: 0x002292B4 File Offset: 0x002274B4
		[CallerCount(0)]
		public unsafe bool CanFire(bool checkAmmo = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref checkAmmo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_CanFire_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600818B RID: 33163 RVA: 0x00229300 File Offset: 0x00227500
		[CallerCount(0)]
		public unsafe bool CanCock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_CanCock_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600818C RID: 33164 RVA: 0x0022933C File Offset: 0x0022753C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245837, XrefRangeEnd = 245849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_Cock_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600818D RID: 33165 RVA: 0x00229370 File Offset: 0x00227570
		[CallerCount(0)]
		public unsafe float GetSpread()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_GetSpread_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600818E RID: 33166 RVA: 0x002293AC File Offset: 0x002275AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245849, XrefRangeEnd = 245906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckAimingAtNPC()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_CheckAimingAtNPC_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600818F RID: 33167 RVA: 0x002293E0 File Offset: 0x002275E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245906, XrefRangeEnd = 245919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_RangedWeapon() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008190 RID: 33168 RVA: 0x0022941C File Offset: 0x0022761C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245919, XrefRangeEnd = 245924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06008191 RID: 33169 RVA: 0x0022945C File Offset: 0x0022765C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245924, XrefRangeEnd = 245929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06008192 RID: 33170 RVA: 0x0003D796 File Offset: 0x0003B996
		public Equippable_RangedWeapon(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002721 RID: 10017
		// (get) Token: 0x06008193 RID: 33171 RVA: 0x0022949C File Offset: 0x0022769C
		// (set) Token: 0x06008194 RID: 33172 RVA: 0x0003D79F File Offset: 0x0003B99F
		public unsafe static float NPC_AIM_DETECTION_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Equippable_RangedWeapon.NativeFieldInfoPtr_NPC_AIM_DETECTION_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Equippable_RangedWeapon.NativeFieldInfoPtr_NPC_AIM_DETECTION_RANGE, (void*)(&value));
			}
		}

		// Token: 0x17002722 RID: 10018
		// (get) Token: 0x06008195 RID: 33173 RVA: 0x002294B8 File Offset: 0x002276B8
		// (set) Token: 0x06008196 RID: 33174 RVA: 0x0003D7AD File Offset: 0x0003B9AD
		public unsafe float _Aim_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr__Aim_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr__Aim_k__BackingField)) = value;
			}
		}

		// Token: 0x17002723 RID: 10019
		// (get) Token: 0x06008197 RID: 33175 RVA: 0x002294E0 File Offset: 0x002276E0
		// (set) Token: 0x06008198 RID: 33176 RVA: 0x0003D7C8 File Offset: 0x0003B9C8
		public unsafe float _Accuracy_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr__Accuracy_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr__Accuracy_k__BackingField)) = value;
			}
		}

		// Token: 0x17002724 RID: 10020
		// (get) Token: 0x06008199 RID: 33177 RVA: 0x00229508 File Offset: 0x00227708
		// (set) Token: 0x0600819A RID: 33178 RVA: 0x0003D7E3 File Offset: 0x0003B9E3
		public unsafe float _TimeSinceFire_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr__TimeSinceFire_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr__TimeSinceFire_k__BackingField)) = value;
			}
		}

		// Token: 0x17002725 RID: 10021
		// (get) Token: 0x0600819B RID: 33179 RVA: 0x00229530 File Offset: 0x00227730
		// (set) Token: 0x0600819C RID: 33180 RVA: 0x0003D7FE File Offset: 0x0003B9FE
		public unsafe bool _IsReloading_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr__IsReloading_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr__IsReloading_k__BackingField)) = value;
			}
		}

		// Token: 0x17002726 RID: 10022
		// (get) Token: 0x0600819D RID: 33181 RVA: 0x00229558 File Offset: 0x00227758
		// (set) Token: 0x0600819E RID: 33182 RVA: 0x0003D819 File Offset: 0x0003BA19
		public unsafe bool _IsCocked_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr__IsCocked_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr__IsCocked_k__BackingField)) = value;
			}
		}

		// Token: 0x17002727 RID: 10023
		// (get) Token: 0x0600819F RID: 33183 RVA: 0x00229580 File Offset: 0x00227780
		// (set) Token: 0x060081A0 RID: 33184 RVA: 0x0003D834 File Offset: 0x0003BA34
		public unsafe bool _IsCocking_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr__IsCocking_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr__IsCocking_k__BackingField)) = value;
			}
		}

		// Token: 0x17002728 RID: 10024
		// (get) Token: 0x060081A1 RID: 33185 RVA: 0x002295A8 File Offset: 0x002277A8
		// (set) Token: 0x060081A2 RID: 33186 RVA: 0x0003D84F File Offset: 0x0003BA4F
		public unsafe int MagazineSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_MagazineSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_MagazineSize)) = value;
			}
		}

		// Token: 0x17002729 RID: 10025
		// (get) Token: 0x060081A3 RID: 33187 RVA: 0x002295D0 File Offset: 0x002277D0
		// (set) Token: 0x060081A4 RID: 33188 RVA: 0x0003D86A File Offset: 0x0003BA6A
		public unsafe float AimDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_AimDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_AimDuration)) = value;
			}
		}

		// Token: 0x1700272A RID: 10026
		// (get) Token: 0x060081A5 RID: 33189 RVA: 0x002295F8 File Offset: 0x002277F8
		// (set) Token: 0x060081A6 RID: 33190 RVA: 0x0003D885 File Offset: 0x0003BA85
		public unsafe float AimFOVReduction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_AimFOVReduction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_AimFOVReduction)) = value;
			}
		}

		// Token: 0x1700272B RID: 10027
		// (get) Token: 0x060081A7 RID: 33191 RVA: 0x00229620 File Offset: 0x00227820
		// (set) Token: 0x060081A8 RID: 33192 RVA: 0x0003D8A0 File Offset: 0x0003BAA0
		public unsafe float FOVChangeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_FOVChangeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_FOVChangeDuration)) = value;
			}
		}

		// Token: 0x1700272C RID: 10028
		// (get) Token: 0x060081A9 RID: 33193 RVA: 0x00229648 File Offset: 0x00227848
		// (set) Token: 0x060081AA RID: 33194 RVA: 0x0003D8BB File Offset: 0x0003BABB
		public unsafe AudioSourceController FireSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_FireSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_FireSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700272D RID: 10029
		// (get) Token: 0x060081AB RID: 33195 RVA: 0x00229678 File Offset: 0x00227878
		// (set) Token: 0x060081AC RID: 33196 RVA: 0x0003D8DA File Offset: 0x0003BADA
		public unsafe AudioSourceController EmptySound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_EmptySound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_EmptySound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700272E RID: 10030
		// (get) Token: 0x060081AD RID: 33197 RVA: 0x002296A8 File Offset: 0x002278A8
		// (set) Token: 0x060081AE RID: 33198 RVA: 0x0003D8F9 File Offset: 0x0003BAF9
		public unsafe float FireCooldown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_FireCooldown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_FireCooldown)) = value;
			}
		}

		// Token: 0x1700272F RID: 10031
		// (get) Token: 0x060081AF RID: 33199 RVA: 0x002296D0 File Offset: 0x002278D0
		// (set) Token: 0x060081B0 RID: 33200 RVA: 0x0003D914 File Offset: 0x0003BB14
		public unsafe Il2CppStringArray FireAnimTriggers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_FireAnimTriggers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_FireAnimTriggers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002730 RID: 10032
		// (get) Token: 0x060081B1 RID: 33201 RVA: 0x00229700 File Offset: 0x00227900
		// (set) Token: 0x060081B2 RID: 33202 RVA: 0x0003D933 File Offset: 0x0003BB33
		public unsafe float AccuracyChangeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_AccuracyChangeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_AccuracyChangeDuration)) = value;
			}
		}

		// Token: 0x17002731 RID: 10033
		// (get) Token: 0x060081B3 RID: 33203 RVA: 0x00229728 File Offset: 0x00227928
		// (set) Token: 0x060081B4 RID: 33204 RVA: 0x0003D94E File Offset: 0x0003BB4E
		public unsafe float Range
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_Range);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_Range)) = value;
			}
		}

		// Token: 0x17002732 RID: 10034
		// (get) Token: 0x060081B5 RID: 33205 RVA: 0x00229750 File Offset: 0x00227950
		// (set) Token: 0x060081B6 RID: 33206 RVA: 0x0003D969 File Offset: 0x0003BB69
		public unsafe float RayRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_RayRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_RayRadius)) = value;
			}
		}

		// Token: 0x17002733 RID: 10035
		// (get) Token: 0x060081B7 RID: 33207 RVA: 0x00229778 File Offset: 0x00227978
		// (set) Token: 0x060081B8 RID: 33208 RVA: 0x0003D984 File Offset: 0x0003BB84
		public unsafe float MinSpread
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_MinSpread);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_MinSpread)) = value;
			}
		}

		// Token: 0x17002734 RID: 10036
		// (get) Token: 0x060081B9 RID: 33209 RVA: 0x002297A0 File Offset: 0x002279A0
		// (set) Token: 0x060081BA RID: 33210 RVA: 0x0003D99F File Offset: 0x0003BB9F
		public unsafe float MaxSpread
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_MaxSpread);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_MaxSpread)) = value;
			}
		}

		// Token: 0x17002735 RID: 10037
		// (get) Token: 0x060081BB RID: 33211 RVA: 0x002297C8 File Offset: 0x002279C8
		// (set) Token: 0x060081BC RID: 33212 RVA: 0x0003D9BA File Offset: 0x0003BBBA
		public unsafe float Damage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_Damage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_Damage)) = value;
			}
		}

		// Token: 0x17002736 RID: 10038
		// (get) Token: 0x060081BD RID: 33213 RVA: 0x002297F0 File Offset: 0x002279F0
		// (set) Token: 0x060081BE RID: 33214 RVA: 0x0003D9D5 File Offset: 0x0003BBD5
		public unsafe float ImpactForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ImpactForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ImpactForce)) = value;
			}
		}

		// Token: 0x17002737 RID: 10039
		// (get) Token: 0x060081BF RID: 33215 RVA: 0x00229818 File Offset: 0x00227A18
		// (set) Token: 0x060081C0 RID: 33216 RVA: 0x0003D9F0 File Offset: 0x0003BBF0
		public unsafe bool CanReload
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_CanReload);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_CanReload)) = value;
			}
		}

		// Token: 0x17002738 RID: 10040
		// (get) Token: 0x060081C1 RID: 33217 RVA: 0x00229840 File Offset: 0x00227A40
		// (set) Token: 0x060081C2 RID: 33218 RVA: 0x0003DA0B File Offset: 0x0003BC0B
		public unsafe bool IncrementalReload
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_IncrementalReload);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_IncrementalReload)) = value;
			}
		}

		// Token: 0x17002739 RID: 10041
		// (get) Token: 0x060081C3 RID: 33219 RVA: 0x00229868 File Offset: 0x00227A68
		// (set) Token: 0x060081C4 RID: 33220 RVA: 0x0003DA26 File Offset: 0x0003BC26
		public unsafe StorableItemDefinition Magazine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_Magazine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorableItemDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_Magazine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700273A RID: 10042
		// (get) Token: 0x060081C5 RID: 33221 RVA: 0x00229898 File Offset: 0x00227A98
		// (set) Token: 0x060081C6 RID: 33222 RVA: 0x0003DA45 File Offset: 0x0003BC45
		public unsafe float ReloadStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadStartTime)) = value;
			}
		}

		// Token: 0x1700273B RID: 10043
		// (get) Token: 0x060081C7 RID: 33223 RVA: 0x002298C0 File Offset: 0x00227AC0
		// (set) Token: 0x060081C8 RID: 33224 RVA: 0x0003DA60 File Offset: 0x0003BC60
		public unsafe float ReloadIndividalTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadIndividalTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadIndividalTime)) = value;
			}
		}

		// Token: 0x1700273C RID: 10044
		// (get) Token: 0x060081C9 RID: 33225 RVA: 0x002298E8 File Offset: 0x00227AE8
		// (set) Token: 0x060081CA RID: 33226 RVA: 0x0003DA7B File Offset: 0x0003BC7B
		public unsafe float ReloadEndTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadEndTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadEndTime)) = value;
			}
		}

		// Token: 0x1700273D RID: 10045
		// (get) Token: 0x060081CB RID: 33227 RVA: 0x00229910 File Offset: 0x00227B10
		// (set) Token: 0x060081CC RID: 33228 RVA: 0x0003DA96 File Offset: 0x0003BC96
		public unsafe string ReloadStartAnimTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadStartAnimTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadStartAnimTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700273E RID: 10046
		// (get) Token: 0x060081CD RID: 33229 RVA: 0x00229938 File Offset: 0x00227B38
		// (set) Token: 0x060081CE RID: 33230 RVA: 0x0003DAB5 File Offset: 0x0003BCB5
		public unsafe string ReloadIndividualAnimTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadIndividualAnimTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadIndividualAnimTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700273F RID: 10047
		// (get) Token: 0x060081CF RID: 33231 RVA: 0x00229960 File Offset: 0x00227B60
		// (set) Token: 0x060081D0 RID: 33232 RVA: 0x0003DAD4 File Offset: 0x0003BCD4
		public unsafe string ReloadEndAnimTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadEndAnimTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadEndAnimTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002740 RID: 10048
		// (get) Token: 0x060081D1 RID: 33233 RVA: 0x00229988 File Offset: 0x00227B88
		// (set) Token: 0x060081D2 RID: 33234 RVA: 0x0003DAF3 File Offset: 0x0003BCF3
		public unsafe TrashItem ReloadTrash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadTrash);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadTrash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002741 RID: 10049
		// (get) Token: 0x060081D3 RID: 33235 RVA: 0x002299B8 File Offset: 0x00227BB8
		// (set) Token: 0x060081D4 RID: 33236 RVA: 0x0003DB12 File Offset: 0x0003BD12
		public unsafe bool MustBeCocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_MustBeCocked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_MustBeCocked)) = value;
			}
		}

		// Token: 0x17002742 RID: 10050
		// (get) Token: 0x060081D5 RID: 33237 RVA: 0x002299E0 File Offset: 0x00227BE0
		// (set) Token: 0x060081D6 RID: 33238 RVA: 0x0003DB2D File Offset: 0x0003BD2D
		public unsafe float CockTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_CockTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_CockTime)) = value;
			}
		}

		// Token: 0x17002743 RID: 10051
		// (get) Token: 0x060081D7 RID: 33239 RVA: 0x00229A08 File Offset: 0x00227C08
		// (set) Token: 0x060081D8 RID: 33240 RVA: 0x0003DB48 File Offset: 0x0003BD48
		public unsafe string CockAnimTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_CockAnimTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_CockAnimTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002744 RID: 10052
		// (get) Token: 0x060081D9 RID: 33241 RVA: 0x00229A30 File Offset: 0x00227C30
		// (set) Token: 0x060081DA RID: 33242 RVA: 0x0003DB67 File Offset: 0x0003BD67
		public unsafe float TracerSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_TracerSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_TracerSpeed)) = value;
			}
		}

		// Token: 0x17002745 RID: 10053
		// (get) Token: 0x060081DB RID: 33243 RVA: 0x00229A58 File Offset: 0x00227C58
		// (set) Token: 0x060081DC RID: 33244 RVA: 0x0003DB82 File Offset: 0x0003BD82
		public unsafe UnityEvent onFire
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_onFire);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_onFire), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002746 RID: 10054
		// (get) Token: 0x060081DD RID: 33245 RVA: 0x00229A88 File Offset: 0x00227C88
		// (set) Token: 0x060081DE RID: 33246 RVA: 0x0003DBA1 File Offset: 0x0003BDA1
		public unsafe UnityEvent onReloadStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_onReloadStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_onReloadStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002747 RID: 10055
		// (get) Token: 0x060081DF RID: 33247 RVA: 0x00229AB8 File Offset: 0x00227CB8
		// (set) Token: 0x060081E0 RID: 33248 RVA: 0x0003DBC0 File Offset: 0x0003BDC0
		public unsafe UnityEvent onReloadIndividual
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_onReloadIndividual);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_onReloadIndividual), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002748 RID: 10056
		// (get) Token: 0x060081E1 RID: 33249 RVA: 0x00229AE8 File Offset: 0x00227CE8
		// (set) Token: 0x060081E2 RID: 33250 RVA: 0x0003DBDF File Offset: 0x0003BDDF
		public unsafe UnityEvent onReloadEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_onReloadEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_onReloadEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002749 RID: 10057
		// (get) Token: 0x060081E3 RID: 33251 RVA: 0x00229B18 File Offset: 0x00227D18
		// (set) Token: 0x060081E4 RID: 33252 RVA: 0x0003DBFE File Offset: 0x0003BDFE
		public unsafe UnityEvent onCockStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_onCockStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_onCockStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700274A RID: 10058
		// (get) Token: 0x060081E5 RID: 33253 RVA: 0x00229B48 File Offset: 0x00227D48
		// (set) Token: 0x060081E6 RID: 33254 RVA: 0x0003DC1D File Offset: 0x0003BE1D
		public unsafe IntegerItemInstance weaponItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_weaponItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IntegerItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_weaponItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700274B RID: 10059
		// (get) Token: 0x060081E7 RID: 33255 RVA: 0x00229B78 File Offset: 0x00227D78
		// (set) Token: 0x060081E8 RID: 33256 RVA: 0x0003DC3C File Offset: 0x0003BE3C
		public unsafe bool fovOverridden
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_fovOverridden);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_fovOverridden)) = value;
			}
		}

		// Token: 0x1700274C RID: 10060
		// (get) Token: 0x060081E9 RID: 33257 RVA: 0x00229BA0 File Offset: 0x00227DA0
		// (set) Token: 0x060081EA RID: 33258 RVA: 0x0003DC57 File Offset: 0x0003BE57
		public unsafe float aimVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_aimVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_aimVelocity)) = value;
			}
		}

		// Token: 0x1700274D RID: 10061
		// (get) Token: 0x060081EB RID: 33259 RVA: 0x00229BC8 File Offset: 0x00227DC8
		// (set) Token: 0x060081EC RID: 33260 RVA: 0x0003DC72 File Offset: 0x0003BE72
		public unsafe Coroutine reloadRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_reloadRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_reloadRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700274E RID: 10062
		// (get) Token: 0x060081ED RID: 33261 RVA: 0x00229BF8 File Offset: 0x00227DF8
		// (set) Token: 0x060081EE RID: 33262 RVA: 0x0003DC91 File Offset: 0x0003BE91
		public unsafe bool shotQueued
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_shotQueued);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_shotQueued)) = value;
			}
		}

		// Token: 0x1700274F RID: 10063
		// (get) Token: 0x060081EF RID: 33263 RVA: 0x00229C20 File Offset: 0x00227E20
		// (set) Token: 0x060081F0 RID: 33264 RVA: 0x0003DCAC File Offset: 0x0003BEAC
		public unsafe bool reloadQueued
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_reloadQueued);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_reloadQueued)) = value;
			}
		}

		// Token: 0x17002750 RID: 10064
		// (get) Token: 0x060081F1 RID: 33265 RVA: 0x00229C48 File Offset: 0x00227E48
		// (set) Token: 0x060081F2 RID: 33266 RVA: 0x0003DCC7 File Offset: 0x0003BEC7
		public unsafe float timeSincePrimaryClick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_timeSincePrimaryClick);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_timeSincePrimaryClick)) = value;
			}
		}

		// Token: 0x04005819 RID: 22553
		private static readonly IntPtr NativeFieldInfoPtr_NPC_AIM_DETECTION_RANGE;

		// Token: 0x0400581A RID: 22554
		private static readonly IntPtr NativeFieldInfoPtr__Aim_k__BackingField;

		// Token: 0x0400581B RID: 22555
		private static readonly IntPtr NativeFieldInfoPtr__Accuracy_k__BackingField;

		// Token: 0x0400581C RID: 22556
		private static readonly IntPtr NativeFieldInfoPtr__TimeSinceFire_k__BackingField;

		// Token: 0x0400581D RID: 22557
		private static readonly IntPtr NativeFieldInfoPtr__IsReloading_k__BackingField;

		// Token: 0x0400581E RID: 22558
		private static readonly IntPtr NativeFieldInfoPtr__IsCocked_k__BackingField;

		// Token: 0x0400581F RID: 22559
		private static readonly IntPtr NativeFieldInfoPtr__IsCocking_k__BackingField;

		// Token: 0x04005820 RID: 22560
		private static readonly IntPtr NativeFieldInfoPtr_MagazineSize;

		// Token: 0x04005821 RID: 22561
		private static readonly IntPtr NativeFieldInfoPtr_AimDuration;

		// Token: 0x04005822 RID: 22562
		private static readonly IntPtr NativeFieldInfoPtr_AimFOVReduction;

		// Token: 0x04005823 RID: 22563
		private static readonly IntPtr NativeFieldInfoPtr_FOVChangeDuration;

		// Token: 0x04005824 RID: 22564
		private static readonly IntPtr NativeFieldInfoPtr_FireSound;

		// Token: 0x04005825 RID: 22565
		private static readonly IntPtr NativeFieldInfoPtr_EmptySound;

		// Token: 0x04005826 RID: 22566
		private static readonly IntPtr NativeFieldInfoPtr_FireCooldown;

		// Token: 0x04005827 RID: 22567
		private static readonly IntPtr NativeFieldInfoPtr_FireAnimTriggers;

		// Token: 0x04005828 RID: 22568
		private static readonly IntPtr NativeFieldInfoPtr_AccuracyChangeDuration;

		// Token: 0x04005829 RID: 22569
		private static readonly IntPtr NativeFieldInfoPtr_Range;

		// Token: 0x0400582A RID: 22570
		private static readonly IntPtr NativeFieldInfoPtr_RayRadius;

		// Token: 0x0400582B RID: 22571
		private static readonly IntPtr NativeFieldInfoPtr_MinSpread;

		// Token: 0x0400582C RID: 22572
		private static readonly IntPtr NativeFieldInfoPtr_MaxSpread;

		// Token: 0x0400582D RID: 22573
		private static readonly IntPtr NativeFieldInfoPtr_Damage;

		// Token: 0x0400582E RID: 22574
		private static readonly IntPtr NativeFieldInfoPtr_ImpactForce;

		// Token: 0x0400582F RID: 22575
		private static readonly IntPtr NativeFieldInfoPtr_CanReload;

		// Token: 0x04005830 RID: 22576
		private static readonly IntPtr NativeFieldInfoPtr_IncrementalReload;

		// Token: 0x04005831 RID: 22577
		private static readonly IntPtr NativeFieldInfoPtr_Magazine;

		// Token: 0x04005832 RID: 22578
		private static readonly IntPtr NativeFieldInfoPtr_ReloadStartTime;

		// Token: 0x04005833 RID: 22579
		private static readonly IntPtr NativeFieldInfoPtr_ReloadIndividalTime;

		// Token: 0x04005834 RID: 22580
		private static readonly IntPtr NativeFieldInfoPtr_ReloadEndTime;

		// Token: 0x04005835 RID: 22581
		private static readonly IntPtr NativeFieldInfoPtr_ReloadStartAnimTrigger;

		// Token: 0x04005836 RID: 22582
		private static readonly IntPtr NativeFieldInfoPtr_ReloadIndividualAnimTrigger;

		// Token: 0x04005837 RID: 22583
		private static readonly IntPtr NativeFieldInfoPtr_ReloadEndAnimTrigger;

		// Token: 0x04005838 RID: 22584
		private static readonly IntPtr NativeFieldInfoPtr_ReloadTrash;

		// Token: 0x04005839 RID: 22585
		private static readonly IntPtr NativeFieldInfoPtr_MustBeCocked;

		// Token: 0x0400583A RID: 22586
		private static readonly IntPtr NativeFieldInfoPtr_CockTime;

		// Token: 0x0400583B RID: 22587
		private static readonly IntPtr NativeFieldInfoPtr_CockAnimTrigger;

		// Token: 0x0400583C RID: 22588
		private static readonly IntPtr NativeFieldInfoPtr_TracerSpeed;

		// Token: 0x0400583D RID: 22589
		private static readonly IntPtr NativeFieldInfoPtr_onFire;

		// Token: 0x0400583E RID: 22590
		private static readonly IntPtr NativeFieldInfoPtr_onReloadStart;

		// Token: 0x0400583F RID: 22591
		private static readonly IntPtr NativeFieldInfoPtr_onReloadIndividual;

		// Token: 0x04005840 RID: 22592
		private static readonly IntPtr NativeFieldInfoPtr_onReloadEnd;

		// Token: 0x04005841 RID: 22593
		private static readonly IntPtr NativeFieldInfoPtr_onCockStart;

		// Token: 0x04005842 RID: 22594
		private static readonly IntPtr NativeFieldInfoPtr_weaponItem;

		// Token: 0x04005843 RID: 22595
		private static readonly IntPtr NativeFieldInfoPtr_fovOverridden;

		// Token: 0x04005844 RID: 22596
		private static readonly IntPtr NativeFieldInfoPtr_aimVelocity;

		// Token: 0x04005845 RID: 22597
		private static readonly IntPtr NativeFieldInfoPtr_reloadRoutine;

		// Token: 0x04005846 RID: 22598
		private static readonly IntPtr NativeFieldInfoPtr_shotQueued;

		// Token: 0x04005847 RID: 22599
		private static readonly IntPtr NativeFieldInfoPtr_reloadQueued;

		// Token: 0x04005848 RID: 22600
		private static readonly IntPtr NativeFieldInfoPtr_timeSincePrimaryClick;

		// Token: 0x04005849 RID: 22601
		private static readonly IntPtr NativeMethodInfoPtr_get_Aim_Public_get_Single_0;

		// Token: 0x0400584A RID: 22602
		private static readonly IntPtr NativeMethodInfoPtr_set_Aim_Private_set_Void_Single_0;

		// Token: 0x0400584B RID: 22603
		private static readonly IntPtr NativeMethodInfoPtr_get_Accuracy_Public_get_Single_0;

		// Token: 0x0400584C RID: 22604
		private static readonly IntPtr NativeMethodInfoPtr_set_Accuracy_Private_set_Void_Single_0;

		// Token: 0x0400584D RID: 22605
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSinceFire_Public_get_Single_0;

		// Token: 0x0400584E RID: 22606
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeSinceFire_Public_set_Void_Single_0;

		// Token: 0x0400584F RID: 22607
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReloading_Public_get_Boolean_0;

		// Token: 0x04005850 RID: 22608
		private static readonly IntPtr NativeMethodInfoPtr_set_IsReloading_Private_set_Void_Boolean_0;

		// Token: 0x04005851 RID: 22609
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCocked_Public_get_Boolean_0;

		// Token: 0x04005852 RID: 22610
		private static readonly IntPtr NativeMethodInfoPtr_set_IsCocked_Private_set_Void_Boolean_0;

		// Token: 0x04005853 RID: 22611
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCocking_Public_get_Boolean_0;

		// Token: 0x04005854 RID: 22612
		private static readonly IntPtr NativeMethodInfoPtr_set_IsCocking_Private_set_Void_Boolean_0;

		// Token: 0x04005855 RID: 22613
		private static readonly IntPtr NativeMethodInfoPtr_get_Ammo_Public_get_Int32_0;

		// Token: 0x04005856 RID: 22614
		private static readonly IntPtr NativeMethodInfoPtr_get_aimFov_Private_get_Single_0;

		// Token: 0x04005857 RID: 22615
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04005858 RID: 22616
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x04005859 RID: 22617
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x0400585A RID: 22618
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInput_Private_Void_0;

		// Token: 0x0400585B RID: 22619
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAnim_Private_Void_0;

		// Token: 0x0400585C RID: 22620
		private static readonly IntPtr NativeMethodInfoPtr_CanAim_Private_Boolean_0;

		// Token: 0x0400585D RID: 22621
		private static readonly IntPtr NativeMethodInfoPtr_Fire_Public_Virtual_New_Void_0;

		// Token: 0x0400585E RID: 22622
		private static readonly IntPtr NativeMethodInfoPtr_Reload_Public_Virtual_New_Void_0;

		// Token: 0x0400585F RID: 22623
		private static readonly IntPtr NativeMethodInfoPtr_NotifyIncrementalReload_Protected_Virtual_New_Void_0;

		// Token: 0x04005860 RID: 22624
		private static readonly IntPtr NativeMethodInfoPtr_IsReloadReady_Private_Boolean_Boolean_0;

		// Token: 0x04005861 RID: 22625
		private static readonly IntPtr NativeMethodInfoPtr_GetMagazine_Protected_Virtual_New_Boolean_byref_StorableItemInstance_0;

		// Token: 0x04005862 RID: 22626
		private static readonly IntPtr NativeMethodInfoPtr_CanFire_Private_Boolean_Boolean_0;

		// Token: 0x04005863 RID: 22627
		private static readonly IntPtr NativeMethodInfoPtr_CanCock_Private_Boolean_0;

		// Token: 0x04005864 RID: 22628
		private static readonly IntPtr NativeMethodInfoPtr_Cock_Private_Void_0;

		// Token: 0x04005865 RID: 22629
		private static readonly IntPtr NativeMethodInfoPtr_GetSpread_Private_Single_0;

		// Token: 0x04005866 RID: 22630
		private static readonly IntPtr NativeMethodInfoPtr_CheckAimingAtNPC_Private_Void_0;

		// Token: 0x04005867 RID: 22631
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005868 RID: 22632
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04005869 RID: 22633
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1;

		// Token: 0x02000AE1 RID: 2785
		[ObfuscatedName("ScheduleOne.Equipping.Equippable_RangedWeapon+<<Cock>g__CockRoutine|83_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D51C RID: 54556 RVA: 0x0032D084 File Offset: 0x0032B284
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique()
			{
				Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "<<Cock>g__CockRoutine|83_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr);
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, "<>1__state");
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, "<>2__current");
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, "<>4__this");
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, 100679542);
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, 100679543);
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, 100679544);
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, 100679545);
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, 100679546);
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, 100679547);
			}

			// Token: 0x0600D51D RID: 54557 RVA: 0x0032D164 File Offset: 0x0032B364
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D51E RID: 54558 RVA: 0x0032D1AC File Offset: 0x0032B3AC
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D51F RID: 54559 RVA: 0x0032D1E0 File Offset: 0x0032B3E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245437, XrefRangeEnd = 245448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700420A RID: 16906
			// (get) Token: 0x0600D520 RID: 54560 RVA: 0x0032D21C File Offset: 0x0032B41C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D521 RID: 54561 RVA: 0x0032D25C File Offset: 0x0032B45C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245448, XrefRangeEnd = 245453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700420B RID: 16907
			// (get) Token: 0x0600D522 RID: 54562 RVA: 0x0032D290 File Offset: 0x0032B490
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D523 RID: 54563 RVA: 0x00067B36 File Offset: 0x00065D36
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004207 RID: 16903
			// (get) Token: 0x0600D524 RID: 54564 RVA: 0x0032D2D0 File Offset: 0x0032B4D0
			// (set) Token: 0x0600D525 RID: 54565 RVA: 0x00067B3F File Offset: 0x00065D3F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004208 RID: 16904
			// (get) Token: 0x0600D526 RID: 54566 RVA: 0x0032D2F8 File Offset: 0x0032B4F8
			// (set) Token: 0x0600D527 RID: 54567 RVA: 0x00067B5A File Offset: 0x00065D5A
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004209 RID: 16905
			// (get) Token: 0x0600D528 RID: 54568 RVA: 0x0032D328 File Offset: 0x0032B528
			// (set) Token: 0x0600D529 RID: 54569 RVA: 0x00067B79 File Offset: 0x00065D79
			public unsafe Equippable_RangedWeapon __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable_RangedWeapon>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F5D RID: 36701
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008F5E RID: 36702
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008F5F RID: 36703
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008F60 RID: 36704
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008F61 RID: 36705
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F62 RID: 36706
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008F63 RID: 36707
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008F64 RID: 36708
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F65 RID: 36709
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000AE2 RID: 2786
		[ObfuscatedName("ScheduleOne.Equipping.Equippable_RangedWeapon+<<Reload>g__ReloadRoutine|77_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D52A RID: 54570 RVA: 0x0032D358 File Offset: 0x0032B558
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique()
			{
				Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "<<Reload>g__ReloadRoutine|77_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr);
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr, "<>1__state");
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr, "<>2__current");
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr, "<>4__this");
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeFieldInfoPtr__mag_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr, "<mag>5__2");
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr, 100679548);
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr, 100679549);
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr, 100679550);
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr, 100679551);
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr, 100679552);
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr, 100679553);
			}

			// Token: 0x0600D52B RID: 54571 RVA: 0x0032D44C File Offset: 0x0032B64C
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D52C RID: 54572 RVA: 0x0032D494 File Offset: 0x0032B694
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D52D RID: 54573 RVA: 0x0032D4C8 File Offset: 0x0032B6C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245453, XrefRangeEnd = 245471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004210 RID: 16912
			// (get) Token: 0x0600D52E RID: 54574 RVA: 0x0032D504 File Offset: 0x0032B704
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D52F RID: 54575 RVA: 0x0032D544 File Offset: 0x0032B744
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245471, XrefRangeEnd = 245476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004211 RID: 16913
			// (get) Token: 0x0600D530 RID: 54576 RVA: 0x0032D578 File Offset: 0x0032B778
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D531 RID: 54577 RVA: 0x00067B98 File Offset: 0x00065D98
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700420C RID: 16908
			// (get) Token: 0x0600D532 RID: 54578 RVA: 0x0032D5B8 File Offset: 0x0032B7B8
			// (set) Token: 0x0600D533 RID: 54579 RVA: 0x00067BA1 File Offset: 0x00065DA1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700420D RID: 16909
			// (get) Token: 0x0600D534 RID: 54580 RVA: 0x0032D5E0 File Offset: 0x0032B7E0
			// (set) Token: 0x0600D535 RID: 54581 RVA: 0x00067BBC File Offset: 0x00065DBC
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700420E RID: 16910
			// (get) Token: 0x0600D536 RID: 54582 RVA: 0x0032D610 File Offset: 0x0032B810
			// (set) Token: 0x0600D537 RID: 54583 RVA: 0x00067BDB File Offset: 0x00065DDB
			public unsafe Equippable_RangedWeapon __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable_RangedWeapon>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700420F RID: 16911
			// (get) Token: 0x0600D538 RID: 54584 RVA: 0x0032D640 File Offset: 0x0032B840
			// (set) Token: 0x0600D539 RID: 54585 RVA: 0x00067BFA File Offset: 0x00065DFA
			public unsafe StorableItemInstance _mag_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeFieldInfoPtr__mag_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorableItemInstance>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeFieldInfoPtr__mag_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F66 RID: 36710
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008F67 RID: 36711
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008F68 RID: 36712
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008F69 RID: 36713
			private static readonly IntPtr NativeFieldInfoPtr__mag_5__2;

			// Token: 0x04008F6A RID: 36714
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008F6B RID: 36715
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F6C RID: 36716
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008F6D RID: 36717
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008F6E RID: 36718
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F6F RID: 36719
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000AE3 RID: 2787
		[ObfuscatedName("ScheduleOne.Equipping.Equippable_RangedWeapon+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D53A RID: 54586 RVA: 0x0032D670 File Offset: 0x0032B870
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Equippable_RangedWeapon.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_RangedWeapon.__c>.NativeClassPtr);
				Equippable_RangedWeapon.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon.__c>.NativeClassPtr, "<>9");
				Equippable_RangedWeapon.__c.NativeFieldInfoPtr___9__76_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon.__c>.NativeClassPtr, "<>9__76_0");
				Equippable_RangedWeapon.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.__c>.NativeClassPtr, 100679555);
				Equippable_RangedWeapon.__c.NativeMethodInfoPtr__Fire_b__76_0_Internal_Int32_RaycastHit_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.__c>.NativeClassPtr, 100679556);
			}

			// Token: 0x0600D53B RID: 54587 RVA: 0x0032D6EC File Offset: 0x0032B8EC
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_RangedWeapon.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D53C RID: 54588 RVA: 0x0032D728 File Offset: 0x0032B928
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Fire_b__76_0(RaycastHit a, RaycastHit b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.__c.NativeMethodInfoPtr__Fire_b__76_0_Internal_Int32_RaycastHit_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D53D RID: 54589 RVA: 0x00067C19 File Offset: 0x00065E19
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004212 RID: 16914
			// (get) Token: 0x0600D53E RID: 54590 RVA: 0x0032D780 File Offset: 0x0032B980
			// (set) Token: 0x0600D53F RID: 54591 RVA: 0x00067C22 File Offset: 0x00065E22
			public unsafe static Equippable_RangedWeapon.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Equippable_RangedWeapon.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable_RangedWeapon.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Equippable_RangedWeapon.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004213 RID: 16915
			// (get) Token: 0x0600D540 RID: 54592 RVA: 0x0032D7A8 File Offset: 0x0032B9A8
			// (set) Token: 0x0600D541 RID: 54593 RVA: 0x00067C34 File Offset: 0x00065E34
			public unsafe static Comparison<RaycastHit> __9__76_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Equippable_RangedWeapon.__c.NativeFieldInfoPtr___9__76_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<RaycastHit>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Equippable_RangedWeapon.__c.NativeFieldInfoPtr___9__76_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F70 RID: 36720
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008F71 RID: 36721
			private static readonly IntPtr NativeFieldInfoPtr___9__76_0;

			// Token: 0x04008F72 RID: 36722
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F73 RID: 36723
			private static readonly IntPtr NativeMethodInfoPtr__Fire_b__76_0_Internal_Int32_RaycastHit_RaycastHit_0;
		}
	}
}
