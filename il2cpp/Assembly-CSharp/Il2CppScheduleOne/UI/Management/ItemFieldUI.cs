using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Management;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006C6 RID: 1734
	public class ItemFieldUI : MonoBehaviour
	{
		// Token: 0x06009BAF RID: 39855 RVA: 0x00277B80 File Offset: 0x00275D80
		// Note: this type is marked as 'beforefieldinit'.
		static ItemFieldUI()
		{
			Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "ItemFieldUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr);
			ItemFieldUI.NativeFieldInfoPtr__Fields_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, "<Fields>k__BackingField");
			ItemFieldUI.NativeFieldInfoPtr_ShowNoneAsAny = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, "ShowNoneAsAny");
			ItemFieldUI.NativeFieldInfoPtr_FieldLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, "FieldLabel");
			ItemFieldUI.NativeFieldInfoPtr_IconImg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, "IconImg");
			ItemFieldUI.NativeFieldInfoPtr_SelectionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, "SelectionLabel");
			ItemFieldUI.NativeFieldInfoPtr_NoneSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, "NoneSelected");
			ItemFieldUI.NativeFieldInfoPtr_MultipleSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, "MultipleSelected");
			ItemFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_ItemField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, 100682422);
			ItemFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_ItemField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, 100682423);
			ItemFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_ItemField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, 100682424);
			ItemFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, 100682425);
			ItemFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, 100682426);
			ItemFieldUI.NativeMethodInfoPtr_Clicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, 100682427);
			ItemFieldUI.NativeMethodInfoPtr_OptionSelected_Private_Void_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, 100682428);
			ItemFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, 100682429);
		}

		// Token: 0x17002FF3 RID: 12275
		// (get) Token: 0x06009BB0 RID: 39856 RVA: 0x00277CDC File Offset: 0x00275EDC
		// (set) Token: 0x06009BB1 RID: 39857 RVA: 0x00277D1C File Offset: 0x00275F1C
		public unsafe List<ItemField> Fields
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17399, RefRangeEnd = 17400, XrefRangeStart = 17399, XrefRangeEnd = 17400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_ItemField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemField>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_ItemField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009BB2 RID: 39858 RVA: 0x00277D60 File Offset: 0x00275F60
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 276584, RefRangeEnd = 276588, XrefRangeStart = 276557, XrefRangeEnd = 276584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Bind(List<ItemField> field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_ItemField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BB3 RID: 39859 RVA: 0x00277DA4 File Offset: 0x00275FA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 276611, RefRangeEnd = 276612, XrefRangeStart = 276588, XrefRangeEnd = 276611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh(ItemDefinition newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newVal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BB4 RID: 39860 RVA: 0x00277DE8 File Offset: 0x00275FE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 276623, RefRangeEnd = 276625, XrefRangeStart = 276612, XrefRangeEnd = 276623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreFieldsUniform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009BB5 RID: 39861 RVA: 0x00277E24 File Offset: 0x00276024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276625, XrefRangeEnd = 276697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFieldUI.NativeMethodInfoPtr_Clicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BB6 RID: 39862 RVA: 0x00277E58 File Offset: 0x00276058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276697, XrefRangeEnd = 276712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OptionSelected(ItemSelector.Option option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFieldUI.NativeMethodInfoPtr_OptionSelected_Private_Void_Option_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BB7 RID: 39863 RVA: 0x00277E9C File Offset: 0x0027609C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276712, XrefRangeEnd = 276720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemFieldUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BB8 RID: 39864 RVA: 0x0004C42F File Offset: 0x0004A62F
		public ItemFieldUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002FEC RID: 12268
		// (get) Token: 0x06009BB9 RID: 39865 RVA: 0x00277ED8 File Offset: 0x002760D8
		// (set) Token: 0x06009BBA RID: 39866 RVA: 0x0004C438 File Offset: 0x0004A638
		public unsafe List<ItemField> _Fields_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr__Fields_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemField>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr__Fields_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FED RID: 12269
		// (get) Token: 0x06009BBB RID: 39867 RVA: 0x00277F08 File Offset: 0x00276108
		// (set) Token: 0x06009BBC RID: 39868 RVA: 0x0004C457 File Offset: 0x0004A657
		public unsafe bool ShowNoneAsAny
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr_ShowNoneAsAny);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr_ShowNoneAsAny)) = value;
			}
		}

		// Token: 0x17002FEE RID: 12270
		// (get) Token: 0x06009BBD RID: 39869 RVA: 0x00277F30 File Offset: 0x00276130
		// (set) Token: 0x06009BBE RID: 39870 RVA: 0x0004C472 File Offset: 0x0004A672
		public unsafe TextMeshProUGUI FieldLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr_FieldLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr_FieldLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FEF RID: 12271
		// (get) Token: 0x06009BBF RID: 39871 RVA: 0x00277F60 File Offset: 0x00276160
		// (set) Token: 0x06009BC0 RID: 39872 RVA: 0x0004C491 File Offset: 0x0004A691
		public unsafe Image IconImg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr_IconImg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr_IconImg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FF0 RID: 12272
		// (get) Token: 0x06009BC1 RID: 39873 RVA: 0x00277F90 File Offset: 0x00276190
		// (set) Token: 0x06009BC2 RID: 39874 RVA: 0x0004C4B0 File Offset: 0x0004A6B0
		public unsafe TextMeshProUGUI SelectionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr_SelectionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr_SelectionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FF1 RID: 12273
		// (get) Token: 0x06009BC3 RID: 39875 RVA: 0x00277FC0 File Offset: 0x002761C0
		// (set) Token: 0x06009BC4 RID: 39876 RVA: 0x0004C4CF File Offset: 0x0004A6CF
		public unsafe GameObject NoneSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr_NoneSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr_NoneSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FF2 RID: 12274
		// (get) Token: 0x06009BC5 RID: 39877 RVA: 0x00277FF0 File Offset: 0x002761F0
		// (set) Token: 0x06009BC6 RID: 39878 RVA: 0x0004C4EE File Offset: 0x0004A6EE
		public unsafe GameObject MultipleSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr_MultipleSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr_MultipleSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400689A RID: 26778
		private static readonly IntPtr NativeFieldInfoPtr__Fields_k__BackingField;

		// Token: 0x0400689B RID: 26779
		private static readonly IntPtr NativeFieldInfoPtr_ShowNoneAsAny;

		// Token: 0x0400689C RID: 26780
		private static readonly IntPtr NativeFieldInfoPtr_FieldLabel;

		// Token: 0x0400689D RID: 26781
		private static readonly IntPtr NativeFieldInfoPtr_IconImg;

		// Token: 0x0400689E RID: 26782
		private static readonly IntPtr NativeFieldInfoPtr_SelectionLabel;

		// Token: 0x0400689F RID: 26783
		private static readonly IntPtr NativeFieldInfoPtr_NoneSelected;

		// Token: 0x040068A0 RID: 26784
		private static readonly IntPtr NativeFieldInfoPtr_MultipleSelected;

		// Token: 0x040068A1 RID: 26785
		private static readonly IntPtr NativeMethodInfoPtr_get_Fields_Public_get_List_1_ItemField_0;

		// Token: 0x040068A2 RID: 26786
		private static readonly IntPtr NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_ItemField_0;

		// Token: 0x040068A3 RID: 26787
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Void_List_1_ItemField_0;

		// Token: 0x040068A4 RID: 26788
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Private_Void_ItemDefinition_0;

		// Token: 0x040068A5 RID: 26789
		private static readonly IntPtr NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0;

		// Token: 0x040068A6 RID: 26790
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Public_Void_0;

		// Token: 0x040068A7 RID: 26791
		private static readonly IntPtr NativeMethodInfoPtr_OptionSelected_Private_Void_Option_0;

		// Token: 0x040068A8 RID: 26792
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
