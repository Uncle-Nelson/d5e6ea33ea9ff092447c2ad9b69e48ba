using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs.Behaviour;
using Il2CppSystem;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003DA RID: 986
	[Serializable]
	public class PatrolInstance : Object
	{
		// Token: 0x06004C40 RID: 19520 RVA: 0x0016F3AC File Offset: 0x0016D5AC
		// Note: this type is marked as 'beforefieldinit'.
		static PatrolInstance()
		{
			Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "PatrolInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr);
			PatrolInstance.NativeFieldInfoPtr_Route = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, "Route");
			PatrolInstance.NativeFieldInfoPtr_Members = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, "Members");
			PatrolInstance.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, "StartTime");
			PatrolInstance.NativeFieldInfoPtr_EndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, "EndTime");
			PatrolInstance.NativeFieldInfoPtr_IntensityRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, "IntensityRequirement");
			PatrolInstance.NativeFieldInfoPtr_OnlyIfCurfewEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, "OnlyIfCurfewEnabled");
			PatrolInstance.NativeFieldInfoPtr__ActiveGroup_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, "<ActiveGroup>k__BackingField");
			PatrolInstance.NativeMethodInfoPtr_get_ActiveGroup_Public_get_PatrolGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, 100672731);
			PatrolInstance.NativeMethodInfoPtr_set_ActiveGroup_Protected_set_Void_PatrolGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, 100672732);
			PatrolInstance.NativeMethodInfoPtr_Evaluate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, 100672733);
			PatrolInstance.NativeMethodInfoPtr_StartPatrol_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, 100672734);
			PatrolInstance.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, 100672735);
			PatrolInstance.NativeMethodInfoPtr_EndPatrol_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, 100672736);
			PatrolInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, 100672737);
		}

		// Token: 0x170016E8 RID: 5864
		// (get) Token: 0x06004C41 RID: 19521 RVA: 0x0016F4F4 File Offset: 0x0016D6F4
		// (set) Token: 0x06004C42 RID: 19522 RVA: 0x0016F534 File Offset: 0x0016D734
		public unsafe PatrolGroup ActiveGroup
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19644, RefRangeEnd = 19658, XrefRangeStart = 19644, XrefRangeEnd = 19658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolInstance.NativeMethodInfoPtr_get_ActiveGroup_Public_get_PatrolGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PatrolGroup>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 19659, RefRangeEnd = 19660, XrefRangeStart = 19659, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolInstance.NativeMethodInfoPtr_set_ActiveGroup_Protected_set_Void_PatrolGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004C43 RID: 19523 RVA: 0x0016F578 File Offset: 0x0016D778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165539, XrefRangeEnd = 165551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Evaluate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolInstance.NativeMethodInfoPtr_Evaluate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C44 RID: 19524 RVA: 0x0016F5AC File Offset: 0x0016D7AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 165579, RefRangeEnd = 165581, XrefRangeStart = 165551, XrefRangeEnd = 165579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartPatrol()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolInstance.NativeMethodInfoPtr_StartPatrol_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C45 RID: 19525 RVA: 0x0016F5E0 File Offset: 0x0016D7E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165581, XrefRangeEnd = 165603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolInstance.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C46 RID: 19526 RVA: 0x0016F614 File Offset: 0x0016D814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165603, XrefRangeEnd = 165620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndPatrol()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolInstance.NativeMethodInfoPtr_EndPatrol_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C47 RID: 19527 RVA: 0x0016F648 File Offset: 0x0016D848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165620, XrefRangeEnd = 165621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PatrolInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C48 RID: 19528 RVA: 0x00024A9C File Offset: 0x00022C9C
		public PatrolInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016E1 RID: 5857
		// (get) Token: 0x06004C49 RID: 19529 RVA: 0x0016F684 File Offset: 0x0016D884
		// (set) Token: 0x06004C4A RID: 19530 RVA: 0x00024AA5 File Offset: 0x00022CA5
		public unsafe FootPatrolRoute Route
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_Route);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootPatrolRoute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_Route), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016E2 RID: 5858
		// (get) Token: 0x06004C4B RID: 19531 RVA: 0x0016F6B4 File Offset: 0x0016D8B4
		// (set) Token: 0x06004C4C RID: 19532 RVA: 0x00024AC4 File Offset: 0x00022CC4
		public unsafe int Members
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_Members);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_Members)) = value;
			}
		}

		// Token: 0x170016E3 RID: 5859
		// (get) Token: 0x06004C4D RID: 19533 RVA: 0x0016F6DC File Offset: 0x0016D8DC
		// (set) Token: 0x06004C4E RID: 19534 RVA: 0x00024ADF File Offset: 0x00022CDF
		public unsafe int StartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_StartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_StartTime)) = value;
			}
		}

		// Token: 0x170016E4 RID: 5860
		// (get) Token: 0x06004C4F RID: 19535 RVA: 0x0016F704 File Offset: 0x0016D904
		// (set) Token: 0x06004C50 RID: 19536 RVA: 0x00024AFA File Offset: 0x00022CFA
		public unsafe int EndTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_EndTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_EndTime)) = value;
			}
		}

		// Token: 0x170016E5 RID: 5861
		// (get) Token: 0x06004C51 RID: 19537 RVA: 0x0016F72C File Offset: 0x0016D92C
		// (set) Token: 0x06004C52 RID: 19538 RVA: 0x00024B15 File Offset: 0x00022D15
		public unsafe int IntensityRequirement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_IntensityRequirement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_IntensityRequirement)) = value;
			}
		}

		// Token: 0x170016E6 RID: 5862
		// (get) Token: 0x06004C53 RID: 19539 RVA: 0x0016F754 File Offset: 0x0016D954
		// (set) Token: 0x06004C54 RID: 19540 RVA: 0x00024B30 File Offset: 0x00022D30
		public unsafe bool OnlyIfCurfewEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_OnlyIfCurfewEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_OnlyIfCurfewEnabled)) = value;
			}
		}

		// Token: 0x170016E7 RID: 5863
		// (get) Token: 0x06004C55 RID: 19541 RVA: 0x0016F77C File Offset: 0x0016D97C
		// (set) Token: 0x06004C56 RID: 19542 RVA: 0x00024B4B File Offset: 0x00022D4B
		public unsafe PatrolGroup _ActiveGroup_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr__ActiveGroup_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PatrolGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr__ActiveGroup_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003365 RID: 13157
		private static readonly IntPtr NativeFieldInfoPtr_Route;

		// Token: 0x04003366 RID: 13158
		private static readonly IntPtr NativeFieldInfoPtr_Members;

		// Token: 0x04003367 RID: 13159
		private static readonly IntPtr NativeFieldInfoPtr_StartTime;

		// Token: 0x04003368 RID: 13160
		private static readonly IntPtr NativeFieldInfoPtr_EndTime;

		// Token: 0x04003369 RID: 13161
		private static readonly IntPtr NativeFieldInfoPtr_IntensityRequirement;

		// Token: 0x0400336A RID: 13162
		private static readonly IntPtr NativeFieldInfoPtr_OnlyIfCurfewEnabled;

		// Token: 0x0400336B RID: 13163
		private static readonly IntPtr NativeFieldInfoPtr__ActiveGroup_k__BackingField;

		// Token: 0x0400336C RID: 13164
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveGroup_Public_get_PatrolGroup_0;

		// Token: 0x0400336D RID: 13165
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveGroup_Protected_set_Void_PatrolGroup_0;

		// Token: 0x0400336E RID: 13166
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Void_0;

		// Token: 0x0400336F RID: 13167
		private static readonly IntPtr NativeMethodInfoPtr_StartPatrol_Public_Void_0;

		// Token: 0x04003370 RID: 13168
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x04003371 RID: 13169
		private static readonly IntPtr NativeMethodInfoPtr_EndPatrol_Public_Void_0;

		// Token: 0x04003372 RID: 13170
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
