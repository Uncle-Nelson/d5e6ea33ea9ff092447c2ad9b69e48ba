using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.StationFramework;
using Il2CppSystem;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x0200074B RID: 1867
	[Serializable]
	public class OvenCookOperation : Object
	{
		// Token: 0x0600AF32 RID: 44850 RVA: 0x002BB194 File Offset: 0x002B9394
		// Note: this type is marked as 'beforefieldinit'.
		static OvenCookOperation()
		{
			Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "OvenCookOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr);
			OvenCookOperation.NativeFieldInfoPtr__itemDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, "_itemDefinition");
			OvenCookOperation.NativeFieldInfoPtr__productionDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, "_productionDefinition");
			OvenCookOperation.NativeFieldInfoPtr__cookable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, "_cookable");
			OvenCookOperation.NativeFieldInfoPtr_IngredientID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, "IngredientID");
			OvenCookOperation.NativeFieldInfoPtr_IngredientQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, "IngredientQuality");
			OvenCookOperation.NativeFieldInfoPtr_IngredientQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, "IngredientQuantity");
			OvenCookOperation.NativeFieldInfoPtr_ProductID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, "ProductID");
			OvenCookOperation.NativeFieldInfoPtr_CookProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, "CookProgress");
			OvenCookOperation.NativeFieldInfoPtr_cookDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, "cookDuration");
			OvenCookOperation.NativeMethodInfoPtr_get_Ingredient_Public_get_StorableItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, 100684824);
			OvenCookOperation.NativeMethodInfoPtr_get_Product_Public_get_StorableItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, 100684825);
			OvenCookOperation.NativeMethodInfoPtr_get_Cookable_Public_get_CookableModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, 100684826);
			OvenCookOperation.NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, 100684827);
			OvenCookOperation.NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, 100684828);
			OvenCookOperation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, 100684829);
			OvenCookOperation.NativeMethodInfoPtr_UpdateCookProgress_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, 100684830);
			OvenCookOperation.NativeMethodInfoPtr_GetCookDuration_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, 100684831);
			OvenCookOperation.NativeMethodInfoPtr_GetProductItem_Public_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, 100684832);
			OvenCookOperation.NativeMethodInfoPtr_IsReady_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, 100684833);
		}

		// Token: 0x1700365D RID: 13917
		// (get) Token: 0x0600AF33 RID: 44851 RVA: 0x002BB340 File Offset: 0x002B9540
		public unsafe StorableItemDefinition Ingredient
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 302720, RefRangeEnd = 302727, XrefRangeStart = 302708, XrefRangeEnd = 302720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OvenCookOperation.NativeMethodInfoPtr_get_Ingredient_Public_get_StorableItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StorableItemDefinition>(intPtr3) : null;
			}
		}

		// Token: 0x1700365E RID: 13918
		// (get) Token: 0x0600AF34 RID: 44852 RVA: 0x002BB380 File Offset: 0x002B9580
		public unsafe StorableItemDefinition Product
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 302739, RefRangeEnd = 302742, XrefRangeStart = 302727, XrefRangeEnd = 302739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OvenCookOperation.NativeMethodInfoPtr_get_Product_Public_get_StorableItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StorableItemDefinition>(intPtr3) : null;
			}
		}

		// Token: 0x1700365F RID: 13919
		// (get) Token: 0x0600AF35 RID: 44853 RVA: 0x002BB3C0 File Offset: 0x002B95C0
		public unsafe CookableModule Cookable
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 302751, RefRangeEnd = 302757, XrefRangeStart = 302742, XrefRangeEnd = 302751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OvenCookOperation.NativeMethodInfoPtr_get_Cookable_Public_get_CookableModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CookableModule>(intPtr3) : null;
			}
		}

		// Token: 0x0600AF36 RID: 44854 RVA: 0x002BB400 File Offset: 0x002B9600
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 302760, RefRangeEnd = 302763, XrefRangeStart = 302757, XrefRangeEnd = 302760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OvenCookOperation(string ingredientID, EQuality ingredientQuality, int ingredientQuantity, string productID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ingredientID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ingredientQuality;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ingredientQuantity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(productID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OvenCookOperation.NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AF37 RID: 44855 RVA: 0x002BB47C File Offset: 0x002B967C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 302766, RefRangeEnd = 302767, XrefRangeStart = 302763, XrefRangeEnd = 302766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OvenCookOperation(string ingredientID, EQuality ingredientQuality, int ingredientQuantity, string productID, int progress) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ingredientID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ingredientQuality;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ingredientQuantity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(productID);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OvenCookOperation.NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_Int32_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AF38 RID: 44856 RVA: 0x002BB504 File Offset: 0x002B9704
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 302768, RefRangeEnd = 302769, XrefRangeStart = 302767, XrefRangeEnd = 302768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OvenCookOperation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OvenCookOperation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AF39 RID: 44857 RVA: 0x002BB540 File Offset: 0x002B9740
		[CallerCount(0)]
		public unsafe void UpdateCookProgress(int change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OvenCookOperation.NativeMethodInfoPtr_UpdateCookProgress_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AF3A RID: 44858 RVA: 0x002BB580 File Offset: 0x002B9780
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 302773, RefRangeEnd = 302781, XrefRangeStart = 302769, XrefRangeEnd = 302773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetCookDuration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OvenCookOperation.NativeMethodInfoPtr_GetCookDuration_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600AF3B RID: 44859 RVA: 0x002BB5BC File Offset: 0x002B97BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 302796, RefRangeEnd = 302799, XrefRangeStart = 302781, XrefRangeEnd = 302796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemInstance GetProductItem(int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OvenCookOperation.NativeMethodInfoPtr_GetProductItem_Public_ItemInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x0600AF3C RID: 44860 RVA: 0x002BB608 File Offset: 0x002B9808
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 302803, RefRangeEnd = 302804, XrefRangeStart = 302799, XrefRangeEnd = 302803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsReady()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OvenCookOperation.NativeMethodInfoPtr_IsReady_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600AF3D RID: 44861 RVA: 0x000561EA File Offset: 0x000543EA
		public OvenCookOperation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003654 RID: 13908
		// (get) Token: 0x0600AF3E RID: 44862 RVA: 0x002BB644 File Offset: 0x002B9844
		// (set) Token: 0x0600AF3F RID: 44863 RVA: 0x000561F3 File Offset: 0x000543F3
		public unsafe StorableItemDefinition _itemDefinition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr__itemDefinition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorableItemDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr__itemDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003655 RID: 13909
		// (get) Token: 0x0600AF40 RID: 44864 RVA: 0x002BB674 File Offset: 0x002B9874
		// (set) Token: 0x0600AF41 RID: 44865 RVA: 0x00056212 File Offset: 0x00054412
		public unsafe StorableItemDefinition _productionDefinition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr__productionDefinition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorableItemDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr__productionDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003656 RID: 13910
		// (get) Token: 0x0600AF42 RID: 44866 RVA: 0x002BB6A4 File Offset: 0x002B98A4
		// (set) Token: 0x0600AF43 RID: 44867 RVA: 0x00056231 File Offset: 0x00054431
		public unsafe CookableModule _cookable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr__cookable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookableModule>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr__cookable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003657 RID: 13911
		// (get) Token: 0x0600AF44 RID: 44868 RVA: 0x002BB6D4 File Offset: 0x002B98D4
		// (set) Token: 0x0600AF45 RID: 44869 RVA: 0x00056250 File Offset: 0x00054450
		public unsafe string IngredientID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr_IngredientID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr_IngredientID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003658 RID: 13912
		// (get) Token: 0x0600AF46 RID: 44870 RVA: 0x002BB6FC File Offset: 0x002B98FC
		// (set) Token: 0x0600AF47 RID: 44871 RVA: 0x0005626F File Offset: 0x0005446F
		public unsafe EQuality IngredientQuality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr_IngredientQuality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr_IngredientQuality)) = value;
			}
		}

		// Token: 0x17003659 RID: 13913
		// (get) Token: 0x0600AF48 RID: 44872 RVA: 0x002BB724 File Offset: 0x002B9924
		// (set) Token: 0x0600AF49 RID: 44873 RVA: 0x0005628A File Offset: 0x0005448A
		public unsafe int IngredientQuantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr_IngredientQuantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr_IngredientQuantity)) = value;
			}
		}

		// Token: 0x1700365A RID: 13914
		// (get) Token: 0x0600AF4A RID: 44874 RVA: 0x002BB74C File Offset: 0x002B994C
		// (set) Token: 0x0600AF4B RID: 44875 RVA: 0x000562A5 File Offset: 0x000544A5
		public unsafe string ProductID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr_ProductID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr_ProductID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700365B RID: 13915
		// (get) Token: 0x0600AF4C RID: 44876 RVA: 0x002BB774 File Offset: 0x002B9974
		// (set) Token: 0x0600AF4D RID: 44877 RVA: 0x000562C4 File Offset: 0x000544C4
		public unsafe int CookProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr_CookProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr_CookProgress)) = value;
			}
		}

		// Token: 0x1700365C RID: 13916
		// (get) Token: 0x0600AF4E RID: 44878 RVA: 0x002BB79C File Offset: 0x002B999C
		// (set) Token: 0x0600AF4F RID: 44879 RVA: 0x000562DF File Offset: 0x000544DF
		public unsafe int cookDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr_cookDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr_cookDuration)) = value;
			}
		}

		// Token: 0x040075EA RID: 30186
		private static readonly IntPtr NativeFieldInfoPtr__itemDefinition;

		// Token: 0x040075EB RID: 30187
		private static readonly IntPtr NativeFieldInfoPtr__productionDefinition;

		// Token: 0x040075EC RID: 30188
		private static readonly IntPtr NativeFieldInfoPtr__cookable;

		// Token: 0x040075ED RID: 30189
		private static readonly IntPtr NativeFieldInfoPtr_IngredientID;

		// Token: 0x040075EE RID: 30190
		private static readonly IntPtr NativeFieldInfoPtr_IngredientQuality;

		// Token: 0x040075EF RID: 30191
		private static readonly IntPtr NativeFieldInfoPtr_IngredientQuantity;

		// Token: 0x040075F0 RID: 30192
		private static readonly IntPtr NativeFieldInfoPtr_ProductID;

		// Token: 0x040075F1 RID: 30193
		private static readonly IntPtr NativeFieldInfoPtr_CookProgress;

		// Token: 0x040075F2 RID: 30194
		private static readonly IntPtr NativeFieldInfoPtr_cookDuration;

		// Token: 0x040075F3 RID: 30195
		private static readonly IntPtr NativeMethodInfoPtr_get_Ingredient_Public_get_StorableItemDefinition_0;

		// Token: 0x040075F4 RID: 30196
		private static readonly IntPtr NativeMethodInfoPtr_get_Product_Public_get_StorableItemDefinition_0;

		// Token: 0x040075F5 RID: 30197
		private static readonly IntPtr NativeMethodInfoPtr_get_Cookable_Public_get_CookableModule_0;

		// Token: 0x040075F6 RID: 30198
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_Int32_String_0;

		// Token: 0x040075F7 RID: 30199
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_Int32_String_Int32_0;

		// Token: 0x040075F8 RID: 30200
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040075F9 RID: 30201
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCookProgress_Public_Void_Int32_0;

		// Token: 0x040075FA RID: 30202
		private static readonly IntPtr NativeMethodInfoPtr_GetCookDuration_Public_Int32_0;

		// Token: 0x040075FB RID: 30203
		private static readonly IntPtr NativeMethodInfoPtr_GetProductItem_Public_ItemInstance_Int32_0;

		// Token: 0x040075FC RID: 30204
		private static readonly IntPtr NativeMethodInfoPtr_IsReady_Public_Boolean_0;
	}
}
