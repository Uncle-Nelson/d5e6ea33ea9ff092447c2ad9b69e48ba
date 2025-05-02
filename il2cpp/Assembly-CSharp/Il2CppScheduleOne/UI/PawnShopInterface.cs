using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.NPCs;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000650 RID: 1616
	public class PawnShopInterface : Singleton<PawnShopInterface>
	{
		// Token: 0x06008F7C RID: 36732 RVA: 0x002538B8 File Offset: 0x00251AB8
		// Note: this type is marked as 'beforefieldinit'.
		static PawnShopInterface()
		{
			Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "PawnShopInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr);
			PawnShopInterface.NativeFieldInfoPtr_PAYMENT_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "PAYMENT_MIN");
			PawnShopInterface.NativeFieldInfoPtr_PAYMENT_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "PAYMENT_MAX");
			PawnShopInterface.NativeFieldInfoPtr_THINK_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "THINK_TIME");
			PawnShopInterface.NativeFieldInfoPtr_MIN_VALUE_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "MIN_VALUE_MULTIPLIER");
			PawnShopInterface.NativeFieldInfoPtr_MAX_VALUE_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "MAX_VALUE_MULTIPLIER");
			PawnShopInterface.NativeFieldInfoPtr_PAWN_SLOT_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "PAWN_SLOT_COUNT");
			PawnShopInterface.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "<IsOpen>k__BackingField");
			PawnShopInterface.NativeFieldInfoPtr_CurrentState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "CurrentState");
			PawnShopInterface.NativeFieldInfoPtr_PlayerResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "PlayerResponse");
			PawnShopInterface.NativeFieldInfoPtr_CurrentNegotiationRound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "CurrentNegotiationRound");
			PawnShopInterface.NativeFieldInfoPtr_InitialShopOffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "InitialShopOffer");
			PawnShopInterface.NativeFieldInfoPtr_LastShopOffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "LastShopOffer");
			PawnShopInterface.NativeFieldInfoPtr_LastRefusedAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "LastRefusedAmount");
			PawnShopInterface.NativeFieldInfoPtr_PawnShopNPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "PawnShopNPC");
			PawnShopInterface.NativeFieldInfoPtr__SelectedPayment_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "<SelectedPayment>k__BackingField");
			PawnShopInterface.NativeFieldInfoPtr__NPCAnger_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "<NPCAnger>k__BackingField");
			PawnShopInterface.NativeFieldInfoPtr_RandomCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "RandomCurve");
			PawnShopInterface.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "Canvas");
			PawnShopInterface.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "Container");
			PawnShopInterface.NativeFieldInfoPtr_Slots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "Slots");
			PawnShopInterface.NativeFieldInfoPtr_ValueRangeLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "ValueRangeLabels");
			PawnShopInterface.NativeFieldInfoPtr_TotalValueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "TotalValueLabel");
			PawnShopInterface.NativeFieldInfoPtr_StartButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "StartButton");
			PawnShopInterface.NativeFieldInfoPtr_Step1Animation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "Step1Animation");
			PawnShopInterface.NativeFieldInfoPtr_Step1CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "Step1CanvasGroup");
			PawnShopInterface.NativeFieldInfoPtr_Step2Animation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "Step2Animation");
			PawnShopInterface.NativeFieldInfoPtr_Step2CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "Step2CanvasGroup");
			PawnShopInterface.NativeFieldInfoPtr_FadeInAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "FadeInAnim");
			PawnShopInterface.NativeFieldInfoPtr_FadeOutAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "FadeOutAnim");
			PawnShopInterface.NativeFieldInfoPtr_OfferInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "OfferInputField");
			PawnShopInterface.NativeFieldInfoPtr_AngerSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "AngerSlider");
			PawnShopInterface.NativeFieldInfoPtr_AcceptCounterButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "AcceptCounterButtonLabel");
			PawnShopInterface.NativeFieldInfoPtr_OfferLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "OfferLines");
			PawnShopInterface.NativeFieldInfoPtr_ThinkLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "ThinkLines");
			PawnShopInterface.NativeFieldInfoPtr_AcceptLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "AcceptLines");
			PawnShopInterface.NativeFieldInfoPtr_CounterLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "CounterLines");
			PawnShopInterface.NativeFieldInfoPtr_RefusalLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "RefusalLines");
			PawnShopInterface.NativeFieldInfoPtr_DealFinalizedLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "DealFinalizedLines");
			PawnShopInterface.NativeFieldInfoPtr_AngeredLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "AngeredLines");
			PawnShopInterface.NativeFieldInfoPtr_CrashOutLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "CrashOutLines");
			PawnShopInterface.NativeFieldInfoPtr_PawnSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "PawnSlots");
			PawnShopInterface.NativeFieldInfoPtr_routine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "routine");
			PawnShopInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681086);
			PawnShopInterface.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681087);
			PawnShopInterface.NativeMethodInfoPtr_get_SelectedPayment_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681088);
			PawnShopInterface.NativeMethodInfoPtr_set_SelectedPayment_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681089);
			PawnShopInterface.NativeMethodInfoPtr_get_NPCAnger_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681090);
			PawnShopInterface.NativeMethodInfoPtr_set_NPCAnger_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681091);
			PawnShopInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681092);
			PawnShopInterface.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681093);
			PawnShopInterface.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681094);
			PawnShopInterface.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681095);
			PawnShopInterface.NativeMethodInfoPtr_Close_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681096);
			PawnShopInterface.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681097);
			PawnShopInterface.NativeMethodInfoPtr_OnMinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681098);
			PawnShopInterface.NativeMethodInfoPtr_OnDayPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681099);
			PawnShopInterface.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681100);
			PawnShopInterface.NativeMethodInfoPtr_GetPawnItems_Private_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681101);
			PawnShopInterface.NativeMethodInfoPtr_PawnSlotChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681102);
			PawnShopInterface.NativeMethodInfoPtr_UpdateValueRangeLabels_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681103);
			PawnShopInterface.NativeMethodInfoPtr_StartButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681104);
			PawnShopInterface.NativeMethodInfoPtr_StartNegotiation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681105);
			PawnShopInterface.NativeMethodInfoPtr_PlayShopResponse_Private_Void_EShopResponse_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681106);
			PawnShopInterface.NativeMethodInfoPtr_EvaluateCounter_Private_EShopResponse_Single_Single_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681107);
			PawnShopInterface.NativeMethodInfoPtr_EndNegotiation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681108);
			PawnShopInterface.NativeMethodInfoPtr_PaymentSubmitted_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681109);
			PawnShopInterface.NativeMethodInfoPtr_ChangePayment_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681110);
			PawnShopInterface.NativeMethodInfoPtr_SetSelectedPayment_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681111);
			PawnShopInterface.NativeMethodInfoPtr_SetPlayerResponse_Public_Void_EPlayerResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681112);
			PawnShopInterface.NativeMethodInfoPtr_AcceptOrCounter_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681113);
			PawnShopInterface.NativeMethodInfoPtr_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681114);
			PawnShopInterface.NativeMethodInfoPtr_ChangeAnger_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681115);
			PawnShopInterface.NativeMethodInfoPtr_SetAngeredToday_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681116);
			PawnShopInterface.NativeMethodInfoPtr_Think_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681117);
			PawnShopInterface.NativeMethodInfoPtr_SetOffer_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681118);
			PawnShopInterface.NativeMethodInfoPtr_FinalizeDeal_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681119);
			PawnShopInterface.NativeMethodInfoPtr_GetTotalValue_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681120);
			PawnShopInterface.NativeMethodInfoPtr_RoundOffer_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681121);
			PawnShopInterface.NativeMethodInfoPtr_GetItemValue_Private_Single_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681122);
			PawnShopInterface.NativeMethodInfoPtr_ResetUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681123);
			PawnShopInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681124);
			PawnShopInterface.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681125);
			PawnShopInterface.NativeMethodInfoPtr__StartNegotiation_b__67_1_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681126);
			PawnShopInterface.NativeMethodInfoPtr__StartNegotiation_b__67_2_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681127);
		}

		// Token: 0x17002C0E RID: 11278
		// (get) Token: 0x06008F7D RID: 36733 RVA: 0x00253F78 File Offset: 0x00252178
		// (set) Token: 0x06008F7E RID: 36734 RVA: 0x00253FB4 File Offset: 0x002521B4
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 37992, RefRangeEnd = 38015, XrefRangeStart = 37992, XrefRangeEnd = 38015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002C0F RID: 11279
		// (get) Token: 0x06008F7F RID: 36735 RVA: 0x00253FF4 File Offset: 0x002521F4
		// (set) Token: 0x06008F80 RID: 36736 RVA: 0x00254030 File Offset: 0x00252230
		public unsafe float SelectedPayment
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_get_SelectedPayment_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_set_SelectedPayment_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002C10 RID: 11280
		// (get) Token: 0x06008F81 RID: 36737 RVA: 0x00254070 File Offset: 0x00252270
		// (set) Token: 0x06008F82 RID: 36738 RVA: 0x002540AC File Offset: 0x002522AC
		public unsafe float NPCAnger
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_get_NPCAnger_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 83984, RefRangeEnd = 83986, XrefRangeStart = 83984, XrefRangeEnd = 83986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_set_NPCAnger_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008F83 RID: 36739 RVA: 0x002540EC File Offset: 0x002522EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260606, XrefRangeEnd = 260679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PawnShopInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F84 RID: 36740 RVA: 0x00254128 File Offset: 0x00252328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260679, XrefRangeEnd = 260743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PawnShopInterface.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F85 RID: 36741 RVA: 0x00254164 File Offset: 0x00252364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260743, XrefRangeEnd = 260777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PawnShopInterface.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F86 RID: 36742 RVA: 0x002541A0 File Offset: 0x002523A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260777, XrefRangeEnd = 260838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F87 RID: 36743 RVA: 0x002541D4 File Offset: 0x002523D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 260889, RefRangeEnd = 260892, XrefRangeStart = 260838, XrefRangeEnd = 260889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(bool returnItemsToPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref returnItemsToPlayer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_Close_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F88 RID: 36744 RVA: 0x00254214 File Offset: 0x00252414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260892, XrefRangeEnd = 260894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F89 RID: 36745 RVA: 0x00254258 File Offset: 0x00252458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260894, XrefRangeEnd = 260895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_OnMinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F8A RID: 36746 RVA: 0x0025428C File Offset: 0x0025248C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260895, XrefRangeEnd = 260896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDayPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_OnDayPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F8B RID: 36747 RVA: 0x002542C0 File Offset: 0x002524C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260896, XrefRangeEnd = 260921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F8C RID: 36748 RVA: 0x002542F4 File Offset: 0x002524F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260921, XrefRangeEnd = 260931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ItemInstance> GetPawnItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_GetPawnItems_Private_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemInstance>>(intPtr3) : null;
		}

		// Token: 0x06008F8D RID: 36749 RVA: 0x00254334 File Offset: 0x00252534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260931, XrefRangeEnd = 260932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PawnSlotChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_PawnSlotChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F8E RID: 36750 RVA: 0x00254368 File Offset: 0x00252568
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 260955, RefRangeEnd = 260957, XrefRangeStart = 260932, XrefRangeEnd = 260955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateValueRangeLabels()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_UpdateValueRangeLabels_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F8F RID: 36751 RVA: 0x0025439C File Offset: 0x0025259C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260957, XrefRangeEnd = 260964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_StartButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F90 RID: 36752 RVA: 0x002543D0 File Offset: 0x002525D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartNegotiation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_StartNegotiation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F91 RID: 36753 RVA: 0x00254404 File Offset: 0x00252604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260964, XrefRangeEnd = 260970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayShopResponse(PawnShopInterface.EShopResponse response, float counter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref response;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref counter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_PlayShopResponse_Private_Void_EShopResponse_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F92 RID: 36754 RVA: 0x00254450 File Offset: 0x00252650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260970, XrefRangeEnd = 260999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PawnShopInterface.EShopResponse EvaluateCounter(float lastShopOffer, float playerOffer, out float counterAmount, out float angerChange)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lastShopOffer;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerOffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &counterAmount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &angerChange;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_EvaluateCounter_Private_EShopResponse_Single_Single_byref_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008F93 RID: 36755 RVA: 0x002544C4 File Offset: 0x002526C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260999, XrefRangeEnd = 261003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndNegotiation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_EndNegotiation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F94 RID: 36756 RVA: 0x002544F8 File Offset: 0x002526F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261003, XrefRangeEnd = 261005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PaymentSubmitted(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_PaymentSubmitted_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F95 RID: 36757 RVA: 0x0025453C File Offset: 0x0025273C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261005, XrefRangeEnd = 261006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangePayment(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_ChangePayment_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F96 RID: 36758 RVA: 0x0025457C File Offset: 0x0025277C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 261026, RefRangeEnd = 261029, XrefRangeStart = 261006, XrefRangeEnd = 261026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelectedPayment(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_SetSelectedPayment_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F97 RID: 36759 RVA: 0x002545BC File Offset: 0x002527BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 261039, RefRangeEnd = 261042, XrefRangeStart = 261029, XrefRangeEnd = 261039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPlayerResponse(PawnShopInterface.EPlayerResponse response)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref response;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_SetPlayerResponse_Public_Void_EPlayerResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F98 RID: 36760 RVA: 0x002545FC File Offset: 0x002527FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261042, XrefRangeEnd = 261043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AcceptOrCounter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_AcceptOrCounter_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F99 RID: 36761 RVA: 0x00254630 File Offset: 0x00252830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261043, XrefRangeEnd = 261044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F9A RID: 36762 RVA: 0x00254664 File Offset: 0x00252864
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 261077, RefRangeEnd = 261078, XrefRangeStart = 261044, XrefRangeEnd = 261077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeAnger(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_ChangeAnger_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F9B RID: 36763 RVA: 0x002546A4 File Offset: 0x002528A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 261089, RefRangeEnd = 261091, XrefRangeStart = 261078, XrefRangeEnd = 261089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAngeredToday(bool angered)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref angered;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_SetAngeredToday_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F9C RID: 36764 RVA: 0x002546E4 File Offset: 0x002528E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 261095, RefRangeEnd = 261096, XrefRangeStart = 261091, XrefRangeEnd = 261095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Think()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_Think_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F9D RID: 36765 RVA: 0x00254718 File Offset: 0x00252918
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 261110, RefRangeEnd = 261111, XrefRangeStart = 261096, XrefRangeEnd = 261110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOffer(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_SetOffer_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F9E RID: 36766 RVA: 0x00254758 File Offset: 0x00252958
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 261121, RefRangeEnd = 261122, XrefRangeStart = 261111, XrefRangeEnd = 261121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinalizeDeal(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_FinalizeDeal_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F9F RID: 36767 RVA: 0x00254798 File Offset: 0x00252998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261122, XrefRangeEnd = 261124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetTotalValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_GetTotalValue_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008FA0 RID: 36768 RVA: 0x002547D4 File Offset: 0x002529D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 261125, RefRangeEnd = 261127, XrefRangeStart = 261124, XrefRangeEnd = 261125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float RoundOffer(float offer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref offer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_RoundOffer_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008FA1 RID: 36769 RVA: 0x00254820 File Offset: 0x00252A20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 261157, RefRangeEnd = 261159, XrefRangeStart = 261127, XrefRangeEnd = 261157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetItemValue(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_GetItemValue_Private_Single_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008FA2 RID: 36770 RVA: 0x00254870 File Offset: 0x00252A70
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 261166, RefRangeEnd = 261169, XrefRangeStart = 261159, XrefRangeEnd = 261166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_ResetUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008FA3 RID: 36771 RVA: 0x002548A4 File Offset: 0x00252AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261169, XrefRangeEnd = 261172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PawnShopInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008FA4 RID: 36772 RVA: 0x002548E0 File Offset: 0x00252AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261172, XrefRangeEnd = 261177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06008FA5 RID: 36773 RVA: 0x00254920 File Offset: 0x00252B20
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 261177, RefRangeEnd = 261186, XrefRangeStart = 261177, XrefRangeEnd = 261177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _StartNegotiation_b__67_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr__StartNegotiation_b__67_1_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008FA6 RID: 36774 RVA: 0x0025495C File Offset: 0x00252B5C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 261177, RefRangeEnd = 261186, XrefRangeStart = 261177, XrefRangeEnd = 261186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _StartNegotiation_b__67_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr__StartNegotiation_b__67_2_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008FA7 RID: 36775 RVA: 0x000452D0 File Offset: 0x000434D0
		public PawnShopInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002BE4 RID: 11236
		// (get) Token: 0x06008FA8 RID: 36776 RVA: 0x00254998 File Offset: 0x00252B98
		// (set) Token: 0x06008FA9 RID: 36777 RVA: 0x000452D9 File Offset: 0x000434D9
		public unsafe static float PAYMENT_MIN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PawnShopInterface.NativeFieldInfoPtr_PAYMENT_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PawnShopInterface.NativeFieldInfoPtr_PAYMENT_MIN, (void*)(&value));
			}
		}

		// Token: 0x17002BE5 RID: 11237
		// (get) Token: 0x06008FAA RID: 36778 RVA: 0x002549B4 File Offset: 0x00252BB4
		// (set) Token: 0x06008FAB RID: 36779 RVA: 0x000452E7 File Offset: 0x000434E7
		public unsafe static float PAYMENT_MAX
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PawnShopInterface.NativeFieldInfoPtr_PAYMENT_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PawnShopInterface.NativeFieldInfoPtr_PAYMENT_MAX, (void*)(&value));
			}
		}

		// Token: 0x17002BE6 RID: 11238
		// (get) Token: 0x06008FAC RID: 36780 RVA: 0x002549D0 File Offset: 0x00252BD0
		// (set) Token: 0x06008FAD RID: 36781 RVA: 0x000452F5 File Offset: 0x000434F5
		public unsafe static float THINK_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PawnShopInterface.NativeFieldInfoPtr_THINK_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PawnShopInterface.NativeFieldInfoPtr_THINK_TIME, (void*)(&value));
			}
		}

		// Token: 0x17002BE7 RID: 11239
		// (get) Token: 0x06008FAE RID: 36782 RVA: 0x002549EC File Offset: 0x00252BEC
		// (set) Token: 0x06008FAF RID: 36783 RVA: 0x00045303 File Offset: 0x00043503
		public unsafe static float MIN_VALUE_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PawnShopInterface.NativeFieldInfoPtr_MIN_VALUE_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PawnShopInterface.NativeFieldInfoPtr_MIN_VALUE_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x17002BE8 RID: 11240
		// (get) Token: 0x06008FB0 RID: 36784 RVA: 0x00254A08 File Offset: 0x00252C08
		// (set) Token: 0x06008FB1 RID: 36785 RVA: 0x00045311 File Offset: 0x00043511
		public unsafe static float MAX_VALUE_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PawnShopInterface.NativeFieldInfoPtr_MAX_VALUE_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PawnShopInterface.NativeFieldInfoPtr_MAX_VALUE_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x17002BE9 RID: 11241
		// (get) Token: 0x06008FB2 RID: 36786 RVA: 0x00254A24 File Offset: 0x00252C24
		// (set) Token: 0x06008FB3 RID: 36787 RVA: 0x0004531F File Offset: 0x0004351F
		public unsafe static int PAWN_SLOT_COUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PawnShopInterface.NativeFieldInfoPtr_PAWN_SLOT_COUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PawnShopInterface.NativeFieldInfoPtr_PAWN_SLOT_COUNT, (void*)(&value));
			}
		}

		// Token: 0x17002BEA RID: 11242
		// (get) Token: 0x06008FB4 RID: 36788 RVA: 0x00254A40 File Offset: 0x00252C40
		// (set) Token: 0x06008FB5 RID: 36789 RVA: 0x0004532D File Offset: 0x0004352D
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002BEB RID: 11243
		// (get) Token: 0x06008FB6 RID: 36790 RVA: 0x00254A68 File Offset: 0x00252C68
		// (set) Token: 0x06008FB7 RID: 36791 RVA: 0x00045348 File Offset: 0x00043548
		public unsafe PawnShopInterface.EState CurrentState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_CurrentState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_CurrentState)) = value;
			}
		}

		// Token: 0x17002BEC RID: 11244
		// (get) Token: 0x06008FB8 RID: 36792 RVA: 0x00254A90 File Offset: 0x00252C90
		// (set) Token: 0x06008FB9 RID: 36793 RVA: 0x00045363 File Offset: 0x00043563
		public unsafe PawnShopInterface.EPlayerResponse PlayerResponse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_PlayerResponse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_PlayerResponse)) = value;
			}
		}

		// Token: 0x17002BED RID: 11245
		// (get) Token: 0x06008FBA RID: 36794 RVA: 0x00254AB8 File Offset: 0x00252CB8
		// (set) Token: 0x06008FBB RID: 36795 RVA: 0x0004537E File Offset: 0x0004357E
		public unsafe int CurrentNegotiationRound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_CurrentNegotiationRound);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_CurrentNegotiationRound)) = value;
			}
		}

		// Token: 0x17002BEE RID: 11246
		// (get) Token: 0x06008FBC RID: 36796 RVA: 0x00254AE0 File Offset: 0x00252CE0
		// (set) Token: 0x06008FBD RID: 36797 RVA: 0x00045399 File Offset: 0x00043599
		public unsafe float InitialShopOffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_InitialShopOffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_InitialShopOffer)) = value;
			}
		}

		// Token: 0x17002BEF RID: 11247
		// (get) Token: 0x06008FBE RID: 36798 RVA: 0x00254B08 File Offset: 0x00252D08
		// (set) Token: 0x06008FBF RID: 36799 RVA: 0x000453B4 File Offset: 0x000435B4
		public unsafe float LastShopOffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_LastShopOffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_LastShopOffer)) = value;
			}
		}

		// Token: 0x17002BF0 RID: 11248
		// (get) Token: 0x06008FC0 RID: 36800 RVA: 0x00254B30 File Offset: 0x00252D30
		// (set) Token: 0x06008FC1 RID: 36801 RVA: 0x000453CF File Offset: 0x000435CF
		public unsafe float LastRefusedAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_LastRefusedAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_LastRefusedAmount)) = value;
			}
		}

		// Token: 0x17002BF1 RID: 11249
		// (get) Token: 0x06008FC2 RID: 36802 RVA: 0x00254B58 File Offset: 0x00252D58
		// (set) Token: 0x06008FC3 RID: 36803 RVA: 0x000453EA File Offset: 0x000435EA
		public unsafe NPC PawnShopNPC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_PawnShopNPC);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_PawnShopNPC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BF2 RID: 11250
		// (get) Token: 0x06008FC4 RID: 36804 RVA: 0x00254B88 File Offset: 0x00252D88
		// (set) Token: 0x06008FC5 RID: 36805 RVA: 0x00045409 File Offset: 0x00043609
		public unsafe float _SelectedPayment_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr__SelectedPayment_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr__SelectedPayment_k__BackingField)) = value;
			}
		}

		// Token: 0x17002BF3 RID: 11251
		// (get) Token: 0x06008FC6 RID: 36806 RVA: 0x00254BB0 File Offset: 0x00252DB0
		// (set) Token: 0x06008FC7 RID: 36807 RVA: 0x00045424 File Offset: 0x00043624
		public unsafe float _NPCAnger_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr__NPCAnger_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr__NPCAnger_k__BackingField)) = value;
			}
		}

		// Token: 0x17002BF4 RID: 11252
		// (get) Token: 0x06008FC8 RID: 36808 RVA: 0x00254BD8 File Offset: 0x00252DD8
		// (set) Token: 0x06008FC9 RID: 36809 RVA: 0x0004543F File Offset: 0x0004363F
		public unsafe AnimationCurve RandomCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_RandomCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_RandomCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BF5 RID: 11253
		// (get) Token: 0x06008FCA RID: 36810 RVA: 0x00254C08 File Offset: 0x00252E08
		// (set) Token: 0x06008FCB RID: 36811 RVA: 0x0004545E File Offset: 0x0004365E
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BF6 RID: 11254
		// (get) Token: 0x06008FCC RID: 36812 RVA: 0x00254C38 File Offset: 0x00252E38
		// (set) Token: 0x06008FCD RID: 36813 RVA: 0x0004547D File Offset: 0x0004367D
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BF7 RID: 11255
		// (get) Token: 0x06008FCE RID: 36814 RVA: 0x00254C68 File Offset: 0x00252E68
		// (set) Token: 0x06008FCF RID: 36815 RVA: 0x0004549C File Offset: 0x0004369C
		public unsafe Il2CppReferenceArray<ItemSlotUI> Slots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Slots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemSlotUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Slots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BF8 RID: 11256
		// (get) Token: 0x06008FD0 RID: 36816 RVA: 0x00254C98 File Offset: 0x00252E98
		// (set) Token: 0x06008FD1 RID: 36817 RVA: 0x000454BB File Offset: 0x000436BB
		public unsafe Il2CppReferenceArray<TextMeshProUGUI> ValueRangeLabels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_ValueRangeLabels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextMeshProUGUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_ValueRangeLabels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BF9 RID: 11257
		// (get) Token: 0x06008FD2 RID: 36818 RVA: 0x00254CC8 File Offset: 0x00252EC8
		// (set) Token: 0x06008FD3 RID: 36819 RVA: 0x000454DA File Offset: 0x000436DA
		public unsafe TextMeshProUGUI TotalValueLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_TotalValueLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_TotalValueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BFA RID: 11258
		// (get) Token: 0x06008FD4 RID: 36820 RVA: 0x00254CF8 File Offset: 0x00252EF8
		// (set) Token: 0x06008FD5 RID: 36821 RVA: 0x000454F9 File Offset: 0x000436F9
		public unsafe Button StartButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_StartButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_StartButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BFB RID: 11259
		// (get) Token: 0x06008FD6 RID: 36822 RVA: 0x00254D28 File Offset: 0x00252F28
		// (set) Token: 0x06008FD7 RID: 36823 RVA: 0x00045518 File Offset: 0x00043718
		public unsafe Animation Step1Animation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Step1Animation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Step1Animation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BFC RID: 11260
		// (get) Token: 0x06008FD8 RID: 36824 RVA: 0x00254D58 File Offset: 0x00252F58
		// (set) Token: 0x06008FD9 RID: 36825 RVA: 0x00045537 File Offset: 0x00043737
		public unsafe CanvasGroup Step1CanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Step1CanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Step1CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BFD RID: 11261
		// (get) Token: 0x06008FDA RID: 36826 RVA: 0x00254D88 File Offset: 0x00252F88
		// (set) Token: 0x06008FDB RID: 36827 RVA: 0x00045556 File Offset: 0x00043756
		public unsafe Animation Step2Animation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Step2Animation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Step2Animation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BFE RID: 11262
		// (get) Token: 0x06008FDC RID: 36828 RVA: 0x00254DB8 File Offset: 0x00252FB8
		// (set) Token: 0x06008FDD RID: 36829 RVA: 0x00045575 File Offset: 0x00043775
		public unsafe CanvasGroup Step2CanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Step2CanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Step2CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BFF RID: 11263
		// (get) Token: 0x06008FDE RID: 36830 RVA: 0x00254DE8 File Offset: 0x00252FE8
		// (set) Token: 0x06008FDF RID: 36831 RVA: 0x00045594 File Offset: 0x00043794
		public unsafe AnimationClip FadeInAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_FadeInAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_FadeInAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C00 RID: 11264
		// (get) Token: 0x06008FE0 RID: 36832 RVA: 0x00254E18 File Offset: 0x00253018
		// (set) Token: 0x06008FE1 RID: 36833 RVA: 0x000455B3 File Offset: 0x000437B3
		public unsafe AnimationClip FadeOutAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_FadeOutAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_FadeOutAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C01 RID: 11265
		// (get) Token: 0x06008FE2 RID: 36834 RVA: 0x00254E48 File Offset: 0x00253048
		// (set) Token: 0x06008FE3 RID: 36835 RVA: 0x000455D2 File Offset: 0x000437D2
		public unsafe TMP_InputField OfferInputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_OfferInputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_OfferInputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C02 RID: 11266
		// (get) Token: 0x06008FE4 RID: 36836 RVA: 0x00254E78 File Offset: 0x00253078
		// (set) Token: 0x06008FE5 RID: 36837 RVA: 0x000455F1 File Offset: 0x000437F1
		public unsafe Slider AngerSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_AngerSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_AngerSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C03 RID: 11267
		// (get) Token: 0x06008FE6 RID: 36838 RVA: 0x00254EA8 File Offset: 0x002530A8
		// (set) Token: 0x06008FE7 RID: 36839 RVA: 0x00045610 File Offset: 0x00043810
		public unsafe TextMeshProUGUI AcceptCounterButtonLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_AcceptCounterButtonLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_AcceptCounterButtonLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C04 RID: 11268
		// (get) Token: 0x06008FE8 RID: 36840 RVA: 0x00254ED8 File Offset: 0x002530D8
		// (set) Token: 0x06008FE9 RID: 36841 RVA: 0x0004562F File Offset: 0x0004382F
		public unsafe Il2CppStringArray OfferLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_OfferLines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_OfferLines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C05 RID: 11269
		// (get) Token: 0x06008FEA RID: 36842 RVA: 0x00254F08 File Offset: 0x00253108
		// (set) Token: 0x06008FEB RID: 36843 RVA: 0x0004564E File Offset: 0x0004384E
		public unsafe Il2CppStringArray ThinkLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_ThinkLines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_ThinkLines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C06 RID: 11270
		// (get) Token: 0x06008FEC RID: 36844 RVA: 0x00254F38 File Offset: 0x00253138
		// (set) Token: 0x06008FED RID: 36845 RVA: 0x0004566D File Offset: 0x0004386D
		public unsafe Il2CppStringArray AcceptLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_AcceptLines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_AcceptLines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C07 RID: 11271
		// (get) Token: 0x06008FEE RID: 36846 RVA: 0x00254F68 File Offset: 0x00253168
		// (set) Token: 0x06008FEF RID: 36847 RVA: 0x0004568C File Offset: 0x0004388C
		public unsafe Il2CppStringArray CounterLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_CounterLines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_CounterLines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C08 RID: 11272
		// (get) Token: 0x06008FF0 RID: 36848 RVA: 0x00254F98 File Offset: 0x00253198
		// (set) Token: 0x06008FF1 RID: 36849 RVA: 0x000456AB File Offset: 0x000438AB
		public unsafe Il2CppStringArray RefusalLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_RefusalLines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_RefusalLines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C09 RID: 11273
		// (get) Token: 0x06008FF2 RID: 36850 RVA: 0x00254FC8 File Offset: 0x002531C8
		// (set) Token: 0x06008FF3 RID: 36851 RVA: 0x000456CA File Offset: 0x000438CA
		public unsafe Il2CppStringArray DealFinalizedLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_DealFinalizedLines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_DealFinalizedLines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C0A RID: 11274
		// (get) Token: 0x06008FF4 RID: 36852 RVA: 0x00254FF8 File Offset: 0x002531F8
		// (set) Token: 0x06008FF5 RID: 36853 RVA: 0x000456E9 File Offset: 0x000438E9
		public unsafe Il2CppStringArray AngeredLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_AngeredLines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_AngeredLines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C0B RID: 11275
		// (get) Token: 0x06008FF6 RID: 36854 RVA: 0x00255028 File Offset: 0x00253228
		// (set) Token: 0x06008FF7 RID: 36855 RVA: 0x00045708 File Offset: 0x00043908
		public unsafe Il2CppStringArray CrashOutLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_CrashOutLines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_CrashOutLines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C0C RID: 11276
		// (get) Token: 0x06008FF8 RID: 36856 RVA: 0x00255058 File Offset: 0x00253258
		// (set) Token: 0x06008FF9 RID: 36857 RVA: 0x00045727 File Offset: 0x00043927
		public unsafe Il2CppReferenceArray<ItemSlot> PawnSlots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_PawnSlots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_PawnSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C0D RID: 11277
		// (get) Token: 0x06008FFA RID: 36858 RVA: 0x00255088 File Offset: 0x00253288
		// (set) Token: 0x06008FFB RID: 36859 RVA: 0x00045746 File Offset: 0x00043946
		public unsafe Coroutine routine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_routine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_routine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006110 RID: 24848
		private static readonly IntPtr NativeFieldInfoPtr_PAYMENT_MIN;

		// Token: 0x04006111 RID: 24849
		private static readonly IntPtr NativeFieldInfoPtr_PAYMENT_MAX;

		// Token: 0x04006112 RID: 24850
		private static readonly IntPtr NativeFieldInfoPtr_THINK_TIME;

		// Token: 0x04006113 RID: 24851
		private static readonly IntPtr NativeFieldInfoPtr_MIN_VALUE_MULTIPLIER;

		// Token: 0x04006114 RID: 24852
		private static readonly IntPtr NativeFieldInfoPtr_MAX_VALUE_MULTIPLIER;

		// Token: 0x04006115 RID: 24853
		private static readonly IntPtr NativeFieldInfoPtr_PAWN_SLOT_COUNT;

		// Token: 0x04006116 RID: 24854
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04006117 RID: 24855
		private static readonly IntPtr NativeFieldInfoPtr_CurrentState;

		// Token: 0x04006118 RID: 24856
		private static readonly IntPtr NativeFieldInfoPtr_PlayerResponse;

		// Token: 0x04006119 RID: 24857
		private static readonly IntPtr NativeFieldInfoPtr_CurrentNegotiationRound;

		// Token: 0x0400611A RID: 24858
		private static readonly IntPtr NativeFieldInfoPtr_InitialShopOffer;

		// Token: 0x0400611B RID: 24859
		private static readonly IntPtr NativeFieldInfoPtr_LastShopOffer;

		// Token: 0x0400611C RID: 24860
		private static readonly IntPtr NativeFieldInfoPtr_LastRefusedAmount;

		// Token: 0x0400611D RID: 24861
		private static readonly IntPtr NativeFieldInfoPtr_PawnShopNPC;

		// Token: 0x0400611E RID: 24862
		private static readonly IntPtr NativeFieldInfoPtr__SelectedPayment_k__BackingField;

		// Token: 0x0400611F RID: 24863
		private static readonly IntPtr NativeFieldInfoPtr__NPCAnger_k__BackingField;

		// Token: 0x04006120 RID: 24864
		private static readonly IntPtr NativeFieldInfoPtr_RandomCurve;

		// Token: 0x04006121 RID: 24865
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04006122 RID: 24866
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006123 RID: 24867
		private static readonly IntPtr NativeFieldInfoPtr_Slots;

		// Token: 0x04006124 RID: 24868
		private static readonly IntPtr NativeFieldInfoPtr_ValueRangeLabels;

		// Token: 0x04006125 RID: 24869
		private static readonly IntPtr NativeFieldInfoPtr_TotalValueLabel;

		// Token: 0x04006126 RID: 24870
		private static readonly IntPtr NativeFieldInfoPtr_StartButton;

		// Token: 0x04006127 RID: 24871
		private static readonly IntPtr NativeFieldInfoPtr_Step1Animation;

		// Token: 0x04006128 RID: 24872
		private static readonly IntPtr NativeFieldInfoPtr_Step1CanvasGroup;

		// Token: 0x04006129 RID: 24873
		private static readonly IntPtr NativeFieldInfoPtr_Step2Animation;

		// Token: 0x0400612A RID: 24874
		private static readonly IntPtr NativeFieldInfoPtr_Step2CanvasGroup;

		// Token: 0x0400612B RID: 24875
		private static readonly IntPtr NativeFieldInfoPtr_FadeInAnim;

		// Token: 0x0400612C RID: 24876
		private static readonly IntPtr NativeFieldInfoPtr_FadeOutAnim;

		// Token: 0x0400612D RID: 24877
		private static readonly IntPtr NativeFieldInfoPtr_OfferInputField;

		// Token: 0x0400612E RID: 24878
		private static readonly IntPtr NativeFieldInfoPtr_AngerSlider;

		// Token: 0x0400612F RID: 24879
		private static readonly IntPtr NativeFieldInfoPtr_AcceptCounterButtonLabel;

		// Token: 0x04006130 RID: 24880
		private static readonly IntPtr NativeFieldInfoPtr_OfferLines;

		// Token: 0x04006131 RID: 24881
		private static readonly IntPtr NativeFieldInfoPtr_ThinkLines;

		// Token: 0x04006132 RID: 24882
		private static readonly IntPtr NativeFieldInfoPtr_AcceptLines;

		// Token: 0x04006133 RID: 24883
		private static readonly IntPtr NativeFieldInfoPtr_CounterLines;

		// Token: 0x04006134 RID: 24884
		private static readonly IntPtr NativeFieldInfoPtr_RefusalLines;

		// Token: 0x04006135 RID: 24885
		private static readonly IntPtr NativeFieldInfoPtr_DealFinalizedLines;

		// Token: 0x04006136 RID: 24886
		private static readonly IntPtr NativeFieldInfoPtr_AngeredLines;

		// Token: 0x04006137 RID: 24887
		private static readonly IntPtr NativeFieldInfoPtr_CrashOutLines;

		// Token: 0x04006138 RID: 24888
		private static readonly IntPtr NativeFieldInfoPtr_PawnSlots;

		// Token: 0x04006139 RID: 24889
		private static readonly IntPtr NativeFieldInfoPtr_routine;

		// Token: 0x0400613A RID: 24890
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x0400613B RID: 24891
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x0400613C RID: 24892
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedPayment_Public_get_Single_0;

		// Token: 0x0400613D RID: 24893
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectedPayment_Private_set_Void_Single_0;

		// Token: 0x0400613E RID: 24894
		private static readonly IntPtr NativeMethodInfoPtr_get_NPCAnger_Public_get_Single_0;

		// Token: 0x0400613F RID: 24895
		private static readonly IntPtr NativeMethodInfoPtr_set_NPCAnger_Private_set_Void_Single_0;

		// Token: 0x04006140 RID: 24896
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006141 RID: 24897
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04006142 RID: 24898
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04006143 RID: 24899
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04006144 RID: 24900
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_Boolean_0;

		// Token: 0x04006145 RID: 24901
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04006146 RID: 24902
		private static readonly IntPtr NativeMethodInfoPtr_OnMinPass_Private_Void_0;

		// Token: 0x04006147 RID: 24903
		private static readonly IntPtr NativeMethodInfoPtr_OnDayPass_Private_Void_0;

		// Token: 0x04006148 RID: 24904
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04006149 RID: 24905
		private static readonly IntPtr NativeMethodInfoPtr_GetPawnItems_Private_List_1_ItemInstance_0;

		// Token: 0x0400614A RID: 24906
		private static readonly IntPtr NativeMethodInfoPtr_PawnSlotChanged_Private_Void_0;

		// Token: 0x0400614B RID: 24907
		private static readonly IntPtr NativeMethodInfoPtr_UpdateValueRangeLabels_Private_Void_0;

		// Token: 0x0400614C RID: 24908
		private static readonly IntPtr NativeMethodInfoPtr_StartButtonPressed_Public_Void_0;

		// Token: 0x0400614D RID: 24909
		private static readonly IntPtr NativeMethodInfoPtr_StartNegotiation_Private_Void_0;

		// Token: 0x0400614E RID: 24910
		private static readonly IntPtr NativeMethodInfoPtr_PlayShopResponse_Private_Void_EShopResponse_Single_0;

		// Token: 0x0400614F RID: 24911
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateCounter_Private_EShopResponse_Single_Single_byref_Single_byref_Single_0;

		// Token: 0x04006150 RID: 24912
		private static readonly IntPtr NativeMethodInfoPtr_EndNegotiation_Private_Void_0;

		// Token: 0x04006151 RID: 24913
		private static readonly IntPtr NativeMethodInfoPtr_PaymentSubmitted_Public_Void_String_0;

		// Token: 0x04006152 RID: 24914
		private static readonly IntPtr NativeMethodInfoPtr_ChangePayment_Public_Void_Single_0;

		// Token: 0x04006153 RID: 24915
		private static readonly IntPtr NativeMethodInfoPtr_SetSelectedPayment_Public_Void_Single_0;

		// Token: 0x04006154 RID: 24916
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayerResponse_Public_Void_EPlayerResponse_0;

		// Token: 0x04006155 RID: 24917
		private static readonly IntPtr NativeMethodInfoPtr_AcceptOrCounter_Public_Void_0;

		// Token: 0x04006156 RID: 24918
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Public_Void_0;

		// Token: 0x04006157 RID: 24919
		private static readonly IntPtr NativeMethodInfoPtr_ChangeAnger_Private_Void_Single_0;

		// Token: 0x04006158 RID: 24920
		private static readonly IntPtr NativeMethodInfoPtr_SetAngeredToday_Private_Void_Boolean_0;

		// Token: 0x04006159 RID: 24921
		private static readonly IntPtr NativeMethodInfoPtr_Think_Private_Void_0;

		// Token: 0x0400615A RID: 24922
		private static readonly IntPtr NativeMethodInfoPtr_SetOffer_Private_Void_Single_0;

		// Token: 0x0400615B RID: 24923
		private static readonly IntPtr NativeMethodInfoPtr_FinalizeDeal_Private_Void_Single_0;

		// Token: 0x0400615C RID: 24924
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalValue_Private_Single_0;

		// Token: 0x0400615D RID: 24925
		private static readonly IntPtr NativeMethodInfoPtr_RoundOffer_Private_Single_Single_0;

		// Token: 0x0400615E RID: 24926
		private static readonly IntPtr NativeMethodInfoPtr_GetItemValue_Private_Single_ItemInstance_0;

		// Token: 0x0400615F RID: 24927
		private static readonly IntPtr NativeMethodInfoPtr_ResetUI_Private_Void_0;

		// Token: 0x04006160 RID: 24928
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006161 RID: 24929
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04006162 RID: 24930
		private static readonly IntPtr NativeMethodInfoPtr__StartNegotiation_b__67_1_Private_Boolean_0;

		// Token: 0x04006163 RID: 24931
		private static readonly IntPtr NativeMethodInfoPtr__StartNegotiation_b__67_2_Private_Boolean_0;

		// Token: 0x02000B34 RID: 2868
		[OriginalName("Assembly-CSharp.dll", "", "EState")]
		public enum EState
		{
			// Token: 0x04009149 RID: 37193
			WaitingForOffer,
			// Token: 0x0400914A RID: 37194
			Negotiating
		}

		// Token: 0x02000B35 RID: 2869
		[OriginalName("Assembly-CSharp.dll", "", "EPlayerResponse")]
		public enum EPlayerResponse
		{
			// Token: 0x0400914C RID: 37196
			None,
			// Token: 0x0400914D RID: 37197
			Accept,
			// Token: 0x0400914E RID: 37198
			Counter,
			// Token: 0x0400914F RID: 37199
			Cancel
		}

		// Token: 0x02000B36 RID: 2870
		[OriginalName("Assembly-CSharp.dll", "", "EShopResponse")]
		public enum EShopResponse
		{
			// Token: 0x04009151 RID: 37201
			Accept,
			// Token: 0x04009152 RID: 37202
			Counter,
			// Token: 0x04009153 RID: 37203
			Refusal
		}

		// Token: 0x02000B37 RID: 2871
		[ObfuscatedName("ScheduleOne.UI.PawnShopInterface+<<StartNegotiation>g__NegotiationRoutine|67_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D840 RID: 55360 RVA: 0x00335EAC File Offset: 0x003340AC
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique()
			{
				Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "<<StartNegotiation>g__NegotiationRoutine|67_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr);
				PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr, "<>1__state");
				PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr, "<>2__current");
				PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr, "<>4__this");
				PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr__shopResponse_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr, "<shopResponse>5__2");
				PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr__counter_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr, "<counter>5__3");
				PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr, 100681128);
				PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr, 100681129);
				PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr, 100681130);
				PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr, 100681131);
				PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr, 100681132);
				PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr, 100681133);
			}

			// Token: 0x0600D841 RID: 55361 RVA: 0x00335FB4 File Offset: 0x003341B4
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D842 RID: 55362 RVA: 0x00335FFC File Offset: 0x003341FC
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D843 RID: 55363 RVA: 0x00336030 File Offset: 0x00334230
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260556, XrefRangeEnd = 260601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700430D RID: 17165
			// (get) Token: 0x0600D844 RID: 55364 RVA: 0x0033606C File Offset: 0x0033426C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D845 RID: 55365 RVA: 0x003360AC File Offset: 0x003342AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260601, XrefRangeEnd = 260606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700430E RID: 17166
			// (get) Token: 0x0600D846 RID: 55366 RVA: 0x003360E0 File Offset: 0x003342E0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D847 RID: 55367 RVA: 0x0006951A File Offset: 0x0006771A
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004308 RID: 17160
			// (get) Token: 0x0600D848 RID: 55368 RVA: 0x00336120 File Offset: 0x00334320
			// (set) Token: 0x0600D849 RID: 55369 RVA: 0x00069523 File Offset: 0x00067723
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004309 RID: 17161
			// (get) Token: 0x0600D84A RID: 55370 RVA: 0x00336148 File Offset: 0x00334348
			// (set) Token: 0x0600D84B RID: 55371 RVA: 0x0006953E File Offset: 0x0006773E
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700430A RID: 17162
			// (get) Token: 0x0600D84C RID: 55372 RVA: 0x00336178 File Offset: 0x00334378
			// (set) Token: 0x0600D84D RID: 55373 RVA: 0x0006955D File Offset: 0x0006775D
			public unsafe PawnShopInterface __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PawnShopInterface>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700430B RID: 17163
			// (get) Token: 0x0600D84E RID: 55374 RVA: 0x003361A8 File Offset: 0x003343A8
			// (set) Token: 0x0600D84F RID: 55375 RVA: 0x0006957C File Offset: 0x0006777C
			public unsafe PawnShopInterface.EShopResponse _shopResponse_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr__shopResponse_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr__shopResponse_5__2)) = value;
				}
			}

			// Token: 0x1700430C RID: 17164
			// (get) Token: 0x0600D850 RID: 55376 RVA: 0x003361D0 File Offset: 0x003343D0
			// (set) Token: 0x0600D851 RID: 55377 RVA: 0x00069597 File Offset: 0x00067797
			public unsafe float _counter_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr__counter_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr__counter_5__3)) = value;
				}
			}

			// Token: 0x04009154 RID: 37204
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009155 RID: 37205
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009156 RID: 37206
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009157 RID: 37207
			private static readonly IntPtr NativeFieldInfoPtr__shopResponse_5__2;

			// Token: 0x04009158 RID: 37208
			private static readonly IntPtr NativeFieldInfoPtr__counter_5__3;

			// Token: 0x04009159 RID: 37209
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400915A RID: 37210
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400915B RID: 37211
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400915C RID: 37212
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400915D RID: 37213
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400915E RID: 37214
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
