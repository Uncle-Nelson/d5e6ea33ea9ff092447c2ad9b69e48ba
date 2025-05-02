using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppTMPro;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x02000712 RID: 1810
	public class ItemUI_Cash : ItemUI
	{
		// Token: 0x0600A30F RID: 41743 RVA: 0x0028F100 File Offset: 0x0028D300
		// Note: this type is marked as 'beforefieldinit'.
		static ItemUI_Cash()
		{
			Il2CppClassPointerStore<ItemUI_Cash>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "ItemUI_Cash");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemUI_Cash>.NativeClassPtr);
			ItemUI_Cash.NativeFieldInfoPtr_cashInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUI_Cash>.NativeClassPtr, "cashInstance");
			ItemUI_Cash.NativeFieldInfoPtr_AmountLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUI_Cash>.NativeClassPtr, "AmountLabel");
			ItemUI_Cash.NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI_Cash>.NativeClassPtr, 100683255);
			ItemUI_Cash.NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI_Cash>.NativeClassPtr, 100683256);
			ItemUI_Cash.NativeMethodInfoPtr_SetDisplayedBalance_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI_Cash>.NativeClassPtr, 100683257);
			ItemUI_Cash.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI_Cash>.NativeClassPtr, 100683258);
		}

		// Token: 0x0600A310 RID: 41744 RVA: 0x0028F1A8 File Offset: 0x0028D3A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285918, XrefRangeEnd = 285926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Setup(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUI_Cash.NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A311 RID: 41745 RVA: 0x0028F1F8 File Offset: 0x0028D3F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285926, XrefRangeEnd = 285928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUI_Cash.NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A312 RID: 41746 RVA: 0x0028F234 File Offset: 0x0028D434
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285950, RefRangeEnd = 285951, XrefRangeStart = 285928, XrefRangeEnd = 285950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDisplayedBalance(float balance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref balance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUI_Cash.NativeMethodInfoPtr_SetDisplayedBalance_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A313 RID: 41747 RVA: 0x0028F274 File Offset: 0x0028D474
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemUI_Cash() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemUI_Cash>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUI_Cash.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A314 RID: 41748 RVA: 0x00050441 File Offset: 0x0004E641
		public ItemUI_Cash(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700324B RID: 12875
		// (get) Token: 0x0600A315 RID: 41749 RVA: 0x0028F2B0 File Offset: 0x0028D4B0
		// (set) Token: 0x0600A316 RID: 41750 RVA: 0x0005044A File Offset: 0x0004E64A
		public unsafe CashInstance cashInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI_Cash.NativeFieldInfoPtr_cashInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CashInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI_Cash.NativeFieldInfoPtr_cashInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700324C RID: 12876
		// (get) Token: 0x0600A317 RID: 41751 RVA: 0x0028F2E0 File Offset: 0x0028D4E0
		// (set) Token: 0x0600A318 RID: 41752 RVA: 0x00050469 File Offset: 0x0004E669
		public unsafe TextMeshProUGUI AmountLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI_Cash.NativeFieldInfoPtr_AmountLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI_Cash.NativeFieldInfoPtr_AmountLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006D63 RID: 28003
		private static readonly IntPtr NativeFieldInfoPtr_cashInstance;

		// Token: 0x04006D64 RID: 28004
		private static readonly IntPtr NativeFieldInfoPtr_AmountLabel;

		// Token: 0x04006D65 RID: 28005
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04006D66 RID: 28006
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0;

		// Token: 0x04006D67 RID: 28007
		private static readonly IntPtr NativeMethodInfoPtr_SetDisplayedBalance_Public_Void_Single_0;

		// Token: 0x04006D68 RID: 28008
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
