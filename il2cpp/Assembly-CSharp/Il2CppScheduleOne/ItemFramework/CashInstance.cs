using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Storage;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005CE RID: 1486
	[Serializable]
	public class CashInstance : StorableItemInstance
	{
		// Token: 0x06008308 RID: 33544 RVA: 0x0022DA70 File Offset: 0x0022BC70
		// Note: this type is marked as 'beforefieldinit'.
		static CashInstance()
		{
			Il2CppClassPointerStore<CashInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "CashInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CashInstance>.NativeClassPtr);
			CashInstance.NativeFieldInfoPtr_MAX_BALANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashInstance>.NativeClassPtr, "MAX_BALANCE");
			CashInstance.NativeFieldInfoPtr__Balance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashInstance>.NativeClassPtr, "<Balance>k__BackingField");
			CashInstance.NativeMethodInfoPtr_get_Balance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashInstance>.NativeClassPtr, 100679694);
			CashInstance.NativeMethodInfoPtr_set_Balance_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashInstance>.NativeClassPtr, 100679695);
			CashInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashInstance>.NativeClassPtr, 100679696);
			CashInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashInstance>.NativeClassPtr, 100679697);
			CashInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashInstance>.NativeClassPtr, 100679698);
			CashInstance.NativeMethodInfoPtr_ChangeBalance_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashInstance>.NativeClassPtr, 100679699);
			CashInstance.NativeMethodInfoPtr_SetBalance_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashInstance>.NativeClassPtr, 100679700);
			CashInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashInstance>.NativeClassPtr, 100679701);
			CashInstance.NativeMethodInfoPtr_GetMonetaryValue_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashInstance>.NativeClassPtr, 100679702);
		}

		// Token: 0x170027AF RID: 10159
		// (get) Token: 0x06008309 RID: 33545 RVA: 0x0022DB7C File Offset: 0x0022BD7C
		// (set) Token: 0x0600830A RID: 33546 RVA: 0x0022DBB8 File Offset: 0x0022BDB8
		public unsafe float Balance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashInstance.NativeMethodInfoPtr_get_Balance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 49126, RefRangeEnd = 49129, XrefRangeStart = 49126, XrefRangeEnd = 49129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashInstance.NativeMethodInfoPtr_set_Balance_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600830B RID: 33547 RVA: 0x0022DBF8 File Offset: 0x0022BDF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 206929, RefRangeEnd = 206931, XrefRangeStart = 206929, XrefRangeEnd = 206931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CashInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CashInstance>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600830C RID: 33548 RVA: 0x0022DC34 File Offset: 0x0022BE34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 247318, RefRangeEnd = 247320, XrefRangeStart = 247317, XrefRangeEnd = 247318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CashInstance(ItemDefinition definition, int quantity) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CashInstance>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600830D RID: 33549 RVA: 0x0022DC90 File Offset: 0x0022BE90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247320, XrefRangeEnd = 247325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref overrideQuantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CashInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x0600830E RID: 33550 RVA: 0x0022DCE8 File Offset: 0x0022BEE8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 247326, RefRangeEnd = 247334, XrefRangeStart = 247325, XrefRangeEnd = 247326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeBalance(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashInstance.NativeMethodInfoPtr_ChangeBalance_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600830F RID: 33551 RVA: 0x0022DD28 File Offset: 0x0022BF28
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 247335, RefRangeEnd = 247342, XrefRangeStart = 247334, XrefRangeEnd = 247335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBalance(float newBalance, bool blockClear = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newBalance;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blockClear;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashInstance.NativeMethodInfoPtr_SetBalance_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008310 RID: 33552 RVA: 0x0022DD74 File Offset: 0x0022BF74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247342, XrefRangeEnd = 247346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemData GetItemData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CashInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemData>(intPtr3) : null;
		}

		// Token: 0x06008311 RID: 33553 RVA: 0x0022DDC0 File Offset: 0x0022BFC0
		[CallerCount(0)]
		public unsafe override float GetMonetaryValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CashInstance.NativeMethodInfoPtr_GetMonetaryValue_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008312 RID: 33554 RVA: 0x0003E48B File Offset: 0x0003C68B
		public CashInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027AD RID: 10157
		// (get) Token: 0x06008313 RID: 33555 RVA: 0x0022DE08 File Offset: 0x0022C008
		// (set) Token: 0x06008314 RID: 33556 RVA: 0x0003E494 File Offset: 0x0003C694
		public unsafe static float MAX_BALANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CashInstance.NativeFieldInfoPtr_MAX_BALANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CashInstance.NativeFieldInfoPtr_MAX_BALANCE, (void*)(&value));
			}
		}

		// Token: 0x170027AE RID: 10158
		// (get) Token: 0x06008315 RID: 33557 RVA: 0x0022DE24 File Offset: 0x0022C024
		// (set) Token: 0x06008316 RID: 33558 RVA: 0x0003E4A2 File Offset: 0x0003C6A2
		public unsafe float _Balance_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashInstance.NativeFieldInfoPtr__Balance_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashInstance.NativeFieldInfoPtr__Balance_k__BackingField)) = value;
			}
		}

		// Token: 0x0400592D RID: 22829
		private static readonly IntPtr NativeFieldInfoPtr_MAX_BALANCE;

		// Token: 0x0400592E RID: 22830
		private static readonly IntPtr NativeFieldInfoPtr__Balance_k__BackingField;

		// Token: 0x0400592F RID: 22831
		private static readonly IntPtr NativeMethodInfoPtr_get_Balance_Public_get_Single_0;

		// Token: 0x04005930 RID: 22832
		private static readonly IntPtr NativeMethodInfoPtr_set_Balance_Protected_set_Void_Single_0;

		// Token: 0x04005931 RID: 22833
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005932 RID: 22834
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_0;

		// Token: 0x04005933 RID: 22835
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x04005934 RID: 22836
		private static readonly IntPtr NativeMethodInfoPtr_ChangeBalance_Public_Void_Single_0;

		// Token: 0x04005935 RID: 22837
		private static readonly IntPtr NativeMethodInfoPtr_SetBalance_Public_Void_Single_Boolean_0;

		// Token: 0x04005936 RID: 22838
		private static readonly IntPtr NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0;

		// Token: 0x04005937 RID: 22839
		private static readonly IntPtr NativeMethodInfoPtr_GetMonetaryValue_Public_Virtual_Single_0;
	}
}
