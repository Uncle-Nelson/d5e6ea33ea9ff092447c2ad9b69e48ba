using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Property.Utilities.Power;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.ConstructableScripts
{
	// Token: 0x020005CC RID: 1484
	public class Constructable_GridBased : Constructable
	{
		// Token: 0x060082A4 RID: 33444 RVA: 0x0022C190 File Offset: 0x0022A390
		// Note: this type is marked as 'beforefieldinit'.
		static Constructable_GridBased()
		{
			Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ConstructableScripts", "Constructable_GridBased");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr);
			Constructable_GridBased.NativeFieldInfoPtr_buildPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "buildPoint");
			Constructable_GridBased.NativeFieldInfoPtr_CoordinateFootprintTilePairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "CoordinateFootprintTilePairs");
			Constructable_GridBased.NativeFieldInfoPtr_ContentContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "ContentContainer");
			Constructable_GridBased.NativeFieldInfoPtr_Grids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "Grids");
			Constructable_GridBased.NativeFieldInfoPtr_roofObjectsForVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "roofObjectsForVisibility");
			Constructable_GridBased.NativeFieldInfoPtr_AlwaysPowered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "AlwaysPowered");
			Constructable_GridBased.NativeFieldInfoPtr_powerNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "powerNode");
			Constructable_GridBased.NativeFieldInfoPtr_isGhost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "isGhost");
			Constructable_GridBased.NativeFieldInfoPtr_dataChangedThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "dataChangedThisFrame");
			Constructable_GridBased.NativeFieldInfoPtr__OwnerGrid_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "<OwnerGrid>k__BackingField");
			Constructable_GridBased.NativeFieldInfoPtr_OwnerGridGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "OwnerGridGUID");
			Constructable_GridBased.NativeFieldInfoPtr_OriginCoordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "OriginCoordinate");
			Constructable_GridBased.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "Rotation");
			Constructable_GridBased.NativeFieldInfoPtr_coordinatePairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "coordinatePairs");
			Constructable_GridBased.NativeFieldInfoPtr_originalRoofLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "originalRoofLayers");
			Constructable_GridBased.NativeFieldInfoPtr_roofVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "roofVisible");
			Constructable_GridBased.NativeFieldInfoPtr_syncVar___OwnerGridGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "syncVar___OwnerGridGUID");
			Constructable_GridBased.NativeFieldInfoPtr_syncVar___OriginCoordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "syncVar___OriginCoordinate");
			Constructable_GridBased.NativeFieldInfoPtr_syncVar___Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "syncVar___Rotation");
			Constructable_GridBased.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ConstructableScripts.Constructable_GridBasedAssembly-CSharp.dll_Excuted");
			Constructable_GridBased.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ConstructableScripts.Constructable_GridBasedAssembly-CSharp.dll_Excuted");
			Constructable_GridBased.NativeMethodInfoPtr_get_OriginFootprint_Public_get_FootprintTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679634);
			Constructable_GridBased.NativeMethodInfoPtr_get_FootprintX_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679635);
			Constructable_GridBased.NativeMethodInfoPtr_get_FootprintY_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679636);
			Constructable_GridBased.NativeMethodInfoPtr_get_hasWaterSupply_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679637);
			Constructable_GridBased.NativeMethodInfoPtr_get_PowerNode_Public_get_PowerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679638);
			Constructable_GridBased.NativeMethodInfoPtr_get_isPowered_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679639);
			Constructable_GridBased.NativeMethodInfoPtr_get_OwnerGrid_Public_get_Grid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679640);
			Constructable_GridBased.NativeMethodInfoPtr_set_OwnerGrid_Protected_set_Void_Grid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679641);
			Constructable_GridBased.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679642);
			Constructable_GridBased.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679643);
			Constructable_GridBased.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679644);
			Constructable_GridBased.NativeMethodInfoPtr_OnStartNetwork_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679645);
			Constructable_GridBased.NativeMethodInfoPtr_InitializeConstructable_GridBased_Public_Virtual_New_Void_Grid_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679646);
			Constructable_GridBased.NativeMethodInfoPtr_ReceiveData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679647);
			Constructable_GridBased.NativeMethodInfoPtr_SetParent_Private_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679648);
			Constructable_GridBased.NativeMethodInfoPtr_SetData_Protected_Virtual_New_Void_Guid_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679649);
			Constructable_GridBased.NativeMethodInfoPtr_RepositionConstructable_Public_Virtual_New_Void_Guid_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679650);
			Constructable_GridBased.NativeMethodInfoPtr_RefreshTransform_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679651);
			Constructable_GridBased.NativeMethodInfoPtr_ClearPositionData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679652);
			Constructable_GridBased.NativeMethodInfoPtr_DestroyConstructable_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679653);
			Constructable_GridBased.NativeMethodInfoPtr_GenerateGridGUIDs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679654);
			Constructable_GridBased.NativeMethodInfoPtr_GetGridGUIDs_Private_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679655);
			Constructable_GridBased.NativeMethodInfoPtr_SetGridGUIDs_Protected_Void_NetworkConnection_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679656);
			Constructable_GridBased.NativeMethodInfoPtr_SetInvisible_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679657);
			Constructable_GridBased.NativeMethodInfoPtr_RestoreVisibility_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679658);
			Constructable_GridBased.NativeMethodInfoPtr_SetRoofVisible_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679659);
			Constructable_GridBased.NativeMethodInfoPtr_CalculateFootprintTileIntersections_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679660);
			Constructable_GridBased.NativeMethodInfoPtr_SetFootprintTileVisiblity_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679661);
			Constructable_GridBased.NativeMethodInfoPtr_GetFootprintTile_Public_FootprintTile_Coordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679662);
			Constructable_GridBased.NativeMethodInfoPtr_GetFootprintTiles_Public_List_1_FootprintTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679663);
			Constructable_GridBased.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679664);
			Constructable_GridBased.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679665);
			Constructable_GridBased.NativeMethodInfoPtr__ReceiveData_b__36_1_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679666);
			Constructable_GridBased.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679667);
			Constructable_GridBased.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679668);
			Constructable_GridBased.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679669);
			Constructable_GridBased.NativeMethodInfoPtr_RpcWriter___Server_SetData_810381718_Private_Void_Guid_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679670);
			Constructable_GridBased.NativeMethodInfoPtr_RpcLogic___SetData_810381718_Protected_Virtual_New_Void_Guid_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679671);
			Constructable_GridBased.NativeMethodInfoPtr_RpcReader___Server_SetData_810381718_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679672);
			Constructable_GridBased.NativeMethodInfoPtr_RpcWriter___Observers_SetGridGUIDs_2890081366_Private_Void_NetworkConnection_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679673);
			Constructable_GridBased.NativeMethodInfoPtr_RpcLogic___SetGridGUIDs_2890081366_Protected_Void_NetworkConnection_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679674);
			Constructable_GridBased.NativeMethodInfoPtr_RpcReader___Observers_SetGridGUIDs_2890081366_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679675);
			Constructable_GridBased.NativeMethodInfoPtr_RpcWriter___Target_SetGridGUIDs_2890081366_Private_Void_NetworkConnection_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679676);
			Constructable_GridBased.NativeMethodInfoPtr_RpcReader___Target_SetGridGUIDs_2890081366_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679677);
			Constructable_GridBased.NativeMethodInfoPtr_sync___get_value_OwnerGridGUID_Public_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679678);
			Constructable_GridBased.NativeMethodInfoPtr_sync___set_value_OwnerGridGUID_Public_set_Void_Guid_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679679);
			Constructable_GridBased.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_ConstructableScripts_Constructable_GridBased_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679680);
			Constructable_GridBased.NativeMethodInfoPtr_sync___get_value_OriginCoordinate_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679681);
			Constructable_GridBased.NativeMethodInfoPtr_sync___set_value_OriginCoordinate_Public_set_Void_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679682);
			Constructable_GridBased.NativeMethodInfoPtr_sync___get_value_Rotation_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679683);
			Constructable_GridBased.NativeMethodInfoPtr_sync___set_value_Rotation_Public_set_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679684);
			Constructable_GridBased.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679685);
		}

		// Token: 0x170027A3 RID: 10147
		// (get) Token: 0x060082A5 RID: 33445 RVA: 0x0022C774 File Offset: 0x0022A974
		public unsafe FootprintTile OriginFootprint
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 246560, RefRangeEnd = 246563, XrefRangeStart = 246557, XrefRangeEnd = 246560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_get_OriginFootprint_Public_get_FootprintTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr3) : null;
			}
		}

		// Token: 0x170027A4 RID: 10148
		// (get) Token: 0x060082A6 RID: 33446 RVA: 0x0022C7B4 File Offset: 0x0022A9B4
		public unsafe int FootprintX
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246563, XrefRangeEnd = 246567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_get_FootprintX_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170027A5 RID: 10149
		// (get) Token: 0x060082A7 RID: 33447 RVA: 0x0022C7F0 File Offset: 0x0022A9F0
		public unsafe int FootprintY
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246567, XrefRangeEnd = 246571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_get_FootprintY_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170027A6 RID: 10150
		// (get) Token: 0x060082A8 RID: 33448 RVA: 0x0022C82C File Offset: 0x0022AA2C
		public unsafe bool hasWaterSupply
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 30138, RefRangeEnd = 30158, XrefRangeStart = 30138, XrefRangeEnd = 30158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_get_hasWaterSupply_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170027A7 RID: 10151
		// (get) Token: 0x060082A9 RID: 33449 RVA: 0x0022C868 File Offset: 0x0022AA68
		public unsafe PowerNode PowerNode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_get_PowerNode_Public_get_PowerNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PowerNode>(intPtr3) : null;
			}
		}

		// Token: 0x170027A8 RID: 10152
		// (get) Token: 0x060082AA RID: 33450 RVA: 0x0022C8A8 File Offset: 0x0022AAA8
		public unsafe bool isPowered
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_get_isPowered_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170027A9 RID: 10153
		// (get) Token: 0x060082AB RID: 33451 RVA: 0x0022C8E4 File Offset: 0x0022AAE4
		// (set) Token: 0x060082AC RID: 33452 RVA: 0x0022C924 File Offset: 0x0022AB24
		public unsafe Grid OwnerGrid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_get_OwnerGrid_Public_get_Grid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Grid>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_set_OwnerGrid_Protected_set_Void_Grid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060082AD RID: 33453 RVA: 0x0022C968 File Offset: 0x0022AB68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 246572, RefRangeEnd = 246573, XrefRangeStart = 246571, XrefRangeEnd = 246572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082AE RID: 33454 RVA: 0x0022C9A4 File Offset: 0x0022ABA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246573, XrefRangeEnd = 246581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082AF RID: 33455 RVA: 0x0022C9E0 File Offset: 0x0022ABE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246581, XrefRangeEnd = 246596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082B0 RID: 33456 RVA: 0x0022CA30 File Offset: 0x0022AC30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246596, XrefRangeEnd = 246604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartNetwork()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_OnStartNetwork_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082B1 RID: 33457 RVA: 0x0022CA6C File Offset: 0x0022AC6C
		[CallerCount(0)]
		public unsafe virtual void InitializeConstructable_GridBased(Grid grid, Vector2 originCoordinate, float rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_InitializeConstructable_GridBased_Public_Virtual_New_Void_Grid_Vector2_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082B2 RID: 33458 RVA: 0x0022CAD8 File Offset: 0x0022ACD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 246653, RefRangeEnd = 246654, XrefRangeStart = 246604, XrefRangeEnd = 246653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_ReceiveData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082B3 RID: 33459 RVA: 0x0022CB0C File Offset: 0x0022AD0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246654, XrefRangeEnd = 246658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetParent(Transform parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_SetParent_Private_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082B4 RID: 33460 RVA: 0x0022CB50 File Offset: 0x0022AD50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246658, XrefRangeEnd = 246683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetData(Guid gridGUID, Vector2 originCoordinate, float rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gridGUID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_SetData_Protected_Virtual_New_Void_Guid_Vector2_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082B5 RID: 33461 RVA: 0x0022CBB8 File Offset: 0x0022ADB8
		[CallerCount(0)]
		public unsafe virtual void RepositionConstructable(Guid gridGUID, Vector2 originCoordinate, float rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gridGUID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_RepositionConstructable_Public_Virtual_New_Void_Guid_Vector2_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082B6 RID: 33462 RVA: 0x0022CC20 File Offset: 0x0022AE20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246683, XrefRangeEnd = 246718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshTransform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_RefreshTransform_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082B7 RID: 33463 RVA: 0x0022CC54 File Offset: 0x0022AE54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246718, XrefRangeEnd = 246730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearPositionData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_ClearPositionData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082B8 RID: 33464 RVA: 0x0022CC88 File Offset: 0x0022AE88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 246772, RefRangeEnd = 246773, XrefRangeStart = 246730, XrefRangeEnd = 246772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DestroyConstructable(bool callOnServer = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref callOnServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_DestroyConstructable_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082B9 RID: 33465 RVA: 0x0022CCD4 File Offset: 0x0022AED4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 246797, RefRangeEnd = 246798, XrefRangeStart = 246773, XrefRangeEnd = 246797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateGridGUIDs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_GenerateGridGUIDs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082BA RID: 33466 RVA: 0x0022CD08 File Offset: 0x0022AF08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 246804, RefRangeEnd = 246806, XrefRangeStart = 246798, XrefRangeEnd = 246804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetGridGUIDs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_GetGridGUIDs_Private_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060082BB RID: 33467 RVA: 0x0022CD48 File Offset: 0x0022AF48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 246837, RefRangeEnd = 246839, XrefRangeStart = 246806, XrefRangeEnd = 246837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGridGUIDs(NetworkConnection target, Il2CppStringArray guids)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(guids);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_SetGridGUIDs_Protected_Void_NetworkConnection_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082BC RID: 33468 RVA: 0x0022CD9C File Offset: 0x0022AF9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246839, XrefRangeEnd = 246854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetInvisible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_SetInvisible_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082BD RID: 33469 RVA: 0x0022CDD8 File Offset: 0x0022AFD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246854, XrefRangeEnd = 246865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RestoreVisibility()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_RestoreVisibility_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082BE RID: 33470 RVA: 0x0022CE14 File Offset: 0x0022B014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246865, XrefRangeEnd = 246923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetRoofVisible(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_SetRoofVisible_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082BF RID: 33471 RVA: 0x0022CE60 File Offset: 0x0022B060
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 246928, RefRangeEnd = 246929, XrefRangeStart = 246923, XrefRangeEnd = 246928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalculateFootprintTileIntersections()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_CalculateFootprintTileIntersections_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082C0 RID: 33472 RVA: 0x0022CE94 File Offset: 0x0022B094
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 246935, RefRangeEnd = 246938, XrefRangeStart = 246929, XrefRangeEnd = 246935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFootprintTileVisiblity(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_SetFootprintTileVisiblity_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082C1 RID: 33473 RVA: 0x0022CED4 File Offset: 0x0022B0D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 246945, RefRangeEnd = 246947, XrefRangeStart = 246938, XrefRangeEnd = 246945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FootprintTile GetFootprintTile(Coordinate coord)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(coord);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_GetFootprintTile_Public_FootprintTile_Coordinate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr3) : null;
		}

		// Token: 0x060082C2 RID: 33474 RVA: 0x0022CF24 File Offset: 0x0022B124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246947, XrefRangeEnd = 246963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<FootprintTile> GetFootprintTiles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_GetFootprintTiles_Public_List_1_FootprintTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<FootprintTile>>(intPtr3) : null;
		}

		// Token: 0x060082C3 RID: 33475 RVA: 0x0022CF64 File Offset: 0x0022B164
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 247026, RefRangeEnd = 247029, XrefRangeStart = 246963, XrefRangeEnd = 247026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Constructable_GridBased() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082C4 RID: 33476 RVA: 0x0022CFA0 File Offset: 0x0022B1A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247029, XrefRangeEnd = 247034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060082C5 RID: 33477 RVA: 0x0022CFE0 File Offset: 0x0022B1E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _ReceiveData_b__36_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr__ReceiveData_b__36_1_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060082C6 RID: 33478 RVA: 0x0022D01C File Offset: 0x0022B21C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 247102, RefRangeEnd = 247105, XrefRangeStart = 247034, XrefRangeEnd = 247102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082C7 RID: 33479 RVA: 0x0022D058 File Offset: 0x0022B258
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 247105, RefRangeEnd = 247108, XrefRangeStart = 247105, XrefRangeEnd = 247105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082C8 RID: 33480 RVA: 0x0022D094 File Offset: 0x0022B294
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082C9 RID: 33481 RVA: 0x0022D0D0 File Offset: 0x0022B2D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247108, XrefRangeEnd = 247122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetData_810381718(Guid gridGUID, Vector2 originCoordinate, float rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gridGUID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_RpcWriter___Server_SetData_810381718_Private_Void_Guid_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082CA RID: 33482 RVA: 0x0022D12C File Offset: 0x0022B32C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 247166, RefRangeEnd = 247168, XrefRangeStart = 247122, XrefRangeEnd = 247166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetData_810381718(Guid gridGUID, Vector2 originCoordinate, float rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gridGUID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_RpcLogic___SetData_810381718_Protected_Virtual_New_Void_Guid_Vector2_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082CB RID: 33483 RVA: 0x0022D194 File Offset: 0x0022B394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247168, XrefRangeEnd = 247175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetData_810381718(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_RpcReader___Server_SetData_810381718_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082CC RID: 33484 RVA: 0x0022D1F8 File Offset: 0x0022B3F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247175, XrefRangeEnd = 247194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetGridGUIDs_2890081366(NetworkConnection target, Il2CppStringArray guids)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(guids);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_RpcWriter___Observers_SetGridGUIDs_2890081366_Private_Void_NetworkConnection_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082CD RID: 33485 RVA: 0x0022D24C File Offset: 0x0022B44C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 247206, RefRangeEnd = 247208, XrefRangeStart = 247194, XrefRangeEnd = 247206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetGridGUIDs_2890081366(NetworkConnection target, Il2CppStringArray guids)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(guids);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_RpcLogic___SetGridGUIDs_2890081366_Protected_Void_NetworkConnection_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082CE RID: 33486 RVA: 0x0022D2A0 File Offset: 0x0022B4A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247208, XrefRangeEnd = 247211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetGridGUIDs_2890081366(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_RpcReader___Observers_SetGridGUIDs_2890081366_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082CF RID: 33487 RVA: 0x0022D2F0 File Offset: 0x0022B4F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247211, XrefRangeEnd = 247230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetGridGUIDs_2890081366(NetworkConnection target, Il2CppStringArray guids)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(guids);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_RpcWriter___Target_SetGridGUIDs_2890081366_Private_Void_NetworkConnection_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082D0 RID: 33488 RVA: 0x0022D344 File Offset: 0x0022B544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247230, XrefRangeEnd = 247234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetGridGUIDs_2890081366(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_RpcReader___Target_SetGridGUIDs_2890081366_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170027AA RID: 10154
		// (get) Token: 0x060082D1 RID: 33489 RVA: 0x0022D394 File Offset: 0x0022B594
		// (set) Token: 0x060082D2 RID: 33490 RVA: 0x0022D3D0 File Offset: 0x0022B5D0
		public unsafe Guid SyncAccessor_OwnerGridGUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_sync___get_value_OwnerGridGUID_Public_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 247242, RefRangeEnd = 247243, XrefRangeStart = 247234, XrefRangeEnd = 247242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_sync___set_value_OwnerGridGUID_Public_set_Void_Guid_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060082D3 RID: 33491 RVA: 0x0022D41C File Offset: 0x0022B61C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247243, XrefRangeEnd = 247263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_ConstructableScripts_Constructable_GridBased(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_ConstructableScripts_Constructable_GridBased_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170027AB RID: 10155
		// (get) Token: 0x060082D4 RID: 33492 RVA: 0x0022D490 File Offset: 0x0022B690
		// (set) Token: 0x060082D5 RID: 33493 RVA: 0x0022D4CC File Offset: 0x0022B6CC
		public unsafe Vector2 SyncAccessor_OriginCoordinate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_sync___get_value_OriginCoordinate_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 247271, RefRangeEnd = 247272, XrefRangeStart = 247263, XrefRangeEnd = 247271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_sync___set_value_OriginCoordinate_Public_set_Void_Vector2_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170027AC RID: 10156
		// (get) Token: 0x060082D6 RID: 33494 RVA: 0x0022D518 File Offset: 0x0022B718
		// (set) Token: 0x060082D7 RID: 33495 RVA: 0x0022D554 File Offset: 0x0022B754
		public unsafe float SyncAccessor_Rotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_sync___get_value_Rotation_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247272, XrefRangeEnd = 247280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_sync___set_value_Rotation_Public_set_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060082D8 RID: 33496 RVA: 0x0022D5A0 File Offset: 0x0022B7A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 247310, RefRangeEnd = 247313, XrefRangeStart = 247280, XrefRangeEnd = 247310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082D9 RID: 33497 RVA: 0x0003E212 File Offset: 0x0003C412
		public Constructable_GridBased(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700278E RID: 10126
		// (get) Token: 0x060082DA RID: 33498 RVA: 0x0022D5DC File Offset: 0x0022B7DC
		// (set) Token: 0x060082DB RID: 33499 RVA: 0x0003E21B File Offset: 0x0003C41B
		public unsafe Transform buildPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_buildPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_buildPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700278F RID: 10127
		// (get) Token: 0x060082DC RID: 33500 RVA: 0x0022D60C File Offset: 0x0022B80C
		// (set) Token: 0x060082DD RID: 33501 RVA: 0x0003E23A File Offset: 0x0003C43A
		public unsafe List<CoordinateFootprintTilePair> CoordinateFootprintTilePairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_CoordinateFootprintTilePairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CoordinateFootprintTilePair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_CoordinateFootprintTilePairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002790 RID: 10128
		// (get) Token: 0x060082DE RID: 33502 RVA: 0x0022D63C File Offset: 0x0022B83C
		// (set) Token: 0x060082DF RID: 33503 RVA: 0x0003E259 File Offset: 0x0003C459
		public unsafe Transform ContentContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_ContentContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_ContentContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002791 RID: 10129
		// (get) Token: 0x060082E0 RID: 33504 RVA: 0x0022D66C File Offset: 0x0022B86C
		// (set) Token: 0x060082E1 RID: 33505 RVA: 0x0003E278 File Offset: 0x0003C478
		public unsafe Il2CppReferenceArray<Grid> Grids
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_Grids);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Grid>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_Grids), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002792 RID: 10130
		// (get) Token: 0x060082E2 RID: 33506 RVA: 0x0022D69C File Offset: 0x0022B89C
		// (set) Token: 0x060082E3 RID: 33507 RVA: 0x0003E297 File Offset: 0x0003C497
		public unsafe List<GameObject> roofObjectsForVisibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_roofObjectsForVisibility);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_roofObjectsForVisibility), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002793 RID: 10131
		// (get) Token: 0x060082E4 RID: 33508 RVA: 0x0022D6CC File Offset: 0x0022B8CC
		// (set) Token: 0x060082E5 RID: 33509 RVA: 0x0003E2B6 File Offset: 0x0003C4B6
		public unsafe bool AlwaysPowered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_AlwaysPowered);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_AlwaysPowered)) = value;
			}
		}

		// Token: 0x17002794 RID: 10132
		// (get) Token: 0x060082E6 RID: 33510 RVA: 0x0022D6F4 File Offset: 0x0022B8F4
		// (set) Token: 0x060082E7 RID: 33511 RVA: 0x0003E2D1 File Offset: 0x0003C4D1
		public unsafe PowerNode powerNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_powerNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PowerNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_powerNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002795 RID: 10133
		// (get) Token: 0x060082E8 RID: 33512 RVA: 0x0022D724 File Offset: 0x0022B924
		// (set) Token: 0x060082E9 RID: 33513 RVA: 0x0003E2F0 File Offset: 0x0003C4F0
		public unsafe bool isGhost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_isGhost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_isGhost)) = value;
			}
		}

		// Token: 0x17002796 RID: 10134
		// (get) Token: 0x060082EA RID: 33514 RVA: 0x0022D74C File Offset: 0x0022B94C
		// (set) Token: 0x060082EB RID: 33515 RVA: 0x0003E30B File Offset: 0x0003C50B
		public unsafe bool dataChangedThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_dataChangedThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_dataChangedThisFrame)) = value;
			}
		}

		// Token: 0x17002797 RID: 10135
		// (get) Token: 0x060082EC RID: 33516 RVA: 0x0022D774 File Offset: 0x0022B974
		// (set) Token: 0x060082ED RID: 33517 RVA: 0x0003E326 File Offset: 0x0003C526
		public unsafe Grid _OwnerGrid_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr__OwnerGrid_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Grid>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr__OwnerGrid_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002798 RID: 10136
		// (get) Token: 0x060082EE RID: 33518 RVA: 0x0022D7A4 File Offset: 0x0022B9A4
		// (set) Token: 0x060082EF RID: 33519 RVA: 0x0003E345 File Offset: 0x0003C545
		public unsafe Guid OwnerGridGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_OwnerGridGUID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_OwnerGridGUID)) = value;
			}
		}

		// Token: 0x17002799 RID: 10137
		// (get) Token: 0x060082F0 RID: 33520 RVA: 0x0022D7CC File Offset: 0x0022B9CC
		// (set) Token: 0x060082F1 RID: 33521 RVA: 0x0003E360 File Offset: 0x0003C560
		public unsafe Vector2 OriginCoordinate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_OriginCoordinate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_OriginCoordinate)) = value;
			}
		}

		// Token: 0x1700279A RID: 10138
		// (get) Token: 0x060082F2 RID: 33522 RVA: 0x0022D7F4 File Offset: 0x0022B9F4
		// (set) Token: 0x060082F3 RID: 33523 RVA: 0x0003E37B File Offset: 0x0003C57B
		public unsafe float Rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_Rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_Rotation)) = value;
			}
		}

		// Token: 0x1700279B RID: 10139
		// (get) Token: 0x060082F4 RID: 33524 RVA: 0x0022D81C File Offset: 0x0022BA1C
		// (set) Token: 0x060082F5 RID: 33525 RVA: 0x0003E396 File Offset: 0x0003C596
		public unsafe List<CoordinatePair> coordinatePairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_coordinatePairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CoordinatePair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_coordinatePairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700279C RID: 10140
		// (get) Token: 0x060082F6 RID: 33526 RVA: 0x0022D84C File Offset: 0x0022BA4C
		// (set) Token: 0x060082F7 RID: 33527 RVA: 0x0003E3B5 File Offset: 0x0003C5B5
		public unsafe Dictionary<GameObject, LayerMask> originalRoofLayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_originalRoofLayers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<GameObject, LayerMask>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_originalRoofLayers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700279D RID: 10141
		// (get) Token: 0x060082F8 RID: 33528 RVA: 0x0022D87C File Offset: 0x0022BA7C
		// (set) Token: 0x060082F9 RID: 33529 RVA: 0x0003E3D4 File Offset: 0x0003C5D4
		public unsafe bool roofVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_roofVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_roofVisible)) = value;
			}
		}

		// Token: 0x1700279E RID: 10142
		// (get) Token: 0x060082FA RID: 33530 RVA: 0x0022D8A4 File Offset: 0x0022BAA4
		// (set) Token: 0x060082FB RID: 33531 RVA: 0x0003E3EF File Offset: 0x0003C5EF
		public unsafe SyncVar<Guid> syncVar___OwnerGridGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_syncVar___OwnerGridGUID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<Guid>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_syncVar___OwnerGridGUID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700279F RID: 10143
		// (get) Token: 0x060082FC RID: 33532 RVA: 0x0022D8D4 File Offset: 0x0022BAD4
		// (set) Token: 0x060082FD RID: 33533 RVA: 0x0003E40E File Offset: 0x0003C60E
		public unsafe SyncVar<Vector2> syncVar___OriginCoordinate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_syncVar___OriginCoordinate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_syncVar___OriginCoordinate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027A0 RID: 10144
		// (get) Token: 0x060082FE RID: 33534 RVA: 0x0022D904 File Offset: 0x0022BB04
		// (set) Token: 0x060082FF RID: 33535 RVA: 0x0003E42D File Offset: 0x0003C62D
		public unsafe SyncVar<float> syncVar___Rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_syncVar___Rotation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_syncVar___Rotation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027A1 RID: 10145
		// (get) Token: 0x06008300 RID: 33536 RVA: 0x0022D934 File Offset: 0x0022BB34
		// (set) Token: 0x06008301 RID: 33537 RVA: 0x0003E44C File Offset: 0x0003C64C
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170027A2 RID: 10146
		// (get) Token: 0x06008302 RID: 33538 RVA: 0x0022D95C File Offset: 0x0022BB5C
		// (set) Token: 0x06008303 RID: 33539 RVA: 0x0003E467 File Offset: 0x0003C667
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040058E2 RID: 22754
		private static readonly IntPtr NativeFieldInfoPtr_buildPoint;

		// Token: 0x040058E3 RID: 22755
		private static readonly IntPtr NativeFieldInfoPtr_CoordinateFootprintTilePairs;

		// Token: 0x040058E4 RID: 22756
		private static readonly IntPtr NativeFieldInfoPtr_ContentContainer;

		// Token: 0x040058E5 RID: 22757
		private static readonly IntPtr NativeFieldInfoPtr_Grids;

		// Token: 0x040058E6 RID: 22758
		private static readonly IntPtr NativeFieldInfoPtr_roofObjectsForVisibility;

		// Token: 0x040058E7 RID: 22759
		private static readonly IntPtr NativeFieldInfoPtr_AlwaysPowered;

		// Token: 0x040058E8 RID: 22760
		private static readonly IntPtr NativeFieldInfoPtr_powerNode;

		// Token: 0x040058E9 RID: 22761
		private static readonly IntPtr NativeFieldInfoPtr_isGhost;

		// Token: 0x040058EA RID: 22762
		private static readonly IntPtr NativeFieldInfoPtr_dataChangedThisFrame;

		// Token: 0x040058EB RID: 22763
		private static readonly IntPtr NativeFieldInfoPtr__OwnerGrid_k__BackingField;

		// Token: 0x040058EC RID: 22764
		private static readonly IntPtr NativeFieldInfoPtr_OwnerGridGUID;

		// Token: 0x040058ED RID: 22765
		private static readonly IntPtr NativeFieldInfoPtr_OriginCoordinate;

		// Token: 0x040058EE RID: 22766
		private static readonly IntPtr NativeFieldInfoPtr_Rotation;

		// Token: 0x040058EF RID: 22767
		private static readonly IntPtr NativeFieldInfoPtr_coordinatePairs;

		// Token: 0x040058F0 RID: 22768
		private static readonly IntPtr NativeFieldInfoPtr_originalRoofLayers;

		// Token: 0x040058F1 RID: 22769
		private static readonly IntPtr NativeFieldInfoPtr_roofVisible;

		// Token: 0x040058F2 RID: 22770
		private static readonly IntPtr NativeFieldInfoPtr_syncVar___OwnerGridGUID;

		// Token: 0x040058F3 RID: 22771
		private static readonly IntPtr NativeFieldInfoPtr_syncVar___OriginCoordinate;

		// Token: 0x040058F4 RID: 22772
		private static readonly IntPtr NativeFieldInfoPtr_syncVar___Rotation;

		// Token: 0x040058F5 RID: 22773
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040058F6 RID: 22774
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040058F7 RID: 22775
		private static readonly IntPtr NativeMethodInfoPtr_get_OriginFootprint_Public_get_FootprintTile_0;

		// Token: 0x040058F8 RID: 22776
		private static readonly IntPtr NativeMethodInfoPtr_get_FootprintX_Public_get_Int32_0;

		// Token: 0x040058F9 RID: 22777
		private static readonly IntPtr NativeMethodInfoPtr_get_FootprintY_Public_get_Int32_0;

		// Token: 0x040058FA RID: 22778
		private static readonly IntPtr NativeMethodInfoPtr_get_hasWaterSupply_Public_get_Boolean_0;

		// Token: 0x040058FB RID: 22779
		private static readonly IntPtr NativeMethodInfoPtr_get_PowerNode_Public_get_PowerNode_0;

		// Token: 0x040058FC RID: 22780
		private static readonly IntPtr NativeMethodInfoPtr_get_isPowered_Public_get_Boolean_0;

		// Token: 0x040058FD RID: 22781
		private static readonly IntPtr NativeMethodInfoPtr_get_OwnerGrid_Public_get_Grid_0;

		// Token: 0x040058FE RID: 22782
		private static readonly IntPtr NativeMethodInfoPtr_set_OwnerGrid_Protected_set_Void_Grid_0;

		// Token: 0x040058FF RID: 22783
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04005900 RID: 22784
		private static readonly IntPtr NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0;

		// Token: 0x04005901 RID: 22785
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04005902 RID: 22786
		private static readonly IntPtr NativeMethodInfoPtr_OnStartNetwork_Public_Virtual_Void_0;

		// Token: 0x04005903 RID: 22787
		private static readonly IntPtr NativeMethodInfoPtr_InitializeConstructable_GridBased_Public_Virtual_New_Void_Grid_Vector2_Single_0;

		// Token: 0x04005904 RID: 22788
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveData_Private_Void_0;

		// Token: 0x04005905 RID: 22789
		private static readonly IntPtr NativeMethodInfoPtr_SetParent_Private_Void_Transform_0;

		// Token: 0x04005906 RID: 22790
		private static readonly IntPtr NativeMethodInfoPtr_SetData_Protected_Virtual_New_Void_Guid_Vector2_Single_0;

		// Token: 0x04005907 RID: 22791
		private static readonly IntPtr NativeMethodInfoPtr_RepositionConstructable_Public_Virtual_New_Void_Guid_Vector2_Single_0;

		// Token: 0x04005908 RID: 22792
		private static readonly IntPtr NativeMethodInfoPtr_RefreshTransform_Private_Void_0;

		// Token: 0x04005909 RID: 22793
		private static readonly IntPtr NativeMethodInfoPtr_ClearPositionData_Private_Void_0;

		// Token: 0x0400590A RID: 22794
		private static readonly IntPtr NativeMethodInfoPtr_DestroyConstructable_Public_Virtual_Void_Boolean_0;

		// Token: 0x0400590B RID: 22795
		private static readonly IntPtr NativeMethodInfoPtr_GenerateGridGUIDs_Private_Void_0;

		// Token: 0x0400590C RID: 22796
		private static readonly IntPtr NativeMethodInfoPtr_GetGridGUIDs_Private_Il2CppStringArray_0;

		// Token: 0x0400590D RID: 22797
		private static readonly IntPtr NativeMethodInfoPtr_SetGridGUIDs_Protected_Void_NetworkConnection_Il2CppStringArray_0;

		// Token: 0x0400590E RID: 22798
		private static readonly IntPtr NativeMethodInfoPtr_SetInvisible_Public_Virtual_Void_0;

		// Token: 0x0400590F RID: 22799
		private static readonly IntPtr NativeMethodInfoPtr_RestoreVisibility_Public_Virtual_Void_0;

		// Token: 0x04005910 RID: 22800
		private static readonly IntPtr NativeMethodInfoPtr_SetRoofVisible_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04005911 RID: 22801
		private static readonly IntPtr NativeMethodInfoPtr_CalculateFootprintTileIntersections_Public_Void_0;

		// Token: 0x04005912 RID: 22802
		private static readonly IntPtr NativeMethodInfoPtr_SetFootprintTileVisiblity_Public_Void_Boolean_0;

		// Token: 0x04005913 RID: 22803
		private static readonly IntPtr NativeMethodInfoPtr_GetFootprintTile_Public_FootprintTile_Coordinate_0;

		// Token: 0x04005914 RID: 22804
		private static readonly IntPtr NativeMethodInfoPtr_GetFootprintTiles_Public_List_1_FootprintTile_0;

		// Token: 0x04005915 RID: 22805
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005916 RID: 22806
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04005917 RID: 22807
		private static readonly IntPtr NativeMethodInfoPtr__ReceiveData_b__36_1_Private_Boolean_0;

		// Token: 0x04005918 RID: 22808
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04005919 RID: 22809
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400591A RID: 22810
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400591B RID: 22811
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetData_810381718_Private_Void_Guid_Vector2_Single_0;

		// Token: 0x0400591C RID: 22812
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetData_810381718_Protected_Virtual_New_Void_Guid_Vector2_Single_0;

		// Token: 0x0400591D RID: 22813
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetData_810381718_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400591E RID: 22814
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetGridGUIDs_2890081366_Private_Void_NetworkConnection_Il2CppStringArray_0;

		// Token: 0x0400591F RID: 22815
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetGridGUIDs_2890081366_Protected_Void_NetworkConnection_Il2CppStringArray_0;

		// Token: 0x04005920 RID: 22816
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetGridGUIDs_2890081366_Private_Void_PooledReader_Channel_0;

		// Token: 0x04005921 RID: 22817
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetGridGUIDs_2890081366_Private_Void_NetworkConnection_Il2CppStringArray_0;

		// Token: 0x04005922 RID: 22818
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetGridGUIDs_2890081366_Private_Void_PooledReader_Channel_0;

		// Token: 0x04005923 RID: 22819
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value_OwnerGridGUID_Public_get_Guid_0;

		// Token: 0x04005924 RID: 22820
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value_OwnerGridGUID_Public_set_Void_Guid_Boolean_0;

		// Token: 0x04005925 RID: 22821
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_ConstructableScripts_Constructable_GridBased_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04005926 RID: 22822
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value_OriginCoordinate_Public_get_Vector2_0;

		// Token: 0x04005927 RID: 22823
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value_OriginCoordinate_Public_set_Void_Vector2_Boolean_0;

		// Token: 0x04005928 RID: 22824
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value_Rotation_Public_get_Single_0;

		// Token: 0x04005929 RID: 22825
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value_Rotation_Public_set_Void_Single_Boolean_0;

		// Token: 0x0400592A RID: 22826
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000AE4 RID: 2788
		[ObfuscatedName("ScheduleOne.ConstructableScripts.Constructable_GridBased+<<ReceiveData>g__Routine|36_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D542 RID: 54594 RVA: 0x0032D7D0 File Offset: 0x0032B9D0
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique()
			{
				Il2CppClassPointerStore<Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "<<ReceiveData>g__Routine|36_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique>.NativeClassPtr);
				Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique>.NativeClassPtr, "<>1__state");
				Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique>.NativeClassPtr, "<>2__current");
				Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique>.NativeClassPtr, "<>4__this");
				Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique>.NativeClassPtr, 100679686);
				Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique>.NativeClassPtr, 100679687);
				Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique>.NativeClassPtr, 100679688);
				Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique>.NativeClassPtr, 100679689);
				Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique>.NativeClassPtr, 100679690);
				Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique>.NativeClassPtr, 100679691);
			}

			// Token: 0x0600D543 RID: 54595 RVA: 0x0032D8B0 File Offset: 0x0032BAB0
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D544 RID: 54596 RVA: 0x0032D8F8 File Offset: 0x0032BAF8
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D545 RID: 54597 RVA: 0x0032D92C File Offset: 0x0032BB2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246541, XrefRangeEnd = 246552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004217 RID: 16919
			// (get) Token: 0x0600D546 RID: 54598 RVA: 0x0032D968 File Offset: 0x0032BB68
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D547 RID: 54599 RVA: 0x0032D9A8 File Offset: 0x0032BBA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246552, XrefRangeEnd = 246557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004218 RID: 16920
			// (get) Token: 0x0600D548 RID: 54600 RVA: 0x0032D9DC File Offset: 0x0032BBDC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D549 RID: 54601 RVA: 0x00067C46 File Offset: 0x00065E46
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004214 RID: 16916
			// (get) Token: 0x0600D54A RID: 54602 RVA: 0x0032DA1C File Offset: 0x0032BC1C
			// (set) Token: 0x0600D54B RID: 54603 RVA: 0x00067C4F File Offset: 0x00065E4F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004215 RID: 16917
			// (get) Token: 0x0600D54C RID: 54604 RVA: 0x0032DA44 File Offset: 0x0032BC44
			// (set) Token: 0x0600D54D RID: 54605 RVA: 0x00067C6A File Offset: 0x00065E6A
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004216 RID: 16918
			// (get) Token: 0x0600D54E RID: 54606 RVA: 0x0032DA74 File Offset: 0x0032BC74
			// (set) Token: 0x0600D54F RID: 54607 RVA: 0x00067C89 File Offset: 0x00065E89
			public unsafe Constructable_GridBased __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Constructable_GridBased>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F74 RID: 36724
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008F75 RID: 36725
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008F76 RID: 36726
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008F77 RID: 36727
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008F78 RID: 36728
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F79 RID: 36729
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008F7A RID: 36730
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008F7B RID: 36731
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F7C RID: 36732
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
