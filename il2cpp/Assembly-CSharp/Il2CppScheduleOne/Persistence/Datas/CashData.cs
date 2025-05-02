using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000262 RID: 610
	[Serializable]
	public class CashData : ItemData
	{
		// Token: 0x06002F21 RID: 12065 RVA: 0x00106DD8 File Offset: 0x00104FD8
		// Note: this type is marked as 'beforefieldinit'.
		static CashData()
		{
			Il2CppClassPointerStore<CashData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "CashData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CashData>.NativeClassPtr);
			CashData.NativeFieldInfoPtr_CashBalance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashData>.NativeClassPtr, "CashBalance");
			CashData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashData>.NativeClassPtr, 100668760);
		}

		// Token: 0x06002F22 RID: 12066 RVA: 0x00106E30 File Offset: 0x00105030
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 130698, RefRangeEnd = 130700, XrefRangeStart = 130696, XrefRangeEnd = 130698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CashData(string iD, int quantity, float cashBalance) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CashData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iD);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cashBalance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F23 RID: 12067 RVA: 0x00018E91 File Offset: 0x00017091
		public CashData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F6E RID: 3950
		// (get) Token: 0x06002F24 RID: 12068 RVA: 0x00106E98 File Offset: 0x00105098
		// (set) Token: 0x06002F25 RID: 12069 RVA: 0x00018E9A File Offset: 0x0001709A
		public unsafe float CashBalance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashData.NativeFieldInfoPtr_CashBalance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashData.NativeFieldInfoPtr_CashBalance)) = value;
			}
		}

		// Token: 0x04001F24 RID: 7972
		private static readonly IntPtr NativeFieldInfoPtr_CashBalance;

		// Token: 0x04001F25 RID: 7973
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Single_0;
	}
}
