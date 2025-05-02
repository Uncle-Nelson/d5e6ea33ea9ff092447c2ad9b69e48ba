using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001B3 RID: 435
	public class Quest_Botanists : Quest_Employees
	{
		// Token: 0x06002607 RID: 9735 RVA: 0x000E7FA8 File Offset: 0x000E61A8
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_Botanists()
		{
			Il2CppClassPointerStore<Quest_Botanists>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_Botanists");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_Botanists>.NativeClassPtr);
			Quest_Botanists.NativeFieldInfoPtr_AssignSuppliesEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_Botanists>.NativeClassPtr, "AssignSuppliesEntry");
			Quest_Botanists.NativeFieldInfoPtr_AssignWorkEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_Botanists>.NativeClassPtr, "AssignWorkEntry");
			Quest_Botanists.NativeFieldInfoPtr_AssignDestinationEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_Botanists>.NativeClassPtr, "AssignDestinationEntry");
			Quest_Botanists.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Botanists>.NativeClassPtr, 100667555);
			Quest_Botanists.NativeMethodInfoPtr_GetEmployees_Public_Virtual_List_1_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Botanists>.NativeClassPtr, 100667556);
			Quest_Botanists.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Botanists>.NativeClassPtr, 100667557);
		}

		// Token: 0x06002608 RID: 9736 RVA: 0x000E8050 File Offset: 0x000E6250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116576, XrefRangeEnd = 116656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_Botanists.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002609 RID: 9737 RVA: 0x000E808C File Offset: 0x000E628C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116656, XrefRangeEnd = 116662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override List<Employee> GetEmployees()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_Botanists.NativeMethodInfoPtr_GetEmployees_Public_Virtual_List_1_Employee_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Employee>>(intPtr3) : null;
		}

		// Token: 0x0600260A RID: 9738 RVA: 0x000E80D8 File Offset: 0x000E62D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116662, XrefRangeEnd = 116666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_Botanists() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_Botanists>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_Botanists.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600260B RID: 9739 RVA: 0x00015205 File Offset: 0x00013405
		public Quest_Botanists(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D11 RID: 3345
		// (get) Token: 0x0600260C RID: 9740 RVA: 0x000E8114 File Offset: 0x000E6314
		// (set) Token: 0x0600260D RID: 9741 RVA: 0x0001520E File Offset: 0x0001340E
		public unsafe QuestEntry AssignSuppliesEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_Botanists.NativeFieldInfoPtr_AssignSuppliesEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_Botanists.NativeFieldInfoPtr_AssignSuppliesEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D12 RID: 3346
		// (get) Token: 0x0600260E RID: 9742 RVA: 0x000E8144 File Offset: 0x000E6344
		// (set) Token: 0x0600260F RID: 9743 RVA: 0x0001522D File Offset: 0x0001342D
		public unsafe QuestEntry AssignWorkEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_Botanists.NativeFieldInfoPtr_AssignWorkEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_Botanists.NativeFieldInfoPtr_AssignWorkEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D13 RID: 3347
		// (get) Token: 0x06002610 RID: 9744 RVA: 0x000E8174 File Offset: 0x000E6374
		// (set) Token: 0x06002611 RID: 9745 RVA: 0x0001524C File Offset: 0x0001344C
		public unsafe QuestEntry AssignDestinationEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_Botanists.NativeFieldInfoPtr_AssignDestinationEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_Botanists.NativeFieldInfoPtr_AssignDestinationEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400195C RID: 6492
		private static readonly IntPtr NativeFieldInfoPtr_AssignSuppliesEntry;

		// Token: 0x0400195D RID: 6493
		private static readonly IntPtr NativeFieldInfoPtr_AssignWorkEntry;

		// Token: 0x0400195E RID: 6494
		private static readonly IntPtr NativeFieldInfoPtr_AssignDestinationEntry;

		// Token: 0x0400195F RID: 6495
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x04001960 RID: 6496
		private static readonly IntPtr NativeMethodInfoPtr_GetEmployees_Public_Virtual_List_1_Employee_0;

		// Token: 0x04001961 RID: 6497
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
