using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Casino
{
	// Token: 0x020004A5 RID: 1189
	public class CasinoGamePlayers : NetworkBehaviour
	{
		// Token: 0x0600676E RID: 26478 RVA: 0x001D0DBC File Offset: 0x001CEFBC
		// Note: this type is marked as 'beforefieldinit'.
		static CasinoGamePlayers()
		{
			Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino", "CasinoGamePlayers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr);
			CasinoGamePlayers.NativeFieldInfoPtr_PlayerLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, "PlayerLimit");
			CasinoGamePlayers.NativeFieldInfoPtr_Players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, "Players");
			CasinoGamePlayers.NativeFieldInfoPtr_onPlayerListChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, "onPlayerListChanged");
			CasinoGamePlayers.NativeFieldInfoPtr_onPlayerScoresChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, "onPlayerScoresChanged");
			CasinoGamePlayers.NativeFieldInfoPtr_playerScores = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, "playerScores");
			CasinoGamePlayers.NativeFieldInfoPtr_playerDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, "playerDatas");
			CasinoGamePlayers.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Casino.CasinoGamePlayersAssembly-CSharp.dll_Excuted");
			CasinoGamePlayers.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Casino.CasinoGamePlayersAssembly-CSharp.dll_Excuted");
			CasinoGamePlayers.NativeMethodInfoPtr_get_CurrentPlayerCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676404);
			CasinoGamePlayers.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676405);
			CasinoGamePlayers.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676406);
			CasinoGamePlayers.NativeMethodInfoPtr_AddPlayer_Public_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676407);
			CasinoGamePlayers.NativeMethodInfoPtr_RemovePlayer_Public_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676408);
			CasinoGamePlayers.NativeMethodInfoPtr_SetPlayerScore_Public_Void_Player_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676409);
			CasinoGamePlayers.NativeMethodInfoPtr_GetPlayerScore_Public_Int32_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676410);
			CasinoGamePlayers.NativeMethodInfoPtr_GetPlayer_Public_Player_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676411);
			CasinoGamePlayers.NativeMethodInfoPtr_GetPlayerIndex_Public_Int32_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676412);
			CasinoGamePlayers.NativeMethodInfoPtr_RequestAddPlayer_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676413);
			CasinoGamePlayers.NativeMethodInfoPtr_AddPlayerToArray_Private_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676414);
			CasinoGamePlayers.NativeMethodInfoPtr_RequestRemovePlayer_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676415);
			CasinoGamePlayers.NativeMethodInfoPtr_RemovePlayerFromArray_Private_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676416);
			CasinoGamePlayers.NativeMethodInfoPtr_RequestSetScore_Private_Void_NetworkObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676417);
			CasinoGamePlayers.NativeMethodInfoPtr_SetPlayerScore_Private_Void_NetworkConnection_NetworkObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676418);
			CasinoGamePlayers.NativeMethodInfoPtr_SetPlayerList_Private_Void_NetworkConnection_Il2CppReferenceArray_1_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676419);
			CasinoGamePlayers.NativeMethodInfoPtr_GetPlayerData_Public_CasinoGamePlayerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676420);
			CasinoGamePlayers.NativeMethodInfoPtr_GetPlayerData_Public_CasinoGamePlayerData_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676421);
			CasinoGamePlayers.NativeMethodInfoPtr_GetPlayerData_Public_CasinoGamePlayerData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676422);
			CasinoGamePlayers.NativeMethodInfoPtr_SendPlayerBool_Public_Void_NetworkObject_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676423);
			CasinoGamePlayers.NativeMethodInfoPtr_ReceivePlayerBool_Private_Void_NetworkConnection_NetworkObject_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676424);
			CasinoGamePlayers.NativeMethodInfoPtr_SendPlayerFloat_Public_Void_NetworkObject_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676425);
			CasinoGamePlayers.NativeMethodInfoPtr_ReceivePlayerFloat_Private_Void_NetworkConnection_NetworkObject_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676426);
			CasinoGamePlayers.NativeMethodInfoPtr_GetPlayerObjects_Private_Il2CppReferenceArray_1_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676427);
			CasinoGamePlayers.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676428);
			CasinoGamePlayers.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676429);
			CasinoGamePlayers.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676430);
			CasinoGamePlayers.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676431);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Server_RequestAddPlayer_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676432);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___RequestAddPlayer_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676433);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Server_RequestAddPlayer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676434);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Server_RequestRemovePlayer_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676435);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___RequestRemovePlayer_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676436);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Server_RequestRemovePlayer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676437);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Server_RequestSetScore_4172557123_Private_Void_NetworkObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676438);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___RequestSetScore_4172557123_Private_Void_NetworkObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676439);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Server_RequestSetScore_4172557123_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676440);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Observers_SetPlayerScore_1865307316_Private_Void_NetworkConnection_NetworkObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676441);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___SetPlayerScore_1865307316_Private_Void_NetworkConnection_NetworkObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676442);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Observers_SetPlayerScore_1865307316_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676443);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Target_SetPlayerScore_1865307316_Private_Void_NetworkConnection_NetworkObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676444);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Target_SetPlayerScore_1865307316_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676445);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Observers_SetPlayerList_204172449_Private_Void_NetworkConnection_Il2CppReferenceArray_1_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676446);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___SetPlayerList_204172449_Private_Void_NetworkConnection_Il2CppReferenceArray_1_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676447);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Observers_SetPlayerList_204172449_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676448);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Target_SetPlayerList_204172449_Private_Void_NetworkConnection_Il2CppReferenceArray_1_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676449);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Target_SetPlayerList_204172449_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676450);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Server_SendPlayerBool_77262511_Private_Void_NetworkObject_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676451);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___SendPlayerBool_77262511_Public_Void_NetworkObject_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676452);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Server_SendPlayerBool_77262511_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676453);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Observers_ReceivePlayerBool_1748594478_Private_Void_NetworkConnection_NetworkObject_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676454);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___ReceivePlayerBool_1748594478_Private_Void_NetworkConnection_NetworkObject_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676455);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Observers_ReceivePlayerBool_1748594478_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676456);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Target_ReceivePlayerBool_1748594478_Private_Void_NetworkConnection_NetworkObject_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676457);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Target_ReceivePlayerBool_1748594478_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676458);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Server_SendPlayerFloat_2931762093_Private_Void_NetworkObject_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676459);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___SendPlayerFloat_2931762093_Public_Void_NetworkObject_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676460);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Server_SendPlayerFloat_2931762093_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676461);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Observers_ReceivePlayerFloat_2317689966_Private_Void_NetworkConnection_NetworkObject_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676462);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___ReceivePlayerFloat_2317689966_Private_Void_NetworkConnection_NetworkObject_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676463);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Observers_ReceivePlayerFloat_2317689966_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676464);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Target_ReceivePlayerFloat_2317689966_Private_Void_NetworkConnection_NetworkObject_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676465);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Target_ReceivePlayerFloat_2317689966_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676466);
			CasinoGamePlayers.NativeMethodInfoPtr_Method_Private_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676467);
		}

		// Token: 0x17001F23 RID: 7971
		// (get) Token: 0x0600676F RID: 26479 RVA: 0x001D138C File Offset: 0x001CF58C
		public unsafe int CurrentPlayerCount
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 209370, RefRangeEnd = 209392, XrefRangeStart = 209352, XrefRangeEnd = 209370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_get_CurrentPlayerCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06006770 RID: 26480 RVA: 0x001D13C8 File Offset: 0x001CF5C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209392, XrefRangeEnd = 209396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGamePlayers.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006771 RID: 26481 RVA: 0x001D1404 File Offset: 0x001CF604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209396, XrefRangeEnd = 209411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGamePlayers.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006772 RID: 26482 RVA: 0x001D1454 File Offset: 0x001CF654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209411, XrefRangeEnd = 209433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_AddPlayer_Public_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006773 RID: 26483 RVA: 0x001D1498 File Offset: 0x001CF698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209433, XrefRangeEnd = 209452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemovePlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RemovePlayer_Public_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006774 RID: 26484 RVA: 0x001D14DC File Offset: 0x001CF6DC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 209464, RefRangeEnd = 209469, XrefRangeStart = 209452, XrefRangeEnd = 209464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPlayerScore(Player player, int score)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref score;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_SetPlayerScore_Public_Void_Player_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006775 RID: 26485 RVA: 0x001D152C File Offset: 0x001CF72C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 209479, RefRangeEnd = 209481, XrefRangeStart = 209469, XrefRangeEnd = 209479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPlayerScore(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_GetPlayerScore_Public_Int32_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006776 RID: 26486 RVA: 0x001D157C File Offset: 0x001CF77C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 209481, RefRangeEnd = 209490, XrefRangeStart = 209481, XrefRangeEnd = 209481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Player GetPlayer(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_GetPlayer_Public_Player_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
		}

		// Token: 0x06006777 RID: 26487 RVA: 0x001D15C8 File Offset: 0x001CF7C8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 209493, RefRangeEnd = 209497, XrefRangeStart = 209490, XrefRangeEnd = 209493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPlayerIndex(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_GetPlayerIndex_Public_Int32_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006778 RID: 26488 RVA: 0x001D1618 File Offset: 0x001CF818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209497, XrefRangeEnd = 209519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestAddPlayer(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RequestAddPlayer_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006779 RID: 26489 RVA: 0x001D165C File Offset: 0x001CF85C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209519, XrefRangeEnd = 209523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPlayerToArray(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_AddPlayerToArray_Private_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600677A RID: 26490 RVA: 0x001D16A0 File Offset: 0x001CF8A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209523, XrefRangeEnd = 209542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestRemovePlayer(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RequestRemovePlayer_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600677B RID: 26491 RVA: 0x001D16E4 File Offset: 0x001CF8E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209542, XrefRangeEnd = 209546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemovePlayerFromArray(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RemovePlayerFromArray_Private_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600677C RID: 26492 RVA: 0x001D1728 File Offset: 0x001CF928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209546, XrefRangeEnd = 209567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestSetScore(NetworkObject playerObject, int score)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref score;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RequestSetScore_Private_Void_NetworkObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600677D RID: 26493 RVA: 0x001D1778 File Offset: 0x001CF978
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 209613, RefRangeEnd = 209616, XrefRangeStart = 209567, XrefRangeEnd = 209613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPlayerScore(NetworkConnection conn, NetworkObject playerObject, int score)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref score;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_SetPlayerScore_Private_Void_NetworkConnection_NetworkObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600677E RID: 26494 RVA: 0x001D17DC File Offset: 0x001CF9DC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 209658, RefRangeEnd = 209662, XrefRangeStart = 209616, XrefRangeEnd = 209658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPlayerList(NetworkConnection conn, Il2CppReferenceArray<NetworkObject> playerObjects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObjects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_SetPlayerList_Private_Void_NetworkConnection_Il2CppReferenceArray_1_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600677F RID: 26495 RVA: 0x001D1830 File Offset: 0x001CFA30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209662, XrefRangeEnd = 209667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CasinoGamePlayerData GetPlayerData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_GetPlayerData_Public_CasinoGamePlayerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CasinoGamePlayerData>(intPtr3) : null;
		}

		// Token: 0x06006780 RID: 26496 RVA: 0x001D1870 File Offset: 0x001CFA70
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 209681, RefRangeEnd = 209690, XrefRangeStart = 209667, XrefRangeEnd = 209681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CasinoGamePlayerData GetPlayerData(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_GetPlayerData_Public_CasinoGamePlayerData_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CasinoGamePlayerData>(intPtr3) : null;
		}

		// Token: 0x06006781 RID: 26497 RVA: 0x001D18C0 File Offset: 0x001CFAC0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 209695, RefRangeEnd = 209701, XrefRangeStart = 209690, XrefRangeEnd = 209695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CasinoGamePlayerData GetPlayerData(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_GetPlayerData_Public_CasinoGamePlayerData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CasinoGamePlayerData>(intPtr3) : null;
		}

		// Token: 0x06006782 RID: 26498 RVA: 0x001D190C File Offset: 0x001CFB0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209701, XrefRangeEnd = 209724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendPlayerBool(NetworkObject playerObject, string key, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_SendPlayerBool_Public_Void_NetworkObject_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006783 RID: 26499 RVA: 0x001D1970 File Offset: 0x001CFB70
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 209770, RefRangeEnd = 209773, XrefRangeStart = 209724, XrefRangeEnd = 209770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceivePlayerBool(NetworkConnection conn, NetworkObject playerObject, string key, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_ReceivePlayerBool_Private_Void_NetworkConnection_NetworkObject_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006784 RID: 26500 RVA: 0x001D19E4 File Offset: 0x001CFBE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 209796, RefRangeEnd = 209797, XrefRangeStart = 209773, XrefRangeEnd = 209796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendPlayerFloat(NetworkObject playerObject, string key, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_SendPlayerFloat_Public_Void_NetworkObject_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006785 RID: 26501 RVA: 0x001D1A48 File Offset: 0x001CFC48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 209843, RefRangeEnd = 209846, XrefRangeStart = 209797, XrefRangeEnd = 209843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceivePlayerFloat(NetworkConnection conn, NetworkObject playerObject, string key, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_ReceivePlayerFloat_Private_Void_NetworkConnection_NetworkObject_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006786 RID: 26502 RVA: 0x001D1ABC File Offset: 0x001CFCBC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 209855, RefRangeEnd = 209859, XrefRangeStart = 209846, XrefRangeEnd = 209855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<NetworkObject> GetPlayerObjects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_GetPlayerObjects_Private_Il2CppReferenceArray_1_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NetworkObject>>(intPtr3) : null;
		}

		// Token: 0x06006787 RID: 26503 RVA: 0x001D1AFC File Offset: 0x001CFCFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209859, XrefRangeEnd = 209874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CasinoGamePlayers() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006788 RID: 26504 RVA: 0x001D1B38 File Offset: 0x001CFD38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209874, XrefRangeEnd = 209954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGamePlayers.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006789 RID: 26505 RVA: 0x001D1B74 File Offset: 0x001CFD74
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGamePlayers.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600678A RID: 26506 RVA: 0x001D1BB0 File Offset: 0x001CFDB0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGamePlayers.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600678B RID: 26507 RVA: 0x001D1BEC File Offset: 0x001CFDEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209954, XrefRangeEnd = 209973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_RequestAddPlayer_3323014238(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Server_RequestAddPlayer_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600678C RID: 26508 RVA: 0x001D1C30 File Offset: 0x001CFE30
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 210012, RefRangeEnd = 210016, XrefRangeStart = 209973, XrefRangeEnd = 210012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RequestAddPlayer_3323014238(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___RequestAddPlayer_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600678D RID: 26509 RVA: 0x001D1C74 File Offset: 0x001CFE74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210016, XrefRangeEnd = 210020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_RequestAddPlayer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Server_RequestAddPlayer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600678E RID: 26510 RVA: 0x001D1CD8 File Offset: 0x001CFED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_RequestRemovePlayer_3323014238(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Server_RequestRemovePlayer_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600678F RID: 26511 RVA: 0x001D1D1C File Offset: 0x001CFF1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210020, XrefRangeEnd = 210040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RequestRemovePlayer_3323014238(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___RequestRemovePlayer_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006790 RID: 26512 RVA: 0x001D1D60 File Offset: 0x001CFF60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210040, XrefRangeEnd = 210058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_RequestRemovePlayer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Server_RequestRemovePlayer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006791 RID: 26513 RVA: 0x001D1DC4 File Offset: 0x001CFFC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_RequestSetScore_4172557123(NetworkObject playerObject, int score)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref score;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Server_RequestSetScore_4172557123_Private_Void_NetworkObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006792 RID: 26514 RVA: 0x001D1E14 File Offset: 0x001D0014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210058, XrefRangeEnd = 210059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RequestSetScore_4172557123(NetworkObject playerObject, int score)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref score;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___RequestSetScore_4172557123_Private_Void_NetworkObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006793 RID: 26515 RVA: 0x001D1E64 File Offset: 0x001D0064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210059, XrefRangeEnd = 210064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_RequestSetScore_4172557123(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Server_RequestSetScore_4172557123_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006794 RID: 26516 RVA: 0x001D1EC8 File Offset: 0x001D00C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210064, XrefRangeEnd = 210085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetPlayerScore_1865307316(NetworkConnection conn, NetworkObject playerObject, int score)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref score;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Observers_SetPlayerScore_1865307316_Private_Void_NetworkConnection_NetworkObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006795 RID: 26517 RVA: 0x001D1F2C File Offset: 0x001D012C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 210103, RefRangeEnd = 210106, XrefRangeStart = 210085, XrefRangeEnd = 210103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetPlayerScore_1865307316(NetworkConnection conn, NetworkObject playerObject, int score)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref score;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___SetPlayerScore_1865307316_Private_Void_NetworkConnection_NetworkObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006796 RID: 26518 RVA: 0x001D1F90 File Offset: 0x001D0190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210106, XrefRangeEnd = 210112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetPlayerScore_1865307316(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Observers_SetPlayerScore_1865307316_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006797 RID: 26519 RVA: 0x001D1FE0 File Offset: 0x001D01E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210112, XrefRangeEnd = 210124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetPlayerScore_1865307316(NetworkConnection conn, NetworkObject playerObject, int score)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref score;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Target_SetPlayerScore_1865307316_Private_Void_NetworkConnection_NetworkObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006798 RID: 26520 RVA: 0x001D2044 File Offset: 0x001D0244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210124, XrefRangeEnd = 210130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetPlayerScore_1865307316(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Target_SetPlayerScore_1865307316_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006799 RID: 26521 RVA: 0x001D2094 File Offset: 0x001D0294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210130, XrefRangeEnd = 210149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetPlayerList_204172449(NetworkConnection conn, Il2CppReferenceArray<NetworkObject> playerObjects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObjects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Observers_SetPlayerList_204172449_Private_Void_NetworkConnection_Il2CppReferenceArray_1_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600679A RID: 26522 RVA: 0x001D20E8 File Offset: 0x001D02E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 210184, RefRangeEnd = 210187, XrefRangeStart = 210149, XrefRangeEnd = 210184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetPlayerList_204172449(NetworkConnection conn, Il2CppReferenceArray<NetworkObject> playerObjects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObjects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___SetPlayerList_204172449_Private_Void_NetworkConnection_Il2CppReferenceArray_1_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600679B RID: 26523 RVA: 0x001D213C File Offset: 0x001D033C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210187, XrefRangeEnd = 210191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetPlayerList_204172449(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Observers_SetPlayerList_204172449_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600679C RID: 26524 RVA: 0x001D218C File Offset: 0x001D038C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210191, XrefRangeEnd = 210210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetPlayerList_204172449(NetworkConnection conn, Il2CppReferenceArray<NetworkObject> playerObjects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObjects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Target_SetPlayerList_204172449_Private_Void_NetworkConnection_Il2CppReferenceArray_1_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600679D RID: 26525 RVA: 0x001D21E0 File Offset: 0x001D03E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210210, XrefRangeEnd = 210214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetPlayerList_204172449(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Target_SetPlayerList_204172449_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600679E RID: 26526 RVA: 0x001D2230 File Offset: 0x001D0430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210214, XrefRangeEnd = 210226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendPlayerBool_77262511(NetworkObject playerObject, string key, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Server_SendPlayerBool_77262511_Private_Void_NetworkObject_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600679F RID: 26527 RVA: 0x001D2294 File Offset: 0x001D0494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210226, XrefRangeEnd = 210227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendPlayerBool_77262511(NetworkObject playerObject, string key, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___SendPlayerBool_77262511_Public_Void_NetworkObject_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067A0 RID: 26528 RVA: 0x001D22F8 File Offset: 0x001D04F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210227, XrefRangeEnd = 210232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendPlayerBool_77262511(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Server_SendPlayerBool_77262511_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067A1 RID: 26529 RVA: 0x001D235C File Offset: 0x001D055C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210232, XrefRangeEnd = 210253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceivePlayerBool_1748594478(NetworkConnection conn, NetworkObject playerObject, string key, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Observers_ReceivePlayerBool_1748594478_Private_Void_NetworkConnection_NetworkObject_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067A2 RID: 26530 RVA: 0x001D23D0 File Offset: 0x001D05D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 210276, RefRangeEnd = 210279, XrefRangeStart = 210253, XrefRangeEnd = 210276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceivePlayerBool_1748594478(NetworkConnection conn, NetworkObject playerObject, string key, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___ReceivePlayerBool_1748594478_Private_Void_NetworkConnection_NetworkObject_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067A3 RID: 26531 RVA: 0x001D2444 File Offset: 0x001D0644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210279, XrefRangeEnd = 210284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceivePlayerBool_1748594478(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Observers_ReceivePlayerBool_1748594478_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067A4 RID: 26532 RVA: 0x001D2494 File Offset: 0x001D0694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210284, XrefRangeEnd = 210296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ReceivePlayerBool_1748594478(NetworkConnection conn, NetworkObject playerObject, string key, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Target_ReceivePlayerBool_1748594478_Private_Void_NetworkConnection_NetworkObject_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067A5 RID: 26533 RVA: 0x001D2508 File Offset: 0x001D0708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210296, XrefRangeEnd = 210301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ReceivePlayerBool_1748594478(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Target_ReceivePlayerBool_1748594478_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067A6 RID: 26534 RVA: 0x001D2558 File Offset: 0x001D0758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210301, XrefRangeEnd = 210313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendPlayerFloat_2931762093(NetworkObject playerObject, string key, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Server_SendPlayerFloat_2931762093_Private_Void_NetworkObject_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067A7 RID: 26535 RVA: 0x001D25BC File Offset: 0x001D07BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210313, XrefRangeEnd = 210314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendPlayerFloat_2931762093(NetworkObject playerObject, string key, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___SendPlayerFloat_2931762093_Public_Void_NetworkObject_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067A8 RID: 26536 RVA: 0x001D2620 File Offset: 0x001D0820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210314, XrefRangeEnd = 210320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendPlayerFloat_2931762093(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Server_SendPlayerFloat_2931762093_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067A9 RID: 26537 RVA: 0x001D2684 File Offset: 0x001D0884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210320, XrefRangeEnd = 210341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceivePlayerFloat_2317689966(NetworkConnection conn, NetworkObject playerObject, string key, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Observers_ReceivePlayerFloat_2317689966_Private_Void_NetworkConnection_NetworkObject_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067AA RID: 26538 RVA: 0x001D26F8 File Offset: 0x001D08F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 210364, RefRangeEnd = 210367, XrefRangeStart = 210341, XrefRangeEnd = 210364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceivePlayerFloat_2317689966(NetworkConnection conn, NetworkObject playerObject, string key, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___ReceivePlayerFloat_2317689966_Private_Void_NetworkConnection_NetworkObject_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067AB RID: 26539 RVA: 0x001D276C File Offset: 0x001D096C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210367, XrefRangeEnd = 210373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceivePlayerFloat_2317689966(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Observers_ReceivePlayerFloat_2317689966_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067AC RID: 26540 RVA: 0x001D27BC File Offset: 0x001D09BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210373, XrefRangeEnd = 210385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ReceivePlayerFloat_2317689966(NetworkConnection conn, NetworkObject playerObject, string key, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Target_ReceivePlayerFloat_2317689966_Private_Void_NetworkConnection_NetworkObject_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067AD RID: 26541 RVA: 0x001D2830 File Offset: 0x001D0A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210385, XrefRangeEnd = 210391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ReceivePlayerFloat_2317689966(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Target_ReceivePlayerFloat_2317689966_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067AE RID: 26542 RVA: 0x001D2880 File Offset: 0x001D0A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210391, XrefRangeEnd = 210395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_Method_Private_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067AF RID: 26543 RVA: 0x00030DD2 File Offset: 0x0002EFD2
		public CasinoGamePlayers(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F1B RID: 7963
		// (get) Token: 0x060067B0 RID: 26544 RVA: 0x001D28B4 File Offset: 0x001D0AB4
		// (set) Token: 0x060067B1 RID: 26545 RVA: 0x00030DDB File Offset: 0x0002EFDB
		public unsafe int PlayerLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_PlayerLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_PlayerLimit)) = value;
			}
		}

		// Token: 0x17001F1C RID: 7964
		// (get) Token: 0x060067B2 RID: 26546 RVA: 0x001D28DC File Offset: 0x001D0ADC
		// (set) Token: 0x060067B3 RID: 26547 RVA: 0x00030DF6 File Offset: 0x0002EFF6
		public unsafe Il2CppReferenceArray<Player> Players
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_Players);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_Players), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F1D RID: 7965
		// (get) Token: 0x060067B4 RID: 26548 RVA: 0x001D290C File Offset: 0x001D0B0C
		// (set) Token: 0x060067B5 RID: 26549 RVA: 0x00030E15 File Offset: 0x0002F015
		public unsafe UnityEvent onPlayerListChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_onPlayerListChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_onPlayerListChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F1E RID: 7966
		// (get) Token: 0x060067B6 RID: 26550 RVA: 0x001D293C File Offset: 0x001D0B3C
		// (set) Token: 0x060067B7 RID: 26551 RVA: 0x00030E34 File Offset: 0x0002F034
		public unsafe UnityEvent onPlayerScoresChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_onPlayerScoresChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_onPlayerScoresChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F1F RID: 7967
		// (get) Token: 0x060067B8 RID: 26552 RVA: 0x001D296C File Offset: 0x001D0B6C
		// (set) Token: 0x060067B9 RID: 26553 RVA: 0x00030E53 File Offset: 0x0002F053
		public unsafe Dictionary<Player, int> playerScores
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_playerScores);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Player, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_playerScores), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F20 RID: 7968
		// (get) Token: 0x060067BA RID: 26554 RVA: 0x001D299C File Offset: 0x001D0B9C
		// (set) Token: 0x060067BB RID: 26555 RVA: 0x00030E72 File Offset: 0x0002F072
		public unsafe Dictionary<Player, CasinoGamePlayerData> playerDatas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_playerDatas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Player, CasinoGamePlayerData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_playerDatas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F21 RID: 7969
		// (get) Token: 0x060067BC RID: 26556 RVA: 0x001D29CC File Offset: 0x001D0BCC
		// (set) Token: 0x060067BD RID: 26557 RVA: 0x00030E91 File Offset: 0x0002F091
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001F22 RID: 7970
		// (get) Token: 0x060067BE RID: 26558 RVA: 0x001D29F4 File Offset: 0x001D0BF4
		// (set) Token: 0x060067BF RID: 26559 RVA: 0x00030EAC File Offset: 0x0002F0AC
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040046CC RID: 18124
		private static readonly IntPtr NativeFieldInfoPtr_PlayerLimit;

		// Token: 0x040046CD RID: 18125
		private static readonly IntPtr NativeFieldInfoPtr_Players;

		// Token: 0x040046CE RID: 18126
		private static readonly IntPtr NativeFieldInfoPtr_onPlayerListChanged;

		// Token: 0x040046CF RID: 18127
		private static readonly IntPtr NativeFieldInfoPtr_onPlayerScoresChanged;

		// Token: 0x040046D0 RID: 18128
		private static readonly IntPtr NativeFieldInfoPtr_playerScores;

		// Token: 0x040046D1 RID: 18129
		private static readonly IntPtr NativeFieldInfoPtr_playerDatas;

		// Token: 0x040046D2 RID: 18130
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040046D3 RID: 18131
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040046D4 RID: 18132
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPlayerCount_Public_get_Int32_0;

		// Token: 0x040046D5 RID: 18133
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040046D6 RID: 18134
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x040046D7 RID: 18135
		private static readonly IntPtr NativeMethodInfoPtr_AddPlayer_Public_Void_Player_0;

		// Token: 0x040046D8 RID: 18136
		private static readonly IntPtr NativeMethodInfoPtr_RemovePlayer_Public_Void_Player_0;

		// Token: 0x040046D9 RID: 18137
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayerScore_Public_Void_Player_Int32_0;

		// Token: 0x040046DA RID: 18138
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerScore_Public_Int32_Player_0;

		// Token: 0x040046DB RID: 18139
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayer_Public_Player_Int32_0;

		// Token: 0x040046DC RID: 18140
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerIndex_Public_Int32_Player_0;

		// Token: 0x040046DD RID: 18141
		private static readonly IntPtr NativeMethodInfoPtr_RequestAddPlayer_Private_Void_NetworkObject_0;

		// Token: 0x040046DE RID: 18142
		private static readonly IntPtr NativeMethodInfoPtr_AddPlayerToArray_Private_Void_Player_0;

		// Token: 0x040046DF RID: 18143
		private static readonly IntPtr NativeMethodInfoPtr_RequestRemovePlayer_Private_Void_NetworkObject_0;

		// Token: 0x040046E0 RID: 18144
		private static readonly IntPtr NativeMethodInfoPtr_RemovePlayerFromArray_Private_Void_Player_0;

		// Token: 0x040046E1 RID: 18145
		private static readonly IntPtr NativeMethodInfoPtr_RequestSetScore_Private_Void_NetworkObject_Int32_0;

		// Token: 0x040046E2 RID: 18146
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayerScore_Private_Void_NetworkConnection_NetworkObject_Int32_0;

		// Token: 0x040046E3 RID: 18147
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayerList_Private_Void_NetworkConnection_Il2CppReferenceArray_1_NetworkObject_0;

		// Token: 0x040046E4 RID: 18148
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerData_Public_CasinoGamePlayerData_0;

		// Token: 0x040046E5 RID: 18149
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerData_Public_CasinoGamePlayerData_Player_0;

		// Token: 0x040046E6 RID: 18150
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerData_Public_CasinoGamePlayerData_Int32_0;

		// Token: 0x040046E7 RID: 18151
		private static readonly IntPtr NativeMethodInfoPtr_SendPlayerBool_Public_Void_NetworkObject_String_Boolean_0;

		// Token: 0x040046E8 RID: 18152
		private static readonly IntPtr NativeMethodInfoPtr_ReceivePlayerBool_Private_Void_NetworkConnection_NetworkObject_String_Boolean_0;

		// Token: 0x040046E9 RID: 18153
		private static readonly IntPtr NativeMethodInfoPtr_SendPlayerFloat_Public_Void_NetworkObject_String_Single_0;

		// Token: 0x040046EA RID: 18154
		private static readonly IntPtr NativeMethodInfoPtr_ReceivePlayerFloat_Private_Void_NetworkConnection_NetworkObject_String_Single_0;

		// Token: 0x040046EB RID: 18155
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerObjects_Private_Il2CppReferenceArray_1_NetworkObject_0;

		// Token: 0x040046EC RID: 18156
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040046ED RID: 18157
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040046EE RID: 18158
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040046EF RID: 18159
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040046F0 RID: 18160
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_RequestAddPlayer_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x040046F1 RID: 18161
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___RequestAddPlayer_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x040046F2 RID: 18162
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_RequestAddPlayer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040046F3 RID: 18163
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_RequestRemovePlayer_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x040046F4 RID: 18164
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___RequestRemovePlayer_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x040046F5 RID: 18165
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_RequestRemovePlayer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040046F6 RID: 18166
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_RequestSetScore_4172557123_Private_Void_NetworkObject_Int32_0;

		// Token: 0x040046F7 RID: 18167
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___RequestSetScore_4172557123_Private_Void_NetworkObject_Int32_0;

		// Token: 0x040046F8 RID: 18168
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_RequestSetScore_4172557123_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040046F9 RID: 18169
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetPlayerScore_1865307316_Private_Void_NetworkConnection_NetworkObject_Int32_0;

		// Token: 0x040046FA RID: 18170
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetPlayerScore_1865307316_Private_Void_NetworkConnection_NetworkObject_Int32_0;

		// Token: 0x040046FB RID: 18171
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetPlayerScore_1865307316_Private_Void_PooledReader_Channel_0;

		// Token: 0x040046FC RID: 18172
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetPlayerScore_1865307316_Private_Void_NetworkConnection_NetworkObject_Int32_0;

		// Token: 0x040046FD RID: 18173
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetPlayerScore_1865307316_Private_Void_PooledReader_Channel_0;

		// Token: 0x040046FE RID: 18174
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetPlayerList_204172449_Private_Void_NetworkConnection_Il2CppReferenceArray_1_NetworkObject_0;

		// Token: 0x040046FF RID: 18175
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetPlayerList_204172449_Private_Void_NetworkConnection_Il2CppReferenceArray_1_NetworkObject_0;

		// Token: 0x04004700 RID: 18176
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetPlayerList_204172449_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004701 RID: 18177
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetPlayerList_204172449_Private_Void_NetworkConnection_Il2CppReferenceArray_1_NetworkObject_0;

		// Token: 0x04004702 RID: 18178
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetPlayerList_204172449_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004703 RID: 18179
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendPlayerBool_77262511_Private_Void_NetworkObject_String_Boolean_0;

		// Token: 0x04004704 RID: 18180
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendPlayerBool_77262511_Public_Void_NetworkObject_String_Boolean_0;

		// Token: 0x04004705 RID: 18181
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendPlayerBool_77262511_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004706 RID: 18182
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceivePlayerBool_1748594478_Private_Void_NetworkConnection_NetworkObject_String_Boolean_0;

		// Token: 0x04004707 RID: 18183
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceivePlayerBool_1748594478_Private_Void_NetworkConnection_NetworkObject_String_Boolean_0;

		// Token: 0x04004708 RID: 18184
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceivePlayerBool_1748594478_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004709 RID: 18185
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_ReceivePlayerBool_1748594478_Private_Void_NetworkConnection_NetworkObject_String_Boolean_0;

		// Token: 0x0400470A RID: 18186
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_ReceivePlayerBool_1748594478_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400470B RID: 18187
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendPlayerFloat_2931762093_Private_Void_NetworkObject_String_Single_0;

		// Token: 0x0400470C RID: 18188
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendPlayerFloat_2931762093_Public_Void_NetworkObject_String_Single_0;

		// Token: 0x0400470D RID: 18189
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendPlayerFloat_2931762093_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400470E RID: 18190
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceivePlayerFloat_2317689966_Private_Void_NetworkConnection_NetworkObject_String_Single_0;

		// Token: 0x0400470F RID: 18191
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceivePlayerFloat_2317689966_Private_Void_NetworkConnection_NetworkObject_String_Single_0;

		// Token: 0x04004710 RID: 18192
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceivePlayerFloat_2317689966_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004711 RID: 18193
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_ReceivePlayerFloat_2317689966_Private_Void_NetworkConnection_NetworkObject_String_Single_0;

		// Token: 0x04004712 RID: 18194
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_ReceivePlayerFloat_2317689966_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004713 RID: 18195
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_0;

		// Token: 0x02000A42 RID: 2626
		[ObfuscatedName("ScheduleOne.Casino.CasinoGamePlayers+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600CFEF RID: 53231 RVA: 0x0031EAD4 File Offset: 0x0031CCD4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CasinoGamePlayers.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CasinoGamePlayers.__c>.NativeClassPtr);
				CasinoGamePlayers.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayers.__c>.NativeClassPtr, "<>9");
				CasinoGamePlayers.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayers.__c>.NativeClassPtr, "<>9__2_0");
				CasinoGamePlayers.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers.__c>.NativeClassPtr, 100676469);
				CasinoGamePlayers.__c.NativeMethodInfoPtr__get_CurrentPlayerCount_b__2_0_Internal_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers.__c>.NativeClassPtr, 100676470);
			}

			// Token: 0x0600CFF0 RID: 53232 RVA: 0x0031EB50 File Offset: 0x0031CD50
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CasinoGamePlayers.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFF1 RID: 53233 RVA: 0x0031EB8C File Offset: 0x0031CD8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209348, XrefRangeEnd = 209352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_CurrentPlayerCount_b__2_0(Player p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.__c.NativeMethodInfoPtr__get_CurrentPlayerCount_b__2_0_Internal_Boolean_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CFF2 RID: 53234 RVA: 0x000652BA File Offset: 0x000634BA
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004097 RID: 16535
			// (get) Token: 0x0600CFF3 RID: 53235 RVA: 0x0031EBDC File Offset: 0x0031CDDC
			// (set) Token: 0x0600CFF4 RID: 53236 RVA: 0x000652C3 File Offset: 0x000634C3
			public unsafe static CasinoGamePlayers.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CasinoGamePlayers.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CasinoGamePlayers.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CasinoGamePlayers.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004098 RID: 16536
			// (get) Token: 0x0600CFF5 RID: 53237 RVA: 0x0031EC04 File Offset: 0x0031CE04
			// (set) Token: 0x0600CFF6 RID: 53238 RVA: 0x000652D5 File Offset: 0x000634D5
			public unsafe static Func<Player, bool> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CasinoGamePlayers.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Player, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CasinoGamePlayers.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C3A RID: 35898
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008C3B RID: 35899
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x04008C3C RID: 35900
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C3D RID: 35901
			private static readonly IntPtr NativeMethodInfoPtr__get_CurrentPlayerCount_b__2_0_Internal_Boolean_Player_0;
		}
	}
}
