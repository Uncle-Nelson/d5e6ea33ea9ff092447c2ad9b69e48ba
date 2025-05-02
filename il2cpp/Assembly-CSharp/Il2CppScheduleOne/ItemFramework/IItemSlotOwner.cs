using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005DF RID: 1503
	public class IItemSlotOwner : Il2CppObjectBase
	{
		// Token: 0x0600837B RID: 33659 RVA: 0x0022F208 File Offset: 0x0022D408
		// Note: this type is marked as 'beforefieldinit'.
		static IItemSlotOwner()
		{
			Il2CppClassPointerStore<IItemSlotOwner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "IItemSlotOwner");
			IItemSlotOwner.NativeMethodInfoPtr_get_ItemSlots_Public_Abstract_Virtual_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IItemSlotOwner>.NativeClassPtr, 100679739);
			IItemSlotOwner.NativeMethodInfoPtr_set_ItemSlots_Public_Abstract_Virtual_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IItemSlotOwner>.NativeClassPtr, 100679740);
			IItemSlotOwner.NativeMethodInfoPtr_SetStoredInstance_Public_Abstract_Virtual_New_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IItemSlotOwner>.NativeClassPtr, 100679741);
			IItemSlotOwner.NativeMethodInfoPtr_SetItemSlotQuantity_Public_Abstract_Virtual_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IItemSlotOwner>.NativeClassPtr, 100679742);
			IItemSlotOwner.NativeMethodInfoPtr_SetSlotLocked_Public_Abstract_Virtual_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IItemSlotOwner>.NativeClassPtr, 100679743);
			IItemSlotOwner.NativeMethodInfoPtr_SendItemsToClient_Public_Virtual_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IItemSlotOwner>.NativeClassPtr, 100679744);
			IItemSlotOwner.NativeMethodInfoPtr_GetTotalItemCount_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IItemSlotOwner>.NativeClassPtr, 100679745);
			IItemSlotOwner.NativeMethodInfoPtr_GetItemCount_Public_Virtual_New_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IItemSlotOwner>.NativeClassPtr, 100679746);
		}

		// Token: 0x170027C2 RID: 10178
		// (get) Token: 0x0600837C RID: 33660 RVA: 0x0022F2D0 File Offset: 0x0022D4D0
		// (set) Token: 0x0600837D RID: 33661 RVA: 0x0022F31C File Offset: 0x0022D51C
		public unsafe virtual List<ItemSlot> ItemSlots
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IItemSlotOwner.NativeMethodInfoPtr_get_ItemSlots_Public_Abstract_Virtual_New_get_List_1_ItemSlot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IItemSlotOwner.NativeMethodInfoPtr_set_ItemSlots_Public_Abstract_Virtual_New_set_Void_List_1_ItemSlot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600837E RID: 33662 RVA: 0x0022F36C File Offset: 0x0022D56C
		[CallerCount(0)]
		public unsafe virtual void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IItemSlotOwner.NativeMethodInfoPtr_SetStoredInstance_Public_Abstract_Virtual_New_Void_NetworkConnection_Int32_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600837F RID: 33663 RVA: 0x0022F3DC File Offset: 0x0022D5DC
		[CallerCount(0)]
		public unsafe virtual void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IItemSlotOwner.NativeMethodInfoPtr_SetItemSlotQuantity_Public_Abstract_Virtual_New_Void_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008380 RID: 33664 RVA: 0x0022F434 File Offset: 0x0022D634
		[CallerCount(0)]
		public unsafe virtual void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IItemSlotOwner.NativeMethodInfoPtr_SetSlotLocked_Public_Abstract_Virtual_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008381 RID: 33665 RVA: 0x0022F4C4 File Offset: 0x0022D6C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247532, XrefRangeEnd = 247565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendItemsToClient(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IItemSlotOwner.NativeMethodInfoPtr_SendItemsToClient_Public_Virtual_New_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008382 RID: 33666 RVA: 0x0022F514 File Offset: 0x0022D714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247565, XrefRangeEnd = 247586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetTotalItemCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IItemSlotOwner.NativeMethodInfoPtr_GetTotalItemCount_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008383 RID: 33667 RVA: 0x0022F55C File Offset: 0x0022D75C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247586, XrefRangeEnd = 247608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetItemCount(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IItemSlotOwner.NativeMethodInfoPtr_GetItemCount_Public_Virtual_New_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008384 RID: 33668 RVA: 0x0003E72B File Offset: 0x0003C92B
		public IItemSlotOwner(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400597A RID: 22906
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemSlots_Public_Abstract_Virtual_New_get_List_1_ItemSlot_0;

		// Token: 0x0400597B RID: 22907
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemSlots_Public_Abstract_Virtual_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x0400597C RID: 22908
		private static readonly IntPtr NativeMethodInfoPtr_SetStoredInstance_Public_Abstract_Virtual_New_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x0400597D RID: 22909
		private static readonly IntPtr NativeMethodInfoPtr_SetItemSlotQuantity_Public_Abstract_Virtual_New_Void_Int32_Int32_0;

		// Token: 0x0400597E RID: 22910
		private static readonly IntPtr NativeMethodInfoPtr_SetSlotLocked_Public_Abstract_Virtual_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x0400597F RID: 22911
		private static readonly IntPtr NativeMethodInfoPtr_SendItemsToClient_Public_Virtual_New_Void_NetworkConnection_0;

		// Token: 0x04005980 RID: 22912
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalItemCount_Public_Virtual_New_Int32_0;

		// Token: 0x04005981 RID: 22913
		private static readonly IntPtr NativeMethodInfoPtr_GetItemCount_Public_Virtual_New_Int32_String_0;

		// Token: 0x02000AE7 RID: 2791
		[ObfuscatedName("ScheduleOne.ItemFramework.IItemSlotOwner+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600D550 RID: 54608 RVA: 0x0032DAA4 File Offset: 0x0032BCA4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<IItemSlotOwner.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IItemSlotOwner>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IItemSlotOwner.__c>.NativeClassPtr);
				IItemSlotOwner.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IItemSlotOwner.__c>.NativeClassPtr, "<>9");
				IItemSlotOwner.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IItemSlotOwner.__c>.NativeClassPtr, "<>9__7_0");
				IItemSlotOwner.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IItemSlotOwner.__c>.NativeClassPtr, 100679748);
				IItemSlotOwner.__c.NativeMethodInfoPtr__GetTotalItemCount_b__7_0_Internal_Int32_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IItemSlotOwner.__c>.NativeClassPtr, 100679749);
			}

			// Token: 0x0600D551 RID: 54609 RVA: 0x0032DB20 File Offset: 0x0032BD20
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IItemSlotOwner.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IItemSlotOwner.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D552 RID: 54610 RVA: 0x0032DB5C File Offset: 0x0032BD5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247530, XrefRangeEnd = 247532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetTotalItemCount_b__7_0(ItemSlot x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IItemSlotOwner.__c.NativeMethodInfoPtr__GetTotalItemCount_b__7_0_Internal_Int32_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D553 RID: 54611 RVA: 0x00067CA8 File Offset: 0x00065EA8
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004219 RID: 16921
			// (get) Token: 0x0600D554 RID: 54612 RVA: 0x0032DBAC File Offset: 0x0032BDAC
			// (set) Token: 0x0600D555 RID: 54613 RVA: 0x00067CB1 File Offset: 0x00065EB1
			public unsafe static IItemSlotOwner.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IItemSlotOwner.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IItemSlotOwner.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IItemSlotOwner.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700421A RID: 16922
			// (get) Token: 0x0600D556 RID: 54614 RVA: 0x0032DBD4 File Offset: 0x0032BDD4
			// (set) Token: 0x0600D557 RID: 54615 RVA: 0x00067CC3 File Offset: 0x00065EC3
			public unsafe static Func<ItemSlot, int> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IItemSlotOwner.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ItemSlot, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IItemSlotOwner.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F84 RID: 36740
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008F85 RID: 36741
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x04008F86 RID: 36742
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F87 RID: 36743
			private static readonly IntPtr NativeMethodInfoPtr__GetTotalItemCount_b__7_0_Internal_Int32_ItemSlot_0;
		}
	}
}
