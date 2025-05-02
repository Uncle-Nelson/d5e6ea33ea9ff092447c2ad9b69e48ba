using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x02000601 RID: 1537
	public class AvatarRangedWeapon : AvatarWeapon
	{
		// Token: 0x06008765 RID: 34661 RVA: 0x0023BDC8 File Offset: 0x00239FC8
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarRangedWeapon()
		{
			Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Equipping", "AvatarRangedWeapon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr);
			AvatarRangedWeapon.NativeFieldInfoPtr_RaycastLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "RaycastLayers");
			AvatarRangedWeapon.NativeFieldInfoPtr_MagazineSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "MagazineSize");
			AvatarRangedWeapon.NativeFieldInfoPtr_ReloadTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "ReloadTime");
			AvatarRangedWeapon.NativeFieldInfoPtr_MaxFireRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "MaxFireRate");
			AvatarRangedWeapon.NativeFieldInfoPtr_CanShootWhileMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "CanShootWhileMoving");
			AvatarRangedWeapon.NativeFieldInfoPtr_EquipTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "EquipTime");
			AvatarRangedWeapon.NativeFieldInfoPtr_RaiseTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "RaiseTime");
			AvatarRangedWeapon.NativeFieldInfoPtr_Damage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "Damage");
			AvatarRangedWeapon.NativeFieldInfoPtr_HitChange_MinRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "HitChange_MinRange");
			AvatarRangedWeapon.NativeFieldInfoPtr_HitChange_MaxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "HitChange_MaxRange");
			AvatarRangedWeapon.NativeFieldInfoPtr_MuzzlePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "MuzzlePoint");
			AvatarRangedWeapon.NativeFieldInfoPtr_FireSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "FireSound");
			AvatarRangedWeapon.NativeFieldInfoPtr_LoweredAnimationTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "LoweredAnimationTrigger");
			AvatarRangedWeapon.NativeFieldInfoPtr_RaisedAnimationTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "RaisedAnimationTrigger");
			AvatarRangedWeapon.NativeFieldInfoPtr_RecoilAnimationTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "RecoilAnimationTrigger");
			AvatarRangedWeapon.NativeFieldInfoPtr__IsRaised_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "<IsRaised>k__BackingField");
			AvatarRangedWeapon.NativeFieldInfoPtr_isReloading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "isReloading");
			AvatarRangedWeapon.NativeFieldInfoPtr_timeEquipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "timeEquipped");
			AvatarRangedWeapon.NativeFieldInfoPtr_timeRaised = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "timeRaised");
			AvatarRangedWeapon.NativeFieldInfoPtr_timeSinceLastShot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "timeSinceLastShot");
			AvatarRangedWeapon.NativeFieldInfoPtr_currentAmmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "currentAmmo");
			AvatarRangedWeapon.NativeMethodInfoPtr_get_IsRaised_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, 100680196);
			AvatarRangedWeapon.NativeMethodInfoPtr_set_IsRaised_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, 100680197);
			AvatarRangedWeapon.NativeMethodInfoPtr_Equip_Public_Virtual_Void_Avatar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, 100680198);
			AvatarRangedWeapon.NativeMethodInfoPtr_SetIsRaised_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, 100680199);
			AvatarRangedWeapon.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, 100680200);
			AvatarRangedWeapon.NativeMethodInfoPtr_ReceiveMessage_Public_Virtual_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, 100680201);
			AvatarRangedWeapon.NativeMethodInfoPtr_CanShoot_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, 100680202);
			AvatarRangedWeapon.NativeMethodInfoPtr_Shoot_Public_Virtual_New_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, 100680203);
			AvatarRangedWeapon.NativeMethodInfoPtr_Reload_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, 100680204);
			AvatarRangedWeapon.NativeMethodInfoPtr_IsPlayerInLoS_Public_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, 100680205);
			AvatarRangedWeapon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, 100680206);
		}

		// Token: 0x1700293B RID: 10555
		// (get) Token: 0x06008766 RID: 34662 RVA: 0x0023C078 File Offset: 0x0023A278
		// (set) Token: 0x06008767 RID: 34663 RVA: 0x0023C0B4 File Offset: 0x0023A2B4
		public unsafe bool IsRaised
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon.NativeMethodInfoPtr_get_IsRaised_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon.NativeMethodInfoPtr_set_IsRaised_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008768 RID: 34664 RVA: 0x0023C0F4 File Offset: 0x0023A2F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251805, XrefRangeEnd = 251812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(Avatar _avatar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_avatar);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarRangedWeapon.NativeMethodInfoPtr_Equip_Public_Virtual_Void_Avatar_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008769 RID: 34665 RVA: 0x0023C144 File Offset: 0x0023A344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251812, XrefRangeEnd = 251816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetIsRaised(bool raised)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref raised;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarRangedWeapon.NativeMethodInfoPtr_SetIsRaised_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600876A RID: 34666 RVA: 0x0023C190 File Offset: 0x0023A390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251816, XrefRangeEnd = 251819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600876B RID: 34667 RVA: 0x0023C1C4 File Offset: 0x0023A3C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251819, XrefRangeEnd = 251831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ReceiveMessage(string message, Il2CppSystem.Object data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarRangedWeapon.NativeMethodInfoPtr_ReceiveMessage_Public_Virtual_Void_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600876C RID: 34668 RVA: 0x0023C224 File Offset: 0x0023A424
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 251831, RefRangeEnd = 251832, XrefRangeStart = 251831, XrefRangeEnd = 251831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanShoot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon.NativeMethodInfoPtr_CanShoot_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600876D RID: 34669 RVA: 0x0023C260 File Offset: 0x0023A460
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 251851, RefRangeEnd = 251853, XrefRangeStart = 251832, XrefRangeEnd = 251851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Shoot(Vector3 endPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref endPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarRangedWeapon.NativeMethodInfoPtr_Shoot_Public_Virtual_New_Void_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600876E RID: 34670 RVA: 0x0023C2AC File Offset: 0x0023A4AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251853, XrefRangeEnd = 251858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Reload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon.NativeMethodInfoPtr_Reload_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600876F RID: 34671 RVA: 0x0023C2EC File Offset: 0x0023A4EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 251903, RefRangeEnd = 251904, XrefRangeStart = 251858, XrefRangeEnd = 251903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPlayerInLoS(Player target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon.NativeMethodInfoPtr_IsPlayerInLoS_Public_Boolean_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008770 RID: 34672 RVA: 0x0023C33C File Offset: 0x0023A53C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251904, XrefRangeEnd = 251905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarRangedWeapon() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008771 RID: 34673 RVA: 0x00040713 File Offset: 0x0003E913
		public AvatarRangedWeapon(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002926 RID: 10534
		// (get) Token: 0x06008772 RID: 34674 RVA: 0x0023C378 File Offset: 0x0023A578
		// (set) Token: 0x06008773 RID: 34675 RVA: 0x0004071C File Offset: 0x0003E91C
		public unsafe static Il2CppStringArray RaycastLayers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AvatarRangedWeapon.NativeFieldInfoPtr_RaycastLayers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarRangedWeapon.NativeFieldInfoPtr_RaycastLayers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002927 RID: 10535
		// (get) Token: 0x06008774 RID: 34676 RVA: 0x0023C3A0 File Offset: 0x0023A5A0
		// (set) Token: 0x06008775 RID: 34677 RVA: 0x0004072E File Offset: 0x0003E92E
		public unsafe int MagazineSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_MagazineSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_MagazineSize)) = value;
			}
		}

		// Token: 0x17002928 RID: 10536
		// (get) Token: 0x06008776 RID: 34678 RVA: 0x0023C3C8 File Offset: 0x0023A5C8
		// (set) Token: 0x06008777 RID: 34679 RVA: 0x00040749 File Offset: 0x0003E949
		public unsafe float ReloadTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_ReloadTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_ReloadTime)) = value;
			}
		}

		// Token: 0x17002929 RID: 10537
		// (get) Token: 0x06008778 RID: 34680 RVA: 0x0023C3F0 File Offset: 0x0023A5F0
		// (set) Token: 0x06008779 RID: 34681 RVA: 0x00040764 File Offset: 0x0003E964
		public unsafe float MaxFireRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_MaxFireRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_MaxFireRate)) = value;
			}
		}

		// Token: 0x1700292A RID: 10538
		// (get) Token: 0x0600877A RID: 34682 RVA: 0x0023C418 File Offset: 0x0023A618
		// (set) Token: 0x0600877B RID: 34683 RVA: 0x0004077F File Offset: 0x0003E97F
		public unsafe bool CanShootWhileMoving
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_CanShootWhileMoving);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_CanShootWhileMoving)) = value;
			}
		}

		// Token: 0x1700292B RID: 10539
		// (get) Token: 0x0600877C RID: 34684 RVA: 0x0023C440 File Offset: 0x0023A640
		// (set) Token: 0x0600877D RID: 34685 RVA: 0x0004079A File Offset: 0x0003E99A
		public unsafe float EquipTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_EquipTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_EquipTime)) = value;
			}
		}

		// Token: 0x1700292C RID: 10540
		// (get) Token: 0x0600877E RID: 34686 RVA: 0x0023C468 File Offset: 0x0023A668
		// (set) Token: 0x0600877F RID: 34687 RVA: 0x000407B5 File Offset: 0x0003E9B5
		public unsafe float RaiseTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_RaiseTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_RaiseTime)) = value;
			}
		}

		// Token: 0x1700292D RID: 10541
		// (get) Token: 0x06008780 RID: 34688 RVA: 0x0023C490 File Offset: 0x0023A690
		// (set) Token: 0x06008781 RID: 34689 RVA: 0x000407D0 File Offset: 0x0003E9D0
		public unsafe float Damage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_Damage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_Damage)) = value;
			}
		}

		// Token: 0x1700292E RID: 10542
		// (get) Token: 0x06008782 RID: 34690 RVA: 0x0023C4B8 File Offset: 0x0023A6B8
		// (set) Token: 0x06008783 RID: 34691 RVA: 0x000407EB File Offset: 0x0003E9EB
		public unsafe float HitChange_MinRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_HitChange_MinRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_HitChange_MinRange)) = value;
			}
		}

		// Token: 0x1700292F RID: 10543
		// (get) Token: 0x06008784 RID: 34692 RVA: 0x0023C4E0 File Offset: 0x0023A6E0
		// (set) Token: 0x06008785 RID: 34693 RVA: 0x00040806 File Offset: 0x0003EA06
		public unsafe float HitChange_MaxRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_HitChange_MaxRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_HitChange_MaxRange)) = value;
			}
		}

		// Token: 0x17002930 RID: 10544
		// (get) Token: 0x06008786 RID: 34694 RVA: 0x0023C508 File Offset: 0x0023A708
		// (set) Token: 0x06008787 RID: 34695 RVA: 0x00040821 File Offset: 0x0003EA21
		public unsafe Transform MuzzlePoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_MuzzlePoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_MuzzlePoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002931 RID: 10545
		// (get) Token: 0x06008788 RID: 34696 RVA: 0x0023C538 File Offset: 0x0023A738
		// (set) Token: 0x06008789 RID: 34697 RVA: 0x00040840 File Offset: 0x0003EA40
		public unsafe AudioSourceController FireSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_FireSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_FireSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002932 RID: 10546
		// (get) Token: 0x0600878A RID: 34698 RVA: 0x0023C568 File Offset: 0x0023A768
		// (set) Token: 0x0600878B RID: 34699 RVA: 0x0004085F File Offset: 0x0003EA5F
		public unsafe string LoweredAnimationTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_LoweredAnimationTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_LoweredAnimationTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002933 RID: 10547
		// (get) Token: 0x0600878C RID: 34700 RVA: 0x0023C590 File Offset: 0x0023A790
		// (set) Token: 0x0600878D RID: 34701 RVA: 0x0004087E File Offset: 0x0003EA7E
		public unsafe string RaisedAnimationTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_RaisedAnimationTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_RaisedAnimationTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002934 RID: 10548
		// (get) Token: 0x0600878E RID: 34702 RVA: 0x0023C5B8 File Offset: 0x0023A7B8
		// (set) Token: 0x0600878F RID: 34703 RVA: 0x0004089D File Offset: 0x0003EA9D
		public unsafe string RecoilAnimationTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_RecoilAnimationTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_RecoilAnimationTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002935 RID: 10549
		// (get) Token: 0x06008790 RID: 34704 RVA: 0x0023C5E0 File Offset: 0x0023A7E0
		// (set) Token: 0x06008791 RID: 34705 RVA: 0x000408BC File Offset: 0x0003EABC
		public unsafe bool _IsRaised_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr__IsRaised_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr__IsRaised_k__BackingField)) = value;
			}
		}

		// Token: 0x17002936 RID: 10550
		// (get) Token: 0x06008792 RID: 34706 RVA: 0x0023C608 File Offset: 0x0023A808
		// (set) Token: 0x06008793 RID: 34707 RVA: 0x000408D7 File Offset: 0x0003EAD7
		public unsafe bool isReloading
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_isReloading);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_isReloading)) = value;
			}
		}

		// Token: 0x17002937 RID: 10551
		// (get) Token: 0x06008794 RID: 34708 RVA: 0x0023C630 File Offset: 0x0023A830
		// (set) Token: 0x06008795 RID: 34709 RVA: 0x000408F2 File Offset: 0x0003EAF2
		public unsafe float timeEquipped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_timeEquipped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_timeEquipped)) = value;
			}
		}

		// Token: 0x17002938 RID: 10552
		// (get) Token: 0x06008796 RID: 34710 RVA: 0x0023C658 File Offset: 0x0023A858
		// (set) Token: 0x06008797 RID: 34711 RVA: 0x0004090D File Offset: 0x0003EB0D
		public unsafe float timeRaised
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_timeRaised);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_timeRaised)) = value;
			}
		}

		// Token: 0x17002939 RID: 10553
		// (get) Token: 0x06008798 RID: 34712 RVA: 0x0023C680 File Offset: 0x0023A880
		// (set) Token: 0x06008799 RID: 34713 RVA: 0x00040928 File Offset: 0x0003EB28
		public unsafe float timeSinceLastShot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_timeSinceLastShot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_timeSinceLastShot)) = value;
			}
		}

		// Token: 0x1700293A RID: 10554
		// (get) Token: 0x0600879A RID: 34714 RVA: 0x0023C6A8 File Offset: 0x0023A8A8
		// (set) Token: 0x0600879B RID: 34715 RVA: 0x00040943 File Offset: 0x0003EB43
		public unsafe int currentAmmo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_currentAmmo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_currentAmmo)) = value;
			}
		}

		// Token: 0x04005C1A RID: 23578
		private static readonly IntPtr NativeFieldInfoPtr_RaycastLayers;

		// Token: 0x04005C1B RID: 23579
		private static readonly IntPtr NativeFieldInfoPtr_MagazineSize;

		// Token: 0x04005C1C RID: 23580
		private static readonly IntPtr NativeFieldInfoPtr_ReloadTime;

		// Token: 0x04005C1D RID: 23581
		private static readonly IntPtr NativeFieldInfoPtr_MaxFireRate;

		// Token: 0x04005C1E RID: 23582
		private static readonly IntPtr NativeFieldInfoPtr_CanShootWhileMoving;

		// Token: 0x04005C1F RID: 23583
		private static readonly IntPtr NativeFieldInfoPtr_EquipTime;

		// Token: 0x04005C20 RID: 23584
		private static readonly IntPtr NativeFieldInfoPtr_RaiseTime;

		// Token: 0x04005C21 RID: 23585
		private static readonly IntPtr NativeFieldInfoPtr_Damage;

		// Token: 0x04005C22 RID: 23586
		private static readonly IntPtr NativeFieldInfoPtr_HitChange_MinRange;

		// Token: 0x04005C23 RID: 23587
		private static readonly IntPtr NativeFieldInfoPtr_HitChange_MaxRange;

		// Token: 0x04005C24 RID: 23588
		private static readonly IntPtr NativeFieldInfoPtr_MuzzlePoint;

		// Token: 0x04005C25 RID: 23589
		private static readonly IntPtr NativeFieldInfoPtr_FireSound;

		// Token: 0x04005C26 RID: 23590
		private static readonly IntPtr NativeFieldInfoPtr_LoweredAnimationTrigger;

		// Token: 0x04005C27 RID: 23591
		private static readonly IntPtr NativeFieldInfoPtr_RaisedAnimationTrigger;

		// Token: 0x04005C28 RID: 23592
		private static readonly IntPtr NativeFieldInfoPtr_RecoilAnimationTrigger;

		// Token: 0x04005C29 RID: 23593
		private static readonly IntPtr NativeFieldInfoPtr__IsRaised_k__BackingField;

		// Token: 0x04005C2A RID: 23594
		private static readonly IntPtr NativeFieldInfoPtr_isReloading;

		// Token: 0x04005C2B RID: 23595
		private static readonly IntPtr NativeFieldInfoPtr_timeEquipped;

		// Token: 0x04005C2C RID: 23596
		private static readonly IntPtr NativeFieldInfoPtr_timeRaised;

		// Token: 0x04005C2D RID: 23597
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastShot;

		// Token: 0x04005C2E RID: 23598
		private static readonly IntPtr NativeFieldInfoPtr_currentAmmo;

		// Token: 0x04005C2F RID: 23599
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRaised_Public_get_Boolean_0;

		// Token: 0x04005C30 RID: 23600
		private static readonly IntPtr NativeMethodInfoPtr_set_IsRaised_Protected_set_Void_Boolean_0;

		// Token: 0x04005C31 RID: 23601
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_Avatar_0;

		// Token: 0x04005C32 RID: 23602
		private static readonly IntPtr NativeMethodInfoPtr_SetIsRaised_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04005C33 RID: 23603
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04005C34 RID: 23604
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveMessage_Public_Virtual_Void_String_Object_0;

		// Token: 0x04005C35 RID: 23605
		private static readonly IntPtr NativeMethodInfoPtr_CanShoot_Public_Boolean_0;

		// Token: 0x04005C36 RID: 23606
		private static readonly IntPtr NativeMethodInfoPtr_Shoot_Public_Virtual_New_Void_Vector3_0;

		// Token: 0x04005C37 RID: 23607
		private static readonly IntPtr NativeMethodInfoPtr_Reload_Private_IEnumerator_0;

		// Token: 0x04005C38 RID: 23608
		private static readonly IntPtr NativeMethodInfoPtr_IsPlayerInLoS_Public_Boolean_Player_0;

		// Token: 0x04005C39 RID: 23609
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AF9 RID: 2809
		[ObfuscatedName("ScheduleOne.AvatarFramework.Equipping.AvatarRangedWeapon+<Reload>d__30")]
		public sealed class _Reload_d__30 : Il2CppSystem.Object
		{
			// Token: 0x0600D5F5 RID: 54773 RVA: 0x0032F6C8 File Offset: 0x0032D8C8
			// Note: this type is marked as 'beforefieldinit'.
			static _Reload_d__30()
			{
				Il2CppClassPointerStore<AvatarRangedWeapon._Reload_d__30>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "<Reload>d__30");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarRangedWeapon._Reload_d__30>.NativeClassPtr);
				AvatarRangedWeapon._Reload_d__30.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon._Reload_d__30>.NativeClassPtr, "<>1__state");
				AvatarRangedWeapon._Reload_d__30.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon._Reload_d__30>.NativeClassPtr, "<>2__current");
				AvatarRangedWeapon._Reload_d__30.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon._Reload_d__30>.NativeClassPtr, "<>4__this");
				AvatarRangedWeapon._Reload_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon._Reload_d__30>.NativeClassPtr, 100680208);
				AvatarRangedWeapon._Reload_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon._Reload_d__30>.NativeClassPtr, 100680209);
				AvatarRangedWeapon._Reload_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon._Reload_d__30>.NativeClassPtr, 100680210);
				AvatarRangedWeapon._Reload_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon._Reload_d__30>.NativeClassPtr, 100680211);
				AvatarRangedWeapon._Reload_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon._Reload_d__30>.NativeClassPtr, 100680212);
				AvatarRangedWeapon._Reload_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon._Reload_d__30>.NativeClassPtr, 100680213);
			}

			// Token: 0x0600D5F6 RID: 54774 RVA: 0x0032F7A8 File Offset: 0x0032D9A8
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Reload_d__30(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarRangedWeapon._Reload_d__30>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon._Reload_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5F7 RID: 54775 RVA: 0x0032F7F0 File Offset: 0x0032D9F0
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon._Reload_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5F8 RID: 54776 RVA: 0x0032F824 File Offset: 0x0032DA24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251795, XrefRangeEnd = 251800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon._Reload_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004251 RID: 16977
			// (get) Token: 0x0600D5F9 RID: 54777 RVA: 0x0032F860 File Offset: 0x0032DA60
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon._Reload_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D5FA RID: 54778 RVA: 0x0032F8A0 File Offset: 0x0032DAA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251800, XrefRangeEnd = 251805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon._Reload_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004252 RID: 16978
			// (get) Token: 0x0600D5FB RID: 54779 RVA: 0x0032F8D4 File Offset: 0x0032DAD4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon._Reload_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D5FC RID: 54780 RVA: 0x0006821E File Offset: 0x0006641E
			public _Reload_d__30(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700424E RID: 16974
			// (get) Token: 0x0600D5FD RID: 54781 RVA: 0x0032F914 File Offset: 0x0032DB14
			// (set) Token: 0x0600D5FE RID: 54782 RVA: 0x00068227 File Offset: 0x00066427
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon._Reload_d__30.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon._Reload_d__30.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700424F RID: 16975
			// (get) Token: 0x0600D5FF RID: 54783 RVA: 0x0032F93C File Offset: 0x0032DB3C
			// (set) Token: 0x0600D600 RID: 54784 RVA: 0x00068242 File Offset: 0x00066442
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon._Reload_d__30.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon._Reload_d__30.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004250 RID: 16976
			// (get) Token: 0x0600D601 RID: 54785 RVA: 0x0032F96C File Offset: 0x0032DB6C
			// (set) Token: 0x0600D602 RID: 54786 RVA: 0x00068261 File Offset: 0x00066461
			public unsafe AvatarRangedWeapon __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon._Reload_d__30.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarRangedWeapon>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon._Reload_d__30.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008FEA RID: 36842
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008FEB RID: 36843
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008FEC RID: 36844
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008FED RID: 36845
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008FEE RID: 36846
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008FEF RID: 36847
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008FF0 RID: 36848
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008FF1 RID: 36849
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008FF2 RID: 36850
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
