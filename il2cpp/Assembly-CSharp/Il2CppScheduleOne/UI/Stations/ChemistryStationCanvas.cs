using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.StationFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Stations
{
	// Token: 0x0200067D RID: 1661
	public class ChemistryStationCanvas : Singleton<ChemistryStationCanvas>
	{
		// Token: 0x06009456 RID: 37974 RVA: 0x00261D90 File Offset: 0x0025FF90
		// Note: this type is marked as 'beforefieldinit'.
		static ChemistryStationCanvas()
		{
			Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Stations", "ChemistryStationCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr);
			ChemistryStationCanvas.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "<isOpen>k__BackingField");
			ChemistryStationCanvas.NativeFieldInfoPtr__ChemistryStation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "<ChemistryStation>k__BackingField");
			ChemistryStationCanvas.NativeFieldInfoPtr_Recipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "Recipes");
			ChemistryStationCanvas.NativeFieldInfoPtr_RecipeEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "RecipeEntryPrefab");
			ChemistryStationCanvas.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "Canvas");
			ChemistryStationCanvas.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "Container");
			ChemistryStationCanvas.NativeFieldInfoPtr_InputSlotsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "InputSlotsContainer");
			ChemistryStationCanvas.NativeFieldInfoPtr_InputSlotUIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "InputSlotUIs");
			ChemistryStationCanvas.NativeFieldInfoPtr_OutputSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "OutputSlotUI");
			ChemistryStationCanvas.NativeFieldInfoPtr_RecipeSelectionContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "RecipeSelectionContainer");
			ChemistryStationCanvas.NativeFieldInfoPtr_InstructionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "InstructionLabel");
			ChemistryStationCanvas.NativeFieldInfoPtr_BeginButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "BeginButton");
			ChemistryStationCanvas.NativeFieldInfoPtr_SelectionIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "SelectionIndicator");
			ChemistryStationCanvas.NativeFieldInfoPtr_RecipeContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "RecipeContainer");
			ChemistryStationCanvas.NativeFieldInfoPtr_CookingInProgressContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "CookingInProgressContainer");
			ChemistryStationCanvas.NativeFieldInfoPtr_InProgressRecipeEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "InProgressRecipeEntry");
			ChemistryStationCanvas.NativeFieldInfoPtr_InProgressLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "InProgressLabel");
			ChemistryStationCanvas.NativeFieldInfoPtr_ErrorLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "ErrorLabel");
			ChemistryStationCanvas.NativeFieldInfoPtr_recipeEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "recipeEntries");
			ChemistryStationCanvas.NativeFieldInfoPtr_selectedRecipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "selectedRecipe");
			ChemistryStationCanvas.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100681668);
			ChemistryStationCanvas.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100681669);
			ChemistryStationCanvas.NativeMethodInfoPtr_get_ChemistryStation_Public_get_ChemistryStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100681670);
			ChemistryStationCanvas.NativeMethodInfoPtr_set_ChemistryStation_Protected_set_Void_ChemistryStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100681671);
			ChemistryStationCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100681672);
			ChemistryStationCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100681673);
			ChemistryStationCanvas.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100681674);
			ChemistryStationCanvas.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100681675);
			ChemistryStationCanvas.NativeMethodInfoPtr_UpdateUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100681676);
			ChemistryStationCanvas.NativeMethodInfoPtr_UpdateInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100681677);
			ChemistryStationCanvas.NativeMethodInfoPtr_Open_Public_Void_ChemistryStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100681678);
			ChemistryStationCanvas.NativeMethodInfoPtr_Close_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100681679);
			ChemistryStationCanvas.NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100681680);
			ChemistryStationCanvas.NativeMethodInfoPtr_StationSlotsChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100681681);
			ChemistryStationCanvas.NativeMethodInfoPtr_SortRecipes_Private_Void_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100681682);
			ChemistryStationCanvas.NativeMethodInfoPtr_SetSelectedRecipe_Private_Void_StationRecipeEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100681683);
			ChemistryStationCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100681684);
		}

		// Token: 0x17002D97 RID: 11671
		// (get) Token: 0x06009457 RID: 37975 RVA: 0x002620A4 File Offset: 0x002602A4
		// (set) Token: 0x06009458 RID: 37976 RVA: 0x002620E0 File Offset: 0x002602E0
		public unsafe bool isOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationCanvas.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 37992, RefRangeEnd = 38015, XrefRangeStart = 37992, XrefRangeEnd = 38015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationCanvas.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002D98 RID: 11672
		// (get) Token: 0x06009459 RID: 37977 RVA: 0x00262120 File Offset: 0x00260320
		// (set) Token: 0x0600945A RID: 37978 RVA: 0x00262160 File Offset: 0x00260360
		public unsafe ChemistryStation ChemistryStation
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19644, RefRangeEnd = 19658, XrefRangeStart = 19644, XrefRangeEnd = 19658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationCanvas.NativeMethodInfoPtr_get_ChemistryStation_Public_get_ChemistryStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ChemistryStation>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 19659, RefRangeEnd = 19660, XrefRangeStart = 19659, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationCanvas.NativeMethodInfoPtr_set_ChemistryStation_Protected_set_Void_ChemistryStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600945B RID: 37979 RVA: 0x002621A4 File Offset: 0x002603A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266917, XrefRangeEnd = 266947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChemistryStationCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600945C RID: 37980 RVA: 0x002621E0 File Offset: 0x002603E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266947, XrefRangeEnd = 266951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChemistryStationCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600945D RID: 37981 RVA: 0x0026221C File Offset: 0x0026041C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266951, XrefRangeEnd = 266980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChemistryStationCanvas.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600945E RID: 37982 RVA: 0x00262258 File Offset: 0x00260458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266980, XrefRangeEnd = 266987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationCanvas.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600945F RID: 37983 RVA: 0x0026228C File Offset: 0x0026048C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 267002, RefRangeEnd = 267004, XrefRangeStart = 266987, XrefRangeEnd = 267002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationCanvas.NativeMethodInfoPtr_UpdateUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009460 RID: 37984 RVA: 0x002622C0 File Offset: 0x002604C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 267038, RefRangeEnd = 267039, XrefRangeStart = 267004, XrefRangeEnd = 267038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationCanvas.NativeMethodInfoPtr_UpdateInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009461 RID: 37985 RVA: 0x002622F4 File Offset: 0x002604F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 267135, RefRangeEnd = 267137, XrefRangeStart = 267039, XrefRangeEnd = 267135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(ChemistryStation station)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(station);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationCanvas.NativeMethodInfoPtr_Open_Public_Void_ChemistryStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009462 RID: 37986 RVA: 0x00262338 File Offset: 0x00260538
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 267180, RefRangeEnd = 267184, XrefRangeStart = 267137, XrefRangeEnd = 267180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(bool removeUI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref removeUI;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationCanvas.NativeMethodInfoPtr_Close_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009463 RID: 37987 RVA: 0x00262378 File Offset: 0x00260578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267184, XrefRangeEnd = 267195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationCanvas.NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009464 RID: 37988 RVA: 0x002623AC File Offset: 0x002605AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267195, XrefRangeEnd = 267214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StationSlotsChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationCanvas.NativeMethodInfoPtr_StationSlotsChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009465 RID: 37989 RVA: 0x002623E0 File Offset: 0x002605E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 267255, RefRangeEnd = 267257, XrefRangeStart = 267214, XrefRangeEnd = 267255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortRecipes(List<ItemInstance> ingredients)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ingredients);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationCanvas.NativeMethodInfoPtr_SortRecipes_Private_Void_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009466 RID: 37990 RVA: 0x00262424 File Offset: 0x00260624
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 267270, RefRangeEnd = 267272, XrefRangeStart = 267257, XrefRangeEnd = 267270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelectedRecipe(StationRecipeEntry entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationCanvas.NativeMethodInfoPtr_SetSelectedRecipe_Private_Void_StationRecipeEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009467 RID: 37991 RVA: 0x00262468 File Offset: 0x00260668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267272, XrefRangeEnd = 267289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChemistryStationCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009468 RID: 37992 RVA: 0x00047FB0 File Offset: 0x000461B0
		public ChemistryStationCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D83 RID: 11651
		// (get) Token: 0x06009469 RID: 37993 RVA: 0x002624A4 File Offset: 0x002606A4
		// (set) Token: 0x0600946A RID: 37994 RVA: 0x00047FB9 File Offset: 0x000461B9
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002D84 RID: 11652
		// (get) Token: 0x0600946B RID: 37995 RVA: 0x002624CC File Offset: 0x002606CC
		// (set) Token: 0x0600946C RID: 37996 RVA: 0x00047FD4 File Offset: 0x000461D4
		public unsafe ChemistryStation _ChemistryStation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr__ChemistryStation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChemistryStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr__ChemistryStation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D85 RID: 11653
		// (get) Token: 0x0600946D RID: 37997 RVA: 0x002624FC File Offset: 0x002606FC
		// (set) Token: 0x0600946E RID: 37998 RVA: 0x00047FF3 File Offset: 0x000461F3
		public unsafe List<StationRecipe> Recipes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_Recipes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StationRecipe>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_Recipes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D86 RID: 11654
		// (get) Token: 0x0600946F RID: 37999 RVA: 0x0026252C File Offset: 0x0026072C
		// (set) Token: 0x06009470 RID: 38000 RVA: 0x00048012 File Offset: 0x00046212
		public unsafe StationRecipeEntry RecipeEntryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_RecipeEntryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipeEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_RecipeEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D87 RID: 11655
		// (get) Token: 0x06009471 RID: 38001 RVA: 0x0026255C File Offset: 0x0026075C
		// (set) Token: 0x06009472 RID: 38002 RVA: 0x00048031 File Offset: 0x00046231
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D88 RID: 11656
		// (get) Token: 0x06009473 RID: 38003 RVA: 0x0026258C File Offset: 0x0026078C
		// (set) Token: 0x06009474 RID: 38004 RVA: 0x00048050 File Offset: 0x00046250
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D89 RID: 11657
		// (get) Token: 0x06009475 RID: 38005 RVA: 0x002625BC File Offset: 0x002607BC
		// (set) Token: 0x06009476 RID: 38006 RVA: 0x0004806F File Offset: 0x0004626F
		public unsafe RectTransform InputSlotsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_InputSlotsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_InputSlotsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D8A RID: 11658
		// (get) Token: 0x06009477 RID: 38007 RVA: 0x002625EC File Offset: 0x002607EC
		// (set) Token: 0x06009478 RID: 38008 RVA: 0x0004808E File Offset: 0x0004628E
		public unsafe Il2CppReferenceArray<ItemSlotUI> InputSlotUIs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_InputSlotUIs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemSlotUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_InputSlotUIs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D8B RID: 11659
		// (get) Token: 0x06009479 RID: 38009 RVA: 0x0026261C File Offset: 0x0026081C
		// (set) Token: 0x0600947A RID: 38010 RVA: 0x000480AD File Offset: 0x000462AD
		public unsafe ItemSlotUI OutputSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_OutputSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_OutputSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D8C RID: 11660
		// (get) Token: 0x0600947B RID: 38011 RVA: 0x0026264C File Offset: 0x0026084C
		// (set) Token: 0x0600947C RID: 38012 RVA: 0x000480CC File Offset: 0x000462CC
		public unsafe RectTransform RecipeSelectionContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_RecipeSelectionContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_RecipeSelectionContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D8D RID: 11661
		// (get) Token: 0x0600947D RID: 38013 RVA: 0x0026267C File Offset: 0x0026087C
		// (set) Token: 0x0600947E RID: 38014 RVA: 0x000480EB File Offset: 0x000462EB
		public unsafe TextMeshProUGUI InstructionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_InstructionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_InstructionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D8E RID: 11662
		// (get) Token: 0x0600947F RID: 38015 RVA: 0x002626AC File Offset: 0x002608AC
		// (set) Token: 0x06009480 RID: 38016 RVA: 0x0004810A File Offset: 0x0004630A
		public unsafe Button BeginButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_BeginButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_BeginButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D8F RID: 11663
		// (get) Token: 0x06009481 RID: 38017 RVA: 0x002626DC File Offset: 0x002608DC
		// (set) Token: 0x06009482 RID: 38018 RVA: 0x00048129 File Offset: 0x00046329
		public unsafe RectTransform SelectionIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_SelectionIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_SelectionIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D90 RID: 11664
		// (get) Token: 0x06009483 RID: 38019 RVA: 0x0026270C File Offset: 0x0026090C
		// (set) Token: 0x06009484 RID: 38020 RVA: 0x00048148 File Offset: 0x00046348
		public unsafe RectTransform RecipeContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_RecipeContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_RecipeContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D91 RID: 11665
		// (get) Token: 0x06009485 RID: 38021 RVA: 0x0026273C File Offset: 0x0026093C
		// (set) Token: 0x06009486 RID: 38022 RVA: 0x00048167 File Offset: 0x00046367
		public unsafe RectTransform CookingInProgressContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_CookingInProgressContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_CookingInProgressContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D92 RID: 11666
		// (get) Token: 0x06009487 RID: 38023 RVA: 0x0026276C File Offset: 0x0026096C
		// (set) Token: 0x06009488 RID: 38024 RVA: 0x00048186 File Offset: 0x00046386
		public unsafe StationRecipeEntry InProgressRecipeEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_InProgressRecipeEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipeEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_InProgressRecipeEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D93 RID: 11667
		// (get) Token: 0x06009489 RID: 38025 RVA: 0x0026279C File Offset: 0x0026099C
		// (set) Token: 0x0600948A RID: 38026 RVA: 0x000481A5 File Offset: 0x000463A5
		public unsafe TextMeshProUGUI InProgressLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_InProgressLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_InProgressLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D94 RID: 11668
		// (get) Token: 0x0600948B RID: 38027 RVA: 0x002627CC File Offset: 0x002609CC
		// (set) Token: 0x0600948C RID: 38028 RVA: 0x000481C4 File Offset: 0x000463C4
		public unsafe TextMeshProUGUI ErrorLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_ErrorLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_ErrorLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D95 RID: 11669
		// (get) Token: 0x0600948D RID: 38029 RVA: 0x002627FC File Offset: 0x002609FC
		// (set) Token: 0x0600948E RID: 38030 RVA: 0x000481E3 File Offset: 0x000463E3
		public unsafe List<StationRecipeEntry> recipeEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_recipeEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StationRecipeEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_recipeEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D96 RID: 11670
		// (get) Token: 0x0600948F RID: 38031 RVA: 0x0026282C File Offset: 0x00260A2C
		// (set) Token: 0x06009490 RID: 38032 RVA: 0x00048202 File Offset: 0x00046402
		public unsafe StationRecipeEntry selectedRecipe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_selectedRecipe);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipeEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_selectedRecipe), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006413 RID: 25619
		private static readonly IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x04006414 RID: 25620
		private static readonly IntPtr NativeFieldInfoPtr__ChemistryStation_k__BackingField;

		// Token: 0x04006415 RID: 25621
		private static readonly IntPtr NativeFieldInfoPtr_Recipes;

		// Token: 0x04006416 RID: 25622
		private static readonly IntPtr NativeFieldInfoPtr_RecipeEntryPrefab;

		// Token: 0x04006417 RID: 25623
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04006418 RID: 25624
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006419 RID: 25625
		private static readonly IntPtr NativeFieldInfoPtr_InputSlotsContainer;

		// Token: 0x0400641A RID: 25626
		private static readonly IntPtr NativeFieldInfoPtr_InputSlotUIs;

		// Token: 0x0400641B RID: 25627
		private static readonly IntPtr NativeFieldInfoPtr_OutputSlotUI;

		// Token: 0x0400641C RID: 25628
		private static readonly IntPtr NativeFieldInfoPtr_RecipeSelectionContainer;

		// Token: 0x0400641D RID: 25629
		private static readonly IntPtr NativeFieldInfoPtr_InstructionLabel;

		// Token: 0x0400641E RID: 25630
		private static readonly IntPtr NativeFieldInfoPtr_BeginButton;

		// Token: 0x0400641F RID: 25631
		private static readonly IntPtr NativeFieldInfoPtr_SelectionIndicator;

		// Token: 0x04006420 RID: 25632
		private static readonly IntPtr NativeFieldInfoPtr_RecipeContainer;

		// Token: 0x04006421 RID: 25633
		private static readonly IntPtr NativeFieldInfoPtr_CookingInProgressContainer;

		// Token: 0x04006422 RID: 25634
		private static readonly IntPtr NativeFieldInfoPtr_InProgressRecipeEntry;

		// Token: 0x04006423 RID: 25635
		private static readonly IntPtr NativeFieldInfoPtr_InProgressLabel;

		// Token: 0x04006424 RID: 25636
		private static readonly IntPtr NativeFieldInfoPtr_ErrorLabel;

		// Token: 0x04006425 RID: 25637
		private static readonly IntPtr NativeFieldInfoPtr_recipeEntries;

		// Token: 0x04006426 RID: 25638
		private static readonly IntPtr NativeFieldInfoPtr_selectedRecipe;

		// Token: 0x04006427 RID: 25639
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x04006428 RID: 25640
		private static readonly IntPtr NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04006429 RID: 25641
		private static readonly IntPtr NativeMethodInfoPtr_get_ChemistryStation_Public_get_ChemistryStation_0;

		// Token: 0x0400642A RID: 25642
		private static readonly IntPtr NativeMethodInfoPtr_set_ChemistryStation_Protected_set_Void_ChemistryStation_0;

		// Token: 0x0400642B RID: 25643
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400642C RID: 25644
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400642D RID: 25645
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x0400642E RID: 25646
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x0400642F RID: 25647
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Private_Void_0;

		// Token: 0x04006430 RID: 25648
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInput_Private_Void_0;

		// Token: 0x04006431 RID: 25649
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_ChemistryStation_0;

		// Token: 0x04006432 RID: 25650
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_Boolean_0;

		// Token: 0x04006433 RID: 25651
		private static readonly IntPtr NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0;

		// Token: 0x04006434 RID: 25652
		private static readonly IntPtr NativeMethodInfoPtr_StationSlotsChanged_Private_Void_0;

		// Token: 0x04006435 RID: 25653
		private static readonly IntPtr NativeMethodInfoPtr_SortRecipes_Private_Void_List_1_ItemInstance_0;

		// Token: 0x04006436 RID: 25654
		private static readonly IntPtr NativeMethodInfoPtr_SetSelectedRecipe_Private_Void_StationRecipeEntry_0;

		// Token: 0x04006437 RID: 25655
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B5A RID: 2906
		[ObfuscatedName("ScheduleOne.UI.Stations.ChemistryStationCanvas+<>c__DisplayClass36_0")]
		public sealed class __c__DisplayClass36_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DA2F RID: 55855 RVA: 0x0033BB40 File Offset: 0x00339D40
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass36_0()
			{
				Il2CppClassPointerStore<ChemistryStationCanvas.__c__DisplayClass36_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "<>c__DisplayClass36_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChemistryStationCanvas.__c__DisplayClass36_0>.NativeClassPtr);
				ChemistryStationCanvas.__c__DisplayClass36_0.NativeFieldInfoPtr_recipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas.__c__DisplayClass36_0>.NativeClassPtr, "recipes");
				ChemistryStationCanvas.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas.__c__DisplayClass36_0>.NativeClassPtr, 100681685);
				ChemistryStationCanvas.__c__DisplayClass36_0.NativeMethodInfoPtr__SortRecipes_b__0_Internal_Int32_StationRecipeEntry_StationRecipeEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas.__c__DisplayClass36_0>.NativeClassPtr, 100681686);
			}

			// Token: 0x0600DA30 RID: 55856 RVA: 0x0033BBA8 File Offset: 0x00339DA8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass36_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistryStationCanvas.__c__DisplayClass36_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationCanvas.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA31 RID: 55857 RVA: 0x0033BBE4 File Offset: 0x00339DE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266911, XrefRangeEnd = 266917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _SortRecipes_b__0(StationRecipeEntry a, StationRecipeEntry b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationCanvas.__c__DisplayClass36_0.NativeMethodInfoPtr__SortRecipes_b__0_Internal_Int32_StationRecipeEntry_StationRecipeEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DA32 RID: 55858 RVA: 0x0006A41A File Offset: 0x0006861A
			public __c__DisplayClass36_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043B2 RID: 17330
			// (get) Token: 0x0600DA33 RID: 55859 RVA: 0x0033BC44 File Offset: 0x00339E44
			// (set) Token: 0x0600DA34 RID: 55860 RVA: 0x0006A423 File Offset: 0x00068623
			public unsafe Dictionary<StationRecipeEntry, float> recipes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.__c__DisplayClass36_0.NativeFieldInfoPtr_recipes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<StationRecipeEntry, float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.__c__DisplayClass36_0.NativeFieldInfoPtr_recipes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009280 RID: 37504
			private static readonly IntPtr NativeFieldInfoPtr_recipes;

			// Token: 0x04009281 RID: 37505
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009282 RID: 37506
			private static readonly IntPtr NativeMethodInfoPtr__SortRecipes_b__0_Internal_Int32_StationRecipeEntry_StationRecipeEntry_0;
		}
	}
}
