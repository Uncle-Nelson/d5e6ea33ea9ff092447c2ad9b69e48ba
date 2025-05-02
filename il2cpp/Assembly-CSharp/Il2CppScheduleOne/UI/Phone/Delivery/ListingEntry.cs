using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.UI.Shop;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.Delivery
{
	// Token: 0x020006AD RID: 1709
	public class ListingEntry : MonoBehaviour
	{
		// Token: 0x0600996E RID: 39278 RVA: 0x002716B0 File Offset: 0x0026F8B0
		// Note: this type is marked as 'beforefieldinit'.
		static ListingEntry()
		{
			Il2CppClassPointerStore<ListingEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Delivery", "ListingEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr);
			ListingEntry.NativeFieldInfoPtr__MatchingListing_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, "<MatchingListing>k__BackingField");
			ListingEntry.NativeFieldInfoPtr__SelectedQuantity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, "<SelectedQuantity>k__BackingField");
			ListingEntry.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, "Icon");
			ListingEntry.NativeFieldInfoPtr_ItemNameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, "ItemNameLabel");
			ListingEntry.NativeFieldInfoPtr_ItemPriceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, "ItemPriceLabel");
			ListingEntry.NativeFieldInfoPtr_QuantityInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, "QuantityInput");
			ListingEntry.NativeFieldInfoPtr_IncrementButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, "IncrementButton");
			ListingEntry.NativeFieldInfoPtr_DecrementButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, "DecrementButton");
			ListingEntry.NativeFieldInfoPtr_LockedContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, "LockedContainer");
			ListingEntry.NativeFieldInfoPtr_onQuantityChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, "onQuantityChanged");
			ListingEntry.NativeMethodInfoPtr_get_MatchingListing_Public_get_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100682221);
			ListingEntry.NativeMethodInfoPtr_set_MatchingListing_Private_set_Void_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100682222);
			ListingEntry.NativeMethodInfoPtr_get_SelectedQuantity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100682223);
			ListingEntry.NativeMethodInfoPtr_set_SelectedQuantity_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100682224);
			ListingEntry.NativeMethodInfoPtr_Initialize_Public_Void_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100682225);
			ListingEntry.NativeMethodInfoPtr_RefreshLocked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100682226);
			ListingEntry.NativeMethodInfoPtr_SetQuantity_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100682227);
			ListingEntry.NativeMethodInfoPtr_ChangeQuantity_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100682228);
			ListingEntry.NativeMethodInfoPtr_OnQuantityInputSubmitted_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100682229);
			ListingEntry.NativeMethodInfoPtr_ValidateInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100682230);
			ListingEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100682231);
			ListingEntry.NativeMethodInfoPtr__Initialize_b__16_0_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100682232);
			ListingEntry.NativeMethodInfoPtr__Initialize_b__16_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100682233);
			ListingEntry.NativeMethodInfoPtr__Initialize_b__16_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100682234);
		}

		// Token: 0x17002F2F RID: 12079
		// (get) Token: 0x0600996F RID: 39279 RVA: 0x002718C0 File Offset: 0x0026FAC0
		// (set) Token: 0x06009970 RID: 39280 RVA: 0x00271900 File Offset: 0x0026FB00
		public unsafe ShopListing MatchingListing
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17399, RefRangeEnd = 17400, XrefRangeStart = 17399, XrefRangeEnd = 17400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr_get_MatchingListing_Public_get_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ShopListing>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr_set_MatchingListing_Private_set_Void_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002F30 RID: 12080
		// (get) Token: 0x06009971 RID: 39281 RVA: 0x00271944 File Offset: 0x0026FB44
		// (set) Token: 0x06009972 RID: 39282 RVA: 0x00271980 File Offset: 0x0026FB80
		public unsafe int SelectedQuantity
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29988, RefRangeEnd = 29989, XrefRangeStart = 29988, XrefRangeEnd = 29989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr_get_SelectedQuantity_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29989, RefRangeEnd = 29990, XrefRangeStart = 29989, XrefRangeEnd = 29990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr_set_SelectedQuantity_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009973 RID: 39283 RVA: 0x002719C0 File Offset: 0x0026FBC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 273924, RefRangeEnd = 273925, XrefRangeStart = 273888, XrefRangeEnd = 273924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(ShopListing match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr_Initialize_Public_Void_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009974 RID: 39284 RVA: 0x00271A04 File Offset: 0x0026FC04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 273931, RefRangeEnd = 273932, XrefRangeStart = 273925, XrefRangeEnd = 273931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshLocked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr_RefreshLocked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009975 RID: 39285 RVA: 0x00271A38 File Offset: 0x0026FC38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273932, XrefRangeEnd = 273937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetQuantity(int quant, bool notify = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quant;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr_SetQuantity_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009976 RID: 39286 RVA: 0x00271A84 File Offset: 0x0026FC84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 273942, RefRangeEnd = 273944, XrefRangeStart = 273937, XrefRangeEnd = 273942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeQuantity(int change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr_ChangeQuantity_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009977 RID: 39287 RVA: 0x00271AC4 File Offset: 0x0026FCC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273944, XrefRangeEnd = 273949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnQuantityInputSubmitted(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr_OnQuantityInputSubmitted_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009978 RID: 39288 RVA: 0x00271B08 File Offset: 0x0026FD08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273949, XrefRangeEnd = 273958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr_ValidateInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009979 RID: 39289 RVA: 0x00271B3C File Offset: 0x0026FD3C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ListingEntry() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600997A RID: 39290 RVA: 0x00271B78 File Offset: 0x0026FD78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273958, XrefRangeEnd = 273967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__16_0(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr__Initialize_b__16_0_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600997B RID: 39291 RVA: 0x00271BBC File Offset: 0x0026FDBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273967, XrefRangeEnd = 273968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__16_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr__Initialize_b__16_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600997C RID: 39292 RVA: 0x00271BF0 File Offset: 0x0026FDF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273968, XrefRangeEnd = 273969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__16_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr__Initialize_b__16_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600997D RID: 39293 RVA: 0x0004AD36 File Offset: 0x00048F36
		public ListingEntry(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002F25 RID: 12069
		// (get) Token: 0x0600997E RID: 39294 RVA: 0x00271C24 File Offset: 0x0026FE24
		// (set) Token: 0x0600997F RID: 39295 RVA: 0x0004AD3F File Offset: 0x00048F3F
		public unsafe ShopListing _MatchingListing_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr__MatchingListing_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopListing>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr__MatchingListing_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F26 RID: 12070
		// (get) Token: 0x06009980 RID: 39296 RVA: 0x00271C54 File Offset: 0x0026FE54
		// (set) Token: 0x06009981 RID: 39297 RVA: 0x0004AD5E File Offset: 0x00048F5E
		public unsafe int _SelectedQuantity_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr__SelectedQuantity_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr__SelectedQuantity_k__BackingField)) = value;
			}
		}

		// Token: 0x17002F27 RID: 12071
		// (get) Token: 0x06009982 RID: 39298 RVA: 0x00271C7C File Offset: 0x0026FE7C
		// (set) Token: 0x06009983 RID: 39299 RVA: 0x0004AD79 File Offset: 0x00048F79
		public unsafe Image Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F28 RID: 12072
		// (get) Token: 0x06009984 RID: 39300 RVA: 0x00271CAC File Offset: 0x0026FEAC
		// (set) Token: 0x06009985 RID: 39301 RVA: 0x0004AD98 File Offset: 0x00048F98
		public unsafe Text ItemNameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_ItemNameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_ItemNameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F29 RID: 12073
		// (get) Token: 0x06009986 RID: 39302 RVA: 0x00271CDC File Offset: 0x0026FEDC
		// (set) Token: 0x06009987 RID: 39303 RVA: 0x0004ADB7 File Offset: 0x00048FB7
		public unsafe Text ItemPriceLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_ItemPriceLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_ItemPriceLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F2A RID: 12074
		// (get) Token: 0x06009988 RID: 39304 RVA: 0x00271D0C File Offset: 0x0026FF0C
		// (set) Token: 0x06009989 RID: 39305 RVA: 0x0004ADD6 File Offset: 0x00048FD6
		public unsafe InputField QuantityInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_QuantityInput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_QuantityInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F2B RID: 12075
		// (get) Token: 0x0600998A RID: 39306 RVA: 0x00271D3C File Offset: 0x0026FF3C
		// (set) Token: 0x0600998B RID: 39307 RVA: 0x0004ADF5 File Offset: 0x00048FF5
		public unsafe Button IncrementButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_IncrementButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_IncrementButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F2C RID: 12076
		// (get) Token: 0x0600998C RID: 39308 RVA: 0x00271D6C File Offset: 0x0026FF6C
		// (set) Token: 0x0600998D RID: 39309 RVA: 0x0004AE14 File Offset: 0x00049014
		public unsafe Button DecrementButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_DecrementButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_DecrementButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F2D RID: 12077
		// (get) Token: 0x0600998E RID: 39310 RVA: 0x00271D9C File Offset: 0x0026FF9C
		// (set) Token: 0x0600998F RID: 39311 RVA: 0x0004AE33 File Offset: 0x00049033
		public unsafe RectTransform LockedContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_LockedContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_LockedContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F2E RID: 12078
		// (get) Token: 0x06009990 RID: 39312 RVA: 0x00271DCC File Offset: 0x0026FFCC
		// (set) Token: 0x06009991 RID: 39313 RVA: 0x0004AE52 File Offset: 0x00049052
		public unsafe UnityEvent onQuantityChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_onQuantityChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_onQuantityChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400674B RID: 26443
		private static readonly IntPtr NativeFieldInfoPtr__MatchingListing_k__BackingField;

		// Token: 0x0400674C RID: 26444
		private static readonly IntPtr NativeFieldInfoPtr__SelectedQuantity_k__BackingField;

		// Token: 0x0400674D RID: 26445
		private static readonly IntPtr NativeFieldInfoPtr_Icon;

		// Token: 0x0400674E RID: 26446
		private static readonly IntPtr NativeFieldInfoPtr_ItemNameLabel;

		// Token: 0x0400674F RID: 26447
		private static readonly IntPtr NativeFieldInfoPtr_ItemPriceLabel;

		// Token: 0x04006750 RID: 26448
		private static readonly IntPtr NativeFieldInfoPtr_QuantityInput;

		// Token: 0x04006751 RID: 26449
		private static readonly IntPtr NativeFieldInfoPtr_IncrementButton;

		// Token: 0x04006752 RID: 26450
		private static readonly IntPtr NativeFieldInfoPtr_DecrementButton;

		// Token: 0x04006753 RID: 26451
		private static readonly IntPtr NativeFieldInfoPtr_LockedContainer;

		// Token: 0x04006754 RID: 26452
		private static readonly IntPtr NativeFieldInfoPtr_onQuantityChanged;

		// Token: 0x04006755 RID: 26453
		private static readonly IntPtr NativeMethodInfoPtr_get_MatchingListing_Public_get_ShopListing_0;

		// Token: 0x04006756 RID: 26454
		private static readonly IntPtr NativeMethodInfoPtr_set_MatchingListing_Private_set_Void_ShopListing_0;

		// Token: 0x04006757 RID: 26455
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedQuantity_Public_get_Int32_0;

		// Token: 0x04006758 RID: 26456
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectedQuantity_Private_set_Void_Int32_0;

		// Token: 0x04006759 RID: 26457
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_ShopListing_0;

		// Token: 0x0400675A RID: 26458
		private static readonly IntPtr NativeMethodInfoPtr_RefreshLocked_Public_Void_0;

		// Token: 0x0400675B RID: 26459
		private static readonly IntPtr NativeMethodInfoPtr_SetQuantity_Public_Void_Int32_Boolean_0;

		// Token: 0x0400675C RID: 26460
		private static readonly IntPtr NativeMethodInfoPtr_ChangeQuantity_Private_Void_Int32_0;

		// Token: 0x0400675D RID: 26461
		private static readonly IntPtr NativeMethodInfoPtr_OnQuantityInputSubmitted_Private_Void_String_0;

		// Token: 0x0400675E RID: 26462
		private static readonly IntPtr NativeMethodInfoPtr_ValidateInput_Private_Void_0;

		// Token: 0x0400675F RID: 26463
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006760 RID: 26464
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__16_0_Private_Void_String_0;

		// Token: 0x04006761 RID: 26465
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__16_1_Private_Void_0;

		// Token: 0x04006762 RID: 26466
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__16_2_Private_Void_0;
	}
}
