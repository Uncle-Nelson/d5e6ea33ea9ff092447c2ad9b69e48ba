using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Vehicles;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x02000784 RID: 1924
	public class ParkingSpot : MonoBehaviour
	{
		// Token: 0x0600B610 RID: 46608 RVA: 0x002D3BD0 File Offset: 0x002D1DD0
		// Note: this type is marked as 'beforefieldinit'.
		static ParkingSpot()
		{
			Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "ParkingSpot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr);
			ParkingSpot.NativeFieldInfoPtr_ParentLot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr, "ParentLot");
			ParkingSpot.NativeFieldInfoPtr_AlignmentPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr, "AlignmentPoint");
			ParkingSpot.NativeFieldInfoPtr_Alignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr, "Alignment");
			ParkingSpot.NativeFieldInfoPtr_OccupantVehicle_Readonly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr, "OccupantVehicle_Readonly");
			ParkingSpot.NativeFieldInfoPtr__OccupantVehicle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr, "<OccupantVehicle>k__BackingField");
			ParkingSpot.NativeMethodInfoPtr_get_OccupantVehicle_Public_get_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr, 100685681);
			ParkingSpot.NativeMethodInfoPtr_set_OccupantVehicle_Protected_set_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr, 100685682);
			ParkingSpot.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr, 100685683);
			ParkingSpot.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr, 100685684);
			ParkingSpot.NativeMethodInfoPtr_SetOccupant_Public_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr, 100685685);
			ParkingSpot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr, 100685686);
		}

		// Token: 0x17003875 RID: 14453
		// (get) Token: 0x0600B611 RID: 46609 RVA: 0x002D3CDC File Offset: 0x002D1EDC
		// (set) Token: 0x0600B612 RID: 46610 RVA: 0x002D3D1C File Offset: 0x002D1F1C
		public unsafe LandVehicle OccupantVehicle
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35358, RefRangeEnd = 35359, XrefRangeStart = 35358, XrefRangeEnd = 35359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingSpot.NativeMethodInfoPtr_get_OccupantVehicle_Public_get_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingSpot.NativeMethodInfoPtr_set_OccupantVehicle_Protected_set_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B613 RID: 46611 RVA: 0x002D3D60 File Offset: 0x002D1F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311136, XrefRangeEnd = 311168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingSpot.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B614 RID: 46612 RVA: 0x002D3D94 File Offset: 0x002D1F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311168, XrefRangeEnd = 311191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingSpot.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B615 RID: 46613 RVA: 0x002D3DC8 File Offset: 0x002D1FC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 311193, RefRangeEnd = 311195, XrefRangeStart = 311191, XrefRangeEnd = 311193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOccupant(LandVehicle vehicle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingSpot.NativeMethodInfoPtr_SetOccupant_Public_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B616 RID: 46614 RVA: 0x002D3E0C File Offset: 0x002D200C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParkingSpot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingSpot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B617 RID: 46615 RVA: 0x000595E9 File Offset: 0x000577E9
		public ParkingSpot(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003870 RID: 14448
		// (get) Token: 0x0600B618 RID: 46616 RVA: 0x002D3E48 File Offset: 0x002D2048
		// (set) Token: 0x0600B619 RID: 46617 RVA: 0x000595F2 File Offset: 0x000577F2
		public unsafe ParkingLot ParentLot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingSpot.NativeFieldInfoPtr_ParentLot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParkingLot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingSpot.NativeFieldInfoPtr_ParentLot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003871 RID: 14449
		// (get) Token: 0x0600B61A RID: 46618 RVA: 0x002D3E78 File Offset: 0x002D2078
		// (set) Token: 0x0600B61B RID: 46619 RVA: 0x00059611 File Offset: 0x00057811
		public unsafe Transform AlignmentPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingSpot.NativeFieldInfoPtr_AlignmentPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingSpot.NativeFieldInfoPtr_AlignmentPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003872 RID: 14450
		// (get) Token: 0x0600B61C RID: 46620 RVA: 0x002D3EA8 File Offset: 0x002D20A8
		// (set) Token: 0x0600B61D RID: 46621 RVA: 0x00059630 File Offset: 0x00057830
		public unsafe EParkingAlignment Alignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingSpot.NativeFieldInfoPtr_Alignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingSpot.NativeFieldInfoPtr_Alignment)) = value;
			}
		}

		// Token: 0x17003873 RID: 14451
		// (get) Token: 0x0600B61E RID: 46622 RVA: 0x002D3ED0 File Offset: 0x002D20D0
		// (set) Token: 0x0600B61F RID: 46623 RVA: 0x0005964B File Offset: 0x0005784B
		public unsafe LandVehicle OccupantVehicle_Readonly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingSpot.NativeFieldInfoPtr_OccupantVehicle_Readonly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingSpot.NativeFieldInfoPtr_OccupantVehicle_Readonly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003874 RID: 14452
		// (get) Token: 0x0600B620 RID: 46624 RVA: 0x002D3F00 File Offset: 0x002D2100
		// (set) Token: 0x0600B621 RID: 46625 RVA: 0x0005966A File Offset: 0x0005786A
		public unsafe LandVehicle _OccupantVehicle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingSpot.NativeFieldInfoPtr__OccupantVehicle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingSpot.NativeFieldInfoPtr__OccupantVehicle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007AA9 RID: 31401
		private static readonly IntPtr NativeFieldInfoPtr_ParentLot;

		// Token: 0x04007AAA RID: 31402
		private static readonly IntPtr NativeFieldInfoPtr_AlignmentPoint;

		// Token: 0x04007AAB RID: 31403
		private static readonly IntPtr NativeFieldInfoPtr_Alignment;

		// Token: 0x04007AAC RID: 31404
		private static readonly IntPtr NativeFieldInfoPtr_OccupantVehicle_Readonly;

		// Token: 0x04007AAD RID: 31405
		private static readonly IntPtr NativeFieldInfoPtr__OccupantVehicle_k__BackingField;

		// Token: 0x04007AAE RID: 31406
		private static readonly IntPtr NativeMethodInfoPtr_get_OccupantVehicle_Public_get_LandVehicle_0;

		// Token: 0x04007AAF RID: 31407
		private static readonly IntPtr NativeMethodInfoPtr_set_OccupantVehicle_Protected_set_Void_LandVehicle_0;

		// Token: 0x04007AB0 RID: 31408
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04007AB1 RID: 31409
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

		// Token: 0x04007AB2 RID: 31410
		private static readonly IntPtr NativeMethodInfoPtr_SetOccupant_Public_Void_LandVehicle_0;

		// Token: 0x04007AB3 RID: 31411
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
