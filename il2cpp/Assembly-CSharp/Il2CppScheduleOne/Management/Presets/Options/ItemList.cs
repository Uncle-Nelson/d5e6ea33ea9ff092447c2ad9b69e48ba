using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Management.Presets.Options
{
	// Token: 0x020003AF RID: 943
	public class ItemList : Option
	{
		// Token: 0x060049AA RID: 18858 RVA: 0x00166B50 File Offset: 0x00164D50
		// Note: this type is marked as 'beforefieldinit'.
		static ItemList()
		{
			Il2CppClassPointerStore<ItemList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management.Presets.Options", "ItemList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemList>.NativeClassPtr);
			ItemList.NativeFieldInfoPtr_All = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemList>.NativeClassPtr, "All");
			ItemList.NativeFieldInfoPtr_None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemList>.NativeClassPtr, "None");
			ItemList.NativeFieldInfoPtr_Selection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemList>.NativeClassPtr, "Selection");
			ItemList.NativeFieldInfoPtr__CanBeAll_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemList>.NativeClassPtr, "<CanBeAll>k__BackingField");
			ItemList.NativeFieldInfoPtr__CanBeNone_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemList>.NativeClassPtr, "<CanBeNone>k__BackingField");
			ItemList.NativeFieldInfoPtr__OptionList_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemList>.NativeClassPtr, "<OptionList>k__BackingField");
			ItemList.NativeMethodInfoPtr_get_CanBeAll_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemList>.NativeClassPtr, 100672436);
			ItemList.NativeMethodInfoPtr_set_CanBeAll_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemList>.NativeClassPtr, 100672437);
			ItemList.NativeMethodInfoPtr_get_CanBeNone_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemList>.NativeClassPtr, 100672438);
			ItemList.NativeMethodInfoPtr_set_CanBeNone_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemList>.NativeClassPtr, 100672439);
			ItemList.NativeMethodInfoPtr_get_OptionList_Public_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemList>.NativeClassPtr, 100672440);
			ItemList.NativeMethodInfoPtr_set_OptionList_Protected_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemList>.NativeClassPtr, 100672441);
			ItemList.NativeMethodInfoPtr__ctor_Public_Void_String_List_1_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemList>.NativeClassPtr, 100672442);
			ItemList.NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemList>.NativeClassPtr, 100672443);
			ItemList.NativeMethodInfoPtr_GetDisplayString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemList>.NativeClassPtr, 100672444);
		}

		// Token: 0x1700161C RID: 5660
		// (get) Token: 0x060049AB RID: 18859 RVA: 0x00166CAC File Offset: 0x00164EAC
		// (set) Token: 0x060049AC RID: 18860 RVA: 0x00166CE8 File Offset: 0x00164EE8
		public unsafe bool CanBeAll
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemList.NativeMethodInfoPtr_get_CanBeAll_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 37992, RefRangeEnd = 38015, XrefRangeStart = 37992, XrefRangeEnd = 38015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemList.NativeMethodInfoPtr_set_CanBeAll_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700161D RID: 5661
		// (get) Token: 0x060049AD RID: 18861 RVA: 0x00166D28 File Offset: 0x00164F28
		// (set) Token: 0x060049AE RID: 18862 RVA: 0x00166D64 File Offset: 0x00164F64
		public unsafe bool CanBeNone
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemList.NativeMethodInfoPtr_get_CanBeNone_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemList.NativeMethodInfoPtr_set_CanBeNone_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700161E RID: 5662
		// (get) Token: 0x060049AF RID: 18863 RVA: 0x00166DA4 File Offset: 0x00164FA4
		// (set) Token: 0x060049B0 RID: 18864 RVA: 0x00166DE4 File Offset: 0x00164FE4
		public unsafe List<string> OptionList
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19644, RefRangeEnd = 19658, XrefRangeStart = 19644, XrefRangeEnd = 19658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemList.NativeMethodInfoPtr_get_OptionList_Public_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 19659, RefRangeEnd = 19660, XrefRangeStart = 19659, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemList.NativeMethodInfoPtr_set_OptionList_Protected_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060049B1 RID: 18865 RVA: 0x00166E28 File Offset: 0x00165028
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 163645, RefRangeEnd = 163647, XrefRangeStart = 163624, XrefRangeEnd = 163645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemList(string name, List<string> optionList, bool canBeAll, bool canBeNone) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemList>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(optionList);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canBeAll;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canBeNone;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemList.NativeMethodInfoPtr__ctor_Public_Void_String_List_1_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049B2 RID: 18866 RVA: 0x00166EA4 File Offset: 0x001650A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163647, XrefRangeEnd = 163663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyTo(Option other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemList.NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Option_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049B3 RID: 18867 RVA: 0x00166EF4 File Offset: 0x001650F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163663, XrefRangeEnd = 163686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetDisplayString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemList.NativeMethodInfoPtr_GetDisplayString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060049B4 RID: 18868 RVA: 0x000237FB File Offset: 0x000219FB
		public ItemList(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001616 RID: 5654
		// (get) Token: 0x060049B5 RID: 18869 RVA: 0x00166F38 File Offset: 0x00165138
		// (set) Token: 0x060049B6 RID: 18870 RVA: 0x00023804 File Offset: 0x00021A04
		public unsafe bool All
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemList.NativeFieldInfoPtr_All);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemList.NativeFieldInfoPtr_All)) = value;
			}
		}

		// Token: 0x17001617 RID: 5655
		// (get) Token: 0x060049B7 RID: 18871 RVA: 0x00166F60 File Offset: 0x00165160
		// (set) Token: 0x060049B8 RID: 18872 RVA: 0x0002381F File Offset: 0x00021A1F
		public unsafe bool None
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemList.NativeFieldInfoPtr_None);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemList.NativeFieldInfoPtr_None)) = value;
			}
		}

		// Token: 0x17001618 RID: 5656
		// (get) Token: 0x060049B9 RID: 18873 RVA: 0x00166F88 File Offset: 0x00165188
		// (set) Token: 0x060049BA RID: 18874 RVA: 0x0002383A File Offset: 0x00021A3A
		public unsafe List<string> Selection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemList.NativeFieldInfoPtr_Selection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemList.NativeFieldInfoPtr_Selection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001619 RID: 5657
		// (get) Token: 0x060049BB RID: 18875 RVA: 0x00166FB8 File Offset: 0x001651B8
		// (set) Token: 0x060049BC RID: 18876 RVA: 0x00023859 File Offset: 0x00021A59
		public unsafe bool _CanBeAll_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemList.NativeFieldInfoPtr__CanBeAll_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemList.NativeFieldInfoPtr__CanBeAll_k__BackingField)) = value;
			}
		}

		// Token: 0x1700161A RID: 5658
		// (get) Token: 0x060049BD RID: 18877 RVA: 0x00166FE0 File Offset: 0x001651E0
		// (set) Token: 0x060049BE RID: 18878 RVA: 0x00023874 File Offset: 0x00021A74
		public unsafe bool _CanBeNone_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemList.NativeFieldInfoPtr__CanBeNone_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemList.NativeFieldInfoPtr__CanBeNone_k__BackingField)) = value;
			}
		}

		// Token: 0x1700161B RID: 5659
		// (get) Token: 0x060049BF RID: 18879 RVA: 0x00167008 File Offset: 0x00165208
		// (set) Token: 0x060049C0 RID: 18880 RVA: 0x0002388F File Offset: 0x00021A8F
		public unsafe List<string> _OptionList_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemList.NativeFieldInfoPtr__OptionList_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemList.NativeFieldInfoPtr__OptionList_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031AD RID: 12717
		private static readonly IntPtr NativeFieldInfoPtr_All;

		// Token: 0x040031AE RID: 12718
		private static readonly IntPtr NativeFieldInfoPtr_None;

		// Token: 0x040031AF RID: 12719
		private static readonly IntPtr NativeFieldInfoPtr_Selection;

		// Token: 0x040031B0 RID: 12720
		private static readonly IntPtr NativeFieldInfoPtr__CanBeAll_k__BackingField;

		// Token: 0x040031B1 RID: 12721
		private static readonly IntPtr NativeFieldInfoPtr__CanBeNone_k__BackingField;

		// Token: 0x040031B2 RID: 12722
		private static readonly IntPtr NativeFieldInfoPtr__OptionList_k__BackingField;

		// Token: 0x040031B3 RID: 12723
		private static readonly IntPtr NativeMethodInfoPtr_get_CanBeAll_Public_get_Boolean_0;

		// Token: 0x040031B4 RID: 12724
		private static readonly IntPtr NativeMethodInfoPtr_set_CanBeAll_Protected_set_Void_Boolean_0;

		// Token: 0x040031B5 RID: 12725
		private static readonly IntPtr NativeMethodInfoPtr_get_CanBeNone_Public_get_Boolean_0;

		// Token: 0x040031B6 RID: 12726
		private static readonly IntPtr NativeMethodInfoPtr_set_CanBeNone_Protected_set_Void_Boolean_0;

		// Token: 0x040031B7 RID: 12727
		private static readonly IntPtr NativeMethodInfoPtr_get_OptionList_Public_get_List_1_String_0;

		// Token: 0x040031B8 RID: 12728
		private static readonly IntPtr NativeMethodInfoPtr_set_OptionList_Protected_set_Void_List_1_String_0;

		// Token: 0x040031B9 RID: 12729
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_List_1_String_Boolean_Boolean_0;

		// Token: 0x040031BA RID: 12730
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Option_0;

		// Token: 0x040031BB RID: 12731
		private static readonly IntPtr NativeMethodInfoPtr_GetDisplayString_Public_Virtual_String_0;
	}
}
