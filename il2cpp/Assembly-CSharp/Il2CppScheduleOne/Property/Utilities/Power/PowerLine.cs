using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ConstructableScripts;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Property.Utilities.Power
{
	// Token: 0x02000518 RID: 1304
	public class PowerLine : Constructable
	{
		// Token: 0x06007415 RID: 29717 RVA: 0x001FA68C File Offset: 0x001F888C
		// Note: this type is marked as 'beforefieldinit'.
		static PowerLine()
		{
			Il2CppClassPointerStore<PowerLine>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property.Utilities.Power", "PowerLine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PowerLine>.NativeClassPtr);
			PowerLine.NativeFieldInfoPtr_powerLine_MinSegments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, "powerLine_MinSegments");
			PowerLine.NativeFieldInfoPtr_powerLine_MaxSegments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, "powerLine_MaxSegments");
			PowerLine.NativeFieldInfoPtr_maxLineLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, "maxLineLength");
			PowerLine.NativeFieldInfoPtr_updateThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, "updateThreshold");
			PowerLine.NativeFieldInfoPtr_nodeA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, "nodeA");
			PowerLine.NativeFieldInfoPtr_nodeB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, "nodeB");
			PowerLine.NativeFieldInfoPtr_LengthFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, "LengthFactor");
			PowerLine.NativeFieldInfoPtr_segments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, "segments");
			PowerLine.NativeFieldInfoPtr_nodeA_LastUpdatePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, "nodeA_LastUpdatePos");
			PowerLine.NativeFieldInfoPtr_nodeB_LastUpdatePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, "nodeB_LastUpdatePos");
			PowerLine.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Property.Utilities.Power.PowerLineAssembly-CSharp.dll_Excuted");
			PowerLine.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Property.Utilities.Power.PowerLineAssembly-CSharp.dll_Excuted");
			PowerLine.NativeMethodInfoPtr_InitializePowerLine_Public_Void_PowerNode_PowerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100677895);
			PowerLine.NativeMethodInfoPtr_DestroyConstructable_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100677896);
			PowerLine.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100677897);
			PowerLine.NativeMethodInfoPtr_RefreshVisuals_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100677898);
			PowerLine.NativeMethodInfoPtr_RefreshBoundingBox_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100677899);
			PowerLine.NativeMethodInfoPtr_GetOtherNode_Public_PowerNode_PowerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100677900);
			PowerLine.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100677901);
			PowerLine.NativeMethodInfoPtr_GetCosmeticCenter_Public_Virtual_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100677902);
			PowerLine.NativeMethodInfoPtr_CanNodesBeConnected_Public_Static_Boolean_PowerNode_PowerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100677903);
			PowerLine.NativeMethodInfoPtr_GetSegmentCount_Public_Static_Int32_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100677904);
			PowerLine.NativeMethodInfoPtr_DrawPowerLine_Public_Static_Void_Vector3_Vector3_List_1_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100677905);
			PowerLine.NativeMethodInfoPtr_PositionSegments_Private_Static_Void_List_1_Vector3_List_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100677906);
			PowerLine.NativeMethodInfoPtr_GetCatenaryPoints_Private_Static_List_1_Vector3_Vector3_Vector3_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100677907);
			PowerLine.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100677908);
			PowerLine.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100677910);
			PowerLine.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100677911);
			PowerLine.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100677912);
			PowerLine.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100677913);
		}

		// Token: 0x06007416 RID: 29718 RVA: 0x001FA914 File Offset: 0x001F8B14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 227069, RefRangeEnd = 227070, XrefRangeStart = 227030, XrefRangeEnd = 227069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializePowerLine(PowerNode a, PowerNode b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerLine.NativeMethodInfoPtr_InitializePowerLine_Public_Void_PowerNode_PowerNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007417 RID: 29719 RVA: 0x001FA968 File Offset: 0x001F8B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227070, XrefRangeEnd = 227092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DestroyConstructable(bool callOnServer = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref callOnServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PowerLine.NativeMethodInfoPtr_DestroyConstructable_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007418 RID: 29720 RVA: 0x001FA9B4 File Offset: 0x001F8BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227092, XrefRangeEnd = 227134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PowerLine.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007419 RID: 29721 RVA: 0x001FA9F0 File Offset: 0x001F8BF0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 227185, RefRangeEnd = 227188, XrefRangeStart = 227134, XrefRangeEnd = 227185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerLine.NativeMethodInfoPtr_RefreshVisuals_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600741A RID: 29722 RVA: 0x001FAA24 File Offset: 0x001F8C24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 227208, RefRangeEnd = 227209, XrefRangeStart = 227188, XrefRangeEnd = 227208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshBoundingBox()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerLine.NativeMethodInfoPtr_RefreshBoundingBox_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600741B RID: 29723 RVA: 0x001FAA58 File Offset: 0x001F8C58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 227216, RefRangeEnd = 227218, XrefRangeStart = 227209, XrefRangeEnd = 227216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PowerNode GetOtherNode(PowerNode firstNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(firstNode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerLine.NativeMethodInfoPtr_GetOtherNode_Public_PowerNode_PowerNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PowerNode>(intPtr3) : null;
		}

		// Token: 0x0600741C RID: 29724 RVA: 0x001FAAA8 File Offset: 0x001F8CA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 227225, RefRangeEnd = 227227, XrefRangeStart = 227218, XrefRangeEnd = 227225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible(bool v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerLine.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600741D RID: 29725 RVA: 0x001FAAE8 File Offset: 0x001F8CE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227227, XrefRangeEnd = 227231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Vector3 GetCosmeticCenter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PowerLine.NativeMethodInfoPtr_GetCosmeticCenter_Public_Virtual_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600741E RID: 29726 RVA: 0x001FAB30 File Offset: 0x001F8D30
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 227268, RefRangeEnd = 227275, XrefRangeStart = 227231, XrefRangeEnd = 227268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanNodesBeConnected(PowerNode nodeA, PowerNode nodeB)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(nodeA);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nodeB);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerLine.NativeMethodInfoPtr_CanNodesBeConnected_Public_Static_Boolean_PowerNode_PowerNode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600741F RID: 29727 RVA: 0x001FAB84 File Offset: 0x001F8D84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 227285, RefRangeEnd = 227287, XrefRangeStart = 227275, XrefRangeEnd = 227285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetSegmentCount(Vector3 startPoint, Vector3 endPoint)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref startPoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerLine.NativeMethodInfoPtr_GetSegmentCount_Public_Static_Int32_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007420 RID: 29728 RVA: 0x001FABD0 File Offset: 0x001F8DD0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 227294, RefRangeEnd = 227298, XrefRangeStart = 227287, XrefRangeEnd = 227294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawPowerLine(Vector3 startPoint, Vector3 endPoint, List<Transform> segments, float lengthFactor)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref startPoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endPoint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(segments);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lengthFactor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerLine.NativeMethodInfoPtr_DrawPowerLine_Public_Static_Void_Vector3_Vector3_List_1_Transform_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007421 RID: 29729 RVA: 0x001FAC30 File Offset: 0x001F8E30
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 227336, RefRangeEnd = 227339, XrefRangeStart = 227298, XrefRangeEnd = 227336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PositionSegments(List<Vector3> points, List<Transform> segments)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(points);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(segments);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerLine.NativeMethodInfoPtr_PositionSegments_Private_Static_Void_List_1_Vector3_List_1_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007422 RID: 29730 RVA: 0x001FAC78 File Offset: 0x001F8E78
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 227412, RefRangeEnd = 227415, XrefRangeStart = 227339, XrefRangeEnd = 227412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Vector3> GetCatenaryPoints(Vector3 startPoint, Vector3 endPoint, int pointCount, float l)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref startPoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endPoint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref l;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerLine.NativeMethodInfoPtr_GetCatenaryPoints_Private_Static_List_1_Vector3_Vector3_Vector3_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06007423 RID: 29731 RVA: 0x001FACE4 File Offset: 0x001F8EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227415, XrefRangeEnd = 227427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PowerLine() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PowerLine>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerLine.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007424 RID: 29732 RVA: 0x001FAD20 File Offset: 0x001F8F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227427, XrefRangeEnd = 227428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PowerLine.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007425 RID: 29733 RVA: 0x001FAD5C File Offset: 0x001F8F5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227428, XrefRangeEnd = 227429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PowerLine.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007426 RID: 29734 RVA: 0x001FAD98 File Offset: 0x001F8F98
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PowerLine.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007427 RID: 29735 RVA: 0x001FADD4 File Offset: 0x001F8FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227429, XrefRangeEnd = 227430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PowerLine.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007428 RID: 29736 RVA: 0x00037261 File Offset: 0x00035461
		public PowerLine(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002330 RID: 9008
		// (get) Token: 0x06007429 RID: 29737 RVA: 0x001FAE10 File Offset: 0x001F9010
		// (set) Token: 0x0600742A RID: 29738 RVA: 0x0003726A File Offset: 0x0003546A
		public unsafe static int powerLine_MinSegments
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PowerLine.NativeFieldInfoPtr_powerLine_MinSegments, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PowerLine.NativeFieldInfoPtr_powerLine_MinSegments, (void*)(&value));
			}
		}

		// Token: 0x17002331 RID: 9009
		// (get) Token: 0x0600742B RID: 29739 RVA: 0x001FAE2C File Offset: 0x001F902C
		// (set) Token: 0x0600742C RID: 29740 RVA: 0x00037278 File Offset: 0x00035478
		public unsafe static int powerLine_MaxSegments
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PowerLine.NativeFieldInfoPtr_powerLine_MaxSegments, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PowerLine.NativeFieldInfoPtr_powerLine_MaxSegments, (void*)(&value));
			}
		}

		// Token: 0x17002332 RID: 9010
		// (get) Token: 0x0600742D RID: 29741 RVA: 0x001FAE48 File Offset: 0x001F9048
		// (set) Token: 0x0600742E RID: 29742 RVA: 0x00037286 File Offset: 0x00035486
		public unsafe static float maxLineLength
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PowerLine.NativeFieldInfoPtr_maxLineLength, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PowerLine.NativeFieldInfoPtr_maxLineLength, (void*)(&value));
			}
		}

		// Token: 0x17002333 RID: 9011
		// (get) Token: 0x0600742F RID: 29743 RVA: 0x001FAE64 File Offset: 0x001F9064
		// (set) Token: 0x06007430 RID: 29744 RVA: 0x00037294 File Offset: 0x00035494
		public unsafe static float updateThreshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PowerLine.NativeFieldInfoPtr_updateThreshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PowerLine.NativeFieldInfoPtr_updateThreshold, (void*)(&value));
			}
		}

		// Token: 0x17002334 RID: 9012
		// (get) Token: 0x06007431 RID: 29745 RVA: 0x001FAE80 File Offset: 0x001F9080
		// (set) Token: 0x06007432 RID: 29746 RVA: 0x000372A2 File Offset: 0x000354A2
		public unsafe PowerNode nodeA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerLine.NativeFieldInfoPtr_nodeA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PowerNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerLine.NativeFieldInfoPtr_nodeA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002335 RID: 9013
		// (get) Token: 0x06007433 RID: 29747 RVA: 0x001FAEB0 File Offset: 0x001F90B0
		// (set) Token: 0x06007434 RID: 29748 RVA: 0x000372C1 File Offset: 0x000354C1
		public unsafe PowerNode nodeB
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerLine.NativeFieldInfoPtr_nodeB);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PowerNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerLine.NativeFieldInfoPtr_nodeB), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002336 RID: 9014
		// (get) Token: 0x06007435 RID: 29749 RVA: 0x001FAEE0 File Offset: 0x001F90E0
		// (set) Token: 0x06007436 RID: 29750 RVA: 0x000372E0 File Offset: 0x000354E0
		public unsafe float LengthFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerLine.NativeFieldInfoPtr_LengthFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerLine.NativeFieldInfoPtr_LengthFactor)) = value;
			}
		}

		// Token: 0x17002337 RID: 9015
		// (get) Token: 0x06007437 RID: 29751 RVA: 0x001FAF08 File Offset: 0x001F9108
		// (set) Token: 0x06007438 RID: 29752 RVA: 0x000372FB File Offset: 0x000354FB
		public unsafe List<Transform> segments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerLine.NativeFieldInfoPtr_segments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerLine.NativeFieldInfoPtr_segments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002338 RID: 9016
		// (get) Token: 0x06007439 RID: 29753 RVA: 0x001FAF38 File Offset: 0x001F9138
		// (set) Token: 0x0600743A RID: 29754 RVA: 0x0003731A File Offset: 0x0003551A
		public unsafe Vector3 nodeA_LastUpdatePos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerLine.NativeFieldInfoPtr_nodeA_LastUpdatePos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerLine.NativeFieldInfoPtr_nodeA_LastUpdatePos)) = value;
			}
		}

		// Token: 0x17002339 RID: 9017
		// (get) Token: 0x0600743B RID: 29755 RVA: 0x001FAF60 File Offset: 0x001F9160
		// (set) Token: 0x0600743C RID: 29756 RVA: 0x00037335 File Offset: 0x00035535
		public unsafe Vector3 nodeB_LastUpdatePos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerLine.NativeFieldInfoPtr_nodeB_LastUpdatePos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerLine.NativeFieldInfoPtr_nodeB_LastUpdatePos)) = value;
			}
		}

		// Token: 0x1700233A RID: 9018
		// (get) Token: 0x0600743D RID: 29757 RVA: 0x001FAF88 File Offset: 0x001F9188
		// (set) Token: 0x0600743E RID: 29758 RVA: 0x00037350 File Offset: 0x00035550
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerLine.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerLine.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700233B RID: 9019
		// (get) Token: 0x0600743F RID: 29759 RVA: 0x001FAFB0 File Offset: 0x001F91B0
		// (set) Token: 0x06007440 RID: 29760 RVA: 0x0003736B File Offset: 0x0003556B
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerLine.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerLine.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004F45 RID: 20293
		private static readonly IntPtr NativeFieldInfoPtr_powerLine_MinSegments;

		// Token: 0x04004F46 RID: 20294
		private static readonly IntPtr NativeFieldInfoPtr_powerLine_MaxSegments;

		// Token: 0x04004F47 RID: 20295
		private static readonly IntPtr NativeFieldInfoPtr_maxLineLength;

		// Token: 0x04004F48 RID: 20296
		private static readonly IntPtr NativeFieldInfoPtr_updateThreshold;

		// Token: 0x04004F49 RID: 20297
		private static readonly IntPtr NativeFieldInfoPtr_nodeA;

		// Token: 0x04004F4A RID: 20298
		private static readonly IntPtr NativeFieldInfoPtr_nodeB;

		// Token: 0x04004F4B RID: 20299
		private static readonly IntPtr NativeFieldInfoPtr_LengthFactor;

		// Token: 0x04004F4C RID: 20300
		private static readonly IntPtr NativeFieldInfoPtr_segments;

		// Token: 0x04004F4D RID: 20301
		private static readonly IntPtr NativeFieldInfoPtr_nodeA_LastUpdatePos;

		// Token: 0x04004F4E RID: 20302
		private static readonly IntPtr NativeFieldInfoPtr_nodeB_LastUpdatePos;

		// Token: 0x04004F4F RID: 20303
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004F50 RID: 20304
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004F51 RID: 20305
		private static readonly IntPtr NativeMethodInfoPtr_InitializePowerLine_Public_Void_PowerNode_PowerNode_0;

		// Token: 0x04004F52 RID: 20306
		private static readonly IntPtr NativeMethodInfoPtr_DestroyConstructable_Public_Virtual_Void_Boolean_0;

		// Token: 0x04004F53 RID: 20307
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04004F54 RID: 20308
		private static readonly IntPtr NativeMethodInfoPtr_RefreshVisuals_Private_Void_0;

		// Token: 0x04004F55 RID: 20309
		private static readonly IntPtr NativeMethodInfoPtr_RefreshBoundingBox_Private_Void_0;

		// Token: 0x04004F56 RID: 20310
		private static readonly IntPtr NativeMethodInfoPtr_GetOtherNode_Public_PowerNode_PowerNode_0;

		// Token: 0x04004F57 RID: 20311
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0;

		// Token: 0x04004F58 RID: 20312
		private static readonly IntPtr NativeMethodInfoPtr_GetCosmeticCenter_Public_Virtual_Vector3_0;

		// Token: 0x04004F59 RID: 20313
		private static readonly IntPtr NativeMethodInfoPtr_CanNodesBeConnected_Public_Static_Boolean_PowerNode_PowerNode_0;

		// Token: 0x04004F5A RID: 20314
		private static readonly IntPtr NativeMethodInfoPtr_GetSegmentCount_Public_Static_Int32_Vector3_Vector3_0;

		// Token: 0x04004F5B RID: 20315
		private static readonly IntPtr NativeMethodInfoPtr_DrawPowerLine_Public_Static_Void_Vector3_Vector3_List_1_Transform_Single_0;

		// Token: 0x04004F5C RID: 20316
		private static readonly IntPtr NativeMethodInfoPtr_PositionSegments_Private_Static_Void_List_1_Vector3_List_1_Transform_0;

		// Token: 0x04004F5D RID: 20317
		private static readonly IntPtr NativeMethodInfoPtr_GetCatenaryPoints_Private_Static_List_1_Vector3_Vector3_Vector3_Int32_Single_0;

		// Token: 0x04004F5E RID: 20318
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004F5F RID: 20319
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004F60 RID: 20320
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004F61 RID: 20321
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004F62 RID: 20322
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
