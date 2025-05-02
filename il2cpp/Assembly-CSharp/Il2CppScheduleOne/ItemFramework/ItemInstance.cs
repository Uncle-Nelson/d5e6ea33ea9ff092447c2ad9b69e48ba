using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005E5 RID: 1509
	[Serializable]
	public class ItemInstance : Il2CppSystem.Object
	{
		// Token: 0x060083BD RID: 33725 RVA: 0x0022FF20 File Offset: 0x0022E120
		// Note: this type is marked as 'beforefieldinit'.
		static ItemInstance()
		{
			Il2CppClassPointerStore<ItemInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr);
			ItemInstance.NativeFieldInfoPtr_definition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, "definition");
			ItemInstance.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, "ID");
			ItemInstance.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, "Quantity");
			ItemInstance.NativeFieldInfoPtr_onDataChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, "onDataChanged");
			ItemInstance.NativeFieldInfoPtr_requestClearSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, "requestClearSlot");
			ItemInstance.NativeMethodInfoPtr_get_Definition_Public_get_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100679762);
			ItemInstance.NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100679763);
			ItemInstance.NativeMethodInfoPtr_get_Description_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100679764);
			ItemInstance.NativeMethodInfoPtr_get_Icon_Public_Virtual_New_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100679765);
			ItemInstance.NativeMethodInfoPtr_get_Category_Public_Virtual_New_get_EItemCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100679766);
			ItemInstance.NativeMethodInfoPtr_get_StackLimit_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100679767);
			ItemInstance.NativeMethodInfoPtr_get_LabelDisplayColor_Public_Virtual_New_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100679768);
			ItemInstance.NativeMethodInfoPtr_get_Equippable_Public_Virtual_New_get_Equippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100679769);
			ItemInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100679770);
			ItemInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100679771);
			ItemInstance.NativeMethodInfoPtr_CanStackWith_Public_Virtual_New_Boolean_ItemInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100679772);
			ItemInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_New_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100679773);
			ItemInstance.NativeMethodInfoPtr_IsValidInstance_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100679774);
			ItemInstance.NativeMethodInfoPtr_InvokeDataChange_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100679775);
			ItemInstance.NativeMethodInfoPtr_SetQuantity_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100679776);
			ItemInstance.NativeMethodInfoPtr_ChangeQuantity_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100679777);
			ItemInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_New_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100679778);
			ItemInstance.NativeMethodInfoPtr_GetMonetaryValue_Public_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100679779);
			ItemInstance.NativeMethodInfoPtr_RequestClearSlot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100679780);
		}

		// Token: 0x170027DA RID: 10202
		// (get) Token: 0x060083BE RID: 33726 RVA: 0x00230130 File Offset: 0x0022E330
		public unsafe ItemDefinition Definition
		{
			[CallerCount(134)]
			[CachedScanResults(RefRangeStart = 247657, RefRangeEnd = 247791, XrefRangeStart = 247641, XrefRangeEnd = 247657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInstance.NativeMethodInfoPtr_get_Definition_Public_get_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr3) : null;
			}
		}

		// Token: 0x170027DB RID: 10203
		// (get) Token: 0x060083BF RID: 33727 RVA: 0x00230170 File Offset: 0x0022E370
		public unsafe virtual string Name
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 247792, RefRangeEnd = 247794, XrefRangeStart = 247791, XrefRangeEnd = 247792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInstance.NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170027DC RID: 10204
		// (get) Token: 0x060083C0 RID: 33728 RVA: 0x002301B4 File Offset: 0x0022E3B4
		public unsafe virtual string Description
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247794, XrefRangeEnd = 247795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInstance.NativeMethodInfoPtr_get_Description_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170027DD RID: 10205
		// (get) Token: 0x060083C1 RID: 33729 RVA: 0x002301F8 File Offset: 0x0022E3F8
		public unsafe virtual Sprite Icon
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 247796, RefRangeEnd = 247798, XrefRangeStart = 247795, XrefRangeEnd = 247796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInstance.NativeMethodInfoPtr_get_Icon_Public_Virtual_New_get_Sprite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
		}

		// Token: 0x170027DE RID: 10206
		// (get) Token: 0x060083C2 RID: 33730 RVA: 0x00230244 File Offset: 0x0022E444
		public unsafe virtual EItemCategory Category
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247798, XrefRangeEnd = 247799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInstance.NativeMethodInfoPtr_get_Category_Public_Virtual_New_get_EItemCategory_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170027DF RID: 10207
		// (get) Token: 0x060083C3 RID: 33731 RVA: 0x0023028C File Offset: 0x0022E48C
		public unsafe virtual int StackLimit
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247799, XrefRangeEnd = 247800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInstance.NativeMethodInfoPtr_get_StackLimit_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170027E0 RID: 10208
		// (get) Token: 0x060083C4 RID: 33732 RVA: 0x002302D4 File Offset: 0x0022E4D4
		public unsafe virtual Color LabelDisplayColor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247800, XrefRangeEnd = 247801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInstance.NativeMethodInfoPtr_get_LabelDisplayColor_Public_Virtual_New_get_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170027E1 RID: 10209
		// (get) Token: 0x060083C5 RID: 33733 RVA: 0x0023031C File Offset: 0x0022E51C
		public unsafe virtual Equippable Equippable
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 247802, RefRangeEnd = 247804, XrefRangeStart = 247801, XrefRangeEnd = 247802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInstance.NativeMethodInfoPtr_get_Equippable_Public_Virtual_New_get_Equippable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Equippable>(intPtr3) : null;
			}
		}

		// Token: 0x060083C6 RID: 33734 RVA: 0x00230368 File Offset: 0x0022E568
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 247808, RefRangeEnd = 247809, XrefRangeStart = 247804, XrefRangeEnd = 247808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060083C7 RID: 33735 RVA: 0x002303A4 File Offset: 0x0022E5A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 247816, RefRangeEnd = 247818, XrefRangeStart = 247809, XrefRangeEnd = 247816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemInstance(ItemDefinition definition, int quantity) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060083C8 RID: 33736 RVA: 0x00230400 File Offset: 0x0022E600
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 247819, RefRangeEnd = 247820, XrefRangeStart = 247818, XrefRangeEnd = 247819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanStackWith(ItemInstance other, bool checkQuantities = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkQuantities;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInstance.NativeMethodInfoPtr_CanStackWith_Public_Virtual_New_Boolean_ItemInstance_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060083C9 RID: 33737 RVA: 0x00230468 File Offset: 0x0022E668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247820, XrefRangeEnd = 247826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ItemInstance GetCopy(int overrideQuantity = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref overrideQuantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_New_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x060083CA RID: 33738 RVA: 0x002304C0 File Offset: 0x0022E6C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247826, XrefRangeEnd = 247834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsValidInstance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInstance.NativeMethodInfoPtr_IsValidInstance_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060083CB RID: 33739 RVA: 0x00230508 File Offset: 0x0022E708
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 247834, RefRangeEnd = 247837, XrefRangeStart = 247834, XrefRangeEnd = 247834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeDataChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInstance.NativeMethodInfoPtr_InvokeDataChange_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060083CC RID: 33740 RVA: 0x0023053C File Offset: 0x0022E73C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247837, XrefRangeEnd = 247848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetQuantity(int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInstance.NativeMethodInfoPtr_SetQuantity_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060083CD RID: 33741 RVA: 0x0023057C File Offset: 0x0022E77C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 247859, RefRangeEnd = 247869, XrefRangeStart = 247848, XrefRangeEnd = 247859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeQuantity(int change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInstance.NativeMethodInfoPtr_ChangeQuantity_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060083CE RID: 33742 RVA: 0x002305BC File Offset: 0x0022E7BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247869, XrefRangeEnd = 247873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ItemData GetItemData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_New_ItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemData>(intPtr3) : null;
		}

		// Token: 0x060083CF RID: 33743 RVA: 0x00230608 File Offset: 0x0022E808
		[CallerCount(0)]
		public unsafe virtual float GetMonetaryValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInstance.NativeMethodInfoPtr_GetMonetaryValue_Public_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060083D0 RID: 33744 RVA: 0x00230650 File Offset: 0x0022E850
		[CallerCount(0)]
		public unsafe void RequestClearSlot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInstance.NativeMethodInfoPtr_RequestClearSlot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060083D1 RID: 33745 RVA: 0x0003E955 File Offset: 0x0003CB55
		public ItemInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027D5 RID: 10197
		// (get) Token: 0x060083D2 RID: 33746 RVA: 0x00230684 File Offset: 0x0022E884
		// (set) Token: 0x060083D3 RID: 33747 RVA: 0x0003E95E File Offset: 0x0003CB5E
		public unsafe ItemDefinition definition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInstance.NativeFieldInfoPtr_definition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInstance.NativeFieldInfoPtr_definition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027D6 RID: 10198
		// (get) Token: 0x060083D4 RID: 33748 RVA: 0x002306B4 File Offset: 0x0022E8B4
		// (set) Token: 0x060083D5 RID: 33749 RVA: 0x0003E97D File Offset: 0x0003CB7D
		public unsafe string ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInstance.NativeFieldInfoPtr_ID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInstance.NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170027D7 RID: 10199
		// (get) Token: 0x060083D6 RID: 33750 RVA: 0x002306DC File Offset: 0x0022E8DC
		// (set) Token: 0x060083D7 RID: 33751 RVA: 0x0003E99C File Offset: 0x0003CB9C
		public unsafe int Quantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInstance.NativeFieldInfoPtr_Quantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInstance.NativeFieldInfoPtr_Quantity)) = value;
			}
		}

		// Token: 0x170027D8 RID: 10200
		// (get) Token: 0x060083D8 RID: 33752 RVA: 0x00230704 File Offset: 0x0022E904
		// (set) Token: 0x060083D9 RID: 33753 RVA: 0x0003E9B7 File Offset: 0x0003CBB7
		public unsafe Action onDataChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInstance.NativeFieldInfoPtr_onDataChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInstance.NativeFieldInfoPtr_onDataChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027D9 RID: 10201
		// (get) Token: 0x060083DA RID: 33754 RVA: 0x00230734 File Offset: 0x0022E934
		// (set) Token: 0x060083DB RID: 33755 RVA: 0x0003E9D6 File Offset: 0x0003CBD6
		public unsafe Action requestClearSlot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInstance.NativeFieldInfoPtr_requestClearSlot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInstance.NativeFieldInfoPtr_requestClearSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040059A6 RID: 22950
		private static readonly IntPtr NativeFieldInfoPtr_definition;

		// Token: 0x040059A7 RID: 22951
		private static readonly IntPtr NativeFieldInfoPtr_ID;

		// Token: 0x040059A8 RID: 22952
		private static readonly IntPtr NativeFieldInfoPtr_Quantity;

		// Token: 0x040059A9 RID: 22953
		private static readonly IntPtr NativeFieldInfoPtr_onDataChanged;

		// Token: 0x040059AA RID: 22954
		private static readonly IntPtr NativeFieldInfoPtr_requestClearSlot;

		// Token: 0x040059AB RID: 22955
		private static readonly IntPtr NativeMethodInfoPtr_get_Definition_Public_get_ItemDefinition_0;

		// Token: 0x040059AC RID: 22956
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0;

		// Token: 0x040059AD RID: 22957
		private static readonly IntPtr NativeMethodInfoPtr_get_Description_Public_Virtual_New_get_String_0;

		// Token: 0x040059AE RID: 22958
		private static readonly IntPtr NativeMethodInfoPtr_get_Icon_Public_Virtual_New_get_Sprite_0;

		// Token: 0x040059AF RID: 22959
		private static readonly IntPtr NativeMethodInfoPtr_get_Category_Public_Virtual_New_get_EItemCategory_0;

		// Token: 0x040059B0 RID: 22960
		private static readonly IntPtr NativeMethodInfoPtr_get_StackLimit_Public_Virtual_New_get_Int32_0;

		// Token: 0x040059B1 RID: 22961
		private static readonly IntPtr NativeMethodInfoPtr_get_LabelDisplayColor_Public_Virtual_New_get_Color_0;

		// Token: 0x040059B2 RID: 22962
		private static readonly IntPtr NativeMethodInfoPtr_get_Equippable_Public_Virtual_New_get_Equippable_0;

		// Token: 0x040059B3 RID: 22963
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040059B4 RID: 22964
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_0;

		// Token: 0x040059B5 RID: 22965
		private static readonly IntPtr NativeMethodInfoPtr_CanStackWith_Public_Virtual_New_Boolean_ItemInstance_Boolean_0;

		// Token: 0x040059B6 RID: 22966
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_Virtual_New_ItemInstance_Int32_0;

		// Token: 0x040059B7 RID: 22967
		private static readonly IntPtr NativeMethodInfoPtr_IsValidInstance_Public_Virtual_New_Boolean_0;

		// Token: 0x040059B8 RID: 22968
		private static readonly IntPtr NativeMethodInfoPtr_InvokeDataChange_Protected_Void_0;

		// Token: 0x040059B9 RID: 22969
		private static readonly IntPtr NativeMethodInfoPtr_SetQuantity_Public_Void_Int32_0;

		// Token: 0x040059BA RID: 22970
		private static readonly IntPtr NativeMethodInfoPtr_ChangeQuantity_Public_Void_Int32_0;

		// Token: 0x040059BB RID: 22971
		private static readonly IntPtr NativeMethodInfoPtr_GetItemData_Public_Virtual_New_ItemData_0;

		// Token: 0x040059BC RID: 22972
		private static readonly IntPtr NativeMethodInfoPtr_GetMonetaryValue_Public_Virtual_New_Single_0;

		// Token: 0x040059BD RID: 22973
		private static readonly IntPtr NativeMethodInfoPtr_RequestClearSlot_Public_Void_0;
	}
}
