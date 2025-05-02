using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001BE RID: 446
	public class Quest_NeedingTheGreen : Quest
	{
		// Token: 0x06002666 RID: 9830 RVA: 0x000E919C File Offset: 0x000E739C
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_NeedingTheGreen()
		{
			Il2CppClassPointerStore<Quest_NeedingTheGreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_NeedingTheGreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_NeedingTheGreen>.NativeClassPtr);
			Quest_NeedingTheGreen.NativeFieldInfoPtr_PrerequisiteQuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_NeedingTheGreen>.NativeClassPtr, "PrerequisiteQuests");
			Quest_NeedingTheGreen.NativeFieldInfoPtr_EarnEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_NeedingTheGreen>.NativeClassPtr, "EarnEntry");
			Quest_NeedingTheGreen.NativeFieldInfoPtr_LifetimeEarningsRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_NeedingTheGreen>.NativeClassPtr, "LifetimeEarningsRequirement");
			Quest_NeedingTheGreen.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_NeedingTheGreen>.NativeClassPtr, 100667591);
			Quest_NeedingTheGreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_NeedingTheGreen>.NativeClassPtr, 100667592);
		}

		// Token: 0x06002667 RID: 9831 RVA: 0x000E9230 File Offset: 0x000E7430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116973, XrefRangeEnd = 117003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_NeedingTheGreen.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002668 RID: 9832 RVA: 0x000E926C File Offset: 0x000E746C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117003, XrefRangeEnd = 117007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_NeedingTheGreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_NeedingTheGreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_NeedingTheGreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002669 RID: 9833 RVA: 0x000154C8 File Offset: 0x000136C8
		public Quest_NeedingTheGreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D25 RID: 3365
		// (get) Token: 0x0600266A RID: 9834 RVA: 0x000E92A8 File Offset: 0x000E74A8
		// (set) Token: 0x0600266B RID: 9835 RVA: 0x000154D1 File Offset: 0x000136D1
		public unsafe Il2CppReferenceArray<Quest> PrerequisiteQuests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_NeedingTheGreen.NativeFieldInfoPtr_PrerequisiteQuests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Quest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_NeedingTheGreen.NativeFieldInfoPtr_PrerequisiteQuests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D26 RID: 3366
		// (get) Token: 0x0600266C RID: 9836 RVA: 0x000E92D8 File Offset: 0x000E74D8
		// (set) Token: 0x0600266D RID: 9837 RVA: 0x000154F0 File Offset: 0x000136F0
		public unsafe QuestEntry EarnEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_NeedingTheGreen.NativeFieldInfoPtr_EarnEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_NeedingTheGreen.NativeFieldInfoPtr_EarnEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D27 RID: 3367
		// (get) Token: 0x0600266E RID: 9838 RVA: 0x000E9308 File Offset: 0x000E7508
		// (set) Token: 0x0600266F RID: 9839 RVA: 0x0001550F File Offset: 0x0001370F
		public unsafe float LifetimeEarningsRequirement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_NeedingTheGreen.NativeFieldInfoPtr_LifetimeEarningsRequirement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_NeedingTheGreen.NativeFieldInfoPtr_LifetimeEarningsRequirement)) = value;
			}
		}

		// Token: 0x04001991 RID: 6545
		private static readonly IntPtr NativeFieldInfoPtr_PrerequisiteQuests;

		// Token: 0x04001992 RID: 6546
		private static readonly IntPtr NativeFieldInfoPtr_EarnEntry;

		// Token: 0x04001993 RID: 6547
		private static readonly IntPtr NativeFieldInfoPtr_LifetimeEarningsRequirement;

		// Token: 0x04001994 RID: 6548
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x04001995 RID: 6549
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
