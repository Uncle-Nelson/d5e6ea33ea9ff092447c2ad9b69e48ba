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
using Il2CppScheduleOne.Misc;
using Il2CppScheduleOne.Trash;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x0200072B RID: 1835
	public class Recycler : NetworkBehaviour
	{
		// Token: 0x0600A5A8 RID: 42408 RVA: 0x00297714 File Offset: 0x00295914
		// Note: this type is marked as 'beforefieldinit'.
		static Recycler()
		{
			Il2CppClassPointerStore<Recycler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "Recycler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Recycler>.NativeClassPtr);
			Recycler.NativeFieldInfoPtr__State_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "<State>k__BackingField");
			Recycler.NativeFieldInfoPtr__IsHatchOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "<IsHatchOpen>k__BackingField");
			Recycler.NativeFieldInfoPtr_DetectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "DetectionMask");
			Recycler.NativeFieldInfoPtr_HandleIntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "HandleIntObj");
			Recycler.NativeFieldInfoPtr_ButtonIntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "ButtonIntObj");
			Recycler.NativeFieldInfoPtr_CashIntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "CashIntObj");
			Recycler.NativeFieldInfoPtr_ButtonLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "ButtonLight");
			Recycler.NativeFieldInfoPtr_ButtonAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "ButtonAnim");
			Recycler.NativeFieldInfoPtr_HatchAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "HatchAnim");
			Recycler.NativeFieldInfoPtr_CashAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "CashAnim");
			Recycler.NativeFieldInfoPtr_OpenHatchInstruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "OpenHatchInstruction");
			Recycler.NativeFieldInfoPtr_InsertTrashInstruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "InsertTrashInstruction");
			Recycler.NativeFieldInfoPtr_PressBeginInstruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "PressBeginInstruction");
			Recycler.NativeFieldInfoPtr_ProcessingScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "ProcessingScreen");
			Recycler.NativeFieldInfoPtr_ProcessingLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "ProcessingLabel");
			Recycler.NativeFieldInfoPtr_ValueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "ValueLabel");
			Recycler.NativeFieldInfoPtr_CheckCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "CheckCollider");
			Recycler.NativeFieldInfoPtr_Cash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "Cash");
			Recycler.NativeFieldInfoPtr_BankNote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "BankNote");
			Recycler.NativeFieldInfoPtr_OpenSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "OpenSound");
			Recycler.NativeFieldInfoPtr_CloseSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "CloseSound");
			Recycler.NativeFieldInfoPtr_PressSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "PressSound");
			Recycler.NativeFieldInfoPtr_DoneSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "DoneSound");
			Recycler.NativeFieldInfoPtr_CashEjectSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "CashEjectSound");
			Recycler.NativeFieldInfoPtr_cashValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "cashValue");
			Recycler.NativeFieldInfoPtr_onStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "onStart");
			Recycler.NativeFieldInfoPtr_onStop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "onStop");
			Recycler.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ObjectScripts.RecyclerAssembly-CSharp.dll_Excuted");
			Recycler.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ObjectScripts.RecyclerAssembly-CSharp.dll_Excuted");
			Recycler.NativeMethodInfoPtr_get_State_Public_get_EState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683556);
			Recycler.NativeMethodInfoPtr_set_State_Protected_set_Void_EState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683557);
			Recycler.NativeMethodInfoPtr_get_IsHatchOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683558);
			Recycler.NativeMethodInfoPtr_set_IsHatchOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683559);
			Recycler.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683560);
			Recycler.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683561);
			Recycler.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683562);
			Recycler.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683563);
			Recycler.NativeMethodInfoPtr_HandleInteracted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683564);
			Recycler.NativeMethodInfoPtr_ButtonInteracted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683565);
			Recycler.NativeMethodInfoPtr_CashInteracted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683566);
			Recycler.NativeMethodInfoPtr_SendCashCollected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683567);
			Recycler.NativeMethodInfoPtr_CashCollected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683568);
			Recycler.NativeMethodInfoPtr_EnableCash_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683569);
			Recycler.NativeMethodInfoPtr_SetCashValue_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683570);
			Recycler.NativeMethodInfoPtr_Process_Private_IEnumerator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683571);
			Recycler.NativeMethodInfoPtr_SendState_Public_Void_EState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683572);
			Recycler.NativeMethodInfoPtr_SetState_Private_Void_NetworkConnection_EState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683573);
			Recycler.NativeMethodInfoPtr_SetHatchOpen_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683574);
			Recycler.NativeMethodInfoPtr_GetTrash_Private_Il2CppReferenceArray_1_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683575);
			Recycler.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683576);
			Recycler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683577);
			Recycler.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683578);
			Recycler.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683579);
			Recycler.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683580);
			Recycler.NativeMethodInfoPtr_RpcWriter___Server_SendCashCollected_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683581);
			Recycler.NativeMethodInfoPtr_RpcLogic___SendCashCollected_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683582);
			Recycler.NativeMethodInfoPtr_RpcReader___Server_SendCashCollected_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683583);
			Recycler.NativeMethodInfoPtr_RpcWriter___Observers_CashCollected_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683584);
			Recycler.NativeMethodInfoPtr_RpcLogic___CashCollected_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683585);
			Recycler.NativeMethodInfoPtr_RpcReader___Observers_CashCollected_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683586);
			Recycler.NativeMethodInfoPtr_RpcWriter___Observers_EnableCash_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683587);
			Recycler.NativeMethodInfoPtr_RpcLogic___EnableCash_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683588);
			Recycler.NativeMethodInfoPtr_RpcReader___Observers_EnableCash_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683589);
			Recycler.NativeMethodInfoPtr_RpcWriter___Observers_SetCashValue_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683590);
			Recycler.NativeMethodInfoPtr_RpcLogic___SetCashValue_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683591);
			Recycler.NativeMethodInfoPtr_RpcReader___Observers_SetCashValue_431000436_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683592);
			Recycler.NativeMethodInfoPtr_RpcWriter___Server_SendState_3569965459_Private_Void_EState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683593);
			Recycler.NativeMethodInfoPtr_RpcLogic___SendState_3569965459_Public_Void_EState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683594);
			Recycler.NativeMethodInfoPtr_RpcReader___Server_SendState_3569965459_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683595);
			Recycler.NativeMethodInfoPtr_RpcWriter___Observers_SetState_3790170803_Private_Void_NetworkConnection_EState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683596);
			Recycler.NativeMethodInfoPtr_RpcLogic___SetState_3790170803_Private_Void_NetworkConnection_EState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683597);
			Recycler.NativeMethodInfoPtr_RpcReader___Observers_SetState_3790170803_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683598);
			Recycler.NativeMethodInfoPtr_RpcWriter___Target_SetState_3790170803_Private_Void_NetworkConnection_EState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683599);
			Recycler.NativeMethodInfoPtr_RpcReader___Target_SetState_3790170803_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683600);
			Recycler.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683601);
		}

		// Token: 0x1700333C RID: 13116
		// (get) Token: 0x0600A5A9 RID: 42409 RVA: 0x00297D20 File Offset: 0x00295F20
		// (set) Token: 0x0600A5AA RID: 42410 RVA: 0x00297D5C File Offset: 0x00295F5C
		public unsafe Recycler.EState State
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_get_State_Public_get_EState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_set_State_Protected_set_Void_EState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700333D RID: 13117
		// (get) Token: 0x0600A5AB RID: 42411 RVA: 0x00297D9C File Offset: 0x00295F9C
		// (set) Token: 0x0600A5AC RID: 42412 RVA: 0x00297DD8 File Offset: 0x00295FD8
		public unsafe bool IsHatchOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_get_IsHatchOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_set_IsHatchOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A5AD RID: 42413 RVA: 0x00297E18 File Offset: 0x00296018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289666, XrefRangeEnd = 289703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5AE RID: 42414 RVA: 0x00297E4C File Offset: 0x0029604C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289703, XrefRangeEnd = 289705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Recycler.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5AF RID: 42415 RVA: 0x00297E9C File Offset: 0x0029609C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289705, XrefRangeEnd = 289723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5B0 RID: 42416 RVA: 0x00297ED0 File Offset: 0x002960D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289723, XrefRangeEnd = 289734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5B1 RID: 42417 RVA: 0x00297F04 File Offset: 0x00296104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289734, XrefRangeEnd = 289735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleInteracted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_HandleInteracted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5B2 RID: 42418 RVA: 0x00297F38 File Offset: 0x00296138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289735, XrefRangeEnd = 289762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ButtonInteracted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_ButtonInteracted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5B3 RID: 42419 RVA: 0x00297F6C File Offset: 0x0029616C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289762, XrefRangeEnd = 289802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CashInteracted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_CashInteracted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5B4 RID: 42420 RVA: 0x00297FA0 File Offset: 0x002961A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289802, XrefRangeEnd = 289820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendCashCollected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_SendCashCollected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5B5 RID: 42421 RVA: 0x00297FD4 File Offset: 0x002961D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289820, XrefRangeEnd = 289842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CashCollected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_CashCollected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5B6 RID: 42422 RVA: 0x00298008 File Offset: 0x00296208
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 289861, RefRangeEnd = 289862, XrefRangeStart = 289842, XrefRangeEnd = 289861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableCash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_EnableCash_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5B7 RID: 42423 RVA: 0x0029803C File Offset: 0x0029623C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 289882, RefRangeEnd = 289883, XrefRangeStart = 289862, XrefRangeEnd = 289882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCashValue(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_SetCashValue_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5B8 RID: 42424 RVA: 0x0029807C File Offset: 0x0029627C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 289888, RefRangeEnd = 289890, XrefRangeStart = 289883, XrefRangeEnd = 289888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Process(bool startedByLocalPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref startedByLocalPlayer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_Process_Private_IEnumerator_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600A5B9 RID: 42425 RVA: 0x002980C8 File Offset: 0x002962C8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 289911, RefRangeEnd = 289919, XrefRangeStart = 289890, XrefRangeEnd = 289911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendState(Recycler.EState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_SendState_Public_Void_EState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5BA RID: 42426 RVA: 0x00298108 File Offset: 0x00296308
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 289963, RefRangeEnd = 289967, XrefRangeStart = 289919, XrefRangeEnd = 289963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetState(NetworkConnection conn, Recycler.EState state, bool force = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref force;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_SetState_Private_Void_NetworkConnection_EState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5BB RID: 42427 RVA: 0x00298168 File Offset: 0x00296368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289967, XrefRangeEnd = 289971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHatchOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_SetHatchOpen_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5BC RID: 42428 RVA: 0x002981A8 File Offset: 0x002963A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 290009, RefRangeEnd = 290011, XrefRangeStart = 289971, XrefRangeEnd = 290009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<TrashItem> GetTrash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_GetTrash_Private_Il2CppReferenceArray_1_TrashItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TrashItem>>(intPtr3) : null;
		}

		// Token: 0x0600A5BD RID: 42429 RVA: 0x002981E8 File Offset: 0x002963E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290011, XrefRangeEnd = 290019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5BE RID: 42430 RVA: 0x0029821C File Offset: 0x0029641C
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 134906, RefRangeEnd = 134928, XrefRangeStart = 134906, XrefRangeEnd = 134928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Recycler() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Recycler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5BF RID: 42431 RVA: 0x00298258 File Offset: 0x00296458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290019, XrefRangeEnd = 290063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Recycler.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5C0 RID: 42432 RVA: 0x00298294 File Offset: 0x00296494
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Recycler.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5C1 RID: 42433 RVA: 0x002982D0 File Offset: 0x002964D0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Recycler.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5C2 RID: 42434 RVA: 0x0029830C File Offset: 0x0029650C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendCashCollected_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcWriter___Server_SendCashCollected_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5C3 RID: 42435 RVA: 0x00298340 File Offset: 0x00296540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendCashCollected_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcLogic___SendCashCollected_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5C4 RID: 42436 RVA: 0x00298374 File Offset: 0x00296574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290063, XrefRangeEnd = 290086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendCashCollected_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcReader___Server_SendCashCollected_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5C5 RID: 42437 RVA: 0x002983D8 File Offset: 0x002965D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290086, XrefRangeEnd = 290104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_CashCollected_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcWriter___Observers_CashCollected_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5C6 RID: 42438 RVA: 0x0029840C File Offset: 0x0029660C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290104, XrefRangeEnd = 290107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___CashCollected_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcLogic___CashCollected_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5C7 RID: 42439 RVA: 0x00298440 File Offset: 0x00296640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290107, XrefRangeEnd = 290112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_CashCollected_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcReader___Observers_CashCollected_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5C8 RID: 42440 RVA: 0x00298490 File Offset: 0x00296690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290112, XrefRangeEnd = 290130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_EnableCash_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcWriter___Observers_EnableCash_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5C9 RID: 42441 RVA: 0x002984C4 File Offset: 0x002966C4
		[CallerCount(0)]
		public unsafe void RpcLogic___EnableCash_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcLogic___EnableCash_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5CA RID: 42442 RVA: 0x002984F8 File Offset: 0x002966F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290130, XrefRangeEnd = 290132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_EnableCash_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcReader___Observers_EnableCash_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5CB RID: 42443 RVA: 0x00298548 File Offset: 0x00296748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290132, XrefRangeEnd = 290151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetCashValue_431000436(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcWriter___Observers_SetCashValue_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5CC RID: 42444 RVA: 0x00298588 File Offset: 0x00296788
		[CallerCount(0)]
		public unsafe void RpcLogic___SetCashValue_431000436(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcLogic___SetCashValue_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5CD RID: 42445 RVA: 0x002985C8 File Offset: 0x002967C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290151, XrefRangeEnd = 290154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetCashValue_431000436(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcReader___Observers_SetCashValue_431000436_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5CE RID: 42446 RVA: 0x00298618 File Offset: 0x00296818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290154, XrefRangeEnd = 290173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendState_3569965459(Recycler.EState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcWriter___Server_SendState_3569965459_Private_Void_EState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5CF RID: 42447 RVA: 0x00298658 File Offset: 0x00296858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290173, XrefRangeEnd = 290174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendState_3569965459(Recycler.EState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcLogic___SendState_3569965459_Public_Void_EState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5D0 RID: 42448 RVA: 0x00298698 File Offset: 0x00296898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290174, XrefRangeEnd = 290178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendState_3569965459(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcReader___Server_SendState_3569965459_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5D1 RID: 42449 RVA: 0x002986FC File Offset: 0x002968FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290178, XrefRangeEnd = 290198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetState_3790170803(NetworkConnection conn, Recycler.EState state, bool force = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref force;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcWriter___Observers_SetState_3790170803_Private_Void_NetworkConnection_EState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5D2 RID: 42450 RVA: 0x0029875C File Offset: 0x0029695C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 290217, RefRangeEnd = 290220, XrefRangeStart = 290198, XrefRangeEnd = 290217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetState_3790170803(NetworkConnection conn, Recycler.EState state, bool force = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref force;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcLogic___SetState_3790170803_Private_Void_NetworkConnection_EState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5D3 RID: 42451 RVA: 0x002987BC File Offset: 0x002969BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290220, XrefRangeEnd = 290224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetState_3790170803(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcReader___Observers_SetState_3790170803_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5D4 RID: 42452 RVA: 0x0029880C File Offset: 0x00296A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290224, XrefRangeEnd = 290235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetState_3790170803(NetworkConnection conn, Recycler.EState state, bool force = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref force;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcWriter___Target_SetState_3790170803_Private_Void_NetworkConnection_EState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5D5 RID: 42453 RVA: 0x0029886C File Offset: 0x00296A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290235, XrefRangeEnd = 290239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetState_3790170803(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcReader___Target_SetState_3790170803_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5D6 RID: 42454 RVA: 0x002988BC File Offset: 0x00296ABC
		[CallerCount(0)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Recycler.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5D7 RID: 42455 RVA: 0x000519E3 File Offset: 0x0004FBE3
		public Recycler(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700331F RID: 13087
		// (get) Token: 0x0600A5D8 RID: 42456 RVA: 0x002988F8 File Offset: 0x00296AF8
		// (set) Token: 0x0600A5D9 RID: 42457 RVA: 0x000519EC File Offset: 0x0004FBEC
		public unsafe Recycler.EState _State_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr__State_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr__State_k__BackingField)) = value;
			}
		}

		// Token: 0x17003320 RID: 13088
		// (get) Token: 0x0600A5DA RID: 42458 RVA: 0x00298920 File Offset: 0x00296B20
		// (set) Token: 0x0600A5DB RID: 42459 RVA: 0x00051A07 File Offset: 0x0004FC07
		public unsafe bool _IsHatchOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr__IsHatchOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr__IsHatchOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17003321 RID: 13089
		// (get) Token: 0x0600A5DC RID: 42460 RVA: 0x00298948 File Offset: 0x00296B48
		// (set) Token: 0x0600A5DD RID: 42461 RVA: 0x00051A22 File Offset: 0x0004FC22
		public unsafe LayerMask DetectionMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_DetectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_DetectionMask)) = value;
			}
		}

		// Token: 0x17003322 RID: 13090
		// (get) Token: 0x0600A5DE RID: 42462 RVA: 0x00298970 File Offset: 0x00296B70
		// (set) Token: 0x0600A5DF RID: 42463 RVA: 0x00051A3D File Offset: 0x0004FC3D
		public unsafe InteractableObject HandleIntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_HandleIntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_HandleIntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003323 RID: 13091
		// (get) Token: 0x0600A5E0 RID: 42464 RVA: 0x002989A0 File Offset: 0x00296BA0
		// (set) Token: 0x0600A5E1 RID: 42465 RVA: 0x00051A5C File Offset: 0x0004FC5C
		public unsafe InteractableObject ButtonIntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_ButtonIntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_ButtonIntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003324 RID: 13092
		// (get) Token: 0x0600A5E2 RID: 42466 RVA: 0x002989D0 File Offset: 0x00296BD0
		// (set) Token: 0x0600A5E3 RID: 42467 RVA: 0x00051A7B File Offset: 0x0004FC7B
		public unsafe InteractableObject CashIntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_CashIntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_CashIntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003325 RID: 13093
		// (get) Token: 0x0600A5E4 RID: 42468 RVA: 0x00298A00 File Offset: 0x00296C00
		// (set) Token: 0x0600A5E5 RID: 42469 RVA: 0x00051A9A File Offset: 0x0004FC9A
		public unsafe ToggleableLight ButtonLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_ButtonLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ToggleableLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_ButtonLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003326 RID: 13094
		// (get) Token: 0x0600A5E6 RID: 42470 RVA: 0x00298A30 File Offset: 0x00296C30
		// (set) Token: 0x0600A5E7 RID: 42471 RVA: 0x00051AB9 File Offset: 0x0004FCB9
		public unsafe Animation ButtonAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_ButtonAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_ButtonAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003327 RID: 13095
		// (get) Token: 0x0600A5E8 RID: 42472 RVA: 0x00298A60 File Offset: 0x00296C60
		// (set) Token: 0x0600A5E9 RID: 42473 RVA: 0x00051AD8 File Offset: 0x0004FCD8
		public unsafe Animation HatchAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_HatchAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_HatchAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003328 RID: 13096
		// (get) Token: 0x0600A5EA RID: 42474 RVA: 0x00298A90 File Offset: 0x00296C90
		// (set) Token: 0x0600A5EB RID: 42475 RVA: 0x00051AF7 File Offset: 0x0004FCF7
		public unsafe Animation CashAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_CashAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_CashAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003329 RID: 13097
		// (get) Token: 0x0600A5EC RID: 42476 RVA: 0x00298AC0 File Offset: 0x00296CC0
		// (set) Token: 0x0600A5ED RID: 42477 RVA: 0x00051B16 File Offset: 0x0004FD16
		public unsafe RectTransform OpenHatchInstruction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_OpenHatchInstruction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_OpenHatchInstruction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700332A RID: 13098
		// (get) Token: 0x0600A5EE RID: 42478 RVA: 0x00298AF0 File Offset: 0x00296CF0
		// (set) Token: 0x0600A5EF RID: 42479 RVA: 0x00051B35 File Offset: 0x0004FD35
		public unsafe RectTransform InsertTrashInstruction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_InsertTrashInstruction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_InsertTrashInstruction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700332B RID: 13099
		// (get) Token: 0x0600A5F0 RID: 42480 RVA: 0x00298B20 File Offset: 0x00296D20
		// (set) Token: 0x0600A5F1 RID: 42481 RVA: 0x00051B54 File Offset: 0x0004FD54
		public unsafe RectTransform PressBeginInstruction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_PressBeginInstruction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_PressBeginInstruction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700332C RID: 13100
		// (get) Token: 0x0600A5F2 RID: 42482 RVA: 0x00298B50 File Offset: 0x00296D50
		// (set) Token: 0x0600A5F3 RID: 42483 RVA: 0x00051B73 File Offset: 0x0004FD73
		public unsafe RectTransform ProcessingScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_ProcessingScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_ProcessingScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700332D RID: 13101
		// (get) Token: 0x0600A5F4 RID: 42484 RVA: 0x00298B80 File Offset: 0x00296D80
		// (set) Token: 0x0600A5F5 RID: 42485 RVA: 0x00051B92 File Offset: 0x0004FD92
		public unsafe TextMeshProUGUI ProcessingLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_ProcessingLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_ProcessingLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700332E RID: 13102
		// (get) Token: 0x0600A5F6 RID: 42486 RVA: 0x00298BB0 File Offset: 0x00296DB0
		// (set) Token: 0x0600A5F7 RID: 42487 RVA: 0x00051BB1 File Offset: 0x0004FDB1
		public unsafe TextMeshProUGUI ValueLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_ValueLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_ValueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700332F RID: 13103
		// (get) Token: 0x0600A5F8 RID: 42488 RVA: 0x00298BE0 File Offset: 0x00296DE0
		// (set) Token: 0x0600A5F9 RID: 42489 RVA: 0x00051BD0 File Offset: 0x0004FDD0
		public unsafe BoxCollider CheckCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_CheckCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_CheckCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003330 RID: 13104
		// (get) Token: 0x0600A5FA RID: 42490 RVA: 0x00298C10 File Offset: 0x00296E10
		// (set) Token: 0x0600A5FB RID: 42491 RVA: 0x00051BEF File Offset: 0x0004FDEF
		public unsafe Transform Cash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_Cash);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_Cash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003331 RID: 13105
		// (get) Token: 0x0600A5FC RID: 42492 RVA: 0x00298C40 File Offset: 0x00296E40
		// (set) Token: 0x0600A5FD RID: 42493 RVA: 0x00051C0E File Offset: 0x0004FE0E
		public unsafe GameObject BankNote
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_BankNote);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_BankNote), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003332 RID: 13106
		// (get) Token: 0x0600A5FE RID: 42494 RVA: 0x00298C70 File Offset: 0x00296E70
		// (set) Token: 0x0600A5FF RID: 42495 RVA: 0x00051C2D File Offset: 0x0004FE2D
		public unsafe AudioSourceController OpenSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_OpenSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_OpenSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003333 RID: 13107
		// (get) Token: 0x0600A600 RID: 42496 RVA: 0x00298CA0 File Offset: 0x00296EA0
		// (set) Token: 0x0600A601 RID: 42497 RVA: 0x00051C4C File Offset: 0x0004FE4C
		public unsafe AudioSourceController CloseSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_CloseSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_CloseSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003334 RID: 13108
		// (get) Token: 0x0600A602 RID: 42498 RVA: 0x00298CD0 File Offset: 0x00296ED0
		// (set) Token: 0x0600A603 RID: 42499 RVA: 0x00051C6B File Offset: 0x0004FE6B
		public unsafe AudioSourceController PressSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_PressSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_PressSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003335 RID: 13109
		// (get) Token: 0x0600A604 RID: 42500 RVA: 0x00298D00 File Offset: 0x00296F00
		// (set) Token: 0x0600A605 RID: 42501 RVA: 0x00051C8A File Offset: 0x0004FE8A
		public unsafe AudioSourceController DoneSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_DoneSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_DoneSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003336 RID: 13110
		// (get) Token: 0x0600A606 RID: 42502 RVA: 0x00298D30 File Offset: 0x00296F30
		// (set) Token: 0x0600A607 RID: 42503 RVA: 0x00051CA9 File Offset: 0x0004FEA9
		public unsafe AudioSourceController CashEjectSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_CashEjectSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_CashEjectSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003337 RID: 13111
		// (get) Token: 0x0600A608 RID: 42504 RVA: 0x00298D60 File Offset: 0x00296F60
		// (set) Token: 0x0600A609 RID: 42505 RVA: 0x00051CC8 File Offset: 0x0004FEC8
		public unsafe float cashValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_cashValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_cashValue)) = value;
			}
		}

		// Token: 0x17003338 RID: 13112
		// (get) Token: 0x0600A60A RID: 42506 RVA: 0x00298D88 File Offset: 0x00296F88
		// (set) Token: 0x0600A60B RID: 42507 RVA: 0x00051CE3 File Offset: 0x0004FEE3
		public unsafe UnityEvent onStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_onStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_onStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003339 RID: 13113
		// (get) Token: 0x0600A60C RID: 42508 RVA: 0x00298DB8 File Offset: 0x00296FB8
		// (set) Token: 0x0600A60D RID: 42509 RVA: 0x00051D02 File Offset: 0x0004FF02
		public unsafe UnityEvent onStop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_onStop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_onStop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700333A RID: 13114
		// (get) Token: 0x0600A60E RID: 42510 RVA: 0x00298DE8 File Offset: 0x00296FE8
		// (set) Token: 0x0600A60F RID: 42511 RVA: 0x00051D21 File Offset: 0x0004FF21
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700333B RID: 13115
		// (get) Token: 0x0600A610 RID: 42512 RVA: 0x00298E10 File Offset: 0x00297010
		// (set) Token: 0x0600A611 RID: 42513 RVA: 0x00051D3C File Offset: 0x0004FF3C
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04006F12 RID: 28434
		private static readonly IntPtr NativeFieldInfoPtr__State_k__BackingField;

		// Token: 0x04006F13 RID: 28435
		private static readonly IntPtr NativeFieldInfoPtr__IsHatchOpen_k__BackingField;

		// Token: 0x04006F14 RID: 28436
		private static readonly IntPtr NativeFieldInfoPtr_DetectionMask;

		// Token: 0x04006F15 RID: 28437
		private static readonly IntPtr NativeFieldInfoPtr_HandleIntObj;

		// Token: 0x04006F16 RID: 28438
		private static readonly IntPtr NativeFieldInfoPtr_ButtonIntObj;

		// Token: 0x04006F17 RID: 28439
		private static readonly IntPtr NativeFieldInfoPtr_CashIntObj;

		// Token: 0x04006F18 RID: 28440
		private static readonly IntPtr NativeFieldInfoPtr_ButtonLight;

		// Token: 0x04006F19 RID: 28441
		private static readonly IntPtr NativeFieldInfoPtr_ButtonAnim;

		// Token: 0x04006F1A RID: 28442
		private static readonly IntPtr NativeFieldInfoPtr_HatchAnim;

		// Token: 0x04006F1B RID: 28443
		private static readonly IntPtr NativeFieldInfoPtr_CashAnim;

		// Token: 0x04006F1C RID: 28444
		private static readonly IntPtr NativeFieldInfoPtr_OpenHatchInstruction;

		// Token: 0x04006F1D RID: 28445
		private static readonly IntPtr NativeFieldInfoPtr_InsertTrashInstruction;

		// Token: 0x04006F1E RID: 28446
		private static readonly IntPtr NativeFieldInfoPtr_PressBeginInstruction;

		// Token: 0x04006F1F RID: 28447
		private static readonly IntPtr NativeFieldInfoPtr_ProcessingScreen;

		// Token: 0x04006F20 RID: 28448
		private static readonly IntPtr NativeFieldInfoPtr_ProcessingLabel;

		// Token: 0x04006F21 RID: 28449
		private static readonly IntPtr NativeFieldInfoPtr_ValueLabel;

		// Token: 0x04006F22 RID: 28450
		private static readonly IntPtr NativeFieldInfoPtr_CheckCollider;

		// Token: 0x04006F23 RID: 28451
		private static readonly IntPtr NativeFieldInfoPtr_Cash;

		// Token: 0x04006F24 RID: 28452
		private static readonly IntPtr NativeFieldInfoPtr_BankNote;

		// Token: 0x04006F25 RID: 28453
		private static readonly IntPtr NativeFieldInfoPtr_OpenSound;

		// Token: 0x04006F26 RID: 28454
		private static readonly IntPtr NativeFieldInfoPtr_CloseSound;

		// Token: 0x04006F27 RID: 28455
		private static readonly IntPtr NativeFieldInfoPtr_PressSound;

		// Token: 0x04006F28 RID: 28456
		private static readonly IntPtr NativeFieldInfoPtr_DoneSound;

		// Token: 0x04006F29 RID: 28457
		private static readonly IntPtr NativeFieldInfoPtr_CashEjectSound;

		// Token: 0x04006F2A RID: 28458
		private static readonly IntPtr NativeFieldInfoPtr_cashValue;

		// Token: 0x04006F2B RID: 28459
		private static readonly IntPtr NativeFieldInfoPtr_onStart;

		// Token: 0x04006F2C RID: 28460
		private static readonly IntPtr NativeFieldInfoPtr_onStop;

		// Token: 0x04006F2D RID: 28461
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04006F2E RID: 28462
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04006F2F RID: 28463
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_get_EState_0;

		// Token: 0x04006F30 RID: 28464
		private static readonly IntPtr NativeMethodInfoPtr_set_State_Protected_set_Void_EState_0;

		// Token: 0x04006F31 RID: 28465
		private static readonly IntPtr NativeMethodInfoPtr_get_IsHatchOpen_Public_get_Boolean_0;

		// Token: 0x04006F32 RID: 28466
		private static readonly IntPtr NativeMethodInfoPtr_set_IsHatchOpen_Private_set_Void_Boolean_0;

		// Token: 0x04006F33 RID: 28467
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04006F34 RID: 28468
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04006F35 RID: 28469
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04006F36 RID: 28470
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x04006F37 RID: 28471
		private static readonly IntPtr NativeMethodInfoPtr_HandleInteracted_Public_Void_0;

		// Token: 0x04006F38 RID: 28472
		private static readonly IntPtr NativeMethodInfoPtr_ButtonInteracted_Public_Void_0;

		// Token: 0x04006F39 RID: 28473
		private static readonly IntPtr NativeMethodInfoPtr_CashInteracted_Public_Void_0;

		// Token: 0x04006F3A RID: 28474
		private static readonly IntPtr NativeMethodInfoPtr_SendCashCollected_Private_Void_0;

		// Token: 0x04006F3B RID: 28475
		private static readonly IntPtr NativeMethodInfoPtr_CashCollected_Private_Void_0;

		// Token: 0x04006F3C RID: 28476
		private static readonly IntPtr NativeMethodInfoPtr_EnableCash_Private_Void_0;

		// Token: 0x04006F3D RID: 28477
		private static readonly IntPtr NativeMethodInfoPtr_SetCashValue_Private_Void_Single_0;

		// Token: 0x04006F3E RID: 28478
		private static readonly IntPtr NativeMethodInfoPtr_Process_Private_IEnumerator_Boolean_0;

		// Token: 0x04006F3F RID: 28479
		private static readonly IntPtr NativeMethodInfoPtr_SendState_Public_Void_EState_0;

		// Token: 0x04006F40 RID: 28480
		private static readonly IntPtr NativeMethodInfoPtr_SetState_Private_Void_NetworkConnection_EState_Boolean_0;

		// Token: 0x04006F41 RID: 28481
		private static readonly IntPtr NativeMethodInfoPtr_SetHatchOpen_Private_Void_Boolean_0;

		// Token: 0x04006F42 RID: 28482
		private static readonly IntPtr NativeMethodInfoPtr_GetTrash_Private_Il2CppReferenceArray_1_TrashItem_0;

		// Token: 0x04006F43 RID: 28483
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04006F44 RID: 28484
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006F45 RID: 28485
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04006F46 RID: 28486
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04006F47 RID: 28487
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04006F48 RID: 28488
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendCashCollected_2166136261_Private_Void_0;

		// Token: 0x04006F49 RID: 28489
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendCashCollected_2166136261_Private_Void_0;

		// Token: 0x04006F4A RID: 28490
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendCashCollected_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04006F4B RID: 28491
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_CashCollected_2166136261_Private_Void_0;

		// Token: 0x04006F4C RID: 28492
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___CashCollected_2166136261_Private_Void_0;

		// Token: 0x04006F4D RID: 28493
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_CashCollected_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006F4E RID: 28494
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_EnableCash_2166136261_Private_Void_0;

		// Token: 0x04006F4F RID: 28495
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___EnableCash_2166136261_Private_Void_0;

		// Token: 0x04006F50 RID: 28496
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_EnableCash_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006F51 RID: 28497
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetCashValue_431000436_Private_Void_Single_0;

		// Token: 0x04006F52 RID: 28498
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetCashValue_431000436_Private_Void_Single_0;

		// Token: 0x04006F53 RID: 28499
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetCashValue_431000436_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006F54 RID: 28500
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendState_3569965459_Private_Void_EState_0;

		// Token: 0x04006F55 RID: 28501
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendState_3569965459_Public_Void_EState_0;

		// Token: 0x04006F56 RID: 28502
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendState_3569965459_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04006F57 RID: 28503
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetState_3790170803_Private_Void_NetworkConnection_EState_Boolean_0;

		// Token: 0x04006F58 RID: 28504
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetState_3790170803_Private_Void_NetworkConnection_EState_Boolean_0;

		// Token: 0x04006F59 RID: 28505
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetState_3790170803_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006F5A RID: 28506
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetState_3790170803_Private_Void_NetworkConnection_EState_Boolean_0;

		// Token: 0x04006F5B RID: 28507
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetState_3790170803_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006F5C RID: 28508
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000BCF RID: 3023
		[OriginalName("Assembly-CSharp.dll", "", "EState")]
		public enum EState
		{
			// Token: 0x040094DB RID: 38107
			HatchClosed,
			// Token: 0x040094DC RID: 38108
			HatchOpen,
			// Token: 0x040094DD RID: 38109
			Processing
		}

		// Token: 0x02000BD0 RID: 3024
		[ObfuscatedName("ScheduleOne.ObjectScripts.Recycler+<Process>d__45")]
		public sealed class _Process_d__45 : Il2CppSystem.Object
		{
			// Token: 0x0600DE53 RID: 56915 RVA: 0x00347460 File Offset: 0x00345660
			// Note: this type is marked as 'beforefieldinit'.
			static _Process_d__45()
			{
				Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "<Process>d__45");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr);
				Recycler._Process_d__45.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, "<>1__state");
				Recycler._Process_d__45.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, "<>2__current");
				Recycler._Process_d__45.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, "<>4__this");
				Recycler._Process_d__45.NativeFieldInfoPtr_startedByLocalPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, "startedByLocalPlayer");
				Recycler._Process_d__45.NativeFieldInfoPtr__value_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, "<value>5__2");
				Recycler._Process_d__45.NativeFieldInfoPtr__lerpTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, "<lerpTime>5__3");
				Recycler._Process_d__45.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, "<i>5__4");
				Recycler._Process_d__45.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, 100683602);
				Recycler._Process_d__45.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, 100683603);
				Recycler._Process_d__45.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, 100683604);
				Recycler._Process_d__45.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, 100683605);
				Recycler._Process_d__45.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, 100683606);
				Recycler._Process_d__45.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, 100683607);
			}

			// Token: 0x0600DE54 RID: 56916 RVA: 0x00347590 File Offset: 0x00345790
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Process_d__45(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler._Process_d__45.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE55 RID: 56917 RVA: 0x003475D8 File Offset: 0x003457D8
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler._Process_d__45.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE56 RID: 56918 RVA: 0x0034760C File Offset: 0x0034580C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289587, XrefRangeEnd = 289661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler._Process_d__45.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170044EE RID: 17646
			// (get) Token: 0x0600DE57 RID: 56919 RVA: 0x00347648 File Offset: 0x00345848
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler._Process_d__45.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DE58 RID: 56920 RVA: 0x00347688 File Offset: 0x00345888
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289661, XrefRangeEnd = 289666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler._Process_d__45.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170044EF RID: 17647
			// (get) Token: 0x0600DE59 RID: 56921 RVA: 0x003476BC File Offset: 0x003458BC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler._Process_d__45.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DE5A RID: 56922 RVA: 0x0006C64D File Offset: 0x0006A84D
			public _Process_d__45(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044E7 RID: 17639
			// (get) Token: 0x0600DE5B RID: 56923 RVA: 0x003476FC File Offset: 0x003458FC
			// (set) Token: 0x0600DE5C RID: 56924 RVA: 0x0006C656 File Offset: 0x0006A856
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170044E8 RID: 17640
			// (get) Token: 0x0600DE5D RID: 56925 RVA: 0x00347724 File Offset: 0x00345924
			// (set) Token: 0x0600DE5E RID: 56926 RVA: 0x0006C671 File Offset: 0x0006A871
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044E9 RID: 17641
			// (get) Token: 0x0600DE5F RID: 56927 RVA: 0x00347754 File Offset: 0x00345954
			// (set) Token: 0x0600DE60 RID: 56928 RVA: 0x0006C690 File Offset: 0x0006A890
			public unsafe Recycler __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Recycler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044EA RID: 17642
			// (get) Token: 0x0600DE61 RID: 56929 RVA: 0x00347784 File Offset: 0x00345984
			// (set) Token: 0x0600DE62 RID: 56930 RVA: 0x0006C6AF File Offset: 0x0006A8AF
			public unsafe bool startedByLocalPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr_startedByLocalPlayer);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr_startedByLocalPlayer)) = value;
				}
			}

			// Token: 0x170044EB RID: 17643
			// (get) Token: 0x0600DE63 RID: 56931 RVA: 0x003477AC File Offset: 0x003459AC
			// (set) Token: 0x0600DE64 RID: 56932 RVA: 0x0006C6CA File Offset: 0x0006A8CA
			public unsafe float _value_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr__value_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr__value_5__2)) = value;
				}
			}

			// Token: 0x170044EC RID: 17644
			// (get) Token: 0x0600DE65 RID: 56933 RVA: 0x003477D4 File Offset: 0x003459D4
			// (set) Token: 0x0600DE66 RID: 56934 RVA: 0x0006C6E5 File Offset: 0x0006A8E5
			public unsafe float _lerpTime_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr__lerpTime_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr__lerpTime_5__3)) = value;
				}
			}

			// Token: 0x170044ED RID: 17645
			// (get) Token: 0x0600DE67 RID: 56935 RVA: 0x003477FC File Offset: 0x003459FC
			// (set) Token: 0x0600DE68 RID: 56936 RVA: 0x0006C700 File Offset: 0x0006A900
			public unsafe float _i_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr__i_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr__i_5__4)) = value;
				}
			}

			// Token: 0x040094DE RID: 38110
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040094DF RID: 38111
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040094E0 RID: 38112
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040094E1 RID: 38113
			private static readonly IntPtr NativeFieldInfoPtr_startedByLocalPlayer;

			// Token: 0x040094E2 RID: 38114
			private static readonly IntPtr NativeFieldInfoPtr__value_5__2;

			// Token: 0x040094E3 RID: 38115
			private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__3;

			// Token: 0x040094E4 RID: 38116
			private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

			// Token: 0x040094E5 RID: 38117
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040094E6 RID: 38118
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040094E7 RID: 38119
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040094E8 RID: 38120
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040094E9 RID: 38121
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040094EA RID: 38122
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
