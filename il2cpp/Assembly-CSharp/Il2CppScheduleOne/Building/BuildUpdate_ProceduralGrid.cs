using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x020004BF RID: 1215
	public class BuildUpdate_ProceduralGrid : BuildUpdate_Base
	{
		// Token: 0x06006A60 RID: 27232 RVA: 0x001DB7CC File Offset: 0x001D99CC
		// Note: this type is marked as 'beforefieldinit'.
		static BuildUpdate_ProceduralGrid()
		{
			Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "BuildUpdate_ProceduralGrid");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr);
			BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_GhostModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, "GhostModel");
			BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_ItemClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, "ItemClass");
			BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_ItemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, "ItemInstance");
			BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_detectionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, "detectionRange");
			BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_detectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, "detectionMask");
			BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_rotation_Smoothing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, "rotation_Smoothing");
			BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_currentRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, "currentRotation");
			BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_validPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, "validPosition");
			BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_currentGhostMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, "currentGhostMaterial");
			BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_bestIntersection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, "bestIntersection");
			BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, 100676800);
			BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, 100676801);
			BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_CheckRotation_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, 100676802);
			BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_ApplyRotation_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, 100676803);
			BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_CheckGridIntersections_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, 100676804);
			BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, 100676805);
			BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_IsMatchValid_Private_Boolean_FootprintTile_ProceduralTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, 100676806);
			BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_Place_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, 100676807);
			BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_GetNearbyProcTile_Private_ProceduralTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, 100676808);
			BuildUpdate_ProceduralGrid.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, 100676809);
		}

		// Token: 0x06006A61 RID: 27233 RVA: 0x001DB98C File Offset: 0x001D9B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214611, XrefRangeEnd = 214629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A62 RID: 27234 RVA: 0x001DB9C8 File Offset: 0x001D9BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214629, XrefRangeEnd = 214670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A63 RID: 27235 RVA: 0x001DBA04 File Offset: 0x001D9C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214670, XrefRangeEnd = 214683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_CheckRotation_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A64 RID: 27236 RVA: 0x001DBA38 File Offset: 0x001D9C38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 214714, RefRangeEnd = 214715, XrefRangeStart = 214683, XrefRangeEnd = 214714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_ApplyRotation_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A65 RID: 27237 RVA: 0x001DBA6C File Offset: 0x001D9C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214715, XrefRangeEnd = 214796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CheckGridIntersections()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_CheckGridIntersections_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A66 RID: 27238 RVA: 0x001DBAA8 File Offset: 0x001D9CA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 214812, RefRangeEnd = 214813, XrefRangeStart = 214796, XrefRangeEnd = 214812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMaterials()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A67 RID: 27239 RVA: 0x001DBADC File Offset: 0x001D9CDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 214831, RefRangeEnd = 214833, XrefRangeStart = 214813, XrefRangeEnd = 214831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMatchValid(FootprintTile footprintTile, ProceduralTile matchedTile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(footprintTile);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(matchedTile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_IsMatchValid_Private_Boolean_FootprintTile_ProceduralTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006A68 RID: 27240 RVA: 0x001DBB3C File Offset: 0x001D9D3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 214876, RefRangeEnd = 214877, XrefRangeStart = 214833, XrefRangeEnd = 214876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Place()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_Place_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A69 RID: 27241 RVA: 0x001DBB70 File Offset: 0x001D9D70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214877, XrefRangeEnd = 214892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProceduralTile GetNearbyProcTile()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_GetNearbyProcTile_Private_ProceduralTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProceduralTile>(intPtr3) : null;
		}

		// Token: 0x06006A6A RID: 27242 RVA: 0x001DBBB0 File Offset: 0x001D9DB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214892, XrefRangeEnd = 214893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildUpdate_ProceduralGrid() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_ProceduralGrid.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A6B RID: 27243 RVA: 0x000323F1 File Offset: 0x000305F1
		public BuildUpdate_ProceduralGrid(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FEA RID: 8170
		// (get) Token: 0x06006A6C RID: 27244 RVA: 0x001DBBEC File Offset: 0x001D9DEC
		// (set) Token: 0x06006A6D RID: 27245 RVA: 0x000323FA File Offset: 0x000305FA
		public unsafe GameObject GhostModel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_GhostModel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_GhostModel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FEB RID: 8171
		// (get) Token: 0x06006A6E RID: 27246 RVA: 0x001DBC1C File Offset: 0x001D9E1C
		// (set) Token: 0x06006A6F RID: 27247 RVA: 0x00032419 File Offset: 0x00030619
		public unsafe ProceduralGridItem ItemClass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_ItemClass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProceduralGridItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_ItemClass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FEC RID: 8172
		// (get) Token: 0x06006A70 RID: 27248 RVA: 0x001DBC4C File Offset: 0x001D9E4C
		// (set) Token: 0x06006A71 RID: 27249 RVA: 0x00032438 File Offset: 0x00030638
		public unsafe ItemInstance ItemInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_ItemInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_ItemInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FED RID: 8173
		// (get) Token: 0x06006A72 RID: 27250 RVA: 0x001DBC7C File Offset: 0x001D9E7C
		// (set) Token: 0x06006A73 RID: 27251 RVA: 0x00032457 File Offset: 0x00030657
		public unsafe float detectionRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_detectionRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_detectionRange)) = value;
			}
		}

		// Token: 0x17001FEE RID: 8174
		// (get) Token: 0x06006A74 RID: 27252 RVA: 0x001DBCA4 File Offset: 0x001D9EA4
		// (set) Token: 0x06006A75 RID: 27253 RVA: 0x00032472 File Offset: 0x00030672
		public unsafe LayerMask detectionMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_detectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_detectionMask)) = value;
			}
		}

		// Token: 0x17001FEF RID: 8175
		// (get) Token: 0x06006A76 RID: 27254 RVA: 0x001DBCCC File Offset: 0x001D9ECC
		// (set) Token: 0x06006A77 RID: 27255 RVA: 0x0003248D File Offset: 0x0003068D
		public unsafe float rotation_Smoothing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_rotation_Smoothing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_rotation_Smoothing)) = value;
			}
		}

		// Token: 0x17001FF0 RID: 8176
		// (get) Token: 0x06006A78 RID: 27256 RVA: 0x001DBCF4 File Offset: 0x001D9EF4
		// (set) Token: 0x06006A79 RID: 27257 RVA: 0x000324A8 File Offset: 0x000306A8
		public unsafe float currentRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_currentRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_currentRotation)) = value;
			}
		}

		// Token: 0x17001FF1 RID: 8177
		// (get) Token: 0x06006A7A RID: 27258 RVA: 0x001DBD1C File Offset: 0x001D9F1C
		// (set) Token: 0x06006A7B RID: 27259 RVA: 0x000324C3 File Offset: 0x000306C3
		public unsafe bool validPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_validPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_validPosition)) = value;
			}
		}

		// Token: 0x17001FF2 RID: 8178
		// (get) Token: 0x06006A7C RID: 27260 RVA: 0x001DBD44 File Offset: 0x001D9F44
		// (set) Token: 0x06006A7D RID: 27261 RVA: 0x000324DE File Offset: 0x000306DE
		public unsafe Material currentGhostMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_currentGhostMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_currentGhostMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FF3 RID: 8179
		// (get) Token: 0x06006A7E RID: 27262 RVA: 0x001DBD74 File Offset: 0x001D9F74
		// (set) Token: 0x06006A7F RID: 27263 RVA: 0x000324FD File Offset: 0x000306FD
		public unsafe BuildUpdate_ProceduralGrid.Intersection bestIntersection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_bestIntersection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuildUpdate_ProceduralGrid.Intersection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_bestIntersection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040048D5 RID: 18645
		private static readonly IntPtr NativeFieldInfoPtr_GhostModel;

		// Token: 0x040048D6 RID: 18646
		private static readonly IntPtr NativeFieldInfoPtr_ItemClass;

		// Token: 0x040048D7 RID: 18647
		private static readonly IntPtr NativeFieldInfoPtr_ItemInstance;

		// Token: 0x040048D8 RID: 18648
		private static readonly IntPtr NativeFieldInfoPtr_detectionRange;

		// Token: 0x040048D9 RID: 18649
		private static readonly IntPtr NativeFieldInfoPtr_detectionMask;

		// Token: 0x040048DA RID: 18650
		private static readonly IntPtr NativeFieldInfoPtr_rotation_Smoothing;

		// Token: 0x040048DB RID: 18651
		private static readonly IntPtr NativeFieldInfoPtr_currentRotation;

		// Token: 0x040048DC RID: 18652
		private static readonly IntPtr NativeFieldInfoPtr_validPosition;

		// Token: 0x040048DD RID: 18653
		private static readonly IntPtr NativeFieldInfoPtr_currentGhostMaterial;

		// Token: 0x040048DE RID: 18654
		private static readonly IntPtr NativeFieldInfoPtr_bestIntersection;

		// Token: 0x040048DF RID: 18655
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040048E0 RID: 18656
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x040048E1 RID: 18657
		private static readonly IntPtr NativeMethodInfoPtr_CheckRotation_Protected_Void_0;

		// Token: 0x040048E2 RID: 18658
		private static readonly IntPtr NativeMethodInfoPtr_ApplyRotation_Protected_Void_0;

		// Token: 0x040048E3 RID: 18659
		private static readonly IntPtr NativeMethodInfoPtr_CheckGridIntersections_Protected_Virtual_New_Void_0;

		// Token: 0x040048E4 RID: 18660
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0;

		// Token: 0x040048E5 RID: 18661
		private static readonly IntPtr NativeMethodInfoPtr_IsMatchValid_Private_Boolean_FootprintTile_ProceduralTile_0;

		// Token: 0x040048E6 RID: 18662
		private static readonly IntPtr NativeMethodInfoPtr_Place_Protected_Void_0;

		// Token: 0x040048E7 RID: 18663
		private static readonly IntPtr NativeMethodInfoPtr_GetNearbyProcTile_Private_ProceduralTile_0;

		// Token: 0x040048E8 RID: 18664
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A55 RID: 2645
		public class Intersection : Il2CppSystem.Object
		{
			// Token: 0x0600D06B RID: 53355 RVA: 0x0031FF24 File Offset: 0x0031E124
			// Note: this type is marked as 'beforefieldinit'.
			static Intersection()
			{
				Il2CppClassPointerStore<BuildUpdate_ProceduralGrid.Intersection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, "Intersection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid.Intersection>.NativeClassPtr);
				BuildUpdate_ProceduralGrid.Intersection.NativeFieldInfoPtr_footprintTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid.Intersection>.NativeClassPtr, "footprintTile");
				BuildUpdate_ProceduralGrid.Intersection.NativeFieldInfoPtr_procTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid.Intersection>.NativeClassPtr, "procTile");
				BuildUpdate_ProceduralGrid.Intersection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid.Intersection>.NativeClassPtr, 100676810);
			}

			// Token: 0x0600D06C RID: 53356 RVA: 0x0031FF8C File Offset: 0x0031E18C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Intersection() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid.Intersection>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_ProceduralGrid.Intersection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D06D RID: 53357 RVA: 0x000656E2 File Offset: 0x000638E2
			public Intersection(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040BA RID: 16570
			// (get) Token: 0x0600D06E RID: 53358 RVA: 0x0031FFC8 File Offset: 0x0031E1C8
			// (set) Token: 0x0600D06F RID: 53359 RVA: 0x000656EB File Offset: 0x000638EB
			public unsafe FootprintTile footprintTile
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.Intersection.NativeFieldInfoPtr_footprintTile);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.Intersection.NativeFieldInfoPtr_footprintTile), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040BB RID: 16571
			// (get) Token: 0x0600D070 RID: 53360 RVA: 0x0031FFF8 File Offset: 0x0031E1F8
			// (set) Token: 0x0600D071 RID: 53361 RVA: 0x0006570A File Offset: 0x0006390A
			public unsafe ProceduralTile procTile
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.Intersection.NativeFieldInfoPtr_procTile);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProceduralTile>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.Intersection.NativeFieldInfoPtr_procTile), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008CA4 RID: 36004
			private static readonly IntPtr NativeFieldInfoPtr_footprintTile;

			// Token: 0x04008CA5 RID: 36005
			private static readonly IntPtr NativeFieldInfoPtr_procTile;

			// Token: 0x04008CA6 RID: 36006
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
