using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Product;
using Il2CppSystem;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x0200040E RID: 1038
	[Serializable]
	public class ProductTypeAffinity : Object
	{
		// Token: 0x06005A20 RID: 23072 RVA: 0x001A3804 File Offset: 0x001A1A04
		// Note: this type is marked as 'beforefieldinit'.
		static ProductTypeAffinity()
		{
			Il2CppClassPointerStore<ProductTypeAffinity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "ProductTypeAffinity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductTypeAffinity>.NativeClassPtr);
			ProductTypeAffinity.NativeFieldInfoPtr_DrugType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductTypeAffinity>.NativeClassPtr, "DrugType");
			ProductTypeAffinity.NativeFieldInfoPtr_Affinity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductTypeAffinity>.NativeClassPtr, "Affinity");
			ProductTypeAffinity.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductTypeAffinity>.NativeClassPtr, 100674779);
		}

		// Token: 0x06005A21 RID: 23073 RVA: 0x001A3870 File Offset: 0x001A1A70
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductTypeAffinity() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductTypeAffinity>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductTypeAffinity.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A22 RID: 23074 RVA: 0x0002A900 File Offset: 0x00028B00
		public ProductTypeAffinity(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B28 RID: 6952
		// (get) Token: 0x06005A23 RID: 23075 RVA: 0x001A38AC File Offset: 0x001A1AAC
		// (set) Token: 0x06005A24 RID: 23076 RVA: 0x0002A909 File Offset: 0x00028B09
		public unsafe EDrugType DrugType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductTypeAffinity.NativeFieldInfoPtr_DrugType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductTypeAffinity.NativeFieldInfoPtr_DrugType)) = value;
			}
		}

		// Token: 0x17001B29 RID: 6953
		// (get) Token: 0x06005A25 RID: 23077 RVA: 0x001A38D4 File Offset: 0x001A1AD4
		// (set) Token: 0x06005A26 RID: 23078 RVA: 0x0002A924 File Offset: 0x00028B24
		public unsafe float Affinity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductTypeAffinity.NativeFieldInfoPtr_Affinity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductTypeAffinity.NativeFieldInfoPtr_Affinity)) = value;
			}
		}

		// Token: 0x04003D8D RID: 15757
		private static readonly IntPtr NativeFieldInfoPtr_DrugType;

		// Token: 0x04003D8E RID: 15758
		private static readonly IntPtr NativeFieldInfoPtr_Affinity;

		// Token: 0x04003D8F RID: 15759
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
