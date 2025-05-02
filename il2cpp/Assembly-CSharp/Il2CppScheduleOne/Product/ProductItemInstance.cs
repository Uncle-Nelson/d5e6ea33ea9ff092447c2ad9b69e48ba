using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.Packaging;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Product.Packaging;
using Il2CppScheduleOne.Properties;
using Il2CppScheduleOne.Storage;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005A8 RID: 1448
	[Serializable]
	public class ProductItemInstance : QualityItemInstance
	{
		// Token: 0x06007E98 RID: 32408 RVA: 0x0021D9EC File Offset: 0x0021BBEC
		// Note: this type is marked as 'beforefieldinit'.
		static ProductItemInstance()
		{
			Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "ProductItemInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr);
			ProductItemInstance.NativeFieldInfoPtr_PackagingID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, "PackagingID");
			ProductItemInstance.NativeFieldInfoPtr_packaging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, "packaging");
			ProductItemInstance.NativeMethodInfoPtr_get_AppliedPackaging_Public_get_PackagingDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679127);
			ProductItemInstance.NativeMethodInfoPtr_get_Amount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679128);
			ProductItemInstance.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679129);
			ProductItemInstance.NativeMethodInfoPtr_get_Equippable_Public_Virtual_get_Equippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679130);
			ProductItemInstance.NativeMethodInfoPtr_get_StoredItem_Public_Virtual_get_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679131);
			ProductItemInstance.NativeMethodInfoPtr_get_Icon_Public_Virtual_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679132);
			ProductItemInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679133);
			ProductItemInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_EQuality_PackagingDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679134);
			ProductItemInstance.NativeMethodInfoPtr_CanStackWith_Public_Virtual_Boolean_ItemInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679135);
			ProductItemInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679136);
			ProductItemInstance.NativeMethodInfoPtr_SetPackaging_Public_Virtual_New_Void_PackagingDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679137);
			ProductItemInstance.NativeMethodInfoPtr_GetEquippable_Private_Equippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679138);
			ProductItemInstance.NativeMethodInfoPtr_GetStoredItem_Private_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679139);
			ProductItemInstance.NativeMethodInfoPtr_SetupPackagingVisuals_Public_Virtual_New_Void_FilledPackagingVisuals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679140);
			ProductItemInstance.NativeMethodInfoPtr_GetIcon_Private_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679141);
			ProductItemInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679142);
			ProductItemInstance.NativeMethodInfoPtr_GetAddictiveness_Public_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679143);
			ProductItemInstance.NativeMethodInfoPtr_GetSimilarity_Public_Single_ProductDefinition_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679144);
			ProductItemInstance.NativeMethodInfoPtr_ApplyEffectsToNPC_Public_Virtual_New_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679145);
			ProductItemInstance.NativeMethodInfoPtr_ClearEffectsFromNPC_Public_Virtual_New_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679146);
			ProductItemInstance.NativeMethodInfoPtr_ApplyEffectsToPlayer_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679147);
			ProductItemInstance.NativeMethodInfoPtr_ClearEffectsFromPlayer_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679148);
			ProductItemInstance.NativeMethodInfoPtr_GetMonetaryValue_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679149);
		}

		// Token: 0x17002652 RID: 9810
		// (get) Token: 0x06007E99 RID: 32409 RVA: 0x0021DC10 File Offset: 0x0021BE10
		public unsafe PackagingDefinition AppliedPackaging
		{
			[CallerCount(49)]
			[CachedScanResults(RefRangeStart = 239473, RefRangeEnd = 239522, XrefRangeStart = 239446, XrefRangeEnd = 239473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.NativeMethodInfoPtr_get_AppliedPackaging_Public_get_PackagingDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PackagingDefinition>(intPtr3) : null;
			}
		}

		// Token: 0x17002653 RID: 9811
		// (get) Token: 0x06007E9A RID: 32410 RVA: 0x0021DC50 File Offset: 0x0021BE50
		public unsafe int Amount
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 239528, RefRangeEnd = 239545, XrefRangeStart = 239522, XrefRangeEnd = 239528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.NativeMethodInfoPtr_get_Amount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002654 RID: 9812
		// (get) Token: 0x06007E9B RID: 32411 RVA: 0x0021DC8C File Offset: 0x0021BE8C
		public unsafe override string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239545, XrefRangeEnd = 239556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17002655 RID: 9813
		// (get) Token: 0x06007E9C RID: 32412 RVA: 0x0021DCD0 File Offset: 0x0021BED0
		public unsafe override Equippable Equippable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239556, XrefRangeEnd = 239563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_get_Equippable_Public_Virtual_get_Equippable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Equippable>(intPtr3) : null;
			}
		}

		// Token: 0x17002656 RID: 9814
		// (get) Token: 0x06007E9D RID: 32413 RVA: 0x0021DD1C File Offset: 0x0021BF1C
		public unsafe override StoredItem StoredItem
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239563, XrefRangeEnd = 239570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_get_StoredItem_Public_Virtual_get_StoredItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StoredItem>(intPtr3) : null;
			}
		}

		// Token: 0x17002657 RID: 9815
		// (get) Token: 0x06007E9E RID: 32414 RVA: 0x0021DD68 File Offset: 0x0021BF68
		public unsafe override Sprite Icon
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239570, XrefRangeEnd = 239582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_get_Icon_Public_Virtual_get_Sprite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
		}

		// Token: 0x06007E9F RID: 32415 RVA: 0x0021DDB4 File Offset: 0x0021BFB4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 238569, RefRangeEnd = 238574, XrefRangeStart = 238569, XrefRangeEnd = 238574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductItemInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007EA0 RID: 32416 RVA: 0x0021DDF0 File Offset: 0x0021BFF0
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 239595, RefRangeEnd = 239607, XrefRangeStart = 239582, XrefRangeEnd = 239595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductItemInstance(ItemDefinition definition, int quantity, EQuality quality, PackagingDefinition _packaging = null) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quality;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_packaging);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_EQuality_PackagingDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007EA1 RID: 32417 RVA: 0x0021DE6C File Offset: 0x0021C06C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239607, XrefRangeEnd = 239630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanStackWith(ItemInstance other, bool checkQuantities = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkQuantities;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_CanStackWith_Public_Virtual_Boolean_ItemInstance_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007EA2 RID: 32418 RVA: 0x0021DED4 File Offset: 0x0021C0D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239630, XrefRangeEnd = 239636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref overrideQuantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06007EA3 RID: 32419 RVA: 0x0021DF2C File Offset: 0x0021C12C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239636, XrefRangeEnd = 239645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetPackaging(PackagingDefinition def)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(def);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_SetPackaging_Public_Virtual_New_Void_PackagingDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007EA4 RID: 32420 RVA: 0x0021DF7C File Offset: 0x0021C17C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable GetEquippable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.NativeMethodInfoPtr_GetEquippable_Private_Equippable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Equippable>(intPtr3) : null;
		}

		// Token: 0x06007EA5 RID: 32421 RVA: 0x0021DFBC File Offset: 0x0021C1BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StoredItem GetStoredItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.NativeMethodInfoPtr_GetStoredItem_Private_StoredItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StoredItem>(intPtr3) : null;
		}

		// Token: 0x06007EA6 RID: 32422 RVA: 0x0021DFFC File Offset: 0x0021C1FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 239647, RefRangeEnd = 239648, XrefRangeStart = 239645, XrefRangeEnd = 239647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetupPackagingVisuals(FilledPackagingVisuals visuals)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(visuals);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_SetupPackagingVisuals_Public_Virtual_New_Void_FilledPackagingVisuals_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007EA7 RID: 32423 RVA: 0x0021E04C File Offset: 0x0021C24C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239648, XrefRangeEnd = 239660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sprite GetIcon()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.NativeMethodInfoPtr_GetIcon_Private_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
		}

		// Token: 0x06007EA8 RID: 32424 RVA: 0x0021E08C File Offset: 0x0021C28C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239660, XrefRangeEnd = 239667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemData GetItemData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemData>(intPtr3) : null;
		}

		// Token: 0x06007EA9 RID: 32425 RVA: 0x0021E0D8 File Offset: 0x0021C2D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239667, XrefRangeEnd = 239675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float GetAddictiveness()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_GetAddictiveness_Public_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007EAA RID: 32426 RVA: 0x0021E120 File Offset: 0x0021C320
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 239699, RefRangeEnd = 239700, XrefRangeStart = 239675, XrefRangeEnd = 239699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetSimilarity(ProductDefinition other, EQuality quality)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quality;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.NativeMethodInfoPtr_GetSimilarity_Public_Single_ProductDefinition_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007EAB RID: 32427 RVA: 0x0021E17C File Offset: 0x0021C37C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 239738, RefRangeEnd = 239741, XrefRangeStart = 239700, XrefRangeEnd = 239738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplyEffectsToNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_ApplyEffectsToNPC_Public_Virtual_New_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007EAC RID: 32428 RVA: 0x0021E1CC File Offset: 0x0021C3CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 239779, RefRangeEnd = 239782, XrefRangeStart = 239741, XrefRangeEnd = 239779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ClearEffectsFromNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_ClearEffectsFromNPC_Public_Virtual_New_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007EAD RID: 32429 RVA: 0x0021E21C File Offset: 0x0021C41C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 239820, RefRangeEnd = 239823, XrefRangeStart = 239782, XrefRangeEnd = 239820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplyEffectsToPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_ApplyEffectsToPlayer_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007EAE RID: 32430 RVA: 0x0021E26C File Offset: 0x0021C46C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 239861, RefRangeEnd = 239864, XrefRangeStart = 239823, XrefRangeEnd = 239861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ClearEffectsFromPlayer(Player Player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(Player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_ClearEffectsFromPlayer_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007EAF RID: 32431 RVA: 0x0021E2BC File Offset: 0x0021C4BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239864, XrefRangeEnd = 239872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float GetMonetaryValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_GetMonetaryValue_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007EB0 RID: 32432 RVA: 0x0003C2C8 File Offset: 0x0003A4C8
		public ProductItemInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002650 RID: 9808
		// (get) Token: 0x06007EB1 RID: 32433 RVA: 0x0021E304 File Offset: 0x0021C504
		// (set) Token: 0x06007EB2 RID: 32434 RVA: 0x0003C2D1 File Offset: 0x0003A4D1
		public unsafe string PackagingID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductItemInstance.NativeFieldInfoPtr_PackagingID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductItemInstance.NativeFieldInfoPtr_PackagingID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002651 RID: 9809
		// (get) Token: 0x06007EB3 RID: 32435 RVA: 0x0021E32C File Offset: 0x0021C52C
		// (set) Token: 0x06007EB4 RID: 32436 RVA: 0x0003C2F0 File Offset: 0x0003A4F0
		public unsafe PackagingDefinition packaging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductItemInstance.NativeFieldInfoPtr_packaging);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductItemInstance.NativeFieldInfoPtr_packaging), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005625 RID: 22053
		private static readonly IntPtr NativeFieldInfoPtr_PackagingID;

		// Token: 0x04005626 RID: 22054
		private static readonly IntPtr NativeFieldInfoPtr_packaging;

		// Token: 0x04005627 RID: 22055
		private static readonly IntPtr NativeMethodInfoPtr_get_AppliedPackaging_Public_get_PackagingDefinition_0;

		// Token: 0x04005628 RID: 22056
		private static readonly IntPtr NativeMethodInfoPtr_get_Amount_Public_get_Int32_0;

		// Token: 0x04005629 RID: 22057
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x0400562A RID: 22058
		private static readonly IntPtr NativeMethodInfoPtr_get_Equippable_Public_Virtual_get_Equippable_0;

		// Token: 0x0400562B RID: 22059
		private static readonly IntPtr NativeMethodInfoPtr_get_StoredItem_Public_Virtual_get_StoredItem_0;

		// Token: 0x0400562C RID: 22060
		private static readonly IntPtr NativeMethodInfoPtr_get_Icon_Public_Virtual_get_Sprite_0;

		// Token: 0x0400562D RID: 22061
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400562E RID: 22062
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_EQuality_PackagingDefinition_0;

		// Token: 0x0400562F RID: 22063
		private static readonly IntPtr NativeMethodInfoPtr_CanStackWith_Public_Virtual_Boolean_ItemInstance_Boolean_0;

		// Token: 0x04005630 RID: 22064
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x04005631 RID: 22065
		private static readonly IntPtr NativeMethodInfoPtr_SetPackaging_Public_Virtual_New_Void_PackagingDefinition_0;

		// Token: 0x04005632 RID: 22066
		private static readonly IntPtr NativeMethodInfoPtr_GetEquippable_Private_Equippable_0;

		// Token: 0x04005633 RID: 22067
		private static readonly IntPtr NativeMethodInfoPtr_GetStoredItem_Private_StoredItem_0;

		// Token: 0x04005634 RID: 22068
		private static readonly IntPtr NativeMethodInfoPtr_SetupPackagingVisuals_Public_Virtual_New_Void_FilledPackagingVisuals_0;

		// Token: 0x04005635 RID: 22069
		private static readonly IntPtr NativeMethodInfoPtr_GetIcon_Private_Sprite_0;

		// Token: 0x04005636 RID: 22070
		private static readonly IntPtr NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0;

		// Token: 0x04005637 RID: 22071
		private static readonly IntPtr NativeMethodInfoPtr_GetAddictiveness_Public_Virtual_New_Single_0;

		// Token: 0x04005638 RID: 22072
		private static readonly IntPtr NativeMethodInfoPtr_GetSimilarity_Public_Single_ProductDefinition_EQuality_0;

		// Token: 0x04005639 RID: 22073
		private static readonly IntPtr NativeMethodInfoPtr_ApplyEffectsToNPC_Public_Virtual_New_Void_NPC_0;

		// Token: 0x0400563A RID: 22074
		private static readonly IntPtr NativeMethodInfoPtr_ClearEffectsFromNPC_Public_Virtual_New_Void_NPC_0;

		// Token: 0x0400563B RID: 22075
		private static readonly IntPtr NativeMethodInfoPtr_ApplyEffectsToPlayer_Public_Virtual_New_Void_Player_0;

		// Token: 0x0400563C RID: 22076
		private static readonly IntPtr NativeMethodInfoPtr_ClearEffectsFromPlayer_Public_Virtual_New_Void_Player_0;

		// Token: 0x0400563D RID: 22077
		private static readonly IntPtr NativeMethodInfoPtr_GetMonetaryValue_Public_Virtual_Single_0;

		// Token: 0x02000ACC RID: 2764
		[ObfuscatedName("ScheduleOne.Product.ProductItemInstance+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D464 RID: 54372 RVA: 0x0032B030 File Offset: 0x00329230
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr);
				ProductItemInstance.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr, "<>9");
				ProductItemInstance.__c.NativeFieldInfoPtr___9__26_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr, "<>9__26_0");
				ProductItemInstance.__c.NativeFieldInfoPtr___9__27_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr, "<>9__27_0");
				ProductItemInstance.__c.NativeFieldInfoPtr___9__28_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr, "<>9__28_0");
				ProductItemInstance.__c.NativeFieldInfoPtr___9__29_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr, "<>9__29_0");
				ProductItemInstance.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr, 100679151);
				ProductItemInstance.__c.NativeMethodInfoPtr__ApplyEffectsToNPC_b__26_0_Internal_Int32_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr, 100679152);
				ProductItemInstance.__c.NativeMethodInfoPtr__ClearEffectsFromNPC_b__27_0_Internal_Int32_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr, 100679153);
				ProductItemInstance.__c.NativeMethodInfoPtr__ApplyEffectsToPlayer_b__28_0_Internal_Int32_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr, 100679154);
				ProductItemInstance.__c.NativeMethodInfoPtr__ClearEffectsFromPlayer_b__29_0_Internal_Int32_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr, 100679155);
			}

			// Token: 0x0600D465 RID: 54373 RVA: 0x0032B124 File Offset: 0x00329324
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D466 RID: 54374 RVA: 0x0032B160 File Offset: 0x00329360
			[CallerCount(0)]
			public unsafe int _ApplyEffectsToNPC_b__26_0(Property x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.__c.NativeMethodInfoPtr__ApplyEffectsToNPC_b__26_0_Internal_Int32_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D467 RID: 54375 RVA: 0x0032B1B0 File Offset: 0x003293B0
			[CallerCount(0)]
			public unsafe int _ClearEffectsFromNPC_b__27_0(Property x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.__c.NativeMethodInfoPtr__ClearEffectsFromNPC_b__27_0_Internal_Int32_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D468 RID: 54376 RVA: 0x0032B200 File Offset: 0x00329400
			[CallerCount(0)]
			public unsafe int _ApplyEffectsToPlayer_b__28_0(Property x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.__c.NativeMethodInfoPtr__ApplyEffectsToPlayer_b__28_0_Internal_Int32_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D469 RID: 54377 RVA: 0x0032B250 File Offset: 0x00329450
			[CallerCount(0)]
			public unsafe int _ClearEffectsFromPlayer_b__29_0(Property x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.__c.NativeMethodInfoPtr__ClearEffectsFromPlayer_b__29_0_Internal_Int32_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D46A RID: 54378 RVA: 0x000675FD File Offset: 0x000657FD
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041D6 RID: 16854
			// (get) Token: 0x0600D46B RID: 54379 RVA: 0x0032B2A0 File Offset: 0x003294A0
			// (set) Token: 0x0600D46C RID: 54380 RVA: 0x00067606 File Offset: 0x00065806
			public unsafe static ProductItemInstance.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProductItemInstance.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductItemInstance.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProductItemInstance.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041D7 RID: 16855
			// (get) Token: 0x0600D46D RID: 54381 RVA: 0x0032B2C8 File Offset: 0x003294C8
			// (set) Token: 0x0600D46E RID: 54382 RVA: 0x00067618 File Offset: 0x00065818
			public unsafe static Func<Property, int> __9__26_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProductItemInstance.__c.NativeFieldInfoPtr___9__26_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Property, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProductItemInstance.__c.NativeFieldInfoPtr___9__26_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041D8 RID: 16856
			// (get) Token: 0x0600D46F RID: 54383 RVA: 0x0032B2F0 File Offset: 0x003294F0
			// (set) Token: 0x0600D470 RID: 54384 RVA: 0x0006762A File Offset: 0x0006582A
			public unsafe static Func<Property, int> __9__27_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProductItemInstance.__c.NativeFieldInfoPtr___9__27_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Property, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProductItemInstance.__c.NativeFieldInfoPtr___9__27_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041D9 RID: 16857
			// (get) Token: 0x0600D471 RID: 54385 RVA: 0x0032B318 File Offset: 0x00329518
			// (set) Token: 0x0600D472 RID: 54386 RVA: 0x0006763C File Offset: 0x0006583C
			public unsafe static Func<Property, int> __9__28_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProductItemInstance.__c.NativeFieldInfoPtr___9__28_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Property, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProductItemInstance.__c.NativeFieldInfoPtr___9__28_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041DA RID: 16858
			// (get) Token: 0x0600D473 RID: 54387 RVA: 0x0032B340 File Offset: 0x00329540
			// (set) Token: 0x0600D474 RID: 54388 RVA: 0x0006764E File Offset: 0x0006584E
			public unsafe static Func<Property, int> __9__29_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProductItemInstance.__c.NativeFieldInfoPtr___9__29_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Property, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProductItemInstance.__c.NativeFieldInfoPtr___9__29_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008EFC RID: 36604
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008EFD RID: 36605
			private static readonly IntPtr NativeFieldInfoPtr___9__26_0;

			// Token: 0x04008EFE RID: 36606
			private static readonly IntPtr NativeFieldInfoPtr___9__27_0;

			// Token: 0x04008EFF RID: 36607
			private static readonly IntPtr NativeFieldInfoPtr___9__28_0;

			// Token: 0x04008F00 RID: 36608
			private static readonly IntPtr NativeFieldInfoPtr___9__29_0;

			// Token: 0x04008F01 RID: 36609
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F02 RID: 36610
			private static readonly IntPtr NativeMethodInfoPtr__ApplyEffectsToNPC_b__26_0_Internal_Int32_Property_0;

			// Token: 0x04008F03 RID: 36611
			private static readonly IntPtr NativeMethodInfoPtr__ClearEffectsFromNPC_b__27_0_Internal_Int32_Property_0;

			// Token: 0x04008F04 RID: 36612
			private static readonly IntPtr NativeMethodInfoPtr__ApplyEffectsToPlayer_b__28_0_Internal_Int32_Property_0;

			// Token: 0x04008F05 RID: 36613
			private static readonly IntPtr NativeMethodInfoPtr__ClearEffectsFromPlayer_b__29_0_Internal_Int32_Property_0;
		}
	}
}
