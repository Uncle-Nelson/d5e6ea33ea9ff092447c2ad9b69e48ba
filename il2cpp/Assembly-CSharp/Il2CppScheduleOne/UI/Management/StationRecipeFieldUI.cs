using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.StationFramework;
using Il2CppScheduleOne.UI.Stations;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006CE RID: 1742
	public class StationRecipeFieldUI : MonoBehaviour
	{
		// Token: 0x06009C77 RID: 40055 RVA: 0x0027A344 File Offset: 0x00278544
		// Note: this type is marked as 'beforefieldinit'.
		static StationRecipeFieldUI()
		{
			Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "StationRecipeFieldUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr);
			StationRecipeFieldUI.NativeFieldInfoPtr__Fields_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, "<Fields>k__BackingField");
			StationRecipeFieldUI.NativeFieldInfoPtr_RecipeEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, "RecipeEntry");
			StationRecipeFieldUI.NativeFieldInfoPtr_None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, "None");
			StationRecipeFieldUI.NativeFieldInfoPtr_Mixed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, "Mixed");
			StationRecipeFieldUI.NativeFieldInfoPtr_ClearButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, "ClearButton");
			StationRecipeFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_StationRecipeField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, 100682504);
			StationRecipeFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_StationRecipeField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, 100682505);
			StationRecipeFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_StationRecipeField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, 100682506);
			StationRecipeFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, 100682507);
			StationRecipeFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, 100682508);
			StationRecipeFieldUI.NativeMethodInfoPtr_Clicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, 100682509);
			StationRecipeFieldUI.NativeMethodInfoPtr_OptionSelected_Private_Void_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, 100682510);
			StationRecipeFieldUI.NativeMethodInfoPtr_ClearClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, 100682511);
			StationRecipeFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, 100682512);
		}

		// Token: 0x17003031 RID: 12337
		// (get) Token: 0x06009C78 RID: 40056 RVA: 0x0027A48C File Offset: 0x0027868C
		// (set) Token: 0x06009C79 RID: 40057 RVA: 0x0027A4CC File Offset: 0x002786CC
		public unsafe List<StationRecipeField> Fields
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17399, RefRangeEnd = 17400, XrefRangeStart = 17399, XrefRangeEnd = 17400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_StationRecipeField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<StationRecipeField>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_StationRecipeField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009C7A RID: 40058 RVA: 0x0027A510 File Offset: 0x00278710
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 277825, RefRangeEnd = 277826, XrefRangeStart = 277798, XrefRangeEnd = 277825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Bind(List<StationRecipeField> field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_StationRecipeField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C7B RID: 40059 RVA: 0x0027A554 File Offset: 0x00278754
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 277852, RefRangeEnd = 277853, XrefRangeStart = 277826, XrefRangeEnd = 277852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh(StationRecipe newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newVal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C7C RID: 40060 RVA: 0x0027A598 File Offset: 0x00278798
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 277864, RefRangeEnd = 277866, XrefRangeStart = 277853, XrefRangeEnd = 277864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreFieldsUniform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009C7D RID: 40061 RVA: 0x0027A5D4 File Offset: 0x002787D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277866, XrefRangeEnd = 277910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeFieldUI.NativeMethodInfoPtr_Clicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C7E RID: 40062 RVA: 0x0027A608 File Offset: 0x00278808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277910, XrefRangeEnd = 277925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OptionSelected(StationRecipe option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeFieldUI.NativeMethodInfoPtr_OptionSelected_Private_Void_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C7F RID: 40063 RVA: 0x0027A64C File Offset: 0x0027884C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277925, XrefRangeEnd = 277940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeFieldUI.NativeMethodInfoPtr_ClearClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C80 RID: 40064 RVA: 0x0027A680 File Offset: 0x00278880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277940, XrefRangeEnd = 277948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StationRecipeFieldUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C81 RID: 40065 RVA: 0x0004CB33 File Offset: 0x0004AD33
		public StationRecipeFieldUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700302C RID: 12332
		// (get) Token: 0x06009C82 RID: 40066 RVA: 0x0027A6BC File Offset: 0x002788BC
		// (set) Token: 0x06009C83 RID: 40067 RVA: 0x0004CB3C File Offset: 0x0004AD3C
		public unsafe List<StationRecipeField> _Fields_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeFieldUI.NativeFieldInfoPtr__Fields_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StationRecipeField>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeFieldUI.NativeFieldInfoPtr__Fields_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700302D RID: 12333
		// (get) Token: 0x06009C84 RID: 40068 RVA: 0x0027A6EC File Offset: 0x002788EC
		// (set) Token: 0x06009C85 RID: 40069 RVA: 0x0004CB5B File Offset: 0x0004AD5B
		public unsafe StationRecipeEntry RecipeEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeFieldUI.NativeFieldInfoPtr_RecipeEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipeEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeFieldUI.NativeFieldInfoPtr_RecipeEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700302E RID: 12334
		// (get) Token: 0x06009C86 RID: 40070 RVA: 0x0027A71C File Offset: 0x0027891C
		// (set) Token: 0x06009C87 RID: 40071 RVA: 0x0004CB7A File Offset: 0x0004AD7A
		public unsafe GameObject None
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeFieldUI.NativeFieldInfoPtr_None);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeFieldUI.NativeFieldInfoPtr_None), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700302F RID: 12335
		// (get) Token: 0x06009C88 RID: 40072 RVA: 0x0027A74C File Offset: 0x0027894C
		// (set) Token: 0x06009C89 RID: 40073 RVA: 0x0004CB99 File Offset: 0x0004AD99
		public unsafe GameObject Mixed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeFieldUI.NativeFieldInfoPtr_Mixed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeFieldUI.NativeFieldInfoPtr_Mixed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003030 RID: 12336
		// (get) Token: 0x06009C8A RID: 40074 RVA: 0x0027A77C File Offset: 0x0027897C
		// (set) Token: 0x06009C8B RID: 40075 RVA: 0x0004CBB8 File Offset: 0x0004ADB8
		public unsafe GameObject ClearButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeFieldUI.NativeFieldInfoPtr_ClearButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeFieldUI.NativeFieldInfoPtr_ClearButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400691A RID: 26906
		private static readonly IntPtr NativeFieldInfoPtr__Fields_k__BackingField;

		// Token: 0x0400691B RID: 26907
		private static readonly IntPtr NativeFieldInfoPtr_RecipeEntry;

		// Token: 0x0400691C RID: 26908
		private static readonly IntPtr NativeFieldInfoPtr_None;

		// Token: 0x0400691D RID: 26909
		private static readonly IntPtr NativeFieldInfoPtr_Mixed;

		// Token: 0x0400691E RID: 26910
		private static readonly IntPtr NativeFieldInfoPtr_ClearButton;

		// Token: 0x0400691F RID: 26911
		private static readonly IntPtr NativeMethodInfoPtr_get_Fields_Public_get_List_1_StationRecipeField_0;

		// Token: 0x04006920 RID: 26912
		private static readonly IntPtr NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_StationRecipeField_0;

		// Token: 0x04006921 RID: 26913
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Void_List_1_StationRecipeField_0;

		// Token: 0x04006922 RID: 26914
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Private_Void_StationRecipe_0;

		// Token: 0x04006923 RID: 26915
		private static readonly IntPtr NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0;

		// Token: 0x04006924 RID: 26916
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Public_Void_0;

		// Token: 0x04006925 RID: 26917
		private static readonly IntPtr NativeMethodInfoPtr_OptionSelected_Private_Void_StationRecipe_0;

		// Token: 0x04006926 RID: 26918
		private static readonly IntPtr NativeMethodInfoPtr_ClearClicked_Public_Void_0;

		// Token: 0x04006927 RID: 26919
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B90 RID: 2960
		[ObfuscatedName("ScheduleOne.UI.Management.StationRecipeFieldUI+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DC06 RID: 56326 RVA: 0x00340C7C File Offset: 0x0033EE7C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<StationRecipeFieldUI.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipeFieldUI.__c>.NativeClassPtr);
				StationRecipeFieldUI.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeFieldUI.__c>.NativeClassPtr, "<>9");
				StationRecipeFieldUI.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeFieldUI.__c>.NativeClassPtr, "<>9__11_0");
				StationRecipeFieldUI.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeFieldUI.__c>.NativeClassPtr, 100682514);
				StationRecipeFieldUI.__c.NativeMethodInfoPtr__Clicked_b__11_0_Internal_Boolean_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeFieldUI.__c>.NativeClassPtr, 100682515);
			}

			// Token: 0x0600DC07 RID: 56327 RVA: 0x00340CF8 File Offset: 0x0033EEF8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipeFieldUI.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeFieldUI.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC08 RID: 56328 RVA: 0x00340D34 File Offset: 0x0033EF34
			[CallerCount(0)]
			public unsafe bool _Clicked_b__11_0(StationRecipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeFieldUI.__c.NativeMethodInfoPtr__Clicked_b__11_0_Internal_Boolean_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DC09 RID: 56329 RVA: 0x0006B31F File Offset: 0x0006951F
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004437 RID: 17463
			// (get) Token: 0x0600DC0A RID: 56330 RVA: 0x00340D84 File Offset: 0x0033EF84
			// (set) Token: 0x0600DC0B RID: 56331 RVA: 0x0006B328 File Offset: 0x00069528
			public unsafe static StationRecipeFieldUI.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StationRecipeFieldUI.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipeFieldUI.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StationRecipeFieldUI.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004438 RID: 17464
			// (get) Token: 0x0600DC0C RID: 56332 RVA: 0x00340DAC File Offset: 0x0033EFAC
			// (set) Token: 0x0600DC0D RID: 56333 RVA: 0x0006B33A File Offset: 0x0006953A
			public unsafe static Func<StationRecipe, bool> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StationRecipeFieldUI.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<StationRecipe, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StationRecipeFieldUI.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009381 RID: 37761
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009382 RID: 37762
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x04009383 RID: 37763
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009384 RID: 37764
			private static readonly IntPtr NativeMethodInfoPtr__Clicked_b__11_0_Internal_Boolean_StationRecipe_0;
		}
	}
}
