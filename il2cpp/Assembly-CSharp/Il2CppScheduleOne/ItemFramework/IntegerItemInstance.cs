using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Storage;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005E1 RID: 1505
	public class IntegerItemInstance : StorableItemInstance
	{
		// Token: 0x0600838B RID: 33675 RVA: 0x0022F6DC File Offset: 0x0022D8DC
		// Note: this type is marked as 'beforefieldinit'.
		static IntegerItemInstance()
		{
			Il2CppClassPointerStore<IntegerItemInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "IntegerItemInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntegerItemInstance>.NativeClassPtr);
			IntegerItemInstance.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegerItemInstance>.NativeClassPtr, "Value");
			IntegerItemInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemInstance>.NativeClassPtr, 100679752);
			IntegerItemInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemInstance>.NativeClassPtr, 100679753);
			IntegerItemInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemInstance>.NativeClassPtr, 100679754);
			IntegerItemInstance.NativeMethodInfoPtr_ChangeValue_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemInstance>.NativeClassPtr, 100679755);
			IntegerItemInstance.NativeMethodInfoPtr_SetValue_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemInstance>.NativeClassPtr, 100679756);
			IntegerItemInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemInstance>.NativeClassPtr, 100679757);
		}

		// Token: 0x0600838C RID: 33676 RVA: 0x0022F798 File Offset: 0x0022D998
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 206929, RefRangeEnd = 206931, XrefRangeStart = 206929, XrefRangeEnd = 206931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntegerItemInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntegerItemInstance>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntegerItemInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600838D RID: 33677 RVA: 0x0022F7D4 File Offset: 0x0022D9D4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 206932, RefRangeEnd = 206937, XrefRangeStart = 206932, XrefRangeEnd = 206937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntegerItemInstance(ItemDefinition definition, int quantity, int value) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntegerItemInstance>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntegerItemInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600838E RID: 33678 RVA: 0x0022F83C File Offset: 0x0022DA3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247612, XrefRangeEnd = 247617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref overrideQuantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntegerItemInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x0600838F RID: 33679 RVA: 0x0022F894 File Offset: 0x0022DA94
		[CallerCount(0)]
		public unsafe void ChangeValue(int change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntegerItemInstance.NativeMethodInfoPtr_ChangeValue_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008390 RID: 33680 RVA: 0x0022F8D4 File Offset: 0x0022DAD4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 247617, RefRangeEnd = 247622, XrefRangeStart = 247617, XrefRangeEnd = 247617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntegerItemInstance.NativeMethodInfoPtr_SetValue_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008391 RID: 33681 RVA: 0x0022F914 File Offset: 0x0022DB14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247622, XrefRangeEnd = 247626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemData GetItemData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntegerItemInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemData>(intPtr3) : null;
		}

		// Token: 0x06008392 RID: 33682 RVA: 0x0003E758 File Offset: 0x0003C958
		public IntegerItemInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027C4 RID: 10180
		// (get) Token: 0x06008393 RID: 33683 RVA: 0x0022F960 File Offset: 0x0022DB60
		// (set) Token: 0x06008394 RID: 33684 RVA: 0x0003E761 File Offset: 0x0003C961
		public unsafe int Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegerItemInstance.NativeFieldInfoPtr_Value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegerItemInstance.NativeFieldInfoPtr_Value)) = value;
			}
		}

		// Token: 0x04005985 RID: 22917
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04005986 RID: 22918
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005987 RID: 22919
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_Int32_0;

		// Token: 0x04005988 RID: 22920
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x04005989 RID: 22921
		private static readonly IntPtr NativeMethodInfoPtr_ChangeValue_Public_Void_Int32_0;

		// Token: 0x0400598A RID: 22922
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_Int32_0;

		// Token: 0x0400598B RID: 22923
		private static readonly IntPtr NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0;
	}
}
