using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Dialogue;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Police;
using Il2CppScheduleOne.Product.Packaging;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000342 RID: 834
	public class BodySearchBehaviour : Behaviour
	{
		// Token: 0x06003DA9 RID: 15785 RVA: 0x00139880 File Offset: 0x00137A80
		// Note: this type is marked as 'beforefieldinit'.
		static BodySearchBehaviour()
		{
			Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "BodySearchBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr);
			BodySearchBehaviour.NativeFieldInfoPtr_MAX_STEALTH_LEVEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "MAX_STEALTH_LEVEL");
			BodySearchBehaviour.NativeFieldInfoPtr_BODY_SEARCH_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "BODY_SEARCH_RANGE");
			BodySearchBehaviour.NativeFieldInfoPtr_MAX_SEARCH_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "MAX_SEARCH_TIME");
			BodySearchBehaviour.NativeFieldInfoPtr_MAX_TIME_OUTSIDE_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "MAX_TIME_OUTSIDE_RANGE");
			BodySearchBehaviour.NativeFieldInfoPtr_RANGE_TO_ESCALATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "RANGE_TO_ESCALATE");
			BodySearchBehaviour.NativeFieldInfoPtr_MOVE_SPEED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "MOVE_SPEED");
			BodySearchBehaviour.NativeFieldInfoPtr_BODY_SEARCH_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "BODY_SEARCH_COOLDOWN");
			BodySearchBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "<TargetPlayer>k__BackingField");
			BodySearchBehaviour.NativeFieldInfoPtr_ArrestCircle_MaxVisibleDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "ArrestCircle_MaxVisibleDistance");
			BodySearchBehaviour.NativeFieldInfoPtr_ArrestCircle_MaxOpacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "ArrestCircle_MaxOpacity");
			BodySearchBehaviour.NativeFieldInfoPtr_ShowPostSearchDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "ShowPostSearchDialogue");
			BodySearchBehaviour.NativeFieldInfoPtr_MaxStealthLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "MaxStealthLevel");
			BodySearchBehaviour.NativeFieldInfoPtr_officer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "officer");
			BodySearchBehaviour.NativeFieldInfoPtr_targetDistanceOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "targetDistanceOnStart");
			BodySearchBehaviour.NativeFieldInfoPtr_searchTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "searchTime");
			BodySearchBehaviour.NativeFieldInfoPtr_hasBeenInRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "hasBeenInRange");
			BodySearchBehaviour.NativeFieldInfoPtr_timeOutsideRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "timeOutsideRange");
			BodySearchBehaviour.NativeFieldInfoPtr_timeWithinSearchRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "timeWithinSearchRange");
			BodySearchBehaviour.NativeFieldInfoPtr_timeSinceCantReach = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "timeSinceCantReach");
			BodySearchBehaviour.NativeFieldInfoPtr_onSearchComplete_Clear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "onSearchComplete_Clear");
			BodySearchBehaviour.NativeFieldInfoPtr_onSearchComplete_ItemsFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "onSearchComplete_ItemsFound");
			BodySearchBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.BodySearchBehaviourAssembly-CSharp.dll_Excuted");
			BodySearchBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.BodySearchBehaviourAssembly-CSharp.dll_Excuted");
			BodySearchBehaviour.NativeMethodInfoPtr_get_BODY_SEARCH_TIME_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670513);
			BodySearchBehaviour.NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670514);
			BodySearchBehaviour.NativeMethodInfoPtr_set_TargetPlayer_Protected_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670515);
			BodySearchBehaviour.NativeMethodInfoPtr_get_dialogueDatabase_Private_get_DialogueDatabase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670516);
			BodySearchBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670517);
			BodySearchBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670518);
			BodySearchBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670519);
			BodySearchBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670520);
			BodySearchBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670521);
			BodySearchBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670522);
			BodySearchBehaviour.NativeMethodInfoPtr_UpdateSearch_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670523);
			BodySearchBehaviour.NativeMethodInfoPtr_UpdateMovement_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670524);
			BodySearchBehaviour.NativeMethodInfoPtr_SearchClean_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670525);
			BodySearchBehaviour.NativeMethodInfoPtr_SearchFail_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670526);
			BodySearchBehaviour.NativeMethodInfoPtr_UpdateEscalation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670527);
			BodySearchBehaviour.NativeMethodInfoPtr_UpdateLookAt_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670528);
			BodySearchBehaviour.NativeMethodInfoPtr_UpdateCircle_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670529);
			BodySearchBehaviour.NativeMethodInfoPtr_SetArrestCircleAlpha_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670530);
			BodySearchBehaviour.NativeMethodInfoPtr_SetArrestCircleColor_Private_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670531);
			BodySearchBehaviour.NativeMethodInfoPtr_GetNewDestination_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670532);
			BodySearchBehaviour.NativeMethodInfoPtr_ClearSpeedControls_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670533);
			BodySearchBehaviour.NativeMethodInfoPtr_IsTargetValid_Private_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670534);
			BodySearchBehaviour.NativeMethodInfoPtr_AssignTarget_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670535);
			BodySearchBehaviour.NativeMethodInfoPtr_DoesPlayerContainItemsOfInterest_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670536);
			BodySearchBehaviour.NativeMethodInfoPtr_ConcludeSearch_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670537);
			BodySearchBehaviour.NativeMethodInfoPtr_Escalate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670538);
			BodySearchBehaviour.NativeMethodInfoPtr_NoItemsOfInterestFound_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670539);
			BodySearchBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670540);
			BodySearchBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670541);
			BodySearchBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670542);
			BodySearchBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670543);
			BodySearchBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_AssignTarget_1824087381_Private_Void_NetworkConnection_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670544);
			BodySearchBehaviour.NativeMethodInfoPtr_RpcLogic___AssignTarget_1824087381_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670545);
			BodySearchBehaviour.NativeMethodInfoPtr_RpcReader___Observers_AssignTarget_1824087381_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670546);
			BodySearchBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670547);
		}

		// Token: 0x17001328 RID: 4904
		// (get) Token: 0x06003DAA RID: 15786 RVA: 0x00139D38 File Offset: 0x00137F38
		public unsafe static float BODY_SEARCH_TIME
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145205, XrefRangeEnd = 145210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_get_BODY_SEARCH_TIME_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001329 RID: 4905
		// (get) Token: 0x06003DAB RID: 15787 RVA: 0x00139D68 File Offset: 0x00137F68
		// (set) Token: 0x06003DAC RID: 15788 RVA: 0x00139DA8 File Offset: 0x00137FA8
		public unsafe Player TargetPlayer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 115205, RefRangeEnd = 115213, XrefRangeStart = 115205, XrefRangeEnd = 115213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_set_TargetPlayer_Protected_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700132A RID: 4906
		// (get) Token: 0x06003DAD RID: 15789 RVA: 0x00139DEC File Offset: 0x00137FEC
		public unsafe DialogueDatabase dialogueDatabase
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_get_dialogueDatabase_Private_get_DialogueDatabase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogueDatabase>(intPtr3) : null;
			}
		}

		// Token: 0x06003DAE RID: 15790 RVA: 0x00139E2C File Offset: 0x0013802C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145210, XrefRangeEnd = 145219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DAF RID: 15791 RVA: 0x00139E68 File Offset: 0x00138068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145219, XrefRangeEnd = 145252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DB0 RID: 15792 RVA: 0x00139EA4 File Offset: 0x001380A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145252, XrefRangeEnd = 145269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DB1 RID: 15793 RVA: 0x00139EE0 File Offset: 0x001380E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145269, XrefRangeEnd = 145282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DB2 RID: 15794 RVA: 0x00139F1C File Offset: 0x0013811C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145282, XrefRangeEnd = 145291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DB3 RID: 15795 RVA: 0x00139F58 File Offset: 0x00138158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145291, XrefRangeEnd = 145303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BehaviourUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DB4 RID: 15796 RVA: 0x00139F94 File Offset: 0x00138194
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 145351, RefRangeEnd = 145352, XrefRangeStart = 145303, XrefRangeEnd = 145351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSearch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_UpdateSearch_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DB5 RID: 15797 RVA: 0x00139FC8 File Offset: 0x001381C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145352, XrefRangeEnd = 145374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_UpdateMovement_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DB6 RID: 15798 RVA: 0x0013A004 File Offset: 0x00138204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145374, XrefRangeEnd = 145395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SearchClean()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_SearchClean_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DB7 RID: 15799 RVA: 0x0013A038 File Offset: 0x00138238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145395, XrefRangeEnd = 145416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SearchFail()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_SearchFail_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DB8 RID: 15800 RVA: 0x0013A06C File Offset: 0x0013826C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 145438, RefRangeEnd = 145439, XrefRangeStart = 145416, XrefRangeEnd = 145438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateEscalation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_UpdateEscalation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DB9 RID: 15801 RVA: 0x0013A0A0 File Offset: 0x001382A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145439, XrefRangeEnd = 145446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateLookAt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_UpdateLookAt_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DBA RID: 15802 RVA: 0x0013A0DC File Offset: 0x001382DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145446, XrefRangeEnd = 145470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateCircle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_UpdateCircle_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DBB RID: 15803 RVA: 0x0013A118 File Offset: 0x00138318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145470, XrefRangeEnd = 145472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetArrestCircleAlpha(float alpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref alpha;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_SetArrestCircleAlpha_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DBC RID: 15804 RVA: 0x0013A158 File Offset: 0x00138358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145472, XrefRangeEnd = 145473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetArrestCircleColor(Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_SetArrestCircleColor_Private_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DBD RID: 15805 RVA: 0x0013A198 File Offset: 0x00138398
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 145485, RefRangeEnd = 145486, XrefRangeStart = 145473, XrefRangeEnd = 145485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetNewDestination()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_GetNewDestination_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003DBE RID: 15806 RVA: 0x0013A1D4 File Offset: 0x001383D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 145493, RefRangeEnd = 145495, XrefRangeStart = 145486, XrefRangeEnd = 145493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearSpeedControls()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_ClearSpeedControls_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DBF RID: 15807 RVA: 0x0013A208 File Offset: 0x00138408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145495, XrefRangeEnd = 145500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTargetValid(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_IsTargetValid_Private_Boolean_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003DC0 RID: 15808 RVA: 0x0013A258 File Offset: 0x00138458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145500, XrefRangeEnd = 145502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AssignTarget(NetworkConnection conn, NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_AssignTarget_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DC1 RID: 15809 RVA: 0x0013A2B8 File Offset: 0x001384B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145502, XrefRangeEnd = 145529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool DoesPlayerContainItemsOfInterest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_DoesPlayerContainItemsOfInterest_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003DC2 RID: 15810 RVA: 0x0013A300 File Offset: 0x00138500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145529, XrefRangeEnd = 145581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ConcludeSearch(bool clear)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref clear;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_ConcludeSearch_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DC3 RID: 15811 RVA: 0x0013A34C File Offset: 0x0013854C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145581, XrefRangeEnd = 145600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Escalate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_Escalate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DC4 RID: 15812 RVA: 0x0013A388 File Offset: 0x00138588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145600, XrefRangeEnd = 145604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NoItemsOfInterestFound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_NoItemsOfInterestFound_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DC5 RID: 15813 RVA: 0x0013A3C4 File Offset: 0x001385C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145604, XrefRangeEnd = 145605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BodySearchBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DC6 RID: 15814 RVA: 0x0013A400 File Offset: 0x00138600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145605, XrefRangeEnd = 145613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DC7 RID: 15815 RVA: 0x0013A43C File Offset: 0x0013863C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145613, XrefRangeEnd = 145614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DC8 RID: 15816 RVA: 0x0013A478 File Offset: 0x00138678
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DC9 RID: 15817 RVA: 0x0013A4B4 File Offset: 0x001386B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 145643, RefRangeEnd = 145644, XrefRangeStart = 145614, XrefRangeEnd = 145643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AssignTarget_1824087381(NetworkConnection conn, NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_AssignTarget_1824087381_Private_Void_NetworkConnection_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DCA RID: 15818 RVA: 0x0013A508 File Offset: 0x00138708
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 145656, RefRangeEnd = 145658, XrefRangeStart = 145644, XrefRangeEnd = 145656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___AssignTarget_1824087381(NetworkConnection conn, NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_RpcLogic___AssignTarget_1824087381_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DCB RID: 15819 RVA: 0x0013A568 File Offset: 0x00138768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145658, XrefRangeEnd = 145663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AssignTarget_1824087381(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_RpcReader___Observers_AssignTarget_1824087381_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DCC RID: 15820 RVA: 0x0013A5B8 File Offset: 0x001387B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145663, XrefRangeEnd = 145672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DCD RID: 15821 RVA: 0x0001F119 File Offset: 0x0001D319
		public BodySearchBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001311 RID: 4881
		// (get) Token: 0x06003DCE RID: 15822 RVA: 0x0013A5F4 File Offset: 0x001387F4
		// (set) Token: 0x06003DCF RID: 15823 RVA: 0x0001F122 File Offset: 0x0001D322
		public unsafe static EStealthLevel MAX_STEALTH_LEVEL
		{
			get
			{
				EStealthLevel result;
				IL2CPP.il2cpp_field_static_get_value(BodySearchBehaviour.NativeFieldInfoPtr_MAX_STEALTH_LEVEL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BodySearchBehaviour.NativeFieldInfoPtr_MAX_STEALTH_LEVEL, (void*)(&value));
			}
		}

		// Token: 0x17001312 RID: 4882
		// (get) Token: 0x06003DD0 RID: 15824 RVA: 0x0013A610 File Offset: 0x00138810
		// (set) Token: 0x06003DD1 RID: 15825 RVA: 0x0001F130 File Offset: 0x0001D330
		public unsafe static float BODY_SEARCH_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BodySearchBehaviour.NativeFieldInfoPtr_BODY_SEARCH_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BodySearchBehaviour.NativeFieldInfoPtr_BODY_SEARCH_RANGE, (void*)(&value));
			}
		}

		// Token: 0x17001313 RID: 4883
		// (get) Token: 0x06003DD2 RID: 15826 RVA: 0x0013A62C File Offset: 0x0013882C
		// (set) Token: 0x06003DD3 RID: 15827 RVA: 0x0001F13E File Offset: 0x0001D33E
		public unsafe static float MAX_SEARCH_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BodySearchBehaviour.NativeFieldInfoPtr_MAX_SEARCH_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BodySearchBehaviour.NativeFieldInfoPtr_MAX_SEARCH_TIME, (void*)(&value));
			}
		}

		// Token: 0x17001314 RID: 4884
		// (get) Token: 0x06003DD4 RID: 15828 RVA: 0x0013A648 File Offset: 0x00138848
		// (set) Token: 0x06003DD5 RID: 15829 RVA: 0x0001F14C File Offset: 0x0001D34C
		public unsafe static float MAX_TIME_OUTSIDE_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BodySearchBehaviour.NativeFieldInfoPtr_MAX_TIME_OUTSIDE_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BodySearchBehaviour.NativeFieldInfoPtr_MAX_TIME_OUTSIDE_RANGE, (void*)(&value));
			}
		}

		// Token: 0x17001315 RID: 4885
		// (get) Token: 0x06003DD6 RID: 15830 RVA: 0x0013A664 File Offset: 0x00138864
		// (set) Token: 0x06003DD7 RID: 15831 RVA: 0x0001F15A File Offset: 0x0001D35A
		public unsafe static float RANGE_TO_ESCALATE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BodySearchBehaviour.NativeFieldInfoPtr_RANGE_TO_ESCALATE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BodySearchBehaviour.NativeFieldInfoPtr_RANGE_TO_ESCALATE, (void*)(&value));
			}
		}

		// Token: 0x17001316 RID: 4886
		// (get) Token: 0x06003DD8 RID: 15832 RVA: 0x0013A680 File Offset: 0x00138880
		// (set) Token: 0x06003DD9 RID: 15833 RVA: 0x0001F168 File Offset: 0x0001D368
		public unsafe static float MOVE_SPEED
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BodySearchBehaviour.NativeFieldInfoPtr_MOVE_SPEED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BodySearchBehaviour.NativeFieldInfoPtr_MOVE_SPEED, (void*)(&value));
			}
		}

		// Token: 0x17001317 RID: 4887
		// (get) Token: 0x06003DDA RID: 15834 RVA: 0x0013A69C File Offset: 0x0013889C
		// (set) Token: 0x06003DDB RID: 15835 RVA: 0x0001F176 File Offset: 0x0001D376
		public unsafe static float BODY_SEARCH_COOLDOWN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BodySearchBehaviour.NativeFieldInfoPtr_BODY_SEARCH_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BodySearchBehaviour.NativeFieldInfoPtr_BODY_SEARCH_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x17001318 RID: 4888
		// (get) Token: 0x06003DDC RID: 15836 RVA: 0x0013A6B8 File Offset: 0x001388B8
		// (set) Token: 0x06003DDD RID: 15837 RVA: 0x0001F184 File Offset: 0x0001D384
		public unsafe Player _TargetPlayer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001319 RID: 4889
		// (get) Token: 0x06003DDE RID: 15838 RVA: 0x0013A6E8 File Offset: 0x001388E8
		// (set) Token: 0x06003DDF RID: 15839 RVA: 0x0001F1A3 File Offset: 0x0001D3A3
		public unsafe float ArrestCircle_MaxVisibleDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_ArrestCircle_MaxVisibleDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_ArrestCircle_MaxVisibleDistance)) = value;
			}
		}

		// Token: 0x1700131A RID: 4890
		// (get) Token: 0x06003DE0 RID: 15840 RVA: 0x0013A710 File Offset: 0x00138910
		// (set) Token: 0x06003DE1 RID: 15841 RVA: 0x0001F1BE File Offset: 0x0001D3BE
		public unsafe float ArrestCircle_MaxOpacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_ArrestCircle_MaxOpacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_ArrestCircle_MaxOpacity)) = value;
			}
		}

		// Token: 0x1700131B RID: 4891
		// (get) Token: 0x06003DE2 RID: 15842 RVA: 0x0013A738 File Offset: 0x00138938
		// (set) Token: 0x06003DE3 RID: 15843 RVA: 0x0001F1D9 File Offset: 0x0001D3D9
		public unsafe bool ShowPostSearchDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_ShowPostSearchDialogue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_ShowPostSearchDialogue)) = value;
			}
		}

		// Token: 0x1700131C RID: 4892
		// (get) Token: 0x06003DE4 RID: 15844 RVA: 0x0013A760 File Offset: 0x00138960
		// (set) Token: 0x06003DE5 RID: 15845 RVA: 0x0001F1F4 File Offset: 0x0001D3F4
		public unsafe EStealthLevel MaxStealthLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_MaxStealthLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_MaxStealthLevel)) = value;
			}
		}

		// Token: 0x1700131D RID: 4893
		// (get) Token: 0x06003DE6 RID: 15846 RVA: 0x0013A788 File Offset: 0x00138988
		// (set) Token: 0x06003DE7 RID: 15847 RVA: 0x0001F20F File Offset: 0x0001D40F
		public unsafe PoliceOfficer officer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_officer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceOfficer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_officer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700131E RID: 4894
		// (get) Token: 0x06003DE8 RID: 15848 RVA: 0x0013A7B8 File Offset: 0x001389B8
		// (set) Token: 0x06003DE9 RID: 15849 RVA: 0x0001F22E File Offset: 0x0001D42E
		public unsafe float targetDistanceOnStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_targetDistanceOnStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_targetDistanceOnStart)) = value;
			}
		}

		// Token: 0x1700131F RID: 4895
		// (get) Token: 0x06003DEA RID: 15850 RVA: 0x0013A7E0 File Offset: 0x001389E0
		// (set) Token: 0x06003DEB RID: 15851 RVA: 0x0001F249 File Offset: 0x0001D449
		public unsafe float searchTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_searchTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_searchTime)) = value;
			}
		}

		// Token: 0x17001320 RID: 4896
		// (get) Token: 0x06003DEC RID: 15852 RVA: 0x0013A808 File Offset: 0x00138A08
		// (set) Token: 0x06003DED RID: 15853 RVA: 0x0001F264 File Offset: 0x0001D464
		public unsafe bool hasBeenInRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_hasBeenInRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_hasBeenInRange)) = value;
			}
		}

		// Token: 0x17001321 RID: 4897
		// (get) Token: 0x06003DEE RID: 15854 RVA: 0x0013A830 File Offset: 0x00138A30
		// (set) Token: 0x06003DEF RID: 15855 RVA: 0x0001F27F File Offset: 0x0001D47F
		public unsafe float timeOutsideRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_timeOutsideRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_timeOutsideRange)) = value;
			}
		}

		// Token: 0x17001322 RID: 4898
		// (get) Token: 0x06003DF0 RID: 15856 RVA: 0x0013A858 File Offset: 0x00138A58
		// (set) Token: 0x06003DF1 RID: 15857 RVA: 0x0001F29A File Offset: 0x0001D49A
		public unsafe float timeWithinSearchRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_timeWithinSearchRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_timeWithinSearchRange)) = value;
			}
		}

		// Token: 0x17001323 RID: 4899
		// (get) Token: 0x06003DF2 RID: 15858 RVA: 0x0013A880 File Offset: 0x00138A80
		// (set) Token: 0x06003DF3 RID: 15859 RVA: 0x0001F2B5 File Offset: 0x0001D4B5
		public unsafe float timeSinceCantReach
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_timeSinceCantReach);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_timeSinceCantReach)) = value;
			}
		}

		// Token: 0x17001324 RID: 4900
		// (get) Token: 0x06003DF4 RID: 15860 RVA: 0x0013A8A8 File Offset: 0x00138AA8
		// (set) Token: 0x06003DF5 RID: 15861 RVA: 0x0001F2D0 File Offset: 0x0001D4D0
		public unsafe UnityEvent onSearchComplete_Clear
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_onSearchComplete_Clear);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_onSearchComplete_Clear), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001325 RID: 4901
		// (get) Token: 0x06003DF6 RID: 15862 RVA: 0x0013A8D8 File Offset: 0x00138AD8
		// (set) Token: 0x06003DF7 RID: 15863 RVA: 0x0001F2EF File Offset: 0x0001D4EF
		public unsafe UnityEvent onSearchComplete_ItemsFound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_onSearchComplete_ItemsFound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_onSearchComplete_ItemsFound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001326 RID: 4902
		// (get) Token: 0x06003DF8 RID: 15864 RVA: 0x0013A908 File Offset: 0x00138B08
		// (set) Token: 0x06003DF9 RID: 15865 RVA: 0x0001F30E File Offset: 0x0001D50E
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001327 RID: 4903
		// (get) Token: 0x06003DFA RID: 15866 RVA: 0x0013A930 File Offset: 0x00138B30
		// (set) Token: 0x06003DFB RID: 15867 RVA: 0x0001F329 File Offset: 0x0001D529
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040028BF RID: 10431
		private static readonly IntPtr NativeFieldInfoPtr_MAX_STEALTH_LEVEL;

		// Token: 0x040028C0 RID: 10432
		private static readonly IntPtr NativeFieldInfoPtr_BODY_SEARCH_RANGE;

		// Token: 0x040028C1 RID: 10433
		private static readonly IntPtr NativeFieldInfoPtr_MAX_SEARCH_TIME;

		// Token: 0x040028C2 RID: 10434
		private static readonly IntPtr NativeFieldInfoPtr_MAX_TIME_OUTSIDE_RANGE;

		// Token: 0x040028C3 RID: 10435
		private static readonly IntPtr NativeFieldInfoPtr_RANGE_TO_ESCALATE;

		// Token: 0x040028C4 RID: 10436
		private static readonly IntPtr NativeFieldInfoPtr_MOVE_SPEED;

		// Token: 0x040028C5 RID: 10437
		private static readonly IntPtr NativeFieldInfoPtr_BODY_SEARCH_COOLDOWN;

		// Token: 0x040028C6 RID: 10438
		private static readonly IntPtr NativeFieldInfoPtr__TargetPlayer_k__BackingField;

		// Token: 0x040028C7 RID: 10439
		private static readonly IntPtr NativeFieldInfoPtr_ArrestCircle_MaxVisibleDistance;

		// Token: 0x040028C8 RID: 10440
		private static readonly IntPtr NativeFieldInfoPtr_ArrestCircle_MaxOpacity;

		// Token: 0x040028C9 RID: 10441
		private static readonly IntPtr NativeFieldInfoPtr_ShowPostSearchDialogue;

		// Token: 0x040028CA RID: 10442
		private static readonly IntPtr NativeFieldInfoPtr_MaxStealthLevel;

		// Token: 0x040028CB RID: 10443
		private static readonly IntPtr NativeFieldInfoPtr_officer;

		// Token: 0x040028CC RID: 10444
		private static readonly IntPtr NativeFieldInfoPtr_targetDistanceOnStart;

		// Token: 0x040028CD RID: 10445
		private static readonly IntPtr NativeFieldInfoPtr_searchTime;

		// Token: 0x040028CE RID: 10446
		private static readonly IntPtr NativeFieldInfoPtr_hasBeenInRange;

		// Token: 0x040028CF RID: 10447
		private static readonly IntPtr NativeFieldInfoPtr_timeOutsideRange;

		// Token: 0x040028D0 RID: 10448
		private static readonly IntPtr NativeFieldInfoPtr_timeWithinSearchRange;

		// Token: 0x040028D1 RID: 10449
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceCantReach;

		// Token: 0x040028D2 RID: 10450
		private static readonly IntPtr NativeFieldInfoPtr_onSearchComplete_Clear;

		// Token: 0x040028D3 RID: 10451
		private static readonly IntPtr NativeFieldInfoPtr_onSearchComplete_ItemsFound;

		// Token: 0x040028D4 RID: 10452
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040028D5 RID: 10453
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040028D6 RID: 10454
		private static readonly IntPtr NativeMethodInfoPtr_get_BODY_SEARCH_TIME_Public_Static_get_Single_0;

		// Token: 0x040028D7 RID: 10455
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0;

		// Token: 0x040028D8 RID: 10456
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetPlayer_Protected_set_Void_Player_0;

		// Token: 0x040028D9 RID: 10457
		private static readonly IntPtr NativeMethodInfoPtr_get_dialogueDatabase_Private_get_DialogueDatabase_0;

		// Token: 0x040028DA RID: 10458
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040028DB RID: 10459
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1;

		// Token: 0x040028DC RID: 10460
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1;

		// Token: 0x040028DD RID: 10461
		private static readonly IntPtr NativeMethodInfoPtr_End_Protected_Virtual_Void_1;

		// Token: 0x040028DE RID: 10462
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1;

		// Token: 0x040028DF RID: 10463
		private static readonly IntPtr NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0;

		// Token: 0x040028E0 RID: 10464
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSearch_Private_Void_0;

		// Token: 0x040028E1 RID: 10465
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMovement_Protected_Virtual_New_Void_0;

		// Token: 0x040028E2 RID: 10466
		private static readonly IntPtr NativeMethodInfoPtr_SearchClean_Private_Void_0;

		// Token: 0x040028E3 RID: 10467
		private static readonly IntPtr NativeMethodInfoPtr_SearchFail_Private_Void_0;

		// Token: 0x040028E4 RID: 10468
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEscalation_Private_Void_0;

		// Token: 0x040028E5 RID: 10469
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLookAt_Protected_Virtual_New_Void_0;

		// Token: 0x040028E6 RID: 10470
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCircle_Protected_Virtual_New_Void_0;

		// Token: 0x040028E7 RID: 10471
		private static readonly IntPtr NativeMethodInfoPtr_SetArrestCircleAlpha_Private_Void_Single_0;

		// Token: 0x040028E8 RID: 10472
		private static readonly IntPtr NativeMethodInfoPtr_SetArrestCircleColor_Private_Void_Color_0;

		// Token: 0x040028E9 RID: 10473
		private static readonly IntPtr NativeMethodInfoPtr_GetNewDestination_Private_Vector3_0;

		// Token: 0x040028EA RID: 10474
		private static readonly IntPtr NativeMethodInfoPtr_ClearSpeedControls_Private_Void_0;

		// Token: 0x040028EB RID: 10475
		private static readonly IntPtr NativeMethodInfoPtr_IsTargetValid_Private_Boolean_Player_0;

		// Token: 0x040028EC RID: 10476
		private static readonly IntPtr NativeMethodInfoPtr_AssignTarget_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0;

		// Token: 0x040028ED RID: 10477
		private static readonly IntPtr NativeMethodInfoPtr_DoesPlayerContainItemsOfInterest_Public_Virtual_New_Boolean_0;

		// Token: 0x040028EE RID: 10478
		private static readonly IntPtr NativeMethodInfoPtr_ConcludeSearch_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x040028EF RID: 10479
		private static readonly IntPtr NativeMethodInfoPtr_Escalate_Public_Virtual_New_Void_0;

		// Token: 0x040028F0 RID: 10480
		private static readonly IntPtr NativeMethodInfoPtr_NoItemsOfInterestFound_Public_Virtual_New_Void_0;

		// Token: 0x040028F1 RID: 10481
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040028F2 RID: 10482
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040028F3 RID: 10483
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040028F4 RID: 10484
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040028F5 RID: 10485
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AssignTarget_1824087381_Private_Void_NetworkConnection_NetworkObject_0;

		// Token: 0x040028F6 RID: 10486
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AssignTarget_1824087381_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0;

		// Token: 0x040028F7 RID: 10487
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_AssignTarget_1824087381_Private_Void_PooledReader_Channel_0;

		// Token: 0x040028F8 RID: 10488
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;
	}
}
