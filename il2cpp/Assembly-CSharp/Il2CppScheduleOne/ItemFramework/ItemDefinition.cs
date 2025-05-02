using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.UI.Items;
using UnityEngine;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005E3 RID: 1507
	[Serializable]
	public class ItemDefinition : ScriptableObject
	{
		// Token: 0x06008395 RID: 33685 RVA: 0x0022F988 File Offset: 0x0022DB88
		// Note: this type is marked as 'beforefieldinit'.
		static ItemDefinition()
		{
			Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr);
			ItemDefinition.NativeFieldInfoPtr_DEFAULT_STACK_LIMIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, "DEFAULT_STACK_LIMIT");
			ItemDefinition.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, "Name");
			ItemDefinition.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, "Description");
			ItemDefinition.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, "ID");
			ItemDefinition.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, "Icon");
			ItemDefinition.NativeFieldInfoPtr_Category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, "Category");
			ItemDefinition.NativeFieldInfoPtr_Keywords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, "Keywords");
			ItemDefinition.NativeFieldInfoPtr_AvailableInDemo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, "AvailableInDemo");
			ItemDefinition.NativeFieldInfoPtr_LabelDisplayColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, "LabelDisplayColor");
			ItemDefinition.NativeFieldInfoPtr_StackLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, "StackLimit");
			ItemDefinition.NativeFieldInfoPtr_Equippable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, "Equippable");
			ItemDefinition.NativeFieldInfoPtr_CustomItemUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, "CustomItemUI");
			ItemDefinition.NativeFieldInfoPtr_CustomInfoContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, "CustomInfoContent");
			ItemDefinition.NativeFieldInfoPtr_legalStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, "legalStatus");
			ItemDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_New_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, 100679758);
			ItemDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, 100679759);
		}

		// Token: 0x06008396 RID: 33686 RVA: 0x0022FAF8 File Offset: 0x0022DCF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247626, XrefRangeEnd = 247632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ItemInstance GetDefaultInstance(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_New_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06008397 RID: 33687 RVA: 0x0022FB50 File Offset: 0x0022DD50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 247633, RefRangeEnd = 247635, XrefRangeStart = 247632, XrefRangeEnd = 247633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008398 RID: 33688 RVA: 0x0003E77C File Offset: 0x0003C97C
		public ItemDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027C5 RID: 10181
		// (get) Token: 0x06008399 RID: 33689 RVA: 0x0022FB8C File Offset: 0x0022DD8C
		// (set) Token: 0x0600839A RID: 33690 RVA: 0x0003E785 File Offset: 0x0003C985
		public unsafe static int DEFAULT_STACK_LIMIT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ItemDefinition.NativeFieldInfoPtr_DEFAULT_STACK_LIMIT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemDefinition.NativeFieldInfoPtr_DEFAULT_STACK_LIMIT, (void*)(&value));
			}
		}

		// Token: 0x170027C6 RID: 10182
		// (get) Token: 0x0600839B RID: 33691 RVA: 0x0022FBA8 File Offset: 0x0022DDA8
		// (set) Token: 0x0600839C RID: 33692 RVA: 0x0003E793 File Offset: 0x0003C993
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170027C7 RID: 10183
		// (get) Token: 0x0600839D RID: 33693 RVA: 0x0022FBD0 File Offset: 0x0022DDD0
		// (set) Token: 0x0600839E RID: 33694 RVA: 0x0003E7B2 File Offset: 0x0003C9B2
		public unsafe string Description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_Description);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_Description), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170027C8 RID: 10184
		// (get) Token: 0x0600839F RID: 33695 RVA: 0x0022FBF8 File Offset: 0x0022DDF8
		// (set) Token: 0x060083A0 RID: 33696 RVA: 0x0003E7D1 File Offset: 0x0003C9D1
		public unsafe string ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_ID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170027C9 RID: 10185
		// (get) Token: 0x060083A1 RID: 33697 RVA: 0x0022FC20 File Offset: 0x0022DE20
		// (set) Token: 0x060083A2 RID: 33698 RVA: 0x0003E7F0 File Offset: 0x0003C9F0
		public unsafe Sprite Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027CA RID: 10186
		// (get) Token: 0x060083A3 RID: 33699 RVA: 0x0022FC50 File Offset: 0x0022DE50
		// (set) Token: 0x060083A4 RID: 33700 RVA: 0x0003E80F File Offset: 0x0003CA0F
		public unsafe EItemCategory Category
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_Category);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_Category)) = value;
			}
		}

		// Token: 0x170027CB RID: 10187
		// (get) Token: 0x060083A5 RID: 33701 RVA: 0x0022FC78 File Offset: 0x0022DE78
		// (set) Token: 0x060083A6 RID: 33702 RVA: 0x0003E82A File Offset: 0x0003CA2A
		public unsafe Il2CppStringArray Keywords
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_Keywords);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_Keywords), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027CC RID: 10188
		// (get) Token: 0x060083A7 RID: 33703 RVA: 0x0022FCA8 File Offset: 0x0022DEA8
		// (set) Token: 0x060083A8 RID: 33704 RVA: 0x0003E849 File Offset: 0x0003CA49
		public unsafe bool AvailableInDemo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_AvailableInDemo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_AvailableInDemo)) = value;
			}
		}

		// Token: 0x170027CD RID: 10189
		// (get) Token: 0x060083A9 RID: 33705 RVA: 0x0022FCD0 File Offset: 0x0022DED0
		// (set) Token: 0x060083AA RID: 33706 RVA: 0x0003E864 File Offset: 0x0003CA64
		public unsafe Color LabelDisplayColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_LabelDisplayColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_LabelDisplayColor)) = value;
			}
		}

		// Token: 0x170027CE RID: 10190
		// (get) Token: 0x060083AB RID: 33707 RVA: 0x0022FCF8 File Offset: 0x0022DEF8
		// (set) Token: 0x060083AC RID: 33708 RVA: 0x0003E87F File Offset: 0x0003CA7F
		public unsafe int StackLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_StackLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_StackLimit)) = value;
			}
		}

		// Token: 0x170027CF RID: 10191
		// (get) Token: 0x060083AD RID: 33709 RVA: 0x0022FD20 File Offset: 0x0022DF20
		// (set) Token: 0x060083AE RID: 33710 RVA: 0x0003E89A File Offset: 0x0003CA9A
		public unsafe Equippable Equippable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_Equippable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_Equippable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027D0 RID: 10192
		// (get) Token: 0x060083AF RID: 33711 RVA: 0x0022FD50 File Offset: 0x0022DF50
		// (set) Token: 0x060083B0 RID: 33712 RVA: 0x0003E8B9 File Offset: 0x0003CAB9
		public unsafe ItemUI CustomItemUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_CustomItemUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_CustomItemUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027D1 RID: 10193
		// (get) Token: 0x060083B1 RID: 33713 RVA: 0x0022FD80 File Offset: 0x0022DF80
		// (set) Token: 0x060083B2 RID: 33714 RVA: 0x0003E8D8 File Offset: 0x0003CAD8
		public unsafe ItemInfoContent CustomInfoContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_CustomInfoContent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInfoContent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_CustomInfoContent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027D2 RID: 10194
		// (get) Token: 0x060083B3 RID: 33715 RVA: 0x0022FDB0 File Offset: 0x0022DFB0
		// (set) Token: 0x060083B4 RID: 33716 RVA: 0x0003E8F7 File Offset: 0x0003CAF7
		public unsafe ELegalStatus legalStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_legalStatus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_legalStatus)) = value;
			}
		}

		// Token: 0x04005992 RID: 22930
		private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_STACK_LIMIT;

		// Token: 0x04005993 RID: 22931
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04005994 RID: 22932
		private static readonly IntPtr NativeFieldInfoPtr_Description;

		// Token: 0x04005995 RID: 22933
		private static readonly IntPtr NativeFieldInfoPtr_ID;

		// Token: 0x04005996 RID: 22934
		private static readonly IntPtr NativeFieldInfoPtr_Icon;

		// Token: 0x04005997 RID: 22935
		private static readonly IntPtr NativeFieldInfoPtr_Category;

		// Token: 0x04005998 RID: 22936
		private static readonly IntPtr NativeFieldInfoPtr_Keywords;

		// Token: 0x04005999 RID: 22937
		private static readonly IntPtr NativeFieldInfoPtr_AvailableInDemo;

		// Token: 0x0400599A RID: 22938
		private static readonly IntPtr NativeFieldInfoPtr_LabelDisplayColor;

		// Token: 0x0400599B RID: 22939
		private static readonly IntPtr NativeFieldInfoPtr_StackLimit;

		// Token: 0x0400599C RID: 22940
		private static readonly IntPtr NativeFieldInfoPtr_Equippable;

		// Token: 0x0400599D RID: 22941
		private static readonly IntPtr NativeFieldInfoPtr_CustomItemUI;

		// Token: 0x0400599E RID: 22942
		private static readonly IntPtr NativeFieldInfoPtr_CustomInfoContent;

		// Token: 0x0400599F RID: 22943
		private static readonly IntPtr NativeFieldInfoPtr_legalStatus;

		// Token: 0x040059A0 RID: 22944
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_New_ItemInstance_Int32_0;

		// Token: 0x040059A1 RID: 22945
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
