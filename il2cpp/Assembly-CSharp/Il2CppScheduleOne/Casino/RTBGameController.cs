using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Casino
{
	// Token: 0x020004A7 RID: 1191
	public class RTBGameController : CasinoGameController
	{
		// Token: 0x060067EF RID: 26607 RVA: 0x001D33B8 File Offset: 0x001D15B8
		// Note: this type is marked as 'beforefieldinit'.
		static RTBGameController()
		{
			Il2CppClassPointerStore<RTBGameController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino", "RTBGameController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr);
			RTBGameController.NativeFieldInfoPtr_BET_MINIMUM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "BET_MINIMUM");
			RTBGameController.NativeFieldInfoPtr_BET_MAXIMUM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "BET_MAXIMUM");
			RTBGameController.NativeFieldInfoPtr_ANSWER_MAX_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "ANSWER_MAX_TIME");
			RTBGameController.NativeFieldInfoPtr_PlayCameraTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "PlayCameraTransform");
			RTBGameController.NativeFieldInfoPtr_FocusedCameraTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "FocusedCameraTransform");
			RTBGameController.NativeFieldInfoPtr_Cards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "Cards");
			RTBGameController.NativeFieldInfoPtr_CardDefaultPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "CardDefaultPositions");
			RTBGameController.NativeFieldInfoPtr_ActiveCardPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "ActiveCardPosition");
			RTBGameController.NativeFieldInfoPtr_DockedCardPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "DockedCardPositions");
			RTBGameController.NativeFieldInfoPtr__CurrentStage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "<CurrentStage>k__BackingField");
			RTBGameController.NativeFieldInfoPtr_onStageChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "onStageChange");
			RTBGameController.NativeFieldInfoPtr_onQuestionReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "onQuestionReady");
			RTBGameController.NativeFieldInfoPtr_onQuestionDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "onQuestionDone");
			RTBGameController.NativeFieldInfoPtr_onLocalPlayerCorrect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "onLocalPlayerCorrect");
			RTBGameController.NativeFieldInfoPtr_onLocalPlayerIncorrect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "onLocalPlayerIncorrect");
			RTBGameController.NativeFieldInfoPtr_onLocalPlayerBetChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "onLocalPlayerBetChange");
			RTBGameController.NativeFieldInfoPtr_onLocalPlayerExitRound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "onLocalPlayerExitRound");
			RTBGameController.NativeFieldInfoPtr__IsQuestionActive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "<IsQuestionActive>k__BackingField");
			RTBGameController.NativeFieldInfoPtr__LocalPlayerBet_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "<LocalPlayerBet>k__BackingField");
			RTBGameController.NativeFieldInfoPtr__LocalPlayerBetMultiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "<LocalPlayerBetMultiplier>k__BackingField");
			RTBGameController.NativeFieldInfoPtr__RemainingAnswerTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "<RemainingAnswerTime>k__BackingField");
			RTBGameController.NativeFieldInfoPtr_playersInCurrentRound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "playersInCurrentRound");
			RTBGameController.NativeFieldInfoPtr_cardsInDeck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "cardsInDeck");
			RTBGameController.NativeFieldInfoPtr_drawnCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "drawnCards");
			RTBGameController.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Casino.RTBGameControllerAssembly-CSharp.dll_Excuted");
			RTBGameController.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Casino.RTBGameControllerAssembly-CSharp.dll_Excuted");
			RTBGameController.NativeMethodInfoPtr_get_CurrentStage_Public_get_EStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676500);
			RTBGameController.NativeMethodInfoPtr_set_CurrentStage_Private_set_Void_EStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676501);
			RTBGameController.NativeMethodInfoPtr_get_IsQuestionActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676502);
			RTBGameController.NativeMethodInfoPtr_set_IsQuestionActive_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676503);
			RTBGameController.NativeMethodInfoPtr_get_LocalPlayerBet_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676504);
			RTBGameController.NativeMethodInfoPtr_set_LocalPlayerBet_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676505);
			RTBGameController.NativeMethodInfoPtr_get_LocalPlayerBetMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676506);
			RTBGameController.NativeMethodInfoPtr_set_LocalPlayerBetMultiplier_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676507);
			RTBGameController.NativeMethodInfoPtr_get_MultipliedLocalPlayerBet_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676508);
			RTBGameController.NativeMethodInfoPtr_get_RemainingAnswerTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676509);
			RTBGameController.NativeMethodInfoPtr_set_RemainingAnswerTime_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676510);
			RTBGameController.NativeMethodInfoPtr_get_IsLocalPlayerInCurrentRound_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676511);
			RTBGameController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676512);
			RTBGameController.NativeMethodInfoPtr_Open_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676513);
			RTBGameController.NativeMethodInfoPtr_Close_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676514);
			RTBGameController.NativeMethodInfoPtr_Exit_Protected_Virtual_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676515);
			RTBGameController.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676516);
			RTBGameController.NativeMethodInfoPtr_SetStage_Private_Void_EStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676517);
			RTBGameController.NativeMethodInfoPtr_RunRound_Private_Void_EStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676518);
			RTBGameController.NativeMethodInfoPtr_SetBetMultiplier_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676519);
			RTBGameController.NativeMethodInfoPtr_EndGame_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676520);
			RTBGameController.NativeMethodInfoPtr_RemoveLocalPlayerFromGame_Public_Void_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676521);
			RTBGameController.NativeMethodInfoPtr_IsCurrentRoundEmpty_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676522);
			RTBGameController.NativeMethodInfoPtr_GetAnswerIndex_Private_Single_EStage_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676523);
			RTBGameController.NativeMethodInfoPtr_NotifyAnswer_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676524);
			RTBGameController.NativeMethodInfoPtr_QuestionDone_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676525);
			RTBGameController.NativeMethodInfoPtr_GetQuestionsAndAnswers_Private_Void_EStage_byref_String_byref_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676526);
			RTBGameController.NativeMethodInfoPtr_ResetCards_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676527);
			RTBGameController.NativeMethodInfoPtr_AddPlayerToCurrentRound_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676528);
			RTBGameController.NativeMethodInfoPtr_RequestRemovePlayerFromCurrentRound_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676529);
			RTBGameController.NativeMethodInfoPtr_RemovePlayerFromCurrentRound_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676530);
			RTBGameController.NativeMethodInfoPtr_PullCardFromDeck_Private_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676531);
			RTBGameController.NativeMethodInfoPtr_SetLocalPlayerBet_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676532);
			RTBGameController.NativeMethodInfoPtr_AreAllPlayersReady_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676533);
			RTBGameController.NativeMethodInfoPtr_GetPlayersReadyCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676534);
			RTBGameController.NativeMethodInfoPtr_SetLocalPlayerAnswer_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676535);
			RTBGameController.NativeMethodInfoPtr_GetAnsweredPlayersCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676536);
			RTBGameController.NativeMethodInfoPtr_ToggleLocalPlayerReady_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676537);
			RTBGameController.NativeMethodInfoPtr_GetCardNumberValue_Private_Int32_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676538);
			RTBGameController.NativeMethodInfoPtr_GetNetBetMultiplier_Public_Static_Single_EStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676539);
			RTBGameController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676540);
			RTBGameController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676541);
			RTBGameController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676542);
			RTBGameController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676543);
			RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_SetStage_2502303021_Private_Void_EStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676544);
			RTBGameController.NativeMethodInfoPtr_RpcLogic___SetStage_2502303021_Private_Void_EStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676545);
			RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_SetStage_2502303021_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676546);
			RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_SetBetMultiplier_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676547);
			RTBGameController.NativeMethodInfoPtr_RpcLogic___SetBetMultiplier_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676548);
			RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_SetBetMultiplier_431000436_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676549);
			RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_EndGame_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676550);
			RTBGameController.NativeMethodInfoPtr_RpcLogic___EndGame_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676551);
			RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_EndGame_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676552);
			RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_NotifyAnswer_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676553);
			RTBGameController.NativeMethodInfoPtr_RpcLogic___NotifyAnswer_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676554);
			RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_NotifyAnswer_431000436_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676555);
			RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_QuestionDone_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676556);
			RTBGameController.NativeMethodInfoPtr_RpcLogic___QuestionDone_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676557);
			RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_QuestionDone_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676558);
			RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_AddPlayerToCurrentRound_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676559);
			RTBGameController.NativeMethodInfoPtr_RpcLogic___AddPlayerToCurrentRound_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676560);
			RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_AddPlayerToCurrentRound_3323014238_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676561);
			RTBGameController.NativeMethodInfoPtr_RpcWriter___Server_RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676562);
			RTBGameController.NativeMethodInfoPtr_RpcLogic___RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676563);
			RTBGameController.NativeMethodInfoPtr_RpcReader___Server_RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676564);
			RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_RemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676565);
			RTBGameController.NativeMethodInfoPtr_RpcLogic___RemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676566);
			RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_RemovePlayerFromCurrentRound_3323014238_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676567);
			RTBGameController.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676568);
		}

		// Token: 0x17001F50 RID: 8016
		// (get) Token: 0x060067F0 RID: 26608 RVA: 0x001D3B54 File Offset: 0x001D1D54
		// (set) Token: 0x060067F1 RID: 26609 RVA: 0x001D3B90 File Offset: 0x001D1D90
		public unsafe RTBGameController.EStage CurrentStage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_get_CurrentStage_Public_get_EStage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_set_CurrentStage_Private_set_Void_EStage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001F51 RID: 8017
		// (get) Token: 0x060067F2 RID: 26610 RVA: 0x001D3BD0 File Offset: 0x001D1DD0
		// (set) Token: 0x060067F3 RID: 26611 RVA: 0x001D3C0C File Offset: 0x001D1E0C
		public unsafe bool IsQuestionActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_get_IsQuestionActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_set_IsQuestionActive_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001F52 RID: 8018
		// (get) Token: 0x060067F4 RID: 26612 RVA: 0x001D3C4C File Offset: 0x001D1E4C
		// (set) Token: 0x060067F5 RID: 26613 RVA: 0x001D3C88 File Offset: 0x001D1E88
		public unsafe float LocalPlayerBet
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_get_LocalPlayerBet_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_set_LocalPlayerBet_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001F53 RID: 8019
		// (get) Token: 0x060067F6 RID: 26614 RVA: 0x001D3CC8 File Offset: 0x001D1EC8
		// (set) Token: 0x060067F7 RID: 26615 RVA: 0x001D3D04 File Offset: 0x001D1F04
		public unsafe float LocalPlayerBetMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_get_LocalPlayerBetMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_set_LocalPlayerBetMultiplier_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001F54 RID: 8020
		// (get) Token: 0x060067F8 RID: 26616 RVA: 0x001D3D44 File Offset: 0x001D1F44
		public unsafe float MultipliedLocalPlayerBet
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_get_MultipliedLocalPlayerBet_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001F55 RID: 8021
		// (get) Token: 0x060067F9 RID: 26617 RVA: 0x001D3D80 File Offset: 0x001D1F80
		// (set) Token: 0x060067FA RID: 26618 RVA: 0x001D3DBC File Offset: 0x001D1FBC
		public unsafe float RemainingAnswerTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_get_RemainingAnswerTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_set_RemainingAnswerTime_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001F56 RID: 8022
		// (get) Token: 0x060067FB RID: 26619 RVA: 0x001D3DFC File Offset: 0x001D1FFC
		public unsafe bool IsLocalPlayerInCurrentRound
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 210802, RefRangeEnd = 210814, XrefRangeStart = 210794, XrefRangeEnd = 210802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_get_IsLocalPlayerInCurrentRound_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060067FC RID: 26620 RVA: 0x001D3E38 File Offset: 0x001D2038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210814, XrefRangeEnd = 210816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RTBGameController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067FD RID: 26621 RVA: 0x001D3E74 File Offset: 0x001D2074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210816, XrefRangeEnd = 210823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RTBGameController.NativeMethodInfoPtr_Open_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067FE RID: 26622 RVA: 0x001D3EB0 File Offset: 0x001D20B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210823, XrefRangeEnd = 210832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RTBGameController.NativeMethodInfoPtr_Close_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067FF RID: 26623 RVA: 0x001D3EEC File Offset: 0x001D20EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210832, XrefRangeEnd = 210836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RTBGameController.NativeMethodInfoPtr_Exit_Protected_Virtual_Void_ExitAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006800 RID: 26624 RVA: 0x001D3F3C File Offset: 0x001D213C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210836, XrefRangeEnd = 210866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RTBGameController.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006801 RID: 26625 RVA: 0x001D3F78 File Offset: 0x001D2178
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 210888, RefRangeEnd = 210893, XrefRangeStart = 210866, XrefRangeEnd = 210888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStage(RTBGameController.EStage stage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref stage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_SetStage_Private_Void_EStage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006802 RID: 26626 RVA: 0x001D3FB8 File Offset: 0x001D21B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210910, RefRangeEnd = 210911, XrefRangeStart = 210893, XrefRangeEnd = 210910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunRound(RTBGameController.EStage stage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref stage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RunRound_Private_Void_EStage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006803 RID: 26627 RVA: 0x001D3FF8 File Offset: 0x001D21F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 210931, RefRangeEnd = 210934, XrefRangeStart = 210911, XrefRangeEnd = 210931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBetMultiplier(float multiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref multiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_SetBetMultiplier_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006804 RID: 26628 RVA: 0x001D4038 File Offset: 0x001D2238
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210958, RefRangeEnd = 210959, XrefRangeStart = 210934, XrefRangeEnd = 210958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_EndGame_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006805 RID: 26629 RVA: 0x001D406C File Offset: 0x001D226C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 211003, RefRangeEnd = 211009, XrefRangeStart = 210959, XrefRangeEnd = 211003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveLocalPlayerFromGame(bool payout, float cameraDelay = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref payout;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cameraDelay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RemoveLocalPlayerFromGame_Public_Void_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006806 RID: 26630 RVA: 0x001D40B8 File Offset: 0x001D22B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 211010, RefRangeEnd = 211011, XrefRangeStart = 211009, XrefRangeEnd = 211010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCurrentRoundEmpty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_IsCurrentRoundEmpty_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006807 RID: 26631 RVA: 0x001D40F4 File Offset: 0x001D22F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 211023, RefRangeEnd = 211024, XrefRangeStart = 211011, XrefRangeEnd = 211023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAnswerIndex(RTBGameController.EStage stage, PlayingCard.CardData card)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref stage;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref card;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_GetAnswerIndex_Private_Single_EStage_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006808 RID: 26632 RVA: 0x001D414C File Offset: 0x001D234C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211024, XrefRangeEnd = 211046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyAnswer(float answerIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref answerIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_NotifyAnswer_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006809 RID: 26633 RVA: 0x001D418C File Offset: 0x001D238C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211046, XrefRangeEnd = 211067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QuestionDone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_QuestionDone_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600680A RID: 26634 RVA: 0x001D41C0 File Offset: 0x001D23C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 211130, RefRangeEnd = 211131, XrefRangeStart = 211067, XrefRangeEnd = 211130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetQuestionsAndAnswers(RTBGameController.EStage stage, out string question, out Il2CppStringArray answers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref stage;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_GetQuestionsAndAnswers_Private_Void_EStage_byref_String_byref_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			question = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			answers = ((intPtr5 == 0) ? null : new Il2CppStringArray(intPtr5));
		}

		// Token: 0x0600680B RID: 26635 RVA: 0x001D423C File Offset: 0x001D243C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 211153, RefRangeEnd = 211158, XrefRangeStart = 211131, XrefRangeEnd = 211153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetCards()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_ResetCards_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600680C RID: 26636 RVA: 0x001D4270 File Offset: 0x001D2470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211158, XrefRangeEnd = 211180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPlayerToCurrentRound(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_AddPlayerToCurrentRound_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600680D RID: 26637 RVA: 0x001D42B4 File Offset: 0x001D24B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211180, XrefRangeEnd = 211202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestRemovePlayerFromCurrentRound(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RequestRemovePlayerFromCurrentRound_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600680E RID: 26638 RVA: 0x001D42F8 File Offset: 0x001D24F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 211224, RefRangeEnd = 211227, XrefRangeStart = 211202, XrefRangeEnd = 211224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemovePlayerFromCurrentRound(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RemovePlayerFromCurrentRound_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600680F RID: 26639 RVA: 0x001D433C File Offset: 0x001D253C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211227, XrefRangeEnd = 211238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayingCard.CardData PullCardFromDeck()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_PullCardFromDeck_Private_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006810 RID: 26640 RVA: 0x001D4378 File Offset: 0x001D2578
		[CallerCount(0)]
		public unsafe void SetLocalPlayerBet(float bet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref bet;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_SetLocalPlayerBet_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006811 RID: 26641 RVA: 0x001D43B8 File Offset: 0x001D25B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211238, XrefRangeEnd = 211241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreAllPlayersReady()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_AreAllPlayersReady_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006812 RID: 26642 RVA: 0x001D43F4 File Offset: 0x001D25F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 211254, RefRangeEnd = 211256, XrefRangeStart = 211241, XrefRangeEnd = 211254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPlayersReadyCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_GetPlayersReadyCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006813 RID: 26643 RVA: 0x001D4430 File Offset: 0x001D2630
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 211262, RefRangeEnd = 211265, XrefRangeStart = 211256, XrefRangeEnd = 211262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLocalPlayerAnswer(float answer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref answer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_SetLocalPlayerAnswer_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006814 RID: 26644 RVA: 0x001D4470 File Offset: 0x001D2670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211265, XrefRangeEnd = 211282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetAnsweredPlayersCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_GetAnsweredPlayersCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006815 RID: 26645 RVA: 0x001D44AC File Offset: 0x001D26AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211282, XrefRangeEnd = 211293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleLocalPlayerReady()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_ToggleLocalPlayerReady_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006816 RID: 26646 RVA: 0x001D44E0 File Offset: 0x001D26E0
		[CallerCount(0)]
		public unsafe int GetCardNumberValue(PlayingCard.CardData card)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref card;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_GetCardNumberValue_Private_Int32_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006817 RID: 26647 RVA: 0x001D452C File Offset: 0x001D272C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 211293, RefRangeEnd = 211294, XrefRangeStart = 211293, XrefRangeEnd = 211293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetNetBetMultiplier(RTBGameController.EStage stage)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref stage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_GetNetBetMultiplier_Public_Static_Single_EStage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006818 RID: 26648 RVA: 0x001D456C File Offset: 0x001D276C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211294, XrefRangeEnd = 211314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTBGameController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006819 RID: 26649 RVA: 0x001D45A8 File Offset: 0x001D27A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211314, XrefRangeEnd = 211365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RTBGameController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600681A RID: 26650 RVA: 0x001D45E4 File Offset: 0x001D27E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211365, XrefRangeEnd = 211366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RTBGameController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600681B RID: 26651 RVA: 0x001D4620 File Offset: 0x001D2820
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RTBGameController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600681C RID: 26652 RVA: 0x001D465C File Offset: 0x001D285C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211366, XrefRangeEnd = 211385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetStage_2502303021(RTBGameController.EStage stage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref stage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_SetStage_2502303021_Private_Void_EStage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600681D RID: 26653 RVA: 0x001D469C File Offset: 0x001D289C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 211401, RefRangeEnd = 211403, XrefRangeStart = 211385, XrefRangeEnd = 211401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetStage_2502303021(RTBGameController.EStage stage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref stage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcLogic___SetStage_2502303021_Private_Void_EStage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600681E RID: 26654 RVA: 0x001D46DC File Offset: 0x001D28DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211403, XrefRangeEnd = 211407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetStage_2502303021(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_SetStage_2502303021_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600681F RID: 26655 RVA: 0x001D472C File Offset: 0x001D292C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211407, XrefRangeEnd = 211426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetBetMultiplier_431000436(float multiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref multiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_SetBetMultiplier_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006820 RID: 26656 RVA: 0x001D476C File Offset: 0x001D296C
		[CallerCount(0)]
		public unsafe void RpcLogic___SetBetMultiplier_431000436(float multiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref multiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcLogic___SetBetMultiplier_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006821 RID: 26657 RVA: 0x001D47AC File Offset: 0x001D29AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211426, XrefRangeEnd = 211429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetBetMultiplier_431000436(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_SetBetMultiplier_431000436_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006822 RID: 26658 RVA: 0x001D47FC File Offset: 0x001D29FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211429, XrefRangeEnd = 211447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_EndGame_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_EndGame_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006823 RID: 26659 RVA: 0x001D4830 File Offset: 0x001D2A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211447, XrefRangeEnd = 211451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___EndGame_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcLogic___EndGame_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006824 RID: 26660 RVA: 0x001D4864 File Offset: 0x001D2A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211451, XrefRangeEnd = 211457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_EndGame_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_EndGame_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006825 RID: 26661 RVA: 0x001D48B4 File Offset: 0x001D2AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211457, XrefRangeEnd = 211476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_NotifyAnswer_431000436(float answerIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref answerIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_NotifyAnswer_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006826 RID: 26662 RVA: 0x001D48F4 File Offset: 0x001D2AF4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 211496, RefRangeEnd = 211499, XrefRangeStart = 211476, XrefRangeEnd = 211496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___NotifyAnswer_431000436(float answerIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref answerIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcLogic___NotifyAnswer_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006827 RID: 26663 RVA: 0x001D4934 File Offset: 0x001D2B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211499, XrefRangeEnd = 211503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_NotifyAnswer_431000436(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_NotifyAnswer_431000436_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006828 RID: 26664 RVA: 0x001D4984 File Offset: 0x001D2B84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211503, XrefRangeEnd = 211521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_QuestionDone_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_QuestionDone_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006829 RID: 26665 RVA: 0x001D49B8 File Offset: 0x001D2BB8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 211529, RefRangeEnd = 211534, XrefRangeStart = 211521, XrefRangeEnd = 211529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___QuestionDone_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcLogic___QuestionDone_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600682A RID: 26666 RVA: 0x001D49EC File Offset: 0x001D2BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211534, XrefRangeEnd = 211537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_QuestionDone_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_QuestionDone_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600682B RID: 26667 RVA: 0x001D4A3C File Offset: 0x001D2C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211537, XrefRangeEnd = 211556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AddPlayerToCurrentRound_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_AddPlayerToCurrentRound_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600682C RID: 26668 RVA: 0x001D4A80 File Offset: 0x001D2C80
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 211569, RefRangeEnd = 211572, XrefRangeStart = 211556, XrefRangeEnd = 211569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AddPlayerToCurrentRound_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcLogic___AddPlayerToCurrentRound_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600682D RID: 26669 RVA: 0x001D4AC4 File Offset: 0x001D2CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211572, XrefRangeEnd = 211576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AddPlayerToCurrentRound_3323014238(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_AddPlayerToCurrentRound_3323014238_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600682E RID: 26670 RVA: 0x001D4B14 File Offset: 0x001D2D14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211576, XrefRangeEnd = 211595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_RequestRemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcWriter___Server_RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600682F RID: 26671 RVA: 0x001D4B58 File Offset: 0x001D2D58
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 211224, RefRangeEnd = 211227, XrefRangeStart = 211224, XrefRangeEnd = 211227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RequestRemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcLogic___RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006830 RID: 26672 RVA: 0x001D4B9C File Offset: 0x001D2D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211595, XrefRangeEnd = 211599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_RequestRemovePlayerFromCurrentRound_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcReader___Server_RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006831 RID: 26673 RVA: 0x001D4C00 File Offset: 0x001D2E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211599, XrefRangeEnd = 211618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_RemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_RemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006832 RID: 26674 RVA: 0x001D4C44 File Offset: 0x001D2E44
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 211634, RefRangeEnd = 211637, XrefRangeStart = 211618, XrefRangeEnd = 211634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcLogic___RemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006833 RID: 26675 RVA: 0x001D4C88 File Offset: 0x001D2E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211637, XrefRangeEnd = 211641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_RemovePlayerFromCurrentRound_3323014238(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_RemovePlayerFromCurrentRound_3323014238_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006834 RID: 26676 RVA: 0x001D4CD8 File Offset: 0x001D2ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211641, XrefRangeEnd = 211643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RTBGameController.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006835 RID: 26677 RVA: 0x00031076 File Offset: 0x0002F276
		public RTBGameController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F36 RID: 7990
		// (get) Token: 0x06006836 RID: 26678 RVA: 0x001D4D14 File Offset: 0x001D2F14
		// (set) Token: 0x06006837 RID: 26679 RVA: 0x0003107F File Offset: 0x0002F27F
		public unsafe static int BET_MINIMUM
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(RTBGameController.NativeFieldInfoPtr_BET_MINIMUM, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RTBGameController.NativeFieldInfoPtr_BET_MINIMUM, (void*)(&value));
			}
		}

		// Token: 0x17001F37 RID: 7991
		// (get) Token: 0x06006838 RID: 26680 RVA: 0x001D4D30 File Offset: 0x001D2F30
		// (set) Token: 0x06006839 RID: 26681 RVA: 0x0003108D File Offset: 0x0002F28D
		public unsafe static int BET_MAXIMUM
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(RTBGameController.NativeFieldInfoPtr_BET_MAXIMUM, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RTBGameController.NativeFieldInfoPtr_BET_MAXIMUM, (void*)(&value));
			}
		}

		// Token: 0x17001F38 RID: 7992
		// (get) Token: 0x0600683A RID: 26682 RVA: 0x001D4D4C File Offset: 0x001D2F4C
		// (set) Token: 0x0600683B RID: 26683 RVA: 0x0003109B File Offset: 0x0002F29B
		public unsafe static float ANSWER_MAX_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(RTBGameController.NativeFieldInfoPtr_ANSWER_MAX_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RTBGameController.NativeFieldInfoPtr_ANSWER_MAX_TIME, (void*)(&value));
			}
		}

		// Token: 0x17001F39 RID: 7993
		// (get) Token: 0x0600683C RID: 26684 RVA: 0x001D4D68 File Offset: 0x001D2F68
		// (set) Token: 0x0600683D RID: 26685 RVA: 0x000310A9 File Offset: 0x0002F2A9
		public unsafe Transform PlayCameraTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_PlayCameraTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_PlayCameraTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F3A RID: 7994
		// (get) Token: 0x0600683E RID: 26686 RVA: 0x001D4D98 File Offset: 0x001D2F98
		// (set) Token: 0x0600683F RID: 26687 RVA: 0x000310C8 File Offset: 0x0002F2C8
		public unsafe Transform FocusedCameraTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_FocusedCameraTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_FocusedCameraTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F3B RID: 7995
		// (get) Token: 0x06006840 RID: 26688 RVA: 0x001D4DC8 File Offset: 0x001D2FC8
		// (set) Token: 0x06006841 RID: 26689 RVA: 0x000310E7 File Offset: 0x0002F2E7
		public unsafe Il2CppReferenceArray<PlayingCard> Cards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_Cards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PlayingCard>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_Cards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F3C RID: 7996
		// (get) Token: 0x06006842 RID: 26690 RVA: 0x001D4DF8 File Offset: 0x001D2FF8
		// (set) Token: 0x06006843 RID: 26691 RVA: 0x00031106 File Offset: 0x0002F306
		public unsafe Il2CppReferenceArray<Transform> CardDefaultPositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_CardDefaultPositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_CardDefaultPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F3D RID: 7997
		// (get) Token: 0x06006844 RID: 26692 RVA: 0x001D4E28 File Offset: 0x001D3028
		// (set) Token: 0x06006845 RID: 26693 RVA: 0x00031125 File Offset: 0x0002F325
		public unsafe Transform ActiveCardPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_ActiveCardPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_ActiveCardPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F3E RID: 7998
		// (get) Token: 0x06006846 RID: 26694 RVA: 0x001D4E58 File Offset: 0x001D3058
		// (set) Token: 0x06006847 RID: 26695 RVA: 0x00031144 File Offset: 0x0002F344
		public unsafe Il2CppReferenceArray<Transform> DockedCardPositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_DockedCardPositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_DockedCardPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F3F RID: 7999
		// (get) Token: 0x06006848 RID: 26696 RVA: 0x001D4E88 File Offset: 0x001D3088
		// (set) Token: 0x06006849 RID: 26697 RVA: 0x00031163 File Offset: 0x0002F363
		public unsafe RTBGameController.EStage _CurrentStage_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr__CurrentStage_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr__CurrentStage_k__BackingField)) = value;
			}
		}

		// Token: 0x17001F40 RID: 8000
		// (get) Token: 0x0600684A RID: 26698 RVA: 0x001D4EB0 File Offset: 0x001D30B0
		// (set) Token: 0x0600684B RID: 26699 RVA: 0x0003117E File Offset: 0x0002F37E
		public unsafe Action<RTBGameController.EStage> onStageChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onStageChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<RTBGameController.EStage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onStageChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F41 RID: 8001
		// (get) Token: 0x0600684C RID: 26700 RVA: 0x001D4EE0 File Offset: 0x001D30E0
		// (set) Token: 0x0600684D RID: 26701 RVA: 0x0003119D File Offset: 0x0002F39D
		public unsafe Action<string, Il2CppStringArray> onQuestionReady
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onQuestionReady);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string, Il2CppStringArray>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onQuestionReady), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F42 RID: 8002
		// (get) Token: 0x0600684E RID: 26702 RVA: 0x001D4F10 File Offset: 0x001D3110
		// (set) Token: 0x0600684F RID: 26703 RVA: 0x000311BC File Offset: 0x0002F3BC
		public unsafe Action onQuestionDone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onQuestionDone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onQuestionDone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F43 RID: 8003
		// (get) Token: 0x06006850 RID: 26704 RVA: 0x001D4F40 File Offset: 0x001D3140
		// (set) Token: 0x06006851 RID: 26705 RVA: 0x000311DB File Offset: 0x0002F3DB
		public unsafe Action onLocalPlayerCorrect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onLocalPlayerCorrect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onLocalPlayerCorrect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F44 RID: 8004
		// (get) Token: 0x06006852 RID: 26706 RVA: 0x001D4F70 File Offset: 0x001D3170
		// (set) Token: 0x06006853 RID: 26707 RVA: 0x000311FA File Offset: 0x0002F3FA
		public unsafe Action onLocalPlayerIncorrect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onLocalPlayerIncorrect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onLocalPlayerIncorrect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F45 RID: 8005
		// (get) Token: 0x06006854 RID: 26708 RVA: 0x001D4FA0 File Offset: 0x001D31A0
		// (set) Token: 0x06006855 RID: 26709 RVA: 0x00031219 File Offset: 0x0002F419
		public unsafe Action onLocalPlayerBetChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onLocalPlayerBetChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onLocalPlayerBetChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F46 RID: 8006
		// (get) Token: 0x06006856 RID: 26710 RVA: 0x001D4FD0 File Offset: 0x001D31D0
		// (set) Token: 0x06006857 RID: 26711 RVA: 0x00031238 File Offset: 0x0002F438
		public unsafe Action onLocalPlayerExitRound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onLocalPlayerExitRound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onLocalPlayerExitRound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F47 RID: 8007
		// (get) Token: 0x06006858 RID: 26712 RVA: 0x001D5000 File Offset: 0x001D3200
		// (set) Token: 0x06006859 RID: 26713 RVA: 0x00031257 File Offset: 0x0002F457
		public unsafe bool _IsQuestionActive_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr__IsQuestionActive_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr__IsQuestionActive_k__BackingField)) = value;
			}
		}

		// Token: 0x17001F48 RID: 8008
		// (get) Token: 0x0600685A RID: 26714 RVA: 0x001D5028 File Offset: 0x001D3228
		// (set) Token: 0x0600685B RID: 26715 RVA: 0x00031272 File Offset: 0x0002F472
		public unsafe float _LocalPlayerBet_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr__LocalPlayerBet_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr__LocalPlayerBet_k__BackingField)) = value;
			}
		}

		// Token: 0x17001F49 RID: 8009
		// (get) Token: 0x0600685C RID: 26716 RVA: 0x001D5050 File Offset: 0x001D3250
		// (set) Token: 0x0600685D RID: 26717 RVA: 0x0003128D File Offset: 0x0002F48D
		public unsafe float _LocalPlayerBetMultiplier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr__LocalPlayerBetMultiplier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr__LocalPlayerBetMultiplier_k__BackingField)) = value;
			}
		}

		// Token: 0x17001F4A RID: 8010
		// (get) Token: 0x0600685E RID: 26718 RVA: 0x001D5078 File Offset: 0x001D3278
		// (set) Token: 0x0600685F RID: 26719 RVA: 0x000312A8 File Offset: 0x0002F4A8
		public unsafe float _RemainingAnswerTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr__RemainingAnswerTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr__RemainingAnswerTime_k__BackingField)) = value;
			}
		}

		// Token: 0x17001F4B RID: 8011
		// (get) Token: 0x06006860 RID: 26720 RVA: 0x001D50A0 File Offset: 0x001D32A0
		// (set) Token: 0x06006861 RID: 26721 RVA: 0x000312C3 File Offset: 0x0002F4C3
		public unsafe List<Player> playersInCurrentRound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_playersInCurrentRound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_playersInCurrentRound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F4C RID: 8012
		// (get) Token: 0x06006862 RID: 26722 RVA: 0x001D50D0 File Offset: 0x001D32D0
		// (set) Token: 0x06006863 RID: 26723 RVA: 0x000312E2 File Offset: 0x0002F4E2
		public unsafe List<PlayingCard.CardData> cardsInDeck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_cardsInDeck);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayingCard.CardData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_cardsInDeck), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F4D RID: 8013
		// (get) Token: 0x06006864 RID: 26724 RVA: 0x001D5100 File Offset: 0x001D3300
		// (set) Token: 0x06006865 RID: 26725 RVA: 0x00031301 File Offset: 0x0002F501
		public unsafe List<PlayingCard.CardData> drawnCards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_drawnCards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayingCard.CardData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_drawnCards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F4E RID: 8014
		// (get) Token: 0x06006866 RID: 26726 RVA: 0x001D5130 File Offset: 0x001D3330
		// (set) Token: 0x06006867 RID: 26727 RVA: 0x00031320 File Offset: 0x0002F520
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001F4F RID: 8015
		// (get) Token: 0x06006868 RID: 26728 RVA: 0x001D5158 File Offset: 0x001D3358
		// (set) Token: 0x06006869 RID: 26729 RVA: 0x0003133B File Offset: 0x0002F53B
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004733 RID: 18227
		private static readonly IntPtr NativeFieldInfoPtr_BET_MINIMUM;

		// Token: 0x04004734 RID: 18228
		private static readonly IntPtr NativeFieldInfoPtr_BET_MAXIMUM;

		// Token: 0x04004735 RID: 18229
		private static readonly IntPtr NativeFieldInfoPtr_ANSWER_MAX_TIME;

		// Token: 0x04004736 RID: 18230
		private static readonly IntPtr NativeFieldInfoPtr_PlayCameraTransform;

		// Token: 0x04004737 RID: 18231
		private static readonly IntPtr NativeFieldInfoPtr_FocusedCameraTransform;

		// Token: 0x04004738 RID: 18232
		private static readonly IntPtr NativeFieldInfoPtr_Cards;

		// Token: 0x04004739 RID: 18233
		private static readonly IntPtr NativeFieldInfoPtr_CardDefaultPositions;

		// Token: 0x0400473A RID: 18234
		private static readonly IntPtr NativeFieldInfoPtr_ActiveCardPosition;

		// Token: 0x0400473B RID: 18235
		private static readonly IntPtr NativeFieldInfoPtr_DockedCardPositions;

		// Token: 0x0400473C RID: 18236
		private static readonly IntPtr NativeFieldInfoPtr__CurrentStage_k__BackingField;

		// Token: 0x0400473D RID: 18237
		private static readonly IntPtr NativeFieldInfoPtr_onStageChange;

		// Token: 0x0400473E RID: 18238
		private static readonly IntPtr NativeFieldInfoPtr_onQuestionReady;

		// Token: 0x0400473F RID: 18239
		private static readonly IntPtr NativeFieldInfoPtr_onQuestionDone;

		// Token: 0x04004740 RID: 18240
		private static readonly IntPtr NativeFieldInfoPtr_onLocalPlayerCorrect;

		// Token: 0x04004741 RID: 18241
		private static readonly IntPtr NativeFieldInfoPtr_onLocalPlayerIncorrect;

		// Token: 0x04004742 RID: 18242
		private static readonly IntPtr NativeFieldInfoPtr_onLocalPlayerBetChange;

		// Token: 0x04004743 RID: 18243
		private static readonly IntPtr NativeFieldInfoPtr_onLocalPlayerExitRound;

		// Token: 0x04004744 RID: 18244
		private static readonly IntPtr NativeFieldInfoPtr__IsQuestionActive_k__BackingField;

		// Token: 0x04004745 RID: 18245
		private static readonly IntPtr NativeFieldInfoPtr__LocalPlayerBet_k__BackingField;

		// Token: 0x04004746 RID: 18246
		private static readonly IntPtr NativeFieldInfoPtr__LocalPlayerBetMultiplier_k__BackingField;

		// Token: 0x04004747 RID: 18247
		private static readonly IntPtr NativeFieldInfoPtr__RemainingAnswerTime_k__BackingField;

		// Token: 0x04004748 RID: 18248
		private static readonly IntPtr NativeFieldInfoPtr_playersInCurrentRound;

		// Token: 0x04004749 RID: 18249
		private static readonly IntPtr NativeFieldInfoPtr_cardsInDeck;

		// Token: 0x0400474A RID: 18250
		private static readonly IntPtr NativeFieldInfoPtr_drawnCards;

		// Token: 0x0400474B RID: 18251
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400474C RID: 18252
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400474D RID: 18253
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentStage_Public_get_EStage_0;

		// Token: 0x0400474E RID: 18254
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentStage_Private_set_Void_EStage_0;

		// Token: 0x0400474F RID: 18255
		private static readonly IntPtr NativeMethodInfoPtr_get_IsQuestionActive_Public_get_Boolean_0;

		// Token: 0x04004750 RID: 18256
		private static readonly IntPtr NativeMethodInfoPtr_set_IsQuestionActive_Private_set_Void_Boolean_0;

		// Token: 0x04004751 RID: 18257
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalPlayerBet_Public_get_Single_0;

		// Token: 0x04004752 RID: 18258
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalPlayerBet_Private_set_Void_Single_0;

		// Token: 0x04004753 RID: 18259
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalPlayerBetMultiplier_Public_get_Single_0;

		// Token: 0x04004754 RID: 18260
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalPlayerBetMultiplier_Private_set_Void_Single_0;

		// Token: 0x04004755 RID: 18261
		private static readonly IntPtr NativeMethodInfoPtr_get_MultipliedLocalPlayerBet_Public_get_Single_0;

		// Token: 0x04004756 RID: 18262
		private static readonly IntPtr NativeMethodInfoPtr_get_RemainingAnswerTime_Public_get_Single_0;

		// Token: 0x04004757 RID: 18263
		private static readonly IntPtr NativeMethodInfoPtr_set_RemainingAnswerTime_Private_set_Void_Single_0;

		// Token: 0x04004758 RID: 18264
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLocalPlayerInCurrentRound_Public_get_Boolean_0;

		// Token: 0x04004759 RID: 18265
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0400475A RID: 18266
		private static readonly IntPtr NativeMethodInfoPtr_Open_Protected_Virtual_Void_1;

		// Token: 0x0400475B RID: 18267
		private static readonly IntPtr NativeMethodInfoPtr_Close_Protected_Virtual_Void_1;

		// Token: 0x0400475C RID: 18268
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Protected_Virtual_Void_ExitAction_0;

		// Token: 0x0400475D RID: 18269
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_1;

		// Token: 0x0400475E RID: 18270
		private static readonly IntPtr NativeMethodInfoPtr_SetStage_Private_Void_EStage_0;

		// Token: 0x0400475F RID: 18271
		private static readonly IntPtr NativeMethodInfoPtr_RunRound_Private_Void_EStage_0;

		// Token: 0x04004760 RID: 18272
		private static readonly IntPtr NativeMethodInfoPtr_SetBetMultiplier_Private_Void_Single_0;

		// Token: 0x04004761 RID: 18273
		private static readonly IntPtr NativeMethodInfoPtr_EndGame_Private_Void_0;

		// Token: 0x04004762 RID: 18274
		private static readonly IntPtr NativeMethodInfoPtr_RemoveLocalPlayerFromGame_Public_Void_Boolean_Single_0;

		// Token: 0x04004763 RID: 18275
		private static readonly IntPtr NativeMethodInfoPtr_IsCurrentRoundEmpty_Private_Boolean_0;

		// Token: 0x04004764 RID: 18276
		private static readonly IntPtr NativeMethodInfoPtr_GetAnswerIndex_Private_Single_EStage_CardData_0;

		// Token: 0x04004765 RID: 18277
		private static readonly IntPtr NativeMethodInfoPtr_NotifyAnswer_Private_Void_Single_0;

		// Token: 0x04004766 RID: 18278
		private static readonly IntPtr NativeMethodInfoPtr_QuestionDone_Private_Void_0;

		// Token: 0x04004767 RID: 18279
		private static readonly IntPtr NativeMethodInfoPtr_GetQuestionsAndAnswers_Private_Void_EStage_byref_String_byref_Il2CppStringArray_0;

		// Token: 0x04004768 RID: 18280
		private static readonly IntPtr NativeMethodInfoPtr_ResetCards_Private_Void_0;

		// Token: 0x04004769 RID: 18281
		private static readonly IntPtr NativeMethodInfoPtr_AddPlayerToCurrentRound_Private_Void_NetworkObject_0;

		// Token: 0x0400476A RID: 18282
		private static readonly IntPtr NativeMethodInfoPtr_RequestRemovePlayerFromCurrentRound_Private_Void_NetworkObject_0;

		// Token: 0x0400476B RID: 18283
		private static readonly IntPtr NativeMethodInfoPtr_RemovePlayerFromCurrentRound_Private_Void_NetworkObject_0;

		// Token: 0x0400476C RID: 18284
		private static readonly IntPtr NativeMethodInfoPtr_PullCardFromDeck_Private_CardData_0;

		// Token: 0x0400476D RID: 18285
		private static readonly IntPtr NativeMethodInfoPtr_SetLocalPlayerBet_Public_Void_Single_0;

		// Token: 0x0400476E RID: 18286
		private static readonly IntPtr NativeMethodInfoPtr_AreAllPlayersReady_Public_Boolean_0;

		// Token: 0x0400476F RID: 18287
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayersReadyCount_Public_Int32_0;

		// Token: 0x04004770 RID: 18288
		private static readonly IntPtr NativeMethodInfoPtr_SetLocalPlayerAnswer_Public_Void_Single_0;

		// Token: 0x04004771 RID: 18289
		private static readonly IntPtr NativeMethodInfoPtr_GetAnsweredPlayersCount_Public_Int32_0;

		// Token: 0x04004772 RID: 18290
		private static readonly IntPtr NativeMethodInfoPtr_ToggleLocalPlayerReady_Public_Void_0;

		// Token: 0x04004773 RID: 18291
		private static readonly IntPtr NativeMethodInfoPtr_GetCardNumberValue_Private_Int32_CardData_0;

		// Token: 0x04004774 RID: 18292
		private static readonly IntPtr NativeMethodInfoPtr_GetNetBetMultiplier_Public_Static_Single_EStage_0;

		// Token: 0x04004775 RID: 18293
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004776 RID: 18294
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004777 RID: 18295
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004778 RID: 18296
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004779 RID: 18297
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetStage_2502303021_Private_Void_EStage_0;

		// Token: 0x0400477A RID: 18298
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetStage_2502303021_Private_Void_EStage_0;

		// Token: 0x0400477B RID: 18299
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetStage_2502303021_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400477C RID: 18300
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetBetMultiplier_431000436_Private_Void_Single_0;

		// Token: 0x0400477D RID: 18301
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetBetMultiplier_431000436_Private_Void_Single_0;

		// Token: 0x0400477E RID: 18302
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetBetMultiplier_431000436_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400477F RID: 18303
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_EndGame_2166136261_Private_Void_0;

		// Token: 0x04004780 RID: 18304
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___EndGame_2166136261_Private_Void_0;

		// Token: 0x04004781 RID: 18305
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_EndGame_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004782 RID: 18306
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_NotifyAnswer_431000436_Private_Void_Single_0;

		// Token: 0x04004783 RID: 18307
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___NotifyAnswer_431000436_Private_Void_Single_0;

		// Token: 0x04004784 RID: 18308
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_NotifyAnswer_431000436_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004785 RID: 18309
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_QuestionDone_2166136261_Private_Void_0;

		// Token: 0x04004786 RID: 18310
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___QuestionDone_2166136261_Private_Void_0;

		// Token: 0x04004787 RID: 18311
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_QuestionDone_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004788 RID: 18312
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AddPlayerToCurrentRound_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04004789 RID: 18313
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AddPlayerToCurrentRound_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x0400478A RID: 18314
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_AddPlayerToCurrentRound_3323014238_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400478B RID: 18315
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x0400478C RID: 18316
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x0400478D RID: 18317
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400478E RID: 18318
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_RemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x0400478F RID: 18319
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___RemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04004790 RID: 18320
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_RemovePlayerFromCurrentRound_3323014238_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004791 RID: 18321
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000A49 RID: 2633
		[OriginalName("Assembly-CSharp.dll", "", "EStage")]
		public enum EStage
		{
			// Token: 0x04008C67 RID: 35943
			WaitingForPlayers,
			// Token: 0x04008C68 RID: 35944
			RedOrBlack,
			// Token: 0x04008C69 RID: 35945
			HigherOrLower,
			// Token: 0x04008C6A RID: 35946
			InsideOrOutside,
			// Token: 0x04008C6B RID: 35947
			Suit
		}

		// Token: 0x02000A4A RID: 2634
		[ObfuscatedName("ScheduleOne.Casino.RTBGameController+<>c__DisplayClass50_0")]
		public sealed class __c__DisplayClass50_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D019 RID: 53273 RVA: 0x0031F168 File Offset: 0x0031D368
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass50_0()
			{
				Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "<>c__DisplayClass50_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0>.NativeClassPtr);
				RTBGameController.__c__DisplayClass50_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0>.NativeClassPtr, "<>4__this");
				RTBGameController.__c__DisplayClass50_0.NativeFieldInfoPtr_stage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0>.NativeClassPtr, "stage");
				RTBGameController.__c__DisplayClass50_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0>.NativeClassPtr, 100676569);
				RTBGameController.__c__DisplayClass50_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0>.NativeClassPtr, 100676570);
				RTBGameController.__c__DisplayClass50_0.NativeMethodInfoPtr__RunRound_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0>.NativeClassPtr, 100676571);
			}

			// Token: 0x0600D01A RID: 53274 RVA: 0x0031F1F8 File Offset: 0x0031D3F8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass50_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass50_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D01B RID: 53275 RVA: 0x0031F234 File Offset: 0x0031D434
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210766, XrefRangeEnd = 210771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass50_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D01C RID: 53276 RVA: 0x0031F274 File Offset: 0x0031D474
			[CallerCount(0)]
			public unsafe bool _RunRound_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass50_0.NativeMethodInfoPtr__RunRound_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D01D RID: 53277 RVA: 0x0006542A File Offset: 0x0006362A
			public __c__DisplayClass50_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040A3 RID: 16547
			// (get) Token: 0x0600D01E RID: 53278 RVA: 0x0031F2B0 File Offset: 0x0031D4B0
			// (set) Token: 0x0600D01F RID: 53279 RVA: 0x00065433 File Offset: 0x00063633
			public unsafe RTBGameController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass50_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTBGameController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass50_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040A4 RID: 16548
			// (get) Token: 0x0600D020 RID: 53280 RVA: 0x0031F2E0 File Offset: 0x0031D4E0
			// (set) Token: 0x0600D021 RID: 53281 RVA: 0x00065452 File Offset: 0x00063652
			public unsafe RTBGameController.EStage stage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass50_0.NativeFieldInfoPtr_stage);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass50_0.NativeFieldInfoPtr_stage)) = value;
				}
			}

			// Token: 0x04008C6C RID: 35948
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008C6D RID: 35949
			private static readonly IntPtr NativeFieldInfoPtr_stage;

			// Token: 0x04008C6E RID: 35950
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C6F RID: 35951
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04008C70 RID: 35952
			private static readonly IntPtr NativeMethodInfoPtr__RunRound_b__1_Internal_Boolean_0;

			// Token: 0x02000C5B RID: 3163
			[ObfuscatedName("ScheduleOne.Casino.RTBGameController+<>c__DisplayClass50_0+<<RunRound>g__RunRound|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E3C4 RID: 58308 RVA: 0x00357200 File Offset: 0x00355400
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique()
				{
					Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0>.NativeClassPtr, "<<RunRound>g__RunRound|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr);
					RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, "<>1__state");
					RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, "<>2__current");
					RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, "<>4__this");
					RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr__activeCard_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, "<activeCard>5__2");
					RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, 100676572);
					RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, 100676573);
					RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, 100676574);
					RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, 100676575);
					RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, 100676576);
					RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, 100676577);
				}

				// Token: 0x0600E3C5 RID: 58309 RVA: 0x003572F4 File Offset: 0x003554F4
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E3C6 RID: 58310 RVA: 0x0035733C File Offset: 0x0035553C
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E3C7 RID: 58311 RVA: 0x00357370 File Offset: 0x00355570
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210583, XrefRangeEnd = 210761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170046B4 RID: 18100
				// (get) Token: 0x0600E3C8 RID: 58312 RVA: 0x003573AC File Offset: 0x003555AC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E3C9 RID: 58313 RVA: 0x003573EC File Offset: 0x003555EC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210761, XrefRangeEnd = 210766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170046B5 RID: 18101
				// (get) Token: 0x0600E3CA RID: 58314 RVA: 0x00357420 File Offset: 0x00355620
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E3CB RID: 58315 RVA: 0x0006F069 File Offset: 0x0006D269
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170046B0 RID: 18096
				// (get) Token: 0x0600E3CC RID: 58316 RVA: 0x00357460 File Offset: 0x00355660
				// (set) Token: 0x0600E3CD RID: 58317 RVA: 0x0006F072 File Offset: 0x0006D272
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170046B1 RID: 18097
				// (get) Token: 0x0600E3CE RID: 58318 RVA: 0x00357488 File Offset: 0x00355688
				// (set) Token: 0x0600E3CF RID: 58319 RVA: 0x0006F08D File Offset: 0x0006D28D
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046B2 RID: 18098
				// (get) Token: 0x0600E3D0 RID: 58320 RVA: 0x003574B8 File Offset: 0x003556B8
				// (set) Token: 0x0600E3D1 RID: 58321 RVA: 0x0006F0AC File Offset: 0x0006D2AC
				public unsafe RTBGameController.__c__DisplayClass50_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTBGameController.__c__DisplayClass50_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046B3 RID: 18099
				// (get) Token: 0x0600E3D2 RID: 58322 RVA: 0x003574E8 File Offset: 0x003556E8
				// (set) Token: 0x0600E3D3 RID: 58323 RVA: 0x0006F0CB File Offset: 0x0006D2CB
				public unsafe PlayingCard _activeCard_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr__activeCard_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayingCard>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr__activeCard_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009866 RID: 39014
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009867 RID: 39015
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009868 RID: 39016
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009869 RID: 39017
				private static readonly IntPtr NativeFieldInfoPtr__activeCard_5__2;

				// Token: 0x0400986A RID: 39018
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400986B RID: 39019
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400986C RID: 39020
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400986D RID: 39021
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400986E RID: 39022
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400986F RID: 39023
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000A4B RID: 2635
		[ObfuscatedName("ScheduleOne.Casino.RTBGameController+<>c__DisplayClass53_0")]
		public sealed class __c__DisplayClass53_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D022 RID: 53282 RVA: 0x0031F308 File Offset: 0x0031D508
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass53_0()
			{
				Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "<>c__DisplayClass53_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0>.NativeClassPtr);
				RTBGameController.__c__DisplayClass53_0.NativeFieldInfoPtr_cameraDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0>.NativeClassPtr, "cameraDelay");
				RTBGameController.__c__DisplayClass53_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0>.NativeClassPtr, "<>4__this");
				RTBGameController.__c__DisplayClass53_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0>.NativeClassPtr, 100676578);
				RTBGameController.__c__DisplayClass53_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0>.NativeClassPtr, 100676579);
			}

			// Token: 0x0600D023 RID: 53283 RVA: 0x0031F384 File Offset: 0x0031D584
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass53_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass53_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D024 RID: 53284 RVA: 0x0031F3C0 File Offset: 0x0031D5C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210789, XrefRangeEnd = 210794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass53_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D025 RID: 53285 RVA: 0x0006546D File Offset: 0x0006366D
			public __c__DisplayClass53_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040A5 RID: 16549
			// (get) Token: 0x0600D026 RID: 53286 RVA: 0x0031F400 File Offset: 0x0031D600
			// (set) Token: 0x0600D027 RID: 53287 RVA: 0x00065476 File Offset: 0x00063676
			public unsafe float cameraDelay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass53_0.NativeFieldInfoPtr_cameraDelay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass53_0.NativeFieldInfoPtr_cameraDelay)) = value;
				}
			}

			// Token: 0x170040A6 RID: 16550
			// (get) Token: 0x0600D028 RID: 53288 RVA: 0x0031F428 File Offset: 0x0031D628
			// (set) Token: 0x0600D029 RID: 53289 RVA: 0x00065491 File Offset: 0x00063691
			public unsafe RTBGameController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass53_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTBGameController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass53_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C71 RID: 35953
			private static readonly IntPtr NativeFieldInfoPtr_cameraDelay;

			// Token: 0x04008C72 RID: 35954
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008C73 RID: 35955
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C74 RID: 35956
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C5C RID: 3164
			[ObfuscatedName("ScheduleOne.Casino.RTBGameController+<>c__DisplayClass53_0+<<RemoveLocalPlayerFromGame>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E3D4 RID: 58324 RVA: 0x00357518 File Offset: 0x00355718
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0>.NativeClassPtr, "<<RemoveLocalPlayerFromGame>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676580);
					RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676581);
					RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676582);
					RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676583);
					RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676584);
					RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676585);
				}

				// Token: 0x0600E3D5 RID: 58325 RVA: 0x003575F8 File Offset: 0x003557F8
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E3D6 RID: 58326 RVA: 0x00357640 File Offset: 0x00355840
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E3D7 RID: 58327 RVA: 0x00357674 File Offset: 0x00355874
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210771, XrefRangeEnd = 210784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170046B9 RID: 18105
				// (get) Token: 0x0600E3D8 RID: 58328 RVA: 0x003576B0 File Offset: 0x003558B0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E3D9 RID: 58329 RVA: 0x003576F0 File Offset: 0x003558F0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210784, XrefRangeEnd = 210789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170046BA RID: 18106
				// (get) Token: 0x0600E3DA RID: 58330 RVA: 0x00357724 File Offset: 0x00355924
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E3DB RID: 58331 RVA: 0x0006F0EA File Offset: 0x0006D2EA
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170046B6 RID: 18102
				// (get) Token: 0x0600E3DC RID: 58332 RVA: 0x00357764 File Offset: 0x00355964
				// (set) Token: 0x0600E3DD RID: 58333 RVA: 0x0006F0F3 File Offset: 0x0006D2F3
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170046B7 RID: 18103
				// (get) Token: 0x0600E3DE RID: 58334 RVA: 0x0035778C File Offset: 0x0035598C
				// (set) Token: 0x0600E3DF RID: 58335 RVA: 0x0006F10E File Offset: 0x0006D30E
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046B8 RID: 18104
				// (get) Token: 0x0600E3E0 RID: 58336 RVA: 0x003577BC File Offset: 0x003559BC
				// (set) Token: 0x0600E3E1 RID: 58337 RVA: 0x0006F12D File Offset: 0x0006D32D
				public unsafe RTBGameController.__c__DisplayClass53_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTBGameController.__c__DisplayClass53_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009870 RID: 39024
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009871 RID: 39025
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009872 RID: 39026
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009873 RID: 39027
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009874 RID: 39028
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009875 RID: 39029
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009876 RID: 39030
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009877 RID: 39031
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009878 RID: 39032
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
