using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Persistence.Datas;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x02000230 RID: 560
	public class ProductManagerLoader : Loader
	{
		// Token: 0x06002DE8 RID: 11752 RVA: 0x00102890 File Offset: 0x00100A90
		// Note: this type is marked as 'beforefieldinit'.
		static ProductManagerLoader()
		{
			Il2CppClassPointerStore<ProductManagerLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "ProductManagerLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductManagerLoader>.NativeClassPtr);
			ProductManagerLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerLoader>.NativeClassPtr, 100668567);
			ProductManagerLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerLoader>.NativeClassPtr, 100668568);
			ProductManagerLoader.NativeMethodInfoPtr_SanitizeProductData_Private_Void_ProductData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerLoader>.NativeClassPtr, 100668569);
			ProductManagerLoader.NativeMethodInfoPtr_LoadProducts_Private_Void_ProductManagerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerLoader>.NativeClassPtr, 100668570);
		}

		// Token: 0x06002DE9 RID: 11753 RVA: 0x00102910 File Offset: 0x00100B10
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductManagerLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductManagerLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DEA RID: 11754 RVA: 0x0010294C File Offset: 0x00100B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127656, XrefRangeEnd = 127765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductManagerLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DEB RID: 11755 RVA: 0x0010299C File Offset: 0x00100B9C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 127793, RefRangeEnd = 127796, XrefRangeStart = 127765, XrefRangeEnd = 127793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SanitizeProductData(ProductData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerLoader.NativeMethodInfoPtr_SanitizeProductData_Private_Void_ProductData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DEC RID: 11756 RVA: 0x001029E0 File Offset: 0x00100BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127796, XrefRangeEnd = 127819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadProducts(ProductManagerData productData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(productData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerLoader.NativeMethodInfoPtr_LoadProducts_Private_Void_ProductManagerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DED RID: 11757 RVA: 0x000188A8 File Offset: 0x00016AA8
		public ProductManagerLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001E74 RID: 7796
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E75 RID: 7797
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;

		// Token: 0x04001E76 RID: 7798
		private static readonly IntPtr NativeMethodInfoPtr_SanitizeProductData_Private_Void_ProductData_0;

		// Token: 0x04001E77 RID: 7799
		private static readonly IntPtr NativeMethodInfoPtr_LoadProducts_Private_Void_ProductManagerData_0;
	}
}
