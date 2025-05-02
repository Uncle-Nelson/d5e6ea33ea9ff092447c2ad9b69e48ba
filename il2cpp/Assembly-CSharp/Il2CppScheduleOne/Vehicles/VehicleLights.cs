using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Vehicles.AI;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020004EF RID: 1263
	public class VehicleLights : NetworkBehaviour
	{
		// Token: 0x06006F59 RID: 28505 RVA: 0x001EB620 File Offset: 0x001E9820
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleLights()
		{
			Il2CppClassPointerStore<VehicleLights>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "VehicleLights");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr);
			VehicleLights.NativeFieldInfoPtr_vehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "vehicle");
			VehicleLights.NativeFieldInfoPtr_hasHeadLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "hasHeadLights");
			VehicleLights.NativeFieldInfoPtr_headLightMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "headLightMeshes");
			VehicleLights.NativeFieldInfoPtr_headLightSources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "headLightSources");
			VehicleLights.NativeFieldInfoPtr_headlightMat_On = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "headlightMat_On");
			VehicleLights.NativeFieldInfoPtr_headLightMat_Off = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "headLightMat_Off");
			VehicleLights.NativeFieldInfoPtr__headLightsOn_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "<headLightsOn>k__BackingField");
			VehicleLights.NativeFieldInfoPtr_headLightsApplied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "headLightsApplied");
			VehicleLights.NativeFieldInfoPtr_hasBrakeLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "hasBrakeLights");
			VehicleLights.NativeFieldInfoPtr_brakeLightMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "brakeLightMeshes");
			VehicleLights.NativeFieldInfoPtr_brakeLightSources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "brakeLightSources");
			VehicleLights.NativeFieldInfoPtr_brakeLightMat_On = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "brakeLightMat_On");
			VehicleLights.NativeFieldInfoPtr_brakeLightMat_Off = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "brakeLightMat_Off");
			VehicleLights.NativeFieldInfoPtr_brakeLightMat_Ambient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "brakeLightMat_Ambient");
			VehicleLights.NativeFieldInfoPtr_brakeLightsOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "brakeLightsOn");
			VehicleLights.NativeFieldInfoPtr_brakeLightsApplied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "brakeLightsApplied");
			VehicleLights.NativeFieldInfoPtr_hasReverseLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "hasReverseLights");
			VehicleLights.NativeFieldInfoPtr_reverseLightMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "reverseLightMeshes");
			VehicleLights.NativeFieldInfoPtr_reverseLightSources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "reverseLightSources");
			VehicleLights.NativeFieldInfoPtr_reverseLightMat_On = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "reverseLightMat_On");
			VehicleLights.NativeFieldInfoPtr_reverseLightMat_Off = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "reverseLightMat_Off");
			VehicleLights.NativeFieldInfoPtr_reverseLightsOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "reverseLightsOn");
			VehicleLights.NativeFieldInfoPtr_reverseLightsApplied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "reverseLightsApplied");
			VehicleLights.NativeFieldInfoPtr_onHeadlightsOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "onHeadlightsOn");
			VehicleLights.NativeFieldInfoPtr_onHeadlightsOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "onHeadlightsOff");
			VehicleLights.NativeFieldInfoPtr_brakesAppliedHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "brakesAppliedHistory");
			VehicleLights.NativeFieldInfoPtr_agent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "agent");
			VehicleLights.NativeFieldInfoPtr_syncVar____headLightsOn_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "syncVar___<headLightsOn>k__BackingField");
			VehicleLights.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Vehicles.VehicleLightsAssembly-CSharp.dll_Excuted");
			VehicleLights.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Vehicles.VehicleLightsAssembly-CSharp.dll_Excuted");
			VehicleLights.NativeMethodInfoPtr_get_headLightsOn_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677349);
			VehicleLights.NativeMethodInfoPtr_set_headLightsOn_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677350);
			VehicleLights.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677351);
			VehicleLights.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677352);
			VehicleLights.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677353);
			VehicleLights.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677354);
			VehicleLights.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677355);
			VehicleLights.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677356);
			VehicleLights.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677357);
			VehicleLights.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677358);
			VehicleLights.NativeMethodInfoPtr_RpcWriter___Server_set_headLightsOn_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677359);
			VehicleLights.NativeMethodInfoPtr_RpcLogic___set_headLightsOn_1140765316_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677360);
			VehicleLights.NativeMethodInfoPtr_RpcReader___Server_set_headLightsOn_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677361);
			VehicleLights.NativeMethodInfoPtr_sync___get_value__headLightsOn_k__BackingField_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677362);
			VehicleLights.NativeMethodInfoPtr_sync___set_value__headLightsOn_k__BackingField_Public_set_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677363);
			VehicleLights.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Vehicles_VehicleLights_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677364);
			VehicleLights.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677365);
		}

		// Token: 0x170021AC RID: 8620
		// (get) Token: 0x06006F5A RID: 28506 RVA: 0x001EB9FC File Offset: 0x001E9BFC
		// (set) Token: 0x06006F5B RID: 28507 RVA: 0x001EBA38 File Offset: 0x001E9C38
		public unsafe bool headLightsOn
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleLights.NativeMethodInfoPtr_get_headLightsOn_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 221016, RefRangeEnd = 221018, XrefRangeStart = 220994, XrefRangeEnd = 221016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleLights.NativeMethodInfoPtr_set_headLightsOn_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006F5C RID: 28508 RVA: 0x001EBA78 File Offset: 0x001E9C78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221018, XrefRangeEnd = 221022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleLights.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F5D RID: 28509 RVA: 0x001EBAB4 File Offset: 0x001E9CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221022, XrefRangeEnd = 221048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleLights.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F5E RID: 28510 RVA: 0x001EBAF0 File Offset: 0x001E9CF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221048, XrefRangeEnd = 221066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleLights.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F5F RID: 28511 RVA: 0x001EBB2C File Offset: 0x001E9D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221066, XrefRangeEnd = 221088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleLights.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F60 RID: 28512 RVA: 0x001EBB68 File Offset: 0x001E9D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221088, XrefRangeEnd = 221096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleLights() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleLights.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F61 RID: 28513 RVA: 0x001EBBA4 File Offset: 0x001E9DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221096, XrefRangeEnd = 221119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleLights.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F62 RID: 28514 RVA: 0x001EBBE0 File Offset: 0x001E9DE0
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleLights.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F63 RID: 28515 RVA: 0x001EBC1C File Offset: 0x001E9E1C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleLights.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F64 RID: 28516 RVA: 0x001EBC58 File Offset: 0x001E9E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221119, XrefRangeEnd = 221138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_set_headLightsOn_1140765316(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleLights.NativeMethodInfoPtr_RpcWriter___Server_set_headLightsOn_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F65 RID: 28517 RVA: 0x001EBC98 File Offset: 0x001E9E98
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 221145, RefRangeEnd = 221148, XrefRangeStart = 221138, XrefRangeEnd = 221145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___set_headLightsOn_1140765316(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleLights.NativeMethodInfoPtr_RpcLogic___set_headLightsOn_1140765316_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F66 RID: 28518 RVA: 0x001EBCD8 File Offset: 0x001E9ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221148, XrefRangeEnd = 221151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_set_headLightsOn_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleLights.NativeMethodInfoPtr_RpcReader___Server_set_headLightsOn_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170021AD RID: 8621
		// (get) Token: 0x06006F67 RID: 28519 RVA: 0x001EBD3C File Offset: 0x001E9F3C
		// (set) Token: 0x06006F68 RID: 28520 RVA: 0x001EBD78 File Offset: 0x001E9F78
		public unsafe bool SyncAccessor_<headLightsOn>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleLights.NativeMethodInfoPtr_sync___get_value__headLightsOn_k__BackingField_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 221159, RefRangeEnd = 221160, XrefRangeStart = 221151, XrefRangeEnd = 221159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleLights.NativeMethodInfoPtr_sync___set_value__headLightsOn_k__BackingField_Public_set_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006F69 RID: 28521 RVA: 0x001EBDC4 File Offset: 0x001E9FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221160, XrefRangeEnd = 221163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_Vehicles_VehicleLights(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleLights.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Vehicles_VehicleLights_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006F6A RID: 28522 RVA: 0x001EBE38 File Offset: 0x001EA038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221163, XrefRangeEnd = 221167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleLights.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F6B RID: 28523 RVA: 0x00034B6A File Offset: 0x00032D6A
		public VehicleLights(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700218E RID: 8590
		// (get) Token: 0x06006F6C RID: 28524 RVA: 0x001EBE74 File Offset: 0x001EA074
		// (set) Token: 0x06006F6D RID: 28525 RVA: 0x00034B73 File Offset: 0x00032D73
		public unsafe LandVehicle vehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_vehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_vehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700218F RID: 8591
		// (get) Token: 0x06006F6E RID: 28526 RVA: 0x001EBEA4 File Offset: 0x001EA0A4
		// (set) Token: 0x06006F6F RID: 28527 RVA: 0x00034B92 File Offset: 0x00032D92
		public unsafe bool hasHeadLights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_hasHeadLights);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_hasHeadLights)) = value;
			}
		}

		// Token: 0x17002190 RID: 8592
		// (get) Token: 0x06006F70 RID: 28528 RVA: 0x001EBECC File Offset: 0x001EA0CC
		// (set) Token: 0x06006F71 RID: 28529 RVA: 0x00034BAD File Offset: 0x00032DAD
		public unsafe Il2CppReferenceArray<MeshRenderer> headLightMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_headLightMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_headLightMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002191 RID: 8593
		// (get) Token: 0x06006F72 RID: 28530 RVA: 0x001EBEFC File Offset: 0x001EA0FC
		// (set) Token: 0x06006F73 RID: 28531 RVA: 0x00034BCC File Offset: 0x00032DCC
		public unsafe Il2CppReferenceArray<OptimizedLight> headLightSources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_headLightSources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<OptimizedLight>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_headLightSources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002192 RID: 8594
		// (get) Token: 0x06006F74 RID: 28532 RVA: 0x001EBF2C File Offset: 0x001EA12C
		// (set) Token: 0x06006F75 RID: 28533 RVA: 0x00034BEB File Offset: 0x00032DEB
		public unsafe Material headlightMat_On
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_headlightMat_On);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_headlightMat_On), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002193 RID: 8595
		// (get) Token: 0x06006F76 RID: 28534 RVA: 0x001EBF5C File Offset: 0x001EA15C
		// (set) Token: 0x06006F77 RID: 28535 RVA: 0x00034C0A File Offset: 0x00032E0A
		public unsafe Material headLightMat_Off
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_headLightMat_Off);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_headLightMat_Off), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002194 RID: 8596
		// (get) Token: 0x06006F78 RID: 28536 RVA: 0x001EBF8C File Offset: 0x001EA18C
		// (set) Token: 0x06006F79 RID: 28537 RVA: 0x00034C29 File Offset: 0x00032E29
		public unsafe bool _headLightsOn_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr__headLightsOn_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr__headLightsOn_k__BackingField)) = value;
			}
		}

		// Token: 0x17002195 RID: 8597
		// (get) Token: 0x06006F7A RID: 28538 RVA: 0x001EBFB4 File Offset: 0x001EA1B4
		// (set) Token: 0x06006F7B RID: 28539 RVA: 0x00034C44 File Offset: 0x00032E44
		public unsafe bool headLightsApplied
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_headLightsApplied);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_headLightsApplied)) = value;
			}
		}

		// Token: 0x17002196 RID: 8598
		// (get) Token: 0x06006F7C RID: 28540 RVA: 0x001EBFDC File Offset: 0x001EA1DC
		// (set) Token: 0x06006F7D RID: 28541 RVA: 0x00034C5F File Offset: 0x00032E5F
		public unsafe bool hasBrakeLights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_hasBrakeLights);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_hasBrakeLights)) = value;
			}
		}

		// Token: 0x17002197 RID: 8599
		// (get) Token: 0x06006F7E RID: 28542 RVA: 0x001EC004 File Offset: 0x001EA204
		// (set) Token: 0x06006F7F RID: 28543 RVA: 0x00034C7A File Offset: 0x00032E7A
		public unsafe Il2CppReferenceArray<MeshRenderer> brakeLightMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002198 RID: 8600
		// (get) Token: 0x06006F80 RID: 28544 RVA: 0x001EC034 File Offset: 0x001EA234
		// (set) Token: 0x06006F81 RID: 28545 RVA: 0x00034C99 File Offset: 0x00032E99
		public unsafe Il2CppReferenceArray<Light> brakeLightSources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightSources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Light>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightSources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002199 RID: 8601
		// (get) Token: 0x06006F82 RID: 28546 RVA: 0x001EC064 File Offset: 0x001EA264
		// (set) Token: 0x06006F83 RID: 28547 RVA: 0x00034CB8 File Offset: 0x00032EB8
		public unsafe Material brakeLightMat_On
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightMat_On);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightMat_On), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700219A RID: 8602
		// (get) Token: 0x06006F84 RID: 28548 RVA: 0x001EC094 File Offset: 0x001EA294
		// (set) Token: 0x06006F85 RID: 28549 RVA: 0x00034CD7 File Offset: 0x00032ED7
		public unsafe Material brakeLightMat_Off
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightMat_Off);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightMat_Off), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700219B RID: 8603
		// (get) Token: 0x06006F86 RID: 28550 RVA: 0x001EC0C4 File Offset: 0x001EA2C4
		// (set) Token: 0x06006F87 RID: 28551 RVA: 0x00034CF6 File Offset: 0x00032EF6
		public unsafe Material brakeLightMat_Ambient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightMat_Ambient);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightMat_Ambient), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700219C RID: 8604
		// (get) Token: 0x06006F88 RID: 28552 RVA: 0x001EC0F4 File Offset: 0x001EA2F4
		// (set) Token: 0x06006F89 RID: 28553 RVA: 0x00034D15 File Offset: 0x00032F15
		public unsafe bool brakeLightsOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightsOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightsOn)) = value;
			}
		}

		// Token: 0x1700219D RID: 8605
		// (get) Token: 0x06006F8A RID: 28554 RVA: 0x001EC11C File Offset: 0x001EA31C
		// (set) Token: 0x06006F8B RID: 28555 RVA: 0x00034D30 File Offset: 0x00032F30
		public unsafe bool brakeLightsApplied
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightsApplied);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightsApplied)) = value;
			}
		}

		// Token: 0x1700219E RID: 8606
		// (get) Token: 0x06006F8C RID: 28556 RVA: 0x001EC144 File Offset: 0x001EA344
		// (set) Token: 0x06006F8D RID: 28557 RVA: 0x00034D4B File Offset: 0x00032F4B
		public unsafe bool hasReverseLights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_hasReverseLights);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_hasReverseLights)) = value;
			}
		}

		// Token: 0x1700219F RID: 8607
		// (get) Token: 0x06006F8E RID: 28558 RVA: 0x001EC16C File Offset: 0x001EA36C
		// (set) Token: 0x06006F8F RID: 28559 RVA: 0x00034D66 File Offset: 0x00032F66
		public unsafe Il2CppReferenceArray<MeshRenderer> reverseLightMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_reverseLightMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_reverseLightMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021A0 RID: 8608
		// (get) Token: 0x06006F90 RID: 28560 RVA: 0x001EC19C File Offset: 0x001EA39C
		// (set) Token: 0x06006F91 RID: 28561 RVA: 0x00034D85 File Offset: 0x00032F85
		public unsafe Il2CppReferenceArray<Light> reverseLightSources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_reverseLightSources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Light>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_reverseLightSources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021A1 RID: 8609
		// (get) Token: 0x06006F92 RID: 28562 RVA: 0x001EC1CC File Offset: 0x001EA3CC
		// (set) Token: 0x06006F93 RID: 28563 RVA: 0x00034DA4 File Offset: 0x00032FA4
		public unsafe Material reverseLightMat_On
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_reverseLightMat_On);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_reverseLightMat_On), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021A2 RID: 8610
		// (get) Token: 0x06006F94 RID: 28564 RVA: 0x001EC1FC File Offset: 0x001EA3FC
		// (set) Token: 0x06006F95 RID: 28565 RVA: 0x00034DC3 File Offset: 0x00032FC3
		public unsafe Material reverseLightMat_Off
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_reverseLightMat_Off);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_reverseLightMat_Off), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021A3 RID: 8611
		// (get) Token: 0x06006F96 RID: 28566 RVA: 0x001EC22C File Offset: 0x001EA42C
		// (set) Token: 0x06006F97 RID: 28567 RVA: 0x00034DE2 File Offset: 0x00032FE2
		public unsafe bool reverseLightsOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_reverseLightsOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_reverseLightsOn)) = value;
			}
		}

		// Token: 0x170021A4 RID: 8612
		// (get) Token: 0x06006F98 RID: 28568 RVA: 0x001EC254 File Offset: 0x001EA454
		// (set) Token: 0x06006F99 RID: 28569 RVA: 0x00034DFD File Offset: 0x00032FFD
		public unsafe bool reverseLightsApplied
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_reverseLightsApplied);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_reverseLightsApplied)) = value;
			}
		}

		// Token: 0x170021A5 RID: 8613
		// (get) Token: 0x06006F9A RID: 28570 RVA: 0x001EC27C File Offset: 0x001EA47C
		// (set) Token: 0x06006F9B RID: 28571 RVA: 0x00034E18 File Offset: 0x00033018
		public unsafe UnityEvent onHeadlightsOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_onHeadlightsOn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_onHeadlightsOn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021A6 RID: 8614
		// (get) Token: 0x06006F9C RID: 28572 RVA: 0x001EC2AC File Offset: 0x001EA4AC
		// (set) Token: 0x06006F9D RID: 28573 RVA: 0x00034E37 File Offset: 0x00033037
		public unsafe UnityEvent onHeadlightsOff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_onHeadlightsOff);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_onHeadlightsOff), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021A7 RID: 8615
		// (get) Token: 0x06006F9E RID: 28574 RVA: 0x001EC2DC File Offset: 0x001EA4DC
		// (set) Token: 0x06006F9F RID: 28575 RVA: 0x00034E56 File Offset: 0x00033056
		public unsafe List<bool> brakesAppliedHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakesAppliedHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakesAppliedHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021A8 RID: 8616
		// (get) Token: 0x06006FA0 RID: 28576 RVA: 0x001EC30C File Offset: 0x001EA50C
		// (set) Token: 0x06006FA1 RID: 28577 RVA: 0x00034E75 File Offset: 0x00033075
		public unsafe VehicleAgent agent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_agent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleAgent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_agent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021A9 RID: 8617
		// (get) Token: 0x06006FA2 RID: 28578 RVA: 0x001EC33C File Offset: 0x001EA53C
		// (set) Token: 0x06006FA3 RID: 28579 RVA: 0x00034E94 File Offset: 0x00033094
		public unsafe SyncVar<bool> syncVar____headLightsOn_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_syncVar____headLightsOn_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_syncVar____headLightsOn_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021AA RID: 8618
		// (get) Token: 0x06006FA4 RID: 28580 RVA: 0x001EC36C File Offset: 0x001EA56C
		// (set) Token: 0x06006FA5 RID: 28581 RVA: 0x00034EB3 File Offset: 0x000330B3
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170021AB RID: 8619
		// (get) Token: 0x06006FA6 RID: 28582 RVA: 0x001EC394 File Offset: 0x001EA594
		// (set) Token: 0x06006FA7 RID: 28583 RVA: 0x00034ECE File Offset: 0x000330CE
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004C20 RID: 19488
		private static readonly IntPtr NativeFieldInfoPtr_vehicle;

		// Token: 0x04004C21 RID: 19489
		private static readonly IntPtr NativeFieldInfoPtr_hasHeadLights;

		// Token: 0x04004C22 RID: 19490
		private static readonly IntPtr NativeFieldInfoPtr_headLightMeshes;

		// Token: 0x04004C23 RID: 19491
		private static readonly IntPtr NativeFieldInfoPtr_headLightSources;

		// Token: 0x04004C24 RID: 19492
		private static readonly IntPtr NativeFieldInfoPtr_headlightMat_On;

		// Token: 0x04004C25 RID: 19493
		private static readonly IntPtr NativeFieldInfoPtr_headLightMat_Off;

		// Token: 0x04004C26 RID: 19494
		private static readonly IntPtr NativeFieldInfoPtr__headLightsOn_k__BackingField;

		// Token: 0x04004C27 RID: 19495
		private static readonly IntPtr NativeFieldInfoPtr_headLightsApplied;

		// Token: 0x04004C28 RID: 19496
		private static readonly IntPtr NativeFieldInfoPtr_hasBrakeLights;

		// Token: 0x04004C29 RID: 19497
		private static readonly IntPtr NativeFieldInfoPtr_brakeLightMeshes;

		// Token: 0x04004C2A RID: 19498
		private static readonly IntPtr NativeFieldInfoPtr_brakeLightSources;

		// Token: 0x04004C2B RID: 19499
		private static readonly IntPtr NativeFieldInfoPtr_brakeLightMat_On;

		// Token: 0x04004C2C RID: 19500
		private static readonly IntPtr NativeFieldInfoPtr_brakeLightMat_Off;

		// Token: 0x04004C2D RID: 19501
		private static readonly IntPtr NativeFieldInfoPtr_brakeLightMat_Ambient;

		// Token: 0x04004C2E RID: 19502
		private static readonly IntPtr NativeFieldInfoPtr_brakeLightsOn;

		// Token: 0x04004C2F RID: 19503
		private static readonly IntPtr NativeFieldInfoPtr_brakeLightsApplied;

		// Token: 0x04004C30 RID: 19504
		private static readonly IntPtr NativeFieldInfoPtr_hasReverseLights;

		// Token: 0x04004C31 RID: 19505
		private static readonly IntPtr NativeFieldInfoPtr_reverseLightMeshes;

		// Token: 0x04004C32 RID: 19506
		private static readonly IntPtr NativeFieldInfoPtr_reverseLightSources;

		// Token: 0x04004C33 RID: 19507
		private static readonly IntPtr NativeFieldInfoPtr_reverseLightMat_On;

		// Token: 0x04004C34 RID: 19508
		private static readonly IntPtr NativeFieldInfoPtr_reverseLightMat_Off;

		// Token: 0x04004C35 RID: 19509
		private static readonly IntPtr NativeFieldInfoPtr_reverseLightsOn;

		// Token: 0x04004C36 RID: 19510
		private static readonly IntPtr NativeFieldInfoPtr_reverseLightsApplied;

		// Token: 0x04004C37 RID: 19511
		private static readonly IntPtr NativeFieldInfoPtr_onHeadlightsOn;

		// Token: 0x04004C38 RID: 19512
		private static readonly IntPtr NativeFieldInfoPtr_onHeadlightsOff;

		// Token: 0x04004C39 RID: 19513
		private static readonly IntPtr NativeFieldInfoPtr_brakesAppliedHistory;

		// Token: 0x04004C3A RID: 19514
		private static readonly IntPtr NativeFieldInfoPtr_agent;

		// Token: 0x04004C3B RID: 19515
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____headLightsOn_k__BackingField;

		// Token: 0x04004C3C RID: 19516
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004C3D RID: 19517
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004C3E RID: 19518
		private static readonly IntPtr NativeMethodInfoPtr_get_headLightsOn_Public_get_Boolean_0;

		// Token: 0x04004C3F RID: 19519
		private static readonly IntPtr NativeMethodInfoPtr_set_headLightsOn_Public_set_Void_Boolean_0;

		// Token: 0x04004C40 RID: 19520
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04004C41 RID: 19521
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1;

		// Token: 0x04004C42 RID: 19522
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1;

		// Token: 0x04004C43 RID: 19523
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_1;

		// Token: 0x04004C44 RID: 19524
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004C45 RID: 19525
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004C46 RID: 19526
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004C47 RID: 19527
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004C48 RID: 19528
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_set_headLightsOn_1140765316_Private_Void_Boolean_0;

		// Token: 0x04004C49 RID: 19529
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___set_headLightsOn_1140765316_Public_Void_Boolean_0;

		// Token: 0x04004C4A RID: 19530
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_set_headLightsOn_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004C4B RID: 19531
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__headLightsOn_k__BackingField_Public_get_Boolean_0;

		// Token: 0x04004C4C RID: 19532
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__headLightsOn_k__BackingField_Public_set_Void_Boolean_Boolean_0;

		// Token: 0x04004C4D RID: 19533
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Vehicles_VehicleLights_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04004C4E RID: 19534
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;
	}
}
