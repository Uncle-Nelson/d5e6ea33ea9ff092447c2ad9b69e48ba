using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001BA RID: 442
	public class Quest_ExpandingOperations : Quest
	{
		// Token: 0x0600263F RID: 9791 RVA: 0x000E8AC0 File Offset: 0x000E6CC0
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_ExpandingOperations()
		{
			Il2CppClassPointerStore<Quest_ExpandingOperations>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_ExpandingOperations");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_ExpandingOperations>.NativeClassPtr);
			Quest_ExpandingOperations.NativeFieldInfoPtr_SetUpGrowTentsEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_ExpandingOperations>.NativeClassPtr, "SetUpGrowTentsEntry");
			Quest_ExpandingOperations.NativeFieldInfoPtr_ReachCustomersEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_ExpandingOperations>.NativeClassPtr, "ReachCustomersEntry");
			Quest_ExpandingOperations.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_ExpandingOperations>.NativeClassPtr, 100667577);
			Quest_ExpandingOperations.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_ExpandingOperations>.NativeClassPtr, 100667578);
		}

		// Token: 0x06002640 RID: 9792 RVA: 0x000E8B40 File Offset: 0x000E6D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116862, XrefRangeEnd = 116895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_ExpandingOperations.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002641 RID: 9793 RVA: 0x000E8B7C File Offset: 0x000E6D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116895, XrefRangeEnd = 116899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_ExpandingOperations() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_ExpandingOperations>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_ExpandingOperations.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002642 RID: 9794 RVA: 0x00015376 File Offset: 0x00013576
		public Quest_ExpandingOperations(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D1B RID: 3355
		// (get) Token: 0x06002643 RID: 9795 RVA: 0x000E8BB8 File Offset: 0x000E6DB8
		// (set) Token: 0x06002644 RID: 9796 RVA: 0x0001537F File Offset: 0x0001357F
		public unsafe QuestEntry SetUpGrowTentsEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_ExpandingOperations.NativeFieldInfoPtr_SetUpGrowTentsEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_ExpandingOperations.NativeFieldInfoPtr_SetUpGrowTentsEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D1C RID: 3356
		// (get) Token: 0x06002645 RID: 9797 RVA: 0x000E8BE8 File Offset: 0x000E6DE8
		// (set) Token: 0x06002646 RID: 9798 RVA: 0x0001539E File Offset: 0x0001359E
		public unsafe QuestEntry ReachCustomersEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_ExpandingOperations.NativeFieldInfoPtr_ReachCustomersEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_ExpandingOperations.NativeFieldInfoPtr_ReachCustomersEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400197C RID: 6524
		private static readonly IntPtr NativeFieldInfoPtr_SetUpGrowTentsEntry;

		// Token: 0x0400197D RID: 6525
		private static readonly IntPtr NativeFieldInfoPtr_ReachCustomersEntry;

		// Token: 0x0400197E RID: 6526
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x0400197F RID: 6527
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
