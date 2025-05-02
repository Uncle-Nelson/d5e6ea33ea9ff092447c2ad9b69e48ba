using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020004F3 RID: 1267
	public class VehicleSeat : MonoBehaviour
	{
		// Token: 0x06006FEC RID: 28652 RVA: 0x001ED4A8 File Offset: 0x001EB6A8
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleSeat()
		{
			Il2CppClassPointerStore<VehicleSeat>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "VehicleSeat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleSeat>.NativeClassPtr);
			VehicleSeat.NativeFieldInfoPtr_isDriverSeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSeat>.NativeClassPtr, "isDriverSeat");
			VehicleSeat.NativeFieldInfoPtr_Occupant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSeat>.NativeClassPtr, "Occupant");
			VehicleSeat.NativeMethodInfoPtr_get_isOccupied_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSeat>.NativeClassPtr, 100677405);
			VehicleSeat.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSeat>.NativeClassPtr, 100677406);
		}

		// Token: 0x170021C4 RID: 8644
		// (get) Token: 0x06006FED RID: 28653 RVA: 0x001ED528 File Offset: 0x001EB728
		public unsafe bool isOccupied
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 221548, RefRangeEnd = 221550, XrefRangeStart = 221544, XrefRangeEnd = 221548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSeat.NativeMethodInfoPtr_get_isOccupied_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06006FEE RID: 28654 RVA: 0x001ED564 File Offset: 0x001EB764
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleSeat() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleSeat>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSeat.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FEF RID: 28655 RVA: 0x00035076 File Offset: 0x00033276
		public VehicleSeat(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170021C2 RID: 8642
		// (get) Token: 0x06006FF0 RID: 28656 RVA: 0x001ED5A0 File Offset: 0x001EB7A0
		// (set) Token: 0x06006FF1 RID: 28657 RVA: 0x0003507F File Offset: 0x0003327F
		public unsafe bool isDriverSeat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSeat.NativeFieldInfoPtr_isDriverSeat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSeat.NativeFieldInfoPtr_isDriverSeat)) = value;
			}
		}

		// Token: 0x170021C3 RID: 8643
		// (get) Token: 0x06006FF2 RID: 28658 RVA: 0x001ED5C8 File Offset: 0x001EB7C8
		// (set) Token: 0x06006FF3 RID: 28659 RVA: 0x0003509A File Offset: 0x0003329A
		public unsafe Player Occupant
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSeat.NativeFieldInfoPtr_Occupant);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSeat.NativeFieldInfoPtr_Occupant), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004C80 RID: 19584
		private static readonly IntPtr NativeFieldInfoPtr_isDriverSeat;

		// Token: 0x04004C81 RID: 19585
		private static readonly IntPtr NativeFieldInfoPtr_Occupant;

		// Token: 0x04004C82 RID: 19586
		private static readonly IntPtr NativeMethodInfoPtr_get_isOccupied_Public_get_Boolean_0;

		// Token: 0x04004C83 RID: 19587
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
