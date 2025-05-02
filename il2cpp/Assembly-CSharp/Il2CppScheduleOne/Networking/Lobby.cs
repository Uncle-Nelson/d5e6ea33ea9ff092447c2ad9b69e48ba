using System;
using Il2CppFishNet.Managing;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSteamworks;
using Il2CppSystem;

namespace Il2CppScheduleOne.Networking
{
	// Token: 0x0200036E RID: 878
	public class Lobby : PersistentSingleton<Lobby>
	{
		// Token: 0x06004483 RID: 17539 RVA: 0x001528E0 File Offset: 0x00150AE0
		// Note: this type is marked as 'beforefieldinit'.
		static Lobby()
		{
			Il2CppClassPointerStore<Lobby>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Networking", "Lobby");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lobby>.NativeClassPtr);
			Lobby.NativeFieldInfoPtr_ENABLED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "ENABLED");
			Lobby.NativeFieldInfoPtr_PLAYER_LIMIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "PLAYER_LIMIT");
			Lobby.NativeFieldInfoPtr_JOIN_READY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "JOIN_READY");
			Lobby.NativeFieldInfoPtr_LOAD_TUTORIAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "LOAD_TUTORIAL");
			Lobby.NativeFieldInfoPtr_HOST_LOADING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "HOST_LOADING");
			Lobby.NativeFieldInfoPtr_NetworkManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "NetworkManager");
			Lobby.NativeFieldInfoPtr__LobbyID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "<LobbyID>k__BackingField");
			Lobby.NativeFieldInfoPtr__LocalPlayerID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "<LocalPlayerID>k__BackingField");
			Lobby.NativeFieldInfoPtr_Players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "Players");
			Lobby.NativeFieldInfoPtr_onLobbyChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "onLobbyChange");
			Lobby.NativeFieldInfoPtr_LobbyCreatedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "LobbyCreatedCallback");
			Lobby.NativeFieldInfoPtr_LobbyEnteredCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "LobbyEnteredCallback");
			Lobby.NativeFieldInfoPtr_ChatUpdateCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "ChatUpdateCallback");
			Lobby.NativeFieldInfoPtr_GameLobbyJoinRequestedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "GameLobbyJoinRequestedCallback");
			Lobby.NativeFieldInfoPtr_LobbyChatMessageCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "LobbyChatMessageCallback");
			Lobby.NativeFieldInfoPtr_DebugSteamId64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "DebugSteamId64");
			Lobby.NativeMethodInfoPtr_get_IsHost_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671660);
			Lobby.NativeMethodInfoPtr_get_LobbyID_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671661);
			Lobby.NativeMethodInfoPtr_set_LobbyID_Private_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671662);
			Lobby.NativeMethodInfoPtr_get_LobbySteamID_Public_get_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671663);
			Lobby.NativeMethodInfoPtr_get_IsInLobby_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671664);
			Lobby.NativeMethodInfoPtr_get_PlayerCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671665);
			Lobby.NativeMethodInfoPtr_get_LocalPlayerID_Public_get_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671666);
			Lobby.NativeMethodInfoPtr_set_LocalPlayerID_Private_set_Void_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671667);
			Lobby.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671668);
			Lobby.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671669);
			Lobby.NativeMethodInfoPtr_InitializeCallbacks_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671670);
			Lobby.NativeMethodInfoPtr_TryOpenInviteInterface_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671671);
			Lobby.NativeMethodInfoPtr_LeaveLobby_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671672);
			Lobby.NativeMethodInfoPtr_CreateLobby_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671673);
			Lobby.NativeMethodInfoPtr_GetLaunchLobby_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671674);
			Lobby.NativeMethodInfoPtr_UpdateLobbyMembers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671675);
			Lobby.NativeMethodInfoPtr_DebugJoin_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671676);
			Lobby.NativeMethodInfoPtr_JoinAsClient_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671677);
			Lobby.NativeMethodInfoPtr_SendLobbyMessage_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671678);
			Lobby.NativeMethodInfoPtr_SetLobbyData_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671679);
			Lobby.NativeMethodInfoPtr_OnLobbyCreated_Private_Void_LobbyCreated_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671680);
			Lobby.NativeMethodInfoPtr_OnLobbyEntered_Private_Void_LobbyEnter_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671681);
			Lobby.NativeMethodInfoPtr_PlayerEnterOrLeave_Private_Void_LobbyChatUpdate_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671682);
			Lobby.NativeMethodInfoPtr_LobbyJoinRequested_Private_Void_GameLobbyJoinRequested_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671683);
			Lobby.NativeMethodInfoPtr_OnLobbyChatMessage_Private_Void_LobbyChatMsg_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671684);
			Lobby.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671685);
		}

		// Token: 0x170014C6 RID: 5318
		// (get) Token: 0x06004484 RID: 17540 RVA: 0x00152C58 File Offset: 0x00150E58
		public unsafe bool IsHost
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 155104, RefRangeEnd = 155124, XrefRangeStart = 155103, XrefRangeEnd = 155104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_get_IsHost_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170014C7 RID: 5319
		// (get) Token: 0x06004485 RID: 17541 RVA: 0x00152C94 File Offset: 0x00150E94
		// (set) Token: 0x06004486 RID: 17542 RVA: 0x00152CD0 File Offset: 0x00150ED0
		public unsafe ulong LobbyID
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19644, RefRangeEnd = 19658, XrefRangeStart = 19644, XrefRangeEnd = 19658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_get_LobbyID_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_set_LobbyID_Private_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170014C8 RID: 5320
		// (get) Token: 0x06004487 RID: 17543 RVA: 0x00152D10 File Offset: 0x00150F10
		public unsafe CSteamID LobbySteamID
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19644, RefRangeEnd = 19658, XrefRangeStart = 19644, XrefRangeEnd = 19658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_get_LobbySteamID_Public_get_CSteamID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170014C9 RID: 5321
		// (get) Token: 0x06004488 RID: 17544 RVA: 0x00152D4C File Offset: 0x00150F4C
		public unsafe bool IsInLobby
		{
			[CallerCount(33)]
			[CachedScanResults(RefRangeStart = 155124, RefRangeEnd = 155157, XrefRangeStart = 155124, XrefRangeEnd = 155124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_get_IsInLobby_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170014CA RID: 5322
		// (get) Token: 0x06004489 RID: 17545 RVA: 0x00152D88 File Offset: 0x00150F88
		public unsafe int PlayerCount
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 155175, RefRangeEnd = 155178, XrefRangeStart = 155157, XrefRangeEnd = 155175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_get_PlayerCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170014CB RID: 5323
		// (get) Token: 0x0600448A RID: 17546 RVA: 0x00152DC4 File Offset: 0x00150FC4
		// (set) Token: 0x0600448B RID: 17547 RVA: 0x00152E00 File Offset: 0x00151000
		public unsafe CSteamID LocalPlayerID
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 19660, RefRangeEnd = 19667, XrefRangeStart = 19660, XrefRangeEnd = 19667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_get_LocalPlayerID_Public_get_CSteamID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_set_LocalPlayerID_Private_set_Void_CSteamID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600448C RID: 17548 RVA: 0x00152E40 File Offset: 0x00151040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155178, XrefRangeEnd = 155195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Lobby.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600448D RID: 17549 RVA: 0x00152E7C File Offset: 0x0015107C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155195, XrefRangeEnd = 155237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Lobby.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600448E RID: 17550 RVA: 0x00152EB8 File Offset: 0x001510B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 155287, RefRangeEnd = 155288, XrefRangeStart = 155237, XrefRangeEnd = 155287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeCallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_InitializeCallbacks_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600448F RID: 17551 RVA: 0x00152EEC File Offset: 0x001510EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 155303, RefRangeEnd = 155304, XrefRangeStart = 155288, XrefRangeEnd = 155303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryOpenInviteInterface()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_TryOpenInviteInterface_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004490 RID: 17552 RVA: 0x00152F20 File Offset: 0x00151120
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 155314, RefRangeEnd = 155319, XrefRangeStart = 155304, XrefRangeEnd = 155314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LeaveLobby()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_LeaveLobby_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004491 RID: 17553 RVA: 0x00152F54 File Offset: 0x00151154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155319, XrefRangeEnd = 155320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateLobby()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_CreateLobby_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004492 RID: 17554 RVA: 0x00152F88 File Offset: 0x00151188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155320, XrefRangeEnd = 155327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLaunchLobby()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_GetLaunchLobby_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004493 RID: 17555 RVA: 0x00152FC0 File Offset: 0x001511C0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 155334, RefRangeEnd = 155338, XrefRangeStart = 155327, XrefRangeEnd = 155334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLobbyMembers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_UpdateLobbyMembers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004494 RID: 17556 RVA: 0x00152FF4 File Offset: 0x001511F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155338, XrefRangeEnd = 155339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DebugJoin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_DebugJoin_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004495 RID: 17557 RVA: 0x00153028 File Offset: 0x00151228
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 155345, RefRangeEnd = 155347, XrefRangeStart = 155339, XrefRangeEnd = 155345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void JoinAsClient(string steamId64)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(steamId64);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_JoinAsClient_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004496 RID: 17558 RVA: 0x0015306C File Offset: 0x0015126C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 155356, RefRangeEnd = 155359, XrefRangeStart = 155347, XrefRangeEnd = 155356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendLobbyMessage(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_SendLobbyMessage_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004497 RID: 17559 RVA: 0x001530B0 File Offset: 0x001512B0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 155366, RefRangeEnd = 155370, XrefRangeStart = 155359, XrefRangeEnd = 155366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLobbyData(string key, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_SetLobbyData_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004498 RID: 17560 RVA: 0x00153104 File Offset: 0x00151304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155370, XrefRangeEnd = 155417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLobbyCreated(LobbyCreated_t result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_OnLobbyCreated_Private_Void_LobbyCreated_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004499 RID: 17561 RVA: 0x00153144 File Offset: 0x00151344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155417, XrefRangeEnd = 155503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLobbyEntered(LobbyEnter_t result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_OnLobbyEntered_Private_Void_LobbyEnter_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600449A RID: 17562 RVA: 0x00153184 File Offset: 0x00151384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155503, XrefRangeEnd = 155518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerEnterOrLeave(LobbyChatUpdate_t result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_PlayerEnterOrLeave_Private_Void_LobbyChatUpdate_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600449B RID: 17563 RVA: 0x001531C4 File Offset: 0x001513C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155518, XrefRangeEnd = 155531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LobbyJoinRequested(GameLobbyJoinRequested_t result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_LobbyJoinRequested_Private_Void_GameLobbyJoinRequested_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600449C RID: 17564 RVA: 0x00153204 File Offset: 0x00151404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155531, XrefRangeEnd = 155568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLobbyChatMessage(LobbyChatMsg_t result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_OnLobbyChatMessage_Private_Void_LobbyChatMsg_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600449D RID: 17565 RVA: 0x00153244 File Offset: 0x00151444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155568, XrefRangeEnd = 155582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Lobby() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lobby>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600449E RID: 17566 RVA: 0x0002179F File Offset: 0x0001F99F
		public Lobby(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014B6 RID: 5302
		// (get) Token: 0x0600449F RID: 17567 RVA: 0x00153280 File Offset: 0x00151480
		// (set) Token: 0x060044A0 RID: 17568 RVA: 0x000217A8 File Offset: 0x0001F9A8
		public unsafe static bool ENABLED
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(Lobby.NativeFieldInfoPtr_ENABLED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Lobby.NativeFieldInfoPtr_ENABLED, (void*)(&value));
			}
		}

		// Token: 0x170014B7 RID: 5303
		// (get) Token: 0x060044A1 RID: 17569 RVA: 0x0015329C File Offset: 0x0015149C
		// (set) Token: 0x060044A2 RID: 17570 RVA: 0x000217B6 File Offset: 0x0001F9B6
		public unsafe static int PLAYER_LIMIT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Lobby.NativeFieldInfoPtr_PLAYER_LIMIT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Lobby.NativeFieldInfoPtr_PLAYER_LIMIT, (void*)(&value));
			}
		}

		// Token: 0x170014B8 RID: 5304
		// (get) Token: 0x060044A3 RID: 17571 RVA: 0x001532B8 File Offset: 0x001514B8
		// (set) Token: 0x060044A4 RID: 17572 RVA: 0x000217C4 File Offset: 0x0001F9C4
		public unsafe static string JOIN_READY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Lobby.NativeFieldInfoPtr_JOIN_READY, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Lobby.NativeFieldInfoPtr_JOIN_READY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170014B9 RID: 5305
		// (get) Token: 0x060044A5 RID: 17573 RVA: 0x001532D8 File Offset: 0x001514D8
		// (set) Token: 0x060044A6 RID: 17574 RVA: 0x000217D6 File Offset: 0x0001F9D6
		public unsafe static string LOAD_TUTORIAL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Lobby.NativeFieldInfoPtr_LOAD_TUTORIAL, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Lobby.NativeFieldInfoPtr_LOAD_TUTORIAL, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170014BA RID: 5306
		// (get) Token: 0x060044A7 RID: 17575 RVA: 0x001532F8 File Offset: 0x001514F8
		// (set) Token: 0x060044A8 RID: 17576 RVA: 0x000217E8 File Offset: 0x0001F9E8
		public unsafe static string HOST_LOADING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Lobby.NativeFieldInfoPtr_HOST_LOADING, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Lobby.NativeFieldInfoPtr_HOST_LOADING, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170014BB RID: 5307
		// (get) Token: 0x060044A9 RID: 17577 RVA: 0x00153318 File Offset: 0x00151518
		// (set) Token: 0x060044AA RID: 17578 RVA: 0x000217FA File Offset: 0x0001F9FA
		public unsafe NetworkManager NetworkManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_NetworkManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_NetworkManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014BC RID: 5308
		// (get) Token: 0x060044AB RID: 17579 RVA: 0x00153348 File Offset: 0x00151548
		// (set) Token: 0x060044AC RID: 17580 RVA: 0x00021819 File Offset: 0x0001FA19
		public unsafe ulong _LobbyID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr__LobbyID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr__LobbyID_k__BackingField)) = value;
			}
		}

		// Token: 0x170014BD RID: 5309
		// (get) Token: 0x060044AD RID: 17581 RVA: 0x00153370 File Offset: 0x00151570
		// (set) Token: 0x060044AE RID: 17582 RVA: 0x00021834 File Offset: 0x0001FA34
		public unsafe CSteamID _LocalPlayerID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr__LocalPlayerID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr__LocalPlayerID_k__BackingField)) = value;
			}
		}

		// Token: 0x170014BE RID: 5310
		// (get) Token: 0x060044AF RID: 17583 RVA: 0x00153398 File Offset: 0x00151598
		// (set) Token: 0x060044B0 RID: 17584 RVA: 0x0002184F File Offset: 0x0001FA4F
		public unsafe Il2CppStructArray<CSteamID> Players
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_Players);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<CSteamID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_Players), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014BF RID: 5311
		// (get) Token: 0x060044B1 RID: 17585 RVA: 0x001533C8 File Offset: 0x001515C8
		// (set) Token: 0x060044B2 RID: 17586 RVA: 0x0002186E File Offset: 0x0001FA6E
		public unsafe Action onLobbyChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_onLobbyChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_onLobbyChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014C0 RID: 5312
		// (get) Token: 0x060044B3 RID: 17587 RVA: 0x001533F8 File Offset: 0x001515F8
		// (set) Token: 0x060044B4 RID: 17588 RVA: 0x0002188D File Offset: 0x0001FA8D
		public unsafe Callback<LobbyCreated_t> LobbyCreatedCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_LobbyCreatedCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Callback<LobbyCreated_t>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_LobbyCreatedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014C1 RID: 5313
		// (get) Token: 0x060044B5 RID: 17589 RVA: 0x00153428 File Offset: 0x00151628
		// (set) Token: 0x060044B6 RID: 17590 RVA: 0x000218AC File Offset: 0x0001FAAC
		public unsafe Callback<LobbyEnter_t> LobbyEnteredCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_LobbyEnteredCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Callback<LobbyEnter_t>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_LobbyEnteredCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014C2 RID: 5314
		// (get) Token: 0x060044B7 RID: 17591 RVA: 0x00153458 File Offset: 0x00151658
		// (set) Token: 0x060044B8 RID: 17592 RVA: 0x000218CB File Offset: 0x0001FACB
		public unsafe Callback<LobbyChatUpdate_t> ChatUpdateCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_ChatUpdateCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Callback<LobbyChatUpdate_t>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_ChatUpdateCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014C3 RID: 5315
		// (get) Token: 0x060044B9 RID: 17593 RVA: 0x00153488 File Offset: 0x00151688
		// (set) Token: 0x060044BA RID: 17594 RVA: 0x000218EA File Offset: 0x0001FAEA
		public unsafe Callback<GameLobbyJoinRequested_t> GameLobbyJoinRequestedCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_GameLobbyJoinRequestedCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Callback<GameLobbyJoinRequested_t>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_GameLobbyJoinRequestedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014C4 RID: 5316
		// (get) Token: 0x060044BB RID: 17595 RVA: 0x001534B8 File Offset: 0x001516B8
		// (set) Token: 0x060044BC RID: 17596 RVA: 0x00021909 File Offset: 0x0001FB09
		public unsafe Callback<LobbyChatMsg_t> LobbyChatMessageCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_LobbyChatMessageCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Callback<LobbyChatMsg_t>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_LobbyChatMessageCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014C5 RID: 5317
		// (get) Token: 0x060044BD RID: 17597 RVA: 0x001534E8 File Offset: 0x001516E8
		// (set) Token: 0x060044BE RID: 17598 RVA: 0x00021928 File Offset: 0x0001FB28
		public unsafe string DebugSteamId64
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_DebugSteamId64);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_DebugSteamId64), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002DE0 RID: 11744
		private static readonly IntPtr NativeFieldInfoPtr_ENABLED;

		// Token: 0x04002DE1 RID: 11745
		private static readonly IntPtr NativeFieldInfoPtr_PLAYER_LIMIT;

		// Token: 0x04002DE2 RID: 11746
		private static readonly IntPtr NativeFieldInfoPtr_JOIN_READY;

		// Token: 0x04002DE3 RID: 11747
		private static readonly IntPtr NativeFieldInfoPtr_LOAD_TUTORIAL;

		// Token: 0x04002DE4 RID: 11748
		private static readonly IntPtr NativeFieldInfoPtr_HOST_LOADING;

		// Token: 0x04002DE5 RID: 11749
		private static readonly IntPtr NativeFieldInfoPtr_NetworkManager;

		// Token: 0x04002DE6 RID: 11750
		private static readonly IntPtr NativeFieldInfoPtr__LobbyID_k__BackingField;

		// Token: 0x04002DE7 RID: 11751
		private static readonly IntPtr NativeFieldInfoPtr__LocalPlayerID_k__BackingField;

		// Token: 0x04002DE8 RID: 11752
		private static readonly IntPtr NativeFieldInfoPtr_Players;

		// Token: 0x04002DE9 RID: 11753
		private static readonly IntPtr NativeFieldInfoPtr_onLobbyChange;

		// Token: 0x04002DEA RID: 11754
		private static readonly IntPtr NativeFieldInfoPtr_LobbyCreatedCallback;

		// Token: 0x04002DEB RID: 11755
		private static readonly IntPtr NativeFieldInfoPtr_LobbyEnteredCallback;

		// Token: 0x04002DEC RID: 11756
		private static readonly IntPtr NativeFieldInfoPtr_ChatUpdateCallback;

		// Token: 0x04002DED RID: 11757
		private static readonly IntPtr NativeFieldInfoPtr_GameLobbyJoinRequestedCallback;

		// Token: 0x04002DEE RID: 11758
		private static readonly IntPtr NativeFieldInfoPtr_LobbyChatMessageCallback;

		// Token: 0x04002DEF RID: 11759
		private static readonly IntPtr NativeFieldInfoPtr_DebugSteamId64;

		// Token: 0x04002DF0 RID: 11760
		private static readonly IntPtr NativeMethodInfoPtr_get_IsHost_Public_get_Boolean_0;

		// Token: 0x04002DF1 RID: 11761
		private static readonly IntPtr NativeMethodInfoPtr_get_LobbyID_Public_get_UInt64_0;

		// Token: 0x04002DF2 RID: 11762
		private static readonly IntPtr NativeMethodInfoPtr_set_LobbyID_Private_set_Void_UInt64_0;

		// Token: 0x04002DF3 RID: 11763
		private static readonly IntPtr NativeMethodInfoPtr_get_LobbySteamID_Public_get_CSteamID_0;

		// Token: 0x04002DF4 RID: 11764
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInLobby_Public_get_Boolean_0;

		// Token: 0x04002DF5 RID: 11765
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerCount_Public_get_Int32_0;

		// Token: 0x04002DF6 RID: 11766
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalPlayerID_Public_get_CSteamID_0;

		// Token: 0x04002DF7 RID: 11767
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalPlayerID_Private_set_Void_CSteamID_0;

		// Token: 0x04002DF8 RID: 11768
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04002DF9 RID: 11769
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04002DFA RID: 11770
		private static readonly IntPtr NativeMethodInfoPtr_InitializeCallbacks_Private_Void_0;

		// Token: 0x04002DFB RID: 11771
		private static readonly IntPtr NativeMethodInfoPtr_TryOpenInviteInterface_Public_Void_0;

		// Token: 0x04002DFC RID: 11772
		private static readonly IntPtr NativeMethodInfoPtr_LeaveLobby_Public_Void_0;

		// Token: 0x04002DFD RID: 11773
		private static readonly IntPtr NativeMethodInfoPtr_CreateLobby_Private_Void_0;

		// Token: 0x04002DFE RID: 11774
		private static readonly IntPtr NativeMethodInfoPtr_GetLaunchLobby_Private_String_0;

		// Token: 0x04002DFF RID: 11775
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLobbyMembers_Private_Void_0;

		// Token: 0x04002E00 RID: 11776
		private static readonly IntPtr NativeMethodInfoPtr_DebugJoin_Public_Void_0;

		// Token: 0x04002E01 RID: 11777
		private static readonly IntPtr NativeMethodInfoPtr_JoinAsClient_Public_Void_String_0;

		// Token: 0x04002E02 RID: 11778
		private static readonly IntPtr NativeMethodInfoPtr_SendLobbyMessage_Public_Void_String_0;

		// Token: 0x04002E03 RID: 11779
		private static readonly IntPtr NativeMethodInfoPtr_SetLobbyData_Public_Void_String_String_0;

		// Token: 0x04002E04 RID: 11780
		private static readonly IntPtr NativeMethodInfoPtr_OnLobbyCreated_Private_Void_LobbyCreated_t_0;

		// Token: 0x04002E05 RID: 11781
		private static readonly IntPtr NativeMethodInfoPtr_OnLobbyEntered_Private_Void_LobbyEnter_t_0;

		// Token: 0x04002E06 RID: 11782
		private static readonly IntPtr NativeMethodInfoPtr_PlayerEnterOrLeave_Private_Void_LobbyChatUpdate_t_0;

		// Token: 0x04002E07 RID: 11783
		private static readonly IntPtr NativeMethodInfoPtr_LobbyJoinRequested_Private_Void_GameLobbyJoinRequested_t_0;

		// Token: 0x04002E08 RID: 11784
		private static readonly IntPtr NativeMethodInfoPtr_OnLobbyChatMessage_Private_Void_LobbyChatMsg_t_0;

		// Token: 0x04002E09 RID: 11785
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000968 RID: 2408
		[ObfuscatedName("ScheduleOne.Networking.Lobby+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600C959 RID: 51545 RVA: 0x0030C0F4 File Offset: 0x0030A2F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Lobby.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lobby.__c>.NativeClassPtr);
				Lobby.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby.__c>.NativeClassPtr, "<>9");
				Lobby.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby.__c>.NativeClassPtr, "<>9__17_0");
				Lobby.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby.__c>.NativeClassPtr, 100671687);
				Lobby.__c.NativeMethodInfoPtr__get_PlayerCount_b__17_0_Internal_Boolean_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby.__c>.NativeClassPtr, 100671688);
			}

			// Token: 0x0600C95A RID: 51546 RVA: 0x0030C170 File Offset: 0x0030A370
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lobby.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C95B RID: 51547 RVA: 0x0030C1AC File Offset: 0x0030A3AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155098, XrefRangeEnd = 155103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_PlayerCount_b__17_0(CSteamID p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.__c.NativeMethodInfoPtr__get_PlayerCount_b__17_0_Internal_Boolean_CSteamID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C95C RID: 51548 RVA: 0x00061EF2 File Offset: 0x000600F2
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003ECF RID: 16079
			// (get) Token: 0x0600C95D RID: 51549 RVA: 0x0030C1F8 File Offset: 0x0030A3F8
			// (set) Token: 0x0600C95E RID: 51550 RVA: 0x00061EFB File Offset: 0x000600FB
			public unsafe static Lobby.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Lobby.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lobby.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Lobby.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003ED0 RID: 16080
			// (get) Token: 0x0600C95F RID: 51551 RVA: 0x0030C220 File Offset: 0x0030A420
			// (set) Token: 0x0600C960 RID: 51552 RVA: 0x00061F0D File Offset: 0x0006010D
			public unsafe static Func<CSteamID, bool> __9__17_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Lobby.__c.NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<CSteamID, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Lobby.__c.NativeFieldInfoPtr___9__17_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008849 RID: 34889
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400884A RID: 34890
			private static readonly IntPtr NativeFieldInfoPtr___9__17_0;

			// Token: 0x0400884B RID: 34891
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400884C RID: 34892
			private static readonly IntPtr NativeMethodInfoPtr__get_PlayerCount_b__17_0_Internal_Boolean_CSteamID_0;
		}
	}
}
