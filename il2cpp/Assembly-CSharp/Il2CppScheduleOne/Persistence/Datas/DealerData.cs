using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200028E RID: 654
	public class DealerData : NPCData
	{
		// Token: 0x06003039 RID: 12345 RVA: 0x00109DC8 File Offset: 0x00107FC8
		// Note: this type is marked as 'beforefieldinit'.
		static DealerData()
		{
			Il2CppClassPointerStore<DealerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "DealerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealerData>.NativeClassPtr);
			DealerData.NativeFieldInfoPtr_Recruited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerData>.NativeClassPtr, "Recruited");
			DealerData.NativeFieldInfoPtr_AssignedCustomerIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerData>.NativeClassPtr, "AssignedCustomerIDs");
			DealerData.NativeFieldInfoPtr_ActiveContractGUIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerData>.NativeClassPtr, "ActiveContractGUIDs");
			DealerData.NativeFieldInfoPtr_Cash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerData>.NativeClassPtr, "Cash");
			DealerData.NativeFieldInfoPtr_OverflowItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerData>.NativeClassPtr, "OverflowItems");
			DealerData.NativeFieldInfoPtr_HasBeenRecommended = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerData>.NativeClassPtr, "HasBeenRecommended");
			DealerData.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Il2CppStringArray_Il2CppStringArray_Single_ItemSet_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerData>.NativeClassPtr, 100668806);
		}

		// Token: 0x0600303A RID: 12346 RVA: 0x00109E84 File Offset: 0x00108084
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130941, RefRangeEnd = 130942, XrefRangeStart = 130936, XrefRangeEnd = 130941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DealerData(string id, bool recruited, Il2CppStringArray assignedCustomerIDs, Il2CppStringArray activeContractGUIDs, float cash, ItemSet overflowItems, bool hasBeenRecommended) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealerData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recruited;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assignedCustomerIDs);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(activeContractGUIDs);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cash;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(overflowItems);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasBeenRecommended;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerData.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Il2CppStringArray_Il2CppStringArray_Single_ItemSet_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600303B RID: 12347 RVA: 0x00019974 File Offset: 0x00017B74
		public DealerData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FB7 RID: 4023
		// (get) Token: 0x0600303C RID: 12348 RVA: 0x00109F34 File Offset: 0x00108134
		// (set) Token: 0x0600303D RID: 12349 RVA: 0x0001997D File Offset: 0x00017B7D
		public unsafe bool Recruited
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerData.NativeFieldInfoPtr_Recruited);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerData.NativeFieldInfoPtr_Recruited)) = value;
			}
		}

		// Token: 0x17000FB8 RID: 4024
		// (get) Token: 0x0600303E RID: 12350 RVA: 0x00109F5C File Offset: 0x0010815C
		// (set) Token: 0x0600303F RID: 12351 RVA: 0x00019998 File Offset: 0x00017B98
		public unsafe Il2CppStringArray AssignedCustomerIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerData.NativeFieldInfoPtr_AssignedCustomerIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerData.NativeFieldInfoPtr_AssignedCustomerIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FB9 RID: 4025
		// (get) Token: 0x06003040 RID: 12352 RVA: 0x00109F8C File Offset: 0x0010818C
		// (set) Token: 0x06003041 RID: 12353 RVA: 0x000199B7 File Offset: 0x00017BB7
		public unsafe Il2CppStringArray ActiveContractGUIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerData.NativeFieldInfoPtr_ActiveContractGUIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerData.NativeFieldInfoPtr_ActiveContractGUIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FBA RID: 4026
		// (get) Token: 0x06003042 RID: 12354 RVA: 0x00109FBC File Offset: 0x001081BC
		// (set) Token: 0x06003043 RID: 12355 RVA: 0x000199D6 File Offset: 0x00017BD6
		public unsafe float Cash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerData.NativeFieldInfoPtr_Cash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerData.NativeFieldInfoPtr_Cash)) = value;
			}
		}

		// Token: 0x17000FBB RID: 4027
		// (get) Token: 0x06003044 RID: 12356 RVA: 0x00109FE4 File Offset: 0x001081E4
		// (set) Token: 0x06003045 RID: 12357 RVA: 0x000199F1 File Offset: 0x00017BF1
		public unsafe ItemSet OverflowItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerData.NativeFieldInfoPtr_OverflowItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerData.NativeFieldInfoPtr_OverflowItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FBC RID: 4028
		// (get) Token: 0x06003046 RID: 12358 RVA: 0x0010A014 File Offset: 0x00108214
		// (set) Token: 0x06003047 RID: 12359 RVA: 0x00019A10 File Offset: 0x00017C10
		public unsafe bool HasBeenRecommended
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerData.NativeFieldInfoPtr_HasBeenRecommended);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerData.NativeFieldInfoPtr_HasBeenRecommended)) = value;
			}
		}

		// Token: 0x04001F9B RID: 8091
		private static readonly IntPtr NativeFieldInfoPtr_Recruited;

		// Token: 0x04001F9C RID: 8092
		private static readonly IntPtr NativeFieldInfoPtr_AssignedCustomerIDs;

		// Token: 0x04001F9D RID: 8093
		private static readonly IntPtr NativeFieldInfoPtr_ActiveContractGUIDs;

		// Token: 0x04001F9E RID: 8094
		private static readonly IntPtr NativeFieldInfoPtr_Cash;

		// Token: 0x04001F9F RID: 8095
		private static readonly IntPtr NativeFieldInfoPtr_OverflowItems;

		// Token: 0x04001FA0 RID: 8096
		private static readonly IntPtr NativeFieldInfoPtr_HasBeenRecommended;

		// Token: 0x04001FA1 RID: 8097
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Il2CppStringArray_Il2CppStringArray_Single_ItemSet_Boolean_0;
	}
}
