using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Combat;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005C2 RID: 1474
	public class Equippable_MeleeWeapon : Equippable_AvatarViewmodel
	{
		// Token: 0x06008122 RID: 33058 RVA: 0x0022787C File Offset: 0x00225A7C
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_MeleeWeapon()
		{
			Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_MeleeWeapon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr);
			Equippable_MeleeWeapon.NativeFieldInfoPtr__IsAttacking_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "<IsAttacking>k__BackingField");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_ImpactType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "ImpactType");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "Range");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_HitRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "HitRadius");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxLoadTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "MaxLoadTime");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_MinCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "MinCooldown");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "MaxCooldown");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_MinHitDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "MinHitDelay");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxHitDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "MaxHitDelay");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_MinDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "MinDamage");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "MaxDamage");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_MinForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "MinForce");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "MaxForce");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_MinStaminaCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "MinStaminaCost");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxStaminaCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "MaxStaminaCost");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_WhooshSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "WhooshSound");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_WhooshSoundPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "WhooshSoundPitch");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_ImpactSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "ImpactSound");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_SwingAnimationTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "SwingAnimationTrigger");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_load = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "load");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_remainingCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "remainingCooldown");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_hitRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "hitRoutine");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_loadQueued = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "loadQueued");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_clickReleased = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "clickReleased");
			Equippable_MeleeWeapon.NativeMethodInfoPtr_get_IsLoading_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679481);
			Equippable_MeleeWeapon.NativeMethodInfoPtr_get_IsAttacking_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679482);
			Equippable_MeleeWeapon.NativeMethodInfoPtr_set_IsAttacking_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679483);
			Equippable_MeleeWeapon.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679484);
			Equippable_MeleeWeapon.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679485);
			Equippable_MeleeWeapon.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679486);
			Equippable_MeleeWeapon.NativeMethodInfoPtr_UpdateCooldown_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679487);
			Equippable_MeleeWeapon.NativeMethodInfoPtr_UpdateInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679488);
			Equippable_MeleeWeapon.NativeMethodInfoPtr_CanStartLoading_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679489);
			Equippable_MeleeWeapon.NativeMethodInfoPtr_StartLoad_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679490);
			Equippable_MeleeWeapon.NativeMethodInfoPtr_Release_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679491);
			Equippable_MeleeWeapon.NativeMethodInfoPtr_Hit_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679492);
			Equippable_MeleeWeapon.NativeMethodInfoPtr_ExecuteHit_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679493);
			Equippable_MeleeWeapon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679494);
		}

		// Token: 0x1700271B RID: 10011
		// (get) Token: 0x06008123 RID: 33059 RVA: 0x00227BA4 File Offset: 0x00225DA4
		public unsafe bool IsLoading
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.NativeMethodInfoPtr_get_IsLoading_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700271C RID: 10012
		// (get) Token: 0x06008124 RID: 33060 RVA: 0x00227BE0 File Offset: 0x00225DE0
		// (set) Token: 0x06008125 RID: 33061 RVA: 0x00227C1C File Offset: 0x00225E1C
		public unsafe bool IsAttacking
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.NativeMethodInfoPtr_get_IsAttacking_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.NativeMethodInfoPtr_set_IsAttacking_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008126 RID: 33062 RVA: 0x00227C5C File Offset: 0x00225E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245179, XrefRangeEnd = 245187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_MeleeWeapon.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008127 RID: 33063 RVA: 0x00227C98 File Offset: 0x00225E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245187, XrefRangeEnd = 245188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_MeleeWeapon.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008128 RID: 33064 RVA: 0x00227CE8 File Offset: 0x00225EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245188, XrefRangeEnd = 245197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_MeleeWeapon.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008129 RID: 33065 RVA: 0x00227D24 File Offset: 0x00225F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245197, XrefRangeEnd = 245199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCooldown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.NativeMethodInfoPtr_UpdateCooldown_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600812A RID: 33066 RVA: 0x00227D58 File Offset: 0x00225F58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 245207, RefRangeEnd = 245208, XrefRangeStart = 245199, XrefRangeEnd = 245207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.NativeMethodInfoPtr_UpdateInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600812B RID: 33067 RVA: 0x00227D8C File Offset: 0x00225F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245208, XrefRangeEnd = 245212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanStartLoading()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.NativeMethodInfoPtr_CanStartLoading_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600812C RID: 33068 RVA: 0x00227DC8 File Offset: 0x00225FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245212, XrefRangeEnd = 245231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartLoad()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.NativeMethodInfoPtr_StartLoad_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600812D RID: 33069 RVA: 0x00227DFC File Offset: 0x00225FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245231, XrefRangeEnd = 245278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.NativeMethodInfoPtr_Release_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600812E RID: 33070 RVA: 0x00227E30 File Offset: 0x00226030
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 245293, RefRangeEnd = 245294, XrefRangeStart = 245278, XrefRangeEnd = 245293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hit(float power)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref power;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.NativeMethodInfoPtr_Hit_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600812F RID: 33071 RVA: 0x00227E70 File Offset: 0x00226070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245294, XrefRangeEnd = 245369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteHit(float power)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref power;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.NativeMethodInfoPtr_ExecuteHit_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008130 RID: 33072 RVA: 0x00227EB0 File Offset: 0x002260B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245369, XrefRangeEnd = 245370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_MeleeWeapon() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008131 RID: 33073 RVA: 0x0003D493 File Offset: 0x0003B693
		public Equippable_MeleeWeapon(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002703 RID: 9987
		// (get) Token: 0x06008132 RID: 33074 RVA: 0x00227EEC File Offset: 0x002260EC
		// (set) Token: 0x06008133 RID: 33075 RVA: 0x0003D49C File Offset: 0x0003B69C
		public unsafe bool _IsAttacking_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr__IsAttacking_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr__IsAttacking_k__BackingField)) = value;
			}
		}

		// Token: 0x17002704 RID: 9988
		// (get) Token: 0x06008134 RID: 33076 RVA: 0x00227F14 File Offset: 0x00226114
		// (set) Token: 0x06008135 RID: 33077 RVA: 0x0003D4B7 File Offset: 0x0003B6B7
		public unsafe EImpactType ImpactType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_ImpactType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_ImpactType)) = value;
			}
		}

		// Token: 0x17002705 RID: 9989
		// (get) Token: 0x06008136 RID: 33078 RVA: 0x00227F3C File Offset: 0x0022613C
		// (set) Token: 0x06008137 RID: 33079 RVA: 0x0003D4D2 File Offset: 0x0003B6D2
		public unsafe float Range
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_Range);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_Range)) = value;
			}
		}

		// Token: 0x17002706 RID: 9990
		// (get) Token: 0x06008138 RID: 33080 RVA: 0x00227F64 File Offset: 0x00226164
		// (set) Token: 0x06008139 RID: 33081 RVA: 0x0003D4ED File Offset: 0x0003B6ED
		public unsafe float HitRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_HitRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_HitRadius)) = value;
			}
		}

		// Token: 0x17002707 RID: 9991
		// (get) Token: 0x0600813A RID: 33082 RVA: 0x00227F8C File Offset: 0x0022618C
		// (set) Token: 0x0600813B RID: 33083 RVA: 0x0003D508 File Offset: 0x0003B708
		public unsafe float MaxLoadTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxLoadTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxLoadTime)) = value;
			}
		}

		// Token: 0x17002708 RID: 9992
		// (get) Token: 0x0600813C RID: 33084 RVA: 0x00227FB4 File Offset: 0x002261B4
		// (set) Token: 0x0600813D RID: 33085 RVA: 0x0003D523 File Offset: 0x0003B723
		public unsafe float MinCooldown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MinCooldown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MinCooldown)) = value;
			}
		}

		// Token: 0x17002709 RID: 9993
		// (get) Token: 0x0600813E RID: 33086 RVA: 0x00227FDC File Offset: 0x002261DC
		// (set) Token: 0x0600813F RID: 33087 RVA: 0x0003D53E File Offset: 0x0003B73E
		public unsafe float MaxCooldown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxCooldown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxCooldown)) = value;
			}
		}

		// Token: 0x1700270A RID: 9994
		// (get) Token: 0x06008140 RID: 33088 RVA: 0x00228004 File Offset: 0x00226204
		// (set) Token: 0x06008141 RID: 33089 RVA: 0x0003D559 File Offset: 0x0003B759
		public unsafe float MinHitDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MinHitDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MinHitDelay)) = value;
			}
		}

		// Token: 0x1700270B RID: 9995
		// (get) Token: 0x06008142 RID: 33090 RVA: 0x0022802C File Offset: 0x0022622C
		// (set) Token: 0x06008143 RID: 33091 RVA: 0x0003D574 File Offset: 0x0003B774
		public unsafe float MaxHitDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxHitDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxHitDelay)) = value;
			}
		}

		// Token: 0x1700270C RID: 9996
		// (get) Token: 0x06008144 RID: 33092 RVA: 0x00228054 File Offset: 0x00226254
		// (set) Token: 0x06008145 RID: 33093 RVA: 0x0003D58F File Offset: 0x0003B78F
		public unsafe float MinDamage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MinDamage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MinDamage)) = value;
			}
		}

		// Token: 0x1700270D RID: 9997
		// (get) Token: 0x06008146 RID: 33094 RVA: 0x0022807C File Offset: 0x0022627C
		// (set) Token: 0x06008147 RID: 33095 RVA: 0x0003D5AA File Offset: 0x0003B7AA
		public unsafe float MaxDamage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxDamage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxDamage)) = value;
			}
		}

		// Token: 0x1700270E RID: 9998
		// (get) Token: 0x06008148 RID: 33096 RVA: 0x002280A4 File Offset: 0x002262A4
		// (set) Token: 0x06008149 RID: 33097 RVA: 0x0003D5C5 File Offset: 0x0003B7C5
		public unsafe float MinForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MinForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MinForce)) = value;
			}
		}

		// Token: 0x1700270F RID: 9999
		// (get) Token: 0x0600814A RID: 33098 RVA: 0x002280CC File Offset: 0x002262CC
		// (set) Token: 0x0600814B RID: 33099 RVA: 0x0003D5E0 File Offset: 0x0003B7E0
		public unsafe float MaxForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxForce)) = value;
			}
		}

		// Token: 0x17002710 RID: 10000
		// (get) Token: 0x0600814C RID: 33100 RVA: 0x002280F4 File Offset: 0x002262F4
		// (set) Token: 0x0600814D RID: 33101 RVA: 0x0003D5FB File Offset: 0x0003B7FB
		public unsafe float MinStaminaCost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MinStaminaCost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MinStaminaCost)) = value;
			}
		}

		// Token: 0x17002711 RID: 10001
		// (get) Token: 0x0600814E RID: 33102 RVA: 0x0022811C File Offset: 0x0022631C
		// (set) Token: 0x0600814F RID: 33103 RVA: 0x0003D616 File Offset: 0x0003B816
		public unsafe float MaxStaminaCost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxStaminaCost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxStaminaCost)) = value;
			}
		}

		// Token: 0x17002712 RID: 10002
		// (get) Token: 0x06008150 RID: 33104 RVA: 0x00228144 File Offset: 0x00226344
		// (set) Token: 0x06008151 RID: 33105 RVA: 0x0003D631 File Offset: 0x0003B831
		public unsafe AudioSourceController WhooshSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_WhooshSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_WhooshSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002713 RID: 10003
		// (get) Token: 0x06008152 RID: 33106 RVA: 0x00228174 File Offset: 0x00226374
		// (set) Token: 0x06008153 RID: 33107 RVA: 0x0003D650 File Offset: 0x0003B850
		public unsafe float WhooshSoundPitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_WhooshSoundPitch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_WhooshSoundPitch)) = value;
			}
		}

		// Token: 0x17002714 RID: 10004
		// (get) Token: 0x06008154 RID: 33108 RVA: 0x0022819C File Offset: 0x0022639C
		// (set) Token: 0x06008155 RID: 33109 RVA: 0x0003D66B File Offset: 0x0003B86B
		public unsafe AudioSourceController ImpactSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_ImpactSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_ImpactSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002715 RID: 10005
		// (get) Token: 0x06008156 RID: 33110 RVA: 0x002281CC File Offset: 0x002263CC
		// (set) Token: 0x06008157 RID: 33111 RVA: 0x0003D68A File Offset: 0x0003B88A
		public unsafe string SwingAnimationTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_SwingAnimationTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_SwingAnimationTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002716 RID: 10006
		// (get) Token: 0x06008158 RID: 33112 RVA: 0x002281F4 File Offset: 0x002263F4
		// (set) Token: 0x06008159 RID: 33113 RVA: 0x0003D6A9 File Offset: 0x0003B8A9
		public unsafe float load
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_load);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_load)) = value;
			}
		}

		// Token: 0x17002717 RID: 10007
		// (get) Token: 0x0600815A RID: 33114 RVA: 0x0022821C File Offset: 0x0022641C
		// (set) Token: 0x0600815B RID: 33115 RVA: 0x0003D6C4 File Offset: 0x0003B8C4
		public unsafe float remainingCooldown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_remainingCooldown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_remainingCooldown)) = value;
			}
		}

		// Token: 0x17002718 RID: 10008
		// (get) Token: 0x0600815C RID: 33116 RVA: 0x00228244 File Offset: 0x00226444
		// (set) Token: 0x0600815D RID: 33117 RVA: 0x0003D6DF File Offset: 0x0003B8DF
		public unsafe Coroutine hitRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_hitRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_hitRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002719 RID: 10009
		// (get) Token: 0x0600815E RID: 33118 RVA: 0x00228274 File Offset: 0x00226474
		// (set) Token: 0x0600815F RID: 33119 RVA: 0x0003D6FE File Offset: 0x0003B8FE
		public unsafe bool loadQueued
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_loadQueued);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_loadQueued)) = value;
			}
		}

		// Token: 0x1700271A RID: 10010
		// (get) Token: 0x06008160 RID: 33120 RVA: 0x0022829C File Offset: 0x0022649C
		// (set) Token: 0x06008161 RID: 33121 RVA: 0x0003D719 File Offset: 0x0003B919
		public unsafe bool clickReleased
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_clickReleased);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_clickReleased)) = value;
			}
		}

		// Token: 0x040057EA RID: 22506
		private static readonly IntPtr NativeFieldInfoPtr__IsAttacking_k__BackingField;

		// Token: 0x040057EB RID: 22507
		private static readonly IntPtr NativeFieldInfoPtr_ImpactType;

		// Token: 0x040057EC RID: 22508
		private static readonly IntPtr NativeFieldInfoPtr_Range;

		// Token: 0x040057ED RID: 22509
		private static readonly IntPtr NativeFieldInfoPtr_HitRadius;

		// Token: 0x040057EE RID: 22510
		private static readonly IntPtr NativeFieldInfoPtr_MaxLoadTime;

		// Token: 0x040057EF RID: 22511
		private static readonly IntPtr NativeFieldInfoPtr_MinCooldown;

		// Token: 0x040057F0 RID: 22512
		private static readonly IntPtr NativeFieldInfoPtr_MaxCooldown;

		// Token: 0x040057F1 RID: 22513
		private static readonly IntPtr NativeFieldInfoPtr_MinHitDelay;

		// Token: 0x040057F2 RID: 22514
		private static readonly IntPtr NativeFieldInfoPtr_MaxHitDelay;

		// Token: 0x040057F3 RID: 22515
		private static readonly IntPtr NativeFieldInfoPtr_MinDamage;

		// Token: 0x040057F4 RID: 22516
		private static readonly IntPtr NativeFieldInfoPtr_MaxDamage;

		// Token: 0x040057F5 RID: 22517
		private static readonly IntPtr NativeFieldInfoPtr_MinForce;

		// Token: 0x040057F6 RID: 22518
		private static readonly IntPtr NativeFieldInfoPtr_MaxForce;

		// Token: 0x040057F7 RID: 22519
		private static readonly IntPtr NativeFieldInfoPtr_MinStaminaCost;

		// Token: 0x040057F8 RID: 22520
		private static readonly IntPtr NativeFieldInfoPtr_MaxStaminaCost;

		// Token: 0x040057F9 RID: 22521
		private static readonly IntPtr NativeFieldInfoPtr_WhooshSound;

		// Token: 0x040057FA RID: 22522
		private static readonly IntPtr NativeFieldInfoPtr_WhooshSoundPitch;

		// Token: 0x040057FB RID: 22523
		private static readonly IntPtr NativeFieldInfoPtr_ImpactSound;

		// Token: 0x040057FC RID: 22524
		private static readonly IntPtr NativeFieldInfoPtr_SwingAnimationTrigger;

		// Token: 0x040057FD RID: 22525
		private static readonly IntPtr NativeFieldInfoPtr_load;

		// Token: 0x040057FE RID: 22526
		private static readonly IntPtr NativeFieldInfoPtr_remainingCooldown;

		// Token: 0x040057FF RID: 22527
		private static readonly IntPtr NativeFieldInfoPtr_hitRoutine;

		// Token: 0x04005800 RID: 22528
		private static readonly IntPtr NativeFieldInfoPtr_loadQueued;

		// Token: 0x04005801 RID: 22529
		private static readonly IntPtr NativeFieldInfoPtr_clickReleased;

		// Token: 0x04005802 RID: 22530
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLoading_Public_get_Boolean_0;

		// Token: 0x04005803 RID: 22531
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAttacking_Public_get_Boolean_0;

		// Token: 0x04005804 RID: 22532
		private static readonly IntPtr NativeMethodInfoPtr_set_IsAttacking_Private_set_Void_Boolean_0;

		// Token: 0x04005805 RID: 22533
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04005806 RID: 22534
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04005807 RID: 22535
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x04005808 RID: 22536
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCooldown_Private_Void_0;

		// Token: 0x04005809 RID: 22537
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInput_Private_Void_0;

		// Token: 0x0400580A RID: 22538
		private static readonly IntPtr NativeMethodInfoPtr_CanStartLoading_Private_Boolean_0;

		// Token: 0x0400580B RID: 22539
		private static readonly IntPtr NativeMethodInfoPtr_StartLoad_Private_Void_0;

		// Token: 0x0400580C RID: 22540
		private static readonly IntPtr NativeMethodInfoPtr_Release_Private_Void_0;

		// Token: 0x0400580D RID: 22541
		private static readonly IntPtr NativeMethodInfoPtr_Hit_Private_Void_Single_0;

		// Token: 0x0400580E RID: 22542
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteHit_Private_Void_Single_0;

		// Token: 0x0400580F RID: 22543
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AE0 RID: 2784
		[ObfuscatedName("ScheduleOne.Equipping.Equippable_MeleeWeapon+<>c__DisplayClass37_0")]
		public sealed class __c__DisplayClass37_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D514 RID: 54548 RVA: 0x0032CF34 File Offset: 0x0032B134
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass37_0()
			{
				Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "<>c__DisplayClass37_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0>.NativeClassPtr);
				Equippable_MeleeWeapon.__c__DisplayClass37_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0>.NativeClassPtr, "<>4__this");
				Equippable_MeleeWeapon.__c__DisplayClass37_0.NativeFieldInfoPtr_power = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0>.NativeClassPtr, "power");
				Equippable_MeleeWeapon.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0>.NativeClassPtr, 100679495);
				Equippable_MeleeWeapon.__c__DisplayClass37_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0>.NativeClassPtr, 100679496);
			}

			// Token: 0x0600D515 RID: 54549 RVA: 0x0032CFB0 File Offset: 0x0032B1B0
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass37_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D516 RID: 54550 RVA: 0x0032CFEC File Offset: 0x0032B1EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245174, XrefRangeEnd = 245179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.__c__DisplayClass37_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D517 RID: 54551 RVA: 0x00067AF3 File Offset: 0x00065CF3
			public __c__DisplayClass37_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004205 RID: 16901
			// (get) Token: 0x0600D518 RID: 54552 RVA: 0x0032D02C File Offset: 0x0032B22C
			// (set) Token: 0x0600D519 RID: 54553 RVA: 0x00067AFC File Offset: 0x00065CFC
			public unsafe Equippable_MeleeWeapon __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.__c__DisplayClass37_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable_MeleeWeapon>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.__c__DisplayClass37_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004206 RID: 16902
			// (get) Token: 0x0600D51A RID: 54554 RVA: 0x0032D05C File Offset: 0x0032B25C
			// (set) Token: 0x0600D51B RID: 54555 RVA: 0x00067B1B File Offset: 0x00065D1B
			public unsafe float power
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.__c__DisplayClass37_0.NativeFieldInfoPtr_power);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.__c__DisplayClass37_0.NativeFieldInfoPtr_power)) = value;
				}
			}

			// Token: 0x04008F59 RID: 36697
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008F5A RID: 36698
			private static readonly IntPtr NativeFieldInfoPtr_power;

			// Token: 0x04008F5B RID: 36699
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F5C RID: 36700
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C65 RID: 3173
			[ObfuscatedName("ScheduleOne.Equipping.Equippable_MeleeWeapon+<>c__DisplayClass37_0+<<Hit>g__HitRoutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E465 RID: 58469 RVA: 0x00358FE8 File Offset: 0x003571E8
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0>.NativeClassPtr, "<<Hit>g__HitRoutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679497);
					Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679498);
					Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679499);
					Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679500);
					Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679501);
					Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679502);
				}

				// Token: 0x0600E466 RID: 58470 RVA: 0x003590C8 File Offset: 0x003572C8
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E467 RID: 58471 RVA: 0x00359110 File Offset: 0x00357310
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E468 RID: 58472 RVA: 0x00359144 File Offset: 0x00357344
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245156, XrefRangeEnd = 245169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170046F0 RID: 18160
				// (get) Token: 0x0600E469 RID: 58473 RVA: 0x00359180 File Offset: 0x00357380
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E46A RID: 58474 RVA: 0x003591C0 File Offset: 0x003573C0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245169, XrefRangeEnd = 245174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170046F1 RID: 18161
				// (get) Token: 0x0600E46B RID: 58475 RVA: 0x003591F4 File Offset: 0x003573F4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E46C RID: 58476 RVA: 0x0006F5B0 File Offset: 0x0006D7B0
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170046ED RID: 18157
				// (get) Token: 0x0600E46D RID: 58477 RVA: 0x00359234 File Offset: 0x00357434
				// (set) Token: 0x0600E46E RID: 58478 RVA: 0x0006F5B9 File Offset: 0x0006D7B9
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170046EE RID: 18158
				// (get) Token: 0x0600E46F RID: 58479 RVA: 0x0035925C File Offset: 0x0035745C
				// (set) Token: 0x0600E470 RID: 58480 RVA: 0x0006F5D4 File Offset: 0x0006D7D4
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046EF RID: 18159
				// (get) Token: 0x0600E471 RID: 58481 RVA: 0x0035928C File Offset: 0x0035748C
				// (set) Token: 0x0600E472 RID: 58482 RVA: 0x0006F5F3 File Offset: 0x0006D7F3
				public unsafe Equippable_MeleeWeapon.__c__DisplayClass37_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable_MeleeWeapon.__c__DisplayClass37_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040098C8 RID: 39112
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040098C9 RID: 39113
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040098CA RID: 39114
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040098CB RID: 39115
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040098CC RID: 39116
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040098CD RID: 39117
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040098CE RID: 39118
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040098CF RID: 39119
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040098D0 RID: 39120
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
