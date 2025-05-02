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
	// Token: 0x020004A0 RID: 1184
	public class BlackjackGameController : CasinoGameController
	{
		// Token: 0x06006663 RID: 26211 RVA: 0x001CCD2C File Offset: 0x001CAF2C
		// Note: this type is marked as 'beforefieldinit'.
		static BlackjackGameController()
		{
			Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino", "BlackjackGameController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr);
			BlackjackGameController.NativeFieldInfoPtr_BET_MINIMUM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "BET_MINIMUM");
			BlackjackGameController.NativeFieldInfoPtr_BET_MAXIMUM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "BET_MAXIMUM");
			BlackjackGameController.NativeFieldInfoPtr_PAYOUT_RATIO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "PAYOUT_RATIO");
			BlackjackGameController.NativeFieldInfoPtr_BLACKJACK_PAYOUT_RATIO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "BLACKJACK_PAYOUT_RATIO");
			BlackjackGameController.NativeFieldInfoPtr__CurrentStage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "<CurrentStage>k__BackingField");
			BlackjackGameController.NativeFieldInfoPtr__PlayerTurn_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "<PlayerTurn>k__BackingField");
			BlackjackGameController.NativeFieldInfoPtr__LocalPlayerBet_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "<LocalPlayerBet>k__BackingField");
			BlackjackGameController.NativeFieldInfoPtr__DealerScore_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "<DealerScore>k__BackingField");
			BlackjackGameController.NativeFieldInfoPtr__LocalPlayerScore_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "<LocalPlayerScore>k__BackingField");
			BlackjackGameController.NativeFieldInfoPtr__IsLocalPlayerBlackjack_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "<IsLocalPlayerBlackjack>k__BackingField");
			BlackjackGameController.NativeFieldInfoPtr__IsLocalPlayerBust_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "<IsLocalPlayerBust>k__BackingField");
			BlackjackGameController.NativeFieldInfoPtr_Cards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "Cards");
			BlackjackGameController.NativeFieldInfoPtr_DefaultCardPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "DefaultCardPositions");
			BlackjackGameController.NativeFieldInfoPtr_FocusedCameraTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "FocusedCameraTransforms");
			BlackjackGameController.NativeFieldInfoPtr_FinalCameraTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "FinalCameraTransforms");
			BlackjackGameController.NativeFieldInfoPtr_Player1CardPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "Player1CardPositions");
			BlackjackGameController.NativeFieldInfoPtr_Player2CardPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "Player2CardPositions");
			BlackjackGameController.NativeFieldInfoPtr_Player3CardPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "Player3CardPositions");
			BlackjackGameController.NativeFieldInfoPtr_Player4CardPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "Player4CardPositions");
			BlackjackGameController.NativeFieldInfoPtr_DealerCardPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "DealerCardPositions");
			BlackjackGameController.NativeFieldInfoPtr_playersInCurrentRound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "playersInCurrentRound");
			BlackjackGameController.NativeFieldInfoPtr_playStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "playStack");
			BlackjackGameController.NativeFieldInfoPtr_player1Hand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "player1Hand");
			BlackjackGameController.NativeFieldInfoPtr_player2Hand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "player2Hand");
			BlackjackGameController.NativeFieldInfoPtr_player3Hand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "player3Hand");
			BlackjackGameController.NativeFieldInfoPtr_player4Hand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "player4Hand");
			BlackjackGameController.NativeFieldInfoPtr_dealerHand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "dealerHand");
			BlackjackGameController.NativeFieldInfoPtr_cardValuesInDeck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "cardValuesInDeck");
			BlackjackGameController.NativeFieldInfoPtr_drawnCardsValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "drawnCardsValues");
			BlackjackGameController.NativeFieldInfoPtr_localFocusCameraTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "localFocusCameraTransform");
			BlackjackGameController.NativeFieldInfoPtr_localFinalCameraTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "localFinalCameraTransform");
			BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerBetChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "onLocalPlayerBetChange");
			BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerExitRound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "onLocalPlayerExitRound");
			BlackjackGameController.NativeFieldInfoPtr_onInitialCardsDealt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "onInitialCardsDealt");
			BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerReadyForInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "onLocalPlayerReadyForInput");
			BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerBust = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "onLocalPlayerBust");
			BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerRoundCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "onLocalPlayerRoundCompleted");
			BlackjackGameController.NativeFieldInfoPtr_roundEnded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "roundEnded");
			BlackjackGameController.NativeFieldInfoPtr_gameRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "gameRoutine");
			BlackjackGameController.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Casino.BlackjackGameControllerAssembly-CSharp.dll_Excuted");
			BlackjackGameController.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Casino.BlackjackGameControllerAssembly-CSharp.dll_Excuted");
			BlackjackGameController.NativeMethodInfoPtr_get_CurrentStage_Public_get_EStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676248);
			BlackjackGameController.NativeMethodInfoPtr_set_CurrentStage_Private_set_Void_EStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676249);
			BlackjackGameController.NativeMethodInfoPtr_get_PlayerTurn_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676250);
			BlackjackGameController.NativeMethodInfoPtr_set_PlayerTurn_Private_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676251);
			BlackjackGameController.NativeMethodInfoPtr_get_LocalPlayerBet_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676252);
			BlackjackGameController.NativeMethodInfoPtr_set_LocalPlayerBet_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676253);
			BlackjackGameController.NativeMethodInfoPtr_get_DealerScore_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676254);
			BlackjackGameController.NativeMethodInfoPtr_set_DealerScore_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676255);
			BlackjackGameController.NativeMethodInfoPtr_get_LocalPlayerScore_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676256);
			BlackjackGameController.NativeMethodInfoPtr_set_LocalPlayerScore_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676257);
			BlackjackGameController.NativeMethodInfoPtr_get_IsLocalPlayerBlackjack_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676258);
			BlackjackGameController.NativeMethodInfoPtr_set_IsLocalPlayerBlackjack_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676259);
			BlackjackGameController.NativeMethodInfoPtr_get_IsLocalPlayerBust_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676260);
			BlackjackGameController.NativeMethodInfoPtr_set_IsLocalPlayerBust_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676261);
			BlackjackGameController.NativeMethodInfoPtr_get_IsLocalPlayerInCurrentRound_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676262);
			BlackjackGameController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676263);
			BlackjackGameController.NativeMethodInfoPtr_Open_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676264);
			BlackjackGameController.NativeMethodInfoPtr_Close_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676265);
			BlackjackGameController.NativeMethodInfoPtr_Exit_Protected_Virtual_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676266);
			BlackjackGameController.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676267);
			BlackjackGameController.NativeMethodInfoPtr_GetClockwisePlayers_Private_List_1_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676268);
			BlackjackGameController.NativeMethodInfoPtr_StartGame_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676269);
			BlackjackGameController.NativeMethodInfoPtr_NotifyPlayerScore_Private_Void_NetworkObject_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676270);
			BlackjackGameController.NativeMethodInfoPtr_GetPlayerCardPositions_Private_Il2CppReferenceArray_1_Transform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676271);
			BlackjackGameController.NativeMethodInfoPtr_SetRoundEnded_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676272);
			BlackjackGameController.NativeMethodInfoPtr_AddCardToPlayerHand_Private_Void_Int32_PlayingCard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676273);
			BlackjackGameController.NativeMethodInfoPtr_AddCardToPlayerHand_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676274);
			BlackjackGameController.NativeMethodInfoPtr_AddCardToDealerHand_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676275);
			BlackjackGameController.NativeMethodInfoPtr_GetPlayerCards_Private_List_1_PlayingCard_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676276);
			BlackjackGameController.NativeMethodInfoPtr_GetHandScore_Private_Int32_List_1_PlayingCard_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676277);
			BlackjackGameController.NativeMethodInfoPtr_GetCardValue_Private_Int32_PlayingCard_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676278);
			BlackjackGameController.NativeMethodInfoPtr_DrawCard_Private_PlayingCard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676279);
			BlackjackGameController.NativeMethodInfoPtr_ResetCards_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676280);
			BlackjackGameController.NativeMethodInfoPtr_EndGame_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676281);
			BlackjackGameController.NativeMethodInfoPtr_RemoveLocalPlayerFromGame_Public_Void_EPayoutType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676282);
			BlackjackGameController.NativeMethodInfoPtr_GetPayout_Public_Single_Single_EPayoutType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676283);
			BlackjackGameController.NativeMethodInfoPtr_IsCurrentRoundEmpty_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676284);
			BlackjackGameController.NativeMethodInfoPtr_AddPlayerToCurrentRound_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676285);
			BlackjackGameController.NativeMethodInfoPtr_RequestRemovePlayerFromCurrentRound_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676286);
			BlackjackGameController.NativeMethodInfoPtr_RemovePlayerFromCurrentRound_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676287);
			BlackjackGameController.NativeMethodInfoPtr_SetLocalPlayerBet_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676288);
			BlackjackGameController.NativeMethodInfoPtr_AreAllPlayersReady_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676289);
			BlackjackGameController.NativeMethodInfoPtr_GetPlayersReadyCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676290);
			BlackjackGameController.NativeMethodInfoPtr_ToggleLocalPlayerReady_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676291);
			BlackjackGameController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676292);
			BlackjackGameController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676293);
			BlackjackGameController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676294);
			BlackjackGameController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676295);
			BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_StartGame_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676296);
			BlackjackGameController.NativeMethodInfoPtr_RpcLogic___StartGame_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676297);
			BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_StartGame_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676298);
			BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_NotifyPlayerScore_2864061566_Private_Void_NetworkObject_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676299);
			BlackjackGameController.NativeMethodInfoPtr_RpcLogic___NotifyPlayerScore_2864061566_Private_Void_NetworkObject_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676300);
			BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_NotifyPlayerScore_2864061566_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676301);
			BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_SetRoundEnded_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676302);
			BlackjackGameController.NativeMethodInfoPtr_RpcLogic___SetRoundEnded_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676303);
			BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_SetRoundEnded_1140765316_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676304);
			BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_AddCardToPlayerHand_2801973956_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676305);
			BlackjackGameController.NativeMethodInfoPtr_RpcLogic___AddCardToPlayerHand_2801973956_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676306);
			BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_AddCardToPlayerHand_2801973956_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676307);
			BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_AddCardToDealerHand_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676308);
			BlackjackGameController.NativeMethodInfoPtr_RpcLogic___AddCardToDealerHand_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676309);
			BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_AddCardToDealerHand_3615296227_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676310);
			BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_EndGame_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676311);
			BlackjackGameController.NativeMethodInfoPtr_RpcLogic___EndGame_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676312);
			BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_EndGame_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676313);
			BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_AddPlayerToCurrentRound_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676314);
			BlackjackGameController.NativeMethodInfoPtr_RpcLogic___AddPlayerToCurrentRound_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676315);
			BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_AddPlayerToCurrentRound_3323014238_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676316);
			BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Server_RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676317);
			BlackjackGameController.NativeMethodInfoPtr_RpcLogic___RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676318);
			BlackjackGameController.NativeMethodInfoPtr_RpcReader___Server_RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676319);
			BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_RemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676320);
			BlackjackGameController.NativeMethodInfoPtr_RpcLogic___RemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676321);
			BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_RemovePlayerFromCurrentRound_3323014238_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676322);
			BlackjackGameController.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676323);
		}

		// Token: 0x17001EFA RID: 7930
		// (get) Token: 0x06006664 RID: 26212 RVA: 0x001CD680 File Offset: 0x001CB880
		// (set) Token: 0x06006665 RID: 26213 RVA: 0x001CD6BC File Offset: 0x001CB8BC
		public unsafe BlackjackGameController.EStage CurrentStage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_get_CurrentStage_Public_get_EStage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_set_CurrentStage_Private_set_Void_EStage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001EFB RID: 7931
		// (get) Token: 0x06006666 RID: 26214 RVA: 0x001CD6FC File Offset: 0x001CB8FC
		// (set) Token: 0x06006667 RID: 26215 RVA: 0x001CD73C File Offset: 0x001CB93C
		public unsafe Player PlayerTurn
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_get_PlayerTurn_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_set_PlayerTurn_Private_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001EFC RID: 7932
		// (get) Token: 0x06006668 RID: 26216 RVA: 0x001CD780 File Offset: 0x001CB980
		// (set) Token: 0x06006669 RID: 26217 RVA: 0x001CD7BC File Offset: 0x001CB9BC
		public unsafe float LocalPlayerBet
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_get_LocalPlayerBet_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_set_LocalPlayerBet_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001EFD RID: 7933
		// (get) Token: 0x0600666A RID: 26218 RVA: 0x001CD7FC File Offset: 0x001CB9FC
		// (set) Token: 0x0600666B RID: 26219 RVA: 0x001CD838 File Offset: 0x001CBA38
		public unsafe int DealerScore
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_get_DealerScore_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_set_DealerScore_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001EFE RID: 7934
		// (get) Token: 0x0600666C RID: 26220 RVA: 0x001CD878 File Offset: 0x001CBA78
		// (set) Token: 0x0600666D RID: 26221 RVA: 0x001CD8B4 File Offset: 0x001CBAB4
		public unsafe int LocalPlayerScore
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_get_LocalPlayerScore_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_set_LocalPlayerScore_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001EFF RID: 7935
		// (get) Token: 0x0600666E RID: 26222 RVA: 0x001CD8F4 File Offset: 0x001CBAF4
		// (set) Token: 0x0600666F RID: 26223 RVA: 0x001CD930 File Offset: 0x001CBB30
		public unsafe bool IsLocalPlayerBlackjack
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_get_IsLocalPlayerBlackjack_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_set_IsLocalPlayerBlackjack_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001F00 RID: 7936
		// (get) Token: 0x06006670 RID: 26224 RVA: 0x001CD970 File Offset: 0x001CBB70
		// (set) Token: 0x06006671 RID: 26225 RVA: 0x001CD9AC File Offset: 0x001CBBAC
		public unsafe bool IsLocalPlayerBust
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_get_IsLocalPlayerBust_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_set_IsLocalPlayerBust_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001F01 RID: 7937
		// (get) Token: 0x06006672 RID: 26226 RVA: 0x001CD9EC File Offset: 0x001CBBEC
		public unsafe bool IsLocalPlayerInCurrentRound
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 207512, RefRangeEnd = 207517, XrefRangeStart = 207504, XrefRangeEnd = 207512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_get_IsLocalPlayerInCurrentRound_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06006673 RID: 26227 RVA: 0x001CDA28 File Offset: 0x001CBC28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207517, XrefRangeEnd = 207518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlackjackGameController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006674 RID: 26228 RVA: 0x001CDA64 File Offset: 0x001CBC64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207518, XrefRangeEnd = 207539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlackjackGameController.NativeMethodInfoPtr_Open_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006675 RID: 26229 RVA: 0x001CDAA0 File Offset: 0x001CBCA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207539, XrefRangeEnd = 207548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlackjackGameController.NativeMethodInfoPtr_Close_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006676 RID: 26230 RVA: 0x001CDADC File Offset: 0x001CBCDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207548, XrefRangeEnd = 207552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlackjackGameController.NativeMethodInfoPtr_Exit_Protected_Virtual_Void_ExitAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006677 RID: 26231 RVA: 0x001CDB2C File Offset: 0x001CBD2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207552, XrefRangeEnd = 207613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlackjackGameController.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006678 RID: 26232 RVA: 0x001CDB68 File Offset: 0x001CBD68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 207644, RefRangeEnd = 207646, XrefRangeStart = 207613, XrefRangeEnd = 207644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Player> GetClockwisePlayers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_GetClockwisePlayers_Private_List_1_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Player>>(intPtr3) : null;
		}

		// Token: 0x06006679 RID: 26233 RVA: 0x001CDBA8 File Offset: 0x001CBDA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207646, XrefRangeEnd = 207667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_StartGame_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600667A RID: 26234 RVA: 0x001CDBDC File Offset: 0x001CBDDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 207692, RefRangeEnd = 207694, XrefRangeStart = 207667, XrefRangeEnd = 207692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyPlayerScore(NetworkObject player, int score, bool blackjack)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref score;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blackjack;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_NotifyPlayerScore_Private_Void_NetworkObject_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600667B RID: 26235 RVA: 0x001CDC3C File Offset: 0x001CBE3C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 207694, RefRangeEnd = 207697, XrefRangeStart = 207694, XrefRangeEnd = 207694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Transform> GetPlayerCardPositions(int playerIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref playerIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_GetPlayerCardPositions_Private_Il2CppReferenceArray_1_Transform_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr3) : null;
		}

		// Token: 0x0600667C RID: 26236 RVA: 0x001CDC88 File Offset: 0x001CBE88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 207717, RefRangeEnd = 207718, XrefRangeStart = 207697, XrefRangeEnd = 207717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRoundEnded(bool ended)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref ended;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_SetRoundEnded_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600667D RID: 26237 RVA: 0x001CDCC8 File Offset: 0x001CBEC8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 207742, RefRangeEnd = 207745, XrefRangeStart = 207718, XrefRangeEnd = 207742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCardToPlayerHand(int playerIndex, PlayingCard card)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref playerIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(card);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_AddCardToPlayerHand_Private_Void_Int32_PlayingCard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600667E RID: 26238 RVA: 0x001CDD18 File Offset: 0x001CBF18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207745, XrefRangeEnd = 207769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCardToPlayerHand(int playerindex, string cardID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref playerindex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(cardID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_AddCardToPlayerHand_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600667F RID: 26239 RVA: 0x001CDD68 File Offset: 0x001CBF68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 207791, RefRangeEnd = 207793, XrefRangeStart = 207769, XrefRangeEnd = 207791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCardToDealerHand(string cardID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_AddCardToDealerHand_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006680 RID: 26240 RVA: 0x001CDDAC File Offset: 0x001CBFAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 207793, RefRangeEnd = 207794, XrefRangeStart = 207793, XrefRangeEnd = 207793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<PlayingCard> GetPlayerCards(int playerIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref playerIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_GetPlayerCards_Private_List_1_PlayingCard_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<PlayingCard>>(intPtr3) : null;
		}

		// Token: 0x06006681 RID: 26241 RVA: 0x001CDDF8 File Offset: 0x001CBFF8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 207822, RefRangeEnd = 207825, XrefRangeStart = 207794, XrefRangeEnd = 207822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetHandScore(List<PlayingCard> cards, bool countFaceDown = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cards);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref countFaceDown;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_GetHandScore_Private_Int32_List_1_PlayingCard_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006682 RID: 26242 RVA: 0x001CDE54 File Offset: 0x001CC054
		[CallerCount(0)]
		public unsafe int GetCardValue(PlayingCard card, bool aceAsEleven = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref aceAsEleven;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_GetCardValue_Private_Int32_PlayingCard_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006683 RID: 26243 RVA: 0x001CDEB0 File Offset: 0x001CC0B0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 207844, RefRangeEnd = 207849, XrefRangeStart = 207825, XrefRangeEnd = 207844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayingCard DrawCard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_DrawCard_Private_PlayingCard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayingCard>(intPtr3) : null;
		}

		// Token: 0x06006684 RID: 26244 RVA: 0x001CDEF0 File Offset: 0x001CC0F0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 207882, RefRangeEnd = 207887, XrefRangeStart = 207849, XrefRangeEnd = 207882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetCards()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_ResetCards_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006685 RID: 26245 RVA: 0x001CDF24 File Offset: 0x001CC124
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 207909, RefRangeEnd = 207910, XrefRangeStart = 207887, XrefRangeEnd = 207909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_EndGame_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006686 RID: 26246 RVA: 0x001CDF58 File Offset: 0x001CC158
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 207956, RefRangeEnd = 207959, XrefRangeStart = 207910, XrefRangeEnd = 207956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveLocalPlayerFromGame(BlackjackGameController.EPayoutType payout, float cameraDelay = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref payout;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cameraDelay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RemoveLocalPlayerFromGame_Public_Void_EPayoutType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006687 RID: 26247 RVA: 0x001CDFA4 File Offset: 0x001CC1A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 207959, RefRangeEnd = 207960, XrefRangeStart = 207959, XrefRangeEnd = 207959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetPayout(float bet, BlackjackGameController.EPayoutType payout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref bet;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref payout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_GetPayout_Public_Single_Single_EPayoutType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006688 RID: 26248 RVA: 0x001CDFFC File Offset: 0x001CC1FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207960, XrefRangeEnd = 207961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCurrentRoundEmpty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_IsCurrentRoundEmpty_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006689 RID: 26249 RVA: 0x001CE038 File Offset: 0x001CC238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207961, XrefRangeEnd = 207983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPlayerToCurrentRound(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_AddPlayerToCurrentRound_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600668A RID: 26250 RVA: 0x001CE07C File Offset: 0x001CC27C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207983, XrefRangeEnd = 208005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestRemovePlayerFromCurrentRound(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RequestRemovePlayerFromCurrentRound_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600668B RID: 26251 RVA: 0x001CE0C0 File Offset: 0x001CC2C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 208027, RefRangeEnd = 208030, XrefRangeStart = 208005, XrefRangeEnd = 208027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemovePlayerFromCurrentRound(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RemovePlayerFromCurrentRound_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600668C RID: 26252 RVA: 0x001CE104 File Offset: 0x001CC304
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 208030, RefRangeEnd = 208032, XrefRangeStart = 208030, XrefRangeEnd = 208030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLocalPlayerBet(float bet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref bet;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_SetLocalPlayerBet_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600668D RID: 26253 RVA: 0x001CE144 File Offset: 0x001CC344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208032, XrefRangeEnd = 208047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreAllPlayersReady()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_AreAllPlayersReady_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600668E RID: 26254 RVA: 0x001CE180 File Offset: 0x001CC380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208047, XrefRangeEnd = 208060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPlayersReadyCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_GetPlayersReadyCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600668F RID: 26255 RVA: 0x001CE1BC File Offset: 0x001CC3BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 208079, RefRangeEnd = 208080, XrefRangeStart = 208060, XrefRangeEnd = 208079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleLocalPlayerReady()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_ToggleLocalPlayerReady_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006690 RID: 26256 RVA: 0x001CE1F0 File Offset: 0x001CC3F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208080, XrefRangeEnd = 208132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlackjackGameController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006691 RID: 26257 RVA: 0x001CE22C File Offset: 0x001CC42C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208132, XrefRangeEnd = 208188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlackjackGameController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006692 RID: 26258 RVA: 0x001CE268 File Offset: 0x001CC468
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlackjackGameController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006693 RID: 26259 RVA: 0x001CE2A4 File Offset: 0x001CC4A4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlackjackGameController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006694 RID: 26260 RVA: 0x001CE2E0 File Offset: 0x001CC4E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208188, XrefRangeEnd = 208206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_StartGame_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_StartGame_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006695 RID: 26261 RVA: 0x001CE314 File Offset: 0x001CC514
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 208263, RefRangeEnd = 208268, XrefRangeStart = 208206, XrefRangeEnd = 208263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___StartGame_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcLogic___StartGame_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006696 RID: 26262 RVA: 0x001CE348 File Offset: 0x001CC548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208268, XrefRangeEnd = 208271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_StartGame_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_StartGame_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006697 RID: 26263 RVA: 0x001CE398 File Offset: 0x001CC598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208271, XrefRangeEnd = 208284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_NotifyPlayerScore_2864061566(NetworkObject player, int score, bool blackjack)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref score;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blackjack;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_NotifyPlayerScore_2864061566_Private_Void_NetworkObject_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006698 RID: 26264 RVA: 0x001CE3F8 File Offset: 0x001CC5F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 208292, RefRangeEnd = 208294, XrefRangeStart = 208284, XrefRangeEnd = 208292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___NotifyPlayerScore_2864061566(NetworkObject player, int score, bool blackjack)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref score;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blackjack;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcLogic___NotifyPlayerScore_2864061566_Private_Void_NetworkObject_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006699 RID: 26265 RVA: 0x001CE458 File Offset: 0x001CC658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208294, XrefRangeEnd = 208300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_NotifyPlayerScore_2864061566(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_NotifyPlayerScore_2864061566_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600669A RID: 26266 RVA: 0x001CE4A8 File Offset: 0x001CC6A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208300, XrefRangeEnd = 208319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetRoundEnded_1140765316(bool ended)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref ended;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_SetRoundEnded_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600669B RID: 26267 RVA: 0x001CE4E8 File Offset: 0x001CC6E8
		[CallerCount(0)]
		public unsafe void RpcLogic___SetRoundEnded_1140765316(bool ended)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref ended;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcLogic___SetRoundEnded_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600669C RID: 26268 RVA: 0x001CE528 File Offset: 0x001CC728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208319, XrefRangeEnd = 208321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetRoundEnded_1140765316(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_SetRoundEnded_1140765316_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600669D RID: 26269 RVA: 0x001CE578 File Offset: 0x001CC778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208321, XrefRangeEnd = 208342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AddCardToPlayerHand_2801973956(int playerindex, string cardID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref playerindex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(cardID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_AddCardToPlayerHand_2801973956_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600669E RID: 26270 RVA: 0x001CE5C8 File Offset: 0x001CC7C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 208366, RefRangeEnd = 208369, XrefRangeStart = 208342, XrefRangeEnd = 208366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AddCardToPlayerHand_2801973956(int playerindex, string cardID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref playerindex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(cardID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcLogic___AddCardToPlayerHand_2801973956_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600669F RID: 26271 RVA: 0x001CE618 File Offset: 0x001CC818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208369, XrefRangeEnd = 208375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AddCardToPlayerHand_2801973956(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_AddCardToPlayerHand_2801973956_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066A0 RID: 26272 RVA: 0x001CE668 File Offset: 0x001CC868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208375, XrefRangeEnd = 208394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AddCardToDealerHand_3615296227(string cardID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_AddCardToDealerHand_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066A1 RID: 26273 RVA: 0x001CE6AC File Offset: 0x001CC8AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 208418, RefRangeEnd = 208420, XrefRangeStart = 208394, XrefRangeEnd = 208418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AddCardToDealerHand_3615296227(string cardID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcLogic___AddCardToDealerHand_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066A2 RID: 26274 RVA: 0x001CE6F0 File Offset: 0x001CC8F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208420, XrefRangeEnd = 208424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AddCardToDealerHand_3615296227(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_AddCardToDealerHand_3615296227_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066A3 RID: 26275 RVA: 0x001CE740 File Offset: 0x001CC940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208424, XrefRangeEnd = 208442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_EndGame_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_EndGame_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066A4 RID: 26276 RVA: 0x001CE774 File Offset: 0x001CC974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208442, XrefRangeEnd = 208444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___EndGame_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcLogic___EndGame_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066A5 RID: 26277 RVA: 0x001CE7A8 File Offset: 0x001CC9A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208444, XrefRangeEnd = 208448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_EndGame_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_EndGame_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066A6 RID: 26278 RVA: 0x001CE7F8 File Offset: 0x001CC9F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208448, XrefRangeEnd = 208467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AddPlayerToCurrentRound_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_AddPlayerToCurrentRound_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066A7 RID: 26279 RVA: 0x001CE83C File Offset: 0x001CCA3C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 208488, RefRangeEnd = 208491, XrefRangeStart = 208467, XrefRangeEnd = 208488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AddPlayerToCurrentRound_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcLogic___AddPlayerToCurrentRound_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066A8 RID: 26280 RVA: 0x001CE880 File Offset: 0x001CCA80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208491, XrefRangeEnd = 208495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AddPlayerToCurrentRound_3323014238(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_AddPlayerToCurrentRound_3323014238_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066A9 RID: 26281 RVA: 0x001CE8D0 File Offset: 0x001CCAD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208495, XrefRangeEnd = 208514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_RequestRemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Server_RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066AA RID: 26282 RVA: 0x001CE914 File Offset: 0x001CCB14
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 208027, RefRangeEnd = 208030, XrefRangeStart = 208027, XrefRangeEnd = 208030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RequestRemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcLogic___RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066AB RID: 26283 RVA: 0x001CE958 File Offset: 0x001CCB58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208514, XrefRangeEnd = 208518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_RequestRemovePlayerFromCurrentRound_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcReader___Server_RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066AC RID: 26284 RVA: 0x001CE9BC File Offset: 0x001CCBBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208518, XrefRangeEnd = 208537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_RemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_RemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066AD RID: 26285 RVA: 0x001CEA00 File Offset: 0x001CCC00
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 208558, RefRangeEnd = 208561, XrefRangeStart = 208537, XrefRangeEnd = 208558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcLogic___RemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066AE RID: 26286 RVA: 0x001CEA44 File Offset: 0x001CCC44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208561, XrefRangeEnd = 208565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_RemovePlayerFromCurrentRound_3323014238(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_RemovePlayerFromCurrentRound_3323014238_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066AF RID: 26287 RVA: 0x001CEA94 File Offset: 0x001CCC94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 208588, RefRangeEnd = 208589, XrefRangeStart = 208565, XrefRangeEnd = 208588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlackjackGameController.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066B0 RID: 26288 RVA: 0x000306C1 File Offset: 0x0002E8C1
		public BlackjackGameController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001ED1 RID: 7889
		// (get) Token: 0x060066B1 RID: 26289 RVA: 0x001CEAD0 File Offset: 0x001CCCD0
		// (set) Token: 0x060066B2 RID: 26290 RVA: 0x000306CA File Offset: 0x0002E8CA
		public unsafe static int BET_MINIMUM
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(BlackjackGameController.NativeFieldInfoPtr_BET_MINIMUM, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BlackjackGameController.NativeFieldInfoPtr_BET_MINIMUM, (void*)(&value));
			}
		}

		// Token: 0x17001ED2 RID: 7890
		// (get) Token: 0x060066B3 RID: 26291 RVA: 0x001CEAEC File Offset: 0x001CCCEC
		// (set) Token: 0x060066B4 RID: 26292 RVA: 0x000306D8 File Offset: 0x0002E8D8
		public unsafe static int BET_MAXIMUM
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(BlackjackGameController.NativeFieldInfoPtr_BET_MAXIMUM, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BlackjackGameController.NativeFieldInfoPtr_BET_MAXIMUM, (void*)(&value));
			}
		}

		// Token: 0x17001ED3 RID: 7891
		// (get) Token: 0x060066B5 RID: 26293 RVA: 0x001CEB08 File Offset: 0x001CCD08
		// (set) Token: 0x060066B6 RID: 26294 RVA: 0x000306E6 File Offset: 0x0002E8E6
		public unsafe static float PAYOUT_RATIO
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BlackjackGameController.NativeFieldInfoPtr_PAYOUT_RATIO, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BlackjackGameController.NativeFieldInfoPtr_PAYOUT_RATIO, (void*)(&value));
			}
		}

		// Token: 0x17001ED4 RID: 7892
		// (get) Token: 0x060066B7 RID: 26295 RVA: 0x001CEB24 File Offset: 0x001CCD24
		// (set) Token: 0x060066B8 RID: 26296 RVA: 0x000306F4 File Offset: 0x0002E8F4
		public unsafe static float BLACKJACK_PAYOUT_RATIO
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BlackjackGameController.NativeFieldInfoPtr_BLACKJACK_PAYOUT_RATIO, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BlackjackGameController.NativeFieldInfoPtr_BLACKJACK_PAYOUT_RATIO, (void*)(&value));
			}
		}

		// Token: 0x17001ED5 RID: 7893
		// (get) Token: 0x060066B9 RID: 26297 RVA: 0x001CEB40 File Offset: 0x001CCD40
		// (set) Token: 0x060066BA RID: 26298 RVA: 0x00030702 File Offset: 0x0002E902
		public unsafe BlackjackGameController.EStage _CurrentStage_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__CurrentStage_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__CurrentStage_k__BackingField)) = value;
			}
		}

		// Token: 0x17001ED6 RID: 7894
		// (get) Token: 0x060066BB RID: 26299 RVA: 0x001CEB68 File Offset: 0x001CCD68
		// (set) Token: 0x060066BC RID: 26300 RVA: 0x0003071D File Offset: 0x0002E91D
		public unsafe Player _PlayerTurn_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__PlayerTurn_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__PlayerTurn_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ED7 RID: 7895
		// (get) Token: 0x060066BD RID: 26301 RVA: 0x001CEB98 File Offset: 0x001CCD98
		// (set) Token: 0x060066BE RID: 26302 RVA: 0x0003073C File Offset: 0x0002E93C
		public unsafe float _LocalPlayerBet_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__LocalPlayerBet_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__LocalPlayerBet_k__BackingField)) = value;
			}
		}

		// Token: 0x17001ED8 RID: 7896
		// (get) Token: 0x060066BF RID: 26303 RVA: 0x001CEBC0 File Offset: 0x001CCDC0
		// (set) Token: 0x060066C0 RID: 26304 RVA: 0x00030757 File Offset: 0x0002E957
		public unsafe int _DealerScore_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__DealerScore_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__DealerScore_k__BackingField)) = value;
			}
		}

		// Token: 0x17001ED9 RID: 7897
		// (get) Token: 0x060066C1 RID: 26305 RVA: 0x001CEBE8 File Offset: 0x001CCDE8
		// (set) Token: 0x060066C2 RID: 26306 RVA: 0x00030772 File Offset: 0x0002E972
		public unsafe int _LocalPlayerScore_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__LocalPlayerScore_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__LocalPlayerScore_k__BackingField)) = value;
			}
		}

		// Token: 0x17001EDA RID: 7898
		// (get) Token: 0x060066C3 RID: 26307 RVA: 0x001CEC10 File Offset: 0x001CCE10
		// (set) Token: 0x060066C4 RID: 26308 RVA: 0x0003078D File Offset: 0x0002E98D
		public unsafe bool _IsLocalPlayerBlackjack_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__IsLocalPlayerBlackjack_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__IsLocalPlayerBlackjack_k__BackingField)) = value;
			}
		}

		// Token: 0x17001EDB RID: 7899
		// (get) Token: 0x060066C5 RID: 26309 RVA: 0x001CEC38 File Offset: 0x001CCE38
		// (set) Token: 0x060066C6 RID: 26310 RVA: 0x000307A8 File Offset: 0x0002E9A8
		public unsafe bool _IsLocalPlayerBust_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__IsLocalPlayerBust_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__IsLocalPlayerBust_k__BackingField)) = value;
			}
		}

		// Token: 0x17001EDC RID: 7900
		// (get) Token: 0x060066C7 RID: 26311 RVA: 0x001CEC60 File Offset: 0x001CCE60
		// (set) Token: 0x060066C8 RID: 26312 RVA: 0x000307C3 File Offset: 0x0002E9C3
		public unsafe Il2CppReferenceArray<PlayingCard> Cards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_Cards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PlayingCard>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_Cards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EDD RID: 7901
		// (get) Token: 0x060066C9 RID: 26313 RVA: 0x001CEC90 File Offset: 0x001CCE90
		// (set) Token: 0x060066CA RID: 26314 RVA: 0x000307E2 File Offset: 0x0002E9E2
		public unsafe Il2CppReferenceArray<Transform> DefaultCardPositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_DefaultCardPositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_DefaultCardPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EDE RID: 7902
		// (get) Token: 0x060066CB RID: 26315 RVA: 0x001CECC0 File Offset: 0x001CCEC0
		// (set) Token: 0x060066CC RID: 26316 RVA: 0x00030801 File Offset: 0x0002EA01
		public unsafe Il2CppReferenceArray<Transform> FocusedCameraTransforms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_FocusedCameraTransforms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_FocusedCameraTransforms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EDF RID: 7903
		// (get) Token: 0x060066CD RID: 26317 RVA: 0x001CECF0 File Offset: 0x001CCEF0
		// (set) Token: 0x060066CE RID: 26318 RVA: 0x00030820 File Offset: 0x0002EA20
		public unsafe Il2CppReferenceArray<Transform> FinalCameraTransforms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_FinalCameraTransforms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_FinalCameraTransforms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EE0 RID: 7904
		// (get) Token: 0x060066CF RID: 26319 RVA: 0x001CED20 File Offset: 0x001CCF20
		// (set) Token: 0x060066D0 RID: 26320 RVA: 0x0003083F File Offset: 0x0002EA3F
		public unsafe Il2CppReferenceArray<Transform> Player1CardPositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_Player1CardPositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_Player1CardPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EE1 RID: 7905
		// (get) Token: 0x060066D1 RID: 26321 RVA: 0x001CED50 File Offset: 0x001CCF50
		// (set) Token: 0x060066D2 RID: 26322 RVA: 0x0003085E File Offset: 0x0002EA5E
		public unsafe Il2CppReferenceArray<Transform> Player2CardPositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_Player2CardPositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_Player2CardPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EE2 RID: 7906
		// (get) Token: 0x060066D3 RID: 26323 RVA: 0x001CED80 File Offset: 0x001CCF80
		// (set) Token: 0x060066D4 RID: 26324 RVA: 0x0003087D File Offset: 0x0002EA7D
		public unsafe Il2CppReferenceArray<Transform> Player3CardPositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_Player3CardPositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_Player3CardPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EE3 RID: 7907
		// (get) Token: 0x060066D5 RID: 26325 RVA: 0x001CEDB0 File Offset: 0x001CCFB0
		// (set) Token: 0x060066D6 RID: 26326 RVA: 0x0003089C File Offset: 0x0002EA9C
		public unsafe Il2CppReferenceArray<Transform> Player4CardPositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_Player4CardPositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_Player4CardPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EE4 RID: 7908
		// (get) Token: 0x060066D7 RID: 26327 RVA: 0x001CEDE0 File Offset: 0x001CCFE0
		// (set) Token: 0x060066D8 RID: 26328 RVA: 0x000308BB File Offset: 0x0002EABB
		public unsafe Il2CppReferenceArray<Transform> DealerCardPositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_DealerCardPositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_DealerCardPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EE5 RID: 7909
		// (get) Token: 0x060066D9 RID: 26329 RVA: 0x001CEE10 File Offset: 0x001CD010
		// (set) Token: 0x060066DA RID: 26330 RVA: 0x000308DA File Offset: 0x0002EADA
		public unsafe List<Player> playersInCurrentRound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_playersInCurrentRound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_playersInCurrentRound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EE6 RID: 7910
		// (get) Token: 0x060066DB RID: 26331 RVA: 0x001CEE40 File Offset: 0x001CD040
		// (set) Token: 0x060066DC RID: 26332 RVA: 0x000308F9 File Offset: 0x0002EAF9
		public unsafe List<PlayingCard> playStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_playStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayingCard>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_playStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EE7 RID: 7911
		// (get) Token: 0x060066DD RID: 26333 RVA: 0x001CEE70 File Offset: 0x001CD070
		// (set) Token: 0x060066DE RID: 26334 RVA: 0x00030918 File Offset: 0x0002EB18
		public unsafe List<PlayingCard> player1Hand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_player1Hand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayingCard>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_player1Hand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EE8 RID: 7912
		// (get) Token: 0x060066DF RID: 26335 RVA: 0x001CEEA0 File Offset: 0x001CD0A0
		// (set) Token: 0x060066E0 RID: 26336 RVA: 0x00030937 File Offset: 0x0002EB37
		public unsafe List<PlayingCard> player2Hand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_player2Hand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayingCard>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_player2Hand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EE9 RID: 7913
		// (get) Token: 0x060066E1 RID: 26337 RVA: 0x001CEED0 File Offset: 0x001CD0D0
		// (set) Token: 0x060066E2 RID: 26338 RVA: 0x00030956 File Offset: 0x0002EB56
		public unsafe List<PlayingCard> player3Hand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_player3Hand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayingCard>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_player3Hand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EEA RID: 7914
		// (get) Token: 0x060066E3 RID: 26339 RVA: 0x001CEF00 File Offset: 0x001CD100
		// (set) Token: 0x060066E4 RID: 26340 RVA: 0x00030975 File Offset: 0x0002EB75
		public unsafe List<PlayingCard> player4Hand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_player4Hand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayingCard>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_player4Hand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EEB RID: 7915
		// (get) Token: 0x060066E5 RID: 26341 RVA: 0x001CEF30 File Offset: 0x001CD130
		// (set) Token: 0x060066E6 RID: 26342 RVA: 0x00030994 File Offset: 0x0002EB94
		public unsafe List<PlayingCard> dealerHand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_dealerHand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayingCard>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_dealerHand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EEC RID: 7916
		// (get) Token: 0x060066E7 RID: 26343 RVA: 0x001CEF60 File Offset: 0x001CD160
		// (set) Token: 0x060066E8 RID: 26344 RVA: 0x000309B3 File Offset: 0x0002EBB3
		public unsafe List<PlayingCard.CardData> cardValuesInDeck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_cardValuesInDeck);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayingCard.CardData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_cardValuesInDeck), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EED RID: 7917
		// (get) Token: 0x060066E9 RID: 26345 RVA: 0x001CEF90 File Offset: 0x001CD190
		// (set) Token: 0x060066EA RID: 26346 RVA: 0x000309D2 File Offset: 0x0002EBD2
		public unsafe List<PlayingCard.CardData> drawnCardsValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_drawnCardsValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayingCard.CardData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_drawnCardsValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EEE RID: 7918
		// (get) Token: 0x060066EB RID: 26347 RVA: 0x001CEFC0 File Offset: 0x001CD1C0
		// (set) Token: 0x060066EC RID: 26348 RVA: 0x000309F1 File Offset: 0x0002EBF1
		public unsafe Transform localFocusCameraTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_localFocusCameraTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_localFocusCameraTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EEF RID: 7919
		// (get) Token: 0x060066ED RID: 26349 RVA: 0x001CEFF0 File Offset: 0x001CD1F0
		// (set) Token: 0x060066EE RID: 26350 RVA: 0x00030A10 File Offset: 0x0002EC10
		public unsafe Transform localFinalCameraTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_localFinalCameraTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_localFinalCameraTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EF0 RID: 7920
		// (get) Token: 0x060066EF RID: 26351 RVA: 0x001CF020 File Offset: 0x001CD220
		// (set) Token: 0x060066F0 RID: 26352 RVA: 0x00030A2F File Offset: 0x0002EC2F
		public unsafe Action onLocalPlayerBetChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerBetChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerBetChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EF1 RID: 7921
		// (get) Token: 0x060066F1 RID: 26353 RVA: 0x001CF050 File Offset: 0x001CD250
		// (set) Token: 0x060066F2 RID: 26354 RVA: 0x00030A4E File Offset: 0x0002EC4E
		public unsafe Action onLocalPlayerExitRound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerExitRound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerExitRound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EF2 RID: 7922
		// (get) Token: 0x060066F3 RID: 26355 RVA: 0x001CF080 File Offset: 0x001CD280
		// (set) Token: 0x060066F4 RID: 26356 RVA: 0x00030A6D File Offset: 0x0002EC6D
		public unsafe Action onInitialCardsDealt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_onInitialCardsDealt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_onInitialCardsDealt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EF3 RID: 7923
		// (get) Token: 0x060066F5 RID: 26357 RVA: 0x001CF0B0 File Offset: 0x001CD2B0
		// (set) Token: 0x060066F6 RID: 26358 RVA: 0x00030A8C File Offset: 0x0002EC8C
		public unsafe Action onLocalPlayerReadyForInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerReadyForInput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerReadyForInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EF4 RID: 7924
		// (get) Token: 0x060066F7 RID: 26359 RVA: 0x001CF0E0 File Offset: 0x001CD2E0
		// (set) Token: 0x060066F8 RID: 26360 RVA: 0x00030AAB File Offset: 0x0002ECAB
		public unsafe Action onLocalPlayerBust
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerBust);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerBust), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EF5 RID: 7925
		// (get) Token: 0x060066F9 RID: 26361 RVA: 0x001CF110 File Offset: 0x001CD310
		// (set) Token: 0x060066FA RID: 26362 RVA: 0x00030ACA File Offset: 0x0002ECCA
		public unsafe Action<BlackjackGameController.EPayoutType> onLocalPlayerRoundCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerRoundCompleted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<BlackjackGameController.EPayoutType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerRoundCompleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EF6 RID: 7926
		// (get) Token: 0x060066FB RID: 26363 RVA: 0x001CF140 File Offset: 0x001CD340
		// (set) Token: 0x060066FC RID: 26364 RVA: 0x00030AE9 File Offset: 0x0002ECE9
		public unsafe bool roundEnded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_roundEnded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_roundEnded)) = value;
			}
		}

		// Token: 0x17001EF7 RID: 7927
		// (get) Token: 0x060066FD RID: 26365 RVA: 0x001CF168 File Offset: 0x001CD368
		// (set) Token: 0x060066FE RID: 26366 RVA: 0x00030B04 File Offset: 0x0002ED04
		public unsafe Coroutine gameRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_gameRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_gameRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EF8 RID: 7928
		// (get) Token: 0x060066FF RID: 26367 RVA: 0x001CF198 File Offset: 0x001CD398
		// (set) Token: 0x06006700 RID: 26368 RVA: 0x00030B23 File Offset: 0x0002ED23
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001EF9 RID: 7929
		// (get) Token: 0x06006701 RID: 26369 RVA: 0x001CF1C0 File Offset: 0x001CD3C0
		// (set) Token: 0x06006702 RID: 26370 RVA: 0x00030B3E File Offset: 0x0002ED3E
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004609 RID: 17929
		private static readonly IntPtr NativeFieldInfoPtr_BET_MINIMUM;

		// Token: 0x0400460A RID: 17930
		private static readonly IntPtr NativeFieldInfoPtr_BET_MAXIMUM;

		// Token: 0x0400460B RID: 17931
		private static readonly IntPtr NativeFieldInfoPtr_PAYOUT_RATIO;

		// Token: 0x0400460C RID: 17932
		private static readonly IntPtr NativeFieldInfoPtr_BLACKJACK_PAYOUT_RATIO;

		// Token: 0x0400460D RID: 17933
		private static readonly IntPtr NativeFieldInfoPtr__CurrentStage_k__BackingField;

		// Token: 0x0400460E RID: 17934
		private static readonly IntPtr NativeFieldInfoPtr__PlayerTurn_k__BackingField;

		// Token: 0x0400460F RID: 17935
		private static readonly IntPtr NativeFieldInfoPtr__LocalPlayerBet_k__BackingField;

		// Token: 0x04004610 RID: 17936
		private static readonly IntPtr NativeFieldInfoPtr__DealerScore_k__BackingField;

		// Token: 0x04004611 RID: 17937
		private static readonly IntPtr NativeFieldInfoPtr__LocalPlayerScore_k__BackingField;

		// Token: 0x04004612 RID: 17938
		private static readonly IntPtr NativeFieldInfoPtr__IsLocalPlayerBlackjack_k__BackingField;

		// Token: 0x04004613 RID: 17939
		private static readonly IntPtr NativeFieldInfoPtr__IsLocalPlayerBust_k__BackingField;

		// Token: 0x04004614 RID: 17940
		private static readonly IntPtr NativeFieldInfoPtr_Cards;

		// Token: 0x04004615 RID: 17941
		private static readonly IntPtr NativeFieldInfoPtr_DefaultCardPositions;

		// Token: 0x04004616 RID: 17942
		private static readonly IntPtr NativeFieldInfoPtr_FocusedCameraTransforms;

		// Token: 0x04004617 RID: 17943
		private static readonly IntPtr NativeFieldInfoPtr_FinalCameraTransforms;

		// Token: 0x04004618 RID: 17944
		private static readonly IntPtr NativeFieldInfoPtr_Player1CardPositions;

		// Token: 0x04004619 RID: 17945
		private static readonly IntPtr NativeFieldInfoPtr_Player2CardPositions;

		// Token: 0x0400461A RID: 17946
		private static readonly IntPtr NativeFieldInfoPtr_Player3CardPositions;

		// Token: 0x0400461B RID: 17947
		private static readonly IntPtr NativeFieldInfoPtr_Player4CardPositions;

		// Token: 0x0400461C RID: 17948
		private static readonly IntPtr NativeFieldInfoPtr_DealerCardPositions;

		// Token: 0x0400461D RID: 17949
		private static readonly IntPtr NativeFieldInfoPtr_playersInCurrentRound;

		// Token: 0x0400461E RID: 17950
		private static readonly IntPtr NativeFieldInfoPtr_playStack;

		// Token: 0x0400461F RID: 17951
		private static readonly IntPtr NativeFieldInfoPtr_player1Hand;

		// Token: 0x04004620 RID: 17952
		private static readonly IntPtr NativeFieldInfoPtr_player2Hand;

		// Token: 0x04004621 RID: 17953
		private static readonly IntPtr NativeFieldInfoPtr_player3Hand;

		// Token: 0x04004622 RID: 17954
		private static readonly IntPtr NativeFieldInfoPtr_player4Hand;

		// Token: 0x04004623 RID: 17955
		private static readonly IntPtr NativeFieldInfoPtr_dealerHand;

		// Token: 0x04004624 RID: 17956
		private static readonly IntPtr NativeFieldInfoPtr_cardValuesInDeck;

		// Token: 0x04004625 RID: 17957
		private static readonly IntPtr NativeFieldInfoPtr_drawnCardsValues;

		// Token: 0x04004626 RID: 17958
		private static readonly IntPtr NativeFieldInfoPtr_localFocusCameraTransform;

		// Token: 0x04004627 RID: 17959
		private static readonly IntPtr NativeFieldInfoPtr_localFinalCameraTransform;

		// Token: 0x04004628 RID: 17960
		private static readonly IntPtr NativeFieldInfoPtr_onLocalPlayerBetChange;

		// Token: 0x04004629 RID: 17961
		private static readonly IntPtr NativeFieldInfoPtr_onLocalPlayerExitRound;

		// Token: 0x0400462A RID: 17962
		private static readonly IntPtr NativeFieldInfoPtr_onInitialCardsDealt;

		// Token: 0x0400462B RID: 17963
		private static readonly IntPtr NativeFieldInfoPtr_onLocalPlayerReadyForInput;

		// Token: 0x0400462C RID: 17964
		private static readonly IntPtr NativeFieldInfoPtr_onLocalPlayerBust;

		// Token: 0x0400462D RID: 17965
		private static readonly IntPtr NativeFieldInfoPtr_onLocalPlayerRoundCompleted;

		// Token: 0x0400462E RID: 17966
		private static readonly IntPtr NativeFieldInfoPtr_roundEnded;

		// Token: 0x0400462F RID: 17967
		private static readonly IntPtr NativeFieldInfoPtr_gameRoutine;

		// Token: 0x04004630 RID: 17968
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004631 RID: 17969
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004632 RID: 17970
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentStage_Public_get_EStage_0;

		// Token: 0x04004633 RID: 17971
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentStage_Private_set_Void_EStage_0;

		// Token: 0x04004634 RID: 17972
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerTurn_Public_get_Player_0;

		// Token: 0x04004635 RID: 17973
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayerTurn_Private_set_Void_Player_0;

		// Token: 0x04004636 RID: 17974
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalPlayerBet_Public_get_Single_0;

		// Token: 0x04004637 RID: 17975
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalPlayerBet_Private_set_Void_Single_0;

		// Token: 0x04004638 RID: 17976
		private static readonly IntPtr NativeMethodInfoPtr_get_DealerScore_Public_get_Int32_0;

		// Token: 0x04004639 RID: 17977
		private static readonly IntPtr NativeMethodInfoPtr_set_DealerScore_Private_set_Void_Int32_0;

		// Token: 0x0400463A RID: 17978
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalPlayerScore_Public_get_Int32_0;

		// Token: 0x0400463B RID: 17979
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalPlayerScore_Private_set_Void_Int32_0;

		// Token: 0x0400463C RID: 17980
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLocalPlayerBlackjack_Public_get_Boolean_0;

		// Token: 0x0400463D RID: 17981
		private static readonly IntPtr NativeMethodInfoPtr_set_IsLocalPlayerBlackjack_Private_set_Void_Boolean_0;

		// Token: 0x0400463E RID: 17982
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLocalPlayerBust_Public_get_Boolean_0;

		// Token: 0x0400463F RID: 17983
		private static readonly IntPtr NativeMethodInfoPtr_set_IsLocalPlayerBust_Private_set_Void_Boolean_0;

		// Token: 0x04004640 RID: 17984
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLocalPlayerInCurrentRound_Public_get_Boolean_0;

		// Token: 0x04004641 RID: 17985
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04004642 RID: 17986
		private static readonly IntPtr NativeMethodInfoPtr_Open_Protected_Virtual_Void_1;

		// Token: 0x04004643 RID: 17987
		private static readonly IntPtr NativeMethodInfoPtr_Close_Protected_Virtual_Void_1;

		// Token: 0x04004644 RID: 17988
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Protected_Virtual_Void_ExitAction_0;

		// Token: 0x04004645 RID: 17989
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_1;

		// Token: 0x04004646 RID: 17990
		private static readonly IntPtr NativeMethodInfoPtr_GetClockwisePlayers_Private_List_1_Player_0;

		// Token: 0x04004647 RID: 17991
		private static readonly IntPtr NativeMethodInfoPtr_StartGame_Private_Void_0;

		// Token: 0x04004648 RID: 17992
		private static readonly IntPtr NativeMethodInfoPtr_NotifyPlayerScore_Private_Void_NetworkObject_Int32_Boolean_0;

		// Token: 0x04004649 RID: 17993
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerCardPositions_Private_Il2CppReferenceArray_1_Transform_Int32_0;

		// Token: 0x0400464A RID: 17994
		private static readonly IntPtr NativeMethodInfoPtr_SetRoundEnded_Private_Void_Boolean_0;

		// Token: 0x0400464B RID: 17995
		private static readonly IntPtr NativeMethodInfoPtr_AddCardToPlayerHand_Private_Void_Int32_PlayingCard_0;

		// Token: 0x0400464C RID: 17996
		private static readonly IntPtr NativeMethodInfoPtr_AddCardToPlayerHand_Private_Void_Int32_String_0;

		// Token: 0x0400464D RID: 17997
		private static readonly IntPtr NativeMethodInfoPtr_AddCardToDealerHand_Private_Void_String_0;

		// Token: 0x0400464E RID: 17998
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerCards_Private_List_1_PlayingCard_Int32_0;

		// Token: 0x0400464F RID: 17999
		private static readonly IntPtr NativeMethodInfoPtr_GetHandScore_Private_Int32_List_1_PlayingCard_Boolean_0;

		// Token: 0x04004650 RID: 18000
		private static readonly IntPtr NativeMethodInfoPtr_GetCardValue_Private_Int32_PlayingCard_Boolean_0;

		// Token: 0x04004651 RID: 18001
		private static readonly IntPtr NativeMethodInfoPtr_DrawCard_Private_PlayingCard_0;

		// Token: 0x04004652 RID: 18002
		private static readonly IntPtr NativeMethodInfoPtr_ResetCards_Private_Void_0;

		// Token: 0x04004653 RID: 18003
		private static readonly IntPtr NativeMethodInfoPtr_EndGame_Private_Void_0;

		// Token: 0x04004654 RID: 18004
		private static readonly IntPtr NativeMethodInfoPtr_RemoveLocalPlayerFromGame_Public_Void_EPayoutType_Single_0;

		// Token: 0x04004655 RID: 18005
		private static readonly IntPtr NativeMethodInfoPtr_GetPayout_Public_Single_Single_EPayoutType_0;

		// Token: 0x04004656 RID: 18006
		private static readonly IntPtr NativeMethodInfoPtr_IsCurrentRoundEmpty_Private_Boolean_0;

		// Token: 0x04004657 RID: 18007
		private static readonly IntPtr NativeMethodInfoPtr_AddPlayerToCurrentRound_Private_Void_NetworkObject_0;

		// Token: 0x04004658 RID: 18008
		private static readonly IntPtr NativeMethodInfoPtr_RequestRemovePlayerFromCurrentRound_Private_Void_NetworkObject_0;

		// Token: 0x04004659 RID: 18009
		private static readonly IntPtr NativeMethodInfoPtr_RemovePlayerFromCurrentRound_Private_Void_NetworkObject_0;

		// Token: 0x0400465A RID: 18010
		private static readonly IntPtr NativeMethodInfoPtr_SetLocalPlayerBet_Public_Void_Single_0;

		// Token: 0x0400465B RID: 18011
		private static readonly IntPtr NativeMethodInfoPtr_AreAllPlayersReady_Public_Boolean_0;

		// Token: 0x0400465C RID: 18012
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayersReadyCount_Public_Int32_0;

		// Token: 0x0400465D RID: 18013
		private static readonly IntPtr NativeMethodInfoPtr_ToggleLocalPlayerReady_Public_Void_0;

		// Token: 0x0400465E RID: 18014
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400465F RID: 18015
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004660 RID: 18016
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004661 RID: 18017
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004662 RID: 18018
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_StartGame_2166136261_Private_Void_0;

		// Token: 0x04004663 RID: 18019
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___StartGame_2166136261_Private_Void_0;

		// Token: 0x04004664 RID: 18020
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_StartGame_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004665 RID: 18021
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_NotifyPlayerScore_2864061566_Private_Void_NetworkObject_Int32_Boolean_0;

		// Token: 0x04004666 RID: 18022
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___NotifyPlayerScore_2864061566_Private_Void_NetworkObject_Int32_Boolean_0;

		// Token: 0x04004667 RID: 18023
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_NotifyPlayerScore_2864061566_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004668 RID: 18024
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetRoundEnded_1140765316_Private_Void_Boolean_0;

		// Token: 0x04004669 RID: 18025
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetRoundEnded_1140765316_Private_Void_Boolean_0;

		// Token: 0x0400466A RID: 18026
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetRoundEnded_1140765316_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400466B RID: 18027
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AddCardToPlayerHand_2801973956_Private_Void_Int32_String_0;

		// Token: 0x0400466C RID: 18028
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AddCardToPlayerHand_2801973956_Private_Void_Int32_String_0;

		// Token: 0x0400466D RID: 18029
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_AddCardToPlayerHand_2801973956_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400466E RID: 18030
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AddCardToDealerHand_3615296227_Private_Void_String_0;

		// Token: 0x0400466F RID: 18031
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AddCardToDealerHand_3615296227_Private_Void_String_0;

		// Token: 0x04004670 RID: 18032
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_AddCardToDealerHand_3615296227_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004671 RID: 18033
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_EndGame_2166136261_Private_Void_0;

		// Token: 0x04004672 RID: 18034
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___EndGame_2166136261_Private_Void_0;

		// Token: 0x04004673 RID: 18035
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_EndGame_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004674 RID: 18036
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AddPlayerToCurrentRound_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04004675 RID: 18037
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AddPlayerToCurrentRound_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04004676 RID: 18038
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_AddPlayerToCurrentRound_3323014238_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004677 RID: 18039
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04004678 RID: 18040
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04004679 RID: 18041
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400467A RID: 18042
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_RemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x0400467B RID: 18043
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___RemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x0400467C RID: 18044
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_RemovePlayerFromCurrentRound_3323014238_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400467D RID: 18045
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000A39 RID: 2617
		[OriginalName("Assembly-CSharp.dll", "", "EStage")]
		public enum EStage
		{
			// Token: 0x04008C1A RID: 35866
			WaitingForPlayers,
			// Token: 0x04008C1B RID: 35867
			Dealing,
			// Token: 0x04008C1C RID: 35868
			PlayerTurn,
			// Token: 0x04008C1D RID: 35869
			DealerTurn,
			// Token: 0x04008C1E RID: 35870
			Ending
		}

		// Token: 0x02000A3A RID: 2618
		[OriginalName("Assembly-CSharp.dll", "", "EPayoutType")]
		public enum EPayoutType
		{
			// Token: 0x04008C20 RID: 35872
			None,
			// Token: 0x04008C21 RID: 35873
			Blackjack,
			// Token: 0x04008C22 RID: 35874
			Win,
			// Token: 0x04008C23 RID: 35875
			Push
		}

		// Token: 0x02000A3B RID: 2619
		[ObfuscatedName("ScheduleOne.Casino.BlackjackGameController+<>c__DisplayClass70_0")]
		public sealed class __c__DisplayClass70_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CFC6 RID: 53190 RVA: 0x0031E364 File Offset: 0x0031C564
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass70_0()
			{
				Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "<>c__DisplayClass70_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0>.NativeClassPtr);
				BlackjackGameController.__c__DisplayClass70_0.NativeFieldInfoPtr_clockwisePlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0>.NativeClassPtr, "clockwisePlayers");
				BlackjackGameController.__c__DisplayClass70_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0>.NativeClassPtr, "<>4__this");
				BlackjackGameController.__c__DisplayClass70_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0>.NativeClassPtr, 100676324);
				BlackjackGameController.__c__DisplayClass70_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0>.NativeClassPtr, 100676325);
				BlackjackGameController.__c__DisplayClass70_0.NativeMethodInfoPtr__StartGame_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0>.NativeClassPtr, 100676326);
			}

			// Token: 0x0600CFC7 RID: 53191 RVA: 0x0031E3F4 File Offset: 0x0031C5F4
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass70_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass70_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFC8 RID: 53192 RVA: 0x0031E430 File Offset: 0x0031C630
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207467, XrefRangeEnd = 207472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass70_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600CFC9 RID: 53193 RVA: 0x0031E470 File Offset: 0x0031C670
			[CallerCount(0)]
			public unsafe bool _StartGame_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass70_0.NativeMethodInfoPtr__StartGame_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CFCA RID: 53194 RVA: 0x0006517A File Offset: 0x0006337A
			public __c__DisplayClass70_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700408E RID: 16526
			// (get) Token: 0x0600CFCB RID: 53195 RVA: 0x0031E4AC File Offset: 0x0031C6AC
			// (set) Token: 0x0600CFCC RID: 53196 RVA: 0x00065183 File Offset: 0x00063383
			public unsafe List<Player> clockwisePlayers
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.NativeFieldInfoPtr_clockwisePlayers);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Player>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.NativeFieldInfoPtr_clockwisePlayers), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700408F RID: 16527
			// (get) Token: 0x0600CFCD RID: 53197 RVA: 0x0031E4DC File Offset: 0x0031C6DC
			// (set) Token: 0x0600CFCE RID: 53198 RVA: 0x000651A2 File Offset: 0x000633A2
			public unsafe BlackjackGameController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlackjackGameController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C24 RID: 35876
			private static readonly IntPtr NativeFieldInfoPtr_clockwisePlayers;

			// Token: 0x04008C25 RID: 35877
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008C26 RID: 35878
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C27 RID: 35879
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04008C28 RID: 35880
			private static readonly IntPtr NativeMethodInfoPtr__StartGame_b__1_Internal_Boolean_0;

			// Token: 0x02000C58 RID: 3160
			[ObfuscatedName("ScheduleOne.Casino.BlackjackGameController+<>c__DisplayClass70_0+<<StartGame>g__GameRoutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E388 RID: 58248 RVA: 0x00356760 File Offset: 0x00354960
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique()
				{
					Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0>.NativeClassPtr, "<<StartGame>g__GameRoutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr);
					BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, "<>1__state");
					BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, "<>2__current");
					BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, "<>4__this");
					BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, "<>8__1");
					BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__drawSpacing_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, "<drawSpacing>5__2");
					BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__dealerTurn_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, "<dealerTurn>5__3");
					BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, "<i>5__4");
					BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__playerIndex_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, "<playerIndex>5__5");
					BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__turn_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, "<turn>5__6");
					BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, 100676327);
					BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, 100676328);
					BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, 100676329);
					BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, 100676330);
					BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, 100676331);
					BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, 100676332);
				}

				// Token: 0x0600E389 RID: 58249 RVA: 0x003568B8 File Offset: 0x00354AB8
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E38A RID: 58250 RVA: 0x00356900 File Offset: 0x00354B00
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E38B RID: 58251 RVA: 0x00356934 File Offset: 0x00354B34
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207203, XrefRangeEnd = 207462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170046A1 RID: 18081
				// (get) Token: 0x0600E38C RID: 58252 RVA: 0x00356970 File Offset: 0x00354B70
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E38D RID: 58253 RVA: 0x003569B0 File Offset: 0x00354BB0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207462, XrefRangeEnd = 207467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170046A2 RID: 18082
				// (get) Token: 0x0600E38E RID: 58254 RVA: 0x003569E4 File Offset: 0x00354BE4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E38F RID: 58255 RVA: 0x0006EE4C File Offset: 0x0006D04C
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004698 RID: 18072
				// (get) Token: 0x0600E390 RID: 58256 RVA: 0x00356A24 File Offset: 0x00354C24
				// (set) Token: 0x0600E391 RID: 58257 RVA: 0x0006EE55 File Offset: 0x0006D055
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004699 RID: 18073
				// (get) Token: 0x0600E392 RID: 58258 RVA: 0x00356A4C File Offset: 0x00354C4C
				// (set) Token: 0x0600E393 RID: 58259 RVA: 0x0006EE70 File Offset: 0x0006D070
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700469A RID: 18074
				// (get) Token: 0x0600E394 RID: 58260 RVA: 0x00356A7C File Offset: 0x00354C7C
				// (set) Token: 0x0600E395 RID: 58261 RVA: 0x0006EE8F File Offset: 0x0006D08F
				public unsafe BlackjackGameController.__c__DisplayClass70_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlackjackGameController.__c__DisplayClass70_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700469B RID: 18075
				// (get) Token: 0x0600E396 RID: 58262 RVA: 0x00356AAC File Offset: 0x00354CAC
				// (set) Token: 0x0600E397 RID: 58263 RVA: 0x0006EEAE File Offset: 0x0006D0AE
				public unsafe BlackjackGameController.__c__DisplayClass70_1 __8__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr___8__1);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlackjackGameController.__c__DisplayClass70_1>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700469C RID: 18076
				// (get) Token: 0x0600E398 RID: 58264 RVA: 0x00356ADC File Offset: 0x00354CDC
				// (set) Token: 0x0600E399 RID: 58265 RVA: 0x0006EECD File Offset: 0x0006D0CD
				public unsafe float _drawSpacing_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__drawSpacing_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__drawSpacing_5__2)) = value;
					}
				}

				// Token: 0x1700469D RID: 18077
				// (get) Token: 0x0600E39A RID: 58266 RVA: 0x00356B04 File Offset: 0x00354D04
				// (set) Token: 0x0600E39B RID: 58267 RVA: 0x0006EEE8 File Offset: 0x0006D0E8
				public unsafe int _dealerTurn_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__dealerTurn_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__dealerTurn_5__3)) = value;
					}
				}

				// Token: 0x1700469E RID: 18078
				// (get) Token: 0x0600E39C RID: 58268 RVA: 0x00356B2C File Offset: 0x00354D2C
				// (set) Token: 0x0600E39D RID: 58269 RVA: 0x0006EF03 File Offset: 0x0006D103
				public unsafe int _i_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__i_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__i_5__4)) = value;
					}
				}

				// Token: 0x1700469F RID: 18079
				// (get) Token: 0x0600E39E RID: 58270 RVA: 0x00356B54 File Offset: 0x00354D54
				// (set) Token: 0x0600E39F RID: 58271 RVA: 0x0006EF1E File Offset: 0x0006D11E
				public unsafe int _playerIndex_5__5
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__playerIndex_5__5);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__playerIndex_5__5)) = value;
					}
				}

				// Token: 0x170046A0 RID: 18080
				// (get) Token: 0x0600E3A0 RID: 58272 RVA: 0x00356B7C File Offset: 0x00354D7C
				// (set) Token: 0x0600E3A1 RID: 58273 RVA: 0x0006EF39 File Offset: 0x0006D139
				public unsafe int _turn_5__6
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__turn_5__6);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__turn_5__6)) = value;
					}
				}

				// Token: 0x04009842 RID: 38978
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009843 RID: 38979
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009844 RID: 38980
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009845 RID: 38981
				private static readonly IntPtr NativeFieldInfoPtr___8__1;

				// Token: 0x04009846 RID: 38982
				private static readonly IntPtr NativeFieldInfoPtr__drawSpacing_5__2;

				// Token: 0x04009847 RID: 38983
				private static readonly IntPtr NativeFieldInfoPtr__dealerTurn_5__3;

				// Token: 0x04009848 RID: 38984
				private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

				// Token: 0x04009849 RID: 38985
				private static readonly IntPtr NativeFieldInfoPtr__playerIndex_5__5;

				// Token: 0x0400984A RID: 38986
				private static readonly IntPtr NativeFieldInfoPtr__turn_5__6;

				// Token: 0x0400984B RID: 38987
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400984C RID: 38988
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400984D RID: 38989
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400984E RID: 38990
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400984F RID: 38991
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009850 RID: 38992
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000A3C RID: 2620
		[ObfuscatedName("ScheduleOne.Casino.BlackjackGameController+<>c__DisplayClass70_1")]
		public sealed class __c__DisplayClass70_1 : Il2CppSystem.Object
		{
			// Token: 0x0600CFCF RID: 53199 RVA: 0x0031E50C File Offset: 0x0031C70C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass70_1()
			{
				Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "<>c__DisplayClass70_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_1>.NativeClassPtr);
				BlackjackGameController.__c__DisplayClass70_1.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_1>.NativeClassPtr, "player");
				BlackjackGameController.__c__DisplayClass70_1.NativeFieldInfoPtr_field_Public___c__DisplayClass70_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_1>.NativeClassPtr, "CS$<>8__locals1");
				BlackjackGameController.__c__DisplayClass70_1.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_1>.NativeClassPtr, "<>9__2");
				BlackjackGameController.__c__DisplayClass70_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_1>.NativeClassPtr, 100676333);
				BlackjackGameController.__c__DisplayClass70_1.NativeMethodInfoPtr__StartGame_b__2_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_1>.NativeClassPtr, 100676334);
			}

			// Token: 0x0600CFD0 RID: 53200 RVA: 0x0031E59C File Offset: 0x0031C79C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass70_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass70_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFD1 RID: 53201 RVA: 0x0031E5D8 File Offset: 0x0031C7D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207472, XrefRangeEnd = 207479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _StartGame_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass70_1.NativeMethodInfoPtr__StartGame_b__2_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CFD2 RID: 53202 RVA: 0x000651C1 File Offset: 0x000633C1
			public __c__DisplayClass70_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004090 RID: 16528
			// (get) Token: 0x0600CFD3 RID: 53203 RVA: 0x0031E614 File Offset: 0x0031C814
			// (set) Token: 0x0600CFD4 RID: 53204 RVA: 0x000651CA File Offset: 0x000633CA
			public unsafe Player player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_1.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_1.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004091 RID: 16529
			// (get) Token: 0x0600CFD5 RID: 53205 RVA: 0x0031E644 File Offset: 0x0031C844
			// (set) Token: 0x0600CFD6 RID: 53206 RVA: 0x000651E9 File Offset: 0x000633E9
			public unsafe BlackjackGameController.__c__DisplayClass70_0 field_Public___c__DisplayClass70_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_1.NativeFieldInfoPtr_field_Public___c__DisplayClass70_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlackjackGameController.__c__DisplayClass70_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_1.NativeFieldInfoPtr_field_Public___c__DisplayClass70_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004092 RID: 16530
			// (get) Token: 0x0600CFD7 RID: 53207 RVA: 0x0031E674 File Offset: 0x0031C874
			// (set) Token: 0x0600CFD8 RID: 53208 RVA: 0x00065208 File Offset: 0x00063408
			public unsafe Func<bool> __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_1.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_1.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C29 RID: 35881
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04008C2A RID: 35882
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass70_0_0;

			// Token: 0x04008C2B RID: 35883
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x04008C2C RID: 35884
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C2D RID: 35885
			private static readonly IntPtr NativeMethodInfoPtr__StartGame_b__2_Internal_Boolean_0;
		}

		// Token: 0x02000A3D RID: 2621
		[ObfuscatedName("ScheduleOne.Casino.BlackjackGameController+<>c__DisplayClass75_0")]
		public sealed class __c__DisplayClass75_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CFD9 RID: 53209 RVA: 0x0031E6A4 File Offset: 0x0031C8A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass75_0()
			{
				Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass75_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "<>c__DisplayClass75_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass75_0>.NativeClassPtr);
				BlackjackGameController.__c__DisplayClass75_0.NativeFieldInfoPtr_cardID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass75_0>.NativeClassPtr, "cardID");
				BlackjackGameController.__c__DisplayClass75_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass75_0>.NativeClassPtr, 100676335);
				BlackjackGameController.__c__DisplayClass75_0.NativeMethodInfoPtr__AddCardToPlayerHand_b__0_Internal_Boolean_PlayingCard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass75_0>.NativeClassPtr, 100676336);
			}

			// Token: 0x0600CFDA RID: 53210 RVA: 0x0031E70C File Offset: 0x0031C90C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass75_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass75_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass75_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFDB RID: 53211 RVA: 0x0031E748 File Offset: 0x0031C948
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207479, XrefRangeEnd = 207481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddCardToPlayerHand_b__0(PlayingCard x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass75_0.NativeMethodInfoPtr__AddCardToPlayerHand_b__0_Internal_Boolean_PlayingCard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CFDC RID: 53212 RVA: 0x00065227 File Offset: 0x00063427
			public __c__DisplayClass75_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004093 RID: 16531
			// (get) Token: 0x0600CFDD RID: 53213 RVA: 0x0031E798 File Offset: 0x0031C998
			// (set) Token: 0x0600CFDE RID: 53214 RVA: 0x00065230 File Offset: 0x00063430
			public unsafe string cardID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass75_0.NativeFieldInfoPtr_cardID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass75_0.NativeFieldInfoPtr_cardID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008C2E RID: 35886
			private static readonly IntPtr NativeFieldInfoPtr_cardID;

			// Token: 0x04008C2F RID: 35887
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C30 RID: 35888
			private static readonly IntPtr NativeMethodInfoPtr__AddCardToPlayerHand_b__0_Internal_Boolean_PlayingCard_0;
		}

		// Token: 0x02000A3E RID: 2622
		[ObfuscatedName("ScheduleOne.Casino.BlackjackGameController+<>c__DisplayClass76_0")]
		public sealed class __c__DisplayClass76_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CFDF RID: 53215 RVA: 0x0031E7C0 File Offset: 0x0031C9C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass76_0()
			{
				Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass76_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "<>c__DisplayClass76_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass76_0>.NativeClassPtr);
				BlackjackGameController.__c__DisplayClass76_0.NativeFieldInfoPtr_cardID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass76_0>.NativeClassPtr, "cardID");
				BlackjackGameController.__c__DisplayClass76_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass76_0>.NativeClassPtr, 100676337);
				BlackjackGameController.__c__DisplayClass76_0.NativeMethodInfoPtr__AddCardToDealerHand_b__0_Internal_Boolean_PlayingCard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass76_0>.NativeClassPtr, 100676338);
			}

			// Token: 0x0600CFE0 RID: 53216 RVA: 0x0031E828 File Offset: 0x0031CA28
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass76_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass76_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass76_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFE1 RID: 53217 RVA: 0x0031E864 File Offset: 0x0031CA64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddCardToDealerHand_b__0(PlayingCard x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass76_0.NativeMethodInfoPtr__AddCardToDealerHand_b__0_Internal_Boolean_PlayingCard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CFE2 RID: 53218 RVA: 0x0006524F File Offset: 0x0006344F
			public __c__DisplayClass76_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004094 RID: 16532
			// (get) Token: 0x0600CFE3 RID: 53219 RVA: 0x0031E8B4 File Offset: 0x0031CAB4
			// (set) Token: 0x0600CFE4 RID: 53220 RVA: 0x00065258 File Offset: 0x00063458
			public unsafe string cardID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass76_0.NativeFieldInfoPtr_cardID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass76_0.NativeFieldInfoPtr_cardID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008C31 RID: 35889
			private static readonly IntPtr NativeFieldInfoPtr_cardID;

			// Token: 0x04008C32 RID: 35890
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C33 RID: 35891
			private static readonly IntPtr NativeMethodInfoPtr__AddCardToDealerHand_b__0_Internal_Boolean_PlayingCard_0;
		}

		// Token: 0x02000A3F RID: 2623
		[ObfuscatedName("ScheduleOne.Casino.BlackjackGameController+<>c__DisplayClass83_0")]
		public sealed class __c__DisplayClass83_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CFE5 RID: 53221 RVA: 0x0031E8DC File Offset: 0x0031CADC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass83_0()
			{
				Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "<>c__DisplayClass83_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0>.NativeClassPtr);
				BlackjackGameController.__c__DisplayClass83_0.NativeFieldInfoPtr_cameraDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0>.NativeClassPtr, "cameraDelay");
				BlackjackGameController.__c__DisplayClass83_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0>.NativeClassPtr, "<>4__this");
				BlackjackGameController.__c__DisplayClass83_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0>.NativeClassPtr, 100676339);
				BlackjackGameController.__c__DisplayClass83_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0>.NativeClassPtr, 100676340);
			}

			// Token: 0x0600CFE6 RID: 53222 RVA: 0x0031E958 File Offset: 0x0031CB58
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass83_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass83_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFE7 RID: 53223 RVA: 0x0031E994 File Offset: 0x0031CB94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207499, XrefRangeEnd = 207504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass83_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600CFE8 RID: 53224 RVA: 0x00065277 File Offset: 0x00063477
			public __c__DisplayClass83_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004095 RID: 16533
			// (get) Token: 0x0600CFE9 RID: 53225 RVA: 0x0031E9D4 File Offset: 0x0031CBD4
			// (set) Token: 0x0600CFEA RID: 53226 RVA: 0x00065280 File Offset: 0x00063480
			public unsafe float cameraDelay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass83_0.NativeFieldInfoPtr_cameraDelay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass83_0.NativeFieldInfoPtr_cameraDelay)) = value;
				}
			}

			// Token: 0x17004096 RID: 16534
			// (get) Token: 0x0600CFEB RID: 53227 RVA: 0x0031E9FC File Offset: 0x0031CBFC
			// (set) Token: 0x0600CFEC RID: 53228 RVA: 0x0006529B File Offset: 0x0006349B
			public unsafe BlackjackGameController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass83_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlackjackGameController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass83_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C34 RID: 35892
			private static readonly IntPtr NativeFieldInfoPtr_cameraDelay;

			// Token: 0x04008C35 RID: 35893
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008C36 RID: 35894
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C37 RID: 35895
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C59 RID: 3161
			[ObfuscatedName("ScheduleOne.Casino.BlackjackGameController+<>c__DisplayClass83_0+<<RemoveLocalPlayerFromGame>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E3A2 RID: 58274 RVA: 0x00356BA4 File Offset: 0x00354DA4
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0>.NativeClassPtr, "<<RemoveLocalPlayerFromGame>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676341);
					BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676342);
					BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676343);
					BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676344);
					BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676345);
					BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676346);
				}

				// Token: 0x0600E3A3 RID: 58275 RVA: 0x00356C84 File Offset: 0x00354E84
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E3A4 RID: 58276 RVA: 0x00356CCC File Offset: 0x00354ECC
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E3A5 RID: 58277 RVA: 0x00356D00 File Offset: 0x00354F00
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207481, XrefRangeEnd = 207494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170046A6 RID: 18086
				// (get) Token: 0x0600E3A6 RID: 58278 RVA: 0x00356D3C File Offset: 0x00354F3C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E3A7 RID: 58279 RVA: 0x00356D7C File Offset: 0x00354F7C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207494, XrefRangeEnd = 207499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170046A7 RID: 18087
				// (get) Token: 0x0600E3A8 RID: 58280 RVA: 0x00356DB0 File Offset: 0x00354FB0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E3A9 RID: 58281 RVA: 0x0006EF54 File Offset: 0x0006D154
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170046A3 RID: 18083
				// (get) Token: 0x0600E3AA RID: 58282 RVA: 0x00356DF0 File Offset: 0x00354FF0
				// (set) Token: 0x0600E3AB RID: 58283 RVA: 0x0006EF5D File Offset: 0x0006D15D
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170046A4 RID: 18084
				// (get) Token: 0x0600E3AC RID: 58284 RVA: 0x00356E18 File Offset: 0x00355018
				// (set) Token: 0x0600E3AD RID: 58285 RVA: 0x0006EF78 File Offset: 0x0006D178
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046A5 RID: 18085
				// (get) Token: 0x0600E3AE RID: 58286 RVA: 0x00356E48 File Offset: 0x00355048
				// (set) Token: 0x0600E3AF RID: 58287 RVA: 0x0006EF97 File Offset: 0x0006D197
				public unsafe BlackjackGameController.__c__DisplayClass83_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlackjackGameController.__c__DisplayClass83_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009851 RID: 38993
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009852 RID: 38994
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009853 RID: 38995
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009854 RID: 38996
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009855 RID: 38997
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009856 RID: 38998
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009857 RID: 38999
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009858 RID: 39000
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009859 RID: 39001
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
