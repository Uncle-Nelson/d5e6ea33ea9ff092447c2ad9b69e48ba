using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Product;
using Il2CppScheduleOne.Quests;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002AF RID: 687
	[Serializable]
	public class ContractData : QuestData
	{
		// Token: 0x0600317B RID: 12667 RVA: 0x0010D8C4 File Offset: 0x0010BAC4
		// Note: this type is marked as 'beforefieldinit'.
		static ContractData()
		{
			Il2CppClassPointerStore<ContractData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ContractData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContractData>.NativeClassPtr);
			ContractData.NativeFieldInfoPtr_CustomerGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractData>.NativeClassPtr, "CustomerGUID");
			ContractData.NativeFieldInfoPtr_Payment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractData>.NativeClassPtr, "Payment");
			ContractData.NativeFieldInfoPtr_ProductList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractData>.NativeClassPtr, "ProductList");
			ContractData.NativeFieldInfoPtr_DeliveryLocationGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractData>.NativeClassPtr, "DeliveryLocationGUID");
			ContractData.NativeFieldInfoPtr_DeliveryWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractData>.NativeClassPtr, "DeliveryWindow");
			ContractData.NativeFieldInfoPtr_PickupScheduleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractData>.NativeClassPtr, "PickupScheduleIndex");
			ContractData.NativeFieldInfoPtr_AcceptTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractData>.NativeClassPtr, "AcceptTime");
			ContractData.NativeMethodInfoPtr__ctor_Public_Void_String_EQuestState_Boolean_String_String_Boolean_GameDateTimeData_Il2CppReferenceArray_1_QuestEntryData_String_Single_ProductList_String_QuestWindowConfig_Int32_GameDateTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContractData>.NativeClassPtr, 100668840);
		}

		// Token: 0x0600317C RID: 12668 RVA: 0x0010D994 File Offset: 0x0010BB94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131140, RefRangeEnd = 131141, XrefRangeStart = 131134, XrefRangeEnd = 131140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContractData(string guid, EQuestState state, bool isTracked, string title, string desc, bool isTimed, GameDateTimeData expiry, Il2CppReferenceArray<QuestEntryData> entries, string customerGUID, float payment, ProductList productList, string deliveryLocationGUID, QuestWindowConfig deliveryWindow, int pickupScheduleIndex, GameDateTimeData acceptTime) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContractData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)15) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isTracked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(desc);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isTimed;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(expiry);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entries);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(customerGUID);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref payment;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(productList);
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(deliveryLocationGUID);
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deliveryWindow);
			ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pickupScheduleIndex;
			ptr[checked(unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(acceptTime);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContractData.NativeMethodInfoPtr__ctor_Public_Void_String_EQuestState_Boolean_String_String_Boolean_GameDateTimeData_Il2CppReferenceArray_1_QuestEntryData_String_Single_ProductList_String_QuestWindowConfig_Int32_GameDateTimeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600317D RID: 12669 RVA: 0x0001A75A File Offset: 0x0001895A
		public ContractData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001026 RID: 4134
		// (get) Token: 0x0600317E RID: 12670 RVA: 0x0010DAD8 File Offset: 0x0010BCD8
		// (set) Token: 0x0600317F RID: 12671 RVA: 0x0001A763 File Offset: 0x00018963
		public unsafe string CustomerGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_CustomerGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_CustomerGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001027 RID: 4135
		// (get) Token: 0x06003180 RID: 12672 RVA: 0x0010DB00 File Offset: 0x0010BD00
		// (set) Token: 0x06003181 RID: 12673 RVA: 0x0001A782 File Offset: 0x00018982
		public unsafe float Payment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_Payment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_Payment)) = value;
			}
		}

		// Token: 0x17001028 RID: 4136
		// (get) Token: 0x06003182 RID: 12674 RVA: 0x0010DB28 File Offset: 0x0010BD28
		// (set) Token: 0x06003183 RID: 12675 RVA: 0x0001A79D File Offset: 0x0001899D
		public unsafe ProductList ProductList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_ProductList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_ProductList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001029 RID: 4137
		// (get) Token: 0x06003184 RID: 12676 RVA: 0x0010DB58 File Offset: 0x0010BD58
		// (set) Token: 0x06003185 RID: 12677 RVA: 0x0001A7BC File Offset: 0x000189BC
		public unsafe string DeliveryLocationGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_DeliveryLocationGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_DeliveryLocationGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700102A RID: 4138
		// (get) Token: 0x06003186 RID: 12678 RVA: 0x0010DB80 File Offset: 0x0010BD80
		// (set) Token: 0x06003187 RID: 12679 RVA: 0x0001A7DB File Offset: 0x000189DB
		public unsafe QuestWindowConfig DeliveryWindow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_DeliveryWindow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestWindowConfig>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_DeliveryWindow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700102B RID: 4139
		// (get) Token: 0x06003188 RID: 12680 RVA: 0x0010DBB0 File Offset: 0x0010BDB0
		// (set) Token: 0x06003189 RID: 12681 RVA: 0x0001A7FA File Offset: 0x000189FA
		public unsafe int PickupScheduleIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_PickupScheduleIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_PickupScheduleIndex)) = value;
			}
		}

		// Token: 0x1700102C RID: 4140
		// (get) Token: 0x0600318A RID: 12682 RVA: 0x0010DBD8 File Offset: 0x0010BDD8
		// (set) Token: 0x0600318B RID: 12683 RVA: 0x0001A815 File Offset: 0x00018A15
		public unsafe GameDateTimeData AcceptTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_AcceptTime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameDateTimeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_AcceptTime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400202C RID: 8236
		private static readonly IntPtr NativeFieldInfoPtr_CustomerGUID;

		// Token: 0x0400202D RID: 8237
		private static readonly IntPtr NativeFieldInfoPtr_Payment;

		// Token: 0x0400202E RID: 8238
		private static readonly IntPtr NativeFieldInfoPtr_ProductList;

		// Token: 0x0400202F RID: 8239
		private static readonly IntPtr NativeFieldInfoPtr_DeliveryLocationGUID;

		// Token: 0x04002030 RID: 8240
		private static readonly IntPtr NativeFieldInfoPtr_DeliveryWindow;

		// Token: 0x04002031 RID: 8241
		private static readonly IntPtr NativeFieldInfoPtr_PickupScheduleIndex;

		// Token: 0x04002032 RID: 8242
		private static readonly IntPtr NativeFieldInfoPtr_AcceptTime;

		// Token: 0x04002033 RID: 8243
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_EQuestState_Boolean_String_String_Boolean_GameDateTimeData_Il2CppReferenceArray_1_QuestEntryData_String_Single_ProductList_String_QuestWindowConfig_Int32_GameDateTimeData_0;
	}
}
