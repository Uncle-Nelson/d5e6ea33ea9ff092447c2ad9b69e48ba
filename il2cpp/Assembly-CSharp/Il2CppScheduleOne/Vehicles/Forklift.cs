using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020004DD RID: 1245
	public class Forklift : LandVehicle
	{
		// Token: 0x06006CCE RID: 27854 RVA: 0x001E2B08 File Offset: 0x001E0D08
		// Note: this type is marked as 'beforefieldinit'.
		static Forklift()
		{
			Il2CppClassPointerStore<Forklift>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "Forklift");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Forklift>.NativeClassPtr);
			Forklift.NativeFieldInfoPtr_steeringWheel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forklift>.NativeClassPtr, "steeringWheel");
			Forklift.NativeFieldInfoPtr_forkRb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forklift>.NativeClassPtr, "forkRb");
			Forklift.NativeFieldInfoPtr_joint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forklift>.NativeClassPtr, "joint");
			Forklift.NativeFieldInfoPtr_steeringWheelAngleMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forklift>.NativeClassPtr, "steeringWheelAngleMultiplier");
			Forklift.NativeFieldInfoPtr_lift_MinY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forklift>.NativeClassPtr, "lift_MinY");
			Forklift.NativeFieldInfoPtr_lift_MaxY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forklift>.NativeClassPtr, "lift_MaxY");
			Forklift.NativeFieldInfoPtr_liftMoveRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forklift>.NativeClassPtr, "liftMoveRate");
			Forklift.NativeFieldInfoPtr__targetForkHeight_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forklift>.NativeClassPtr, "<targetForkHeight>k__BackingField");
			Forklift.NativeFieldInfoPtr_lastFrameTargetForkHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forklift>.NativeClassPtr, "lastFrameTargetForkHeight");
			Forklift.NativeFieldInfoPtr__actualForkHeight_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forklift>.NativeClassPtr, "<actualForkHeight>k__BackingField");
			Forklift.NativeFieldInfoPtr_syncVar____targetForkHeight_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forklift>.NativeClassPtr, "syncVar___<targetForkHeight>k__BackingField");
			Forklift.NativeFieldInfoPtr_syncVar____actualForkHeight_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forklift>.NativeClassPtr, "syncVar___<actualForkHeight>k__BackingField");
			Forklift.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forklift>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Vehicles.ForkliftAssembly-CSharp.dll_Excuted");
			Forklift.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Forklift>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Vehicles.ForkliftAssembly-CSharp.dll_Excuted");
			Forklift.NativeMethodInfoPtr_get_targetForkHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677051);
			Forklift.NativeMethodInfoPtr_set_targetForkHeight_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677052);
			Forklift.NativeMethodInfoPtr_get_actualForkHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677053);
			Forklift.NativeMethodInfoPtr_set_actualForkHeight_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677054);
			Forklift.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677055);
			Forklift.NativeMethodInfoPtr_Update_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677056);
			Forklift.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677057);
			Forklift.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677058);
			Forklift.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677059);
			Forklift.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677060);
			Forklift.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677061);
			Forklift.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677062);
			Forklift.NativeMethodInfoPtr_RpcWriter___Server_set_targetForkHeight_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677063);
			Forklift.NativeMethodInfoPtr_RpcLogic___set_targetForkHeight_431000436_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677064);
			Forklift.NativeMethodInfoPtr_RpcReader___Server_set_targetForkHeight_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677065);
			Forklift.NativeMethodInfoPtr_RpcWriter___Server_set_actualForkHeight_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677066);
			Forklift.NativeMethodInfoPtr_RpcLogic___set_actualForkHeight_431000436_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677067);
			Forklift.NativeMethodInfoPtr_RpcReader___Server_set_actualForkHeight_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677068);
			Forklift.NativeMethodInfoPtr_sync___get_value__targetForkHeight_k__BackingField_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677069);
			Forklift.NativeMethodInfoPtr_sync___set_value__targetForkHeight_k__BackingField_Public_set_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677070);
			Forklift.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Vehicles_Forklift_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677071);
			Forklift.NativeMethodInfoPtr_sync___get_value__actualForkHeight_k__BackingField_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677072);
			Forklift.NativeMethodInfoPtr_sync___set_value__actualForkHeight_k__BackingField_Public_set_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677073);
			Forklift.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Forklift>.NativeClassPtr, 100677074);
		}

		// Token: 0x170020C0 RID: 8384
		// (get) Token: 0x06006CCF RID: 27855 RVA: 0x001E2E30 File Offset: 0x001E1030
		// (set) Token: 0x06006CD0 RID: 27856 RVA: 0x001E2E6C File Offset: 0x001E106C
		public unsafe float targetForkHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Forklift.NativeMethodInfoPtr_get_targetForkHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 217556, RefRangeEnd = 217558, XrefRangeStart = 217523, XrefRangeEnd = 217556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Forklift.NativeMethodInfoPtr_set_targetForkHeight_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170020C1 RID: 8385
		// (get) Token: 0x06006CD1 RID: 27857 RVA: 0x001E2EAC File Offset: 0x001E10AC
		// (set) Token: 0x06006CD2 RID: 27858 RVA: 0x001E2EE8 File Offset: 0x001E10E8
		public unsafe float actualForkHeight
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 217558, RefRangeEnd = 217563, XrefRangeStart = 217558, XrefRangeEnd = 217558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Forklift.NativeMethodInfoPtr_get_actualForkHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 217596, RefRangeEnd = 217597, XrefRangeStart = 217563, XrefRangeEnd = 217596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Forklift.NativeMethodInfoPtr_set_actualForkHeight_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006CD3 RID: 27859 RVA: 0x001E2F28 File Offset: 0x001E1128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217597, XrefRangeEnd = 217609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Forklift.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CD4 RID: 27860 RVA: 0x001E2F64 File Offset: 0x001E1164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217609, XrefRangeEnd = 217616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Forklift.NativeMethodInfoPtr_Update_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CD5 RID: 27861 RVA: 0x001E2FA0 File Offset: 0x001E11A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217616, XrefRangeEnd = 217632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Forklift.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CD6 RID: 27862 RVA: 0x001E2FDC File Offset: 0x001E11DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217632, XrefRangeEnd = 217646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Forklift.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CD7 RID: 27863 RVA: 0x001E3018 File Offset: 0x001E1218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217646, XrefRangeEnd = 217647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Forklift() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Forklift>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Forklift.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CD8 RID: 27864 RVA: 0x001E3054 File Offset: 0x001E1254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217647, XrefRangeEnd = 217684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Forklift.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CD9 RID: 27865 RVA: 0x001E3090 File Offset: 0x001E1290
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Forklift.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CDA RID: 27866 RVA: 0x001E30CC File Offset: 0x001E12CC
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Forklift.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CDB RID: 27867 RVA: 0x001E3108 File Offset: 0x001E1308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217684, XrefRangeEnd = 217713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_set_targetForkHeight_431000436(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Forklift.NativeMethodInfoPtr_RpcWriter___Server_set_targetForkHeight_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CDC RID: 27868 RVA: 0x001E3148 File Offset: 0x001E1348
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 217720, RefRangeEnd = 217722, XrefRangeStart = 217713, XrefRangeEnd = 217720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___set_targetForkHeight_431000436(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Forklift.NativeMethodInfoPtr_RpcLogic___set_targetForkHeight_431000436_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CDD RID: 27869 RVA: 0x001E3188 File Offset: 0x001E1388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217722, XrefRangeEnd = 217727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_set_targetForkHeight_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Forklift.NativeMethodInfoPtr_RpcReader___Server_set_targetForkHeight_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CDE RID: 27870 RVA: 0x001E31EC File Offset: 0x001E13EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217727, XrefRangeEnd = 217756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_set_actualForkHeight_431000436(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Forklift.NativeMethodInfoPtr_RpcWriter___Server_set_actualForkHeight_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CDF RID: 27871 RVA: 0x001E322C File Offset: 0x001E142C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 217763, RefRangeEnd = 217765, XrefRangeStart = 217756, XrefRangeEnd = 217763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___set_actualForkHeight_431000436(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Forklift.NativeMethodInfoPtr_RpcLogic___set_actualForkHeight_431000436_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CE0 RID: 27872 RVA: 0x001E326C File Offset: 0x001E146C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217765, XrefRangeEnd = 217770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_set_actualForkHeight_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Forklift.NativeMethodInfoPtr_RpcReader___Server_set_actualForkHeight_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170020C2 RID: 8386
		// (get) Token: 0x06006CE1 RID: 27873 RVA: 0x001E32D0 File Offset: 0x001E14D0
		// (set) Token: 0x06006CE2 RID: 27874 RVA: 0x001E330C File Offset: 0x001E150C
		public unsafe float SyncAccessor_<targetForkHeight>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Forklift.NativeMethodInfoPtr_sync___get_value__targetForkHeight_k__BackingField_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 217778, RefRangeEnd = 217779, XrefRangeStart = 217770, XrefRangeEnd = 217778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Forklift.NativeMethodInfoPtr_sync___set_value__targetForkHeight_k__BackingField_Public_set_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006CE3 RID: 27875 RVA: 0x001E3358 File Offset: 0x001E1558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217779, XrefRangeEnd = 217783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_Vehicles_Forklift(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Forklift.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Vehicles_Forklift_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170020C3 RID: 8387
		// (get) Token: 0x06006CE4 RID: 27876 RVA: 0x001E33CC File Offset: 0x001E15CC
		// (set) Token: 0x06006CE5 RID: 27877 RVA: 0x001E3408 File Offset: 0x001E1608
		public unsafe float SyncAccessor_<actualForkHeight>k__BackingField
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 217558, RefRangeEnd = 217563, XrefRangeStart = 217558, XrefRangeEnd = 217563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Forklift.NativeMethodInfoPtr_sync___get_value__actualForkHeight_k__BackingField_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217783, XrefRangeEnd = 217791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Forklift.NativeMethodInfoPtr_sync___set_value__actualForkHeight_k__BackingField_Public_set_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006CE6 RID: 27878 RVA: 0x001E3454 File Offset: 0x001E1654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217791, XrefRangeEnd = 217802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Forklift.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CE7 RID: 27879 RVA: 0x00033821 File Offset: 0x00031A21
		public Forklift(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170020B2 RID: 8370
		// (get) Token: 0x06006CE8 RID: 27880 RVA: 0x001E3490 File Offset: 0x001E1690
		// (set) Token: 0x06006CE9 RID: 27881 RVA: 0x0003382A File Offset: 0x00031A2A
		public unsafe Transform steeringWheel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_steeringWheel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_steeringWheel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020B3 RID: 8371
		// (get) Token: 0x06006CEA RID: 27882 RVA: 0x001E34C0 File Offset: 0x001E16C0
		// (set) Token: 0x06006CEB RID: 27883 RVA: 0x00033849 File Offset: 0x00031A49
		public unsafe Rigidbody forkRb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_forkRb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_forkRb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020B4 RID: 8372
		// (get) Token: 0x06006CEC RID: 27884 RVA: 0x001E34F0 File Offset: 0x001E16F0
		// (set) Token: 0x06006CED RID: 27885 RVA: 0x00033868 File Offset: 0x00031A68
		public unsafe ConfigurableJoint joint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_joint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurableJoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_joint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020B5 RID: 8373
		// (get) Token: 0x06006CEE RID: 27886 RVA: 0x001E3520 File Offset: 0x001E1720
		// (set) Token: 0x06006CEF RID: 27887 RVA: 0x00033887 File Offset: 0x00031A87
		public unsafe float steeringWheelAngleMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_steeringWheelAngleMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_steeringWheelAngleMultiplier)) = value;
			}
		}

		// Token: 0x170020B6 RID: 8374
		// (get) Token: 0x06006CF0 RID: 27888 RVA: 0x001E3548 File Offset: 0x001E1748
		// (set) Token: 0x06006CF1 RID: 27889 RVA: 0x000338A2 File Offset: 0x00031AA2
		public unsafe float lift_MinY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_lift_MinY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_lift_MinY)) = value;
			}
		}

		// Token: 0x170020B7 RID: 8375
		// (get) Token: 0x06006CF2 RID: 27890 RVA: 0x001E3570 File Offset: 0x001E1770
		// (set) Token: 0x06006CF3 RID: 27891 RVA: 0x000338BD File Offset: 0x00031ABD
		public unsafe float lift_MaxY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_lift_MaxY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_lift_MaxY)) = value;
			}
		}

		// Token: 0x170020B8 RID: 8376
		// (get) Token: 0x06006CF4 RID: 27892 RVA: 0x001E3598 File Offset: 0x001E1798
		// (set) Token: 0x06006CF5 RID: 27893 RVA: 0x000338D8 File Offset: 0x00031AD8
		public unsafe float liftMoveRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_liftMoveRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_liftMoveRate)) = value;
			}
		}

		// Token: 0x170020B9 RID: 8377
		// (get) Token: 0x06006CF6 RID: 27894 RVA: 0x001E35C0 File Offset: 0x001E17C0
		// (set) Token: 0x06006CF7 RID: 27895 RVA: 0x000338F3 File Offset: 0x00031AF3
		public unsafe float _targetForkHeight_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr__targetForkHeight_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr__targetForkHeight_k__BackingField)) = value;
			}
		}

		// Token: 0x170020BA RID: 8378
		// (get) Token: 0x06006CF8 RID: 27896 RVA: 0x001E35E8 File Offset: 0x001E17E8
		// (set) Token: 0x06006CF9 RID: 27897 RVA: 0x0003390E File Offset: 0x00031B0E
		public unsafe float lastFrameTargetForkHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_lastFrameTargetForkHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_lastFrameTargetForkHeight)) = value;
			}
		}

		// Token: 0x170020BB RID: 8379
		// (get) Token: 0x06006CFA RID: 27898 RVA: 0x001E3610 File Offset: 0x001E1810
		// (set) Token: 0x06006CFB RID: 27899 RVA: 0x00033929 File Offset: 0x00031B29
		public unsafe float _actualForkHeight_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr__actualForkHeight_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr__actualForkHeight_k__BackingField)) = value;
			}
		}

		// Token: 0x170020BC RID: 8380
		// (get) Token: 0x06006CFC RID: 27900 RVA: 0x001E3638 File Offset: 0x001E1838
		// (set) Token: 0x06006CFD RID: 27901 RVA: 0x00033944 File Offset: 0x00031B44
		public unsafe SyncVar<float> syncVar____targetForkHeight_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_syncVar____targetForkHeight_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_syncVar____targetForkHeight_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020BD RID: 8381
		// (get) Token: 0x06006CFE RID: 27902 RVA: 0x001E3668 File Offset: 0x001E1868
		// (set) Token: 0x06006CFF RID: 27903 RVA: 0x00033963 File Offset: 0x00031B63
		public unsafe SyncVar<float> syncVar____actualForkHeight_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_syncVar____actualForkHeight_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_syncVar____actualForkHeight_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020BE RID: 8382
		// (get) Token: 0x06006D00 RID: 27904 RVA: 0x001E3698 File Offset: 0x001E1898
		// (set) Token: 0x06006D01 RID: 27905 RVA: 0x00033982 File Offset: 0x00031B82
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170020BF RID: 8383
		// (get) Token: 0x06006D02 RID: 27906 RVA: 0x001E36C0 File Offset: 0x001E18C0
		// (set) Token: 0x06006D03 RID: 27907 RVA: 0x0003399D File Offset: 0x00031B9D
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Forklift.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004A5F RID: 19039
		private static readonly IntPtr NativeFieldInfoPtr_steeringWheel;

		// Token: 0x04004A60 RID: 19040
		private static readonly IntPtr NativeFieldInfoPtr_forkRb;

		// Token: 0x04004A61 RID: 19041
		private static readonly IntPtr NativeFieldInfoPtr_joint;

		// Token: 0x04004A62 RID: 19042
		private static readonly IntPtr NativeFieldInfoPtr_steeringWheelAngleMultiplier;

		// Token: 0x04004A63 RID: 19043
		private static readonly IntPtr NativeFieldInfoPtr_lift_MinY;

		// Token: 0x04004A64 RID: 19044
		private static readonly IntPtr NativeFieldInfoPtr_lift_MaxY;

		// Token: 0x04004A65 RID: 19045
		private static readonly IntPtr NativeFieldInfoPtr_liftMoveRate;

		// Token: 0x04004A66 RID: 19046
		private static readonly IntPtr NativeFieldInfoPtr__targetForkHeight_k__BackingField;

		// Token: 0x04004A67 RID: 19047
		private static readonly IntPtr NativeFieldInfoPtr_lastFrameTargetForkHeight;

		// Token: 0x04004A68 RID: 19048
		private static readonly IntPtr NativeFieldInfoPtr__actualForkHeight_k__BackingField;

		// Token: 0x04004A69 RID: 19049
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____targetForkHeight_k__BackingField;

		// Token: 0x04004A6A RID: 19050
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____actualForkHeight_k__BackingField;

		// Token: 0x04004A6B RID: 19051
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004A6C RID: 19052
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004A6D RID: 19053
		private static readonly IntPtr NativeMethodInfoPtr_get_targetForkHeight_Public_get_Single_0;

		// Token: 0x04004A6E RID: 19054
		private static readonly IntPtr NativeMethodInfoPtr_set_targetForkHeight_Protected_set_Void_Single_0;

		// Token: 0x04004A6F RID: 19055
		private static readonly IntPtr NativeMethodInfoPtr_get_actualForkHeight_Public_get_Single_0;

		// Token: 0x04004A70 RID: 19056
		private static readonly IntPtr NativeMethodInfoPtr_set_actualForkHeight_Protected_set_Void_Single_0;

		// Token: 0x04004A71 RID: 19057
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04004A72 RID: 19058
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_1;

		// Token: 0x04004A73 RID: 19059
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_1;

		// Token: 0x04004A74 RID: 19060
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04004A75 RID: 19061
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004A76 RID: 19062
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004A77 RID: 19063
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004A78 RID: 19064
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004A79 RID: 19065
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_set_targetForkHeight_431000436_Private_Void_Single_0;

		// Token: 0x04004A7A RID: 19066
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___set_targetForkHeight_431000436_Protected_Void_Single_0;

		// Token: 0x04004A7B RID: 19067
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_set_targetForkHeight_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004A7C RID: 19068
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_set_actualForkHeight_431000436_Private_Void_Single_0;

		// Token: 0x04004A7D RID: 19069
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___set_actualForkHeight_431000436_Protected_Void_Single_0;

		// Token: 0x04004A7E RID: 19070
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_set_actualForkHeight_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004A7F RID: 19071
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__targetForkHeight_k__BackingField_Public_get_Single_0;

		// Token: 0x04004A80 RID: 19072
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__targetForkHeight_k__BackingField_Public_set_Void_Single_Boolean_0;

		// Token: 0x04004A81 RID: 19073
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Vehicles_Forklift_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04004A82 RID: 19074
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__actualForkHeight_k__BackingField_Public_get_Single_0;

		// Token: 0x04004A83 RID: 19075
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__actualForkHeight_k__BackingField_Public_set_Void_Single_Boolean_0;

		// Token: 0x04004A84 RID: 19076
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;
	}
}
