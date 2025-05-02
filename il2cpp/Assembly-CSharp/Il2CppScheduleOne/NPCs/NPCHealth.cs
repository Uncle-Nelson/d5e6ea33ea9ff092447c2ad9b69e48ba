using System;
using Il2CppFishNet.Object;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using UnityEngine.Events;

namespace Il2CppScheduleOne.NPCs
{
	// Token: 0x020002D7 RID: 727
	public class NPCHealth : NetworkBehaviour
	{
		// Token: 0x06003448 RID: 13384 RVA: 0x00117F8C File Offset: 0x0011618C
		// Note: this type is marked as 'beforefieldinit'.
		static NPCHealth()
		{
			Il2CppClassPointerStore<NPCHealth>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs", "NPCHealth");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr);
			NPCHealth.NativeFieldInfoPtr_REVIVE_DAYS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "REVIVE_DAYS");
			NPCHealth.NativeFieldInfoPtr__Health_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "<Health>k__BackingField");
			NPCHealth.NativeFieldInfoPtr__IsDead_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "<IsDead>k__BackingField");
			NPCHealth.NativeFieldInfoPtr__IsKnockedOut_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "<IsKnockedOut>k__BackingField");
			NPCHealth.NativeFieldInfoPtr__DaysPassedSinceDeath_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "<DaysPassedSinceDeath>k__BackingField");
			NPCHealth.NativeFieldInfoPtr_Invincible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "Invincible");
			NPCHealth.NativeFieldInfoPtr_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "MaxHealth");
			NPCHealth.NativeFieldInfoPtr_npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "npc");
			NPCHealth.NativeFieldInfoPtr_onDie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "onDie");
			NPCHealth.NativeFieldInfoPtr_onKnockedOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "onKnockedOut");
			NPCHealth.NativeFieldInfoPtr_AfflictedWithLethalEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "AfflictedWithLethalEffect");
			NPCHealth.NativeFieldInfoPtr_syncVar____Health_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "syncVar___<Health>k__BackingField");
			NPCHealth.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.NPCHealthAssembly-CSharp.dll_Excuted");
			NPCHealth.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.NPCHealthAssembly-CSharp.dll_Excuted");
			NPCHealth.NativeMethodInfoPtr_get_Health_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669189);
			NPCHealth.NativeMethodInfoPtr_set_Health_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669190);
			NPCHealth.NativeMethodInfoPtr_get_IsDead_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669191);
			NPCHealth.NativeMethodInfoPtr_set_IsDead_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669192);
			NPCHealth.NativeMethodInfoPtr_get_IsKnockedOut_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669193);
			NPCHealth.NativeMethodInfoPtr_set_IsKnockedOut_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669194);
			NPCHealth.NativeMethodInfoPtr_get_DaysPassedSinceDeath_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669195);
			NPCHealth.NativeMethodInfoPtr_set_DaysPassedSinceDeath_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669196);
			NPCHealth.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669197);
			NPCHealth.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669198);
			NPCHealth.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669199);
			NPCHealth.NativeMethodInfoPtr_Load_Public_Void_NPCHealthData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669200);
			NPCHealth.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669201);
			NPCHealth.NativeMethodInfoPtr_SetAfflictedWithLethalEffect_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669202);
			NPCHealth.NativeMethodInfoPtr_SleepStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669203);
			NPCHealth.NativeMethodInfoPtr_TakeDamage_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669204);
			NPCHealth.NativeMethodInfoPtr_Die_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669205);
			NPCHealth.NativeMethodInfoPtr_KnockOut_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669206);
			NPCHealth.NativeMethodInfoPtr_Revive_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669207);
			NPCHealth.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669208);
			NPCHealth.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669209);
			NPCHealth.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669210);
			NPCHealth.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669211);
			NPCHealth.NativeMethodInfoPtr_sync___get_value__Health_k__BackingField_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669212);
			NPCHealth.NativeMethodInfoPtr_sync___set_value__Health_k__BackingField_Public_set_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669213);
			NPCHealth.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_NPCs_NPCHealth_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669214);
			NPCHealth.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669215);
		}

		// Token: 0x170010F0 RID: 4336
		// (get) Token: 0x06003449 RID: 13385 RVA: 0x001182F0 File Offset: 0x001164F0
		// (set) Token: 0x0600344A RID: 13386 RVA: 0x0011832C File Offset: 0x0011652C
		public unsafe float Health
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_get_Health_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 135022, RefRangeEnd = 135028, XrefRangeStart = 135015, XrefRangeEnd = 135022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_set_Health_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170010F1 RID: 4337
		// (get) Token: 0x0600344B RID: 13387 RVA: 0x0011836C File Offset: 0x0011656C
		// (set) Token: 0x0600344C RID: 13388 RVA: 0x001183A8 File Offset: 0x001165A8
		public unsafe bool IsDead
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_get_IsDead_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_set_IsDead_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170010F2 RID: 4338
		// (get) Token: 0x0600344D RID: 13389 RVA: 0x001183E8 File Offset: 0x001165E8
		// (set) Token: 0x0600344E RID: 13390 RVA: 0x00118424 File Offset: 0x00116624
		public unsafe bool IsKnockedOut
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_get_IsKnockedOut_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_set_IsKnockedOut_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170010F3 RID: 4339
		// (get) Token: 0x0600344F RID: 13391 RVA: 0x00118464 File Offset: 0x00116664
		// (set) Token: 0x06003450 RID: 13392 RVA: 0x001184A0 File Offset: 0x001166A0
		public unsafe int DaysPassedSinceDeath
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_get_DaysPassedSinceDeath_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_set_DaysPassedSinceDeath_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003451 RID: 13393 RVA: 0x001184E0 File Offset: 0x001166E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135028, XrefRangeEnd = 135029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCHealth.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003452 RID: 13394 RVA: 0x0011851C File Offset: 0x0011671C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135029, XrefRangeEnd = 135047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003453 RID: 13395 RVA: 0x00118550 File Offset: 0x00116750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135047, XrefRangeEnd = 135049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCHealth.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003454 RID: 13396 RVA: 0x0011858C File Offset: 0x0011678C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 135050, RefRangeEnd = 135051, XrefRangeStart = 135049, XrefRangeEnd = 135050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(NPCHealthData healthData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(healthData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_Load_Public_Void_NPCHealthData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003455 RID: 13397 RVA: 0x001185D0 File Offset: 0x001167D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135051, XrefRangeEnd = 135053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003456 RID: 13398 RVA: 0x00118604 File Offset: 0x00116804
		[CallerCount(0)]
		public unsafe void SetAfflictedWithLethalEffect(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_SetAfflictedWithLethalEffect_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003457 RID: 13399 RVA: 0x00118644 File Offset: 0x00116844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135053, XrefRangeEnd = 135071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SleepStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_SleepStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003458 RID: 13400 RVA: 0x00118678 File Offset: 0x00116878
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 135086, RefRangeEnd = 135088, XrefRangeStart = 135071, XrefRangeEnd = 135086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TakeDamage(float damage, bool isLethal = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref damage;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isLethal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_TakeDamage_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003459 RID: 13401 RVA: 0x001186C4 File Offset: 0x001168C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135088, XrefRangeEnd = 135100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Die()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCHealth.NativeMethodInfoPtr_Die_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600345A RID: 13402 RVA: 0x00118700 File Offset: 0x00116900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135100, XrefRangeEnd = 135112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void KnockOut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCHealth.NativeMethodInfoPtr_KnockOut_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600345B RID: 13403 RVA: 0x0011873C File Offset: 0x0011693C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135112, XrefRangeEnd = 135126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Revive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCHealth.NativeMethodInfoPtr_Revive_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600345C RID: 13404 RVA: 0x00118778 File Offset: 0x00116978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135126, XrefRangeEnd = 135127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCHealth() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600345D RID: 13405 RVA: 0x001187B4 File Offset: 0x001169B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135127, XrefRangeEnd = 135143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCHealth.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600345E RID: 13406 RVA: 0x001187F0 File Offset: 0x001169F0
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCHealth.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600345F RID: 13407 RVA: 0x0011882C File Offset: 0x00116A2C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCHealth.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170010F4 RID: 4340
		// (get) Token: 0x06003460 RID: 13408 RVA: 0x00118868 File Offset: 0x00116A68
		// (set) Token: 0x06003461 RID: 13409 RVA: 0x001188A4 File Offset: 0x00116AA4
		public unsafe float SyncAccessor_<Health>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_sync___get_value__Health_k__BackingField_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135143, XrefRangeEnd = 135151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_sync___set_value__Health_k__BackingField_Public_set_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003462 RID: 13410 RVA: 0x001188F0 File Offset: 0x00116AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135151, XrefRangeEnd = 135152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_NPCs_NPCHealth(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCHealth.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_NPCs_NPCHealth_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003463 RID: 13411 RVA: 0x00118964 File Offset: 0x00116B64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 135189, RefRangeEnd = 135190, XrefRangeStart = 135152, XrefRangeEnd = 135189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCHealth.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003464 RID: 13412 RVA: 0x0001BA32 File Offset: 0x00019C32
		public NPCHealth(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170010E2 RID: 4322
		// (get) Token: 0x06003465 RID: 13413 RVA: 0x001189A0 File Offset: 0x00116BA0
		// (set) Token: 0x06003466 RID: 13414 RVA: 0x0001BA3B File Offset: 0x00019C3B
		public unsafe static int REVIVE_DAYS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(NPCHealth.NativeFieldInfoPtr_REVIVE_DAYS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCHealth.NativeFieldInfoPtr_REVIVE_DAYS, (void*)(&value));
			}
		}

		// Token: 0x170010E3 RID: 4323
		// (get) Token: 0x06003467 RID: 13415 RVA: 0x001189BC File Offset: 0x00116BBC
		// (set) Token: 0x06003468 RID: 13416 RVA: 0x0001BA49 File Offset: 0x00019C49
		public unsafe float _Health_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr__Health_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr__Health_k__BackingField)) = value;
			}
		}

		// Token: 0x170010E4 RID: 4324
		// (get) Token: 0x06003469 RID: 13417 RVA: 0x001189E4 File Offset: 0x00116BE4
		// (set) Token: 0x0600346A RID: 13418 RVA: 0x0001BA64 File Offset: 0x00019C64
		public unsafe bool _IsDead_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr__IsDead_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr__IsDead_k__BackingField)) = value;
			}
		}

		// Token: 0x170010E5 RID: 4325
		// (get) Token: 0x0600346B RID: 13419 RVA: 0x00118A0C File Offset: 0x00116C0C
		// (set) Token: 0x0600346C RID: 13420 RVA: 0x0001BA7F File Offset: 0x00019C7F
		public unsafe bool _IsKnockedOut_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr__IsKnockedOut_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr__IsKnockedOut_k__BackingField)) = value;
			}
		}

		// Token: 0x170010E6 RID: 4326
		// (get) Token: 0x0600346D RID: 13421 RVA: 0x00118A34 File Offset: 0x00116C34
		// (set) Token: 0x0600346E RID: 13422 RVA: 0x0001BA9A File Offset: 0x00019C9A
		public unsafe int _DaysPassedSinceDeath_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr__DaysPassedSinceDeath_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr__DaysPassedSinceDeath_k__BackingField)) = value;
			}
		}

		// Token: 0x170010E7 RID: 4327
		// (get) Token: 0x0600346F RID: 13423 RVA: 0x00118A5C File Offset: 0x00116C5C
		// (set) Token: 0x06003470 RID: 13424 RVA: 0x0001BAB5 File Offset: 0x00019CB5
		public unsafe bool Invincible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_Invincible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_Invincible)) = value;
			}
		}

		// Token: 0x170010E8 RID: 4328
		// (get) Token: 0x06003471 RID: 13425 RVA: 0x00118A84 File Offset: 0x00116C84
		// (set) Token: 0x06003472 RID: 13426 RVA: 0x0001BAD0 File Offset: 0x00019CD0
		public unsafe float MaxHealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_MaxHealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_MaxHealth)) = value;
			}
		}

		// Token: 0x170010E9 RID: 4329
		// (get) Token: 0x06003473 RID: 13427 RVA: 0x00118AAC File Offset: 0x00116CAC
		// (set) Token: 0x06003474 RID: 13428 RVA: 0x0001BAEB File Offset: 0x00019CEB
		public unsafe NPC npc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_npc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_npc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010EA RID: 4330
		// (get) Token: 0x06003475 RID: 13429 RVA: 0x00118ADC File Offset: 0x00116CDC
		// (set) Token: 0x06003476 RID: 13430 RVA: 0x0001BB0A File Offset: 0x00019D0A
		public unsafe UnityEvent onDie
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_onDie);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_onDie), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010EB RID: 4331
		// (get) Token: 0x06003477 RID: 13431 RVA: 0x00118B0C File Offset: 0x00116D0C
		// (set) Token: 0x06003478 RID: 13432 RVA: 0x0001BB29 File Offset: 0x00019D29
		public unsafe UnityEvent onKnockedOut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_onKnockedOut);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_onKnockedOut), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010EC RID: 4332
		// (get) Token: 0x06003479 RID: 13433 RVA: 0x00118B3C File Offset: 0x00116D3C
		// (set) Token: 0x0600347A RID: 13434 RVA: 0x0001BB48 File Offset: 0x00019D48
		public unsafe bool AfflictedWithLethalEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_AfflictedWithLethalEffect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_AfflictedWithLethalEffect)) = value;
			}
		}

		// Token: 0x170010ED RID: 4333
		// (get) Token: 0x0600347B RID: 13435 RVA: 0x00118B64 File Offset: 0x00116D64
		// (set) Token: 0x0600347C RID: 13436 RVA: 0x0001BB63 File Offset: 0x00019D63
		public unsafe SyncVar<float> syncVar____Health_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_syncVar____Health_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_syncVar____Health_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010EE RID: 4334
		// (get) Token: 0x0600347D RID: 13437 RVA: 0x00118B94 File Offset: 0x00116D94
		// (set) Token: 0x0600347E RID: 13438 RVA: 0x0001BB82 File Offset: 0x00019D82
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170010EF RID: 4335
		// (get) Token: 0x0600347F RID: 13439 RVA: 0x00118BBC File Offset: 0x00116DBC
		// (set) Token: 0x06003480 RID: 13440 RVA: 0x0001BB9D File Offset: 0x00019D9D
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002211 RID: 8721
		private static readonly IntPtr NativeFieldInfoPtr_REVIVE_DAYS;

		// Token: 0x04002212 RID: 8722
		private static readonly IntPtr NativeFieldInfoPtr__Health_k__BackingField;

		// Token: 0x04002213 RID: 8723
		private static readonly IntPtr NativeFieldInfoPtr__IsDead_k__BackingField;

		// Token: 0x04002214 RID: 8724
		private static readonly IntPtr NativeFieldInfoPtr__IsKnockedOut_k__BackingField;

		// Token: 0x04002215 RID: 8725
		private static readonly IntPtr NativeFieldInfoPtr__DaysPassedSinceDeath_k__BackingField;

		// Token: 0x04002216 RID: 8726
		private static readonly IntPtr NativeFieldInfoPtr_Invincible;

		// Token: 0x04002217 RID: 8727
		private static readonly IntPtr NativeFieldInfoPtr_MaxHealth;

		// Token: 0x04002218 RID: 8728
		private static readonly IntPtr NativeFieldInfoPtr_npc;

		// Token: 0x04002219 RID: 8729
		private static readonly IntPtr NativeFieldInfoPtr_onDie;

		// Token: 0x0400221A RID: 8730
		private static readonly IntPtr NativeFieldInfoPtr_onKnockedOut;

		// Token: 0x0400221B RID: 8731
		private static readonly IntPtr NativeFieldInfoPtr_AfflictedWithLethalEffect;

		// Token: 0x0400221C RID: 8732
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____Health_k__BackingField;

		// Token: 0x0400221D RID: 8733
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400221E RID: 8734
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400221F RID: 8735
		private static readonly IntPtr NativeMethodInfoPtr_get_Health_Public_get_Single_0;

		// Token: 0x04002220 RID: 8736
		private static readonly IntPtr NativeMethodInfoPtr_set_Health_Private_set_Void_Single_0;

		// Token: 0x04002221 RID: 8737
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDead_Public_get_Boolean_0;

		// Token: 0x04002222 RID: 8738
		private static readonly IntPtr NativeMethodInfoPtr_set_IsDead_Private_set_Void_Boolean_0;

		// Token: 0x04002223 RID: 8739
		private static readonly IntPtr NativeMethodInfoPtr_get_IsKnockedOut_Public_get_Boolean_0;

		// Token: 0x04002224 RID: 8740
		private static readonly IntPtr NativeMethodInfoPtr_set_IsKnockedOut_Private_set_Void_Boolean_0;

		// Token: 0x04002225 RID: 8741
		private static readonly IntPtr NativeMethodInfoPtr_get_DaysPassedSinceDeath_Public_get_Int32_0;

		// Token: 0x04002226 RID: 8742
		private static readonly IntPtr NativeMethodInfoPtr_set_DaysPassedSinceDeath_Private_set_Void_Int32_0;

		// Token: 0x04002227 RID: 8743
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04002228 RID: 8744
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04002229 RID: 8745
		private static readonly IntPtr NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0;

		// Token: 0x0400222A RID: 8746
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_NPCHealthData_0;

		// Token: 0x0400222B RID: 8747
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400222C RID: 8748
		private static readonly IntPtr NativeMethodInfoPtr_SetAfflictedWithLethalEffect_Public_Void_Boolean_0;

		// Token: 0x0400222D RID: 8749
		private static readonly IntPtr NativeMethodInfoPtr_SleepStart_Public_Void_0;

		// Token: 0x0400222E RID: 8750
		private static readonly IntPtr NativeMethodInfoPtr_TakeDamage_Public_Void_Single_Boolean_0;

		// Token: 0x0400222F RID: 8751
		private static readonly IntPtr NativeMethodInfoPtr_Die_Public_Virtual_New_Void_0;

		// Token: 0x04002230 RID: 8752
		private static readonly IntPtr NativeMethodInfoPtr_KnockOut_Public_Virtual_New_Void_0;

		// Token: 0x04002231 RID: 8753
		private static readonly IntPtr NativeMethodInfoPtr_Revive_Public_Virtual_New_Void_0;

		// Token: 0x04002232 RID: 8754
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002233 RID: 8755
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002234 RID: 8756
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002235 RID: 8757
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002236 RID: 8758
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__Health_k__BackingField_Public_get_Single_0;

		// Token: 0x04002237 RID: 8759
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__Health_k__BackingField_Public_set_Void_Single_Boolean_0;

		// Token: 0x04002238 RID: 8760
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_NPCs_NPCHealth_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04002239 RID: 8761
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;
	}
}
