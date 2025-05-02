using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002B5 RID: 693
	public class ShopData : SaveData
	{
		// Token: 0x060031C3 RID: 12739 RVA: 0x0010E55C File Offset: 0x0010C75C
		// Note: this type is marked as 'beforefieldinit'.
		static ShopData()
		{
			Il2CppClassPointerStore<ShopData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ShopData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopData>.NativeClassPtr);
			ShopData.NativeFieldInfoPtr_ShopCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopData>.NativeClassPtr, "ShopCode");
			ShopData.NativeFieldInfoPtr_ItemStockQuantities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopData>.NativeClassPtr, "ItemStockQuantities");
			ShopData.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_StringIntPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopData>.NativeClassPtr, 100668850);
		}

		// Token: 0x060031C4 RID: 12740 RVA: 0x0010E5C8 File Offset: 0x0010C7C8
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 130739, RefRangeEnd = 130748, XrefRangeStart = 130739, XrefRangeEnd = 130748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShopData(string shopCode, Il2CppReferenceArray<StringIntPair> itemStockQuantities) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(shopCode);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(itemStockQuantities);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopData.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_StringIntPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031C5 RID: 12741 RVA: 0x0001AA59 File Offset: 0x00018C59
		public ShopData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001040 RID: 4160
		// (get) Token: 0x060031C6 RID: 12742 RVA: 0x0010E628 File Offset: 0x0010C828
		// (set) Token: 0x060031C7 RID: 12743 RVA: 0x0001AA62 File Offset: 0x00018C62
		public unsafe string ShopCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopData.NativeFieldInfoPtr_ShopCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopData.NativeFieldInfoPtr_ShopCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001041 RID: 4161
		// (get) Token: 0x060031C8 RID: 12744 RVA: 0x0010E650 File Offset: 0x0010C850
		// (set) Token: 0x060031C9 RID: 12745 RVA: 0x0001AA81 File Offset: 0x00018C81
		public unsafe Il2CppReferenceArray<StringIntPair> ItemStockQuantities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopData.NativeFieldInfoPtr_ItemStockQuantities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StringIntPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopData.NativeFieldInfoPtr_ItemStockQuantities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400204F RID: 8271
		private static readonly IntPtr NativeFieldInfoPtr_ShopCode;

		// Token: 0x04002050 RID: 8272
		private static readonly IntPtr NativeFieldInfoPtr_ItemStockQuantities;

		// Token: 0x04002051 RID: 8273
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_StringIntPair_0;
	}
}
