using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.NPCs;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x0200039C RID: 924
	public class ITransitEntity : Il2CppObjectBase
	{
		// Token: 0x0600487A RID: 18554 RVA: 0x001626C0 File Offset: 0x001608C0
		// Note: this type is marked as 'beforefieldinit'.
		static ITransitEntity()
		{
			Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "ITransitEntity");
			ITransitEntity.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672264);
			ITransitEntity.NativeMethodInfoPtr_get_InputSlots_Public_Abstract_Virtual_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672265);
			ITransitEntity.NativeMethodInfoPtr_set_InputSlots_Public_Abstract_Virtual_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672266);
			ITransitEntity.NativeMethodInfoPtr_get_OutputSlots_Public_Abstract_Virtual_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672267);
			ITransitEntity.NativeMethodInfoPtr_set_OutputSlots_Public_Abstract_Virtual_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672268);
			ITransitEntity.NativeMethodInfoPtr_get_LinkOrigin_Public_Abstract_Virtual_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672269);
			ITransitEntity.NativeMethodInfoPtr_get_AccessPoints_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672270);
			ITransitEntity.NativeMethodInfoPtr_get_Selectable_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672271);
			ITransitEntity.NativeMethodInfoPtr_get_IsAcceptingItems_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672272);
			ITransitEntity.NativeMethodInfoPtr_get_IsDestroyed_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672273);
			ITransitEntity.NativeMethodInfoPtr_get_GUID_Public_Abstract_Virtual_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672274);
			ITransitEntity.NativeMethodInfoPtr_ShowOutline_Public_Abstract_Virtual_New_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672275);
			ITransitEntity.NativeMethodInfoPtr_HideOutline_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672276);
			ITransitEntity.NativeMethodInfoPtr_InsertItemIntoInput_Public_Virtual_New_Void_ItemInstance_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672277);
			ITransitEntity.NativeMethodInfoPtr_InsertItemIntoOutput_Public_Virtual_New_Void_ItemInstance_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672278);
			ITransitEntity.NativeMethodInfoPtr_GetInputCapacityForItem_Public_Virtual_New_Int32_ItemInstance_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672279);
			ITransitEntity.NativeMethodInfoPtr_GetOutputCapacityForItem_Public_Virtual_New_Int32_ItemInstance_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672280);
			ITransitEntity.NativeMethodInfoPtr_GetOutputItemContainer_Public_Virtual_New_ItemSlot_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672281);
			ITransitEntity.NativeMethodInfoPtr_ReserveInputSlotsForItem_Public_Virtual_New_List_1_ItemSlot_ItemInstance_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672282);
			ITransitEntity.NativeMethodInfoPtr_RemoveSlotLocks_Public_Virtual_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672283);
			ITransitEntity.NativeMethodInfoPtr_GetFirstSlotContainingItem_Public_Virtual_New_ItemSlot_String_ESlotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672284);
			ITransitEntity.NativeMethodInfoPtr_GetFirstSlotContainingTemplateItem_Public_Virtual_New_ItemSlot_ItemInstance_ESlotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672285);
		}

		// Token: 0x170015BE RID: 5566
		// (get) Token: 0x0600487B RID: 18555 RVA: 0x001628A0 File Offset: 0x00160AA0
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170015BF RID: 5567
		// (get) Token: 0x0600487C RID: 18556 RVA: 0x001628E4 File Offset: 0x00160AE4
		// (set) Token: 0x0600487D RID: 18557 RVA: 0x00162930 File Offset: 0x00160B30
		public unsafe virtual List<ItemSlot> InputSlots
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_get_InputSlots_Public_Abstract_Virtual_New_get_List_1_ItemSlot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_set_InputSlots_Public_Abstract_Virtual_New_set_Void_List_1_ItemSlot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015C0 RID: 5568
		// (get) Token: 0x0600487E RID: 18558 RVA: 0x00162980 File Offset: 0x00160B80
		// (set) Token: 0x0600487F RID: 18559 RVA: 0x001629CC File Offset: 0x00160BCC
		public unsafe virtual List<ItemSlot> OutputSlots
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_get_OutputSlots_Public_Abstract_Virtual_New_get_List_1_ItemSlot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_set_OutputSlots_Public_Abstract_Virtual_New_set_Void_List_1_ItemSlot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015C1 RID: 5569
		// (get) Token: 0x06004880 RID: 18560 RVA: 0x00162A1C File Offset: 0x00160C1C
		public unsafe virtual Transform LinkOrigin
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_get_LinkOrigin_Public_Abstract_Virtual_New_get_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x170015C2 RID: 5570
		// (get) Token: 0x06004881 RID: 18561 RVA: 0x00162A68 File Offset: 0x00160C68
		public unsafe virtual Il2CppReferenceArray<Transform> AccessPoints
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_get_AccessPoints_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr3) : null;
			}
		}

		// Token: 0x170015C3 RID: 5571
		// (get) Token: 0x06004882 RID: 18562 RVA: 0x00162AB4 File Offset: 0x00160CB4
		public unsafe virtual bool Selectable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_get_Selectable_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170015C4 RID: 5572
		// (get) Token: 0x06004883 RID: 18563 RVA: 0x00162AFC File Offset: 0x00160CFC
		public unsafe virtual bool IsAcceptingItems
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_get_IsAcceptingItems_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170015C5 RID: 5573
		// (get) Token: 0x06004884 RID: 18564 RVA: 0x00162B44 File Offset: 0x00160D44
		public unsafe virtual bool IsDestroyed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_get_IsDestroyed_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170015C6 RID: 5574
		// (get) Token: 0x06004885 RID: 18565 RVA: 0x00162B8C File Offset: 0x00160D8C
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_get_GUID_Public_Abstract_Virtual_New_get_Guid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004886 RID: 18566 RVA: 0x00162BD4 File Offset: 0x00160DD4
		[CallerCount(0)]
		public unsafe virtual void ShowOutline(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_ShowOutline_Public_Abstract_Virtual_New_Void_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004887 RID: 18567 RVA: 0x00162C20 File Offset: 0x00160E20
		[CallerCount(0)]
		public unsafe virtual void HideOutline()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_HideOutline_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004888 RID: 18568 RVA: 0x00162C5C File Offset: 0x00160E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162244, XrefRangeEnd = 162286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InsertItemIntoInput(ItemInstance item, NPC inserter = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inserter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_InsertItemIntoInput_Public_Virtual_New_Void_ItemInstance_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004889 RID: 18569 RVA: 0x00162CBC File Offset: 0x00160EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162286, XrefRangeEnd = 162328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InsertItemIntoOutput(ItemInstance item, NPC inserter = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inserter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_InsertItemIntoOutput_Public_Virtual_New_Void_ItemInstance_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600488A RID: 18570 RVA: 0x00162D1C File Offset: 0x00160F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162328, XrefRangeEnd = 162368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetInputCapacityForItem(ItemInstance item, NPC asker = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asker);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_GetInputCapacityForItem_Public_Virtual_New_Int32_ItemInstance_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600488B RID: 18571 RVA: 0x00162D88 File Offset: 0x00160F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162368, XrefRangeEnd = 162408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetOutputCapacityForItem(ItemInstance item, NPC asker = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asker);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_GetOutputCapacityForItem_Public_Virtual_New_Int32_ItemInstance_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600488C RID: 18572 RVA: 0x00162DF4 File Offset: 0x00160FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162408, XrefRangeEnd = 162426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ItemSlot GetOutputItemContainer(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_GetOutputItemContainer_Public_Virtual_New_ItemSlot_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr3) : null;
		}

		// Token: 0x0600488D RID: 18573 RVA: 0x00162E50 File Offset: 0x00161050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162426, XrefRangeEnd = 162458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<ItemSlot> ReserveInputSlotsForItem(ItemInstance item, NetworkObject locker)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locker);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_ReserveInputSlotsForItem_Public_Virtual_New_List_1_ItemSlot_ItemInstance_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr3) : null;
		}

		// Token: 0x0600488E RID: 18574 RVA: 0x00162EC0 File Offset: 0x001610C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162458, XrefRangeEnd = 162483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveSlotLocks(NetworkObject locker)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(locker);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_RemoveSlotLocks_Public_Virtual_New_Void_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600488F RID: 18575 RVA: 0x00162F10 File Offset: 0x00161110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162483, XrefRangeEnd = 162504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ItemSlot GetFirstSlotContainingItem(string id, ITransitEntity.ESlotType searchType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_GetFirstSlotContainingItem_Public_Virtual_New_ItemSlot_String_ESlotType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr3) : null;
		}

		// Token: 0x06004890 RID: 18576 RVA: 0x00162F7C File Offset: 0x0016117C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162504, XrefRangeEnd = 162524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ItemSlot GetFirstSlotContainingTemplateItem(ItemInstance templateItem, ITransitEntity.ESlotType searchType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(templateItem);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_GetFirstSlotContainingTemplateItem_Public_Virtual_New_ItemSlot_ItemInstance_ESlotType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr3) : null;
		}

		// Token: 0x06004891 RID: 18577 RVA: 0x00023009 File Offset: 0x00021209
		public ITransitEntity(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040030DD RID: 12509
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040030DE RID: 12510
		private static readonly IntPtr NativeMethodInfoPtr_get_InputSlots_Public_Abstract_Virtual_New_get_List_1_ItemSlot_0;

		// Token: 0x040030DF RID: 12511
		private static readonly IntPtr NativeMethodInfoPtr_set_InputSlots_Public_Abstract_Virtual_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x040030E0 RID: 12512
		private static readonly IntPtr NativeMethodInfoPtr_get_OutputSlots_Public_Abstract_Virtual_New_get_List_1_ItemSlot_0;

		// Token: 0x040030E1 RID: 12513
		private static readonly IntPtr NativeMethodInfoPtr_set_OutputSlots_Public_Abstract_Virtual_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x040030E2 RID: 12514
		private static readonly IntPtr NativeMethodInfoPtr_get_LinkOrigin_Public_Abstract_Virtual_New_get_Transform_0;

		// Token: 0x040030E3 RID: 12515
		private static readonly IntPtr NativeMethodInfoPtr_get_AccessPoints_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Transform_0;

		// Token: 0x040030E4 RID: 12516
		private static readonly IntPtr NativeMethodInfoPtr_get_Selectable_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040030E5 RID: 12517
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAcceptingItems_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040030E6 RID: 12518
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDestroyed_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040030E7 RID: 12519
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Abstract_Virtual_New_get_Guid_0;

		// Token: 0x040030E8 RID: 12520
		private static readonly IntPtr NativeMethodInfoPtr_ShowOutline_Public_Abstract_Virtual_New_Void_Color_0;

		// Token: 0x040030E9 RID: 12521
		private static readonly IntPtr NativeMethodInfoPtr_HideOutline_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040030EA RID: 12522
		private static readonly IntPtr NativeMethodInfoPtr_InsertItemIntoInput_Public_Virtual_New_Void_ItemInstance_NPC_0;

		// Token: 0x040030EB RID: 12523
		private static readonly IntPtr NativeMethodInfoPtr_InsertItemIntoOutput_Public_Virtual_New_Void_ItemInstance_NPC_0;

		// Token: 0x040030EC RID: 12524
		private static readonly IntPtr NativeMethodInfoPtr_GetInputCapacityForItem_Public_Virtual_New_Int32_ItemInstance_NPC_0;

		// Token: 0x040030ED RID: 12525
		private static readonly IntPtr NativeMethodInfoPtr_GetOutputCapacityForItem_Public_Virtual_New_Int32_ItemInstance_NPC_0;

		// Token: 0x040030EE RID: 12526
		private static readonly IntPtr NativeMethodInfoPtr_GetOutputItemContainer_Public_Virtual_New_ItemSlot_ItemInstance_0;

		// Token: 0x040030EF RID: 12527
		private static readonly IntPtr NativeMethodInfoPtr_ReserveInputSlotsForItem_Public_Virtual_New_List_1_ItemSlot_ItemInstance_NetworkObject_0;

		// Token: 0x040030F0 RID: 12528
		private static readonly IntPtr NativeMethodInfoPtr_RemoveSlotLocks_Public_Virtual_New_Void_NetworkObject_0;

		// Token: 0x040030F1 RID: 12529
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstSlotContainingItem_Public_Virtual_New_ItemSlot_String_ESlotType_0;

		// Token: 0x040030F2 RID: 12530
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstSlotContainingTemplateItem_Public_Virtual_New_ItemSlot_ItemInstance_ESlotType_0;

		// Token: 0x02000978 RID: 2424
		[OriginalName("Assembly-CSharp.dll", "", "ESlotType")]
		public enum ESlotType
		{
			// Token: 0x04008891 RID: 34961
			Input,
			// Token: 0x04008892 RID: 34962
			Output,
			// Token: 0x04008893 RID: 34963
			Both
		}

		// Token: 0x02000979 RID: 2425
		[ObfuscatedName("ScheduleOne.Management.ITransitEntity+<>c__DisplayClass27_0")]
		public sealed class __c__DisplayClass27_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C9D3 RID: 51667 RVA: 0x0030D7F8 File Offset: 0x0030B9F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass27_0()
			{
				Il2CppClassPointerStore<ITransitEntity.__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, "<>c__DisplayClass27_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ITransitEntity.__c__DisplayClass27_0>.NativeClassPtr);
				ITransitEntity.__c__DisplayClass27_0.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ITransitEntity.__c__DisplayClass27_0>.NativeClassPtr, "item");
				ITransitEntity.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity.__c__DisplayClass27_0>.NativeClassPtr, 100672286);
				ITransitEntity.__c__DisplayClass27_0.NativeMethodInfoPtr__GetOutputItemContainer_b__0_Internal_Boolean_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity.__c__DisplayClass27_0>.NativeClassPtr, 100672287);
			}

			// Token: 0x0600C9D4 RID: 51668 RVA: 0x0030D860 File Offset: 0x0030BA60
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass27_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ITransitEntity.__c__DisplayClass27_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ITransitEntity.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C9D5 RID: 51669 RVA: 0x0030D89C File Offset: 0x0030BA9C
			[CallerCount(0)]
			public unsafe bool _GetOutputItemContainer_b__0(ItemSlot x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ITransitEntity.__c__DisplayClass27_0.NativeMethodInfoPtr__GetOutputItemContainer_b__0_Internal_Boolean_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C9D6 RID: 51670 RVA: 0x00062241 File Offset: 0x00060441
			public __c__DisplayClass27_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EEB RID: 16107
			// (get) Token: 0x0600C9D7 RID: 51671 RVA: 0x0030D8EC File Offset: 0x0030BAEC
			// (set) Token: 0x0600C9D8 RID: 51672 RVA: 0x0006224A File Offset: 0x0006044A
			public unsafe ItemInstance item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ITransitEntity.__c__DisplayClass27_0.NativeFieldInfoPtr_item);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ITransitEntity.__c__DisplayClass27_0.NativeFieldInfoPtr_item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008894 RID: 34964
			private static readonly IntPtr NativeFieldInfoPtr_item;

			// Token: 0x04008895 RID: 34965
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008896 RID: 34966
			private static readonly IntPtr NativeMethodInfoPtr__GetOutputItemContainer_b__0_Internal_Boolean_ItemSlot_0;
		}
	}
}
