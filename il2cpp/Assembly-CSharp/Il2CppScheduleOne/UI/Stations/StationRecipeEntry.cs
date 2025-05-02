using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.StationFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Stations
{
	// Token: 0x0200067E RID: 1662
	public class StationRecipeEntry : MonoBehaviour
	{
		// Token: 0x06009491 RID: 38033 RVA: 0x0026285C File Offset: 0x00260A5C
		// Note: this type is marked as 'beforefieldinit'.
		static StationRecipeEntry()
		{
			Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Stations", "StationRecipeEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr);
			StationRecipeEntry.NativeFieldInfoPtr_ValidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "ValidColor");
			StationRecipeEntry.NativeFieldInfoPtr_InvalidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "InvalidColor");
			StationRecipeEntry.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "Button");
			StationRecipeEntry.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "Icon");
			StationRecipeEntry.NativeFieldInfoPtr_TitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "TitleLabel");
			StationRecipeEntry.NativeFieldInfoPtr_CookingTimeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "CookingTimeLabel");
			StationRecipeEntry.NativeFieldInfoPtr_IngredientRects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "IngredientRects");
			StationRecipeEntry.NativeFieldInfoPtr_IngredientQuantities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "IngredientQuantities");
			StationRecipeEntry.NativeFieldInfoPtr__IsValid_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "<IsValid>k__BackingField");
			StationRecipeEntry.NativeFieldInfoPtr__Recipe_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "<Recipe>k__BackingField");
			StationRecipeEntry.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, 100681687);
			StationRecipeEntry.NativeMethodInfoPtr_set_IsValid_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, 100681688);
			StationRecipeEntry.NativeMethodInfoPtr_get_Recipe_Public_get_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, 100681689);
			StationRecipeEntry.NativeMethodInfoPtr_set_Recipe_Private_set_Void_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, 100681690);
			StationRecipeEntry.NativeMethodInfoPtr_AssignRecipe_Public_Void_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, 100681691);
			StationRecipeEntry.NativeMethodInfoPtr_RefreshValidity_Public_Void_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, 100681692);
			StationRecipeEntry.NativeMethodInfoPtr_GetIngredientsMatchDelta_Public_Single_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, 100681693);
			StationRecipeEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, 100681694);
		}

		// Token: 0x17002DA3 RID: 11683
		// (get) Token: 0x06009492 RID: 38034 RVA: 0x002629F4 File Offset: 0x00260BF4
		// (set) Token: 0x06009493 RID: 38035 RVA: 0x00262A30 File Offset: 0x00260C30
		public unsafe bool IsValid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.NativeMethodInfoPtr_set_IsValid_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002DA4 RID: 11684
		// (get) Token: 0x06009494 RID: 38036 RVA: 0x00262A70 File Offset: 0x00260C70
		// (set) Token: 0x06009495 RID: 38037 RVA: 0x00262AB0 File Offset: 0x00260CB0
		public unsafe StationRecipe Recipe
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.NativeMethodInfoPtr_get_Recipe_Public_get_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.NativeMethodInfoPtr_set_Recipe_Private_set_Void_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009496 RID: 38038 RVA: 0x00262AF4 File Offset: 0x00260CF4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 267354, RefRangeEnd = 267358, XrefRangeStart = 267289, XrefRangeEnd = 267354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignRecipe(StationRecipe recipe)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipe);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.NativeMethodInfoPtr_AssignRecipe_Public_Void_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009497 RID: 38039 RVA: 0x00262B38 File Offset: 0x00260D38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 267421, RefRangeEnd = 267423, XrefRangeStart = 267358, XrefRangeEnd = 267421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshValidity(List<ItemInstance> ingredients)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ingredients);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.NativeMethodInfoPtr_RefreshValidity_Public_Void_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009498 RID: 38040 RVA: 0x00262B7C File Offset: 0x00260D7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 267493, RefRangeEnd = 267494, XrefRangeStart = 267423, XrefRangeEnd = 267493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetIngredientsMatchDelta(List<ItemInstance> ingredients)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ingredients);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.NativeMethodInfoPtr_GetIngredientsMatchDelta_Public_Single_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009499 RID: 38041 RVA: 0x00262BCC File Offset: 0x00260DCC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StationRecipeEntry() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600949A RID: 38042 RVA: 0x00048221 File Offset: 0x00046421
		public StationRecipeEntry(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D99 RID: 11673
		// (get) Token: 0x0600949B RID: 38043 RVA: 0x00262C08 File Offset: 0x00260E08
		// (set) Token: 0x0600949C RID: 38044 RVA: 0x0004822A File Offset: 0x0004642A
		public unsafe static Color ValidColor
		{
			get
			{
				Color result;
				IL2CPP.il2cpp_field_static_get_value(StationRecipeEntry.NativeFieldInfoPtr_ValidColor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StationRecipeEntry.NativeFieldInfoPtr_ValidColor, (void*)(&value));
			}
		}

		// Token: 0x17002D9A RID: 11674
		// (get) Token: 0x0600949D RID: 38045 RVA: 0x00262C24 File Offset: 0x00260E24
		// (set) Token: 0x0600949E RID: 38046 RVA: 0x00048238 File Offset: 0x00046438
		public unsafe static Color InvalidColor
		{
			get
			{
				Color result;
				IL2CPP.il2cpp_field_static_get_value(StationRecipeEntry.NativeFieldInfoPtr_InvalidColor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StationRecipeEntry.NativeFieldInfoPtr_InvalidColor, (void*)(&value));
			}
		}

		// Token: 0x17002D9B RID: 11675
		// (get) Token: 0x0600949F RID: 38047 RVA: 0x00262C40 File Offset: 0x00260E40
		// (set) Token: 0x060094A0 RID: 38048 RVA: 0x00048246 File Offset: 0x00046446
		public unsafe Button Button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr_Button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D9C RID: 11676
		// (get) Token: 0x060094A1 RID: 38049 RVA: 0x00262C70 File Offset: 0x00260E70
		// (set) Token: 0x060094A2 RID: 38050 RVA: 0x00048265 File Offset: 0x00046465
		public unsafe Image Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr_Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D9D RID: 11677
		// (get) Token: 0x060094A3 RID: 38051 RVA: 0x00262CA0 File Offset: 0x00260EA0
		// (set) Token: 0x060094A4 RID: 38052 RVA: 0x00048284 File Offset: 0x00046484
		public unsafe TextMeshProUGUI TitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr_TitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr_TitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D9E RID: 11678
		// (get) Token: 0x060094A5 RID: 38053 RVA: 0x00262CD0 File Offset: 0x00260ED0
		// (set) Token: 0x060094A6 RID: 38054 RVA: 0x000482A3 File Offset: 0x000464A3
		public unsafe TextMeshProUGUI CookingTimeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr_CookingTimeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr_CookingTimeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D9F RID: 11679
		// (get) Token: 0x060094A7 RID: 38055 RVA: 0x00262D00 File Offset: 0x00260F00
		// (set) Token: 0x060094A8 RID: 38056 RVA: 0x000482C2 File Offset: 0x000464C2
		public unsafe Il2CppReferenceArray<RectTransform> IngredientRects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr_IngredientRects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr_IngredientRects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DA0 RID: 11680
		// (get) Token: 0x060094A9 RID: 38057 RVA: 0x00262D30 File Offset: 0x00260F30
		// (set) Token: 0x060094AA RID: 38058 RVA: 0x000482E1 File Offset: 0x000464E1
		public unsafe Il2CppReferenceArray<TextMeshProUGUI> IngredientQuantities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr_IngredientQuantities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextMeshProUGUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr_IngredientQuantities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DA1 RID: 11681
		// (get) Token: 0x060094AB RID: 38059 RVA: 0x00262D60 File Offset: 0x00260F60
		// (set) Token: 0x060094AC RID: 38060 RVA: 0x00048300 File Offset: 0x00046500
		public unsafe bool _IsValid_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr__IsValid_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr__IsValid_k__BackingField)) = value;
			}
		}

		// Token: 0x17002DA2 RID: 11682
		// (get) Token: 0x060094AD RID: 38061 RVA: 0x00262D88 File Offset: 0x00260F88
		// (set) Token: 0x060094AE RID: 38062 RVA: 0x0004831B File Offset: 0x0004651B
		public unsafe StationRecipe _Recipe_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr__Recipe_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr__Recipe_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006438 RID: 25656
		private static readonly IntPtr NativeFieldInfoPtr_ValidColor;

		// Token: 0x04006439 RID: 25657
		private static readonly IntPtr NativeFieldInfoPtr_InvalidColor;

		// Token: 0x0400643A RID: 25658
		private static readonly IntPtr NativeFieldInfoPtr_Button;

		// Token: 0x0400643B RID: 25659
		private static readonly IntPtr NativeFieldInfoPtr_Icon;

		// Token: 0x0400643C RID: 25660
		private static readonly IntPtr NativeFieldInfoPtr_TitleLabel;

		// Token: 0x0400643D RID: 25661
		private static readonly IntPtr NativeFieldInfoPtr_CookingTimeLabel;

		// Token: 0x0400643E RID: 25662
		private static readonly IntPtr NativeFieldInfoPtr_IngredientRects;

		// Token: 0x0400643F RID: 25663
		private static readonly IntPtr NativeFieldInfoPtr_IngredientQuantities;

		// Token: 0x04006440 RID: 25664
		private static readonly IntPtr NativeFieldInfoPtr__IsValid_k__BackingField;

		// Token: 0x04006441 RID: 25665
		private static readonly IntPtr NativeFieldInfoPtr__Recipe_k__BackingField;

		// Token: 0x04006442 RID: 25666
		private static readonly IntPtr NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0;

		// Token: 0x04006443 RID: 25667
		private static readonly IntPtr NativeMethodInfoPtr_set_IsValid_Private_set_Void_Boolean_0;

		// Token: 0x04006444 RID: 25668
		private static readonly IntPtr NativeMethodInfoPtr_get_Recipe_Public_get_StationRecipe_0;

		// Token: 0x04006445 RID: 25669
		private static readonly IntPtr NativeMethodInfoPtr_set_Recipe_Private_set_Void_StationRecipe_0;

		// Token: 0x04006446 RID: 25670
		private static readonly IntPtr NativeMethodInfoPtr_AssignRecipe_Public_Void_StationRecipe_0;

		// Token: 0x04006447 RID: 25671
		private static readonly IntPtr NativeMethodInfoPtr_RefreshValidity_Public_Void_List_1_ItemInstance_0;

		// Token: 0x04006448 RID: 25672
		private static readonly IntPtr NativeMethodInfoPtr_GetIngredientsMatchDelta_Public_Single_List_1_ItemInstance_0;

		// Token: 0x04006449 RID: 25673
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B5B RID: 2907
		[ObfuscatedName("ScheduleOne.UI.Stations.StationRecipeEntry+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DA35 RID: 55861 RVA: 0x0033BC74 File Offset: 0x00339E74
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<StationRecipeEntry.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipeEntry.__c>.NativeClassPtr);
				StationRecipeEntry.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry.__c>.NativeClassPtr, "<>9");
				StationRecipeEntry.__c.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry.__c>.NativeClassPtr, "<>9__18_0");
				StationRecipeEntry.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry.__c>.NativeClassPtr, 100681697);
				StationRecipeEntry.__c.NativeMethodInfoPtr__GetIngredientsMatchDelta_b__18_0_Internal_Int32_IngredientQuantity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry.__c>.NativeClassPtr, 100681698);
			}

			// Token: 0x0600DA36 RID: 55862 RVA: 0x0033BCF0 File Offset: 0x00339EF0
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipeEntry.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA37 RID: 55863 RVA: 0x0033BD2C File Offset: 0x00339F2C
			[CallerCount(0)]
			public unsafe int _GetIngredientsMatchDelta_b__18_0(StationRecipe.IngredientQuantity x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.__c.NativeMethodInfoPtr__GetIngredientsMatchDelta_b__18_0_Internal_Int32_IngredientQuantity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DA38 RID: 55864 RVA: 0x0006A442 File Offset: 0x00068642
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043B3 RID: 17331
			// (get) Token: 0x0600DA39 RID: 55865 RVA: 0x0033BD7C File Offset: 0x00339F7C
			// (set) Token: 0x0600DA3A RID: 55866 RVA: 0x0006A44B File Offset: 0x0006864B
			public unsafe static StationRecipeEntry.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StationRecipeEntry.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipeEntry.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StationRecipeEntry.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043B4 RID: 17332
			// (get) Token: 0x0600DA3B RID: 55867 RVA: 0x0033BDA4 File Offset: 0x00339FA4
			// (set) Token: 0x0600DA3C RID: 55868 RVA: 0x0006A45D File Offset: 0x0006865D
			public unsafe static Func<StationRecipe.IngredientQuantity, int> __9__18_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StationRecipeEntry.__c.NativeFieldInfoPtr___9__18_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<StationRecipe.IngredientQuantity, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StationRecipeEntry.__c.NativeFieldInfoPtr___9__18_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009283 RID: 37507
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009284 RID: 37508
			private static readonly IntPtr NativeFieldInfoPtr___9__18_0;

			// Token: 0x04009285 RID: 37509
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009286 RID: 37510
			private static readonly IntPtr NativeMethodInfoPtr__GetIngredientsMatchDelta_b__18_0_Internal_Int32_IngredientQuantity_0;
		}

		// Token: 0x02000B5C RID: 2908
		[ObfuscatedName("ScheduleOne.UI.Stations.StationRecipeEntry+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DA3D RID: 55869 RVA: 0x0033BDCC File Offset: 0x00339FCC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<StationRecipeEntry.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipeEntry.__c__DisplayClass17_0>.NativeClassPtr);
				StationRecipeEntry.__c__DisplayClass17_0.NativeFieldInfoPtr_ingredientVariant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry.__c__DisplayClass17_0>.NativeClassPtr, "ingredientVariant");
				StationRecipeEntry.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry.__c__DisplayClass17_0>.NativeClassPtr, 100681699);
				StationRecipeEntry.__c__DisplayClass17_0.NativeMethodInfoPtr__RefreshValidity_b__0_Internal_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry.__c__DisplayClass17_0>.NativeClassPtr, 100681700);
			}

			// Token: 0x0600DA3E RID: 55870 RVA: 0x0033BE34 File Offset: 0x0033A034
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipeEntry.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA3F RID: 55871 RVA: 0x0033BE70 File Offset: 0x0033A070
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RefreshValidity_b__0(ItemInstance x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.__c__DisplayClass17_0.NativeMethodInfoPtr__RefreshValidity_b__0_Internal_Boolean_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DA40 RID: 55872 RVA: 0x0006A46F File Offset: 0x0006866F
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043B5 RID: 17333
			// (get) Token: 0x0600DA41 RID: 55873 RVA: 0x0033BEC0 File Offset: 0x0033A0C0
			// (set) Token: 0x0600DA42 RID: 55874 RVA: 0x0006A478 File Offset: 0x00068678
			public unsafe ItemDefinition ingredientVariant
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.__c__DisplayClass17_0.NativeFieldInfoPtr_ingredientVariant);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.__c__DisplayClass17_0.NativeFieldInfoPtr_ingredientVariant), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009287 RID: 37511
			private static readonly IntPtr NativeFieldInfoPtr_ingredientVariant;

			// Token: 0x04009288 RID: 37512
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009289 RID: 37513
			private static readonly IntPtr NativeMethodInfoPtr__RefreshValidity_b__0_Internal_Boolean_ItemInstance_0;
		}

		// Token: 0x02000B5D RID: 2909
		[ObfuscatedName("ScheduleOne.UI.Stations.StationRecipeEntry+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DA43 RID: 55875 RVA: 0x0033BEF0 File Offset: 0x0033A0F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<StationRecipeEntry.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipeEntry.__c__DisplayClass18_0>.NativeClassPtr);
				StationRecipeEntry.__c__DisplayClass18_0.NativeFieldInfoPtr_ingredientVariant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry.__c__DisplayClass18_0>.NativeClassPtr, "ingredientVariant");
				StationRecipeEntry.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry.__c__DisplayClass18_0>.NativeClassPtr, 100681701);
				StationRecipeEntry.__c__DisplayClass18_0.NativeMethodInfoPtr__GetIngredientsMatchDelta_b__1_Internal_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry.__c__DisplayClass18_0>.NativeClassPtr, 100681702);
			}

			// Token: 0x0600DA44 RID: 55876 RVA: 0x0033BF58 File Offset: 0x0033A158
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipeEntry.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA45 RID: 55877 RVA: 0x0033BF94 File Offset: 0x0033A194
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetIngredientsMatchDelta_b__1(ItemInstance x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.__c__DisplayClass18_0.NativeMethodInfoPtr__GetIngredientsMatchDelta_b__1_Internal_Boolean_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DA46 RID: 55878 RVA: 0x0006A497 File Offset: 0x00068697
			public __c__DisplayClass18_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043B6 RID: 17334
			// (get) Token: 0x0600DA47 RID: 55879 RVA: 0x0033BFE4 File Offset: 0x0033A1E4
			// (set) Token: 0x0600DA48 RID: 55880 RVA: 0x0006A4A0 File Offset: 0x000686A0
			public unsafe ItemDefinition ingredientVariant
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.__c__DisplayClass18_0.NativeFieldInfoPtr_ingredientVariant);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.__c__DisplayClass18_0.NativeFieldInfoPtr_ingredientVariant), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400928A RID: 37514
			private static readonly IntPtr NativeFieldInfoPtr_ingredientVariant;

			// Token: 0x0400928B RID: 37515
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400928C RID: 37516
			private static readonly IntPtr NativeMethodInfoPtr__GetIngredientsMatchDelta_b__1_Internal_Boolean_ItemInstance_0;
		}
	}
}
