using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Animation;
using Il2CppScheduleOne.AvatarFramework.Emotions;
using Il2CppScheduleOne.AvatarFramework.Equipping;
using Il2CppScheduleOne.AvatarFramework.Impostors;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x020005F1 RID: 1521
	public class Avatar : MonoBehaviour
	{
		// Token: 0x060084CF RID: 33999 RVA: 0x00233E50 File Offset: 0x00232050
		// Note: this type is marked as 'beforefieldinit'.
		static Avatar()
		{
			Il2CppClassPointerStore<Avatar>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "Avatar");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Avatar>.NativeClassPtr);
			Avatar.NativeFieldInfoPtr_MAX_ACCESSORIES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "MAX_ACCESSORIES");
			Avatar.NativeFieldInfoPtr_USE_COMBINED_LAYERS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "USE_COMBINED_LAYERS");
			Avatar.NativeFieldInfoPtr_DEFAULT_SMOOTHNESS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "DEFAULT_SMOOTHNESS");
			Avatar.NativeFieldInfoPtr_maleShoulderScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "maleShoulderScale");
			Avatar.NativeFieldInfoPtr_femaleShoulderScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "femaleShoulderScale");
			Avatar.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "Anim");
			Avatar.NativeFieldInfoPtr_LookController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "LookController");
			Avatar.NativeFieldInfoPtr_BodyMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "BodyMeshes");
			Avatar.NativeFieldInfoPtr_ShapeKeyMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "ShapeKeyMeshes");
			Avatar.NativeFieldInfoPtr_FaceMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "FaceMesh");
			Avatar.NativeFieldInfoPtr_Eyes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "Eyes");
			Avatar.NativeFieldInfoPtr_EyeBrows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "EyeBrows");
			Avatar.NativeFieldInfoPtr_BodyContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "BodyContainer");
			Avatar.NativeFieldInfoPtr_Armature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "Armature");
			Avatar.NativeFieldInfoPtr_LeftShoulder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "LeftShoulder");
			Avatar.NativeFieldInfoPtr_RightShoulder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "RightShoulder");
			Avatar.NativeFieldInfoPtr_HeadBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "HeadBone");
			Avatar.NativeFieldInfoPtr_HipBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "HipBone");
			Avatar.NativeFieldInfoPtr_RagdollRBs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "RagdollRBs");
			Avatar.NativeFieldInfoPtr_RagdollColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "RagdollColliders");
			Avatar.NativeFieldInfoPtr_MiddleSpineRB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "MiddleSpineRB");
			Avatar.NativeFieldInfoPtr_EmotionManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "EmotionManager");
			Avatar.NativeFieldInfoPtr_Effects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "Effects");
			Avatar.NativeFieldInfoPtr_MiddleSpine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "MiddleSpine");
			Avatar.NativeFieldInfoPtr_LowerSpine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "LowerSpine");
			Avatar.NativeFieldInfoPtr_LowestSpine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "LowestSpine");
			Avatar.NativeFieldInfoPtr_Impostor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "Impostor");
			Avatar.NativeFieldInfoPtr_InitialAvatarSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "InitialAvatarSettings");
			Avatar.NativeFieldInfoPtr_DefaultAvatarMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "DefaultAvatarMaterial");
			Avatar.NativeFieldInfoPtr_UseImpostor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "UseImpostor");
			Avatar.NativeFieldInfoPtr_onRagdollChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "onRagdollChange");
			Avatar.NativeFieldInfoPtr__Ragdolled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "<Ragdolled>k__BackingField");
			Avatar.NativeFieldInfoPtr__CurrentEquippable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "<CurrentEquippable>k__BackingField");
			Avatar.NativeFieldInfoPtr_appliedGender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "appliedGender");
			Avatar.NativeFieldInfoPtr_appliedWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "appliedWeight");
			Avatar.NativeFieldInfoPtr_appliedHair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "appliedHair");
			Avatar.NativeFieldInfoPtr_appliedHairColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "appliedHairColor");
			Avatar.NativeFieldInfoPtr_appliedAccessories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "appliedAccessories");
			Avatar.NativeFieldInfoPtr_wearingHairBlockingAccessory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "wearingHairBlockingAccessory");
			Avatar.NativeFieldInfoPtr_additionalWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "additionalWeight");
			Avatar.NativeFieldInfoPtr_additionalGender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "additionalGender");
			Avatar.NativeFieldInfoPtr__CurrentSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "<CurrentSettings>k__BackingField");
			Avatar.NativeFieldInfoPtr_SettingsToLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "SettingsToLoad");
			Avatar.NativeFieldInfoPtr_onSettingsLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "onSettingsLoaded");
			Avatar.NativeFieldInfoPtr_originalHipPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "originalHipPos");
			Avatar.NativeFieldInfoPtr_usingCombinedLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "usingCombinedLayer");
			Avatar.NativeFieldInfoPtr_blockEyeFaceLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "blockEyeFaceLayers");
			Avatar.NativeMethodInfoPtr_get_Ragdolled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679908);
			Avatar.NativeMethodInfoPtr_set_Ragdolled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679909);
			Avatar.NativeMethodInfoPtr_get_CurrentEquippable_Public_get_AvatarEquippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679910);
			Avatar.NativeMethodInfoPtr_set_CurrentEquippable_Protected_set_Void_AvatarEquippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679911);
			Avatar.NativeMethodInfoPtr_get_CurrentSettings_Public_get_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679912);
			Avatar.NativeMethodInfoPtr_set_CurrentSettings_Protected_set_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679913);
			Avatar.NativeMethodInfoPtr_Load_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679914);
			Avatar.NativeMethodInfoPtr_LoadNaked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679915);
			Avatar.NativeMethodInfoPtr_get_CenterPoint_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679916);
			Avatar.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679917);
			Avatar.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679918);
			Avatar.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679919);
			Avatar.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679920);
			Avatar.NativeMethodInfoPtr_GetMugshot_Public_Void_Action_1_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679921);
			Avatar.NativeMethodInfoPtr_SetEmission_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679922);
			Avatar.NativeMethodInfoPtr_IsMale_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679923);
			Avatar.NativeMethodInfoPtr_IsWhite_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679924);
			Avatar.NativeMethodInfoPtr_GetFormalAddress_Public_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679925);
			Avatar.NativeMethodInfoPtr_GetThirdPersonAddress_Public_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679926);
			Avatar.NativeMethodInfoPtr_GetThirdPersonPronoun_Public_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679927);
			Avatar.NativeMethodInfoPtr_ApplyShapeKeys_Private_Void_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679928);
			Avatar.NativeMethodInfoPtr_SetFeetShrunk_Private_Void_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679929);
			Avatar.NativeMethodInfoPtr_SetWearingHairBlockingAccessory_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679930);
			Avatar.NativeMethodInfoPtr_LoadAvatarSettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679931);
			Avatar.NativeMethodInfoPtr_LoadNakedSettings_Public_Void_AvatarSettings_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679932);
			Avatar.NativeMethodInfoPtr_ApplyBodySettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679933);
			Avatar.NativeMethodInfoPtr_SetAdditionalWeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679934);
			Avatar.NativeMethodInfoPtr_SetAdditionalGender_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679935);
			Avatar.NativeMethodInfoPtr_SetSkinColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679936);
			Avatar.NativeMethodInfoPtr_ApplyHairSettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679937);
			Avatar.NativeMethodInfoPtr_SetHairVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679938);
			Avatar.NativeMethodInfoPtr_ApplyHairColorSettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679939);
			Avatar.NativeMethodInfoPtr_OverrideHairColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679940);
			Avatar.NativeMethodInfoPtr_ResetHairColor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679941);
			Avatar.NativeMethodInfoPtr_ApplyEyeBallSettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679942);
			Avatar.NativeMethodInfoPtr_ApplyEyeLidSettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679943);
			Avatar.NativeMethodInfoPtr_ApplyEyeLidColorSettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679944);
			Avatar.NativeMethodInfoPtr_ApplyEyebrowSettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679945);
			Avatar.NativeMethodInfoPtr_SetBlockEyeFaceLayers_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679946);
			Avatar.NativeMethodInfoPtr_ApplyFaceLayerSettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679947);
			Avatar.NativeMethodInfoPtr_SetFaceLayer_Private_Void_Int32_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679948);
			Avatar.NativeMethodInfoPtr_SetFaceTexture_Public_Void_Texture2D_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679949);
			Avatar.NativeMethodInfoPtr_ApplyBodyLayerSettings_Public_Void_AvatarSettings_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679950);
			Avatar.NativeMethodInfoPtr_SetBodyLayer_Private_Void_Int32_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679951);
			Avatar.NativeMethodInfoPtr_ApplyAccessorySettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679952);
			Avatar.NativeMethodInfoPtr_DestroyAccessories_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679953);
			Avatar.NativeMethodInfoPtr_SetRagdollPhysicsEnabled_Public_Virtual_New_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679954);
			Avatar.NativeMethodInfoPtr_SetEquippable_Public_Virtual_New_AvatarEquippable_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679955);
			Avatar.NativeMethodInfoPtr_ReceiveEquippableMessage_Public_Virtual_New_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679956);
			Avatar.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100679957);
		}

		// Token: 0x17002854 RID: 10324
		// (get) Token: 0x060084D0 RID: 34000 RVA: 0x00234614 File Offset: 0x00232814
		// (set) Token: 0x060084D1 RID: 34001 RVA: 0x00234650 File Offset: 0x00232850
		public unsafe bool Ragdolled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_get_Ragdolled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_set_Ragdolled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002855 RID: 10325
		// (get) Token: 0x060084D2 RID: 34002 RVA: 0x00234690 File Offset: 0x00232890
		// (set) Token: 0x060084D3 RID: 34003 RVA: 0x002346D0 File Offset: 0x002328D0
		public unsafe AvatarEquippable CurrentEquippable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_get_CurrentEquippable_Public_get_AvatarEquippable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_set_CurrentEquippable_Protected_set_Void_AvatarEquippable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002856 RID: 10326
		// (get) Token: 0x060084D4 RID: 34004 RVA: 0x00234714 File Offset: 0x00232914
		// (set) Token: 0x060084D5 RID: 34005 RVA: 0x00234754 File Offset: 0x00232954
		public unsafe AvatarSettings CurrentSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_get_CurrentSettings_Public_get_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_set_CurrentSettings_Protected_set_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060084D6 RID: 34006 RVA: 0x00234798 File Offset: 0x00232998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249319, XrefRangeEnd = 249320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_Load_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084D7 RID: 34007 RVA: 0x002347CC File Offset: 0x002329CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249320, XrefRangeEnd = 249321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadNaked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_LoadNaked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17002857 RID: 10327
		// (get) Token: 0x060084D8 RID: 34008 RVA: 0x00234800 File Offset: 0x00232A00
		public unsafe Vector3 CenterPoint
		{
			[CallerCount(77)]
			[CachedScanResults(RefRangeStart = 249323, RefRangeEnd = 249400, XrefRangeStart = 249321, XrefRangeEnd = 249323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_get_CenterPoint_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060084D9 RID: 34009 RVA: 0x0023483C File Offset: 0x00232A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249400, XrefRangeEnd = 249406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Avatar.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084DA RID: 34010 RVA: 0x00234878 File Offset: 0x00232A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249406, XrefRangeEnd = 249411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Avatar.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084DB RID: 34011 RVA: 0x002348B4 File Offset: 0x00232AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249411, XrefRangeEnd = 249433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Avatar.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084DC RID: 34012 RVA: 0x002348F0 File Offset: 0x00232AF0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 249437, RefRangeEnd = 249443, XrefRangeStart = 249433, XrefRangeEnd = 249437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084DD RID: 34013 RVA: 0x00234930 File Offset: 0x00232B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249443, XrefRangeEnd = 249448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetMugshot(Action<Texture2D> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_GetMugshot_Public_Void_Action_1_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084DE RID: 34014 RVA: 0x00234974 File Offset: 0x00232B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249448, XrefRangeEnd = 249456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEmission(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetEmission_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084DF RID: 34015 RVA: 0x002349B4 File Offset: 0x00232BB4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 249460, RefRangeEnd = 249464, XrefRangeStart = 249456, XrefRangeEnd = 249460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMale()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_IsMale_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060084E0 RID: 34016 RVA: 0x002349F0 File Offset: 0x00232BF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249464, XrefRangeEnd = 249468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsWhite()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_IsWhite_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060084E1 RID: 34017 RVA: 0x00234A2C File Offset: 0x00232C2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 249475, RefRangeEnd = 249476, XrefRangeStart = 249468, XrefRangeEnd = 249475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetFormalAddress(bool capitalized = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref capitalized;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_GetFormalAddress_Public_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060084E2 RID: 34018 RVA: 0x00234A70 File Offset: 0x00232C70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 249483, RefRangeEnd = 249484, XrefRangeStart = 249476, XrefRangeEnd = 249483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetThirdPersonAddress(bool capitalized = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref capitalized;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_GetThirdPersonAddress_Public_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060084E3 RID: 34019 RVA: 0x00234AB4 File Offset: 0x00232CB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 249491, RefRangeEnd = 249492, XrefRangeStart = 249484, XrefRangeEnd = 249491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetThirdPersonPronoun(bool capitalized = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref capitalized;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_GetThirdPersonPronoun_Public_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060084E4 RID: 34020 RVA: 0x00234AF8 File Offset: 0x00232CF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 249519, RefRangeEnd = 249521, XrefRangeStart = 249492, XrefRangeEnd = 249519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyShapeKeys(float gender, float weight, bool bodyOnly = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gender;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weight;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bodyOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ApplyShapeKeys_Private_Void_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084E5 RID: 34021 RVA: 0x00234B54 File Offset: 0x00232D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249521, XrefRangeEnd = 249525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFeetShrunk(bool shrink, float reduction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref shrink;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reduction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetFeetShrunk_Private_Void_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084E6 RID: 34022 RVA: 0x00234BA0 File Offset: 0x00232DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249525, XrefRangeEnd = 249529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWearingHairBlockingAccessory(bool blocked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref blocked;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetWearingHairBlockingAccessory_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084E7 RID: 34023 RVA: 0x00234BE0 File Offset: 0x00232DE0
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 249564, RefRangeEnd = 249577, XrefRangeStart = 249529, XrefRangeEnd = 249564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadAvatarSettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_LoadAvatarSettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084E8 RID: 34024 RVA: 0x00234C24 File Offset: 0x00232E24
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 249642, RefRangeEnd = 249645, XrefRangeStart = 249577, XrefRangeEnd = 249642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadNakedSettings(AvatarSettings settings, int maxLayerOrder = 19)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxLayerOrder;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_LoadNakedSettings_Public_Void_AvatarSettings_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084E9 RID: 34025 RVA: 0x00234C74 File Offset: 0x00232E74
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 249649, RefRangeEnd = 249656, XrefRangeStart = 249645, XrefRangeEnd = 249649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyBodySettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ApplyBodySettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084EA RID: 34026 RVA: 0x00234CB8 File Offset: 0x00232EB8
		[CallerCount(0)]
		public unsafe void SetAdditionalWeight(float weight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref weight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetAdditionalWeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084EB RID: 34027 RVA: 0x00234CF8 File Offset: 0x00232EF8
		[CallerCount(0)]
		public unsafe void SetAdditionalGender(float gender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gender;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetAdditionalGender_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084EC RID: 34028 RVA: 0x00234D38 File Offset: 0x00232F38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 249678, RefRangeEnd = 249679, XrefRangeStart = 249656, XrefRangeEnd = 249678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSkinColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetSkinColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084ED RID: 34029 RVA: 0x00234D78 File Offset: 0x00232F78
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 249705, RefRangeEnd = 249711, XrefRangeStart = 249679, XrefRangeEnd = 249705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyHairSettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ApplyHairSettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084EE RID: 34030 RVA: 0x00234DBC File Offset: 0x00232FBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 249717, RefRangeEnd = 249719, XrefRangeStart = 249711, XrefRangeEnd = 249717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHairVisible(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetHairVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084EF RID: 34031 RVA: 0x00234DFC File Offset: 0x00232FFC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 249727, RefRangeEnd = 249732, XrefRangeStart = 249719, XrefRangeEnd = 249727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyHairColorSettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ApplyHairColorSettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084F0 RID: 34032 RVA: 0x00234E40 File Offset: 0x00233040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249732, XrefRangeEnd = 249746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideHairColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_OverrideHairColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084F1 RID: 34033 RVA: 0x00234E80 File Offset: 0x00233080
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 249760, RefRangeEnd = 249761, XrefRangeStart = 249746, XrefRangeEnd = 249760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetHairColor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ResetHairColor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084F2 RID: 34034 RVA: 0x00234EB4 File Offset: 0x002330B4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 249765, RefRangeEnd = 249769, XrefRangeStart = 249761, XrefRangeEnd = 249765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyEyeBallSettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ApplyEyeBallSettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084F3 RID: 34035 RVA: 0x00234EF8 File Offset: 0x002330F8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 249771, RefRangeEnd = 249775, XrefRangeStart = 249769, XrefRangeEnd = 249771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyEyeLidSettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ApplyEyeLidSettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084F4 RID: 34036 RVA: 0x00234F3C File Offset: 0x0023313C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 249783, RefRangeEnd = 249787, XrefRangeStart = 249775, XrefRangeEnd = 249783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyEyeLidColorSettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ApplyEyeLidColorSettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084F5 RID: 34037 RVA: 0x00234F80 File Offset: 0x00233180
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 249789, RefRangeEnd = 249793, XrefRangeStart = 249787, XrefRangeEnd = 249789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyEyebrowSettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ApplyEyebrowSettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084F6 RID: 34038 RVA: 0x00234FC4 File Offset: 0x002331C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 249798, RefRangeEnd = 249799, XrefRangeStart = 249793, XrefRangeEnd = 249798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBlockEyeFaceLayers(bool block)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref block;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetBlockEyeFaceLayers_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084F7 RID: 34039 RVA: 0x00235004 File Offset: 0x00233204
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 249895, RefRangeEnd = 249902, XrefRangeStart = 249799, XrefRangeEnd = 249895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyFaceLayerSettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ApplyFaceLayerSettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084F8 RID: 34040 RVA: 0x00235048 File Offset: 0x00233248
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 249930, RefRangeEnd = 249938, XrefRangeStart = 249902, XrefRangeEnd = 249930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFaceLayer(int index, string assetPath, Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assetPath);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetFaceLayer_Private_Void_Int32_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084F9 RID: 34041 RVA: 0x002350A8 File Offset: 0x002332A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249938, XrefRangeEnd = 249953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFaceTexture(Texture2D tex, Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetFaceTexture_Public_Void_Texture2D_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084FA RID: 34042 RVA: 0x002350F8 File Offset: 0x002332F8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 250038, RefRangeEnd = 250045, XrefRangeStart = 249953, XrefRangeEnd = 250038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyBodyLayerSettings(AvatarSettings settings, int maxOrder = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxOrder;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ApplyBodyLayerSettings_Public_Void_AvatarSettings_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084FB RID: 34043 RVA: 0x00235148 File Offset: 0x00233348
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 250095, RefRangeEnd = 250097, XrefRangeStart = 250045, XrefRangeEnd = 250095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBodyLayer(int index, string assetPath, Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assetPath);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetBodyLayer_Private_Void_Int32_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084FC RID: 34044 RVA: 0x002351A8 File Offset: 0x002333A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 250173, RefRangeEnd = 250176, XrefRangeStart = 250097, XrefRangeEnd = 250173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyAccessorySettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ApplyAccessorySettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084FD RID: 34045 RVA: 0x002351EC File Offset: 0x002333EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250176, XrefRangeEnd = 250185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyAccessories()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_DestroyAccessories_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084FE RID: 34046 RVA: 0x00235220 File Offset: 0x00233420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250185, XrefRangeEnd = 250206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetRagdollPhysicsEnabled(bool ragdollEnabled, bool playStandUpAnim = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref ragdollEnabled;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playStandUpAnim;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Avatar.NativeMethodInfoPtr_SetRagdollPhysicsEnabled_Public_Virtual_New_Void_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084FF RID: 34047 RVA: 0x00235278 File Offset: 0x00233478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250206, XrefRangeEnd = 250230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AvatarEquippable SetEquippable(string assetPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(assetPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Avatar.NativeMethodInfoPtr_SetEquippable_Public_Virtual_New_AvatarEquippable_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr3) : null;
		}

		// Token: 0x06008500 RID: 34048 RVA: 0x002352D4 File Offset: 0x002334D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250230, XrefRangeEnd = 250240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ReceiveEquippableMessage(string message, Il2CppSystem.Object data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Avatar.NativeMethodInfoPtr_ReceiveEquippableMessage_Public_Virtual_New_Void_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008501 RID: 34049 RVA: 0x00235334 File Offset: 0x00233534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250240, XrefRangeEnd = 250247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Avatar() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Avatar>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008502 RID: 34050 RVA: 0x0003EFC8 File Offset: 0x0003D1C8
		public Avatar(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002825 RID: 10277
		// (get) Token: 0x06008503 RID: 34051 RVA: 0x00235370 File Offset: 0x00233570
		// (set) Token: 0x06008504 RID: 34052 RVA: 0x0003EFD1 File Offset: 0x0003D1D1
		public unsafe static int MAX_ACCESSORIES
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Avatar.NativeFieldInfoPtr_MAX_ACCESSORIES, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Avatar.NativeFieldInfoPtr_MAX_ACCESSORIES, (void*)(&value));
			}
		}

		// Token: 0x17002826 RID: 10278
		// (get) Token: 0x06008505 RID: 34053 RVA: 0x0023538C File Offset: 0x0023358C
		// (set) Token: 0x06008506 RID: 34054 RVA: 0x0003EFDF File Offset: 0x0003D1DF
		public unsafe static bool USE_COMBINED_LAYERS
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(Avatar.NativeFieldInfoPtr_USE_COMBINED_LAYERS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Avatar.NativeFieldInfoPtr_USE_COMBINED_LAYERS, (void*)(&value));
			}
		}

		// Token: 0x17002827 RID: 10279
		// (get) Token: 0x06008507 RID: 34055 RVA: 0x002353A8 File Offset: 0x002335A8
		// (set) Token: 0x06008508 RID: 34056 RVA: 0x0003EFED File Offset: 0x0003D1ED
		public unsafe static float DEFAULT_SMOOTHNESS
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Avatar.NativeFieldInfoPtr_DEFAULT_SMOOTHNESS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Avatar.NativeFieldInfoPtr_DEFAULT_SMOOTHNESS, (void*)(&value));
			}
		}

		// Token: 0x17002828 RID: 10280
		// (get) Token: 0x06008509 RID: 34057 RVA: 0x002353C4 File Offset: 0x002335C4
		// (set) Token: 0x0600850A RID: 34058 RVA: 0x0003EFFB File Offset: 0x0003D1FB
		public unsafe static float maleShoulderScale
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Avatar.NativeFieldInfoPtr_maleShoulderScale, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Avatar.NativeFieldInfoPtr_maleShoulderScale, (void*)(&value));
			}
		}

		// Token: 0x17002829 RID: 10281
		// (get) Token: 0x0600850B RID: 34059 RVA: 0x002353E0 File Offset: 0x002335E0
		// (set) Token: 0x0600850C RID: 34060 RVA: 0x0003F009 File Offset: 0x0003D209
		public unsafe static float femaleShoulderScale
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Avatar.NativeFieldInfoPtr_femaleShoulderScale, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Avatar.NativeFieldInfoPtr_femaleShoulderScale, (void*)(&value));
			}
		}

		// Token: 0x1700282A RID: 10282
		// (get) Token: 0x0600850D RID: 34061 RVA: 0x002353FC File Offset: 0x002335FC
		// (set) Token: 0x0600850E RID: 34062 RVA: 0x0003F017 File Offset: 0x0003D217
		public unsafe AvatarAnimation Anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_Anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarAnimation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700282B RID: 10283
		// (get) Token: 0x0600850F RID: 34063 RVA: 0x0023542C File Offset: 0x0023362C
		// (set) Token: 0x06008510 RID: 34064 RVA: 0x0003F036 File Offset: 0x0003D236
		public unsafe AvatarLookController LookController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_LookController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarLookController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_LookController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700282C RID: 10284
		// (get) Token: 0x06008511 RID: 34065 RVA: 0x0023545C File Offset: 0x0023365C
		// (set) Token: 0x06008512 RID: 34066 RVA: 0x0003F055 File Offset: 0x0003D255
		public unsafe Il2CppReferenceArray<SkinnedMeshRenderer> BodyMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_BodyMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SkinnedMeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_BodyMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700282D RID: 10285
		// (get) Token: 0x06008513 RID: 34067 RVA: 0x0023548C File Offset: 0x0023368C
		// (set) Token: 0x06008514 RID: 34068 RVA: 0x0003F074 File Offset: 0x0003D274
		public unsafe Il2CppReferenceArray<SkinnedMeshRenderer> ShapeKeyMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_ShapeKeyMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SkinnedMeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_ShapeKeyMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700282E RID: 10286
		// (get) Token: 0x06008515 RID: 34069 RVA: 0x002354BC File Offset: 0x002336BC
		// (set) Token: 0x06008516 RID: 34070 RVA: 0x0003F093 File Offset: 0x0003D293
		public unsafe SkinnedMeshRenderer FaceMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_FaceMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkinnedMeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_FaceMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700282F RID: 10287
		// (get) Token: 0x06008517 RID: 34071 RVA: 0x002354EC File Offset: 0x002336EC
		// (set) Token: 0x06008518 RID: 34072 RVA: 0x0003F0B2 File Offset: 0x0003D2B2
		public unsafe EyeController Eyes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_Eyes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EyeController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_Eyes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002830 RID: 10288
		// (get) Token: 0x06008519 RID: 34073 RVA: 0x0023551C File Offset: 0x0023371C
		// (set) Token: 0x0600851A RID: 34074 RVA: 0x0003F0D1 File Offset: 0x0003D2D1
		public unsafe EyebrowController EyeBrows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_EyeBrows);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EyebrowController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_EyeBrows), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002831 RID: 10289
		// (get) Token: 0x0600851B RID: 34075 RVA: 0x0023554C File Offset: 0x0023374C
		// (set) Token: 0x0600851C RID: 34076 RVA: 0x0003F0F0 File Offset: 0x0003D2F0
		public unsafe Transform BodyContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_BodyContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_BodyContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002832 RID: 10290
		// (get) Token: 0x0600851D RID: 34077 RVA: 0x0023557C File Offset: 0x0023377C
		// (set) Token: 0x0600851E RID: 34078 RVA: 0x0003F10F File Offset: 0x0003D30F
		public unsafe Transform Armature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_Armature);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_Armature), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002833 RID: 10291
		// (get) Token: 0x0600851F RID: 34079 RVA: 0x002355AC File Offset: 0x002337AC
		// (set) Token: 0x06008520 RID: 34080 RVA: 0x0003F12E File Offset: 0x0003D32E
		public unsafe Transform LeftShoulder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_LeftShoulder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_LeftShoulder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002834 RID: 10292
		// (get) Token: 0x06008521 RID: 34081 RVA: 0x002355DC File Offset: 0x002337DC
		// (set) Token: 0x06008522 RID: 34082 RVA: 0x0003F14D File Offset: 0x0003D34D
		public unsafe Transform RightShoulder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_RightShoulder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_RightShoulder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002835 RID: 10293
		// (get) Token: 0x06008523 RID: 34083 RVA: 0x0023560C File Offset: 0x0023380C
		// (set) Token: 0x06008524 RID: 34084 RVA: 0x0003F16C File Offset: 0x0003D36C
		public unsafe Transform HeadBone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_HeadBone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_HeadBone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002836 RID: 10294
		// (get) Token: 0x06008525 RID: 34085 RVA: 0x0023563C File Offset: 0x0023383C
		// (set) Token: 0x06008526 RID: 34086 RVA: 0x0003F18B File Offset: 0x0003D38B
		public unsafe Transform HipBone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_HipBone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_HipBone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002837 RID: 10295
		// (get) Token: 0x06008527 RID: 34087 RVA: 0x0023566C File Offset: 0x0023386C
		// (set) Token: 0x06008528 RID: 34088 RVA: 0x0003F1AA File Offset: 0x0003D3AA
		public unsafe Il2CppReferenceArray<Rigidbody> RagdollRBs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_RagdollRBs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Rigidbody>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_RagdollRBs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002838 RID: 10296
		// (get) Token: 0x06008529 RID: 34089 RVA: 0x0023569C File Offset: 0x0023389C
		// (set) Token: 0x0600852A RID: 34090 RVA: 0x0003F1C9 File Offset: 0x0003D3C9
		public unsafe Il2CppReferenceArray<Collider> RagdollColliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_RagdollColliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_RagdollColliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002839 RID: 10297
		// (get) Token: 0x0600852B RID: 34091 RVA: 0x002356CC File Offset: 0x002338CC
		// (set) Token: 0x0600852C RID: 34092 RVA: 0x0003F1E8 File Offset: 0x0003D3E8
		public unsafe Rigidbody MiddleSpineRB
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_MiddleSpineRB);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_MiddleSpineRB), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700283A RID: 10298
		// (get) Token: 0x0600852D RID: 34093 RVA: 0x002356FC File Offset: 0x002338FC
		// (set) Token: 0x0600852E RID: 34094 RVA: 0x0003F207 File Offset: 0x0003D407
		public unsafe AvatarEmotionManager EmotionManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_EmotionManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEmotionManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_EmotionManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700283B RID: 10299
		// (get) Token: 0x0600852F RID: 34095 RVA: 0x0023572C File Offset: 0x0023392C
		// (set) Token: 0x06008530 RID: 34096 RVA: 0x0003F226 File Offset: 0x0003D426
		public unsafe AvatarEffects Effects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_Effects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEffects>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_Effects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700283C RID: 10300
		// (get) Token: 0x06008531 RID: 34097 RVA: 0x0023575C File Offset: 0x0023395C
		// (set) Token: 0x06008532 RID: 34098 RVA: 0x0003F245 File Offset: 0x0003D445
		public unsafe Transform MiddleSpine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_MiddleSpine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_MiddleSpine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700283D RID: 10301
		// (get) Token: 0x06008533 RID: 34099 RVA: 0x0023578C File Offset: 0x0023398C
		// (set) Token: 0x06008534 RID: 34100 RVA: 0x0003F264 File Offset: 0x0003D464
		public unsafe Transform LowerSpine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_LowerSpine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_LowerSpine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700283E RID: 10302
		// (get) Token: 0x06008535 RID: 34101 RVA: 0x002357BC File Offset: 0x002339BC
		// (set) Token: 0x06008536 RID: 34102 RVA: 0x0003F283 File Offset: 0x0003D483
		public unsafe Transform LowestSpine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_LowestSpine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_LowestSpine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700283F RID: 10303
		// (get) Token: 0x06008537 RID: 34103 RVA: 0x002357EC File Offset: 0x002339EC
		// (set) Token: 0x06008538 RID: 34104 RVA: 0x0003F2A2 File Offset: 0x0003D4A2
		public unsafe AvatarImpostor Impostor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_Impostor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarImpostor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_Impostor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002840 RID: 10304
		// (get) Token: 0x06008539 RID: 34105 RVA: 0x0023581C File Offset: 0x00233A1C
		// (set) Token: 0x0600853A RID: 34106 RVA: 0x0003F2C1 File Offset: 0x0003D4C1
		public unsafe AvatarSettings InitialAvatarSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_InitialAvatarSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_InitialAvatarSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002841 RID: 10305
		// (get) Token: 0x0600853B RID: 34107 RVA: 0x0023584C File Offset: 0x00233A4C
		// (set) Token: 0x0600853C RID: 34108 RVA: 0x0003F2E0 File Offset: 0x0003D4E0
		public unsafe Material DefaultAvatarMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_DefaultAvatarMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_DefaultAvatarMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002842 RID: 10306
		// (get) Token: 0x0600853D RID: 34109 RVA: 0x0023587C File Offset: 0x00233A7C
		// (set) Token: 0x0600853E RID: 34110 RVA: 0x0003F2FF File Offset: 0x0003D4FF
		public unsafe bool UseImpostor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_UseImpostor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_UseImpostor)) = value;
			}
		}

		// Token: 0x17002843 RID: 10307
		// (get) Token: 0x0600853F RID: 34111 RVA: 0x002358A4 File Offset: 0x00233AA4
		// (set) Token: 0x06008540 RID: 34112 RVA: 0x0003F31A File Offset: 0x0003D51A
		public unsafe UnityEvent<bool, bool, bool> onRagdollChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_onRagdollChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<bool, bool, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_onRagdollChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002844 RID: 10308
		// (get) Token: 0x06008541 RID: 34113 RVA: 0x002358D4 File Offset: 0x00233AD4
		// (set) Token: 0x06008542 RID: 34114 RVA: 0x0003F339 File Offset: 0x0003D539
		public unsafe bool _Ragdolled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr__Ragdolled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr__Ragdolled_k__BackingField)) = value;
			}
		}

		// Token: 0x17002845 RID: 10309
		// (get) Token: 0x06008543 RID: 34115 RVA: 0x002358FC File Offset: 0x00233AFC
		// (set) Token: 0x06008544 RID: 34116 RVA: 0x0003F354 File Offset: 0x0003D554
		public unsafe AvatarEquippable _CurrentEquippable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr__CurrentEquippable_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr__CurrentEquippable_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002846 RID: 10310
		// (get) Token: 0x06008545 RID: 34117 RVA: 0x0023592C File Offset: 0x00233B2C
		// (set) Token: 0x06008546 RID: 34118 RVA: 0x0003F373 File Offset: 0x0003D573
		public unsafe float appliedGender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_appliedGender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_appliedGender)) = value;
			}
		}

		// Token: 0x17002847 RID: 10311
		// (get) Token: 0x06008547 RID: 34119 RVA: 0x00235954 File Offset: 0x00233B54
		// (set) Token: 0x06008548 RID: 34120 RVA: 0x0003F38E File Offset: 0x0003D58E
		public unsafe float appliedWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_appliedWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_appliedWeight)) = value;
			}
		}

		// Token: 0x17002848 RID: 10312
		// (get) Token: 0x06008549 RID: 34121 RVA: 0x0023597C File Offset: 0x00233B7C
		// (set) Token: 0x0600854A RID: 34122 RVA: 0x0003F3A9 File Offset: 0x0003D5A9
		public unsafe Hair appliedHair
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_appliedHair);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hair>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_appliedHair), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002849 RID: 10313
		// (get) Token: 0x0600854B RID: 34123 RVA: 0x002359AC File Offset: 0x00233BAC
		// (set) Token: 0x0600854C RID: 34124 RVA: 0x0003F3C8 File Offset: 0x0003D5C8
		public unsafe Color appliedHairColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_appliedHairColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_appliedHairColor)) = value;
			}
		}

		// Token: 0x1700284A RID: 10314
		// (get) Token: 0x0600854D RID: 34125 RVA: 0x002359D4 File Offset: 0x00233BD4
		// (set) Token: 0x0600854E RID: 34126 RVA: 0x0003F3E3 File Offset: 0x0003D5E3
		public unsafe Il2CppReferenceArray<Accessory> appliedAccessories
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_appliedAccessories);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Accessory>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_appliedAccessories), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700284B RID: 10315
		// (get) Token: 0x0600854F RID: 34127 RVA: 0x00235A04 File Offset: 0x00233C04
		// (set) Token: 0x06008550 RID: 34128 RVA: 0x0003F402 File Offset: 0x0003D602
		public unsafe bool wearingHairBlockingAccessory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_wearingHairBlockingAccessory);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_wearingHairBlockingAccessory)) = value;
			}
		}

		// Token: 0x1700284C RID: 10316
		// (get) Token: 0x06008551 RID: 34129 RVA: 0x00235A2C File Offset: 0x00233C2C
		// (set) Token: 0x06008552 RID: 34130 RVA: 0x0003F41D File Offset: 0x0003D61D
		public unsafe float additionalWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_additionalWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_additionalWeight)) = value;
			}
		}

		// Token: 0x1700284D RID: 10317
		// (get) Token: 0x06008553 RID: 34131 RVA: 0x00235A54 File Offset: 0x00233C54
		// (set) Token: 0x06008554 RID: 34132 RVA: 0x0003F438 File Offset: 0x0003D638
		public unsafe float additionalGender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_additionalGender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_additionalGender)) = value;
			}
		}

		// Token: 0x1700284E RID: 10318
		// (get) Token: 0x06008555 RID: 34133 RVA: 0x00235A7C File Offset: 0x00233C7C
		// (set) Token: 0x06008556 RID: 34134 RVA: 0x0003F453 File Offset: 0x0003D653
		public unsafe AvatarSettings _CurrentSettings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr__CurrentSettings_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr__CurrentSettings_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700284F RID: 10319
		// (get) Token: 0x06008557 RID: 34135 RVA: 0x00235AAC File Offset: 0x00233CAC
		// (set) Token: 0x06008558 RID: 34136 RVA: 0x0003F472 File Offset: 0x0003D672
		public unsafe AvatarSettings SettingsToLoad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_SettingsToLoad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_SettingsToLoad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002850 RID: 10320
		// (get) Token: 0x06008559 RID: 34137 RVA: 0x00235ADC File Offset: 0x00233CDC
		// (set) Token: 0x0600855A RID: 34138 RVA: 0x0003F491 File Offset: 0x0003D691
		public unsafe UnityEvent onSettingsLoaded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_onSettingsLoaded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_onSettingsLoaded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002851 RID: 10321
		// (get) Token: 0x0600855B RID: 34139 RVA: 0x00235B0C File Offset: 0x00233D0C
		// (set) Token: 0x0600855C RID: 34140 RVA: 0x0003F4B0 File Offset: 0x0003D6B0
		public unsafe Vector3 originalHipPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_originalHipPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_originalHipPos)) = value;
			}
		}

		// Token: 0x17002852 RID: 10322
		// (get) Token: 0x0600855D RID: 34141 RVA: 0x00235B34 File Offset: 0x00233D34
		// (set) Token: 0x0600855E RID: 34142 RVA: 0x0003F4CB File Offset: 0x0003D6CB
		public unsafe bool usingCombinedLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_usingCombinedLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_usingCombinedLayer)) = value;
			}
		}

		// Token: 0x17002853 RID: 10323
		// (get) Token: 0x0600855F RID: 34143 RVA: 0x00235B5C File Offset: 0x00233D5C
		// (set) Token: 0x06008560 RID: 34144 RVA: 0x0003F4E6 File Offset: 0x0003D6E6
		public unsafe bool blockEyeFaceLayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_blockEyeFaceLayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_blockEyeFaceLayers)) = value;
			}
		}

		// Token: 0x04005A6E RID: 23150
		private static readonly IntPtr NativeFieldInfoPtr_MAX_ACCESSORIES;

		// Token: 0x04005A6F RID: 23151
		private static readonly IntPtr NativeFieldInfoPtr_USE_COMBINED_LAYERS;

		// Token: 0x04005A70 RID: 23152
		private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_SMOOTHNESS;

		// Token: 0x04005A71 RID: 23153
		private static readonly IntPtr NativeFieldInfoPtr_maleShoulderScale;

		// Token: 0x04005A72 RID: 23154
		private static readonly IntPtr NativeFieldInfoPtr_femaleShoulderScale;

		// Token: 0x04005A73 RID: 23155
		private static readonly IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x04005A74 RID: 23156
		private static readonly IntPtr NativeFieldInfoPtr_LookController;

		// Token: 0x04005A75 RID: 23157
		private static readonly IntPtr NativeFieldInfoPtr_BodyMeshes;

		// Token: 0x04005A76 RID: 23158
		private static readonly IntPtr NativeFieldInfoPtr_ShapeKeyMeshes;

		// Token: 0x04005A77 RID: 23159
		private static readonly IntPtr NativeFieldInfoPtr_FaceMesh;

		// Token: 0x04005A78 RID: 23160
		private static readonly IntPtr NativeFieldInfoPtr_Eyes;

		// Token: 0x04005A79 RID: 23161
		private static readonly IntPtr NativeFieldInfoPtr_EyeBrows;

		// Token: 0x04005A7A RID: 23162
		private static readonly IntPtr NativeFieldInfoPtr_BodyContainer;

		// Token: 0x04005A7B RID: 23163
		private static readonly IntPtr NativeFieldInfoPtr_Armature;

		// Token: 0x04005A7C RID: 23164
		private static readonly IntPtr NativeFieldInfoPtr_LeftShoulder;

		// Token: 0x04005A7D RID: 23165
		private static readonly IntPtr NativeFieldInfoPtr_RightShoulder;

		// Token: 0x04005A7E RID: 23166
		private static readonly IntPtr NativeFieldInfoPtr_HeadBone;

		// Token: 0x04005A7F RID: 23167
		private static readonly IntPtr NativeFieldInfoPtr_HipBone;

		// Token: 0x04005A80 RID: 23168
		private static readonly IntPtr NativeFieldInfoPtr_RagdollRBs;

		// Token: 0x04005A81 RID: 23169
		private static readonly IntPtr NativeFieldInfoPtr_RagdollColliders;

		// Token: 0x04005A82 RID: 23170
		private static readonly IntPtr NativeFieldInfoPtr_MiddleSpineRB;

		// Token: 0x04005A83 RID: 23171
		private static readonly IntPtr NativeFieldInfoPtr_EmotionManager;

		// Token: 0x04005A84 RID: 23172
		private static readonly IntPtr NativeFieldInfoPtr_Effects;

		// Token: 0x04005A85 RID: 23173
		private static readonly IntPtr NativeFieldInfoPtr_MiddleSpine;

		// Token: 0x04005A86 RID: 23174
		private static readonly IntPtr NativeFieldInfoPtr_LowerSpine;

		// Token: 0x04005A87 RID: 23175
		private static readonly IntPtr NativeFieldInfoPtr_LowestSpine;

		// Token: 0x04005A88 RID: 23176
		private static readonly IntPtr NativeFieldInfoPtr_Impostor;

		// Token: 0x04005A89 RID: 23177
		private static readonly IntPtr NativeFieldInfoPtr_InitialAvatarSettings;

		// Token: 0x04005A8A RID: 23178
		private static readonly IntPtr NativeFieldInfoPtr_DefaultAvatarMaterial;

		// Token: 0x04005A8B RID: 23179
		private static readonly IntPtr NativeFieldInfoPtr_UseImpostor;

		// Token: 0x04005A8C RID: 23180
		private static readonly IntPtr NativeFieldInfoPtr_onRagdollChange;

		// Token: 0x04005A8D RID: 23181
		private static readonly IntPtr NativeFieldInfoPtr__Ragdolled_k__BackingField;

		// Token: 0x04005A8E RID: 23182
		private static readonly IntPtr NativeFieldInfoPtr__CurrentEquippable_k__BackingField;

		// Token: 0x04005A8F RID: 23183
		private static readonly IntPtr NativeFieldInfoPtr_appliedGender;

		// Token: 0x04005A90 RID: 23184
		private static readonly IntPtr NativeFieldInfoPtr_appliedWeight;

		// Token: 0x04005A91 RID: 23185
		private static readonly IntPtr NativeFieldInfoPtr_appliedHair;

		// Token: 0x04005A92 RID: 23186
		private static readonly IntPtr NativeFieldInfoPtr_appliedHairColor;

		// Token: 0x04005A93 RID: 23187
		private static readonly IntPtr NativeFieldInfoPtr_appliedAccessories;

		// Token: 0x04005A94 RID: 23188
		private static readonly IntPtr NativeFieldInfoPtr_wearingHairBlockingAccessory;

		// Token: 0x04005A95 RID: 23189
		private static readonly IntPtr NativeFieldInfoPtr_additionalWeight;

		// Token: 0x04005A96 RID: 23190
		private static readonly IntPtr NativeFieldInfoPtr_additionalGender;

		// Token: 0x04005A97 RID: 23191
		private static readonly IntPtr NativeFieldInfoPtr__CurrentSettings_k__BackingField;

		// Token: 0x04005A98 RID: 23192
		private static readonly IntPtr NativeFieldInfoPtr_SettingsToLoad;

		// Token: 0x04005A99 RID: 23193
		private static readonly IntPtr NativeFieldInfoPtr_onSettingsLoaded;

		// Token: 0x04005A9A RID: 23194
		private static readonly IntPtr NativeFieldInfoPtr_originalHipPos;

		// Token: 0x04005A9B RID: 23195
		private static readonly IntPtr NativeFieldInfoPtr_usingCombinedLayer;

		// Token: 0x04005A9C RID: 23196
		private static readonly IntPtr NativeFieldInfoPtr_blockEyeFaceLayers;

		// Token: 0x04005A9D RID: 23197
		private static readonly IntPtr NativeMethodInfoPtr_get_Ragdolled_Public_get_Boolean_0;

		// Token: 0x04005A9E RID: 23198
		private static readonly IntPtr NativeMethodInfoPtr_set_Ragdolled_Protected_set_Void_Boolean_0;

		// Token: 0x04005A9F RID: 23199
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentEquippable_Public_get_AvatarEquippable_0;

		// Token: 0x04005AA0 RID: 23200
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentEquippable_Protected_set_Void_AvatarEquippable_0;

		// Token: 0x04005AA1 RID: 23201
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSettings_Public_get_AvatarSettings_0;

		// Token: 0x04005AA2 RID: 23202
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentSettings_Protected_set_Void_AvatarSettings_0;

		// Token: 0x04005AA3 RID: 23203
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_0;

		// Token: 0x04005AA4 RID: 23204
		private static readonly IntPtr NativeMethodInfoPtr_LoadNaked_Public_Void_0;

		// Token: 0x04005AA5 RID: 23205
		private static readonly IntPtr NativeMethodInfoPtr_get_CenterPoint_Public_get_Vector3_0;

		// Token: 0x04005AA6 RID: 23206
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04005AA7 RID: 23207
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04005AA8 RID: 23208
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04005AA9 RID: 23209
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0;

		// Token: 0x04005AAA RID: 23210
		private static readonly IntPtr NativeMethodInfoPtr_GetMugshot_Public_Void_Action_1_Texture2D_0;

		// Token: 0x04005AAB RID: 23211
		private static readonly IntPtr NativeMethodInfoPtr_SetEmission_Public_Void_Color_0;

		// Token: 0x04005AAC RID: 23212
		private static readonly IntPtr NativeMethodInfoPtr_IsMale_Public_Boolean_0;

		// Token: 0x04005AAD RID: 23213
		private static readonly IntPtr NativeMethodInfoPtr_IsWhite_Public_Boolean_0;

		// Token: 0x04005AAE RID: 23214
		private static readonly IntPtr NativeMethodInfoPtr_GetFormalAddress_Public_String_Boolean_0;

		// Token: 0x04005AAF RID: 23215
		private static readonly IntPtr NativeMethodInfoPtr_GetThirdPersonAddress_Public_String_Boolean_0;

		// Token: 0x04005AB0 RID: 23216
		private static readonly IntPtr NativeMethodInfoPtr_GetThirdPersonPronoun_Public_String_Boolean_0;

		// Token: 0x04005AB1 RID: 23217
		private static readonly IntPtr NativeMethodInfoPtr_ApplyShapeKeys_Private_Void_Single_Single_Boolean_0;

		// Token: 0x04005AB2 RID: 23218
		private static readonly IntPtr NativeMethodInfoPtr_SetFeetShrunk_Private_Void_Boolean_Single_0;

		// Token: 0x04005AB3 RID: 23219
		private static readonly IntPtr NativeMethodInfoPtr_SetWearingHairBlockingAccessory_Private_Void_Boolean_0;

		// Token: 0x04005AB4 RID: 23220
		private static readonly IntPtr NativeMethodInfoPtr_LoadAvatarSettings_Public_Void_AvatarSettings_0;

		// Token: 0x04005AB5 RID: 23221
		private static readonly IntPtr NativeMethodInfoPtr_LoadNakedSettings_Public_Void_AvatarSettings_Int32_0;

		// Token: 0x04005AB6 RID: 23222
		private static readonly IntPtr NativeMethodInfoPtr_ApplyBodySettings_Public_Void_AvatarSettings_0;

		// Token: 0x04005AB7 RID: 23223
		private static readonly IntPtr NativeMethodInfoPtr_SetAdditionalWeight_Public_Void_Single_0;

		// Token: 0x04005AB8 RID: 23224
		private static readonly IntPtr NativeMethodInfoPtr_SetAdditionalGender_Public_Void_Single_0;

		// Token: 0x04005AB9 RID: 23225
		private static readonly IntPtr NativeMethodInfoPtr_SetSkinColor_Public_Void_Color_0;

		// Token: 0x04005ABA RID: 23226
		private static readonly IntPtr NativeMethodInfoPtr_ApplyHairSettings_Public_Void_AvatarSettings_0;

		// Token: 0x04005ABB RID: 23227
		private static readonly IntPtr NativeMethodInfoPtr_SetHairVisible_Public_Void_Boolean_0;

		// Token: 0x04005ABC RID: 23228
		private static readonly IntPtr NativeMethodInfoPtr_ApplyHairColorSettings_Public_Void_AvatarSettings_0;

		// Token: 0x04005ABD RID: 23229
		private static readonly IntPtr NativeMethodInfoPtr_OverrideHairColor_Public_Void_Color_0;

		// Token: 0x04005ABE RID: 23230
		private static readonly IntPtr NativeMethodInfoPtr_ResetHairColor_Public_Void_0;

		// Token: 0x04005ABF RID: 23231
		private static readonly IntPtr NativeMethodInfoPtr_ApplyEyeBallSettings_Public_Void_AvatarSettings_0;

		// Token: 0x04005AC0 RID: 23232
		private static readonly IntPtr NativeMethodInfoPtr_ApplyEyeLidSettings_Public_Void_AvatarSettings_0;

		// Token: 0x04005AC1 RID: 23233
		private static readonly IntPtr NativeMethodInfoPtr_ApplyEyeLidColorSettings_Public_Void_AvatarSettings_0;

		// Token: 0x04005AC2 RID: 23234
		private static readonly IntPtr NativeMethodInfoPtr_ApplyEyebrowSettings_Public_Void_AvatarSettings_0;

		// Token: 0x04005AC3 RID: 23235
		private static readonly IntPtr NativeMethodInfoPtr_SetBlockEyeFaceLayers_Public_Void_Boolean_0;

		// Token: 0x04005AC4 RID: 23236
		private static readonly IntPtr NativeMethodInfoPtr_ApplyFaceLayerSettings_Public_Void_AvatarSettings_0;

		// Token: 0x04005AC5 RID: 23237
		private static readonly IntPtr NativeMethodInfoPtr_SetFaceLayer_Private_Void_Int32_String_Color_0;

		// Token: 0x04005AC6 RID: 23238
		private static readonly IntPtr NativeMethodInfoPtr_SetFaceTexture_Public_Void_Texture2D_Color_0;

		// Token: 0x04005AC7 RID: 23239
		private static readonly IntPtr NativeMethodInfoPtr_ApplyBodyLayerSettings_Public_Void_AvatarSettings_Int32_0;

		// Token: 0x04005AC8 RID: 23240
		private static readonly IntPtr NativeMethodInfoPtr_SetBodyLayer_Private_Void_Int32_String_Color_0;

		// Token: 0x04005AC9 RID: 23241
		private static readonly IntPtr NativeMethodInfoPtr_ApplyAccessorySettings_Public_Void_AvatarSettings_0;

		// Token: 0x04005ACA RID: 23242
		private static readonly IntPtr NativeMethodInfoPtr_DestroyAccessories_Private_Void_0;

		// Token: 0x04005ACB RID: 23243
		private static readonly IntPtr NativeMethodInfoPtr_SetRagdollPhysicsEnabled_Public_Virtual_New_Void_Boolean_Boolean_0;

		// Token: 0x04005ACC RID: 23244
		private static readonly IntPtr NativeMethodInfoPtr_SetEquippable_Public_Virtual_New_AvatarEquippable_String_0;

		// Token: 0x04005ACD RID: 23245
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveEquippableMessage_Public_Virtual_New_Void_String_Object_0;

		// Token: 0x04005ACE RID: 23246
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AEA RID: 2794
		[ObfuscatedName("ScheduleOne.AvatarFramework.Avatar+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D56E RID: 54638 RVA: 0x0032E014 File Offset: 0x0032C214
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Avatar.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Avatar.__c>.NativeClassPtr);
				Avatar.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar.__c>.NativeClassPtr, "<>9");
				Avatar.__c.NativeFieldInfoPtr___9__90_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar.__c>.NativeClassPtr, "<>9__90_0");
				Avatar.__c.NativeFieldInfoPtr___9__93_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar.__c>.NativeClassPtr, "<>9__93_0");
				Avatar.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar.__c>.NativeClassPtr, 100679960);
				Avatar.__c.NativeMethodInfoPtr__ApplyFaceLayerSettings_b__90_0_Internal_Int32_Tuple_2_FaceLayer_Color_Tuple_2_FaceLayer_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar.__c>.NativeClassPtr, 100679961);
				Avatar.__c.NativeMethodInfoPtr__ApplyBodyLayerSettings_b__93_0_Internal_Int32_Tuple_2_AvatarLayer_Color_Tuple_2_AvatarLayer_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar.__c>.NativeClassPtr, 100679962);
			}

			// Token: 0x0600D56F RID: 54639 RVA: 0x0032E0B8 File Offset: 0x0032C2B8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Avatar.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D570 RID: 54640 RVA: 0x0032E0F4 File Offset: 0x0032C2F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249313, XrefRangeEnd = 249316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _ApplyFaceLayerSettings_b__90_0(Tuple<FaceLayer, Color> x, Tuple<FaceLayer, Color> y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.__c.NativeMethodInfoPtr__ApplyFaceLayerSettings_b__90_0_Internal_Int32_Tuple_2_FaceLayer_Color_Tuple_2_FaceLayer_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D571 RID: 54641 RVA: 0x0032E154 File Offset: 0x0032C354
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249316, XrefRangeEnd = 249319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _ApplyBodyLayerSettings_b__93_0(Tuple<AvatarLayer, Color> x, Tuple<AvatarLayer, Color> y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.__c.NativeMethodInfoPtr__ApplyBodyLayerSettings_b__93_0_Internal_Int32_Tuple_2_AvatarLayer_Color_Tuple_2_AvatarLayer_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D572 RID: 54642 RVA: 0x00067D64 File Offset: 0x00065F64
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004222 RID: 16930
			// (get) Token: 0x0600D573 RID: 54643 RVA: 0x0032E1B4 File Offset: 0x0032C3B4
			// (set) Token: 0x0600D574 RID: 54644 RVA: 0x00067D6D File Offset: 0x00065F6D
			public unsafe static Avatar.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Avatar.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Avatar.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004223 RID: 16931
			// (get) Token: 0x0600D575 RID: 54645 RVA: 0x0032E1DC File Offset: 0x0032C3DC
			// (set) Token: 0x0600D576 RID: 54646 RVA: 0x00067D7F File Offset: 0x00065F7F
			public unsafe static Comparison<Tuple<FaceLayer, Color>> __9__90_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Avatar.__c.NativeFieldInfoPtr___9__90_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<Tuple<FaceLayer, Color>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Avatar.__c.NativeFieldInfoPtr___9__90_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004224 RID: 16932
			// (get) Token: 0x0600D577 RID: 54647 RVA: 0x0032E204 File Offset: 0x0032C404
			// (set) Token: 0x0600D578 RID: 54648 RVA: 0x00067D91 File Offset: 0x00065F91
			public unsafe static Comparison<Tuple<AvatarLayer, Color>> __9__93_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Avatar.__c.NativeFieldInfoPtr___9__93_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<Tuple<AvatarLayer, Color>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Avatar.__c.NativeFieldInfoPtr___9__93_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F95 RID: 36757
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008F96 RID: 36758
			private static readonly IntPtr NativeFieldInfoPtr___9__90_0;

			// Token: 0x04008F97 RID: 36759
			private static readonly IntPtr NativeFieldInfoPtr___9__93_0;

			// Token: 0x04008F98 RID: 36760
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F99 RID: 36761
			private static readonly IntPtr NativeMethodInfoPtr__ApplyFaceLayerSettings_b__90_0_Internal_Int32_Tuple_2_FaceLayer_Color_Tuple_2_FaceLayer_Color_0;

			// Token: 0x04008F9A RID: 36762
			private static readonly IntPtr NativeMethodInfoPtr__ApplyBodyLayerSettings_b__93_0_Internal_Int32_Tuple_2_AvatarLayer_Color_Tuple_2_AvatarLayer_Color_0;
		}
	}
}
