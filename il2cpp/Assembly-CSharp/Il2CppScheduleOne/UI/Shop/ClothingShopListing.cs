using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Clothing;

namespace Il2CppScheduleOne.UI.Shop
{
	// Token: 0x0200070A RID: 1802
	public class ClothingShopListing : ShopListing
	{
		// Token: 0x0600A1E4 RID: 41444 RVA: 0x0028B594 File Offset: 0x00289794
		// Note: this type is marked as 'beforefieldinit'.
		static ClothingShopListing()
		{
			Il2CppClassPointerStore<ClothingShopListing>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Shop", "ClothingShopListing");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingShopListing>.NativeClassPtr);
			ClothingShopListing.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingShopListing>.NativeClassPtr, "Color");
			ClothingShopListing.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingShopListing>.NativeClassPtr, 100683105);
		}

		// Token: 0x0600A1E5 RID: 41445 RVA: 0x0028B5EC File Offset: 0x002897EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284495, XrefRangeEnd = 284496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClothingShopListing() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingShopListing>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingShopListing.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1E6 RID: 41446 RVA: 0x0004FA34 File Offset: 0x0004DC34
		public ClothingShopListing(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170031E2 RID: 12770
		// (get) Token: 0x0600A1E7 RID: 41447 RVA: 0x0028B628 File Offset: 0x00289828
		// (set) Token: 0x0600A1E8 RID: 41448 RVA: 0x0004FA3D File Offset: 0x0004DC3D
		public unsafe EClothingColor Color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingShopListing.NativeFieldInfoPtr_Color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingShopListing.NativeFieldInfoPtr_Color)) = value;
			}
		}

		// Token: 0x04006C89 RID: 27785
		private static readonly IntPtr NativeFieldInfoPtr_Color;

		// Token: 0x04006C8A RID: 27786
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
