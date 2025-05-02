using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Money
{
	// Token: 0x02000728 RID: 1832
	public class Transaction : Object
	{
		// Token: 0x0600A57E RID: 42366 RVA: 0x00297020 File Offset: 0x00295220
		// Note: this type is marked as 'beforefieldinit'.
		static Transaction()
		{
			Il2CppClassPointerStore<Transaction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Money", "Transaction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Transaction>.NativeClassPtr);
			Transaction.NativeFieldInfoPtr_transaction_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Transaction>.NativeClassPtr, "transaction_Name");
			Transaction.NativeFieldInfoPtr_unit_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Transaction>.NativeClassPtr, "unit_Amount");
			Transaction.NativeFieldInfoPtr_quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Transaction>.NativeClassPtr, "quantity");
			Transaction.NativeFieldInfoPtr_transaction_Note = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Transaction>.NativeClassPtr, "transaction_Note");
			Transaction.NativeMethodInfoPtr_get_total_Amount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transaction>.NativeClassPtr, 100683542);
			Transaction.NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transaction>.NativeClassPtr, 100683543);
		}

		// Token: 0x17003314 RID: 13076
		// (get) Token: 0x0600A57F RID: 42367 RVA: 0x002970C8 File Offset: 0x002952C8
		public unsafe float total_Amount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transaction.NativeMethodInfoPtr_get_total_Amount_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600A580 RID: 42368 RVA: 0x00297104 File Offset: 0x00295304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289528, XrefRangeEnd = 289536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transaction(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Transaction>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_transaction_Name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _unit_Amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _quantity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_transaction_Note);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transaction.NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A581 RID: 42369 RVA: 0x00051837 File Offset: 0x0004FA37
		public Transaction(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003310 RID: 13072
		// (get) Token: 0x0600A582 RID: 42370 RVA: 0x00297180 File Offset: 0x00295380
		// (set) Token: 0x0600A583 RID: 42371 RVA: 0x00051840 File Offset: 0x0004FA40
		public unsafe string transaction_Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Transaction.NativeFieldInfoPtr_transaction_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Transaction.NativeFieldInfoPtr_transaction_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003311 RID: 13073
		// (get) Token: 0x0600A584 RID: 42372 RVA: 0x002971A8 File Offset: 0x002953A8
		// (set) Token: 0x0600A585 RID: 42373 RVA: 0x0005185F File Offset: 0x0004FA5F
		public unsafe float unit_Amount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Transaction.NativeFieldInfoPtr_unit_Amount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Transaction.NativeFieldInfoPtr_unit_Amount)) = value;
			}
		}

		// Token: 0x17003312 RID: 13074
		// (get) Token: 0x0600A586 RID: 42374 RVA: 0x002971D0 File Offset: 0x002953D0
		// (set) Token: 0x0600A587 RID: 42375 RVA: 0x0005187A File Offset: 0x0004FA7A
		public unsafe float quantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Transaction.NativeFieldInfoPtr_quantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Transaction.NativeFieldInfoPtr_quantity)) = value;
			}
		}

		// Token: 0x17003313 RID: 13075
		// (get) Token: 0x0600A588 RID: 42376 RVA: 0x002971F8 File Offset: 0x002953F8
		// (set) Token: 0x0600A589 RID: 42377 RVA: 0x00051895 File Offset: 0x0004FA95
		public unsafe string transaction_Note
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Transaction.NativeFieldInfoPtr_transaction_Note);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Transaction.NativeFieldInfoPtr_transaction_Note), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04006EFC RID: 28412
		private static readonly IntPtr NativeFieldInfoPtr_transaction_Name;

		// Token: 0x04006EFD RID: 28413
		private static readonly IntPtr NativeFieldInfoPtr_unit_Amount;

		// Token: 0x04006EFE RID: 28414
		private static readonly IntPtr NativeFieldInfoPtr_quantity;

		// Token: 0x04006EFF RID: 28415
		private static readonly IntPtr NativeFieldInfoPtr_transaction_Note;

		// Token: 0x04006F00 RID: 28416
		private static readonly IntPtr NativeMethodInfoPtr_get_total_Amount_Public_get_Single_0;

		// Token: 0x04006F01 RID: 28417
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_String_0;
	}
}
