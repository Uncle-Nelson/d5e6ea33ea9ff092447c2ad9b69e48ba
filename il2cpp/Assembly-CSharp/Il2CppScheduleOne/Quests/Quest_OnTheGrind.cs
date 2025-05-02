using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001BF RID: 447
	public class Quest_OnTheGrind : Quest
	{
		// Token: 0x06002670 RID: 9840 RVA: 0x000E9330 File Offset: 0x000E7530
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_OnTheGrind()
		{
			Il2CppClassPointerStore<Quest_OnTheGrind>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_OnTheGrind");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_OnTheGrind>.NativeClassPtr);
			Quest_OnTheGrind.NativeFieldInfoPtr_CompleteDealsEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_OnTheGrind>.NativeClassPtr, "CompleteDealsEntry");
			Quest_OnTheGrind.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_OnTheGrind>.NativeClassPtr, 100667593);
			Quest_OnTheGrind.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_OnTheGrind>.NativeClassPtr, 100667594);
		}

		// Token: 0x06002671 RID: 9841 RVA: 0x000E939C File Offset: 0x000E759C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117007, XrefRangeEnd = 117025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_OnTheGrind.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002672 RID: 9842 RVA: 0x000E93D8 File Offset: 0x000E75D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117025, XrefRangeEnd = 117029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_OnTheGrind() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_OnTheGrind>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_OnTheGrind.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002673 RID: 9843 RVA: 0x0001552A File Offset: 0x0001372A
		public Quest_OnTheGrind(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D28 RID: 3368
		// (get) Token: 0x06002674 RID: 9844 RVA: 0x000E9414 File Offset: 0x000E7614
		// (set) Token: 0x06002675 RID: 9845 RVA: 0x00015533 File Offset: 0x00013733
		public unsafe QuestEntry CompleteDealsEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_OnTheGrind.NativeFieldInfoPtr_CompleteDealsEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_OnTheGrind.NativeFieldInfoPtr_CompleteDealsEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001996 RID: 6550
		private static readonly IntPtr NativeFieldInfoPtr_CompleteDealsEntry;

		// Token: 0x04001997 RID: 6551
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x04001998 RID: 6552
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
