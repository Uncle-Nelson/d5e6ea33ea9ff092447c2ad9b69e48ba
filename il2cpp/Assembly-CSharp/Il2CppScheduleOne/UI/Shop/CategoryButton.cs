using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Shop
{
	// Token: 0x02000708 RID: 1800
	public class CategoryButton : MonoBehaviour
	{
		// Token: 0x0600A1C5 RID: 41413 RVA: 0x0028AEF0 File Offset: 0x002890F0
		// Note: this type is marked as 'beforefieldinit'.
		static CategoryButton()
		{
			Il2CppClassPointerStore<CategoryButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Shop", "CategoryButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr);
			CategoryButton.NativeFieldInfoPtr__isSelected_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, "<isSelected>k__BackingField");
			CategoryButton.NativeFieldInfoPtr_Category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, "Category");
			CategoryButton.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, "button");
			CategoryButton.NativeFieldInfoPtr_shop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, "shop");
			CategoryButton.NativeMethodInfoPtr_get_isSelected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, 100683090);
			CategoryButton.NativeMethodInfoPtr_set_isSelected_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, 100683091);
			CategoryButton.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, 100683092);
			CategoryButton.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, 100683093);
			CategoryButton.NativeMethodInfoPtr_Clicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, 100683094);
			CategoryButton.NativeMethodInfoPtr_Deselect_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, 100683095);
			CategoryButton.NativeMethodInfoPtr_Select_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, 100683096);
			CategoryButton.NativeMethodInfoPtr_RefreshUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, 100683097);
			CategoryButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, 100683098);
		}

		// Token: 0x170031DF RID: 12767
		// (get) Token: 0x0600A1C6 RID: 41414 RVA: 0x0028B024 File Offset: 0x00289224
		// (set) Token: 0x0600A1C7 RID: 41415 RVA: 0x0028B060 File Offset: 0x00289260
		public unsafe bool isSelected
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35365, RefRangeEnd = 35366, XrefRangeStart = 35365, XrefRangeEnd = 35366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CategoryButton.NativeMethodInfoPtr_get_isSelected_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35366, RefRangeEnd = 35368, XrefRangeStart = 35366, XrefRangeEnd = 35368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CategoryButton.NativeMethodInfoPtr_set_isSelected_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A1C8 RID: 41416 RVA: 0x0028B0A0 File Offset: 0x002892A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284345, XrefRangeEnd = 284362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CategoryButton.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1C9 RID: 41417 RVA: 0x0028B0D4 File Offset: 0x002892D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284362, XrefRangeEnd = 284367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CategoryButton.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1CA RID: 41418 RVA: 0x0028B108 File Offset: 0x00289308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284367, XrefRangeEnd = 284370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CategoryButton.NativeMethodInfoPtr_Clicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1CB RID: 41419 RVA: 0x0028B13C File Offset: 0x0028933C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284370, XrefRangeEnd = 284372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deselect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CategoryButton.NativeMethodInfoPtr_Deselect_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1CC RID: 41420 RVA: 0x0028B170 File Offset: 0x00289370
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 284384, RefRangeEnd = 284387, XrefRangeStart = 284372, XrefRangeEnd = 284384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Select()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CategoryButton.NativeMethodInfoPtr_Select_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1CD RID: 41421 RVA: 0x0028B1A4 File Offset: 0x002893A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284387, XrefRangeEnd = 284389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CategoryButton.NativeMethodInfoPtr_RefreshUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1CE RID: 41422 RVA: 0x0028B1D8 File Offset: 0x002893D8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CategoryButton() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CategoryButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1CF RID: 41423 RVA: 0x0004F970 File Offset: 0x0004DB70
		public CategoryButton(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170031DB RID: 12763
		// (get) Token: 0x0600A1D0 RID: 41424 RVA: 0x0028B214 File Offset: 0x00289414
		// (set) Token: 0x0600A1D1 RID: 41425 RVA: 0x0004F979 File Offset: 0x0004DB79
		public unsafe bool _isSelected_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryButton.NativeFieldInfoPtr__isSelected_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryButton.NativeFieldInfoPtr__isSelected_k__BackingField)) = value;
			}
		}

		// Token: 0x170031DC RID: 12764
		// (get) Token: 0x0600A1D2 RID: 41426 RVA: 0x0028B23C File Offset: 0x0028943C
		// (set) Token: 0x0600A1D3 RID: 41427 RVA: 0x0004F994 File Offset: 0x0004DB94
		public unsafe EShopCategory Category
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryButton.NativeFieldInfoPtr_Category);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryButton.NativeFieldInfoPtr_Category)) = value;
			}
		}

		// Token: 0x170031DD RID: 12765
		// (get) Token: 0x0600A1D4 RID: 41428 RVA: 0x0028B264 File Offset: 0x00289464
		// (set) Token: 0x0600A1D5 RID: 41429 RVA: 0x0004F9AF File Offset: 0x0004DBAF
		public unsafe Button button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryButton.NativeFieldInfoPtr_button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryButton.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031DE RID: 12766
		// (get) Token: 0x0600A1D6 RID: 41430 RVA: 0x0028B294 File Offset: 0x00289494
		// (set) Token: 0x0600A1D7 RID: 41431 RVA: 0x0004F9CE File Offset: 0x0004DBCE
		public unsafe ShopInterface shop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryButton.NativeFieldInfoPtr_shop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryButton.NativeFieldInfoPtr_shop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006C74 RID: 27764
		private static readonly IntPtr NativeFieldInfoPtr__isSelected_k__BackingField;

		// Token: 0x04006C75 RID: 27765
		private static readonly IntPtr NativeFieldInfoPtr_Category;

		// Token: 0x04006C76 RID: 27766
		private static readonly IntPtr NativeFieldInfoPtr_button;

		// Token: 0x04006C77 RID: 27767
		private static readonly IntPtr NativeFieldInfoPtr_shop;

		// Token: 0x04006C78 RID: 27768
		private static readonly IntPtr NativeMethodInfoPtr_get_isSelected_Public_get_Boolean_0;

		// Token: 0x04006C79 RID: 27769
		private static readonly IntPtr NativeMethodInfoPtr_set_isSelected_Protected_set_Void_Boolean_0;

		// Token: 0x04006C7A RID: 27770
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04006C7B RID: 27771
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04006C7C RID: 27772
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Private_Void_0;

		// Token: 0x04006C7D RID: 27773
		private static readonly IntPtr NativeMethodInfoPtr_Deselect_Public_Void_0;

		// Token: 0x04006C7E RID: 27774
		private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Void_0;

		// Token: 0x04006C7F RID: 27775
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Private_Void_0;

		// Token: 0x04006C80 RID: 27776
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
