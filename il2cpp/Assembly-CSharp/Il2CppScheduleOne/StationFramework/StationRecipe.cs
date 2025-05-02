using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Storage;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x02000593 RID: 1427
	[Serializable]
	public class StationRecipe : ScriptableObject
	{
		// Token: 0x06007D99 RID: 32153 RVA: 0x0021A550 File Offset: 0x00218750
		// Note: this type is marked as 'beforefieldinit'.
		static StationRecipe()
		{
			Il2CppClassPointerStore<StationRecipe>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "StationRecipe");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr);
			StationRecipe.NativeFieldInfoPtr_IsDiscovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "IsDiscovered");
			StationRecipe.NativeFieldInfoPtr_RecipeTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "RecipeTitle");
			StationRecipe.NativeFieldInfoPtr_Unlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "Unlocked");
			StationRecipe.NativeFieldInfoPtr_Ingredients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "Ingredients");
			StationRecipe.NativeFieldInfoPtr_Product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "Product");
			StationRecipe.NativeFieldInfoPtr_FinalLiquidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "FinalLiquidColor");
			StationRecipe.NativeFieldInfoPtr_CookTime_Mins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "CookTime_Mins");
			StationRecipe.NativeFieldInfoPtr_CookTemperature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "CookTemperature");
			StationRecipe.NativeFieldInfoPtr_CookTemperatureTolerance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "CookTemperatureTolerance");
			StationRecipe.NativeFieldInfoPtr_QualityCalculationMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "QualityCalculationMethod");
			StationRecipe.NativeMethodInfoPtr_get_CookTemperatureLowerBound_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, 100679007);
			StationRecipe.NativeMethodInfoPtr_get_CookTemperatureUpperBound_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, 100679008);
			StationRecipe.NativeMethodInfoPtr_get_RecipeID_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, 100679009);
			StationRecipe.NativeMethodInfoPtr_GetProductInstance_Public_StorableItemInstance_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, 100679010);
			StationRecipe.NativeMethodInfoPtr_GetProductInstance_Public_StorableItemInstance_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, 100679011);
			StationRecipe.NativeMethodInfoPtr_DoIngredientsSuffice_Public_Boolean_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, 100679012);
			StationRecipe.NativeMethodInfoPtr_CalculateQuality_Public_EQuality_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, 100679013);
			StationRecipe.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, 100679014);
		}

		// Token: 0x1700260E RID: 9742
		// (get) Token: 0x06007D9A RID: 32154 RVA: 0x0021A6E8 File Offset: 0x002188E8
		public unsafe float CookTemperatureLowerBound
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipe.NativeMethodInfoPtr_get_CookTemperatureLowerBound_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700260F RID: 9743
		// (get) Token: 0x06007D9B RID: 32155 RVA: 0x0021A724 File Offset: 0x00218924
		public unsafe float CookTemperatureUpperBound
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipe.NativeMethodInfoPtr_get_CookTemperatureUpperBound_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002610 RID: 9744
		// (get) Token: 0x06007D9C RID: 32156 RVA: 0x0021A760 File Offset: 0x00218960
		public unsafe string RecipeID
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 238272, RefRangeEnd = 238277, XrefRangeStart = 238267, XrefRangeEnd = 238272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipe.NativeMethodInfoPtr_get_RecipeID_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06007D9D RID: 32157 RVA: 0x0021A798 File Offset: 0x00218998
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 238285, RefRangeEnd = 238288, XrefRangeStart = 238277, XrefRangeEnd = 238285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorableItemInstance GetProductInstance(List<ItemInstance> ingredients)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ingredients);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipe.NativeMethodInfoPtr_GetProductInstance_Public_StorableItemInstance_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StorableItemInstance>(intPtr3) : null;
		}

		// Token: 0x06007D9E RID: 32158 RVA: 0x0021A7E8 File Offset: 0x002189E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 238290, RefRangeEnd = 238291, XrefRangeStart = 238288, XrefRangeEnd = 238290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorableItemInstance GetProductInstance(EQuality quality)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quality;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipe.NativeMethodInfoPtr_GetProductInstance_Public_StorableItemInstance_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StorableItemInstance>(intPtr3) : null;
		}

		// Token: 0x06007D9F RID: 32159 RVA: 0x0021A834 File Offset: 0x00218A34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 238343, RefRangeEnd = 238344, XrefRangeStart = 238291, XrefRangeEnd = 238343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoIngredientsSuffice(List<ItemInstance> ingredients)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ingredients);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipe.NativeMethodInfoPtr_DoIngredientsSuffice_Public_Boolean_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007DA0 RID: 32160 RVA: 0x0021A884 File Offset: 0x00218A84
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 238357, RefRangeEnd = 238360, XrefRangeStart = 238344, XrefRangeEnd = 238357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EQuality CalculateQuality(List<ItemInstance> ingredients)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ingredients);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipe.NativeMethodInfoPtr_CalculateQuality_Public_EQuality_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007DA1 RID: 32161 RVA: 0x0021A8D4 File Offset: 0x00218AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238360, XrefRangeEnd = 238368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StationRecipe() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipe.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007DA2 RID: 32162 RVA: 0x0003BB26 File Offset: 0x00039D26
		public StationRecipe(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002604 RID: 9732
		// (get) Token: 0x06007DA3 RID: 32163 RVA: 0x0021A910 File Offset: 0x00218B10
		// (set) Token: 0x06007DA4 RID: 32164 RVA: 0x0003BB2F File Offset: 0x00039D2F
		public unsafe bool IsDiscovered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_IsDiscovered);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_IsDiscovered)) = value;
			}
		}

		// Token: 0x17002605 RID: 9733
		// (get) Token: 0x06007DA5 RID: 32165 RVA: 0x0021A938 File Offset: 0x00218B38
		// (set) Token: 0x06007DA6 RID: 32166 RVA: 0x0003BB4A File Offset: 0x00039D4A
		public unsafe string RecipeTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_RecipeTitle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_RecipeTitle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002606 RID: 9734
		// (get) Token: 0x06007DA7 RID: 32167 RVA: 0x0021A960 File Offset: 0x00218B60
		// (set) Token: 0x06007DA8 RID: 32168 RVA: 0x0003BB69 File Offset: 0x00039D69
		public unsafe bool Unlocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_Unlocked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_Unlocked)) = value;
			}
		}

		// Token: 0x17002607 RID: 9735
		// (get) Token: 0x06007DA9 RID: 32169 RVA: 0x0021A988 File Offset: 0x00218B88
		// (set) Token: 0x06007DAA RID: 32170 RVA: 0x0003BB84 File Offset: 0x00039D84
		public unsafe List<StationRecipe.IngredientQuantity> Ingredients
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_Ingredients);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StationRecipe.IngredientQuantity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_Ingredients), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002608 RID: 9736
		// (get) Token: 0x06007DAB RID: 32171 RVA: 0x0021A9B8 File Offset: 0x00218BB8
		// (set) Token: 0x06007DAC RID: 32172 RVA: 0x0003BBA3 File Offset: 0x00039DA3
		public unsafe StationRecipe.ItemQuantity Product
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_Product);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipe.ItemQuantity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_Product), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002609 RID: 9737
		// (get) Token: 0x06007DAD RID: 32173 RVA: 0x0021A9E8 File Offset: 0x00218BE8
		// (set) Token: 0x06007DAE RID: 32174 RVA: 0x0003BBC2 File Offset: 0x00039DC2
		public unsafe Color FinalLiquidColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_FinalLiquidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_FinalLiquidColor)) = value;
			}
		}

		// Token: 0x1700260A RID: 9738
		// (get) Token: 0x06007DAF RID: 32175 RVA: 0x0021AA10 File Offset: 0x00218C10
		// (set) Token: 0x06007DB0 RID: 32176 RVA: 0x0003BBDD File Offset: 0x00039DDD
		public unsafe int CookTime_Mins
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_CookTime_Mins);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_CookTime_Mins)) = value;
			}
		}

		// Token: 0x1700260B RID: 9739
		// (get) Token: 0x06007DB1 RID: 32177 RVA: 0x0021AA38 File Offset: 0x00218C38
		// (set) Token: 0x06007DB2 RID: 32178 RVA: 0x0003BBF8 File Offset: 0x00039DF8
		public unsafe float CookTemperature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_CookTemperature);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_CookTemperature)) = value;
			}
		}

		// Token: 0x1700260C RID: 9740
		// (get) Token: 0x06007DB3 RID: 32179 RVA: 0x0021AA60 File Offset: 0x00218C60
		// (set) Token: 0x06007DB4 RID: 32180 RVA: 0x0003BC13 File Offset: 0x00039E13
		public unsafe float CookTemperatureTolerance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_CookTemperatureTolerance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_CookTemperatureTolerance)) = value;
			}
		}

		// Token: 0x1700260D RID: 9741
		// (get) Token: 0x06007DB5 RID: 32181 RVA: 0x0021AA88 File Offset: 0x00218C88
		// (set) Token: 0x06007DB6 RID: 32182 RVA: 0x0003BC2E File Offset: 0x00039E2E
		public unsafe StationRecipe.EQualityCalculationMethod QualityCalculationMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_QualityCalculationMethod);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_QualityCalculationMethod)) = value;
			}
		}

		// Token: 0x04005570 RID: 21872
		private static readonly IntPtr NativeFieldInfoPtr_IsDiscovered;

		// Token: 0x04005571 RID: 21873
		private static readonly IntPtr NativeFieldInfoPtr_RecipeTitle;

		// Token: 0x04005572 RID: 21874
		private static readonly IntPtr NativeFieldInfoPtr_Unlocked;

		// Token: 0x04005573 RID: 21875
		private static readonly IntPtr NativeFieldInfoPtr_Ingredients;

		// Token: 0x04005574 RID: 21876
		private static readonly IntPtr NativeFieldInfoPtr_Product;

		// Token: 0x04005575 RID: 21877
		private static readonly IntPtr NativeFieldInfoPtr_FinalLiquidColor;

		// Token: 0x04005576 RID: 21878
		private static readonly IntPtr NativeFieldInfoPtr_CookTime_Mins;

		// Token: 0x04005577 RID: 21879
		private static readonly IntPtr NativeFieldInfoPtr_CookTemperature;

		// Token: 0x04005578 RID: 21880
		private static readonly IntPtr NativeFieldInfoPtr_CookTemperatureTolerance;

		// Token: 0x04005579 RID: 21881
		private static readonly IntPtr NativeFieldInfoPtr_QualityCalculationMethod;

		// Token: 0x0400557A RID: 21882
		private static readonly IntPtr NativeMethodInfoPtr_get_CookTemperatureLowerBound_Public_get_Single_0;

		// Token: 0x0400557B RID: 21883
		private static readonly IntPtr NativeMethodInfoPtr_get_CookTemperatureUpperBound_Public_get_Single_0;

		// Token: 0x0400557C RID: 21884
		private static readonly IntPtr NativeMethodInfoPtr_get_RecipeID_Public_get_String_0;

		// Token: 0x0400557D RID: 21885
		private static readonly IntPtr NativeMethodInfoPtr_GetProductInstance_Public_StorableItemInstance_List_1_ItemInstance_0;

		// Token: 0x0400557E RID: 21886
		private static readonly IntPtr NativeMethodInfoPtr_GetProductInstance_Public_StorableItemInstance_EQuality_0;

		// Token: 0x0400557F RID: 21887
		private static readonly IntPtr NativeMethodInfoPtr_DoIngredientsSuffice_Public_Boolean_List_1_ItemInstance_0;

		// Token: 0x04005580 RID: 21888
		private static readonly IntPtr NativeMethodInfoPtr_CalculateQuality_Public_EQuality_List_1_ItemInstance_0;

		// Token: 0x04005581 RID: 21889
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AC1 RID: 2753
		[OriginalName("Assembly-CSharp.dll", "", "EQualityCalculationMethod")]
		public enum EQualityCalculationMethod
		{
			// Token: 0x04008ECD RID: 36557
			Additive
		}

		// Token: 0x02000AC2 RID: 2754
		[Serializable]
		public class ItemQuantity : Il2CppSystem.Object
		{
			// Token: 0x0600D40A RID: 54282 RVA: 0x0032A0D0 File Offset: 0x003282D0
			// Note: this type is marked as 'beforefieldinit'.
			static ItemQuantity()
			{
				Il2CppClassPointerStore<StationRecipe.ItemQuantity>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "ItemQuantity");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipe.ItemQuantity>.NativeClassPtr);
				StationRecipe.ItemQuantity.NativeFieldInfoPtr_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe.ItemQuantity>.NativeClassPtr, "Item");
				StationRecipe.ItemQuantity.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe.ItemQuantity>.NativeClassPtr, "Quantity");
				StationRecipe.ItemQuantity.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe.ItemQuantity>.NativeClassPtr, 100679015);
			}

			// Token: 0x0600D40B RID: 54283 RVA: 0x0032A138 File Offset: 0x00328338
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238239, XrefRangeEnd = 238240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ItemQuantity() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipe.ItemQuantity>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipe.ItemQuantity.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D40C RID: 54284 RVA: 0x00067356 File Offset: 0x00065556
			public ItemQuantity(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041BD RID: 16829
			// (get) Token: 0x0600D40D RID: 54285 RVA: 0x0032A174 File Offset: 0x00328374
			// (set) Token: 0x0600D40E RID: 54286 RVA: 0x0006735F File Offset: 0x0006555F
			public unsafe ItemDefinition Item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.ItemQuantity.NativeFieldInfoPtr_Item);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.ItemQuantity.NativeFieldInfoPtr_Item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041BE RID: 16830
			// (get) Token: 0x0600D40F RID: 54287 RVA: 0x0032A1A4 File Offset: 0x003283A4
			// (set) Token: 0x0600D410 RID: 54288 RVA: 0x0006737E File Offset: 0x0006557E
			public unsafe int Quantity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.ItemQuantity.NativeFieldInfoPtr_Quantity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.ItemQuantity.NativeFieldInfoPtr_Quantity)) = value;
				}
			}

			// Token: 0x04008ECE RID: 36558
			private static readonly IntPtr NativeFieldInfoPtr_Item;

			// Token: 0x04008ECF RID: 36559
			private static readonly IntPtr NativeFieldInfoPtr_Quantity;

			// Token: 0x04008ED0 RID: 36560
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000AC3 RID: 2755
		[Serializable]
		public class IngredientQuantity : Il2CppSystem.Object
		{
			// Token: 0x0600D411 RID: 54289 RVA: 0x0032A1CC File Offset: 0x003283CC
			// Note: this type is marked as 'beforefieldinit'.
			static IngredientQuantity()
			{
				Il2CppClassPointerStore<StationRecipe.IngredientQuantity>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "IngredientQuantity");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipe.IngredientQuantity>.NativeClassPtr);
				StationRecipe.IngredientQuantity.NativeFieldInfoPtr_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe.IngredientQuantity>.NativeClassPtr, "Items");
				StationRecipe.IngredientQuantity.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe.IngredientQuantity>.NativeClassPtr, "Quantity");
				StationRecipe.IngredientQuantity.NativeMethodInfoPtr_get_Item_Public_get_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe.IngredientQuantity>.NativeClassPtr, 100679016);
				StationRecipe.IngredientQuantity.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe.IngredientQuantity>.NativeClassPtr, 100679017);
			}

			// Token: 0x170041C1 RID: 16833
			// (get) Token: 0x0600D412 RID: 54290 RVA: 0x0032A248 File Offset: 0x00328448
			public unsafe ItemDefinition Item
			{
				[CallerCount(12)]
				[CachedScanResults(RefRangeStart = 238243, RefRangeEnd = 238255, XrefRangeStart = 238240, XrefRangeEnd = 238243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipe.IngredientQuantity.NativeMethodInfoPtr_get_Item_Public_get_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr3) : null;
				}
			}

			// Token: 0x0600D413 RID: 54291 RVA: 0x0032A288 File Offset: 0x00328488
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 238263, RefRangeEnd = 238265, XrefRangeStart = 238255, XrefRangeEnd = 238263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IngredientQuantity() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipe.IngredientQuantity>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipe.IngredientQuantity.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D414 RID: 54292 RVA: 0x00067399 File Offset: 0x00065599
			public IngredientQuantity(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041BF RID: 16831
			// (get) Token: 0x0600D415 RID: 54293 RVA: 0x0032A2C4 File Offset: 0x003284C4
			// (set) Token: 0x0600D416 RID: 54294 RVA: 0x000673A2 File Offset: 0x000655A2
			public unsafe List<ItemDefinition> Items
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.IngredientQuantity.NativeFieldInfoPtr_Items);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemDefinition>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.IngredientQuantity.NativeFieldInfoPtr_Items), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041C0 RID: 16832
			// (get) Token: 0x0600D417 RID: 54295 RVA: 0x0032A2F4 File Offset: 0x003284F4
			// (set) Token: 0x0600D418 RID: 54296 RVA: 0x000673C1 File Offset: 0x000655C1
			public unsafe int Quantity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.IngredientQuantity.NativeFieldInfoPtr_Quantity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.IngredientQuantity.NativeFieldInfoPtr_Quantity)) = value;
				}
			}

			// Token: 0x04008ED1 RID: 36561
			private static readonly IntPtr NativeFieldInfoPtr_Items;

			// Token: 0x04008ED2 RID: 36562
			private static readonly IntPtr NativeFieldInfoPtr_Quantity;

			// Token: 0x04008ED3 RID: 36563
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_ItemDefinition_0;

			// Token: 0x04008ED4 RID: 36564
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000AC4 RID: 2756
		[ObfuscatedName("ScheduleOne.StationFramework.StationRecipe+<>c__DisplayClass21_0")]
		public sealed class __c__DisplayClass21_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D419 RID: 54297 RVA: 0x0032A31C File Offset: 0x0032851C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_0()
			{
				Il2CppClassPointerStore<StationRecipe.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "<>c__DisplayClass21_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipe.__c__DisplayClass21_0>.NativeClassPtr);
				StationRecipe.__c__DisplayClass21_0.NativeFieldInfoPtr_ingredientVariant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe.__c__DisplayClass21_0>.NativeClassPtr, "ingredientVariant");
				StationRecipe.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe.__c__DisplayClass21_0>.NativeClassPtr, 100679018);
				StationRecipe.__c__DisplayClass21_0.NativeMethodInfoPtr__DoIngredientsSuffice_b__0_Internal_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe.__c__DisplayClass21_0>.NativeClassPtr, 100679019);
			}

			// Token: 0x0600D41A RID: 54298 RVA: 0x0032A384 File Offset: 0x00328584
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipe.__c__DisplayClass21_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipe.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D41B RID: 54299 RVA: 0x0032A3C0 File Offset: 0x003285C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238265, XrefRangeEnd = 238267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DoIngredientsSuffice_b__0(ItemInstance x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipe.__c__DisplayClass21_0.NativeMethodInfoPtr__DoIngredientsSuffice_b__0_Internal_Boolean_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D41C RID: 54300 RVA: 0x000673DC File Offset: 0x000655DC
			public __c__DisplayClass21_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041C2 RID: 16834
			// (get) Token: 0x0600D41D RID: 54301 RVA: 0x0032A410 File Offset: 0x00328610
			// (set) Token: 0x0600D41E RID: 54302 RVA: 0x000673E5 File Offset: 0x000655E5
			public unsafe ItemDefinition ingredientVariant
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.__c__DisplayClass21_0.NativeFieldInfoPtr_ingredientVariant);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.__c__DisplayClass21_0.NativeFieldInfoPtr_ingredientVariant), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008ED5 RID: 36565
			private static readonly IntPtr NativeFieldInfoPtr_ingredientVariant;

			// Token: 0x04008ED6 RID: 36566
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008ED7 RID: 36567
			private static readonly IntPtr NativeMethodInfoPtr__DoIngredientsSuffice_b__0_Internal_Boolean_ItemInstance_0;
		}
	}
}
