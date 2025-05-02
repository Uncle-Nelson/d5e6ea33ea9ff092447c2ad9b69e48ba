using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Building;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x0200072E RID: 1838
	public class FloorRack : GridItem
	{
		// Token: 0x0600A6C6 RID: 42694 RVA: 0x0029B364 File Offset: 0x00299564
		// Note: this type is marked as 'beforefieldinit'.
		static FloorRack()
		{
			Il2CppClassPointerStore<FloorRack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "FloorRack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloorRack>.NativeClassPtr);
			FloorRack.NativeFieldInfoPtr_leg_BottomLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, "leg_BottomLeft");
			FloorRack.NativeFieldInfoPtr_leg_BottomRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, "leg_BottomRight");
			FloorRack.NativeFieldInfoPtr_leg_TopLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, "leg_TopLeft");
			FloorRack.NativeFieldInfoPtr_leg_TopRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, "leg_TopRight");
			FloorRack.NativeFieldInfoPtr_obs_BottomLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, "obs_BottomLeft");
			FloorRack.NativeFieldInfoPtr_obs_BottomRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, "obs_BottomRight");
			FloorRack.NativeFieldInfoPtr_obs_TopLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, "obs_TopLeft");
			FloorRack.NativeFieldInfoPtr_obs_TopRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, "obs_TopRight");
			FloorRack.NativeFieldInfoPtr_procTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, "procTiles");
			FloorRack.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ObjectScripts.FloorRackAssembly-CSharp.dll_Excuted");
			FloorRack.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ObjectScripts.FloorRackAssembly-CSharp.dll_Excuted");
			FloorRack.NativeMethodInfoPtr_get_ProceduralTiles_Public_Virtual_Final_New_get_List_1_ProceduralTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100683711);
			FloorRack.NativeMethodInfoPtr_UpdateLegVisibility_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100683712);
			FloorRack.NativeMethodInfoPtr_CockAndBalls_Protected_Void_GameObject_CornerObstacle_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100683713);
			FloorRack.NativeMethodInfoPtr_GetFloorRackFromOccupants_Private_FloorRack_List_1_GridItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100683714);
			FloorRack.NativeMethodInfoPtr_GetSurroundingRacks_Public_List_1_FloorRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100683715);
			FloorRack.NativeMethodInfoPtr_CanShareTileWith_Public_Virtual_Boolean_List_1_GridItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100683716);
			FloorRack.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100683717);
			FloorRack.NativeMethodInfoPtr_DestroyItem_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100683718);
			FloorRack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100683719);
			FloorRack.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100683720);
			FloorRack.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100683721);
			FloorRack.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100683722);
			FloorRack.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100683723);
		}

		// Token: 0x1700337E RID: 13182
		// (get) Token: 0x0600A6C7 RID: 42695 RVA: 0x0029B574 File Offset: 0x00299774
		public unsafe virtual List<ProceduralTile> ProceduralTiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloorRack.NativeMethodInfoPtr_get_ProceduralTiles_Public_Virtual_Final_New_get_List_1_ProceduralTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ProceduralTile>>(intPtr3) : null;
			}
		}

		// Token: 0x0600A6C8 RID: 42696 RVA: 0x0029B5B4 File Offset: 0x002997B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291099, XrefRangeEnd = 291107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateLegVisibility()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FloorRack.NativeMethodInfoPtr_UpdateLegVisibility_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6C9 RID: 42697 RVA: 0x0029B5F0 File Offset: 0x002997F0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 291190, RefRangeEnd = 291194, XrefRangeStart = 291107, XrefRangeEnd = 291190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CockAndBalls(GameObject leg, CornerObstacle obs, int xOffset, int yOffset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(leg);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xOffset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloorRack.NativeMethodInfoPtr_CockAndBalls_Protected_Void_GameObject_CornerObstacle_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6CA RID: 42698 RVA: 0x0029B660 File Offset: 0x00299860
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 291205, RefRangeEnd = 291213, XrefRangeStart = 291194, XrefRangeEnd = 291205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FloorRack GetFloorRackFromOccupants(List<GridItem> occs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(occs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloorRack.NativeMethodInfoPtr_GetFloorRackFromOccupants_Private_FloorRack_List_1_GridItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FloorRack>(intPtr3) : null;
		}

		// Token: 0x0600A6CB RID: 42699 RVA: 0x0029B6B0 File Offset: 0x002998B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291213, XrefRangeEnd = 291243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<FloorRack> GetSurroundingRacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloorRack.NativeMethodInfoPtr_GetSurroundingRacks_Public_List_1_FloorRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<FloorRack>>(intPtr3) : null;
		}

		// Token: 0x0600A6CC RID: 42700 RVA: 0x0029B6F0 File Offset: 0x002998F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291243, XrefRangeEnd = 291250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanShareTileWith(List<GridItem> obstacles)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obstacles);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FloorRack.NativeMethodInfoPtr_CanShareTileWith_Public_Virtual_Boolean_List_1_GridItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A6CD RID: 42701 RVA: 0x0029B748 File Offset: 0x00299948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291250, XrefRangeEnd = 291270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanBeDestroyed(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FloorRack.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600A6CE RID: 42702 RVA: 0x0029B7AC File Offset: 0x002999AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291270, XrefRangeEnd = 291282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DestroyItem(bool callOnServer = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref callOnServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FloorRack.NativeMethodInfoPtr_DestroyItem_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6CF RID: 42703 RVA: 0x0029B7F8 File Offset: 0x002999F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291282, XrefRangeEnd = 291283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FloorRack() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloorRack>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloorRack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6D0 RID: 42704 RVA: 0x0029B834 File Offset: 0x00299A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291283, XrefRangeEnd = 291284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FloorRack.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6D1 RID: 42705 RVA: 0x0029B870 File Offset: 0x00299A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291284, XrefRangeEnd = 291285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FloorRack.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6D2 RID: 42706 RVA: 0x0029B8AC File Offset: 0x00299AAC
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FloorRack.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6D3 RID: 42707 RVA: 0x0029B8E8 File Offset: 0x00299AE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 291098, RefRangeEnd = 291099, XrefRangeStart = 291098, XrefRangeEnd = 291099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FloorRack.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6D4 RID: 42708 RVA: 0x00052294 File Offset: 0x00050494
		public FloorRack(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003373 RID: 13171
		// (get) Token: 0x0600A6D5 RID: 42709 RVA: 0x0029B924 File Offset: 0x00299B24
		// (set) Token: 0x0600A6D6 RID: 42710 RVA: 0x0005229D File Offset: 0x0005049D
		public unsafe Transform leg_BottomLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_leg_BottomLeft);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_leg_BottomLeft), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003374 RID: 13172
		// (get) Token: 0x0600A6D7 RID: 42711 RVA: 0x0029B954 File Offset: 0x00299B54
		// (set) Token: 0x0600A6D8 RID: 42712 RVA: 0x000522BC File Offset: 0x000504BC
		public unsafe Transform leg_BottomRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_leg_BottomRight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_leg_BottomRight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003375 RID: 13173
		// (get) Token: 0x0600A6D9 RID: 42713 RVA: 0x0029B984 File Offset: 0x00299B84
		// (set) Token: 0x0600A6DA RID: 42714 RVA: 0x000522DB File Offset: 0x000504DB
		public unsafe Transform leg_TopLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_leg_TopLeft);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_leg_TopLeft), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003376 RID: 13174
		// (get) Token: 0x0600A6DB RID: 42715 RVA: 0x0029B9B4 File Offset: 0x00299BB4
		// (set) Token: 0x0600A6DC RID: 42716 RVA: 0x000522FA File Offset: 0x000504FA
		public unsafe Transform leg_TopRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_leg_TopRight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_leg_TopRight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003377 RID: 13175
		// (get) Token: 0x0600A6DD RID: 42717 RVA: 0x0029B9E4 File Offset: 0x00299BE4
		// (set) Token: 0x0600A6DE RID: 42718 RVA: 0x00052319 File Offset: 0x00050519
		public unsafe CornerObstacle obs_BottomLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_obs_BottomLeft);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CornerObstacle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_obs_BottomLeft), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003378 RID: 13176
		// (get) Token: 0x0600A6DF RID: 42719 RVA: 0x0029BA14 File Offset: 0x00299C14
		// (set) Token: 0x0600A6E0 RID: 42720 RVA: 0x00052338 File Offset: 0x00050538
		public unsafe CornerObstacle obs_BottomRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_obs_BottomRight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CornerObstacle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_obs_BottomRight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003379 RID: 13177
		// (get) Token: 0x0600A6E1 RID: 42721 RVA: 0x0029BA44 File Offset: 0x00299C44
		// (set) Token: 0x0600A6E2 RID: 42722 RVA: 0x00052357 File Offset: 0x00050557
		public unsafe CornerObstacle obs_TopLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_obs_TopLeft);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CornerObstacle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_obs_TopLeft), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700337A RID: 13178
		// (get) Token: 0x0600A6E3 RID: 42723 RVA: 0x0029BA74 File Offset: 0x00299C74
		// (set) Token: 0x0600A6E4 RID: 42724 RVA: 0x00052376 File Offset: 0x00050576
		public unsafe CornerObstacle obs_TopRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_obs_TopRight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CornerObstacle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_obs_TopRight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700337B RID: 13179
		// (get) Token: 0x0600A6E5 RID: 42725 RVA: 0x0029BAA4 File Offset: 0x00299CA4
		// (set) Token: 0x0600A6E6 RID: 42726 RVA: 0x00052395 File Offset: 0x00050595
		public unsafe List<ProceduralTile> procTiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_procTiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProceduralTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_procTiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700337C RID: 13180
		// (get) Token: 0x0600A6E7 RID: 42727 RVA: 0x0029BAD4 File Offset: 0x00299CD4
		// (set) Token: 0x0600A6E8 RID: 42728 RVA: 0x000523B4 File Offset: 0x000505B4
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700337D RID: 13181
		// (get) Token: 0x0600A6E9 RID: 42729 RVA: 0x0029BAFC File Offset: 0x00299CFC
		// (set) Token: 0x0600A6EA RID: 42730 RVA: 0x000523CF File Offset: 0x000505CF
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04006FDC RID: 28636
		private static readonly IntPtr NativeFieldInfoPtr_leg_BottomLeft;

		// Token: 0x04006FDD RID: 28637
		private static readonly IntPtr NativeFieldInfoPtr_leg_BottomRight;

		// Token: 0x04006FDE RID: 28638
		private static readonly IntPtr NativeFieldInfoPtr_leg_TopLeft;

		// Token: 0x04006FDF RID: 28639
		private static readonly IntPtr NativeFieldInfoPtr_leg_TopRight;

		// Token: 0x04006FE0 RID: 28640
		private static readonly IntPtr NativeFieldInfoPtr_obs_BottomLeft;

		// Token: 0x04006FE1 RID: 28641
		private static readonly IntPtr NativeFieldInfoPtr_obs_BottomRight;

		// Token: 0x04006FE2 RID: 28642
		private static readonly IntPtr NativeFieldInfoPtr_obs_TopLeft;

		// Token: 0x04006FE3 RID: 28643
		private static readonly IntPtr NativeFieldInfoPtr_obs_TopRight;

		// Token: 0x04006FE4 RID: 28644
		private static readonly IntPtr NativeFieldInfoPtr_procTiles;

		// Token: 0x04006FE5 RID: 28645
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04006FE6 RID: 28646
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04006FE7 RID: 28647
		private static readonly IntPtr NativeMethodInfoPtr_get_ProceduralTiles_Public_Virtual_Final_New_get_List_1_ProceduralTile_0;

		// Token: 0x04006FE8 RID: 28648
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLegVisibility_Public_Virtual_New_Void_0;

		// Token: 0x04006FE9 RID: 28649
		private static readonly IntPtr NativeMethodInfoPtr_CockAndBalls_Protected_Void_GameObject_CornerObstacle_Int32_Int32_0;

		// Token: 0x04006FEA RID: 28650
		private static readonly IntPtr NativeMethodInfoPtr_GetFloorRackFromOccupants_Private_FloorRack_List_1_GridItem_0;

		// Token: 0x04006FEB RID: 28651
		private static readonly IntPtr NativeMethodInfoPtr_GetSurroundingRacks_Public_List_1_FloorRack_0;

		// Token: 0x04006FEC RID: 28652
		private static readonly IntPtr NativeMethodInfoPtr_CanShareTileWith_Public_Virtual_Boolean_List_1_GridItem_0;

		// Token: 0x04006FED RID: 28653
		private static readonly IntPtr NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0;

		// Token: 0x04006FEE RID: 28654
		private static readonly IntPtr NativeMethodInfoPtr_DestroyItem_Public_Virtual_Void_Boolean_0;

		// Token: 0x04006FEF RID: 28655
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006FF0 RID: 28656
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04006FF1 RID: 28657
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04006FF2 RID: 28658
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04006FF3 RID: 28659
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
