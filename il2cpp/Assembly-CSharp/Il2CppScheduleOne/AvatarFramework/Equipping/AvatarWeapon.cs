using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x02000602 RID: 1538
	public class AvatarWeapon : AvatarEquippable
	{
		// Token: 0x0600879C RID: 34716 RVA: 0x0023C6D0 File Offset: 0x0023A8D0
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarWeapon()
		{
			Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Equipping", "AvatarWeapon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr);
			AvatarWeapon.NativeFieldInfoPtr_MinUseRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, "MinUseRange");
			AvatarWeapon.NativeFieldInfoPtr_MaxUseRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, "MaxUseRange");
			AvatarWeapon.NativeFieldInfoPtr_CooldownDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, "CooldownDuration");
			AvatarWeapon.NativeFieldInfoPtr_EquipClips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, "EquipClips");
			AvatarWeapon.NativeFieldInfoPtr_EquipSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, "EquipSound");
			AvatarWeapon.NativeFieldInfoPtr__LastUseTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, "<LastUseTime>k__BackingField");
			AvatarWeapon.NativeFieldInfoPtr_onSuccessfulHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, "onSuccessfulHit");
			AvatarWeapon.NativeMethodInfoPtr_get_LastUseTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, 100680214);
			AvatarWeapon.NativeMethodInfoPtr_set_LastUseTime_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, 100680215);
			AvatarWeapon.NativeMethodInfoPtr_Equip_Public_Virtual_Void_Avatar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, 100680216);
			AvatarWeapon.NativeMethodInfoPtr_Attack_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, 100680217);
			AvatarWeapon.NativeMethodInfoPtr_IsReadyToAttack_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, 100680218);
			AvatarWeapon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, 100680219);
		}

		// Token: 0x17002943 RID: 10563
		// (get) Token: 0x0600879D RID: 34717 RVA: 0x0023C804 File Offset: 0x0023AA04
		// (set) Token: 0x0600879E RID: 34718 RVA: 0x0023C840 File Offset: 0x0023AA40
		public unsafe float LastUseTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarWeapon.NativeMethodInfoPtr_get_LastUseTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarWeapon.NativeMethodInfoPtr_set_LastUseTime_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600879F RID: 34719 RVA: 0x0023C880 File Offset: 0x0023AA80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251905, XrefRangeEnd = 251912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(Avatar _avatar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_avatar);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarWeapon.NativeMethodInfoPtr_Equip_Public_Virtual_Void_Avatar_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060087A0 RID: 34720 RVA: 0x0023C8D0 File Offset: 0x0023AAD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251912, XrefRangeEnd = 251913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Attack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarWeapon.NativeMethodInfoPtr_Attack_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060087A1 RID: 34721 RVA: 0x0023C90C File Offset: 0x0023AB0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251913, XrefRangeEnd = 251914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsReadyToAttack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarWeapon.NativeMethodInfoPtr_IsReadyToAttack_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060087A2 RID: 34722 RVA: 0x0023C954 File Offset: 0x0023AB54
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 251922, RefRangeEnd = 251926, XrefRangeStart = 251914, XrefRangeEnd = 251922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarWeapon() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarWeapon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060087A3 RID: 34723 RVA: 0x0004095E File Offset: 0x0003EB5E
		public AvatarWeapon(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700293C RID: 10556
		// (get) Token: 0x060087A4 RID: 34724 RVA: 0x0023C990 File Offset: 0x0023AB90
		// (set) Token: 0x060087A5 RID: 34725 RVA: 0x00040967 File Offset: 0x0003EB67
		public unsafe float MinUseRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_MinUseRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_MinUseRange)) = value;
			}
		}

		// Token: 0x1700293D RID: 10557
		// (get) Token: 0x060087A6 RID: 34726 RVA: 0x0023C9B8 File Offset: 0x0023ABB8
		// (set) Token: 0x060087A7 RID: 34727 RVA: 0x00040982 File Offset: 0x0003EB82
		public unsafe float MaxUseRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_MaxUseRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_MaxUseRange)) = value;
			}
		}

		// Token: 0x1700293E RID: 10558
		// (get) Token: 0x060087A8 RID: 34728 RVA: 0x0023C9E0 File Offset: 0x0023ABE0
		// (set) Token: 0x060087A9 RID: 34729 RVA: 0x0004099D File Offset: 0x0003EB9D
		public unsafe float CooldownDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_CooldownDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_CooldownDuration)) = value;
			}
		}

		// Token: 0x1700293F RID: 10559
		// (get) Token: 0x060087AA RID: 34730 RVA: 0x0023CA08 File Offset: 0x0023AC08
		// (set) Token: 0x060087AB RID: 34731 RVA: 0x000409B8 File Offset: 0x0003EBB8
		public unsafe Il2CppReferenceArray<AudioClip> EquipClips
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_EquipClips);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_EquipClips), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002940 RID: 10560
		// (get) Token: 0x060087AC RID: 34732 RVA: 0x0023CA38 File Offset: 0x0023AC38
		// (set) Token: 0x060087AD RID: 34733 RVA: 0x000409D7 File Offset: 0x0003EBD7
		public unsafe AudioSourceController EquipSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_EquipSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_EquipSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002941 RID: 10561
		// (get) Token: 0x060087AE RID: 34734 RVA: 0x0023CA68 File Offset: 0x0023AC68
		// (set) Token: 0x060087AF RID: 34735 RVA: 0x000409F6 File Offset: 0x0003EBF6
		public unsafe float _LastUseTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr__LastUseTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr__LastUseTime_k__BackingField)) = value;
			}
		}

		// Token: 0x17002942 RID: 10562
		// (get) Token: 0x060087B0 RID: 34736 RVA: 0x0023CA90 File Offset: 0x0023AC90
		// (set) Token: 0x060087B1 RID: 34737 RVA: 0x00040A11 File Offset: 0x0003EC11
		public unsafe UnityEvent onSuccessfulHit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_onSuccessfulHit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_onSuccessfulHit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005C3A RID: 23610
		private static readonly IntPtr NativeFieldInfoPtr_MinUseRange;

		// Token: 0x04005C3B RID: 23611
		private static readonly IntPtr NativeFieldInfoPtr_MaxUseRange;

		// Token: 0x04005C3C RID: 23612
		private static readonly IntPtr NativeFieldInfoPtr_CooldownDuration;

		// Token: 0x04005C3D RID: 23613
		private static readonly IntPtr NativeFieldInfoPtr_EquipClips;

		// Token: 0x04005C3E RID: 23614
		private static readonly IntPtr NativeFieldInfoPtr_EquipSound;

		// Token: 0x04005C3F RID: 23615
		private static readonly IntPtr NativeFieldInfoPtr__LastUseTime_k__BackingField;

		// Token: 0x04005C40 RID: 23616
		private static readonly IntPtr NativeFieldInfoPtr_onSuccessfulHit;

		// Token: 0x04005C41 RID: 23617
		private static readonly IntPtr NativeMethodInfoPtr_get_LastUseTime_Public_get_Single_0;

		// Token: 0x04005C42 RID: 23618
		private static readonly IntPtr NativeMethodInfoPtr_set_LastUseTime_Private_set_Void_Single_0;

		// Token: 0x04005C43 RID: 23619
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_Avatar_0;

		// Token: 0x04005C44 RID: 23620
		private static readonly IntPtr NativeMethodInfoPtr_Attack_Public_Virtual_New_Void_0;

		// Token: 0x04005C45 RID: 23621
		private static readonly IntPtr NativeMethodInfoPtr_IsReadyToAttack_Public_Virtual_New_Boolean_0;

		// Token: 0x04005C46 RID: 23622
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
