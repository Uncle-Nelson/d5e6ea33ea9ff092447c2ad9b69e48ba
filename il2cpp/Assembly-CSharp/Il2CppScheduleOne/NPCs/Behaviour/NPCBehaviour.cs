using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Combat;
using Il2CppScheduleOne.Product;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x0200035F RID: 863
	public class NPCBehaviour : NetworkBehaviour
	{
		// Token: 0x0600424F RID: 16975 RVA: 0x0014B3A0 File Offset: 0x001495A0
		// Note: this type is marked as 'beforefieldinit'.
		static NPCBehaviour()
		{
			Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "NPCBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr);
			NPCBehaviour.NativeFieldInfoPtr_DEBUG_MODE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "DEBUG_MODE");
			NPCBehaviour.NativeFieldInfoPtr_ScheduleManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "ScheduleManager");
			NPCBehaviour.NativeFieldInfoPtr_CoweringBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "CoweringBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_RagdollBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "RagdollBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_CallPoliceBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "CallPoliceBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_GenericDialogueBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "GenericDialogueBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_HeavyFlinchBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "HeavyFlinchBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_FacePlayerBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "FacePlayerBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_DeadBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "DeadBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_UnconsciousBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "UnconsciousBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_SummonBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "SummonBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_ConsumeProductBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "ConsumeProductBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_CombatBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "CombatBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_FleeBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "FleeBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_StationaryBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "StationaryBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_RequestProductBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "RequestProductBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_behaviourStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "behaviourStack");
			NPCBehaviour.NativeFieldInfoPtr__activeBehaviour_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "<activeBehaviour>k__BackingField");
			NPCBehaviour.NativeFieldInfoPtr__Npc_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "<Npc>k__BackingField");
			NPCBehaviour.NativeFieldInfoPtr_summonRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "summonRoutine");
			NPCBehaviour.NativeFieldInfoPtr_enabledBehaviours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "enabledBehaviours");
			NPCBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.NPCBehaviourAssembly-CSharp.dll_Excuted");
			NPCBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.NPCBehaviourAssembly-CSharp.dll_Excuted");
			NPCBehaviour.NativeMethodInfoPtr_get_activeBehaviour_Public_get_Behaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671369);
			NPCBehaviour.NativeMethodInfoPtr_set_activeBehaviour_Public_set_Void_Behaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671370);
			NPCBehaviour.NativeMethodInfoPtr_get_Npc_Public_get_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671371);
			NPCBehaviour.NativeMethodInfoPtr_set_Npc_Private_set_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671372);
			NPCBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671373);
			NPCBehaviour.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671374);
			NPCBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671375);
			NPCBehaviour.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671376);
			NPCBehaviour.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671377);
			NPCBehaviour.NativeMethodInfoPtr_Summon_Public_Void_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671378);
			NPCBehaviour.NativeMethodInfoPtr_ConsumeProduct_Public_Void_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671379);
			NPCBehaviour.NativeMethodInfoPtr_OnKnockOut_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671380);
			NPCBehaviour.NativeMethodInfoPtr_OnDie_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671381);
			NPCBehaviour.NativeMethodInfoPtr_GetBehaviour_Public_Behaviour_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671382);
			NPCBehaviour.NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671383);
			NPCBehaviour.NativeMethodInfoPtr_LateUpdate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671384);
			NPCBehaviour.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671385);
			NPCBehaviour.NativeMethodInfoPtr_SortBehaviourStack_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671386);
			NPCBehaviour.NativeMethodInfoPtr_GetEnabledBehaviour_Private_Behaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671387);
			NPCBehaviour.NativeMethodInfoPtr_AddEnabledBehaviour_Private_Void_Behaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671388);
			NPCBehaviour.NativeMethodInfoPtr_RemoveEnabledBehaviour_Private_Void_Behaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671389);
			NPCBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671390);
			NPCBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671391);
			NPCBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671392);
			NPCBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671393);
			NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Server_Summon_900355577_Private_Void_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671394);
			NPCBehaviour.NativeMethodInfoPtr_RpcLogic___Summon_900355577_Public_Void_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671395);
			NPCBehaviour.NativeMethodInfoPtr_RpcReader___Server_Summon_900355577_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671396);
			NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Server_ConsumeProduct_2622925554_Private_Void_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671397);
			NPCBehaviour.NativeMethodInfoPtr_RpcLogic___ConsumeProduct_2622925554_Public_Void_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671398);
			NPCBehaviour.NativeMethodInfoPtr_RpcReader___Server_ConsumeProduct_2622925554_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671399);
			NPCBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671400);
		}

		// Token: 0x1700142E RID: 5166
		// (get) Token: 0x06004250 RID: 16976 RVA: 0x0014B81C File Offset: 0x00149A1C
		// (set) Token: 0x06004251 RID: 16977 RVA: 0x0014B85C File Offset: 0x00149A5C
		public unsafe Behaviour activeBehaviour
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_get_activeBehaviour_Public_get_Behaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Behaviour>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152450, XrefRangeEnd = 152451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_set_activeBehaviour_Public_set_Void_Behaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700142F RID: 5167
		// (get) Token: 0x06004252 RID: 16978 RVA: 0x0014B8A0 File Offset: 0x00149AA0
		// (set) Token: 0x06004253 RID: 16979 RVA: 0x0014B8E0 File Offset: 0x00149AE0
		public unsafe NPC Npc
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 131979, RefRangeEnd = 131989, XrefRangeStart = 131979, XrefRangeEnd = 131989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_get_Npc_Public_get_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_set_Npc_Private_set_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004254 RID: 16980 RVA: 0x0014B924 File Offset: 0x00149B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152451, XrefRangeEnd = 152465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004255 RID: 16981 RVA: 0x0014B960 File Offset: 0x00149B60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152465, XrefRangeEnd = 152522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004256 RID: 16982 RVA: 0x0014B99C File Offset: 0x00149B9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152522, XrefRangeEnd = 152538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004257 RID: 16983 RVA: 0x0014B9D0 File Offset: 0x00149BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152538, XrefRangeEnd = 152568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004258 RID: 16984 RVA: 0x0014BA0C File Offset: 0x00149C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152568, XrefRangeEnd = 152574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004259 RID: 16985 RVA: 0x0014BA5C File Offset: 0x00149C5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 152575, RefRangeEnd = 152576, XrefRangeStart = 152574, XrefRangeEnd = 152575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Summon(string buildingGUID, int doorIndex, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(buildingGUID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doorIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_Summon_Public_Void_String_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600425A RID: 16986 RVA: 0x0014BABC File Offset: 0x00149CBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 152595, RefRangeEnd = 152596, XrefRangeStart = 152576, XrefRangeEnd = 152595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConsumeProduct(ProductItemInstance product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_ConsumeProduct_Public_Void_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600425B RID: 16987 RVA: 0x0014BB00 File Offset: 0x00149D00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152596, XrefRangeEnd = 152630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnKnockOut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_OnKnockOut_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600425C RID: 16988 RVA: 0x0014BB3C File Offset: 0x00149D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152630, XrefRangeEnd = 152632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDie()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_OnDie_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600425D RID: 16989 RVA: 0x0014BB78 File Offset: 0x00149D78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 152659, RefRangeEnd = 152660, XrefRangeStart = 152632, XrefRangeEnd = 152659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Behaviour GetBehaviour(string BehaviourName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(BehaviourName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_GetBehaviour_Public_Behaviour_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Behaviour>(intPtr3) : null;
		}

		// Token: 0x0600425E RID: 16990 RVA: 0x0014BBC8 File Offset: 0x00149DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152660, XrefRangeEnd = 152691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600425F RID: 16991 RVA: 0x0014BC04 File Offset: 0x00149E04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152691, XrefRangeEnd = 152695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_LateUpdate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004260 RID: 16992 RVA: 0x0014BC40 File Offset: 0x00149E40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152695, XrefRangeEnd = 152699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004261 RID: 16993 RVA: 0x0014BC7C File Offset: 0x00149E7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 152721, RefRangeEnd = 152722, XrefRangeStart = 152699, XrefRangeEnd = 152721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortBehaviourStack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_SortBehaviourStack_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004262 RID: 16994 RVA: 0x0014BCB0 File Offset: 0x00149EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152722, XrefRangeEnd = 152725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Behaviour GetEnabledBehaviour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_GetEnabledBehaviour_Private_Behaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Behaviour>(intPtr3) : null;
		}

		// Token: 0x06004263 RID: 16995 RVA: 0x0014BCF0 File Offset: 0x00149EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152725, XrefRangeEnd = 152753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddEnabledBehaviour(Behaviour b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_AddEnabledBehaviour_Private_Void_Behaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004264 RID: 16996 RVA: 0x0014BD34 File Offset: 0x00149F34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152753, XrefRangeEnd = 152781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveEnabledBehaviour(Behaviour b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RemoveEnabledBehaviour_Private_Void_Behaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004265 RID: 16997 RVA: 0x0014BD78 File Offset: 0x00149F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152781, XrefRangeEnd = 152794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004266 RID: 16998 RVA: 0x0014BDB4 File Offset: 0x00149FB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152794, XrefRangeEnd = 152807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004267 RID: 16999 RVA: 0x0014BDF0 File Offset: 0x00149FF0
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004268 RID: 17000 RVA: 0x0014BE2C File Offset: 0x0014A02C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004269 RID: 17001 RVA: 0x0014BE68 File Offset: 0x0014A068
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 152830, RefRangeEnd = 152831, XrefRangeStart = 152807, XrefRangeEnd = 152830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_Summon_900355577(string buildingGUID, int doorIndex, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(buildingGUID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doorIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Server_Summon_900355577_Private_Void_String_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600426A RID: 17002 RVA: 0x0014BEC8 File Offset: 0x0014A0C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 152865, RefRangeEnd = 152866, XrefRangeStart = 152831, XrefRangeEnd = 152865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Summon_900355577(string buildingGUID, int doorIndex, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(buildingGUID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doorIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcLogic___Summon_900355577_Public_Void_String_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600426B RID: 17003 RVA: 0x0014BF28 File Offset: 0x0014A128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152866, XrefRangeEnd = 152872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_Summon_900355577(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcReader___Server_Summon_900355577_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600426C RID: 17004 RVA: 0x0014BF8C File Offset: 0x0014A18C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 152595, RefRangeEnd = 152596, XrefRangeStart = 152595, XrefRangeEnd = 152596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ConsumeProduct_2622925554(ProductItemInstance product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Server_ConsumeProduct_2622925554_Private_Void_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600426D RID: 17005 RVA: 0x0014BFD0 File Offset: 0x0014A1D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152872, XrefRangeEnd = 152875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ConsumeProduct_2622925554(ProductItemInstance product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcLogic___ConsumeProduct_2622925554_Public_Void_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600426E RID: 17006 RVA: 0x0014C014 File Offset: 0x0014A214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152875, XrefRangeEnd = 152879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ConsumeProduct_2622925554(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcReader___Server_ConsumeProduct_2622925554_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600426F RID: 17007 RVA: 0x0014C078 File Offset: 0x0014A278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152879, XrefRangeEnd = 152893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004270 RID: 17008 RVA: 0x00020890 File Offset: 0x0001EA90
		public NPCBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001417 RID: 5143
		// (get) Token: 0x06004271 RID: 17009 RVA: 0x0014C0B4 File Offset: 0x0014A2B4
		// (set) Token: 0x06004272 RID: 17010 RVA: 0x00020899 File Offset: 0x0001EA99
		public unsafe bool DEBUG_MODE
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_DEBUG_MODE);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_DEBUG_MODE)) = value;
			}
		}

		// Token: 0x17001418 RID: 5144
		// (get) Token: 0x06004273 RID: 17011 RVA: 0x0014C0DC File Offset: 0x0014A2DC
		// (set) Token: 0x06004274 RID: 17012 RVA: 0x000208B4 File Offset: 0x0001EAB4
		public unsafe NPCScheduleManager ScheduleManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_ScheduleManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCScheduleManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_ScheduleManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001419 RID: 5145
		// (get) Token: 0x06004275 RID: 17013 RVA: 0x0014C10C File Offset: 0x0014A30C
		// (set) Token: 0x06004276 RID: 17014 RVA: 0x000208D3 File Offset: 0x0001EAD3
		public unsafe CoweringBehaviour CoweringBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_CoweringBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CoweringBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_CoweringBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700141A RID: 5146
		// (get) Token: 0x06004277 RID: 17015 RVA: 0x0014C13C File Offset: 0x0014A33C
		// (set) Token: 0x06004278 RID: 17016 RVA: 0x000208F2 File Offset: 0x0001EAF2
		public unsafe RagdollBehaviour RagdollBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_RagdollBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RagdollBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_RagdollBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700141B RID: 5147
		// (get) Token: 0x06004279 RID: 17017 RVA: 0x0014C16C File Offset: 0x0014A36C
		// (set) Token: 0x0600427A RID: 17018 RVA: 0x00020911 File Offset: 0x0001EB11
		public unsafe CallPoliceBehaviour CallPoliceBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_CallPoliceBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallPoliceBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_CallPoliceBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700141C RID: 5148
		// (get) Token: 0x0600427B RID: 17019 RVA: 0x0014C19C File Offset: 0x0014A39C
		// (set) Token: 0x0600427C RID: 17020 RVA: 0x00020930 File Offset: 0x0001EB30
		public unsafe GenericDialogueBehaviour GenericDialogueBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_GenericDialogueBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericDialogueBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_GenericDialogueBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700141D RID: 5149
		// (get) Token: 0x0600427D RID: 17021 RVA: 0x0014C1CC File Offset: 0x0014A3CC
		// (set) Token: 0x0600427E RID: 17022 RVA: 0x0002094F File Offset: 0x0001EB4F
		public unsafe HeavyFlinchBehaviour HeavyFlinchBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_HeavyFlinchBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HeavyFlinchBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_HeavyFlinchBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700141E RID: 5150
		// (get) Token: 0x0600427F RID: 17023 RVA: 0x0014C1FC File Offset: 0x0014A3FC
		// (set) Token: 0x06004280 RID: 17024 RVA: 0x0002096E File Offset: 0x0001EB6E
		public unsafe FacePlayerBehaviour FacePlayerBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_FacePlayerBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FacePlayerBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_FacePlayerBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700141F RID: 5151
		// (get) Token: 0x06004281 RID: 17025 RVA: 0x0014C22C File Offset: 0x0014A42C
		// (set) Token: 0x06004282 RID: 17026 RVA: 0x0002098D File Offset: 0x0001EB8D
		public unsafe DeadBehaviour DeadBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_DeadBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeadBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_DeadBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001420 RID: 5152
		// (get) Token: 0x06004283 RID: 17027 RVA: 0x0014C25C File Offset: 0x0014A45C
		// (set) Token: 0x06004284 RID: 17028 RVA: 0x000209AC File Offset: 0x0001EBAC
		public unsafe UnconsciousBehaviour UnconsciousBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_UnconsciousBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnconsciousBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_UnconsciousBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001421 RID: 5153
		// (get) Token: 0x06004285 RID: 17029 RVA: 0x0014C28C File Offset: 0x0014A48C
		// (set) Token: 0x06004286 RID: 17030 RVA: 0x000209CB File Offset: 0x0001EBCB
		public unsafe Behaviour SummonBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_SummonBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Behaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_SummonBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001422 RID: 5154
		// (get) Token: 0x06004287 RID: 17031 RVA: 0x0014C2BC File Offset: 0x0014A4BC
		// (set) Token: 0x06004288 RID: 17032 RVA: 0x000209EA File Offset: 0x0001EBEA
		public unsafe ConsumeProductBehaviour ConsumeProductBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_ConsumeProductBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConsumeProductBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_ConsumeProductBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001423 RID: 5155
		// (get) Token: 0x06004289 RID: 17033 RVA: 0x0014C2EC File Offset: 0x0014A4EC
		// (set) Token: 0x0600428A RID: 17034 RVA: 0x00020A09 File Offset: 0x0001EC09
		public unsafe CombatBehaviour CombatBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_CombatBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CombatBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_CombatBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001424 RID: 5156
		// (get) Token: 0x0600428B RID: 17035 RVA: 0x0014C31C File Offset: 0x0014A51C
		// (set) Token: 0x0600428C RID: 17036 RVA: 0x00020A28 File Offset: 0x0001EC28
		public unsafe FleeBehaviour FleeBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_FleeBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FleeBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_FleeBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001425 RID: 5157
		// (get) Token: 0x0600428D RID: 17037 RVA: 0x0014C34C File Offset: 0x0014A54C
		// (set) Token: 0x0600428E RID: 17038 RVA: 0x00020A47 File Offset: 0x0001EC47
		public unsafe StationaryBehaviour StationaryBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_StationaryBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationaryBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_StationaryBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001426 RID: 5158
		// (get) Token: 0x0600428F RID: 17039 RVA: 0x0014C37C File Offset: 0x0014A57C
		// (set) Token: 0x06004290 RID: 17040 RVA: 0x00020A66 File Offset: 0x0001EC66
		public unsafe RequestProductBehaviour RequestProductBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_RequestProductBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RequestProductBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_RequestProductBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001427 RID: 5159
		// (get) Token: 0x06004291 RID: 17041 RVA: 0x0014C3AC File Offset: 0x0014A5AC
		// (set) Token: 0x06004292 RID: 17042 RVA: 0x00020A85 File Offset: 0x0001EC85
		public unsafe List<Behaviour> behaviourStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_behaviourStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Behaviour>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_behaviourStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001428 RID: 5160
		// (get) Token: 0x06004293 RID: 17043 RVA: 0x0014C3DC File Offset: 0x0014A5DC
		// (set) Token: 0x06004294 RID: 17044 RVA: 0x00020AA4 File Offset: 0x0001ECA4
		public unsafe Behaviour _activeBehaviour_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr__activeBehaviour_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Behaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr__activeBehaviour_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001429 RID: 5161
		// (get) Token: 0x06004295 RID: 17045 RVA: 0x0014C40C File Offset: 0x0014A60C
		// (set) Token: 0x06004296 RID: 17046 RVA: 0x00020AC3 File Offset: 0x0001ECC3
		public unsafe NPC _Npc_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr__Npc_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr__Npc_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700142A RID: 5162
		// (get) Token: 0x06004297 RID: 17047 RVA: 0x0014C43C File Offset: 0x0014A63C
		// (set) Token: 0x06004298 RID: 17048 RVA: 0x00020AE2 File Offset: 0x0001ECE2
		public unsafe Coroutine summonRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_summonRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_summonRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700142B RID: 5163
		// (get) Token: 0x06004299 RID: 17049 RVA: 0x0014C46C File Offset: 0x0014A66C
		// (set) Token: 0x0600429A RID: 17050 RVA: 0x00020B01 File Offset: 0x0001ED01
		public unsafe List<Behaviour> enabledBehaviours
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_enabledBehaviours);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Behaviour>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_enabledBehaviours), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700142C RID: 5164
		// (get) Token: 0x0600429B RID: 17051 RVA: 0x0014C49C File Offset: 0x0014A69C
		// (set) Token: 0x0600429C RID: 17052 RVA: 0x00020B20 File Offset: 0x0001ED20
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700142D RID: 5165
		// (get) Token: 0x0600429D RID: 17053 RVA: 0x0014C4C4 File Offset: 0x0014A6C4
		// (set) Token: 0x0600429E RID: 17054 RVA: 0x00020B3B File Offset: 0x0001ED3B
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002C53 RID: 11347
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG_MODE;

		// Token: 0x04002C54 RID: 11348
		private static readonly IntPtr NativeFieldInfoPtr_ScheduleManager;

		// Token: 0x04002C55 RID: 11349
		private static readonly IntPtr NativeFieldInfoPtr_CoweringBehaviour;

		// Token: 0x04002C56 RID: 11350
		private static readonly IntPtr NativeFieldInfoPtr_RagdollBehaviour;

		// Token: 0x04002C57 RID: 11351
		private static readonly IntPtr NativeFieldInfoPtr_CallPoliceBehaviour;

		// Token: 0x04002C58 RID: 11352
		private static readonly IntPtr NativeFieldInfoPtr_GenericDialogueBehaviour;

		// Token: 0x04002C59 RID: 11353
		private static readonly IntPtr NativeFieldInfoPtr_HeavyFlinchBehaviour;

		// Token: 0x04002C5A RID: 11354
		private static readonly IntPtr NativeFieldInfoPtr_FacePlayerBehaviour;

		// Token: 0x04002C5B RID: 11355
		private static readonly IntPtr NativeFieldInfoPtr_DeadBehaviour;

		// Token: 0x04002C5C RID: 11356
		private static readonly IntPtr NativeFieldInfoPtr_UnconsciousBehaviour;

		// Token: 0x04002C5D RID: 11357
		private static readonly IntPtr NativeFieldInfoPtr_SummonBehaviour;

		// Token: 0x04002C5E RID: 11358
		private static readonly IntPtr NativeFieldInfoPtr_ConsumeProductBehaviour;

		// Token: 0x04002C5F RID: 11359
		private static readonly IntPtr NativeFieldInfoPtr_CombatBehaviour;

		// Token: 0x04002C60 RID: 11360
		private static readonly IntPtr NativeFieldInfoPtr_FleeBehaviour;

		// Token: 0x04002C61 RID: 11361
		private static readonly IntPtr NativeFieldInfoPtr_StationaryBehaviour;

		// Token: 0x04002C62 RID: 11362
		private static readonly IntPtr NativeFieldInfoPtr_RequestProductBehaviour;

		// Token: 0x04002C63 RID: 11363
		private static readonly IntPtr NativeFieldInfoPtr_behaviourStack;

		// Token: 0x04002C64 RID: 11364
		private static readonly IntPtr NativeFieldInfoPtr__activeBehaviour_k__BackingField;

		// Token: 0x04002C65 RID: 11365
		private static readonly IntPtr NativeFieldInfoPtr__Npc_k__BackingField;

		// Token: 0x04002C66 RID: 11366
		private static readonly IntPtr NativeFieldInfoPtr_summonRoutine;

		// Token: 0x04002C67 RID: 11367
		private static readonly IntPtr NativeFieldInfoPtr_enabledBehaviours;

		// Token: 0x04002C68 RID: 11368
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002C69 RID: 11369
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002C6A RID: 11370
		private static readonly IntPtr NativeMethodInfoPtr_get_activeBehaviour_Public_get_Behaviour_0;

		// Token: 0x04002C6B RID: 11371
		private static readonly IntPtr NativeMethodInfoPtr_set_activeBehaviour_Public_set_Void_Behaviour_0;

		// Token: 0x04002C6C RID: 11372
		private static readonly IntPtr NativeMethodInfoPtr_get_Npc_Public_get_NPC_0;

		// Token: 0x04002C6D RID: 11373
		private static readonly IntPtr NativeMethodInfoPtr_set_Npc_Private_set_Void_NPC_0;

		// Token: 0x04002C6E RID: 11374
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04002C6F RID: 11375
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1;

		// Token: 0x04002C70 RID: 11376
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04002C71 RID: 11377
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0;

		// Token: 0x04002C72 RID: 11378
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04002C73 RID: 11379
		private static readonly IntPtr NativeMethodInfoPtr_Summon_Public_Void_String_Int32_Single_0;

		// Token: 0x04002C74 RID: 11380
		private static readonly IntPtr NativeMethodInfoPtr_ConsumeProduct_Public_Void_ProductItemInstance_0;

		// Token: 0x04002C75 RID: 11381
		private static readonly IntPtr NativeMethodInfoPtr_OnKnockOut_Protected_Virtual_New_Void_1;

		// Token: 0x04002C76 RID: 11382
		private static readonly IntPtr NativeMethodInfoPtr_OnDie_Protected_Virtual_New_Void_1;

		// Token: 0x04002C77 RID: 11383
		private static readonly IntPtr NativeMethodInfoPtr_GetBehaviour_Public_Behaviour_String_0;

		// Token: 0x04002C78 RID: 11384
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0;

		// Token: 0x04002C79 RID: 11385
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Public_Virtual_New_Void_0;

		// Token: 0x04002C7A RID: 11386
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_1;

		// Token: 0x04002C7B RID: 11387
		private static readonly IntPtr NativeMethodInfoPtr_SortBehaviourStack_Public_Void_0;

		// Token: 0x04002C7C RID: 11388
		private static readonly IntPtr NativeMethodInfoPtr_GetEnabledBehaviour_Private_Behaviour_0;

		// Token: 0x04002C7D RID: 11389
		private static readonly IntPtr NativeMethodInfoPtr_AddEnabledBehaviour_Private_Void_Behaviour_0;

		// Token: 0x04002C7E RID: 11390
		private static readonly IntPtr NativeMethodInfoPtr_RemoveEnabledBehaviour_Private_Void_Behaviour_0;

		// Token: 0x04002C7F RID: 11391
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002C80 RID: 11392
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002C81 RID: 11393
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002C82 RID: 11394
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002C83 RID: 11395
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_Summon_900355577_Private_Void_String_Int32_Single_0;

		// Token: 0x04002C84 RID: 11396
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Summon_900355577_Public_Void_String_Int32_Single_0;

		// Token: 0x04002C85 RID: 11397
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_Summon_900355577_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002C86 RID: 11398
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_ConsumeProduct_2622925554_Private_Void_ProductItemInstance_0;

		// Token: 0x04002C87 RID: 11399
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ConsumeProduct_2622925554_Public_Void_ProductItemInstance_0;

		// Token: 0x04002C88 RID: 11400
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_ConsumeProduct_2622925554_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002C89 RID: 11401
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;

		// Token: 0x0200095E RID: 2398
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.NPCBehaviour+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600C8FB RID: 51451 RVA: 0x0030AF60 File Offset: 0x00309160
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NPCBehaviour.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCBehaviour.__c>.NativeClassPtr);
				NPCBehaviour.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c>.NativeClassPtr, "<>9");
				NPCBehaviour.__c.NativeFieldInfoPtr___9__40_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c>.NativeClassPtr, "<>9__40_0");
				NPCBehaviour.__c.NativeFieldInfoPtr___9__42_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c>.NativeClassPtr, "<>9__42_0");
				NPCBehaviour.__c.NativeFieldInfoPtr___9__43_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c>.NativeClassPtr, "<>9__43_0");
				NPCBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c>.NativeClassPtr, 100671402);
				NPCBehaviour.__c.NativeMethodInfoPtr__SortBehaviourStack_b__40_0_Internal_Int32_Behaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c>.NativeClassPtr, 100671403);
				NPCBehaviour.__c.NativeMethodInfoPtr__AddEnabledBehaviour_b__42_0_Internal_Int32_Behaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c>.NativeClassPtr, 100671404);
				NPCBehaviour.__c.NativeMethodInfoPtr__RemoveEnabledBehaviour_b__43_0_Internal_Int32_Behaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c>.NativeClassPtr, 100671405);
			}

			// Token: 0x0600C8FC RID: 51452 RVA: 0x0030B02C File Offset: 0x0030922C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCBehaviour.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C8FD RID: 51453 RVA: 0x0030B068 File Offset: 0x00309268
			[CallerCount(0)]
			public unsafe int _SortBehaviourStack_b__40_0(Behaviour x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c.NativeMethodInfoPtr__SortBehaviourStack_b__40_0_Internal_Int32_Behaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C8FE RID: 51454 RVA: 0x0030B0B8 File Offset: 0x003092B8
			[CallerCount(0)]
			public unsafe int _AddEnabledBehaviour_b__42_0(Behaviour x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c.NativeMethodInfoPtr__AddEnabledBehaviour_b__42_0_Internal_Int32_Behaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C8FF RID: 51455 RVA: 0x0030B108 File Offset: 0x00309308
			[CallerCount(0)]
			public unsafe int _RemoveEnabledBehaviour_b__43_0(Behaviour x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c.NativeMethodInfoPtr__RemoveEnabledBehaviour_b__43_0_Internal_Int32_Behaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C900 RID: 51456 RVA: 0x00061C48 File Offset: 0x0005FE48
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EB4 RID: 16052
			// (get) Token: 0x0600C901 RID: 51457 RVA: 0x0030B158 File Offset: 0x00309358
			// (set) Token: 0x0600C902 RID: 51458 RVA: 0x00061C51 File Offset: 0x0005FE51
			public unsafe static NPCBehaviour.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCBehaviour.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCBehaviour.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCBehaviour.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EB5 RID: 16053
			// (get) Token: 0x0600C903 RID: 51459 RVA: 0x0030B180 File Offset: 0x00309380
			// (set) Token: 0x0600C904 RID: 51460 RVA: 0x00061C63 File Offset: 0x0005FE63
			public unsafe static Func<Behaviour, int> __9__40_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCBehaviour.__c.NativeFieldInfoPtr___9__40_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Behaviour, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCBehaviour.__c.NativeFieldInfoPtr___9__40_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EB6 RID: 16054
			// (get) Token: 0x0600C905 RID: 51461 RVA: 0x0030B1A8 File Offset: 0x003093A8
			// (set) Token: 0x0600C906 RID: 51462 RVA: 0x00061C75 File Offset: 0x0005FE75
			public unsafe static Func<Behaviour, int> __9__42_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCBehaviour.__c.NativeFieldInfoPtr___9__42_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Behaviour, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCBehaviour.__c.NativeFieldInfoPtr___9__42_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EB7 RID: 16055
			// (get) Token: 0x0600C907 RID: 51463 RVA: 0x0030B1D0 File Offset: 0x003093D0
			// (set) Token: 0x0600C908 RID: 51464 RVA: 0x00061C87 File Offset: 0x0005FE87
			public unsafe static Func<Behaviour, int> __9__43_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCBehaviour.__c.NativeFieldInfoPtr___9__43_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Behaviour, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCBehaviour.__c.NativeFieldInfoPtr___9__43_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400880B RID: 34827
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400880C RID: 34828
			private static readonly IntPtr NativeFieldInfoPtr___9__40_0;

			// Token: 0x0400880D RID: 34829
			private static readonly IntPtr NativeFieldInfoPtr___9__42_0;

			// Token: 0x0400880E RID: 34830
			private static readonly IntPtr NativeFieldInfoPtr___9__43_0;

			// Token: 0x0400880F RID: 34831
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008810 RID: 34832
			private static readonly IntPtr NativeMethodInfoPtr__SortBehaviourStack_b__40_0_Internal_Int32_Behaviour_0;

			// Token: 0x04008811 RID: 34833
			private static readonly IntPtr NativeMethodInfoPtr__AddEnabledBehaviour_b__42_0_Internal_Int32_Behaviour_0;

			// Token: 0x04008812 RID: 34834
			private static readonly IntPtr NativeMethodInfoPtr__RemoveEnabledBehaviour_b__43_0_Internal_Int32_Behaviour_0;
		}

		// Token: 0x0200095F RID: 2399
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.NPCBehaviour+<>c__DisplayClass28_0")]
		public sealed class __c__DisplayClass28_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C909 RID: 51465 RVA: 0x0030B1F8 File Offset: 0x003093F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass28_0()
			{
				Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass28_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "<>c__DisplayClass28_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass28_0>.NativeClassPtr);
				NPCBehaviour.__c__DisplayClass28_0.NativeFieldInfoPtr_b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass28_0>.NativeClassPtr, "b");
				NPCBehaviour.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass28_0>.NativeClassPtr, "<>4__this");
				NPCBehaviour.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass28_0>.NativeClassPtr, 100671406);
				NPCBehaviour.__c__DisplayClass28_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass28_0>.NativeClassPtr, 100671407);
				NPCBehaviour.__c__DisplayClass28_0.NativeMethodInfoPtr__Start_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass28_0>.NativeClassPtr, 100671408);
			}

			// Token: 0x0600C90A RID: 51466 RVA: 0x0030B288 File Offset: 0x00309488
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass28_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass28_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C90B RID: 51467 RVA: 0x0030B2C4 File Offset: 0x003094C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152358, XrefRangeEnd = 152386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass28_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C90C RID: 51468 RVA: 0x0030B2F8 File Offset: 0x003094F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152386, XrefRangeEnd = 152414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass28_0.NativeMethodInfoPtr__Start_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C90D RID: 51469 RVA: 0x00061C99 File Offset: 0x0005FE99
			public __c__DisplayClass28_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EB8 RID: 16056
			// (get) Token: 0x0600C90E RID: 51470 RVA: 0x0030B32C File Offset: 0x0030952C
			// (set) Token: 0x0600C90F RID: 51471 RVA: 0x00061CA2 File Offset: 0x0005FEA2
			public unsafe Behaviour b
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass28_0.NativeFieldInfoPtr_b);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Behaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass28_0.NativeFieldInfoPtr_b), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EB9 RID: 16057
			// (get) Token: 0x0600C910 RID: 51472 RVA: 0x0030B35C File Offset: 0x0030955C
			// (set) Token: 0x0600C911 RID: 51473 RVA: 0x00061CC1 File Offset: 0x0005FEC1
			public unsafe NPCBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008813 RID: 34835
			private static readonly IntPtr NativeFieldInfoPtr_b;

			// Token: 0x04008814 RID: 34836
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008815 RID: 34837
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008816 RID: 34838
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__0_Internal_Void_0;

			// Token: 0x04008817 RID: 34839
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__1_Internal_Void_0;
		}

		// Token: 0x02000960 RID: 2400
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.NPCBehaviour+<>c__DisplayClass32_0")]
		public sealed class __c__DisplayClass32_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C912 RID: 51474 RVA: 0x0030B38C File Offset: 0x0030958C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass32_0()
			{
				Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "<>c__DisplayClass32_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0>.NativeClassPtr);
				NPCBehaviour.__c__DisplayClass32_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0>.NativeClassPtr, "<>4__this");
				NPCBehaviour.__c__DisplayClass32_0.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0>.NativeClassPtr, "duration");
				NPCBehaviour.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0>.NativeClassPtr, 100671409);
				NPCBehaviour.__c__DisplayClass32_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0>.NativeClassPtr, 100671410);
			}

			// Token: 0x0600C913 RID: 51475 RVA: 0x0030B408 File Offset: 0x00309608
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass32_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C914 RID: 51476 RVA: 0x0030B444 File Offset: 0x00309644
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152427, XrefRangeEnd = 152432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass32_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600C915 RID: 51477 RVA: 0x00061CE0 File Offset: 0x0005FEE0
			public __c__DisplayClass32_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EBA RID: 16058
			// (get) Token: 0x0600C916 RID: 51478 RVA: 0x0030B484 File Offset: 0x00309684
			// (set) Token: 0x0600C917 RID: 51479 RVA: 0x00061CE9 File Offset: 0x0005FEE9
			public unsafe NPCBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass32_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass32_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EBB RID: 16059
			// (get) Token: 0x0600C918 RID: 51480 RVA: 0x0030B4B4 File Offset: 0x003096B4
			// (set) Token: 0x0600C919 RID: 51481 RVA: 0x00061D08 File Offset: 0x0005FF08
			public unsafe float duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass32_0.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass32_0.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x04008818 RID: 34840
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008819 RID: 34841
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x0400881A RID: 34842
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400881B RID: 34843
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C40 RID: 3136
			[ObfuscatedName("ScheduleOne.NPCs.Behaviour.NPCBehaviour+<>c__DisplayClass32_0+<<Summon>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E227 RID: 57895 RVA: 0x003521A8 File Offset: 0x003503A8
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique()
				{
					Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0>.NativeClassPtr, "<<Summon>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr);
					NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>1__state");
					NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>2__current");
					NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>4__this");
					NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__t_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<t>5__2");
					NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100671411);
					NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100671412);
					NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100671413);
					NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100671414);
					NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100671415);
					NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100671416);
				}

				// Token: 0x0600E228 RID: 57896 RVA: 0x0035229C File Offset: 0x0035049C
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E229 RID: 57897 RVA: 0x003522E4 File Offset: 0x003504E4
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E22A RID: 57898 RVA: 0x00352318 File Offset: 0x00350518
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152414, XrefRangeEnd = 152422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x1700461F RID: 17951
				// (get) Token: 0x0600E22B RID: 57899 RVA: 0x00352354 File Offset: 0x00350554
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E22C RID: 57900 RVA: 0x00352394 File Offset: 0x00350594
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152422, XrefRangeEnd = 152427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004620 RID: 17952
				// (get) Token: 0x0600E22D RID: 57901 RVA: 0x003523C8 File Offset: 0x003505C8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E22E RID: 57902 RVA: 0x0006E40A File Offset: 0x0006C60A
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x1700461B RID: 17947
				// (get) Token: 0x0600E22F RID: 57903 RVA: 0x00352408 File Offset: 0x00350608
				// (set) Token: 0x0600E230 RID: 57904 RVA: 0x0006E413 File Offset: 0x0006C613
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700461C RID: 17948
				// (get) Token: 0x0600E231 RID: 57905 RVA: 0x00352430 File Offset: 0x00350630
				// (set) Token: 0x0600E232 RID: 57906 RVA: 0x0006E42E File Offset: 0x0006C62E
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700461D RID: 17949
				// (get) Token: 0x0600E233 RID: 57907 RVA: 0x00352460 File Offset: 0x00350660
				// (set) Token: 0x0600E234 RID: 57908 RVA: 0x0006E44D File Offset: 0x0006C64D
				public unsafe NPCBehaviour.__c__DisplayClass32_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCBehaviour.__c__DisplayClass32_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700461E RID: 17950
				// (get) Token: 0x0600E235 RID: 57909 RVA: 0x00352490 File Offset: 0x00350690
				// (set) Token: 0x0600E236 RID: 57910 RVA: 0x0006E46C File Offset: 0x0006C66C
				public unsafe float _t_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__t_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__t_5__2)) = value;
					}
				}

				// Token: 0x04009765 RID: 38757
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009766 RID: 38758
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009767 RID: 38759
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009768 RID: 38760
				private static readonly IntPtr NativeFieldInfoPtr__t_5__2;

				// Token: 0x04009769 RID: 38761
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400976A RID: 38762
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400976B RID: 38763
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400976C RID: 38764
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400976D RID: 38765
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400976E RID: 38766
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000961 RID: 2401
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.NPCBehaviour+<>c__DisplayClass36_0")]
		public sealed class __c__DisplayClass36_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C91A RID: 51482 RVA: 0x0030B4DC File Offset: 0x003096DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass36_0()
			{
				Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass36_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "<>c__DisplayClass36_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass36_0>.NativeClassPtr);
				NPCBehaviour.__c__DisplayClass36_0.NativeFieldInfoPtr_BehaviourName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass36_0>.NativeClassPtr, "BehaviourName");
				NPCBehaviour.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass36_0>.NativeClassPtr, 100671417);
				NPCBehaviour.__c__DisplayClass36_0.NativeMethodInfoPtr__GetBehaviour_b__0_Internal_Boolean_Behaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass36_0>.NativeClassPtr, 100671418);
			}

			// Token: 0x0600C91B RID: 51483 RVA: 0x0030B544 File Offset: 0x00309744
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass36_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass36_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C91C RID: 51484 RVA: 0x0030B580 File Offset: 0x00309780
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152432, XrefRangeEnd = 152450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetBehaviour_b__0(Behaviour x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass36_0.NativeMethodInfoPtr__GetBehaviour_b__0_Internal_Boolean_Behaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C91D RID: 51485 RVA: 0x00061D23 File Offset: 0x0005FF23
			public __c__DisplayClass36_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EBC RID: 16060
			// (get) Token: 0x0600C91E RID: 51486 RVA: 0x0030B5D0 File Offset: 0x003097D0
			// (set) Token: 0x0600C91F RID: 51487 RVA: 0x00061D2C File Offset: 0x0005FF2C
			public unsafe string BehaviourName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass36_0.NativeFieldInfoPtr_BehaviourName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass36_0.NativeFieldInfoPtr_BehaviourName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400881C RID: 34844
			private static readonly IntPtr NativeFieldInfoPtr_BehaviourName;

			// Token: 0x0400881D RID: 34845
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400881E RID: 34846
			private static readonly IntPtr NativeMethodInfoPtr__GetBehaviour_b__0_Internal_Boolean_Behaviour_0;
		}
	}
}
