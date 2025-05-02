using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Product;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002AB RID: 683
	[Serializable]
	public class ProductData : SaveData
	{
		// Token: 0x06003149 RID: 12617 RVA: 0x0010D050 File Offset: 0x0010B250
		// Note: this type is marked as 'beforefieldinit'.
		static ProductData()
		{
			Il2CppClassPointerStore<ProductData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ProductData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductData>.NativeClassPtr);
			ProductData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductData>.NativeClassPtr, "Name");
			ProductData.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductData>.NativeClassPtr, "ID");
			ProductData.NativeFieldInfoPtr_DrugType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductData>.NativeClassPtr, "DrugType");
			ProductData.NativeFieldInfoPtr_Properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductData>.NativeClassPtr, "Properties");
			ProductData.NativeMethodInfoPtr__ctor_Public_Void_String_String_EDrugType_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductData>.NativeClassPtr, 100668836);
		}

		// Token: 0x0600314A RID: 12618 RVA: 0x0010D0E4 File Offset: 0x0010B2E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131117, RefRangeEnd = 131118, XrefRangeStart = 131113, XrefRangeEnd = 131117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductData(string name, string id, EDrugType drugType, Il2CppStringArray properties) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref drugType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductData.NativeMethodInfoPtr__ctor_Public_Void_String_String_EDrugType_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600314B RID: 12619 RVA: 0x0001A4F5 File Offset: 0x000186F5
		public ProductData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001013 RID: 4115
		// (get) Token: 0x0600314C RID: 12620 RVA: 0x0010D164 File Offset: 0x0010B364
		// (set) Token: 0x0600314D RID: 12621 RVA: 0x0001A4FE File Offset: 0x000186FE
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductData.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductData.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001014 RID: 4116
		// (get) Token: 0x0600314E RID: 12622 RVA: 0x0010D18C File Offset: 0x0010B38C
		// (set) Token: 0x0600314F RID: 12623 RVA: 0x0001A51D File Offset: 0x0001871D
		public unsafe string ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductData.NativeFieldInfoPtr_ID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductData.NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001015 RID: 4117
		// (get) Token: 0x06003150 RID: 12624 RVA: 0x0010D1B4 File Offset: 0x0010B3B4
		// (set) Token: 0x06003151 RID: 12625 RVA: 0x0001A53C File Offset: 0x0001873C
		public unsafe EDrugType DrugType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductData.NativeFieldInfoPtr_DrugType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductData.NativeFieldInfoPtr_DrugType)) = value;
			}
		}

		// Token: 0x17001016 RID: 4118
		// (get) Token: 0x06003152 RID: 12626 RVA: 0x0010D1DC File Offset: 0x0010B3DC
		// (set) Token: 0x06003153 RID: 12627 RVA: 0x0001A557 File Offset: 0x00018757
		public unsafe Il2CppStringArray Properties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductData.NativeFieldInfoPtr_Properties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductData.NativeFieldInfoPtr_Properties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002015 RID: 8213
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04002016 RID: 8214
		private static readonly IntPtr NativeFieldInfoPtr_ID;

		// Token: 0x04002017 RID: 8215
		private static readonly IntPtr NativeFieldInfoPtr_DrugType;

		// Token: 0x04002018 RID: 8216
		private static readonly IntPtr NativeFieldInfoPtr_Properties;

		// Token: 0x04002019 RID: 8217
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_EDrugType_Il2CppStringArray_0;
	}
}
