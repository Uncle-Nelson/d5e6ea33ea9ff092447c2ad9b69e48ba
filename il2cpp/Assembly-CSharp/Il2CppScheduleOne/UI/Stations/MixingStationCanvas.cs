using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.Product;
using Il2CppScheduleOne.Properties;
using Il2CppScheduleOne.StationFramework;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Stations
{
	// Token: 0x02000681 RID: 1665
	public class MixingStationCanvas : Singleton<MixingStationCanvas>
	{
		// Token: 0x06009506 RID: 38150 RVA: 0x00263E74 File Offset: 0x00262074
		// Note: this type is marked as 'beforefieldinit'.
		static MixingStationCanvas()
		{
			Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Stations", "MixingStationCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr);
			MixingStationCanvas.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "<isOpen>k__BackingField");
			MixingStationCanvas.NativeFieldInfoPtr__MixingStation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "<MixingStation>k__BackingField");
			MixingStationCanvas.NativeFieldInfoPtr_RecipeEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "RecipeEntryPrefab");
			MixingStationCanvas.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "Canvas");
			MixingStationCanvas.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "Container");
			MixingStationCanvas.NativeFieldInfoPtr_ProductSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "ProductSlotUI");
			MixingStationCanvas.NativeFieldInfoPtr_ProductPropertiesLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "ProductPropertiesLabel");
			MixingStationCanvas.NativeFieldInfoPtr_IngredientSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "IngredientSlotUI");
			MixingStationCanvas.NativeFieldInfoPtr_IngredientProblemLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "IngredientProblemLabel");
			MixingStationCanvas.NativeFieldInfoPtr_PreviewSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "PreviewSlotUI");
			MixingStationCanvas.NativeFieldInfoPtr_PreviewIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "PreviewIcon");
			MixingStationCanvas.NativeFieldInfoPtr_PreviewLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "PreviewLabel");
			MixingStationCanvas.NativeFieldInfoPtr_UnknownOutputIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "UnknownOutputIcon");
			MixingStationCanvas.NativeFieldInfoPtr_PreviewPropertiesLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "PreviewPropertiesLabel");
			MixingStationCanvas.NativeFieldInfoPtr_OutputSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "OutputSlotUI");
			MixingStationCanvas.NativeFieldInfoPtr_InstructionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "InstructionLabel");
			MixingStationCanvas.NativeFieldInfoPtr_TitleContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "TitleContainer");
			MixingStationCanvas.NativeFieldInfoPtr_MainContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "MainContainer");
			MixingStationCanvas.NativeFieldInfoPtr_BeginButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "BeginButton");
			MixingStationCanvas.NativeFieldInfoPtr_ProductHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "ProductHint");
			MixingStationCanvas.NativeFieldInfoPtr_MixerHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "MixerHint");
			MixingStationCanvas.NativeFieldInfoPtr_selectedRecipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "selectedRecipe");
			MixingStationCanvas.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681734);
			MixingStationCanvas.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681735);
			MixingStationCanvas.NativeMethodInfoPtr_get_MixingStation_Public_get_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681736);
			MixingStationCanvas.NativeMethodInfoPtr_set_MixingStation_Protected_set_Void_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681737);
			MixingStationCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681738);
			MixingStationCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681739);
			MixingStationCanvas.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681740);
			MixingStationCanvas.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681741);
			MixingStationCanvas.NativeMethodInfoPtr_UpdateUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681742);
			MixingStationCanvas.NativeMethodInfoPtr_UpdateInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681743);
			MixingStationCanvas.NativeMethodInfoPtr_Open_Public_Void_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681744);
			MixingStationCanvas.NativeMethodInfoPtr_Close_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681745);
			MixingStationCanvas.NativeMethodInfoPtr_MixingDone_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681746);
			MixingStationCanvas.NativeMethodInfoPtr_StationContentsChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681747);
			MixingStationCanvas.NativeMethodInfoPtr_UpdateDisplayMode_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681748);
			MixingStationCanvas.NativeMethodInfoPtr_UpdateInstruction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681749);
			MixingStationCanvas.NativeMethodInfoPtr_UpdatePreview_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681750);
			MixingStationCanvas.NativeMethodInfoPtr_GetPropertyListString_Private_String_List_1_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681751);
			MixingStationCanvas.NativeMethodInfoPtr_GetPropertyString_Private_String_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681752);
			MixingStationCanvas.NativeMethodInfoPtr_GetOutputProperties_Private_List_1_Property_ProductDefinition_PropertyItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681753);
			MixingStationCanvas.NativeMethodInfoPtr_IsOutputKnown_Private_Boolean_byref_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681754);
			MixingStationCanvas.NativeMethodInfoPtr_UpdateBeginButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681755);
			MixingStationCanvas.NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681756);
			MixingStationCanvas.NativeMethodInfoPtr_StartMixOperation_Public_Void_MixOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681757);
			MixingStationCanvas.NativeMethodInfoPtr_MixNamed_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681758);
			MixingStationCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681759);
		}

		// Token: 0x17002DDA RID: 11738
		// (get) Token: 0x06009507 RID: 38151 RVA: 0x00264264 File Offset: 0x00262464
		// (set) Token: 0x06009508 RID: 38152 RVA: 0x002642A0 File Offset: 0x002624A0
		public unsafe bool isOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002DDB RID: 11739
		// (get) Token: 0x06009509 RID: 38153 RVA: 0x002642E0 File Offset: 0x002624E0
		// (set) Token: 0x0600950A RID: 38154 RVA: 0x00264320 File Offset: 0x00262520
		public unsafe MixingStation MixingStation
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19644, RefRangeEnd = 19658, XrefRangeStart = 19644, XrefRangeEnd = 19658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_get_MixingStation_Public_get_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MixingStation>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 19659, RefRangeEnd = 19660, XrefRangeStart = 19659, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_set_MixingStation_Protected_set_Void_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600950B RID: 38155 RVA: 0x00264364 File Offset: 0x00262564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267991, XrefRangeEnd = 268002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MixingStationCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600950C RID: 38156 RVA: 0x002643A0 File Offset: 0x002625A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268002, XrefRangeEnd = 268019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MixingStationCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600950D RID: 38157 RVA: 0x002643DC File Offset: 0x002625DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268019, XrefRangeEnd = 268028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600950E RID: 38158 RVA: 0x00264420 File Offset: 0x00262620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268028, XrefRangeEnd = 268033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MixingStationCanvas.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600950F RID: 38159 RVA: 0x0026445C File Offset: 0x0026265C
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_UpdateUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009510 RID: 38160 RVA: 0x00264490 File Offset: 0x00262690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268033, XrefRangeEnd = 268035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_UpdateInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009511 RID: 38161 RVA: 0x002644C4 File Offset: 0x002626C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 268223, RefRangeEnd = 268224, XrefRangeStart = 268035, XrefRangeEnd = 268223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(MixingStation station)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(station);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_Open_Public_Void_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009512 RID: 38162 RVA: 0x00264508 File Offset: 0x00262708
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 268284, RefRangeEnd = 268287, XrefRangeStart = 268224, XrefRangeEnd = 268284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(bool enablePlayerControl = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enablePlayerControl;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_Close_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009513 RID: 38163 RVA: 0x00264548 File Offset: 0x00262748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268287, XrefRangeEnd = 268345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MixingDone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_MixingDone_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009514 RID: 38164 RVA: 0x0026457C File Offset: 0x0026277C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268345, XrefRangeEnd = 268354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StationContentsChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_StationContentsChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009515 RID: 38165 RVA: 0x002645B0 File Offset: 0x002627B0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 268369, RefRangeEnd = 268374, XrefRangeStart = 268354, XrefRangeEnd = 268369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDisplayMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_UpdateDisplayMode_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009516 RID: 38166 RVA: 0x002645E4 File Offset: 0x002627E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 268385, RefRangeEnd = 268388, XrefRangeStart = 268374, XrefRangeEnd = 268385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInstruction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_UpdateInstruction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009517 RID: 38167 RVA: 0x00264618 File Offset: 0x00262818
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 268477, RefRangeEnd = 268480, XrefRangeStart = 268388, XrefRangeEnd = 268477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePreview()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_UpdatePreview_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009518 RID: 38168 RVA: 0x0026464C File Offset: 0x0026284C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 268492, RefRangeEnd = 268494, XrefRangeStart = 268480, XrefRangeEnd = 268492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetPropertyListString(List<Property> properties)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_GetPropertyListString_Private_String_List_1_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06009519 RID: 38169 RVA: 0x00264694 File Offset: 0x00262894
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 268512, RefRangeEnd = 268514, XrefRangeStart = 268494, XrefRangeEnd = 268512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetPropertyString(Property property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_GetPropertyString_Private_String_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600951A RID: 38170 RVA: 0x002646DC File Offset: 0x002628DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268514, XrefRangeEnd = 268520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Property> GetOutputProperties(ProductDefinition product, PropertyItemDefinition mixer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mixer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_GetOutputProperties_Private_List_1_Property_ProductDefinition_PropertyItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Property>>(intPtr3) : null;
		}

		// Token: 0x0600951B RID: 38171 RVA: 0x00264740 File Offset: 0x00262940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268520, XrefRangeEnd = 268547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsOutputKnown(out ProductDefinition knownProduct)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_IsOutputKnown_Private_Boolean_byref_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			knownProduct = ((intPtr4 == 0) ? null : new ProductDefinition(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600951C RID: 38172 RVA: 0x002647A0 File Offset: 0x002629A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 268555, RefRangeEnd = 268558, XrefRangeStart = 268547, XrefRangeEnd = 268555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBeginButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_UpdateBeginButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600951D RID: 38173 RVA: 0x002647D4 File Offset: 0x002629D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 268604, RefRangeEnd = 268605, XrefRangeStart = 268558, XrefRangeEnd = 268604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600951E RID: 38174 RVA: 0x00264808 File Offset: 0x00262A08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 268621, RefRangeEnd = 268622, XrefRangeStart = 268605, XrefRangeEnd = 268621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartMixOperation(MixOperation mixOperation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mixOperation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_StartMixOperation_Public_Void_MixOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600951F RID: 38175 RVA: 0x0026484C File Offset: 0x00262A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268622, XrefRangeEnd = 268646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MixNamed(string mixName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mixName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_MixNamed_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009520 RID: 38176 RVA: 0x00264890 File Offset: 0x00262A90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268646, XrefRangeEnd = 268649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixingStationCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009521 RID: 38177 RVA: 0x00048689 File Offset: 0x00046889
		public MixingStationCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002DC4 RID: 11716
		// (get) Token: 0x06009522 RID: 38178 RVA: 0x002648CC File Offset: 0x00262ACC
		// (set) Token: 0x06009523 RID: 38179 RVA: 0x00048692 File Offset: 0x00046892
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002DC5 RID: 11717
		// (get) Token: 0x06009524 RID: 38180 RVA: 0x002648F4 File Offset: 0x00262AF4
		// (set) Token: 0x06009525 RID: 38181 RVA: 0x000486AD File Offset: 0x000468AD
		public unsafe MixingStation _MixingStation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr__MixingStation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MixingStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr__MixingStation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DC6 RID: 11718
		// (get) Token: 0x06009526 RID: 38182 RVA: 0x00264924 File Offset: 0x00262B24
		// (set) Token: 0x06009527 RID: 38183 RVA: 0x000486CC File Offset: 0x000468CC
		public unsafe StationRecipeEntry RecipeEntryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_RecipeEntryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipeEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_RecipeEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DC7 RID: 11719
		// (get) Token: 0x06009528 RID: 38184 RVA: 0x00264954 File Offset: 0x00262B54
		// (set) Token: 0x06009529 RID: 38185 RVA: 0x000486EB File Offset: 0x000468EB
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DC8 RID: 11720
		// (get) Token: 0x0600952A RID: 38186 RVA: 0x00264984 File Offset: 0x00262B84
		// (set) Token: 0x0600952B RID: 38187 RVA: 0x0004870A File Offset: 0x0004690A
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DC9 RID: 11721
		// (get) Token: 0x0600952C RID: 38188 RVA: 0x002649B4 File Offset: 0x00262BB4
		// (set) Token: 0x0600952D RID: 38189 RVA: 0x00048729 File Offset: 0x00046929
		public unsafe ItemSlotUI ProductSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_ProductSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_ProductSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DCA RID: 11722
		// (get) Token: 0x0600952E RID: 38190 RVA: 0x002649E4 File Offset: 0x00262BE4
		// (set) Token: 0x0600952F RID: 38191 RVA: 0x00048748 File Offset: 0x00046948
		public unsafe TextMeshProUGUI ProductPropertiesLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_ProductPropertiesLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_ProductPropertiesLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DCB RID: 11723
		// (get) Token: 0x06009530 RID: 38192 RVA: 0x00264A14 File Offset: 0x00262C14
		// (set) Token: 0x06009531 RID: 38193 RVA: 0x00048767 File Offset: 0x00046967
		public unsafe ItemSlotUI IngredientSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_IngredientSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_IngredientSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DCC RID: 11724
		// (get) Token: 0x06009532 RID: 38194 RVA: 0x00264A44 File Offset: 0x00262C44
		// (set) Token: 0x06009533 RID: 38195 RVA: 0x00048786 File Offset: 0x00046986
		public unsafe TextMeshProUGUI IngredientProblemLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_IngredientProblemLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_IngredientProblemLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DCD RID: 11725
		// (get) Token: 0x06009534 RID: 38196 RVA: 0x00264A74 File Offset: 0x00262C74
		// (set) Token: 0x06009535 RID: 38197 RVA: 0x000487A5 File Offset: 0x000469A5
		public unsafe ItemSlotUI PreviewSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_PreviewSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_PreviewSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DCE RID: 11726
		// (get) Token: 0x06009536 RID: 38198 RVA: 0x00264AA4 File Offset: 0x00262CA4
		// (set) Token: 0x06009537 RID: 38199 RVA: 0x000487C4 File Offset: 0x000469C4
		public unsafe Image PreviewIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_PreviewIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_PreviewIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DCF RID: 11727
		// (get) Token: 0x06009538 RID: 38200 RVA: 0x00264AD4 File Offset: 0x00262CD4
		// (set) Token: 0x06009539 RID: 38201 RVA: 0x000487E3 File Offset: 0x000469E3
		public unsafe TextMeshProUGUI PreviewLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_PreviewLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_PreviewLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DD0 RID: 11728
		// (get) Token: 0x0600953A RID: 38202 RVA: 0x00264B04 File Offset: 0x00262D04
		// (set) Token: 0x0600953B RID: 38203 RVA: 0x00048802 File Offset: 0x00046A02
		public unsafe RectTransform UnknownOutputIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_UnknownOutputIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_UnknownOutputIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DD1 RID: 11729
		// (get) Token: 0x0600953C RID: 38204 RVA: 0x00264B34 File Offset: 0x00262D34
		// (set) Token: 0x0600953D RID: 38205 RVA: 0x00048821 File Offset: 0x00046A21
		public unsafe TextMeshProUGUI PreviewPropertiesLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_PreviewPropertiesLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_PreviewPropertiesLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DD2 RID: 11730
		// (get) Token: 0x0600953E RID: 38206 RVA: 0x00264B64 File Offset: 0x00262D64
		// (set) Token: 0x0600953F RID: 38207 RVA: 0x00048840 File Offset: 0x00046A40
		public unsafe ItemSlotUI OutputSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_OutputSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_OutputSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DD3 RID: 11731
		// (get) Token: 0x06009540 RID: 38208 RVA: 0x00264B94 File Offset: 0x00262D94
		// (set) Token: 0x06009541 RID: 38209 RVA: 0x0004885F File Offset: 0x00046A5F
		public unsafe TextMeshProUGUI InstructionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_InstructionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_InstructionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DD4 RID: 11732
		// (get) Token: 0x06009542 RID: 38210 RVA: 0x00264BC4 File Offset: 0x00262DC4
		// (set) Token: 0x06009543 RID: 38211 RVA: 0x0004887E File Offset: 0x00046A7E
		public unsafe RectTransform TitleContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_TitleContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_TitleContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DD5 RID: 11733
		// (get) Token: 0x06009544 RID: 38212 RVA: 0x00264BF4 File Offset: 0x00262DF4
		// (set) Token: 0x06009545 RID: 38213 RVA: 0x0004889D File Offset: 0x00046A9D
		public unsafe RectTransform MainContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_MainContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_MainContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DD6 RID: 11734
		// (get) Token: 0x06009546 RID: 38214 RVA: 0x00264C24 File Offset: 0x00262E24
		// (set) Token: 0x06009547 RID: 38215 RVA: 0x000488BC File Offset: 0x00046ABC
		public unsafe Button BeginButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_BeginButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_BeginButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DD7 RID: 11735
		// (get) Token: 0x06009548 RID: 38216 RVA: 0x00264C54 File Offset: 0x00262E54
		// (set) Token: 0x06009549 RID: 38217 RVA: 0x000488DB File Offset: 0x00046ADB
		public unsafe RectTransform ProductHint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_ProductHint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_ProductHint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DD8 RID: 11736
		// (get) Token: 0x0600954A RID: 38218 RVA: 0x00264C84 File Offset: 0x00262E84
		// (set) Token: 0x0600954B RID: 38219 RVA: 0x000488FA File Offset: 0x00046AFA
		public unsafe RectTransform MixerHint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_MixerHint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_MixerHint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DD9 RID: 11737
		// (get) Token: 0x0600954C RID: 38220 RVA: 0x00264CB4 File Offset: 0x00262EB4
		// (set) Token: 0x0600954D RID: 38221 RVA: 0x00048919 File Offset: 0x00046B19
		public unsafe StationRecipe selectedRecipe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_selectedRecipe);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_selectedRecipe), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006482 RID: 25730
		private static readonly IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x04006483 RID: 25731
		private static readonly IntPtr NativeFieldInfoPtr__MixingStation_k__BackingField;

		// Token: 0x04006484 RID: 25732
		private static readonly IntPtr NativeFieldInfoPtr_RecipeEntryPrefab;

		// Token: 0x04006485 RID: 25733
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04006486 RID: 25734
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006487 RID: 25735
		private static readonly IntPtr NativeFieldInfoPtr_ProductSlotUI;

		// Token: 0x04006488 RID: 25736
		private static readonly IntPtr NativeFieldInfoPtr_ProductPropertiesLabel;

		// Token: 0x04006489 RID: 25737
		private static readonly IntPtr NativeFieldInfoPtr_IngredientSlotUI;

		// Token: 0x0400648A RID: 25738
		private static readonly IntPtr NativeFieldInfoPtr_IngredientProblemLabel;

		// Token: 0x0400648B RID: 25739
		private static readonly IntPtr NativeFieldInfoPtr_PreviewSlotUI;

		// Token: 0x0400648C RID: 25740
		private static readonly IntPtr NativeFieldInfoPtr_PreviewIcon;

		// Token: 0x0400648D RID: 25741
		private static readonly IntPtr NativeFieldInfoPtr_PreviewLabel;

		// Token: 0x0400648E RID: 25742
		private static readonly IntPtr NativeFieldInfoPtr_UnknownOutputIcon;

		// Token: 0x0400648F RID: 25743
		private static readonly IntPtr NativeFieldInfoPtr_PreviewPropertiesLabel;

		// Token: 0x04006490 RID: 25744
		private static readonly IntPtr NativeFieldInfoPtr_OutputSlotUI;

		// Token: 0x04006491 RID: 25745
		private static readonly IntPtr NativeFieldInfoPtr_InstructionLabel;

		// Token: 0x04006492 RID: 25746
		private static readonly IntPtr NativeFieldInfoPtr_TitleContainer;

		// Token: 0x04006493 RID: 25747
		private static readonly IntPtr NativeFieldInfoPtr_MainContainer;

		// Token: 0x04006494 RID: 25748
		private static readonly IntPtr NativeFieldInfoPtr_BeginButton;

		// Token: 0x04006495 RID: 25749
		private static readonly IntPtr NativeFieldInfoPtr_ProductHint;

		// Token: 0x04006496 RID: 25750
		private static readonly IntPtr NativeFieldInfoPtr_MixerHint;

		// Token: 0x04006497 RID: 25751
		private static readonly IntPtr NativeFieldInfoPtr_selectedRecipe;

		// Token: 0x04006498 RID: 25752
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x04006499 RID: 25753
		private static readonly IntPtr NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0;

		// Token: 0x0400649A RID: 25754
		private static readonly IntPtr NativeMethodInfoPtr_get_MixingStation_Public_get_MixingStation_0;

		// Token: 0x0400649B RID: 25755
		private static readonly IntPtr NativeMethodInfoPtr_set_MixingStation_Protected_set_Void_MixingStation_0;

		// Token: 0x0400649C RID: 25756
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400649D RID: 25757
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400649E RID: 25758
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x0400649F RID: 25759
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040064A0 RID: 25760
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Private_Void_0;

		// Token: 0x040064A1 RID: 25761
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInput_Private_Void_0;

		// Token: 0x040064A2 RID: 25762
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_MixingStation_0;

		// Token: 0x040064A3 RID: 25763
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_Boolean_0;

		// Token: 0x040064A4 RID: 25764
		private static readonly IntPtr NativeMethodInfoPtr_MixingDone_Private_Void_0;

		// Token: 0x040064A5 RID: 25765
		private static readonly IntPtr NativeMethodInfoPtr_StationContentsChanged_Private_Void_0;

		// Token: 0x040064A6 RID: 25766
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDisplayMode_Private_Void_0;

		// Token: 0x040064A7 RID: 25767
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInstruction_Private_Void_0;

		// Token: 0x040064A8 RID: 25768
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePreview_Private_Void_0;

		// Token: 0x040064A9 RID: 25769
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyListString_Private_String_List_1_Property_0;

		// Token: 0x040064AA RID: 25770
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyString_Private_String_Property_0;

		// Token: 0x040064AB RID: 25771
		private static readonly IntPtr NativeMethodInfoPtr_GetOutputProperties_Private_List_1_Property_ProductDefinition_PropertyItemDefinition_0;

		// Token: 0x040064AC RID: 25772
		private static readonly IntPtr NativeMethodInfoPtr_IsOutputKnown_Private_Boolean_byref_ProductDefinition_0;

		// Token: 0x040064AD RID: 25773
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBeginButton_Private_Void_0;

		// Token: 0x040064AE RID: 25774
		private static readonly IntPtr NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0;

		// Token: 0x040064AF RID: 25775
		private static readonly IntPtr NativeMethodInfoPtr_StartMixOperation_Public_Void_MixOperation_0;

		// Token: 0x040064B0 RID: 25776
		private static readonly IntPtr NativeMethodInfoPtr_MixNamed_Private_Void_String_0;

		// Token: 0x040064B1 RID: 25777
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
