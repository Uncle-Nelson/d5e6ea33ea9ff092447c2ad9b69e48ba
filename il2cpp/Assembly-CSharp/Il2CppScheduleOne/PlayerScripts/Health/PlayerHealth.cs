using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.PlayerScripts.Health
{
	// Token: 0x020003EE RID: 1006
	public class PlayerHealth : NetworkBehaviour
	{
		// Token: 0x060052D5 RID: 21205 RVA: 0x001871E0 File Offset: 0x001853E0
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerHealth()
		{
			Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts.Health", "PlayerHealth");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr);
			PlayerHealth.NativeFieldInfoPtr_MAX_HEALTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "MAX_HEALTH");
			PlayerHealth.NativeFieldInfoPtr_HEALTH_RECOVERY_PER_MINUTE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "HEALTH_RECOVERY_PER_MINUTE");
			PlayerHealth.NativeFieldInfoPtr__IsAlive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "<IsAlive>k__BackingField");
			PlayerHealth.NativeFieldInfoPtr__CurrentHealth_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "<CurrentHealth>k__BackingField");
			PlayerHealth.NativeFieldInfoPtr__TimeSinceLastDamage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "<TimeSinceLastDamage>k__BackingField");
			PlayerHealth.NativeFieldInfoPtr_Player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "Player");
			PlayerHealth.NativeFieldInfoPtr_BloodParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "BloodParticles");
			PlayerHealth.NativeFieldInfoPtr_onHealthChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "onHealthChanged");
			PlayerHealth.NativeFieldInfoPtr_onDie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "onDie");
			PlayerHealth.NativeFieldInfoPtr_onRevive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "onRevive");
			PlayerHealth.NativeFieldInfoPtr_AfflictedWithLethalEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "AfflictedWithLethalEffect");
			PlayerHealth.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.PlayerScripts.Health.PlayerHealthAssembly-CSharp.dll_Excuted");
			PlayerHealth.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.PlayerScripts.Health.PlayerHealthAssembly-CSharp.dll_Excuted");
			PlayerHealth.NativeMethodInfoPtr_get_IsAlive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673642);
			PlayerHealth.NativeMethodInfoPtr_set_IsAlive_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673643);
			PlayerHealth.NativeMethodInfoPtr_get_CurrentHealth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673644);
			PlayerHealth.NativeMethodInfoPtr_set_CurrentHealth_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673645);
			PlayerHealth.NativeMethodInfoPtr_get_TimeSinceLastDamage_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673646);
			PlayerHealth.NativeMethodInfoPtr_set_TimeSinceLastDamage_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673647);
			PlayerHealth.NativeMethodInfoPtr_get_CanTakeDamage_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673648);
			PlayerHealth.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673649);
			PlayerHealth.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673650);
			PlayerHealth.NativeMethodInfoPtr_TakeDamage_Public_Void_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673651);
			PlayerHealth.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673652);
			PlayerHealth.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673653);
			PlayerHealth.NativeMethodInfoPtr_SetAfflictedWithLethalEffect_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673654);
			PlayerHealth.NativeMethodInfoPtr_RecoverHealth_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673655);
			PlayerHealth.NativeMethodInfoPtr_SetHealth_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673656);
			PlayerHealth.NativeMethodInfoPtr_SendDie_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673657);
			PlayerHealth.NativeMethodInfoPtr_Die_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673658);
			PlayerHealth.NativeMethodInfoPtr_SendRevive_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673659);
			PlayerHealth.NativeMethodInfoPtr_Revive_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673660);
			PlayerHealth.NativeMethodInfoPtr_PlayBloodMist_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673661);
			PlayerHealth.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673662);
			PlayerHealth.NativeMethodInfoPtr__Awake_b__22_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673663);
			PlayerHealth.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673664);
			PlayerHealth.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673665);
			PlayerHealth.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673666);
			PlayerHealth.NativeMethodInfoPtr_RpcWriter___Observers_TakeDamage_3505310624_Private_Void_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673667);
			PlayerHealth.NativeMethodInfoPtr_RpcLogic___TakeDamage_3505310624_Public_Void_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673668);
			PlayerHealth.NativeMethodInfoPtr_RpcReader___Observers_TakeDamage_3505310624_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673669);
			PlayerHealth.NativeMethodInfoPtr_RpcWriter___Server_SendDie_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673670);
			PlayerHealth.NativeMethodInfoPtr_RpcLogic___SendDie_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673671);
			PlayerHealth.NativeMethodInfoPtr_RpcReader___Server_SendDie_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673672);
			PlayerHealth.NativeMethodInfoPtr_RpcWriter___Observers_Die_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673673);
			PlayerHealth.NativeMethodInfoPtr_RpcLogic___Die_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673674);
			PlayerHealth.NativeMethodInfoPtr_RpcReader___Observers_Die_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673675);
			PlayerHealth.NativeMethodInfoPtr_RpcWriter___Server_SendRevive_3848837105_Private_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673676);
			PlayerHealth.NativeMethodInfoPtr_RpcLogic___SendRevive_3848837105_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673677);
			PlayerHealth.NativeMethodInfoPtr_RpcReader___Server_SendRevive_3848837105_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673678);
			PlayerHealth.NativeMethodInfoPtr_RpcWriter___Observers_Revive_3848837105_Private_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673679);
			PlayerHealth.NativeMethodInfoPtr_RpcLogic___Revive_3848837105_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673680);
			PlayerHealth.NativeMethodInfoPtr_RpcReader___Observers_Revive_3848837105_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673681);
			PlayerHealth.NativeMethodInfoPtr_RpcWriter___Observers_PlayBloodMist_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673682);
			PlayerHealth.NativeMethodInfoPtr_RpcLogic___PlayBloodMist_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673683);
			PlayerHealth.NativeMethodInfoPtr_RpcReader___Observers_PlayBloodMist_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673684);
			PlayerHealth.NativeMethodInfoPtr_Method_Private_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673685);
		}

		// Token: 0x17001905 RID: 6405
		// (get) Token: 0x060052D6 RID: 21206 RVA: 0x00187684 File Offset: 0x00185884
		// (set) Token: 0x060052D7 RID: 21207 RVA: 0x001876C0 File Offset: 0x001858C0
		public unsafe bool IsAlive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_get_IsAlive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_set_IsAlive_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001906 RID: 6406
		// (get) Token: 0x060052D8 RID: 21208 RVA: 0x00187700 File Offset: 0x00185900
		// (set) Token: 0x060052D9 RID: 21209 RVA: 0x0018773C File Offset: 0x0018593C
		public unsafe float CurrentHealth
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 86625, RefRangeEnd = 86627, XrefRangeStart = 86625, XrefRangeEnd = 86627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_get_CurrentHealth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_set_CurrentHealth_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001907 RID: 6407
		// (get) Token: 0x060052DA RID: 21210 RVA: 0x0018777C File Offset: 0x0018597C
		// (set) Token: 0x060052DB RID: 21211 RVA: 0x001877B8 File Offset: 0x001859B8
		public unsafe float TimeSinceLastDamage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_get_TimeSinceLastDamage_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_set_TimeSinceLastDamage_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001908 RID: 6408
		// (get) Token: 0x060052DC RID: 21212 RVA: 0x001877F8 File Offset: 0x001859F8
		public unsafe bool CanTakeDamage
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 178185, RefRangeEnd = 178186, XrefRangeStart = 178179, XrefRangeEnd = 178185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_get_CanTakeDamage_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060052DD RID: 21213 RVA: 0x00187834 File Offset: 0x00185A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178186, XrefRangeEnd = 178198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerHealth.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052DE RID: 21214 RVA: 0x00187870 File Offset: 0x00185A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178198, XrefRangeEnd = 178230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052DF RID: 21215 RVA: 0x001878A4 File Offset: 0x00185AA4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 178242, RefRangeEnd = 178246, XrefRangeStart = 178230, XrefRangeEnd = 178242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TakeDamage(float damage, bool flinch = true, bool playBloodMist = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref damage;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flinch;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playBloodMist;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_TakeDamage_Public_Void_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052E0 RID: 21216 RVA: 0x00187900 File Offset: 0x00185B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178246, XrefRangeEnd = 178260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052E1 RID: 21217 RVA: 0x00187934 File Offset: 0x00185B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178260, XrefRangeEnd = 178270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052E2 RID: 21218 RVA: 0x00187968 File Offset: 0x00185B68
		[CallerCount(0)]
		public unsafe void SetAfflictedWithLethalEffect(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_SetAfflictedWithLethalEffect_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052E3 RID: 21219 RVA: 0x001879A8 File Offset: 0x00185BA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 178280, RefRangeEnd = 178282, XrefRangeStart = 178270, XrefRangeEnd = 178280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecoverHealth(float recovery)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref recovery;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RecoverHealth_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052E4 RID: 21220 RVA: 0x001879E8 File Offset: 0x00185BE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 178287, RefRangeEnd = 178289, XrefRangeStart = 178282, XrefRangeEnd = 178287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHealth(float health)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref health;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_SetHealth_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052E5 RID: 21221 RVA: 0x00187A28 File Offset: 0x00185C28
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 178310, RefRangeEnd = 178313, XrefRangeStart = 178289, XrefRangeEnd = 178310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendDie()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_SendDie_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052E6 RID: 21222 RVA: 0x00187A5C File Offset: 0x00185C5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 178334, RefRangeEnd = 178336, XrefRangeStart = 178313, XrefRangeEnd = 178334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Die()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_Die_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052E7 RID: 21223 RVA: 0x00187A90 File Offset: 0x00185C90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 178339, RefRangeEnd = 178340, XrefRangeStart = 178336, XrefRangeEnd = 178339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendRevive(Vector3 position, Quaternion rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_SendRevive_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052E8 RID: 21224 RVA: 0x00187ADC File Offset: 0x00185CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178340, XrefRangeEnd = 178342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Revive(Vector3 position, Quaternion rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_Revive_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052E9 RID: 21225 RVA: 0x00187B28 File Offset: 0x00185D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178342, XrefRangeEnd = 178360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayBloodMist()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_PlayBloodMist_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052EA RID: 21226 RVA: 0x00187B5C File Offset: 0x00185D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178360, XrefRangeEnd = 178361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerHealth() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052EB RID: 21227 RVA: 0x00187B98 File Offset: 0x00185D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178361, XrefRangeEnd = 178365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__22_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr__Awake_b__22_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052EC RID: 21228 RVA: 0x00187BCC File Offset: 0x00185DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178365, XrefRangeEnd = 178403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerHealth.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052ED RID: 21229 RVA: 0x00187C08 File Offset: 0x00185E08
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerHealth.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052EE RID: 21230 RVA: 0x00187C44 File Offset: 0x00185E44
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerHealth.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052EF RID: 21231 RVA: 0x00187C80 File Offset: 0x00185E80
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 178242, RefRangeEnd = 178246, XrefRangeStart = 178242, XrefRangeEnd = 178246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_TakeDamage_3505310624(float damage, bool flinch = true, bool playBloodMist = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref damage;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flinch;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playBloodMist;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcWriter___Observers_TakeDamage_3505310624_Private_Void_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052F0 RID: 21232 RVA: 0x00187CDC File Offset: 0x00185EDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 178456, RefRangeEnd = 178457, XrefRangeStart = 178403, XrefRangeEnd = 178456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___TakeDamage_3505310624(float damage, bool flinch = true, bool playBloodMist = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref damage;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flinch;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playBloodMist;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcLogic___TakeDamage_3505310624_Public_Void_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052F1 RID: 21233 RVA: 0x00187D38 File Offset: 0x00185F38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178457, XrefRangeEnd = 178460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_TakeDamage_3505310624(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcReader___Observers_TakeDamage_3505310624_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052F2 RID: 21234 RVA: 0x00187D88 File Offset: 0x00185F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178460, XrefRangeEnd = 178478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendDie_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcWriter___Server_SendDie_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052F3 RID: 21235 RVA: 0x00187DBC File Offset: 0x00185FBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 178334, RefRangeEnd = 178336, XrefRangeStart = 178334, XrefRangeEnd = 178336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendDie_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcLogic___SendDie_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052F4 RID: 21236 RVA: 0x00187DF0 File Offset: 0x00185FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178478, XrefRangeEnd = 178481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendDie_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcReader___Server_SendDie_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052F5 RID: 21237 RVA: 0x00187E54 File Offset: 0x00186054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178481, XrefRangeEnd = 178499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Die_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcWriter___Observers_Die_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052F6 RID: 21238 RVA: 0x00187E88 File Offset: 0x00186088
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 178519, RefRangeEnd = 178522, XrefRangeStart = 178499, XrefRangeEnd = 178519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Die_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcLogic___Die_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052F7 RID: 21239 RVA: 0x00187EBC File Offset: 0x001860BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178522, XrefRangeEnd = 178525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Die_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcReader___Observers_Die_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052F8 RID: 21240 RVA: 0x00187F0C File Offset: 0x0018610C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 178558, RefRangeEnd = 178559, XrefRangeStart = 178525, XrefRangeEnd = 178558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendRevive_3848837105(Vector3 position, Quaternion rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcWriter___Server_SendRevive_3848837105_Private_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052F9 RID: 21241 RVA: 0x00187F58 File Offset: 0x00186158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendRevive_3848837105(Vector3 position, Quaternion rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcLogic___SendRevive_3848837105_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052FA RID: 21242 RVA: 0x00187FA4 File Offset: 0x001861A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178559, XrefRangeEnd = 178568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendRevive_3848837105(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcReader___Server_SendRevive_3848837105_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052FB RID: 21243 RVA: 0x00188008 File Offset: 0x00186208
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 178592, RefRangeEnd = 178596, XrefRangeStart = 178568, XrefRangeEnd = 178592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Revive_3848837105(Vector3 position, Quaternion rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcWriter___Observers_Revive_3848837105_Private_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052FC RID: 21244 RVA: 0x00188054 File Offset: 0x00186254
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 178626, RefRangeEnd = 178631, XrefRangeStart = 178596, XrefRangeEnd = 178626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Revive_3848837105(Vector3 position, Quaternion rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcLogic___Revive_3848837105_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052FD RID: 21245 RVA: 0x001880A0 File Offset: 0x001862A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178631, XrefRangeEnd = 178639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Revive_3848837105(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcReader___Observers_Revive_3848837105_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052FE RID: 21246 RVA: 0x001880F0 File Offset: 0x001862F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_PlayBloodMist_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcWriter___Observers_PlayBloodMist_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052FF RID: 21247 RVA: 0x00188124 File Offset: 0x00186324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178639, XrefRangeEnd = 178646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___PlayBloodMist_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcLogic___PlayBloodMist_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005300 RID: 21248 RVA: 0x00188158 File Offset: 0x00186358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178646, XrefRangeEnd = 178653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_PlayBloodMist_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcReader___Observers_PlayBloodMist_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005301 RID: 21249 RVA: 0x001881A8 File Offset: 0x001863A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178653, XrefRangeEnd = 178665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_Method_Private_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005302 RID: 21250 RVA: 0x00027879 File Offset: 0x00025A79
		public PlayerHealth(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170018F8 RID: 6392
		// (get) Token: 0x06005303 RID: 21251 RVA: 0x001881DC File Offset: 0x001863DC
		// (set) Token: 0x06005304 RID: 21252 RVA: 0x00027882 File Offset: 0x00025A82
		public unsafe static float MAX_HEALTH
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerHealth.NativeFieldInfoPtr_MAX_HEALTH, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerHealth.NativeFieldInfoPtr_MAX_HEALTH, (void*)(&value));
			}
		}

		// Token: 0x170018F9 RID: 6393
		// (get) Token: 0x06005305 RID: 21253 RVA: 0x001881F8 File Offset: 0x001863F8
		// (set) Token: 0x06005306 RID: 21254 RVA: 0x00027890 File Offset: 0x00025A90
		public unsafe static float HEALTH_RECOVERY_PER_MINUTE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerHealth.NativeFieldInfoPtr_HEALTH_RECOVERY_PER_MINUTE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerHealth.NativeFieldInfoPtr_HEALTH_RECOVERY_PER_MINUTE, (void*)(&value));
			}
		}

		// Token: 0x170018FA RID: 6394
		// (get) Token: 0x06005307 RID: 21255 RVA: 0x00188214 File Offset: 0x00186414
		// (set) Token: 0x06005308 RID: 21256 RVA: 0x0002789E File Offset: 0x00025A9E
		public unsafe bool _IsAlive_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr__IsAlive_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr__IsAlive_k__BackingField)) = value;
			}
		}

		// Token: 0x170018FB RID: 6395
		// (get) Token: 0x06005309 RID: 21257 RVA: 0x0018823C File Offset: 0x0018643C
		// (set) Token: 0x0600530A RID: 21258 RVA: 0x000278B9 File Offset: 0x00025AB9
		public unsafe float _CurrentHealth_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr__CurrentHealth_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr__CurrentHealth_k__BackingField)) = value;
			}
		}

		// Token: 0x170018FC RID: 6396
		// (get) Token: 0x0600530B RID: 21259 RVA: 0x00188264 File Offset: 0x00186464
		// (set) Token: 0x0600530C RID: 21260 RVA: 0x000278D4 File Offset: 0x00025AD4
		public unsafe float _TimeSinceLastDamage_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr__TimeSinceLastDamage_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr__TimeSinceLastDamage_k__BackingField)) = value;
			}
		}

		// Token: 0x170018FD RID: 6397
		// (get) Token: 0x0600530D RID: 21261 RVA: 0x0018828C File Offset: 0x0018648C
		// (set) Token: 0x0600530E RID: 21262 RVA: 0x000278EF File Offset: 0x00025AEF
		public unsafe Player Player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_Player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_Player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018FE RID: 6398
		// (get) Token: 0x0600530F RID: 21263 RVA: 0x001882BC File Offset: 0x001864BC
		// (set) Token: 0x06005310 RID: 21264 RVA: 0x0002790E File Offset: 0x00025B0E
		public unsafe ParticleSystem BloodParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_BloodParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_BloodParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018FF RID: 6399
		// (get) Token: 0x06005311 RID: 21265 RVA: 0x001882EC File Offset: 0x001864EC
		// (set) Token: 0x06005312 RID: 21266 RVA: 0x0002792D File Offset: 0x00025B2D
		public unsafe UnityEvent<float> onHealthChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_onHealthChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_onHealthChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001900 RID: 6400
		// (get) Token: 0x06005313 RID: 21267 RVA: 0x0018831C File Offset: 0x0018651C
		// (set) Token: 0x06005314 RID: 21268 RVA: 0x0002794C File Offset: 0x00025B4C
		public unsafe UnityEvent onDie
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_onDie);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_onDie), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001901 RID: 6401
		// (get) Token: 0x06005315 RID: 21269 RVA: 0x0018834C File Offset: 0x0018654C
		// (set) Token: 0x06005316 RID: 21270 RVA: 0x0002796B File Offset: 0x00025B6B
		public unsafe UnityEvent onRevive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_onRevive);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_onRevive), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001902 RID: 6402
		// (get) Token: 0x06005317 RID: 21271 RVA: 0x0018837C File Offset: 0x0018657C
		// (set) Token: 0x06005318 RID: 21272 RVA: 0x0002798A File Offset: 0x00025B8A
		public unsafe bool AfflictedWithLethalEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_AfflictedWithLethalEffect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_AfflictedWithLethalEffect)) = value;
			}
		}

		// Token: 0x17001903 RID: 6403
		// (get) Token: 0x06005319 RID: 21273 RVA: 0x001883A4 File Offset: 0x001865A4
		// (set) Token: 0x0600531A RID: 21274 RVA: 0x000279A5 File Offset: 0x00025BA5
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001904 RID: 6404
		// (get) Token: 0x0600531B RID: 21275 RVA: 0x001883CC File Offset: 0x001865CC
		// (set) Token: 0x0600531C RID: 21276 RVA: 0x000279C0 File Offset: 0x00025BC0
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003824 RID: 14372
		private static readonly IntPtr NativeFieldInfoPtr_MAX_HEALTH;

		// Token: 0x04003825 RID: 14373
		private static readonly IntPtr NativeFieldInfoPtr_HEALTH_RECOVERY_PER_MINUTE;

		// Token: 0x04003826 RID: 14374
		private static readonly IntPtr NativeFieldInfoPtr__IsAlive_k__BackingField;

		// Token: 0x04003827 RID: 14375
		private static readonly IntPtr NativeFieldInfoPtr__CurrentHealth_k__BackingField;

		// Token: 0x04003828 RID: 14376
		private static readonly IntPtr NativeFieldInfoPtr__TimeSinceLastDamage_k__BackingField;

		// Token: 0x04003829 RID: 14377
		private static readonly IntPtr NativeFieldInfoPtr_Player;

		// Token: 0x0400382A RID: 14378
		private static readonly IntPtr NativeFieldInfoPtr_BloodParticles;

		// Token: 0x0400382B RID: 14379
		private static readonly IntPtr NativeFieldInfoPtr_onHealthChanged;

		// Token: 0x0400382C RID: 14380
		private static readonly IntPtr NativeFieldInfoPtr_onDie;

		// Token: 0x0400382D RID: 14381
		private static readonly IntPtr NativeFieldInfoPtr_onRevive;

		// Token: 0x0400382E RID: 14382
		private static readonly IntPtr NativeFieldInfoPtr_AfflictedWithLethalEffect;

		// Token: 0x0400382F RID: 14383
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003830 RID: 14384
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003831 RID: 14385
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAlive_Public_get_Boolean_0;

		// Token: 0x04003832 RID: 14386
		private static readonly IntPtr NativeMethodInfoPtr_set_IsAlive_Protected_set_Void_Boolean_0;

		// Token: 0x04003833 RID: 14387
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentHealth_Public_get_Single_0;

		// Token: 0x04003834 RID: 14388
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentHealth_Protected_set_Void_Single_0;

		// Token: 0x04003835 RID: 14389
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSinceLastDamage_Public_get_Single_0;

		// Token: 0x04003836 RID: 14390
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeSinceLastDamage_Protected_set_Void_Single_0;

		// Token: 0x04003837 RID: 14391
		private static readonly IntPtr NativeMethodInfoPtr_get_CanTakeDamage_Public_get_Boolean_0;

		// Token: 0x04003838 RID: 14392
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04003839 RID: 14393
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400383A RID: 14394
		private static readonly IntPtr NativeMethodInfoPtr_TakeDamage_Public_Void_Single_Boolean_Boolean_0;

		// Token: 0x0400383B RID: 14395
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400383C RID: 14396
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x0400383D RID: 14397
		private static readonly IntPtr NativeMethodInfoPtr_SetAfflictedWithLethalEffect_Public_Void_Boolean_0;

		// Token: 0x0400383E RID: 14398
		private static readonly IntPtr NativeMethodInfoPtr_RecoverHealth_Public_Void_Single_0;

		// Token: 0x0400383F RID: 14399
		private static readonly IntPtr NativeMethodInfoPtr_SetHealth_Public_Void_Single_0;

		// Token: 0x04003840 RID: 14400
		private static readonly IntPtr NativeMethodInfoPtr_SendDie_Public_Void_0;

		// Token: 0x04003841 RID: 14401
		private static readonly IntPtr NativeMethodInfoPtr_Die_Public_Void_0;

		// Token: 0x04003842 RID: 14402
		private static readonly IntPtr NativeMethodInfoPtr_SendRevive_Public_Void_Vector3_Quaternion_0;

		// Token: 0x04003843 RID: 14403
		private static readonly IntPtr NativeMethodInfoPtr_Revive_Public_Void_Vector3_Quaternion_0;

		// Token: 0x04003844 RID: 14404
		private static readonly IntPtr NativeMethodInfoPtr_PlayBloodMist_Public_Void_0;

		// Token: 0x04003845 RID: 14405
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003846 RID: 14406
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__22_0_Private_Void_0;

		// Token: 0x04003847 RID: 14407
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003848 RID: 14408
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003849 RID: 14409
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400384A RID: 14410
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_TakeDamage_3505310624_Private_Void_Single_Boolean_Boolean_0;

		// Token: 0x0400384B RID: 14411
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___TakeDamage_3505310624_Public_Void_Single_Boolean_Boolean_0;

		// Token: 0x0400384C RID: 14412
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_TakeDamage_3505310624_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400384D RID: 14413
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendDie_2166136261_Private_Void_0;

		// Token: 0x0400384E RID: 14414
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendDie_2166136261_Public_Void_0;

		// Token: 0x0400384F RID: 14415
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendDie_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003850 RID: 14416
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Die_2166136261_Private_Void_0;

		// Token: 0x04003851 RID: 14417
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Die_2166136261_Public_Void_0;

		// Token: 0x04003852 RID: 14418
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Die_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003853 RID: 14419
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendRevive_3848837105_Private_Void_Vector3_Quaternion_0;

		// Token: 0x04003854 RID: 14420
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendRevive_3848837105_Public_Void_Vector3_Quaternion_0;

		// Token: 0x04003855 RID: 14421
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendRevive_3848837105_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003856 RID: 14422
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Revive_3848837105_Private_Void_Vector3_Quaternion_0;

		// Token: 0x04003857 RID: 14423
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Revive_3848837105_Public_Void_Vector3_Quaternion_0;

		// Token: 0x04003858 RID: 14424
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Revive_3848837105_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003859 RID: 14425
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_PlayBloodMist_2166136261_Private_Void_0;

		// Token: 0x0400385A RID: 14426
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___PlayBloodMist_2166136261_Public_Void_0;

		// Token: 0x0400385B RID: 14427
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_PlayBloodMist_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400385C RID: 14428
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_0;
	}
}
