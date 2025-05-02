using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Combat;
using Il2CppScheduleOne.Noise;
using Il2CppScheduleOne.NPCs.Actions;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Vehicles;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Responses
{
	// Token: 0x020002EE RID: 750
	public class NPCResponses : MonoBehaviour
	{
		// Token: 0x060038A0 RID: 14496 RVA: 0x001284E0 File Offset: 0x001266E0
		// Note: this type is marked as 'beforefieldinit'.
		static NPCResponses()
		{
			Il2CppClassPointerStore<NPCResponses>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Responses", "NPCResponses");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr);
			NPCResponses.NativeFieldInfoPtr_ASSAULT_RELATIONSHIPCHANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, "ASSAULT_RELATIONSHIPCHANGE");
			NPCResponses.NativeFieldInfoPtr_DEADLYASSAULT_RELATIONSHIPCHANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, "DEADLYASSAULT_RELATIONSHIPCHANGE");
			NPCResponses.NativeFieldInfoPtr_AIMED_AT_RELATIONSHIPCHANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, "AIMED_AT_RELATIONSHIPCHANGE");
			NPCResponses.NativeFieldInfoPtr_PICKPOCKET_RELATIONSHIPCHANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, "PICKPOCKET_RELATIONSHIPCHANGE");
			NPCResponses.NativeFieldInfoPtr__npc_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, "<npc>k__BackingField");
			NPCResponses.NativeFieldInfoPtr_timeSinceLastImpact = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, "timeSinceLastImpact");
			NPCResponses.NativeFieldInfoPtr_timeSinceAimedAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, "timeSinceAimedAt");
			NPCResponses.NativeMethodInfoPtr_get_npc_Protected_get_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669868);
			NPCResponses.NativeMethodInfoPtr_set_npc_Private_set_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669869);
			NPCResponses.NativeMethodInfoPtr_get_actions_Protected_get_NPCActions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669870);
			NPCResponses.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669871);
			NPCResponses.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669872);
			NPCResponses.NativeMethodInfoPtr_GunshotHeard_Public_Virtual_New_Void_NoiseEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669873);
			NPCResponses.NativeMethodInfoPtr_ExplosionHeard_Public_Virtual_New_Void_NoiseEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669874);
			NPCResponses.NativeMethodInfoPtr_NoticedPettyCrime_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669875);
			NPCResponses.NativeMethodInfoPtr_NoticedVandalism_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669876);
			NPCResponses.NativeMethodInfoPtr_SawPickpocketing_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669877);
			NPCResponses.NativeMethodInfoPtr_NoticePlayerBrandishingWeapon_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669878);
			NPCResponses.NativeMethodInfoPtr_NoticePlayerDischargingWeapon_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669879);
			NPCResponses.NativeMethodInfoPtr_PlayerFailedPickpocket_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669880);
			NPCResponses.NativeMethodInfoPtr_NoticedDrugDeal_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669881);
			NPCResponses.NativeMethodInfoPtr_NoticedViolatingCurfew_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669882);
			NPCResponses.NativeMethodInfoPtr_NoticedWantedPlayer_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669883);
			NPCResponses.NativeMethodInfoPtr_NoticedSuspiciousPlayer_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669884);
			NPCResponses.NativeMethodInfoPtr_HitByCar_Public_Virtual_New_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669885);
			NPCResponses.NativeMethodInfoPtr_ImpactReceived_Public_Virtual_New_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669886);
			NPCResponses.NativeMethodInfoPtr_RespondToFirstNonLethalAttack_Protected_Virtual_New_Void_Player_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669887);
			NPCResponses.NativeMethodInfoPtr_RespondToRepeatedNonLethalAttack_Protected_Virtual_New_Void_Player_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669888);
			NPCResponses.NativeMethodInfoPtr_RespondToLethalAttack_Protected_Virtual_New_Void_Player_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669889);
			NPCResponses.NativeMethodInfoPtr_RespondToAnnoyingImpact_Protected_Virtual_New_Void_Player_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669890);
			NPCResponses.NativeMethodInfoPtr_RespondToAimedAt_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669891);
			NPCResponses.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100669892);
		}

		// Token: 0x1700120A RID: 4618
		// (get) Token: 0x060038A1 RID: 14497 RVA: 0x00128790 File Offset: 0x00126990
		// (set) Token: 0x060038A2 RID: 14498 RVA: 0x001287D0 File Offset: 0x001269D0
		public unsafe NPC npc
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17399, RefRangeEnd = 17400, XrefRangeStart = 17399, XrefRangeEnd = 17400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCResponses.NativeMethodInfoPtr_get_npc_Protected_get_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCResponses.NativeMethodInfoPtr_set_npc_Private_set_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700120B RID: 4619
		// (get) Token: 0x060038A3 RID: 14499 RVA: 0x00128814 File Offset: 0x00126A14
		public unsafe NPCActions actions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCResponses.NativeMethodInfoPtr_get_actions_Protected_get_NPCActions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPCActions>(intPtr3) : null;
			}
		}

		// Token: 0x060038A4 RID: 14500 RVA: 0x00128854 File Offset: 0x00126A54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 141536, RefRangeEnd = 141537, XrefRangeStart = 141532, XrefRangeEnd = 141536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A5 RID: 14501 RVA: 0x00128890 File Offset: 0x00126A90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141537, XrefRangeEnd = 141539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A6 RID: 14502 RVA: 0x001288CC File Offset: 0x00126ACC
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GunshotHeard(NoiseEvent gunshotSound)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gunshotSound);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_GunshotHeard_Public_Virtual_New_Void_NoiseEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A7 RID: 14503 RVA: 0x0012891C File Offset: 0x00126B1C
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ExplosionHeard(NoiseEvent explosionSound)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(explosionSound);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_ExplosionHeard_Public_Virtual_New_Void_NoiseEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A8 RID: 14504 RVA: 0x0012896C File Offset: 0x00126B6C
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NoticedPettyCrime(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_NoticedPettyCrime_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A9 RID: 14505 RVA: 0x001289BC File Offset: 0x00126BBC
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NoticedVandalism(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_NoticedVandalism_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038AA RID: 14506 RVA: 0x00128A0C File Offset: 0x00126C0C
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SawPickpocketing(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_SawPickpocketing_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038AB RID: 14507 RVA: 0x00128A5C File Offset: 0x00126C5C
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NoticePlayerBrandishingWeapon(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_NoticePlayerBrandishingWeapon_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038AC RID: 14508 RVA: 0x00128AAC File Offset: 0x00126CAC
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NoticePlayerDischargingWeapon(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_NoticePlayerDischargingWeapon_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038AD RID: 14509 RVA: 0x00128AFC File Offset: 0x00126CFC
		[CallerCount(0)]
		public unsafe virtual void PlayerFailedPickpocket(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_PlayerFailedPickpocket_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038AE RID: 14510 RVA: 0x00128B4C File Offset: 0x00126D4C
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NoticedDrugDeal(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_NoticedDrugDeal_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038AF RID: 14511 RVA: 0x00128B9C File Offset: 0x00126D9C
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NoticedViolatingCurfew(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_NoticedViolatingCurfew_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038B0 RID: 14512 RVA: 0x00128BEC File Offset: 0x00126DEC
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NoticedWantedPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_NoticedWantedPlayer_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038B1 RID: 14513 RVA: 0x00128C3C File Offset: 0x00126E3C
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NoticedSuspiciousPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_NoticedSuspiciousPlayer_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038B2 RID: 14514 RVA: 0x00128C8C File Offset: 0x00126E8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 141564, RefRangeEnd = 141565, XrefRangeStart = 141539, XrefRangeEnd = 141564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HitByCar(LandVehicle vehicle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_HitByCar_Public_Virtual_New_Void_LandVehicle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038B3 RID: 14515 RVA: 0x00128CDC File Offset: 0x00126EDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 141567, RefRangeEnd = 141568, XrefRangeStart = 141565, XrefRangeEnd = 141567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ImpactReceived(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_ImpactReceived_Public_Virtual_New_Void_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038B4 RID: 14516 RVA: 0x00128D2C File Offset: 0x00126F2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 141568, RefRangeEnd = 141570, XrefRangeStart = 141568, XrefRangeEnd = 141568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RespondToFirstNonLethalAttack(Player perpetrator, Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(perpetrator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_RespondToFirstNonLethalAttack_Protected_Virtual_New_Void_Player_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038B5 RID: 14517 RVA: 0x00128D8C File Offset: 0x00126F8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 141570, RefRangeEnd = 141572, XrefRangeStart = 141570, XrefRangeEnd = 141570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RespondToRepeatedNonLethalAttack(Player perpetrator, Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(perpetrator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_RespondToRepeatedNonLethalAttack_Protected_Virtual_New_Void_Player_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038B6 RID: 14518 RVA: 0x00128DEC File Offset: 0x00126FEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 141572, RefRangeEnd = 141574, XrefRangeStart = 141572, XrefRangeEnd = 141572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RespondToLethalAttack(Player perpetrator, Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(perpetrator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_RespondToLethalAttack_Protected_Virtual_New_Void_Player_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038B7 RID: 14519 RVA: 0x00128E4C File Offset: 0x0012704C
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RespondToAnnoyingImpact(Player perpetrator, Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(perpetrator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_RespondToAnnoyingImpact_Protected_Virtual_New_Void_Player_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038B8 RID: 14520 RVA: 0x00128EAC File Offset: 0x001270AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 141574, RefRangeEnd = 141575, XrefRangeStart = 141574, XrefRangeEnd = 141574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RespondToAimedAt(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_RespondToAimedAt_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038B9 RID: 14521 RVA: 0x00128EFC File Offset: 0x001270FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 141576, RefRangeEnd = 141578, XrefRangeStart = 141575, XrefRangeEnd = 141576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCResponses() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCResponses.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038BA RID: 14522 RVA: 0x0001D399 File Offset: 0x0001B599
		public NPCResponses(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001203 RID: 4611
		// (get) Token: 0x060038BB RID: 14523 RVA: 0x00128F38 File Offset: 0x00127138
		// (set) Token: 0x060038BC RID: 14524 RVA: 0x0001D3A2 File Offset: 0x0001B5A2
		public unsafe static float ASSAULT_RELATIONSHIPCHANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCResponses.NativeFieldInfoPtr_ASSAULT_RELATIONSHIPCHANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCResponses.NativeFieldInfoPtr_ASSAULT_RELATIONSHIPCHANGE, (void*)(&value));
			}
		}

		// Token: 0x17001204 RID: 4612
		// (get) Token: 0x060038BD RID: 14525 RVA: 0x00128F54 File Offset: 0x00127154
		// (set) Token: 0x060038BE RID: 14526 RVA: 0x0001D3B0 File Offset: 0x0001B5B0
		public unsafe static float DEADLYASSAULT_RELATIONSHIPCHANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCResponses.NativeFieldInfoPtr_DEADLYASSAULT_RELATIONSHIPCHANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCResponses.NativeFieldInfoPtr_DEADLYASSAULT_RELATIONSHIPCHANGE, (void*)(&value));
			}
		}

		// Token: 0x17001205 RID: 4613
		// (get) Token: 0x060038BF RID: 14527 RVA: 0x00128F70 File Offset: 0x00127170
		// (set) Token: 0x060038C0 RID: 14528 RVA: 0x0001D3BE File Offset: 0x0001B5BE
		public unsafe static float AIMED_AT_RELATIONSHIPCHANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCResponses.NativeFieldInfoPtr_AIMED_AT_RELATIONSHIPCHANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCResponses.NativeFieldInfoPtr_AIMED_AT_RELATIONSHIPCHANGE, (void*)(&value));
			}
		}

		// Token: 0x17001206 RID: 4614
		// (get) Token: 0x060038C1 RID: 14529 RVA: 0x00128F8C File Offset: 0x0012718C
		// (set) Token: 0x060038C2 RID: 14530 RVA: 0x0001D3CC File Offset: 0x0001B5CC
		public unsafe static float PICKPOCKET_RELATIONSHIPCHANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCResponses.NativeFieldInfoPtr_PICKPOCKET_RELATIONSHIPCHANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCResponses.NativeFieldInfoPtr_PICKPOCKET_RELATIONSHIPCHANGE, (void*)(&value));
			}
		}

		// Token: 0x17001207 RID: 4615
		// (get) Token: 0x060038C3 RID: 14531 RVA: 0x00128FA8 File Offset: 0x001271A8
		// (set) Token: 0x060038C4 RID: 14532 RVA: 0x0001D3DA File Offset: 0x0001B5DA
		public unsafe NPC _npc_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCResponses.NativeFieldInfoPtr__npc_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCResponses.NativeFieldInfoPtr__npc_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001208 RID: 4616
		// (get) Token: 0x060038C5 RID: 14533 RVA: 0x00128FD8 File Offset: 0x001271D8
		// (set) Token: 0x060038C6 RID: 14534 RVA: 0x0001D3F9 File Offset: 0x0001B5F9
		public unsafe float timeSinceLastImpact
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCResponses.NativeFieldInfoPtr_timeSinceLastImpact);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCResponses.NativeFieldInfoPtr_timeSinceLastImpact)) = value;
			}
		}

		// Token: 0x17001209 RID: 4617
		// (get) Token: 0x060038C7 RID: 14535 RVA: 0x00129000 File Offset: 0x00127200
		// (set) Token: 0x060038C8 RID: 14536 RVA: 0x0001D414 File Offset: 0x0001B614
		public unsafe float timeSinceAimedAt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCResponses.NativeFieldInfoPtr_timeSinceAimedAt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCResponses.NativeFieldInfoPtr_timeSinceAimedAt)) = value;
			}
		}

		// Token: 0x04002552 RID: 9554
		private static readonly IntPtr NativeFieldInfoPtr_ASSAULT_RELATIONSHIPCHANGE;

		// Token: 0x04002553 RID: 9555
		private static readonly IntPtr NativeFieldInfoPtr_DEADLYASSAULT_RELATIONSHIPCHANGE;

		// Token: 0x04002554 RID: 9556
		private static readonly IntPtr NativeFieldInfoPtr_AIMED_AT_RELATIONSHIPCHANGE;

		// Token: 0x04002555 RID: 9557
		private static readonly IntPtr NativeFieldInfoPtr_PICKPOCKET_RELATIONSHIPCHANGE;

		// Token: 0x04002556 RID: 9558
		private static readonly IntPtr NativeFieldInfoPtr__npc_k__BackingField;

		// Token: 0x04002557 RID: 9559
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastImpact;

		// Token: 0x04002558 RID: 9560
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceAimedAt;

		// Token: 0x04002559 RID: 9561
		private static readonly IntPtr NativeMethodInfoPtr_get_npc_Protected_get_NPC_0;

		// Token: 0x0400255A RID: 9562
		private static readonly IntPtr NativeMethodInfoPtr_set_npc_Private_set_Void_NPC_0;

		// Token: 0x0400255B RID: 9563
		private static readonly IntPtr NativeMethodInfoPtr_get_actions_Protected_get_NPCActions_0;

		// Token: 0x0400255C RID: 9564
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x0400255D RID: 9565
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x0400255E RID: 9566
		private static readonly IntPtr NativeMethodInfoPtr_GunshotHeard_Public_Virtual_New_Void_NoiseEvent_0;

		// Token: 0x0400255F RID: 9567
		private static readonly IntPtr NativeMethodInfoPtr_ExplosionHeard_Public_Virtual_New_Void_NoiseEvent_0;

		// Token: 0x04002560 RID: 9568
		private static readonly IntPtr NativeMethodInfoPtr_NoticedPettyCrime_Public_Virtual_New_Void_Player_0;

		// Token: 0x04002561 RID: 9569
		private static readonly IntPtr NativeMethodInfoPtr_NoticedVandalism_Public_Virtual_New_Void_Player_0;

		// Token: 0x04002562 RID: 9570
		private static readonly IntPtr NativeMethodInfoPtr_SawPickpocketing_Public_Virtual_New_Void_Player_0;

		// Token: 0x04002563 RID: 9571
		private static readonly IntPtr NativeMethodInfoPtr_NoticePlayerBrandishingWeapon_Public_Virtual_New_Void_Player_0;

		// Token: 0x04002564 RID: 9572
		private static readonly IntPtr NativeMethodInfoPtr_NoticePlayerDischargingWeapon_Public_Virtual_New_Void_Player_0;

		// Token: 0x04002565 RID: 9573
		private static readonly IntPtr NativeMethodInfoPtr_PlayerFailedPickpocket_Public_Virtual_New_Void_Player_0;

		// Token: 0x04002566 RID: 9574
		private static readonly IntPtr NativeMethodInfoPtr_NoticedDrugDeal_Public_Virtual_New_Void_Player_0;

		// Token: 0x04002567 RID: 9575
		private static readonly IntPtr NativeMethodInfoPtr_NoticedViolatingCurfew_Public_Virtual_New_Void_Player_0;

		// Token: 0x04002568 RID: 9576
		private static readonly IntPtr NativeMethodInfoPtr_NoticedWantedPlayer_Public_Virtual_New_Void_Player_0;

		// Token: 0x04002569 RID: 9577
		private static readonly IntPtr NativeMethodInfoPtr_NoticedSuspiciousPlayer_Public_Virtual_New_Void_Player_0;

		// Token: 0x0400256A RID: 9578
		private static readonly IntPtr NativeMethodInfoPtr_HitByCar_Public_Virtual_New_Void_LandVehicle_0;

		// Token: 0x0400256B RID: 9579
		private static readonly IntPtr NativeMethodInfoPtr_ImpactReceived_Public_Virtual_New_Void_Impact_0;

		// Token: 0x0400256C RID: 9580
		private static readonly IntPtr NativeMethodInfoPtr_RespondToFirstNonLethalAttack_Protected_Virtual_New_Void_Player_Impact_0;

		// Token: 0x0400256D RID: 9581
		private static readonly IntPtr NativeMethodInfoPtr_RespondToRepeatedNonLethalAttack_Protected_Virtual_New_Void_Player_Impact_0;

		// Token: 0x0400256E RID: 9582
		private static readonly IntPtr NativeMethodInfoPtr_RespondToLethalAttack_Protected_Virtual_New_Void_Player_Impact_0;

		// Token: 0x0400256F RID: 9583
		private static readonly IntPtr NativeMethodInfoPtr_RespondToAnnoyingImpact_Protected_Virtual_New_Void_Player_Impact_0;

		// Token: 0x04002570 RID: 9584
		private static readonly IntPtr NativeMethodInfoPtr_RespondToAimedAt_Public_Virtual_New_Void_Player_0;

		// Token: 0x04002571 RID: 9585
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
