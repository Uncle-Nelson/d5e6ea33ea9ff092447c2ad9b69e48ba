using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts.WateringCan;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x02000713 RID: 1811
	public class ItemUI_WateringCan : ItemUI
	{
		// Token: 0x0600A319 RID: 41753 RVA: 0x0028F310 File Offset: 0x0028D510
		// Note: this type is marked as 'beforefieldinit'.
		static ItemUI_WateringCan()
		{
			Il2CppClassPointerStore<ItemUI_WateringCan>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "ItemUI_WateringCan");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemUI_WateringCan>.NativeClassPtr);
			ItemUI_WateringCan.NativeFieldInfoPtr_wcInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUI_WateringCan>.NativeClassPtr, "wcInstance");
			ItemUI_WateringCan.NativeFieldInfoPtr_AmountLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUI_WateringCan>.NativeClassPtr, "AmountLabel");
			ItemUI_WateringCan.NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI_WateringCan>.NativeClassPtr, 100683259);
			ItemUI_WateringCan.NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI_WateringCan>.NativeClassPtr, 100683260);
			ItemUI_WateringCan.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI_WateringCan>.NativeClassPtr, 100683261);
		}

		// Token: 0x0600A31A RID: 41754 RVA: 0x0028F3A4 File Offset: 0x0028D5A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285951, XrefRangeEnd = 285959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Setup(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUI_WateringCan.NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A31B RID: 41755 RVA: 0x0028F3F4 File Offset: 0x0028D5F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285959, XrefRangeEnd = 285965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUI_WateringCan.NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A31C RID: 41756 RVA: 0x0028F430 File Offset: 0x0028D630
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemUI_WateringCan() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemUI_WateringCan>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUI_WateringCan.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A31D RID: 41757 RVA: 0x00050488 File Offset: 0x0004E688
		public ItemUI_WateringCan(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700324D RID: 12877
		// (get) Token: 0x0600A31E RID: 41758 RVA: 0x0028F46C File Offset: 0x0028D66C
		// (set) Token: 0x0600A31F RID: 41759 RVA: 0x00050491 File Offset: 0x0004E691
		public unsafe WateringCanInstance wcInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI_WateringCan.NativeFieldInfoPtr_wcInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WateringCanInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI_WateringCan.NativeFieldInfoPtr_wcInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700324E RID: 12878
		// (get) Token: 0x0600A320 RID: 41760 RVA: 0x0028F49C File Offset: 0x0028D69C
		// (set) Token: 0x0600A321 RID: 41761 RVA: 0x000504B0 File Offset: 0x0004E6B0
		public unsafe Text AmountLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI_WateringCan.NativeFieldInfoPtr_AmountLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI_WateringCan.NativeFieldInfoPtr_AmountLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006D69 RID: 28009
		private static readonly IntPtr NativeFieldInfoPtr_wcInstance;

		// Token: 0x04006D6A RID: 28010
		private static readonly IntPtr NativeFieldInfoPtr_AmountLabel;

		// Token: 0x04006D6B RID: 28011
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04006D6C RID: 28012
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0;

		// Token: 0x04006D6D RID: 28013
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
