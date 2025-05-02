using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Casino.UI
{
	// Token: 0x020004AA RID: 1194
	public class BlackjackInterface : Singleton<BlackjackInterface>
	{
		// Token: 0x060068E8 RID: 26856 RVA: 0x001D6DCC File Offset: 0x001D4FCC
		// Note: this type is marked as 'beforefieldinit'.
		static BlackjackInterface()
		{
			Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino.UI", "BlackjackInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr);
			BlackjackInterface.NativeFieldInfoPtr__CurrentGame_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "<CurrentGame>k__BackingField");
			BlackjackInterface.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "Canvas");
			BlackjackInterface.NativeFieldInfoPtr_PlayerDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "PlayerDisplay");
			BlackjackInterface.NativeFieldInfoPtr_BetContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "BetContainer");
			BlackjackInterface.NativeFieldInfoPtr_BetTitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "BetTitleLabel");
			BlackjackInterface.NativeFieldInfoPtr_BetSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "BetSlider");
			BlackjackInterface.NativeFieldInfoPtr_BetAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "BetAmount");
			BlackjackInterface.NativeFieldInfoPtr_ReadyButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "ReadyButton");
			BlackjackInterface.NativeFieldInfoPtr_ReadyLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "ReadyLabel");
			BlackjackInterface.NativeFieldInfoPtr_WaitingContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "WaitingContainer");
			BlackjackInterface.NativeFieldInfoPtr_WaitingLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "WaitingLabel");
			BlackjackInterface.NativeFieldInfoPtr_DealerScoreLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "DealerScoreLabel");
			BlackjackInterface.NativeFieldInfoPtr_PlayerScoreLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "PlayerScoreLabel");
			BlackjackInterface.NativeFieldInfoPtr_HitButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "HitButton");
			BlackjackInterface.NativeFieldInfoPtr_StandButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "StandButton");
			BlackjackInterface.NativeFieldInfoPtr_InputContainerAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "InputContainerAnimation");
			BlackjackInterface.NativeFieldInfoPtr_InputContainerCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "InputContainerCanvasGroup");
			BlackjackInterface.NativeFieldInfoPtr_InputContainerFadeIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "InputContainerFadeIn");
			BlackjackInterface.NativeFieldInfoPtr_InputContainerFadeOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "InputContainerFadeOut");
			BlackjackInterface.NativeFieldInfoPtr_SelectionIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "SelectionIndicator");
			BlackjackInterface.NativeFieldInfoPtr_ScoresContainerAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "ScoresContainerAnimation");
			BlackjackInterface.NativeFieldInfoPtr_ScoresContainerCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "ScoresContainerCanvasGroup");
			BlackjackInterface.NativeFieldInfoPtr_PositiveOutcomeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "PositiveOutcomeLabel");
			BlackjackInterface.NativeFieldInfoPtr_PayoutLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "PayoutLabel");
			BlackjackInterface.NativeFieldInfoPtr_onBust = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "onBust");
			BlackjackInterface.NativeFieldInfoPtr_onBlackjack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "onBlackjack");
			BlackjackInterface.NativeFieldInfoPtr_onWin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "onWin");
			BlackjackInterface.NativeFieldInfoPtr_onLose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "onLose");
			BlackjackInterface.NativeFieldInfoPtr_onPush = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "onPush");
			BlackjackInterface.NativeMethodInfoPtr_get_CurrentGame_Public_get_BlackjackGameController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676652);
			BlackjackInterface.NativeMethodInfoPtr_set_CurrentGame_Private_set_Void_BlackjackGameController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676653);
			BlackjackInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676654);
			BlackjackInterface.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676655);
			BlackjackInterface.NativeMethodInfoPtr_Open_Public_Void_BlackjackGameController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676656);
			BlackjackInterface.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676657);
			BlackjackInterface.NativeMethodInfoPtr_BetSliderChanged_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676658);
			BlackjackInterface.NativeMethodInfoPtr_GetBetFromSliderValue_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676659);
			BlackjackInterface.NativeMethodInfoPtr_RefreshDisplayedBet_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676660);
			BlackjackInterface.NativeMethodInfoPtr_RefreshReadyButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676661);
			BlackjackInterface.NativeMethodInfoPtr_LocalPlayerReadyForInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676662);
			BlackjackInterface.NativeMethodInfoPtr_ShowScores_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676663);
			BlackjackInterface.NativeMethodInfoPtr_HideScores_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676664);
			BlackjackInterface.NativeMethodInfoPtr_HitClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676665);
			BlackjackInterface.NativeMethodInfoPtr_StandClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676666);
			BlackjackInterface.NativeMethodInfoPtr_LocalPlayerExitRound_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676667);
			BlackjackInterface.NativeMethodInfoPtr_ReadyButtonClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676668);
			BlackjackInterface.NativeMethodInfoPtr_OnLocalPlayerBust_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676669);
			BlackjackInterface.NativeMethodInfoPtr_OnLocalPlayerRoundCompleted_Private_Void_EPayoutType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676670);
			BlackjackInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676671);
		}

		// Token: 0x17001F9A RID: 8090
		// (get) Token: 0x060068E9 RID: 26857 RVA: 0x001D71D0 File Offset: 0x001D53D0
		// (set) Token: 0x060068EA RID: 26858 RVA: 0x001D7210 File Offset: 0x001D5410
		public unsafe BlackjackGameController CurrentGame
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19637, RefRangeEnd = 19640, XrefRangeStart = 19637, XrefRangeEnd = 19640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_get_CurrentGame_Public_get_BlackjackGameController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BlackjackGameController>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19641, RefRangeEnd = 19644, XrefRangeStart = 19641, XrefRangeEnd = 19644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_set_CurrentGame_Private_set_Void_BlackjackGameController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060068EB RID: 26859 RVA: 0x001D7254 File Offset: 0x001D5454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212237, XrefRangeEnd = 212273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlackjackInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068EC RID: 26860 RVA: 0x001D7290 File Offset: 0x001D5490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212273, XrefRangeEnd = 212319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068ED RID: 26861 RVA: 0x001D72C4 File Offset: 0x001D54C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212409, RefRangeEnd = 212410, XrefRangeStart = 212319, XrefRangeEnd = 212409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(BlackjackGameController game)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(game);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_Open_Public_Void_BlackjackGameController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068EE RID: 26862 RVA: 0x001D7308 File Offset: 0x001D5508
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212499, RefRangeEnd = 212500, XrefRangeStart = 212410, XrefRangeEnd = 212499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068EF RID: 26863 RVA: 0x001D733C File Offset: 0x001D553C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212500, XrefRangeEnd = 212505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BetSliderChanged(float newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_BetSliderChanged_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068F0 RID: 26864 RVA: 0x001D737C File Offset: 0x001D557C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212505, XrefRangeEnd = 212507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetBetFromSliderValue(float sliderVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sliderVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_GetBetFromSliderValue_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060068F1 RID: 26865 RVA: 0x001D73C8 File Offset: 0x001D55C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 212512, RefRangeEnd = 212515, XrefRangeStart = 212507, XrefRangeEnd = 212512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshDisplayedBet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_RefreshDisplayedBet_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068F2 RID: 26866 RVA: 0x001D73FC File Offset: 0x001D55FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212533, RefRangeEnd = 212534, XrefRangeStart = 212515, XrefRangeEnd = 212533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshReadyButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_RefreshReadyButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068F3 RID: 26867 RVA: 0x001D7430 File Offset: 0x001D5630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212534, XrefRangeEnd = 212540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LocalPlayerReadyForInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_LocalPlayerReadyForInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068F4 RID: 26868 RVA: 0x001D7464 File Offset: 0x001D5664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212540, XrefRangeEnd = 212543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowScores()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_ShowScores_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068F5 RID: 26869 RVA: 0x001D7498 File Offset: 0x001D5698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212543, XrefRangeEnd = 212546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HideScores()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_HideScores_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068F6 RID: 26870 RVA: 0x001D74CC File Offset: 0x001D56CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212546, XrefRangeEnd = 212562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HitClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_HitClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068F7 RID: 26871 RVA: 0x001D7500 File Offset: 0x001D5700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212562, XrefRangeEnd = 212578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StandClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_StandClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068F8 RID: 26872 RVA: 0x001D7534 File Offset: 0x001D5734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212578, XrefRangeEnd = 212584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LocalPlayerExitRound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_LocalPlayerExitRound_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068F9 RID: 26873 RVA: 0x001D7568 File Offset: 0x001D5768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212584, XrefRangeEnd = 212586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadyButtonClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_ReadyButtonClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068FA RID: 26874 RVA: 0x001D759C File Offset: 0x001D579C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212586, XrefRangeEnd = 212587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLocalPlayerBust()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_OnLocalPlayerBust_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068FB RID: 26875 RVA: 0x001D75D0 File Offset: 0x001D57D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212587, XrefRangeEnd = 212592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLocalPlayerRoundCompleted(BlackjackGameController.EPayoutType payout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref payout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_OnLocalPlayerRoundCompleted_Private_Void_EPayoutType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068FC RID: 26876 RVA: 0x001D7610 File Offset: 0x001D5810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212592, XrefRangeEnd = 212595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlackjackInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068FD RID: 26877 RVA: 0x0003173A File Offset: 0x0002F93A
		public BlackjackInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F7D RID: 8061
		// (get) Token: 0x060068FE RID: 26878 RVA: 0x001D764C File Offset: 0x001D584C
		// (set) Token: 0x060068FF RID: 26879 RVA: 0x00031743 File Offset: 0x0002F943
		public unsafe BlackjackGameController _CurrentGame_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr__CurrentGame_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlackjackGameController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr__CurrentGame_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F7E RID: 8062
		// (get) Token: 0x06006900 RID: 26880 RVA: 0x001D767C File Offset: 0x001D587C
		// (set) Token: 0x06006901 RID: 26881 RVA: 0x00031762 File Offset: 0x0002F962
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F7F RID: 8063
		// (get) Token: 0x06006902 RID: 26882 RVA: 0x001D76AC File Offset: 0x001D58AC
		// (set) Token: 0x06006903 RID: 26883 RVA: 0x00031781 File Offset: 0x0002F981
		public unsafe CasinoGamePlayerDisplay PlayerDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_PlayerDisplay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CasinoGamePlayerDisplay>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_PlayerDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F80 RID: 8064
		// (get) Token: 0x06006904 RID: 26884 RVA: 0x001D76DC File Offset: 0x001D58DC
		// (set) Token: 0x06006905 RID: 26885 RVA: 0x000317A0 File Offset: 0x0002F9A0
		public unsafe RectTransform BetContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_BetContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_BetContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F81 RID: 8065
		// (get) Token: 0x06006906 RID: 26886 RVA: 0x001D770C File Offset: 0x001D590C
		// (set) Token: 0x06006907 RID: 26887 RVA: 0x000317BF File Offset: 0x0002F9BF
		public unsafe TextMeshProUGUI BetTitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_BetTitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_BetTitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F82 RID: 8066
		// (get) Token: 0x06006908 RID: 26888 RVA: 0x001D773C File Offset: 0x001D593C
		// (set) Token: 0x06006909 RID: 26889 RVA: 0x000317DE File Offset: 0x0002F9DE
		public unsafe Slider BetSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_BetSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_BetSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F83 RID: 8067
		// (get) Token: 0x0600690A RID: 26890 RVA: 0x001D776C File Offset: 0x001D596C
		// (set) Token: 0x0600690B RID: 26891 RVA: 0x000317FD File Offset: 0x0002F9FD
		public unsafe TextMeshProUGUI BetAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_BetAmount);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_BetAmount), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F84 RID: 8068
		// (get) Token: 0x0600690C RID: 26892 RVA: 0x001D779C File Offset: 0x001D599C
		// (set) Token: 0x0600690D RID: 26893 RVA: 0x0003181C File Offset: 0x0002FA1C
		public unsafe Button ReadyButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_ReadyButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_ReadyButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F85 RID: 8069
		// (get) Token: 0x0600690E RID: 26894 RVA: 0x001D77CC File Offset: 0x001D59CC
		// (set) Token: 0x0600690F RID: 26895 RVA: 0x0003183B File Offset: 0x0002FA3B
		public unsafe TextMeshProUGUI ReadyLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_ReadyLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_ReadyLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F86 RID: 8070
		// (get) Token: 0x06006910 RID: 26896 RVA: 0x001D77FC File Offset: 0x001D59FC
		// (set) Token: 0x06006911 RID: 26897 RVA: 0x0003185A File Offset: 0x0002FA5A
		public unsafe RectTransform WaitingContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_WaitingContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_WaitingContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F87 RID: 8071
		// (get) Token: 0x06006912 RID: 26898 RVA: 0x001D782C File Offset: 0x001D5A2C
		// (set) Token: 0x06006913 RID: 26899 RVA: 0x00031879 File Offset: 0x0002FA79
		public unsafe TextMeshProUGUI WaitingLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_WaitingLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_WaitingLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F88 RID: 8072
		// (get) Token: 0x06006914 RID: 26900 RVA: 0x001D785C File Offset: 0x001D5A5C
		// (set) Token: 0x06006915 RID: 26901 RVA: 0x00031898 File Offset: 0x0002FA98
		public unsafe TextMeshProUGUI DealerScoreLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_DealerScoreLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_DealerScoreLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F89 RID: 8073
		// (get) Token: 0x06006916 RID: 26902 RVA: 0x001D788C File Offset: 0x001D5A8C
		// (set) Token: 0x06006917 RID: 26903 RVA: 0x000318B7 File Offset: 0x0002FAB7
		public unsafe TextMeshProUGUI PlayerScoreLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_PlayerScoreLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_PlayerScoreLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F8A RID: 8074
		// (get) Token: 0x06006918 RID: 26904 RVA: 0x001D78BC File Offset: 0x001D5ABC
		// (set) Token: 0x06006919 RID: 26905 RVA: 0x000318D6 File Offset: 0x0002FAD6
		public unsafe Button HitButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_HitButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_HitButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F8B RID: 8075
		// (get) Token: 0x0600691A RID: 26906 RVA: 0x001D78EC File Offset: 0x001D5AEC
		// (set) Token: 0x0600691B RID: 26907 RVA: 0x000318F5 File Offset: 0x0002FAF5
		public unsafe Button StandButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_StandButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_StandButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F8C RID: 8076
		// (get) Token: 0x0600691C RID: 26908 RVA: 0x001D791C File Offset: 0x001D5B1C
		// (set) Token: 0x0600691D RID: 26909 RVA: 0x00031914 File Offset: 0x0002FB14
		public unsafe Animation InputContainerAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_InputContainerAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_InputContainerAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F8D RID: 8077
		// (get) Token: 0x0600691E RID: 26910 RVA: 0x001D794C File Offset: 0x001D5B4C
		// (set) Token: 0x0600691F RID: 26911 RVA: 0x00031933 File Offset: 0x0002FB33
		public unsafe CanvasGroup InputContainerCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_InputContainerCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_InputContainerCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F8E RID: 8078
		// (get) Token: 0x06006920 RID: 26912 RVA: 0x001D797C File Offset: 0x001D5B7C
		// (set) Token: 0x06006921 RID: 26913 RVA: 0x00031952 File Offset: 0x0002FB52
		public unsafe AnimationClip InputContainerFadeIn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_InputContainerFadeIn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_InputContainerFadeIn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F8F RID: 8079
		// (get) Token: 0x06006922 RID: 26914 RVA: 0x001D79AC File Offset: 0x001D5BAC
		// (set) Token: 0x06006923 RID: 26915 RVA: 0x00031971 File Offset: 0x0002FB71
		public unsafe AnimationClip InputContainerFadeOut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_InputContainerFadeOut);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_InputContainerFadeOut), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F90 RID: 8080
		// (get) Token: 0x06006924 RID: 26916 RVA: 0x001D79DC File Offset: 0x001D5BDC
		// (set) Token: 0x06006925 RID: 26917 RVA: 0x00031990 File Offset: 0x0002FB90
		public unsafe RectTransform SelectionIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_SelectionIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_SelectionIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F91 RID: 8081
		// (get) Token: 0x06006926 RID: 26918 RVA: 0x001D7A0C File Offset: 0x001D5C0C
		// (set) Token: 0x06006927 RID: 26919 RVA: 0x000319AF File Offset: 0x0002FBAF
		public unsafe Animation ScoresContainerAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_ScoresContainerAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_ScoresContainerAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F92 RID: 8082
		// (get) Token: 0x06006928 RID: 26920 RVA: 0x001D7A3C File Offset: 0x001D5C3C
		// (set) Token: 0x06006929 RID: 26921 RVA: 0x000319CE File Offset: 0x0002FBCE
		public unsafe CanvasGroup ScoresContainerCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_ScoresContainerCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_ScoresContainerCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F93 RID: 8083
		// (get) Token: 0x0600692A RID: 26922 RVA: 0x001D7A6C File Offset: 0x001D5C6C
		// (set) Token: 0x0600692B RID: 26923 RVA: 0x000319ED File Offset: 0x0002FBED
		public unsafe TextMeshProUGUI PositiveOutcomeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_PositiveOutcomeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_PositiveOutcomeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F94 RID: 8084
		// (get) Token: 0x0600692C RID: 26924 RVA: 0x001D7A9C File Offset: 0x001D5C9C
		// (set) Token: 0x0600692D RID: 26925 RVA: 0x00031A0C File Offset: 0x0002FC0C
		public unsafe TextMeshProUGUI PayoutLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_PayoutLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_PayoutLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F95 RID: 8085
		// (get) Token: 0x0600692E RID: 26926 RVA: 0x001D7ACC File Offset: 0x001D5CCC
		// (set) Token: 0x0600692F RID: 26927 RVA: 0x00031A2B File Offset: 0x0002FC2B
		public unsafe UnityEvent onBust
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_onBust);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_onBust), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F96 RID: 8086
		// (get) Token: 0x06006930 RID: 26928 RVA: 0x001D7AFC File Offset: 0x001D5CFC
		// (set) Token: 0x06006931 RID: 26929 RVA: 0x00031A4A File Offset: 0x0002FC4A
		public unsafe UnityEvent onBlackjack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_onBlackjack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_onBlackjack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F97 RID: 8087
		// (get) Token: 0x06006932 RID: 26930 RVA: 0x001D7B2C File Offset: 0x001D5D2C
		// (set) Token: 0x06006933 RID: 26931 RVA: 0x00031A69 File Offset: 0x0002FC69
		public unsafe UnityEvent onWin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_onWin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_onWin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F98 RID: 8088
		// (get) Token: 0x06006934 RID: 26932 RVA: 0x001D7B5C File Offset: 0x001D5D5C
		// (set) Token: 0x06006935 RID: 26933 RVA: 0x00031A88 File Offset: 0x0002FC88
		public unsafe UnityEvent onLose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_onLose);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_onLose), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F99 RID: 8089
		// (get) Token: 0x06006936 RID: 26934 RVA: 0x001D7B8C File Offset: 0x001D5D8C
		// (set) Token: 0x06006937 RID: 26935 RVA: 0x00031AA7 File Offset: 0x0002FCA7
		public unsafe UnityEvent onPush
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_onPush);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_onPush), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040047EB RID: 18411
		private static readonly IntPtr NativeFieldInfoPtr__CurrentGame_k__BackingField;

		// Token: 0x040047EC RID: 18412
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x040047ED RID: 18413
		private static readonly IntPtr NativeFieldInfoPtr_PlayerDisplay;

		// Token: 0x040047EE RID: 18414
		private static readonly IntPtr NativeFieldInfoPtr_BetContainer;

		// Token: 0x040047EF RID: 18415
		private static readonly IntPtr NativeFieldInfoPtr_BetTitleLabel;

		// Token: 0x040047F0 RID: 18416
		private static readonly IntPtr NativeFieldInfoPtr_BetSlider;

		// Token: 0x040047F1 RID: 18417
		private static readonly IntPtr NativeFieldInfoPtr_BetAmount;

		// Token: 0x040047F2 RID: 18418
		private static readonly IntPtr NativeFieldInfoPtr_ReadyButton;

		// Token: 0x040047F3 RID: 18419
		private static readonly IntPtr NativeFieldInfoPtr_ReadyLabel;

		// Token: 0x040047F4 RID: 18420
		private static readonly IntPtr NativeFieldInfoPtr_WaitingContainer;

		// Token: 0x040047F5 RID: 18421
		private static readonly IntPtr NativeFieldInfoPtr_WaitingLabel;

		// Token: 0x040047F6 RID: 18422
		private static readonly IntPtr NativeFieldInfoPtr_DealerScoreLabel;

		// Token: 0x040047F7 RID: 18423
		private static readonly IntPtr NativeFieldInfoPtr_PlayerScoreLabel;

		// Token: 0x040047F8 RID: 18424
		private static readonly IntPtr NativeFieldInfoPtr_HitButton;

		// Token: 0x040047F9 RID: 18425
		private static readonly IntPtr NativeFieldInfoPtr_StandButton;

		// Token: 0x040047FA RID: 18426
		private static readonly IntPtr NativeFieldInfoPtr_InputContainerAnimation;

		// Token: 0x040047FB RID: 18427
		private static readonly IntPtr NativeFieldInfoPtr_InputContainerCanvasGroup;

		// Token: 0x040047FC RID: 18428
		private static readonly IntPtr NativeFieldInfoPtr_InputContainerFadeIn;

		// Token: 0x040047FD RID: 18429
		private static readonly IntPtr NativeFieldInfoPtr_InputContainerFadeOut;

		// Token: 0x040047FE RID: 18430
		private static readonly IntPtr NativeFieldInfoPtr_SelectionIndicator;

		// Token: 0x040047FF RID: 18431
		private static readonly IntPtr NativeFieldInfoPtr_ScoresContainerAnimation;

		// Token: 0x04004800 RID: 18432
		private static readonly IntPtr NativeFieldInfoPtr_ScoresContainerCanvasGroup;

		// Token: 0x04004801 RID: 18433
		private static readonly IntPtr NativeFieldInfoPtr_PositiveOutcomeLabel;

		// Token: 0x04004802 RID: 18434
		private static readonly IntPtr NativeFieldInfoPtr_PayoutLabel;

		// Token: 0x04004803 RID: 18435
		private static readonly IntPtr NativeFieldInfoPtr_onBust;

		// Token: 0x04004804 RID: 18436
		private static readonly IntPtr NativeFieldInfoPtr_onBlackjack;

		// Token: 0x04004805 RID: 18437
		private static readonly IntPtr NativeFieldInfoPtr_onWin;

		// Token: 0x04004806 RID: 18438
		private static readonly IntPtr NativeFieldInfoPtr_onLose;

		// Token: 0x04004807 RID: 18439
		private static readonly IntPtr NativeFieldInfoPtr_onPush;

		// Token: 0x04004808 RID: 18440
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentGame_Public_get_BlackjackGameController_0;

		// Token: 0x04004809 RID: 18441
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentGame_Private_set_Void_BlackjackGameController_0;

		// Token: 0x0400480A RID: 18442
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400480B RID: 18443
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x0400480C RID: 18444
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_BlackjackGameController_0;

		// Token: 0x0400480D RID: 18445
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x0400480E RID: 18446
		private static readonly IntPtr NativeMethodInfoPtr_BetSliderChanged_Private_Void_Single_0;

		// Token: 0x0400480F RID: 18447
		private static readonly IntPtr NativeMethodInfoPtr_GetBetFromSliderValue_Private_Single_Single_0;

		// Token: 0x04004810 RID: 18448
		private static readonly IntPtr NativeMethodInfoPtr_RefreshDisplayedBet_Private_Void_0;

		// Token: 0x04004811 RID: 18449
		private static readonly IntPtr NativeMethodInfoPtr_RefreshReadyButton_Private_Void_0;

		// Token: 0x04004812 RID: 18450
		private static readonly IntPtr NativeMethodInfoPtr_LocalPlayerReadyForInput_Private_Void_0;

		// Token: 0x04004813 RID: 18451
		private static readonly IntPtr NativeMethodInfoPtr_ShowScores_Private_Void_0;

		// Token: 0x04004814 RID: 18452
		private static readonly IntPtr NativeMethodInfoPtr_HideScores_Private_Void_0;

		// Token: 0x04004815 RID: 18453
		private static readonly IntPtr NativeMethodInfoPtr_HitClicked_Private_Void_0;

		// Token: 0x04004816 RID: 18454
		private static readonly IntPtr NativeMethodInfoPtr_StandClicked_Private_Void_0;

		// Token: 0x04004817 RID: 18455
		private static readonly IntPtr NativeMethodInfoPtr_LocalPlayerExitRound_Private_Void_0;

		// Token: 0x04004818 RID: 18456
		private static readonly IntPtr NativeMethodInfoPtr_ReadyButtonClicked_Private_Void_0;

		// Token: 0x04004819 RID: 18457
		private static readonly IntPtr NativeMethodInfoPtr_OnLocalPlayerBust_Private_Void_0;

		// Token: 0x0400481A RID: 18458
		private static readonly IntPtr NativeMethodInfoPtr_OnLocalPlayerRoundCompleted_Private_Void_EPayoutType_0;

		// Token: 0x0400481B RID: 18459
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
