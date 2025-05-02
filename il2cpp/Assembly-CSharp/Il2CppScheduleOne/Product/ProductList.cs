using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005A9 RID: 1449
	[Serializable]
	public class ProductList : Object
	{
		// Token: 0x06007EB5 RID: 32437 RVA: 0x0021E35C File Offset: 0x0021C55C
		// Note: this type is marked as 'beforefieldinit'.
		static ProductList()
		{
			Il2CppClassPointerStore<ProductList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "ProductList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductList>.NativeClassPtr);
			ProductList.NativeFieldInfoPtr_entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductList>.NativeClassPtr, "entries");
			ProductList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductList>.NativeClassPtr, 100679156);
			ProductList.NativeMethodInfoPtr_GetCommaSeperatedString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductList>.NativeClassPtr, 100679157);
			ProductList.NativeMethodInfoPtr_GetLineSeperatedString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductList>.NativeClassPtr, 100679158);
			ProductList.NativeMethodInfoPtr_GetQualityString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductList>.NativeClassPtr, 100679159);
			ProductList.NativeMethodInfoPtr_GetTotalQuantity_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductList>.NativeClassPtr, 100679160);
		}

		// Token: 0x06007EB6 RID: 32438 RVA: 0x0021E404 File Offset: 0x0021C604
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 239880, RefRangeEnd = 239886, XrefRangeStart = 239872, XrefRangeEnd = 239880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductList() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007EB7 RID: 32439 RVA: 0x0021E440 File Offset: 0x0021C640
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 239915, RefRangeEnd = 239920, XrefRangeStart = 239886, XrefRangeEnd = 239915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetCommaSeperatedString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductList.NativeMethodInfoPtr_GetCommaSeperatedString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06007EB8 RID: 32440 RVA: 0x0021E478 File Offset: 0x0021C678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239920, XrefRangeEnd = 239948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLineSeperatedString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductList.NativeMethodInfoPtr_GetLineSeperatedString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06007EB9 RID: 32441 RVA: 0x0021E4B0 File Offset: 0x0021C6B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 239974, RefRangeEnd = 239977, XrefRangeStart = 239948, XrefRangeEnd = 239974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetQualityString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductList.NativeMethodInfoPtr_GetQualityString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06007EBA RID: 32442 RVA: 0x0021E4E8 File Offset: 0x0021C6E8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 239991, RefRangeEnd = 239995, XrefRangeStart = 239977, XrefRangeEnd = 239991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTotalQuantity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductList.NativeMethodInfoPtr_GetTotalQuantity_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007EBB RID: 32443 RVA: 0x0003C30F File Offset: 0x0003A50F
		public ProductList(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002658 RID: 9816
		// (get) Token: 0x06007EBC RID: 32444 RVA: 0x0021E524 File Offset: 0x0021C724
		// (set) Token: 0x06007EBD RID: 32445 RVA: 0x0003C318 File Offset: 0x0003A518
		public unsafe List<ProductList.Entry> entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductList.NativeFieldInfoPtr_entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProductList.Entry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductList.NativeFieldInfoPtr_entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400563E RID: 22078
		private static readonly IntPtr NativeFieldInfoPtr_entries;

		// Token: 0x0400563F RID: 22079
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005640 RID: 22080
		private static readonly IntPtr NativeMethodInfoPtr_GetCommaSeperatedString_Public_String_0;

		// Token: 0x04005641 RID: 22081
		private static readonly IntPtr NativeMethodInfoPtr_GetLineSeperatedString_Public_String_0;

		// Token: 0x04005642 RID: 22082
		private static readonly IntPtr NativeMethodInfoPtr_GetQualityString_Public_String_0;

		// Token: 0x04005643 RID: 22083
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalQuantity_Public_Int32_0;

		// Token: 0x02000ACD RID: 2765
		[Serializable]
		public class Entry : Object
		{
			// Token: 0x0600D475 RID: 54389 RVA: 0x0032B368 File Offset: 0x00329568
			// Note: this type is marked as 'beforefieldinit'.
			static Entry()
			{
				Il2CppClassPointerStore<ProductList.Entry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProductList>.NativeClassPtr, "Entry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductList.Entry>.NativeClassPtr);
				ProductList.Entry.NativeFieldInfoPtr_ProductID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductList.Entry>.NativeClassPtr, "ProductID");
				ProductList.Entry.NativeFieldInfoPtr_Quality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductList.Entry>.NativeClassPtr, "Quality");
				ProductList.Entry.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductList.Entry>.NativeClassPtr, "Quantity");
				ProductList.Entry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductList.Entry>.NativeClassPtr, 100679161);
			}

			// Token: 0x0600D476 RID: 54390 RVA: 0x0032B3E4 File Offset: 0x003295E4
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entry() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductList.Entry>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductList.Entry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D477 RID: 54391 RVA: 0x00067660 File Offset: 0x00065860
			public Entry(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041DB RID: 16859
			// (get) Token: 0x0600D478 RID: 54392 RVA: 0x0032B420 File Offset: 0x00329620
			// (set) Token: 0x0600D479 RID: 54393 RVA: 0x00067669 File Offset: 0x00065869
			public unsafe string ProductID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductList.Entry.NativeFieldInfoPtr_ProductID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductList.Entry.NativeFieldInfoPtr_ProductID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170041DC RID: 16860
			// (get) Token: 0x0600D47A RID: 54394 RVA: 0x0032B448 File Offset: 0x00329648
			// (set) Token: 0x0600D47B RID: 54395 RVA: 0x00067688 File Offset: 0x00065888
			public unsafe EQuality Quality
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductList.Entry.NativeFieldInfoPtr_Quality);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductList.Entry.NativeFieldInfoPtr_Quality)) = value;
				}
			}

			// Token: 0x170041DD RID: 16861
			// (get) Token: 0x0600D47C RID: 54396 RVA: 0x0032B470 File Offset: 0x00329670
			// (set) Token: 0x0600D47D RID: 54397 RVA: 0x000676A3 File Offset: 0x000658A3
			public unsafe int Quantity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductList.Entry.NativeFieldInfoPtr_Quantity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductList.Entry.NativeFieldInfoPtr_Quantity)) = value;
				}
			}

			// Token: 0x04008F06 RID: 36614
			private static readonly IntPtr NativeFieldInfoPtr_ProductID;

			// Token: 0x04008F07 RID: 36615
			private static readonly IntPtr NativeFieldInfoPtr_Quality;

			// Token: 0x04008F08 RID: 36616
			private static readonly IntPtr NativeFieldInfoPtr_Quantity;

			// Token: 0x04008F09 RID: 36617
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
