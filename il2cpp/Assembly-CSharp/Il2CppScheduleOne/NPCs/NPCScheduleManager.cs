using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.GameTime;
using Il2CppScheduleOne.NPCs.Schedules;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs
{
	// Token: 0x020002DD RID: 733
	public class NPCScheduleManager : MonoBehaviour
	{
		// Token: 0x06003612 RID: 13842 RVA: 0x0011E8B8 File Offset: 0x0011CAB8
		// Note: this type is marked as 'beforefieldinit'.
		static NPCScheduleManager()
		{
			Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs", "NPCScheduleManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr);
			NPCScheduleManager.NativeFieldInfoPtr__ScheduleEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "<ScheduleEnabled>k__BackingField");
			NPCScheduleManager.NativeFieldInfoPtr__CurfewModeEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "<CurfewModeEnabled>k__BackingField");
			NPCScheduleManager.NativeFieldInfoPtr_DEBUG_MODE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "DEBUG_MODE");
			NPCScheduleManager.NativeFieldInfoPtr__ActiveAction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "<ActiveAction>k__BackingField");
			NPCScheduleManager.NativeFieldInfoPtr__PendingActions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "<PendingActions>k__BackingField");
			NPCScheduleManager.NativeFieldInfoPtr__Npc_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "<Npc>k__BackingField");
			NPCScheduleManager.NativeFieldInfoPtr_EnabledDuringCurfew = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "EnabledDuringCurfew");
			NPCScheduleManager.NativeFieldInfoPtr_EnabledDuringNoCurfew = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "EnabledDuringNoCurfew");
			NPCScheduleManager.NativeFieldInfoPtr_ActionList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "ActionList");
			NPCScheduleManager.NativeFieldInfoPtr__ActionsAwaitingStart_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "<ActionsAwaitingStart>k__BackingField");
			NPCScheduleManager.NativeFieldInfoPtr_lastProcessedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "lastProcessedTime");
			NPCScheduleManager.NativeMethodInfoPtr_get_ScheduleEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669433);
			NPCScheduleManager.NativeMethodInfoPtr_set_ScheduleEnabled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669434);
			NPCScheduleManager.NativeMethodInfoPtr_get_CurfewModeEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669435);
			NPCScheduleManager.NativeMethodInfoPtr_set_CurfewModeEnabled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669436);
			NPCScheduleManager.NativeMethodInfoPtr_get_ActiveAction_Public_get_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669437);
			NPCScheduleManager.NativeMethodInfoPtr_set_ActiveAction_Public_set_Void_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669438);
			NPCScheduleManager.NativeMethodInfoPtr_get_PendingActions_Public_get_List_1_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669439);
			NPCScheduleManager.NativeMethodInfoPtr_set_PendingActions_Public_set_Void_List_1_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669440);
			NPCScheduleManager.NativeMethodInfoPtr_get_Npc_Public_get_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669441);
			NPCScheduleManager.NativeMethodInfoPtr_set_Npc_Protected_set_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669442);
			NPCScheduleManager.NativeMethodInfoPtr_get_ActionsAwaitingStart_Protected_get_List_1_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669443);
			NPCScheduleManager.NativeMethodInfoPtr_set_ActionsAwaitingStart_Protected_set_Void_List_1_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669444);
			NPCScheduleManager.NativeMethodInfoPtr_get_Time_Protected_get_TimeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669445);
			NPCScheduleManager.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669446);
			NPCScheduleManager.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669447);
			NPCScheduleManager.NativeMethodInfoPtr_LocalPlayerSpawned_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669448);
			NPCScheduleManager.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669449);
			NPCScheduleManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669450);
			NPCScheduleManager.NativeMethodInfoPtr_EnableSchedule_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669451);
			NPCScheduleManager.NativeMethodInfoPtr_DisableSchedule_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669452);
			NPCScheduleManager.NativeMethodInfoPtr_InitializeActions_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669453);
			NPCScheduleManager.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669454);
			NPCScheduleManager.NativeMethodInfoPtr_GetActionsOccurringAt_Private_List_1_NPCAction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669455);
			NPCScheduleManager.NativeMethodInfoPtr_GetActionsTotallyOccurringWithinRange_Private_List_1_NPCAction_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669456);
			NPCScheduleManager.NativeMethodInfoPtr_StartAction_Private_Void_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669457);
			NPCScheduleManager.NativeMethodInfoPtr_EnforceState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669458);
			NPCScheduleManager.NativeMethodInfoPtr_EnforceState_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669459);
			NPCScheduleManager.NativeMethodInfoPtr_CurfewEnabled_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669460);
			NPCScheduleManager.NativeMethodInfoPtr_CurfewDisabled_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669461);
			NPCScheduleManager.NativeMethodInfoPtr_SetCurfewModeEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669462);
			NPCScheduleManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669463);
		}

		// Token: 0x1700117A RID: 4474
		// (get) Token: 0x06003613 RID: 13843 RVA: 0x0011EC30 File Offset: 0x0011CE30
		// (set) Token: 0x06003614 RID: 13844 RVA: 0x0011EC6C File Offset: 0x0011CE6C
		public unsafe bool ScheduleEnabled
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35365, RefRangeEnd = 35366, XrefRangeStart = 35365, XrefRangeEnd = 35366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_get_ScheduleEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35366, RefRangeEnd = 35368, XrefRangeStart = 35366, XrefRangeEnd = 35368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_set_ScheduleEnabled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700117B RID: 4475
		// (get) Token: 0x06003615 RID: 13845 RVA: 0x0011ECAC File Offset: 0x0011CEAC
		// (set) Token: 0x06003616 RID: 13846 RVA: 0x0011ECE8 File Offset: 0x0011CEE8
		public unsafe bool CurfewModeEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_get_CurfewModeEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_set_CurfewModeEnabled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700117C RID: 4476
		// (get) Token: 0x06003617 RID: 13847 RVA: 0x0011ED28 File Offset: 0x0011CF28
		// (set) Token: 0x06003618 RID: 13848 RVA: 0x0011ED68 File Offset: 0x0011CF68
		public unsafe NPCAction ActiveAction
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19637, RefRangeEnd = 19640, XrefRangeStart = 19637, XrefRangeEnd = 19640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_get_ActiveAction_Public_get_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPCAction>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19641, RefRangeEnd = 19644, XrefRangeStart = 19641, XrefRangeEnd = 19644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_set_ActiveAction_Public_set_Void_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700117D RID: 4477
		// (get) Token: 0x06003619 RID: 13849 RVA: 0x0011EDAC File Offset: 0x0011CFAC
		// (set) Token: 0x0600361A RID: 13850 RVA: 0x0011EDEC File Offset: 0x0011CFEC
		public unsafe List<NPCAction> PendingActions
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19644, RefRangeEnd = 19658, XrefRangeStart = 19644, XrefRangeEnd = 19658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_get_PendingActions_Public_get_List_1_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<NPCAction>>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 19659, RefRangeEnd = 19660, XrefRangeStart = 19659, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_set_PendingActions_Public_set_Void_List_1_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700117E RID: 4478
		// (get) Token: 0x0600361B RID: 13851 RVA: 0x0011EE30 File Offset: 0x0011D030
		// (set) Token: 0x0600361C RID: 13852 RVA: 0x0011EE70 File Offset: 0x0011D070
		public unsafe NPC Npc
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 19660, RefRangeEnd = 19667, XrefRangeStart = 19660, XrefRangeEnd = 19667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_get_Npc_Public_get_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_set_Npc_Protected_set_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700117F RID: 4479
		// (get) Token: 0x0600361D RID: 13853 RVA: 0x0011EEB4 File Offset: 0x0011D0B4
		// (set) Token: 0x0600361E RID: 13854 RVA: 0x0011EEF4 File Offset: 0x0011D0F4
		public unsafe List<NPCAction> ActionsAwaitingStart
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_get_ActionsAwaitingStart_Protected_get_List_1_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<NPCAction>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_set_ActionsAwaitingStart_Protected_set_Void_List_1_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001180 RID: 4480
		// (get) Token: 0x0600361F RID: 13855 RVA: 0x0011EF38 File Offset: 0x0011D138
		public unsafe TimeManager Time
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 138285, RefRangeEnd = 138289, XrefRangeStart = 138282, XrefRangeEnd = 138285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_get_Time_Protected_get_TimeManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeManager>(intPtr3) : null;
			}
		}

		// Token: 0x06003620 RID: 13856 RVA: 0x0011EF78 File Offset: 0x0011D178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138289, XrefRangeEnd = 138294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCScheduleManager.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003621 RID: 13857 RVA: 0x0011EFB4 File Offset: 0x0011D1B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138294, XrefRangeEnd = 138382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCScheduleManager.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003622 RID: 13858 RVA: 0x0011EFF0 File Offset: 0x0011D1F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138382, XrefRangeEnd = 138384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LocalPlayerSpawned()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_LocalPlayerSpawned_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003623 RID: 13859 RVA: 0x0011F024 File Offset: 0x0011D224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138384, XrefRangeEnd = 138388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003624 RID: 13860 RVA: 0x0011F058 File Offset: 0x0011D258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138388, XrefRangeEnd = 138392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCScheduleManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003625 RID: 13861 RVA: 0x0011F094 File Offset: 0x0011D294
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 138392, RefRangeEnd = 138394, XrefRangeStart = 138392, XrefRangeEnd = 138392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableSchedule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_EnableSchedule_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003626 RID: 13862 RVA: 0x0011F0C8 File Offset: 0x0011D2C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 138398, RefRangeEnd = 138400, XrefRangeStart = 138394, XrefRangeEnd = 138398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableSchedule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_DisableSchedule_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003627 RID: 13863 RVA: 0x0011F0FC File Offset: 0x0011D2FC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 138453, RefRangeEnd = 138456, XrefRangeStart = 138400, XrefRangeEnd = 138453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeActions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_InitializeActions_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003628 RID: 13864 RVA: 0x0011F130 File Offset: 0x0011D330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138456, XrefRangeEnd = 138548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCScheduleManager.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003629 RID: 13865 RVA: 0x0011F16C File Offset: 0x0011D36C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 138598, RefRangeEnd = 138600, XrefRangeStart = 138548, XrefRangeEnd = 138598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<NPCAction> GetActionsOccurringAt(int time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_GetActionsOccurringAt_Private_List_1_NPCAction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<NPCAction>>(intPtr3) : null;
		}

		// Token: 0x0600362A RID: 13866 RVA: 0x0011F1B8 File Offset: 0x0011D3B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 138646, RefRangeEnd = 138648, XrefRangeStart = 138600, XrefRangeEnd = 138646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<NPCAction> GetActionsTotallyOccurringWithinRange(int min, int max, bool checkShouldStart)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref min;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkShouldStart;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_GetActionsTotallyOccurringWithinRange_Private_List_1_NPCAction_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<NPCAction>>(intPtr3) : null;
		}

		// Token: 0x0600362B RID: 13867 RVA: 0x0011F220 File Offset: 0x0011D420
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 138669, RefRangeEnd = 138670, XrefRangeStart = 138648, XrefRangeEnd = 138669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartAction(NPCAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_StartAction_Private_Void_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600362C RID: 13868 RVA: 0x0011F264 File Offset: 0x0011D464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138670, XrefRangeEnd = 138676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnforceState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_EnforceState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600362D RID: 13869 RVA: 0x0011F298 File Offset: 0x0011D498
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 138778, RefRangeEnd = 138780, XrefRangeStart = 138676, XrefRangeEnd = 138778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnforceState(bool initial = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref initial;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_EnforceState_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600362E RID: 13870 RVA: 0x0011F2D8 File Offset: 0x0011D4D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138780, XrefRangeEnd = 138781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CurfewEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCScheduleManager.NativeMethodInfoPtr_CurfewEnabled_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600362F RID: 13871 RVA: 0x0011F314 File Offset: 0x0011D514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138781, XrefRangeEnd = 138782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CurfewDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCScheduleManager.NativeMethodInfoPtr_CurfewDisabled_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003630 RID: 13872 RVA: 0x0011F350 File Offset: 0x0011D550
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 138788, RefRangeEnd = 138791, XrefRangeStart = 138782, XrefRangeEnd = 138788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCurfewModeEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_SetCurfewModeEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003631 RID: 13873 RVA: 0x0011F390 File Offset: 0x0011D590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138791, XrefRangeEnd = 138809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCScheduleManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003632 RID: 13874 RVA: 0x0001C650 File Offset: 0x0001A850
		public NPCScheduleManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700116F RID: 4463
		// (get) Token: 0x06003633 RID: 13875 RVA: 0x0011F3CC File Offset: 0x0011D5CC
		// (set) Token: 0x06003634 RID: 13876 RVA: 0x0001C659 File Offset: 0x0001A859
		public unsafe bool _ScheduleEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__ScheduleEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__ScheduleEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x17001170 RID: 4464
		// (get) Token: 0x06003635 RID: 13877 RVA: 0x0011F3F4 File Offset: 0x0011D5F4
		// (set) Token: 0x06003636 RID: 13878 RVA: 0x0001C674 File Offset: 0x0001A874
		public unsafe bool _CurfewModeEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__CurfewModeEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__CurfewModeEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x17001171 RID: 4465
		// (get) Token: 0x06003637 RID: 13879 RVA: 0x0011F41C File Offset: 0x0011D61C
		// (set) Token: 0x06003638 RID: 13880 RVA: 0x0001C68F File Offset: 0x0001A88F
		public unsafe bool DEBUG_MODE
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr_DEBUG_MODE);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr_DEBUG_MODE)) = value;
			}
		}

		// Token: 0x17001172 RID: 4466
		// (get) Token: 0x06003639 RID: 13881 RVA: 0x0011F444 File Offset: 0x0011D644
		// (set) Token: 0x0600363A RID: 13882 RVA: 0x0001C6AA File Offset: 0x0001A8AA
		public unsafe NPCAction _ActiveAction_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__ActiveAction_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__ActiveAction_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001173 RID: 4467
		// (get) Token: 0x0600363B RID: 13883 RVA: 0x0011F474 File Offset: 0x0011D674
		// (set) Token: 0x0600363C RID: 13884 RVA: 0x0001C6C9 File Offset: 0x0001A8C9
		public unsafe List<NPCAction> _PendingActions_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__PendingActions_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPCAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__PendingActions_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001174 RID: 4468
		// (get) Token: 0x0600363D RID: 13885 RVA: 0x0011F4A4 File Offset: 0x0011D6A4
		// (set) Token: 0x0600363E RID: 13886 RVA: 0x0001C6E8 File Offset: 0x0001A8E8
		public unsafe NPC _Npc_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__Npc_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__Npc_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001175 RID: 4469
		// (get) Token: 0x0600363F RID: 13887 RVA: 0x0011F4D4 File Offset: 0x0011D6D4
		// (set) Token: 0x06003640 RID: 13888 RVA: 0x0001C707 File Offset: 0x0001A907
		public unsafe Il2CppReferenceArray<GameObject> EnabledDuringCurfew
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr_EnabledDuringCurfew);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr_EnabledDuringCurfew), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001176 RID: 4470
		// (get) Token: 0x06003641 RID: 13889 RVA: 0x0011F504 File Offset: 0x0011D704
		// (set) Token: 0x06003642 RID: 13890 RVA: 0x0001C726 File Offset: 0x0001A926
		public unsafe Il2CppReferenceArray<GameObject> EnabledDuringNoCurfew
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr_EnabledDuringNoCurfew);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr_EnabledDuringNoCurfew), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001177 RID: 4471
		// (get) Token: 0x06003643 RID: 13891 RVA: 0x0011F534 File Offset: 0x0011D734
		// (set) Token: 0x06003644 RID: 13892 RVA: 0x0001C745 File Offset: 0x0001A945
		public unsafe List<NPCAction> ActionList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr_ActionList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPCAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr_ActionList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001178 RID: 4472
		// (get) Token: 0x06003645 RID: 13893 RVA: 0x0011F564 File Offset: 0x0011D764
		// (set) Token: 0x06003646 RID: 13894 RVA: 0x0001C764 File Offset: 0x0001A964
		public unsafe List<NPCAction> _ActionsAwaitingStart_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__ActionsAwaitingStart_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPCAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__ActionsAwaitingStart_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001179 RID: 4473
		// (get) Token: 0x06003647 RID: 13895 RVA: 0x0011F594 File Offset: 0x0011D794
		// (set) Token: 0x06003648 RID: 13896 RVA: 0x0001C783 File Offset: 0x0001A983
		public unsafe int lastProcessedTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr_lastProcessedTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr_lastProcessedTime)) = value;
			}
		}

		// Token: 0x0400235B RID: 9051
		private static readonly IntPtr NativeFieldInfoPtr__ScheduleEnabled_k__BackingField;

		// Token: 0x0400235C RID: 9052
		private static readonly IntPtr NativeFieldInfoPtr__CurfewModeEnabled_k__BackingField;

		// Token: 0x0400235D RID: 9053
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG_MODE;

		// Token: 0x0400235E RID: 9054
		private static readonly IntPtr NativeFieldInfoPtr__ActiveAction_k__BackingField;

		// Token: 0x0400235F RID: 9055
		private static readonly IntPtr NativeFieldInfoPtr__PendingActions_k__BackingField;

		// Token: 0x04002360 RID: 9056
		private static readonly IntPtr NativeFieldInfoPtr__Npc_k__BackingField;

		// Token: 0x04002361 RID: 9057
		private static readonly IntPtr NativeFieldInfoPtr_EnabledDuringCurfew;

		// Token: 0x04002362 RID: 9058
		private static readonly IntPtr NativeFieldInfoPtr_EnabledDuringNoCurfew;

		// Token: 0x04002363 RID: 9059
		private static readonly IntPtr NativeFieldInfoPtr_ActionList;

		// Token: 0x04002364 RID: 9060
		private static readonly IntPtr NativeFieldInfoPtr__ActionsAwaitingStart_k__BackingField;

		// Token: 0x04002365 RID: 9061
		private static readonly IntPtr NativeFieldInfoPtr_lastProcessedTime;

		// Token: 0x04002366 RID: 9062
		private static readonly IntPtr NativeMethodInfoPtr_get_ScheduleEnabled_Public_get_Boolean_0;

		// Token: 0x04002367 RID: 9063
		private static readonly IntPtr NativeMethodInfoPtr_set_ScheduleEnabled_Protected_set_Void_Boolean_0;

		// Token: 0x04002368 RID: 9064
		private static readonly IntPtr NativeMethodInfoPtr_get_CurfewModeEnabled_Public_get_Boolean_0;

		// Token: 0x04002369 RID: 9065
		private static readonly IntPtr NativeMethodInfoPtr_set_CurfewModeEnabled_Protected_set_Void_Boolean_0;

		// Token: 0x0400236A RID: 9066
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveAction_Public_get_NPCAction_0;

		// Token: 0x0400236B RID: 9067
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveAction_Public_set_Void_NPCAction_0;

		// Token: 0x0400236C RID: 9068
		private static readonly IntPtr NativeMethodInfoPtr_get_PendingActions_Public_get_List_1_NPCAction_0;

		// Token: 0x0400236D RID: 9069
		private static readonly IntPtr NativeMethodInfoPtr_set_PendingActions_Public_set_Void_List_1_NPCAction_0;

		// Token: 0x0400236E RID: 9070
		private static readonly IntPtr NativeMethodInfoPtr_get_Npc_Public_get_NPC_0;

		// Token: 0x0400236F RID: 9071
		private static readonly IntPtr NativeMethodInfoPtr_set_Npc_Protected_set_Void_NPC_0;

		// Token: 0x04002370 RID: 9072
		private static readonly IntPtr NativeMethodInfoPtr_get_ActionsAwaitingStart_Protected_get_List_1_NPCAction_0;

		// Token: 0x04002371 RID: 9073
		private static readonly IntPtr NativeMethodInfoPtr_set_ActionsAwaitingStart_Protected_set_Void_List_1_NPCAction_0;

		// Token: 0x04002372 RID: 9074
		private static readonly IntPtr NativeMethodInfoPtr_get_Time_Protected_get_TimeManager_0;

		// Token: 0x04002373 RID: 9075
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04002374 RID: 9076
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04002375 RID: 9077
		private static readonly IntPtr NativeMethodInfoPtr_LocalPlayerSpawned_Private_Void_0;

		// Token: 0x04002376 RID: 9078
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04002377 RID: 9079
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04002378 RID: 9080
		private static readonly IntPtr NativeMethodInfoPtr_EnableSchedule_Public_Void_0;

		// Token: 0x04002379 RID: 9081
		private static readonly IntPtr NativeMethodInfoPtr_DisableSchedule_Public_Void_0;

		// Token: 0x0400237A RID: 9082
		private static readonly IntPtr NativeMethodInfoPtr_InitializeActions_Public_Void_0;

		// Token: 0x0400237B RID: 9083
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0;

		// Token: 0x0400237C RID: 9084
		private static readonly IntPtr NativeMethodInfoPtr_GetActionsOccurringAt_Private_List_1_NPCAction_Int32_0;

		// Token: 0x0400237D RID: 9085
		private static readonly IntPtr NativeMethodInfoPtr_GetActionsTotallyOccurringWithinRange_Private_List_1_NPCAction_Int32_Int32_Boolean_0;

		// Token: 0x0400237E RID: 9086
		private static readonly IntPtr NativeMethodInfoPtr_StartAction_Private_Void_NPCAction_0;

		// Token: 0x0400237F RID: 9087
		private static readonly IntPtr NativeMethodInfoPtr_EnforceState_Private_Void_0;

		// Token: 0x04002380 RID: 9088
		private static readonly IntPtr NativeMethodInfoPtr_EnforceState_Public_Void_Boolean_0;

		// Token: 0x04002381 RID: 9089
		private static readonly IntPtr NativeMethodInfoPtr_CurfewEnabled_Protected_Virtual_New_Void_0;

		// Token: 0x04002382 RID: 9090
		private static readonly IntPtr NativeMethodInfoPtr_CurfewDisabled_Protected_Virtual_New_Void_0;

		// Token: 0x04002383 RID: 9091
		private static readonly IntPtr NativeMethodInfoPtr_SetCurfewModeEnabled_Public_Void_Boolean_0;

		// Token: 0x04002384 RID: 9092
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200092B RID: 2347
		[ObfuscatedName("ScheduleOne.NPCs.NPCScheduleManager+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600C6AD RID: 50861 RVA: 0x00303D70 File Offset: 0x00301F70
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NPCScheduleManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCScheduleManager.__c>.NativeClassPtr);
				NPCScheduleManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager.__c>.NativeClassPtr, "<>9");
				NPCScheduleManager.__c.NativeFieldInfoPtr___9__38_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager.__c>.NativeClassPtr, "<>9__38_0");
				NPCScheduleManager.__c.NativeFieldInfoPtr___9__40_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager.__c>.NativeClassPtr, "<>9__40_0");
				NPCScheduleManager.__c.NativeFieldInfoPtr___9__41_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager.__c>.NativeClassPtr, "<>9__41_0");
				NPCScheduleManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager.__c>.NativeClassPtr, 100669465);
				NPCScheduleManager.__c.NativeMethodInfoPtr__InitializeActions_b__38_0_Internal_Int32_NPCAction_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager.__c>.NativeClassPtr, 100669466);
				NPCScheduleManager.__c.NativeMethodInfoPtr__GetActionsOccurringAt_b__40_0_Internal_Int32_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager.__c>.NativeClassPtr, 100669467);
				NPCScheduleManager.__c.NativeMethodInfoPtr__GetActionsTotallyOccurringWithinRange_b__41_0_Internal_Int32_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager.__c>.NativeClassPtr, 100669468);
			}

			// Token: 0x0600C6AE RID: 50862 RVA: 0x00303E3C File Offset: 0x0030203C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCScheduleManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C6AF RID: 50863 RVA: 0x00303E78 File Offset: 0x00302078
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138274, XrefRangeEnd = 138276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _InitializeActions_b__38_0(NPCAction a, NPCAction b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.__c.NativeMethodInfoPtr__InitializeActions_b__38_0_Internal_Int32_NPCAction_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C6B0 RID: 50864 RVA: 0x00303ED8 File Offset: 0x003020D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138276, XrefRangeEnd = 138277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetActionsOccurringAt_b__40_0(NPCAction x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.__c.NativeMethodInfoPtr__GetActionsOccurringAt_b__40_0_Internal_Int32_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C6B1 RID: 50865 RVA: 0x00303F28 File Offset: 0x00302128
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetActionsTotallyOccurringWithinRange_b__41_0(NPCAction x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.__c.NativeMethodInfoPtr__GetActionsTotallyOccurringWithinRange_b__41_0_Internal_Int32_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C6B2 RID: 50866 RVA: 0x00060B65 File Offset: 0x0005ED65
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DE5 RID: 15845
			// (get) Token: 0x0600C6B3 RID: 50867 RVA: 0x00303F78 File Offset: 0x00302178
			// (set) Token: 0x0600C6B4 RID: 50868 RVA: 0x00060B6E File Offset: 0x0005ED6E
			public unsafe static NPCScheduleManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCScheduleManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCScheduleManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCScheduleManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003DE6 RID: 15846
			// (get) Token: 0x0600C6B5 RID: 50869 RVA: 0x00303FA0 File Offset: 0x003021A0
			// (set) Token: 0x0600C6B6 RID: 50870 RVA: 0x00060B80 File Offset: 0x0005ED80
			public unsafe static Comparison<NPCAction> __9__38_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCScheduleManager.__c.NativeFieldInfoPtr___9__38_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<NPCAction>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCScheduleManager.__c.NativeFieldInfoPtr___9__38_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003DE7 RID: 15847
			// (get) Token: 0x0600C6B7 RID: 50871 RVA: 0x00303FC8 File Offset: 0x003021C8
			// (set) Token: 0x0600C6B8 RID: 50872 RVA: 0x00060B92 File Offset: 0x0005ED92
			public unsafe static Func<NPCAction, int> __9__40_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCScheduleManager.__c.NativeFieldInfoPtr___9__40_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NPCAction, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCScheduleManager.__c.NativeFieldInfoPtr___9__40_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003DE8 RID: 15848
			// (get) Token: 0x0600C6B9 RID: 50873 RVA: 0x00303FF0 File Offset: 0x003021F0
			// (set) Token: 0x0600C6BA RID: 50874 RVA: 0x00060BA4 File Offset: 0x0005EDA4
			public unsafe static Func<NPCAction, int> __9__41_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCScheduleManager.__c.NativeFieldInfoPtr___9__41_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NPCAction, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCScheduleManager.__c.NativeFieldInfoPtr___9__41_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400867B RID: 34427
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400867C RID: 34428
			private static readonly IntPtr NativeFieldInfoPtr___9__38_0;

			// Token: 0x0400867D RID: 34429
			private static readonly IntPtr NativeFieldInfoPtr___9__40_0;

			// Token: 0x0400867E RID: 34430
			private static readonly IntPtr NativeFieldInfoPtr___9__41_0;

			// Token: 0x0400867F RID: 34431
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008680 RID: 34432
			private static readonly IntPtr NativeMethodInfoPtr__InitializeActions_b__38_0_Internal_Int32_NPCAction_NPCAction_0;

			// Token: 0x04008681 RID: 34433
			private static readonly IntPtr NativeMethodInfoPtr__GetActionsOccurringAt_b__40_0_Internal_Int32_NPCAction_0;

			// Token: 0x04008682 RID: 34434
			private static readonly IntPtr NativeMethodInfoPtr__GetActionsTotallyOccurringWithinRange_b__41_0_Internal_Int32_NPCAction_0;
		}

		// Token: 0x0200092C RID: 2348
		[ObfuscatedName("ScheduleOne.NPCs.NPCScheduleManager+<>c__DisplayClass44_0")]
		public sealed class __c__DisplayClass44_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C6BB RID: 50875 RVA: 0x00304018 File Offset: 0x00302218
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass44_0()
			{
				Il2CppClassPointerStore<NPCScheduleManager.__c__DisplayClass44_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "<>c__DisplayClass44_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCScheduleManager.__c__DisplayClass44_0>.NativeClassPtr);
				NPCScheduleManager.__c__DisplayClass44_0.NativeFieldInfoPtr_actionsOccurringThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager.__c__DisplayClass44_0>.NativeClassPtr, "actionsOccurringThisFrame");
				NPCScheduleManager.__c__DisplayClass44_0.NativeFieldInfoPtr_skippedActionOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager.__c__DisplayClass44_0>.NativeClassPtr, "skippedActionOrder");
				NPCScheduleManager.__c__DisplayClass44_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager.__c__DisplayClass44_0>.NativeClassPtr, 100669469);
				NPCScheduleManager.__c__DisplayClass44_0.NativeMethodInfoPtr__EnforceState_b__0_Internal_Boolean_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager.__c__DisplayClass44_0>.NativeClassPtr, 100669470);
				NPCScheduleManager.__c__DisplayClass44_0.NativeMethodInfoPtr__EnforceState_b__1_Internal_Single_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager.__c__DisplayClass44_0>.NativeClassPtr, 100669471);
			}

			// Token: 0x0600C6BC RID: 50876 RVA: 0x003040A8 File Offset: 0x003022A8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass44_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCScheduleManager.__c__DisplayClass44_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.__c__DisplayClass44_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C6BD RID: 50877 RVA: 0x003040E4 File Offset: 0x003022E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138277, XrefRangeEnd = 138278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _EnforceState_b__0(NPCAction x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.__c__DisplayClass44_0.NativeMethodInfoPtr__EnforceState_b__0_Internal_Boolean_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C6BE RID: 50878 RVA: 0x00304134 File Offset: 0x00302334
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138278, XrefRangeEnd = 138282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _EnforceState_b__1(NPCAction x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.__c__DisplayClass44_0.NativeMethodInfoPtr__EnforceState_b__1_Internal_Single_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C6BF RID: 50879 RVA: 0x00060BB6 File Offset: 0x0005EDB6
			public __c__DisplayClass44_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DE9 RID: 15849
			// (get) Token: 0x0600C6C0 RID: 50880 RVA: 0x00304184 File Offset: 0x00302384
			// (set) Token: 0x0600C6C1 RID: 50881 RVA: 0x00060BBF File Offset: 0x0005EDBF
			public unsafe List<NPCAction> actionsOccurringThisFrame
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.__c__DisplayClass44_0.NativeFieldInfoPtr_actionsOccurringThisFrame);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPCAction>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.__c__DisplayClass44_0.NativeFieldInfoPtr_actionsOccurringThisFrame), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003DEA RID: 15850
			// (get) Token: 0x0600C6C2 RID: 50882 RVA: 0x003041B4 File Offset: 0x003023B4
			// (set) Token: 0x0600C6C3 RID: 50883 RVA: 0x00060BDE File Offset: 0x0005EDDE
			public unsafe Dictionary<NPCAction, float> skippedActionOrder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.__c__DisplayClass44_0.NativeFieldInfoPtr_skippedActionOrder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<NPCAction, float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.__c__DisplayClass44_0.NativeFieldInfoPtr_skippedActionOrder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008683 RID: 34435
			private static readonly IntPtr NativeFieldInfoPtr_actionsOccurringThisFrame;

			// Token: 0x04008684 RID: 34436
			private static readonly IntPtr NativeFieldInfoPtr_skippedActionOrder;

			// Token: 0x04008685 RID: 34437
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008686 RID: 34438
			private static readonly IntPtr NativeMethodInfoPtr__EnforceState_b__0_Internal_Boolean_NPCAction_0;

			// Token: 0x04008687 RID: 34439
			private static readonly IntPtr NativeMethodInfoPtr__EnforceState_b__1_Internal_Single_NPCAction_0;
		}
	}
}
