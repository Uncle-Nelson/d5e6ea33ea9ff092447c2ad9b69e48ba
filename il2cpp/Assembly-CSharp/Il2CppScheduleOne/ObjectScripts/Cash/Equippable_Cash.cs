using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts.Cash
{
	// Token: 0x02000765 RID: 1893
	public class Equippable_Cash : Equippable_Viewmodel
	{
		// Token: 0x0600B3D1 RID: 46033 RVA: 0x002CD1E8 File Offset: 0x002CB3E8
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_Cash()
		{
			Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts.Cash", "Equippable_Cash");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr);
			Equippable_Cash.NativeFieldInfoPtr_amountIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, "amountIndex");
			Equippable_Cash.NativeFieldInfoPtr_Container_Under100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, "Container_Under100");
			Equippable_Cash.NativeFieldInfoPtr_SingleNotes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, "SingleNotes");
			Equippable_Cash.NativeFieldInfoPtr_Container_100_300 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, "Container_100_300");
			Equippable_Cash.NativeFieldInfoPtr_Under300Stacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, "Under300Stacks");
			Equippable_Cash.NativeFieldInfoPtr_Container_300Plus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, "Container_300Plus");
			Equippable_Cash.NativeFieldInfoPtr_PlusStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, "PlusStacks");
			Equippable_Cash.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, 100685459);
			Equippable_Cash.NativeMethodInfoPtr_StartBuildingStoredItem_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, 100685460);
			Equippable_Cash.NativeMethodInfoPtr_StopBuildingStoredItem_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, 100685461);
			Equippable_Cash.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, 100685462);
			Equippable_Cash.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, 100685463);
			Equippable_Cash.NativeMethodInfoPtr_UpdateCashVisuals_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, 100685464);
			Equippable_Cash.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, 100685465);
		}

		// Token: 0x0600B3D2 RID: 46034 RVA: 0x002CD330 File Offset: 0x002CB530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309032, XrefRangeEnd = 309037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Cash.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3D3 RID: 46035 RVA: 0x002CD36C File Offset: 0x002CB56C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309037, XrefRangeEnd = 309043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartBuildingStoredItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Cash.NativeMethodInfoPtr_StartBuildingStoredItem_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3D4 RID: 46036 RVA: 0x002CD3A8 File Offset: 0x002CB5A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309043, XrefRangeEnd = 309049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopBuildingStoredItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Cash.NativeMethodInfoPtr_StopBuildingStoredItem_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3D5 RID: 46037 RVA: 0x002CD3E4 File Offset: 0x002CB5E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309049, XrefRangeEnd = 309065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Cash.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3D6 RID: 46038 RVA: 0x002CD434 File Offset: 0x002CB634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309065, XrefRangeEnd = 309080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Cash.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3D7 RID: 46039 RVA: 0x002CD470 File Offset: 0x002CB670
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 309142, RefRangeEnd = 309143, XrefRangeStart = 309080, XrefRangeEnd = 309142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCashVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cash.NativeMethodInfoPtr_UpdateCashVisuals_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3D8 RID: 46040 RVA: 0x002CD4A4 File Offset: 0x002CB6A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_Cash() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cash.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3D9 RID: 46041 RVA: 0x00058218 File Offset: 0x00056418
		public Equippable_Cash(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170037BF RID: 14271
		// (get) Token: 0x0600B3DA RID: 46042 RVA: 0x002CD4E0 File Offset: 0x002CB6E0
		// (set) Token: 0x0600B3DB RID: 46043 RVA: 0x00058221 File Offset: 0x00056421
		public unsafe int amountIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_amountIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_amountIndex)) = value;
			}
		}

		// Token: 0x170037C0 RID: 14272
		// (get) Token: 0x0600B3DC RID: 46044 RVA: 0x002CD508 File Offset: 0x002CB708
		// (set) Token: 0x0600B3DD RID: 46045 RVA: 0x0005823C File Offset: 0x0005643C
		public unsafe Transform Container_Under100
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_Container_Under100);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_Container_Under100), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037C1 RID: 14273
		// (get) Token: 0x0600B3DE RID: 46046 RVA: 0x002CD538 File Offset: 0x002CB738
		// (set) Token: 0x0600B3DF RID: 46047 RVA: 0x0005825B File Offset: 0x0005645B
		public unsafe List<Transform> SingleNotes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_SingleNotes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_SingleNotes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037C2 RID: 14274
		// (get) Token: 0x0600B3E0 RID: 46048 RVA: 0x002CD568 File Offset: 0x002CB768
		// (set) Token: 0x0600B3E1 RID: 46049 RVA: 0x0005827A File Offset: 0x0005647A
		public unsafe Transform Container_100_300
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_Container_100_300);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_Container_100_300), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037C3 RID: 14275
		// (get) Token: 0x0600B3E2 RID: 46050 RVA: 0x002CD598 File Offset: 0x002CB798
		// (set) Token: 0x0600B3E3 RID: 46051 RVA: 0x00058299 File Offset: 0x00056499
		public unsafe List<Transform> Under300Stacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_Under300Stacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_Under300Stacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037C4 RID: 14276
		// (get) Token: 0x0600B3E4 RID: 46052 RVA: 0x002CD5C8 File Offset: 0x002CB7C8
		// (set) Token: 0x0600B3E5 RID: 46053 RVA: 0x000582B8 File Offset: 0x000564B8
		public unsafe Transform Container_300Plus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_Container_300Plus);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_Container_300Plus), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037C5 RID: 14277
		// (get) Token: 0x0600B3E6 RID: 46054 RVA: 0x002CD5F8 File Offset: 0x002CB7F8
		// (set) Token: 0x0600B3E7 RID: 46055 RVA: 0x000582D7 File Offset: 0x000564D7
		public unsafe List<Transform> PlusStacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_PlusStacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_PlusStacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007945 RID: 31045
		private static readonly IntPtr NativeFieldInfoPtr_amountIndex;

		// Token: 0x04007946 RID: 31046
		private static readonly IntPtr NativeFieldInfoPtr_Container_Under100;

		// Token: 0x04007947 RID: 31047
		private static readonly IntPtr NativeFieldInfoPtr_SingleNotes;

		// Token: 0x04007948 RID: 31048
		private static readonly IntPtr NativeFieldInfoPtr_Container_100_300;

		// Token: 0x04007949 RID: 31049
		private static readonly IntPtr NativeFieldInfoPtr_Under300Stacks;

		// Token: 0x0400794A RID: 31050
		private static readonly IntPtr NativeFieldInfoPtr_Container_300Plus;

		// Token: 0x0400794B RID: 31051
		private static readonly IntPtr NativeFieldInfoPtr_PlusStacks;

		// Token: 0x0400794C RID: 31052
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x0400794D RID: 31053
		private static readonly IntPtr NativeMethodInfoPtr_StartBuildingStoredItem_Protected_Virtual_Void_0;

		// Token: 0x0400794E RID: 31054
		private static readonly IntPtr NativeMethodInfoPtr_StopBuildingStoredItem_Protected_Virtual_Void_0;

		// Token: 0x0400794F RID: 31055
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04007950 RID: 31056
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x04007951 RID: 31057
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCashVisuals_Private_Void_0;

		// Token: 0x04007952 RID: 31058
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
