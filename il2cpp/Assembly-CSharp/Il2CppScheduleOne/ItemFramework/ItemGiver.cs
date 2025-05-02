using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005E4 RID: 1508
	public class ItemGiver : MonoBehaviour
	{
		// Token: 0x060083B5 RID: 33717 RVA: 0x0022FDD8 File Offset: 0x0022DFD8
		// Note: this type is marked as 'beforefieldinit'.
		static ItemGiver()
		{
			Il2CppClassPointerStore<ItemGiver>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemGiver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemGiver>.NativeClassPtr);
			ItemGiver.NativeFieldInfoPtr_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemGiver>.NativeClassPtr, "Item");
			ItemGiver.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemGiver>.NativeClassPtr, "Quantity");
			ItemGiver.NativeMethodInfoPtr_Give_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemGiver>.NativeClassPtr, 100679760);
			ItemGiver.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemGiver>.NativeClassPtr, 100679761);
		}

		// Token: 0x060083B6 RID: 33718 RVA: 0x0022FE58 File Offset: 0x0022E058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247635, XrefRangeEnd = 247641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Give()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemGiver.NativeMethodInfoPtr_Give_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060083B7 RID: 33719 RVA: 0x0022FE8C File Offset: 0x0022E08C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemGiver() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemGiver>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemGiver.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060083B8 RID: 33720 RVA: 0x0003E912 File Offset: 0x0003CB12
		public ItemGiver(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027D3 RID: 10195
		// (get) Token: 0x060083B9 RID: 33721 RVA: 0x0022FEC8 File Offset: 0x0022E0C8
		// (set) Token: 0x060083BA RID: 33722 RVA: 0x0003E91B File Offset: 0x0003CB1B
		public unsafe ItemDefinition Item
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemGiver.NativeFieldInfoPtr_Item);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemGiver.NativeFieldInfoPtr_Item), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027D4 RID: 10196
		// (get) Token: 0x060083BB RID: 33723 RVA: 0x0022FEF8 File Offset: 0x0022E0F8
		// (set) Token: 0x060083BC RID: 33724 RVA: 0x0003E93A File Offset: 0x0003CB3A
		public unsafe int Quantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemGiver.NativeFieldInfoPtr_Quantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemGiver.NativeFieldInfoPtr_Quantity)) = value;
			}
		}

		// Token: 0x040059A2 RID: 22946
		private static readonly IntPtr NativeFieldInfoPtr_Item;

		// Token: 0x040059A3 RID: 22947
		private static readonly IntPtr NativeFieldInfoPtr_Quantity;

		// Token: 0x040059A4 RID: 22948
		private static readonly IntPtr NativeMethodInfoPtr_Give_Public_Void_0;

		// Token: 0x040059A5 RID: 22949
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
