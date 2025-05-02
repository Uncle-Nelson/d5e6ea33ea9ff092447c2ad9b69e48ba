using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005C0 RID: 1472
	public class Equippable_AvatarViewmodel : Equippable_Viewmodel
	{
		// Token: 0x06008109 RID: 33033 RVA: 0x002273C8 File Offset: 0x002255C8
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_AvatarViewmodel()
		{
			Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_AvatarViewmodel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr);
			Equippable_AvatarViewmodel.NativeFieldInfoPtr_AnimatorController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr, "AnimatorController");
			Equippable_AvatarViewmodel.NativeFieldInfoPtr_ViewmodelAvatarOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr, "ViewmodelAvatarOffset");
			Equippable_AvatarViewmodel.NativeFieldInfoPtr_EquipTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr, "EquipTime");
			Equippable_AvatarViewmodel.NativeFieldInfoPtr_EquipTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr, "EquipTrigger");
			Equippable_AvatarViewmodel.NativeFieldInfoPtr_timeEquipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr, "timeEquipped");
			Equippable_AvatarViewmodel.NativeMethodInfoPtr_get_equipAnimDone_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr, 100679472);
			Equippable_AvatarViewmodel.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr, 100679473);
			Equippable_AvatarViewmodel.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr, 100679474);
			Equippable_AvatarViewmodel.NativeMethodInfoPtr_PlayEquipAnimation_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr, 100679475);
			Equippable_AvatarViewmodel.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr, 100679476);
			Equippable_AvatarViewmodel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr, 100679477);
		}

		// Token: 0x17002701 RID: 9985
		// (get) Token: 0x0600810A RID: 33034 RVA: 0x002274D4 File Offset: 0x002256D4
		public unsafe bool equipAnimDone
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_AvatarViewmodel.NativeMethodInfoPtr_get_equipAnimDone_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600810B RID: 33035 RVA: 0x00227510 File Offset: 0x00225710
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 245091, RefRangeEnd = 245093, XrefRangeStart = 245067, XrefRangeEnd = 245091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_AvatarViewmodel.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600810C RID: 33036 RVA: 0x00227560 File Offset: 0x00225760
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 245100, RefRangeEnd = 245102, XrefRangeStart = 245093, XrefRangeEnd = 245100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_AvatarViewmodel.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600810D RID: 33037 RVA: 0x0022759C File Offset: 0x0022579C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245102, XrefRangeEnd = 245119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PlayEquipAnimation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_AvatarViewmodel.NativeMethodInfoPtr_PlayEquipAnimation_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600810E RID: 33038 RVA: 0x002275D8 File Offset: 0x002257D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245119, XrefRangeEnd = 245120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_AvatarViewmodel.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600810F RID: 33039 RVA: 0x00227614 File Offset: 0x00225814
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 245129, RefRangeEnd = 245132, XrefRangeStart = 245120, XrefRangeEnd = 245129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_AvatarViewmodel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_AvatarViewmodel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008110 RID: 33040 RVA: 0x0003D3D7 File Offset: 0x0003B5D7
		public Equippable_AvatarViewmodel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026FC RID: 9980
		// (get) Token: 0x06008111 RID: 33041 RVA: 0x00227650 File Offset: 0x00225850
		// (set) Token: 0x06008112 RID: 33042 RVA: 0x0003D3E0 File Offset: 0x0003B5E0
		public unsafe RuntimeAnimatorController AnimatorController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_AvatarViewmodel.NativeFieldInfoPtr_AnimatorController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeAnimatorController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_AvatarViewmodel.NativeFieldInfoPtr_AnimatorController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026FD RID: 9981
		// (get) Token: 0x06008113 RID: 33043 RVA: 0x00227680 File Offset: 0x00225880
		// (set) Token: 0x06008114 RID: 33044 RVA: 0x0003D3FF File Offset: 0x0003B5FF
		public unsafe Vector3 ViewmodelAvatarOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_AvatarViewmodel.NativeFieldInfoPtr_ViewmodelAvatarOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_AvatarViewmodel.NativeFieldInfoPtr_ViewmodelAvatarOffset)) = value;
			}
		}

		// Token: 0x170026FE RID: 9982
		// (get) Token: 0x06008115 RID: 33045 RVA: 0x002276A8 File Offset: 0x002258A8
		// (set) Token: 0x06008116 RID: 33046 RVA: 0x0003D41A File Offset: 0x0003B61A
		public unsafe float EquipTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_AvatarViewmodel.NativeFieldInfoPtr_EquipTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_AvatarViewmodel.NativeFieldInfoPtr_EquipTime)) = value;
			}
		}

		// Token: 0x170026FF RID: 9983
		// (get) Token: 0x06008117 RID: 33047 RVA: 0x002276D0 File Offset: 0x002258D0
		// (set) Token: 0x06008118 RID: 33048 RVA: 0x0003D435 File Offset: 0x0003B635
		public unsafe string EquipTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_AvatarViewmodel.NativeFieldInfoPtr_EquipTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_AvatarViewmodel.NativeFieldInfoPtr_EquipTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002700 RID: 9984
		// (get) Token: 0x06008119 RID: 33049 RVA: 0x002276F8 File Offset: 0x002258F8
		// (set) Token: 0x0600811A RID: 33050 RVA: 0x0003D454 File Offset: 0x0003B654
		public unsafe float timeEquipped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_AvatarViewmodel.NativeFieldInfoPtr_timeEquipped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_AvatarViewmodel.NativeFieldInfoPtr_timeEquipped)) = value;
			}
		}

		// Token: 0x040057DB RID: 22491
		private static readonly IntPtr NativeFieldInfoPtr_AnimatorController;

		// Token: 0x040057DC RID: 22492
		private static readonly IntPtr NativeFieldInfoPtr_ViewmodelAvatarOffset;

		// Token: 0x040057DD RID: 22493
		private static readonly IntPtr NativeFieldInfoPtr_EquipTime;

		// Token: 0x040057DE RID: 22494
		private static readonly IntPtr NativeFieldInfoPtr_EquipTrigger;

		// Token: 0x040057DF RID: 22495
		private static readonly IntPtr NativeFieldInfoPtr_timeEquipped;

		// Token: 0x040057E0 RID: 22496
		private static readonly IntPtr NativeMethodInfoPtr_get_equipAnimDone_Protected_get_Boolean_0;

		// Token: 0x040057E1 RID: 22497
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x040057E2 RID: 22498
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x040057E3 RID: 22499
		private static readonly IntPtr NativeMethodInfoPtr_PlayEquipAnimation_Protected_Virtual_Void_0;

		// Token: 0x040057E4 RID: 22500
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x040057E5 RID: 22501
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
