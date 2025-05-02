using System;
using Il2CppAdvancedPeopleSystem;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2Cpp
{
	// Token: 0x02000020 RID: 32
	public class UIControllerDEMO : MonoBehaviour
	{
		// Token: 0x06000200 RID: 512 RVA: 0x00076C80 File Offset: 0x00074E80
		// Note: this type is marked as 'beforefieldinit'.
		static UIControllerDEMO()
		{
			Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UIControllerDEMO");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr);
			UIControllerDEMO.NativeFieldInfoPtr_CharacterCustomization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "CharacterCustomization");
			UIControllerDEMO.NativeFieldInfoPtr_playbutton_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "playbutton_text");
			UIControllerDEMO.NativeFieldInfoPtr_bake_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "bake_text");
			UIControllerDEMO.NativeFieldInfoPtr_lod_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "lod_text");
			UIControllerDEMO.NativeFieldInfoPtr_panelNameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "panelNameText");
			UIControllerDEMO.NativeFieldInfoPtr_fatSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "fatSlider");
			UIControllerDEMO.NativeFieldInfoPtr_musclesSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "musclesSlider");
			UIControllerDEMO.NativeFieldInfoPtr_thinSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "thinSlider");
			UIControllerDEMO.NativeFieldInfoPtr_slimnessSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "slimnessSlider");
			UIControllerDEMO.NativeFieldInfoPtr_breastSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "breastSlider");
			UIControllerDEMO.NativeFieldInfoPtr_heightSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "heightSlider");
			UIControllerDEMO.NativeFieldInfoPtr_legSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "legSlider");
			UIControllerDEMO.NativeFieldInfoPtr_headSizeSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "headSizeSlider");
			UIControllerDEMO.NativeFieldInfoPtr_headOffsetSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "headOffsetSlider");
			UIControllerDEMO.NativeFieldInfoPtr_faceShapeSliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "faceShapeSliders");
			UIControllerDEMO.NativeFieldInfoPtr_HairPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "HairPanel");
			UIControllerDEMO.NativeFieldInfoPtr_BeardPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "BeardPanel");
			UIControllerDEMO.NativeFieldInfoPtr_ShirtPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "ShirtPanel");
			UIControllerDEMO.NativeFieldInfoPtr_PantsPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "PantsPanel");
			UIControllerDEMO.NativeFieldInfoPtr_ShoesPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "ShoesPanel");
			UIControllerDEMO.NativeFieldInfoPtr_HatPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "HatPanel");
			UIControllerDEMO.NativeFieldInfoPtr_AccessoryPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "AccessoryPanel");
			UIControllerDEMO.NativeFieldInfoPtr_BackpackPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "BackpackPanel");
			UIControllerDEMO.NativeFieldInfoPtr_FaceEditPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "FaceEditPanel");
			UIControllerDEMO.NativeFieldInfoPtr_BaseEditPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "BaseEditPanel");
			UIControllerDEMO.NativeFieldInfoPtr_SkinColorPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "SkinColorPanel");
			UIControllerDEMO.NativeFieldInfoPtr_EyeColorPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "EyeColorPanel");
			UIControllerDEMO.NativeFieldInfoPtr_HairColorPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "HairColorPanel");
			UIControllerDEMO.NativeFieldInfoPtr_UnderpantsColorPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "UnderpantsColorPanel");
			UIControllerDEMO.NativeFieldInfoPtr_EmotionsPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "EmotionsPanel");
			UIControllerDEMO.NativeFieldInfoPtr_SavesPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "SavesPanel");
			UIControllerDEMO.NativeFieldInfoPtr_SavesPanelList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "SavesPanelList");
			UIControllerDEMO.NativeFieldInfoPtr_SavesPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "SavesPrefab");
			UIControllerDEMO.NativeFieldInfoPtr_SavesList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "SavesList");
			UIControllerDEMO.NativeFieldInfoPtr_SkinColorButtonColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "SkinColorButtonColor");
			UIControllerDEMO.NativeFieldInfoPtr_EyeColorButtonColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "EyeColorButtonColor");
			UIControllerDEMO.NativeFieldInfoPtr_HairColorButtonColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "HairColorButtonColor");
			UIControllerDEMO.NativeFieldInfoPtr_UnderpantsColorButtonColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "UnderpantsColorButtonColor");
			UIControllerDEMO.NativeFieldInfoPtr_CameraPositionForPanels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "CameraPositionForPanels");
			UIControllerDEMO.NativeFieldInfoPtr_CameraEulerForPanels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "CameraEulerForPanels");
			UIControllerDEMO.NativeFieldInfoPtr_currentPanelIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "currentPanelIndex");
			UIControllerDEMO.NativeFieldInfoPtr_Camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "Camera");
			UIControllerDEMO.NativeFieldInfoPtr_femaleUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "femaleUI");
			UIControllerDEMO.NativeFieldInfoPtr_maleUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "maleUI");
			UIControllerDEMO.NativeFieldInfoPtr_lodIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "lodIndex");
			UIControllerDEMO.NativeFieldInfoPtr_walk_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "walk_active");
			UIControllerDEMO.NativeFieldInfoPtr_canvasVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "canvasVisible");
			UIControllerDEMO.NativeMethodInfoPtr_SwitchCharacterSettings_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663482);
			UIControllerDEMO.NativeMethodInfoPtr_ShowFaceEdit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663483);
			UIControllerDEMO.NativeMethodInfoPtr_ShowBaseEdit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663484);
			UIControllerDEMO.NativeMethodInfoPtr_SetFaceShape_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663485);
			UIControllerDEMO.NativeMethodInfoPtr_SetHeadOffset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663486);
			UIControllerDEMO.NativeMethodInfoPtr_BodyFat_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663487);
			UIControllerDEMO.NativeMethodInfoPtr_BodyMuscles_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663488);
			UIControllerDEMO.NativeMethodInfoPtr_BodyThin_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663489);
			UIControllerDEMO.NativeMethodInfoPtr_BodySlimness_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663490);
			UIControllerDEMO.NativeMethodInfoPtr_BodyBreast_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663491);
			UIControllerDEMO.NativeMethodInfoPtr_SetHeight_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663492);
			UIControllerDEMO.NativeMethodInfoPtr_SetHeadSize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663493);
			UIControllerDEMO.NativeMethodInfoPtr_Lod_Event_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663494);
			UIControllerDEMO.NativeMethodInfoPtr_SetNewSkinColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663495);
			UIControllerDEMO.NativeMethodInfoPtr_SetNewEyeColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663496);
			UIControllerDEMO.NativeMethodInfoPtr_SetNewHairColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663497);
			UIControllerDEMO.NativeMethodInfoPtr_SetNewUnderpantsColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663498);
			UIControllerDEMO.NativeMethodInfoPtr_VisibleSkinColorPanel_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663499);
			UIControllerDEMO.NativeMethodInfoPtr_VisibleEyeColorPanel_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663500);
			UIControllerDEMO.NativeMethodInfoPtr_VisibleHairColorPanel_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663501);
			UIControllerDEMO.NativeMethodInfoPtr_VisibleUnderpantsColorPanel_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663502);
			UIControllerDEMO.NativeMethodInfoPtr_ShirtPanel_Select_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663503);
			UIControllerDEMO.NativeMethodInfoPtr_PantsPanel_Select_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663504);
			UIControllerDEMO.NativeMethodInfoPtr_ShoesPanel_Select_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663505);
			UIControllerDEMO.NativeMethodInfoPtr_BackpackPanel_Select_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663506);
			UIControllerDEMO.NativeMethodInfoPtr_HairPanel_Select_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663507);
			UIControllerDEMO.NativeMethodInfoPtr_BeardPanel_Select_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663508);
			UIControllerDEMO.NativeMethodInfoPtr_HatPanel_Select_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663509);
			UIControllerDEMO.NativeMethodInfoPtr_EmotionsPanel_Select_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663510);
			UIControllerDEMO.NativeMethodInfoPtr_AccessoryPanel_Select_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663511);
			UIControllerDEMO.NativeMethodInfoPtr_SavesPanel_Select_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663512);
			UIControllerDEMO.NativeMethodInfoPtr_SaveSelect_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663513);
			UIControllerDEMO.NativeMethodInfoPtr_EmotionsChange_Event_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663514);
			UIControllerDEMO.NativeMethodInfoPtr_HairChange_Event_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663515);
			UIControllerDEMO.NativeMethodInfoPtr_BeardChange_Event_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663516);
			UIControllerDEMO.NativeMethodInfoPtr_ShirtChange_Event_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663517);
			UIControllerDEMO.NativeMethodInfoPtr_PantsChange_Event_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663518);
			UIControllerDEMO.NativeMethodInfoPtr_ShoesChange_Event_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663519);
			UIControllerDEMO.NativeMethodInfoPtr_BackpackChange_Event_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663520);
			UIControllerDEMO.NativeMethodInfoPtr_HatChange_Event_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663521);
			UIControllerDEMO.NativeMethodInfoPtr_AccessoryChange_Event_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663522);
			UIControllerDEMO.NativeMethodInfoPtr_HideAllPanels_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663523);
			UIControllerDEMO.NativeMethodInfoPtr_SaveToFile_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663524);
			UIControllerDEMO.NativeMethodInfoPtr_ClearFromFile_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663525);
			UIControllerDEMO.NativeMethodInfoPtr_Randimize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663526);
			UIControllerDEMO.NativeMethodInfoPtr_PlayAnim_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663527);
			UIControllerDEMO.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663528);
			UIControllerDEMO.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, 100663529);
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0007741C File Offset: 0x0007561C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72380, XrefRangeEnd = 72395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwitchCharacterSettings(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_SwitchCharacterSettings_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00077460 File Offset: 0x00075660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72395, XrefRangeEnd = 72402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowFaceEdit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_ShowFaceEdit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00077494 File Offset: 0x00075694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72402, XrefRangeEnd = 72409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowBaseEdit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_ShowBaseEdit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000204 RID: 516 RVA: 0x000774C8 File Offset: 0x000756C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72409, XrefRangeEnd = 72414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFaceShape(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_SetFaceShape_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00077508 File Offset: 0x00075708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72414, XrefRangeEnd = 72415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHeadOffset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_SetHeadOffset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0007753C File Offset: 0x0007573C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72415, XrefRangeEnd = 72416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BodyFat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_BodyFat_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00077570 File Offset: 0x00075770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72416, XrefRangeEnd = 72417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BodyMuscles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_BodyMuscles_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000208 RID: 520 RVA: 0x000775A4 File Offset: 0x000757A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72417, XrefRangeEnd = 72418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BodyThin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_BodyThin_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x000775D8 File Offset: 0x000757D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72418, XrefRangeEnd = 72419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BodySlimness()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_BodySlimness_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0007760C File Offset: 0x0007580C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72419, XrefRangeEnd = 72435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BodyBreast()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_BodyBreast_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00077640 File Offset: 0x00075840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72435, XrefRangeEnd = 72437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHeight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_SetHeight_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00077674 File Offset: 0x00075874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72437, XrefRangeEnd = 72439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHeadSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_SetHeadSize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x000776A8 File Offset: 0x000758A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72439, XrefRangeEnd = 72442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Lod_Event(int next)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref next;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_Lod_Event_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020E RID: 526 RVA: 0x000776E8 File Offset: 0x000758E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72442, XrefRangeEnd = 72443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNewSkinColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_SetNewSkinColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00077728 File Offset: 0x00075928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72443, XrefRangeEnd = 72444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNewEyeColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_SetNewEyeColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00077768 File Offset: 0x00075968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72444, XrefRangeEnd = 72445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNewHairColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_SetNewHairColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x000777A8 File Offset: 0x000759A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72445, XrefRangeEnd = 72446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNewUnderpantsColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_SetNewUnderpantsColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000212 RID: 530 RVA: 0x000777E8 File Offset: 0x000759E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72446, XrefRangeEnd = 72450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VisibleSkinColorPanel(bool v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_VisibleSkinColorPanel_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00077828 File Offset: 0x00075A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72450, XrefRangeEnd = 72454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VisibleEyeColorPanel(bool v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_VisibleEyeColorPanel_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00077868 File Offset: 0x00075A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72454, XrefRangeEnd = 72458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VisibleHairColorPanel(bool v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_VisibleHairColorPanel_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x000778A8 File Offset: 0x00075AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72458, XrefRangeEnd = 72462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VisibleUnderpantsColorPanel(bool v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_VisibleUnderpantsColorPanel_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x000778E8 File Offset: 0x00075AE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72462, XrefRangeEnd = 72468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShirtPanel_Select(bool v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_ShirtPanel_Select_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00077928 File Offset: 0x00075B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72468, XrefRangeEnd = 72474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PantsPanel_Select(bool v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_PantsPanel_Select_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00077968 File Offset: 0x00075B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72474, XrefRangeEnd = 72480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShoesPanel_Select(bool v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_ShoesPanel_Select_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x000779A8 File Offset: 0x00075BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72480, XrefRangeEnd = 72486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BackpackPanel_Select(bool v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_BackpackPanel_Select_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021A RID: 538 RVA: 0x000779E8 File Offset: 0x00075BE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72486, XrefRangeEnd = 72491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HairPanel_Select(bool v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_HairPanel_Select_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00077A28 File Offset: 0x00075C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72491, XrefRangeEnd = 72496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeardPanel_Select(bool v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_BeardPanel_Select_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00077A68 File Offset: 0x00075C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72496, XrefRangeEnd = 72501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HatPanel_Select(bool v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_HatPanel_Select_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00077AA8 File Offset: 0x00075CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72501, XrefRangeEnd = 72506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmotionsPanel_Select(bool v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_EmotionsPanel_Select_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00077AE8 File Offset: 0x00075CE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72506, XrefRangeEnd = 72511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AccessoryPanel_Select(bool v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_AccessoryPanel_Select_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00077B28 File Offset: 0x00075D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72511, XrefRangeEnd = 72562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SavesPanel_Select(bool v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_SavesPanel_Select_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00077B68 File Offset: 0x00075D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72562, XrefRangeEnd = 72570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveSelect(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_SaveSelect_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00077BA8 File Offset: 0x00075DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72570, XrefRangeEnd = 72574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmotionsChange_Event(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_EmotionsChange_Event_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00077BE8 File Offset: 0x00075DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72574, XrefRangeEnd = 72576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HairChange_Event(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_HairChange_Event_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00077C28 File Offset: 0x00075E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72576, XrefRangeEnd = 72578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeardChange_Event(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_BeardChange_Event_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00077C68 File Offset: 0x00075E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72578, XrefRangeEnd = 72580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShirtChange_Event(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_ShirtChange_Event_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00077CA8 File Offset: 0x00075EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72580, XrefRangeEnd = 72582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PantsChange_Event(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_PantsChange_Event_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00077CE8 File Offset: 0x00075EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72582, XrefRangeEnd = 72584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShoesChange_Event(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_ShoesChange_Event_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00077D28 File Offset: 0x00075F28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72584, XrefRangeEnd = 72586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BackpackChange_Event(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_BackpackChange_Event_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00077D68 File Offset: 0x00075F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72586, XrefRangeEnd = 72588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HatChange_Event(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_HatChange_Event_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00077DA8 File Offset: 0x00075FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72588, XrefRangeEnd = 72590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AccessoryChange_Event(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_AccessoryChange_Event_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00077DE8 File Offset: 0x00075FE8
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 72625, RefRangeEnd = 72639, XrefRangeStart = 72590, XrefRangeEnd = 72625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HideAllPanels()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_HideAllPanels_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00077E1C File Offset: 0x0007601C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72639, XrefRangeEnd = 72642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveToFile()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_SaveToFile_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00077E50 File Offset: 0x00076050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72642, XrefRangeEnd = 72646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearFromFile()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_ClearFromFile_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00077E84 File Offset: 0x00076084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72646, XrefRangeEnd = 72648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Randimize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_Randimize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00077EB8 File Offset: 0x000760B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72648, XrefRangeEnd = 72656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayAnim()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_PlayAnim_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00077EEC File Offset: 0x000760EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72656, XrefRangeEnd = 72676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00077F20 File Offset: 0x00076120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72676, XrefRangeEnd = 72684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIControllerDEMO() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000231 RID: 561 RVA: 0x000031B7 File Offset: 0x000013B7
		public UIControllerDEMO(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000232 RID: 562 RVA: 0x00077F5C File Offset: 0x0007615C
		// (set) Token: 0x06000233 RID: 563 RVA: 0x000031C0 File Offset: 0x000013C0
		public unsafe CharacterCustomization CharacterCustomization
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_CharacterCustomization);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCustomization>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_CharacterCustomization), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000234 RID: 564 RVA: 0x00077F8C File Offset: 0x0007618C
		// (set) Token: 0x06000235 RID: 565 RVA: 0x000031DF File Offset: 0x000013DF
		public unsafe Text playbutton_text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_playbutton_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_playbutton_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000236 RID: 566 RVA: 0x00077FBC File Offset: 0x000761BC
		// (set) Token: 0x06000237 RID: 567 RVA: 0x000031FE File Offset: 0x000013FE
		public unsafe Text bake_text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_bake_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_bake_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000238 RID: 568 RVA: 0x00077FEC File Offset: 0x000761EC
		// (set) Token: 0x06000239 RID: 569 RVA: 0x0000321D File Offset: 0x0000141D
		public unsafe Text lod_text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_lod_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_lod_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600023A RID: 570 RVA: 0x0007801C File Offset: 0x0007621C
		// (set) Token: 0x0600023B RID: 571 RVA: 0x0000323C File Offset: 0x0000143C
		public unsafe Text panelNameText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_panelNameText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_panelNameText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600023C RID: 572 RVA: 0x0007804C File Offset: 0x0007624C
		// (set) Token: 0x0600023D RID: 573 RVA: 0x0000325B File Offset: 0x0000145B
		public unsafe Slider fatSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_fatSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_fatSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600023E RID: 574 RVA: 0x0007807C File Offset: 0x0007627C
		// (set) Token: 0x0600023F RID: 575 RVA: 0x0000327A File Offset: 0x0000147A
		public unsafe Slider musclesSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_musclesSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_musclesSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000240 RID: 576 RVA: 0x000780AC File Offset: 0x000762AC
		// (set) Token: 0x06000241 RID: 577 RVA: 0x00003299 File Offset: 0x00001499
		public unsafe Slider thinSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_thinSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_thinSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000242 RID: 578 RVA: 0x000780DC File Offset: 0x000762DC
		// (set) Token: 0x06000243 RID: 579 RVA: 0x000032B8 File Offset: 0x000014B8
		public unsafe Slider slimnessSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_slimnessSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_slimnessSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000244 RID: 580 RVA: 0x0007810C File Offset: 0x0007630C
		// (set) Token: 0x06000245 RID: 581 RVA: 0x000032D7 File Offset: 0x000014D7
		public unsafe Slider breastSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_breastSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_breastSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000246 RID: 582 RVA: 0x0007813C File Offset: 0x0007633C
		// (set) Token: 0x06000247 RID: 583 RVA: 0x000032F6 File Offset: 0x000014F6
		public unsafe Slider heightSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_heightSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_heightSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000248 RID: 584 RVA: 0x0007816C File Offset: 0x0007636C
		// (set) Token: 0x06000249 RID: 585 RVA: 0x00003315 File Offset: 0x00001515
		public unsafe Slider legSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_legSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_legSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600024A RID: 586 RVA: 0x0007819C File Offset: 0x0007639C
		// (set) Token: 0x0600024B RID: 587 RVA: 0x00003334 File Offset: 0x00001534
		public unsafe Slider headSizeSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_headSizeSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_headSizeSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600024C RID: 588 RVA: 0x000781CC File Offset: 0x000763CC
		// (set) Token: 0x0600024D RID: 589 RVA: 0x00003353 File Offset: 0x00001553
		public unsafe Slider headOffsetSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_headOffsetSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_headOffsetSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600024E RID: 590 RVA: 0x000781FC File Offset: 0x000763FC
		// (set) Token: 0x0600024F RID: 591 RVA: 0x00003372 File Offset: 0x00001572
		public unsafe Il2CppReferenceArray<Slider> faceShapeSliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_faceShapeSliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Slider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_faceShapeSliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000250 RID: 592 RVA: 0x0007822C File Offset: 0x0007642C
		// (set) Token: 0x06000251 RID: 593 RVA: 0x00003391 File Offset: 0x00001591
		public unsafe RectTransform HairPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_HairPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_HairPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000252 RID: 594 RVA: 0x0007825C File Offset: 0x0007645C
		// (set) Token: 0x06000253 RID: 595 RVA: 0x000033B0 File Offset: 0x000015B0
		public unsafe RectTransform BeardPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_BeardPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_BeardPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000254 RID: 596 RVA: 0x0007828C File Offset: 0x0007648C
		// (set) Token: 0x06000255 RID: 597 RVA: 0x000033CF File Offset: 0x000015CF
		public unsafe RectTransform ShirtPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_ShirtPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_ShirtPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000256 RID: 598 RVA: 0x000782BC File Offset: 0x000764BC
		// (set) Token: 0x06000257 RID: 599 RVA: 0x000033EE File Offset: 0x000015EE
		public unsafe RectTransform PantsPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_PantsPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_PantsPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000258 RID: 600 RVA: 0x000782EC File Offset: 0x000764EC
		// (set) Token: 0x06000259 RID: 601 RVA: 0x0000340D File Offset: 0x0000160D
		public unsafe RectTransform ShoesPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_ShoesPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_ShoesPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600025A RID: 602 RVA: 0x0007831C File Offset: 0x0007651C
		// (set) Token: 0x0600025B RID: 603 RVA: 0x0000342C File Offset: 0x0000162C
		public unsafe RectTransform HatPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_HatPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_HatPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600025C RID: 604 RVA: 0x0007834C File Offset: 0x0007654C
		// (set) Token: 0x0600025D RID: 605 RVA: 0x0000344B File Offset: 0x0000164B
		public unsafe RectTransform AccessoryPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_AccessoryPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_AccessoryPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600025E RID: 606 RVA: 0x0007837C File Offset: 0x0007657C
		// (set) Token: 0x0600025F RID: 607 RVA: 0x0000346A File Offset: 0x0000166A
		public unsafe RectTransform BackpackPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_BackpackPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_BackpackPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000260 RID: 608 RVA: 0x000783AC File Offset: 0x000765AC
		// (set) Token: 0x06000261 RID: 609 RVA: 0x00003489 File Offset: 0x00001689
		public unsafe RectTransform FaceEditPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_FaceEditPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_FaceEditPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000262 RID: 610 RVA: 0x000783DC File Offset: 0x000765DC
		// (set) Token: 0x06000263 RID: 611 RVA: 0x000034A8 File Offset: 0x000016A8
		public unsafe RectTransform BaseEditPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_BaseEditPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_BaseEditPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000264 RID: 612 RVA: 0x0007840C File Offset: 0x0007660C
		// (set) Token: 0x06000265 RID: 613 RVA: 0x000034C7 File Offset: 0x000016C7
		public unsafe RectTransform SkinColorPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_SkinColorPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_SkinColorPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000266 RID: 614 RVA: 0x0007843C File Offset: 0x0007663C
		// (set) Token: 0x06000267 RID: 615 RVA: 0x000034E6 File Offset: 0x000016E6
		public unsafe RectTransform EyeColorPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_EyeColorPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_EyeColorPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000268 RID: 616 RVA: 0x0007846C File Offset: 0x0007666C
		// (set) Token: 0x06000269 RID: 617 RVA: 0x00003505 File Offset: 0x00001705
		public unsafe RectTransform HairColorPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_HairColorPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_HairColorPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600026A RID: 618 RVA: 0x0007849C File Offset: 0x0007669C
		// (set) Token: 0x0600026B RID: 619 RVA: 0x00003524 File Offset: 0x00001724
		public unsafe RectTransform UnderpantsColorPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_UnderpantsColorPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_UnderpantsColorPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600026C RID: 620 RVA: 0x000784CC File Offset: 0x000766CC
		// (set) Token: 0x0600026D RID: 621 RVA: 0x00003543 File Offset: 0x00001743
		public unsafe RectTransform EmotionsPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_EmotionsPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_EmotionsPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600026E RID: 622 RVA: 0x000784FC File Offset: 0x000766FC
		// (set) Token: 0x0600026F RID: 623 RVA: 0x00003562 File Offset: 0x00001762
		public unsafe RectTransform SavesPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_SavesPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_SavesPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000270 RID: 624 RVA: 0x0007852C File Offset: 0x0007672C
		// (set) Token: 0x06000271 RID: 625 RVA: 0x00003581 File Offset: 0x00001781
		public unsafe RectTransform SavesPanelList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_SavesPanelList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_SavesPanelList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000272 RID: 626 RVA: 0x0007855C File Offset: 0x0007675C
		// (set) Token: 0x06000273 RID: 627 RVA: 0x000035A0 File Offset: 0x000017A0
		public unsafe RectTransform SavesPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_SavesPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_SavesPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000274 RID: 628 RVA: 0x0007858C File Offset: 0x0007678C
		// (set) Token: 0x06000275 RID: 629 RVA: 0x000035BF File Offset: 0x000017BF
		public unsafe List<RectTransform> SavesList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_SavesList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_SavesList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000276 RID: 630 RVA: 0x000785BC File Offset: 0x000767BC
		// (set) Token: 0x06000277 RID: 631 RVA: 0x000035DE File Offset: 0x000017DE
		public unsafe Image SkinColorButtonColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_SkinColorButtonColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_SkinColorButtonColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000278 RID: 632 RVA: 0x000785EC File Offset: 0x000767EC
		// (set) Token: 0x06000279 RID: 633 RVA: 0x000035FD File Offset: 0x000017FD
		public unsafe Image EyeColorButtonColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_EyeColorButtonColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_EyeColorButtonColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x0600027A RID: 634 RVA: 0x0007861C File Offset: 0x0007681C
		// (set) Token: 0x0600027B RID: 635 RVA: 0x0000361C File Offset: 0x0000181C
		public unsafe Image HairColorButtonColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_HairColorButtonColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_HairColorButtonColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600027C RID: 636 RVA: 0x0007864C File Offset: 0x0007684C
		// (set) Token: 0x0600027D RID: 637 RVA: 0x0000363B File Offset: 0x0000183B
		public unsafe Image UnderpantsColorButtonColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_UnderpantsColorButtonColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_UnderpantsColorButtonColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600027E RID: 638 RVA: 0x0007867C File Offset: 0x0007687C
		// (set) Token: 0x0600027F RID: 639 RVA: 0x0000365A File Offset: 0x0000185A
		public unsafe Il2CppStructArray<Vector3> CameraPositionForPanels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_CameraPositionForPanels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_CameraPositionForPanels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000280 RID: 640 RVA: 0x000786AC File Offset: 0x000768AC
		// (set) Token: 0x06000281 RID: 641 RVA: 0x00003679 File Offset: 0x00001879
		public unsafe Il2CppStructArray<Vector3> CameraEulerForPanels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_CameraEulerForPanels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_CameraEulerForPanels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000282 RID: 642 RVA: 0x000786DC File Offset: 0x000768DC
		// (set) Token: 0x06000283 RID: 643 RVA: 0x00003698 File Offset: 0x00001898
		public unsafe int currentPanelIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_currentPanelIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_currentPanelIndex)) = value;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000284 RID: 644 RVA: 0x00078704 File Offset: 0x00076904
		// (set) Token: 0x06000285 RID: 645 RVA: 0x000036B3 File Offset: 0x000018B3
		public unsafe Camera Camera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_Camera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_Camera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000286 RID: 646 RVA: 0x00078734 File Offset: 0x00076934
		// (set) Token: 0x06000287 RID: 647 RVA: 0x000036D2 File Offset: 0x000018D2
		public unsafe RectTransform femaleUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_femaleUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_femaleUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000288 RID: 648 RVA: 0x00078764 File Offset: 0x00076964
		// (set) Token: 0x06000289 RID: 649 RVA: 0x000036F1 File Offset: 0x000018F1
		public unsafe RectTransform maleUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_maleUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_maleUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x0600028A RID: 650 RVA: 0x00078794 File Offset: 0x00076994
		// (set) Token: 0x0600028B RID: 651 RVA: 0x00003710 File Offset: 0x00001910
		public unsafe int lodIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_lodIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_lodIndex)) = value;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600028C RID: 652 RVA: 0x000787BC File Offset: 0x000769BC
		// (set) Token: 0x0600028D RID: 653 RVA: 0x0000372B File Offset: 0x0000192B
		public unsafe bool walk_active
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_walk_active);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_walk_active)) = value;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600028E RID: 654 RVA: 0x000787E4 File Offset: 0x000769E4
		// (set) Token: 0x0600028F RID: 655 RVA: 0x00003746 File Offset: 0x00001946
		public unsafe bool canvasVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_canvasVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.NativeFieldInfoPtr_canvasVisible)) = value;
			}
		}

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeFieldInfoPtr_CharacterCustomization;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeFieldInfoPtr_playbutton_text;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeFieldInfoPtr_bake_text;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeFieldInfoPtr_lod_text;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeFieldInfoPtr_panelNameText;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeFieldInfoPtr_fatSlider;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeFieldInfoPtr_musclesSlider;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeFieldInfoPtr_thinSlider;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeFieldInfoPtr_slimnessSlider;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeFieldInfoPtr_breastSlider;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeFieldInfoPtr_heightSlider;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeFieldInfoPtr_legSlider;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeFieldInfoPtr_headSizeSlider;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeFieldInfoPtr_headOffsetSlider;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeFieldInfoPtr_faceShapeSliders;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeFieldInfoPtr_HairPanel;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeFieldInfoPtr_BeardPanel;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeFieldInfoPtr_ShirtPanel;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeFieldInfoPtr_PantsPanel;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeFieldInfoPtr_ShoesPanel;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeFieldInfoPtr_HatPanel;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeFieldInfoPtr_AccessoryPanel;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeFieldInfoPtr_BackpackPanel;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeFieldInfoPtr_FaceEditPanel;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeFieldInfoPtr_BaseEditPanel;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeFieldInfoPtr_SkinColorPanel;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeFieldInfoPtr_EyeColorPanel;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeFieldInfoPtr_HairColorPanel;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeFieldInfoPtr_UnderpantsColorPanel;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeFieldInfoPtr_EmotionsPanel;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeFieldInfoPtr_SavesPanel;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeFieldInfoPtr_SavesPanelList;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeFieldInfoPtr_SavesPrefab;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeFieldInfoPtr_SavesList;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeFieldInfoPtr_SkinColorButtonColor;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeFieldInfoPtr_EyeColorButtonColor;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeFieldInfoPtr_HairColorButtonColor;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeFieldInfoPtr_UnderpantsColorButtonColor;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeFieldInfoPtr_CameraPositionForPanels;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeFieldInfoPtr_CameraEulerForPanels;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeFieldInfoPtr_currentPanelIndex;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeFieldInfoPtr_Camera;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeFieldInfoPtr_femaleUI;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeFieldInfoPtr_maleUI;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeFieldInfoPtr_lodIndex;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeFieldInfoPtr_walk_active;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeFieldInfoPtr_canvasVisible;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeMethodInfoPtr_SwitchCharacterSettings_Public_Void_String_0;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeMethodInfoPtr_ShowFaceEdit_Public_Void_0;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeMethodInfoPtr_ShowBaseEdit_Public_Void_0;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeMethodInfoPtr_SetFaceShape_Public_Void_Int32_0;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeMethodInfoPtr_SetHeadOffset_Public_Void_0;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeMethodInfoPtr_BodyFat_Public_Void_0;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeMethodInfoPtr_BodyMuscles_Public_Void_0;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeMethodInfoPtr_BodyThin_Public_Void_0;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeMethodInfoPtr_BodySlimness_Public_Void_0;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeMethodInfoPtr_BodyBreast_Public_Void_0;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeMethodInfoPtr_SetHeight_Public_Void_0;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeMethodInfoPtr_SetHeadSize_Public_Void_0;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeMethodInfoPtr_Lod_Event_Public_Void_Int32_0;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeMethodInfoPtr_SetNewSkinColor_Public_Void_Color_0;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeMethodInfoPtr_SetNewEyeColor_Public_Void_Color_0;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeMethodInfoPtr_SetNewHairColor_Public_Void_Color_0;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeMethodInfoPtr_SetNewUnderpantsColor_Public_Void_Color_0;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeMethodInfoPtr_VisibleSkinColorPanel_Public_Void_Boolean_0;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeMethodInfoPtr_VisibleEyeColorPanel_Public_Void_Boolean_0;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeMethodInfoPtr_VisibleHairColorPanel_Public_Void_Boolean_0;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeMethodInfoPtr_VisibleUnderpantsColorPanel_Public_Void_Boolean_0;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeMethodInfoPtr_ShirtPanel_Select_Public_Void_Boolean_0;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeMethodInfoPtr_PantsPanel_Select_Public_Void_Boolean_0;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeMethodInfoPtr_ShoesPanel_Select_Public_Void_Boolean_0;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeMethodInfoPtr_BackpackPanel_Select_Public_Void_Boolean_0;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeMethodInfoPtr_HairPanel_Select_Public_Void_Boolean_0;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeMethodInfoPtr_BeardPanel_Select_Public_Void_Boolean_0;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeMethodInfoPtr_HatPanel_Select_Public_Void_Boolean_0;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeMethodInfoPtr_EmotionsPanel_Select_Public_Void_Boolean_0;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeMethodInfoPtr_AccessoryPanel_Select_Public_Void_Boolean_0;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeMethodInfoPtr_SavesPanel_Select_Public_Void_Boolean_0;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeMethodInfoPtr_SaveSelect_Public_Void_Int32_0;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeMethodInfoPtr_EmotionsChange_Event_Public_Void_Int32_0;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeMethodInfoPtr_HairChange_Event_Public_Void_Int32_0;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeMethodInfoPtr_BeardChange_Event_Public_Void_Int32_0;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeMethodInfoPtr_ShirtChange_Event_Public_Void_Int32_0;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeMethodInfoPtr_PantsChange_Event_Public_Void_Int32_0;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeMethodInfoPtr_ShoesChange_Event_Public_Void_Int32_0;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeMethodInfoPtr_BackpackChange_Event_Public_Void_Int32_0;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeMethodInfoPtr_HatChange_Event_Public_Void_Int32_0;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeMethodInfoPtr_AccessoryChange_Event_Public_Void_Int32_0;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeMethodInfoPtr_HideAllPanels_Public_Void_0;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeMethodInfoPtr_SaveToFile_Public_Void_0;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromFile_Public_Void_0;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeMethodInfoPtr_Randimize_Public_Void_0;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeMethodInfoPtr_PlayAnim_Public_Void_0;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007AC RID: 1964
		[ObfuscatedName("UIControllerDEMO+<>c__DisplayClass75_0")]
		public sealed class __c__DisplayClass75_0 : Il2CppSystem.Object
		{
			// Token: 0x0600B97B RID: 47483 RVA: 0x002E0CC4 File Offset: 0x002DEEC4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass75_0()
			{
				Il2CppClassPointerStore<UIControllerDEMO.__c__DisplayClass75_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIControllerDEMO>.NativeClassPtr, "<>c__DisplayClass75_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIControllerDEMO.__c__DisplayClass75_0>.NativeClassPtr);
				UIControllerDEMO.__c__DisplayClass75_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO.__c__DisplayClass75_0>.NativeClassPtr, "index");
				UIControllerDEMO.__c__DisplayClass75_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControllerDEMO.__c__DisplayClass75_0>.NativeClassPtr, "<>4__this");
				UIControllerDEMO.__c__DisplayClass75_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO.__c__DisplayClass75_0>.NativeClassPtr, 100663530);
				UIControllerDEMO.__c__DisplayClass75_0.NativeMethodInfoPtr__SavesPanel_Select_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControllerDEMO.__c__DisplayClass75_0>.NativeClassPtr, 100663531);
			}

			// Token: 0x0600B97C RID: 47484 RVA: 0x002E0D40 File Offset: 0x002DEF40
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass75_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIControllerDEMO.__c__DisplayClass75_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.__c__DisplayClass75_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B97D RID: 47485 RVA: 0x002E0D7C File Offset: 0x002DEF7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72344, XrefRangeEnd = 72380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SavesPanel_Select_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControllerDEMO.__c__DisplayClass75_0.NativeMethodInfoPtr__SavesPanel_Select_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B97E RID: 47486 RVA: 0x0005AAF0 File Offset: 0x00058CF0
			public __c__DisplayClass75_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700393E RID: 14654
			// (get) Token: 0x0600B97F RID: 47487 RVA: 0x002E0DB0 File Offset: 0x002DEFB0
			// (set) Token: 0x0600B980 RID: 47488 RVA: 0x0005AAF9 File Offset: 0x00058CF9
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.__c__DisplayClass75_0.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.__c__DisplayClass75_0.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x1700393F RID: 14655
			// (get) Token: 0x0600B981 RID: 47489 RVA: 0x002E0DD8 File Offset: 0x002DEFD8
			// (set) Token: 0x0600B982 RID: 47490 RVA: 0x0005AB14 File Offset: 0x00058D14
			public unsafe UIControllerDEMO __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.__c__DisplayClass75_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIControllerDEMO>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControllerDEMO.__c__DisplayClass75_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007D27 RID: 32039
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04007D28 RID: 32040
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007D29 RID: 32041
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007D2A RID: 32042
			private static readonly IntPtr NativeMethodInfoPtr__SavesPanel_Select_b__0_Internal_Void_0;
		}
	}
}
