using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.UI.Management;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x02000397 RID: 919
	public class ObjectListField : ConfigField
	{
		// Token: 0x06004822 RID: 18466 RVA: 0x00160FF0 File Offset: 0x0015F1F0
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectListField()
		{
			Il2CppClassPointerStore<ObjectListField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "ObjectListField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr);
			ObjectListField.NativeFieldInfoPtr_SelectedObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, "SelectedObjects");
			ObjectListField.NativeFieldInfoPtr_MaxItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, "MaxItems");
			ObjectListField.NativeFieldInfoPtr_objectFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, "objectFilter");
			ObjectListField.NativeFieldInfoPtr_TypeRequirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, "TypeRequirements");
			ObjectListField.NativeFieldInfoPtr_onListChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, "onListChanged");
			ObjectListField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, 100672210);
			ObjectListField.NativeMethodInfoPtr_SetList_Public_Void_List_1_BuildableItem_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, 100672211);
			ObjectListField.NativeMethodInfoPtr_AddItem_Public_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, 100672212);
			ObjectListField.NativeMethodInfoPtr_RemoveItem_Public_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, 100672213);
			ObjectListField.NativeMethodInfoPtr_SelectedObjectDestroyed_Private_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, 100672214);
			ObjectListField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, 100672215);
			ObjectListField.NativeMethodInfoPtr_GetData_Public_ObjectListFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, 100672216);
			ObjectListField.NativeMethodInfoPtr_Load_Public_Void_ObjectListFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, 100672217);
		}

		// Token: 0x06004823 RID: 18467 RVA: 0x00161124 File Offset: 0x0015F324
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 161786, RefRangeEnd = 161790, XrefRangeStart = 161764, XrefRangeEnd = 161786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectListField(EntityConfiguration parentConfig) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentConfig);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004824 RID: 18468 RVA: 0x00161170 File Offset: 0x0015F370
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 161850, RefRangeEnd = 161855, XrefRangeStart = 161790, XrefRangeEnd = 161850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetList(List<BuildableItem> list, bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListField.NativeMethodInfoPtr_SetList_Public_Void_List_1_BuildableItem_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004825 RID: 18469 RVA: 0x001611C0 File Offset: 0x0015F3C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161855, XrefRangeEnd = 161872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddItem(BuildableItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListField.NativeMethodInfoPtr_AddItem_Public_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004826 RID: 18470 RVA: 0x00161204 File Offset: 0x0015F404
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 161885, RefRangeEnd = 161887, XrefRangeStart = 161872, XrefRangeEnd = 161885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveItem(BuildableItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListField.NativeMethodInfoPtr_RemoveItem_Public_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004827 RID: 18471 RVA: 0x00161248 File Offset: 0x0015F448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161887, XrefRangeEnd = 161900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectedObjectDestroyed(BuildableItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListField.NativeMethodInfoPtr_SelectedObjectDestroyed_Private_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004828 RID: 18472 RVA: 0x0016128C File Offset: 0x0015F48C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161900, XrefRangeEnd = 161901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsValueDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectListField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004829 RID: 18473 RVA: 0x001612D4 File Offset: 0x0015F4D4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 161922, RefRangeEnd = 161926, XrefRangeStart = 161901, XrefRangeEnd = 161922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectListFieldData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListField.NativeMethodInfoPtr_GetData_Public_ObjectListFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectListFieldData>(intPtr3) : null;
		}

		// Token: 0x0600482A RID: 18474 RVA: 0x00161314 File Offset: 0x0015F514
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 161955, RefRangeEnd = 161959, XrefRangeStart = 161926, XrefRangeEnd = 161955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(ObjectListFieldData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListField.NativeMethodInfoPtr_Load_Public_Void_ObjectListFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600482B RID: 18475 RVA: 0x00022E55 File Offset: 0x00021055
		public ObjectListField(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170015A3 RID: 5539
		// (get) Token: 0x0600482C RID: 18476 RVA: 0x00161358 File Offset: 0x0015F558
		// (set) Token: 0x0600482D RID: 18477 RVA: 0x00022E5E File Offset: 0x0002105E
		public unsafe List<BuildableItem> SelectedObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListField.NativeFieldInfoPtr_SelectedObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BuildableItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListField.NativeFieldInfoPtr_SelectedObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015A4 RID: 5540
		// (get) Token: 0x0600482E RID: 18478 RVA: 0x00161388 File Offset: 0x0015F588
		// (set) Token: 0x0600482F RID: 18479 RVA: 0x00022E7D File Offset: 0x0002107D
		public unsafe int MaxItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListField.NativeFieldInfoPtr_MaxItems);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListField.NativeFieldInfoPtr_MaxItems)) = value;
			}
		}

		// Token: 0x170015A5 RID: 5541
		// (get) Token: 0x06004830 RID: 18480 RVA: 0x001613B0 File Offset: 0x0015F5B0
		// (set) Token: 0x06004831 RID: 18481 RVA: 0x00022E98 File Offset: 0x00021098
		public unsafe ObjectSelector.ObjectFilter objectFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListField.NativeFieldInfoPtr_objectFilter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectSelector.ObjectFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListField.NativeFieldInfoPtr_objectFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015A6 RID: 5542
		// (get) Token: 0x06004832 RID: 18482 RVA: 0x001613E0 File Offset: 0x0015F5E0
		// (set) Token: 0x06004833 RID: 18483 RVA: 0x00022EB7 File Offset: 0x000210B7
		public unsafe List<Type> TypeRequirements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListField.NativeFieldInfoPtr_TypeRequirements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListField.NativeFieldInfoPtr_TypeRequirements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015A7 RID: 5543
		// (get) Token: 0x06004834 RID: 18484 RVA: 0x00161410 File Offset: 0x0015F610
		// (set) Token: 0x06004835 RID: 18485 RVA: 0x00022ED6 File Offset: 0x000210D6
		public unsafe UnityEvent<List<BuildableItem>> onListChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListField.NativeFieldInfoPtr_onListChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<List<BuildableItem>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListField.NativeFieldInfoPtr_onListChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400309C RID: 12444
		private static readonly IntPtr NativeFieldInfoPtr_SelectedObjects;

		// Token: 0x0400309D RID: 12445
		private static readonly IntPtr NativeFieldInfoPtr_MaxItems;

		// Token: 0x0400309E RID: 12446
		private static readonly IntPtr NativeFieldInfoPtr_objectFilter;

		// Token: 0x0400309F RID: 12447
		private static readonly IntPtr NativeFieldInfoPtr_TypeRequirements;

		// Token: 0x040030A0 RID: 12448
		private static readonly IntPtr NativeFieldInfoPtr_onListChanged;

		// Token: 0x040030A1 RID: 12449
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0;

		// Token: 0x040030A2 RID: 12450
		private static readonly IntPtr NativeMethodInfoPtr_SetList_Public_Void_List_1_BuildableItem_Boolean_0;

		// Token: 0x040030A3 RID: 12451
		private static readonly IntPtr NativeMethodInfoPtr_AddItem_Public_Void_BuildableItem_0;

		// Token: 0x040030A4 RID: 12452
		private static readonly IntPtr NativeMethodInfoPtr_RemoveItem_Public_Void_BuildableItem_0;

		// Token: 0x040030A5 RID: 12453
		private static readonly IntPtr NativeMethodInfoPtr_SelectedObjectDestroyed_Private_Void_BuildableItem_0;

		// Token: 0x040030A6 RID: 12454
		private static readonly IntPtr NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0;

		// Token: 0x040030A7 RID: 12455
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_ObjectListFieldData_0;

		// Token: 0x040030A8 RID: 12456
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_ObjectListFieldData_0;
	}
}
