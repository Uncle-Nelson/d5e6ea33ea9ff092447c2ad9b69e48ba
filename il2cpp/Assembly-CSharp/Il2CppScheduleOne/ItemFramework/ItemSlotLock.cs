using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005EC RID: 1516
	public class ItemSlotLock : Object
	{
		// Token: 0x06008482 RID: 33922 RVA: 0x00232F9C File Offset: 0x0023119C
		// Note: this type is marked as 'beforefieldinit'.
		static ItemSlotLock()
		{
			Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemSlotLock");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr);
			ItemSlotLock.NativeFieldInfoPtr__Slot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr, "<Slot>k__BackingField");
			ItemSlotLock.NativeFieldInfoPtr__LockOwner_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr, "<LockOwner>k__BackingField");
			ItemSlotLock.NativeFieldInfoPtr__LockReason_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr, "<LockReason>k__BackingField");
			ItemSlotLock.NativeMethodInfoPtr_get_Slot_Public_get_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr, 100679885);
			ItemSlotLock.NativeMethodInfoPtr_set_Slot_Protected_set_Void_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr, 100679886);
			ItemSlotLock.NativeMethodInfoPtr_get_LockOwner_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr, 100679887);
			ItemSlotLock.NativeMethodInfoPtr_set_LockOwner_Protected_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr, 100679888);
			ItemSlotLock.NativeMethodInfoPtr_get_LockReason_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr, 100679889);
			ItemSlotLock.NativeMethodInfoPtr_set_LockReason_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr, 100679890);
			ItemSlotLock.NativeMethodInfoPtr__ctor_Public_Void_ItemSlot_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr, 100679891);
		}

		// Token: 0x1700280E RID: 10254
		// (get) Token: 0x06008483 RID: 33923 RVA: 0x00233094 File Offset: 0x00231294
		// (set) Token: 0x06008484 RID: 33924 RVA: 0x002330D4 File Offset: 0x002312D4
		public unsafe ItemSlot Slot
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 17380, RefRangeEnd = 17390, XrefRangeStart = 17380, XrefRangeEnd = 17390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotLock.NativeMethodInfoPtr_get_Slot_Public_get_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29995, RefRangeEnd = 29997, XrefRangeStart = 29995, XrefRangeEnd = 29997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotLock.NativeMethodInfoPtr_set_Slot_Protected_set_Void_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700280F RID: 10255
		// (get) Token: 0x06008485 RID: 33925 RVA: 0x00233118 File Offset: 0x00231318
		// (set) Token: 0x06008486 RID: 33926 RVA: 0x00233158 File Offset: 0x00231358
		public unsafe NetworkObject LockOwner
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotLock.NativeMethodInfoPtr_get_LockOwner_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotLock.NativeMethodInfoPtr_set_LockOwner_Protected_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002810 RID: 10256
		// (get) Token: 0x06008487 RID: 33927 RVA: 0x0023319C File Offset: 0x0023139C
		// (set) Token: 0x06008488 RID: 33928 RVA: 0x002331D4 File Offset: 0x002313D4
		public unsafe string LockReason
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17399, RefRangeEnd = 17400, XrefRangeStart = 17399, XrefRangeEnd = 17400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotLock.NativeMethodInfoPtr_get_LockReason_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotLock.NativeMethodInfoPtr_set_LockReason_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008489 RID: 33929 RVA: 0x00233218 File Offset: 0x00231418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249187, XrefRangeEnd = 249195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSlotLock(ItemSlot slot, NetworkObject lockOwner, string lockReason) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotLock.NativeMethodInfoPtr__ctor_Public_Void_ItemSlot_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600848A RID: 33930 RVA: 0x0003ED19 File Offset: 0x0003CF19
		public ItemSlotLock(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700280B RID: 10251
		// (get) Token: 0x0600848B RID: 33931 RVA: 0x00233288 File Offset: 0x00231488
		// (set) Token: 0x0600848C RID: 33932 RVA: 0x0003ED22 File Offset: 0x0003CF22
		public unsafe ItemSlot _Slot_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotLock.NativeFieldInfoPtr__Slot_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotLock.NativeFieldInfoPtr__Slot_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700280C RID: 10252
		// (get) Token: 0x0600848D RID: 33933 RVA: 0x002332B8 File Offset: 0x002314B8
		// (set) Token: 0x0600848E RID: 33934 RVA: 0x0003ED41 File Offset: 0x0003CF41
		public unsafe NetworkObject _LockOwner_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotLock.NativeFieldInfoPtr__LockOwner_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotLock.NativeFieldInfoPtr__LockOwner_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700280D RID: 10253
		// (get) Token: 0x0600848F RID: 33935 RVA: 0x002332E8 File Offset: 0x002314E8
		// (set) Token: 0x06008490 RID: 33936 RVA: 0x0003ED60 File Offset: 0x0003CF60
		public unsafe string _LockReason_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotLock.NativeFieldInfoPtr__LockReason_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotLock.NativeFieldInfoPtr__LockReason_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04005A41 RID: 23105
		private static readonly IntPtr NativeFieldInfoPtr__Slot_k__BackingField;

		// Token: 0x04005A42 RID: 23106
		private static readonly IntPtr NativeFieldInfoPtr__LockOwner_k__BackingField;

		// Token: 0x04005A43 RID: 23107
		private static readonly IntPtr NativeFieldInfoPtr__LockReason_k__BackingField;

		// Token: 0x04005A44 RID: 23108
		private static readonly IntPtr NativeMethodInfoPtr_get_Slot_Public_get_ItemSlot_0;

		// Token: 0x04005A45 RID: 23109
		private static readonly IntPtr NativeMethodInfoPtr_set_Slot_Protected_set_Void_ItemSlot_0;

		// Token: 0x04005A46 RID: 23110
		private static readonly IntPtr NativeMethodInfoPtr_get_LockOwner_Public_get_NetworkObject_0;

		// Token: 0x04005A47 RID: 23111
		private static readonly IntPtr NativeMethodInfoPtr_set_LockOwner_Protected_set_Void_NetworkObject_0;

		// Token: 0x04005A48 RID: 23112
		private static readonly IntPtr NativeMethodInfoPtr_get_LockReason_Public_get_String_0;

		// Token: 0x04005A49 RID: 23113
		private static readonly IntPtr NativeMethodInfoPtr_set_LockReason_Protected_set_Void_String_0;

		// Token: 0x04005A4A RID: 23114
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ItemSlot_NetworkObject_String_0;
	}
}
