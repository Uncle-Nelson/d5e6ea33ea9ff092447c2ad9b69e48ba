using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020004E3 RID: 1251
	public class ObstructionDetector : MonoBehaviour
	{
		// Token: 0x06006E98 RID: 28312 RVA: 0x001E946C File Offset: 0x001E766C
		// Note: this type is marked as 'beforefieldinit'.
		static ObstructionDetector()
		{
			Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "ObstructionDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr);
			ObstructionDetector.NativeFieldInfoPtr_vehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr, "vehicle");
			ObstructionDetector.NativeFieldInfoPtr_vehicles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr, "vehicles");
			ObstructionDetector.NativeFieldInfoPtr_npcs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr, "npcs");
			ObstructionDetector.NativeFieldInfoPtr_players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr, "players");
			ObstructionDetector.NativeFieldInfoPtr_vehicleObstacles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr, "vehicleObstacles");
			ObstructionDetector.NativeFieldInfoPtr_closestObstructionDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr, "closestObstructionDistance");
			ObstructionDetector.NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr, "range");
			ObstructionDetector.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr, 100677292);
			ObstructionDetector.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr, 100677293);
			ObstructionDetector.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr, 100677294);
			ObstructionDetector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr, 100677295);
		}

		// Token: 0x06006E99 RID: 28313 RVA: 0x001E9578 File Offset: 0x001E7778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220275, XrefRangeEnd = 220286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObstructionDetector.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E9A RID: 28314 RVA: 0x001E95B4 File Offset: 0x001E77B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220286, XrefRangeEnd = 220378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObstructionDetector.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E9B RID: 28315 RVA: 0x001E95F0 File Offset: 0x001E77F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220378, XrefRangeEnd = 220439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerStay(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObstructionDetector.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E9C RID: 28316 RVA: 0x001E9634 File Offset: 0x001E7834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220439, XrefRangeEnd = 220468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObstructionDetector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObstructionDetector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E9D RID: 28317 RVA: 0x000344F7 File Offset: 0x000326F7
		public ObstructionDetector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002154 RID: 8532
		// (get) Token: 0x06006E9E RID: 28318 RVA: 0x001E9670 File Offset: 0x001E7870
		// (set) Token: 0x06006E9F RID: 28319 RVA: 0x00034500 File Offset: 0x00032700
		public unsafe LandVehicle vehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_vehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_vehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002155 RID: 8533
		// (get) Token: 0x06006EA0 RID: 28320 RVA: 0x001E96A0 File Offset: 0x001E78A0
		// (set) Token: 0x06006EA1 RID: 28321 RVA: 0x0003451F File Offset: 0x0003271F
		public unsafe List<LandVehicle> vehicles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_vehicles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LandVehicle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_vehicles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002156 RID: 8534
		// (get) Token: 0x06006EA2 RID: 28322 RVA: 0x001E96D0 File Offset: 0x001E78D0
		// (set) Token: 0x06006EA3 RID: 28323 RVA: 0x0003453E File Offset: 0x0003273E
		public unsafe List<NPC> npcs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_npcs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_npcs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002157 RID: 8535
		// (get) Token: 0x06006EA4 RID: 28324 RVA: 0x001E9700 File Offset: 0x001E7900
		// (set) Token: 0x06006EA5 RID: 28325 RVA: 0x0003455D File Offset: 0x0003275D
		public unsafe List<PlayerMovement> players
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_players);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayerMovement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_players), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002158 RID: 8536
		// (get) Token: 0x06006EA6 RID: 28326 RVA: 0x001E9730 File Offset: 0x001E7930
		// (set) Token: 0x06006EA7 RID: 28327 RVA: 0x0003457C File Offset: 0x0003277C
		public unsafe List<VehicleObstacle> vehicleObstacles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_vehicleObstacles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VehicleObstacle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_vehicleObstacles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002159 RID: 8537
		// (get) Token: 0x06006EA8 RID: 28328 RVA: 0x001E9760 File Offset: 0x001E7960
		// (set) Token: 0x06006EA9 RID: 28329 RVA: 0x0003459B File Offset: 0x0003279B
		public unsafe float closestObstructionDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_closestObstructionDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_closestObstructionDistance)) = value;
			}
		}

		// Token: 0x1700215A RID: 8538
		// (get) Token: 0x06006EAA RID: 28330 RVA: 0x001E9788 File Offset: 0x001E7988
		// (set) Token: 0x06006EAB RID: 28331 RVA: 0x000345B6 File Offset: 0x000327B6
		public unsafe float range
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_range);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_range)) = value;
			}
		}

		// Token: 0x04004BB0 RID: 19376
		private static readonly IntPtr NativeFieldInfoPtr_vehicle;

		// Token: 0x04004BB1 RID: 19377
		private static readonly IntPtr NativeFieldInfoPtr_vehicles;

		// Token: 0x04004BB2 RID: 19378
		private static readonly IntPtr NativeFieldInfoPtr_npcs;

		// Token: 0x04004BB3 RID: 19379
		private static readonly IntPtr NativeFieldInfoPtr_players;

		// Token: 0x04004BB4 RID: 19380
		private static readonly IntPtr NativeFieldInfoPtr_vehicleObstacles;

		// Token: 0x04004BB5 RID: 19381
		private static readonly IntPtr NativeFieldInfoPtr_closestObstructionDistance;

		// Token: 0x04004BB6 RID: 19382
		private static readonly IntPtr NativeFieldInfoPtr_range;

		// Token: 0x04004BB7 RID: 19383
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04004BB8 RID: 19384
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04004BB9 RID: 19385
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0;

		// Token: 0x04004BBA RID: 19386
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
