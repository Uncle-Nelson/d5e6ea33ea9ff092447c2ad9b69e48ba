using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Shop
{
	// Token: 0x02000706 RID: 1798
	public class CartEntry : MonoBehaviour
	{
		// Token: 0x0600A1A0 RID: 41376 RVA: 0x0028A6FC File Offset: 0x002888FC
		// Note: this type is marked as 'beforefieldinit'.
		static CartEntry()
		{
			Il2CppClassPointerStore<CartEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Shop", "CartEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CartEntry>.NativeClassPtr);
			CartEntry.NativeFieldInfoPtr_NameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, "NameLabel");
			CartEntry.NativeFieldInfoPtr_PriceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, "PriceLabel");
			CartEntry.NativeFieldInfoPtr_IncrementButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, "IncrementButton");
			CartEntry.NativeFieldInfoPtr_DecrementButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, "DecrementButton");
			CartEntry.NativeFieldInfoPtr_RemoveButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, "RemoveButton");
			CartEntry.NativeFieldInfoPtr__Quantity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, "<Quantity>k__BackingField");
			CartEntry.NativeFieldInfoPtr__Cart_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, "<Cart>k__BackingField");
			CartEntry.NativeFieldInfoPtr__Listing_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, "<Listing>k__BackingField");
			CartEntry.NativeMethodInfoPtr_get_Quantity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100683073);
			CartEntry.NativeMethodInfoPtr_set_Quantity_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100683074);
			CartEntry.NativeMethodInfoPtr_get_Cart_Public_get_Cart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100683075);
			CartEntry.NativeMethodInfoPtr_set_Cart_Protected_set_Void_Cart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100683076);
			CartEntry.NativeMethodInfoPtr_get_Listing_Public_get_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100683077);
			CartEntry.NativeMethodInfoPtr_set_Listing_Protected_set_Void_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100683078);
			CartEntry.NativeMethodInfoPtr_Initialize_Public_Void_Cart_ShopListing_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100683079);
			CartEntry.NativeMethodInfoPtr_SetQuantity_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100683080);
			CartEntry.NativeMethodInfoPtr_UpdateTitle_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100683081);
			CartEntry.NativeMethodInfoPtr_UpdatePrice_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100683082);
			CartEntry.NativeMethodInfoPtr_ChangeAmount_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100683083);
			CartEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100683084);
			CartEntry.NativeMethodInfoPtr__Initialize_b__17_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100683085);
			CartEntry.NativeMethodInfoPtr__Initialize_b__17_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100683086);
			CartEntry.NativeMethodInfoPtr__Initialize_b__17_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100683087);
		}

		// Token: 0x170031D8 RID: 12760
		// (get) Token: 0x0600A1A1 RID: 41377 RVA: 0x0028A8F8 File Offset: 0x00288AF8
		// (set) Token: 0x0600A1A2 RID: 41378 RVA: 0x0028A934 File Offset: 0x00288B34
		public unsafe int Quantity
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 42845, RefRangeEnd = 42849, XrefRangeStart = 42845, XrefRangeEnd = 42849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr_get_Quantity_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr_set_Quantity_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170031D9 RID: 12761
		// (get) Token: 0x0600A1A3 RID: 41379 RVA: 0x0028A974 File Offset: 0x00288B74
		// (set) Token: 0x0600A1A4 RID: 41380 RVA: 0x0028A9B4 File Offset: 0x00288BB4
		public unsafe Cart Cart
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 16593, RefRangeEnd = 16594, XrefRangeStart = 16593, XrefRangeEnd = 16594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr_get_Cart_Public_get_Cart_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Cart>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 38376, RefRangeEnd = 38379, XrefRangeStart = 38376, XrefRangeEnd = 38379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr_set_Cart_Protected_set_Void_Cart_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170031DA RID: 12762
		// (get) Token: 0x0600A1A5 RID: 41381 RVA: 0x0028A9F8 File Offset: 0x00288BF8
		// (set) Token: 0x0600A1A6 RID: 41382 RVA: 0x0028AA38 File Offset: 0x00288C38
		public unsafe ShopListing Listing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr_get_Listing_Public_get_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr_set_Listing_Protected_set_Void_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A1A7 RID: 41383 RVA: 0x0028AA7C File Offset: 0x00288C7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284292, RefRangeEnd = 284293, XrefRangeStart = 284268, XrefRangeEnd = 284292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Cart cart, ShopListing listing, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cart);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listing);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr_Initialize_Public_Void_Cart_ShopListing_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1A8 RID: 41384 RVA: 0x0028AAE0 File Offset: 0x00288CE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284296, RefRangeEnd = 284297, XrefRangeStart = 284293, XrefRangeEnd = 284296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetQuantity(int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr_SetQuantity_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1A9 RID: 41385 RVA: 0x0028AB20 File Offset: 0x00288D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284297, XrefRangeEnd = 284301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateTitle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartEntry.NativeMethodInfoPtr_UpdateTitle_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1AA RID: 41386 RVA: 0x0028AB5C File Offset: 0x00288D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284301, XrefRangeEnd = 284304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePrice()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr_UpdatePrice_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1AB RID: 41387 RVA: 0x0028AB90 File Offset: 0x00288D90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 284326, RefRangeEnd = 284328, XrefRangeStart = 284304, XrefRangeEnd = 284326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeAmount(int change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr_ChangeAmount_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1AC RID: 41388 RVA: 0x0028ABD0 File Offset: 0x00288DD0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CartEntry() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CartEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1AD RID: 41389 RVA: 0x0028AC0C File Offset: 0x00288E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284328, XrefRangeEnd = 284329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__17_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr__Initialize_b__17_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1AE RID: 41390 RVA: 0x0028AC40 File Offset: 0x00288E40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284329, XrefRangeEnd = 284330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__17_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr__Initialize_b__17_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1AF RID: 41391 RVA: 0x0028AC74 File Offset: 0x00288E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284330, XrefRangeEnd = 284331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__17_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr__Initialize_b__17_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1B0 RID: 41392 RVA: 0x0004F86A File Offset: 0x0004DA6A
		public CartEntry(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170031D0 RID: 12752
		// (get) Token: 0x0600A1B1 RID: 41393 RVA: 0x0028ACA8 File Offset: 0x00288EA8
		// (set) Token: 0x0600A1B2 RID: 41394 RVA: 0x0004F873 File Offset: 0x0004DA73
		public unsafe TextMeshProUGUI NameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr_NameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr_NameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031D1 RID: 12753
		// (get) Token: 0x0600A1B3 RID: 41395 RVA: 0x0028ACD8 File Offset: 0x00288ED8
		// (set) Token: 0x0600A1B4 RID: 41396 RVA: 0x0004F892 File Offset: 0x0004DA92
		public unsafe TextMeshProUGUI PriceLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr_PriceLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr_PriceLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031D2 RID: 12754
		// (get) Token: 0x0600A1B5 RID: 41397 RVA: 0x0028AD08 File Offset: 0x00288F08
		// (set) Token: 0x0600A1B6 RID: 41398 RVA: 0x0004F8B1 File Offset: 0x0004DAB1
		public unsafe Button IncrementButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr_IncrementButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr_IncrementButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031D3 RID: 12755
		// (get) Token: 0x0600A1B7 RID: 41399 RVA: 0x0028AD38 File Offset: 0x00288F38
		// (set) Token: 0x0600A1B8 RID: 41400 RVA: 0x0004F8D0 File Offset: 0x0004DAD0
		public unsafe Button DecrementButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr_DecrementButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr_DecrementButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031D4 RID: 12756
		// (get) Token: 0x0600A1B9 RID: 41401 RVA: 0x0028AD68 File Offset: 0x00288F68
		// (set) Token: 0x0600A1BA RID: 41402 RVA: 0x0004F8EF File Offset: 0x0004DAEF
		public unsafe Button RemoveButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr_RemoveButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr_RemoveButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031D5 RID: 12757
		// (get) Token: 0x0600A1BB RID: 41403 RVA: 0x0028AD98 File Offset: 0x00288F98
		// (set) Token: 0x0600A1BC RID: 41404 RVA: 0x0004F90E File Offset: 0x0004DB0E
		public unsafe int _Quantity_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr__Quantity_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr__Quantity_k__BackingField)) = value;
			}
		}

		// Token: 0x170031D6 RID: 12758
		// (get) Token: 0x0600A1BD RID: 41405 RVA: 0x0028ADC0 File Offset: 0x00288FC0
		// (set) Token: 0x0600A1BE RID: 41406 RVA: 0x0004F929 File Offset: 0x0004DB29
		public unsafe Cart _Cart_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr__Cart_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cart>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr__Cart_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031D7 RID: 12759
		// (get) Token: 0x0600A1BF RID: 41407 RVA: 0x0028ADF0 File Offset: 0x00288FF0
		// (set) Token: 0x0600A1C0 RID: 41408 RVA: 0x0004F948 File Offset: 0x0004DB48
		public unsafe ShopListing _Listing_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr__Listing_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopListing>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr__Listing_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006C5B RID: 27739
		private static readonly IntPtr NativeFieldInfoPtr_NameLabel;

		// Token: 0x04006C5C RID: 27740
		private static readonly IntPtr NativeFieldInfoPtr_PriceLabel;

		// Token: 0x04006C5D RID: 27741
		private static readonly IntPtr NativeFieldInfoPtr_IncrementButton;

		// Token: 0x04006C5E RID: 27742
		private static readonly IntPtr NativeFieldInfoPtr_DecrementButton;

		// Token: 0x04006C5F RID: 27743
		private static readonly IntPtr NativeFieldInfoPtr_RemoveButton;

		// Token: 0x04006C60 RID: 27744
		private static readonly IntPtr NativeFieldInfoPtr__Quantity_k__BackingField;

		// Token: 0x04006C61 RID: 27745
		private static readonly IntPtr NativeFieldInfoPtr__Cart_k__BackingField;

		// Token: 0x04006C62 RID: 27746
		private static readonly IntPtr NativeFieldInfoPtr__Listing_k__BackingField;

		// Token: 0x04006C63 RID: 27747
		private static readonly IntPtr NativeMethodInfoPtr_get_Quantity_Public_get_Int32_0;

		// Token: 0x04006C64 RID: 27748
		private static readonly IntPtr NativeMethodInfoPtr_set_Quantity_Protected_set_Void_Int32_0;

		// Token: 0x04006C65 RID: 27749
		private static readonly IntPtr NativeMethodInfoPtr_get_Cart_Public_get_Cart_0;

		// Token: 0x04006C66 RID: 27750
		private static readonly IntPtr NativeMethodInfoPtr_set_Cart_Protected_set_Void_Cart_0;

		// Token: 0x04006C67 RID: 27751
		private static readonly IntPtr NativeMethodInfoPtr_get_Listing_Public_get_ShopListing_0;

		// Token: 0x04006C68 RID: 27752
		private static readonly IntPtr NativeMethodInfoPtr_set_Listing_Protected_set_Void_ShopListing_0;

		// Token: 0x04006C69 RID: 27753
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Cart_ShopListing_Int32_0;

		// Token: 0x04006C6A RID: 27754
		private static readonly IntPtr NativeMethodInfoPtr_SetQuantity_Public_Void_Int32_0;

		// Token: 0x04006C6B RID: 27755
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTitle_Protected_Virtual_New_Void_0;

		// Token: 0x04006C6C RID: 27756
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePrice_Private_Void_0;

		// Token: 0x04006C6D RID: 27757
		private static readonly IntPtr NativeMethodInfoPtr_ChangeAmount_Private_Void_Int32_0;

		// Token: 0x04006C6E RID: 27758
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006C6F RID: 27759
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__17_0_Private_Void_0;

		// Token: 0x04006C70 RID: 27760
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__17_1_Private_Void_0;

		// Token: 0x04006C71 RID: 27761
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__17_2_Private_Void_0;
	}
}
