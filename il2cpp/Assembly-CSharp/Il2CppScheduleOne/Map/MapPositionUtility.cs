using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x0200077D RID: 1917
	public class MapPositionUtility : Singleton<MapPositionUtility>
	{
		// Token: 0x0600B5A3 RID: 46499 RVA: 0x002D26CC File Offset: 0x002D08CC
		// Note: this type is marked as 'beforefieldinit'.
		static MapPositionUtility()
		{
			Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "MapPositionUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr);
			MapPositionUtility.NativeFieldInfoPtr_OriginPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr, "OriginPoint");
			MapPositionUtility.NativeFieldInfoPtr_EdgePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr, "EdgePoint");
			MapPositionUtility.NativeFieldInfoPtr_MapDimensions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr, "MapDimensions");
			MapPositionUtility.NativeFieldInfoPtr__conversionFactor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr, "<conversionFactor>k__BackingField");
			MapPositionUtility.NativeMethodInfoPtr_get_conversionFactor_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr, 100685621);
			MapPositionUtility.NativeMethodInfoPtr_set_conversionFactor_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr, 100685622);
			MapPositionUtility.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr, 100685623);
			MapPositionUtility.NativeMethodInfoPtr_GetMapPosition_Public_Vector2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr, 100685624);
			MapPositionUtility.NativeMethodInfoPtr_Recalculate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr, 100685625);
			MapPositionUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr, 100685626);
		}

		// Token: 0x17003853 RID: 14419
		// (get) Token: 0x0600B5A4 RID: 46500 RVA: 0x002D27C4 File Offset: 0x002D09C4
		// (set) Token: 0x0600B5A5 RID: 46501 RVA: 0x002D2800 File Offset: 0x002D0A00
		public unsafe float conversionFactor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapPositionUtility.NativeMethodInfoPtr_get_conversionFactor_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapPositionUtility.NativeMethodInfoPtr_set_conversionFactor_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B5A6 RID: 46502 RVA: 0x002D2840 File Offset: 0x002D0A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310599, XrefRangeEnd = 310609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MapPositionUtility.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5A7 RID: 46503 RVA: 0x002D287C File Offset: 0x002D0A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310609, XrefRangeEnd = 310611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetMapPosition(Vector3 worldPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref worldPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapPositionUtility.NativeMethodInfoPtr_GetMapPosition_Public_Vector2_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B5A8 RID: 46504 RVA: 0x002D28C8 File Offset: 0x002D0AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310611, XrefRangeEnd = 310618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Recalculate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapPositionUtility.NativeMethodInfoPtr_Recalculate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5A9 RID: 46505 RVA: 0x002D28FC File Offset: 0x002D0AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310618, XrefRangeEnd = 310621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MapPositionUtility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapPositionUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5AA RID: 46506 RVA: 0x00059288 File Offset: 0x00057488
		public MapPositionUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700384F RID: 14415
		// (get) Token: 0x0600B5AB RID: 46507 RVA: 0x002D2938 File Offset: 0x002D0B38
		// (set) Token: 0x0600B5AC RID: 46508 RVA: 0x00059291 File Offset: 0x00057491
		public unsafe Transform OriginPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapPositionUtility.NativeFieldInfoPtr_OriginPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapPositionUtility.NativeFieldInfoPtr_OriginPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003850 RID: 14416
		// (get) Token: 0x0600B5AD RID: 46509 RVA: 0x002D2968 File Offset: 0x002D0B68
		// (set) Token: 0x0600B5AE RID: 46510 RVA: 0x000592B0 File Offset: 0x000574B0
		public unsafe Transform EdgePoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapPositionUtility.NativeFieldInfoPtr_EdgePoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapPositionUtility.NativeFieldInfoPtr_EdgePoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003851 RID: 14417
		// (get) Token: 0x0600B5AF RID: 46511 RVA: 0x002D2998 File Offset: 0x002D0B98
		// (set) Token: 0x0600B5B0 RID: 46512 RVA: 0x000592CF File Offset: 0x000574CF
		public unsafe float MapDimensions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapPositionUtility.NativeFieldInfoPtr_MapDimensions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapPositionUtility.NativeFieldInfoPtr_MapDimensions)) = value;
			}
		}

		// Token: 0x17003852 RID: 14418
		// (get) Token: 0x0600B5B1 RID: 46513 RVA: 0x002D29C0 File Offset: 0x002D0BC0
		// (set) Token: 0x0600B5B2 RID: 46514 RVA: 0x000592EA File Offset: 0x000574EA
		public unsafe float _conversionFactor_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapPositionUtility.NativeFieldInfoPtr__conversionFactor_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapPositionUtility.NativeFieldInfoPtr__conversionFactor_k__BackingField)) = value;
			}
		}

		// Token: 0x04007A66 RID: 31334
		private static readonly IntPtr NativeFieldInfoPtr_OriginPoint;

		// Token: 0x04007A67 RID: 31335
		private static readonly IntPtr NativeFieldInfoPtr_EdgePoint;

		// Token: 0x04007A68 RID: 31336
		private static readonly IntPtr NativeFieldInfoPtr_MapDimensions;

		// Token: 0x04007A69 RID: 31337
		private static readonly IntPtr NativeFieldInfoPtr__conversionFactor_k__BackingField;

		// Token: 0x04007A6A RID: 31338
		private static readonly IntPtr NativeMethodInfoPtr_get_conversionFactor_Private_get_Single_0;

		// Token: 0x04007A6B RID: 31339
		private static readonly IntPtr NativeMethodInfoPtr_set_conversionFactor_Private_set_Void_Single_0;

		// Token: 0x04007A6C RID: 31340
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04007A6D RID: 31341
		private static readonly IntPtr NativeMethodInfoPtr_GetMapPosition_Public_Vector2_Vector3_0;

		// Token: 0x04007A6E RID: 31342
		private static readonly IntPtr NativeMethodInfoPtr_Recalculate_Public_Void_0;

		// Token: 0x04007A6F RID: 31343
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
