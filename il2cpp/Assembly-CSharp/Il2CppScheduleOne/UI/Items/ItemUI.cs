using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x02000719 RID: 1817
	public class ItemUI : MonoBehaviour
	{
		// Token: 0x0600A362 RID: 41826 RVA: 0x00290064 File Offset: 0x0028E264
		// Note: this type is marked as 'beforefieldinit'.
		static ItemUI()
		{
			Il2CppClassPointerStore<ItemUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "ItemUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemUI>.NativeClassPtr);
			ItemUI.NativeFieldInfoPtr_itemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, "itemInstance");
			ItemUI.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, "Rect");
			ItemUI.NativeFieldInfoPtr_IconImg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, "IconImg");
			ItemUI.NativeFieldInfoPtr_QuantityLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, "QuantityLabel");
			ItemUI.NativeFieldInfoPtr_DisplayedQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, "DisplayedQuantity");
			ItemUI.NativeFieldInfoPtr_Destroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, "Destroyed");
			ItemUI.NativeMethodInfoPtr_Setup_Public_Virtual_New_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, 100683280);
			ItemUI.NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, 100683281);
			ItemUI.NativeMethodInfoPtr_DuplicateIcon_Public_Virtual_New_RectTransform_Transform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, 100683282);
			ItemUI.NativeMethodInfoPtr_SetVisible_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, 100683283);
			ItemUI.NativeMethodInfoPtr_UpdateUI_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, 100683284);
			ItemUI.NativeMethodInfoPtr_SetDisplayedQuantity_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, 100683285);
			ItemUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, 100683286);
		}

		// Token: 0x0600A363 RID: 41827 RVA: 0x00290198 File Offset: 0x0028E398
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 286119, RefRangeEnd = 286124, XrefRangeStart = 286090, XrefRangeEnd = 286119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Setup(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUI.NativeMethodInfoPtr_Setup_Public_Virtual_New_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A364 RID: 41828 RVA: 0x002901E8 File Offset: 0x0028E3E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286124, XrefRangeEnd = 286142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUI.NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A365 RID: 41829 RVA: 0x00290224 File Offset: 0x0028E424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286142, XrefRangeEnd = 286155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual RectTransform DuplicateIcon(Transform parent, int overriddenQuantity = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overriddenQuantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUI.NativeMethodInfoPtr_DuplicateIcon_Public_Virtual_New_RectTransform_Transform_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
		}

		// Token: 0x0600A366 RID: 41830 RVA: 0x00290290 File Offset: 0x0028E490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286155, XrefRangeEnd = 286158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetVisible(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUI.NativeMethodInfoPtr_SetVisible_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A367 RID: 41831 RVA: 0x002902DC File Offset: 0x0028E4DC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 286159, RefRangeEnd = 286165, XrefRangeStart = 286158, XrefRangeEnd = 286159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUI.NativeMethodInfoPtr_UpdateUI_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A368 RID: 41832 RVA: 0x00290318 File Offset: 0x0028E518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286165, XrefRangeEnd = 286168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetDisplayedQuantity(int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUI.NativeMethodInfoPtr_SetDisplayedQuantity_Public_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A369 RID: 41833 RVA: 0x00290364 File Offset: 0x0028E564
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A36A RID: 41834 RVA: 0x0005070D File Offset: 0x0004E90D
		public ItemUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003263 RID: 12899
		// (get) Token: 0x0600A36B RID: 41835 RVA: 0x002903A0 File Offset: 0x0028E5A0
		// (set) Token: 0x0600A36C RID: 41836 RVA: 0x00050716 File Offset: 0x0004E916
		public unsafe ItemInstance itemInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI.NativeFieldInfoPtr_itemInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI.NativeFieldInfoPtr_itemInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003264 RID: 12900
		// (get) Token: 0x0600A36D RID: 41837 RVA: 0x002903D0 File Offset: 0x0028E5D0
		// (set) Token: 0x0600A36E RID: 41838 RVA: 0x00050735 File Offset: 0x0004E935
		public unsafe RectTransform Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI.NativeFieldInfoPtr_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003265 RID: 12901
		// (get) Token: 0x0600A36F RID: 41839 RVA: 0x00290400 File Offset: 0x0028E600
		// (set) Token: 0x0600A370 RID: 41840 RVA: 0x00050754 File Offset: 0x0004E954
		public unsafe Image IconImg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI.NativeFieldInfoPtr_IconImg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI.NativeFieldInfoPtr_IconImg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003266 RID: 12902
		// (get) Token: 0x0600A371 RID: 41841 RVA: 0x00290430 File Offset: 0x0028E630
		// (set) Token: 0x0600A372 RID: 41842 RVA: 0x00050773 File Offset: 0x0004E973
		public unsafe TextMeshProUGUI QuantityLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI.NativeFieldInfoPtr_QuantityLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI.NativeFieldInfoPtr_QuantityLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003267 RID: 12903
		// (get) Token: 0x0600A373 RID: 41843 RVA: 0x00290460 File Offset: 0x0028E660
		// (set) Token: 0x0600A374 RID: 41844 RVA: 0x00050792 File Offset: 0x0004E992
		public unsafe int DisplayedQuantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI.NativeFieldInfoPtr_DisplayedQuantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI.NativeFieldInfoPtr_DisplayedQuantity)) = value;
			}
		}

		// Token: 0x17003268 RID: 12904
		// (get) Token: 0x0600A375 RID: 41845 RVA: 0x00290488 File Offset: 0x0028E688
		// (set) Token: 0x0600A376 RID: 41846 RVA: 0x000507AD File Offset: 0x0004E9AD
		public unsafe bool Destroyed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI.NativeFieldInfoPtr_Destroyed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI.NativeFieldInfoPtr_Destroyed)) = value;
			}
		}

		// Token: 0x04006D92 RID: 28050
		private static readonly IntPtr NativeFieldInfoPtr_itemInstance;

		// Token: 0x04006D93 RID: 28051
		private static readonly IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x04006D94 RID: 28052
		private static readonly IntPtr NativeFieldInfoPtr_IconImg;

		// Token: 0x04006D95 RID: 28053
		private static readonly IntPtr NativeFieldInfoPtr_QuantityLabel;

		// Token: 0x04006D96 RID: 28054
		private static readonly IntPtr NativeFieldInfoPtr_DisplayedQuantity;

		// Token: 0x04006D97 RID: 28055
		private static readonly IntPtr NativeFieldInfoPtr_Destroyed;

		// Token: 0x04006D98 RID: 28056
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Virtual_New_Void_ItemInstance_0;

		// Token: 0x04006D99 RID: 28057
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0;

		// Token: 0x04006D9A RID: 28058
		private static readonly IntPtr NativeMethodInfoPtr_DuplicateIcon_Public_Virtual_New_RectTransform_Transform_Int32_0;

		// Token: 0x04006D9B RID: 28059
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04006D9C RID: 28060
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Public_Virtual_New_Void_0;

		// Token: 0x04006D9D RID: 28061
		private static readonly IntPtr NativeMethodInfoPtr_SetDisplayedQuantity_Public_Virtual_New_Void_Int32_0;

		// Token: 0x04006D9E RID: 28062
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
