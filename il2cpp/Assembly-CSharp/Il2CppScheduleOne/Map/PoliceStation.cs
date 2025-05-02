using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Police;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x02000788 RID: 1928
	public class PoliceStation : NPCEnterableBuilding
	{
		// Token: 0x0600B680 RID: 46720 RVA: 0x002D5068 File Offset: 0x002D3268
		// Note: this type is marked as 'beforefieldinit'.
		static PoliceStation()
		{
			Il2CppClassPointerStore<PoliceStation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "PoliceStation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr);
			PoliceStation.NativeFieldInfoPtr_PoliceStations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, "PoliceStations");
			PoliceStation.NativeFieldInfoPtr_VehicleLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, "VehicleLimit");
			PoliceStation.NativeFieldInfoPtr_SpawnPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, "SpawnPoint");
			PoliceStation.NativeFieldInfoPtr_VehicleSpawnPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, "VehicleSpawnPoints");
			PoliceStation.NativeFieldInfoPtr_PossessedVehicleSpawnPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, "PossessedVehicleSpawnPoints");
			PoliceStation.NativeFieldInfoPtr_PoliceVehiclePrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, "PoliceVehiclePrefabs");
			PoliceStation.NativeFieldInfoPtr_OfficerPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, "OfficerPool");
			PoliceStation.NativeFieldInfoPtr__TimeSinceLastDispatch_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, "<TimeSinceLastDispatch>k__BackingField");
			PoliceStation.NativeFieldInfoPtr_deployedVehicles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, "deployedVehicles");
			PoliceStation.NativeMethodInfoPtr_get_TimeSinceLastDispatch_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100685726);
			PoliceStation.NativeMethodInfoPtr_set_TimeSinceLastDispatch_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100685727);
			PoliceStation.NativeMethodInfoPtr_get_deployedVehicleCount_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100685728);
			PoliceStation.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100685729);
			PoliceStation.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100685730);
			PoliceStation.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100685731);
			PoliceStation.NativeMethodInfoPtr_CleanVehicleList_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100685732);
			PoliceStation.NativeMethodInfoPtr_Dispatch_Public_Void_Int32_Player_EDispatchType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100685733);
			PoliceStation.NativeMethodInfoPtr_PullOfficer_Public_PoliceOfficer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100685734);
			PoliceStation.NativeMethodInfoPtr_CreateVehicle_Public_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100685735);
			PoliceStation.NativeMethodInfoPtr_NPCEnteredBuilding_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100685736);
			PoliceStation.NativeMethodInfoPtr_NPCExitedBuilding_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100685737);
			PoliceStation.NativeMethodInfoPtr_GetClosestPoliceStation_Public_Static_PoliceStation_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100685738);
			PoliceStation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100685739);
			PoliceStation.NativeMethodInfoPtr_Method_Internal_Static_Boolean_Transform_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100685741);
		}

		// Token: 0x170038A0 RID: 14496
		// (get) Token: 0x0600B681 RID: 46721 RVA: 0x002D5278 File Offset: 0x002D3478
		// (set) Token: 0x0600B682 RID: 46722 RVA: 0x002D52B4 File Offset: 0x002D34B4
		public unsafe float TimeSinceLastDispatch
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr_get_TimeSinceLastDispatch_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr_set_TimeSinceLastDispatch_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170038A1 RID: 14497
		// (get) Token: 0x0600B683 RID: 46723 RVA: 0x002D52F4 File Offset: 0x002D34F4
		public unsafe int deployedVehicleCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311492, XrefRangeEnd = 311513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr_get_deployedVehicleCount_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600B684 RID: 46724 RVA: 0x002D5330 File Offset: 0x002D3530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311513, XrefRangeEnd = 311532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceStation.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B685 RID: 46725 RVA: 0x002D536C File Offset: 0x002D356C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311532, XrefRangeEnd = 311545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B686 RID: 46726 RVA: 0x002D53A0 File Offset: 0x002D35A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311545, XrefRangeEnd = 311546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B687 RID: 46727 RVA: 0x002D53D4 File Offset: 0x002D35D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311546, XrefRangeEnd = 311558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanVehicleList()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr_CleanVehicleList_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B688 RID: 46728 RVA: 0x002D5408 File Offset: 0x002D3608
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 311624, RefRangeEnd = 311626, XrefRangeStart = 311558, XrefRangeEnd = 311624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispatch(int requestedOfficerCount, Player targetPlayer, PoliceStation.EDispatchType type = PoliceStation.EDispatchType.Auto, bool beginAsSighted = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref requestedOfficerCount;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetPlayer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref beginAsSighted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr_Dispatch_Public_Void_Int32_Player_EDispatchType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B689 RID: 46729 RVA: 0x002D5474 File Offset: 0x002D3674
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 311635, RefRangeEnd = 311640, XrefRangeStart = 311626, XrefRangeEnd = 311635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PoliceOfficer PullOfficer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr_PullOfficer_Public_PoliceOfficer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PoliceOfficer>(intPtr3) : null;
		}

		// Token: 0x0600B68A RID: 46730 RVA: 0x002D54B4 File Offset: 0x002D36B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 311672, RefRangeEnd = 311675, XrefRangeStart = 311640, XrefRangeEnd = 311672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LandVehicle CreateVehicle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr_CreateVehicle_Public_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr3) : null;
		}

		// Token: 0x0600B68B RID: 46731 RVA: 0x002D54F4 File Offset: 0x002D36F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311675, XrefRangeEnd = 311686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NPCEnteredBuilding(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceStation.NativeMethodInfoPtr_NPCEnteredBuilding_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B68C RID: 46732 RVA: 0x002D5544 File Offset: 0x002D3744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311686, XrefRangeEnd = 311692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NPCExitedBuilding(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceStation.NativeMethodInfoPtr_NPCExitedBuilding_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B68D RID: 46733 RVA: 0x002D5594 File Offset: 0x002D3794
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 311700, RefRangeEnd = 311711, XrefRangeStart = 311692, XrefRangeEnd = 311700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PoliceStation GetClosestPoliceStation(Vector3 point)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr_GetClosestPoliceStation_Public_Static_PoliceStation_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PoliceStation>(intPtr3) : null;
		}

		// Token: 0x0600B68E RID: 46734 RVA: 0x002D55D4 File Offset: 0x002D37D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311711, XrefRangeEnd = 311726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PoliceStation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B68F RID: 46735 RVA: 0x002D5610 File Offset: 0x002D3810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311726, XrefRangeEnd = 311742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Method_Internal_Static_Boolean_Transform_PDM_0(Transform spawnPoint)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spawnPoint);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr_Method_Internal_Static_Boolean_Transform_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B690 RID: 46736 RVA: 0x000599E3 File Offset: 0x00057BE3
		public PoliceStation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003897 RID: 14487
		// (get) Token: 0x0600B691 RID: 46737 RVA: 0x002D5654 File Offset: 0x002D3854
		// (set) Token: 0x0600B692 RID: 46738 RVA: 0x000599EC File Offset: 0x00057BEC
		public unsafe static List<PoliceStation> PoliceStations
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PoliceStation.NativeFieldInfoPtr_PoliceStations, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PoliceStation>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PoliceStation.NativeFieldInfoPtr_PoliceStations, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003898 RID: 14488
		// (get) Token: 0x0600B693 RID: 46739 RVA: 0x002D567C File Offset: 0x002D387C
		// (set) Token: 0x0600B694 RID: 46740 RVA: 0x000599FE File Offset: 0x00057BFE
		public unsafe int VehicleLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_VehicleLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_VehicleLimit)) = value;
			}
		}

		// Token: 0x17003899 RID: 14489
		// (get) Token: 0x0600B695 RID: 46741 RVA: 0x002D56A4 File Offset: 0x002D38A4
		// (set) Token: 0x0600B696 RID: 46742 RVA: 0x00059A19 File Offset: 0x00057C19
		public unsafe Transform SpawnPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_SpawnPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_SpawnPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700389A RID: 14490
		// (get) Token: 0x0600B697 RID: 46743 RVA: 0x002D56D4 File Offset: 0x002D38D4
		// (set) Token: 0x0600B698 RID: 46744 RVA: 0x00059A38 File Offset: 0x00057C38
		public unsafe Il2CppReferenceArray<Transform> VehicleSpawnPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_VehicleSpawnPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_VehicleSpawnPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700389B RID: 14491
		// (get) Token: 0x0600B699 RID: 46745 RVA: 0x002D5704 File Offset: 0x002D3904
		// (set) Token: 0x0600B69A RID: 46746 RVA: 0x00059A57 File Offset: 0x00057C57
		public unsafe Il2CppReferenceArray<Transform> PossessedVehicleSpawnPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_PossessedVehicleSpawnPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_PossessedVehicleSpawnPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700389C RID: 14492
		// (get) Token: 0x0600B69B RID: 46747 RVA: 0x002D5734 File Offset: 0x002D3934
		// (set) Token: 0x0600B69C RID: 46748 RVA: 0x00059A76 File Offset: 0x00057C76
		public unsafe Il2CppReferenceArray<LandVehicle> PoliceVehiclePrefabs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_PoliceVehiclePrefabs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LandVehicle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_PoliceVehiclePrefabs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700389D RID: 14493
		// (get) Token: 0x0600B69D RID: 46749 RVA: 0x002D5764 File Offset: 0x002D3964
		// (set) Token: 0x0600B69E RID: 46750 RVA: 0x00059A95 File Offset: 0x00057C95
		public unsafe List<PoliceOfficer> OfficerPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_OfficerPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PoliceOfficer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_OfficerPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700389E RID: 14494
		// (get) Token: 0x0600B69F RID: 46751 RVA: 0x002D5794 File Offset: 0x002D3994
		// (set) Token: 0x0600B6A0 RID: 46752 RVA: 0x00059AB4 File Offset: 0x00057CB4
		public unsafe float _TimeSinceLastDispatch_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr__TimeSinceLastDispatch_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr__TimeSinceLastDispatch_k__BackingField)) = value;
			}
		}

		// Token: 0x1700389F RID: 14495
		// (get) Token: 0x0600B6A1 RID: 46753 RVA: 0x002D57BC File Offset: 0x002D39BC
		// (set) Token: 0x0600B6A2 RID: 46754 RVA: 0x00059ACF File Offset: 0x00057CCF
		public unsafe List<LandVehicle> deployedVehicles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_deployedVehicles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LandVehicle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_deployedVehicles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007AEF RID: 31471
		private static readonly IntPtr NativeFieldInfoPtr_PoliceStations;

		// Token: 0x04007AF0 RID: 31472
		private static readonly IntPtr NativeFieldInfoPtr_VehicleLimit;

		// Token: 0x04007AF1 RID: 31473
		private static readonly IntPtr NativeFieldInfoPtr_SpawnPoint;

		// Token: 0x04007AF2 RID: 31474
		private static readonly IntPtr NativeFieldInfoPtr_VehicleSpawnPoints;

		// Token: 0x04007AF3 RID: 31475
		private static readonly IntPtr NativeFieldInfoPtr_PossessedVehicleSpawnPoints;

		// Token: 0x04007AF4 RID: 31476
		private static readonly IntPtr NativeFieldInfoPtr_PoliceVehiclePrefabs;

		// Token: 0x04007AF5 RID: 31477
		private static readonly IntPtr NativeFieldInfoPtr_OfficerPool;

		// Token: 0x04007AF6 RID: 31478
		private static readonly IntPtr NativeFieldInfoPtr__TimeSinceLastDispatch_k__BackingField;

		// Token: 0x04007AF7 RID: 31479
		private static readonly IntPtr NativeFieldInfoPtr_deployedVehicles;

		// Token: 0x04007AF8 RID: 31480
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSinceLastDispatch_Public_get_Single_0;

		// Token: 0x04007AF9 RID: 31481
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeSinceLastDispatch_Private_set_Void_Single_0;

		// Token: 0x04007AFA RID: 31482
		private static readonly IntPtr NativeMethodInfoPtr_get_deployedVehicleCount_Private_get_Int32_0;

		// Token: 0x04007AFB RID: 31483
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04007AFC RID: 31484
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04007AFD RID: 31485
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04007AFE RID: 31486
		private static readonly IntPtr NativeMethodInfoPtr_CleanVehicleList_Private_Void_0;

		// Token: 0x04007AFF RID: 31487
		private static readonly IntPtr NativeMethodInfoPtr_Dispatch_Public_Void_Int32_Player_EDispatchType_Boolean_0;

		// Token: 0x04007B00 RID: 31488
		private static readonly IntPtr NativeMethodInfoPtr_PullOfficer_Public_PoliceOfficer_0;

		// Token: 0x04007B01 RID: 31489
		private static readonly IntPtr NativeMethodInfoPtr_CreateVehicle_Public_LandVehicle_0;

		// Token: 0x04007B02 RID: 31490
		private static readonly IntPtr NativeMethodInfoPtr_NPCEnteredBuilding_Public_Virtual_Void_NPC_0;

		// Token: 0x04007B03 RID: 31491
		private static readonly IntPtr NativeMethodInfoPtr_NPCExitedBuilding_Public_Virtual_Void_NPC_0;

		// Token: 0x04007B04 RID: 31492
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestPoliceStation_Public_Static_PoliceStation_Vector3_0;

		// Token: 0x04007B05 RID: 31493
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007B06 RID: 31494
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Boolean_Transform_PDM_0;

		// Token: 0x02000C07 RID: 3079
		[OriginalName("Assembly-CSharp.dll", "", "EDispatchType")]
		public enum EDispatchType
		{
			// Token: 0x0400962C RID: 38444
			Auto,
			// Token: 0x0400962D RID: 38445
			UseVehicle,
			// Token: 0x0400962E RID: 38446
			OnFoot
		}

		// Token: 0x02000C08 RID: 3080
		[ObfuscatedName("ScheduleOne.Map.PoliceStation+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E03B RID: 57403 RVA: 0x0034CD28 File Offset: 0x0034AF28
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PoliceStation.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoliceStation.__c>.NativeClassPtr);
				PoliceStation.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceStation.__c>.NativeClassPtr, "<>9");
				PoliceStation.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceStation.__c>.NativeClassPtr, "<>9__14_0");
				PoliceStation.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation.__c>.NativeClassPtr, 100685743);
				PoliceStation.__c.NativeMethodInfoPtr__get_deployedVehicleCount_b__14_0_Internal_Boolean_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation.__c>.NativeClassPtr, 100685744);
			}

			// Token: 0x0600E03C RID: 57404 RVA: 0x0034CDA4 File Offset: 0x0034AFA4
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoliceStation.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E03D RID: 57405 RVA: 0x0034CDE0 File Offset: 0x0034AFE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311488, XrefRangeEnd = 311492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_deployedVehicleCount_b__14_0(LandVehicle v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.__c.NativeMethodInfoPtr__get_deployedVehicleCount_b__14_0_Internal_Boolean_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E03E RID: 57406 RVA: 0x0006D526 File Offset: 0x0006B726
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700457B RID: 17787
			// (get) Token: 0x0600E03F RID: 57407 RVA: 0x0034CE30 File Offset: 0x0034B030
			// (set) Token: 0x0600E040 RID: 57408 RVA: 0x0006D52F File Offset: 0x0006B72F
			public unsafe static PoliceStation.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PoliceStation.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceStation.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PoliceStation.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700457C RID: 17788
			// (get) Token: 0x0600E041 RID: 57409 RVA: 0x0034CE58 File Offset: 0x0034B058
			// (set) Token: 0x0600E042 RID: 57410 RVA: 0x0006D541 File Offset: 0x0006B741
			public unsafe static Func<LandVehicle, bool> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PoliceStation.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<LandVehicle, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PoliceStation.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400962F RID: 38447
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009630 RID: 38448
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x04009631 RID: 38449
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009632 RID: 38450
			private static readonly IntPtr NativeMethodInfoPtr__get_deployedVehicleCount_b__14_0_Internal_Boolean_LandVehicle_0;
		}
	}
}
