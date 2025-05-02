using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Clothing;
using Il2CppScheduleOne.DevUtilities;

namespace Il2CppScheduleOne.UI.Shop
{
	// Token: 0x02000709 RID: 1801
	public class ClothingShopInterface : ShopInterface
	{
		// Token: 0x0600A1D8 RID: 41432 RVA: 0x0028B2C4 File Offset: 0x002894C4
		// Note: this type is marked as 'beforefieldinit'.
		static ClothingShopInterface()
		{
			Il2CppClassPointerStore<ClothingShopInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Shop", "ClothingShopInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingShopInterface>.NativeClassPtr);
			ClothingShopInterface.NativeFieldInfoPtr_ColorPicker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingShopInterface>.NativeClassPtr, "ColorPicker");
			ClothingShopInterface.NativeFieldInfoPtr__selectedListing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingShopInterface>.NativeClassPtr, "_selectedListing");
			ClothingShopInterface.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingShopInterface>.NativeClassPtr, 100683099);
			ClothingShopInterface.NativeMethodInfoPtr_ListingClicked_Public_Virtual_Void_ListingUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingShopInterface>.NativeClassPtr, 100683100);
			ClothingShopInterface.NativeMethodInfoPtr_Exit_Protected_Virtual_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingShopInterface>.NativeClassPtr, 100683101);
			ClothingShopInterface.NativeMethodInfoPtr_ColorPicked_Private_Void_EClothingColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingShopInterface>.NativeClassPtr, 100683102);
			ClothingShopInterface.NativeMethodInfoPtr_HandoverItems_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingShopInterface>.NativeClassPtr, 100683103);
			ClothingShopInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingShopInterface>.NativeClassPtr, 100683104);
		}

		// Token: 0x0600A1D9 RID: 41433 RVA: 0x0028B394 File Offset: 0x00289594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284389, XrefRangeEnd = 284400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClothingShopInterface.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1DA RID: 41434 RVA: 0x0028B3D0 File Offset: 0x002895D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284400, XrefRangeEnd = 284407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ListingClicked(ListingUI listingUI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listingUI);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClothingShopInterface.NativeMethodInfoPtr_ListingClicked_Public_Virtual_Void_ListingUI_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1DB RID: 41435 RVA: 0x0028B420 File Offset: 0x00289620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284407, XrefRangeEnd = 284417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClothingShopInterface.NativeMethodInfoPtr_Exit_Protected_Virtual_Void_ExitAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1DC RID: 41436 RVA: 0x0028B470 File Offset: 0x00289670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284417, XrefRangeEnd = 284423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ColorPicked(EClothingColor color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingShopInterface.NativeMethodInfoPtr_ColorPicked_Private_Void_EClothingColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1DD RID: 41437 RVA: 0x0028B4B0 File Offset: 0x002896B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284423, XrefRangeEnd = 284491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool HandoverItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClothingShopInterface.NativeMethodInfoPtr_HandoverItems_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A1DE RID: 41438 RVA: 0x0028B4F8 File Offset: 0x002896F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284491, XrefRangeEnd = 284495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClothingShopInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingShopInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingShopInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1DF RID: 41439 RVA: 0x0004F9ED File Offset: 0x0004DBED
		public ClothingShopInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170031E0 RID: 12768
		// (get) Token: 0x0600A1E0 RID: 41440 RVA: 0x0028B534 File Offset: 0x00289734
		// (set) Token: 0x0600A1E1 RID: 41441 RVA: 0x0004F9F6 File Offset: 0x0004DBF6
		public unsafe ShopColorPicker ColorPicker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingShopInterface.NativeFieldInfoPtr_ColorPicker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopColorPicker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingShopInterface.NativeFieldInfoPtr_ColorPicker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031E1 RID: 12769
		// (get) Token: 0x0600A1E2 RID: 41442 RVA: 0x0028B564 File Offset: 0x00289764
		// (set) Token: 0x0600A1E3 RID: 41443 RVA: 0x0004FA15 File Offset: 0x0004DC15
		public unsafe ShopListing _selectedListing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingShopInterface.NativeFieldInfoPtr__selectedListing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopListing>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingShopInterface.NativeFieldInfoPtr__selectedListing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006C81 RID: 27777
		private static readonly IntPtr NativeFieldInfoPtr_ColorPicker;

		// Token: 0x04006C82 RID: 27778
		private static readonly IntPtr NativeFieldInfoPtr__selectedListing;

		// Token: 0x04006C83 RID: 27779
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04006C84 RID: 27780
		private static readonly IntPtr NativeMethodInfoPtr_ListingClicked_Public_Virtual_Void_ListingUI_0;

		// Token: 0x04006C85 RID: 27781
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Protected_Virtual_Void_ExitAction_0;

		// Token: 0x04006C86 RID: 27782
		private static readonly IntPtr NativeMethodInfoPtr_ColorPicked_Private_Void_EClothingColor_0;

		// Token: 0x04006C87 RID: 27783
		private static readonly IntPtr NativeMethodInfoPtr_HandoverItems_Public_Virtual_Boolean_0;

		// Token: 0x04006C88 RID: 27784
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
