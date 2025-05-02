using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.NPCs.Behaviour;
using Il2CppScheduleOne.Police;
using Il2CppSystem;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003DE RID: 990
	[Serializable]
	public class VehiclePatrolInstance : Object
	{
		// Token: 0x06004C92 RID: 19602 RVA: 0x0016FF30 File Offset: 0x0016E130
		// Note: this type is marked as 'beforefieldinit'.
		static VehiclePatrolInstance()
		{
			Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "VehiclePatrolInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr);
			VehiclePatrolInstance.NativeFieldInfoPtr_Route = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr, "Route");
			VehiclePatrolInstance.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr, "StartTime");
			VehiclePatrolInstance.NativeFieldInfoPtr_IntensityRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr, "IntensityRequirement");
			VehiclePatrolInstance.NativeFieldInfoPtr_OnlyIfCurfewEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr, "OnlyIfCurfewEnabled");
			VehiclePatrolInstance.NativeFieldInfoPtr_activeOfficer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr, "activeOfficer");
			VehiclePatrolInstance.NativeFieldInfoPtr_latestStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr, "latestStartTime");
			VehiclePatrolInstance.NativeFieldInfoPtr_startedThisCycle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr, "startedThisCycle");
			VehiclePatrolInstance.NativeMethodInfoPtr_get_nearestStation_Private_get_PoliceStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr, 100672745);
			VehiclePatrolInstance.NativeMethodInfoPtr_Evaluate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr, 100672746);
			VehiclePatrolInstance.NativeMethodInfoPtr_CheckEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr, 100672747);
			VehiclePatrolInstance.NativeMethodInfoPtr_StartPatrol_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr, 100672748);
			VehiclePatrolInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr, 100672749);
		}

		// Token: 0x17001707 RID: 5895
		// (get) Token: 0x06004C93 RID: 19603 RVA: 0x00170050 File Offset: 0x0016E250
		public unsafe PoliceStation nearestStation
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 165843, RefRangeEnd = 165845, XrefRangeStart = 165837, XrefRangeEnd = 165843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePatrolInstance.NativeMethodInfoPtr_get_nearestStation_Private_get_PoliceStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PoliceStation>(intPtr3) : null;
			}
		}

		// Token: 0x06004C94 RID: 19604 RVA: 0x00170090 File Offset: 0x0016E290
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 165863, RefRangeEnd = 165864, XrefRangeStart = 165845, XrefRangeEnd = 165863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Evaluate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePatrolInstance.NativeMethodInfoPtr_Evaluate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C95 RID: 19605 RVA: 0x001700C4 File Offset: 0x0016E2C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165864, XrefRangeEnd = 165869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePatrolInstance.NativeMethodInfoPtr_CheckEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C96 RID: 19606 RVA: 0x001700F8 File Offset: 0x0016E2F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 165900, RefRangeEnd = 165901, XrefRangeStart = 165869, XrefRangeEnd = 165900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartPatrol()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePatrolInstance.NativeMethodInfoPtr_StartPatrol_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C97 RID: 19607 RVA: 0x0017012C File Offset: 0x0016E32C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165901, XrefRangeEnd = 165902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehiclePatrolInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePatrolInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C98 RID: 19608 RVA: 0x00024D4C File Offset: 0x00022F4C
		public VehiclePatrolInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001700 RID: 5888
		// (get) Token: 0x06004C99 RID: 19609 RVA: 0x00170168 File Offset: 0x0016E368
		// (set) Token: 0x06004C9A RID: 19610 RVA: 0x00024D55 File Offset: 0x00022F55
		public unsafe VehiclePatrolRoute Route
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_Route);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehiclePatrolRoute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_Route), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001701 RID: 5889
		// (get) Token: 0x06004C9B RID: 19611 RVA: 0x00170198 File Offset: 0x0016E398
		// (set) Token: 0x06004C9C RID: 19612 RVA: 0x00024D74 File Offset: 0x00022F74
		public unsafe int StartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_StartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_StartTime)) = value;
			}
		}

		// Token: 0x17001702 RID: 5890
		// (get) Token: 0x06004C9D RID: 19613 RVA: 0x001701C0 File Offset: 0x0016E3C0
		// (set) Token: 0x06004C9E RID: 19614 RVA: 0x00024D8F File Offset: 0x00022F8F
		public unsafe int IntensityRequirement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_IntensityRequirement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_IntensityRequirement)) = value;
			}
		}

		// Token: 0x17001703 RID: 5891
		// (get) Token: 0x06004C9F RID: 19615 RVA: 0x001701E8 File Offset: 0x0016E3E8
		// (set) Token: 0x06004CA0 RID: 19616 RVA: 0x00024DAA File Offset: 0x00022FAA
		public unsafe bool OnlyIfCurfewEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_OnlyIfCurfewEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_OnlyIfCurfewEnabled)) = value;
			}
		}

		// Token: 0x17001704 RID: 5892
		// (get) Token: 0x06004CA1 RID: 19617 RVA: 0x00170210 File Offset: 0x0016E410
		// (set) Token: 0x06004CA2 RID: 19618 RVA: 0x00024DC5 File Offset: 0x00022FC5
		public unsafe PoliceOfficer activeOfficer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_activeOfficer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceOfficer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_activeOfficer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001705 RID: 5893
		// (get) Token: 0x06004CA3 RID: 19619 RVA: 0x00170240 File Offset: 0x0016E440
		// (set) Token: 0x06004CA4 RID: 19620 RVA: 0x00024DE4 File Offset: 0x00022FE4
		public unsafe int latestStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_latestStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_latestStartTime)) = value;
			}
		}

		// Token: 0x17001706 RID: 5894
		// (get) Token: 0x06004CA5 RID: 19621 RVA: 0x00170268 File Offset: 0x0016E468
		// (set) Token: 0x06004CA6 RID: 19622 RVA: 0x00024DFF File Offset: 0x00022FFF
		public unsafe bool startedThisCycle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_startedThisCycle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_startedThisCycle)) = value;
			}
		}

		// Token: 0x04003391 RID: 13201
		private static readonly IntPtr NativeFieldInfoPtr_Route;

		// Token: 0x04003392 RID: 13202
		private static readonly IntPtr NativeFieldInfoPtr_StartTime;

		// Token: 0x04003393 RID: 13203
		private static readonly IntPtr NativeFieldInfoPtr_IntensityRequirement;

		// Token: 0x04003394 RID: 13204
		private static readonly IntPtr NativeFieldInfoPtr_OnlyIfCurfewEnabled;

		// Token: 0x04003395 RID: 13205
		private static readonly IntPtr NativeFieldInfoPtr_activeOfficer;

		// Token: 0x04003396 RID: 13206
		private static readonly IntPtr NativeFieldInfoPtr_latestStartTime;

		// Token: 0x04003397 RID: 13207
		private static readonly IntPtr NativeFieldInfoPtr_startedThisCycle;

		// Token: 0x04003398 RID: 13208
		private static readonly IntPtr NativeMethodInfoPtr_get_nearestStation_Private_get_PoliceStation_0;

		// Token: 0x04003399 RID: 13209
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Void_0;

		// Token: 0x0400339A RID: 13210
		private static readonly IntPtr NativeMethodInfoPtr_CheckEnd_Private_Void_0;

		// Token: 0x0400339B RID: 13211
		private static readonly IntPtr NativeMethodInfoPtr_StartPatrol_Public_Void_0;

		// Token: 0x0400339C RID: 13212
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
