using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.NPCs.Schedules
{
	// Token: 0x020002E5 RID: 741
	public class NPCActionList : Object
	{
		// Token: 0x06003792 RID: 14226 RVA: 0x00124524 File Offset: 0x00122724
		// Note: this type is marked as 'beforefieldinit'.
		static NPCActionList()
		{
			Il2CppClassPointerStore<NPCActionList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Schedules", "NPCActionList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCActionList>.NativeClassPtr);
			NPCActionList.NativeFieldInfoPtr_actionList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCActionList>.NativeClassPtr, "actionList");
			NPCActionList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCActionList>.NativeClassPtr, 100669682);
		}

		// Token: 0x06003793 RID: 14227 RVA: 0x0012457C File Offset: 0x0012277C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140621, XrefRangeEnd = 140629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCActionList() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCActionList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCActionList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003794 RID: 14228 RVA: 0x0001CE78 File Offset: 0x0001B078
		public NPCActionList(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170011CD RID: 4557
		// (get) Token: 0x06003795 RID: 14229 RVA: 0x001245B8 File Offset: 0x001227B8
		// (set) Token: 0x06003796 RID: 14230 RVA: 0x0001CE81 File Offset: 0x0001B081
		public unsafe List<NPCAction> actionList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCActionList.NativeFieldInfoPtr_actionList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPCAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCActionList.NativeFieldInfoPtr_actionList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002483 RID: 9347
		private static readonly IntPtr NativeFieldInfoPtr_actionList;

		// Token: 0x04002484 RID: 9348
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
