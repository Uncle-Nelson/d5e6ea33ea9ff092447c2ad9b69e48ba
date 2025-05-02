using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace Il2CppScheduleOne
{
	// Token: 0x02000169 RID: 361
	public class GameInput : PersistentSingleton<GameInput>
	{
		// Token: 0x06001D27 RID: 7463 RVA: 0x000CB0A4 File Offset: 0x000C92A4
		// Note: this type is marked as 'beforefieldinit'.
		static GameInput()
		{
			Il2CppClassPointerStore<GameInput>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "GameInput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameInput>.NativeClassPtr);
			GameInput.NativeFieldInfoPtr_exitListeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "exitListeners");
			GameInput.NativeFieldInfoPtr_PlayerInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "PlayerInput");
			GameInput.NativeFieldInfoPtr_IsTyping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "IsTyping");
			GameInput.NativeFieldInfoPtr_MotionAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "MotionAxis");
			GameInput.NativeFieldInfoPtr_buttonsDownThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "buttonsDownThisFrame");
			GameInput.NativeFieldInfoPtr_buttonsDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "buttonsDown");
			GameInput.NativeFieldInfoPtr_buttonsUpThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "buttonsUpThisFrame");
			GameInput.NativeMethodInfoPtr_get_MouseDelta_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666594);
			GameInput.NativeMethodInfoPtr_get_MousePosition_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666595);
			GameInput.NativeMethodInfoPtr_get_MouseScrollDelta_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666596);
			GameInput.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666597);
			GameInput.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666598);
			GameInput.NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666599);
			GameInput.NativeMethodInfoPtr_GetButton_Public_Static_Boolean_ButtonCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666600);
			GameInput.NativeMethodInfoPtr_GetButtonDown_Public_Static_Boolean_ButtonCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666601);
			GameInput.NativeMethodInfoPtr_GetButtonUp_Public_Static_Boolean_ButtonCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666602);
			GameInput.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666603);
			GameInput.NativeMethodInfoPtr_Exit_Private_Void_ExitType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666604);
			GameInput.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666605);
			GameInput.NativeMethodInfoPtr_ExitAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666606);
			GameInput.NativeMethodInfoPtr_OnMotion_Private_Void_InputValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666607);
			GameInput.NativeMethodInfoPtr_OnPrimaryClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666608);
			GameInput.NativeMethodInfoPtr_OnSecondaryClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666609);
			GameInput.NativeMethodInfoPtr_OnTertiaryClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666610);
			GameInput.NativeMethodInfoPtr_OnJump_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666611);
			GameInput.NativeMethodInfoPtr_OnCrouch_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666612);
			GameInput.NativeMethodInfoPtr_OnSprint_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666613);
			GameInput.NativeMethodInfoPtr_OnEscape_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666614);
			GameInput.NativeMethodInfoPtr_OnBack_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666615);
			GameInput.NativeMethodInfoPtr_OnInteract_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666616);
			GameInput.NativeMethodInfoPtr_OnSubmit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666617);
			GameInput.NativeMethodInfoPtr_OnTogglePhone_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666618);
			GameInput.NativeMethodInfoPtr_OnToggleLights_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666619);
			GameInput.NativeMethodInfoPtr_OnHandbrake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666620);
			GameInput.NativeMethodInfoPtr_OnRotateLeft_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666621);
			GameInput.NativeMethodInfoPtr_OnRotateRight_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666622);
			GameInput.NativeMethodInfoPtr_OnManagementMode_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666623);
			GameInput.NativeMethodInfoPtr_OnOpenMap_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666624);
			GameInput.NativeMethodInfoPtr_OnOpenJournal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666625);
			GameInput.NativeMethodInfoPtr_OnOpenTexts_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666626);
			GameInput.NativeMethodInfoPtr_OnQuickMove_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666627);
			GameInput.NativeMethodInfoPtr_OnToggleFlashlight_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666628);
			GameInput.NativeMethodInfoPtr_OnViewAvatar_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666629);
			GameInput.NativeMethodInfoPtr_OnReload_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666630);
			GameInput.NativeMethodInfoPtr_RegisterExitListener_Public_Static_Void_ExitDelegate_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666631);
			GameInput.NativeMethodInfoPtr_DeregisterExitListener_Public_Static_Void_ExitDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666632);
			GameInput.NativeMethodInfoPtr_GetAction_Public_InputAction_ButtonCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666633);
			GameInput.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666634);
		}

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x06001D28 RID: 7464 RVA: 0x000CB494 File Offset: 0x000C9694
		public unsafe static Vector2 MouseDelta
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 105125, RefRangeEnd = 105144, XrefRangeStart = 105119, XrefRangeEnd = 105125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_get_MouseDelta_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x06001D29 RID: 7465 RVA: 0x000CB4C4 File Offset: 0x000C96C4
		public unsafe static Vector3 MousePosition
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 105145, RefRangeEnd = 105149, XrefRangeStart = 105144, XrefRangeEnd = 105145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_get_MousePosition_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x06001D2A RID: 7466 RVA: 0x000CB4F4 File Offset: 0x000C96F4
		public unsafe static float MouseScrollDelta
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 105152, RefRangeEnd = 105160, XrefRangeStart = 105149, XrefRangeEnd = 105152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_get_MouseScrollDelta_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D2B RID: 7467 RVA: 0x000CB524 File Offset: 0x000C9724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105160, XrefRangeEnd = 105163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameInput.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D2C RID: 7468 RVA: 0x000CB560 File Offset: 0x000C9760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105163, XrefRangeEnd = 105199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameInput.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D2D RID: 7469 RVA: 0x000CB59C File Offset: 0x000C979C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105199, XrefRangeEnd = 105218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnApplicationFocus(bool focus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref focus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D2E RID: 7470 RVA: 0x000CB5DC File Offset: 0x000C97DC
		[CallerCount(80)]
		[CachedScanResults(RefRangeStart = 105226, RefRangeEnd = 105306, XrefRangeStart = 105218, XrefRangeEnd = 105226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetButton(GameInput.ButtonCode buttonCode)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref buttonCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_GetButton_Public_Static_Boolean_ButtonCode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D2F RID: 7471 RVA: 0x000CB61C File Offset: 0x000C981C
		[CallerCount(116)]
		[CachedScanResults(RefRangeStart = 105314, RefRangeEnd = 105430, XrefRangeStart = 105306, XrefRangeEnd = 105314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetButtonDown(GameInput.ButtonCode buttonCode)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref buttonCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_GetButtonDown_Public_Static_Boolean_ButtonCode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D30 RID: 7472 RVA: 0x000CB65C File Offset: 0x000C985C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 105438, RefRangeEnd = 105439, XrefRangeStart = 105430, XrefRangeEnd = 105438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetButtonUp(GameInput.ButtonCode buttonCode)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref buttonCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_GetButtonUp_Public_Static_Boolean_ButtonCode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D31 RID: 7473 RVA: 0x000CB69C File Offset: 0x000C989C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105439, XrefRangeEnd = 105474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameInput.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D32 RID: 7474 RVA: 0x000CB6D8 File Offset: 0x000C98D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 105489, RefRangeEnd = 105491, XrefRangeStart = 105474, XrefRangeEnd = 105489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_Exit_Private_Void_ExitType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D33 RID: 7475 RVA: 0x000CB718 File Offset: 0x000C9918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105491, XrefRangeEnd = 105492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D34 RID: 7476 RVA: 0x000CB74C File Offset: 0x000C994C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 105520, RefRangeEnd = 105530, XrefRangeStart = 105492, XrefRangeEnd = 105520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_ExitAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D35 RID: 7477 RVA: 0x000CB780 File Offset: 0x000C9980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105530, XrefRangeEnd = 105605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMotion(InputValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnMotion_Private_Void_InputValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D36 RID: 7478 RVA: 0x000CB7C4 File Offset: 0x000C99C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 105615, RefRangeEnd = 105616, XrefRangeStart = 105605, XrefRangeEnd = 105615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPrimaryClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnPrimaryClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D37 RID: 7479 RVA: 0x000CB7F8 File Offset: 0x000C99F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 105626, RefRangeEnd = 105627, XrefRangeStart = 105616, XrefRangeEnd = 105626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSecondaryClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnSecondaryClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D38 RID: 7480 RVA: 0x000CB82C File Offset: 0x000C9A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105627, XrefRangeEnd = 105637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTertiaryClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnTertiaryClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D39 RID: 7481 RVA: 0x000CB860 File Offset: 0x000C9A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105637, XrefRangeEnd = 105647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnJump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnJump_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D3A RID: 7482 RVA: 0x000CB894 File Offset: 0x000C9A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105647, XrefRangeEnd = 105657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCrouch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnCrouch_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D3B RID: 7483 RVA: 0x000CB8C8 File Offset: 0x000C9AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105657, XrefRangeEnd = 105667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSprint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnSprint_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D3C RID: 7484 RVA: 0x000CB8FC File Offset: 0x000C9AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105667, XrefRangeEnd = 105677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEscape()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnEscape_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D3D RID: 7485 RVA: 0x000CB930 File Offset: 0x000C9B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105677, XrefRangeEnd = 105687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnBack_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D3E RID: 7486 RVA: 0x000CB964 File Offset: 0x000C9B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105687, XrefRangeEnd = 105697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnInteract_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D3F RID: 7487 RVA: 0x000CB998 File Offset: 0x000C9B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105697, XrefRangeEnd = 105707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSubmit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnSubmit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D40 RID: 7488 RVA: 0x000CB9CC File Offset: 0x000C9BCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105707, XrefRangeEnd = 105717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTogglePhone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnTogglePhone_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D41 RID: 7489 RVA: 0x000CBA00 File Offset: 0x000C9C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105717, XrefRangeEnd = 105727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnToggleLights()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnToggleLights_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D42 RID: 7490 RVA: 0x000CBA34 File Offset: 0x000C9C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105727, XrefRangeEnd = 105737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnHandbrake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnHandbrake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D43 RID: 7491 RVA: 0x000CBA68 File Offset: 0x000C9C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105737, XrefRangeEnd = 105747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRotateLeft()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnRotateLeft_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D44 RID: 7492 RVA: 0x000CBA9C File Offset: 0x000C9C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105747, XrefRangeEnd = 105757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRotateRight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnRotateRight_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D45 RID: 7493 RVA: 0x000CBAD0 File Offset: 0x000C9CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105757, XrefRangeEnd = 105767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnManagementMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnManagementMode_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D46 RID: 7494 RVA: 0x000CBB04 File Offset: 0x000C9D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105767, XrefRangeEnd = 105777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnOpenMap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnOpenMap_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D47 RID: 7495 RVA: 0x000CBB38 File Offset: 0x000C9D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105777, XrefRangeEnd = 105787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnOpenJournal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnOpenJournal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D48 RID: 7496 RVA: 0x000CBB6C File Offset: 0x000C9D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105787, XrefRangeEnd = 105797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnOpenTexts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnOpenTexts_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D49 RID: 7497 RVA: 0x000CBBA0 File Offset: 0x000C9DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105797, XrefRangeEnd = 105807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnQuickMove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnQuickMove_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D4A RID: 7498 RVA: 0x000CBBD4 File Offset: 0x000C9DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105807, XrefRangeEnd = 105817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnToggleFlashlight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnToggleFlashlight_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D4B RID: 7499 RVA: 0x000CBC08 File Offset: 0x000C9E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105817, XrefRangeEnd = 105827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnViewAvatar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnViewAvatar_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D4C RID: 7500 RVA: 0x000CBC3C File Offset: 0x000C9E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105827, XrefRangeEnd = 105837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnReload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnReload_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D4D RID: 7501 RVA: 0x000CBC70 File Offset: 0x000C9E70
		[CallerCount(65)]
		[CachedScanResults(RefRangeStart = 105867, RefRangeEnd = 105932, XrefRangeStart = 105837, XrefRangeEnd = 105867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterExitListener(GameInput.ExitDelegate listener, int priority = 0)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_RegisterExitListener_Public_Static_Void_ExitDelegate_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D4E RID: 7502 RVA: 0x000CBCB4 File Offset: 0x000C9EB4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 105950, RefRangeEnd = 105961, XrefRangeStart = 105932, XrefRangeEnd = 105950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeregisterExitListener(GameInput.ExitDelegate listener)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_DeregisterExitListener_Public_Static_Void_ExitDelegate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D4F RID: 7503 RVA: 0x000CBCEC File Offset: 0x000C9EEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 105965, RefRangeEnd = 105966, XrefRangeStart = 105961, XrefRangeEnd = 105965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputAction GetAction(GameInput.ButtonCode code)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref code;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_GetAction_Public_InputAction_ButtonCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputAction>(intPtr3) : null;
		}

		// Token: 0x06001D50 RID: 7504 RVA: 0x000CBD38 File Offset: 0x000C9F38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105966, XrefRangeEnd = 105986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameInput() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameInput>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D51 RID: 7505 RVA: 0x0001093F File Offset: 0x0000EB3F
		public GameInput(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x06001D52 RID: 7506 RVA: 0x000CBD74 File Offset: 0x000C9F74
		// (set) Token: 0x06001D53 RID: 7507 RVA: 0x00010948 File Offset: 0x0000EB48
		public unsafe static List<GameInput.ExitListener> exitListeners
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GameInput.NativeFieldInfoPtr_exitListeners, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameInput.ExitListener>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameInput.NativeFieldInfoPtr_exitListeners, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x06001D54 RID: 7508 RVA: 0x000CBD9C File Offset: 0x000C9F9C
		// (set) Token: 0x06001D55 RID: 7509 RVA: 0x0001095A File Offset: 0x0000EB5A
		public unsafe PlayerInput PlayerInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.NativeFieldInfoPtr_PlayerInput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerInput>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.NativeFieldInfoPtr_PlayerInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x06001D56 RID: 7510 RVA: 0x000CBDCC File Offset: 0x000C9FCC
		// (set) Token: 0x06001D57 RID: 7511 RVA: 0x00010979 File Offset: 0x0000EB79
		public unsafe static bool IsTyping
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(GameInput.NativeFieldInfoPtr_IsTyping, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameInput.NativeFieldInfoPtr_IsTyping, (void*)(&value));
			}
		}

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x06001D58 RID: 7512 RVA: 0x000CBDE8 File Offset: 0x000C9FE8
		// (set) Token: 0x06001D59 RID: 7513 RVA: 0x00010987 File Offset: 0x0000EB87
		public unsafe static Vector2 MotionAxis
		{
			get
			{
				Vector2 result;
				IL2CPP.il2cpp_field_static_get_value(GameInput.NativeFieldInfoPtr_MotionAxis, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameInput.NativeFieldInfoPtr_MotionAxis, (void*)(&value));
			}
		}

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x06001D5A RID: 7514 RVA: 0x000CBE04 File Offset: 0x000CA004
		// (set) Token: 0x06001D5B RID: 7515 RVA: 0x00010995 File Offset: 0x0000EB95
		public unsafe List<GameInput.ButtonCode> buttonsDownThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.NativeFieldInfoPtr_buttonsDownThisFrame);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameInput.ButtonCode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.NativeFieldInfoPtr_buttonsDownThisFrame), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x06001D5C RID: 7516 RVA: 0x000CBE34 File Offset: 0x000CA034
		// (set) Token: 0x06001D5D RID: 7517 RVA: 0x000109B4 File Offset: 0x0000EBB4
		public unsafe List<GameInput.ButtonCode> buttonsDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.NativeFieldInfoPtr_buttonsDown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameInput.ButtonCode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.NativeFieldInfoPtr_buttonsDown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x06001D5E RID: 7518 RVA: 0x000CBE64 File Offset: 0x000CA064
		// (set) Token: 0x06001D5F RID: 7519 RVA: 0x000109D3 File Offset: 0x0000EBD3
		public unsafe List<GameInput.ButtonCode> buttonsUpThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.NativeFieldInfoPtr_buttonsUpThisFrame);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameInput.ButtonCode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.NativeFieldInfoPtr_buttonsUpThisFrame), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001350 RID: 4944
		private static readonly IntPtr NativeFieldInfoPtr_exitListeners;

		// Token: 0x04001351 RID: 4945
		private static readonly IntPtr NativeFieldInfoPtr_PlayerInput;

		// Token: 0x04001352 RID: 4946
		private static readonly IntPtr NativeFieldInfoPtr_IsTyping;

		// Token: 0x04001353 RID: 4947
		private static readonly IntPtr NativeFieldInfoPtr_MotionAxis;

		// Token: 0x04001354 RID: 4948
		private static readonly IntPtr NativeFieldInfoPtr_buttonsDownThisFrame;

		// Token: 0x04001355 RID: 4949
		private static readonly IntPtr NativeFieldInfoPtr_buttonsDown;

		// Token: 0x04001356 RID: 4950
		private static readonly IntPtr NativeFieldInfoPtr_buttonsUpThisFrame;

		// Token: 0x04001357 RID: 4951
		private static readonly IntPtr NativeMethodInfoPtr_get_MouseDelta_Public_Static_get_Vector2_0;

		// Token: 0x04001358 RID: 4952
		private static readonly IntPtr NativeMethodInfoPtr_get_MousePosition_Public_Static_get_Vector3_0;

		// Token: 0x04001359 RID: 4953
		private static readonly IntPtr NativeMethodInfoPtr_get_MouseScrollDelta_Public_Static_get_Single_0;

		// Token: 0x0400135A RID: 4954
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400135B RID: 4955
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400135C RID: 4956
		private static readonly IntPtr NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0;

		// Token: 0x0400135D RID: 4957
		private static readonly IntPtr NativeMethodInfoPtr_GetButton_Public_Static_Boolean_ButtonCode_0;

		// Token: 0x0400135E RID: 4958
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonDown_Public_Static_Boolean_ButtonCode_0;

		// Token: 0x0400135F RID: 4959
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonUp_Public_Static_Boolean_ButtonCode_0;

		// Token: 0x04001360 RID: 4960
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04001361 RID: 4961
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitType_0;

		// Token: 0x04001362 RID: 4962
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04001363 RID: 4963
		private static readonly IntPtr NativeMethodInfoPtr_ExitAll_Public_Void_0;

		// Token: 0x04001364 RID: 4964
		private static readonly IntPtr NativeMethodInfoPtr_OnMotion_Private_Void_InputValue_0;

		// Token: 0x04001365 RID: 4965
		private static readonly IntPtr NativeMethodInfoPtr_OnPrimaryClick_Private_Void_0;

		// Token: 0x04001366 RID: 4966
		private static readonly IntPtr NativeMethodInfoPtr_OnSecondaryClick_Private_Void_0;

		// Token: 0x04001367 RID: 4967
		private static readonly IntPtr NativeMethodInfoPtr_OnTertiaryClick_Private_Void_0;

		// Token: 0x04001368 RID: 4968
		private static readonly IntPtr NativeMethodInfoPtr_OnJump_Private_Void_0;

		// Token: 0x04001369 RID: 4969
		private static readonly IntPtr NativeMethodInfoPtr_OnCrouch_Private_Void_0;

		// Token: 0x0400136A RID: 4970
		private static readonly IntPtr NativeMethodInfoPtr_OnSprint_Private_Void_0;

		// Token: 0x0400136B RID: 4971
		private static readonly IntPtr NativeMethodInfoPtr_OnEscape_Private_Void_0;

		// Token: 0x0400136C RID: 4972
		private static readonly IntPtr NativeMethodInfoPtr_OnBack_Private_Void_0;

		// Token: 0x0400136D RID: 4973
		private static readonly IntPtr NativeMethodInfoPtr_OnInteract_Private_Void_0;

		// Token: 0x0400136E RID: 4974
		private static readonly IntPtr NativeMethodInfoPtr_OnSubmit_Private_Void_0;

		// Token: 0x0400136F RID: 4975
		private static readonly IntPtr NativeMethodInfoPtr_OnTogglePhone_Private_Void_0;

		// Token: 0x04001370 RID: 4976
		private static readonly IntPtr NativeMethodInfoPtr_OnToggleLights_Private_Void_0;

		// Token: 0x04001371 RID: 4977
		private static readonly IntPtr NativeMethodInfoPtr_OnHandbrake_Private_Void_0;

		// Token: 0x04001372 RID: 4978
		private static readonly IntPtr NativeMethodInfoPtr_OnRotateLeft_Private_Void_0;

		// Token: 0x04001373 RID: 4979
		private static readonly IntPtr NativeMethodInfoPtr_OnRotateRight_Private_Void_0;

		// Token: 0x04001374 RID: 4980
		private static readonly IntPtr NativeMethodInfoPtr_OnManagementMode_Private_Void_0;

		// Token: 0x04001375 RID: 4981
		private static readonly IntPtr NativeMethodInfoPtr_OnOpenMap_Private_Void_0;

		// Token: 0x04001376 RID: 4982
		private static readonly IntPtr NativeMethodInfoPtr_OnOpenJournal_Private_Void_0;

		// Token: 0x04001377 RID: 4983
		private static readonly IntPtr NativeMethodInfoPtr_OnOpenTexts_Private_Void_0;

		// Token: 0x04001378 RID: 4984
		private static readonly IntPtr NativeMethodInfoPtr_OnQuickMove_Private_Void_0;

		// Token: 0x04001379 RID: 4985
		private static readonly IntPtr NativeMethodInfoPtr_OnToggleFlashlight_Private_Void_0;

		// Token: 0x0400137A RID: 4986
		private static readonly IntPtr NativeMethodInfoPtr_OnViewAvatar_Private_Void_0;

		// Token: 0x0400137B RID: 4987
		private static readonly IntPtr NativeMethodInfoPtr_OnReload_Private_Void_0;

		// Token: 0x0400137C RID: 4988
		private static readonly IntPtr NativeMethodInfoPtr_RegisterExitListener_Public_Static_Void_ExitDelegate_Int32_0;

		// Token: 0x0400137D RID: 4989
		private static readonly IntPtr NativeMethodInfoPtr_DeregisterExitListener_Public_Static_Void_ExitDelegate_0;

		// Token: 0x0400137E RID: 4990
		private static readonly IntPtr NativeMethodInfoPtr_GetAction_Public_InputAction_ButtonCode_0;

		// Token: 0x0400137F RID: 4991
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008A3 RID: 2211
		[OriginalName("Assembly-CSharp.dll", "", "ButtonCode")]
		public enum ButtonCode
		{
			// Token: 0x040083E9 RID: 33769
			PrimaryClick,
			// Token: 0x040083EA RID: 33770
			SecondaryClick,
			// Token: 0x040083EB RID: 33771
			TertiaryClick,
			// Token: 0x040083EC RID: 33772
			Forward,
			// Token: 0x040083ED RID: 33773
			Backward,
			// Token: 0x040083EE RID: 33774
			Left,
			// Token: 0x040083EF RID: 33775
			Right,
			// Token: 0x040083F0 RID: 33776
			Jump,
			// Token: 0x040083F1 RID: 33777
			Crouch,
			// Token: 0x040083F2 RID: 33778
			Sprint,
			// Token: 0x040083F3 RID: 33779
			Escape,
			// Token: 0x040083F4 RID: 33780
			Back,
			// Token: 0x040083F5 RID: 33781
			Interact,
			// Token: 0x040083F6 RID: 33782
			Submit,
			// Token: 0x040083F7 RID: 33783
			TogglePhone,
			// Token: 0x040083F8 RID: 33784
			ToggleLights,
			// Token: 0x040083F9 RID: 33785
			Handbrake,
			// Token: 0x040083FA RID: 33786
			RotateLeft,
			// Token: 0x040083FB RID: 33787
			RotateRight,
			// Token: 0x040083FC RID: 33788
			ManagementMode,
			// Token: 0x040083FD RID: 33789
			OpenMap,
			// Token: 0x040083FE RID: 33790
			OpenJournal,
			// Token: 0x040083FF RID: 33791
			OpenTexts,
			// Token: 0x04008400 RID: 33792
			QuickMove,
			// Token: 0x04008401 RID: 33793
			ToggleFlashlight,
			// Token: 0x04008402 RID: 33794
			ViewAvatar,
			// Token: 0x04008403 RID: 33795
			Reload
		}

		// Token: 0x020008A4 RID: 2212
		public class ExitListener : Il2CppSystem.Object
		{
			// Token: 0x0600C2D0 RID: 49872 RVA: 0x002F916C File Offset: 0x002F736C
			// Note: this type is marked as 'beforefieldinit'.
			static ExitListener()
			{
				Il2CppClassPointerStore<GameInput.ExitListener>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "ExitListener");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameInput.ExitListener>.NativeClassPtr);
				GameInput.ExitListener.NativeFieldInfoPtr_listenerFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput.ExitListener>.NativeClassPtr, "listenerFunction");
				GameInput.ExitListener.NativeFieldInfoPtr_priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput.ExitListener>.NativeClassPtr, "priority");
				GameInput.ExitListener.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput.ExitListener>.NativeClassPtr, 100666636);
			}

			// Token: 0x0600C2D1 RID: 49873 RVA: 0x002F91D4 File Offset: 0x002F73D4
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ExitListener() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameInput.ExitListener>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.ExitListener.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C2D2 RID: 49874 RVA: 0x0005ECD8 File Offset: 0x0005CED8
			public ExitListener(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CD6 RID: 15574
			// (get) Token: 0x0600C2D3 RID: 49875 RVA: 0x002F9210 File Offset: 0x002F7410
			// (set) Token: 0x0600C2D4 RID: 49876 RVA: 0x0005ECE1 File Offset: 0x0005CEE1
			public unsafe GameInput.ExitDelegate listenerFunction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.ExitListener.NativeFieldInfoPtr_listenerFunction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameInput.ExitDelegate>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.ExitListener.NativeFieldInfoPtr_listenerFunction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CD7 RID: 15575
			// (get) Token: 0x0600C2D5 RID: 49877 RVA: 0x002F9240 File Offset: 0x002F7440
			// (set) Token: 0x0600C2D6 RID: 49878 RVA: 0x0005ED00 File Offset: 0x0005CF00
			public unsafe int priority
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.ExitListener.NativeFieldInfoPtr_priority);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.ExitListener.NativeFieldInfoPtr_priority)) = value;
				}
			}

			// Token: 0x04008404 RID: 33796
			private static readonly IntPtr NativeFieldInfoPtr_listenerFunction;

			// Token: 0x04008405 RID: 33797
			private static readonly IntPtr NativeFieldInfoPtr_priority;

			// Token: 0x04008406 RID: 33798
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008A5 RID: 2213
		public sealed class ExitDelegate : MulticastDelegate
		{
			// Token: 0x0600C2D7 RID: 49879 RVA: 0x002F9268 File Offset: 0x002F7468
			// Note: this type is marked as 'beforefieldinit'.
			static ExitDelegate()
			{
				Il2CppClassPointerStore<GameInput.ExitDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "ExitDelegate");
				GameInput.ExitDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput.ExitDelegate>.NativeClassPtr, 100666637);
				GameInput.ExitDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput.ExitDelegate>.NativeClassPtr, 100666638);
				GameInput.ExitDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ExitAction_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput.ExitDelegate>.NativeClassPtr, 100666639);
				GameInput.ExitDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput.ExitDelegate>.NativeClassPtr, 100666640);
			}

			// Token: 0x0600C2D8 RID: 49880 RVA: 0x002F92DC File Offset: 0x002F74DC
			[CallerCount(257)]
			[CachedScanResults(RefRangeStart = 104856, RefRangeEnd = 105113, XrefRangeStart = 104847, XrefRangeEnd = 104856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ExitDelegate(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameInput.ExitDelegate>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.ExitDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C2D9 RID: 49881 RVA: 0x002F9338 File Offset: 0x002F7538
			[CallerCount(0)]
			public unsafe void Invoke(ExitAction exitAction)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exitAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.ExitDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C2DA RID: 49882 RVA: 0x002F937C File Offset: 0x002F757C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 74827, RefRangeEnd = 74828, XrefRangeStart = 74827, XrefRangeEnd = 74828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(ExitAction exitAction, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exitAction);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.ExitDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ExitAction_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600C2DB RID: 49883 RVA: 0x002F93F0 File Offset: 0x002F75F0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22499, RefRangeEnd = 22500, XrefRangeStart = 22499, XrefRangeEnd = 22500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.ExitDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C2DC RID: 49884 RVA: 0x0005ED1B File Offset: 0x0005CF1B
			public ExitDelegate(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600C2DD RID: 49885 RVA: 0x0005ED24 File Offset: 0x0005CF24
			public static implicit operator GameInput.ExitDelegate(Action<ExitAction> A_0)
			{
				return DelegateSupport.ConvertDelegate<GameInput.ExitDelegate>(A_0);
			}

			// Token: 0x0600C2DE RID: 49886 RVA: 0x0005ED2C File Offset: 0x0005CF2C
			public static GameInput.ExitDelegate operator +(GameInput.ExitDelegate A_0, GameInput.ExitDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<GameInput.ExitDelegate>();
			}

			// Token: 0x0600C2DF RID: 49887 RVA: 0x0005ED3A File Offset: 0x0005CF3A
			public static GameInput.ExitDelegate operator -(GameInput.ExitDelegate A_0, GameInput.ExitDelegate A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<GameInput.ExitDelegate>();
				}
				return result;
			}

			// Token: 0x04008407 RID: 33799
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04008408 RID: 33800
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ExitAction_0;

			// Token: 0x04008409 RID: 33801
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ExitAction_AsyncCallback_Object_0;

			// Token: 0x0400840A RID: 33802
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020008A6 RID: 2214
		[ObfuscatedName("ScheduleOne.GameInput+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600C2E0 RID: 49888 RVA: 0x002F9434 File Offset: 0x002F7634
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GameInput.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameInput.__c>.NativeClassPtr);
				GameInput.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput.__c>.NativeClassPtr, "<>9");
				GameInput.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput.__c>.NativeClassPtr, "<>9__17_0");
				GameInput.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput.__c>.NativeClassPtr, 100666642);
				GameInput.__c.NativeMethodInfoPtr__Start_b__17_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput.__c>.NativeClassPtr, 100666643);
			}

			// Token: 0x0600C2E1 RID: 49889 RVA: 0x002F94B0 File Offset: 0x002F76B0
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameInput.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C2E2 RID: 49890 RVA: 0x002F94EC File Offset: 0x002F76EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105113, XrefRangeEnd = 105119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__17_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.__c.NativeMethodInfoPtr__Start_b__17_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C2E3 RID: 49891 RVA: 0x0005ED4B File Offset: 0x0005CF4B
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CD8 RID: 15576
			// (get) Token: 0x0600C2E4 RID: 49892 RVA: 0x002F9520 File Offset: 0x002F7720
			// (set) Token: 0x0600C2E5 RID: 49893 RVA: 0x0005ED54 File Offset: 0x0005CF54
			public unsafe static GameInput.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GameInput.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameInput.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GameInput.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CD9 RID: 15577
			// (get) Token: 0x0600C2E6 RID: 49894 RVA: 0x002F9548 File Offset: 0x002F7748
			// (set) Token: 0x0600C2E7 RID: 49895 RVA: 0x0005ED66 File Offset: 0x0005CF66
			public unsafe static UnityAction __9__17_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GameInput.__c.NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GameInput.__c.NativeFieldInfoPtr___9__17_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400840B RID: 33803
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400840C RID: 33804
			private static readonly IntPtr NativeFieldInfoPtr___9__17_0;

			// Token: 0x0400840D RID: 33805
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400840E RID: 33806
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__17_0_Internal_Void_0;
		}
	}
}
