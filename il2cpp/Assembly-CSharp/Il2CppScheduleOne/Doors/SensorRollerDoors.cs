using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;

namespace Il2CppScheduleOne.Doors
{
	// Token: 0x02000429 RID: 1065
	public class SensorRollerDoors : RollerDoor
	{
		// Token: 0x06005DB3 RID: 23987 RVA: 0x001B0240 File Offset: 0x001AE440
		// Note: this type is marked as 'beforefieldinit'.
		static SensorRollerDoors()
		{
			Il2CppClassPointerStore<SensorRollerDoors>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Doors", "SensorRollerDoors");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SensorRollerDoors>.NativeClassPtr);
			SensorRollerDoors.NativeFieldInfoPtr_Detector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SensorRollerDoors>.NativeClassPtr, "Detector");
			SensorRollerDoors.NativeFieldInfoPtr_ClipDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SensorRollerDoors>.NativeClassPtr, "ClipDetector");
			SensorRollerDoors.NativeFieldInfoPtr_DetectPlayerOccupiedVehiclesOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SensorRollerDoors>.NativeClassPtr, "DetectPlayerOccupiedVehiclesOnly");
			SensorRollerDoors.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensorRollerDoors>.NativeClassPtr, 100675217);
			SensorRollerDoors.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensorRollerDoors>.NativeClassPtr, 100675218);
		}

		// Token: 0x06005DB4 RID: 23988 RVA: 0x001B02D4 File Offset: 0x001AE4D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196196, XrefRangeEnd = 196207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SensorRollerDoors.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DB5 RID: 23989 RVA: 0x001B0310 File Offset: 0x001AE510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SensorRollerDoors() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SensorRollerDoors>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensorRollerDoors.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DB6 RID: 23990 RVA: 0x0002C2FF File Offset: 0x0002A4FF
		public SensorRollerDoors(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C35 RID: 7221
		// (get) Token: 0x06005DB7 RID: 23991 RVA: 0x001B034C File Offset: 0x001AE54C
		// (set) Token: 0x06005DB8 RID: 23992 RVA: 0x0002C308 File Offset: 0x0002A508
		public unsafe VehicleDetector Detector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorRollerDoors.NativeFieldInfoPtr_Detector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorRollerDoors.NativeFieldInfoPtr_Detector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C36 RID: 7222
		// (get) Token: 0x06005DB9 RID: 23993 RVA: 0x001B037C File Offset: 0x001AE57C
		// (set) Token: 0x06005DBA RID: 23994 RVA: 0x0002C327 File Offset: 0x0002A527
		public unsafe VehicleDetector ClipDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorRollerDoors.NativeFieldInfoPtr_ClipDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorRollerDoors.NativeFieldInfoPtr_ClipDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C37 RID: 7223
		// (get) Token: 0x06005DBB RID: 23995 RVA: 0x001B03AC File Offset: 0x001AE5AC
		// (set) Token: 0x06005DBC RID: 23996 RVA: 0x0002C346 File Offset: 0x0002A546
		public unsafe bool DetectPlayerOccupiedVehiclesOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorRollerDoors.NativeFieldInfoPtr_DetectPlayerOccupiedVehiclesOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorRollerDoors.NativeFieldInfoPtr_DetectPlayerOccupiedVehiclesOnly)) = value;
			}
		}

		// Token: 0x0400401C RID: 16412
		private static readonly IntPtr NativeFieldInfoPtr_Detector;

		// Token: 0x0400401D RID: 16413
		private static readonly IntPtr NativeFieldInfoPtr_ClipDetector;

		// Token: 0x0400401E RID: 16414
		private static readonly IntPtr NativeFieldInfoPtr_DetectPlayerOccupiedVehiclesOnly;

		// Token: 0x0400401F RID: 16415
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04004020 RID: 16416
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
