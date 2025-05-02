using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Doors
{
	// Token: 0x02000424 RID: 1060
	public class DoorController : NetworkBehaviour
	{
		// Token: 0x06005D0D RID: 23821 RVA: 0x001AE0C0 File Offset: 0x001AC2C0
		// Note: this type is marked as 'beforefieldinit'.
		static DoorController()
		{
			Il2CppClassPointerStore<DoorController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Doors", "DoorController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoorController>.NativeClassPtr);
			DoorController.NativeFieldInfoPtr_DISTANT_PLAYER_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "DISTANT_PLAYER_THRESHOLD");
			DoorController.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "<IsOpen>k__BackingField");
			DoorController.NativeFieldInfoPtr_PlayerAccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "PlayerAccess");
			DoorController.NativeFieldInfoPtr_AutoOpenForPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "AutoOpenForPlayer");
			DoorController.NativeFieldInfoPtr_InteriorIntObjs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "InteriorIntObjs");
			DoorController.NativeFieldInfoPtr_ExteriorIntObjs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "ExteriorIntObjs");
			DoorController.NativeFieldInfoPtr_PlayerBlocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "PlayerBlocker");
			DoorController.NativeFieldInfoPtr_InteriorDoorHandleAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "InteriorDoorHandleAnimation");
			DoorController.NativeFieldInfoPtr_ExteriorDoorHandleAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "ExteriorDoorHandleAnimation");
			DoorController.NativeFieldInfoPtr_AutoCloseOnSleep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "AutoCloseOnSleep");
			DoorController.NativeFieldInfoPtr_AutoCloseOnDistantPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "AutoCloseOnDistantPlayer");
			DoorController.NativeFieldInfoPtr_OpenableByNPCs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "OpenableByNPCs");
			DoorController.NativeFieldInfoPtr_ReturnToOriginalTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "ReturnToOriginalTime");
			DoorController.NativeFieldInfoPtr_onDoorOpened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "onDoorOpened");
			DoorController.NativeFieldInfoPtr_onDoorClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "onDoorClosed");
			DoorController.NativeFieldInfoPtr_lastOpenSide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "lastOpenSide");
			DoorController.NativeFieldInfoPtr__openedByNPC_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "<openedByNPC>k__BackingField");
			DoorController.NativeFieldInfoPtr__timeSinceNPCSensed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "<timeSinceNPCSensed>k__BackingField");
			DoorController.NativeFieldInfoPtr_autoOpenedForPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "autoOpenedForPlayer");
			DoorController.NativeFieldInfoPtr__playerDetectedSinceOpened_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "<playerDetectedSinceOpened>k__BackingField");
			DoorController.NativeFieldInfoPtr__timeSincePlayerSensed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "<timeSincePlayerSensed>k__BackingField");
			DoorController.NativeFieldInfoPtr__timeInCurrentState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "<timeInCurrentState>k__BackingField");
			DoorController.NativeFieldInfoPtr_noAccessErrorMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "noAccessErrorMessage");
			DoorController.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Doors.DoorControllerAssembly-CSharp.dll_Excuted");
			DoorController.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Doors.DoorControllerAssembly-CSharp.dll_Excuted");
			DoorController.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675155);
			DoorController.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675156);
			DoorController.NativeMethodInfoPtr_get_openedByNPC_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675157);
			DoorController.NativeMethodInfoPtr_set_openedByNPC_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675158);
			DoorController.NativeMethodInfoPtr_get_timeSinceNPCSensed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675159);
			DoorController.NativeMethodInfoPtr_set_timeSinceNPCSensed_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675160);
			DoorController.NativeMethodInfoPtr_get_playerDetectedSinceOpened_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675161);
			DoorController.NativeMethodInfoPtr_set_playerDetectedSinceOpened_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675162);
			DoorController.NativeMethodInfoPtr_get_timeSincePlayerSensed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675163);
			DoorController.NativeMethodInfoPtr_set_timeSincePlayerSensed_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675164);
			DoorController.NativeMethodInfoPtr_get_timeInCurrentState_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675165);
			DoorController.NativeMethodInfoPtr_set_timeInCurrentState_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675166);
			DoorController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675167);
			DoorController.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675168);
			DoorController.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675169);
			DoorController.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675170);
			DoorController.NativeMethodInfoPtr_InteriorHandleHovered_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675171);
			DoorController.NativeMethodInfoPtr_InteriorHandleInteracted_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675172);
			DoorController.NativeMethodInfoPtr_ExteriorHandleHovered_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675173);
			DoorController.NativeMethodInfoPtr_ExteriorHandleInteracted_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675174);
			DoorController.NativeMethodInfoPtr_CanPlayerAccess_Public_Boolean_EDoorSide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675175);
			DoorController.NativeMethodInfoPtr_CanPlayerAccess_Protected_Virtual_New_Boolean_EDoorSide_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675176);
			DoorController.NativeMethodInfoPtr_NPCVicinityDetected_Public_Virtual_New_Void_EDoorSide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675177);
			DoorController.NativeMethodInfoPtr_PlayerVicinityDetected_Public_Virtual_New_Void_EDoorSide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675178);
			DoorController.NativeMethodInfoPtr_SetIsOpen_Server_Public_Void_Boolean_EDoorSide_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675179);
			DoorController.NativeMethodInfoPtr_SetIsOpen_Public_Void_NetworkConnection_Boolean_EDoorSide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675180);
			DoorController.NativeMethodInfoPtr_SetIsOpen_Public_Virtual_New_Void_Boolean_EDoorSide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675181);
			DoorController.NativeMethodInfoPtr_CheckAutoCloseForDistantPlayer_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675182);
			DoorController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675183);
			DoorController.NativeMethodInfoPtr__Start_b__42_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675184);
			DoorController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675185);
			DoorController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675186);
			DoorController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675187);
			DoorController.NativeMethodInfoPtr_RpcWriter___Server_SetIsOpen_Server_1319291243_Private_Void_Boolean_EDoorSide_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675188);
			DoorController.NativeMethodInfoPtr_RpcLogic___SetIsOpen_Server_1319291243_Public_Void_Boolean_EDoorSide_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675189);
			DoorController.NativeMethodInfoPtr_RpcReader___Server_SetIsOpen_Server_1319291243_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675190);
			DoorController.NativeMethodInfoPtr_RpcWriter___Observers_SetIsOpen_3381113727_Private_Void_NetworkConnection_Boolean_EDoorSide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675191);
			DoorController.NativeMethodInfoPtr_RpcLogic___SetIsOpen_3381113727_Public_Void_NetworkConnection_Boolean_EDoorSide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675192);
			DoorController.NativeMethodInfoPtr_RpcReader___Observers_SetIsOpen_3381113727_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675193);
			DoorController.NativeMethodInfoPtr_RpcWriter___Target_SetIsOpen_3381113727_Private_Void_NetworkConnection_Boolean_EDoorSide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675194);
			DoorController.NativeMethodInfoPtr_RpcReader___Target_SetIsOpen_3381113727_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675195);
			DoorController.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675196);
		}

		// Token: 0x17001C18 RID: 7192
		// (get) Token: 0x06005D0E RID: 23822 RVA: 0x001AE62C File Offset: 0x001AC82C
		// (set) Token: 0x06005D0F RID: 23823 RVA: 0x001AE668 File Offset: 0x001AC868
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001C19 RID: 7193
		// (get) Token: 0x06005D10 RID: 23824 RVA: 0x001AE6A8 File Offset: 0x001AC8A8
		// (set) Token: 0x06005D11 RID: 23825 RVA: 0x001AE6E4 File Offset: 0x001AC8E4
		public unsafe bool openedByNPC
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_get_openedByNPC_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_set_openedByNPC_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001C1A RID: 7194
		// (get) Token: 0x06005D12 RID: 23826 RVA: 0x001AE724 File Offset: 0x001AC924
		// (set) Token: 0x06005D13 RID: 23827 RVA: 0x001AE760 File Offset: 0x001AC960
		public unsafe float timeSinceNPCSensed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_get_timeSinceNPCSensed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_set_timeSinceNPCSensed_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001C1B RID: 7195
		// (get) Token: 0x06005D14 RID: 23828 RVA: 0x001AE7A0 File Offset: 0x001AC9A0
		// (set) Token: 0x06005D15 RID: 23829 RVA: 0x001AE7DC File Offset: 0x001AC9DC
		public unsafe bool playerDetectedSinceOpened
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_get_playerDetectedSinceOpened_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_set_playerDetectedSinceOpened_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001C1C RID: 7196
		// (get) Token: 0x06005D16 RID: 23830 RVA: 0x001AE81C File Offset: 0x001ACA1C
		// (set) Token: 0x06005D17 RID: 23831 RVA: 0x001AE858 File Offset: 0x001ACA58
		public unsafe float timeSincePlayerSensed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_get_timeSincePlayerSensed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_set_timeSincePlayerSensed_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001C1D RID: 7197
		// (get) Token: 0x06005D18 RID: 23832 RVA: 0x001AE898 File Offset: 0x001ACA98
		// (set) Token: 0x06005D19 RID: 23833 RVA: 0x001AE8D4 File Offset: 0x001ACAD4
		public unsafe float timeInCurrentState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_get_timeInCurrentState_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_set_timeInCurrentState_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005D1A RID: 23834 RVA: 0x001AE914 File Offset: 0x001ACB14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 195825, RefRangeEnd = 195827, XrefRangeStart = 195824, XrefRangeEnd = 195825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D1B RID: 23835 RVA: 0x001AE950 File Offset: 0x001ACB50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195827, XrefRangeEnd = 195843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D1C RID: 23836 RVA: 0x001AE98C File Offset: 0x001ACB8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195843, XrefRangeEnd = 195849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D1D RID: 23837 RVA: 0x001AE9C8 File Offset: 0x001ACBC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195849, XrefRangeEnd = 195851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D1E RID: 23838 RVA: 0x001AEA18 File Offset: 0x001ACC18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195851, XrefRangeEnd = 195863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InteriorHandleHovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_InteriorHandleHovered_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D1F RID: 23839 RVA: 0x001AEA54 File Offset: 0x001ACC54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195863, XrefRangeEnd = 195869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InteriorHandleInteracted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_InteriorHandleInteracted_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D20 RID: 23840 RVA: 0x001AEA90 File Offset: 0x001ACC90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195869, XrefRangeEnd = 195881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ExteriorHandleHovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_ExteriorHandleHovered_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D21 RID: 23841 RVA: 0x001AEACC File Offset: 0x001ACCCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195881, XrefRangeEnd = 195887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ExteriorHandleInteracted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_ExteriorHandleInteracted_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D22 RID: 23842 RVA: 0x001AEB08 File Offset: 0x001ACD08
		[CallerCount(0)]
		public unsafe bool CanPlayerAccess(EDoorSide side)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref side;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_CanPlayerAccess_Public_Boolean_EDoorSide_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005D23 RID: 23843 RVA: 0x001AEB54 File Offset: 0x001ACD54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195888, RefRangeEnd = 195889, XrefRangeStart = 195887, XrefRangeEnd = 195888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanPlayerAccess(EDoorSide side, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref side;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_CanPlayerAccess_Protected_Virtual_New_Boolean_EDoorSide_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005D24 RID: 23844 RVA: 0x001AEBC4 File Offset: 0x001ACDC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195889, XrefRangeEnd = 195892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NPCVicinityDetected(EDoorSide side)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref side;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_NPCVicinityDetected_Public_Virtual_New_Void_EDoorSide_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D25 RID: 23845 RVA: 0x001AEC10 File Offset: 0x001ACE10
		[CallerCount(0)]
		public unsafe virtual void PlayerVicinityDetected(EDoorSide side)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref side;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_PlayerVicinityDetected_Public_Virtual_New_Void_EDoorSide_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D26 RID: 23846 RVA: 0x001AEC5C File Offset: 0x001ACE5C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 195916, RefRangeEnd = 195922, XrefRangeStart = 195892, XrefRangeEnd = 195916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen_Server(bool open, EDoorSide accessSide, bool openedForPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref accessSide;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref openedForPlayer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_SetIsOpen_Server_Public_Void_Boolean_EDoorSide_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D27 RID: 23847 RVA: 0x001AECB8 File Offset: 0x001ACEB8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 195965, RefRangeEnd = 195970, XrefRangeStart = 195922, XrefRangeEnd = 195965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(NetworkConnection conn, bool open, EDoorSide openSide)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref open;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref openSide;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_SetIsOpen_Public_Void_NetworkConnection_Boolean_EDoorSide_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D28 RID: 23848 RVA: 0x001AED18 File Offset: 0x001ACF18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195970, XrefRangeEnd = 195975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetIsOpen(bool open, EDoorSide openSide)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref openSide;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_SetIsOpen_Public_Virtual_New_Void_Boolean_EDoorSide_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D29 RID: 23849 RVA: 0x001AED70 File Offset: 0x001ACF70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195975, XrefRangeEnd = 195983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CheckAutoCloseForDistantPlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_CheckAutoCloseForDistantPlayer_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D2A RID: 23850 RVA: 0x001AEDAC File Offset: 0x001ACFAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195987, RefRangeEnd = 195988, XrefRangeStart = 195983, XrefRangeEnd = 195987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DoorController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoorController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D2B RID: 23851 RVA: 0x001AEDE8 File Offset: 0x001ACFE8
		[CallerCount(0)]
		public unsafe void _Start_b__42_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr__Start_b__42_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D2C RID: 23852 RVA: 0x001AEE1C File Offset: 0x001AD01C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 196008, RefRangeEnd = 196009, XrefRangeStart = 195988, XrefRangeEnd = 196008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D2D RID: 23853 RVA: 0x001AEE58 File Offset: 0x001AD058
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 112902, RefRangeEnd = 112903, XrefRangeStart = 112902, XrefRangeEnd = 112903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D2E RID: 23854 RVA: 0x001AEE94 File Offset: 0x001AD094
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D2F RID: 23855 RVA: 0x001AEED0 File Offset: 0x001AD0D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196009, XrefRangeEnd = 196021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetIsOpen_Server_1319291243(bool open, EDoorSide accessSide, bool openedForPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref accessSide;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref openedForPlayer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_RpcWriter___Server_SetIsOpen_Server_1319291243_Private_Void_Boolean_EDoorSide_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D30 RID: 23856 RVA: 0x001AEF2C File Offset: 0x001AD12C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196021, XrefRangeEnd = 196022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetIsOpen_Server_1319291243(bool open, EDoorSide accessSide, bool openedForPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref accessSide;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref openedForPlayer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_RpcLogic___SetIsOpen_Server_1319291243_Public_Void_Boolean_EDoorSide_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D31 RID: 23857 RVA: 0x001AEF88 File Offset: 0x001AD188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196022, XrefRangeEnd = 196026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetIsOpen_Server_1319291243(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_RpcReader___Server_SetIsOpen_Server_1319291243_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D32 RID: 23858 RVA: 0x001AEFEC File Offset: 0x001AD1EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196026, XrefRangeEnd = 196046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetIsOpen_3381113727(NetworkConnection conn, bool open, EDoorSide openSide)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref open;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref openSide;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_RpcWriter___Observers_SetIsOpen_3381113727_Private_Void_NetworkConnection_Boolean_EDoorSide_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D33 RID: 23859 RVA: 0x001AF04C File Offset: 0x001AD24C
		[CallerCount(0)]
		public unsafe void RpcLogic___SetIsOpen_3381113727(NetworkConnection conn, bool open, EDoorSide openSide)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref open;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref openSide;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_RpcLogic___SetIsOpen_3381113727_Public_Void_NetworkConnection_Boolean_EDoorSide_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D34 RID: 23860 RVA: 0x001AF0AC File Offset: 0x001AD2AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196046, XrefRangeEnd = 196049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetIsOpen_3381113727(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_RpcReader___Observers_SetIsOpen_3381113727_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D35 RID: 23861 RVA: 0x001AF0FC File Offset: 0x001AD2FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196049, XrefRangeEnd = 196060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetIsOpen_3381113727(NetworkConnection conn, bool open, EDoorSide openSide)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref open;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref openSide;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_RpcWriter___Target_SetIsOpen_3381113727_Private_Void_NetworkConnection_Boolean_EDoorSide_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D36 RID: 23862 RVA: 0x001AF15C File Offset: 0x001AD35C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196060, XrefRangeEnd = 196063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetIsOpen_3381113727(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_RpcReader___Target_SetIsOpen_3381113727_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D37 RID: 23863 RVA: 0x001AF1AC File Offset: 0x001AD3AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 196103, RefRangeEnd = 196104, XrefRangeStart = 196063, XrefRangeEnd = 196103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D38 RID: 23864 RVA: 0x0002BDB3 File Offset: 0x00029FB3
		public DoorController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001BFF RID: 7167
		// (get) Token: 0x06005D39 RID: 23865 RVA: 0x001AF1E8 File Offset: 0x001AD3E8
		// (set) Token: 0x06005D3A RID: 23866 RVA: 0x0002BDBC File Offset: 0x00029FBC
		public unsafe static float DISTANT_PLAYER_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DoorController.NativeFieldInfoPtr_DISTANT_PLAYER_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DoorController.NativeFieldInfoPtr_DISTANT_PLAYER_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17001C00 RID: 7168
		// (get) Token: 0x06005D3B RID: 23867 RVA: 0x001AF204 File Offset: 0x001AD404
		// (set) Token: 0x06005D3C RID: 23868 RVA: 0x0002BDCA File Offset: 0x00029FCA
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17001C01 RID: 7169
		// (get) Token: 0x06005D3D RID: 23869 RVA: 0x001AF22C File Offset: 0x001AD42C
		// (set) Token: 0x06005D3E RID: 23870 RVA: 0x0002BDE5 File Offset: 0x00029FE5
		public unsafe EDoorAccess PlayerAccess
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_PlayerAccess);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_PlayerAccess)) = value;
			}
		}

		// Token: 0x17001C02 RID: 7170
		// (get) Token: 0x06005D3F RID: 23871 RVA: 0x001AF254 File Offset: 0x001AD454
		// (set) Token: 0x06005D40 RID: 23872 RVA: 0x0002BE00 File Offset: 0x0002A000
		public unsafe bool AutoOpenForPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_AutoOpenForPlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_AutoOpenForPlayer)) = value;
			}
		}

		// Token: 0x17001C03 RID: 7171
		// (get) Token: 0x06005D41 RID: 23873 RVA: 0x001AF27C File Offset: 0x001AD47C
		// (set) Token: 0x06005D42 RID: 23874 RVA: 0x0002BE1B File Offset: 0x0002A01B
		public unsafe Il2CppReferenceArray<InteractableObject> InteriorIntObjs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_InteriorIntObjs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InteractableObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_InteriorIntObjs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C04 RID: 7172
		// (get) Token: 0x06005D43 RID: 23875 RVA: 0x001AF2AC File Offset: 0x001AD4AC
		// (set) Token: 0x06005D44 RID: 23876 RVA: 0x0002BE3A File Offset: 0x0002A03A
		public unsafe Il2CppReferenceArray<InteractableObject> ExteriorIntObjs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_ExteriorIntObjs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InteractableObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_ExteriorIntObjs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C05 RID: 7173
		// (get) Token: 0x06005D45 RID: 23877 RVA: 0x001AF2DC File Offset: 0x001AD4DC
		// (set) Token: 0x06005D46 RID: 23878 RVA: 0x0002BE59 File Offset: 0x0002A059
		public unsafe BoxCollider PlayerBlocker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_PlayerBlocker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_PlayerBlocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C06 RID: 7174
		// (get) Token: 0x06005D47 RID: 23879 RVA: 0x001AF30C File Offset: 0x001AD50C
		// (set) Token: 0x06005D48 RID: 23880 RVA: 0x0002BE78 File Offset: 0x0002A078
		public unsafe Animation InteriorDoorHandleAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_InteriorDoorHandleAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_InteriorDoorHandleAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C07 RID: 7175
		// (get) Token: 0x06005D49 RID: 23881 RVA: 0x001AF33C File Offset: 0x001AD53C
		// (set) Token: 0x06005D4A RID: 23882 RVA: 0x0002BE97 File Offset: 0x0002A097
		public unsafe Animation ExteriorDoorHandleAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_ExteriorDoorHandleAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_ExteriorDoorHandleAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C08 RID: 7176
		// (get) Token: 0x06005D4B RID: 23883 RVA: 0x001AF36C File Offset: 0x001AD56C
		// (set) Token: 0x06005D4C RID: 23884 RVA: 0x0002BEB6 File Offset: 0x0002A0B6
		public unsafe bool AutoCloseOnSleep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_AutoCloseOnSleep);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_AutoCloseOnSleep)) = value;
			}
		}

		// Token: 0x17001C09 RID: 7177
		// (get) Token: 0x06005D4D RID: 23885 RVA: 0x001AF394 File Offset: 0x001AD594
		// (set) Token: 0x06005D4E RID: 23886 RVA: 0x0002BED1 File Offset: 0x0002A0D1
		public unsafe bool AutoCloseOnDistantPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_AutoCloseOnDistantPlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_AutoCloseOnDistantPlayer)) = value;
			}
		}

		// Token: 0x17001C0A RID: 7178
		// (get) Token: 0x06005D4F RID: 23887 RVA: 0x001AF3BC File Offset: 0x001AD5BC
		// (set) Token: 0x06005D50 RID: 23888 RVA: 0x0002BEEC File Offset: 0x0002A0EC
		public unsafe bool OpenableByNPCs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_OpenableByNPCs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_OpenableByNPCs)) = value;
			}
		}

		// Token: 0x17001C0B RID: 7179
		// (get) Token: 0x06005D51 RID: 23889 RVA: 0x001AF3E4 File Offset: 0x001AD5E4
		// (set) Token: 0x06005D52 RID: 23890 RVA: 0x0002BF07 File Offset: 0x0002A107
		public unsafe float ReturnToOriginalTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_ReturnToOriginalTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_ReturnToOriginalTime)) = value;
			}
		}

		// Token: 0x17001C0C RID: 7180
		// (get) Token: 0x06005D53 RID: 23891 RVA: 0x001AF40C File Offset: 0x001AD60C
		// (set) Token: 0x06005D54 RID: 23892 RVA: 0x0002BF22 File Offset: 0x0002A122
		public unsafe UnityEvent<EDoorSide> onDoorOpened
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_onDoorOpened);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<EDoorSide>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_onDoorOpened), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C0D RID: 7181
		// (get) Token: 0x06005D55 RID: 23893 RVA: 0x001AF43C File Offset: 0x001AD63C
		// (set) Token: 0x06005D56 RID: 23894 RVA: 0x0002BF41 File Offset: 0x0002A141
		public unsafe UnityEvent onDoorClosed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_onDoorClosed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_onDoorClosed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C0E RID: 7182
		// (get) Token: 0x06005D57 RID: 23895 RVA: 0x001AF46C File Offset: 0x001AD66C
		// (set) Token: 0x06005D58 RID: 23896 RVA: 0x0002BF60 File Offset: 0x0002A160
		public unsafe EDoorSide lastOpenSide
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_lastOpenSide);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_lastOpenSide)) = value;
			}
		}

		// Token: 0x17001C0F RID: 7183
		// (get) Token: 0x06005D59 RID: 23897 RVA: 0x001AF494 File Offset: 0x001AD694
		// (set) Token: 0x06005D5A RID: 23898 RVA: 0x0002BF7B File Offset: 0x0002A17B
		public unsafe bool _openedByNPC_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__openedByNPC_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__openedByNPC_k__BackingField)) = value;
			}
		}

		// Token: 0x17001C10 RID: 7184
		// (get) Token: 0x06005D5B RID: 23899 RVA: 0x001AF4BC File Offset: 0x001AD6BC
		// (set) Token: 0x06005D5C RID: 23900 RVA: 0x0002BF96 File Offset: 0x0002A196
		public unsafe float _timeSinceNPCSensed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__timeSinceNPCSensed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__timeSinceNPCSensed_k__BackingField)) = value;
			}
		}

		// Token: 0x17001C11 RID: 7185
		// (get) Token: 0x06005D5D RID: 23901 RVA: 0x001AF4E4 File Offset: 0x001AD6E4
		// (set) Token: 0x06005D5E RID: 23902 RVA: 0x0002BFB1 File Offset: 0x0002A1B1
		public unsafe bool autoOpenedForPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_autoOpenedForPlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_autoOpenedForPlayer)) = value;
			}
		}

		// Token: 0x17001C12 RID: 7186
		// (get) Token: 0x06005D5F RID: 23903 RVA: 0x001AF50C File Offset: 0x001AD70C
		// (set) Token: 0x06005D60 RID: 23904 RVA: 0x0002BFCC File Offset: 0x0002A1CC
		public unsafe bool _playerDetectedSinceOpened_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__playerDetectedSinceOpened_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__playerDetectedSinceOpened_k__BackingField)) = value;
			}
		}

		// Token: 0x17001C13 RID: 7187
		// (get) Token: 0x06005D61 RID: 23905 RVA: 0x001AF534 File Offset: 0x001AD734
		// (set) Token: 0x06005D62 RID: 23906 RVA: 0x0002BFE7 File Offset: 0x0002A1E7
		public unsafe float _timeSincePlayerSensed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__timeSincePlayerSensed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__timeSincePlayerSensed_k__BackingField)) = value;
			}
		}

		// Token: 0x17001C14 RID: 7188
		// (get) Token: 0x06005D63 RID: 23907 RVA: 0x001AF55C File Offset: 0x001AD75C
		// (set) Token: 0x06005D64 RID: 23908 RVA: 0x0002C002 File Offset: 0x0002A202
		public unsafe float _timeInCurrentState_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__timeInCurrentState_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__timeInCurrentState_k__BackingField)) = value;
			}
		}

		// Token: 0x17001C15 RID: 7189
		// (get) Token: 0x06005D65 RID: 23909 RVA: 0x001AF584 File Offset: 0x001AD784
		// (set) Token: 0x06005D66 RID: 23910 RVA: 0x0002C01D File Offset: 0x0002A21D
		public unsafe string noAccessErrorMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_noAccessErrorMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_noAccessErrorMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001C16 RID: 7190
		// (get) Token: 0x06005D67 RID: 23911 RVA: 0x001AF5AC File Offset: 0x001AD7AC
		// (set) Token: 0x06005D68 RID: 23912 RVA: 0x0002C03C File Offset: 0x0002A23C
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001C17 RID: 7191
		// (get) Token: 0x06005D69 RID: 23913 RVA: 0x001AF5D4 File Offset: 0x001AD7D4
		// (set) Token: 0x06005D6A RID: 23914 RVA: 0x0002C057 File Offset: 0x0002A257
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003FAF RID: 16303
		private static readonly IntPtr NativeFieldInfoPtr_DISTANT_PLAYER_THRESHOLD;

		// Token: 0x04003FB0 RID: 16304
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04003FB1 RID: 16305
		private static readonly IntPtr NativeFieldInfoPtr_PlayerAccess;

		// Token: 0x04003FB2 RID: 16306
		private static readonly IntPtr NativeFieldInfoPtr_AutoOpenForPlayer;

		// Token: 0x04003FB3 RID: 16307
		private static readonly IntPtr NativeFieldInfoPtr_InteriorIntObjs;

		// Token: 0x04003FB4 RID: 16308
		private static readonly IntPtr NativeFieldInfoPtr_ExteriorIntObjs;

		// Token: 0x04003FB5 RID: 16309
		private static readonly IntPtr NativeFieldInfoPtr_PlayerBlocker;

		// Token: 0x04003FB6 RID: 16310
		private static readonly IntPtr NativeFieldInfoPtr_InteriorDoorHandleAnimation;

		// Token: 0x04003FB7 RID: 16311
		private static readonly IntPtr NativeFieldInfoPtr_ExteriorDoorHandleAnimation;

		// Token: 0x04003FB8 RID: 16312
		private static readonly IntPtr NativeFieldInfoPtr_AutoCloseOnSleep;

		// Token: 0x04003FB9 RID: 16313
		private static readonly IntPtr NativeFieldInfoPtr_AutoCloseOnDistantPlayer;

		// Token: 0x04003FBA RID: 16314
		private static readonly IntPtr NativeFieldInfoPtr_OpenableByNPCs;

		// Token: 0x04003FBB RID: 16315
		private static readonly IntPtr NativeFieldInfoPtr_ReturnToOriginalTime;

		// Token: 0x04003FBC RID: 16316
		private static readonly IntPtr NativeFieldInfoPtr_onDoorOpened;

		// Token: 0x04003FBD RID: 16317
		private static readonly IntPtr NativeFieldInfoPtr_onDoorClosed;

		// Token: 0x04003FBE RID: 16318
		private static readonly IntPtr NativeFieldInfoPtr_lastOpenSide;

		// Token: 0x04003FBF RID: 16319
		private static readonly IntPtr NativeFieldInfoPtr__openedByNPC_k__BackingField;

		// Token: 0x04003FC0 RID: 16320
		private static readonly IntPtr NativeFieldInfoPtr__timeSinceNPCSensed_k__BackingField;

		// Token: 0x04003FC1 RID: 16321
		private static readonly IntPtr NativeFieldInfoPtr_autoOpenedForPlayer;

		// Token: 0x04003FC2 RID: 16322
		private static readonly IntPtr NativeFieldInfoPtr__playerDetectedSinceOpened_k__BackingField;

		// Token: 0x04003FC3 RID: 16323
		private static readonly IntPtr NativeFieldInfoPtr__timeSincePlayerSensed_k__BackingField;

		// Token: 0x04003FC4 RID: 16324
		private static readonly IntPtr NativeFieldInfoPtr__timeInCurrentState_k__BackingField;

		// Token: 0x04003FC5 RID: 16325
		private static readonly IntPtr NativeFieldInfoPtr_noAccessErrorMessage;

		// Token: 0x04003FC6 RID: 16326
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003FC7 RID: 16327
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003FC8 RID: 16328
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04003FC9 RID: 16329
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04003FCA RID: 16330
		private static readonly IntPtr NativeMethodInfoPtr_get_openedByNPC_Public_get_Boolean_0;

		// Token: 0x04003FCB RID: 16331
		private static readonly IntPtr NativeMethodInfoPtr_set_openedByNPC_Protected_set_Void_Boolean_0;

		// Token: 0x04003FCC RID: 16332
		private static readonly IntPtr NativeMethodInfoPtr_get_timeSinceNPCSensed_Public_get_Single_0;

		// Token: 0x04003FCD RID: 16333
		private static readonly IntPtr NativeMethodInfoPtr_set_timeSinceNPCSensed_Protected_set_Void_Single_0;

		// Token: 0x04003FCE RID: 16334
		private static readonly IntPtr NativeMethodInfoPtr_get_playerDetectedSinceOpened_Public_get_Boolean_0;

		// Token: 0x04003FCF RID: 16335
		private static readonly IntPtr NativeMethodInfoPtr_set_playerDetectedSinceOpened_Protected_set_Void_Boolean_0;

		// Token: 0x04003FD0 RID: 16336
		private static readonly IntPtr NativeMethodInfoPtr_get_timeSincePlayerSensed_Public_get_Single_0;

		// Token: 0x04003FD1 RID: 16337
		private static readonly IntPtr NativeMethodInfoPtr_set_timeSincePlayerSensed_Protected_set_Void_Single_0;

		// Token: 0x04003FD2 RID: 16338
		private static readonly IntPtr NativeMethodInfoPtr_get_timeInCurrentState_Public_get_Single_0;

		// Token: 0x04003FD3 RID: 16339
		private static readonly IntPtr NativeMethodInfoPtr_set_timeInCurrentState_Protected_set_Void_Single_0;

		// Token: 0x04003FD4 RID: 16340
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04003FD5 RID: 16341
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1;

		// Token: 0x04003FD6 RID: 16342
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1;

		// Token: 0x04003FD7 RID: 16343
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04003FD8 RID: 16344
		private static readonly IntPtr NativeMethodInfoPtr_InteriorHandleHovered_Public_Virtual_New_Void_0;

		// Token: 0x04003FD9 RID: 16345
		private static readonly IntPtr NativeMethodInfoPtr_InteriorHandleInteracted_Public_Virtual_New_Void_0;

		// Token: 0x04003FDA RID: 16346
		private static readonly IntPtr NativeMethodInfoPtr_ExteriorHandleHovered_Public_Virtual_New_Void_0;

		// Token: 0x04003FDB RID: 16347
		private static readonly IntPtr NativeMethodInfoPtr_ExteriorHandleInteracted_Public_Virtual_New_Void_0;

		// Token: 0x04003FDC RID: 16348
		private static readonly IntPtr NativeMethodInfoPtr_CanPlayerAccess_Public_Boolean_EDoorSide_0;

		// Token: 0x04003FDD RID: 16349
		private static readonly IntPtr NativeMethodInfoPtr_CanPlayerAccess_Protected_Virtual_New_Boolean_EDoorSide_byref_String_0;

		// Token: 0x04003FDE RID: 16350
		private static readonly IntPtr NativeMethodInfoPtr_NPCVicinityDetected_Public_Virtual_New_Void_EDoorSide_0;

		// Token: 0x04003FDF RID: 16351
		private static readonly IntPtr NativeMethodInfoPtr_PlayerVicinityDetected_Public_Virtual_New_Void_EDoorSide_0;

		// Token: 0x04003FE0 RID: 16352
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Server_Public_Void_Boolean_EDoorSide_Boolean_0;

		// Token: 0x04003FE1 RID: 16353
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_NetworkConnection_Boolean_EDoorSide_0;

		// Token: 0x04003FE2 RID: 16354
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Virtual_New_Void_Boolean_EDoorSide_0;

		// Token: 0x04003FE3 RID: 16355
		private static readonly IntPtr NativeMethodInfoPtr_CheckAutoCloseForDistantPlayer_Protected_Virtual_New_Void_1;

		// Token: 0x04003FE4 RID: 16356
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003FE5 RID: 16357
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__42_0_Private_Void_0;

		// Token: 0x04003FE6 RID: 16358
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003FE7 RID: 16359
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003FE8 RID: 16360
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003FE9 RID: 16361
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetIsOpen_Server_1319291243_Private_Void_Boolean_EDoorSide_Boolean_0;

		// Token: 0x04003FEA RID: 16362
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetIsOpen_Server_1319291243_Public_Void_Boolean_EDoorSide_Boolean_0;

		// Token: 0x04003FEB RID: 16363
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetIsOpen_Server_1319291243_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003FEC RID: 16364
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetIsOpen_3381113727_Private_Void_NetworkConnection_Boolean_EDoorSide_0;

		// Token: 0x04003FED RID: 16365
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetIsOpen_3381113727_Public_Void_NetworkConnection_Boolean_EDoorSide_0;

		// Token: 0x04003FEE RID: 16366
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetIsOpen_3381113727_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003FEF RID: 16367
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetIsOpen_3381113727_Private_Void_NetworkConnection_Boolean_EDoorSide_0;

		// Token: 0x04003FF0 RID: 16368
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetIsOpen_3381113727_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003FF1 RID: 16369
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;
	}
}
