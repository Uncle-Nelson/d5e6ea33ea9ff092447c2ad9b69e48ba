using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Police;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003DC RID: 988
	[Serializable]
	public class SentryInstance : Object
	{
		// Token: 0x06004C76 RID: 19574 RVA: 0x0016FAD4 File Offset: 0x0016DCD4
		// Note: this type is marked as 'beforefieldinit'.
		static SentryInstance()
		{
			Il2CppClassPointerStore<SentryInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "SentryInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr);
			SentryInstance.NativeFieldInfoPtr_Location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, "Location");
			SentryInstance.NativeFieldInfoPtr_Members = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, "Members");
			SentryInstance.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, "StartTime");
			SentryInstance.NativeFieldInfoPtr_EndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, "EndTime");
			SentryInstance.NativeFieldInfoPtr_IntensityRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, "IntensityRequirement");
			SentryInstance.NativeFieldInfoPtr_OnlyIfCurfewEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, "OnlyIfCurfewEnabled");
			SentryInstance.NativeFieldInfoPtr_officers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, "officers");
			SentryInstance.NativeMethodInfoPtr_Evaluate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, 100672739);
			SentryInstance.NativeMethodInfoPtr_StartEntry_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, 100672740);
			SentryInstance.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, 100672741);
			SentryInstance.NativeMethodInfoPtr_EndSentry_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, 100672742);
			SentryInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, 100672743);
		}

		// Token: 0x06004C77 RID: 19575 RVA: 0x0016FBF4 File Offset: 0x0016DDF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165733, XrefRangeEnd = 165745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Evaluate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryInstance.NativeMethodInfoPtr_Evaluate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C78 RID: 19576 RVA: 0x0016FC28 File Offset: 0x0016DE28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 165782, RefRangeEnd = 165784, XrefRangeStart = 165745, XrefRangeEnd = 165782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartEntry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryInstance.NativeMethodInfoPtr_StartEntry_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C79 RID: 19577 RVA: 0x0016FC5C File Offset: 0x0016DE5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165784, XrefRangeEnd = 165790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryInstance.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C7A RID: 19578 RVA: 0x0016FC90 File Offset: 0x0016DE90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 165813, RefRangeEnd = 165814, XrefRangeStart = 165790, XrefRangeEnd = 165813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndSentry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryInstance.NativeMethodInfoPtr_EndSentry_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C7B RID: 19579 RVA: 0x0016FCC4 File Offset: 0x0016DEC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165814, XrefRangeEnd = 165822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SentryInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C7C RID: 19580 RVA: 0x00024C37 File Offset: 0x00022E37
		public SentryInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016F7 RID: 5879
		// (get) Token: 0x06004C7D RID: 19581 RVA: 0x0016FD00 File Offset: 0x0016DF00
		// (set) Token: 0x06004C7E RID: 19582 RVA: 0x00024C40 File Offset: 0x00022E40
		public unsafe SentryLocation Location
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_Location);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SentryLocation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_Location), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016F8 RID: 5880
		// (get) Token: 0x06004C7F RID: 19583 RVA: 0x0016FD30 File Offset: 0x0016DF30
		// (set) Token: 0x06004C80 RID: 19584 RVA: 0x00024C5F File Offset: 0x00022E5F
		public unsafe int Members
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_Members);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_Members)) = value;
			}
		}

		// Token: 0x170016F9 RID: 5881
		// (get) Token: 0x06004C81 RID: 19585 RVA: 0x0016FD58 File Offset: 0x0016DF58
		// (set) Token: 0x06004C82 RID: 19586 RVA: 0x00024C7A File Offset: 0x00022E7A
		public unsafe int StartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_StartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_StartTime)) = value;
			}
		}

		// Token: 0x170016FA RID: 5882
		// (get) Token: 0x06004C83 RID: 19587 RVA: 0x0016FD80 File Offset: 0x0016DF80
		// (set) Token: 0x06004C84 RID: 19588 RVA: 0x00024C95 File Offset: 0x00022E95
		public unsafe int EndTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_EndTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_EndTime)) = value;
			}
		}

		// Token: 0x170016FB RID: 5883
		// (get) Token: 0x06004C85 RID: 19589 RVA: 0x0016FDA8 File Offset: 0x0016DFA8
		// (set) Token: 0x06004C86 RID: 19590 RVA: 0x00024CB0 File Offset: 0x00022EB0
		public unsafe int IntensityRequirement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_IntensityRequirement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_IntensityRequirement)) = value;
			}
		}

		// Token: 0x170016FC RID: 5884
		// (get) Token: 0x06004C87 RID: 19591 RVA: 0x0016FDD0 File Offset: 0x0016DFD0
		// (set) Token: 0x06004C88 RID: 19592 RVA: 0x00024CCB File Offset: 0x00022ECB
		public unsafe bool OnlyIfCurfewEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_OnlyIfCurfewEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_OnlyIfCurfewEnabled)) = value;
			}
		}

		// Token: 0x170016FD RID: 5885
		// (get) Token: 0x06004C89 RID: 19593 RVA: 0x0016FDF8 File Offset: 0x0016DFF8
		// (set) Token: 0x06004C8A RID: 19594 RVA: 0x00024CE6 File Offset: 0x00022EE6
		public unsafe List<PoliceOfficer> officers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_officers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PoliceOfficer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_officers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003382 RID: 13186
		private static readonly IntPtr NativeFieldInfoPtr_Location;

		// Token: 0x04003383 RID: 13187
		private static readonly IntPtr NativeFieldInfoPtr_Members;

		// Token: 0x04003384 RID: 13188
		private static readonly IntPtr NativeFieldInfoPtr_StartTime;

		// Token: 0x04003385 RID: 13189
		private static readonly IntPtr NativeFieldInfoPtr_EndTime;

		// Token: 0x04003386 RID: 13190
		private static readonly IntPtr NativeFieldInfoPtr_IntensityRequirement;

		// Token: 0x04003387 RID: 13191
		private static readonly IntPtr NativeFieldInfoPtr_OnlyIfCurfewEnabled;

		// Token: 0x04003388 RID: 13192
		private static readonly IntPtr NativeFieldInfoPtr_officers;

		// Token: 0x04003389 RID: 13193
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Void_0;

		// Token: 0x0400338A RID: 13194
		private static readonly IntPtr NativeMethodInfoPtr_StartEntry_Public_Void_0;

		// Token: 0x0400338B RID: 13195
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x0400338C RID: 13196
		private static readonly IntPtr NativeMethodInfoPtr_EndSentry_Public_Void_0;

		// Token: 0x0400338D RID: 13197
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
