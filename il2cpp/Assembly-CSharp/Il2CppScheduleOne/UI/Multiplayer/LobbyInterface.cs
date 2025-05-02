using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Networking;
using Il2CppSteamworks;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Multiplayer
{
	// Token: 0x020006B7 RID: 1719
	public class LobbyInterface : PersistentSingleton<LobbyInterface>
	{
		// Token: 0x06009B11 RID: 39697 RVA: 0x00275E30 File Offset: 0x00274030
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyInterface()
		{
			Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Multiplayer", "LobbyInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr);
			LobbyInterface.NativeFieldInfoPtr_Lobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, "Lobby");
			LobbyInterface.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, "Canvas");
			LobbyInterface.NativeFieldInfoPtr_LobbyTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, "LobbyTitle");
			LobbyInterface.NativeFieldInfoPtr_PlayerSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, "PlayerSlots");
			LobbyInterface.NativeFieldInfoPtr_InviteButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, "InviteButton");
			LobbyInterface.NativeFieldInfoPtr_LeaveButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, "LeaveButton");
			LobbyInterface.NativeFieldInfoPtr_InviteHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, "InviteHint");
			LobbyInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100682366);
			LobbyInterface.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100682367);
			LobbyInterface.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100682368);
			LobbyInterface.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100682369);
			LobbyInterface.NativeMethodInfoPtr_LeaveClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100682370);
			LobbyInterface.NativeMethodInfoPtr_InviteClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100682371);
			LobbyInterface.NativeMethodInfoPtr_UpdateButtons_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100682372);
			LobbyInterface.NativeMethodInfoPtr_UpdatePlayers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100682373);
			LobbyInterface.NativeMethodInfoPtr_SetPlayer_Public_Void_Int32_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100682374);
			LobbyInterface.NativeMethodInfoPtr_ClearPlayer_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100682375);
			LobbyInterface.NativeMethodInfoPtr_GetAvatar_Private_Texture2D_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100682376);
			LobbyInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100682377);
			LobbyInterface.NativeMethodInfoPtr__Awake_b__7_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100682378);
		}

		// Token: 0x06009B12 RID: 39698 RVA: 0x00275FF0 File Offset: 0x002741F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275734, XrefRangeEnd = 275775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LobbyInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B13 RID: 39699 RVA: 0x0027602C File Offset: 0x0027422C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275775, XrefRangeEnd = 275798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LobbyInterface.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B14 RID: 39700 RVA: 0x00276068 File Offset: 0x00274268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275798, XrefRangeEnd = 275806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B15 RID: 39701 RVA: 0x0027609C File Offset: 0x0027429C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275806, XrefRangeEnd = 275808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B16 RID: 39702 RVA: 0x002760DC File Offset: 0x002742DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275808, XrefRangeEnd = 275810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LeaveClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_LeaveClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B17 RID: 39703 RVA: 0x00276110 File Offset: 0x00274310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275810, XrefRangeEnd = 275816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InviteClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_InviteClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B18 RID: 39704 RVA: 0x00276144 File Offset: 0x00274344
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 275825, RefRangeEnd = 275827, XrefRangeStart = 275816, XrefRangeEnd = 275825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateButtons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_UpdateButtons_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B19 RID: 39705 RVA: 0x00276178 File Offset: 0x00274378
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 275845, RefRangeEnd = 275847, XrefRangeStart = 275827, XrefRangeEnd = 275845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePlayers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_UpdatePlayers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B1A RID: 39706 RVA: 0x002761AC File Offset: 0x002743AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 275859, RefRangeEnd = 275861, XrefRangeStart = 275847, XrefRangeEnd = 275859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPlayer(int index, CSteamID player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref player;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_SetPlayer_Public_Void_Int32_CSteamID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B1B RID: 39707 RVA: 0x002761F8 File Offset: 0x002743F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 275869, RefRangeEnd = 275870, XrefRangeStart = 275861, XrefRangeEnd = 275869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearPlayer(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_ClearPlayer_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B1C RID: 39708 RVA: 0x00276238 File Offset: 0x00274438
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 275886, RefRangeEnd = 275887, XrefRangeStart = 275870, XrefRangeEnd = 275886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D GetAvatar(CSteamID user)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref user;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_GetAvatar_Private_Texture2D_CSteamID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}

		// Token: 0x06009B1D RID: 39709 RVA: 0x00276284 File Offset: 0x00274484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275887, XrefRangeEnd = 275890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LobbyInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B1E RID: 39710 RVA: 0x002762C0 File Offset: 0x002744C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275890, XrefRangeEnd = 275910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__7_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr__Awake_b__7_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B1F RID: 39711 RVA: 0x0004BEE4 File Offset: 0x0004A0E4
		public LobbyInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002FC3 RID: 12227
		// (get) Token: 0x06009B20 RID: 39712 RVA: 0x002762F4 File Offset: 0x002744F4
		// (set) Token: 0x06009B21 RID: 39713 RVA: 0x0004BEED File Offset: 0x0004A0ED
		public unsafe Lobby Lobby
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_Lobby);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lobby>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_Lobby), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FC4 RID: 12228
		// (get) Token: 0x06009B22 RID: 39714 RVA: 0x00276324 File Offset: 0x00274524
		// (set) Token: 0x06009B23 RID: 39715 RVA: 0x0004BF0C File Offset: 0x0004A10C
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FC5 RID: 12229
		// (get) Token: 0x06009B24 RID: 39716 RVA: 0x00276354 File Offset: 0x00274554
		// (set) Token: 0x06009B25 RID: 39717 RVA: 0x0004BF2B File Offset: 0x0004A12B
		public unsafe TextMeshProUGUI LobbyTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_LobbyTitle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_LobbyTitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FC6 RID: 12230
		// (get) Token: 0x06009B26 RID: 39718 RVA: 0x00276384 File Offset: 0x00274584
		// (set) Token: 0x06009B27 RID: 39719 RVA: 0x0004BF4A File Offset: 0x0004A14A
		public unsafe Il2CppReferenceArray<RectTransform> PlayerSlots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_PlayerSlots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_PlayerSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FC7 RID: 12231
		// (get) Token: 0x06009B28 RID: 39720 RVA: 0x002763B4 File Offset: 0x002745B4
		// (set) Token: 0x06009B29 RID: 39721 RVA: 0x0004BF69 File Offset: 0x0004A169
		public unsafe Button InviteButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_InviteButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_InviteButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FC8 RID: 12232
		// (get) Token: 0x06009B2A RID: 39722 RVA: 0x002763E4 File Offset: 0x002745E4
		// (set) Token: 0x06009B2B RID: 39723 RVA: 0x0004BF88 File Offset: 0x0004A188
		public unsafe Button LeaveButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_LeaveButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_LeaveButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FC9 RID: 12233
		// (get) Token: 0x06009B2C RID: 39724 RVA: 0x00276414 File Offset: 0x00274614
		// (set) Token: 0x06009B2D RID: 39725 RVA: 0x0004BFA7 File Offset: 0x0004A1A7
		public unsafe GameObject InviteHint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_InviteHint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_InviteHint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006842 RID: 26690
		private static readonly IntPtr NativeFieldInfoPtr_Lobby;

		// Token: 0x04006843 RID: 26691
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04006844 RID: 26692
		private static readonly IntPtr NativeFieldInfoPtr_LobbyTitle;

		// Token: 0x04006845 RID: 26693
		private static readonly IntPtr NativeFieldInfoPtr_PlayerSlots;

		// Token: 0x04006846 RID: 26694
		private static readonly IntPtr NativeFieldInfoPtr_InviteButton;

		// Token: 0x04006847 RID: 26695
		private static readonly IntPtr NativeFieldInfoPtr_LeaveButton;

		// Token: 0x04006848 RID: 26696
		private static readonly IntPtr NativeFieldInfoPtr_InviteHint;

		// Token: 0x04006849 RID: 26697
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400684A RID: 26698
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400684B RID: 26699
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x0400684C RID: 26700
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0;

		// Token: 0x0400684D RID: 26701
		private static readonly IntPtr NativeMethodInfoPtr_LeaveClicked_Public_Void_0;

		// Token: 0x0400684E RID: 26702
		private static readonly IntPtr NativeMethodInfoPtr_InviteClicked_Public_Void_0;

		// Token: 0x0400684F RID: 26703
		private static readonly IntPtr NativeMethodInfoPtr_UpdateButtons_Private_Void_0;

		// Token: 0x04006850 RID: 26704
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePlayers_Private_Void_0;

		// Token: 0x04006851 RID: 26705
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayer_Public_Void_Int32_CSteamID_0;

		// Token: 0x04006852 RID: 26706
		private static readonly IntPtr NativeMethodInfoPtr_ClearPlayer_Public_Void_Int32_0;

		// Token: 0x04006853 RID: 26707
		private static readonly IntPtr NativeMethodInfoPtr_GetAvatar_Private_Texture2D_CSteamID_0;

		// Token: 0x04006854 RID: 26708
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006855 RID: 26709
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__7_0_Private_Void_0;
	}
}
