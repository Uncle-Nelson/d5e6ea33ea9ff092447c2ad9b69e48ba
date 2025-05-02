using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x02000783 RID: 1923
	public class ParkingLot : MonoBehaviour
	{
		// Token: 0x0600B5F4 RID: 46580 RVA: 0x002D36D4 File Offset: 0x002D18D4
		// Note: this type is marked as 'beforefieldinit'.
		static ParkingLot()
		{
			Il2CppClassPointerStore<ParkingLot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "ParkingLot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr);
			ParkingLot.NativeFieldInfoPtr_BakedGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, "BakedGUID");
			ParkingLot.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, "<GUID>k__BackingField");
			ParkingLot.NativeFieldInfoPtr_ParkingSpots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, "ParkingSpots");
			ParkingLot.NativeFieldInfoPtr_EntryPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, "EntryPoint");
			ParkingLot.NativeFieldInfoPtr_HiddenVehicleAccessPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, "HiddenVehicleAccessPoint");
			ParkingLot.NativeFieldInfoPtr_UseExitPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, "UseExitPoint");
			ParkingLot.NativeFieldInfoPtr_ExitAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, "ExitAlignment");
			ParkingLot.NativeFieldInfoPtr_ExitPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, "ExitPoint");
			ParkingLot.NativeFieldInfoPtr_ExitPointVehicleDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, "ExitPointVehicleDetector");
			ParkingLot.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, 100685670);
			ParkingLot.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, 100685671);
			ParkingLot.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, 100685672);
			ParkingLot.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, 100685673);
			ParkingLot.NativeMethodInfoPtr_GetRandomFreeSpot_Public_ParkingSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, 100685674);
			ParkingLot.NativeMethodInfoPtr_GetRandomFreeSpotIndex_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, 100685675);
			ParkingLot.NativeMethodInfoPtr_GetFreeParkingSpots_Public_List_1_ParkingSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, 100685676);
			ParkingLot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, 100685677);
		}

		// Token: 0x1700386F RID: 14447
		// (get) Token: 0x0600B5F5 RID: 46581 RVA: 0x002D3858 File Offset: 0x002D1A58
		// (set) Token: 0x0600B5F6 RID: 46582 RVA: 0x002D3894 File Offset: 0x002D1A94
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingLot.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 54194, RefRangeEnd = 54198, XrefRangeStart = 54194, XrefRangeEnd = 54198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingLot.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B5F7 RID: 46583 RVA: 0x002D38D4 File Offset: 0x002D1AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311033, XrefRangeEnd = 311062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingLot.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5F8 RID: 46584 RVA: 0x002D3908 File Offset: 0x002D1B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311062, XrefRangeEnd = 311066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingLot.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5F9 RID: 46585 RVA: 0x002D3948 File Offset: 0x002D1B48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 311083, RefRangeEnd = 311084, XrefRangeStart = 311066, XrefRangeEnd = 311083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParkingSpot GetRandomFreeSpot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingLot.NativeMethodInfoPtr_GetRandomFreeSpot_Public_ParkingSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParkingSpot>(intPtr3) : null;
		}

		// Token: 0x0600B5FA RID: 46586 RVA: 0x002D3988 File Offset: 0x002D1B88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 311093, RefRangeEnd = 311095, XrefRangeStart = 311084, XrefRangeEnd = 311093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetRandomFreeSpotIndex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingLot.NativeMethodInfoPtr_GetRandomFreeSpotIndex_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B5FB RID: 46587 RVA: 0x002D39C4 File Offset: 0x002D1BC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 311123, RefRangeEnd = 311125, XrefRangeStart = 311095, XrefRangeEnd = 311123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ParkingSpot> GetFreeParkingSpots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingLot.NativeMethodInfoPtr_GetFreeParkingSpots_Public_List_1_ParkingSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ParkingSpot>>(intPtr3) : null;
		}

		// Token: 0x0600B5FC RID: 46588 RVA: 0x002D3A04 File Offset: 0x002D1C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311125, XrefRangeEnd = 311136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParkingLot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingLot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5FD RID: 46589 RVA: 0x000594D5 File Offset: 0x000576D5
		public ParkingLot(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003866 RID: 14438
		// (get) Token: 0x0600B5FE RID: 46590 RVA: 0x002D3A40 File Offset: 0x002D1C40
		// (set) Token: 0x0600B5FF RID: 46591 RVA: 0x000594DE File Offset: 0x000576DE
		public unsafe string BakedGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_BakedGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_BakedGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003867 RID: 14439
		// (get) Token: 0x0600B600 RID: 46592 RVA: 0x002D3A68 File Offset: 0x002D1C68
		// (set) Token: 0x0600B601 RID: 46593 RVA: 0x000594FD File Offset: 0x000576FD
		public unsafe Guid _GUID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x17003868 RID: 14440
		// (get) Token: 0x0600B602 RID: 46594 RVA: 0x002D3A90 File Offset: 0x002D1C90
		// (set) Token: 0x0600B603 RID: 46595 RVA: 0x00059518 File Offset: 0x00057718
		public unsafe List<ParkingSpot> ParkingSpots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_ParkingSpots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ParkingSpot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_ParkingSpots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003869 RID: 14441
		// (get) Token: 0x0600B604 RID: 46596 RVA: 0x002D3AC0 File Offset: 0x002D1CC0
		// (set) Token: 0x0600B605 RID: 46597 RVA: 0x00059537 File Offset: 0x00057737
		public unsafe Transform EntryPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_EntryPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_EntryPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700386A RID: 14442
		// (get) Token: 0x0600B606 RID: 46598 RVA: 0x002D3AF0 File Offset: 0x002D1CF0
		// (set) Token: 0x0600B607 RID: 46599 RVA: 0x00059556 File Offset: 0x00057756
		public unsafe Transform HiddenVehicleAccessPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_HiddenVehicleAccessPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_HiddenVehicleAccessPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700386B RID: 14443
		// (get) Token: 0x0600B608 RID: 46600 RVA: 0x002D3B20 File Offset: 0x002D1D20
		// (set) Token: 0x0600B609 RID: 46601 RVA: 0x00059575 File Offset: 0x00057775
		public unsafe bool UseExitPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_UseExitPoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_UseExitPoint)) = value;
			}
		}

		// Token: 0x1700386C RID: 14444
		// (get) Token: 0x0600B60A RID: 46602 RVA: 0x002D3B48 File Offset: 0x002D1D48
		// (set) Token: 0x0600B60B RID: 46603 RVA: 0x00059590 File Offset: 0x00057790
		public unsafe EParkingAlignment ExitAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_ExitAlignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_ExitAlignment)) = value;
			}
		}

		// Token: 0x1700386D RID: 14445
		// (get) Token: 0x0600B60C RID: 46604 RVA: 0x002D3B70 File Offset: 0x002D1D70
		// (set) Token: 0x0600B60D RID: 46605 RVA: 0x000595AB File Offset: 0x000577AB
		public unsafe Transform ExitPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_ExitPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_ExitPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700386E RID: 14446
		// (get) Token: 0x0600B60E RID: 46606 RVA: 0x002D3BA0 File Offset: 0x002D1DA0
		// (set) Token: 0x0600B60F RID: 46607 RVA: 0x000595CA File Offset: 0x000577CA
		public unsafe VehicleDetector ExitPointVehicleDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_ExitPointVehicleDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_ExitPointVehicleDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007A98 RID: 31384
		private static readonly IntPtr NativeFieldInfoPtr_BakedGUID;

		// Token: 0x04007A99 RID: 31385
		private static readonly IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x04007A9A RID: 31386
		private static readonly IntPtr NativeFieldInfoPtr_ParkingSpots;

		// Token: 0x04007A9B RID: 31387
		private static readonly IntPtr NativeFieldInfoPtr_EntryPoint;

		// Token: 0x04007A9C RID: 31388
		private static readonly IntPtr NativeFieldInfoPtr_HiddenVehicleAccessPoint;

		// Token: 0x04007A9D RID: 31389
		private static readonly IntPtr NativeFieldInfoPtr_UseExitPoint;

		// Token: 0x04007A9E RID: 31390
		private static readonly IntPtr NativeFieldInfoPtr_ExitAlignment;

		// Token: 0x04007A9F RID: 31391
		private static readonly IntPtr NativeFieldInfoPtr_ExitPoint;

		// Token: 0x04007AA0 RID: 31392
		private static readonly IntPtr NativeFieldInfoPtr_ExitPointVehicleDetector;

		// Token: 0x04007AA1 RID: 31393
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x04007AA2 RID: 31394
		private static readonly IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x04007AA3 RID: 31395
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04007AA4 RID: 31396
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x04007AA5 RID: 31397
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomFreeSpot_Public_ParkingSpot_0;

		// Token: 0x04007AA6 RID: 31398
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomFreeSpotIndex_Public_Int32_0;

		// Token: 0x04007AA7 RID: 31399
		private static readonly IntPtr NativeMethodInfoPtr_GetFreeParkingSpots_Public_List_1_ParkingSpot_0;

		// Token: 0x04007AA8 RID: 31400
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C02 RID: 3074
		[ObfuscatedName("ScheduleOne.Map.ParkingLot+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E01D RID: 57373 RVA: 0x0034C7B8 File Offset: 0x0034A9B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ParkingLot.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParkingLot.__c>.NativeClassPtr);
				ParkingLot.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingLot.__c>.NativeClassPtr, "<>9");
				ParkingLot.__c.NativeFieldInfoPtr___9__16_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingLot.__c>.NativeClassPtr, "<>9__16_0");
				ParkingLot.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingLot.__c>.NativeClassPtr, 100685679);
				ParkingLot.__c.NativeMethodInfoPtr__GetFreeParkingSpots_b__16_0_Internal_Boolean_ParkingSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingLot.__c>.NativeClassPtr, 100685680);
			}

			// Token: 0x0600E01E RID: 57374 RVA: 0x0034C834 File Offset: 0x0034AA34
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParkingLot.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingLot.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E01F RID: 57375 RVA: 0x0034C870 File Offset: 0x0034AA70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311029, XrefRangeEnd = 311033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetFreeParkingSpots_b__16_0(ParkingSpot x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingLot.__c.NativeMethodInfoPtr__GetFreeParkingSpots_b__16_0_Internal_Boolean_ParkingSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E020 RID: 57376 RVA: 0x0006D46A File Offset: 0x0006B66A
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004572 RID: 17778
			// (get) Token: 0x0600E021 RID: 57377 RVA: 0x0034C8C0 File Offset: 0x0034AAC0
			// (set) Token: 0x0600E022 RID: 57378 RVA: 0x0006D473 File Offset: 0x0006B673
			public unsafe static ParkingLot.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ParkingLot.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParkingLot.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ParkingLot.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004573 RID: 17779
			// (get) Token: 0x0600E023 RID: 57379 RVA: 0x0034C8E8 File Offset: 0x0034AAE8
			// (set) Token: 0x0600E024 RID: 57380 RVA: 0x0006D485 File Offset: 0x0006B685
			public unsafe static Func<ParkingSpot, bool> __9__16_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ParkingLot.__c.NativeFieldInfoPtr___9__16_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ParkingSpot, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ParkingLot.__c.NativeFieldInfoPtr___9__16_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009612 RID: 38418
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009613 RID: 38419
			private static readonly IntPtr NativeFieldInfoPtr___9__16_0;

			// Token: 0x04009614 RID: 38420
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009615 RID: 38421
			private static readonly IntPtr NativeMethodInfoPtr__GetFreeParkingSpots_b__16_0_Internal_Boolean_ParkingSpot_0;
		}
	}
}
