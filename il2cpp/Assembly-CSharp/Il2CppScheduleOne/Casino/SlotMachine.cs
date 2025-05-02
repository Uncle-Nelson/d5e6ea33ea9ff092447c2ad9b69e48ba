using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Interaction;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Casino
{
	// Token: 0x020004A8 RID: 1192
	public class SlotMachine : NetworkBehaviour
	{
		// Token: 0x0600686A RID: 26730 RVA: 0x001D5180 File Offset: 0x001D3380
		// Note: this type is marked as 'beforefieldinit'.
		static SlotMachine()
		{
			Il2CppClassPointerStore<SlotMachine>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino", "SlotMachine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr);
			SlotMachine.NativeFieldInfoPtr_BetAmounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "BetAmounts");
			SlotMachine.NativeFieldInfoPtr__IsSpinning_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "<IsSpinning>k__BackingField");
			SlotMachine.NativeFieldInfoPtr_DownButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "DownButton");
			SlotMachine.NativeFieldInfoPtr_UpButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "UpButton");
			SlotMachine.NativeFieldInfoPtr_HandleIntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "HandleIntObj");
			SlotMachine.NativeFieldInfoPtr_BetAmountLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "BetAmountLabel");
			SlotMachine.NativeFieldInfoPtr_Reels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "Reels");
			SlotMachine.NativeFieldInfoPtr_SpinLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "SpinLoop");
			SlotMachine.NativeFieldInfoPtr_ScreenAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "ScreenAnimation");
			SlotMachine.NativeFieldInfoPtr_JackpotParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "JackpotParticles");
			SlotMachine.NativeFieldInfoPtr_WinAmountLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "WinAmountLabels");
			SlotMachine.NativeFieldInfoPtr_MiniWinAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "MiniWinAnimation");
			SlotMachine.NativeFieldInfoPtr_SmallWinAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "SmallWinAnimation");
			SlotMachine.NativeFieldInfoPtr_BigWinAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "BigWinAnimation");
			SlotMachine.NativeFieldInfoPtr_JackpotAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "JackpotAnimation");
			SlotMachine.NativeFieldInfoPtr_MiniWinSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "MiniWinSound");
			SlotMachine.NativeFieldInfoPtr_SmallWinSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "SmallWinSound");
			SlotMachine.NativeFieldInfoPtr_BigWinSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "BigWinSound");
			SlotMachine.NativeFieldInfoPtr_JackpotSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "JackpotSound");
			SlotMachine.NativeFieldInfoPtr_onDownPressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "onDownPressed");
			SlotMachine.NativeFieldInfoPtr_onUpPressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "onUpPressed");
			SlotMachine.NativeFieldInfoPtr_onHandlePulled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "onHandlePulled");
			SlotMachine.NativeFieldInfoPtr_currentBetIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "currentBetIndex");
			SlotMachine.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Casino.SlotMachineAssembly-CSharp.dll_Excuted");
			SlotMachine.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Casino.SlotMachineAssembly-CSharp.dll_Excuted");
			SlotMachine.NativeMethodInfoPtr_get_IsSpinning_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676586);
			SlotMachine.NativeMethodInfoPtr_set_IsSpinning_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676587);
			SlotMachine.NativeMethodInfoPtr_get_currentBetAmount_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676588);
			SlotMachine.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676589);
			SlotMachine.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676590);
			SlotMachine.NativeMethodInfoPtr_DownHovered_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676591);
			SlotMachine.NativeMethodInfoPtr_DownInteracted_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676592);
			SlotMachine.NativeMethodInfoPtr_UpHovered_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676593);
			SlotMachine.NativeMethodInfoPtr_UpInteracted_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676594);
			SlotMachine.NativeMethodInfoPtr_HandleHovered_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676595);
			SlotMachine.NativeMethodInfoPtr_HandleInteracted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676596);
			SlotMachine.NativeMethodInfoPtr_SendBetIndex_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676597);
			SlotMachine.NativeMethodInfoPtr_SetBetIndex_Public_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676598);
			SlotMachine.NativeMethodInfoPtr_SendStartSpin_Public_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676599);
			SlotMachine.NativeMethodInfoPtr_StartSpin_Public_Void_NetworkConnection_Il2CppStructArray_1_ESymbol_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676600);
			SlotMachine.NativeMethodInfoPtr_EvaluateOutcome_Private_EOutcome_Il2CppStructArray_1_ESymbol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676601);
			SlotMachine.NativeMethodInfoPtr_GetWinAmount_Private_Int32_EOutcome_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676602);
			SlotMachine.NativeMethodInfoPtr_DisplayOutcome_Private_Void_EOutcome_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676603);
			SlotMachine.NativeMethodInfoPtr_GetRandomSymbol_Public_Static_ESymbol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676604);
			SlotMachine.NativeMethodInfoPtr_IsFruit_Private_Boolean_ESymbol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676605);
			SlotMachine.NativeMethodInfoPtr_IsAllFruit_Private_Boolean_Il2CppStructArray_1_ESymbol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676606);
			SlotMachine.NativeMethodInfoPtr_IsUniform_Private_Boolean_Il2CppStructArray_1_ESymbol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676607);
			SlotMachine.NativeMethodInfoPtr_SimulateMany_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676608);
			SlotMachine.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676609);
			SlotMachine.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676611);
			SlotMachine.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676612);
			SlotMachine.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676613);
			SlotMachine.NativeMethodInfoPtr_RpcWriter___Server_SendBetIndex_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676614);
			SlotMachine.NativeMethodInfoPtr_RpcLogic___SendBetIndex_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676615);
			SlotMachine.NativeMethodInfoPtr_RpcReader___Server_SendBetIndex_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676616);
			SlotMachine.NativeMethodInfoPtr_RpcWriter___Observers_SetBetIndex_2681120339_Private_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676617);
			SlotMachine.NativeMethodInfoPtr_RpcLogic___SetBetIndex_2681120339_Public_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676618);
			SlotMachine.NativeMethodInfoPtr_RpcReader___Observers_SetBetIndex_2681120339_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676619);
			SlotMachine.NativeMethodInfoPtr_RpcWriter___Target_SetBetIndex_2681120339_Private_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676620);
			SlotMachine.NativeMethodInfoPtr_RpcReader___Target_SetBetIndex_2681120339_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676621);
			SlotMachine.NativeMethodInfoPtr_RpcWriter___Server_SendStartSpin_2681120339_Private_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676622);
			SlotMachine.NativeMethodInfoPtr_RpcLogic___SendStartSpin_2681120339_Public_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676623);
			SlotMachine.NativeMethodInfoPtr_RpcReader___Server_SendStartSpin_2681120339_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676624);
			SlotMachine.NativeMethodInfoPtr_RpcWriter___Observers_StartSpin_2659526290_Private_Void_NetworkConnection_Il2CppStructArray_1_ESymbol_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676625);
			SlotMachine.NativeMethodInfoPtr_RpcLogic___StartSpin_2659526290_Public_Void_NetworkConnection_Il2CppStructArray_1_ESymbol_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676626);
			SlotMachine.NativeMethodInfoPtr_RpcReader___Observers_StartSpin_2659526290_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676627);
			SlotMachine.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676628);
		}

		// Token: 0x17001F70 RID: 8048
		// (get) Token: 0x0600686B RID: 26731 RVA: 0x001D56EC File Offset: 0x001D38EC
		// (set) Token: 0x0600686C RID: 26732 RVA: 0x001D5728 File Offset: 0x001D3928
		public unsafe bool IsSpinning
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_get_IsSpinning_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_set_IsSpinning_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001F71 RID: 8049
		// (get) Token: 0x0600686D RID: 26733 RVA: 0x001D5768 File Offset: 0x001D3968
		public unsafe int currentBetAmount
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 211665, RefRangeEnd = 211668, XrefRangeStart = 211661, XrefRangeEnd = 211665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_get_currentBetAmount_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600686E RID: 26734 RVA: 0x001D57A4 File Offset: 0x001D39A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211668, XrefRangeEnd = 211669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SlotMachine.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600686F RID: 26735 RVA: 0x001D57E0 File Offset: 0x001D39E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211669, XrefRangeEnd = 211671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SlotMachine.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006870 RID: 26736 RVA: 0x001D5830 File Offset: 0x001D3A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211671, XrefRangeEnd = 211674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DownHovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_DownHovered_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006871 RID: 26737 RVA: 0x001D5864 File Offset: 0x001D3A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211674, XrefRangeEnd = 211676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DownInteracted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_DownInteracted_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006872 RID: 26738 RVA: 0x001D5898 File Offset: 0x001D3A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211676, XrefRangeEnd = 211679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpHovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_UpHovered_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006873 RID: 26739 RVA: 0x001D58CC File Offset: 0x001D3ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211679, XrefRangeEnd = 211691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpInteracted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_UpInteracted_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006874 RID: 26740 RVA: 0x001D5900 File Offset: 0x001D3B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211691, XrefRangeEnd = 211703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleHovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_HandleHovered_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006875 RID: 26741 RVA: 0x001D5934 File Offset: 0x001D3B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211703, XrefRangeEnd = 211742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleInteracted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_HandleInteracted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006876 RID: 26742 RVA: 0x001D5968 File Offset: 0x001D3B68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 211765, RefRangeEnd = 211767, XrefRangeStart = 211742, XrefRangeEnd = 211765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendBetIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_SendBetIndex_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006877 RID: 26743 RVA: 0x001D59A8 File Offset: 0x001D3BA8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 211811, RefRangeEnd = 211816, XrefRangeStart = 211767, XrefRangeEnd = 211811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBetIndex(NetworkConnection conn, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_SetBetIndex_Public_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006878 RID: 26744 RVA: 0x001D59F8 File Offset: 0x001D3BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211816, XrefRangeEnd = 211840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendStartSpin(NetworkConnection spinner, int betAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spinner);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref betAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_SendStartSpin_Public_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006879 RID: 26745 RVA: 0x001D5A48 File Offset: 0x001D3C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211840, XrefRangeEnd = 211865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartSpin(NetworkConnection spinner, Il2CppStructArray<SlotMachine.ESymbol> symbols, int betAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spinner);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(symbols);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref betAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_StartSpin_Public_Void_NetworkConnection_Il2CppStructArray_1_ESymbol_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600687A RID: 26746 RVA: 0x001D5AAC File Offset: 0x001D3CAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 211867, RefRangeEnd = 211868, XrefRangeStart = 211865, XrefRangeEnd = 211867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SlotMachine.EOutcome EvaluateOutcome(Il2CppStructArray<SlotMachine.ESymbol> outcome)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(outcome);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_EvaluateOutcome_Private_EOutcome_Il2CppStructArray_1_ESymbol_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600687B RID: 26747 RVA: 0x001D5AFC File Offset: 0x001D3CFC
		[CallerCount(0)]
		public unsafe int GetWinAmount(SlotMachine.EOutcome outcome, int betAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref outcome;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref betAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_GetWinAmount_Private_Int32_EOutcome_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600687C RID: 26748 RVA: 0x001D5B54 File Offset: 0x001D3D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211868, XrefRangeEnd = 211872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisplayOutcome(SlotMachine.EOutcome outcome, int winAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref outcome;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref winAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_DisplayOutcome_Private_Void_EOutcome_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600687D RID: 26749 RVA: 0x001D5BA0 File Offset: 0x001D3DA0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 211888, RefRangeEnd = 211891, XrefRangeStart = 211872, XrefRangeEnd = 211888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SlotMachine.ESymbol GetRandomSymbol()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_GetRandomSymbol_Public_Static_ESymbol_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600687E RID: 26750 RVA: 0x001D5BD0 File Offset: 0x001D3DD0
		[CallerCount(0)]
		public unsafe bool IsFruit(SlotMachine.ESymbol symbol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref symbol;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_IsFruit_Private_Boolean_ESymbol_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600687F RID: 26751 RVA: 0x001D5C1C File Offset: 0x001D3E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211891, XrefRangeEnd = 211892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAllFruit(Il2CppStructArray<SlotMachine.ESymbol> symbols)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(symbols);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_IsAllFruit_Private_Boolean_Il2CppStructArray_1_ESymbol_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006880 RID: 26752 RVA: 0x001D5C6C File Offset: 0x001D3E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211892, XrefRangeEnd = 211893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsUniform(Il2CppStructArray<SlotMachine.ESymbol> symbols)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(symbols);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_IsUniform_Private_Boolean_Il2CppStructArray_1_ESymbol_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006881 RID: 26753 RVA: 0x001D5CBC File Offset: 0x001D3EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211893, XrefRangeEnd = 211941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SimulateMany()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_SimulateMany_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006882 RID: 26754 RVA: 0x001D5CF0 File Offset: 0x001D3EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211941, XrefRangeEnd = 211942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SlotMachine() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006883 RID: 26755 RVA: 0x001D5D2C File Offset: 0x001D3F2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211942, XrefRangeEnd = 211974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SlotMachine.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006884 RID: 26756 RVA: 0x001D5D68 File Offset: 0x001D3F68
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SlotMachine.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006885 RID: 26757 RVA: 0x001D5DA4 File Offset: 0x001D3FA4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SlotMachine.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006886 RID: 26758 RVA: 0x001D5DE0 File Offset: 0x001D3FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211974, XrefRangeEnd = 211994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendBetIndex_3316948804(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcWriter___Server_SendBetIndex_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006887 RID: 26759 RVA: 0x001D5E20 File Offset: 0x001D4020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211994, XrefRangeEnd = 211995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendBetIndex_3316948804(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcLogic___SendBetIndex_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006888 RID: 26760 RVA: 0x001D5E60 File Offset: 0x001D4060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211995, XrefRangeEnd = 212000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendBetIndex_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcReader___Server_SendBetIndex_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006889 RID: 26761 RVA: 0x001D5EC4 File Offset: 0x001D40C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212000, XrefRangeEnd = 212020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetBetIndex_2681120339(NetworkConnection conn, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcWriter___Observers_SetBetIndex_2681120339_Private_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600688A RID: 26762 RVA: 0x001D5F14 File Offset: 0x001D4114
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 212028, RefRangeEnd = 212031, XrefRangeStart = 212020, XrefRangeEnd = 212028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetBetIndex_2681120339(NetworkConnection conn, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcLogic___SetBetIndex_2681120339_Public_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600688B RID: 26763 RVA: 0x001D5F64 File Offset: 0x001D4164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212031, XrefRangeEnd = 212036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetBetIndex_2681120339(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcReader___Observers_SetBetIndex_2681120339_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600688C RID: 26764 RVA: 0x001D5FB4 File Offset: 0x001D41B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212036, XrefRangeEnd = 212056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetBetIndex_2681120339(NetworkConnection conn, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcWriter___Target_SetBetIndex_2681120339_Private_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600688D RID: 26765 RVA: 0x001D6004 File Offset: 0x001D4204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212056, XrefRangeEnd = 212061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetBetIndex_2681120339(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcReader___Target_SetBetIndex_2681120339_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600688E RID: 26766 RVA: 0x001D6054 File Offset: 0x001D4254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212061, XrefRangeEnd = 212082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendStartSpin_2681120339(NetworkConnection spinner, int betAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spinner);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref betAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcWriter___Server_SendStartSpin_2681120339_Private_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600688F RID: 26767 RVA: 0x001D60A4 File Offset: 0x001D42A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 212114, RefRangeEnd = 212117, XrefRangeStart = 212082, XrefRangeEnd = 212114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendStartSpin_2681120339(NetworkConnection spinner, int betAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spinner);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref betAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcLogic___SendStartSpin_2681120339_Public_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006890 RID: 26768 RVA: 0x001D60F4 File Offset: 0x001D42F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212117, XrefRangeEnd = 212123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendStartSpin_2681120339(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcReader___Server_SendStartSpin_2681120339_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006891 RID: 26769 RVA: 0x001D6158 File Offset: 0x001D4358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212123, XrefRangeEnd = 212136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_StartSpin_2659526290(NetworkConnection spinner, Il2CppStructArray<SlotMachine.ESymbol> symbols, int betAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spinner);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(symbols);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref betAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcWriter___Observers_StartSpin_2659526290_Private_Void_NetworkConnection_Il2CppStructArray_1_ESymbol_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006892 RID: 26770 RVA: 0x001D61BC File Offset: 0x001D43BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 212153, RefRangeEnd = 212156, XrefRangeStart = 212136, XrefRangeEnd = 212153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___StartSpin_2659526290(NetworkConnection spinner, Il2CppStructArray<SlotMachine.ESymbol> symbols, int betAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spinner);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(symbols);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref betAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcLogic___StartSpin_2659526290_Public_Void_NetworkConnection_Il2CppStructArray_1_ESymbol_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006893 RID: 26771 RVA: 0x001D6220 File Offset: 0x001D4420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212156, XrefRangeEnd = 212163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_StartSpin_2659526290(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcReader___Observers_StartSpin_2659526290_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006894 RID: 26772 RVA: 0x001D6270 File Offset: 0x001D4470
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212202, RefRangeEnd = 212203, XrefRangeStart = 212163, XrefRangeEnd = 212202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006895 RID: 26773 RVA: 0x00031356 File Offset: 0x0002F556
		public SlotMachine(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F57 RID: 8023
		// (get) Token: 0x06006896 RID: 26774 RVA: 0x001D62A4 File Offset: 0x001D44A4
		// (set) Token: 0x06006897 RID: 26775 RVA: 0x0003135F File Offset: 0x0002F55F
		public unsafe static Il2CppStructArray<int> BetAmounts
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SlotMachine.NativeFieldInfoPtr_BetAmounts, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SlotMachine.NativeFieldInfoPtr_BetAmounts, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F58 RID: 8024
		// (get) Token: 0x06006898 RID: 26776 RVA: 0x001D62CC File Offset: 0x001D44CC
		// (set) Token: 0x06006899 RID: 26777 RVA: 0x00031371 File Offset: 0x0002F571
		public unsafe bool _IsSpinning_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr__IsSpinning_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr__IsSpinning_k__BackingField)) = value;
			}
		}

		// Token: 0x17001F59 RID: 8025
		// (get) Token: 0x0600689A RID: 26778 RVA: 0x001D62F4 File Offset: 0x001D44F4
		// (set) Token: 0x0600689B RID: 26779 RVA: 0x0003138C File Offset: 0x0002F58C
		public unsafe InteractableObject DownButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_DownButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_DownButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F5A RID: 8026
		// (get) Token: 0x0600689C RID: 26780 RVA: 0x001D6324 File Offset: 0x001D4524
		// (set) Token: 0x0600689D RID: 26781 RVA: 0x000313AB File Offset: 0x0002F5AB
		public unsafe InteractableObject UpButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_UpButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_UpButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F5B RID: 8027
		// (get) Token: 0x0600689E RID: 26782 RVA: 0x001D6354 File Offset: 0x001D4554
		// (set) Token: 0x0600689F RID: 26783 RVA: 0x000313CA File Offset: 0x0002F5CA
		public unsafe InteractableObject HandleIntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_HandleIntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_HandleIntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F5C RID: 8028
		// (get) Token: 0x060068A0 RID: 26784 RVA: 0x001D6384 File Offset: 0x001D4584
		// (set) Token: 0x060068A1 RID: 26785 RVA: 0x000313E9 File Offset: 0x0002F5E9
		public unsafe TextMeshPro BetAmountLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_BetAmountLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_BetAmountLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F5D RID: 8029
		// (get) Token: 0x060068A2 RID: 26786 RVA: 0x001D63B4 File Offset: 0x001D45B4
		// (set) Token: 0x060068A3 RID: 26787 RVA: 0x00031408 File Offset: 0x0002F608
		public unsafe Il2CppReferenceArray<SlotReel> Reels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_Reels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SlotReel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_Reels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F5E RID: 8030
		// (get) Token: 0x060068A4 RID: 26788 RVA: 0x001D63E4 File Offset: 0x001D45E4
		// (set) Token: 0x060068A5 RID: 26789 RVA: 0x00031427 File Offset: 0x0002F627
		public unsafe AudioSourceController SpinLoop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_SpinLoop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_SpinLoop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F5F RID: 8031
		// (get) Token: 0x060068A6 RID: 26790 RVA: 0x001D6414 File Offset: 0x001D4614
		// (set) Token: 0x060068A7 RID: 26791 RVA: 0x00031446 File Offset: 0x0002F646
		public unsafe Animation ScreenAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_ScreenAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_ScreenAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F60 RID: 8032
		// (get) Token: 0x060068A8 RID: 26792 RVA: 0x001D6444 File Offset: 0x001D4644
		// (set) Token: 0x060068A9 RID: 26793 RVA: 0x00031465 File Offset: 0x0002F665
		public unsafe Il2CppReferenceArray<ParticleSystem> JackpotParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_JackpotParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParticleSystem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_JackpotParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F61 RID: 8033
		// (get) Token: 0x060068AA RID: 26794 RVA: 0x001D6474 File Offset: 0x001D4674
		// (set) Token: 0x060068AB RID: 26795 RVA: 0x00031484 File Offset: 0x0002F684
		public unsafe Il2CppReferenceArray<TextMeshProUGUI> WinAmountLabels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_WinAmountLabels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextMeshProUGUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_WinAmountLabels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F62 RID: 8034
		// (get) Token: 0x060068AC RID: 26796 RVA: 0x001D64A4 File Offset: 0x001D46A4
		// (set) Token: 0x060068AD RID: 26797 RVA: 0x000314A3 File Offset: 0x0002F6A3
		public unsafe AnimationClip MiniWinAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_MiniWinAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_MiniWinAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F63 RID: 8035
		// (get) Token: 0x060068AE RID: 26798 RVA: 0x001D64D4 File Offset: 0x001D46D4
		// (set) Token: 0x060068AF RID: 26799 RVA: 0x000314C2 File Offset: 0x0002F6C2
		public unsafe AnimationClip SmallWinAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_SmallWinAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_SmallWinAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F64 RID: 8036
		// (get) Token: 0x060068B0 RID: 26800 RVA: 0x001D6504 File Offset: 0x001D4704
		// (set) Token: 0x060068B1 RID: 26801 RVA: 0x000314E1 File Offset: 0x0002F6E1
		public unsafe AnimationClip BigWinAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_BigWinAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_BigWinAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F65 RID: 8037
		// (get) Token: 0x060068B2 RID: 26802 RVA: 0x001D6534 File Offset: 0x001D4734
		// (set) Token: 0x060068B3 RID: 26803 RVA: 0x00031500 File Offset: 0x0002F700
		public unsafe AnimationClip JackpotAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_JackpotAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_JackpotAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F66 RID: 8038
		// (get) Token: 0x060068B4 RID: 26804 RVA: 0x001D6564 File Offset: 0x001D4764
		// (set) Token: 0x060068B5 RID: 26805 RVA: 0x0003151F File Offset: 0x0002F71F
		public unsafe AudioSourceController MiniWinSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_MiniWinSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_MiniWinSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F67 RID: 8039
		// (get) Token: 0x060068B6 RID: 26806 RVA: 0x001D6594 File Offset: 0x001D4794
		// (set) Token: 0x060068B7 RID: 26807 RVA: 0x0003153E File Offset: 0x0002F73E
		public unsafe AudioSourceController SmallWinSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_SmallWinSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_SmallWinSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F68 RID: 8040
		// (get) Token: 0x060068B8 RID: 26808 RVA: 0x001D65C4 File Offset: 0x001D47C4
		// (set) Token: 0x060068B9 RID: 26809 RVA: 0x0003155D File Offset: 0x0002F75D
		public unsafe AudioSourceController BigWinSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_BigWinSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_BigWinSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F69 RID: 8041
		// (get) Token: 0x060068BA RID: 26810 RVA: 0x001D65F4 File Offset: 0x001D47F4
		// (set) Token: 0x060068BB RID: 26811 RVA: 0x0003157C File Offset: 0x0002F77C
		public unsafe AudioSourceController JackpotSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_JackpotSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_JackpotSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F6A RID: 8042
		// (get) Token: 0x060068BC RID: 26812 RVA: 0x001D6624 File Offset: 0x001D4824
		// (set) Token: 0x060068BD RID: 26813 RVA: 0x0003159B File Offset: 0x0002F79B
		public unsafe UnityEvent onDownPressed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_onDownPressed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_onDownPressed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F6B RID: 8043
		// (get) Token: 0x060068BE RID: 26814 RVA: 0x001D6654 File Offset: 0x001D4854
		// (set) Token: 0x060068BF RID: 26815 RVA: 0x000315BA File Offset: 0x0002F7BA
		public unsafe UnityEvent onUpPressed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_onUpPressed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_onUpPressed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F6C RID: 8044
		// (get) Token: 0x060068C0 RID: 26816 RVA: 0x001D6684 File Offset: 0x001D4884
		// (set) Token: 0x060068C1 RID: 26817 RVA: 0x000315D9 File Offset: 0x0002F7D9
		public unsafe UnityEvent onHandlePulled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_onHandlePulled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_onHandlePulled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F6D RID: 8045
		// (get) Token: 0x060068C2 RID: 26818 RVA: 0x001D66B4 File Offset: 0x001D48B4
		// (set) Token: 0x060068C3 RID: 26819 RVA: 0x000315F8 File Offset: 0x0002F7F8
		public unsafe int currentBetIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_currentBetIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_currentBetIndex)) = value;
			}
		}

		// Token: 0x17001F6E RID: 8046
		// (get) Token: 0x060068C4 RID: 26820 RVA: 0x001D66DC File Offset: 0x001D48DC
		// (set) Token: 0x060068C5 RID: 26821 RVA: 0x00031613 File Offset: 0x0002F813
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001F6F RID: 8047
		// (get) Token: 0x060068C6 RID: 26822 RVA: 0x001D6704 File Offset: 0x001D4904
		// (set) Token: 0x060068C7 RID: 26823 RVA: 0x0003162E File Offset: 0x0002F82E
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004792 RID: 18322
		private static readonly IntPtr NativeFieldInfoPtr_BetAmounts;

		// Token: 0x04004793 RID: 18323
		private static readonly IntPtr NativeFieldInfoPtr__IsSpinning_k__BackingField;

		// Token: 0x04004794 RID: 18324
		private static readonly IntPtr NativeFieldInfoPtr_DownButton;

		// Token: 0x04004795 RID: 18325
		private static readonly IntPtr NativeFieldInfoPtr_UpButton;

		// Token: 0x04004796 RID: 18326
		private static readonly IntPtr NativeFieldInfoPtr_HandleIntObj;

		// Token: 0x04004797 RID: 18327
		private static readonly IntPtr NativeFieldInfoPtr_BetAmountLabel;

		// Token: 0x04004798 RID: 18328
		private static readonly IntPtr NativeFieldInfoPtr_Reels;

		// Token: 0x04004799 RID: 18329
		private static readonly IntPtr NativeFieldInfoPtr_SpinLoop;

		// Token: 0x0400479A RID: 18330
		private static readonly IntPtr NativeFieldInfoPtr_ScreenAnimation;

		// Token: 0x0400479B RID: 18331
		private static readonly IntPtr NativeFieldInfoPtr_JackpotParticles;

		// Token: 0x0400479C RID: 18332
		private static readonly IntPtr NativeFieldInfoPtr_WinAmountLabels;

		// Token: 0x0400479D RID: 18333
		private static readonly IntPtr NativeFieldInfoPtr_MiniWinAnimation;

		// Token: 0x0400479E RID: 18334
		private static readonly IntPtr NativeFieldInfoPtr_SmallWinAnimation;

		// Token: 0x0400479F RID: 18335
		private static readonly IntPtr NativeFieldInfoPtr_BigWinAnimation;

		// Token: 0x040047A0 RID: 18336
		private static readonly IntPtr NativeFieldInfoPtr_JackpotAnimation;

		// Token: 0x040047A1 RID: 18337
		private static readonly IntPtr NativeFieldInfoPtr_MiniWinSound;

		// Token: 0x040047A2 RID: 18338
		private static readonly IntPtr NativeFieldInfoPtr_SmallWinSound;

		// Token: 0x040047A3 RID: 18339
		private static readonly IntPtr NativeFieldInfoPtr_BigWinSound;

		// Token: 0x040047A4 RID: 18340
		private static readonly IntPtr NativeFieldInfoPtr_JackpotSound;

		// Token: 0x040047A5 RID: 18341
		private static readonly IntPtr NativeFieldInfoPtr_onDownPressed;

		// Token: 0x040047A6 RID: 18342
		private static readonly IntPtr NativeFieldInfoPtr_onUpPressed;

		// Token: 0x040047A7 RID: 18343
		private static readonly IntPtr NativeFieldInfoPtr_onHandlePulled;

		// Token: 0x040047A8 RID: 18344
		private static readonly IntPtr NativeFieldInfoPtr_currentBetIndex;

		// Token: 0x040047A9 RID: 18345
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040047AA RID: 18346
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040047AB RID: 18347
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSpinning_Public_get_Boolean_0;

		// Token: 0x040047AC RID: 18348
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSpinning_Private_set_Void_Boolean_0;

		// Token: 0x040047AD RID: 18349
		private static readonly IntPtr NativeMethodInfoPtr_get_currentBetAmount_Private_get_Int32_0;

		// Token: 0x040047AE RID: 18350
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040047AF RID: 18351
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x040047B0 RID: 18352
		private static readonly IntPtr NativeMethodInfoPtr_DownHovered_Private_Void_1;

		// Token: 0x040047B1 RID: 18353
		private static readonly IntPtr NativeMethodInfoPtr_DownInteracted_Private_Void_1;

		// Token: 0x040047B2 RID: 18354
		private static readonly IntPtr NativeMethodInfoPtr_UpHovered_Private_Void_1;

		// Token: 0x040047B3 RID: 18355
		private static readonly IntPtr NativeMethodInfoPtr_UpInteracted_Private_Void_1;

		// Token: 0x040047B4 RID: 18356
		private static readonly IntPtr NativeMethodInfoPtr_HandleHovered_Private_Void_1;

		// Token: 0x040047B5 RID: 18357
		private static readonly IntPtr NativeMethodInfoPtr_HandleInteracted_Public_Void_0;

		// Token: 0x040047B6 RID: 18358
		private static readonly IntPtr NativeMethodInfoPtr_SendBetIndex_Private_Void_Int32_0;

		// Token: 0x040047B7 RID: 18359
		private static readonly IntPtr NativeMethodInfoPtr_SetBetIndex_Public_Void_NetworkConnection_Int32_0;

		// Token: 0x040047B8 RID: 18360
		private static readonly IntPtr NativeMethodInfoPtr_SendStartSpin_Public_Void_NetworkConnection_Int32_0;

		// Token: 0x040047B9 RID: 18361
		private static readonly IntPtr NativeMethodInfoPtr_StartSpin_Public_Void_NetworkConnection_Il2CppStructArray_1_ESymbol_Int32_0;

		// Token: 0x040047BA RID: 18362
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateOutcome_Private_EOutcome_Il2CppStructArray_1_ESymbol_0;

		// Token: 0x040047BB RID: 18363
		private static readonly IntPtr NativeMethodInfoPtr_GetWinAmount_Private_Int32_EOutcome_Int32_0;

		// Token: 0x040047BC RID: 18364
		private static readonly IntPtr NativeMethodInfoPtr_DisplayOutcome_Private_Void_EOutcome_Int32_0;

		// Token: 0x040047BD RID: 18365
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomSymbol_Public_Static_ESymbol_0;

		// Token: 0x040047BE RID: 18366
		private static readonly IntPtr NativeMethodInfoPtr_IsFruit_Private_Boolean_ESymbol_0;

		// Token: 0x040047BF RID: 18367
		private static readonly IntPtr NativeMethodInfoPtr_IsAllFruit_Private_Boolean_Il2CppStructArray_1_ESymbol_0;

		// Token: 0x040047C0 RID: 18368
		private static readonly IntPtr NativeMethodInfoPtr_IsUniform_Private_Boolean_Il2CppStructArray_1_ESymbol_0;

		// Token: 0x040047C1 RID: 18369
		private static readonly IntPtr NativeMethodInfoPtr_SimulateMany_Public_Void_0;

		// Token: 0x040047C2 RID: 18370
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040047C3 RID: 18371
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040047C4 RID: 18372
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040047C5 RID: 18373
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040047C6 RID: 18374
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendBetIndex_3316948804_Private_Void_Int32_0;

		// Token: 0x040047C7 RID: 18375
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendBetIndex_3316948804_Private_Void_Int32_0;

		// Token: 0x040047C8 RID: 18376
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendBetIndex_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040047C9 RID: 18377
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetBetIndex_2681120339_Private_Void_NetworkConnection_Int32_0;

		// Token: 0x040047CA RID: 18378
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetBetIndex_2681120339_Public_Void_NetworkConnection_Int32_0;

		// Token: 0x040047CB RID: 18379
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetBetIndex_2681120339_Private_Void_PooledReader_Channel_0;

		// Token: 0x040047CC RID: 18380
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetBetIndex_2681120339_Private_Void_NetworkConnection_Int32_0;

		// Token: 0x040047CD RID: 18381
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetBetIndex_2681120339_Private_Void_PooledReader_Channel_0;

		// Token: 0x040047CE RID: 18382
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendStartSpin_2681120339_Private_Void_NetworkConnection_Int32_0;

		// Token: 0x040047CF RID: 18383
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendStartSpin_2681120339_Public_Void_NetworkConnection_Int32_0;

		// Token: 0x040047D0 RID: 18384
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendStartSpin_2681120339_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040047D1 RID: 18385
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_StartSpin_2659526290_Private_Void_NetworkConnection_Il2CppStructArray_1_ESymbol_Int32_0;

		// Token: 0x040047D2 RID: 18386
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___StartSpin_2659526290_Public_Void_NetworkConnection_Il2CppStructArray_1_ESymbol_Int32_0;

		// Token: 0x040047D3 RID: 18387
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_StartSpin_2659526290_Private_Void_PooledReader_Channel_0;

		// Token: 0x040047D4 RID: 18388
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_0;

		// Token: 0x02000A4C RID: 2636
		[OriginalName("Assembly-CSharp.dll", "", "ESymbol")]
		public enum ESymbol
		{
			// Token: 0x04008C76 RID: 35958
			Cherry,
			// Token: 0x04008C77 RID: 35959
			Lemon,
			// Token: 0x04008C78 RID: 35960
			Grape,
			// Token: 0x04008C79 RID: 35961
			Watermelon,
			// Token: 0x04008C7A RID: 35962
			Bell,
			// Token: 0x04008C7B RID: 35963
			Seven
		}

		// Token: 0x02000A4D RID: 2637
		[OriginalName("Assembly-CSharp.dll", "", "EOutcome")]
		public enum EOutcome
		{
			// Token: 0x04008C7D RID: 35965
			Jackpot,
			// Token: 0x04008C7E RID: 35966
			BigWin,
			// Token: 0x04008C7F RID: 35967
			SmallWin,
			// Token: 0x04008C80 RID: 35968
			MiniWin,
			// Token: 0x04008C81 RID: 35969
			NoWin
		}

		// Token: 0x02000A4E RID: 2638
		[ObfuscatedName("ScheduleOne.Casino.SlotMachine+<>c__DisplayClass41_0")]
		public sealed class __c__DisplayClass41_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D02A RID: 53290 RVA: 0x0031F458 File Offset: 0x0031D658
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass41_0()
			{
				Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "<>c__DisplayClass41_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0>.NativeClassPtr);
				SlotMachine.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0>.NativeClassPtr, "<>4__this");
				SlotMachine.__c__DisplayClass41_0.NativeFieldInfoPtr_symbols = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0>.NativeClassPtr, "symbols");
				SlotMachine.__c__DisplayClass41_0.NativeFieldInfoPtr_betAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0>.NativeClassPtr, "betAmount");
				SlotMachine.__c__DisplayClass41_0.NativeFieldInfoPtr_spinner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0>.NativeClassPtr, "spinner");
				SlotMachine.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0>.NativeClassPtr, 100676629);
				SlotMachine.__c__DisplayClass41_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0>.NativeClassPtr, 100676630);
			}

			// Token: 0x0600D02B RID: 53291 RVA: 0x0031F4FC File Offset: 0x0031D6FC
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass41_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D02C RID: 53292 RVA: 0x0031F538 File Offset: 0x0031D738
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211656, XrefRangeEnd = 211661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.__c__DisplayClass41_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D02D RID: 53293 RVA: 0x000654B0 File Offset: 0x000636B0
			public __c__DisplayClass41_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040A7 RID: 16551
			// (get) Token: 0x0600D02E RID: 53294 RVA: 0x0031F578 File Offset: 0x0031D778
			// (set) Token: 0x0600D02F RID: 53295 RVA: 0x000654B9 File Offset: 0x000636B9
			public unsafe SlotMachine __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SlotMachine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040A8 RID: 16552
			// (get) Token: 0x0600D030 RID: 53296 RVA: 0x0031F5A8 File Offset: 0x0031D7A8
			// (set) Token: 0x0600D031 RID: 53297 RVA: 0x000654D8 File Offset: 0x000636D8
			public unsafe Il2CppStructArray<SlotMachine.ESymbol> symbols
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.NativeFieldInfoPtr_symbols);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<SlotMachine.ESymbol>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.NativeFieldInfoPtr_symbols), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040A9 RID: 16553
			// (get) Token: 0x0600D032 RID: 53298 RVA: 0x0031F5D8 File Offset: 0x0031D7D8
			// (set) Token: 0x0600D033 RID: 53299 RVA: 0x000654F7 File Offset: 0x000636F7
			public unsafe int betAmount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.NativeFieldInfoPtr_betAmount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.NativeFieldInfoPtr_betAmount)) = value;
				}
			}

			// Token: 0x170040AA RID: 16554
			// (get) Token: 0x0600D034 RID: 53300 RVA: 0x0031F600 File Offset: 0x0031D800
			// (set) Token: 0x0600D035 RID: 53301 RVA: 0x00065512 File Offset: 0x00063712
			public unsafe NetworkConnection spinner
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.NativeFieldInfoPtr_spinner);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkConnection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.NativeFieldInfoPtr_spinner), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C82 RID: 35970
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008C83 RID: 35971
			private static readonly IntPtr NativeFieldInfoPtr_symbols;

			// Token: 0x04008C84 RID: 35972
			private static readonly IntPtr NativeFieldInfoPtr_betAmount;

			// Token: 0x04008C85 RID: 35973
			private static readonly IntPtr NativeFieldInfoPtr_spinner;

			// Token: 0x04008C86 RID: 35974
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C87 RID: 35975
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C5D RID: 3165
			[ObfuscatedName("ScheduleOne.Casino.SlotMachine+<>c__DisplayClass41_0+<<StartSpin>g__Spin|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E3E2 RID: 58338 RVA: 0x003577EC File Offset: 0x003559EC
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique()
				{
					Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0>.NativeClassPtr, "<<StartSpin>g__Spin|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr);
					SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr, "<>1__state");
					SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr, "<>2__current");
					SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr, "<>4__this");
					SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr__outcome_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr, "<outcome>5__2");
					SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr, "<i>5__3");
					SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr, 100676631);
					SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr, 100676632);
					SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr, 100676633);
					SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr, 100676634);
					SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr, 100676635);
					SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr, 100676636);
				}

				// Token: 0x0600E3E3 RID: 58339 RVA: 0x003578F4 File Offset: 0x00355AF4
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E3E4 RID: 58340 RVA: 0x0035793C File Offset: 0x00355B3C
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E3E5 RID: 58341 RVA: 0x00357970 File Offset: 0x00355B70
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211643, XrefRangeEnd = 211651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170046C0 RID: 18112
				// (get) Token: 0x0600E3E6 RID: 58342 RVA: 0x003579AC File Offset: 0x00355BAC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E3E7 RID: 58343 RVA: 0x003579EC File Offset: 0x00355BEC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211651, XrefRangeEnd = 211656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170046C1 RID: 18113
				// (get) Token: 0x0600E3E8 RID: 58344 RVA: 0x00357A20 File Offset: 0x00355C20
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E3E9 RID: 58345 RVA: 0x0006F14C File Offset: 0x0006D34C
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170046BB RID: 18107
				// (get) Token: 0x0600E3EA RID: 58346 RVA: 0x00357A60 File Offset: 0x00355C60
				// (set) Token: 0x0600E3EB RID: 58347 RVA: 0x0006F155 File Offset: 0x0006D355
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170046BC RID: 18108
				// (get) Token: 0x0600E3EC RID: 58348 RVA: 0x00357A88 File Offset: 0x00355C88
				// (set) Token: 0x0600E3ED RID: 58349 RVA: 0x0006F170 File Offset: 0x0006D370
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046BD RID: 18109
				// (get) Token: 0x0600E3EE RID: 58350 RVA: 0x00357AB8 File Offset: 0x00355CB8
				// (set) Token: 0x0600E3EF RID: 58351 RVA: 0x0006F18F File Offset: 0x0006D38F
				public unsafe SlotMachine.__c__DisplayClass41_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<SlotMachine.__c__DisplayClass41_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046BE RID: 18110
				// (get) Token: 0x0600E3F0 RID: 58352 RVA: 0x00357AE8 File Offset: 0x00355CE8
				// (set) Token: 0x0600E3F1 RID: 58353 RVA: 0x0006F1AE File Offset: 0x0006D3AE
				public unsafe SlotMachine.EOutcome _outcome_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr__outcome_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr__outcome_5__2)) = value;
					}
				}

				// Token: 0x170046BF RID: 18111
				// (get) Token: 0x0600E3F2 RID: 58354 RVA: 0x00357B10 File Offset: 0x00355D10
				// (set) Token: 0x0600E3F3 RID: 58355 RVA: 0x0006F1C9 File Offset: 0x0006D3C9
				public unsafe int _i_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr__i_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr__i_5__3)) = value;
					}
				}

				// Token: 0x04009879 RID: 39033
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400987A RID: 39034
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400987B RID: 39035
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400987C RID: 39036
				private static readonly IntPtr NativeFieldInfoPtr__outcome_5__2;

				// Token: 0x0400987D RID: 39037
				private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

				// Token: 0x0400987E RID: 39038
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400987F RID: 39039
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009880 RID: 39040
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009881 RID: 39041
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009882 RID: 39042
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009883 RID: 39043
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
