using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Storage;
using Il2CppScheduleOne.Trash;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.ObjectScripts.WateringCan
{
	// Token: 0x0200075A RID: 1882
	[Serializable]
	public class TrashGrabberInstance : StorableItemInstance
	{
		// Token: 0x0600B333 RID: 45875 RVA: 0x002CB390 File Offset: 0x002C9590
		// Note: this type is marked as 'beforefieldinit'.
		static TrashGrabberInstance()
		{
			Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts.WateringCan", "TrashGrabberInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr);
			TrashGrabberInstance.NativeFieldInfoPtr_TRASH_CAPACITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, "TRASH_CAPACITY");
			TrashGrabberInstance.NativeFieldInfoPtr_Content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, "Content");
			TrashGrabberInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100685398);
			TrashGrabberInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100685399);
			TrashGrabberInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100685400);
			TrashGrabberInstance.NativeMethodInfoPtr_LoadContentData_Public_Void_TrashContentData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100685401);
			TrashGrabberInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100685402);
			TrashGrabberInstance.NativeMethodInfoPtr_AddTrash_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100685403);
			TrashGrabberInstance.NativeMethodInfoPtr_RemoveTrash_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100685404);
			TrashGrabberInstance.NativeMethodInfoPtr_ClearTrash_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100685405);
			TrashGrabberInstance.NativeMethodInfoPtr_GetTotalSize_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100685406);
			TrashGrabberInstance.NativeMethodInfoPtr_GetTrashIDs_Public_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100685407);
			TrashGrabberInstance.NativeMethodInfoPtr_GetTrashQuantities_Public_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100685408);
			TrashGrabberInstance.NativeMethodInfoPtr_GetTrashUshortQuantities_Public_List_1_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100685409);
		}

		// Token: 0x0600B334 RID: 45876 RVA: 0x002CB4D8 File Offset: 0x002C96D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308729, RefRangeEnd = 308730, XrefRangeStart = 308723, XrefRangeEnd = 308729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashGrabberInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGrabberInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B335 RID: 45877 RVA: 0x002CB514 File Offset: 0x002C9714
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 308736, RefRangeEnd = 308739, XrefRangeStart = 308730, XrefRangeEnd = 308736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashGrabberInstance(ItemDefinition definition, int quantity) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGrabberInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B336 RID: 45878 RVA: 0x002CB570 File Offset: 0x002C9770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308739, XrefRangeEnd = 308746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref overrideQuantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashGrabberInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x0600B337 RID: 45879 RVA: 0x002CB5C8 File Offset: 0x002C97C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308748, RefRangeEnd = 308749, XrefRangeStart = 308746, XrefRangeEnd = 308748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadContentData(TrashContentData content)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGrabberInstance.NativeMethodInfoPtr_LoadContentData_Public_Void_TrashContentData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B338 RID: 45880 RVA: 0x002CB60C File Offset: 0x002C980C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308749, XrefRangeEnd = 308754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemData GetItemData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashGrabberInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemData>(intPtr3) : null;
		}

		// Token: 0x0600B339 RID: 45881 RVA: 0x002CB658 File Offset: 0x002C9858
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 308757, RefRangeEnd = 308759, XrefRangeStart = 308754, XrefRangeEnd = 308757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTrash(string id, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGrabberInstance.NativeMethodInfoPtr_AddTrash_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B33A RID: 45882 RVA: 0x002CB6A8 File Offset: 0x002C98A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 308762, RefRangeEnd = 308764, XrefRangeStart = 308759, XrefRangeEnd = 308762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveTrash(string id, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGrabberInstance.NativeMethodInfoPtr_RemoveTrash_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B33B RID: 45883 RVA: 0x002CB6F8 File Offset: 0x002C98F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308764, XrefRangeEnd = 308767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearTrash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGrabberInstance.NativeMethodInfoPtr_ClearTrash_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B33C RID: 45884 RVA: 0x002CB72C File Offset: 0x002C992C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 308769, RefRangeEnd = 308776, XrefRangeStart = 308767, XrefRangeEnd = 308769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTotalSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGrabberInstance.NativeMethodInfoPtr_GetTotalSize_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B33D RID: 45885 RVA: 0x002CB768 File Offset: 0x002C9968
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 308801, RefRangeEnd = 308804, XrefRangeStart = 308776, XrefRangeEnd = 308801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<string> GetTrashIDs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGrabberInstance.NativeMethodInfoPtr_GetTrashIDs_Public_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x0600B33E RID: 45886 RVA: 0x002CB7A8 File Offset: 0x002C99A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308804, XrefRangeEnd = 308828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<int> GetTrashQuantities()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGrabberInstance.NativeMethodInfoPtr_GetTrashQuantities_Public_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
		}

		// Token: 0x0600B33F RID: 45887 RVA: 0x002CB7E8 File Offset: 0x002C99E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308852, RefRangeEnd = 308853, XrefRangeStart = 308828, XrefRangeEnd = 308852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ushort> GetTrashUshortQuantities()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGrabberInstance.NativeMethodInfoPtr_GetTrashUshortQuantities_Public_List_1_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ushort>>(intPtr3) : null;
		}

		// Token: 0x0600B340 RID: 45888 RVA: 0x00057D42 File Offset: 0x00055F42
		public TrashGrabberInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003792 RID: 14226
		// (get) Token: 0x0600B341 RID: 45889 RVA: 0x002CB828 File Offset: 0x002C9A28
		// (set) Token: 0x0600B342 RID: 45890 RVA: 0x00057D4B File Offset: 0x00055F4B
		public unsafe static int TRASH_CAPACITY
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(TrashGrabberInstance.NativeFieldInfoPtr_TRASH_CAPACITY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashGrabberInstance.NativeFieldInfoPtr_TRASH_CAPACITY, (void*)(&value));
			}
		}

		// Token: 0x17003793 RID: 14227
		// (get) Token: 0x0600B343 RID: 45891 RVA: 0x002CB844 File Offset: 0x002C9A44
		// (set) Token: 0x0600B344 RID: 45892 RVA: 0x00057D59 File Offset: 0x00055F59
		public unsafe TrashContent Content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGrabberInstance.NativeFieldInfoPtr_Content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashContent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGrabberInstance.NativeFieldInfoPtr_Content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040078E7 RID: 30951
		private static readonly IntPtr NativeFieldInfoPtr_TRASH_CAPACITY;

		// Token: 0x040078E8 RID: 30952
		private static readonly IntPtr NativeFieldInfoPtr_Content;

		// Token: 0x040078E9 RID: 30953
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040078EA RID: 30954
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_0;

		// Token: 0x040078EB RID: 30955
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x040078EC RID: 30956
		private static readonly IntPtr NativeMethodInfoPtr_LoadContentData_Public_Void_TrashContentData_0;

		// Token: 0x040078ED RID: 30957
		private static readonly IntPtr NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0;

		// Token: 0x040078EE RID: 30958
		private static readonly IntPtr NativeMethodInfoPtr_AddTrash_Public_Void_String_Int32_0;

		// Token: 0x040078EF RID: 30959
		private static readonly IntPtr NativeMethodInfoPtr_RemoveTrash_Public_Void_String_Int32_0;

		// Token: 0x040078F0 RID: 30960
		private static readonly IntPtr NativeMethodInfoPtr_ClearTrash_Public_Void_0;

		// Token: 0x040078F1 RID: 30961
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalSize_Public_Int32_0;

		// Token: 0x040078F2 RID: 30962
		private static readonly IntPtr NativeMethodInfoPtr_GetTrashIDs_Public_List_1_String_0;

		// Token: 0x040078F3 RID: 30963
		private static readonly IntPtr NativeMethodInfoPtr_GetTrashQuantities_Public_List_1_Int32_0;

		// Token: 0x040078F4 RID: 30964
		private static readonly IntPtr NativeMethodInfoPtr_GetTrashUshortQuantities_Public_List_1_UInt16_0;
	}
}
