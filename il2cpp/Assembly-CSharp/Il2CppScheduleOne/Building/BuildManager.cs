using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Storage;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x020004B3 RID: 1203
	public class BuildManager : Singleton<BuildManager>
	{
		// Token: 0x060069D0 RID: 27088 RVA: 0x001D96E0 File Offset: 0x001D78E0
		// Note: this type is marked as 'beforefieldinit'.
		static BuildManager()
		{
			Il2CppClassPointerStore<BuildManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "BuildManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildManager>.NativeClassPtr);
			BuildManager.NativeFieldInfoPtr_PlaceSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, "PlaceSounds");
			BuildManager.NativeFieldInfoPtr_tempContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, "tempContainer");
			BuildManager.NativeFieldInfoPtr_networkObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, "networkObject");
			BuildManager.NativeFieldInfoPtr_storedItemBuildHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, "storedItemBuildHandler");
			BuildManager.NativeFieldInfoPtr_cashBuildHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, "cashBuildHandler");
			BuildManager.NativeFieldInfoPtr_ghostMaterial_White = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, "ghostMaterial_White");
			BuildManager.NativeFieldInfoPtr_ghostMaterial_Red = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, "ghostMaterial_Red");
			BuildManager.NativeFieldInfoPtr__isBuilding_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, "<isBuilding>k__BackingField");
			BuildManager.NativeFieldInfoPtr__currentBuildHandler_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, "<currentBuildHandler>k__BackingField");
			BuildManager.NativeMethodInfoPtr_get__tempContainer_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676729);
			BuildManager.NativeMethodInfoPtr_get_isBuilding_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676730);
			BuildManager.NativeMethodInfoPtr_set_isBuilding_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676731);
			BuildManager.NativeMethodInfoPtr_get_currentBuildHandler_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676732);
			BuildManager.NativeMethodInfoPtr_set_currentBuildHandler_Protected_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676733);
			BuildManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676734);
			BuildManager.NativeMethodInfoPtr_StartBuilding_Public_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676735);
			BuildManager.NativeMethodInfoPtr_StartBuildingStoredItem_Public_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676736);
			BuildManager.NativeMethodInfoPtr_StartPlacingCash_Public_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676737);
			BuildManager.NativeMethodInfoPtr_StopBuilding_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676738);
			BuildManager.NativeMethodInfoPtr_PlayBuildSound_Public_Void_EBuildSoundType_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676739);
			BuildManager.NativeMethodInfoPtr_DisableColliders_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676740);
			BuildManager.NativeMethodInfoPtr_DisableLights_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676741);
			BuildManager.NativeMethodInfoPtr_DisableNetworking_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676742);
			BuildManager.NativeMethodInfoPtr_DisableSpriteRenderers_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676743);
			BuildManager.NativeMethodInfoPtr_ApplyMaterial_Public_Void_GameObject_Material_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676744);
			BuildManager.NativeMethodInfoPtr_DisableNavigation_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676745);
			BuildManager.NativeMethodInfoPtr_DisableCanvases_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676746);
			BuildManager.NativeMethodInfoPtr_CreateGridItem_Public_GridItem_ItemInstance_Grid_Vector2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676747);
			BuildManager.NativeMethodInfoPtr_CreateProceduralGridItem_Public_ProceduralGridItem_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676748);
			BuildManager.NativeMethodInfoPtr_CreateSurfaceItem_Public_SurfaceItem_ItemInstance_Surface_Vector3_Quaternion_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676749);
			BuildManager.NativeMethodInfoPtr_CreateStoredItem_Public_Void_StorableItemInstance_IStorageEntity_StorageGrid_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676750);
			BuildManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676751);
		}

		// Token: 0x17001FD5 RID: 8149
		// (get) Token: 0x060069D1 RID: 27089 RVA: 0x001D9990 File Offset: 0x001D7B90
		public unsafe Transform _tempContainer
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19644, RefRangeEnd = 19658, XrefRangeStart = 19644, XrefRangeEnd = 19658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_get__tempContainer_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17001FD6 RID: 8150
		// (get) Token: 0x060069D2 RID: 27090 RVA: 0x001D99D0 File Offset: 0x001D7BD0
		// (set) Token: 0x060069D3 RID: 27091 RVA: 0x001D9A0C File Offset: 0x001D7C0C
		public unsafe bool isBuilding
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_get_isBuilding_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_set_isBuilding_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001FD7 RID: 8151
		// (get) Token: 0x060069D4 RID: 27092 RVA: 0x001D9A4C File Offset: 0x001D7C4C
		// (set) Token: 0x060069D5 RID: 27093 RVA: 0x001D9A8C File Offset: 0x001D7C8C
		public unsafe GameObject currentBuildHandler
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 22951, RefRangeEnd = 22968, XrefRangeStart = 22951, XrefRangeEnd = 22968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_get_currentBuildHandler_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_set_currentBuildHandler_Protected_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060069D6 RID: 27094 RVA: 0x001D9AD0 File Offset: 0x001D7CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213245, XrefRangeEnd = 213248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069D7 RID: 27095 RVA: 0x001D9B0C File Offset: 0x001D7D0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 213284, RefRangeEnd = 213286, XrefRangeStart = 213248, XrefRangeEnd = 213284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartBuilding(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_StartBuilding_Public_Void_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069D8 RID: 27096 RVA: 0x001D9B50 File Offset: 0x001D7D50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 213312, RefRangeEnd = 213313, XrefRangeStart = 213286, XrefRangeEnd = 213312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartBuildingStoredItem(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_StartBuildingStoredItem_Public_Void_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069D9 RID: 27097 RVA: 0x001D9B94 File Offset: 0x001D7D94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 213333, RefRangeEnd = 213334, XrefRangeStart = 213313, XrefRangeEnd = 213333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartPlacingCash(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_StartPlacingCash_Public_Void_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069DA RID: 27098 RVA: 0x001D9BD8 File Offset: 0x001D7DD8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 213338, RefRangeEnd = 213345, XrefRangeStart = 213334, XrefRangeEnd = 213338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopBuilding()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_StopBuilding_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069DB RID: 27099 RVA: 0x001D9C0C File Offset: 0x001D7E0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 213360, RefRangeEnd = 213362, XrefRangeStart = 213345, XrefRangeEnd = 213360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayBuildSound(BuildableItemDefinition.EBuildSoundType type, Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_PlayBuildSound_Public_Void_EBuildSoundType_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069DC RID: 27100 RVA: 0x001D9C58 File Offset: 0x001D7E58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 213367, RefRangeEnd = 213369, XrefRangeStart = 213362, XrefRangeEnd = 213367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableColliders(GameObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_DisableColliders_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069DD RID: 27101 RVA: 0x001D9C9C File Offset: 0x001D7E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213369, XrefRangeEnd = 213374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableLights(GameObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_DisableLights_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069DE RID: 27102 RVA: 0x001D9CE0 File Offset: 0x001D7EE0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 213382, RefRangeEnd = 213386, XrefRangeStart = 213374, XrefRangeEnd = 213382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableNetworking(GameObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_DisableNetworking_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069DF RID: 27103 RVA: 0x001D9D24 File Offset: 0x001D7F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213386, XrefRangeEnd = 213391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableSpriteRenderers(GameObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_DisableSpriteRenderers_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069E0 RID: 27104 RVA: 0x001D9D68 File Offset: 0x001D7F68
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 213410, RefRangeEnd = 213417, XrefRangeStart = 213391, XrefRangeEnd = 213410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyMaterial(GameObject obj, Material mat, bool allMaterials = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allMaterials;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_ApplyMaterial_Public_Void_GameObject_Material_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069E1 RID: 27105 RVA: 0x001D9DCC File Offset: 0x001D7FCC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 213432, RefRangeEnd = 213436, XrefRangeStart = 213417, XrefRangeEnd = 213432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableNavigation(GameObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_DisableNavigation_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069E2 RID: 27106 RVA: 0x001D9E10 File Offset: 0x001D8010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213436, XrefRangeEnd = 213441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableCanvases(GameObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_DisableCanvases_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069E3 RID: 27107 RVA: 0x001D9E54 File Offset: 0x001D8054
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 213479, RefRangeEnd = 213481, XrefRangeStart = 213441, XrefRangeEnd = 213479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GridItem CreateGridItem(ItemInstance item, Grid grid, Vector2 originCoordinate, int rotation, string guid = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_CreateGridItem_Public_GridItem_ItemInstance_Grid_Vector2_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GridItem>(intPtr3) : null;
		}

		// Token: 0x060069E4 RID: 27108 RVA: 0x001D9EE8 File Offset: 0x001D80E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213481, XrefRangeEnd = 213510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProceduralGridItem CreateProceduralGridItem(ItemInstance item, int rotationAngle, List<CoordinateProceduralTilePair> matches, string guid = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotationAngle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(matches);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_CreateProceduralGridItem_Public_ProceduralGridItem_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProceduralGridItem>(intPtr3) : null;
		}

		// Token: 0x060069E5 RID: 27109 RVA: 0x001D9F6C File Offset: 0x001D816C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 213540, RefRangeEnd = 213542, XrefRangeStart = 213510, XrefRangeEnd = 213540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SurfaceItem CreateSurfaceItem(ItemInstance item, Surface parentSurface, Vector3 relativePosition, Quaternion relativeRotation, string guid = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentSurface);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relativePosition;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relativeRotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_CreateSurfaceItem_Public_SurfaceItem_ItemInstance_Surface_Vector3_Quaternion_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SurfaceItem>(intPtr3) : null;
		}

		// Token: 0x060069E6 RID: 27110 RVA: 0x001DA000 File Offset: 0x001D8200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213542, XrefRangeEnd = 213557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateStoredItem(StorableItemInstance item, IStorageEntity parentStorageEntity, StorageGrid grid, Vector2 originCoord, float rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentStorageEntity);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoord;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_CreateStoredItem_Public_Void_StorableItemInstance_IStorageEntity_StorageGrid_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069E7 RID: 27111 RVA: 0x001DA084 File Offset: 0x001D8284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213557, XrefRangeEnd = 213567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069E8 RID: 27112 RVA: 0x00032083 File Offset: 0x00030283
		public BuildManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FCC RID: 8140
		// (get) Token: 0x060069E9 RID: 27113 RVA: 0x001DA0C0 File Offset: 0x001D82C0
		// (set) Token: 0x060069EA RID: 27114 RVA: 0x0003208C File Offset: 0x0003028C
		public unsafe List<BuildManager.BuildSound> PlaceSounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_PlaceSounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BuildManager.BuildSound>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_PlaceSounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FCD RID: 8141
		// (get) Token: 0x060069EB RID: 27115 RVA: 0x001DA0F0 File Offset: 0x001D82F0
		// (set) Token: 0x060069EC RID: 27116 RVA: 0x000320AB File Offset: 0x000302AB
		public unsafe Transform tempContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_tempContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_tempContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FCE RID: 8142
		// (get) Token: 0x060069ED RID: 27117 RVA: 0x001DA120 File Offset: 0x001D8320
		// (set) Token: 0x060069EE RID: 27118 RVA: 0x000320CA File Offset: 0x000302CA
		public unsafe NetworkObject networkObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_networkObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_networkObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FCF RID: 8143
		// (get) Token: 0x060069EF RID: 27119 RVA: 0x001DA150 File Offset: 0x001D8350
		// (set) Token: 0x060069F0 RID: 27120 RVA: 0x000320E9 File Offset: 0x000302E9
		public unsafe GameObject storedItemBuildHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_storedItemBuildHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_storedItemBuildHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FD0 RID: 8144
		// (get) Token: 0x060069F1 RID: 27121 RVA: 0x001DA180 File Offset: 0x001D8380
		// (set) Token: 0x060069F2 RID: 27122 RVA: 0x00032108 File Offset: 0x00030308
		public unsafe GameObject cashBuildHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_cashBuildHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_cashBuildHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FD1 RID: 8145
		// (get) Token: 0x060069F3 RID: 27123 RVA: 0x001DA1B0 File Offset: 0x001D83B0
		// (set) Token: 0x060069F4 RID: 27124 RVA: 0x00032127 File Offset: 0x00030327
		public unsafe Material ghostMaterial_White
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_ghostMaterial_White);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_ghostMaterial_White), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FD2 RID: 8146
		// (get) Token: 0x060069F5 RID: 27125 RVA: 0x001DA1E0 File Offset: 0x001D83E0
		// (set) Token: 0x060069F6 RID: 27126 RVA: 0x00032146 File Offset: 0x00030346
		public unsafe Material ghostMaterial_Red
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_ghostMaterial_Red);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_ghostMaterial_Red), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FD3 RID: 8147
		// (get) Token: 0x060069F7 RID: 27127 RVA: 0x001DA210 File Offset: 0x001D8410
		// (set) Token: 0x060069F8 RID: 27128 RVA: 0x00032165 File Offset: 0x00030365
		public unsafe bool _isBuilding_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr__isBuilding_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr__isBuilding_k__BackingField)) = value;
			}
		}

		// Token: 0x17001FD4 RID: 8148
		// (get) Token: 0x060069F9 RID: 27129 RVA: 0x001DA238 File Offset: 0x001D8438
		// (set) Token: 0x060069FA RID: 27130 RVA: 0x00032180 File Offset: 0x00030380
		public unsafe GameObject _currentBuildHandler_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr__currentBuildHandler_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr__currentBuildHandler_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004877 RID: 18551
		private static readonly IntPtr NativeFieldInfoPtr_PlaceSounds;

		// Token: 0x04004878 RID: 18552
		private static readonly IntPtr NativeFieldInfoPtr_tempContainer;

		// Token: 0x04004879 RID: 18553
		private static readonly IntPtr NativeFieldInfoPtr_networkObject;

		// Token: 0x0400487A RID: 18554
		private static readonly IntPtr NativeFieldInfoPtr_storedItemBuildHandler;

		// Token: 0x0400487B RID: 18555
		private static readonly IntPtr NativeFieldInfoPtr_cashBuildHandler;

		// Token: 0x0400487C RID: 18556
		private static readonly IntPtr NativeFieldInfoPtr_ghostMaterial_White;

		// Token: 0x0400487D RID: 18557
		private static readonly IntPtr NativeFieldInfoPtr_ghostMaterial_Red;

		// Token: 0x0400487E RID: 18558
		private static readonly IntPtr NativeFieldInfoPtr__isBuilding_k__BackingField;

		// Token: 0x0400487F RID: 18559
		private static readonly IntPtr NativeFieldInfoPtr__currentBuildHandler_k__BackingField;

		// Token: 0x04004880 RID: 18560
		private static readonly IntPtr NativeMethodInfoPtr_get__tempContainer_Public_get_Transform_0;

		// Token: 0x04004881 RID: 18561
		private static readonly IntPtr NativeMethodInfoPtr_get_isBuilding_Public_get_Boolean_0;

		// Token: 0x04004882 RID: 18562
		private static readonly IntPtr NativeMethodInfoPtr_set_isBuilding_Protected_set_Void_Boolean_0;

		// Token: 0x04004883 RID: 18563
		private static readonly IntPtr NativeMethodInfoPtr_get_currentBuildHandler_Public_get_GameObject_0;

		// Token: 0x04004884 RID: 18564
		private static readonly IntPtr NativeMethodInfoPtr_set_currentBuildHandler_Protected_set_Void_GameObject_0;

		// Token: 0x04004885 RID: 18565
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04004886 RID: 18566
		private static readonly IntPtr NativeMethodInfoPtr_StartBuilding_Public_Void_ItemInstance_0;

		// Token: 0x04004887 RID: 18567
		private static readonly IntPtr NativeMethodInfoPtr_StartBuildingStoredItem_Public_Void_ItemInstance_0;

		// Token: 0x04004888 RID: 18568
		private static readonly IntPtr NativeMethodInfoPtr_StartPlacingCash_Public_Void_ItemInstance_0;

		// Token: 0x04004889 RID: 18569
		private static readonly IntPtr NativeMethodInfoPtr_StopBuilding_Public_Void_0;

		// Token: 0x0400488A RID: 18570
		private static readonly IntPtr NativeMethodInfoPtr_PlayBuildSound_Public_Void_EBuildSoundType_Vector3_0;

		// Token: 0x0400488B RID: 18571
		private static readonly IntPtr NativeMethodInfoPtr_DisableColliders_Public_Void_GameObject_0;

		// Token: 0x0400488C RID: 18572
		private static readonly IntPtr NativeMethodInfoPtr_DisableLights_Public_Void_GameObject_0;

		// Token: 0x0400488D RID: 18573
		private static readonly IntPtr NativeMethodInfoPtr_DisableNetworking_Public_Void_GameObject_0;

		// Token: 0x0400488E RID: 18574
		private static readonly IntPtr NativeMethodInfoPtr_DisableSpriteRenderers_Public_Void_GameObject_0;

		// Token: 0x0400488F RID: 18575
		private static readonly IntPtr NativeMethodInfoPtr_ApplyMaterial_Public_Void_GameObject_Material_Boolean_0;

		// Token: 0x04004890 RID: 18576
		private static readonly IntPtr NativeMethodInfoPtr_DisableNavigation_Public_Void_GameObject_0;

		// Token: 0x04004891 RID: 18577
		private static readonly IntPtr NativeMethodInfoPtr_DisableCanvases_Public_Void_GameObject_0;

		// Token: 0x04004892 RID: 18578
		private static readonly IntPtr NativeMethodInfoPtr_CreateGridItem_Public_GridItem_ItemInstance_Grid_Vector2_Int32_String_0;

		// Token: 0x04004893 RID: 18579
		private static readonly IntPtr NativeMethodInfoPtr_CreateProceduralGridItem_Public_ProceduralGridItem_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0;

		// Token: 0x04004894 RID: 18580
		private static readonly IntPtr NativeMethodInfoPtr_CreateSurfaceItem_Public_SurfaceItem_ItemInstance_Surface_Vector3_Quaternion_String_0;

		// Token: 0x04004895 RID: 18581
		private static readonly IntPtr NativeMethodInfoPtr_CreateStoredItem_Public_Void_StorableItemInstance_IStorageEntity_StorageGrid_Vector2_Single_0;

		// Token: 0x04004896 RID: 18582
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A53 RID: 2643
		[Serializable]
		public class BuildSound : Il2CppSystem.Object
		{
			// Token: 0x0600D05E RID: 53342 RVA: 0x0031FD0C File Offset: 0x0031DF0C
			// Note: this type is marked as 'beforefieldinit'.
			static BuildSound()
			{
				Il2CppClassPointerStore<BuildManager.BuildSound>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, "BuildSound");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildManager.BuildSound>.NativeClassPtr);
				BuildManager.BuildSound.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager.BuildSound>.NativeClassPtr, "Type");
				BuildManager.BuildSound.NativeFieldInfoPtr_Sound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager.BuildSound>.NativeClassPtr, "Sound");
				BuildManager.BuildSound.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager.BuildSound>.NativeClassPtr, 100676752);
			}

			// Token: 0x0600D05F RID: 53343 RVA: 0x0031FD74 File Offset: 0x0031DF74
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BuildSound() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildManager.BuildSound>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.BuildSound.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D060 RID: 53344 RVA: 0x0006567B File Offset: 0x0006387B
			public BuildSound(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040B7 RID: 16567
			// (get) Token: 0x0600D061 RID: 53345 RVA: 0x0031FDB0 File Offset: 0x0031DFB0
			// (set) Token: 0x0600D062 RID: 53346 RVA: 0x00065684 File Offset: 0x00063884
			public unsafe BuildableItemDefinition.EBuildSoundType Type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.BuildSound.NativeFieldInfoPtr_Type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.BuildSound.NativeFieldInfoPtr_Type)) = value;
				}
			}

			// Token: 0x170040B8 RID: 16568
			// (get) Token: 0x0600D063 RID: 53347 RVA: 0x0031FDD8 File Offset: 0x0031DFD8
			// (set) Token: 0x0600D064 RID: 53348 RVA: 0x0006569F File Offset: 0x0006389F
			public unsafe AudioSourceController Sound
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.BuildSound.NativeFieldInfoPtr_Sound);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.BuildSound.NativeFieldInfoPtr_Sound), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C9E RID: 35998
			private static readonly IntPtr NativeFieldInfoPtr_Type;

			// Token: 0x04008C9F RID: 35999
			private static readonly IntPtr NativeFieldInfoPtr_Sound;

			// Token: 0x04008CA0 RID: 36000
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A54 RID: 2644
		[ObfuscatedName("ScheduleOne.Building.BuildManager+<>c__DisplayClass23_0")]
		public sealed class __c__DisplayClass23_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D065 RID: 53349 RVA: 0x0031FE08 File Offset: 0x0031E008
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass23_0()
			{
				Il2CppClassPointerStore<BuildManager.__c__DisplayClass23_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, "<>c__DisplayClass23_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildManager.__c__DisplayClass23_0>.NativeClassPtr);
				BuildManager.__c__DisplayClass23_0.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager.__c__DisplayClass23_0>.NativeClassPtr, "type");
				BuildManager.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager.__c__DisplayClass23_0>.NativeClassPtr, 100676753);
				BuildManager.__c__DisplayClass23_0.NativeMethodInfoPtr__PlayBuildSound_b__0_Internal_Boolean_BuildSound_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager.__c__DisplayClass23_0>.NativeClassPtr, 100676754);
			}

			// Token: 0x0600D066 RID: 53350 RVA: 0x0031FE70 File Offset: 0x0031E070
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildManager.__c__DisplayClass23_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D067 RID: 53351 RVA: 0x0031FEAC File Offset: 0x0031E0AC
			[CallerCount(0)]
			public unsafe bool _PlayBuildSound_b__0(BuildManager.BuildSound s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.__c__DisplayClass23_0.NativeMethodInfoPtr__PlayBuildSound_b__0_Internal_Boolean_BuildSound_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D068 RID: 53352 RVA: 0x000656BE File Offset: 0x000638BE
			public __c__DisplayClass23_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040B9 RID: 16569
			// (get) Token: 0x0600D069 RID: 53353 RVA: 0x0031FEFC File Offset: 0x0031E0FC
			// (set) Token: 0x0600D06A RID: 53354 RVA: 0x000656C7 File Offset: 0x000638C7
			public unsafe BuildableItemDefinition.EBuildSoundType type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.__c__DisplayClass23_0.NativeFieldInfoPtr_type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.__c__DisplayClass23_0.NativeFieldInfoPtr_type)) = value;
				}
			}

			// Token: 0x04008CA1 RID: 36001
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x04008CA2 RID: 36002
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008CA3 RID: 36003
			private static readonly IntPtr NativeMethodInfoPtr__PlayBuildSound_b__0_Internal_Boolean_BuildSound_0;
		}
	}
}
