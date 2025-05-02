using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Tools;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x020003E3 RID: 995
	public class PlayerCamera : PlayerSingleton<PlayerCamera>
	{
		// Token: 0x06004F35 RID: 20277 RVA: 0x0017B470 File Offset: 0x00179670
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerCamera()
		{
			Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "PlayerCamera");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr);
			PlayerCamera.NativeFieldInfoPtr_CAMERA_SHAKE_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "CAMERA_SHAKE_MULTIPLIER");
			PlayerCamera.NativeFieldInfoPtr__AntiAliasingMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<AntiAliasingMode>k__BackingField");
			PlayerCamera.NativeFieldInfoPtr_cameraOffsetFromTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "cameraOffsetFromTop");
			PlayerCamera.NativeFieldInfoPtr_SprintFoVBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "SprintFoVBoost");
			PlayerCamera.NativeFieldInfoPtr_FoVChangeRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "FoVChangeRate");
			PlayerCamera.NativeFieldInfoPtr_HorizontalCameraBob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "HorizontalCameraBob");
			PlayerCamera.NativeFieldInfoPtr_VerticalCameraBob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "VerticalCameraBob");
			PlayerCamera.NativeFieldInfoPtr_BobRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "BobRate");
			PlayerCamera.NativeFieldInfoPtr_HorizontalBobCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "HorizontalBobCurve");
			PlayerCamera.NativeFieldInfoPtr_VerticalBobCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "VerticalBobCurve");
			PlayerCamera.NativeFieldInfoPtr_FreeCamSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "FreeCamSpeed");
			PlayerCamera.NativeFieldInfoPtr_FreeCamAcceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "FreeCamAcceleration");
			PlayerCamera.NativeFieldInfoPtr_SmoothLook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "SmoothLook");
			PlayerCamera.NativeFieldInfoPtr_SmoothLookSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "SmoothLookSpeed");
			PlayerCamera.NativeFieldInfoPtr_FoVChangeSmoother = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "FoVChangeSmoother");
			PlayerCamera.NativeFieldInfoPtr_SmoothLookSmoother = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "SmoothLookSmoother");
			PlayerCamera.NativeFieldInfoPtr_CameraContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "CameraContainer");
			PlayerCamera.NativeFieldInfoPtr_Camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "Camera");
			PlayerCamera.NativeFieldInfoPtr_OverlayCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "OverlayCamera");
			PlayerCamera.NativeFieldInfoPtr_Animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "Animator");
			PlayerCamera.NativeFieldInfoPtr_JoltClips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "JoltClips");
			PlayerCamera.NativeFieldInfoPtr_URPAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "URPAssets");
			PlayerCamera.NativeFieldInfoPtr_ViewAvatarCameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "ViewAvatarCameraPosition");
			PlayerCamera.NativeFieldInfoPtr_HeartbeatSoundController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "HeartbeatSoundController");
			PlayerCamera.NativeFieldInfoPtr_Flies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "Flies");
			PlayerCamera.NativeFieldInfoPtr_MethRumble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "MethRumble");
			PlayerCamera.NativeFieldInfoPtr_SchizoVoices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "SchizoVoices");
			PlayerCamera.NativeFieldInfoPtr__canLook_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<canLook>k__BackingField");
			PlayerCamera.NativeFieldInfoPtr__transformOverriden_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<transformOverriden>k__BackingField");
			PlayerCamera.NativeFieldInfoPtr__fovOverriden_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<fovOverriden>k__BackingField");
			PlayerCamera.NativeFieldInfoPtr_blockNextStopTransformOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "blockNextStopTransformOverride");
			PlayerCamera.NativeFieldInfoPtr__FreeCamEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<FreeCamEnabled>k__BackingField");
			PlayerCamera.NativeFieldInfoPtr__ViewingAvatar_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<ViewingAvatar>k__BackingField");
			PlayerCamera.NativeFieldInfoPtr__CameraMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<CameraMode>k__BackingField");
			PlayerCamera.NativeFieldInfoPtr__MethVisuals_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<MethVisuals>k__BackingField");
			PlayerCamera.NativeFieldInfoPtr__CocaineVisuals_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<CocaineVisuals>k__BackingField");
			PlayerCamera.NativeFieldInfoPtr__FovJitter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<FovJitter>k__BackingField");
			PlayerCamera.NativeFieldInfoPtr_globalVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "globalVolume");
			PlayerCamera.NativeFieldInfoPtr_DoF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "DoF");
			PlayerCamera.NativeFieldInfoPtr__activeUIElements_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<activeUIElements>k__BackingField");
			PlayerCamera.NativeFieldInfoPtr_cameraShakeCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "cameraShakeCoroutine");
			PlayerCamera.NativeFieldInfoPtr_cameraLocalPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "cameraLocalPos");
			PlayerCamera.NativeFieldInfoPtr_freeCamMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "freeCamMovement");
			PlayerCamera.NativeFieldInfoPtr_focusRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "focusRoutine");
			PlayerCamera.NativeFieldInfoPtr_focusMouseX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "focusMouseX");
			PlayerCamera.NativeFieldInfoPtr_focusMouseY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "focusMouseY");
			PlayerCamera.NativeFieldInfoPtr_movementEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "movementEvents");
			PlayerCamera.NativeFieldInfoPtr_freeCamSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "freeCamSpeed");
			PlayerCamera.NativeFieldInfoPtr_mouseX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "mouseX");
			PlayerCamera.NativeFieldInfoPtr_mouseY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "mouseY");
			PlayerCamera.NativeFieldInfoPtr_seizureJitter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "seizureJitter");
			PlayerCamera.NativeFieldInfoPtr_schizoFoV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "schizoFoV");
			PlayerCamera.NativeFieldInfoPtr_timeUntilNextSchizoVoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "timeUntilNextSchizoVoice");
			PlayerCamera.NativeFieldInfoPtr_gizmos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "gizmos");
			PlayerCamera.NativeFieldInfoPtr_cameralocalPos_PriorOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "cameralocalPos_PriorOverride");
			PlayerCamera.NativeFieldInfoPtr_cameraLocalRot_PriorOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "cameraLocalRot_PriorOverride");
			PlayerCamera.NativeFieldInfoPtr_ILerpCamera_Coroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "ILerpCamera_Coroutine");
			PlayerCamera.NativeFieldInfoPtr_lookRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "lookRoutine");
			PlayerCamera.NativeFieldInfoPtr_DoFCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "DoFCoroutine");
			PlayerCamera.NativeFieldInfoPtr_ILerpCameraFOV_Coroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "ILerpCameraFOV_Coroutine");
			PlayerCamera.NativeMethodInfoPtr_get_AntiAliasingMode_Public_Static_get_EAntiAliasingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673196);
			PlayerCamera.NativeMethodInfoPtr_set_AntiAliasingMode_Private_Static_set_Void_EAntiAliasingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673197);
			PlayerCamera.NativeMethodInfoPtr_get_canLook_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673198);
			PlayerCamera.NativeMethodInfoPtr_set_canLook_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673199);
			PlayerCamera.NativeMethodInfoPtr_get_activeUIElementCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673200);
			PlayerCamera.NativeMethodInfoPtr_get_transformOverriden_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673201);
			PlayerCamera.NativeMethodInfoPtr_set_transformOverriden_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673202);
			PlayerCamera.NativeMethodInfoPtr_get_fovOverriden_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673203);
			PlayerCamera.NativeMethodInfoPtr_set_fovOverriden_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673204);
			PlayerCamera.NativeMethodInfoPtr_get_FreeCamEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673205);
			PlayerCamera.NativeMethodInfoPtr_set_FreeCamEnabled_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673206);
			PlayerCamera.NativeMethodInfoPtr_get_ViewingAvatar_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673207);
			PlayerCamera.NativeMethodInfoPtr_set_ViewingAvatar_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673208);
			PlayerCamera.NativeMethodInfoPtr_get_CameraMode_Public_get_ECameraMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673209);
			PlayerCamera.NativeMethodInfoPtr_set_CameraMode_Protected_set_Void_ECameraMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673210);
			PlayerCamera.NativeMethodInfoPtr_get_MethVisuals_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673211);
			PlayerCamera.NativeMethodInfoPtr_set_MethVisuals_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673212);
			PlayerCamera.NativeMethodInfoPtr_get_CocaineVisuals_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673213);
			PlayerCamera.NativeMethodInfoPtr_set_CocaineVisuals_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673214);
			PlayerCamera.NativeMethodInfoPtr_get_FovJitter_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673215);
			PlayerCamera.NativeMethodInfoPtr_set_FovJitter_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673216);
			PlayerCamera.NativeMethodInfoPtr_get_activeUIElements_Public_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673217);
			PlayerCamera.NativeMethodInfoPtr_set_activeUIElements_Protected_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673218);
			PlayerCamera.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673219);
			PlayerCamera.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673220);
			PlayerCamera.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673221);
			PlayerCamera.NativeMethodInfoPtr_PlayerSpawned_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673222);
			PlayerCamera.NativeMethodInfoPtr_SetAntialiasingMode_Public_Static_Void_EAntiAliasingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673223);
			PlayerCamera.NativeMethodInfoPtr_ApplyAASettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673224);
			PlayerCamera.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673225);
			PlayerCamera.NativeMethodInfoPtr_Screenshot_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673226);
			PlayerCamera.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673227);
			PlayerCamera.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673228);
			PlayerCamera.NativeMethodInfoPtr_GetTargetLocalY_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673229);
			PlayerCamera.NativeMethodInfoPtr_SetCameraMode_Public_Void_ECameraMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673230);
			PlayerCamera.NativeMethodInfoPtr_RotateCamera_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673231);
			PlayerCamera.NativeMethodInfoPtr_LockMouse_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673232);
			PlayerCamera.NativeMethodInfoPtr_FreeMouse_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673233);
			PlayerCamera.NativeMethodInfoPtr_LookRaycast_Public_Boolean_Single_byref_RaycastHit_LayerMask_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673234);
			PlayerCamera.NativeMethodInfoPtr_LookRaycast_ExcludeBuildables_Public_Boolean_Single_byref_RaycastHit_LayerMask_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673235);
			PlayerCamera.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673236);
			PlayerCamera.NativeMethodInfoPtr_Raycast_ExcludeBuildables_Public_Boolean_Vector3_Vector3_Single_byref_RaycastHit_LayerMask_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673237);
			PlayerCamera.NativeMethodInfoPtr_MouseRaycast_Public_Boolean_Single_byref_RaycastHit_LayerMask_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673238);
			PlayerCamera.NativeMethodInfoPtr_LookSpherecast_Public_Boolean_Single_Single_byref_RaycastHit_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673239);
			PlayerCamera.NativeMethodInfoPtr_OverrideTransform_Public_Void_Vector3_Quaternion_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673240);
			PlayerCamera.NativeMethodInfoPtr_ILerpCamera_Protected_IEnumerator_Vector3_Quaternion_Single_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673241);
			PlayerCamera.NativeMethodInfoPtr_StopTransformOverride_Public_Void_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673242);
			PlayerCamera.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673243);
			PlayerCamera.NativeMethodInfoPtr_SetCanLook_True_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673244);
			PlayerCamera.NativeMethodInfoPtr_SetCanLook_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673245);
			PlayerCamera.NativeMethodInfoPtr_SetDoFActive_Public_Void_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673246);
			PlayerCamera.NativeMethodInfoPtr_LerpDoF_Private_IEnumerator_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673247);
			PlayerCamera.NativeMethodInfoPtr_OverrideFOV_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673248);
			PlayerCamera.NativeMethodInfoPtr_ILerpFOV_Protected_IEnumerator_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673249);
			PlayerCamera.NativeMethodInfoPtr_StopFOVOverride_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673250);
			PlayerCamera.NativeMethodInfoPtr_AddActiveUIElement_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673251);
			PlayerCamera.NativeMethodInfoPtr_RemoveActiveUIElement_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673252);
			PlayerCamera.NativeMethodInfoPtr_RegisterMovementEvent_Public_Void_Int32_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673253);
			PlayerCamera.NativeMethodInfoPtr_DeregisterMovementEvent_Public_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673254);
			PlayerCamera.NativeMethodInfoPtr_UpdateMovementEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673255);
			PlayerCamera.NativeMethodInfoPtr_ViewAvatar_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673256);
			PlayerCamera.NativeMethodInfoPtr_StopViewingAvatar_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673257);
			PlayerCamera.NativeMethodInfoPtr_JoltCamera_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673258);
			PlayerCamera.NativeMethodInfoPtr_PointInCameraView_Public_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673259);
			PlayerCamera.NativeMethodInfoPtr_Is01_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673260);
			PlayerCamera.NativeMethodInfoPtr_ResetRotation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673261);
			PlayerCamera.NativeMethodInfoPtr_FocusCameraOnTarget_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673262);
			PlayerCamera.NativeMethodInfoPtr_StopFocus_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673263);
			PlayerCamera.NativeMethodInfoPtr_StartCameraShake_Public_Void_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673264);
			PlayerCamera.NativeMethodInfoPtr_StopCameraShake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673265);
			PlayerCamera.NativeMethodInfoPtr_UpdateCameraBob_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673266);
			PlayerCamera.NativeMethodInfoPtr_SetFreeCam_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673267);
			PlayerCamera.NativeMethodInfoPtr_RotateFreeCam_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673268);
			PlayerCamera.NativeMethodInfoPtr_UpdateFreeCamInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673269);
			PlayerCamera.NativeMethodInfoPtr_MoveFreeCam_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673270);
			PlayerCamera.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673271);
			PlayerCamera.NativeMethodInfoPtr__PlayerSpawned_b__92_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673272);
			PlayerCamera.NativeMethodInfoPtr_Method_Internal_Static_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673273);
		}

		// Token: 0x170017EB RID: 6123
		// (get) Token: 0x06004F36 RID: 20278 RVA: 0x0017BF68 File Offset: 0x0017A168
		// (set) Token: 0x06004F37 RID: 20279 RVA: 0x0017BF98 File Offset: 0x0017A198
		public unsafe static Il2CppScheduleOne.DevUtilities.GraphicsSettings.EAntiAliasingMode AntiAliasingMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172360, XrefRangeEnd = 172362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_AntiAliasingMode_Public_Static_get_EAntiAliasingMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172362, XrefRangeEnd = 172364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_set_AntiAliasingMode_Private_Static_set_Void_EAntiAliasingMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017EC RID: 6124
		// (get) Token: 0x06004F38 RID: 20280 RVA: 0x0017BFCC File Offset: 0x0017A1CC
		// (set) Token: 0x06004F39 RID: 20281 RVA: 0x0017C008 File Offset: 0x0017A208
		public unsafe bool canLook
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_canLook_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(51)]
			[CachedScanResults(RefRangeStart = 49275, RefRangeEnd = 49326, XrefRangeStart = 49275, XrefRangeEnd = 49326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_set_canLook_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017ED RID: 6125
		// (get) Token: 0x06004F3A RID: 20282 RVA: 0x0017C048 File Offset: 0x0017A248
		public unsafe int activeUIElementCount
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 172365, RefRangeEnd = 172385, XrefRangeStart = 172364, XrefRangeEnd = 172365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_activeUIElementCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170017EE RID: 6126
		// (get) Token: 0x06004F3B RID: 20283 RVA: 0x0017C084 File Offset: 0x0017A284
		// (set) Token: 0x06004F3C RID: 20284 RVA: 0x0017C0C0 File Offset: 0x0017A2C0
		public unsafe bool transformOverriden
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_transformOverriden_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_set_transformOverriden_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017EF RID: 6127
		// (get) Token: 0x06004F3D RID: 20285 RVA: 0x0017C100 File Offset: 0x0017A300
		// (set) Token: 0x06004F3E RID: 20286 RVA: 0x0017C13C File Offset: 0x0017A33C
		public unsafe bool fovOverriden
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_fovOverriden_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_set_fovOverriden_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017F0 RID: 6128
		// (get) Token: 0x06004F3F RID: 20287 RVA: 0x0017C17C File Offset: 0x0017A37C
		// (set) Token: 0x06004F40 RID: 20288 RVA: 0x0017C1B8 File Offset: 0x0017A3B8
		public unsafe bool FreeCamEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_FreeCamEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_set_FreeCamEnabled_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017F1 RID: 6129
		// (get) Token: 0x06004F41 RID: 20289 RVA: 0x0017C1F8 File Offset: 0x0017A3F8
		// (set) Token: 0x06004F42 RID: 20290 RVA: 0x0017C234 File Offset: 0x0017A434
		public unsafe bool ViewingAvatar
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_ViewingAvatar_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_set_ViewingAvatar_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017F2 RID: 6130
		// (get) Token: 0x06004F43 RID: 20291 RVA: 0x0017C274 File Offset: 0x0017A474
		// (set) Token: 0x06004F44 RID: 20292 RVA: 0x0017C2B0 File Offset: 0x0017A4B0
		public unsafe PlayerCamera.ECameraMode CameraMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_CameraMode_Public_get_ECameraMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 49919, RefRangeEnd = 49923, XrefRangeStart = 49919, XrefRangeEnd = 49923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_set_CameraMode_Protected_set_Void_ECameraMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017F3 RID: 6131
		// (get) Token: 0x06004F45 RID: 20293 RVA: 0x0017C2F0 File Offset: 0x0017A4F0
		// (set) Token: 0x06004F46 RID: 20294 RVA: 0x0017C32C File Offset: 0x0017A52C
		public unsafe bool MethVisuals
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_MethVisuals_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_set_MethVisuals_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017F4 RID: 6132
		// (get) Token: 0x06004F47 RID: 20295 RVA: 0x0017C36C File Offset: 0x0017A56C
		// (set) Token: 0x06004F48 RID: 20296 RVA: 0x0017C3A8 File Offset: 0x0017A5A8
		public unsafe bool CocaineVisuals
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_CocaineVisuals_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_set_CocaineVisuals_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017F5 RID: 6133
		// (get) Token: 0x06004F49 RID: 20297 RVA: 0x0017C3E8 File Offset: 0x0017A5E8
		// (set) Token: 0x06004F4A RID: 20298 RVA: 0x0017C424 File Offset: 0x0017A624
		public unsafe float FovJitter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_FovJitter_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_set_FovJitter_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017F6 RID: 6134
		// (get) Token: 0x06004F4B RID: 20299 RVA: 0x0017C464 File Offset: 0x0017A664
		// (set) Token: 0x06004F4C RID: 20300 RVA: 0x0017C4A4 File Offset: 0x0017A6A4
		public unsafe List<string> activeUIElements
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_activeUIElements_Public_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_set_activeUIElements_Protected_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004F4D RID: 20301 RVA: 0x0017C4E8 File Offset: 0x0017A6E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172385, XrefRangeEnd = 172434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCamera.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F4E RID: 20302 RVA: 0x0017C524 File Offset: 0x0017A724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172434, XrefRangeEnd = 172444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient(bool IsOwner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref IsOwner;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCamera.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F4F RID: 20303 RVA: 0x0017C570 File Offset: 0x0017A770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172444, XrefRangeEnd = 172492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCamera.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F50 RID: 20304 RVA: 0x0017C5AC File Offset: 0x0017A7AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172492, XrefRangeEnd = 172511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerSpawned()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_PlayerSpawned_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F51 RID: 20305 RVA: 0x0017C5E0 File Offset: 0x0017A7E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 172525, RefRangeEnd = 172528, XrefRangeStart = 172511, XrefRangeEnd = 172525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetAntialiasingMode(Il2CppScheduleOne.DevUtilities.GraphicsSettings.EAntiAliasingMode mode)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_SetAntialiasingMode_Public_Static_Void_EAntiAliasingMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F52 RID: 20306 RVA: 0x0017C614 File Offset: 0x0017A814
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 172535, RefRangeEnd = 172537, XrefRangeStart = 172528, XrefRangeEnd = 172535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyAASettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_ApplyAASettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F53 RID: 20307 RVA: 0x0017C648 File Offset: 0x0017A848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172537, XrefRangeEnd = 172614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCamera.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F54 RID: 20308 RVA: 0x0017C684 File Offset: 0x0017A884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172614, XrefRangeEnd = 172619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Screenshot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_Screenshot_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F55 RID: 20309 RVA: 0x0017C6B8 File Offset: 0x0017A8B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172619, XrefRangeEnd = 172668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCamera.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F56 RID: 20310 RVA: 0x0017C6F4 File Offset: 0x0017A8F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172668, XrefRangeEnd = 172672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F57 RID: 20311 RVA: 0x0017C738 File Offset: 0x0017A938
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 172680, RefRangeEnd = 172686, XrefRangeStart = 172672, XrefRangeEnd = 172680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetTargetLocalY()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_GetTargetLocalY_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004F58 RID: 20312 RVA: 0x0017C774 File Offset: 0x0017A974
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 49919, RefRangeEnd = 49923, XrefRangeStart = 49919, XrefRangeEnd = 49923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCameraMode(PlayerCamera.ECameraMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_SetCameraMode_Public_Void_ECameraMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F59 RID: 20313 RVA: 0x0017C7B4 File Offset: 0x0017A9B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 172764, RefRangeEnd = 172765, XrefRangeStart = 172686, XrefRangeEnd = 172764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RotateCamera()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_RotateCamera_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F5A RID: 20314 RVA: 0x0017C7E8 File Offset: 0x0017A9E8
		[CallerCount(40)]
		[CachedScanResults(RefRangeStart = 172775, RefRangeEnd = 172815, XrefRangeStart = 172765, XrefRangeEnd = 172775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LockMouse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_LockMouse_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F5B RID: 20315 RVA: 0x0017C81C File Offset: 0x0017AA1C
		[CallerCount(40)]
		[CachedScanResults(RefRangeStart = 172825, RefRangeEnd = 172865, XrefRangeStart = 172815, XrefRangeEnd = 172825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FreeMouse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_FreeMouse_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F5C RID: 20316 RVA: 0x0017C850 File Offset: 0x0017AA50
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 172874, RefRangeEnd = 172904, XrefRangeStart = 172865, XrefRangeEnd = 172874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool LookRaycast(float range, out RaycastHit hit, LayerMask layerMask, bool includeTriggers = true, float radius = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref range;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hit;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeTriggers;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_LookRaycast_Public_Boolean_Single_byref_RaycastHit_LayerMask_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004F5D RID: 20317 RVA: 0x0017C8D4 File Offset: 0x0017AAD4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 172938, RefRangeEnd = 172942, XrefRangeStart = 172904, XrefRangeEnd = 172938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool LookRaycast_ExcludeBuildables(float range, out RaycastHit hit, LayerMask layerMask, bool includeTriggers = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref range;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hit;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeTriggers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_LookRaycast_ExcludeBuildables_Public_Boolean_Single_byref_RaycastHit_LayerMask_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004F5E RID: 20318 RVA: 0x0017C948 File Offset: 0x0017AB48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172942, XrefRangeEnd = 172949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmosSelected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F5F RID: 20319 RVA: 0x0017C97C File Offset: 0x0017AB7C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 172989, RefRangeEnd = 172997, XrefRangeStart = 172949, XrefRangeEnd = 172989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Raycast_ExcludeBuildables(Vector3 origin, Vector3 direction, float range, out RaycastHit hit, LayerMask layerMask, bool includeTriggers = false, float radius = 0f, float maxAngleDifference = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref range;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hit;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeTriggers;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxAngleDifference;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_Raycast_ExcludeBuildables_Public_Boolean_Vector3_Vector3_Single_byref_RaycastHit_LayerMask_Boolean_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004F60 RID: 20320 RVA: 0x0017CA28 File Offset: 0x0017AC28
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 173008, RefRangeEnd = 173021, XrefRangeStart = 172997, XrefRangeEnd = 173008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MouseRaycast(float range, out RaycastHit hit, LayerMask layerMask, bool includeTriggers = true, float radius = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref range;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hit;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeTriggers;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_MouseRaycast_Public_Boolean_Single_byref_RaycastHit_LayerMask_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004F61 RID: 20321 RVA: 0x0017CAAC File Offset: 0x0017ACAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173021, XrefRangeEnd = 173030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool LookSpherecast(float range, float radius, out RaycastHit hit, LayerMask layerMask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref range;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hit;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_LookSpherecast_Public_Boolean_Single_Single_byref_RaycastHit_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004F62 RID: 20322 RVA: 0x0017CB20 File Offset: 0x0017AD20
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 173051, RefRangeEnd = 173105, XrefRangeStart = 173030, XrefRangeEnd = 173051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideTransform(Vector3 worldPos, Quaternion rot, float lerpTime, bool keepParented = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref worldPos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lerpTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keepParented;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_OverrideTransform_Public_Void_Vector3_Quaternion_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F63 RID: 20323 RVA: 0x0017CB88 File Offset: 0x0017AD88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173105, XrefRangeEnd = 173110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ILerpCamera(Vector3 endPos, Quaternion endRot, float lerpTime, bool worldSpace, bool returnToRestingPosition = false, bool reenableLook = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref endPos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endRot;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lerpTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldSpace;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref returnToRestingPosition;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reenableLook;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_ILerpCamera_Protected_IEnumerator_Vector3_Quaternion_Single_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004F64 RID: 20324 RVA: 0x0017CC1C File Offset: 0x0017AE1C
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 173132, RefRangeEnd = 173163, XrefRangeStart = 173110, XrefRangeEnd = 173132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopTransformOverride(float lerpTime, bool reenableCameraLook = true, bool returnToOriginalRotation = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lerpTime;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reenableCameraLook;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref returnToOriginalRotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_StopTransformOverride_Public_Void_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F65 RID: 20325 RVA: 0x0017CC78 File Offset: 0x0017AE78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173163, XrefRangeEnd = 173176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LookAt(Vector3 point, float duration = 0.25f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F66 RID: 20326 RVA: 0x0017CCC4 File Offset: 0x0017AEC4
		[CallerCount(0)]
		public unsafe void SetCanLook_True()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_SetCanLook_True_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F67 RID: 20327 RVA: 0x0017CCF8 File Offset: 0x0017AEF8
		[CallerCount(51)]
		[CachedScanResults(RefRangeStart = 49275, RefRangeEnd = 49326, XrefRangeStart = 49275, XrefRangeEnd = 49326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCanLook(bool c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref c;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_SetCanLook_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F68 RID: 20328 RVA: 0x0017CD38 File Offset: 0x0017AF38
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 173184, RefRangeEnd = 173206, XrefRangeStart = 173176, XrefRangeEnd = 173184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDoFActive(bool active, float lerpTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lerpTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_SetDoFActive_Public_Void_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F69 RID: 20329 RVA: 0x0017CD84 File Offset: 0x0017AF84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173206, XrefRangeEnd = 173211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LerpDoF(bool active, float lerpTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lerpTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_LerpDoF_Private_IEnumerator_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004F6A RID: 20330 RVA: 0x0017CDE0 File Offset: 0x0017AFE0
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 173224, RefRangeEnd = 173268, XrefRangeStart = 173211, XrefRangeEnd = 173224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideFOV(float fov, float lerpTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fov;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lerpTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_OverrideFOV_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F6B RID: 20331 RVA: 0x0017CE2C File Offset: 0x0017B02C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173268, XrefRangeEnd = 173273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ILerpFOV(float endFov, float lerpTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref endFov;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lerpTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_ILerpFOV_Protected_IEnumerator_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004F6C RID: 20332 RVA: 0x0017CE88 File Offset: 0x0017B088
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 173285, RefRangeEnd = 173311, XrefRangeStart = 173273, XrefRangeEnd = 173285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopFOVOverride(float lerpTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lerpTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_StopFOVOverride_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F6D RID: 20333 RVA: 0x0017CEC8 File Offset: 0x0017B0C8
		[CallerCount(63)]
		[CachedScanResults(RefRangeStart = 173317, RefRangeEnd = 173380, XrefRangeStart = 173311, XrefRangeEnd = 173317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddActiveUIElement(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_AddActiveUIElement_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F6E RID: 20334 RVA: 0x0017CF0C File Offset: 0x0017B10C
		[CallerCount(66)]
		[CachedScanResults(RefRangeStart = 173386, RefRangeEnd = 173452, XrefRangeStart = 173380, XrefRangeEnd = 173386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveActiveUIElement(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_RemoveActiveUIElement_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F6F RID: 20335 RVA: 0x0017CF50 File Offset: 0x0017B150
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 173470, RefRangeEnd = 173472, XrefRangeStart = 173452, XrefRangeEnd = 173470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterMovementEvent(int threshold, Action action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref threshold;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_RegisterMovementEvent_Public_Void_Int32_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F70 RID: 20336 RVA: 0x0017CFA0 File Offset: 0x0017B1A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173500, RefRangeEnd = 173501, XrefRangeStart = 173472, XrefRangeEnd = 173500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeregisterMovementEvent(Action action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_DeregisterMovementEvent_Public_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F71 RID: 20337 RVA: 0x0017CFE4 File Offset: 0x0017B1E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173534, RefRangeEnd = 173535, XrefRangeStart = 173501, XrefRangeEnd = 173534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMovementEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_UpdateMovementEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F72 RID: 20338 RVA: 0x0017D018 File Offset: 0x0017B218
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173583, RefRangeEnd = 173584, XrefRangeStart = 173535, XrefRangeEnd = 173583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ViewAvatar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_ViewAvatar_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F73 RID: 20339 RVA: 0x0017D04C File Offset: 0x0017B24C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 173604, RefRangeEnd = 173606, XrefRangeStart = 173584, XrefRangeEnd = 173604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopViewingAvatar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_StopViewingAvatar_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F74 RID: 20340 RVA: 0x0017D080 File Offset: 0x0017B280
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 173609, RefRangeEnd = 173612, XrefRangeStart = 173606, XrefRangeEnd = 173609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void JoltCamera()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_JoltCamera_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F75 RID: 20341 RVA: 0x0017D0B4 File Offset: 0x0017B2B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173612, XrefRangeEnd = 173636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PointInCameraView(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_PointInCameraView_Public_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004F76 RID: 20342 RVA: 0x0017D100 File Offset: 0x0017B300
		[CallerCount(0)]
		public unsafe bool Is01(float a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_Is01_Public_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004F77 RID: 20343 RVA: 0x0017D14C File Offset: 0x0017B34C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 173640, RefRangeEnd = 173643, XrefRangeStart = 173636, XrefRangeEnd = 173640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_ResetRotation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F78 RID: 20344 RVA: 0x0017D180 File Offset: 0x0017B380
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173658, RefRangeEnd = 173659, XrefRangeStart = 173643, XrefRangeEnd = 173658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FocusCameraOnTarget(Transform target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_FocusCameraOnTarget_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F79 RID: 20345 RVA: 0x0017D1C4 File Offset: 0x0017B3C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173660, RefRangeEnd = 173661, XrefRangeStart = 173659, XrefRangeEnd = 173660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopFocus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_StopFocus_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F7A RID: 20346 RVA: 0x0017D1F8 File Offset: 0x0017B3F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 173679, RefRangeEnd = 173682, XrefRangeStart = 173661, XrefRangeEnd = 173679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartCameraShake(float intensity, float duration = -1f, bool decreaseOverTime = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref intensity;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref decreaseOverTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_StartCameraShake_Public_Void_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F7B RID: 20347 RVA: 0x0017D254 File Offset: 0x0017B454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173682, XrefRangeEnd = 173687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopCameraShake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_StopCameraShake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F7C RID: 20348 RVA: 0x0017D288 File Offset: 0x0017B488
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173704, RefRangeEnd = 173705, XrefRangeStart = 173687, XrefRangeEnd = 173704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCameraBob()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_UpdateCameraBob_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F7D RID: 20349 RVA: 0x0017D2BC File Offset: 0x0017B4BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 173728, RefRangeEnd = 173731, XrefRangeStart = 173705, XrefRangeEnd = 173728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFreeCam(bool enable, bool reenableLook = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enable;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reenableLook;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_SetFreeCam_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F7E RID: 20350 RVA: 0x0017D308 File Offset: 0x0017B508
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173780, RefRangeEnd = 173781, XrefRangeStart = 173731, XrefRangeEnd = 173780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RotateFreeCam()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_RotateFreeCam_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F7F RID: 20351 RVA: 0x0017D33C File Offset: 0x0017B53C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173805, RefRangeEnd = 173806, XrefRangeStart = 173781, XrefRangeEnd = 173805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFreeCamInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_UpdateFreeCamInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F80 RID: 20352 RVA: 0x0017D370 File Offset: 0x0017B570
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173817, RefRangeEnd = 173818, XrefRangeStart = 173806, XrefRangeEnd = 173817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveFreeCam()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_MoveFreeCam_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F81 RID: 20353 RVA: 0x0017D3A4 File Offset: 0x0017B5A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173818, XrefRangeEnd = 173852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerCamera() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F82 RID: 20354 RVA: 0x0017D3E0 File Offset: 0x0017B5E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173852, XrefRangeEnd = 173870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _PlayerSpawned_b__92_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr__PlayerSpawned_b__92_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F83 RID: 20355 RVA: 0x0017D414 File Offset: 0x0017B614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173870, XrefRangeEnd = 173874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator Method_Internal_Static_IEnumerator_PDM_0()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_Method_Internal_Static_IEnumerator_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004F84 RID: 20356 RVA: 0x00025B72 File Offset: 0x00023D72
		public PlayerCamera(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170017AF RID: 6063
		// (get) Token: 0x06004F85 RID: 20357 RVA: 0x0017D448 File Offset: 0x0017B648
		// (set) Token: 0x06004F86 RID: 20358 RVA: 0x00025B7B File Offset: 0x00023D7B
		public unsafe static float CAMERA_SHAKE_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCamera.NativeFieldInfoPtr_CAMERA_SHAKE_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCamera.NativeFieldInfoPtr_CAMERA_SHAKE_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x170017B0 RID: 6064
		// (get) Token: 0x06004F87 RID: 20359 RVA: 0x0017D464 File Offset: 0x0017B664
		// (set) Token: 0x06004F88 RID: 20360 RVA: 0x00025B89 File Offset: 0x00023D89
		public unsafe static Il2CppScheduleOne.DevUtilities.GraphicsSettings.EAntiAliasingMode _AntiAliasingMode_k__BackingField
		{
			get
			{
				Il2CppScheduleOne.DevUtilities.GraphicsSettings.EAntiAliasingMode result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCamera.NativeFieldInfoPtr__AntiAliasingMode_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCamera.NativeFieldInfoPtr__AntiAliasingMode_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x170017B1 RID: 6065
		// (get) Token: 0x06004F89 RID: 20361 RVA: 0x0017D480 File Offset: 0x0017B680
		// (set) Token: 0x06004F8A RID: 20362 RVA: 0x00025B97 File Offset: 0x00023D97
		public unsafe float cameraOffsetFromTop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_cameraOffsetFromTop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_cameraOffsetFromTop)) = value;
			}
		}

		// Token: 0x170017B2 RID: 6066
		// (get) Token: 0x06004F8B RID: 20363 RVA: 0x0017D4A8 File Offset: 0x0017B6A8
		// (set) Token: 0x06004F8C RID: 20364 RVA: 0x00025BB2 File Offset: 0x00023DB2
		public unsafe float SprintFoVBoost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_SprintFoVBoost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_SprintFoVBoost)) = value;
			}
		}

		// Token: 0x170017B3 RID: 6067
		// (get) Token: 0x06004F8D RID: 20365 RVA: 0x0017D4D0 File Offset: 0x0017B6D0
		// (set) Token: 0x06004F8E RID: 20366 RVA: 0x00025BCD File Offset: 0x00023DCD
		public unsafe float FoVChangeRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_FoVChangeRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_FoVChangeRate)) = value;
			}
		}

		// Token: 0x170017B4 RID: 6068
		// (get) Token: 0x06004F8F RID: 20367 RVA: 0x0017D4F8 File Offset: 0x0017B6F8
		// (set) Token: 0x06004F90 RID: 20368 RVA: 0x00025BE8 File Offset: 0x00023DE8
		public unsafe float HorizontalCameraBob
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_HorizontalCameraBob);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_HorizontalCameraBob)) = value;
			}
		}

		// Token: 0x170017B5 RID: 6069
		// (get) Token: 0x06004F91 RID: 20369 RVA: 0x0017D520 File Offset: 0x0017B720
		// (set) Token: 0x06004F92 RID: 20370 RVA: 0x00025C03 File Offset: 0x00023E03
		public unsafe float VerticalCameraBob
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_VerticalCameraBob);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_VerticalCameraBob)) = value;
			}
		}

		// Token: 0x170017B6 RID: 6070
		// (get) Token: 0x06004F93 RID: 20371 RVA: 0x0017D548 File Offset: 0x0017B748
		// (set) Token: 0x06004F94 RID: 20372 RVA: 0x00025C1E File Offset: 0x00023E1E
		public unsafe float BobRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_BobRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_BobRate)) = value;
			}
		}

		// Token: 0x170017B7 RID: 6071
		// (get) Token: 0x06004F95 RID: 20373 RVA: 0x0017D570 File Offset: 0x0017B770
		// (set) Token: 0x06004F96 RID: 20374 RVA: 0x00025C39 File Offset: 0x00023E39
		public unsafe AnimationCurve HorizontalBobCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_HorizontalBobCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_HorizontalBobCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017B8 RID: 6072
		// (get) Token: 0x06004F97 RID: 20375 RVA: 0x0017D5A0 File Offset: 0x0017B7A0
		// (set) Token: 0x06004F98 RID: 20376 RVA: 0x00025C58 File Offset: 0x00023E58
		public unsafe AnimationCurve VerticalBobCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_VerticalBobCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_VerticalBobCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017B9 RID: 6073
		// (get) Token: 0x06004F99 RID: 20377 RVA: 0x0017D5D0 File Offset: 0x0017B7D0
		// (set) Token: 0x06004F9A RID: 20378 RVA: 0x00025C77 File Offset: 0x00023E77
		public unsafe float FreeCamSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_FreeCamSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_FreeCamSpeed)) = value;
			}
		}

		// Token: 0x170017BA RID: 6074
		// (get) Token: 0x06004F9B RID: 20379 RVA: 0x0017D5F8 File Offset: 0x0017B7F8
		// (set) Token: 0x06004F9C RID: 20380 RVA: 0x00025C92 File Offset: 0x00023E92
		public unsafe float FreeCamAcceleration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_FreeCamAcceleration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_FreeCamAcceleration)) = value;
			}
		}

		// Token: 0x170017BB RID: 6075
		// (get) Token: 0x06004F9D RID: 20381 RVA: 0x0017D620 File Offset: 0x0017B820
		// (set) Token: 0x06004F9E RID: 20382 RVA: 0x00025CAD File Offset: 0x00023EAD
		public unsafe bool SmoothLook
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_SmoothLook);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_SmoothLook)) = value;
			}
		}

		// Token: 0x170017BC RID: 6076
		// (get) Token: 0x06004F9F RID: 20383 RVA: 0x0017D648 File Offset: 0x0017B848
		// (set) Token: 0x06004FA0 RID: 20384 RVA: 0x00025CC8 File Offset: 0x00023EC8
		public unsafe float SmoothLookSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_SmoothLookSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_SmoothLookSpeed)) = value;
			}
		}

		// Token: 0x170017BD RID: 6077
		// (get) Token: 0x06004FA1 RID: 20385 RVA: 0x0017D670 File Offset: 0x0017B870
		// (set) Token: 0x06004FA2 RID: 20386 RVA: 0x00025CE3 File Offset: 0x00023EE3
		public unsafe FloatSmoother FoVChangeSmoother
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_FoVChangeSmoother);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_FoVChangeSmoother), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017BE RID: 6078
		// (get) Token: 0x06004FA3 RID: 20387 RVA: 0x0017D6A0 File Offset: 0x0017B8A0
		// (set) Token: 0x06004FA4 RID: 20388 RVA: 0x00025D02 File Offset: 0x00023F02
		public unsafe FloatSmoother SmoothLookSmoother
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_SmoothLookSmoother);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_SmoothLookSmoother), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017BF RID: 6079
		// (get) Token: 0x06004FA5 RID: 20389 RVA: 0x0017D6D0 File Offset: 0x0017B8D0
		// (set) Token: 0x06004FA6 RID: 20390 RVA: 0x00025D21 File Offset: 0x00023F21
		public unsafe Transform CameraContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_CameraContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_CameraContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017C0 RID: 6080
		// (get) Token: 0x06004FA7 RID: 20391 RVA: 0x0017D700 File Offset: 0x0017B900
		// (set) Token: 0x06004FA8 RID: 20392 RVA: 0x00025D40 File Offset: 0x00023F40
		public unsafe Camera Camera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_Camera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_Camera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017C1 RID: 6081
		// (get) Token: 0x06004FA9 RID: 20393 RVA: 0x0017D730 File Offset: 0x0017B930
		// (set) Token: 0x06004FAA RID: 20394 RVA: 0x00025D5F File Offset: 0x00023F5F
		public unsafe Camera OverlayCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_OverlayCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_OverlayCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017C2 RID: 6082
		// (get) Token: 0x06004FAB RID: 20395 RVA: 0x0017D760 File Offset: 0x0017B960
		// (set) Token: 0x06004FAC RID: 20396 RVA: 0x00025D7E File Offset: 0x00023F7E
		public unsafe Animator Animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_Animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_Animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017C3 RID: 6083
		// (get) Token: 0x06004FAD RID: 20397 RVA: 0x0017D790 File Offset: 0x0017B990
		// (set) Token: 0x06004FAE RID: 20398 RVA: 0x00025D9D File Offset: 0x00023F9D
		public unsafe Il2CppReferenceArray<AnimationClip> JoltClips
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_JoltClips);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AnimationClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_JoltClips), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017C4 RID: 6084
		// (get) Token: 0x06004FAF RID: 20399 RVA: 0x0017D7C0 File Offset: 0x0017B9C0
		// (set) Token: 0x06004FB0 RID: 20400 RVA: 0x00025DBC File Offset: 0x00023FBC
		public unsafe Il2CppReferenceArray<UniversalRenderPipelineAsset> URPAssets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_URPAssets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UniversalRenderPipelineAsset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_URPAssets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017C5 RID: 6085
		// (get) Token: 0x06004FB1 RID: 20401 RVA: 0x0017D7F0 File Offset: 0x0017B9F0
		// (set) Token: 0x06004FB2 RID: 20402 RVA: 0x00025DDB File Offset: 0x00023FDB
		public unsafe Transform ViewAvatarCameraPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_ViewAvatarCameraPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_ViewAvatarCameraPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017C6 RID: 6086
		// (get) Token: 0x06004FB3 RID: 20403 RVA: 0x0017D820 File Offset: 0x0017BA20
		// (set) Token: 0x06004FB4 RID: 20404 RVA: 0x00025DFA File Offset: 0x00023FFA
		public unsafe HeartbeatSoundController HeartbeatSoundController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_HeartbeatSoundController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HeartbeatSoundController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_HeartbeatSoundController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017C7 RID: 6087
		// (get) Token: 0x06004FB5 RID: 20405 RVA: 0x0017D850 File Offset: 0x0017BA50
		// (set) Token: 0x06004FB6 RID: 20406 RVA: 0x00025E19 File Offset: 0x00024019
		public unsafe ParticleSystem Flies
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_Flies);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_Flies), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017C8 RID: 6088
		// (get) Token: 0x06004FB7 RID: 20407 RVA: 0x0017D880 File Offset: 0x0017BA80
		// (set) Token: 0x06004FB8 RID: 20408 RVA: 0x00025E38 File Offset: 0x00024038
		public unsafe AudioSourceController MethRumble
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_MethRumble);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_MethRumble), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017C9 RID: 6089
		// (get) Token: 0x06004FB9 RID: 20409 RVA: 0x0017D8B0 File Offset: 0x0017BAB0
		// (set) Token: 0x06004FBA RID: 20410 RVA: 0x00025E57 File Offset: 0x00024057
		public unsafe RandomizedAudioSourceController SchizoVoices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_SchizoVoices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RandomizedAudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_SchizoVoices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017CA RID: 6090
		// (get) Token: 0x06004FBB RID: 20411 RVA: 0x0017D8E0 File Offset: 0x0017BAE0
		// (set) Token: 0x06004FBC RID: 20412 RVA: 0x00025E76 File Offset: 0x00024076
		public unsafe bool _canLook_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__canLook_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__canLook_k__BackingField)) = value;
			}
		}

		// Token: 0x170017CB RID: 6091
		// (get) Token: 0x06004FBD RID: 20413 RVA: 0x0017D908 File Offset: 0x0017BB08
		// (set) Token: 0x06004FBE RID: 20414 RVA: 0x00025E91 File Offset: 0x00024091
		public unsafe bool _transformOverriden_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__transformOverriden_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__transformOverriden_k__BackingField)) = value;
			}
		}

		// Token: 0x170017CC RID: 6092
		// (get) Token: 0x06004FBF RID: 20415 RVA: 0x0017D930 File Offset: 0x0017BB30
		// (set) Token: 0x06004FC0 RID: 20416 RVA: 0x00025EAC File Offset: 0x000240AC
		public unsafe bool _fovOverriden_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__fovOverriden_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__fovOverriden_k__BackingField)) = value;
			}
		}

		// Token: 0x170017CD RID: 6093
		// (get) Token: 0x06004FC1 RID: 20417 RVA: 0x0017D958 File Offset: 0x0017BB58
		// (set) Token: 0x06004FC2 RID: 20418 RVA: 0x00025EC7 File Offset: 0x000240C7
		public unsafe bool blockNextStopTransformOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_blockNextStopTransformOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_blockNextStopTransformOverride)) = value;
			}
		}

		// Token: 0x170017CE RID: 6094
		// (get) Token: 0x06004FC3 RID: 20419 RVA: 0x0017D980 File Offset: 0x0017BB80
		// (set) Token: 0x06004FC4 RID: 20420 RVA: 0x00025EE2 File Offset: 0x000240E2
		public unsafe bool _FreeCamEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__FreeCamEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__FreeCamEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x170017CF RID: 6095
		// (get) Token: 0x06004FC5 RID: 20421 RVA: 0x0017D9A8 File Offset: 0x0017BBA8
		// (set) Token: 0x06004FC6 RID: 20422 RVA: 0x00025EFD File Offset: 0x000240FD
		public unsafe bool _ViewingAvatar_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__ViewingAvatar_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__ViewingAvatar_k__BackingField)) = value;
			}
		}

		// Token: 0x170017D0 RID: 6096
		// (get) Token: 0x06004FC7 RID: 20423 RVA: 0x0017D9D0 File Offset: 0x0017BBD0
		// (set) Token: 0x06004FC8 RID: 20424 RVA: 0x00025F18 File Offset: 0x00024118
		public unsafe PlayerCamera.ECameraMode _CameraMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__CameraMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__CameraMode_k__BackingField)) = value;
			}
		}

		// Token: 0x170017D1 RID: 6097
		// (get) Token: 0x06004FC9 RID: 20425 RVA: 0x0017D9F8 File Offset: 0x0017BBF8
		// (set) Token: 0x06004FCA RID: 20426 RVA: 0x00025F33 File Offset: 0x00024133
		public unsafe bool _MethVisuals_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__MethVisuals_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__MethVisuals_k__BackingField)) = value;
			}
		}

		// Token: 0x170017D2 RID: 6098
		// (get) Token: 0x06004FCB RID: 20427 RVA: 0x0017DA20 File Offset: 0x0017BC20
		// (set) Token: 0x06004FCC RID: 20428 RVA: 0x00025F4E File Offset: 0x0002414E
		public unsafe bool _CocaineVisuals_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__CocaineVisuals_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__CocaineVisuals_k__BackingField)) = value;
			}
		}

		// Token: 0x170017D3 RID: 6099
		// (get) Token: 0x06004FCD RID: 20429 RVA: 0x0017DA48 File Offset: 0x0017BC48
		// (set) Token: 0x06004FCE RID: 20430 RVA: 0x00025F69 File Offset: 0x00024169
		public unsafe float _FovJitter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__FovJitter_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__FovJitter_k__BackingField)) = value;
			}
		}

		// Token: 0x170017D4 RID: 6100
		// (get) Token: 0x06004FCF RID: 20431 RVA: 0x0017DA70 File Offset: 0x0017BC70
		// (set) Token: 0x06004FD0 RID: 20432 RVA: 0x00025F84 File Offset: 0x00024184
		public unsafe Volume globalVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_globalVolume);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Volume>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_globalVolume), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017D5 RID: 6101
		// (get) Token: 0x06004FD1 RID: 20433 RVA: 0x0017DAA0 File Offset: 0x0017BCA0
		// (set) Token: 0x06004FD2 RID: 20434 RVA: 0x00025FA3 File Offset: 0x000241A3
		public unsafe DepthOfField DoF
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_DoF);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DepthOfField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_DoF), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017D6 RID: 6102
		// (get) Token: 0x06004FD3 RID: 20435 RVA: 0x0017DAD0 File Offset: 0x0017BCD0
		// (set) Token: 0x06004FD4 RID: 20436 RVA: 0x00025FC2 File Offset: 0x000241C2
		public unsafe List<string> _activeUIElements_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__activeUIElements_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__activeUIElements_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017D7 RID: 6103
		// (get) Token: 0x06004FD5 RID: 20437 RVA: 0x0017DB00 File Offset: 0x0017BD00
		// (set) Token: 0x06004FD6 RID: 20438 RVA: 0x00025FE1 File Offset: 0x000241E1
		public unsafe Coroutine cameraShakeCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_cameraShakeCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_cameraShakeCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017D8 RID: 6104
		// (get) Token: 0x06004FD7 RID: 20439 RVA: 0x0017DB30 File Offset: 0x0017BD30
		// (set) Token: 0x06004FD8 RID: 20440 RVA: 0x00026000 File Offset: 0x00024200
		public unsafe Vector3 cameraLocalPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_cameraLocalPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_cameraLocalPos)) = value;
			}
		}

		// Token: 0x170017D9 RID: 6105
		// (get) Token: 0x06004FD9 RID: 20441 RVA: 0x0017DB58 File Offset: 0x0017BD58
		// (set) Token: 0x06004FDA RID: 20442 RVA: 0x0002601B File Offset: 0x0002421B
		public unsafe Vector3 freeCamMovement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_freeCamMovement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_freeCamMovement)) = value;
			}
		}

		// Token: 0x170017DA RID: 6106
		// (get) Token: 0x06004FDB RID: 20443 RVA: 0x0017DB80 File Offset: 0x0017BD80
		// (set) Token: 0x06004FDC RID: 20444 RVA: 0x00026036 File Offset: 0x00024236
		public unsafe Coroutine focusRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_focusRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_focusRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017DB RID: 6107
		// (get) Token: 0x06004FDD RID: 20445 RVA: 0x0017DBB0 File Offset: 0x0017BDB0
		// (set) Token: 0x06004FDE RID: 20446 RVA: 0x00026055 File Offset: 0x00024255
		public unsafe float focusMouseX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_focusMouseX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_focusMouseX)) = value;
			}
		}

		// Token: 0x170017DC RID: 6108
		// (get) Token: 0x06004FDF RID: 20447 RVA: 0x0017DBD8 File Offset: 0x0017BDD8
		// (set) Token: 0x06004FE0 RID: 20448 RVA: 0x00026070 File Offset: 0x00024270
		public unsafe float focusMouseY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_focusMouseY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_focusMouseY)) = value;
			}
		}

		// Token: 0x170017DD RID: 6109
		// (get) Token: 0x06004FE1 RID: 20449 RVA: 0x0017DC00 File Offset: 0x0017BE00
		// (set) Token: 0x06004FE2 RID: 20450 RVA: 0x0002608B File Offset: 0x0002428B
		public unsafe Dictionary<int, PlayerMovement.MovementEvent> movementEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_movementEvents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, PlayerMovement.MovementEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_movementEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017DE RID: 6110
		// (get) Token: 0x06004FE3 RID: 20451 RVA: 0x0017DC30 File Offset: 0x0017BE30
		// (set) Token: 0x06004FE4 RID: 20452 RVA: 0x000260AA File Offset: 0x000242AA
		public unsafe float freeCamSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_freeCamSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_freeCamSpeed)) = value;
			}
		}

		// Token: 0x170017DF RID: 6111
		// (get) Token: 0x06004FE5 RID: 20453 RVA: 0x0017DC58 File Offset: 0x0017BE58
		// (set) Token: 0x06004FE6 RID: 20454 RVA: 0x000260C5 File Offset: 0x000242C5
		public unsafe float mouseX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_mouseX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_mouseX)) = value;
			}
		}

		// Token: 0x170017E0 RID: 6112
		// (get) Token: 0x06004FE7 RID: 20455 RVA: 0x0017DC80 File Offset: 0x0017BE80
		// (set) Token: 0x06004FE8 RID: 20456 RVA: 0x000260E0 File Offset: 0x000242E0
		public unsafe float mouseY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_mouseY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_mouseY)) = value;
			}
		}

		// Token: 0x170017E1 RID: 6113
		// (get) Token: 0x06004FE9 RID: 20457 RVA: 0x0017DCA8 File Offset: 0x0017BEA8
		// (set) Token: 0x06004FEA RID: 20458 RVA: 0x000260FB File Offset: 0x000242FB
		public unsafe Vector2 seizureJitter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_seizureJitter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_seizureJitter)) = value;
			}
		}

		// Token: 0x170017E2 RID: 6114
		// (get) Token: 0x06004FEB RID: 20459 RVA: 0x0017DCD0 File Offset: 0x0017BED0
		// (set) Token: 0x06004FEC RID: 20460 RVA: 0x00026116 File Offset: 0x00024316
		public unsafe float schizoFoV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_schizoFoV);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_schizoFoV)) = value;
			}
		}

		// Token: 0x170017E3 RID: 6115
		// (get) Token: 0x06004FED RID: 20461 RVA: 0x0017DCF8 File Offset: 0x0017BEF8
		// (set) Token: 0x06004FEE RID: 20462 RVA: 0x00026131 File Offset: 0x00024331
		public unsafe float timeUntilNextSchizoVoice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_timeUntilNextSchizoVoice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_timeUntilNextSchizoVoice)) = value;
			}
		}

		// Token: 0x170017E4 RID: 6116
		// (get) Token: 0x06004FEF RID: 20463 RVA: 0x0017DD20 File Offset: 0x0017BF20
		// (set) Token: 0x06004FF0 RID: 20464 RVA: 0x0002614C File Offset: 0x0002434C
		public unsafe List<Vector3> gizmos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_gizmos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_gizmos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017E5 RID: 6117
		// (get) Token: 0x06004FF1 RID: 20465 RVA: 0x0017DD50 File Offset: 0x0017BF50
		// (set) Token: 0x06004FF2 RID: 20466 RVA: 0x0002616B File Offset: 0x0002436B
		public unsafe Vector3 cameralocalPos_PriorOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_cameralocalPos_PriorOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_cameralocalPos_PriorOverride)) = value;
			}
		}

		// Token: 0x170017E6 RID: 6118
		// (get) Token: 0x06004FF3 RID: 20467 RVA: 0x0017DD78 File Offset: 0x0017BF78
		// (set) Token: 0x06004FF4 RID: 20468 RVA: 0x00026186 File Offset: 0x00024386
		public unsafe Quaternion cameraLocalRot_PriorOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_cameraLocalRot_PriorOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_cameraLocalRot_PriorOverride)) = value;
			}
		}

		// Token: 0x170017E7 RID: 6119
		// (get) Token: 0x06004FF5 RID: 20469 RVA: 0x0017DDA0 File Offset: 0x0017BFA0
		// (set) Token: 0x06004FF6 RID: 20470 RVA: 0x000261A1 File Offset: 0x000243A1
		public unsafe Coroutine ILerpCamera_Coroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_ILerpCamera_Coroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_ILerpCamera_Coroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017E8 RID: 6120
		// (get) Token: 0x06004FF7 RID: 20471 RVA: 0x0017DDD0 File Offset: 0x0017BFD0
		// (set) Token: 0x06004FF8 RID: 20472 RVA: 0x000261C0 File Offset: 0x000243C0
		public unsafe Coroutine lookRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_lookRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_lookRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017E9 RID: 6121
		// (get) Token: 0x06004FF9 RID: 20473 RVA: 0x0017DE00 File Offset: 0x0017C000
		// (set) Token: 0x06004FFA RID: 20474 RVA: 0x000261DF File Offset: 0x000243DF
		public unsafe Coroutine DoFCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_DoFCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_DoFCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017EA RID: 6122
		// (get) Token: 0x06004FFB RID: 20475 RVA: 0x0017DE30 File Offset: 0x0017C030
		// (set) Token: 0x06004FFC RID: 20476 RVA: 0x000261FE File Offset: 0x000243FE
		public unsafe Coroutine ILerpCameraFOV_Coroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_ILerpCameraFOV_Coroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_ILerpCameraFOV_Coroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040035AE RID: 13742
		private static readonly IntPtr NativeFieldInfoPtr_CAMERA_SHAKE_MULTIPLIER;

		// Token: 0x040035AF RID: 13743
		private static readonly IntPtr NativeFieldInfoPtr__AntiAliasingMode_k__BackingField;

		// Token: 0x040035B0 RID: 13744
		private static readonly IntPtr NativeFieldInfoPtr_cameraOffsetFromTop;

		// Token: 0x040035B1 RID: 13745
		private static readonly IntPtr NativeFieldInfoPtr_SprintFoVBoost;

		// Token: 0x040035B2 RID: 13746
		private static readonly IntPtr NativeFieldInfoPtr_FoVChangeRate;

		// Token: 0x040035B3 RID: 13747
		private static readonly IntPtr NativeFieldInfoPtr_HorizontalCameraBob;

		// Token: 0x040035B4 RID: 13748
		private static readonly IntPtr NativeFieldInfoPtr_VerticalCameraBob;

		// Token: 0x040035B5 RID: 13749
		private static readonly IntPtr NativeFieldInfoPtr_BobRate;

		// Token: 0x040035B6 RID: 13750
		private static readonly IntPtr NativeFieldInfoPtr_HorizontalBobCurve;

		// Token: 0x040035B7 RID: 13751
		private static readonly IntPtr NativeFieldInfoPtr_VerticalBobCurve;

		// Token: 0x040035B8 RID: 13752
		private static readonly IntPtr NativeFieldInfoPtr_FreeCamSpeed;

		// Token: 0x040035B9 RID: 13753
		private static readonly IntPtr NativeFieldInfoPtr_FreeCamAcceleration;

		// Token: 0x040035BA RID: 13754
		private static readonly IntPtr NativeFieldInfoPtr_SmoothLook;

		// Token: 0x040035BB RID: 13755
		private static readonly IntPtr NativeFieldInfoPtr_SmoothLookSpeed;

		// Token: 0x040035BC RID: 13756
		private static readonly IntPtr NativeFieldInfoPtr_FoVChangeSmoother;

		// Token: 0x040035BD RID: 13757
		private static readonly IntPtr NativeFieldInfoPtr_SmoothLookSmoother;

		// Token: 0x040035BE RID: 13758
		private static readonly IntPtr NativeFieldInfoPtr_CameraContainer;

		// Token: 0x040035BF RID: 13759
		private static readonly IntPtr NativeFieldInfoPtr_Camera;

		// Token: 0x040035C0 RID: 13760
		private static readonly IntPtr NativeFieldInfoPtr_OverlayCamera;

		// Token: 0x040035C1 RID: 13761
		private static readonly IntPtr NativeFieldInfoPtr_Animator;

		// Token: 0x040035C2 RID: 13762
		private static readonly IntPtr NativeFieldInfoPtr_JoltClips;

		// Token: 0x040035C3 RID: 13763
		private static readonly IntPtr NativeFieldInfoPtr_URPAssets;

		// Token: 0x040035C4 RID: 13764
		private static readonly IntPtr NativeFieldInfoPtr_ViewAvatarCameraPosition;

		// Token: 0x040035C5 RID: 13765
		private static readonly IntPtr NativeFieldInfoPtr_HeartbeatSoundController;

		// Token: 0x040035C6 RID: 13766
		private static readonly IntPtr NativeFieldInfoPtr_Flies;

		// Token: 0x040035C7 RID: 13767
		private static readonly IntPtr NativeFieldInfoPtr_MethRumble;

		// Token: 0x040035C8 RID: 13768
		private static readonly IntPtr NativeFieldInfoPtr_SchizoVoices;

		// Token: 0x040035C9 RID: 13769
		private static readonly IntPtr NativeFieldInfoPtr__canLook_k__BackingField;

		// Token: 0x040035CA RID: 13770
		private static readonly IntPtr NativeFieldInfoPtr__transformOverriden_k__BackingField;

		// Token: 0x040035CB RID: 13771
		private static readonly IntPtr NativeFieldInfoPtr__fovOverriden_k__BackingField;

		// Token: 0x040035CC RID: 13772
		private static readonly IntPtr NativeFieldInfoPtr_blockNextStopTransformOverride;

		// Token: 0x040035CD RID: 13773
		private static readonly IntPtr NativeFieldInfoPtr__FreeCamEnabled_k__BackingField;

		// Token: 0x040035CE RID: 13774
		private static readonly IntPtr NativeFieldInfoPtr__ViewingAvatar_k__BackingField;

		// Token: 0x040035CF RID: 13775
		private static readonly IntPtr NativeFieldInfoPtr__CameraMode_k__BackingField;

		// Token: 0x040035D0 RID: 13776
		private static readonly IntPtr NativeFieldInfoPtr__MethVisuals_k__BackingField;

		// Token: 0x040035D1 RID: 13777
		private static readonly IntPtr NativeFieldInfoPtr__CocaineVisuals_k__BackingField;

		// Token: 0x040035D2 RID: 13778
		private static readonly IntPtr NativeFieldInfoPtr__FovJitter_k__BackingField;

		// Token: 0x040035D3 RID: 13779
		private static readonly IntPtr NativeFieldInfoPtr_globalVolume;

		// Token: 0x040035D4 RID: 13780
		private static readonly IntPtr NativeFieldInfoPtr_DoF;

		// Token: 0x040035D5 RID: 13781
		private static readonly IntPtr NativeFieldInfoPtr__activeUIElements_k__BackingField;

		// Token: 0x040035D6 RID: 13782
		private static readonly IntPtr NativeFieldInfoPtr_cameraShakeCoroutine;

		// Token: 0x040035D7 RID: 13783
		private static readonly IntPtr NativeFieldInfoPtr_cameraLocalPos;

		// Token: 0x040035D8 RID: 13784
		private static readonly IntPtr NativeFieldInfoPtr_freeCamMovement;

		// Token: 0x040035D9 RID: 13785
		private static readonly IntPtr NativeFieldInfoPtr_focusRoutine;

		// Token: 0x040035DA RID: 13786
		private static readonly IntPtr NativeFieldInfoPtr_focusMouseX;

		// Token: 0x040035DB RID: 13787
		private static readonly IntPtr NativeFieldInfoPtr_focusMouseY;

		// Token: 0x040035DC RID: 13788
		private static readonly IntPtr NativeFieldInfoPtr_movementEvents;

		// Token: 0x040035DD RID: 13789
		private static readonly IntPtr NativeFieldInfoPtr_freeCamSpeed;

		// Token: 0x040035DE RID: 13790
		private static readonly IntPtr NativeFieldInfoPtr_mouseX;

		// Token: 0x040035DF RID: 13791
		private static readonly IntPtr NativeFieldInfoPtr_mouseY;

		// Token: 0x040035E0 RID: 13792
		private static readonly IntPtr NativeFieldInfoPtr_seizureJitter;

		// Token: 0x040035E1 RID: 13793
		private static readonly IntPtr NativeFieldInfoPtr_schizoFoV;

		// Token: 0x040035E2 RID: 13794
		private static readonly IntPtr NativeFieldInfoPtr_timeUntilNextSchizoVoice;

		// Token: 0x040035E3 RID: 13795
		private static readonly IntPtr NativeFieldInfoPtr_gizmos;

		// Token: 0x040035E4 RID: 13796
		private static readonly IntPtr NativeFieldInfoPtr_cameralocalPos_PriorOverride;

		// Token: 0x040035E5 RID: 13797
		private static readonly IntPtr NativeFieldInfoPtr_cameraLocalRot_PriorOverride;

		// Token: 0x040035E6 RID: 13798
		private static readonly IntPtr NativeFieldInfoPtr_ILerpCamera_Coroutine;

		// Token: 0x040035E7 RID: 13799
		private static readonly IntPtr NativeFieldInfoPtr_lookRoutine;

		// Token: 0x040035E8 RID: 13800
		private static readonly IntPtr NativeFieldInfoPtr_DoFCoroutine;

		// Token: 0x040035E9 RID: 13801
		private static readonly IntPtr NativeFieldInfoPtr_ILerpCameraFOV_Coroutine;

		// Token: 0x040035EA RID: 13802
		private static readonly IntPtr NativeMethodInfoPtr_get_AntiAliasingMode_Public_Static_get_EAntiAliasingMode_0;

		// Token: 0x040035EB RID: 13803
		private static readonly IntPtr NativeMethodInfoPtr_set_AntiAliasingMode_Private_Static_set_Void_EAntiAliasingMode_0;

		// Token: 0x040035EC RID: 13804
		private static readonly IntPtr NativeMethodInfoPtr_get_canLook_Public_get_Boolean_0;

		// Token: 0x040035ED RID: 13805
		private static readonly IntPtr NativeMethodInfoPtr_set_canLook_Protected_set_Void_Boolean_0;

		// Token: 0x040035EE RID: 13806
		private static readonly IntPtr NativeMethodInfoPtr_get_activeUIElementCount_Public_get_Int32_0;

		// Token: 0x040035EF RID: 13807
		private static readonly IntPtr NativeMethodInfoPtr_get_transformOverriden_Public_get_Boolean_0;

		// Token: 0x040035F0 RID: 13808
		private static readonly IntPtr NativeMethodInfoPtr_set_transformOverriden_Protected_set_Void_Boolean_0;

		// Token: 0x040035F1 RID: 13809
		private static readonly IntPtr NativeMethodInfoPtr_get_fovOverriden_Public_get_Boolean_0;

		// Token: 0x040035F2 RID: 13810
		private static readonly IntPtr NativeMethodInfoPtr_set_fovOverriden_Protected_set_Void_Boolean_0;

		// Token: 0x040035F3 RID: 13811
		private static readonly IntPtr NativeMethodInfoPtr_get_FreeCamEnabled_Public_get_Boolean_0;

		// Token: 0x040035F4 RID: 13812
		private static readonly IntPtr NativeMethodInfoPtr_set_FreeCamEnabled_Private_set_Void_Boolean_0;

		// Token: 0x040035F5 RID: 13813
		private static readonly IntPtr NativeMethodInfoPtr_get_ViewingAvatar_Public_get_Boolean_0;

		// Token: 0x040035F6 RID: 13814
		private static readonly IntPtr NativeMethodInfoPtr_set_ViewingAvatar_Private_set_Void_Boolean_0;

		// Token: 0x040035F7 RID: 13815
		private static readonly IntPtr NativeMethodInfoPtr_get_CameraMode_Public_get_ECameraMode_0;

		// Token: 0x040035F8 RID: 13816
		private static readonly IntPtr NativeMethodInfoPtr_set_CameraMode_Protected_set_Void_ECameraMode_0;

		// Token: 0x040035F9 RID: 13817
		private static readonly IntPtr NativeMethodInfoPtr_get_MethVisuals_Public_get_Boolean_0;

		// Token: 0x040035FA RID: 13818
		private static readonly IntPtr NativeMethodInfoPtr_set_MethVisuals_Public_set_Void_Boolean_0;

		// Token: 0x040035FB RID: 13819
		private static readonly IntPtr NativeMethodInfoPtr_get_CocaineVisuals_Public_get_Boolean_0;

		// Token: 0x040035FC RID: 13820
		private static readonly IntPtr NativeMethodInfoPtr_set_CocaineVisuals_Public_set_Void_Boolean_0;

		// Token: 0x040035FD RID: 13821
		private static readonly IntPtr NativeMethodInfoPtr_get_FovJitter_Public_get_Single_0;

		// Token: 0x040035FE RID: 13822
		private static readonly IntPtr NativeMethodInfoPtr_set_FovJitter_Private_set_Void_Single_0;

		// Token: 0x040035FF RID: 13823
		private static readonly IntPtr NativeMethodInfoPtr_get_activeUIElements_Public_get_List_1_String_0;

		// Token: 0x04003600 RID: 13824
		private static readonly IntPtr NativeMethodInfoPtr_set_activeUIElements_Protected_set_Void_List_1_String_0;

		// Token: 0x04003601 RID: 13825
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04003602 RID: 13826
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0;

		// Token: 0x04003603 RID: 13827
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04003604 RID: 13828
		private static readonly IntPtr NativeMethodInfoPtr_PlayerSpawned_Private_Void_0;

		// Token: 0x04003605 RID: 13829
		private static readonly IntPtr NativeMethodInfoPtr_SetAntialiasingMode_Public_Static_Void_EAntiAliasingMode_0;

		// Token: 0x04003606 RID: 13830
		private static readonly IntPtr NativeMethodInfoPtr_ApplyAASettings_Public_Void_0;

		// Token: 0x04003607 RID: 13831
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04003608 RID: 13832
		private static readonly IntPtr NativeMethodInfoPtr_Screenshot_Private_Void_0;

		// Token: 0x04003609 RID: 13833
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x0400360A RID: 13834
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x0400360B RID: 13835
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetLocalY_Public_Single_0;

		// Token: 0x0400360C RID: 13836
		private static readonly IntPtr NativeMethodInfoPtr_SetCameraMode_Public_Void_ECameraMode_0;

		// Token: 0x0400360D RID: 13837
		private static readonly IntPtr NativeMethodInfoPtr_RotateCamera_Private_Void_0;

		// Token: 0x0400360E RID: 13838
		private static readonly IntPtr NativeMethodInfoPtr_LockMouse_Public_Void_0;

		// Token: 0x0400360F RID: 13839
		private static readonly IntPtr NativeMethodInfoPtr_FreeMouse_Public_Void_0;

		// Token: 0x04003610 RID: 13840
		private static readonly IntPtr NativeMethodInfoPtr_LookRaycast_Public_Boolean_Single_byref_RaycastHit_LayerMask_Boolean_Single_0;

		// Token: 0x04003611 RID: 13841
		private static readonly IntPtr NativeMethodInfoPtr_LookRaycast_ExcludeBuildables_Public_Boolean_Single_byref_RaycastHit_LayerMask_Boolean_0;

		// Token: 0x04003612 RID: 13842
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0;

		// Token: 0x04003613 RID: 13843
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_ExcludeBuildables_Public_Boolean_Vector3_Vector3_Single_byref_RaycastHit_LayerMask_Boolean_Single_Single_0;

		// Token: 0x04003614 RID: 13844
		private static readonly IntPtr NativeMethodInfoPtr_MouseRaycast_Public_Boolean_Single_byref_RaycastHit_LayerMask_Boolean_Single_0;

		// Token: 0x04003615 RID: 13845
		private static readonly IntPtr NativeMethodInfoPtr_LookSpherecast_Public_Boolean_Single_Single_byref_RaycastHit_LayerMask_0;

		// Token: 0x04003616 RID: 13846
		private static readonly IntPtr NativeMethodInfoPtr_OverrideTransform_Public_Void_Vector3_Quaternion_Single_Boolean_0;

		// Token: 0x04003617 RID: 13847
		private static readonly IntPtr NativeMethodInfoPtr_ILerpCamera_Protected_IEnumerator_Vector3_Quaternion_Single_Boolean_Boolean_Boolean_0;

		// Token: 0x04003618 RID: 13848
		private static readonly IntPtr NativeMethodInfoPtr_StopTransformOverride_Public_Void_Single_Boolean_Boolean_0;

		// Token: 0x04003619 RID: 13849
		private static readonly IntPtr NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Single_0;

		// Token: 0x0400361A RID: 13850
		private static readonly IntPtr NativeMethodInfoPtr_SetCanLook_True_Private_Void_0;

		// Token: 0x0400361B RID: 13851
		private static readonly IntPtr NativeMethodInfoPtr_SetCanLook_Public_Void_Boolean_0;

		// Token: 0x0400361C RID: 13852
		private static readonly IntPtr NativeMethodInfoPtr_SetDoFActive_Public_Void_Boolean_Single_0;

		// Token: 0x0400361D RID: 13853
		private static readonly IntPtr NativeMethodInfoPtr_LerpDoF_Private_IEnumerator_Boolean_Single_0;

		// Token: 0x0400361E RID: 13854
		private static readonly IntPtr NativeMethodInfoPtr_OverrideFOV_Public_Void_Single_Single_0;

		// Token: 0x0400361F RID: 13855
		private static readonly IntPtr NativeMethodInfoPtr_ILerpFOV_Protected_IEnumerator_Single_Single_0;

		// Token: 0x04003620 RID: 13856
		private static readonly IntPtr NativeMethodInfoPtr_StopFOVOverride_Public_Void_Single_0;

		// Token: 0x04003621 RID: 13857
		private static readonly IntPtr NativeMethodInfoPtr_AddActiveUIElement_Public_Void_String_0;

		// Token: 0x04003622 RID: 13858
		private static readonly IntPtr NativeMethodInfoPtr_RemoveActiveUIElement_Public_Void_String_0;

		// Token: 0x04003623 RID: 13859
		private static readonly IntPtr NativeMethodInfoPtr_RegisterMovementEvent_Public_Void_Int32_Action_0;

		// Token: 0x04003624 RID: 13860
		private static readonly IntPtr NativeMethodInfoPtr_DeregisterMovementEvent_Public_Void_Action_0;

		// Token: 0x04003625 RID: 13861
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMovementEvents_Private_Void_0;

		// Token: 0x04003626 RID: 13862
		private static readonly IntPtr NativeMethodInfoPtr_ViewAvatar_Private_Void_0;

		// Token: 0x04003627 RID: 13863
		private static readonly IntPtr NativeMethodInfoPtr_StopViewingAvatar_Private_Void_0;

		// Token: 0x04003628 RID: 13864
		private static readonly IntPtr NativeMethodInfoPtr_JoltCamera_Public_Void_0;

		// Token: 0x04003629 RID: 13865
		private static readonly IntPtr NativeMethodInfoPtr_PointInCameraView_Public_Boolean_Vector3_0;

		// Token: 0x0400362A RID: 13866
		private static readonly IntPtr NativeMethodInfoPtr_Is01_Public_Boolean_Single_0;

		// Token: 0x0400362B RID: 13867
		private static readonly IntPtr NativeMethodInfoPtr_ResetRotation_Public_Void_0;

		// Token: 0x0400362C RID: 13868
		private static readonly IntPtr NativeMethodInfoPtr_FocusCameraOnTarget_Public_Void_Transform_0;

		// Token: 0x0400362D RID: 13869
		private static readonly IntPtr NativeMethodInfoPtr_StopFocus_Public_Void_0;

		// Token: 0x0400362E RID: 13870
		private static readonly IntPtr NativeMethodInfoPtr_StartCameraShake_Public_Void_Single_Single_Boolean_0;

		// Token: 0x0400362F RID: 13871
		private static readonly IntPtr NativeMethodInfoPtr_StopCameraShake_Public_Void_0;

		// Token: 0x04003630 RID: 13872
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCameraBob_Public_Void_0;

		// Token: 0x04003631 RID: 13873
		private static readonly IntPtr NativeMethodInfoPtr_SetFreeCam_Public_Void_Boolean_Boolean_0;

		// Token: 0x04003632 RID: 13874
		private static readonly IntPtr NativeMethodInfoPtr_RotateFreeCam_Private_Void_0;

		// Token: 0x04003633 RID: 13875
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFreeCamInput_Private_Void_0;

		// Token: 0x04003634 RID: 13876
		private static readonly IntPtr NativeMethodInfoPtr_MoveFreeCam_Private_Void_0;

		// Token: 0x04003635 RID: 13877
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003636 RID: 13878
		private static readonly IntPtr NativeMethodInfoPtr__PlayerSpawned_b__92_0_Private_Void_0;

		// Token: 0x04003637 RID: 13879
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_IEnumerator_PDM_0;

		// Token: 0x02000996 RID: 2454
		[OriginalName("Assembly-CSharp.dll", "", "ECameraMode")]
		public enum ECameraMode
		{
			// Token: 0x0400891C RID: 35100
			Default,
			// Token: 0x0400891D RID: 35101
			Vehicle,
			// Token: 0x0400891E RID: 35102
			Skateboard
		}

		// Token: 0x02000997 RID: 2455
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerCamera+<<Screenshot>g__Routine|96_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600CAB9 RID: 51897 RVA: 0x003101EC File Offset: 0x0030E3EC
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
			{
				Il2CppClassPointerStore<PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<<Screenshot>g__Routine|96_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
				PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
				PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
				PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673274);
				PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673275);
				PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673276);
				PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673277);
				PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673278);
				PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673279);
			}

			// Token: 0x0600CABA RID: 51898 RVA: 0x003102B8 File Offset: 0x0030E4B8
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CABB RID: 51899 RVA: 0x00310300 File Offset: 0x0030E500
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CABC RID: 51900 RVA: 0x00310334 File Offset: 0x0030E534
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172139, XrefRangeEnd = 172147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003F23 RID: 16163
			// (get) Token: 0x0600CABD RID: 51901 RVA: 0x00310370 File Offset: 0x0030E570
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CABE RID: 51902 RVA: 0x003103B0 File Offset: 0x0030E5B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172147, XrefRangeEnd = 172152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003F24 RID: 16164
			// (get) Token: 0x0600CABF RID: 51903 RVA: 0x003103E4 File Offset: 0x0030E5E4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CAC0 RID: 51904 RVA: 0x000628BD File Offset: 0x00060ABD
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F21 RID: 16161
			// (get) Token: 0x0600CAC1 RID: 51905 RVA: 0x00310424 File Offset: 0x0030E624
			// (set) Token: 0x0600CAC2 RID: 51906 RVA: 0x000628C6 File Offset: 0x00060AC6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003F22 RID: 16162
			// (get) Token: 0x0600CAC3 RID: 51907 RVA: 0x0031044C File Offset: 0x0030E64C
			// (set) Token: 0x0600CAC4 RID: 51908 RVA: 0x000628E1 File Offset: 0x00060AE1
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400891F RID: 35103
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008920 RID: 35104
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008921 RID: 35105
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008922 RID: 35106
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008923 RID: 35107
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008924 RID: 35108
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008925 RID: 35109
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008926 RID: 35110
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000998 RID: 2456
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerCamera+<>c__DisplayClass118_0")]
		public sealed class __c__DisplayClass118_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CAC5 RID: 51909 RVA: 0x0031047C File Offset: 0x0030E67C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass118_0()
			{
				Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<>c__DisplayClass118_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0>.NativeClassPtr);
				PlayerCamera.__c__DisplayClass118_0.NativeFieldInfoPtr_point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0>.NativeClassPtr, "point");
				PlayerCamera.__c__DisplayClass118_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0>.NativeClassPtr, "<>4__this");
				PlayerCamera.__c__DisplayClass118_0.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0>.NativeClassPtr, "duration");
				PlayerCamera.__c__DisplayClass118_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0>.NativeClassPtr, 100673280);
				PlayerCamera.__c__DisplayClass118_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0>.NativeClassPtr, 100673281);
			}

			// Token: 0x0600CAC6 RID: 51910 RVA: 0x0031050C File Offset: 0x0030E70C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass118_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass118_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CAC7 RID: 51911 RVA: 0x00310548 File Offset: 0x0030E748
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172202, XrefRangeEnd = 172207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass118_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600CAC8 RID: 51912 RVA: 0x00062900 File Offset: 0x00060B00
			public __c__DisplayClass118_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F25 RID: 16165
			// (get) Token: 0x0600CAC9 RID: 51913 RVA: 0x00310588 File Offset: 0x0030E788
			// (set) Token: 0x0600CACA RID: 51914 RVA: 0x00062909 File Offset: 0x00060B09
			public unsafe Vector3 point
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.NativeFieldInfoPtr_point);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.NativeFieldInfoPtr_point)) = value;
				}
			}

			// Token: 0x17003F26 RID: 16166
			// (get) Token: 0x0600CACB RID: 51915 RVA: 0x003105B0 File Offset: 0x0030E7B0
			// (set) Token: 0x0600CACC RID: 51916 RVA: 0x00062924 File Offset: 0x00060B24
			public unsafe PlayerCamera __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerCamera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F27 RID: 16167
			// (get) Token: 0x0600CACD RID: 51917 RVA: 0x003105E0 File Offset: 0x0030E7E0
			// (set) Token: 0x0600CACE RID: 51918 RVA: 0x00062943 File Offset: 0x00060B43
			public unsafe float duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x04008927 RID: 35111
			private static readonly IntPtr NativeFieldInfoPtr_point;

			// Token: 0x04008928 RID: 35112
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008929 RID: 35113
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x0400892A RID: 35114
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400892B RID: 35115
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C45 RID: 3141
			[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerCamera+<>c__DisplayClass118_0+<<LookAt>g__Look|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E279 RID: 57977 RVA: 0x00353144 File Offset: 0x00351344
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique()
				{
					Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0>.NativeClassPtr, "<<LookAt>g__Look|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr);
					PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, "<>1__state");
					PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, "<>2__current");
					PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, "<>4__this");
					PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__playerEndRot_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, "<playerEndRot>5__2");
					PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__cameraRotation_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, "<cameraRotation>5__3");
					PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__playerStartRot_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, "<playerStartRot>5__4");
					PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__cameraStartRot_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, "<cameraStartRot>5__5");
					PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__i_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, "<i>5__6");
					PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, 100673282);
					PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, 100673283);
					PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, 100673284);
					PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, 100673285);
					PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, 100673286);
					PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, 100673287);
				}

				// Token: 0x0600E27A RID: 57978 RVA: 0x00353288 File Offset: 0x00351488
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E27B RID: 57979 RVA: 0x003532D0 File Offset: 0x003514D0
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E27C RID: 57980 RVA: 0x00353304 File Offset: 0x00351504
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172152, XrefRangeEnd = 172197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004642 RID: 17986
				// (get) Token: 0x0600E27D RID: 57981 RVA: 0x00353340 File Offset: 0x00351540
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E27E RID: 57982 RVA: 0x00353380 File Offset: 0x00351580
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172197, XrefRangeEnd = 172202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004643 RID: 17987
				// (get) Token: 0x0600E27F RID: 57983 RVA: 0x003533B4 File Offset: 0x003515B4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E280 RID: 57984 RVA: 0x0006E69E File Offset: 0x0006C89E
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x1700463A RID: 17978
				// (get) Token: 0x0600E281 RID: 57985 RVA: 0x003533F4 File Offset: 0x003515F4
				// (set) Token: 0x0600E282 RID: 57986 RVA: 0x0006E6A7 File Offset: 0x0006C8A7
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700463B RID: 17979
				// (get) Token: 0x0600E283 RID: 57987 RVA: 0x0035341C File Offset: 0x0035161C
				// (set) Token: 0x0600E284 RID: 57988 RVA: 0x0006E6C2 File Offset: 0x0006C8C2
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700463C RID: 17980
				// (get) Token: 0x0600E285 RID: 57989 RVA: 0x0035344C File Offset: 0x0035164C
				// (set) Token: 0x0600E286 RID: 57990 RVA: 0x0006E6E1 File Offset: 0x0006C8E1
				public unsafe PlayerCamera.__c__DisplayClass118_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerCamera.__c__DisplayClass118_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700463D RID: 17981
				// (get) Token: 0x0600E287 RID: 57991 RVA: 0x0035347C File Offset: 0x0035167C
				// (set) Token: 0x0600E288 RID: 57992 RVA: 0x0006E700 File Offset: 0x0006C900
				public unsafe Quaternion _playerEndRot_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__playerEndRot_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__playerEndRot_5__2)) = value;
					}
				}

				// Token: 0x1700463E RID: 17982
				// (get) Token: 0x0600E289 RID: 57993 RVA: 0x003534A4 File Offset: 0x003516A4
				// (set) Token: 0x0600E28A RID: 57994 RVA: 0x0006E71B File Offset: 0x0006C91B
				public unsafe Quaternion _cameraRotation_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__cameraRotation_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__cameraRotation_5__3)) = value;
					}
				}

				// Token: 0x1700463F RID: 17983
				// (get) Token: 0x0600E28B RID: 57995 RVA: 0x003534CC File Offset: 0x003516CC
				// (set) Token: 0x0600E28C RID: 57996 RVA: 0x0006E736 File Offset: 0x0006C936
				public unsafe Quaternion _playerStartRot_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__playerStartRot_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__playerStartRot_5__4)) = value;
					}
				}

				// Token: 0x17004640 RID: 17984
				// (get) Token: 0x0600E28D RID: 57997 RVA: 0x003534F4 File Offset: 0x003516F4
				// (set) Token: 0x0600E28E RID: 57998 RVA: 0x0006E751 File Offset: 0x0006C951
				public unsafe Quaternion _cameraStartRot_5__5
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__cameraStartRot_5__5);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__cameraStartRot_5__5)) = value;
					}
				}

				// Token: 0x17004641 RID: 17985
				// (get) Token: 0x0600E28F RID: 57999 RVA: 0x0035351C File Offset: 0x0035171C
				// (set) Token: 0x0600E290 RID: 58000 RVA: 0x0006E76C File Offset: 0x0006C96C
				public unsafe float _i_5__6
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__i_5__6);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__i_5__6)) = value;
					}
				}

				// Token: 0x04009798 RID: 38808
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009799 RID: 38809
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400979A RID: 38810
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400979B RID: 38811
				private static readonly IntPtr NativeFieldInfoPtr__playerEndRot_5__2;

				// Token: 0x0400979C RID: 38812
				private static readonly IntPtr NativeFieldInfoPtr__cameraRotation_5__3;

				// Token: 0x0400979D RID: 38813
				private static readonly IntPtr NativeFieldInfoPtr__playerStartRot_5__4;

				// Token: 0x0400979E RID: 38814
				private static readonly IntPtr NativeFieldInfoPtr__cameraStartRot_5__5;

				// Token: 0x0400979F RID: 38815
				private static readonly IntPtr NativeFieldInfoPtr__i_5__6;

				// Token: 0x040097A0 RID: 38816
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040097A1 RID: 38817
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040097A2 RID: 38818
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040097A3 RID: 38819
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040097A4 RID: 38820
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040097A5 RID: 38821
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000999 RID: 2457
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerCamera+<>c__DisplayClass139_0")]
		public sealed class __c__DisplayClass139_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CACF RID: 51919 RVA: 0x00310608 File Offset: 0x0030E808
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass139_0()
			{
				Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<>c__DisplayClass139_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0>.NativeClassPtr);
				PlayerCamera.__c__DisplayClass139_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0>.NativeClassPtr, "<>4__this");
				PlayerCamera.__c__DisplayClass139_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0>.NativeClassPtr, "target");
				PlayerCamera.__c__DisplayClass139_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0>.NativeClassPtr, 100673288);
				PlayerCamera.__c__DisplayClass139_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0>.NativeClassPtr, 100673289);
			}

			// Token: 0x0600CAD0 RID: 51920 RVA: 0x00310684 File Offset: 0x0030E884
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass139_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass139_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CAD1 RID: 51921 RVA: 0x003106C0 File Offset: 0x0030E8C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172262, XrefRangeEnd = 172267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass139_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600CAD2 RID: 51922 RVA: 0x0006295E File Offset: 0x00060B5E
			public __c__DisplayClass139_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F28 RID: 16168
			// (get) Token: 0x0600CAD3 RID: 51923 RVA: 0x00310700 File Offset: 0x0030E900
			// (set) Token: 0x0600CAD4 RID: 51924 RVA: 0x00062967 File Offset: 0x00060B67
			public unsafe PlayerCamera __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass139_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerCamera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass139_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F29 RID: 16169
			// (get) Token: 0x0600CAD5 RID: 51925 RVA: 0x00310730 File Offset: 0x0030E930
			// (set) Token: 0x0600CAD6 RID: 51926 RVA: 0x00062986 File Offset: 0x00060B86
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass139_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass139_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400892C RID: 35116
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400892D RID: 35117
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400892E RID: 35118
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400892F RID: 35119
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C46 RID: 3142
			[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerCamera+<>c__DisplayClass139_0+<<FocusCameraOnTarget>g__FocusRoutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E291 RID: 58001 RVA: 0x00353544 File Offset: 0x00351744
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique()
				{
					Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0>.NativeClassPtr, "<<FocusCameraOnTarget>g__FocusRoutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr);
					PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>1__state");
					PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>2__current");
					PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>4__this");
					PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__duration_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<duration>5__2");
					PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673290);
					PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673291);
					PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673292);
					PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673293);
					PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673294);
					PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673295);
				}

				// Token: 0x0600E292 RID: 58002 RVA: 0x00353638 File Offset: 0x00351838
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E293 RID: 58003 RVA: 0x00353680 File Offset: 0x00351880
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E294 RID: 58004 RVA: 0x003536B4 File Offset: 0x003518B4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172207, XrefRangeEnd = 172257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004648 RID: 17992
				// (get) Token: 0x0600E295 RID: 58005 RVA: 0x003536F0 File Offset: 0x003518F0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E296 RID: 58006 RVA: 0x00353730 File Offset: 0x00351930
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172257, XrefRangeEnd = 172262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004649 RID: 17993
				// (get) Token: 0x0600E297 RID: 58007 RVA: 0x00353764 File Offset: 0x00351964
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E298 RID: 58008 RVA: 0x0006E787 File Offset: 0x0006C987
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004644 RID: 17988
				// (get) Token: 0x0600E299 RID: 58009 RVA: 0x003537A4 File Offset: 0x003519A4
				// (set) Token: 0x0600E29A RID: 58010 RVA: 0x0006E790 File Offset: 0x0006C990
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004645 RID: 17989
				// (get) Token: 0x0600E29B RID: 58011 RVA: 0x003537CC File Offset: 0x003519CC
				// (set) Token: 0x0600E29C RID: 58012 RVA: 0x0006E7AB File Offset: 0x0006C9AB
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004646 RID: 17990
				// (get) Token: 0x0600E29D RID: 58013 RVA: 0x003537FC File Offset: 0x003519FC
				// (set) Token: 0x0600E29E RID: 58014 RVA: 0x0006E7CA File Offset: 0x0006C9CA
				public unsafe PlayerCamera.__c__DisplayClass139_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerCamera.__c__DisplayClass139_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004647 RID: 17991
				// (get) Token: 0x0600E29F RID: 58015 RVA: 0x0035382C File Offset: 0x00351A2C
				// (set) Token: 0x0600E2A0 RID: 58016 RVA: 0x0006E7E9 File Offset: 0x0006C9E9
				public unsafe float _duration_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__duration_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__duration_5__2)) = value;
					}
				}

				// Token: 0x040097A6 RID: 38822
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040097A7 RID: 38823
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040097A8 RID: 38824
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040097A9 RID: 38825
				private static readonly IntPtr NativeFieldInfoPtr__duration_5__2;

				// Token: 0x040097AA RID: 38826
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040097AB RID: 38827
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040097AC RID: 38828
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040097AD RID: 38829
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040097AE RID: 38830
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040097AF RID: 38831
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x0200099A RID: 2458
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerCamera+<>c__DisplayClass141_0")]
		public sealed class __c__DisplayClass141_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CAD7 RID: 51927 RVA: 0x00310760 File Offset: 0x0030E960
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass141_0()
			{
				Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<>c__DisplayClass141_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0>.NativeClassPtr);
				PlayerCamera.__c__DisplayClass141_0.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0>.NativeClassPtr, "duration");
				PlayerCamera.__c__DisplayClass141_0.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0>.NativeClassPtr, "intensity");
				PlayerCamera.__c__DisplayClass141_0.NativeFieldInfoPtr_decreaseOverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0>.NativeClassPtr, "decreaseOverTime");
				PlayerCamera.__c__DisplayClass141_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0>.NativeClassPtr, "<>4__this");
				PlayerCamera.__c__DisplayClass141_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0>.NativeClassPtr, 100673296);
				PlayerCamera.__c__DisplayClass141_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0>.NativeClassPtr, 100673297);
			}

			// Token: 0x0600CAD8 RID: 51928 RVA: 0x00310804 File Offset: 0x0030EA04
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass141_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass141_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CAD9 RID: 51929 RVA: 0x00310840 File Offset: 0x0030EA40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172282, XrefRangeEnd = 172287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass141_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600CADA RID: 51930 RVA: 0x000629A5 File Offset: 0x00060BA5
			public __c__DisplayClass141_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F2A RID: 16170
			// (get) Token: 0x0600CADB RID: 51931 RVA: 0x00310880 File Offset: 0x0030EA80
			// (set) Token: 0x0600CADC RID: 51932 RVA: 0x000629AE File Offset: 0x00060BAE
			public unsafe float duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass141_0.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass141_0.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x17003F2B RID: 16171
			// (get) Token: 0x0600CADD RID: 51933 RVA: 0x003108A8 File Offset: 0x0030EAA8
			// (set) Token: 0x0600CADE RID: 51934 RVA: 0x000629C9 File Offset: 0x00060BC9
			public unsafe float intensity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass141_0.NativeFieldInfoPtr_intensity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass141_0.NativeFieldInfoPtr_intensity)) = value;
				}
			}

			// Token: 0x17003F2C RID: 16172
			// (get) Token: 0x0600CADF RID: 51935 RVA: 0x003108D0 File Offset: 0x0030EAD0
			// (set) Token: 0x0600CAE0 RID: 51936 RVA: 0x000629E4 File Offset: 0x00060BE4
			public unsafe bool decreaseOverTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass141_0.NativeFieldInfoPtr_decreaseOverTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass141_0.NativeFieldInfoPtr_decreaseOverTime)) = value;
				}
			}

			// Token: 0x17003F2D RID: 16173
			// (get) Token: 0x0600CAE1 RID: 51937 RVA: 0x003108F8 File Offset: 0x0030EAF8
			// (set) Token: 0x0600CAE2 RID: 51938 RVA: 0x000629FF File Offset: 0x00060BFF
			public unsafe PlayerCamera __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass141_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerCamera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass141_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008930 RID: 35120
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x04008931 RID: 35121
			private static readonly IntPtr NativeFieldInfoPtr_intensity;

			// Token: 0x04008932 RID: 35122
			private static readonly IntPtr NativeFieldInfoPtr_decreaseOverTime;

			// Token: 0x04008933 RID: 35123
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008934 RID: 35124
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008935 RID: 35125
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C47 RID: 3143
			[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerCamera+<>c__DisplayClass141_0+<<StartCameraShake>g__Shake|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E2A1 RID: 58017 RVA: 0x00353854 File Offset: 0x00351A54
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique()
				{
					Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0>.NativeClassPtr, "<<StartCameraShake>g__Shake|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr);
					PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>1__state");
					PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>2__current");
					PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>4__this");
					PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__timeRemaining_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<timeRemaining>5__2");
					PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673298);
					PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673299);
					PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673300);
					PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673301);
					PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673302);
					PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673303);
				}

				// Token: 0x0600E2A2 RID: 58018 RVA: 0x00353948 File Offset: 0x00351B48
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E2A3 RID: 58019 RVA: 0x00353990 File Offset: 0x00351B90
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E2A4 RID: 58020 RVA: 0x003539C4 File Offset: 0x00351BC4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172267, XrefRangeEnd = 172277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x1700464E RID: 17998
				// (get) Token: 0x0600E2A5 RID: 58021 RVA: 0x00353A00 File Offset: 0x00351C00
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E2A6 RID: 58022 RVA: 0x00353A40 File Offset: 0x00351C40
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172277, XrefRangeEnd = 172282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x1700464F RID: 17999
				// (get) Token: 0x0600E2A7 RID: 58023 RVA: 0x00353A74 File Offset: 0x00351C74
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E2A8 RID: 58024 RVA: 0x0006E804 File Offset: 0x0006CA04
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x1700464A RID: 17994
				// (get) Token: 0x0600E2A9 RID: 58025 RVA: 0x00353AB4 File Offset: 0x00351CB4
				// (set) Token: 0x0600E2AA RID: 58026 RVA: 0x0006E80D File Offset: 0x0006CA0D
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700464B RID: 17995
				// (get) Token: 0x0600E2AB RID: 58027 RVA: 0x00353ADC File Offset: 0x00351CDC
				// (set) Token: 0x0600E2AC RID: 58028 RVA: 0x0006E828 File Offset: 0x0006CA28
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700464C RID: 17996
				// (get) Token: 0x0600E2AD RID: 58029 RVA: 0x00353B0C File Offset: 0x00351D0C
				// (set) Token: 0x0600E2AE RID: 58030 RVA: 0x0006E847 File Offset: 0x0006CA47
				public unsafe PlayerCamera.__c__DisplayClass141_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerCamera.__c__DisplayClass141_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700464D RID: 17997
				// (get) Token: 0x0600E2AF RID: 58031 RVA: 0x00353B3C File Offset: 0x00351D3C
				// (set) Token: 0x0600E2B0 RID: 58032 RVA: 0x0006E866 File Offset: 0x0006CA66
				public unsafe float _timeRemaining_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__timeRemaining_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__timeRemaining_5__2)) = value;
					}
				}

				// Token: 0x040097B0 RID: 38832
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040097B1 RID: 38833
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040097B2 RID: 38834
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040097B3 RID: 38835
				private static readonly IntPtr NativeFieldInfoPtr__timeRemaining_5__2;

				// Token: 0x040097B4 RID: 38836
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040097B5 RID: 38837
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040097B6 RID: 38838
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040097B7 RID: 38839
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040097B8 RID: 38840
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040097B9 RID: 38841
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x0200099B RID: 2459
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerCamera+<ILerpCamera>d__115")]
		public sealed class _ILerpCamera_d__115 : Il2CppSystem.Object
		{
			// Token: 0x0600CAE3 RID: 51939 RVA: 0x00310928 File Offset: 0x0030EB28
			// Note: this type is marked as 'beforefieldinit'.
			static _ILerpCamera_d__115()
			{
				Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<ILerpCamera>d__115");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr);
				PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, "<>1__state");
				PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, "<>2__current");
				PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, "<>4__this");
				PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_worldSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, "worldSpace");
				PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_returnToRestingPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, "returnToRestingPosition");
				PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_lerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, "lerpTime");
				PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_endPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, "endPos");
				PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_endRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, "endRot");
				PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_reenableLook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, "reenableLook");
				PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr__startPos_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, "<startPos>5__2");
				PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr__startRot_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, "<startRot>5__3");
				PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr__elapsed_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, "<elapsed>5__4");
				PlayerCamera._ILerpCamera_d__115.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, 100673304);
				PlayerCamera._ILerpCamera_d__115.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, 100673305);
				PlayerCamera._ILerpCamera_d__115.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, 100673306);
				PlayerCamera._ILerpCamera_d__115.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, 100673307);
				PlayerCamera._ILerpCamera_d__115.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, 100673308);
				PlayerCamera._ILerpCamera_d__115.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, 100673309);
			}

			// Token: 0x0600CAE4 RID: 51940 RVA: 0x00310ABC File Offset: 0x0030ECBC
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ILerpCamera_d__115(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._ILerpCamera_d__115.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CAE5 RID: 51941 RVA: 0x00310B04 File Offset: 0x0030ED04
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._ILerpCamera_d__115.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CAE6 RID: 51942 RVA: 0x00310B38 File Offset: 0x0030ED38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172287, XrefRangeEnd = 172326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._ILerpCamera_d__115.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003F3A RID: 16186
			// (get) Token: 0x0600CAE7 RID: 51943 RVA: 0x00310B74 File Offset: 0x0030ED74
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._ILerpCamera_d__115.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CAE8 RID: 51944 RVA: 0x00310BB4 File Offset: 0x0030EDB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172326, XrefRangeEnd = 172331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._ILerpCamera_d__115.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003F3B RID: 16187
			// (get) Token: 0x0600CAE9 RID: 51945 RVA: 0x00310BE8 File Offset: 0x0030EDE8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._ILerpCamera_d__115.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CAEA RID: 51946 RVA: 0x00062A1E File Offset: 0x00060C1E
			public _ILerpCamera_d__115(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F2E RID: 16174
			// (get) Token: 0x0600CAEB RID: 51947 RVA: 0x00310C28 File Offset: 0x0030EE28
			// (set) Token: 0x0600CAEC RID: 51948 RVA: 0x00062A27 File Offset: 0x00060C27
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003F2F RID: 16175
			// (get) Token: 0x0600CAED RID: 51949 RVA: 0x00310C50 File Offset: 0x0030EE50
			// (set) Token: 0x0600CAEE RID: 51950 RVA: 0x00062A42 File Offset: 0x00060C42
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F30 RID: 16176
			// (get) Token: 0x0600CAEF RID: 51951 RVA: 0x00310C80 File Offset: 0x0030EE80
			// (set) Token: 0x0600CAF0 RID: 51952 RVA: 0x00062A61 File Offset: 0x00060C61
			public unsafe PlayerCamera __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerCamera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F31 RID: 16177
			// (get) Token: 0x0600CAF1 RID: 51953 RVA: 0x00310CB0 File Offset: 0x0030EEB0
			// (set) Token: 0x0600CAF2 RID: 51954 RVA: 0x00062A80 File Offset: 0x00060C80
			public unsafe bool worldSpace
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_worldSpace);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_worldSpace)) = value;
				}
			}

			// Token: 0x17003F32 RID: 16178
			// (get) Token: 0x0600CAF3 RID: 51955 RVA: 0x00310CD8 File Offset: 0x0030EED8
			// (set) Token: 0x0600CAF4 RID: 51956 RVA: 0x00062A9B File Offset: 0x00060C9B
			public unsafe bool returnToRestingPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_returnToRestingPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_returnToRestingPosition)) = value;
				}
			}

			// Token: 0x17003F33 RID: 16179
			// (get) Token: 0x0600CAF5 RID: 51957 RVA: 0x00310D00 File Offset: 0x0030EF00
			// (set) Token: 0x0600CAF6 RID: 51958 RVA: 0x00062AB6 File Offset: 0x00060CB6
			public unsafe float lerpTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_lerpTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_lerpTime)) = value;
				}
			}

			// Token: 0x17003F34 RID: 16180
			// (get) Token: 0x0600CAF7 RID: 51959 RVA: 0x00310D28 File Offset: 0x0030EF28
			// (set) Token: 0x0600CAF8 RID: 51960 RVA: 0x00062AD1 File Offset: 0x00060CD1
			public unsafe Vector3 endPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_endPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_endPos)) = value;
				}
			}

			// Token: 0x17003F35 RID: 16181
			// (get) Token: 0x0600CAF9 RID: 51961 RVA: 0x00310D50 File Offset: 0x0030EF50
			// (set) Token: 0x0600CAFA RID: 51962 RVA: 0x00062AEC File Offset: 0x00060CEC
			public unsafe Quaternion endRot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_endRot);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_endRot)) = value;
				}
			}

			// Token: 0x17003F36 RID: 16182
			// (get) Token: 0x0600CAFB RID: 51963 RVA: 0x00310D78 File Offset: 0x0030EF78
			// (set) Token: 0x0600CAFC RID: 51964 RVA: 0x00062B07 File Offset: 0x00060D07
			public unsafe bool reenableLook
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_reenableLook);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_reenableLook)) = value;
				}
			}

			// Token: 0x17003F37 RID: 16183
			// (get) Token: 0x0600CAFD RID: 51965 RVA: 0x00310DA0 File Offset: 0x0030EFA0
			// (set) Token: 0x0600CAFE RID: 51966 RVA: 0x00062B22 File Offset: 0x00060D22
			public unsafe Vector3 _startPos_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr__startPos_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr__startPos_5__2)) = value;
				}
			}

			// Token: 0x17003F38 RID: 16184
			// (get) Token: 0x0600CAFF RID: 51967 RVA: 0x00310DC8 File Offset: 0x0030EFC8
			// (set) Token: 0x0600CB00 RID: 51968 RVA: 0x00062B3D File Offset: 0x00060D3D
			public unsafe Quaternion _startRot_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr__startRot_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr__startRot_5__3)) = value;
				}
			}

			// Token: 0x17003F39 RID: 16185
			// (get) Token: 0x0600CB01 RID: 51969 RVA: 0x00310DF0 File Offset: 0x0030EFF0
			// (set) Token: 0x0600CB02 RID: 51970 RVA: 0x00062B58 File Offset: 0x00060D58
			public unsafe float _elapsed_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr__elapsed_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr__elapsed_5__4)) = value;
				}
			}

			// Token: 0x04008936 RID: 35126
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008937 RID: 35127
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008938 RID: 35128
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008939 RID: 35129
			private static readonly IntPtr NativeFieldInfoPtr_worldSpace;

			// Token: 0x0400893A RID: 35130
			private static readonly IntPtr NativeFieldInfoPtr_returnToRestingPosition;

			// Token: 0x0400893B RID: 35131
			private static readonly IntPtr NativeFieldInfoPtr_lerpTime;

			// Token: 0x0400893C RID: 35132
			private static readonly IntPtr NativeFieldInfoPtr_endPos;

			// Token: 0x0400893D RID: 35133
			private static readonly IntPtr NativeFieldInfoPtr_endRot;

			// Token: 0x0400893E RID: 35134
			private static readonly IntPtr NativeFieldInfoPtr_reenableLook;

			// Token: 0x0400893F RID: 35135
			private static readonly IntPtr NativeFieldInfoPtr__startPos_5__2;

			// Token: 0x04008940 RID: 35136
			private static readonly IntPtr NativeFieldInfoPtr__startRot_5__3;

			// Token: 0x04008941 RID: 35137
			private static readonly IntPtr NativeFieldInfoPtr__elapsed_5__4;

			// Token: 0x04008942 RID: 35138
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008943 RID: 35139
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008944 RID: 35140
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008945 RID: 35141
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008946 RID: 35142
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008947 RID: 35143
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200099C RID: 2460
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerCamera+<ILerpFOV>d__126")]
		public sealed class _ILerpFOV_d__126 : Il2CppSystem.Object
		{
			// Token: 0x0600CB03 RID: 51971 RVA: 0x00310E18 File Offset: 0x0030F018
			// Note: this type is marked as 'beforefieldinit'.
			static _ILerpFOV_d__126()
			{
				Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__126>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<ILerpFOV>d__126");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__126>.NativeClassPtr);
				PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__126>.NativeClassPtr, "<>1__state");
				PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__126>.NativeClassPtr, "<>2__current");
				PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__126>.NativeClassPtr, "<>4__this");
				PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr_endFov = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__126>.NativeClassPtr, "endFov");
				PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr_lerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__126>.NativeClassPtr, "lerpTime");
				PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr__startFov_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__126>.NativeClassPtr, "<startFov>5__2");
				PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__126>.NativeClassPtr, "<i>5__3");
				PlayerCamera._ILerpFOV_d__126.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__126>.NativeClassPtr, 100673310);
				PlayerCamera._ILerpFOV_d__126.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__126>.NativeClassPtr, 100673311);
				PlayerCamera._ILerpFOV_d__126.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__126>.NativeClassPtr, 100673312);
				PlayerCamera._ILerpFOV_d__126.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__126>.NativeClassPtr, 100673313);
				PlayerCamera._ILerpFOV_d__126.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__126>.NativeClassPtr, 100673314);
				PlayerCamera._ILerpFOV_d__126.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__126>.NativeClassPtr, 100673315);
			}

			// Token: 0x0600CB04 RID: 51972 RVA: 0x00310F48 File Offset: 0x0030F148
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ILerpFOV_d__126(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__126>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._ILerpFOV_d__126.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB05 RID: 51973 RVA: 0x00310F90 File Offset: 0x0030F190
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._ILerpFOV_d__126.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB06 RID: 51974 RVA: 0x00310FC4 File Offset: 0x0030F1C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172331, XrefRangeEnd = 172341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._ILerpFOV_d__126.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003F43 RID: 16195
			// (get) Token: 0x0600CB07 RID: 51975 RVA: 0x00311000 File Offset: 0x0030F200
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._ILerpFOV_d__126.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CB08 RID: 51976 RVA: 0x00311040 File Offset: 0x0030F240
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172341, XrefRangeEnd = 172346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._ILerpFOV_d__126.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003F44 RID: 16196
			// (get) Token: 0x0600CB09 RID: 51977 RVA: 0x00311074 File Offset: 0x0030F274
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._ILerpFOV_d__126.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CB0A RID: 51978 RVA: 0x00062B73 File Offset: 0x00060D73
			public _ILerpFOV_d__126(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F3C RID: 16188
			// (get) Token: 0x0600CB0B RID: 51979 RVA: 0x003110B4 File Offset: 0x0030F2B4
			// (set) Token: 0x0600CB0C RID: 51980 RVA: 0x00062B7C File Offset: 0x00060D7C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003F3D RID: 16189
			// (get) Token: 0x0600CB0D RID: 51981 RVA: 0x003110DC File Offset: 0x0030F2DC
			// (set) Token: 0x0600CB0E RID: 51982 RVA: 0x00062B97 File Offset: 0x00060D97
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F3E RID: 16190
			// (get) Token: 0x0600CB0F RID: 51983 RVA: 0x0031110C File Offset: 0x0030F30C
			// (set) Token: 0x0600CB10 RID: 51984 RVA: 0x00062BB6 File Offset: 0x00060DB6
			public unsafe PlayerCamera __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerCamera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F3F RID: 16191
			// (get) Token: 0x0600CB11 RID: 51985 RVA: 0x0031113C File Offset: 0x0030F33C
			// (set) Token: 0x0600CB12 RID: 51986 RVA: 0x00062BD5 File Offset: 0x00060DD5
			public unsafe float endFov
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr_endFov);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr_endFov)) = value;
				}
			}

			// Token: 0x17003F40 RID: 16192
			// (get) Token: 0x0600CB13 RID: 51987 RVA: 0x00311164 File Offset: 0x0030F364
			// (set) Token: 0x0600CB14 RID: 51988 RVA: 0x00062BF0 File Offset: 0x00060DF0
			public unsafe float lerpTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr_lerpTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr_lerpTime)) = value;
				}
			}

			// Token: 0x17003F41 RID: 16193
			// (get) Token: 0x0600CB15 RID: 51989 RVA: 0x0031118C File Offset: 0x0030F38C
			// (set) Token: 0x0600CB16 RID: 51990 RVA: 0x00062C0B File Offset: 0x00060E0B
			public unsafe float _startFov_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr__startFov_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr__startFov_5__2)) = value;
				}
			}

			// Token: 0x17003F42 RID: 16194
			// (get) Token: 0x0600CB17 RID: 51991 RVA: 0x003111B4 File Offset: 0x0030F3B4
			// (set) Token: 0x0600CB18 RID: 51992 RVA: 0x00062C26 File Offset: 0x00060E26
			public unsafe float _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x04008948 RID: 35144
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008949 RID: 35145
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400894A RID: 35146
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400894B RID: 35147
			private static readonly IntPtr NativeFieldInfoPtr_endFov;

			// Token: 0x0400894C RID: 35148
			private static readonly IntPtr NativeFieldInfoPtr_lerpTime;

			// Token: 0x0400894D RID: 35149
			private static readonly IntPtr NativeFieldInfoPtr__startFov_5__2;

			// Token: 0x0400894E RID: 35150
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x0400894F RID: 35151
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008950 RID: 35152
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008951 RID: 35153
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008952 RID: 35154
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008953 RID: 35155
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008954 RID: 35156
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200099D RID: 2461
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerCamera+<LerpDoF>d__123")]
		public sealed class _LerpDoF_d__123 : Il2CppSystem.Object
		{
			// Token: 0x0600CB19 RID: 51993 RVA: 0x003111DC File Offset: 0x0030F3DC
			// Note: this type is marked as 'beforefieldinit'.
			static _LerpDoF_d__123()
			{
				Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<LerpDoF>d__123");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr);
				PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr, "<>1__state");
				PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr, "<>2__current");
				PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr, "active");
				PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr, "<>4__this");
				PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr_lerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr, "lerpTime");
				PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr__startFocusDist_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr, "<startFocusDist>5__2");
				PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr__endFocusDist_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr, "<endFocusDist>5__3");
				PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr, "<i>5__4");
				PlayerCamera._LerpDoF_d__123.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr, 100673316);
				PlayerCamera._LerpDoF_d__123.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr, 100673317);
				PlayerCamera._LerpDoF_d__123.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr, 100673318);
				PlayerCamera._LerpDoF_d__123.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr, 100673319);
				PlayerCamera._LerpDoF_d__123.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr, 100673320);
				PlayerCamera._LerpDoF_d__123.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr, 100673321);
			}

			// Token: 0x0600CB1A RID: 51994 RVA: 0x00311320 File Offset: 0x0030F520
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LerpDoF_d__123(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._LerpDoF_d__123.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB1B RID: 51995 RVA: 0x00311368 File Offset: 0x0030F568
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._LerpDoF_d__123.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB1C RID: 51996 RVA: 0x0031139C File Offset: 0x0030F59C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172346, XrefRangeEnd = 172355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._LerpDoF_d__123.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003F4D RID: 16205
			// (get) Token: 0x0600CB1D RID: 51997 RVA: 0x003113D8 File Offset: 0x0030F5D8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._LerpDoF_d__123.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CB1E RID: 51998 RVA: 0x00311418 File Offset: 0x0030F618
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172355, XrefRangeEnd = 172360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._LerpDoF_d__123.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003F4E RID: 16206
			// (get) Token: 0x0600CB1F RID: 51999 RVA: 0x0031144C File Offset: 0x0030F64C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._LerpDoF_d__123.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CB20 RID: 52000 RVA: 0x00062C41 File Offset: 0x00060E41
			public _LerpDoF_d__123(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F45 RID: 16197
			// (get) Token: 0x0600CB21 RID: 52001 RVA: 0x0031148C File Offset: 0x0030F68C
			// (set) Token: 0x0600CB22 RID: 52002 RVA: 0x00062C4A File Offset: 0x00060E4A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003F46 RID: 16198
			// (get) Token: 0x0600CB23 RID: 52003 RVA: 0x003114B4 File Offset: 0x0030F6B4
			// (set) Token: 0x0600CB24 RID: 52004 RVA: 0x00062C65 File Offset: 0x00060E65
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F47 RID: 16199
			// (get) Token: 0x0600CB25 RID: 52005 RVA: 0x003114E4 File Offset: 0x0030F6E4
			// (set) Token: 0x0600CB26 RID: 52006 RVA: 0x00062C84 File Offset: 0x00060E84
			public unsafe bool active
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr_active);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr_active)) = value;
				}
			}

			// Token: 0x17003F48 RID: 16200
			// (get) Token: 0x0600CB27 RID: 52007 RVA: 0x0031150C File Offset: 0x0030F70C
			// (set) Token: 0x0600CB28 RID: 52008 RVA: 0x00062C9F File Offset: 0x00060E9F
			public unsafe PlayerCamera __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerCamera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F49 RID: 16201
			// (get) Token: 0x0600CB29 RID: 52009 RVA: 0x0031153C File Offset: 0x0030F73C
			// (set) Token: 0x0600CB2A RID: 52010 RVA: 0x00062CBE File Offset: 0x00060EBE
			public unsafe float lerpTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr_lerpTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr_lerpTime)) = value;
				}
			}

			// Token: 0x17003F4A RID: 16202
			// (get) Token: 0x0600CB2B RID: 52011 RVA: 0x00311564 File Offset: 0x0030F764
			// (set) Token: 0x0600CB2C RID: 52012 RVA: 0x00062CD9 File Offset: 0x00060ED9
			public unsafe float _startFocusDist_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr__startFocusDist_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr__startFocusDist_5__2)) = value;
				}
			}

			// Token: 0x17003F4B RID: 16203
			// (get) Token: 0x0600CB2D RID: 52013 RVA: 0x0031158C File Offset: 0x0030F78C
			// (set) Token: 0x0600CB2E RID: 52014 RVA: 0x00062CF4 File Offset: 0x00060EF4
			public unsafe float _endFocusDist_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr__endFocusDist_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr__endFocusDist_5__3)) = value;
				}
			}

			// Token: 0x17003F4C RID: 16204
			// (get) Token: 0x0600CB2F RID: 52015 RVA: 0x003115B4 File Offset: 0x0030F7B4
			// (set) Token: 0x0600CB30 RID: 52016 RVA: 0x00062D0F File Offset: 0x00060F0F
			public unsafe float _i_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr__i_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr__i_5__4)) = value;
				}
			}

			// Token: 0x04008955 RID: 35157
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008956 RID: 35158
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008957 RID: 35159
			private static readonly IntPtr NativeFieldInfoPtr_active;

			// Token: 0x04008958 RID: 35160
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008959 RID: 35161
			private static readonly IntPtr NativeFieldInfoPtr_lerpTime;

			// Token: 0x0400895A RID: 35162
			private static readonly IntPtr NativeFieldInfoPtr__startFocusDist_5__2;

			// Token: 0x0400895B RID: 35163
			private static readonly IntPtr NativeFieldInfoPtr__endFocusDist_5__3;

			// Token: 0x0400895C RID: 35164
			private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

			// Token: 0x0400895D RID: 35165
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400895E RID: 35166
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400895F RID: 35167
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008960 RID: 35168
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008961 RID: 35169
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008962 RID: 35170
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
