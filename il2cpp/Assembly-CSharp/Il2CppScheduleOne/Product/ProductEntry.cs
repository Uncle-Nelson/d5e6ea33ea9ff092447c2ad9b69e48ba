using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005B4 RID: 1460
	public class ProductEntry : MonoBehaviour
	{
		// Token: 0x0600803A RID: 32826 RVA: 0x00224E14 File Offset: 0x00223014
		// Note: this type is marked as 'beforefieldinit'.
		static ProductEntry()
		{
			Il2CppClassPointerStore<ProductEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "ProductEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr);
			ProductEntry.NativeFieldInfoPtr__Definition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "<Definition>k__BackingField");
			ProductEntry.NativeFieldInfoPtr_SelectedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "SelectedColor");
			ProductEntry.NativeFieldInfoPtr_DeselectedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "DeselectedColor");
			ProductEntry.NativeFieldInfoPtr_FavouritedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "FavouritedColor");
			ProductEntry.NativeFieldInfoPtr_UnfavouritedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "UnfavouritedColor");
			ProductEntry.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "Button");
			ProductEntry.NativeFieldInfoPtr_Frame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "Frame");
			ProductEntry.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "Icon");
			ProductEntry.NativeFieldInfoPtr_Tick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "Tick");
			ProductEntry.NativeFieldInfoPtr_Cross = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "Cross");
			ProductEntry.NativeFieldInfoPtr_Trigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "Trigger");
			ProductEntry.NativeFieldInfoPtr_FavouriteButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "FavouriteButton");
			ProductEntry.NativeFieldInfoPtr_FavouriteIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "FavouriteIcon");
			ProductEntry.NativeFieldInfoPtr_onHovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "onHovered");
			ProductEntry.NativeFieldInfoPtr_destroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "destroyed");
			ProductEntry.NativeMethodInfoPtr_get_Definition_Public_get_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679405);
			ProductEntry.NativeMethodInfoPtr_set_Definition_Private_set_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679406);
			ProductEntry.NativeMethodInfoPtr_Initialize_Public_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679407);
			ProductEntry.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679408);
			ProductEntry.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679409);
			ProductEntry.NativeMethodInfoPtr_Clicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679410);
			ProductEntry.NativeMethodInfoPtr_FavouriteClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679411);
			ProductEntry.NativeMethodInfoPtr_ProductListedOrDelisted_Private_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679412);
			ProductEntry.NativeMethodInfoPtr_UpdateListed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679413);
			ProductEntry.NativeMethodInfoPtr_ProductFavouritedOrUnFavourited_Private_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679414);
			ProductEntry.NativeMethodInfoPtr_UpdateFavourited_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679415);
			ProductEntry.NativeMethodInfoPtr_UpdateDiscovered_Public_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679416);
			ProductEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679417);
			ProductEntry.NativeMethodInfoPtr__Initialize_b__18_0_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679418);
		}

		// Token: 0x170026C6 RID: 9926
		// (get) Token: 0x0600803B RID: 32827 RVA: 0x00225088 File Offset: 0x00223288
		// (set) Token: 0x0600803C RID: 32828 RVA: 0x002250C8 File Offset: 0x002232C8
		public unsafe ProductDefinition Definition
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17399, RefRangeEnd = 17400, XrefRangeStart = 17399, XrefRangeEnd = 17400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_get_Definition_Public_get_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_set_Definition_Private_set_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600803D RID: 32829 RVA: 0x0022510C File Offset: 0x0022330C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 244378, RefRangeEnd = 244380, XrefRangeStart = 244254, XrefRangeEnd = 244378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(ProductDefinition definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_Initialize_Public_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600803E RID: 32830 RVA: 0x00225150 File Offset: 0x00223350
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 244388, RefRangeEnd = 244389, XrefRangeStart = 244380, XrefRangeEnd = 244388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600803F RID: 32831 RVA: 0x00225184 File Offset: 0x00223384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244389, XrefRangeEnd = 244475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008040 RID: 32832 RVA: 0x002251B8 File Offset: 0x002233B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244475, XrefRangeEnd = 244482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_Clicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008041 RID: 32833 RVA: 0x002251EC File Offset: 0x002233EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244482, XrefRangeEnd = 244498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FavouriteClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_FavouriteClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008042 RID: 32834 RVA: 0x00225220 File Offset: 0x00223420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244498, XrefRangeEnd = 244503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProductListedOrDelisted(ProductDefinition def)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(def);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_ProductListedOrDelisted_Private_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008043 RID: 32835 RVA: 0x00225264 File Offset: 0x00223464
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 244522, RefRangeEnd = 244528, XrefRangeStart = 244503, XrefRangeEnd = 244522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateListed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_UpdateListed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008044 RID: 32836 RVA: 0x00225298 File Offset: 0x00223498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244528, XrefRangeEnd = 244533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProductFavouritedOrUnFavourited(ProductDefinition def)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(def);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_ProductFavouritedOrUnFavourited_Private_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008045 RID: 32837 RVA: 0x002252DC File Offset: 0x002234DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 244548, RefRangeEnd = 244550, XrefRangeStart = 244533, XrefRangeEnd = 244548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFavourited()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_UpdateFavourited_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008046 RID: 32838 RVA: 0x00225310 File Offset: 0x00223510
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 244572, RefRangeEnd = 244575, XrefRangeStart = 244550, XrefRangeEnd = 244572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDiscovered(ProductDefinition def)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(def);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_UpdateDiscovered_Public_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008047 RID: 32839 RVA: 0x00225354 File Offset: 0x00223554
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductEntry() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008048 RID: 32840 RVA: 0x00225390 File Offset: 0x00223590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244575, XrefRangeEnd = 244577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__18_0(BaseEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr__Initialize_b__18_0_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008049 RID: 32841 RVA: 0x0003CC70 File Offset: 0x0003AE70
		public ProductEntry(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026B7 RID: 9911
		// (get) Token: 0x0600804A RID: 32842 RVA: 0x002253D4 File Offset: 0x002235D4
		// (set) Token: 0x0600804B RID: 32843 RVA: 0x0003CC79 File Offset: 0x0003AE79
		public unsafe ProductDefinition _Definition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr__Definition_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr__Definition_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026B8 RID: 9912
		// (get) Token: 0x0600804C RID: 32844 RVA: 0x00225404 File Offset: 0x00223604
		// (set) Token: 0x0600804D RID: 32845 RVA: 0x0003CC98 File Offset: 0x0003AE98
		public unsafe Color SelectedColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_SelectedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_SelectedColor)) = value;
			}
		}

		// Token: 0x170026B9 RID: 9913
		// (get) Token: 0x0600804E RID: 32846 RVA: 0x0022542C File Offset: 0x0022362C
		// (set) Token: 0x0600804F RID: 32847 RVA: 0x0003CCB3 File Offset: 0x0003AEB3
		public unsafe Color DeselectedColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_DeselectedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_DeselectedColor)) = value;
			}
		}

		// Token: 0x170026BA RID: 9914
		// (get) Token: 0x06008050 RID: 32848 RVA: 0x00225454 File Offset: 0x00223654
		// (set) Token: 0x06008051 RID: 32849 RVA: 0x0003CCCE File Offset: 0x0003AECE
		public unsafe Color FavouritedColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_FavouritedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_FavouritedColor)) = value;
			}
		}

		// Token: 0x170026BB RID: 9915
		// (get) Token: 0x06008052 RID: 32850 RVA: 0x0022547C File Offset: 0x0022367C
		// (set) Token: 0x06008053 RID: 32851 RVA: 0x0003CCE9 File Offset: 0x0003AEE9
		public unsafe Color UnfavouritedColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_UnfavouritedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_UnfavouritedColor)) = value;
			}
		}

		// Token: 0x170026BC RID: 9916
		// (get) Token: 0x06008054 RID: 32852 RVA: 0x002254A4 File Offset: 0x002236A4
		// (set) Token: 0x06008055 RID: 32853 RVA: 0x0003CD04 File Offset: 0x0003AF04
		public unsafe Button Button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026BD RID: 9917
		// (get) Token: 0x06008056 RID: 32854 RVA: 0x002254D4 File Offset: 0x002236D4
		// (set) Token: 0x06008057 RID: 32855 RVA: 0x0003CD23 File Offset: 0x0003AF23
		public unsafe Image Frame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Frame);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Frame), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026BE RID: 9918
		// (get) Token: 0x06008058 RID: 32856 RVA: 0x00225504 File Offset: 0x00223704
		// (set) Token: 0x06008059 RID: 32857 RVA: 0x0003CD42 File Offset: 0x0003AF42
		public unsafe Image Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026BF RID: 9919
		// (get) Token: 0x0600805A RID: 32858 RVA: 0x00225534 File Offset: 0x00223734
		// (set) Token: 0x0600805B RID: 32859 RVA: 0x0003CD61 File Offset: 0x0003AF61
		public unsafe RectTransform Tick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Tick);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Tick), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026C0 RID: 9920
		// (get) Token: 0x0600805C RID: 32860 RVA: 0x00225564 File Offset: 0x00223764
		// (set) Token: 0x0600805D RID: 32861 RVA: 0x0003CD80 File Offset: 0x0003AF80
		public unsafe RectTransform Cross
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Cross);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Cross), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026C1 RID: 9921
		// (get) Token: 0x0600805E RID: 32862 RVA: 0x00225594 File Offset: 0x00223794
		// (set) Token: 0x0600805F RID: 32863 RVA: 0x0003CD9F File Offset: 0x0003AF9F
		public unsafe EventTrigger Trigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Trigger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventTrigger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Trigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026C2 RID: 9922
		// (get) Token: 0x06008060 RID: 32864 RVA: 0x002255C4 File Offset: 0x002237C4
		// (set) Token: 0x06008061 RID: 32865 RVA: 0x0003CDBE File Offset: 0x0003AFBE
		public unsafe Button FavouriteButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_FavouriteButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_FavouriteButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026C3 RID: 9923
		// (get) Token: 0x06008062 RID: 32866 RVA: 0x002255F4 File Offset: 0x002237F4
		// (set) Token: 0x06008063 RID: 32867 RVA: 0x0003CDDD File Offset: 0x0003AFDD
		public unsafe Image FavouriteIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_FavouriteIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_FavouriteIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026C4 RID: 9924
		// (get) Token: 0x06008064 RID: 32868 RVA: 0x00225624 File Offset: 0x00223824
		// (set) Token: 0x06008065 RID: 32869 RVA: 0x0003CDFC File Offset: 0x0003AFFC
		public unsafe UnityEvent onHovered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_onHovered);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_onHovered), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026C5 RID: 9925
		// (get) Token: 0x06008066 RID: 32870 RVA: 0x00225654 File Offset: 0x00223854
		// (set) Token: 0x06008067 RID: 32871 RVA: 0x0003CE1B File Offset: 0x0003B01B
		public unsafe bool destroyed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_destroyed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_destroyed)) = value;
			}
		}

		// Token: 0x0400575C RID: 22364
		private static readonly IntPtr NativeFieldInfoPtr__Definition_k__BackingField;

		// Token: 0x0400575D RID: 22365
		private static readonly IntPtr NativeFieldInfoPtr_SelectedColor;

		// Token: 0x0400575E RID: 22366
		private static readonly IntPtr NativeFieldInfoPtr_DeselectedColor;

		// Token: 0x0400575F RID: 22367
		private static readonly IntPtr NativeFieldInfoPtr_FavouritedColor;

		// Token: 0x04005760 RID: 22368
		private static readonly IntPtr NativeFieldInfoPtr_UnfavouritedColor;

		// Token: 0x04005761 RID: 22369
		private static readonly IntPtr NativeFieldInfoPtr_Button;

		// Token: 0x04005762 RID: 22370
		private static readonly IntPtr NativeFieldInfoPtr_Frame;

		// Token: 0x04005763 RID: 22371
		private static readonly IntPtr NativeFieldInfoPtr_Icon;

		// Token: 0x04005764 RID: 22372
		private static readonly IntPtr NativeFieldInfoPtr_Tick;

		// Token: 0x04005765 RID: 22373
		private static readonly IntPtr NativeFieldInfoPtr_Cross;

		// Token: 0x04005766 RID: 22374
		private static readonly IntPtr NativeFieldInfoPtr_Trigger;

		// Token: 0x04005767 RID: 22375
		private static readonly IntPtr NativeFieldInfoPtr_FavouriteButton;

		// Token: 0x04005768 RID: 22376
		private static readonly IntPtr NativeFieldInfoPtr_FavouriteIcon;

		// Token: 0x04005769 RID: 22377
		private static readonly IntPtr NativeFieldInfoPtr_onHovered;

		// Token: 0x0400576A RID: 22378
		private static readonly IntPtr NativeFieldInfoPtr_destroyed;

		// Token: 0x0400576B RID: 22379
		private static readonly IntPtr NativeMethodInfoPtr_get_Definition_Public_get_ProductDefinition_0;

		// Token: 0x0400576C RID: 22380
		private static readonly IntPtr NativeMethodInfoPtr_set_Definition_Private_set_Void_ProductDefinition_0;

		// Token: 0x0400576D RID: 22381
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_ProductDefinition_0;

		// Token: 0x0400576E RID: 22382
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;

		// Token: 0x0400576F RID: 22383
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04005770 RID: 22384
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Private_Void_0;

		// Token: 0x04005771 RID: 22385
		private static readonly IntPtr NativeMethodInfoPtr_FavouriteClicked_Private_Void_0;

		// Token: 0x04005772 RID: 22386
		private static readonly IntPtr NativeMethodInfoPtr_ProductListedOrDelisted_Private_Void_ProductDefinition_0;

		// Token: 0x04005773 RID: 22387
		private static readonly IntPtr NativeMethodInfoPtr_UpdateListed_Public_Void_0;

		// Token: 0x04005774 RID: 22388
		private static readonly IntPtr NativeMethodInfoPtr_ProductFavouritedOrUnFavourited_Private_Void_ProductDefinition_0;

		// Token: 0x04005775 RID: 22389
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFavourited_Public_Void_0;

		// Token: 0x04005776 RID: 22390
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDiscovered_Public_Void_ProductDefinition_0;

		// Token: 0x04005777 RID: 22391
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005778 RID: 22392
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__18_0_Private_Void_BaseEventData_0;
	}
}
