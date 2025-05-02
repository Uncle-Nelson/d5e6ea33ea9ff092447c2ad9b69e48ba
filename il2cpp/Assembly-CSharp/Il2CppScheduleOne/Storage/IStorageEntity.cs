using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x0200056E RID: 1390
	public class IStorageEntity : Il2CppObjectBase
	{
		// Token: 0x06007A21 RID: 31265 RVA: 0x0020DD80 File Offset: 0x0020BF80
		// Note: this type is marked as 'beforefieldinit'.
		static IStorageEntity()
		{
			Il2CppClassPointerStore<IStorageEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "IStorageEntity");
			IStorageEntity.NativeMethodInfoPtr_get_storedItemContainer_Public_Abstract_Virtual_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity>.NativeClassPtr, 100678569);
			IStorageEntity.NativeMethodInfoPtr_get_reservedItems_Public_Abstract_Virtual_New_get_Dictionary_2_StoredItem_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity>.NativeClassPtr, 100678570);
			IStorageEntity.NativeMethodInfoPtr_GetStoredItems_Public_Abstract_Virtual_New_List_1_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity>.NativeClassPtr, 100678571);
			IStorageEntity.NativeMethodInfoPtr_GetStorageGrids_Public_Abstract_Virtual_New_List_1_StorageGrid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity>.NativeClassPtr, 100678572);
			IStorageEntity.NativeMethodInfoPtr_GetStoredItemsByID_Public_Virtual_New_List_1_StoredItem_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity>.NativeClassPtr, 100678573);
			IStorageEntity.NativeMethodInfoPtr_ReserveItem_Public_Virtual_New_Void_StoredItem_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity>.NativeClassPtr, 100678574);
			IStorageEntity.NativeMethodInfoPtr_DereserveItem_Public_Virtual_New_Void_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity>.NativeClassPtr, 100678575);
			IStorageEntity.NativeMethodInfoPtr_IsItemReserved_Public_Virtual_New_Boolean_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity>.NativeClassPtr, 100678576);
			IStorageEntity.NativeMethodInfoPtr_WhoIsReserving_Public_Virtual_New_Employee_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity>.NativeClassPtr, 100678577);
			IStorageEntity.NativeMethodInfoPtr_GetNonReservedItemsByPrefabID_Public_Virtual_New_List_1_StoredItem_String_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity>.NativeClassPtr, 100678578);
			IStorageEntity.NativeMethodInfoPtr_ClearReserve_Public_Virtual_New_IEnumerator_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity>.NativeClassPtr, 100678579);
			IStorageEntity.NativeMethodInfoPtr_TryFitItem_Public_Virtual_New_Boolean_Int32_Int32_byref_StorageGrid_byref_Coordinate_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity>.NativeClassPtr, 100678580);
			IStorageEntity.NativeMethodInfoPtr_HowManyCanFit_Public_Virtual_New_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity>.NativeClassPtr, 100678581);
		}

		// Token: 0x170024FA RID: 9466
		// (get) Token: 0x06007A22 RID: 31266 RVA: 0x0020DEAC File Offset: 0x0020C0AC
		public unsafe virtual Transform storedItemContainer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStorageEntity.NativeMethodInfoPtr_get_storedItemContainer_Public_Abstract_Virtual_New_get_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x170024FB RID: 9467
		// (get) Token: 0x06007A23 RID: 31267 RVA: 0x0020DEF8 File Offset: 0x0020C0F8
		public unsafe virtual Dictionary<StoredItem, Employee> reservedItems
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStorageEntity.NativeMethodInfoPtr_get_reservedItems_Public_Abstract_Virtual_New_get_Dictionary_2_StoredItem_Employee_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<StoredItem, Employee>>(intPtr3) : null;
			}
		}

		// Token: 0x06007A24 RID: 31268 RVA: 0x0020DF44 File Offset: 0x0020C144
		[CallerCount(0)]
		public unsafe virtual List<StoredItem> GetStoredItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStorageEntity.NativeMethodInfoPtr_GetStoredItems_Public_Abstract_Virtual_New_List_1_StoredItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<StoredItem>>(intPtr3) : null;
		}

		// Token: 0x06007A25 RID: 31269 RVA: 0x0020DF90 File Offset: 0x0020C190
		[CallerCount(0)]
		public unsafe virtual List<StorageGrid> GetStorageGrids()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStorageEntity.NativeMethodInfoPtr_GetStorageGrids_Public_Abstract_Virtual_New_List_1_StorageGrid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<StorageGrid>>(intPtr3) : null;
		}

		// Token: 0x06007A26 RID: 31270 RVA: 0x0020DFDC File Offset: 0x0020C1DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233800, XrefRangeEnd = 233821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<StoredItem> GetStoredItemsByID(string ID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStorageEntity.NativeMethodInfoPtr_GetStoredItemsByID_Public_Virtual_New_List_1_StoredItem_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<StoredItem>>(intPtr3) : null;
		}

		// Token: 0x06007A27 RID: 31271 RVA: 0x0020E038 File Offset: 0x0020C238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233821, XrefRangeEnd = 233838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ReserveItem(StoredItem item, Employee employee)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(employee);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStorageEntity.NativeMethodInfoPtr_ReserveItem_Public_Virtual_New_Void_StoredItem_Employee_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A28 RID: 31272 RVA: 0x0020E098 File Offset: 0x0020C298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233838, XrefRangeEnd = 233849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DereserveItem(StoredItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStorageEntity.NativeMethodInfoPtr_DereserveItem_Public_Virtual_New_Void_StoredItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A29 RID: 31273 RVA: 0x0020E0E8 File Offset: 0x0020C2E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233849, XrefRangeEnd = 233856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsItemReserved(StoredItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStorageEntity.NativeMethodInfoPtr_IsItemReserved_Public_Virtual_New_Boolean_StoredItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007A2A RID: 31274 RVA: 0x0020E140 File Offset: 0x0020C340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233856, XrefRangeEnd = 233863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Employee WhoIsReserving(StoredItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStorageEntity.NativeMethodInfoPtr_WhoIsReserving_Public_Virtual_New_Employee_StoredItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Employee>(intPtr3) : null;
		}

		// Token: 0x06007A2B RID: 31275 RVA: 0x0020E19C File Offset: 0x0020C39C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233863, XrefRangeEnd = 233893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<StoredItem> GetNonReservedItemsByPrefabID(string prefabID, Employee whosAskin)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(prefabID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(whosAskin);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStorageEntity.NativeMethodInfoPtr_GetNonReservedItemsByPrefabID_Public_Virtual_New_List_1_StoredItem_String_Employee_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<StoredItem>>(intPtr3) : null;
		}

		// Token: 0x06007A2C RID: 31276 RVA: 0x0020E20C File Offset: 0x0020C40C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233893, XrefRangeEnd = 233899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator ClearReserve(StoredItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStorageEntity.NativeMethodInfoPtr_ClearReserve_Public_Virtual_New_IEnumerator_StoredItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06007A2D RID: 31277 RVA: 0x0020E268 File Offset: 0x0020C468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233899, XrefRangeEnd = 233923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TryFitItem(int sizeX, int sizeY, out StorageGrid grid, out Coordinate originCoordinate, out float rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sizeX;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sizeY;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rotation;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStorageEntity.NativeMethodInfoPtr_TryFitItem_Public_Virtual_New_Boolean_Int32_Int32_byref_StorageGrid_byref_Coordinate_byref_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			grid = ((intPtr5 == 0) ? null : new StorageGrid(intPtr5));
			IntPtr intPtr6 = intPtr2;
			originCoordinate = ((intPtr6 == 0) ? null : new Coordinate(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06007A2E RID: 31278 RVA: 0x0020E320 File Offset: 0x0020C520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233923, XrefRangeEnd = 233948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int HowManyCanFit(int sizeX, int sizeY, int limit = 2147483647)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sizeX;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sizeY;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref limit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStorageEntity.NativeMethodInfoPtr_HowManyCanFit_Public_Virtual_New_Int32_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007A2F RID: 31279 RVA: 0x0003A280 File Offset: 0x00038480
		public IStorageEntity(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005312 RID: 21266
		private static readonly IntPtr NativeMethodInfoPtr_get_storedItemContainer_Public_Abstract_Virtual_New_get_Transform_0;

		// Token: 0x04005313 RID: 21267
		private static readonly IntPtr NativeMethodInfoPtr_get_reservedItems_Public_Abstract_Virtual_New_get_Dictionary_2_StoredItem_Employee_0;

		// Token: 0x04005314 RID: 21268
		private static readonly IntPtr NativeMethodInfoPtr_GetStoredItems_Public_Abstract_Virtual_New_List_1_StoredItem_0;

		// Token: 0x04005315 RID: 21269
		private static readonly IntPtr NativeMethodInfoPtr_GetStorageGrids_Public_Abstract_Virtual_New_List_1_StorageGrid_0;

		// Token: 0x04005316 RID: 21270
		private static readonly IntPtr NativeMethodInfoPtr_GetStoredItemsByID_Public_Virtual_New_List_1_StoredItem_String_0;

		// Token: 0x04005317 RID: 21271
		private static readonly IntPtr NativeMethodInfoPtr_ReserveItem_Public_Virtual_New_Void_StoredItem_Employee_0;

		// Token: 0x04005318 RID: 21272
		private static readonly IntPtr NativeMethodInfoPtr_DereserveItem_Public_Virtual_New_Void_StoredItem_0;

		// Token: 0x04005319 RID: 21273
		private static readonly IntPtr NativeMethodInfoPtr_IsItemReserved_Public_Virtual_New_Boolean_StoredItem_0;

		// Token: 0x0400531A RID: 21274
		private static readonly IntPtr NativeMethodInfoPtr_WhoIsReserving_Public_Virtual_New_Employee_StoredItem_0;

		// Token: 0x0400531B RID: 21275
		private static readonly IntPtr NativeMethodInfoPtr_GetNonReservedItemsByPrefabID_Public_Virtual_New_List_1_StoredItem_String_Employee_0;

		// Token: 0x0400531C RID: 21276
		private static readonly IntPtr NativeMethodInfoPtr_ClearReserve_Public_Virtual_New_IEnumerator_StoredItem_0;

		// Token: 0x0400531D RID: 21277
		private static readonly IntPtr NativeMethodInfoPtr_TryFitItem_Public_Virtual_New_Boolean_Int32_Int32_byref_StorageGrid_byref_Coordinate_byref_Single_0;

		// Token: 0x0400531E RID: 21278
		private static readonly IntPtr NativeMethodInfoPtr_HowManyCanFit_Public_Virtual_New_Int32_Int32_Int32_Int32_0;

		// Token: 0x02000AB1 RID: 2737
		[ObfuscatedName("ScheduleOne.Storage.IStorageEntity+<ClearReserve>d__12")]
		public sealed class _ClearReserve_d__12 : Il2CppSystem.Object
		{
			// Token: 0x0600D3A2 RID: 54178 RVA: 0x00328D14 File Offset: 0x00326F14
			// Note: this type is marked as 'beforefieldinit'.
			static _ClearReserve_d__12()
			{
				Il2CppClassPointerStore<IStorageEntity._ClearReserve_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IStorageEntity>.NativeClassPtr, "<ClearReserve>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IStorageEntity._ClearReserve_d__12>.NativeClassPtr);
				IStorageEntity._ClearReserve_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IStorageEntity._ClearReserve_d__12>.NativeClassPtr, "<>1__state");
				IStorageEntity._ClearReserve_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IStorageEntity._ClearReserve_d__12>.NativeClassPtr, "<>2__current");
				IStorageEntity._ClearReserve_d__12.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IStorageEntity._ClearReserve_d__12>.NativeClassPtr, "item");
				IStorageEntity._ClearReserve_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IStorageEntity._ClearReserve_d__12>.NativeClassPtr, "<>4__this");
				IStorageEntity._ClearReserve_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity._ClearReserve_d__12>.NativeClassPtr, 100678582);
				IStorageEntity._ClearReserve_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity._ClearReserve_d__12>.NativeClassPtr, 100678583);
				IStorageEntity._ClearReserve_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity._ClearReserve_d__12>.NativeClassPtr, 100678584);
				IStorageEntity._ClearReserve_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity._ClearReserve_d__12>.NativeClassPtr, 100678585);
				IStorageEntity._ClearReserve_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity._ClearReserve_d__12>.NativeClassPtr, 100678586);
				IStorageEntity._ClearReserve_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity._ClearReserve_d__12>.NativeClassPtr, 100678587);
			}

			// Token: 0x0600D3A3 RID: 54179 RVA: 0x00328E08 File Offset: 0x00327008
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ClearReserve_d__12(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IStorageEntity._ClearReserve_d__12>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStorageEntity._ClearReserve_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3A4 RID: 54180 RVA: 0x00328E50 File Offset: 0x00327050
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStorageEntity._ClearReserve_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3A5 RID: 54181 RVA: 0x00328E84 File Offset: 0x00327084
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233788, XrefRangeEnd = 233795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStorageEntity._ClearReserve_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170041A5 RID: 16805
			// (get) Token: 0x0600D3A6 RID: 54182 RVA: 0x00328EC0 File Offset: 0x003270C0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStorageEntity._ClearReserve_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D3A7 RID: 54183 RVA: 0x00328F00 File Offset: 0x00327100
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233795, XrefRangeEnd = 233800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStorageEntity._ClearReserve_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170041A6 RID: 16806
			// (get) Token: 0x0600D3A8 RID: 54184 RVA: 0x00328F34 File Offset: 0x00327134
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStorageEntity._ClearReserve_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D3A9 RID: 54185 RVA: 0x000670A1 File Offset: 0x000652A1
			public _ClearReserve_d__12(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041A1 RID: 16801
			// (get) Token: 0x0600D3AA RID: 54186 RVA: 0x00328F74 File Offset: 0x00327174
			// (set) Token: 0x0600D3AB RID: 54187 RVA: 0x000670AA File Offset: 0x000652AA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStorageEntity._ClearReserve_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStorageEntity._ClearReserve_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170041A2 RID: 16802
			// (get) Token: 0x0600D3AC RID: 54188 RVA: 0x00328F9C File Offset: 0x0032719C
			// (set) Token: 0x0600D3AD RID: 54189 RVA: 0x000670C5 File Offset: 0x000652C5
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStorageEntity._ClearReserve_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStorageEntity._ClearReserve_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041A3 RID: 16803
			// (get) Token: 0x0600D3AE RID: 54190 RVA: 0x00328FCC File Offset: 0x003271CC
			// (set) Token: 0x0600D3AF RID: 54191 RVA: 0x000670E4 File Offset: 0x000652E4
			public unsafe StoredItem item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStorageEntity._ClearReserve_d__12.NativeFieldInfoPtr_item);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StoredItem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStorageEntity._ClearReserve_d__12.NativeFieldInfoPtr_item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041A4 RID: 16804
			// (get) Token: 0x0600D3B0 RID: 54192 RVA: 0x00328FFC File Offset: 0x003271FC
			// (set) Token: 0x0600D3B1 RID: 54193 RVA: 0x00067103 File Offset: 0x00065303
			public unsafe IStorageEntity __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStorageEntity._ClearReserve_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IStorageEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStorageEntity._ClearReserve_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E8B RID: 36491
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008E8C RID: 36492
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008E8D RID: 36493
			private static readonly IntPtr NativeFieldInfoPtr_item;

			// Token: 0x04008E8E RID: 36494
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008E8F RID: 36495
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008E90 RID: 36496
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008E91 RID: 36497
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008E92 RID: 36498
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008E93 RID: 36499
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008E94 RID: 36500
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
