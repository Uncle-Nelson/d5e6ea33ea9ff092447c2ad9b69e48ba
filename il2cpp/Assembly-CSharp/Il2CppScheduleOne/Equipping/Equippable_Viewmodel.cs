using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Equipping;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005C8 RID: 1480
	public class Equippable_Viewmodel : Equippable_StorableItem
	{
		// Token: 0x06008212 RID: 33298 RVA: 0x0022A2F4 File Offset: 0x002284F4
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_Viewmodel()
		{
			Il2CppClassPointerStore<Equippable_Viewmodel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_Viewmodel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_Viewmodel>.NativeClassPtr);
			Equippable_Viewmodel.NativeFieldInfoPtr_localPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Viewmodel>.NativeClassPtr, "localPosition");
			Equippable_Viewmodel.NativeFieldInfoPtr_localEulerAngles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Viewmodel>.NativeClassPtr, "localEulerAngles");
			Equippable_Viewmodel.NativeFieldInfoPtr_localScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Viewmodel>.NativeClassPtr, "localScale");
			Equippable_Viewmodel.NativeFieldInfoPtr_AvatarEquippable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Viewmodel>.NativeClassPtr, "AvatarEquippable");
			Equippable_Viewmodel.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Viewmodel>.NativeClassPtr, 100679572);
			Equippable_Viewmodel.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Viewmodel>.NativeClassPtr, 100679573);
			Equippable_Viewmodel.NativeMethodInfoPtr_PlayEquipAnimation_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Viewmodel>.NativeClassPtr, 100679574);
			Equippable_Viewmodel.NativeMethodInfoPtr_PlayUnequipAnimation_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Viewmodel>.NativeClassPtr, 100679575);
			Equippable_Viewmodel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Viewmodel>.NativeClassPtr, 100679576);
		}

		// Token: 0x06008213 RID: 33299 RVA: 0x0022A3D8 File Offset: 0x002285D8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 246061, RefRangeEnd = 246073, XrefRangeStart = 246033, XrefRangeEnd = 246061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Viewmodel.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008214 RID: 33300 RVA: 0x0022A428 File Offset: 0x00228628
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 246074, RefRangeEnd = 246079, XrefRangeStart = 246073, XrefRangeEnd = 246074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Viewmodel.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008215 RID: 33301 RVA: 0x0022A464 File Offset: 0x00228664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246079, XrefRangeEnd = 246088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PlayEquipAnimation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Viewmodel.NativeMethodInfoPtr_PlayEquipAnimation_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008216 RID: 33302 RVA: 0x0022A4A0 File Offset: 0x002286A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246088, XrefRangeEnd = 246099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PlayUnequipAnimation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Viewmodel.NativeMethodInfoPtr_PlayUnequipAnimation_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008217 RID: 33303 RVA: 0x0022A4DC File Offset: 0x002286DC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 244704, RefRangeEnd = 244712, XrefRangeStart = 244704, XrefRangeEnd = 244712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_Viewmodel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_Viewmodel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Viewmodel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008218 RID: 33304 RVA: 0x0003DD88 File Offset: 0x0003BF88
		public Equippable_Viewmodel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700275E RID: 10078
		// (get) Token: 0x06008219 RID: 33305 RVA: 0x0022A518 File Offset: 0x00228718
		// (set) Token: 0x0600821A RID: 33306 RVA: 0x0003DD91 File Offset: 0x0003BF91
		public unsafe Vector3 localPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Viewmodel.NativeFieldInfoPtr_localPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Viewmodel.NativeFieldInfoPtr_localPosition)) = value;
			}
		}

		// Token: 0x1700275F RID: 10079
		// (get) Token: 0x0600821B RID: 33307 RVA: 0x0022A540 File Offset: 0x00228740
		// (set) Token: 0x0600821C RID: 33308 RVA: 0x0003DDAC File Offset: 0x0003BFAC
		public unsafe Vector3 localEulerAngles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Viewmodel.NativeFieldInfoPtr_localEulerAngles);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Viewmodel.NativeFieldInfoPtr_localEulerAngles)) = value;
			}
		}

		// Token: 0x17002760 RID: 10080
		// (get) Token: 0x0600821D RID: 33309 RVA: 0x0022A568 File Offset: 0x00228768
		// (set) Token: 0x0600821E RID: 33310 RVA: 0x0003DDC7 File Offset: 0x0003BFC7
		public unsafe Vector3 localScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Viewmodel.NativeFieldInfoPtr_localScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Viewmodel.NativeFieldInfoPtr_localScale)) = value;
			}
		}

		// Token: 0x17002761 RID: 10081
		// (get) Token: 0x0600821F RID: 33311 RVA: 0x0022A590 File Offset: 0x00228790
		// (set) Token: 0x06008220 RID: 33312 RVA: 0x0003DDE2 File Offset: 0x0003BFE2
		public unsafe AvatarEquippable AvatarEquippable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Viewmodel.NativeFieldInfoPtr_AvatarEquippable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Viewmodel.NativeFieldInfoPtr_AvatarEquippable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400587E RID: 22654
		private static readonly IntPtr NativeFieldInfoPtr_localPosition;

		// Token: 0x0400587F RID: 22655
		private static readonly IntPtr NativeFieldInfoPtr_localEulerAngles;

		// Token: 0x04005880 RID: 22656
		private static readonly IntPtr NativeFieldInfoPtr_localScale;

		// Token: 0x04005881 RID: 22657
		private static readonly IntPtr NativeFieldInfoPtr_AvatarEquippable;

		// Token: 0x04005882 RID: 22658
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04005883 RID: 22659
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x04005884 RID: 22660
		private static readonly IntPtr NativeMethodInfoPtr_PlayEquipAnimation_Protected_Virtual_New_Void_0;

		// Token: 0x04005885 RID: 22661
		private static readonly IntPtr NativeMethodInfoPtr_PlayUnequipAnimation_Protected_Virtual_New_Void_0;

		// Token: 0x04005886 RID: 22662
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
