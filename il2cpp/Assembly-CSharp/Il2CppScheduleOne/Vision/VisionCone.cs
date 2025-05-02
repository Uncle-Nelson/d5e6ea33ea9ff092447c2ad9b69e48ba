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
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.UI.WorldspacePopup;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Vision
{
	// Token: 0x02000175 RID: 373
	public class VisionCone : NetworkBehaviour
	{
		// Token: 0x06001DE4 RID: 7652 RVA: 0x000CD4FC File Offset: 0x000CB6FC
		// Note: this type is marked as 'beforefieldinit'.
		static VisionCone()
		{
			Il2CppClassPointerStore<VisionCone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vision", "VisionCone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisionCone>.NativeClassPtr);
			VisionCone.NativeFieldInfoPtr_VISION_UPDATE_INTERVAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "VISION_UPDATE_INTERVAL");
			VisionCone.NativeFieldInfoPtr_UniversalAttentivenessScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "UniversalAttentivenessScale");
			VisionCone.NativeFieldInfoPtr_UniversalMemoryScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "UniversalMemoryScale");
			VisionCone.NativeFieldInfoPtr_DisableSightUpdates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "DisableSightUpdates");
			VisionCone.NativeFieldInfoPtr_HorizontalFOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "HorizontalFOV");
			VisionCone.NativeFieldInfoPtr_VerticalFOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "VerticalFOV");
			VisionCone.NativeFieldInfoPtr_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "Range");
			VisionCone.NativeFieldInfoPtr_MinorWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "MinorWidth");
			VisionCone.NativeFieldInfoPtr_MinorHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "MinorHeight");
			VisionCone.NativeFieldInfoPtr_VisionOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "VisionOrigin");
			VisionCone.NativeFieldInfoPtr_DEBUG_FRUSTRUM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "DEBUG_FRUSTRUM");
			VisionCone.NativeFieldInfoPtr_VisionEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "VisionEnabled");
			VisionCone.NativeFieldInfoPtr_VisionFalloff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "VisionFalloff");
			VisionCone.NativeFieldInfoPtr_VisibilityBlockingLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "VisibilityBlockingLayers");
			VisionCone.NativeFieldInfoPtr_RangeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "RangeMultiplier");
			VisionCone.NativeFieldInfoPtr_StatesOfInterest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "StatesOfInterest");
			VisionCone.NativeFieldInfoPtr_MinVisionDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "MinVisionDelta");
			VisionCone.NativeFieldInfoPtr_Attentiveness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "Attentiveness");
			VisionCone.NativeFieldInfoPtr_Memory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "Memory");
			VisionCone.NativeFieldInfoPtr_WorldspaceIconsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "WorldspaceIconsEnabled");
			VisionCone.NativeFieldInfoPtr_QuestionMarkPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "QuestionMarkPopup");
			VisionCone.NativeFieldInfoPtr_ExclamationPointPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "ExclamationPointPopup");
			VisionCone.NativeFieldInfoPtr_ExclamationSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "ExclamationSound");
			VisionCone.NativeFieldInfoPtr_onVisionEventStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "onVisionEventStarted");
			VisionCone.NativeFieldInfoPtr_onVisionEventHalf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "onVisionEventHalf");
			VisionCone.NativeFieldInfoPtr_onVisionEventFull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "onVisionEventFull");
			VisionCone.NativeFieldInfoPtr_onVisionEventExpired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "onVisionEventExpired");
			VisionCone.NativeFieldInfoPtr_StateSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "StateSettings");
			VisionCone.NativeFieldInfoPtr_activeVisionEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "activeVisionEvents");
			VisionCone.NativeFieldInfoPtr_playerSightDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "playerSightDatas");
			VisionCone.NativeFieldInfoPtr_npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "npc");
			VisionCone.NativeFieldInfoPtr_generalCrimeResponseActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "generalCrimeResponseActive");
			VisionCone.NativeFieldInfoPtr_sightedPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "sightedPlayers");
			VisionCone.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Vision.VisionConeAssembly-CSharp.dll_Excuted");
			VisionCone.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Vision.VisionConeAssembly-CSharp.dll_Excuted");
			VisionCone.NativeMethodInfoPtr_get_effectiveRange_Protected_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666684);
			VisionCone.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666685);
			VisionCone.NativeMethodInfoPtr_PlayerSpawned_Private_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666686);
			VisionCone.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666687);
			VisionCone.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666688);
			VisionCone.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666689);
			VisionCone.NativeMethodInfoPtr_VisionUpdate_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666690);
			VisionCone.NativeMethodInfoPtr_UpdateEvents_Protected_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666691);
			VisionCone.NativeMethodInfoPtr_UpdateVision_Protected_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666692);
			VisionCone.NativeMethodInfoPtr_EventReachedZero_Public_Virtual_New_Void_VisionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666693);
			VisionCone.NativeMethodInfoPtr_EventHalfNoticed_Public_Virtual_New_Void_VisionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666694);
			VisionCone.NativeMethodInfoPtr_EventFullyNoticed_Public_Virtual_New_Void_VisionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666695);
			VisionCone.NativeMethodInfoPtr_SendEventReceipt_Public_Void_VisionEventReceipt_EEventLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666696);
			VisionCone.NativeMethodInfoPtr_ReceiveEventReceipt_Public_Virtual_New_Void_VisionEventReceipt_EEventLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666697);
			VisionCone.NativeMethodInfoPtr_IsPointWithinSight_Public_Virtual_New_Boolean_Vector3_Boolean_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666698);
			VisionCone.NativeMethodInfoPtr_GetEvent_Public_VisionEvent_Player_VisualState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666699);
			VisionCone.NativeMethodInfoPtr_IsPlayerVisible_Public_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666700);
			VisionCone.NativeMethodInfoPtr_GetPlayerVisibility_Public_Single_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666701);
			VisionCone.NativeMethodInfoPtr_IsPlayerVisible_Public_Boolean_Player_byref_PlayerSightData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666702);
			VisionCone.NativeMethodInfoPtr_SetGeneralCrimeResponseActive_Public_Virtual_New_Void_Player_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666703);
			VisionCone.NativeMethodInfoPtr_OnDie_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666704);
			VisionCone.NativeMethodInfoPtr_ClearEvents_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666705);
			VisionCone.NativeMethodInfoPtr_GetFrustumVertices_Private_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666706);
			VisionCone.NativeMethodInfoPtr_GetFrustumPlanes_Private_Il2CppStructArray_1_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666707);
			VisionCone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666708);
			VisionCone.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666710);
			VisionCone.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666711);
			VisionCone.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666712);
			VisionCone.NativeMethodInfoPtr_RpcWriter___Server_SendEventReceipt_3486014028_Private_Void_VisionEventReceipt_EEventLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666713);
			VisionCone.NativeMethodInfoPtr_RpcLogic___SendEventReceipt_3486014028_Public_Void_VisionEventReceipt_EEventLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666714);
			VisionCone.NativeMethodInfoPtr_RpcReader___Server_SendEventReceipt_3486014028_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666715);
			VisionCone.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveEventReceipt_3486014028_Private_Void_VisionEventReceipt_EEventLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666716);
			VisionCone.NativeMethodInfoPtr_RpcLogic___ReceiveEventReceipt_3486014028_Public_Virtual_New_Void_VisionEventReceipt_EEventLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666717);
			VisionCone.NativeMethodInfoPtr_RpcReader___Observers_ReceiveEventReceipt_3486014028_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666718);
			VisionCone.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666719);
		}

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x06001DE5 RID: 7653 RVA: 0x000CDAA4 File Offset: 0x000CBCA4
		public unsafe float effectiveRange
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_get_effectiveRange_Protected_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DE6 RID: 7654 RVA: 0x000CDAE0 File Offset: 0x000CBCE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106571, XrefRangeEnd = 106572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DE7 RID: 7655 RVA: 0x000CDB1C File Offset: 0x000CBD1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106572, XrefRangeEnd = 106592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerSpawned(Player plr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(plr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_PlayerSpawned_Private_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DE8 RID: 7656 RVA: 0x000CDB60 File Offset: 0x000CBD60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106592, XrefRangeEnd = 106602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DE9 RID: 7657 RVA: 0x000CDB94 File Offset: 0x000CBD94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106602, XrefRangeEnd = 106603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DEA RID: 7658 RVA: 0x000CDBD0 File Offset: 0x000CBDD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106603, XrefRangeEnd = 106618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DEB RID: 7659 RVA: 0x000CDC0C File Offset: 0x000CBE0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106618, XrefRangeEnd = 106619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void VisionUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_VisionUpdate_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DEC RID: 7660 RVA: 0x000CDC48 File Offset: 0x000CBE48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106619, XrefRangeEnd = 106765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateEvents(float tickTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref tickTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_UpdateEvents_Protected_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DED RID: 7661 RVA: 0x000CDC94 File Offset: 0x000CBE94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106765, XrefRangeEnd = 106853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateVision(float tickTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref tickTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_UpdateVision_Protected_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DEE RID: 7662 RVA: 0x000CDCE0 File Offset: 0x000CBEE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106853, XrefRangeEnd = 106862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EventReachedZero(VisionEvent _event)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_event);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_EventReachedZero_Public_Virtual_New_Void_VisionEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DEF RID: 7663 RVA: 0x000CDD30 File Offset: 0x000CBF30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106862, XrefRangeEnd = 106868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EventHalfNoticed(VisionEvent _event)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_event);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_EventHalfNoticed_Public_Virtual_New_Void_VisionEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DF0 RID: 7664 RVA: 0x000CDD80 File Offset: 0x000CBF80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106868, XrefRangeEnd = 106880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EventFullyNoticed(VisionEvent _event)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_event);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_EventFullyNoticed_Public_Virtual_New_Void_VisionEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DF1 RID: 7665 RVA: 0x000CDDD0 File Offset: 0x000CBFD0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 106902, RefRangeEnd = 106905, XrefRangeStart = 106880, XrefRangeEnd = 106902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendEventReceipt(VisionEventReceipt receipt, VisionCone.EEventLevel level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(receipt);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_SendEventReceipt_Public_Void_VisionEventReceipt_EEventLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DF2 RID: 7666 RVA: 0x000CDE20 File Offset: 0x000CC020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106905, XrefRangeEnd = 106928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ReceiveEventReceipt(VisionEventReceipt receipt, VisionCone.EEventLevel level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(receipt);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_ReceiveEventReceipt_Public_Virtual_New_Void_VisionEventReceipt_EEventLevel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DF3 RID: 7667 RVA: 0x000CDE7C File Offset: 0x000CC07C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106928, XrefRangeEnd = 106966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsPointWithinSight(Vector3 point, bool ignoreLoS = false, LandVehicle vehicleToIgnore = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreLoS;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vehicleToIgnore);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_IsPointWithinSight_Public_Virtual_New_Boolean_Vector3_Boolean_LandVehicle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DF4 RID: 7668 RVA: 0x000CDEF0 File Offset: 0x000CC0F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 106982, RefRangeEnd = 106983, XrefRangeStart = 106966, XrefRangeEnd = 106982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisionEvent GetEvent(Player target, PlayerVisualState.VisualState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_GetEvent_Public_VisionEvent_Player_VisualState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisionEvent>(intPtr3) : null;
		}

		// Token: 0x06001DF5 RID: 7669 RVA: 0x000CDF54 File Offset: 0x000CC154
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 106987, RefRangeEnd = 106999, XrefRangeStart = 106983, XrefRangeEnd = 106987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPlayerVisible(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_IsPlayerVisible_Public_Boolean_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DF6 RID: 7670 RVA: 0x000CDFA4 File Offset: 0x000CC1A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 107003, RefRangeEnd = 107005, XrefRangeStart = 106999, XrefRangeEnd = 107003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetPlayerVisibility(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_GetPlayerVisibility_Public_Single_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DF7 RID: 7671 RVA: 0x000CDFF4 File Offset: 0x000CC1F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 107010, RefRangeEnd = 107011, XrefRangeStart = 107005, XrefRangeEnd = 107010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPlayerVisible(Player player, out VisionCone.PlayerSightData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_IsPlayerVisible_Public_Boolean_Player_byref_PlayerSightData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			data = ((intPtr4 == 0) ? null : new VisionCone.PlayerSightData(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001DF8 RID: 7672 RVA: 0x000CE064 File Offset: 0x000CC264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107011, XrefRangeEnd = 107017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGeneralCrimeResponseActive(Player player, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_SetGeneralCrimeResponseActive_Public_Virtual_New_Void_Player_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DF9 RID: 7673 RVA: 0x000CE0C0 File Offset: 0x000CC2C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 107026, RefRangeEnd = 107027, XrefRangeStart = 107017, XrefRangeEnd = 107026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDie()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_OnDie_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DFA RID: 7674 RVA: 0x000CE0F4 File Offset: 0x000CC2F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 107026, RefRangeEnd = 107027, XrefRangeStart = 107026, XrefRangeEnd = 107027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_ClearEvents_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DFB RID: 7675 RVA: 0x000CE128 File Offset: 0x000CC328
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 107049, RefRangeEnd = 107050, XrefRangeStart = 107027, XrefRangeEnd = 107049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<Vector3> GetFrustumVertices()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_GetFrustumVertices_Private_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06001DFC RID: 7676 RVA: 0x000CE168 File Offset: 0x000CC368
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 107071, RefRangeEnd = 107072, XrefRangeStart = 107050, XrefRangeEnd = 107071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<Plane> GetFrustumPlanes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_GetFrustumPlanes_Private_Il2CppStructArray_1_Plane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Plane>>(intPtr3) : null;
		}

		// Token: 0x06001DFD RID: 7677 RVA: 0x000CE1A8 File Offset: 0x000CC3A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107072, XrefRangeEnd = 107108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisionCone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisionCone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DFE RID: 7678 RVA: 0x000CE1E4 File Offset: 0x000CC3E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107108, XrefRangeEnd = 107122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DFF RID: 7679 RVA: 0x000CE220 File Offset: 0x000CC420
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E00 RID: 7680 RVA: 0x000CE25C File Offset: 0x000CC45C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E01 RID: 7681 RVA: 0x000CE298 File Offset: 0x000CC498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107122, XrefRangeEnd = 107142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendEventReceipt_3486014028(VisionEventReceipt receipt, VisionCone.EEventLevel level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(receipt);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_RpcWriter___Server_SendEventReceipt_3486014028_Private_Void_VisionEventReceipt_EEventLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E02 RID: 7682 RVA: 0x000CE2E8 File Offset: 0x000CC4E8
		[CallerCount(0)]
		public unsafe void RpcLogic___SendEventReceipt_3486014028(VisionEventReceipt receipt, VisionCone.EEventLevel level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(receipt);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_RpcLogic___SendEventReceipt_3486014028_Public_Void_VisionEventReceipt_EEventLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E03 RID: 7683 RVA: 0x000CE338 File Offset: 0x000CC538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107142, XrefRangeEnd = 107146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendEventReceipt_3486014028(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_RpcReader___Server_SendEventReceipt_3486014028_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E04 RID: 7684 RVA: 0x000CE39C File Offset: 0x000CC59C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107146, XrefRangeEnd = 107166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveEventReceipt_3486014028(VisionEventReceipt receipt, VisionCone.EEventLevel level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(receipt);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveEventReceipt_3486014028_Private_Void_VisionEventReceipt_EEventLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E05 RID: 7685 RVA: 0x000CE3EC File Offset: 0x000CC5EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 107166, RefRangeEnd = 107168, XrefRangeStart = 107166, XrefRangeEnd = 107166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___ReceiveEventReceipt_3486014028(VisionEventReceipt receipt, VisionCone.EEventLevel level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(receipt);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_RpcLogic___ReceiveEventReceipt_3486014028_Public_Virtual_New_Void_VisionEventReceipt_EEventLevel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E06 RID: 7686 RVA: 0x000CE448 File Offset: 0x000CC648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107168, XrefRangeEnd = 107173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveEventReceipt_3486014028(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_RpcReader___Observers_ReceiveEventReceipt_3486014028_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E07 RID: 7687 RVA: 0x000CE498 File Offset: 0x000CC698
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 107250, RefRangeEnd = 107251, XrefRangeStart = 107173, XrefRangeEnd = 107250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E08 RID: 7688 RVA: 0x00010E37 File Offset: 0x0000F037
		public VisionCone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x06001E09 RID: 7689 RVA: 0x000CE4D4 File Offset: 0x000CC6D4
		// (set) Token: 0x06001E0A RID: 7690 RVA: 0x00010E40 File Offset: 0x0000F040
		public unsafe static float VISION_UPDATE_INTERVAL
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VisionCone.NativeFieldInfoPtr_VISION_UPDATE_INTERVAL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisionCone.NativeFieldInfoPtr_VISION_UPDATE_INTERVAL, (void*)(&value));
			}
		}

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x06001E0B RID: 7691 RVA: 0x000CE4F0 File Offset: 0x000CC6F0
		// (set) Token: 0x06001E0C RID: 7692 RVA: 0x00010E4E File Offset: 0x0000F04E
		public unsafe static float UniversalAttentivenessScale
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VisionCone.NativeFieldInfoPtr_UniversalAttentivenessScale, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisionCone.NativeFieldInfoPtr_UniversalAttentivenessScale, (void*)(&value));
			}
		}

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x06001E0D RID: 7693 RVA: 0x000CE50C File Offset: 0x000CC70C
		// (set) Token: 0x06001E0E RID: 7694 RVA: 0x00010E5C File Offset: 0x0000F05C
		public unsafe static float UniversalMemoryScale
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VisionCone.NativeFieldInfoPtr_UniversalMemoryScale, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisionCone.NativeFieldInfoPtr_UniversalMemoryScale, (void*)(&value));
			}
		}

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x06001E0F RID: 7695 RVA: 0x000CE528 File Offset: 0x000CC728
		// (set) Token: 0x06001E10 RID: 7696 RVA: 0x00010E6A File Offset: 0x0000F06A
		public unsafe bool DisableSightUpdates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_DisableSightUpdates);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_DisableSightUpdates)) = value;
			}
		}

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x06001E11 RID: 7697 RVA: 0x000CE550 File Offset: 0x000CC750
		// (set) Token: 0x06001E12 RID: 7698 RVA: 0x00010E85 File Offset: 0x0000F085
		public unsafe float HorizontalFOV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_HorizontalFOV);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_HorizontalFOV)) = value;
			}
		}

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x06001E13 RID: 7699 RVA: 0x000CE578 File Offset: 0x000CC778
		// (set) Token: 0x06001E14 RID: 7700 RVA: 0x00010EA0 File Offset: 0x0000F0A0
		public unsafe float VerticalFOV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_VerticalFOV);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_VerticalFOV)) = value;
			}
		}

		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x06001E15 RID: 7701 RVA: 0x000CE5A0 File Offset: 0x000CC7A0
		// (set) Token: 0x06001E16 RID: 7702 RVA: 0x00010EBB File Offset: 0x0000F0BB
		public unsafe float Range
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_Range);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_Range)) = value;
			}
		}

		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x06001E17 RID: 7703 RVA: 0x000CE5C8 File Offset: 0x000CC7C8
		// (set) Token: 0x06001E18 RID: 7704 RVA: 0x00010ED6 File Offset: 0x0000F0D6
		public unsafe float MinorWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_MinorWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_MinorWidth)) = value;
			}
		}

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x06001E19 RID: 7705 RVA: 0x000CE5F0 File Offset: 0x000CC7F0
		// (set) Token: 0x06001E1A RID: 7706 RVA: 0x00010EF1 File Offset: 0x0000F0F1
		public unsafe float MinorHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_MinorHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_MinorHeight)) = value;
			}
		}

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x06001E1B RID: 7707 RVA: 0x000CE618 File Offset: 0x000CC818
		// (set) Token: 0x06001E1C RID: 7708 RVA: 0x00010F0C File Offset: 0x0000F10C
		public unsafe Transform VisionOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_VisionOrigin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_VisionOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x06001E1D RID: 7709 RVA: 0x000CE648 File Offset: 0x000CC848
		// (set) Token: 0x06001E1E RID: 7710 RVA: 0x00010F2B File Offset: 0x0000F12B
		public unsafe bool DEBUG_FRUSTRUM
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_DEBUG_FRUSTRUM);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_DEBUG_FRUSTRUM)) = value;
			}
		}

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x06001E1F RID: 7711 RVA: 0x000CE670 File Offset: 0x000CC870
		// (set) Token: 0x06001E20 RID: 7712 RVA: 0x00010F46 File Offset: 0x0000F146
		public unsafe bool VisionEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_VisionEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_VisionEnabled)) = value;
			}
		}

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x06001E21 RID: 7713 RVA: 0x000CE698 File Offset: 0x000CC898
		// (set) Token: 0x06001E22 RID: 7714 RVA: 0x00010F61 File Offset: 0x0000F161
		public unsafe AnimationCurve VisionFalloff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_VisionFalloff);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_VisionFalloff), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x06001E23 RID: 7715 RVA: 0x000CE6C8 File Offset: 0x000CC8C8
		// (set) Token: 0x06001E24 RID: 7716 RVA: 0x00010F80 File Offset: 0x0000F180
		public unsafe LayerMask VisibilityBlockingLayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_VisibilityBlockingLayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_VisibilityBlockingLayers)) = value;
			}
		}

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x06001E25 RID: 7717 RVA: 0x000CE6F0 File Offset: 0x000CC8F0
		// (set) Token: 0x06001E26 RID: 7718 RVA: 0x00010F9B File Offset: 0x0000F19B
		public unsafe float RangeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_RangeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_RangeMultiplier)) = value;
			}
		}

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x06001E27 RID: 7719 RVA: 0x000CE718 File Offset: 0x000CC918
		// (set) Token: 0x06001E28 RID: 7720 RVA: 0x00010FB6 File Offset: 0x0000F1B6
		public unsafe List<VisionCone.StateContainer> StatesOfInterest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_StatesOfInterest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VisionCone.StateContainer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_StatesOfInterest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x06001E29 RID: 7721 RVA: 0x000CE748 File Offset: 0x000CC948
		// (set) Token: 0x06001E2A RID: 7722 RVA: 0x00010FD5 File Offset: 0x0000F1D5
		public unsafe float MinVisionDelta
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_MinVisionDelta);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_MinVisionDelta)) = value;
			}
		}

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x06001E2B RID: 7723 RVA: 0x000CE770 File Offset: 0x000CC970
		// (set) Token: 0x06001E2C RID: 7724 RVA: 0x00010FF0 File Offset: 0x0000F1F0
		public unsafe float Attentiveness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_Attentiveness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_Attentiveness)) = value;
			}
		}

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x06001E2D RID: 7725 RVA: 0x000CE798 File Offset: 0x000CC998
		// (set) Token: 0x06001E2E RID: 7726 RVA: 0x0001100B File Offset: 0x0000F20B
		public unsafe float Memory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_Memory);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_Memory)) = value;
			}
		}

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x06001E2F RID: 7727 RVA: 0x000CE7C0 File Offset: 0x000CC9C0
		// (set) Token: 0x06001E30 RID: 7728 RVA: 0x00011026 File Offset: 0x0000F226
		public unsafe bool WorldspaceIconsEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_WorldspaceIconsEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_WorldspaceIconsEnabled)) = value;
			}
		}

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x06001E31 RID: 7729 RVA: 0x000CE7E8 File Offset: 0x000CC9E8
		// (set) Token: 0x06001E32 RID: 7730 RVA: 0x00011041 File Offset: 0x0000F241
		public unsafe WorldspacePopup QuestionMarkPopup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_QuestionMarkPopup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspacePopup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_QuestionMarkPopup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x06001E33 RID: 7731 RVA: 0x000CE818 File Offset: 0x000CCA18
		// (set) Token: 0x06001E34 RID: 7732 RVA: 0x00011060 File Offset: 0x0000F260
		public unsafe WorldspacePopup ExclamationPointPopup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_ExclamationPointPopup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspacePopup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_ExclamationPointPopup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x06001E35 RID: 7733 RVA: 0x000CE848 File Offset: 0x000CCA48
		// (set) Token: 0x06001E36 RID: 7734 RVA: 0x0001107F File Offset: 0x0000F27F
		public unsafe AudioSourceController ExclamationSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_ExclamationSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_ExclamationSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x06001E37 RID: 7735 RVA: 0x000CE878 File Offset: 0x000CCA78
		// (set) Token: 0x06001E38 RID: 7736 RVA: 0x0001109E File Offset: 0x0000F29E
		public unsafe VisionCone.EventStateChange onVisionEventStarted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_onVisionEventStarted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisionCone.EventStateChange>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_onVisionEventStarted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x06001E39 RID: 7737 RVA: 0x000CE8A8 File Offset: 0x000CCAA8
		// (set) Token: 0x06001E3A RID: 7738 RVA: 0x000110BD File Offset: 0x0000F2BD
		public unsafe VisionCone.EventStateChange onVisionEventHalf
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_onVisionEventHalf);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisionCone.EventStateChange>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_onVisionEventHalf), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x06001E3B RID: 7739 RVA: 0x000CE8D8 File Offset: 0x000CCAD8
		// (set) Token: 0x06001E3C RID: 7740 RVA: 0x000110DC File Offset: 0x0000F2DC
		public unsafe VisionCone.EventStateChange onVisionEventFull
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_onVisionEventFull);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisionCone.EventStateChange>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_onVisionEventFull), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x06001E3D RID: 7741 RVA: 0x000CE908 File Offset: 0x000CCB08
		// (set) Token: 0x06001E3E RID: 7742 RVA: 0x000110FB File Offset: 0x0000F2FB
		public unsafe VisionCone.EventStateChange onVisionEventExpired
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_onVisionEventExpired);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisionCone.EventStateChange>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_onVisionEventExpired), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x06001E3F RID: 7743 RVA: 0x000CE938 File Offset: 0x000CCB38
		// (set) Token: 0x06001E40 RID: 7744 RVA: 0x0001111A File Offset: 0x0000F31A
		public unsafe Dictionary<Player, Dictionary<PlayerVisualState.EVisualState, VisionCone.StateContainer>> StateSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_StateSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Player, Dictionary<PlayerVisualState.EVisualState, VisionCone.StateContainer>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_StateSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x06001E41 RID: 7745 RVA: 0x000CE968 File Offset: 0x000CCB68
		// (set) Token: 0x06001E42 RID: 7746 RVA: 0x00011139 File Offset: 0x0000F339
		public unsafe List<VisionEvent> activeVisionEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_activeVisionEvents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VisionEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_activeVisionEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x06001E43 RID: 7747 RVA: 0x000CE998 File Offset: 0x000CCB98
		// (set) Token: 0x06001E44 RID: 7748 RVA: 0x00011158 File Offset: 0x0000F358
		public unsafe Dictionary<Player, VisionCone.PlayerSightData> playerSightDatas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_playerSightDatas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Player, VisionCone.PlayerSightData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_playerSightDatas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x06001E45 RID: 7749 RVA: 0x000CE9C8 File Offset: 0x000CCBC8
		// (set) Token: 0x06001E46 RID: 7750 RVA: 0x00011177 File Offset: 0x0000F377
		public unsafe NPC npc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_npc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_npc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x06001E47 RID: 7751 RVA: 0x000CE9F8 File Offset: 0x000CCBF8
		// (set) Token: 0x06001E48 RID: 7752 RVA: 0x00011196 File Offset: 0x0000F396
		public unsafe bool generalCrimeResponseActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_generalCrimeResponseActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_generalCrimeResponseActive)) = value;
			}
		}

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x06001E49 RID: 7753 RVA: 0x000CEA20 File Offset: 0x000CCC20
		// (set) Token: 0x06001E4A RID: 7754 RVA: 0x000111B1 File Offset: 0x0000F3B1
		public unsafe List<Player> sightedPlayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_sightedPlayers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_sightedPlayers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x06001E4B RID: 7755 RVA: 0x000CEA50 File Offset: 0x000CCC50
		// (set) Token: 0x06001E4C RID: 7756 RVA: 0x000111D0 File Offset: 0x0000F3D0
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x06001E4D RID: 7757 RVA: 0x000CEA78 File Offset: 0x000CCC78
		// (set) Token: 0x06001E4E RID: 7758 RVA: 0x000111EB File Offset: 0x0000F3EB
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040013DE RID: 5086
		private static readonly IntPtr NativeFieldInfoPtr_VISION_UPDATE_INTERVAL;

		// Token: 0x040013DF RID: 5087
		private static readonly IntPtr NativeFieldInfoPtr_UniversalAttentivenessScale;

		// Token: 0x040013E0 RID: 5088
		private static readonly IntPtr NativeFieldInfoPtr_UniversalMemoryScale;

		// Token: 0x040013E1 RID: 5089
		private static readonly IntPtr NativeFieldInfoPtr_DisableSightUpdates;

		// Token: 0x040013E2 RID: 5090
		private static readonly IntPtr NativeFieldInfoPtr_HorizontalFOV;

		// Token: 0x040013E3 RID: 5091
		private static readonly IntPtr NativeFieldInfoPtr_VerticalFOV;

		// Token: 0x040013E4 RID: 5092
		private static readonly IntPtr NativeFieldInfoPtr_Range;

		// Token: 0x040013E5 RID: 5093
		private static readonly IntPtr NativeFieldInfoPtr_MinorWidth;

		// Token: 0x040013E6 RID: 5094
		private static readonly IntPtr NativeFieldInfoPtr_MinorHeight;

		// Token: 0x040013E7 RID: 5095
		private static readonly IntPtr NativeFieldInfoPtr_VisionOrigin;

		// Token: 0x040013E8 RID: 5096
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG_FRUSTRUM;

		// Token: 0x040013E9 RID: 5097
		private static readonly IntPtr NativeFieldInfoPtr_VisionEnabled;

		// Token: 0x040013EA RID: 5098
		private static readonly IntPtr NativeFieldInfoPtr_VisionFalloff;

		// Token: 0x040013EB RID: 5099
		private static readonly IntPtr NativeFieldInfoPtr_VisibilityBlockingLayers;

		// Token: 0x040013EC RID: 5100
		private static readonly IntPtr NativeFieldInfoPtr_RangeMultiplier;

		// Token: 0x040013ED RID: 5101
		private static readonly IntPtr NativeFieldInfoPtr_StatesOfInterest;

		// Token: 0x040013EE RID: 5102
		private static readonly IntPtr NativeFieldInfoPtr_MinVisionDelta;

		// Token: 0x040013EF RID: 5103
		private static readonly IntPtr NativeFieldInfoPtr_Attentiveness;

		// Token: 0x040013F0 RID: 5104
		private static readonly IntPtr NativeFieldInfoPtr_Memory;

		// Token: 0x040013F1 RID: 5105
		private static readonly IntPtr NativeFieldInfoPtr_WorldspaceIconsEnabled;

		// Token: 0x040013F2 RID: 5106
		private static readonly IntPtr NativeFieldInfoPtr_QuestionMarkPopup;

		// Token: 0x040013F3 RID: 5107
		private static readonly IntPtr NativeFieldInfoPtr_ExclamationPointPopup;

		// Token: 0x040013F4 RID: 5108
		private static readonly IntPtr NativeFieldInfoPtr_ExclamationSound;

		// Token: 0x040013F5 RID: 5109
		private static readonly IntPtr NativeFieldInfoPtr_onVisionEventStarted;

		// Token: 0x040013F6 RID: 5110
		private static readonly IntPtr NativeFieldInfoPtr_onVisionEventHalf;

		// Token: 0x040013F7 RID: 5111
		private static readonly IntPtr NativeFieldInfoPtr_onVisionEventFull;

		// Token: 0x040013F8 RID: 5112
		private static readonly IntPtr NativeFieldInfoPtr_onVisionEventExpired;

		// Token: 0x040013F9 RID: 5113
		private static readonly IntPtr NativeFieldInfoPtr_StateSettings;

		// Token: 0x040013FA RID: 5114
		private static readonly IntPtr NativeFieldInfoPtr_activeVisionEvents;

		// Token: 0x040013FB RID: 5115
		private static readonly IntPtr NativeFieldInfoPtr_playerSightDatas;

		// Token: 0x040013FC RID: 5116
		private static readonly IntPtr NativeFieldInfoPtr_npc;

		// Token: 0x040013FD RID: 5117
		private static readonly IntPtr NativeFieldInfoPtr_generalCrimeResponseActive;

		// Token: 0x040013FE RID: 5118
		private static readonly IntPtr NativeFieldInfoPtr_sightedPlayers;

		// Token: 0x040013FF RID: 5119
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04001400 RID: 5120
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04001401 RID: 5121
		private static readonly IntPtr NativeMethodInfoPtr_get_effectiveRange_Protected_get_Single_0;

		// Token: 0x04001402 RID: 5122
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04001403 RID: 5123
		private static readonly IntPtr NativeMethodInfoPtr_PlayerSpawned_Private_Void_Player_0;

		// Token: 0x04001404 RID: 5124
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04001405 RID: 5125
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1;

		// Token: 0x04001406 RID: 5126
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1;

		// Token: 0x04001407 RID: 5127
		private static readonly IntPtr NativeMethodInfoPtr_VisionUpdate_Protected_Virtual_New_Void_1;

		// Token: 0x04001408 RID: 5128
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEvents_Protected_Virtual_New_Void_Single_0;

		// Token: 0x04001409 RID: 5129
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVision_Protected_Virtual_New_Void_Single_0;

		// Token: 0x0400140A RID: 5130
		private static readonly IntPtr NativeMethodInfoPtr_EventReachedZero_Public_Virtual_New_Void_VisionEvent_0;

		// Token: 0x0400140B RID: 5131
		private static readonly IntPtr NativeMethodInfoPtr_EventHalfNoticed_Public_Virtual_New_Void_VisionEvent_0;

		// Token: 0x0400140C RID: 5132
		private static readonly IntPtr NativeMethodInfoPtr_EventFullyNoticed_Public_Virtual_New_Void_VisionEvent_0;

		// Token: 0x0400140D RID: 5133
		private static readonly IntPtr NativeMethodInfoPtr_SendEventReceipt_Public_Void_VisionEventReceipt_EEventLevel_0;

		// Token: 0x0400140E RID: 5134
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveEventReceipt_Public_Virtual_New_Void_VisionEventReceipt_EEventLevel_0;

		// Token: 0x0400140F RID: 5135
		private static readonly IntPtr NativeMethodInfoPtr_IsPointWithinSight_Public_Virtual_New_Boolean_Vector3_Boolean_LandVehicle_0;

		// Token: 0x04001410 RID: 5136
		private static readonly IntPtr NativeMethodInfoPtr_GetEvent_Public_VisionEvent_Player_VisualState_0;

		// Token: 0x04001411 RID: 5137
		private static readonly IntPtr NativeMethodInfoPtr_IsPlayerVisible_Public_Boolean_Player_0;

		// Token: 0x04001412 RID: 5138
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerVisibility_Public_Single_Player_0;

		// Token: 0x04001413 RID: 5139
		private static readonly IntPtr NativeMethodInfoPtr_IsPlayerVisible_Public_Boolean_Player_byref_PlayerSightData_0;

		// Token: 0x04001414 RID: 5140
		private static readonly IntPtr NativeMethodInfoPtr_SetGeneralCrimeResponseActive_Public_Virtual_New_Void_Player_Boolean_0;

		// Token: 0x04001415 RID: 5141
		private static readonly IntPtr NativeMethodInfoPtr_OnDie_Private_Void_0;

		// Token: 0x04001416 RID: 5142
		private static readonly IntPtr NativeMethodInfoPtr_ClearEvents_Public_Void_0;

		// Token: 0x04001417 RID: 5143
		private static readonly IntPtr NativeMethodInfoPtr_GetFrustumVertices_Private_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04001418 RID: 5144
		private static readonly IntPtr NativeMethodInfoPtr_GetFrustumPlanes_Private_Il2CppStructArray_1_Plane_0;

		// Token: 0x04001419 RID: 5145
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400141A RID: 5146
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400141B RID: 5147
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400141C RID: 5148
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400141D RID: 5149
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendEventReceipt_3486014028_Private_Void_VisionEventReceipt_EEventLevel_0;

		// Token: 0x0400141E RID: 5150
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendEventReceipt_3486014028_Public_Void_VisionEventReceipt_EEventLevel_0;

		// Token: 0x0400141F RID: 5151
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendEventReceipt_3486014028_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04001420 RID: 5152
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveEventReceipt_3486014028_Private_Void_VisionEventReceipt_EEventLevel_0;

		// Token: 0x04001421 RID: 5153
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveEventReceipt_3486014028_Public_Virtual_New_Void_VisionEventReceipt_EEventLevel_0;

		// Token: 0x04001422 RID: 5154
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveEventReceipt_3486014028_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001423 RID: 5155
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;

		// Token: 0x020008A9 RID: 2217
		[OriginalName("Assembly-CSharp.dll", "", "EEventLevel")]
		public enum EEventLevel
		{
			// Token: 0x04008425 RID: 33829
			Start,
			// Token: 0x04008426 RID: 33830
			Half,
			// Token: 0x04008427 RID: 33831
			Full,
			// Token: 0x04008428 RID: 33832
			Zero
		}

		// Token: 0x020008AA RID: 2218
		[Serializable]
		public class StateContainer : Il2CppSystem.Object
		{
			// Token: 0x0600C2F6 RID: 49910 RVA: 0x002F9844 File Offset: 0x002F7A44
			// Note: this type is marked as 'beforefieldinit'.
			static StateContainer()
			{
				Il2CppClassPointerStore<VisionCone.StateContainer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "StateContainer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisionCone.StateContainer>.NativeClassPtr);
				VisionCone.StateContainer.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone.StateContainer>.NativeClassPtr, "state");
				VisionCone.StateContainer.NativeFieldInfoPtr_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone.StateContainer>.NativeClassPtr, "Enabled");
				VisionCone.StateContainer.NativeFieldInfoPtr_RequiredNoticeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone.StateContainer>.NativeClassPtr, "RequiredNoticeTime");
				VisionCone.StateContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone.StateContainer>.NativeClassPtr, 100666720);
			}

			// Token: 0x0600C2F7 RID: 49911 RVA: 0x002F98C0 File Offset: 0x002F7AC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106469, XrefRangeEnd = 106470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StateContainer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisionCone.StateContainer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.StateContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C2F8 RID: 49912 RVA: 0x0005EDDA File Offset: 0x0005CFDA
			public StateContainer(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CDF RID: 15583
			// (get) Token: 0x0600C2F9 RID: 49913 RVA: 0x002F98FC File Offset: 0x002F7AFC
			// (set) Token: 0x0600C2FA RID: 49914 RVA: 0x0005EDE3 File Offset: 0x0005CFE3
			public unsafe PlayerVisualState.EVisualState state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.StateContainer.NativeFieldInfoPtr_state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.StateContainer.NativeFieldInfoPtr_state)) = value;
				}
			}

			// Token: 0x17003CE0 RID: 15584
			// (get) Token: 0x0600C2FB RID: 49915 RVA: 0x002F9924 File Offset: 0x002F7B24
			// (set) Token: 0x0600C2FC RID: 49916 RVA: 0x0005EDFE File Offset: 0x0005CFFE
			public unsafe bool Enabled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.StateContainer.NativeFieldInfoPtr_Enabled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.StateContainer.NativeFieldInfoPtr_Enabled)) = value;
				}
			}

			// Token: 0x17003CE1 RID: 15585
			// (get) Token: 0x0600C2FD RID: 49917 RVA: 0x002F994C File Offset: 0x002F7B4C
			// (set) Token: 0x0600C2FE RID: 49918 RVA: 0x0005EE19 File Offset: 0x0005D019
			public unsafe float RequiredNoticeTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.StateContainer.NativeFieldInfoPtr_RequiredNoticeTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.StateContainer.NativeFieldInfoPtr_RequiredNoticeTime)) = value;
				}
			}

			// Token: 0x04008429 RID: 33833
			private static readonly IntPtr NativeFieldInfoPtr_state;

			// Token: 0x0400842A RID: 33834
			private static readonly IntPtr NativeFieldInfoPtr_Enabled;

			// Token: 0x0400842B RID: 33835
			private static readonly IntPtr NativeFieldInfoPtr_RequiredNoticeTime;

			// Token: 0x0400842C RID: 33836
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008AB RID: 2219
		public class PlayerSightData : Il2CppSystem.Object
		{
			// Token: 0x0600C2FF RID: 49919 RVA: 0x002F9974 File Offset: 0x002F7B74
			// Note: this type is marked as 'beforefieldinit'.
			static PlayerSightData()
			{
				Il2CppClassPointerStore<VisionCone.PlayerSightData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "PlayerSightData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisionCone.PlayerSightData>.NativeClassPtr);
				VisionCone.PlayerSightData.NativeFieldInfoPtr_Player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone.PlayerSightData>.NativeClassPtr, "Player");
				VisionCone.PlayerSightData.NativeFieldInfoPtr_VisionDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone.PlayerSightData>.NativeClassPtr, "VisionDelta");
				VisionCone.PlayerSightData.NativeFieldInfoPtr_TimeVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone.PlayerSightData>.NativeClassPtr, "TimeVisible");
				VisionCone.PlayerSightData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone.PlayerSightData>.NativeClassPtr, 100666721);
			}

			// Token: 0x0600C300 RID: 49920 RVA: 0x002F99F0 File Offset: 0x002F7BF0
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PlayerSightData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisionCone.PlayerSightData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.PlayerSightData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C301 RID: 49921 RVA: 0x0005EE34 File Offset: 0x0005D034
			public PlayerSightData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CE2 RID: 15586
			// (get) Token: 0x0600C302 RID: 49922 RVA: 0x002F9A2C File Offset: 0x002F7C2C
			// (set) Token: 0x0600C303 RID: 49923 RVA: 0x0005EE3D File Offset: 0x0005D03D
			public unsafe Player Player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.PlayerSightData.NativeFieldInfoPtr_Player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.PlayerSightData.NativeFieldInfoPtr_Player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CE3 RID: 15587
			// (get) Token: 0x0600C304 RID: 49924 RVA: 0x002F9A5C File Offset: 0x002F7C5C
			// (set) Token: 0x0600C305 RID: 49925 RVA: 0x0005EE5C File Offset: 0x0005D05C
			public unsafe float VisionDelta
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.PlayerSightData.NativeFieldInfoPtr_VisionDelta);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.PlayerSightData.NativeFieldInfoPtr_VisionDelta)) = value;
				}
			}

			// Token: 0x17003CE4 RID: 15588
			// (get) Token: 0x0600C306 RID: 49926 RVA: 0x002F9A84 File Offset: 0x002F7C84
			// (set) Token: 0x0600C307 RID: 49927 RVA: 0x0005EE77 File Offset: 0x0005D077
			public unsafe float TimeVisible
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.PlayerSightData.NativeFieldInfoPtr_TimeVisible);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.PlayerSightData.NativeFieldInfoPtr_TimeVisible)) = value;
				}
			}

			// Token: 0x0400842D RID: 33837
			private static readonly IntPtr NativeFieldInfoPtr_Player;

			// Token: 0x0400842E RID: 33838
			private static readonly IntPtr NativeFieldInfoPtr_VisionDelta;

			// Token: 0x0400842F RID: 33839
			private static readonly IntPtr NativeFieldInfoPtr_TimeVisible;

			// Token: 0x04008430 RID: 33840
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008AC RID: 2220
		public sealed class EventStateChange : MulticastDelegate
		{
			// Token: 0x0600C308 RID: 49928 RVA: 0x002F9AAC File Offset: 0x002F7CAC
			// Note: this type is marked as 'beforefieldinit'.
			static EventStateChange()
			{
				Il2CppClassPointerStore<VisionCone.EventStateChange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "EventStateChange");
				VisionCone.EventStateChange.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone.EventStateChange>.NativeClassPtr, 100666722);
				VisionCone.EventStateChange.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VisionEventReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone.EventStateChange>.NativeClassPtr, 100666723);
				VisionCone.EventStateChange.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_VisionEventReceipt_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone.EventStateChange>.NativeClassPtr, 100666724);
				VisionCone.EventStateChange.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone.EventStateChange>.NativeClassPtr, 100666725);
			}

			// Token: 0x0600C309 RID: 49929 RVA: 0x002F9B20 File Offset: 0x002F7D20
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 106479, RefRangeEnd = 106558, XrefRangeStart = 106470, XrefRangeEnd = 106479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EventStateChange(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisionCone.EventStateChange>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.EventStateChange.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C30A RID: 49930 RVA: 0x002F9B7C File Offset: 0x002F7D7C
			[CallerCount(0)]
			public unsafe void Invoke(VisionEventReceipt _event)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_event);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.EventStateChange.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VisionEventReceipt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C30B RID: 49931 RVA: 0x002F9BC0 File Offset: 0x002F7DC0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 74827, RefRangeEnd = 74828, XrefRangeStart = 74827, XrefRangeEnd = 74828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(VisionEventReceipt _event, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_event);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.EventStateChange.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_VisionEventReceipt_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600C30C RID: 49932 RVA: 0x002F9C34 File Offset: 0x002F7E34
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22499, RefRangeEnd = 22500, XrefRangeStart = 22499, XrefRangeEnd = 22500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.EventStateChange.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C30D RID: 49933 RVA: 0x0005EE92 File Offset: 0x0005D092
			public EventStateChange(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600C30E RID: 49934 RVA: 0x0005EE9B File Offset: 0x0005D09B
			public static implicit operator VisionCone.EventStateChange(Action<VisionEventReceipt> A_0)
			{
				return DelegateSupport.ConvertDelegate<VisionCone.EventStateChange>(A_0);
			}

			// Token: 0x0600C30F RID: 49935 RVA: 0x0005EEA3 File Offset: 0x0005D0A3
			public static VisionCone.EventStateChange operator +(VisionCone.EventStateChange A_0, VisionCone.EventStateChange A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<VisionCone.EventStateChange>();
			}

			// Token: 0x0600C310 RID: 49936 RVA: 0x0005EEB1 File Offset: 0x0005D0B1
			public static VisionCone.EventStateChange operator -(VisionCone.EventStateChange A_0, VisionCone.EventStateChange A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<VisionCone.EventStateChange>();
				}
				return result;
			}

			// Token: 0x04008431 RID: 33841
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04008432 RID: 33842
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VisionEventReceipt_0;

			// Token: 0x04008433 RID: 33843
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_VisionEventReceipt_AsyncCallback_Object_0;

			// Token: 0x04008434 RID: 33844
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020008AD RID: 2221
		[ObfuscatedName("ScheduleOne.Vision.VisionCone+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600C311 RID: 49937 RVA: 0x002F9C78 File Offset: 0x002F7E78
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<VisionCone.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisionCone.__c>.NativeClassPtr);
				VisionCone.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone.__c>.NativeClassPtr, "<>9");
				VisionCone.__c.NativeFieldInfoPtr___9__45_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone.__c>.NativeClassPtr, "<>9__45_0");
				VisionCone.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone.__c>.NativeClassPtr, 100666727);
				VisionCone.__c.NativeMethodInfoPtr__UpdateEvents_b__45_0_Internal_Boolean_VisionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone.__c>.NativeClassPtr, 100666728);
			}

			// Token: 0x0600C312 RID: 49938 RVA: 0x002F9CF4 File Offset: 0x002F7EF4
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisionCone.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C313 RID: 49939 RVA: 0x002F9D30 File Offset: 0x002F7F30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106558, XrefRangeEnd = 106567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateEvents_b__45_0(VisionEvent x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.__c.NativeMethodInfoPtr__UpdateEvents_b__45_0_Internal_Boolean_VisionEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C314 RID: 49940 RVA: 0x0005EEC2 File Offset: 0x0005D0C2
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CE5 RID: 15589
			// (get) Token: 0x0600C315 RID: 49941 RVA: 0x002F9D80 File Offset: 0x002F7F80
			// (set) Token: 0x0600C316 RID: 49942 RVA: 0x0005EECB File Offset: 0x0005D0CB
			public unsafe static VisionCone.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VisionCone.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisionCone.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VisionCone.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CE6 RID: 15590
			// (get) Token: 0x0600C317 RID: 49943 RVA: 0x002F9DA8 File Offset: 0x002F7FA8
			// (set) Token: 0x0600C318 RID: 49944 RVA: 0x0005EEDD File Offset: 0x0005D0DD
			public unsafe static Predicate<VisionEvent> __9__45_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VisionCone.__c.NativeFieldInfoPtr___9__45_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<VisionEvent>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VisionCone.__c.NativeFieldInfoPtr___9__45_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008435 RID: 33845
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008436 RID: 33846
			private static readonly IntPtr NativeFieldInfoPtr___9__45_0;

			// Token: 0x04008437 RID: 33847
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008438 RID: 33848
			private static readonly IntPtr NativeMethodInfoPtr__UpdateEvents_b__45_0_Internal_Boolean_VisionEvent_0;
		}

		// Token: 0x020008AE RID: 2222
		[ObfuscatedName("ScheduleOne.Vision.VisionCone+<>c__DisplayClass53_0")]
		public sealed class __c__DisplayClass53_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C319 RID: 49945 RVA: 0x002F9DD0 File Offset: 0x002F7FD0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass53_0()
			{
				Il2CppClassPointerStore<VisionCone.__c__DisplayClass53_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "<>c__DisplayClass53_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisionCone.__c__DisplayClass53_0>.NativeClassPtr);
				VisionCone.__c__DisplayClass53_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone.__c__DisplayClass53_0>.NativeClassPtr, "target");
				VisionCone.__c__DisplayClass53_0.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone.__c__DisplayClass53_0>.NativeClassPtr, "state");
				VisionCone.__c__DisplayClass53_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone.__c__DisplayClass53_0>.NativeClassPtr, 100666729);
				VisionCone.__c__DisplayClass53_0.NativeMethodInfoPtr__GetEvent_b__0_Internal_Boolean_VisionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone.__c__DisplayClass53_0>.NativeClassPtr, 100666730);
			}

			// Token: 0x0600C31A RID: 49946 RVA: 0x002F9E4C File Offset: 0x002F804C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass53_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisionCone.__c__DisplayClass53_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.__c__DisplayClass53_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C31B RID: 49947 RVA: 0x002F9E88 File Offset: 0x002F8088
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106567, XrefRangeEnd = 106571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetEvent_b__0(VisionEvent x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.__c__DisplayClass53_0.NativeMethodInfoPtr__GetEvent_b__0_Internal_Boolean_VisionEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C31C RID: 49948 RVA: 0x0005EEEF File Offset: 0x0005D0EF
			public __c__DisplayClass53_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CE7 RID: 15591
			// (get) Token: 0x0600C31D RID: 49949 RVA: 0x002F9ED8 File Offset: 0x002F80D8
			// (set) Token: 0x0600C31E RID: 49950 RVA: 0x0005EEF8 File Offset: 0x0005D0F8
			public unsafe Player target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.__c__DisplayClass53_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.__c__DisplayClass53_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CE8 RID: 15592
			// (get) Token: 0x0600C31F RID: 49951 RVA: 0x002F9F08 File Offset: 0x002F8108
			// (set) Token: 0x0600C320 RID: 49952 RVA: 0x0005EF17 File Offset: 0x0005D117
			public unsafe PlayerVisualState.VisualState state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.__c__DisplayClass53_0.NativeFieldInfoPtr_state);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerVisualState.VisualState>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.__c__DisplayClass53_0.NativeFieldInfoPtr_state), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008439 RID: 33849
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400843A RID: 33850
			private static readonly IntPtr NativeFieldInfoPtr_state;

			// Token: 0x0400843B RID: 33851
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400843C RID: 33852
			private static readonly IntPtr NativeMethodInfoPtr__GetEvent_b__0_Internal_Boolean_VisionEvent_0;
		}
	}
}
