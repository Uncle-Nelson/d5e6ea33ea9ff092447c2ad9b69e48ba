using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Storage;

namespace Il2CppScheduleOne.ObjectScripts.WateringCan
{
	// Token: 0x0200075D RID: 1885
	[Serializable]
	public class WateringCanInstance : StorableItemInstance
	{
		// Token: 0x0600B353 RID: 45907 RVA: 0x002CBB28 File Offset: 0x002C9D28
		// Note: this type is marked as 'beforefieldinit'.
		static WateringCanInstance()
		{
			Il2CppClassPointerStore<WateringCanInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts.WateringCan", "WateringCanInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WateringCanInstance>.NativeClassPtr);
			WateringCanInstance.NativeFieldInfoPtr_CurrentFillAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WateringCanInstance>.NativeClassPtr, "CurrentFillAmount");
			WateringCanInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WateringCanInstance>.NativeClassPtr, 100685414);
			WateringCanInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WateringCanInstance>.NativeClassPtr, 100685415);
			WateringCanInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WateringCanInstance>.NativeClassPtr, 100685416);
			WateringCanInstance.NativeMethodInfoPtr_ChangeFillAmount_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WateringCanInstance>.NativeClassPtr, 100685417);
			WateringCanInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WateringCanInstance>.NativeClassPtr, 100685418);
		}

		// Token: 0x0600B354 RID: 45908 RVA: 0x002CBBD0 File Offset: 0x002C9DD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 206929, RefRangeEnd = 206931, XrefRangeStart = 206929, XrefRangeEnd = 206931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WateringCanInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WateringCanInstance>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WateringCanInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B355 RID: 45909 RVA: 0x002CBC0C File Offset: 0x002C9E0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308861, RefRangeEnd = 308862, XrefRangeStart = 308860, XrefRangeEnd = 308861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WateringCanInstance(ItemDefinition definition, int quantity, float fillAmount) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WateringCanInstance>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fillAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WateringCanInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B356 RID: 45910 RVA: 0x002CBC74 File Offset: 0x002C9E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308862, XrefRangeEnd = 308867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref overrideQuantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WateringCanInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x0600B357 RID: 45911 RVA: 0x002CBCCC File Offset: 0x002C9ECC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308868, RefRangeEnd = 308869, XrefRangeStart = 308867, XrefRangeEnd = 308868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeFillAmount(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WateringCanInstance.NativeMethodInfoPtr_ChangeFillAmount_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B358 RID: 45912 RVA: 0x002CBD0C File Offset: 0x002C9F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308869, XrefRangeEnd = 308873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemData GetItemData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WateringCanInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemData>(intPtr3) : null;
		}

		// Token: 0x0600B359 RID: 45913 RVA: 0x00057DD6 File Offset: 0x00055FD6
		public WateringCanInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003797 RID: 14231
		// (get) Token: 0x0600B35A RID: 45914 RVA: 0x002CBD58 File Offset: 0x002C9F58
		// (set) Token: 0x0600B35B RID: 45915 RVA: 0x00057DDF File Offset: 0x00055FDF
		public unsafe float CurrentFillAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanInstance.NativeFieldInfoPtr_CurrentFillAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanInstance.NativeFieldInfoPtr_CurrentFillAmount)) = value;
			}
		}

		// Token: 0x040078FC RID: 30972
		private static readonly IntPtr NativeFieldInfoPtr_CurrentFillAmount;

		// Token: 0x040078FD RID: 30973
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040078FE RID: 30974
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_Single_0;

		// Token: 0x040078FF RID: 30975
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x04007900 RID: 30976
		private static readonly IntPtr NativeMethodInfoPtr_ChangeFillAmount_Public_Void_Single_0;

		// Token: 0x04007901 RID: 30977
		private static readonly IntPtr NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0;
	}
}
