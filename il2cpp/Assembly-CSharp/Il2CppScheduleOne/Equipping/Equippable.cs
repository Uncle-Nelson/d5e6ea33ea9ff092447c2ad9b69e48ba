using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005BE RID: 1470
	public class Equippable : MonoBehaviour
	{
		// Token: 0x060080F6 RID: 33014 RVA: 0x00226FC4 File Offset: 0x002251C4
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable()
		{
			Il2CppClassPointerStore<Equippable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable>.NativeClassPtr);
			Equippable.NativeFieldInfoPtr_itemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable>.NativeClassPtr, "itemInstance");
			Equippable.NativeFieldInfoPtr_CanInteractWhenEquipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable>.NativeClassPtr, "CanInteractWhenEquipped");
			Equippable.NativeFieldInfoPtr_CanPickUpWhenEquipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable>.NativeClassPtr, "CanPickUpWhenEquipped");
			Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_New_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable>.NativeClassPtr, 100679465);
			Equippable.NativeMethodInfoPtr_Unequip_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable>.NativeClassPtr, 100679466);
			Equippable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable>.NativeClassPtr, 100679467);
		}

		// Token: 0x060080F7 RID: 33015 RVA: 0x0022706C File Offset: 0x0022526C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245015, XrefRangeEnd = 245022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_New_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060080F8 RID: 33016 RVA: 0x002270BC File Offset: 0x002252BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245022, XrefRangeEnd = 245033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable.NativeMethodInfoPtr_Unequip_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060080F9 RID: 33017 RVA: 0x002270F8 File Offset: 0x002252F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245033, XrefRangeEnd = 245034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060080FA RID: 33018 RVA: 0x0003D351 File Offset: 0x0003B551
		public Equippable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026F8 RID: 9976
		// (get) Token: 0x060080FB RID: 33019 RVA: 0x00227134 File Offset: 0x00225334
		// (set) Token: 0x060080FC RID: 33020 RVA: 0x0003D35A File Offset: 0x0003B55A
		public unsafe ItemInstance itemInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable.NativeFieldInfoPtr_itemInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable.NativeFieldInfoPtr_itemInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026F9 RID: 9977
		// (get) Token: 0x060080FD RID: 33021 RVA: 0x00227164 File Offset: 0x00225364
		// (set) Token: 0x060080FE RID: 33022 RVA: 0x0003D379 File Offset: 0x0003B579
		public unsafe bool CanInteractWhenEquipped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable.NativeFieldInfoPtr_CanInteractWhenEquipped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable.NativeFieldInfoPtr_CanInteractWhenEquipped)) = value;
			}
		}

		// Token: 0x170026FA RID: 9978
		// (get) Token: 0x060080FF RID: 33023 RVA: 0x0022718C File Offset: 0x0022538C
		// (set) Token: 0x06008100 RID: 33024 RVA: 0x0003D394 File Offset: 0x0003B594
		public unsafe bool CanPickUpWhenEquipped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable.NativeFieldInfoPtr_CanPickUpWhenEquipped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable.NativeFieldInfoPtr_CanPickUpWhenEquipped)) = value;
			}
		}

		// Token: 0x040057D0 RID: 22480
		private static readonly IntPtr NativeFieldInfoPtr_itemInstance;

		// Token: 0x040057D1 RID: 22481
		private static readonly IntPtr NativeFieldInfoPtr_CanInteractWhenEquipped;

		// Token: 0x040057D2 RID: 22482
		private static readonly IntPtr NativeFieldInfoPtr_CanPickUpWhenEquipped;

		// Token: 0x040057D3 RID: 22483
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_New_Void_ItemInstance_0;

		// Token: 0x040057D4 RID: 22484
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_New_Void_0;

		// Token: 0x040057D5 RID: 22485
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
