using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x020004BE RID: 1214
	public class BuildUpdate_Grid : BuildUpdate_Base
	{
		// Token: 0x06006A39 RID: 27193 RVA: 0x001DB074 File Offset: 0x001D9274
		// Note: this type is marked as 'beforefieldinit'.
		static BuildUpdate_Grid()
		{
			Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "BuildUpdate_Grid");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr);
			BuildUpdate_Grid.NativeFieldInfoPtr_GhostModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "GhostModel");
			BuildUpdate_Grid.NativeFieldInfoPtr_BuildableItemClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "BuildableItemClass");
			BuildUpdate_Grid.NativeFieldInfoPtr_ItemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "ItemInstance");
			BuildUpdate_Grid.NativeFieldInfoPtr_CurrentRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "CurrentRotation");
			BuildUpdate_Grid.NativeFieldInfoPtr_detectionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "detectionRange");
			BuildUpdate_Grid.NativeFieldInfoPtr_detectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "detectionMask");
			BuildUpdate_Grid.NativeFieldInfoPtr_rotation_Smoothing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "rotation_Smoothing");
			BuildUpdate_Grid.NativeFieldInfoPtr_AllowRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "AllowRotation");
			BuildUpdate_Grid.NativeFieldInfoPtr_validPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "validPosition");
			BuildUpdate_Grid.NativeFieldInfoPtr_currentGhostMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "currentGhostMaterial");
			BuildUpdate_Grid.NativeFieldInfoPtr_closestIntersection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "closestIntersection");
			BuildUpdate_Grid.NativeFieldInfoPtr_verticalOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "verticalOffset");
			BuildUpdate_Grid.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676787);
			BuildUpdate_Grid.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676788);
			BuildUpdate_Grid.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676789);
			BuildUpdate_Grid.NativeMethodInfoPtr_PositionObjectInFrontOfPlayer_Protected_Void_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676790);
			BuildUpdate_Grid.NativeMethodInfoPtr_CheckRotation_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676791);
			BuildUpdate_Grid.NativeMethodInfoPtr_ApplyRotation_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676792);
			BuildUpdate_Grid.NativeMethodInfoPtr_GetRelevantIntersections_Private_List_1_TileIntersection_FootprintTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676793);
			BuildUpdate_Grid.NativeMethodInfoPtr_CheckIntersections_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676794);
			BuildUpdate_Grid.NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676795);
			BuildUpdate_Grid.NativeMethodInfoPtr_Place_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676796);
			BuildUpdate_Grid.NativeMethodInfoPtr_GetOriginCoordinate_Private_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676797);
			BuildUpdate_Grid.NativeMethodInfoPtr_GetHoveredGrid_Private_Grid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676798);
			BuildUpdate_Grid.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676799);
		}

		// Token: 0x06006A3A RID: 27194 RVA: 0x001DB298 File Offset: 0x001D9498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214129, XrefRangeEnd = 214161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Grid.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A3B RID: 27195 RVA: 0x001DB2D4 File Offset: 0x001D94D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214161, XrefRangeEnd = 214179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Grid.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A3C RID: 27196 RVA: 0x001DB310 File Offset: 0x001D9510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214179, XrefRangeEnd = 214289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Grid.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A3D RID: 27197 RVA: 0x001DB34C File Offset: 0x001D954C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 214318, RefRangeEnd = 214319, XrefRangeStart = 214289, XrefRangeEnd = 214318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PositionObjectInFrontOfPlayer(float dist, bool sanitizeForward, bool buildPointAsOrigin)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dist;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sanitizeForward;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buildPointAsOrigin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Grid.NativeMethodInfoPtr_PositionObjectInFrontOfPlayer_Protected_Void_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A3E RID: 27198 RVA: 0x001DB3A8 File Offset: 0x001D95A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214319, XrefRangeEnd = 214332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Grid.NativeMethodInfoPtr_CheckRotation_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A3F RID: 27199 RVA: 0x001DB3DC File Offset: 0x001D95DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 214363, RefRangeEnd = 214365, XrefRangeStart = 214332, XrefRangeEnd = 214363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Grid.NativeMethodInfoPtr_ApplyRotation_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A40 RID: 27200 RVA: 0x001DB410 File Offset: 0x001D9610
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 214395, RefRangeEnd = 214398, XrefRangeStart = 214365, XrefRangeEnd = 214395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<TileIntersection> GetRelevantIntersections(FootprintTile tile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Grid.NativeMethodInfoPtr_GetRelevantIntersections_Private_List_1_TileIntersection_FootprintTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TileIntersection>>(intPtr3) : null;
		}

		// Token: 0x06006A41 RID: 27201 RVA: 0x001DB460 File Offset: 0x001D9660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214398, XrefRangeEnd = 214536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CheckIntersections()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Grid.NativeMethodInfoPtr_CheckIntersections_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A42 RID: 27202 RVA: 0x001DB49C File Offset: 0x001D969C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 214552, RefRangeEnd = 214553, XrefRangeStart = 214536, XrefRangeEnd = 214552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMaterials()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Grid.NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A43 RID: 27203 RVA: 0x001DB4D0 File Offset: 0x001D96D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214553, XrefRangeEnd = 214589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Place()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Grid.NativeMethodInfoPtr_Place_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A44 RID: 27204 RVA: 0x001DB50C File Offset: 0x001D970C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214589, XrefRangeEnd = 214595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetOriginCoordinate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Grid.NativeMethodInfoPtr_GetOriginCoordinate_Private_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006A45 RID: 27205 RVA: 0x001DB548 File Offset: 0x001D9748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214595, XrefRangeEnd = 214610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Grid GetHoveredGrid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Grid.NativeMethodInfoPtr_GetHoveredGrid_Private_Grid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Grid>(intPtr3) : null;
		}

		// Token: 0x06006A46 RID: 27206 RVA: 0x001DB588 File Offset: 0x001D9788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214610, XrefRangeEnd = 214611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildUpdate_Grid() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Grid.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A47 RID: 27207 RVA: 0x00032290 File Offset: 0x00030490
		public BuildUpdate_Grid(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FDE RID: 8158
		// (get) Token: 0x06006A48 RID: 27208 RVA: 0x001DB5C4 File Offset: 0x001D97C4
		// (set) Token: 0x06006A49 RID: 27209 RVA: 0x00032299 File Offset: 0x00030499
		public unsafe GameObject GhostModel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_GhostModel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_GhostModel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FDF RID: 8159
		// (get) Token: 0x06006A4A RID: 27210 RVA: 0x001DB5F4 File Offset: 0x001D97F4
		// (set) Token: 0x06006A4B RID: 27211 RVA: 0x000322B8 File Offset: 0x000304B8
		public unsafe GridItem BuildableItemClass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_BuildableItemClass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_BuildableItemClass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FE0 RID: 8160
		// (get) Token: 0x06006A4C RID: 27212 RVA: 0x001DB624 File Offset: 0x001D9824
		// (set) Token: 0x06006A4D RID: 27213 RVA: 0x000322D7 File Offset: 0x000304D7
		public unsafe ItemInstance ItemInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_ItemInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_ItemInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FE1 RID: 8161
		// (get) Token: 0x06006A4E RID: 27214 RVA: 0x001DB654 File Offset: 0x001D9854
		// (set) Token: 0x06006A4F RID: 27215 RVA: 0x000322F6 File Offset: 0x000304F6
		public unsafe float CurrentRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_CurrentRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_CurrentRotation)) = value;
			}
		}

		// Token: 0x17001FE2 RID: 8162
		// (get) Token: 0x06006A50 RID: 27216 RVA: 0x001DB67C File Offset: 0x001D987C
		// (set) Token: 0x06006A51 RID: 27217 RVA: 0x00032311 File Offset: 0x00030511
		public unsafe float detectionRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_detectionRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_detectionRange)) = value;
			}
		}

		// Token: 0x17001FE3 RID: 8163
		// (get) Token: 0x06006A52 RID: 27218 RVA: 0x001DB6A4 File Offset: 0x001D98A4
		// (set) Token: 0x06006A53 RID: 27219 RVA: 0x0003232C File Offset: 0x0003052C
		public unsafe LayerMask detectionMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_detectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_detectionMask)) = value;
			}
		}

		// Token: 0x17001FE4 RID: 8164
		// (get) Token: 0x06006A54 RID: 27220 RVA: 0x001DB6CC File Offset: 0x001D98CC
		// (set) Token: 0x06006A55 RID: 27221 RVA: 0x00032347 File Offset: 0x00030547
		public unsafe float rotation_Smoothing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_rotation_Smoothing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_rotation_Smoothing)) = value;
			}
		}

		// Token: 0x17001FE5 RID: 8165
		// (get) Token: 0x06006A56 RID: 27222 RVA: 0x001DB6F4 File Offset: 0x001D98F4
		// (set) Token: 0x06006A57 RID: 27223 RVA: 0x00032362 File Offset: 0x00030562
		public unsafe bool AllowRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_AllowRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_AllowRotation)) = value;
			}
		}

		// Token: 0x17001FE6 RID: 8166
		// (get) Token: 0x06006A58 RID: 27224 RVA: 0x001DB71C File Offset: 0x001D991C
		// (set) Token: 0x06006A59 RID: 27225 RVA: 0x0003237D File Offset: 0x0003057D
		public unsafe bool validPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_validPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_validPosition)) = value;
			}
		}

		// Token: 0x17001FE7 RID: 8167
		// (get) Token: 0x06006A5A RID: 27226 RVA: 0x001DB744 File Offset: 0x001D9944
		// (set) Token: 0x06006A5B RID: 27227 RVA: 0x00032398 File Offset: 0x00030598
		public unsafe Material currentGhostMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_currentGhostMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_currentGhostMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FE8 RID: 8168
		// (get) Token: 0x06006A5C RID: 27228 RVA: 0x001DB774 File Offset: 0x001D9974
		// (set) Token: 0x06006A5D RID: 27229 RVA: 0x000323B7 File Offset: 0x000305B7
		public unsafe TileIntersection closestIntersection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_closestIntersection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TileIntersection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_closestIntersection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FE9 RID: 8169
		// (get) Token: 0x06006A5E RID: 27230 RVA: 0x001DB7A4 File Offset: 0x001D99A4
		// (set) Token: 0x06006A5F RID: 27231 RVA: 0x000323D6 File Offset: 0x000305D6
		public unsafe float verticalOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_verticalOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_verticalOffset)) = value;
			}
		}

		// Token: 0x040048BC RID: 18620
		private static readonly IntPtr NativeFieldInfoPtr_GhostModel;

		// Token: 0x040048BD RID: 18621
		private static readonly IntPtr NativeFieldInfoPtr_BuildableItemClass;

		// Token: 0x040048BE RID: 18622
		private static readonly IntPtr NativeFieldInfoPtr_ItemInstance;

		// Token: 0x040048BF RID: 18623
		private static readonly IntPtr NativeFieldInfoPtr_CurrentRotation;

		// Token: 0x040048C0 RID: 18624
		private static readonly IntPtr NativeFieldInfoPtr_detectionRange;

		// Token: 0x040048C1 RID: 18625
		private static readonly IntPtr NativeFieldInfoPtr_detectionMask;

		// Token: 0x040048C2 RID: 18626
		private static readonly IntPtr NativeFieldInfoPtr_rotation_Smoothing;

		// Token: 0x040048C3 RID: 18627
		private static readonly IntPtr NativeFieldInfoPtr_AllowRotation;

		// Token: 0x040048C4 RID: 18628
		private static readonly IntPtr NativeFieldInfoPtr_validPosition;

		// Token: 0x040048C5 RID: 18629
		private static readonly IntPtr NativeFieldInfoPtr_currentGhostMaterial;

		// Token: 0x040048C6 RID: 18630
		private static readonly IntPtr NativeFieldInfoPtr_closestIntersection;

		// Token: 0x040048C7 RID: 18631
		private static readonly IntPtr NativeFieldInfoPtr_verticalOffset;

		// Token: 0x040048C8 RID: 18632
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x040048C9 RID: 18633
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040048CA RID: 18634
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x040048CB RID: 18635
		private static readonly IntPtr NativeMethodInfoPtr_PositionObjectInFrontOfPlayer_Protected_Void_Single_Boolean_Boolean_0;

		// Token: 0x040048CC RID: 18636
		private static readonly IntPtr NativeMethodInfoPtr_CheckRotation_Protected_Void_0;

		// Token: 0x040048CD RID: 18637
		private static readonly IntPtr NativeMethodInfoPtr_ApplyRotation_Protected_Void_0;

		// Token: 0x040048CE RID: 18638
		private static readonly IntPtr NativeMethodInfoPtr_GetRelevantIntersections_Private_List_1_TileIntersection_FootprintTile_0;

		// Token: 0x040048CF RID: 18639
		private static readonly IntPtr NativeMethodInfoPtr_CheckIntersections_Protected_Virtual_New_Void_0;

		// Token: 0x040048D0 RID: 18640
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0;

		// Token: 0x040048D1 RID: 18641
		private static readonly IntPtr NativeMethodInfoPtr_Place_Protected_Virtual_New_Void_0;

		// Token: 0x040048D2 RID: 18642
		private static readonly IntPtr NativeMethodInfoPtr_GetOriginCoordinate_Private_Vector2_0;

		// Token: 0x040048D3 RID: 18643
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredGrid_Private_Grid_0;

		// Token: 0x040048D4 RID: 18644
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
