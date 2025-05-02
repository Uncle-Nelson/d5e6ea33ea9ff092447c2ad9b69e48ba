using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.StationFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006D3 RID: 1747
	public class RecipeSelector : ClipboardScreen
	{
		// Token: 0x06009D2E RID: 40238 RVA: 0x0027C7B0 File Offset: 0x0027A9B0
		// Note: this type is marked as 'beforefieldinit'.
		static RecipeSelector()
		{
			Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "RecipeSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr);
			RecipeSelector.NativeFieldInfoPtr_OptionContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, "OptionContainer");
			RecipeSelector.NativeFieldInfoPtr_TitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, "TitleLabel");
			RecipeSelector.NativeFieldInfoPtr_OptionPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, "OptionPrefab");
			RecipeSelector.NativeFieldInfoPtr_EmptyOptionSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, "EmptyOptionSprite");
			RecipeSelector.NativeFieldInfoPtr_lerpRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, "lerpRoutine");
			RecipeSelector.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, "options");
			RecipeSelector.NativeFieldInfoPtr_selectedOption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, "selectedOption");
			RecipeSelector.NativeFieldInfoPtr_optionButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, "optionButtons");
			RecipeSelector.NativeFieldInfoPtr_optionCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, "optionCallback");
			RecipeSelector.NativeMethodInfoPtr_Initialize_Public_Void_String_List_1_StationRecipe_StationRecipe_Action_1_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, 100682586);
			RecipeSelector.NativeMethodInfoPtr_Open_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, 100682587);
			RecipeSelector.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, 100682588);
			RecipeSelector.NativeMethodInfoPtr_ButtonClicked_Private_Void_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, 100682589);
			RecipeSelector.NativeMethodInfoPtr_CreateOptions_Private_Void_List_1_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, 100682590);
			RecipeSelector.NativeMethodInfoPtr_DeleteOptions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, 100682591);
			RecipeSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, 100682592);
		}

		// Token: 0x06009D2F RID: 40239 RVA: 0x0027C920 File Offset: 0x0027AB20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279237, RefRangeEnd = 279238, XrefRangeStart = 279211, XrefRangeEnd = 279237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(string selectionTitle, List<StationRecipe> _options, StationRecipe _selectedOption = null, Action<StationRecipe> _optionCallback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(selectionTitle);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_options);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_selectedOption);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_optionCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecipeSelector.NativeMethodInfoPtr_Initialize_Public_Void_String_List_1_StationRecipe_StationRecipe_Action_1_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D30 RID: 40240 RVA: 0x0027C99C File Offset: 0x0027AB9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279238, XrefRangeEnd = 279258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RecipeSelector.NativeMethodInfoPtr_Open_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D31 RID: 40241 RVA: 0x0027C9D8 File Offset: 0x0027ABD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279258, XrefRangeEnd = 279270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RecipeSelector.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D32 RID: 40242 RVA: 0x0027CA14 File Offset: 0x0027AC14
		[CallerCount(0)]
		public unsafe void ButtonClicked(StationRecipe option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecipeSelector.NativeMethodInfoPtr_ButtonClicked_Private_Void_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D33 RID: 40243 RVA: 0x0027CA58 File Offset: 0x0027AC58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279335, RefRangeEnd = 279336, XrefRangeStart = 279270, XrefRangeEnd = 279335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateOptions(List<StationRecipe> options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecipeSelector.NativeMethodInfoPtr_CreateOptions_Private_Void_List_1_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D34 RID: 40244 RVA: 0x0027CA9C File Offset: 0x0027AC9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279336, XrefRangeEnd = 279348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecipeSelector.NativeMethodInfoPtr_DeleteOptions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D35 RID: 40245 RVA: 0x0027CAD0 File Offset: 0x0027ACD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279348, XrefRangeEnd = 279363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RecipeSelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecipeSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D36 RID: 40246 RVA: 0x0004D172 File Offset: 0x0004B372
		public RecipeSelector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003067 RID: 12391
		// (get) Token: 0x06009D37 RID: 40247 RVA: 0x0027CB0C File Offset: 0x0027AD0C
		// (set) Token: 0x06009D38 RID: 40248 RVA: 0x0004D17B File Offset: 0x0004B37B
		public unsafe RectTransform OptionContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_OptionContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_OptionContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003068 RID: 12392
		// (get) Token: 0x06009D39 RID: 40249 RVA: 0x0027CB3C File Offset: 0x0027AD3C
		// (set) Token: 0x06009D3A RID: 40250 RVA: 0x0004D19A File Offset: 0x0004B39A
		public unsafe TextMeshProUGUI TitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_TitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_TitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003069 RID: 12393
		// (get) Token: 0x06009D3B RID: 40251 RVA: 0x0027CB6C File Offset: 0x0027AD6C
		// (set) Token: 0x06009D3C RID: 40252 RVA: 0x0004D1B9 File Offset: 0x0004B3B9
		public unsafe GameObject OptionPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_OptionPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_OptionPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700306A RID: 12394
		// (get) Token: 0x06009D3D RID: 40253 RVA: 0x0027CB9C File Offset: 0x0027AD9C
		// (set) Token: 0x06009D3E RID: 40254 RVA: 0x0004D1D8 File Offset: 0x0004B3D8
		public unsafe Sprite EmptyOptionSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_EmptyOptionSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_EmptyOptionSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700306B RID: 12395
		// (get) Token: 0x06009D3F RID: 40255 RVA: 0x0027CBCC File Offset: 0x0027ADCC
		// (set) Token: 0x06009D40 RID: 40256 RVA: 0x0004D1F7 File Offset: 0x0004B3F7
		public new unsafe Coroutine lerpRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_lerpRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_lerpRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700306C RID: 12396
		// (get) Token: 0x06009D41 RID: 40257 RVA: 0x0027CBFC File Offset: 0x0027ADFC
		// (set) Token: 0x06009D42 RID: 40258 RVA: 0x0004D216 File Offset: 0x0004B416
		public unsafe List<StationRecipe> options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StationRecipe>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700306D RID: 12397
		// (get) Token: 0x06009D43 RID: 40259 RVA: 0x0027CC2C File Offset: 0x0027AE2C
		// (set) Token: 0x06009D44 RID: 40260 RVA: 0x0004D235 File Offset: 0x0004B435
		public unsafe StationRecipe selectedOption
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_selectedOption);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_selectedOption), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700306E RID: 12398
		// (get) Token: 0x06009D45 RID: 40261 RVA: 0x0027CC5C File Offset: 0x0027AE5C
		// (set) Token: 0x06009D46 RID: 40262 RVA: 0x0004D254 File Offset: 0x0004B454
		public unsafe List<RectTransform> optionButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_optionButtons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_optionButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700306F RID: 12399
		// (get) Token: 0x06009D47 RID: 40263 RVA: 0x0027CC8C File Offset: 0x0027AE8C
		// (set) Token: 0x06009D48 RID: 40264 RVA: 0x0004D273 File Offset: 0x0004B473
		public unsafe Action<StationRecipe> optionCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_optionCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<StationRecipe>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_optionCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006991 RID: 27025
		private static readonly IntPtr NativeFieldInfoPtr_OptionContainer;

		// Token: 0x04006992 RID: 27026
		private static readonly IntPtr NativeFieldInfoPtr_TitleLabel;

		// Token: 0x04006993 RID: 27027
		private static readonly IntPtr NativeFieldInfoPtr_OptionPrefab;

		// Token: 0x04006994 RID: 27028
		private static readonly IntPtr NativeFieldInfoPtr_EmptyOptionSprite;

		// Token: 0x04006995 RID: 27029
		private static readonly IntPtr NativeFieldInfoPtr_lerpRoutine;

		// Token: 0x04006996 RID: 27030
		private static readonly IntPtr NativeFieldInfoPtr_options;

		// Token: 0x04006997 RID: 27031
		private static readonly IntPtr NativeFieldInfoPtr_selectedOption;

		// Token: 0x04006998 RID: 27032
		private static readonly IntPtr NativeFieldInfoPtr_optionButtons;

		// Token: 0x04006999 RID: 27033
		private static readonly IntPtr NativeFieldInfoPtr_optionCallback;

		// Token: 0x0400699A RID: 27034
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_String_List_1_StationRecipe_StationRecipe_Action_1_StationRecipe_0;

		// Token: 0x0400699B RID: 27035
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_Void_0;

		// Token: 0x0400699C RID: 27036
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x0400699D RID: 27037
		private static readonly IntPtr NativeMethodInfoPtr_ButtonClicked_Private_Void_StationRecipe_0;

		// Token: 0x0400699E RID: 27038
		private static readonly IntPtr NativeMethodInfoPtr_CreateOptions_Private_Void_List_1_StationRecipe_0;

		// Token: 0x0400699F RID: 27039
		private static readonly IntPtr NativeMethodInfoPtr_DeleteOptions_Private_Void_0;

		// Token: 0x040069A0 RID: 27040
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B96 RID: 2966
		[ObfuscatedName("ScheduleOne.UI.Management.RecipeSelector+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DC35 RID: 56373 RVA: 0x003415D4 File Offset: 0x0033F7D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RecipeSelector.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecipeSelector.__c>.NativeClassPtr);
				RecipeSelector.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector.__c>.NativeClassPtr, "<>9");
				RecipeSelector.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector.__c>.NativeClassPtr, "<>9__13_0");
				RecipeSelector.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeSelector.__c>.NativeClassPtr, 100682594);
				RecipeSelector.__c.NativeMethodInfoPtr__CreateOptions_b__13_0_Internal_Int32_StationRecipe_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeSelector.__c>.NativeClassPtr, 100682595);
			}

			// Token: 0x0600DC36 RID: 56374 RVA: 0x00341650 File Offset: 0x0033F850
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RecipeSelector.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecipeSelector.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC37 RID: 56375 RVA: 0x0034168C File Offset: 0x0033F88C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279208, XrefRangeEnd = 279210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _CreateOptions_b__13_0(StationRecipe a, StationRecipe b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecipeSelector.__c.NativeMethodInfoPtr__CreateOptions_b__13_0_Internal_Int32_StationRecipe_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DC38 RID: 56376 RVA: 0x0006B457 File Offset: 0x00069657
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004441 RID: 17473
			// (get) Token: 0x0600DC39 RID: 56377 RVA: 0x003416EC File Offset: 0x0033F8EC
			// (set) Token: 0x0600DC3A RID: 56378 RVA: 0x0006B460 File Offset: 0x00069660
			public unsafe static RecipeSelector.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RecipeSelector.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RecipeSelector.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RecipeSelector.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004442 RID: 17474
			// (get) Token: 0x0600DC3B RID: 56379 RVA: 0x00341714 File Offset: 0x0033F914
			// (set) Token: 0x0600DC3C RID: 56380 RVA: 0x0006B472 File Offset: 0x00069672
			public unsafe static Comparison<StationRecipe> __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RecipeSelector.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<StationRecipe>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RecipeSelector.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400939A RID: 37786
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400939B RID: 37787
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x0400939C RID: 37788
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400939D RID: 37789
			private static readonly IntPtr NativeMethodInfoPtr__CreateOptions_b__13_0_Internal_Int32_StationRecipe_StationRecipe_0;
		}

		// Token: 0x02000B97 RID: 2967
		[ObfuscatedName("ScheduleOne.UI.Management.RecipeSelector+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DC3D RID: 56381 RVA: 0x0034173C File Offset: 0x0033F93C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<RecipeSelector.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecipeSelector.__c__DisplayClass13_0>.NativeClassPtr);
				RecipeSelector.__c__DisplayClass13_0.NativeFieldInfoPtr_opt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector.__c__DisplayClass13_0>.NativeClassPtr, "opt");
				RecipeSelector.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector.__c__DisplayClass13_0>.NativeClassPtr, "<>4__this");
				RecipeSelector.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeSelector.__c__DisplayClass13_0>.NativeClassPtr, 100682596);
				RecipeSelector.__c__DisplayClass13_0.NativeMethodInfoPtr__CreateOptions_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeSelector.__c__DisplayClass13_0>.NativeClassPtr, 100682597);
			}

			// Token: 0x0600DC3E RID: 56382 RVA: 0x003417B8 File Offset: 0x0033F9B8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RecipeSelector.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecipeSelector.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC3F RID: 56383 RVA: 0x003417F4 File Offset: 0x0033F9F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279210, XrefRangeEnd = 279211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateOptions_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecipeSelector.__c__DisplayClass13_0.NativeMethodInfoPtr__CreateOptions_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC40 RID: 56384 RVA: 0x0006B484 File Offset: 0x00069684
			public __c__DisplayClass13_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004443 RID: 17475
			// (get) Token: 0x0600DC41 RID: 56385 RVA: 0x00341828 File Offset: 0x0033FA28
			// (set) Token: 0x0600DC42 RID: 56386 RVA: 0x0006B48D File Offset: 0x0006968D
			public unsafe StationRecipe opt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.__c__DisplayClass13_0.NativeFieldInfoPtr_opt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.__c__DisplayClass13_0.NativeFieldInfoPtr_opt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004444 RID: 17476
			// (get) Token: 0x0600DC43 RID: 56387 RVA: 0x00341858 File Offset: 0x0033FA58
			// (set) Token: 0x0600DC44 RID: 56388 RVA: 0x0006B4AC File Offset: 0x000696AC
			public unsafe RecipeSelector __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RecipeSelector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400939E RID: 37790
			private static readonly IntPtr NativeFieldInfoPtr_opt;

			// Token: 0x0400939F RID: 37791
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040093A0 RID: 37792
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040093A1 RID: 37793
			private static readonly IntPtr NativeMethodInfoPtr__CreateOptions_b__1_Internal_Void_0;
		}
	}
}
