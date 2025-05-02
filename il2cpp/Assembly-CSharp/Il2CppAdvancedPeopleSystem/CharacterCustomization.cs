using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppAdvancedPeopleSystem
{
	// Token: 0x0200013E RID: 318
	public class CharacterCustomization : MonoBehaviour
	{
		// Token: 0x06001A75 RID: 6773 RVA: 0x000C3338 File Offset: 0x000C1538
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterCustomization()
		{
			Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AdvancedPeopleSystem", "CharacterCustomization");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr);
			CharacterCustomization.NativeFieldInfoPtr_isSettingsExpanded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "isSettingsExpanded");
			CharacterCustomization.NativeFieldInfoPtr_selectedsettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "selectedsettings");
			CharacterCustomization.NativeFieldInfoPtr__settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "_settings");
			CharacterCustomization.NativeFieldInfoPtr_characterParts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "characterParts");
			CharacterCustomization.NativeFieldInfoPtr_prefabPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "prefabPath");
			CharacterCustomization.NativeFieldInfoPtr_instanceStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "instanceStatus");
			CharacterCustomization.NativeFieldInfoPtr_originHip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "originHip");
			CharacterCustomization.NativeFieldInfoPtr_headHip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "headHip");
			CharacterCustomization.NativeFieldInfoPtr_clothesAnchors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "clothesAnchors");
			CharacterCustomization.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "animator");
			CharacterCustomization.NativeFieldInfoPtr_characterSelectedElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "characterSelectedElements");
			CharacterCustomization.NativeFieldInfoPtr_heightValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "heightValue");
			CharacterCustomization.NativeFieldInfoPtr_headSizeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "headSizeValue");
			CharacterCustomization.NativeFieldInfoPtr_feetOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "feetOffset");
			CharacterCustomization.NativeFieldInfoPtr_characterBlendshapeDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "characterBlendshapeDatas");
			CharacterCustomization.NativeFieldInfoPtr_Skin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "Skin");
			CharacterCustomization.NativeFieldInfoPtr_Eye = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "Eye");
			CharacterCustomization.NativeFieldInfoPtr_Hair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "Hair");
			CharacterCustomization.NativeFieldInfoPtr_Underpants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "Underpants");
			CharacterCustomization.NativeFieldInfoPtr_OralCavity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "OralCavity");
			CharacterCustomization.NativeFieldInfoPtr_Teeth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "Teeth");
			CharacterCustomization.NativeFieldInfoPtr_bodyPropertyBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "bodyPropertyBlock");
			CharacterCustomization.NativeFieldInfoPtr_currentBlendshapeAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "currentBlendshapeAnimation");
			CharacterCustomization.NativeFieldInfoPtr_CurrentCombinerState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "CurrentCombinerState");
			CharacterCustomization.NativeFieldInfoPtr_combinedCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "combinedCharacter");
			CharacterCustomization.NativeFieldInfoPtr_ProbesAnchorOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "ProbesAnchorOverride");
			CharacterCustomization.NativeFieldInfoPtr_CharacterGenerator_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "CharacterGenerator_settings");
			CharacterCustomization.NativeFieldInfoPtr_UpdateWhenOffscreenMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "UpdateWhenOffscreenMeshes");
			CharacterCustomization.NativeFieldInfoPtr_MinLODLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "MinLODLevels");
			CharacterCustomization.NativeFieldInfoPtr_MaxLODLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "MaxLODLevels");
			CharacterCustomization.NativeFieldInfoPtr__lodGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "_lodGroup");
			CharacterCustomization.NativeFieldInfoPtr__transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "_transform");
			CharacterCustomization.NativeFieldInfoPtr_applyFeetOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "applyFeetOffset");
			CharacterCustomization.NativeFieldInfoPtr_notAPP2Shader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "notAPP2Shader");
			CharacterCustomization.NativeFieldInfoPtr_prebuiltPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "prebuiltPrefab");
			CharacterCustomization.NativeMethodInfoPtr_get_Settings_Public_get_CharacterSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666102);
			CharacterCustomization.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666103);
			CharacterCustomization.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666104);
			CharacterCustomization.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666105);
			CharacterCustomization.NativeMethodInfoPtr_AnimationTick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666106);
			CharacterCustomization.NativeMethodInfoPtr_SwitchCharacterSettings_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666107);
			CharacterCustomization.NativeMethodInfoPtr_SwitchCharacterSettings_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666108);
			CharacterCustomization.NativeMethodInfoPtr_InitializeMeshes_Public_Void_CharacterSettings_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666109);
			CharacterCustomization.NativeMethodInfoPtr_UpdateSkinnedMeshesOffscreenBounds_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666110);
			CharacterCustomization.NativeMethodInfoPtr_GetCharacterSettingsSelectors_Public_List_1_CharacterSettingsSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666111);
			CharacterCustomization.NativeMethodInfoPtr_ResetBodyMaterial_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666112);
			CharacterCustomization.NativeMethodInfoPtr_InitColors_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666113);
			CharacterCustomization.NativeMethodInfoPtr_ResetBodyColors_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666114);
			CharacterCustomization.NativeMethodInfoPtr_SetBlendshapeValue_Public_Void_CharacterBlendShapeType_Single_Il2CppStringArray_Il2CppStructArray_1_CharacterElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666115);
			CharacterCustomization.NativeMethodInfoPtr_ForceLOD_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666116);
			CharacterCustomization.NativeMethodInfoPtr_SetElementByIndex_Public_Void_CharacterElementType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666117);
			CharacterCustomization.NativeMethodInfoPtr_ClearElement_Public_Void_CharacterElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666118);
			CharacterCustomization.NativeMethodInfoPtr_SetHeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666119);
			CharacterCustomization.NativeMethodInfoPtr_SetHeadSize_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666120);
			CharacterCustomization.NativeMethodInfoPtr_SetFeetOffset_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666121);
			CharacterCustomization.NativeMethodInfoPtr_SetHairByIndex_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666122);
			CharacterCustomization.NativeMethodInfoPtr_SetBeardByIndex_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666123);
			CharacterCustomization.NativeMethodInfoPtr_GetClothesAnchor_Public_ClothesAnchor_CharacterElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666124);
			CharacterCustomization.NativeMethodInfoPtr_GetCharacterPart_Public_CharacterPart_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666125);
			CharacterCustomization.NativeMethodInfoPtr_GetAllMeshesByLod_Public_List_1_SkinnedMeshRenderer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666126);
			CharacterCustomization.NativeMethodInfoPtr_GetAllMeshes_Public_List_1_SkinnedMeshRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666127);
			CharacterCustomization.NativeMethodInfoPtr_GetAllMeshes_Public_List_1_SkinnedMeshRenderer_Boolean_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666128);
			CharacterCustomization.NativeMethodInfoPtr_HideParts_Public_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666129);
			CharacterCustomization.NativeMethodInfoPtr_UnHideParts_Public_Void_Il2CppStringArray_CharacterElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666130);
			CharacterCustomization.NativeMethodInfoPtr_SetBodyColor_Public_Void_BodyColorPart_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666131);
			CharacterCustomization.NativeMethodInfoPtr_GetBodyColor_Public_Color_BodyColorPart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666132);
			CharacterCustomization.NativeMethodInfoPtr_SetCharacterSetup_Public_Void_CharacterCustomizationSetup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666133);
			CharacterCustomization.NativeMethodInfoPtr_GetSetup_Public_CharacterCustomizationSetup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666134);
			CharacterCustomization.NativeMethodInfoPtr_ApplySavedCharacterData_Public_Void_SavedCharacterData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666135);
			CharacterCustomization.NativeMethodInfoPtr_LoadCharacterFromFile_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666136);
			CharacterCustomization.NativeMethodInfoPtr_GetSavedCharacterDatas_Public_List_1_SavedCharacterData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666137);
			CharacterCustomization.NativeMethodInfoPtr_ClearSavedData_Public_Void_SavedCharacterData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666138);
			CharacterCustomization.NativeMethodInfoPtr_ClearSavedData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666139);
			CharacterCustomization.NativeMethodInfoPtr_SaveCharacterToFile_Public_Void_CharacterFileSaveFormat_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666140);
			CharacterCustomization.NativeMethodInfoPtr_RecalculateShapes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666141);
			CharacterCustomization.NativeMethodInfoPtr_EditorSavePreBuiltPrefab_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666142);
			CharacterCustomization.NativeMethodInfoPtr_BakeCharacter_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666143);
			CharacterCustomization.NativeMethodInfoPtr_ClearBake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666144);
			CharacterCustomization.NativeMethodInfoPtr_RecalculateLOD_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666145);
			CharacterCustomization.NativeMethodInfoPtr_SetLODRange_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666146);
			CharacterCustomization.NativeMethodInfoPtr_IsBaked_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666147);
			CharacterCustomization.NativeMethodInfoPtr_GetElementsPreset_Public_CharacterElementsPreset_CharacterElementType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666148);
			CharacterCustomization.NativeMethodInfoPtr_GetElementsPreset_Public_CharacterElementsPreset_CharacterElementType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666149);
			CharacterCustomization.NativeMethodInfoPtr_GetElementsPresets_Public_List_1_CharacterElementsPreset_CharacterElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666150);
			CharacterCustomization.NativeMethodInfoPtr_PlayBlendshapeAnimation_Public_Void_String_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666151);
			CharacterCustomization.NativeMethodInfoPtr_StopBlendshapeAnimations_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666152);
			CharacterCustomization.NativeMethodInfoPtr_ResetAll_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666153);
			CharacterCustomization.NativeMethodInfoPtr_Randomize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666154);
			CharacterCustomization.NativeMethodInfoPtr_GetAnimator_Public_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666155);
			CharacterCustomization.NativeMethodInfoPtr_UnlockPrefab_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666156);
			CharacterCustomization.NativeMethodInfoPtr_LockPrefab_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666157);
			CharacterCustomization.NativeMethodInfoPtr_ApplyPrefab_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666158);
			CharacterCustomization.NativeMethodInfoPtr_RevertBonesChanges_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666159);
			CharacterCustomization.NativeMethodInfoPtr_ApplyPrefabInPlaymode_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666160);
			CharacterCustomization.NativeMethodInfoPtr_UpdateActualCharacterInstanceStatus_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666161);
			CharacterCustomization.NativeMethodInfoPtr_GetCharacterInstanceStatus_Public_CharacterInstanceStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666162);
			CharacterCustomization.NativeMethodInfoPtr_SetNewCharacterInstanceStatus_Public_Void_CharacterInstanceStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666163);
			CharacterCustomization.NativeMethodInfoPtr_GetBlendshapeData_Public_CharacterBlendshapeData_CharacterBlendShapeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666164);
			CharacterCustomization.NativeMethodInfoPtr_GetBlendshapeData_Public_CharacterBlendshapeData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666165);
			CharacterCustomization.NativeMethodInfoPtr_GetBlendshapeDatasByGroup_Public_List_1_CharacterBlendshapeData_CharacterBlendShapeGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666166);
			CharacterCustomization.NativeMethodInfoPtr_DestroyObjects_Private_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666167);
			CharacterCustomization.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666168);
			CharacterCustomization.NativeMethodInfoPtr_Method_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666169);
			CharacterCustomization.NativeMethodInfoPtr__BakeCharacter_b__77_1_Private_Void_List_1_SkinnedMeshRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666170);
			CharacterCustomization.NativeMethodInfoPtr__ClearBake_b__78_0_Private_Void_SkinnedMeshRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, 100666171);
		}

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x06001A76 RID: 6774 RVA: 0x000C3B9C File Offset: 0x000C1D9C
		public unsafe CharacterSettings Settings
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19644, RefRangeEnd = 19658, XrefRangeStart = 19644, XrefRangeEnd = 19658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_get_Settings_Public_get_CharacterSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterSettings>(intPtr3) : null;
			}
		}

		// Token: 0x06001A77 RID: 6775 RVA: 0x000C3BDC File Offset: 0x000C1DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97282, XrefRangeEnd = 97289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A78 RID: 6776 RVA: 0x000C3C10 File Offset: 0x000C1E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97289, XrefRangeEnd = 97290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A79 RID: 6777 RVA: 0x000C3C44 File Offset: 0x000C1E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97290, XrefRangeEnd = 97291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A7A RID: 6778 RVA: 0x000C3C78 File Offset: 0x000C1E78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 97309, RefRangeEnd = 97310, XrefRangeStart = 97291, XrefRangeEnd = 97309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AnimationTick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_AnimationTick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A7B RID: 6779 RVA: 0x000C3CAC File Offset: 0x000C1EAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 97315, RefRangeEnd = 97316, XrefRangeStart = 97310, XrefRangeEnd = 97315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwitchCharacterSettings(int settingsIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref settingsIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_SwitchCharacterSettings_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A7C RID: 6780 RVA: 0x000C3CEC File Offset: 0x000C1EEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 97323, RefRangeEnd = 97324, XrefRangeStart = 97316, XrefRangeEnd = 97323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwitchCharacterSettings(string selectorName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(selectorName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_SwitchCharacterSettings_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A7D RID: 6781 RVA: 0x000C3D30 File Offset: 0x000C1F30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 97720, RefRangeEnd = 97722, XrefRangeStart = 97324, XrefRangeEnd = 97720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeMeshes(CharacterSettings newSettings = null, bool resetAll = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newSettings);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resetAll;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_InitializeMeshes_Public_Void_CharacterSettings_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A7E RID: 6782 RVA: 0x000C3D80 File Offset: 0x000C1F80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 97748, RefRangeEnd = 97749, XrefRangeStart = 97722, XrefRangeEnd = 97748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSkinnedMeshesOffscreenBounds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_UpdateSkinnedMeshesOffscreenBounds_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A7F RID: 6783 RVA: 0x000C3DB4 File Offset: 0x000C1FB4
		[CallerCount(0)]
		public unsafe List<CharacterSettingsSelector> GetCharacterSettingsSelectors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_GetCharacterSettingsSelectors_Public_List_1_CharacterSettingsSelector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<CharacterSettingsSelector>>(intPtr3) : null;
		}

		// Token: 0x06001A80 RID: 6784 RVA: 0x000C3DF4 File Offset: 0x000C1FF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 97877, RefRangeEnd = 97879, XrefRangeStart = 97749, XrefRangeEnd = 97877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetBodyMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_ResetBodyMaterial_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A81 RID: 6785 RVA: 0x000C3E28 File Offset: 0x000C2028
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 97894, RefRangeEnd = 97896, XrefRangeStart = 97879, XrefRangeEnd = 97894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitColors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_InitColors_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A82 RID: 6786 RVA: 0x000C3E5C File Offset: 0x000C205C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 97932, RefRangeEnd = 97933, XrefRangeStart = 97896, XrefRangeEnd = 97932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetBodyColors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_ResetBodyColors_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x000C3E90 File Offset: 0x000C2090
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 98055, RefRangeEnd = 98072, XrefRangeStart = 97933, XrefRangeEnd = 98055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBlendshapeValue(CharacterBlendShapeType type, float weight, Il2CppStringArray forPart = null, Il2CppStructArray<CharacterElementType> forClothPart = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weight;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(forPart);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(forClothPart);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_SetBlendshapeValue_Public_Void_CharacterBlendShapeType_Single_Il2CppStringArray_Il2CppStructArray_1_CharacterElementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A84 RID: 6788 RVA: 0x000C3F04 File Offset: 0x000C2104
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98073, RefRangeEnd = 98074, XrefRangeStart = 98072, XrefRangeEnd = 98073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForceLOD(int lodLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lodLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_ForceLOD_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A85 RID: 6789 RVA: 0x000C3F44 File Offset: 0x000C2144
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 98209, RefRangeEnd = 98227, XrefRangeStart = 98074, XrefRangeEnd = 98209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetElementByIndex(CharacterElementType type, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_SetElementByIndex_Public_Void_CharacterElementType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A86 RID: 6790 RVA: 0x000C3F90 File Offset: 0x000C2190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98227, XrefRangeEnd = 98230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearElement(CharacterElementType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_ClearElement_Public_Void_CharacterElementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A87 RID: 6791 RVA: 0x000C3FD0 File Offset: 0x000C21D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 98235, RefRangeEnd = 98237, XrefRangeStart = 98230, XrefRangeEnd = 98235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHeight(float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_SetHeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A88 RID: 6792 RVA: 0x000C4010 File Offset: 0x000C2210
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 98246, RefRangeEnd = 98248, XrefRangeStart = 98237, XrefRangeEnd = 98246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHeadSize(float size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_SetHeadSize_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A89 RID: 6793 RVA: 0x000C4050 File Offset: 0x000C2250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98248, XrefRangeEnd = 98249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFeetOffset(Vector3 offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_SetFeetOffset_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A8A RID: 6794 RVA: 0x000C4090 File Offset: 0x000C2290
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 98282, RefRangeEnd = 98284, XrefRangeStart = 98249, XrefRangeEnd = 98282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHairByIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_SetHairByIndex_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A8B RID: 6795 RVA: 0x000C40D0 File Offset: 0x000C22D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 98316, RefRangeEnd = 98318, XrefRangeStart = 98284, XrefRangeEnd = 98316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBeardByIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_SetBeardByIndex_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A8C RID: 6796 RVA: 0x000C4110 File Offset: 0x000C2310
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 98328, RefRangeEnd = 98330, XrefRangeStart = 98318, XrefRangeEnd = 98328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClothesAnchor GetClothesAnchor(CharacterElementType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_GetClothesAnchor_Public_ClothesAnchor_CharacterElementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClothesAnchor>(intPtr3) : null;
		}

		// Token: 0x06001A8D RID: 6797 RVA: 0x000C415C File Offset: 0x000C235C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 98343, RefRangeEnd = 98354, XrefRangeStart = 98330, XrefRangeEnd = 98343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterPart GetCharacterPart(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_GetCharacterPart_Public_CharacterPart_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterPart>(intPtr3) : null;
		}

		// Token: 0x06001A8E RID: 6798 RVA: 0x000C41AC File Offset: 0x000C23AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98399, RefRangeEnd = 98400, XrefRangeStart = 98354, XrefRangeEnd = 98399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<SkinnedMeshRenderer> GetAllMeshesByLod(int lod)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lod;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_GetAllMeshesByLod_Public_List_1_SkinnedMeshRenderer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SkinnedMeshRenderer>>(intPtr3) : null;
		}

		// Token: 0x06001A8F RID: 6799 RVA: 0x000C41F8 File Offset: 0x000C23F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98439, RefRangeEnd = 98440, XrefRangeStart = 98400, XrefRangeEnd = 98439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<SkinnedMeshRenderer> GetAllMeshes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_GetAllMeshes_Public_List_1_SkinnedMeshRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SkinnedMeshRenderer>>(intPtr3) : null;
		}

		// Token: 0x06001A90 RID: 6800 RVA: 0x000C4238 File Offset: 0x000C2438
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98482, RefRangeEnd = 98483, XrefRangeStart = 98440, XrefRangeEnd = 98482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<SkinnedMeshRenderer> GetAllMeshes(bool onlyBodyMeshes = false, Il2CppStringArray excludeNames = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref onlyBodyMeshes;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(excludeNames);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_GetAllMeshes_Public_List_1_SkinnedMeshRenderer_Boolean_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SkinnedMeshRenderer>>(intPtr3) : null;
		}

		// Token: 0x06001A91 RID: 6801 RVA: 0x000C4298 File Offset: 0x000C2498
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98516, RefRangeEnd = 98517, XrefRangeStart = 98483, XrefRangeEnd = 98516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HideParts(Il2CppStringArray parts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parts);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_HideParts_Public_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A92 RID: 6802 RVA: 0x000C42DC File Offset: 0x000C24DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98563, RefRangeEnd = 98564, XrefRangeStart = 98517, XrefRangeEnd = 98563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnHideParts(Il2CppStringArray parts, CharacterElementType hidePartsForElement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parts);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hidePartsForElement;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_UnHideParts_Public_Void_Il2CppStringArray_CharacterElementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A93 RID: 6803 RVA: 0x000C432C File Offset: 0x000C252C
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 98632, RefRangeEnd = 98661, XrefRangeStart = 98564, XrefRangeEnd = 98632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBodyColor(BodyColorPart bodyColorPart, Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref bodyColorPart;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_SetBodyColor_Public_Void_BodyColorPart_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A94 RID: 6804 RVA: 0x000C4378 File Offset: 0x000C2578
		[CallerCount(0)]
		public unsafe Color GetBodyColor(BodyColorPart bodyColorPart)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref bodyColorPart;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_GetBodyColor_Public_Color_BodyColorPart_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A95 RID: 6805 RVA: 0x000C43C4 File Offset: 0x000C25C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98661, XrefRangeEnd = 98663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCharacterSetup(CharacterCustomizationSetup characterCustomizationSetup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(characterCustomizationSetup);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_SetCharacterSetup_Public_Void_CharacterCustomizationSetup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A96 RID: 6806 RVA: 0x000C4408 File Offset: 0x000C2608
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98711, RefRangeEnd = 98712, XrefRangeStart = 98663, XrefRangeEnd = 98711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterCustomizationSetup GetSetup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_GetSetup_Public_CharacterCustomizationSetup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterCustomizationSetup>(intPtr3) : null;
		}

		// Token: 0x06001A97 RID: 6807 RVA: 0x000C4448 File Offset: 0x000C2648
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 98714, RefRangeEnd = 98716, XrefRangeStart = 98712, XrefRangeEnd = 98714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplySavedCharacterData(SavedCharacterData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_ApplySavedCharacterData_Public_Void_SavedCharacterData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A98 RID: 6808 RVA: 0x000C448C File Offset: 0x000C268C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98739, RefRangeEnd = 98740, XrefRangeStart = 98716, XrefRangeEnd = 98739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadCharacterFromFile(string path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_LoadCharacterFromFile_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A99 RID: 6809 RVA: 0x000C44D0 File Offset: 0x000C26D0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 98784, RefRangeEnd = 98788, XrefRangeStart = 98740, XrefRangeEnd = 98784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<SavedCharacterData> GetSavedCharacterDatas(string path = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_GetSavedCharacterDatas_Public_List_1_SavedCharacterData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SavedCharacterData>>(intPtr3) : null;
		}

		// Token: 0x06001A9A RID: 6810 RVA: 0x000C4520 File Offset: 0x000C2720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98788, XrefRangeEnd = 98790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearSavedData(SavedCharacterData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_ClearSavedData_Public_Void_SavedCharacterData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A9B RID: 6811 RVA: 0x000C4564 File Offset: 0x000C2764
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98820, RefRangeEnd = 98821, XrefRangeStart = 98790, XrefRangeEnd = 98820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearSavedData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_ClearSavedData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A9C RID: 6812 RVA: 0x000C4598 File Offset: 0x000C2798
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98905, RefRangeEnd = 98906, XrefRangeStart = 98821, XrefRangeEnd = 98905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveCharacterToFile(CharacterCustomizationSetup.CharacterFileSaveFormat format, string path = "", string name = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_SaveCharacterToFile_Public_Void_CharacterFileSaveFormat_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A9D RID: 6813 RVA: 0x000C45FC File Offset: 0x000C27FC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 98921, RefRangeEnd = 98924, XrefRangeStart = 98906, XrefRangeEnd = 98921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateShapes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_RecalculateShapes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A9E RID: 6814 RVA: 0x000C4630 File Offset: 0x000C2830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98924, XrefRangeEnd = 98930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EditorSavePreBuiltPrefab()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_EditorSavePreBuiltPrefab_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A9F RID: 6815 RVA: 0x000C4664 File Offset: 0x000C2864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98930, XrefRangeEnd = 98966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BakeCharacter(bool usePreBuiltMeshes = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref usePreBuiltMeshes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_BakeCharacter_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AA0 RID: 6816 RVA: 0x000C46A4 File Offset: 0x000C28A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98966, XrefRangeEnd = 99047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearBake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_ClearBake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AA1 RID: 6817 RVA: 0x000C46D8 File Offset: 0x000C28D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 99133, RefRangeEnd = 99135, XrefRangeStart = 99047, XrefRangeEnd = 99133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateLOD()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_RecalculateLOD_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AA2 RID: 6818 RVA: 0x000C470C File Offset: 0x000C290C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99135, XrefRangeEnd = 99136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLODRange(int minLod, int maxLod)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref minLod;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxLod;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_SetLODRange_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AA3 RID: 6819 RVA: 0x000C4758 File Offset: 0x000C2958
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99136, RefRangeEnd = 99137, XrefRangeStart = 99136, XrefRangeEnd = 99136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsBaked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_IsBaked_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AA4 RID: 6820 RVA: 0x000C4794 File Offset: 0x000C2994
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 99142, RefRangeEnd = 99149, XrefRangeStart = 99137, XrefRangeEnd = 99142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterElementsPreset GetElementsPreset(CharacterElementType type, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_GetElementsPreset_Public_CharacterElementsPreset_CharacterElementType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterElementsPreset>(intPtr3) : null;
		}

		// Token: 0x06001AA5 RID: 6821 RVA: 0x000C47F0 File Offset: 0x000C29F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99149, XrefRangeEnd = 99165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterElementsPreset GetElementsPreset(CharacterElementType type, string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_GetElementsPreset_Public_CharacterElementsPreset_CharacterElementType_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterElementsPreset>(intPtr3) : null;
		}

		// Token: 0x06001AA6 RID: 6822 RVA: 0x000C4850 File Offset: 0x000C2A50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 99165, RefRangeEnd = 99167, XrefRangeStart = 99165, XrefRangeEnd = 99165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<CharacterElementsPreset> GetElementsPresets(CharacterElementType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_GetElementsPresets_Public_List_1_CharacterElementsPreset_CharacterElementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<CharacterElementsPreset>>(intPtr3) : null;
		}

		// Token: 0x06001AA7 RID: 6823 RVA: 0x000C489C File Offset: 0x000C2A9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99227, RefRangeEnd = 99228, XrefRangeStart = 99167, XrefRangeEnd = 99227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayBlendshapeAnimation(string animationName, float duration = 1f, float weightPower = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(animationName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weightPower;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_PlayBlendshapeAnimation_Public_Void_String_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AA8 RID: 6824 RVA: 0x000C48FC File Offset: 0x000C2AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99228, XrefRangeEnd = 99236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopBlendshapeAnimations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_StopBlendshapeAnimations_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AA9 RID: 6825 RVA: 0x000C4930 File Offset: 0x000C2B30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99329, RefRangeEnd = 99330, XrefRangeStart = 99236, XrefRangeEnd = 99329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetAll(bool ignore_settingsDefaultElements = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref ignore_settingsDefaultElements;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_ResetAll_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AAA RID: 6826 RVA: 0x000C4970 File Offset: 0x000C2B70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99331, RefRangeEnd = 99332, XrefRangeStart = 99330, XrefRangeEnd = 99331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Randomize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_Randomize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AAB RID: 6827 RVA: 0x000C49A4 File Offset: 0x000C2BA4
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 22951, RefRangeEnd = 22968, XrefRangeStart = 22951, XrefRangeEnd = 22968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Animator GetAnimator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_GetAnimator_Public_Animator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr3) : null;
		}

		// Token: 0x06001AAC RID: 6828 RVA: 0x000C49E4 File Offset: 0x000C2BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99332, XrefRangeEnd = 99336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnlockPrefab()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_UnlockPrefab_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AAD RID: 6829 RVA: 0x000C4A18 File Offset: 0x000C2C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99336, XrefRangeEnd = 99340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LockPrefab(string custompath = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(custompath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_LockPrefab_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x000C4A5C File Offset: 0x000C2C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99340, XrefRangeEnd = 99346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyPrefab()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_ApplyPrefab_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AAF RID: 6831 RVA: 0x000C4A90 File Offset: 0x000C2C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99346, XrefRangeEnd = 99364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RevertBonesChanges()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_RevertBonesChanges_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AB0 RID: 6832 RVA: 0x000C4AC4 File Offset: 0x000C2CC4
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyPrefabInPlaymode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_ApplyPrefabInPlaymode_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AB1 RID: 6833 RVA: 0x000C4AF8 File Offset: 0x000C2CF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99364, XrefRangeEnd = 99368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateActualCharacterInstanceStatus(bool igroneUserNonPrefab = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref igroneUserNonPrefab;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_UpdateActualCharacterInstanceStatus_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AB2 RID: 6834 RVA: 0x000C4B38 File Offset: 0x000C2D38
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 42845, RefRangeEnd = 42849, XrefRangeStart = 42845, XrefRangeEnd = 42849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterInstanceStatus GetCharacterInstanceStatus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_GetCharacterInstanceStatus_Public_CharacterInstanceStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AB3 RID: 6835 RVA: 0x000C4B74 File Offset: 0x000C2D74
		[CallerCount(0)]
		public unsafe void SetNewCharacterInstanceStatus(CharacterInstanceStatus characterInstanceStatus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref characterInstanceStatus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_SetNewCharacterInstanceStatus_Public_Void_CharacterInstanceStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AB4 RID: 6836 RVA: 0x000C4BB4 File Offset: 0x000C2DB4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 99378, RefRangeEnd = 99382, XrefRangeStart = 99368, XrefRangeEnd = 99378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterBlendshapeData GetBlendshapeData(CharacterBlendShapeType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_GetBlendshapeData_Public_CharacterBlendshapeData_CharacterBlendShapeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterBlendshapeData>(intPtr3) : null;
		}

		// Token: 0x06001AB5 RID: 6837 RVA: 0x000C4C00 File Offset: 0x000C2E00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99393, RefRangeEnd = 99394, XrefRangeStart = 99382, XrefRangeEnd = 99393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterBlendshapeData GetBlendshapeData(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_GetBlendshapeData_Public_CharacterBlendshapeData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterBlendshapeData>(intPtr3) : null;
		}

		// Token: 0x06001AB6 RID: 6838 RVA: 0x000C4C50 File Offset: 0x000C2E50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99417, RefRangeEnd = 99418, XrefRangeStart = 99394, XrefRangeEnd = 99417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<CharacterBlendshapeData> GetBlendshapeDatasByGroup(CharacterBlendShapeGroup group)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref group;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_GetBlendshapeDatasByGroup_Public_List_1_CharacterBlendshapeData_CharacterBlendShapeGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<CharacterBlendshapeData>>(intPtr3) : null;
		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x000C4C9C File Offset: 0x000C2E9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99426, RefRangeEnd = 99427, XrefRangeStart = 99418, XrefRangeEnd = 99426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyObjects(Il2CppReferenceArray<UnityEngine.Object> objects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_DestroyObjects_Private_Void_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AB8 RID: 6840 RVA: 0x000C4CE0 File Offset: 0x000C2EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99427, XrefRangeEnd = 99457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterCustomization() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AB9 RID: 6841 RVA: 0x000C4D1C File Offset: 0x000C2F1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99565, RefRangeEnd = 99566, XrefRangeStart = 99457, XrefRangeEnd = 99565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_Boolean_0(bool usePreBuilt = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref usePreBuilt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr_Method_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ABA RID: 6842 RVA: 0x000C4D5C File Offset: 0x000C2F5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99566, XrefRangeEnd = 99567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _BakeCharacter_b__77_1(List<SkinnedMeshRenderer> meshes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(meshes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr__BakeCharacter_b__77_1_Private_Void_List_1_SkinnedMeshRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ABB RID: 6843 RVA: 0x000C4DA0 File Offset: 0x000C2FA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99567, XrefRangeEnd = 99584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ClearBake_b__78_0(SkinnedMeshRenderer m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.NativeMethodInfoPtr__ClearBake_b__78_0_Private_Void_SkinnedMeshRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ABC RID: 6844 RVA: 0x0000EFF5 File Offset: 0x0000D1F5
		public CharacterCustomization(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x06001ABD RID: 6845 RVA: 0x000C4DE4 File Offset: 0x000C2FE4
		// (set) Token: 0x06001ABE RID: 6846 RVA: 0x0000EFFE File Offset: 0x0000D1FE
		public unsafe bool isSettingsExpanded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_isSettingsExpanded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_isSettingsExpanded)) = value;
			}
		}

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x06001ABF RID: 6847 RVA: 0x000C4E0C File Offset: 0x000C300C
		// (set) Token: 0x06001AC0 RID: 6848 RVA: 0x0000F019 File Offset: 0x0000D219
		public unsafe CharacterSettings selectedsettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_selectedsettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_selectedsettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x06001AC1 RID: 6849 RVA: 0x000C4E3C File Offset: 0x000C303C
		// (set) Token: 0x06001AC2 RID: 6850 RVA: 0x0000F038 File Offset: 0x0000D238
		public unsafe CharacterSettings _settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr__settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr__settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x06001AC3 RID: 6851 RVA: 0x000C4E6C File Offset: 0x000C306C
		// (set) Token: 0x06001AC4 RID: 6852 RVA: 0x0000F057 File Offset: 0x0000D257
		public unsafe List<CharacterPart> characterParts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_characterParts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CharacterPart>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_characterParts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x06001AC5 RID: 6853 RVA: 0x000C4E9C File Offset: 0x000C309C
		// (set) Token: 0x06001AC6 RID: 6854 RVA: 0x0000F076 File Offset: 0x0000D276
		public unsafe string prefabPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_prefabPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_prefabPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x06001AC7 RID: 6855 RVA: 0x000C4EC4 File Offset: 0x000C30C4
		// (set) Token: 0x06001AC8 RID: 6856 RVA: 0x0000F095 File Offset: 0x0000D295
		public unsafe CharacterInstanceStatus instanceStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_instanceStatus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_instanceStatus)) = value;
			}
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x06001AC9 RID: 6857 RVA: 0x000C4EEC File Offset: 0x000C30EC
		// (set) Token: 0x06001ACA RID: 6858 RVA: 0x0000F0B0 File Offset: 0x0000D2B0
		public unsafe Transform originHip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_originHip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_originHip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x06001ACB RID: 6859 RVA: 0x000C4F1C File Offset: 0x000C311C
		// (set) Token: 0x06001ACC RID: 6860 RVA: 0x0000F0CF File Offset: 0x0000D2CF
		public unsafe Transform headHip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_headHip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_headHip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x06001ACD RID: 6861 RVA: 0x000C4F4C File Offset: 0x000C314C
		// (set) Token: 0x06001ACE RID: 6862 RVA: 0x0000F0EE File Offset: 0x0000D2EE
		public unsafe List<ClothesAnchor> clothesAnchors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_clothesAnchors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ClothesAnchor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_clothesAnchors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x06001ACF RID: 6863 RVA: 0x000C4F7C File Offset: 0x000C317C
		// (set) Token: 0x06001AD0 RID: 6864 RVA: 0x0000F10D File Offset: 0x0000D30D
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x06001AD1 RID: 6865 RVA: 0x000C4FAC File Offset: 0x000C31AC
		// (set) Token: 0x06001AD2 RID: 6866 RVA: 0x0000F12C File Offset: 0x0000D32C
		public unsafe CharacterSelectedElements characterSelectedElements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_characterSelectedElements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSelectedElements>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_characterSelectedElements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x06001AD3 RID: 6867 RVA: 0x000C4FDC File Offset: 0x000C31DC
		// (set) Token: 0x06001AD4 RID: 6868 RVA: 0x0000F14B File Offset: 0x0000D34B
		public unsafe float heightValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_heightValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_heightValue)) = value;
			}
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x06001AD5 RID: 6869 RVA: 0x000C5004 File Offset: 0x000C3204
		// (set) Token: 0x06001AD6 RID: 6870 RVA: 0x0000F166 File Offset: 0x0000D366
		public unsafe float headSizeValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_headSizeValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_headSizeValue)) = value;
			}
		}

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x06001AD7 RID: 6871 RVA: 0x000C502C File Offset: 0x000C322C
		// (set) Token: 0x06001AD8 RID: 6872 RVA: 0x0000F181 File Offset: 0x0000D381
		public unsafe float feetOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_feetOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_feetOffset)) = value;
			}
		}

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x06001AD9 RID: 6873 RVA: 0x000C5054 File Offset: 0x000C3254
		// (set) Token: 0x06001ADA RID: 6874 RVA: 0x0000F19C File Offset: 0x0000D39C
		public unsafe List<CharacterBlendshapeData> characterBlendshapeDatas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_characterBlendshapeDatas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CharacterBlendshapeData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_characterBlendshapeDatas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x06001ADB RID: 6875 RVA: 0x000C5084 File Offset: 0x000C3284
		// (set) Token: 0x06001ADC RID: 6876 RVA: 0x0000F1BB File Offset: 0x0000D3BB
		public unsafe Color Skin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_Skin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_Skin)) = value;
			}
		}

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x06001ADD RID: 6877 RVA: 0x000C50AC File Offset: 0x000C32AC
		// (set) Token: 0x06001ADE RID: 6878 RVA: 0x0000F1D6 File Offset: 0x0000D3D6
		public unsafe Color Eye
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_Eye);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_Eye)) = value;
			}
		}

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x06001ADF RID: 6879 RVA: 0x000C50D4 File Offset: 0x000C32D4
		// (set) Token: 0x06001AE0 RID: 6880 RVA: 0x0000F1F1 File Offset: 0x0000D3F1
		public unsafe Color Hair
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_Hair);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_Hair)) = value;
			}
		}

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x06001AE1 RID: 6881 RVA: 0x000C50FC File Offset: 0x000C32FC
		// (set) Token: 0x06001AE2 RID: 6882 RVA: 0x0000F20C File Offset: 0x0000D40C
		public unsafe Color Underpants
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_Underpants);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_Underpants)) = value;
			}
		}

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x06001AE3 RID: 6883 RVA: 0x000C5124 File Offset: 0x000C3324
		// (set) Token: 0x06001AE4 RID: 6884 RVA: 0x0000F227 File Offset: 0x0000D427
		public unsafe Color OralCavity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_OralCavity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_OralCavity)) = value;
			}
		}

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x06001AE5 RID: 6885 RVA: 0x000C514C File Offset: 0x000C334C
		// (set) Token: 0x06001AE6 RID: 6886 RVA: 0x0000F242 File Offset: 0x0000D442
		public unsafe Color Teeth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_Teeth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_Teeth)) = value;
			}
		}

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x06001AE7 RID: 6887 RVA: 0x000C5174 File Offset: 0x000C3374
		// (set) Token: 0x06001AE8 RID: 6888 RVA: 0x0000F25D File Offset: 0x0000D45D
		public unsafe MaterialPropertyBlock bodyPropertyBlock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_bodyPropertyBlock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaterialPropertyBlock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_bodyPropertyBlock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x06001AE9 RID: 6889 RVA: 0x000C51A4 File Offset: 0x000C33A4
		// (set) Token: 0x06001AEA RID: 6890 RVA: 0x0000F27C File Offset: 0x0000D47C
		public unsafe CurrentBlendshapeAnimation currentBlendshapeAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_currentBlendshapeAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CurrentBlendshapeAnimation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_currentBlendshapeAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x06001AEB RID: 6891 RVA: 0x000C51D4 File Offset: 0x000C33D4
		// (set) Token: 0x06001AEC RID: 6892 RVA: 0x0000F29B File Offset: 0x0000D49B
		public unsafe CombinerState CurrentCombinerState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_CurrentCombinerState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_CurrentCombinerState)) = value;
			}
		}

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x06001AED RID: 6893 RVA: 0x000C51FC File Offset: 0x000C33FC
		// (set) Token: 0x06001AEE RID: 6894 RVA: 0x0000F2B6 File Offset: 0x0000D4B6
		public unsafe CharacterPreBuilt combinedCharacter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_combinedCharacter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterPreBuilt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_combinedCharacter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x06001AEF RID: 6895 RVA: 0x000C522C File Offset: 0x000C342C
		// (set) Token: 0x06001AF0 RID: 6896 RVA: 0x0000F2D5 File Offset: 0x0000D4D5
		public unsafe Transform ProbesAnchorOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_ProbesAnchorOverride);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_ProbesAnchorOverride), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x06001AF1 RID: 6897 RVA: 0x000C525C File Offset: 0x000C345C
		// (set) Token: 0x06001AF2 RID: 6898 RVA: 0x0000F2F4 File Offset: 0x0000D4F4
		public unsafe CharacterGeneratorSettings CharacterGenerator_settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_CharacterGenerator_settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterGeneratorSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_CharacterGenerator_settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x06001AF3 RID: 6899 RVA: 0x000C528C File Offset: 0x000C348C
		// (set) Token: 0x06001AF4 RID: 6900 RVA: 0x0000F313 File Offset: 0x0000D513
		public unsafe bool UpdateWhenOffscreenMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_UpdateWhenOffscreenMeshes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_UpdateWhenOffscreenMeshes)) = value;
			}
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x06001AF5 RID: 6901 RVA: 0x000C52B4 File Offset: 0x000C34B4
		// (set) Token: 0x06001AF6 RID: 6902 RVA: 0x0000F32E File Offset: 0x0000D52E
		public unsafe int MinLODLevels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_MinLODLevels);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_MinLODLevels)) = value;
			}
		}

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x06001AF7 RID: 6903 RVA: 0x000C52DC File Offset: 0x000C34DC
		// (set) Token: 0x06001AF8 RID: 6904 RVA: 0x0000F349 File Offset: 0x0000D549
		public unsafe int MaxLODLevels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_MaxLODLevels);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_MaxLODLevels)) = value;
			}
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x06001AF9 RID: 6905 RVA: 0x000C5304 File Offset: 0x000C3504
		// (set) Token: 0x06001AFA RID: 6906 RVA: 0x0000F364 File Offset: 0x0000D564
		public unsafe LODGroup _lodGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr__lodGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LODGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr__lodGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x06001AFB RID: 6907 RVA: 0x000C5334 File Offset: 0x000C3534
		// (set) Token: 0x06001AFC RID: 6908 RVA: 0x0000F383 File Offset: 0x0000D583
		public unsafe Transform _transform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr__transform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr__transform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x06001AFD RID: 6909 RVA: 0x000C5364 File Offset: 0x000C3564
		// (set) Token: 0x06001AFE RID: 6910 RVA: 0x0000F3A2 File Offset: 0x0000D5A2
		public unsafe bool applyFeetOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_applyFeetOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_applyFeetOffset)) = value;
			}
		}

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x06001AFF RID: 6911 RVA: 0x000C538C File Offset: 0x000C358C
		// (set) Token: 0x06001B00 RID: 6912 RVA: 0x0000F3BD File Offset: 0x0000D5BD
		public unsafe bool notAPP2Shader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_notAPP2Shader);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_notAPP2Shader)) = value;
			}
		}

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x06001B01 RID: 6913 RVA: 0x000C53B4 File Offset: 0x000C35B4
		// (set) Token: 0x06001B02 RID: 6914 RVA: 0x0000F3D8 File Offset: 0x0000D5D8
		public unsafe GameObject prebuiltPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_prebuiltPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.NativeFieldInfoPtr_prebuiltPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400115B RID: 4443
		private static readonly IntPtr NativeFieldInfoPtr_isSettingsExpanded;

		// Token: 0x0400115C RID: 4444
		private static readonly IntPtr NativeFieldInfoPtr_selectedsettings;

		// Token: 0x0400115D RID: 4445
		private static readonly IntPtr NativeFieldInfoPtr__settings;

		// Token: 0x0400115E RID: 4446
		private static readonly IntPtr NativeFieldInfoPtr_characterParts;

		// Token: 0x0400115F RID: 4447
		private static readonly IntPtr NativeFieldInfoPtr_prefabPath;

		// Token: 0x04001160 RID: 4448
		private static readonly IntPtr NativeFieldInfoPtr_instanceStatus;

		// Token: 0x04001161 RID: 4449
		private static readonly IntPtr NativeFieldInfoPtr_originHip;

		// Token: 0x04001162 RID: 4450
		private static readonly IntPtr NativeFieldInfoPtr_headHip;

		// Token: 0x04001163 RID: 4451
		private static readonly IntPtr NativeFieldInfoPtr_clothesAnchors;

		// Token: 0x04001164 RID: 4452
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x04001165 RID: 4453
		private static readonly IntPtr NativeFieldInfoPtr_characterSelectedElements;

		// Token: 0x04001166 RID: 4454
		private static readonly IntPtr NativeFieldInfoPtr_heightValue;

		// Token: 0x04001167 RID: 4455
		private static readonly IntPtr NativeFieldInfoPtr_headSizeValue;

		// Token: 0x04001168 RID: 4456
		private static readonly IntPtr NativeFieldInfoPtr_feetOffset;

		// Token: 0x04001169 RID: 4457
		private static readonly IntPtr NativeFieldInfoPtr_characterBlendshapeDatas;

		// Token: 0x0400116A RID: 4458
		private static readonly IntPtr NativeFieldInfoPtr_Skin;

		// Token: 0x0400116B RID: 4459
		private static readonly IntPtr NativeFieldInfoPtr_Eye;

		// Token: 0x0400116C RID: 4460
		private static readonly IntPtr NativeFieldInfoPtr_Hair;

		// Token: 0x0400116D RID: 4461
		private static readonly IntPtr NativeFieldInfoPtr_Underpants;

		// Token: 0x0400116E RID: 4462
		private static readonly IntPtr NativeFieldInfoPtr_OralCavity;

		// Token: 0x0400116F RID: 4463
		private static readonly IntPtr NativeFieldInfoPtr_Teeth;

		// Token: 0x04001170 RID: 4464
		private static readonly IntPtr NativeFieldInfoPtr_bodyPropertyBlock;

		// Token: 0x04001171 RID: 4465
		private static readonly IntPtr NativeFieldInfoPtr_currentBlendshapeAnimation;

		// Token: 0x04001172 RID: 4466
		private static readonly IntPtr NativeFieldInfoPtr_CurrentCombinerState;

		// Token: 0x04001173 RID: 4467
		private static readonly IntPtr NativeFieldInfoPtr_combinedCharacter;

		// Token: 0x04001174 RID: 4468
		private static readonly IntPtr NativeFieldInfoPtr_ProbesAnchorOverride;

		// Token: 0x04001175 RID: 4469
		private static readonly IntPtr NativeFieldInfoPtr_CharacterGenerator_settings;

		// Token: 0x04001176 RID: 4470
		private static readonly IntPtr NativeFieldInfoPtr_UpdateWhenOffscreenMeshes;

		// Token: 0x04001177 RID: 4471
		private static readonly IntPtr NativeFieldInfoPtr_MinLODLevels;

		// Token: 0x04001178 RID: 4472
		private static readonly IntPtr NativeFieldInfoPtr_MaxLODLevels;

		// Token: 0x04001179 RID: 4473
		private static readonly IntPtr NativeFieldInfoPtr__lodGroup;

		// Token: 0x0400117A RID: 4474
		private static readonly IntPtr NativeFieldInfoPtr__transform;

		// Token: 0x0400117B RID: 4475
		private static readonly IntPtr NativeFieldInfoPtr_applyFeetOffset;

		// Token: 0x0400117C RID: 4476
		private static readonly IntPtr NativeFieldInfoPtr_notAPP2Shader;

		// Token: 0x0400117D RID: 4477
		private static readonly IntPtr NativeFieldInfoPtr_prebuiltPrefab;

		// Token: 0x0400117E RID: 4478
		private static readonly IntPtr NativeMethodInfoPtr_get_Settings_Public_get_CharacterSettings_0;

		// Token: 0x0400117F RID: 4479
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04001180 RID: 4480
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001181 RID: 4481
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04001182 RID: 4482
		private static readonly IntPtr NativeMethodInfoPtr_AnimationTick_Public_Void_0;

		// Token: 0x04001183 RID: 4483
		private static readonly IntPtr NativeMethodInfoPtr_SwitchCharacterSettings_Public_Void_Int32_0;

		// Token: 0x04001184 RID: 4484
		private static readonly IntPtr NativeMethodInfoPtr_SwitchCharacterSettings_Public_Void_String_0;

		// Token: 0x04001185 RID: 4485
		private static readonly IntPtr NativeMethodInfoPtr_InitializeMeshes_Public_Void_CharacterSettings_Boolean_0;

		// Token: 0x04001186 RID: 4486
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSkinnedMeshesOffscreenBounds_Public_Void_0;

		// Token: 0x04001187 RID: 4487
		private static readonly IntPtr NativeMethodInfoPtr_GetCharacterSettingsSelectors_Public_List_1_CharacterSettingsSelector_0;

		// Token: 0x04001188 RID: 4488
		private static readonly IntPtr NativeMethodInfoPtr_ResetBodyMaterial_Public_Void_0;

		// Token: 0x04001189 RID: 4489
		private static readonly IntPtr NativeMethodInfoPtr_InitColors_Public_Void_0;

		// Token: 0x0400118A RID: 4490
		private static readonly IntPtr NativeMethodInfoPtr_ResetBodyColors_Public_Void_0;

		// Token: 0x0400118B RID: 4491
		private static readonly IntPtr NativeMethodInfoPtr_SetBlendshapeValue_Public_Void_CharacterBlendShapeType_Single_Il2CppStringArray_Il2CppStructArray_1_CharacterElementType_0;

		// Token: 0x0400118C RID: 4492
		private static readonly IntPtr NativeMethodInfoPtr_ForceLOD_Public_Void_Int32_0;

		// Token: 0x0400118D RID: 4493
		private static readonly IntPtr NativeMethodInfoPtr_SetElementByIndex_Public_Void_CharacterElementType_Int32_0;

		// Token: 0x0400118E RID: 4494
		private static readonly IntPtr NativeMethodInfoPtr_ClearElement_Public_Void_CharacterElementType_0;

		// Token: 0x0400118F RID: 4495
		private static readonly IntPtr NativeMethodInfoPtr_SetHeight_Public_Void_Single_0;

		// Token: 0x04001190 RID: 4496
		private static readonly IntPtr NativeMethodInfoPtr_SetHeadSize_Public_Void_Single_0;

		// Token: 0x04001191 RID: 4497
		private static readonly IntPtr NativeMethodInfoPtr_SetFeetOffset_Public_Void_Vector3_0;

		// Token: 0x04001192 RID: 4498
		private static readonly IntPtr NativeMethodInfoPtr_SetHairByIndex_Private_Void_Int32_0;

		// Token: 0x04001193 RID: 4499
		private static readonly IntPtr NativeMethodInfoPtr_SetBeardByIndex_Private_Void_Int32_0;

		// Token: 0x04001194 RID: 4500
		private static readonly IntPtr NativeMethodInfoPtr_GetClothesAnchor_Public_ClothesAnchor_CharacterElementType_0;

		// Token: 0x04001195 RID: 4501
		private static readonly IntPtr NativeMethodInfoPtr_GetCharacterPart_Public_CharacterPart_String_0;

		// Token: 0x04001196 RID: 4502
		private static readonly IntPtr NativeMethodInfoPtr_GetAllMeshesByLod_Public_List_1_SkinnedMeshRenderer_Int32_0;

		// Token: 0x04001197 RID: 4503
		private static readonly IntPtr NativeMethodInfoPtr_GetAllMeshes_Public_List_1_SkinnedMeshRenderer_0;

		// Token: 0x04001198 RID: 4504
		private static readonly IntPtr NativeMethodInfoPtr_GetAllMeshes_Public_List_1_SkinnedMeshRenderer_Boolean_Il2CppStringArray_0;

		// Token: 0x04001199 RID: 4505
		private static readonly IntPtr NativeMethodInfoPtr_HideParts_Public_Void_Il2CppStringArray_0;

		// Token: 0x0400119A RID: 4506
		private static readonly IntPtr NativeMethodInfoPtr_UnHideParts_Public_Void_Il2CppStringArray_CharacterElementType_0;

		// Token: 0x0400119B RID: 4507
		private static readonly IntPtr NativeMethodInfoPtr_SetBodyColor_Public_Void_BodyColorPart_Color_0;

		// Token: 0x0400119C RID: 4508
		private static readonly IntPtr NativeMethodInfoPtr_GetBodyColor_Public_Color_BodyColorPart_0;

		// Token: 0x0400119D RID: 4509
		private static readonly IntPtr NativeMethodInfoPtr_SetCharacterSetup_Public_Void_CharacterCustomizationSetup_0;

		// Token: 0x0400119E RID: 4510
		private static readonly IntPtr NativeMethodInfoPtr_GetSetup_Public_CharacterCustomizationSetup_0;

		// Token: 0x0400119F RID: 4511
		private static readonly IntPtr NativeMethodInfoPtr_ApplySavedCharacterData_Public_Void_SavedCharacterData_0;

		// Token: 0x040011A0 RID: 4512
		private static readonly IntPtr NativeMethodInfoPtr_LoadCharacterFromFile_Public_Void_String_0;

		// Token: 0x040011A1 RID: 4513
		private static readonly IntPtr NativeMethodInfoPtr_GetSavedCharacterDatas_Public_List_1_SavedCharacterData_String_0;

		// Token: 0x040011A2 RID: 4514
		private static readonly IntPtr NativeMethodInfoPtr_ClearSavedData_Public_Void_SavedCharacterData_0;

		// Token: 0x040011A3 RID: 4515
		private static readonly IntPtr NativeMethodInfoPtr_ClearSavedData_Public_Void_0;

		// Token: 0x040011A4 RID: 4516
		private static readonly IntPtr NativeMethodInfoPtr_SaveCharacterToFile_Public_Void_CharacterFileSaveFormat_String_String_0;

		// Token: 0x040011A5 RID: 4517
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateShapes_Public_Void_0;

		// Token: 0x040011A6 RID: 4518
		private static readonly IntPtr NativeMethodInfoPtr_EditorSavePreBuiltPrefab_Public_Void_0;

		// Token: 0x040011A7 RID: 4519
		private static readonly IntPtr NativeMethodInfoPtr_BakeCharacter_Public_Void_Boolean_0;

		// Token: 0x040011A8 RID: 4520
		private static readonly IntPtr NativeMethodInfoPtr_ClearBake_Public_Void_0;

		// Token: 0x040011A9 RID: 4521
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateLOD_Public_Void_0;

		// Token: 0x040011AA RID: 4522
		private static readonly IntPtr NativeMethodInfoPtr_SetLODRange_Public_Void_Int32_Int32_0;

		// Token: 0x040011AB RID: 4523
		private static readonly IntPtr NativeMethodInfoPtr_IsBaked_Public_Boolean_0;

		// Token: 0x040011AC RID: 4524
		private static readonly IntPtr NativeMethodInfoPtr_GetElementsPreset_Public_CharacterElementsPreset_CharacterElementType_Int32_0;

		// Token: 0x040011AD RID: 4525
		private static readonly IntPtr NativeMethodInfoPtr_GetElementsPreset_Public_CharacterElementsPreset_CharacterElementType_String_0;

		// Token: 0x040011AE RID: 4526
		private static readonly IntPtr NativeMethodInfoPtr_GetElementsPresets_Public_List_1_CharacterElementsPreset_CharacterElementType_0;

		// Token: 0x040011AF RID: 4527
		private static readonly IntPtr NativeMethodInfoPtr_PlayBlendshapeAnimation_Public_Void_String_Single_Single_0;

		// Token: 0x040011B0 RID: 4528
		private static readonly IntPtr NativeMethodInfoPtr_StopBlendshapeAnimations_Public_Void_0;

		// Token: 0x040011B1 RID: 4529
		private static readonly IntPtr NativeMethodInfoPtr_ResetAll_Public_Void_Boolean_0;

		// Token: 0x040011B2 RID: 4530
		private static readonly IntPtr NativeMethodInfoPtr_Randomize_Public_Void_0;

		// Token: 0x040011B3 RID: 4531
		private static readonly IntPtr NativeMethodInfoPtr_GetAnimator_Public_Animator_0;

		// Token: 0x040011B4 RID: 4532
		private static readonly IntPtr NativeMethodInfoPtr_UnlockPrefab_Public_Void_0;

		// Token: 0x040011B5 RID: 4533
		private static readonly IntPtr NativeMethodInfoPtr_LockPrefab_Public_Void_String_0;

		// Token: 0x040011B6 RID: 4534
		private static readonly IntPtr NativeMethodInfoPtr_ApplyPrefab_Public_Void_0;

		// Token: 0x040011B7 RID: 4535
		private static readonly IntPtr NativeMethodInfoPtr_RevertBonesChanges_Public_Void_0;

		// Token: 0x040011B8 RID: 4536
		private static readonly IntPtr NativeMethodInfoPtr_ApplyPrefabInPlaymode_Public_Void_0;

		// Token: 0x040011B9 RID: 4537
		private static readonly IntPtr NativeMethodInfoPtr_UpdateActualCharacterInstanceStatus_Public_Void_Boolean_0;

		// Token: 0x040011BA RID: 4538
		private static readonly IntPtr NativeMethodInfoPtr_GetCharacterInstanceStatus_Public_CharacterInstanceStatus_0;

		// Token: 0x040011BB RID: 4539
		private static readonly IntPtr NativeMethodInfoPtr_SetNewCharacterInstanceStatus_Public_Void_CharacterInstanceStatus_0;

		// Token: 0x040011BC RID: 4540
		private static readonly IntPtr NativeMethodInfoPtr_GetBlendshapeData_Public_CharacterBlendshapeData_CharacterBlendShapeType_0;

		// Token: 0x040011BD RID: 4541
		private static readonly IntPtr NativeMethodInfoPtr_GetBlendshapeData_Public_CharacterBlendshapeData_String_0;

		// Token: 0x040011BE RID: 4542
		private static readonly IntPtr NativeMethodInfoPtr_GetBlendshapeDatasByGroup_Public_List_1_CharacterBlendshapeData_CharacterBlendShapeGroup_0;

		// Token: 0x040011BF RID: 4543
		private static readonly IntPtr NativeMethodInfoPtr_DestroyObjects_Private_Void_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040011C0 RID: 4544
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040011C1 RID: 4545
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_Boolean_0;

		// Token: 0x040011C2 RID: 4546
		private static readonly IntPtr NativeMethodInfoPtr__BakeCharacter_b__77_1_Private_Void_List_1_SkinnedMeshRenderer_0;

		// Token: 0x040011C3 RID: 4547
		private static readonly IntPtr NativeMethodInfoPtr__ClearBake_b__78_0_Private_Void_SkinnedMeshRenderer_0;

		// Token: 0x0200085A RID: 2138
		[ObfuscatedName("AdvancedPeopleSystem.CharacterCustomization+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600C07B RID: 49275 RVA: 0x002F0FE0 File Offset: 0x002EF1E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CharacterCustomization.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCustomization.__c>.NativeClassPtr);
				CharacterCustomization.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization.__c>.NativeClassPtr, "<>9");
				CharacterCustomization.__c.NativeFieldInfoPtr___9__42_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization.__c>.NativeClassPtr, "<>9__42_1");
				CharacterCustomization.__c.NativeFieldInfoPtr___9__77_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization.__c>.NativeClassPtr, "<>9__77_2");
				CharacterCustomization.__c.NativeFieldInfoPtr___9__77_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization.__c>.NativeClassPtr, "<>9__77_3");
				CharacterCustomization.__c.NativeFieldInfoPtr___9__77_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization.__c>.NativeClassPtr, "<>9__77_4");
				CharacterCustomization.__c.NativeFieldInfoPtr___9__78_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization.__c>.NativeClassPtr, "<>9__78_1");
				CharacterCustomization.__c.NativeFieldInfoPtr___9__78_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization.__c>.NativeClassPtr, "<>9__78_2");
				CharacterCustomization.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization.__c>.NativeClassPtr, 100666173);
				CharacterCustomization.__c.NativeMethodInfoPtr__InitializeMeshes_b__42_1_Internal_Boolean_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization.__c>.NativeClassPtr, 100666174);
				CharacterCustomization.__c.NativeMethodInfoPtr__BakeCharacter_b__77_2_Internal_Void_SkinnedMeshRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization.__c>.NativeClassPtr, 100666175);
				CharacterCustomization.__c.NativeMethodInfoPtr__BakeCharacter_b__77_3_Internal_Void_SkinnedMeshRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization.__c>.NativeClassPtr, 100666176);
				CharacterCustomization.__c.NativeMethodInfoPtr__BakeCharacter_b__77_4_Internal_Void_SkinnedMeshRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization.__c>.NativeClassPtr, 100666177);
				CharacterCustomization.__c.NativeMethodInfoPtr__ClearBake_b__78_1_Internal_Void_SkinnedMeshRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization.__c>.NativeClassPtr, 100666178);
				CharacterCustomization.__c.NativeMethodInfoPtr__ClearBake_b__78_2_Internal_Void_SkinnedMeshRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization.__c>.NativeClassPtr, 100666179);
			}

			// Token: 0x0600C07C RID: 49276 RVA: 0x002F1124 File Offset: 0x002EF324
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCustomization.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C07D RID: 49277 RVA: 0x002F1160 File Offset: 0x002EF360
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97223, XrefRangeEnd = 97229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _InitializeMeshes_b__42_1(Transform f)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.__c.NativeMethodInfoPtr__InitializeMeshes_b__42_1_Internal_Boolean_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C07E RID: 49278 RVA: 0x002F11B0 File Offset: 0x002EF3B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97229, XrefRangeEnd = 97233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _BakeCharacter_b__77_2(SkinnedMeshRenderer m)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.__c.NativeMethodInfoPtr__BakeCharacter_b__77_2_Internal_Void_SkinnedMeshRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C07F RID: 49279 RVA: 0x002F11F4 File Offset: 0x002EF3F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97233, XrefRangeEnd = 97236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _BakeCharacter_b__77_3(SkinnedMeshRenderer m)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.__c.NativeMethodInfoPtr__BakeCharacter_b__77_3_Internal_Void_SkinnedMeshRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C080 RID: 49280 RVA: 0x002F1238 File Offset: 0x002EF438
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _BakeCharacter_b__77_4(SkinnedMeshRenderer m)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.__c.NativeMethodInfoPtr__BakeCharacter_b__77_4_Internal_Void_SkinnedMeshRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C081 RID: 49281 RVA: 0x002F127C File Offset: 0x002EF47C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97236, XrefRangeEnd = 97243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ClearBake_b__78_1(SkinnedMeshRenderer m)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.__c.NativeMethodInfoPtr__ClearBake_b__78_1_Internal_Void_SkinnedMeshRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C082 RID: 49282 RVA: 0x002F12C0 File Offset: 0x002EF4C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97243, XrefRangeEnd = 97250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ClearBake_b__78_2(SkinnedMeshRenderer m)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.__c.NativeMethodInfoPtr__ClearBake_b__78_2_Internal_Void_SkinnedMeshRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C083 RID: 49283 RVA: 0x0005E06F File Offset: 0x0005C26F
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003BF1 RID: 15345
			// (get) Token: 0x0600C084 RID: 49284 RVA: 0x002F1304 File Offset: 0x002EF504
			// (set) Token: 0x0600C085 RID: 49285 RVA: 0x0005E078 File Offset: 0x0005C278
			public unsafe static CharacterCustomization.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CharacterCustomization.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCustomization.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CharacterCustomization.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BF2 RID: 15346
			// (get) Token: 0x0600C086 RID: 49286 RVA: 0x002F132C File Offset: 0x002EF52C
			// (set) Token: 0x0600C087 RID: 49287 RVA: 0x0005E08A File Offset: 0x0005C28A
			public unsafe static Func<Transform, bool> __9__42_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CharacterCustomization.__c.NativeFieldInfoPtr___9__42_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Transform, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CharacterCustomization.__c.NativeFieldInfoPtr___9__42_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BF3 RID: 15347
			// (get) Token: 0x0600C088 RID: 49288 RVA: 0x002F1354 File Offset: 0x002EF554
			// (set) Token: 0x0600C089 RID: 49289 RVA: 0x0005E09C File Offset: 0x0005C29C
			public unsafe static Action<SkinnedMeshRenderer> __9__77_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CharacterCustomization.__c.NativeFieldInfoPtr___9__77_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SkinnedMeshRenderer>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CharacterCustomization.__c.NativeFieldInfoPtr___9__77_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BF4 RID: 15348
			// (get) Token: 0x0600C08A RID: 49290 RVA: 0x002F137C File Offset: 0x002EF57C
			// (set) Token: 0x0600C08B RID: 49291 RVA: 0x0005E0AE File Offset: 0x0005C2AE
			public unsafe static Action<SkinnedMeshRenderer> __9__77_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CharacterCustomization.__c.NativeFieldInfoPtr___9__77_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SkinnedMeshRenderer>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CharacterCustomization.__c.NativeFieldInfoPtr___9__77_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BF5 RID: 15349
			// (get) Token: 0x0600C08C RID: 49292 RVA: 0x002F13A4 File Offset: 0x002EF5A4
			// (set) Token: 0x0600C08D RID: 49293 RVA: 0x0005E0C0 File Offset: 0x0005C2C0
			public unsafe static Action<SkinnedMeshRenderer> __9__77_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CharacterCustomization.__c.NativeFieldInfoPtr___9__77_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SkinnedMeshRenderer>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CharacterCustomization.__c.NativeFieldInfoPtr___9__77_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BF6 RID: 15350
			// (get) Token: 0x0600C08E RID: 49294 RVA: 0x002F13CC File Offset: 0x002EF5CC
			// (set) Token: 0x0600C08F RID: 49295 RVA: 0x0005E0D2 File Offset: 0x0005C2D2
			public unsafe static Action<SkinnedMeshRenderer> __9__78_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CharacterCustomization.__c.NativeFieldInfoPtr___9__78_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SkinnedMeshRenderer>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CharacterCustomization.__c.NativeFieldInfoPtr___9__78_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BF7 RID: 15351
			// (get) Token: 0x0600C090 RID: 49296 RVA: 0x002F13F4 File Offset: 0x002EF5F4
			// (set) Token: 0x0600C091 RID: 49297 RVA: 0x0005E0E4 File Offset: 0x0005C2E4
			public unsafe static Action<SkinnedMeshRenderer> __9__78_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CharacterCustomization.__c.NativeFieldInfoPtr___9__78_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SkinnedMeshRenderer>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CharacterCustomization.__c.NativeFieldInfoPtr___9__78_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400826C RID: 33388
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400826D RID: 33389
			private static readonly IntPtr NativeFieldInfoPtr___9__42_1;

			// Token: 0x0400826E RID: 33390
			private static readonly IntPtr NativeFieldInfoPtr___9__77_2;

			// Token: 0x0400826F RID: 33391
			private static readonly IntPtr NativeFieldInfoPtr___9__77_3;

			// Token: 0x04008270 RID: 33392
			private static readonly IntPtr NativeFieldInfoPtr___9__77_4;

			// Token: 0x04008271 RID: 33393
			private static readonly IntPtr NativeFieldInfoPtr___9__78_1;

			// Token: 0x04008272 RID: 33394
			private static readonly IntPtr NativeFieldInfoPtr___9__78_2;

			// Token: 0x04008273 RID: 33395
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008274 RID: 33396
			private static readonly IntPtr NativeMethodInfoPtr__InitializeMeshes_b__42_1_Internal_Boolean_Transform_0;

			// Token: 0x04008275 RID: 33397
			private static readonly IntPtr NativeMethodInfoPtr__BakeCharacter_b__77_2_Internal_Void_SkinnedMeshRenderer_0;

			// Token: 0x04008276 RID: 33398
			private static readonly IntPtr NativeMethodInfoPtr__BakeCharacter_b__77_3_Internal_Void_SkinnedMeshRenderer_0;

			// Token: 0x04008277 RID: 33399
			private static readonly IntPtr NativeMethodInfoPtr__BakeCharacter_b__77_4_Internal_Void_SkinnedMeshRenderer_0;

			// Token: 0x04008278 RID: 33400
			private static readonly IntPtr NativeMethodInfoPtr__ClearBake_b__78_1_Internal_Void_SkinnedMeshRenderer_0;

			// Token: 0x04008279 RID: 33401
			private static readonly IntPtr NativeMethodInfoPtr__ClearBake_b__78_2_Internal_Void_SkinnedMeshRenderer_0;
		}

		// Token: 0x0200085B RID: 2139
		[ObfuscatedName("AdvancedPeopleSystem.CharacterCustomization+<>c__DisplayClass42_0")]
		public sealed class __c__DisplayClass42_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C092 RID: 49298 RVA: 0x002F141C File Offset: 0x002EF61C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass42_0()
			{
				Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass42_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "<>c__DisplayClass42_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass42_0>.NativeClassPtr);
				CharacterCustomization.__c__DisplayClass42_0.NativeFieldInfoPtr_objType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass42_0>.NativeClassPtr, "objType");
				CharacterCustomization.__c__DisplayClass42_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass42_0>.NativeClassPtr, 100666180);
				CharacterCustomization.__c__DisplayClass42_0.NativeMethodInfoPtr__InitializeMeshes_b__0_Internal_Boolean_CharacterPart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass42_0>.NativeClassPtr, 100666181);
				CharacterCustomization.__c__DisplayClass42_0.NativeMethodInfoPtr__InitializeMeshes_b__2_Internal_Boolean_ClothesAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass42_0>.NativeClassPtr, 100666182);
			}

			// Token: 0x0600C093 RID: 49299 RVA: 0x002F1498 File Offset: 0x002EF698
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass42_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass42_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.__c__DisplayClass42_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C094 RID: 49300 RVA: 0x002F14D4 File Offset: 0x002EF6D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97250, XrefRangeEnd = 97252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _InitializeMeshes_b__0(CharacterPart f)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.__c__DisplayClass42_0.NativeMethodInfoPtr__InitializeMeshes_b__0_Internal_Boolean_CharacterPart_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C095 RID: 49301 RVA: 0x002F1524 File Offset: 0x002EF724
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97252, XrefRangeEnd = 97258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _InitializeMeshes_b__2(ClothesAnchor f)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.__c__DisplayClass42_0.NativeMethodInfoPtr__InitializeMeshes_b__2_Internal_Boolean_ClothesAnchor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C096 RID: 49302 RVA: 0x0005E0F6 File Offset: 0x0005C2F6
			public __c__DisplayClass42_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003BF8 RID: 15352
			// (get) Token: 0x0600C097 RID: 49303 RVA: 0x002F1574 File Offset: 0x002EF774
			// (set) Token: 0x0600C098 RID: 49304 RVA: 0x0005E0FF File Offset: 0x0005C2FF
			public unsafe string objType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.__c__DisplayClass42_0.NativeFieldInfoPtr_objType);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.__c__DisplayClass42_0.NativeFieldInfoPtr_objType), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400827A RID: 33402
			private static readonly IntPtr NativeFieldInfoPtr_objType;

			// Token: 0x0400827B RID: 33403
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400827C RID: 33404
			private static readonly IntPtr NativeMethodInfoPtr__InitializeMeshes_b__0_Internal_Boolean_CharacterPart_0;

			// Token: 0x0400827D RID: 33405
			private static readonly IntPtr NativeMethodInfoPtr__InitializeMeshes_b__2_Internal_Boolean_ClothesAnchor_0;
		}

		// Token: 0x0200085C RID: 2140
		[ObfuscatedName("AdvancedPeopleSystem.CharacterCustomization+<>c__DisplayClass43_0")]
		public sealed class __c__DisplayClass43_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C099 RID: 49305 RVA: 0x002F159C File Offset: 0x002EF79C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass43_0()
			{
				Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass43_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "<>c__DisplayClass43_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass43_0>.NativeClassPtr);
				CharacterCustomization.__c__DisplayClass43_0.NativeFieldInfoPtr_mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass43_0>.NativeClassPtr, "mesh");
				CharacterCustomization.__c__DisplayClass43_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass43_0>.NativeClassPtr, "<>4__this");
				CharacterCustomization.__c__DisplayClass43_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass43_0>.NativeClassPtr, 100666183);
				CharacterCustomization.__c__DisplayClass43_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass43_0>.NativeClassPtr, 100666184);
			}

			// Token: 0x0600C09A RID: 49306 RVA: 0x002F1618 File Offset: 0x002EF818
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass43_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass43_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.__c__DisplayClass43_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C09B RID: 49307 RVA: 0x002F1654 File Offset: 0x002EF854
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 97280, RefRangeEnd = 97282, XrefRangeStart = 97275, XrefRangeEnd = 97280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.__c__DisplayClass43_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600C09C RID: 49308 RVA: 0x0005E11E File Offset: 0x0005C31E
			public __c__DisplayClass43_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003BF9 RID: 15353
			// (get) Token: 0x0600C09D RID: 49309 RVA: 0x002F1694 File Offset: 0x002EF894
			// (set) Token: 0x0600C09E RID: 49310 RVA: 0x0005E127 File Offset: 0x0005C327
			public unsafe SkinnedMeshRenderer mesh
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.__c__DisplayClass43_0.NativeFieldInfoPtr_mesh);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkinnedMeshRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.__c__DisplayClass43_0.NativeFieldInfoPtr_mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BFA RID: 15354
			// (get) Token: 0x0600C09F RID: 49311 RVA: 0x002F16C4 File Offset: 0x002EF8C4
			// (set) Token: 0x0600C0A0 RID: 49312 RVA: 0x0005E146 File Offset: 0x0005C346
			public unsafe CharacterCustomization __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.__c__DisplayClass43_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCustomization>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.__c__DisplayClass43_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400827E RID: 33406
			private static readonly IntPtr NativeFieldInfoPtr_mesh;

			// Token: 0x0400827F RID: 33407
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008280 RID: 33408
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008281 RID: 33409
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x02000C2C RID: 3116
			[ObfuscatedName("AdvancedPeopleSystem.CharacterCustomization+<>c__DisplayClass43_0+<<UpdateSkinnedMeshesOffscreenBounds>g__UpdateBounds|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E11E RID: 57630 RVA: 0x0034ED8C File Offset: 0x0034CF8C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass43_0>.NativeClassPtr, "<<UpdateSkinnedMeshesOffscreenBounds>g__UpdateBounds|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100666185);
					CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100666186);
					CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100666187);
					CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100666188);
					CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100666189);
					CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100666190);
				}

				// Token: 0x0600E11F RID: 57631 RVA: 0x0034EE6C File Offset: 0x0034D06C
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E120 RID: 57632 RVA: 0x0034EEB4 File Offset: 0x0034D0B4
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E121 RID: 57633 RVA: 0x0034EEE8 File Offset: 0x0034D0E8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97258, XrefRangeEnd = 97270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170045C2 RID: 17858
				// (get) Token: 0x0600E122 RID: 57634 RVA: 0x0034EF24 File Offset: 0x0034D124
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E123 RID: 57635 RVA: 0x0034EF64 File Offset: 0x0034D164
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97270, XrefRangeEnd = 97275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170045C3 RID: 17859
				// (get) Token: 0x0600E124 RID: 57636 RVA: 0x0034EF98 File Offset: 0x0034D198
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E125 RID: 57637 RVA: 0x0006DC5E File Offset: 0x0006BE5E
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170045BF RID: 17855
				// (get) Token: 0x0600E126 RID: 57638 RVA: 0x0034EFD8 File Offset: 0x0034D1D8
				// (set) Token: 0x0600E127 RID: 57639 RVA: 0x0006DC67 File Offset: 0x0006BE67
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170045C0 RID: 17856
				// (get) Token: 0x0600E128 RID: 57640 RVA: 0x0034F000 File Offset: 0x0034D200
				// (set) Token: 0x0600E129 RID: 57641 RVA: 0x0006DC82 File Offset: 0x0006BE82
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170045C1 RID: 17857
				// (get) Token: 0x0600E12A RID: 57642 RVA: 0x0034F030 File Offset: 0x0034D230
				// (set) Token: 0x0600E12B RID: 57643 RVA: 0x0006DCA1 File Offset: 0x0006BEA1
				public unsafe CharacterCustomization.__c__DisplayClass43_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCustomization.__c__DisplayClass43_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040096C0 RID: 38592
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040096C1 RID: 38593
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040096C2 RID: 38594
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040096C3 RID: 38595
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040096C4 RID: 38596
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040096C5 RID: 38597
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040096C6 RID: 38598
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040096C7 RID: 38599
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040096C8 RID: 38600
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x0200085D RID: 2141
		[ObfuscatedName("AdvancedPeopleSystem.CharacterCustomization+<>c__DisplayClass83_0")]
		public sealed class __c__DisplayClass83_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C0A1 RID: 49313 RVA: 0x002F16F4 File Offset: 0x002EF8F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass83_0()
			{
				Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass83_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCustomization>.NativeClassPtr, "<>c__DisplayClass83_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass83_0>.NativeClassPtr);
				CharacterCustomization.__c__DisplayClass83_0.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass83_0>.NativeClassPtr, "name");
				CharacterCustomization.__c__DisplayClass83_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass83_0>.NativeClassPtr, 100666191);
				CharacterCustomization.__c__DisplayClass83_0.NativeMethodInfoPtr__GetElementsPreset_b__0_Internal_Boolean_CharacterElementsPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass83_0>.NativeClassPtr, 100666192);
			}

			// Token: 0x0600C0A2 RID: 49314 RVA: 0x002F175C File Offset: 0x002EF95C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass83_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCustomization.__c__DisplayClass83_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.__c__DisplayClass83_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C0A3 RID: 49315 RVA: 0x002F1798 File Offset: 0x002EF998
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetElementsPreset_b__0(CharacterElementsPreset f)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomization.__c__DisplayClass83_0.NativeMethodInfoPtr__GetElementsPreset_b__0_Internal_Boolean_CharacterElementsPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C0A4 RID: 49316 RVA: 0x0005E165 File Offset: 0x0005C365
			public __c__DisplayClass83_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003BFB RID: 15355
			// (get) Token: 0x0600C0A5 RID: 49317 RVA: 0x002F17E8 File Offset: 0x002EF9E8
			// (set) Token: 0x0600C0A6 RID: 49318 RVA: 0x0005E16E File Offset: 0x0005C36E
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.__c__DisplayClass83_0.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomization.__c__DisplayClass83_0.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008282 RID: 33410
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x04008283 RID: 33411
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008284 RID: 33412
			private static readonly IntPtr NativeMethodInfoPtr__GetElementsPreset_b__0_Internal_Boolean_CharacterElementsPreset_0;
		}
	}
}
