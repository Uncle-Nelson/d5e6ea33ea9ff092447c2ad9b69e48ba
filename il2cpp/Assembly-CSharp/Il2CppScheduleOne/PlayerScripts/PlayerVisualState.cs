using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x020003EB RID: 1003
	public class PlayerVisualState : NetworkBehaviour
	{
		// Token: 0x06005231 RID: 21041 RVA: 0x00185574 File Offset: 0x00183774
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerVisualState()
		{
			Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "PlayerVisualState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr);
			PlayerVisualState.NativeFieldInfoPtr_Suspiciousness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, "Suspiciousness");
			PlayerVisualState.NativeFieldInfoPtr_visualStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, "visualStates");
			PlayerVisualState.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, "player");
			PlayerVisualState.NativeFieldInfoPtr_removalRoutinesDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, "removalRoutinesDict");
			PlayerVisualState.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.PlayerScripts.PlayerVisualStateAssembly-CSharp.dll_Excuted");
			PlayerVisualState.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.PlayerScripts.PlayerVisualStateAssembly-CSharp.dll_Excuted");
			PlayerVisualState.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673588);
			PlayerVisualState.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673589);
			PlayerVisualState.NativeMethodInfoPtr_ApplyState_Public_Void_String_EVisualState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673590);
			PlayerVisualState.NativeMethodInfoPtr_RemoveState_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673591);
			PlayerVisualState.NativeMethodInfoPtr_GetState_Public_VisualState_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673592);
			PlayerVisualState.NativeMethodInfoPtr_ClearStates_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673593);
			PlayerVisualState.NativeMethodInfoPtr_UpdateSuspiciousness_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673594);
			PlayerVisualState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673595);
			PlayerVisualState.NativeMethodInfoPtr__Awake_b__6_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673596);
			PlayerVisualState.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673597);
			PlayerVisualState.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673598);
			PlayerVisualState.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673599);
			PlayerVisualState.NativeMethodInfoPtr_RpcWriter___Server_ApplyState_868472085_Private_Void_String_EVisualState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673600);
			PlayerVisualState.NativeMethodInfoPtr_RpcLogic___ApplyState_868472085_Public_Void_String_EVisualState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673601);
			PlayerVisualState.NativeMethodInfoPtr_RpcReader___Server_ApplyState_868472085_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673602);
			PlayerVisualState.NativeMethodInfoPtr_RpcWriter___Server_RemoveState_606697822_Private_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673603);
			PlayerVisualState.NativeMethodInfoPtr_RpcLogic___RemoveState_606697822_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673604);
			PlayerVisualState.NativeMethodInfoPtr_RpcReader___Server_RemoveState_606697822_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673605);
			PlayerVisualState.NativeMethodInfoPtr_Method_Private_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673606);
		}

		// Token: 0x06005232 RID: 21042 RVA: 0x00185798 File Offset: 0x00183998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177623, XrefRangeEnd = 177639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerVisualState.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005233 RID: 21043 RVA: 0x001857D4 File Offset: 0x001839D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177639, XrefRangeEnd = 177667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005234 RID: 21044 RVA: 0x00185808 File Offset: 0x00183A08
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 177669, RefRangeEnd = 177675, XrefRangeStart = 177667, XrefRangeEnd = 177669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyState(string label, PlayerVisualState.EVisualState state, float autoRemoveAfter = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoRemoveAfter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.NativeMethodInfoPtr_ApplyState_Public_Void_String_EVisualState_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005235 RID: 21045 RVA: 0x00185868 File Offset: 0x00183A68
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 177677, RefRangeEnd = 177680, XrefRangeStart = 177675, XrefRangeEnd = 177677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveState(string label, float delay = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.NativeMethodInfoPtr_RemoveState_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005236 RID: 21046 RVA: 0x001858B8 File Offset: 0x00183AB8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 177695, RefRangeEnd = 177699, XrefRangeStart = 177680, XrefRangeEnd = 177695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerVisualState.VisualState GetState(string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.NativeMethodInfoPtr_GetState_Public_VisualState_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerVisualState.VisualState>(intPtr3) : null;
		}

		// Token: 0x06005237 RID: 21047 RVA: 0x00185908 File Offset: 0x00183B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177699, XrefRangeEnd = 177708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearStates()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.NativeMethodInfoPtr_ClearStates_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005238 RID: 21048 RVA: 0x0018593C File Offset: 0x00183B3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 177722, RefRangeEnd = 177723, XrefRangeStart = 177708, XrefRangeEnd = 177722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSuspiciousness()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.NativeMethodInfoPtr_UpdateSuspiciousness_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005239 RID: 21049 RVA: 0x00185970 File Offset: 0x00183B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177723, XrefRangeEnd = 177738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerVisualState() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600523A RID: 21050 RVA: 0x001859AC File Offset: 0x00183BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__6_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.NativeMethodInfoPtr__Awake_b__6_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600523B RID: 21051 RVA: 0x001859E0 File Offset: 0x00183BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177738, XrefRangeEnd = 177751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerVisualState.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600523C RID: 21052 RVA: 0x00185A1C File Offset: 0x00183C1C
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerVisualState.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600523D RID: 21053 RVA: 0x00185A58 File Offset: 0x00183C58
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerVisualState.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600523E RID: 21054 RVA: 0x00185A94 File Offset: 0x00183C94
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 177765, RefRangeEnd = 177770, XrefRangeStart = 177751, XrefRangeEnd = 177765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ApplyState_868472085(string label, PlayerVisualState.EVisualState state, float autoRemoveAfter = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoRemoveAfter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.NativeMethodInfoPtr_RpcWriter___Server_ApplyState_868472085_Private_Void_String_EVisualState_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600523F RID: 21055 RVA: 0x00185AF4 File Offset: 0x00183CF4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 177797, RefRangeEnd = 177803, XrefRangeStart = 177770, XrefRangeEnd = 177797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ApplyState_868472085(string label, PlayerVisualState.EVisualState state, float autoRemoveAfter = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoRemoveAfter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.NativeMethodInfoPtr_RpcLogic___ApplyState_868472085_Public_Void_String_EVisualState_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005240 RID: 21056 RVA: 0x00185B54 File Offset: 0x00183D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177803, XrefRangeEnd = 177810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ApplyState_868472085(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.NativeMethodInfoPtr_RpcReader___Server_ApplyState_868472085_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005241 RID: 21057 RVA: 0x00185BB8 File Offset: 0x00183DB8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 177840, RefRangeEnd = 177847, XrefRangeStart = 177810, XrefRangeEnd = 177840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_RemoveState_606697822(string label, float delay = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.NativeMethodInfoPtr_RpcWriter___Server_RemoveState_606697822_Private_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005242 RID: 21058 RVA: 0x00185C08 File Offset: 0x00183E08
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 177861, RefRangeEnd = 177869, XrefRangeStart = 177847, XrefRangeEnd = 177861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RemoveState_606697822(string label, float delay = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.NativeMethodInfoPtr_RpcLogic___RemoveState_606697822_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005243 RID: 21059 RVA: 0x00185C58 File Offset: 0x00183E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177869, XrefRangeEnd = 177875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_RemoveState_606697822(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.NativeMethodInfoPtr_RpcReader___Server_RemoveState_606697822_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005244 RID: 21060 RVA: 0x00185CBC File Offset: 0x00183EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177875, XrefRangeEnd = 177890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.NativeMethodInfoPtr_Method_Private_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005245 RID: 21061 RVA: 0x00027214 File Offset: 0x00025414
		public PlayerVisualState(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170018BC RID: 6332
		// (get) Token: 0x06005246 RID: 21062 RVA: 0x00185CF0 File Offset: 0x00183EF0
		// (set) Token: 0x06005247 RID: 21063 RVA: 0x0002721D File Offset: 0x0002541D
		public unsafe float Suspiciousness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.NativeFieldInfoPtr_Suspiciousness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.NativeFieldInfoPtr_Suspiciousness)) = value;
			}
		}

		// Token: 0x170018BD RID: 6333
		// (get) Token: 0x06005248 RID: 21064 RVA: 0x00185D18 File Offset: 0x00183F18
		// (set) Token: 0x06005249 RID: 21065 RVA: 0x00027238 File Offset: 0x00025438
		public unsafe List<PlayerVisualState.VisualState> visualStates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.NativeFieldInfoPtr_visualStates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayerVisualState.VisualState>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.NativeFieldInfoPtr_visualStates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018BE RID: 6334
		// (get) Token: 0x0600524A RID: 21066 RVA: 0x00185D48 File Offset: 0x00183F48
		// (set) Token: 0x0600524B RID: 21067 RVA: 0x00027257 File Offset: 0x00025457
		public unsafe Player player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.NativeFieldInfoPtr_player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018BF RID: 6335
		// (get) Token: 0x0600524C RID: 21068 RVA: 0x00185D78 File Offset: 0x00183F78
		// (set) Token: 0x0600524D RID: 21069 RVA: 0x00027276 File Offset: 0x00025476
		public unsafe Dictionary<string, Coroutine> removalRoutinesDict
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.NativeFieldInfoPtr_removalRoutinesDict);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Coroutine>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.NativeFieldInfoPtr_removalRoutinesDict), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018C0 RID: 6336
		// (get) Token: 0x0600524E RID: 21070 RVA: 0x00185DA8 File Offset: 0x00183FA8
		// (set) Token: 0x0600524F RID: 21071 RVA: 0x00027295 File Offset: 0x00025495
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170018C1 RID: 6337
		// (get) Token: 0x06005250 RID: 21072 RVA: 0x00185DD0 File Offset: 0x00183FD0
		// (set) Token: 0x06005251 RID: 21073 RVA: 0x000272B0 File Offset: 0x000254B0
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040037C0 RID: 14272
		private static readonly IntPtr NativeFieldInfoPtr_Suspiciousness;

		// Token: 0x040037C1 RID: 14273
		private static readonly IntPtr NativeFieldInfoPtr_visualStates;

		// Token: 0x040037C2 RID: 14274
		private static readonly IntPtr NativeFieldInfoPtr_player;

		// Token: 0x040037C3 RID: 14275
		private static readonly IntPtr NativeFieldInfoPtr_removalRoutinesDict;

		// Token: 0x040037C4 RID: 14276
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040037C5 RID: 14277
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040037C6 RID: 14278
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040037C7 RID: 14279
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040037C8 RID: 14280
		private static readonly IntPtr NativeMethodInfoPtr_ApplyState_Public_Void_String_EVisualState_Single_0;

		// Token: 0x040037C9 RID: 14281
		private static readonly IntPtr NativeMethodInfoPtr_RemoveState_Public_Void_String_Single_0;

		// Token: 0x040037CA RID: 14282
		private static readonly IntPtr NativeMethodInfoPtr_GetState_Public_VisualState_String_0;

		// Token: 0x040037CB RID: 14283
		private static readonly IntPtr NativeMethodInfoPtr_ClearStates_Public_Void_0;

		// Token: 0x040037CC RID: 14284
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSuspiciousness_Private_Void_0;

		// Token: 0x040037CD RID: 14285
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040037CE RID: 14286
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__6_0_Private_Void_0;

		// Token: 0x040037CF RID: 14287
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040037D0 RID: 14288
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040037D1 RID: 14289
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040037D2 RID: 14290
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_ApplyState_868472085_Private_Void_String_EVisualState_Single_0;

		// Token: 0x040037D3 RID: 14291
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ApplyState_868472085_Public_Void_String_EVisualState_Single_0;

		// Token: 0x040037D4 RID: 14292
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_ApplyState_868472085_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040037D5 RID: 14293
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_RemoveState_606697822_Private_Void_String_Single_0;

		// Token: 0x040037D6 RID: 14294
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___RemoveState_606697822_Public_Void_String_Single_0;

		// Token: 0x040037D7 RID: 14295
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_RemoveState_606697822_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040037D8 RID: 14296
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_0;

		// Token: 0x020009AB RID: 2475
		[OriginalName("Assembly-CSharp.dll", "", "EVisualState")]
		public enum EVisualState
		{
			// Token: 0x040089A5 RID: 35237
			Visible,
			// Token: 0x040089A6 RID: 35238
			Suspicious,
			// Token: 0x040089A7 RID: 35239
			DisobeyingCurfew,
			// Token: 0x040089A8 RID: 35240
			Vandalizing,
			// Token: 0x040089A9 RID: 35241
			PettyCrime,
			// Token: 0x040089AA RID: 35242
			DrugDealing,
			// Token: 0x040089AB RID: 35243
			SearchedFor,
			// Token: 0x040089AC RID: 35244
			Wanted,
			// Token: 0x040089AD RID: 35245
			Pickpocketing,
			// Token: 0x040089AE RID: 35246
			DischargingWeapon,
			// Token: 0x040089AF RID: 35247
			Brandishing
		}

		// Token: 0x020009AC RID: 2476
		[Serializable]
		public class VisualState : Il2CppSystem.Object
		{
			// Token: 0x0600CBA1 RID: 52129 RVA: 0x00312914 File Offset: 0x00310B14
			// Note: this type is marked as 'beforefieldinit'.
			static VisualState()
			{
				Il2CppClassPointerStore<PlayerVisualState.VisualState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, "VisualState");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerVisualState.VisualState>.NativeClassPtr);
				PlayerVisualState.VisualState.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState.VisualState>.NativeClassPtr, "state");
				PlayerVisualState.VisualState.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState.VisualState>.NativeClassPtr, "label");
				PlayerVisualState.VisualState.NativeFieldInfoPtr_stateDestroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState.VisualState>.NativeClassPtr, "stateDestroyed");
				PlayerVisualState.VisualState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState.VisualState>.NativeClassPtr, 100673607);
			}

			// Token: 0x0600CBA2 RID: 52130 RVA: 0x00312990 File Offset: 0x00310B90
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe VisualState() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerVisualState.VisualState>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.VisualState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CBA3 RID: 52131 RVA: 0x000630C2 File Offset: 0x000612C2
			public VisualState(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F70 RID: 16240
			// (get) Token: 0x0600CBA4 RID: 52132 RVA: 0x003129CC File Offset: 0x00310BCC
			// (set) Token: 0x0600CBA5 RID: 52133 RVA: 0x000630CB File Offset: 0x000612CB
			public unsafe PlayerVisualState.EVisualState state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.VisualState.NativeFieldInfoPtr_state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.VisualState.NativeFieldInfoPtr_state)) = value;
				}
			}

			// Token: 0x17003F71 RID: 16241
			// (get) Token: 0x0600CBA6 RID: 52134 RVA: 0x003129F4 File Offset: 0x00310BF4
			// (set) Token: 0x0600CBA7 RID: 52135 RVA: 0x000630E6 File Offset: 0x000612E6
			public unsafe string label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.VisualState.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.VisualState.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003F72 RID: 16242
			// (get) Token: 0x0600CBA8 RID: 52136 RVA: 0x00312A1C File Offset: 0x00310C1C
			// (set) Token: 0x0600CBA9 RID: 52137 RVA: 0x00063105 File Offset: 0x00061305
			public unsafe Action stateDestroyed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.VisualState.NativeFieldInfoPtr_stateDestroyed);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.VisualState.NativeFieldInfoPtr_stateDestroyed), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040089B0 RID: 35248
			private static readonly IntPtr NativeFieldInfoPtr_state;

			// Token: 0x040089B1 RID: 35249
			private static readonly IntPtr NativeFieldInfoPtr_label;

			// Token: 0x040089B2 RID: 35250
			private static readonly IntPtr NativeFieldInfoPtr_stateDestroyed;

			// Token: 0x040089B3 RID: 35251
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020009AD RID: 2477
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerVisualState+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CBAA RID: 52138 RVA: 0x00312A4C File Offset: 0x00310C4C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass10_0>.NativeClassPtr);
				PlayerVisualState.__c__DisplayClass10_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass10_0>.NativeClassPtr, "label");
				PlayerVisualState.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass10_0>.NativeClassPtr, 100673608);
				PlayerVisualState.__c__DisplayClass10_0.NativeMethodInfoPtr__GetState_b__0_Internal_Boolean_VisualState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass10_0>.NativeClassPtr, 100673609);
			}

			// Token: 0x0600CBAB RID: 52139 RVA: 0x00312AB4 File Offset: 0x00310CB4
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CBAC RID: 52140 RVA: 0x00312AF0 File Offset: 0x00310CF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetState_b__0(PlayerVisualState.VisualState x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.__c__DisplayClass10_0.NativeMethodInfoPtr__GetState_b__0_Internal_Boolean_VisualState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CBAD RID: 52141 RVA: 0x00063124 File Offset: 0x00061324
			public __c__DisplayClass10_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F73 RID: 16243
			// (get) Token: 0x0600CBAE RID: 52142 RVA: 0x00312B40 File Offset: 0x00310D40
			// (set) Token: 0x0600CBAF RID: 52143 RVA: 0x0006312D File Offset: 0x0006132D
			public unsafe string label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.__c__DisplayClass10_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.__c__DisplayClass10_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040089B4 RID: 35252
			private static readonly IntPtr NativeFieldInfoPtr_label;

			// Token: 0x040089B5 RID: 35253
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040089B6 RID: 35254
			private static readonly IntPtr NativeMethodInfoPtr__GetState_b__0_Internal_Boolean_VisualState_0;
		}

		// Token: 0x020009AE RID: 2478
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerVisualState+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CBB0 RID: 52144 RVA: 0x00312B68 File Offset: 0x00310D68
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0>.NativeClassPtr);
				PlayerVisualState.__c__DisplayClass9_0.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0>.NativeClassPtr, "delay");
				PlayerVisualState.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0>.NativeClassPtr, "<>4__this");
				PlayerVisualState.__c__DisplayClass9_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0>.NativeClassPtr, "label");
				PlayerVisualState.__c__DisplayClass9_0.NativeFieldInfoPtr_newState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0>.NativeClassPtr, "newState");
				PlayerVisualState.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0>.NativeClassPtr, 100673610);
				PlayerVisualState.__c__DisplayClass9_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0>.NativeClassPtr, 100673611);
				PlayerVisualState.__c__DisplayClass9_0.NativeMethodInfoPtr_Method_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0>.NativeClassPtr, 100673612);
			}

			// Token: 0x0600CBB1 RID: 52145 RVA: 0x00312C20 File Offset: 0x00310E20
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CBB2 RID: 52146 RVA: 0x00312C5C File Offset: 0x00310E5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177599, XrefRangeEnd = 177604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.__c__DisplayClass9_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600CBB3 RID: 52147 RVA: 0x00312C9C File Offset: 0x00310E9C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 177622, RefRangeEnd = 177623, XrefRangeStart = 177604, XrefRangeEnd = 177622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.__c__DisplayClass9_0.NativeMethodInfoPtr_Method_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CBB4 RID: 52148 RVA: 0x0006314C File Offset: 0x0006134C
			public __c__DisplayClass9_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F74 RID: 16244
			// (get) Token: 0x0600CBB5 RID: 52149 RVA: 0x00312CD0 File Offset: 0x00310ED0
			// (set) Token: 0x0600CBB6 RID: 52150 RVA: 0x00063155 File Offset: 0x00061355
			public unsafe float delay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.__c__DisplayClass9_0.NativeFieldInfoPtr_delay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.__c__DisplayClass9_0.NativeFieldInfoPtr_delay)) = value;
				}
			}

			// Token: 0x17003F75 RID: 16245
			// (get) Token: 0x0600CBB7 RID: 52151 RVA: 0x00312CF8 File Offset: 0x00310EF8
			// (set) Token: 0x0600CBB8 RID: 52152 RVA: 0x00063170 File Offset: 0x00061370
			public unsafe PlayerVisualState __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerVisualState>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F76 RID: 16246
			// (get) Token: 0x0600CBB9 RID: 52153 RVA: 0x00312D28 File Offset: 0x00310F28
			// (set) Token: 0x0600CBBA RID: 52154 RVA: 0x0006318F File Offset: 0x0006138F
			public unsafe string label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.__c__DisplayClass9_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.__c__DisplayClass9_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003F77 RID: 16247
			// (get) Token: 0x0600CBBB RID: 52155 RVA: 0x00312D50 File Offset: 0x00310F50
			// (set) Token: 0x0600CBBC RID: 52156 RVA: 0x000631AE File Offset: 0x000613AE
			public unsafe PlayerVisualState.VisualState newState
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.__c__DisplayClass9_0.NativeFieldInfoPtr_newState);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerVisualState.VisualState>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.__c__DisplayClass9_0.NativeFieldInfoPtr_newState), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040089B7 RID: 35255
			private static readonly IntPtr NativeFieldInfoPtr_delay;

			// Token: 0x040089B8 RID: 35256
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040089B9 RID: 35257
			private static readonly IntPtr NativeFieldInfoPtr_label;

			// Token: 0x040089BA RID: 35258
			private static readonly IntPtr NativeFieldInfoPtr_newState;

			// Token: 0x040089BB RID: 35259
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040089BC RID: 35260
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x040089BD RID: 35261
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_0;

			// Token: 0x02000C48 RID: 3144
			[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerVisualState+<>c__DisplayClass9_0+<<RemoveState>g__DelayedRemove|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E2B1 RID: 58033 RVA: 0x00353B64 File Offset: 0x00351D64
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0>.NativeClassPtr, "<<RemoveState>g__DelayedRemove|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673613);
					PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673614);
					PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673615);
					PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673616);
					PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673617);
					PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673618);
				}

				// Token: 0x0600E2B2 RID: 58034 RVA: 0x00353C44 File Offset: 0x00351E44
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E2B3 RID: 58035 RVA: 0x00353C8C File Offset: 0x00351E8C
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E2B4 RID: 58036 RVA: 0x00353CC0 File Offset: 0x00351EC0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177588, XrefRangeEnd = 177594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004653 RID: 18003
				// (get) Token: 0x0600E2B5 RID: 58037 RVA: 0x00353CFC File Offset: 0x00351EFC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E2B6 RID: 58038 RVA: 0x00353D3C File Offset: 0x00351F3C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177594, XrefRangeEnd = 177599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004654 RID: 18004
				// (get) Token: 0x0600E2B7 RID: 58039 RVA: 0x00353D70 File Offset: 0x00351F70
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E2B8 RID: 58040 RVA: 0x0006E881 File Offset: 0x0006CA81
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004650 RID: 18000
				// (get) Token: 0x0600E2B9 RID: 58041 RVA: 0x00353DB0 File Offset: 0x00351FB0
				// (set) Token: 0x0600E2BA RID: 58042 RVA: 0x0006E88A File Offset: 0x0006CA8A
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004651 RID: 18001
				// (get) Token: 0x0600E2BB RID: 58043 RVA: 0x00353DD8 File Offset: 0x00351FD8
				// (set) Token: 0x0600E2BC RID: 58044 RVA: 0x0006E8A5 File Offset: 0x0006CAA5
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004652 RID: 18002
				// (get) Token: 0x0600E2BD RID: 58045 RVA: 0x00353E08 File Offset: 0x00352008
				// (set) Token: 0x0600E2BE RID: 58046 RVA: 0x0006E8C4 File Offset: 0x0006CAC4
				public unsafe PlayerVisualState.__c__DisplayClass9_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerVisualState.__c__DisplayClass9_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040097BA RID: 38842
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040097BB RID: 38843
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040097BC RID: 38844
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040097BD RID: 38845
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040097BE RID: 38846
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040097BF RID: 38847
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040097C0 RID: 38848
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040097C1 RID: 38849
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040097C2 RID: 38850
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
