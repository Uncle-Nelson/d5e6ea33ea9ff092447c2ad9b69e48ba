using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000266 RID: 614
	[Serializable]
	public class ItemData : SaveData
	{
		// Token: 0x06002F33 RID: 12083 RVA: 0x00107110 File Offset: 0x00105310
		// Note: this type is marked as 'beforefieldinit'.
		static ItemData()
		{
			Il2CppClassPointerStore<ItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ItemData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemData>.NativeClassPtr);
			ItemData.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemData>.NativeClassPtr, "ID");
			ItemData.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemData>.NativeClassPtr, "Quantity");
			ItemData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemData>.NativeClassPtr, 100668764);
		}

		// Token: 0x06002F34 RID: 12084 RVA: 0x0010717C File Offset: 0x0010537C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 130714, RefRangeEnd = 130719, XrefRangeStart = 130712, XrefRangeEnd = 130714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemData(string iD, int quantity) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iD);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F35 RID: 12085 RVA: 0x00018F3F File Offset: 0x0001713F
		public ItemData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F71 RID: 3953
		// (get) Token: 0x06002F36 RID: 12086 RVA: 0x001071D8 File Offset: 0x001053D8
		// (set) Token: 0x06002F37 RID: 12087 RVA: 0x00018F48 File Offset: 0x00017148
		public unsafe string ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemData.NativeFieldInfoPtr_ID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemData.NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F72 RID: 3954
		// (get) Token: 0x06002F38 RID: 12088 RVA: 0x00107200 File Offset: 0x00105400
		// (set) Token: 0x06002F39 RID: 12089 RVA: 0x00018F67 File Offset: 0x00017167
		public unsafe int Quantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemData.NativeFieldInfoPtr_Quantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemData.NativeFieldInfoPtr_Quantity)) = value;
			}
		}

		// Token: 0x04001F2B RID: 7979
		private static readonly IntPtr NativeFieldInfoPtr_ID;

		// Token: 0x04001F2C RID: 7980
		private static readonly IntPtr NativeFieldInfoPtr_Quantity;

		// Token: 0x04001F2D RID: 7981
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;
	}
}
