using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x02000393 RID: 915
	public class ItemField : ConfigField
	{
		// Token: 0x060047D5 RID: 18389 RVA: 0x0015FEAC File Offset: 0x0015E0AC
		// Note: this type is marked as 'beforefieldinit'.
		static ItemField()
		{
			Il2CppClassPointerStore<ItemField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "ItemField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemField>.NativeClassPtr);
			ItemField.NativeFieldInfoPtr__SelectedItem_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemField>.NativeClassPtr, "<SelectedItem>k__BackingField");
			ItemField.NativeFieldInfoPtr_CanSelectNone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemField>.NativeClassPtr, "CanSelectNone");
			ItemField.NativeFieldInfoPtr_Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemField>.NativeClassPtr, "Options");
			ItemField.NativeFieldInfoPtr_onItemChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemField>.NativeClassPtr, "onItemChanged");
			ItemField.NativeMethodInfoPtr_get_SelectedItem_Public_get_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemField>.NativeClassPtr, 100672175);
			ItemField.NativeMethodInfoPtr_set_SelectedItem_Protected_set_Void_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemField>.NativeClassPtr, 100672176);
			ItemField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemField>.NativeClassPtr, 100672177);
			ItemField.NativeMethodInfoPtr_SetItem_Public_Void_ItemDefinition_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemField>.NativeClassPtr, 100672178);
			ItemField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemField>.NativeClassPtr, 100672179);
			ItemField.NativeMethodInfoPtr_GetData_Public_ItemFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemField>.NativeClassPtr, 100672180);
			ItemField.NativeMethodInfoPtr_Load_Public_Void_ItemFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemField>.NativeClassPtr, 100672181);
		}

		// Token: 0x17001590 RID: 5520
		// (get) Token: 0x060047D6 RID: 18390 RVA: 0x0015FFB8 File Offset: 0x0015E1B8
		// (set) Token: 0x060047D7 RID: 18391 RVA: 0x0015FFF8 File Offset: 0x0015E1F8
		public unsafe ItemDefinition SelectedItem
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemField.NativeMethodInfoPtr_get_SelectedItem_Public_get_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemField.NativeMethodInfoPtr_set_SelectedItem_Protected_set_Void_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060047D8 RID: 18392 RVA: 0x0016003C File Offset: 0x0015E23C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 161510, RefRangeEnd = 161514, XrefRangeStart = 161495, XrefRangeEnd = 161510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemField(EntityConfiguration parentConfig) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemField>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentConfig);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047D9 RID: 18393 RVA: 0x00160088 File Offset: 0x0015E288
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 161519, RefRangeEnd = 161521, XrefRangeStart = 161514, XrefRangeEnd = 161519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetItem(ItemDefinition item, bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemField.NativeMethodInfoPtr_SetItem_Public_Void_ItemDefinition_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047DA RID: 18394 RVA: 0x001600D8 File Offset: 0x0015E2D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161521, XrefRangeEnd = 161525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsValueDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047DB RID: 18395 RVA: 0x00160120 File Offset: 0x0015E320
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 161536, RefRangeEnd = 161540, XrefRangeStart = 161525, XrefRangeEnd = 161536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemFieldData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemField.NativeMethodInfoPtr_GetData_Public_ItemFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemFieldData>(intPtr3) : null;
		}

		// Token: 0x060047DC RID: 18396 RVA: 0x00160160 File Offset: 0x0015E360
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 161547, RefRangeEnd = 161551, XrefRangeStart = 161540, XrefRangeEnd = 161547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(ItemFieldData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemField.NativeMethodInfoPtr_Load_Public_Void_ItemFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047DD RID: 18397 RVA: 0x00022C3A File Offset: 0x00020E3A
		public ItemField(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700158C RID: 5516
		// (get) Token: 0x060047DE RID: 18398 RVA: 0x001601A4 File Offset: 0x0015E3A4
		// (set) Token: 0x060047DF RID: 18399 RVA: 0x00022C43 File Offset: 0x00020E43
		public unsafe ItemDefinition _SelectedItem_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemField.NativeFieldInfoPtr__SelectedItem_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemField.NativeFieldInfoPtr__SelectedItem_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700158D RID: 5517
		// (get) Token: 0x060047E0 RID: 18400 RVA: 0x001601D4 File Offset: 0x0015E3D4
		// (set) Token: 0x060047E1 RID: 18401 RVA: 0x00022C62 File Offset: 0x00020E62
		public unsafe bool CanSelectNone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemField.NativeFieldInfoPtr_CanSelectNone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemField.NativeFieldInfoPtr_CanSelectNone)) = value;
			}
		}

		// Token: 0x1700158E RID: 5518
		// (get) Token: 0x060047E2 RID: 18402 RVA: 0x001601FC File Offset: 0x0015E3FC
		// (set) Token: 0x060047E3 RID: 18403 RVA: 0x00022C7D File Offset: 0x00020E7D
		public unsafe List<ItemDefinition> Options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemField.NativeFieldInfoPtr_Options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemField.NativeFieldInfoPtr_Options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700158F RID: 5519
		// (get) Token: 0x060047E4 RID: 18404 RVA: 0x0016022C File Offset: 0x0015E42C
		// (set) Token: 0x060047E5 RID: 18405 RVA: 0x00022C9C File Offset: 0x00020E9C
		public unsafe UnityEvent<ItemDefinition> onItemChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemField.NativeFieldInfoPtr_onItemChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<ItemDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemField.NativeFieldInfoPtr_onItemChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003068 RID: 12392
		private static readonly IntPtr NativeFieldInfoPtr__SelectedItem_k__BackingField;

		// Token: 0x04003069 RID: 12393
		private static readonly IntPtr NativeFieldInfoPtr_CanSelectNone;

		// Token: 0x0400306A RID: 12394
		private static readonly IntPtr NativeFieldInfoPtr_Options;

		// Token: 0x0400306B RID: 12395
		private static readonly IntPtr NativeFieldInfoPtr_onItemChanged;

		// Token: 0x0400306C RID: 12396
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedItem_Public_get_ItemDefinition_0;

		// Token: 0x0400306D RID: 12397
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectedItem_Protected_set_Void_ItemDefinition_0;

		// Token: 0x0400306E RID: 12398
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0;

		// Token: 0x0400306F RID: 12399
		private static readonly IntPtr NativeMethodInfoPtr_SetItem_Public_Void_ItemDefinition_Boolean_0;

		// Token: 0x04003070 RID: 12400
		private static readonly IntPtr NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0;

		// Token: 0x04003071 RID: 12401
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_ItemFieldData_0;

		// Token: 0x04003072 RID: 12402
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_ItemFieldData_0;
	}
}
