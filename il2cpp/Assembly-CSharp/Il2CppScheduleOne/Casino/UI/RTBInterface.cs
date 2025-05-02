using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Casino.UI
{
	// Token: 0x020004AC RID: 1196
	public class RTBInterface : Singleton<RTBInterface>
	{
		// Token: 0x06006945 RID: 26949 RVA: 0x001D7E38 File Offset: 0x001D6038
		// Note: this type is marked as 'beforefieldinit'.
		static RTBInterface()
		{
			Il2CppClassPointerStore<RTBInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino.UI", "RTBInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr);
			RTBInterface.NativeFieldInfoPtr__CurrentGame_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "<CurrentGame>k__BackingField");
			RTBInterface.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "Canvas");
			RTBInterface.NativeFieldInfoPtr_PlayerDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "PlayerDisplay");
			RTBInterface.NativeFieldInfoPtr_StatusLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "StatusLabel");
			RTBInterface.NativeFieldInfoPtr_BetContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "BetContainer");
			RTBInterface.NativeFieldInfoPtr_BetTitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "BetTitleLabel");
			RTBInterface.NativeFieldInfoPtr_BetSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "BetSlider");
			RTBInterface.NativeFieldInfoPtr_BetAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "BetAmount");
			RTBInterface.NativeFieldInfoPtr_ReadyButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "ReadyButton");
			RTBInterface.NativeFieldInfoPtr_ReadyLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "ReadyLabel");
			RTBInterface.NativeFieldInfoPtr_WinningsMultiplierLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "WinningsMultiplierLabel");
			RTBInterface.NativeFieldInfoPtr_QuestionContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "QuestionContainer");
			RTBInterface.NativeFieldInfoPtr_QuestionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "QuestionLabel");
			RTBInterface.NativeFieldInfoPtr_TimerSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "TimerSlider");
			RTBInterface.NativeFieldInfoPtr_AnswerButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "AnswerButtons");
			RTBInterface.NativeFieldInfoPtr_AnswerLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "AnswerLabels");
			RTBInterface.NativeFieldInfoPtr_ForfeitButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "ForfeitButton");
			RTBInterface.NativeFieldInfoPtr_ForfeitLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "ForfeitLabel");
			RTBInterface.NativeFieldInfoPtr_QuestionContainerAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "QuestionContainerAnimation");
			RTBInterface.NativeFieldInfoPtr_QuestionContainerFadeIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "QuestionContainerFadeIn");
			RTBInterface.NativeFieldInfoPtr_QuestionContainerFadeOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "QuestionContainerFadeOut");
			RTBInterface.NativeFieldInfoPtr_QuestionCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "QuestionCanvasGroup");
			RTBInterface.NativeFieldInfoPtr_SelectionIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "SelectionIndicator");
			RTBInterface.NativeFieldInfoPtr_onCorrect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "onCorrect");
			RTBInterface.NativeFieldInfoPtr_onFinalCorrect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "onFinalCorrect");
			RTBInterface.NativeFieldInfoPtr_onIncorrect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "onIncorrect");
			RTBInterface.NativeMethodInfoPtr_get_CurrentGame_Public_get_RTBGameController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676677);
			RTBInterface.NativeMethodInfoPtr_set_CurrentGame_Private_set_Void_RTBGameController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676678);
			RTBInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676679);
			RTBInterface.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676680);
			RTBInterface.NativeMethodInfoPtr_GetStatusText_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676681);
			RTBInterface.NativeMethodInfoPtr_Open_Public_Void_RTBGameController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676682);
			RTBInterface.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676683);
			RTBInterface.NativeMethodInfoPtr_BetSliderChanged_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676684);
			RTBInterface.NativeMethodInfoPtr_GetBetFromSliderValue_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676685);
			RTBInterface.NativeMethodInfoPtr_RefreshDisplayedBet_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676686);
			RTBInterface.NativeMethodInfoPtr_RefreshReadyButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676687);
			RTBInterface.NativeMethodInfoPtr_QuestionReady_Private_Void_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676688);
			RTBInterface.NativeMethodInfoPtr_AnswerButtonClicked_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676689);
			RTBInterface.NativeMethodInfoPtr_ForfeitClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676690);
			RTBInterface.NativeMethodInfoPtr_QuestionDone_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676691);
			RTBInterface.NativeMethodInfoPtr_LocalPlayerExitRound_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676692);
			RTBInterface.NativeMethodInfoPtr_Correct_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676693);
			RTBInterface.NativeMethodInfoPtr_Incorrect_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676694);
			RTBInterface.NativeMethodInfoPtr_ReadyButtonClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676695);
			RTBInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676696);
			RTBInterface.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676697);
		}

		// Token: 0x17001FB8 RID: 8120
		// (get) Token: 0x06006946 RID: 26950 RVA: 0x001D8214 File Offset: 0x001D6414
		// (set) Token: 0x06006947 RID: 26951 RVA: 0x001D8254 File Offset: 0x001D6454
		public unsafe RTBGameController CurrentGame
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19637, RefRangeEnd = 19640, XrefRangeStart = 19637, XrefRangeEnd = 19640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_get_CurrentGame_Public_get_RTBGameController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTBGameController>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19641, RefRangeEnd = 19644, XrefRangeStart = 19641, XrefRangeEnd = 19644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_set_CurrentGame_Private_set_Void_RTBGameController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006948 RID: 26952 RVA: 0x001D8298 File Offset: 0x001D6498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212719, XrefRangeEnd = 212761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RTBInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006949 RID: 26953 RVA: 0x001D82D4 File Offset: 0x001D64D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212761, XrefRangeEnd = 212781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600694A RID: 26954 RVA: 0x001D8308 File Offset: 0x001D6508
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212791, RefRangeEnd = 212792, XrefRangeStart = 212781, XrefRangeEnd = 212791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetStatusText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_GetStatusText_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600694B RID: 26955 RVA: 0x001D8340 File Offset: 0x001D6540
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212881, RefRangeEnd = 212882, XrefRangeStart = 212792, XrefRangeEnd = 212881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(RTBGameController game)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(game);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_Open_Public_Void_RTBGameController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600694C RID: 26956 RVA: 0x001D8384 File Offset: 0x001D6584
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212971, RefRangeEnd = 212972, XrefRangeStart = 212882, XrefRangeEnd = 212971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600694D RID: 26957 RVA: 0x001D83B8 File Offset: 0x001D65B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212972, XrefRangeEnd = 212976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BetSliderChanged(float newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_BetSliderChanged_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600694E RID: 26958 RVA: 0x001D83F8 File Offset: 0x001D65F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212976, XrefRangeEnd = 212978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetBetFromSliderValue(float sliderVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sliderVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_GetBetFromSliderValue_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600694F RID: 26959 RVA: 0x001D8444 File Offset: 0x001D6644
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 212983, RefRangeEnd = 212986, XrefRangeStart = 212978, XrefRangeEnd = 212983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshDisplayedBet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_RefreshDisplayedBet_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006950 RID: 26960 RVA: 0x001D8478 File Offset: 0x001D6678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212986, XrefRangeEnd = 213004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshReadyButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_RefreshReadyButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006951 RID: 26961 RVA: 0x001D84AC File Offset: 0x001D66AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213004, XrefRangeEnd = 213026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QuestionReady(string question, Il2CppStringArray answers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(question);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(answers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_QuestionReady_Private_Void_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006952 RID: 26962 RVA: 0x001D8500 File Offset: 0x001D6700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213026, XrefRangeEnd = 213035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AnswerButtonClicked(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_AnswerButtonClicked_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006953 RID: 26963 RVA: 0x001D8540 File Offset: 0x001D6740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213035, XrefRangeEnd = 213046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForfeitClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_ForfeitClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006954 RID: 26964 RVA: 0x001D8574 File Offset: 0x001D6774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213046, XrefRangeEnd = 213050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QuestionDone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_QuestionDone_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006955 RID: 26965 RVA: 0x001D85A8 File Offset: 0x001D67A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213050, XrefRangeEnd = 213054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LocalPlayerExitRound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_LocalPlayerExitRound_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006956 RID: 26966 RVA: 0x001D85DC File Offset: 0x001D67DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213054, XrefRangeEnd = 213060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Correct()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_Correct_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006957 RID: 26967 RVA: 0x001D8610 File Offset: 0x001D6810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213060, XrefRangeEnd = 213061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Incorrect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_Incorrect_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006958 RID: 26968 RVA: 0x001D8644 File Offset: 0x001D6844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213061, XrefRangeEnd = 213072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadyButtonClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_ReadyButtonClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006959 RID: 26969 RVA: 0x001D8678 File Offset: 0x001D6878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213072, XrefRangeEnd = 213075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTBInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600695A RID: 26970 RVA: 0x001D86B4 File Offset: 0x001D68B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213075, XrefRangeEnd = 213080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600695B RID: 26971 RVA: 0x00031B2C File Offset: 0x0002FD2C
		public RTBInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F9E RID: 8094
		// (get) Token: 0x0600695C RID: 26972 RVA: 0x001D86F4 File Offset: 0x001D68F4
		// (set) Token: 0x0600695D RID: 26973 RVA: 0x00031B35 File Offset: 0x0002FD35
		public unsafe RTBGameController _CurrentGame_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr__CurrentGame_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTBGameController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr__CurrentGame_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F9F RID: 8095
		// (get) Token: 0x0600695E RID: 26974 RVA: 0x001D8724 File Offset: 0x001D6924
		// (set) Token: 0x0600695F RID: 26975 RVA: 0x00031B54 File Offset: 0x0002FD54
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FA0 RID: 8096
		// (get) Token: 0x06006960 RID: 26976 RVA: 0x001D8754 File Offset: 0x001D6954
		// (set) Token: 0x06006961 RID: 26977 RVA: 0x00031B73 File Offset: 0x0002FD73
		public unsafe CasinoGamePlayerDisplay PlayerDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_PlayerDisplay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CasinoGamePlayerDisplay>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_PlayerDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FA1 RID: 8097
		// (get) Token: 0x06006962 RID: 26978 RVA: 0x001D8784 File Offset: 0x001D6984
		// (set) Token: 0x06006963 RID: 26979 RVA: 0x00031B92 File Offset: 0x0002FD92
		public unsafe TextMeshProUGUI StatusLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_StatusLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_StatusLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FA2 RID: 8098
		// (get) Token: 0x06006964 RID: 26980 RVA: 0x001D87B4 File Offset: 0x001D69B4
		// (set) Token: 0x06006965 RID: 26981 RVA: 0x00031BB1 File Offset: 0x0002FDB1
		public unsafe RectTransform BetContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_BetContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_BetContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FA3 RID: 8099
		// (get) Token: 0x06006966 RID: 26982 RVA: 0x001D87E4 File Offset: 0x001D69E4
		// (set) Token: 0x06006967 RID: 26983 RVA: 0x00031BD0 File Offset: 0x0002FDD0
		public unsafe TextMeshProUGUI BetTitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_BetTitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_BetTitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FA4 RID: 8100
		// (get) Token: 0x06006968 RID: 26984 RVA: 0x001D8814 File Offset: 0x001D6A14
		// (set) Token: 0x06006969 RID: 26985 RVA: 0x00031BEF File Offset: 0x0002FDEF
		public unsafe Slider BetSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_BetSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_BetSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FA5 RID: 8101
		// (get) Token: 0x0600696A RID: 26986 RVA: 0x001D8844 File Offset: 0x001D6A44
		// (set) Token: 0x0600696B RID: 26987 RVA: 0x00031C0E File Offset: 0x0002FE0E
		public unsafe TextMeshProUGUI BetAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_BetAmount);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_BetAmount), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FA6 RID: 8102
		// (get) Token: 0x0600696C RID: 26988 RVA: 0x001D8874 File Offset: 0x001D6A74
		// (set) Token: 0x0600696D RID: 26989 RVA: 0x00031C2D File Offset: 0x0002FE2D
		public unsafe Button ReadyButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_ReadyButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_ReadyButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FA7 RID: 8103
		// (get) Token: 0x0600696E RID: 26990 RVA: 0x001D88A4 File Offset: 0x001D6AA4
		// (set) Token: 0x0600696F RID: 26991 RVA: 0x00031C4C File Offset: 0x0002FE4C
		public unsafe TextMeshProUGUI ReadyLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_ReadyLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_ReadyLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FA8 RID: 8104
		// (get) Token: 0x06006970 RID: 26992 RVA: 0x001D88D4 File Offset: 0x001D6AD4
		// (set) Token: 0x06006971 RID: 26993 RVA: 0x00031C6B File Offset: 0x0002FE6B
		public unsafe TextMeshProUGUI WinningsMultiplierLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_WinningsMultiplierLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_WinningsMultiplierLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FA9 RID: 8105
		// (get) Token: 0x06006972 RID: 26994 RVA: 0x001D8904 File Offset: 0x001D6B04
		// (set) Token: 0x06006973 RID: 26995 RVA: 0x00031C8A File Offset: 0x0002FE8A
		public unsafe RectTransform QuestionContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_QuestionContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_QuestionContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FAA RID: 8106
		// (get) Token: 0x06006974 RID: 26996 RVA: 0x001D8934 File Offset: 0x001D6B34
		// (set) Token: 0x06006975 RID: 26997 RVA: 0x00031CA9 File Offset: 0x0002FEA9
		public unsafe TextMeshProUGUI QuestionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_QuestionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_QuestionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FAB RID: 8107
		// (get) Token: 0x06006976 RID: 26998 RVA: 0x001D8964 File Offset: 0x001D6B64
		// (set) Token: 0x06006977 RID: 26999 RVA: 0x00031CC8 File Offset: 0x0002FEC8
		public unsafe Slider TimerSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_TimerSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_TimerSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FAC RID: 8108
		// (get) Token: 0x06006978 RID: 27000 RVA: 0x001D8994 File Offset: 0x001D6B94
		// (set) Token: 0x06006979 RID: 27001 RVA: 0x00031CE7 File Offset: 0x0002FEE7
		public unsafe Il2CppReferenceArray<Button> AnswerButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_AnswerButtons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Button>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_AnswerButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FAD RID: 8109
		// (get) Token: 0x0600697A RID: 27002 RVA: 0x001D89C4 File Offset: 0x001D6BC4
		// (set) Token: 0x0600697B RID: 27003 RVA: 0x00031D06 File Offset: 0x0002FF06
		public unsafe Il2CppReferenceArray<TextMeshProUGUI> AnswerLabels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_AnswerLabels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextMeshProUGUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_AnswerLabels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FAE RID: 8110
		// (get) Token: 0x0600697C RID: 27004 RVA: 0x001D89F4 File Offset: 0x001D6BF4
		// (set) Token: 0x0600697D RID: 27005 RVA: 0x00031D25 File Offset: 0x0002FF25
		public unsafe Button ForfeitButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_ForfeitButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_ForfeitButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FAF RID: 8111
		// (get) Token: 0x0600697E RID: 27006 RVA: 0x001D8A24 File Offset: 0x001D6C24
		// (set) Token: 0x0600697F RID: 27007 RVA: 0x00031D44 File Offset: 0x0002FF44
		public unsafe TextMeshProUGUI ForfeitLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_ForfeitLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_ForfeitLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FB0 RID: 8112
		// (get) Token: 0x06006980 RID: 27008 RVA: 0x001D8A54 File Offset: 0x001D6C54
		// (set) Token: 0x06006981 RID: 27009 RVA: 0x00031D63 File Offset: 0x0002FF63
		public unsafe Animation QuestionContainerAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_QuestionContainerAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_QuestionContainerAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FB1 RID: 8113
		// (get) Token: 0x06006982 RID: 27010 RVA: 0x001D8A84 File Offset: 0x001D6C84
		// (set) Token: 0x06006983 RID: 27011 RVA: 0x00031D82 File Offset: 0x0002FF82
		public unsafe AnimationClip QuestionContainerFadeIn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_QuestionContainerFadeIn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_QuestionContainerFadeIn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FB2 RID: 8114
		// (get) Token: 0x06006984 RID: 27012 RVA: 0x001D8AB4 File Offset: 0x001D6CB4
		// (set) Token: 0x06006985 RID: 27013 RVA: 0x00031DA1 File Offset: 0x0002FFA1
		public unsafe AnimationClip QuestionContainerFadeOut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_QuestionContainerFadeOut);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_QuestionContainerFadeOut), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FB3 RID: 8115
		// (get) Token: 0x06006986 RID: 27014 RVA: 0x001D8AE4 File Offset: 0x001D6CE4
		// (set) Token: 0x06006987 RID: 27015 RVA: 0x00031DC0 File Offset: 0x0002FFC0
		public unsafe CanvasGroup QuestionCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_QuestionCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_QuestionCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FB4 RID: 8116
		// (get) Token: 0x06006988 RID: 27016 RVA: 0x001D8B14 File Offset: 0x001D6D14
		// (set) Token: 0x06006989 RID: 27017 RVA: 0x00031DDF File Offset: 0x0002FFDF
		public unsafe RectTransform SelectionIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_SelectionIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_SelectionIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FB5 RID: 8117
		// (get) Token: 0x0600698A RID: 27018 RVA: 0x001D8B44 File Offset: 0x001D6D44
		// (set) Token: 0x0600698B RID: 27019 RVA: 0x00031DFE File Offset: 0x0002FFFE
		public unsafe UnityEvent onCorrect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_onCorrect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_onCorrect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FB6 RID: 8118
		// (get) Token: 0x0600698C RID: 27020 RVA: 0x001D8B74 File Offset: 0x001D6D74
		// (set) Token: 0x0600698D RID: 27021 RVA: 0x00031E1D File Offset: 0x0003001D
		public unsafe UnityEvent onFinalCorrect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_onFinalCorrect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_onFinalCorrect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FB7 RID: 8119
		// (get) Token: 0x0600698E RID: 27022 RVA: 0x001D8BA4 File Offset: 0x001D6DA4
		// (set) Token: 0x0600698F RID: 27023 RVA: 0x00031E3C File Offset: 0x0003003C
		public unsafe UnityEvent onIncorrect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_onIncorrect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_onIncorrect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004824 RID: 18468
		private static readonly IntPtr NativeFieldInfoPtr__CurrentGame_k__BackingField;

		// Token: 0x04004825 RID: 18469
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04004826 RID: 18470
		private static readonly IntPtr NativeFieldInfoPtr_PlayerDisplay;

		// Token: 0x04004827 RID: 18471
		private static readonly IntPtr NativeFieldInfoPtr_StatusLabel;

		// Token: 0x04004828 RID: 18472
		private static readonly IntPtr NativeFieldInfoPtr_BetContainer;

		// Token: 0x04004829 RID: 18473
		private static readonly IntPtr NativeFieldInfoPtr_BetTitleLabel;

		// Token: 0x0400482A RID: 18474
		private static readonly IntPtr NativeFieldInfoPtr_BetSlider;

		// Token: 0x0400482B RID: 18475
		private static readonly IntPtr NativeFieldInfoPtr_BetAmount;

		// Token: 0x0400482C RID: 18476
		private static readonly IntPtr NativeFieldInfoPtr_ReadyButton;

		// Token: 0x0400482D RID: 18477
		private static readonly IntPtr NativeFieldInfoPtr_ReadyLabel;

		// Token: 0x0400482E RID: 18478
		private static readonly IntPtr NativeFieldInfoPtr_WinningsMultiplierLabel;

		// Token: 0x0400482F RID: 18479
		private static readonly IntPtr NativeFieldInfoPtr_QuestionContainer;

		// Token: 0x04004830 RID: 18480
		private static readonly IntPtr NativeFieldInfoPtr_QuestionLabel;

		// Token: 0x04004831 RID: 18481
		private static readonly IntPtr NativeFieldInfoPtr_TimerSlider;

		// Token: 0x04004832 RID: 18482
		private static readonly IntPtr NativeFieldInfoPtr_AnswerButtons;

		// Token: 0x04004833 RID: 18483
		private static readonly IntPtr NativeFieldInfoPtr_AnswerLabels;

		// Token: 0x04004834 RID: 18484
		private static readonly IntPtr NativeFieldInfoPtr_ForfeitButton;

		// Token: 0x04004835 RID: 18485
		private static readonly IntPtr NativeFieldInfoPtr_ForfeitLabel;

		// Token: 0x04004836 RID: 18486
		private static readonly IntPtr NativeFieldInfoPtr_QuestionContainerAnimation;

		// Token: 0x04004837 RID: 18487
		private static readonly IntPtr NativeFieldInfoPtr_QuestionContainerFadeIn;

		// Token: 0x04004838 RID: 18488
		private static readonly IntPtr NativeFieldInfoPtr_QuestionContainerFadeOut;

		// Token: 0x04004839 RID: 18489
		private static readonly IntPtr NativeFieldInfoPtr_QuestionCanvasGroup;

		// Token: 0x0400483A RID: 18490
		private static readonly IntPtr NativeFieldInfoPtr_SelectionIndicator;

		// Token: 0x0400483B RID: 18491
		private static readonly IntPtr NativeFieldInfoPtr_onCorrect;

		// Token: 0x0400483C RID: 18492
		private static readonly IntPtr NativeFieldInfoPtr_onFinalCorrect;

		// Token: 0x0400483D RID: 18493
		private static readonly IntPtr NativeFieldInfoPtr_onIncorrect;

		// Token: 0x0400483E RID: 18494
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentGame_Public_get_RTBGameController_0;

		// Token: 0x0400483F RID: 18495
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentGame_Private_set_Void_RTBGameController_0;

		// Token: 0x04004840 RID: 18496
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04004841 RID: 18497
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04004842 RID: 18498
		private static readonly IntPtr NativeMethodInfoPtr_GetStatusText_Private_String_0;

		// Token: 0x04004843 RID: 18499
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_RTBGameController_0;

		// Token: 0x04004844 RID: 18500
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04004845 RID: 18501
		private static readonly IntPtr NativeMethodInfoPtr_BetSliderChanged_Private_Void_Single_0;

		// Token: 0x04004846 RID: 18502
		private static readonly IntPtr NativeMethodInfoPtr_GetBetFromSliderValue_Private_Single_Single_0;

		// Token: 0x04004847 RID: 18503
		private static readonly IntPtr NativeMethodInfoPtr_RefreshDisplayedBet_Private_Void_0;

		// Token: 0x04004848 RID: 18504
		private static readonly IntPtr NativeMethodInfoPtr_RefreshReadyButton_Private_Void_0;

		// Token: 0x04004849 RID: 18505
		private static readonly IntPtr NativeMethodInfoPtr_QuestionReady_Private_Void_String_Il2CppStringArray_0;

		// Token: 0x0400484A RID: 18506
		private static readonly IntPtr NativeMethodInfoPtr_AnswerButtonClicked_Private_Void_Int32_0;

		// Token: 0x0400484B RID: 18507
		private static readonly IntPtr NativeMethodInfoPtr_ForfeitClicked_Private_Void_0;

		// Token: 0x0400484C RID: 18508
		private static readonly IntPtr NativeMethodInfoPtr_QuestionDone_Private_Void_0;

		// Token: 0x0400484D RID: 18509
		private static readonly IntPtr NativeMethodInfoPtr_LocalPlayerExitRound_Private_Void_0;

		// Token: 0x0400484E RID: 18510
		private static readonly IntPtr NativeMethodInfoPtr_Correct_Private_Void_0;

		// Token: 0x0400484F RID: 18511
		private static readonly IntPtr NativeMethodInfoPtr_Incorrect_Private_Void_0;

		// Token: 0x04004850 RID: 18512
		private static readonly IntPtr NativeMethodInfoPtr_ReadyButtonClicked_Private_Void_0;

		// Token: 0x04004851 RID: 18513
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004852 RID: 18514
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000A50 RID: 2640
		[ObfuscatedName("ScheduleOne.Casino.UI.RTBInterface+<<QuestionReady>g__Routine|38_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D03D RID: 53309 RVA: 0x0031F724 File Offset: 0x0031D924
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique()
			{
				Il2CppClassPointerStore<RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "<<QuestionReady>g__Routine|38_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique>.NativeClassPtr);
				RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique>.NativeClassPtr, "<>1__state");
				RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique>.NativeClassPtr, "<>2__current");
				RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique>.NativeClassPtr, "<>4__this");
				RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique>.NativeClassPtr, 100676698);
				RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique>.NativeClassPtr, 100676699);
				RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique>.NativeClassPtr, 100676700);
				RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique>.NativeClassPtr, 100676701);
				RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique>.NativeClassPtr, 100676702);
				RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique>.NativeClassPtr, 100676703);
			}

			// Token: 0x0600D03E RID: 53310 RVA: 0x0031F804 File Offset: 0x0031DA04
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D03F RID: 53311 RVA: 0x0031F84C File Offset: 0x0031DA4C
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D040 RID: 53312 RVA: 0x0031F880 File Offset: 0x0031DA80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212696, XrefRangeEnd = 212705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170040B0 RID: 16560
			// (get) Token: 0x0600D041 RID: 53313 RVA: 0x0031F8BC File Offset: 0x0031DABC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D042 RID: 53314 RVA: 0x0031F8FC File Offset: 0x0031DAFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212705, XrefRangeEnd = 212710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170040B1 RID: 16561
			// (get) Token: 0x0600D043 RID: 53315 RVA: 0x0031F930 File Offset: 0x0031DB30
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D044 RID: 53316 RVA: 0x00065570 File Offset: 0x00063770
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040AD RID: 16557
			// (get) Token: 0x0600D045 RID: 53317 RVA: 0x0031F970 File Offset: 0x0031DB70
			// (set) Token: 0x0600D046 RID: 53318 RVA: 0x00065579 File Offset: 0x00063779
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170040AE RID: 16558
			// (get) Token: 0x0600D047 RID: 53319 RVA: 0x0031F998 File Offset: 0x0031DB98
			// (set) Token: 0x0600D048 RID: 53320 RVA: 0x00065594 File Offset: 0x00063794
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040AF RID: 16559
			// (get) Token: 0x0600D049 RID: 53321 RVA: 0x0031F9C8 File Offset: 0x0031DBC8
			// (set) Token: 0x0600D04A RID: 53322 RVA: 0x000655B3 File Offset: 0x000637B3
			public unsafe RTBInterface __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTBInterface>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C8B RID: 35979
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008C8C RID: 35980
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008C8D RID: 35981
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008C8E RID: 35982
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008C8F RID: 35983
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008C90 RID: 35984
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008C91 RID: 35985
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008C92 RID: 35986
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008C93 RID: 35987
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000A51 RID: 2641
		[ObfuscatedName("ScheduleOne.Casino.UI.RTBInterface+<>c__DisplayClass29_0")]
		public sealed class __c__DisplayClass29_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D04B RID: 53323 RVA: 0x0031F9F8 File Offset: 0x0031DBF8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_0()
			{
				Il2CppClassPointerStore<RTBInterface.__c__DisplayClass29_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "<>c__DisplayClass29_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTBInterface.__c__DisplayClass29_0>.NativeClassPtr);
				RTBInterface.__c__DisplayClass29_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface.__c__DisplayClass29_0>.NativeClassPtr, "index");
				RTBInterface.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface.__c__DisplayClass29_0>.NativeClassPtr, "<>4__this");
				RTBInterface.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface.__c__DisplayClass29_0>.NativeClassPtr, 100676704);
				RTBInterface.__c__DisplayClass29_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface.__c__DisplayClass29_0>.NativeClassPtr, 100676705);
			}

			// Token: 0x0600D04C RID: 53324 RVA: 0x0031FA74 File Offset: 0x0031DC74
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTBInterface.__c__DisplayClass29_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D04D RID: 53325 RVA: 0x0031FAB0 File Offset: 0x0031DCB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212710, XrefRangeEnd = 212719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.__c__DisplayClass29_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D04E RID: 53326 RVA: 0x000655D2 File Offset: 0x000637D2
			public __c__DisplayClass29_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040B2 RID: 16562
			// (get) Token: 0x0600D04F RID: 53327 RVA: 0x0031FAE4 File Offset: 0x0031DCE4
			// (set) Token: 0x0600D050 RID: 53328 RVA: 0x000655DB File Offset: 0x000637DB
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.__c__DisplayClass29_0.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.__c__DisplayClass29_0.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x170040B3 RID: 16563
			// (get) Token: 0x0600D051 RID: 53329 RVA: 0x0031FB0C File Offset: 0x0031DD0C
			// (set) Token: 0x0600D052 RID: 53330 RVA: 0x000655F6 File Offset: 0x000637F6
			public unsafe RTBInterface __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTBInterface>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C94 RID: 35988
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04008C95 RID: 35989
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008C96 RID: 35990
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C97 RID: 35991
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__0_Internal_Void_0;
		}
	}
}
