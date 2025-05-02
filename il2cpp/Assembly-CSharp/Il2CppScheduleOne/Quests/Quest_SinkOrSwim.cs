using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001C2 RID: 450
	public class Quest_SinkOrSwim : Quest
	{
		// Token: 0x06002683 RID: 9859 RVA: 0x000E96CC File Offset: 0x000E78CC
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_SinkOrSwim()
		{
			Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_SinkOrSwim");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr);
			Quest_SinkOrSwim.NativeFieldInfoPtr_DAYS_TO_COMPLETE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr, "DAYS_TO_COMPLETE");
			Quest_SinkOrSwim.NativeFieldInfoPtr_QuestName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr, "QuestName");
			Quest_SinkOrSwim.NativeFieldInfoPtr_NelsonCallTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr, "NelsonCallTime");
			Quest_SinkOrSwim.NativeFieldInfoPtr_LoanSharkVehiclePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr, "LoanSharkVehiclePosition");
			Quest_SinkOrSwim.NativeFieldInfoPtr_LoanSharkGraves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr, "LoanSharkGraves");
			Quest_SinkOrSwim.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr, 100667600);
			Quest_SinkOrSwim.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr, 100667601);
			Quest_SinkOrSwim.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr, 100667602);
			Quest_SinkOrSwim.NativeMethodInfoPtr_HourPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr, 100667603);
			Quest_SinkOrSwim.NativeMethodInfoPtr_SleepStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr, 100667604);
			Quest_SinkOrSwim.NativeMethodInfoPtr_SpawnLoanSharkVehicle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr, 100667605);
			Quest_SinkOrSwim.NativeMethodInfoPtr_CheckArrival_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr, 100667606);
			Quest_SinkOrSwim.NativeMethodInfoPtr_SetQuestState_Public_Virtual_Void_EQuestState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr, 100667607);
			Quest_SinkOrSwim.NativeMethodInfoPtr_UpdateName_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr, 100667608);
			Quest_SinkOrSwim.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr, 100667609);
		}

		// Token: 0x06002684 RID: 9860 RVA: 0x000E9828 File Offset: 0x000E7A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117065, XrefRangeEnd = 117069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_SinkOrSwim.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002685 RID: 9861 RVA: 0x000E9864 File Offset: 0x000E7A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117069, XrefRangeEnd = 117126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_SinkOrSwim.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002686 RID: 9862 RVA: 0x000E98A0 File Offset: 0x000E7AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_SinkOrSwim.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002687 RID: 9863 RVA: 0x000E98DC File Offset: 0x000E7ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117126, XrefRangeEnd = 117130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HourPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_SinkOrSwim.NativeMethodInfoPtr_HourPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002688 RID: 9864 RVA: 0x000E9910 File Offset: 0x000E7B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117130, XrefRangeEnd = 117153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SleepStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_SinkOrSwim.NativeMethodInfoPtr_SleepStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002689 RID: 9865 RVA: 0x000E9944 File Offset: 0x000E7B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117153, XrefRangeEnd = 117160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpawnLoanSharkVehicle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_SinkOrSwim.NativeMethodInfoPtr_SpawnLoanSharkVehicle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600268A RID: 9866 RVA: 0x000E9978 File Offset: 0x000E7B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117160, XrefRangeEnd = 117198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckArrival()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_SinkOrSwim.NativeMethodInfoPtr_CheckArrival_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600268B RID: 9867 RVA: 0x000E99AC File Offset: 0x000E7BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117198, XrefRangeEnd = 117202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetQuestState(EQuestState state, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_SinkOrSwim.NativeMethodInfoPtr_SetQuestState_Public_Virtual_Void_EQuestState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600268C RID: 9868 RVA: 0x000E9A04 File Offset: 0x000E7C04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117234, RefRangeEnd = 117235, XrefRangeStart = 117202, XrefRangeEnd = 117234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_SinkOrSwim.NativeMethodInfoPtr_UpdateName_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600268D RID: 9869 RVA: 0x000E9A38 File Offset: 0x000E7C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117235, XrefRangeEnd = 117243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_SinkOrSwim() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_SinkOrSwim.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600268E RID: 9870 RVA: 0x000155A2 File Offset: 0x000137A2
		public Quest_SinkOrSwim(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D2B RID: 3371
		// (get) Token: 0x0600268F RID: 9871 RVA: 0x000E9A74 File Offset: 0x000E7C74
		// (set) Token: 0x06002690 RID: 9872 RVA: 0x000155AB File Offset: 0x000137AB
		public unsafe static int DAYS_TO_COMPLETE
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Quest_SinkOrSwim.NativeFieldInfoPtr_DAYS_TO_COMPLETE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Quest_SinkOrSwim.NativeFieldInfoPtr_DAYS_TO_COMPLETE, (void*)(&value));
			}
		}

		// Token: 0x17000D2C RID: 3372
		// (get) Token: 0x06002691 RID: 9873 RVA: 0x000E9A90 File Offset: 0x000E7C90
		// (set) Token: 0x06002692 RID: 9874 RVA: 0x000155B9 File Offset: 0x000137B9
		public unsafe string QuestName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_SinkOrSwim.NativeFieldInfoPtr_QuestName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_SinkOrSwim.NativeFieldInfoPtr_QuestName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D2D RID: 3373
		// (get) Token: 0x06002693 RID: 9875 RVA: 0x000E9AB8 File Offset: 0x000E7CB8
		// (set) Token: 0x06002694 RID: 9876 RVA: 0x000155D8 File Offset: 0x000137D8
		public unsafe int NelsonCallTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_SinkOrSwim.NativeFieldInfoPtr_NelsonCallTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_SinkOrSwim.NativeFieldInfoPtr_NelsonCallTime)) = value;
			}
		}

		// Token: 0x17000D2E RID: 3374
		// (get) Token: 0x06002695 RID: 9877 RVA: 0x000E9AE0 File Offset: 0x000E7CE0
		// (set) Token: 0x06002696 RID: 9878 RVA: 0x000155F3 File Offset: 0x000137F3
		public unsafe Transform LoanSharkVehiclePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_SinkOrSwim.NativeFieldInfoPtr_LoanSharkVehiclePosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_SinkOrSwim.NativeFieldInfoPtr_LoanSharkVehiclePosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D2F RID: 3375
		// (get) Token: 0x06002697 RID: 9879 RVA: 0x000E9B10 File Offset: 0x000E7D10
		// (set) Token: 0x06002698 RID: 9880 RVA: 0x00015612 File Offset: 0x00013812
		public unsafe GameObject LoanSharkGraves
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_SinkOrSwim.NativeFieldInfoPtr_LoanSharkGraves);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_SinkOrSwim.NativeFieldInfoPtr_LoanSharkGraves), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019A0 RID: 6560
		private static readonly IntPtr NativeFieldInfoPtr_DAYS_TO_COMPLETE;

		// Token: 0x040019A1 RID: 6561
		private static readonly IntPtr NativeFieldInfoPtr_QuestName;

		// Token: 0x040019A2 RID: 6562
		private static readonly IntPtr NativeFieldInfoPtr_NelsonCallTime;

		// Token: 0x040019A3 RID: 6563
		private static readonly IntPtr NativeFieldInfoPtr_LoanSharkVehiclePosition;

		// Token: 0x040019A4 RID: 6564
		private static readonly IntPtr NativeFieldInfoPtr_LoanSharkGraves;

		// Token: 0x040019A5 RID: 6565
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040019A6 RID: 6566
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040019A7 RID: 6567
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x040019A8 RID: 6568
		private static readonly IntPtr NativeMethodInfoPtr_HourPass_Private_Void_0;

		// Token: 0x040019A9 RID: 6569
		private static readonly IntPtr NativeMethodInfoPtr_SleepStart_Private_Void_0;

		// Token: 0x040019AA RID: 6570
		private static readonly IntPtr NativeMethodInfoPtr_SpawnLoanSharkVehicle_Private_Void_0;

		// Token: 0x040019AB RID: 6571
		private static readonly IntPtr NativeMethodInfoPtr_CheckArrival_Private_Void_0;

		// Token: 0x040019AC RID: 6572
		private static readonly IntPtr NativeMethodInfoPtr_SetQuestState_Public_Virtual_Void_EQuestState_Boolean_0;

		// Token: 0x040019AD RID: 6573
		private static readonly IntPtr NativeMethodInfoPtr_UpdateName_Private_Void_0;

		// Token: 0x040019AE RID: 6574
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
