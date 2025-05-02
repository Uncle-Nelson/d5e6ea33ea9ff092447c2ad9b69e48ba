using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000468 RID: 1128
	public class PositionHistoryTracker : MonoBehaviour
	{
		// Token: 0x060061C3 RID: 25027 RVA: 0x001BD8B0 File Offset: 0x001BBAB0
		// Note: this type is marked as 'beforefieldinit'.
		static PositionHistoryTracker()
		{
			Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "PositionHistoryTracker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr);
			PositionHistoryTracker.NativeFieldInfoPtr_recordingFrequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr, "recordingFrequency");
			PositionHistoryTracker.NativeFieldInfoPtr_historyDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr, "historyDuration");
			PositionHistoryTracker.NativeFieldInfoPtr_positionHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr, "positionHistory");
			PositionHistoryTracker.NativeFieldInfoPtr_lastRecordTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr, "lastRecordTime");
			PositionHistoryTracker.NativeMethodInfoPtr_get_RecordedTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr, 100675713);
			PositionHistoryTracker.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr, 100675714);
			PositionHistoryTracker.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr, 100675715);
			PositionHistoryTracker.NativeMethodInfoPtr_RecordPosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr, 100675716);
			PositionHistoryTracker.NativeMethodInfoPtr_GetPositionXSecondsAgo_Public_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr, 100675717);
			PositionHistoryTracker.NativeMethodInfoPtr_ClearHistory_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr, 100675718);
			PositionHistoryTracker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr, 100675719);
		}

		// Token: 0x17001D6B RID: 7531
		// (get) Token: 0x060061C4 RID: 25028 RVA: 0x001BD9BC File Offset: 0x001BBBBC
		public unsafe float RecordedTime
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 201413, RefRangeEnd = 201415, XrefRangeStart = 201412, XrefRangeEnd = 201413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PositionHistoryTracker.NativeMethodInfoPtr_get_RecordedTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060061C5 RID: 25029 RVA: 0x001BD9F8 File Offset: 0x001BBBF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201415, XrefRangeEnd = 201416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PositionHistoryTracker.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061C6 RID: 25030 RVA: 0x001BDA2C File Offset: 0x001BBC2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201416, XrefRangeEnd = 201428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PositionHistoryTracker.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061C7 RID: 25031 RVA: 0x001BDA60 File Offset: 0x001BBC60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201428, XrefRangeEnd = 201438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PositionHistoryTracker.NativeMethodInfoPtr_RecordPosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061C8 RID: 25032 RVA: 0x001BDA94 File Offset: 0x001BBC94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 201443, RefRangeEnd = 201445, XrefRangeStart = 201438, XrefRangeEnd = 201443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetPositionXSecondsAgo(float secondsAgo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref secondsAgo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PositionHistoryTracker.NativeMethodInfoPtr_GetPositionXSecondsAgo_Public_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060061C9 RID: 25033 RVA: 0x001BDAE0 File Offset: 0x001BBCE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 201446, RefRangeEnd = 201447, XrefRangeStart = 201445, XrefRangeEnd = 201446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearHistory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PositionHistoryTracker.NativeMethodInfoPtr_ClearHistory_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061CA RID: 25034 RVA: 0x001BDB14 File Offset: 0x001BBD14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201447, XrefRangeEnd = 201455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PositionHistoryTracker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PositionHistoryTracker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061CB RID: 25035 RVA: 0x0002E353 File Offset: 0x0002C553
		public PositionHistoryTracker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D67 RID: 7527
		// (get) Token: 0x060061CC RID: 25036 RVA: 0x001BDB50 File Offset: 0x001BBD50
		// (set) Token: 0x060061CD RID: 25037 RVA: 0x0002E35C File Offset: 0x0002C55C
		public unsafe float recordingFrequency
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PositionHistoryTracker.NativeFieldInfoPtr_recordingFrequency);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PositionHistoryTracker.NativeFieldInfoPtr_recordingFrequency)) = value;
			}
		}

		// Token: 0x17001D68 RID: 7528
		// (get) Token: 0x060061CE RID: 25038 RVA: 0x001BDB78 File Offset: 0x001BBD78
		// (set) Token: 0x060061CF RID: 25039 RVA: 0x0002E377 File Offset: 0x0002C577
		public unsafe float historyDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PositionHistoryTracker.NativeFieldInfoPtr_historyDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PositionHistoryTracker.NativeFieldInfoPtr_historyDuration)) = value;
			}
		}

		// Token: 0x17001D69 RID: 7529
		// (get) Token: 0x060061D0 RID: 25040 RVA: 0x001BDBA0 File Offset: 0x001BBDA0
		// (set) Token: 0x060061D1 RID: 25041 RVA: 0x0002E392 File Offset: 0x0002C592
		public unsafe List<Vector3> positionHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PositionHistoryTracker.NativeFieldInfoPtr_positionHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PositionHistoryTracker.NativeFieldInfoPtr_positionHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D6A RID: 7530
		// (get) Token: 0x060061D2 RID: 25042 RVA: 0x001BDBD0 File Offset: 0x001BBDD0
		// (set) Token: 0x060061D3 RID: 25043 RVA: 0x0002E3B1 File Offset: 0x0002C5B1
		public unsafe float lastRecordTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PositionHistoryTracker.NativeFieldInfoPtr_lastRecordTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PositionHistoryTracker.NativeFieldInfoPtr_lastRecordTime)) = value;
			}
		}

		// Token: 0x040042AD RID: 17069
		private static readonly IntPtr NativeFieldInfoPtr_recordingFrequency;

		// Token: 0x040042AE RID: 17070
		private static readonly IntPtr NativeFieldInfoPtr_historyDuration;

		// Token: 0x040042AF RID: 17071
		private static readonly IntPtr NativeFieldInfoPtr_positionHistory;

		// Token: 0x040042B0 RID: 17072
		private static readonly IntPtr NativeFieldInfoPtr_lastRecordTime;

		// Token: 0x040042B1 RID: 17073
		private static readonly IntPtr NativeMethodInfoPtr_get_RecordedTime_Public_get_Single_0;

		// Token: 0x040042B2 RID: 17074
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040042B3 RID: 17075
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040042B4 RID: 17076
		private static readonly IntPtr NativeMethodInfoPtr_RecordPosition_Private_Void_0;

		// Token: 0x040042B5 RID: 17077
		private static readonly IntPtr NativeMethodInfoPtr_GetPositionXSecondsAgo_Public_Vector3_Single_0;

		// Token: 0x040042B6 RID: 17078
		private static readonly IntPtr NativeMethodInfoPtr_ClearHistory_Public_Void_0;

		// Token: 0x040042B7 RID: 17079
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
