using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001B9 RID: 441
	public class Quest_Employees : Quest
	{
		// Token: 0x06002632 RID: 9778 RVA: 0x000E882C File Offset: 0x000E6A2C
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_Employees()
		{
			Il2CppClassPointerStore<Quest_Employees>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_Employees");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_Employees>.NativeClassPtr);
			Quest_Employees.NativeFieldInfoPtr_EmployeeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_Employees>.NativeClassPtr, "EmployeeType");
			Quest_Employees.NativeFieldInfoPtr_AssignBedEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_Employees>.NativeClassPtr, "AssignBedEntry");
			Quest_Employees.NativeFieldInfoPtr_PayEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_Employees>.NativeClassPtr, "PayEntry");
			Quest_Employees.NativeMethodInfoPtr_GetEmployees_Public_Abstract_Virtual_New_List_1_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Employees>.NativeClassPtr, 100667572);
			Quest_Employees.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Employees>.NativeClassPtr, 100667573);
			Quest_Employees.NativeMethodInfoPtr_AreAnyEmployeesAssignedBeds_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Employees>.NativeClassPtr, 100667574);
			Quest_Employees.NativeMethodInfoPtr_AreAnyEmployeesPaid_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Employees>.NativeClassPtr, 100667575);
			Quest_Employees.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Employees>.NativeClassPtr, 100667576);
		}

		// Token: 0x06002633 RID: 9779 RVA: 0x000E88FC File Offset: 0x000E6AFC
		[CallerCount(0)]
		public unsafe virtual List<Employee> GetEmployees()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_Employees.NativeMethodInfoPtr_GetEmployees_Public_Abstract_Virtual_New_List_1_Employee_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Employee>>(intPtr3) : null;
		}

		// Token: 0x06002634 RID: 9780 RVA: 0x000E8948 File Offset: 0x000E6B48
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 116831, RefRangeEnd = 116835, XrefRangeStart = 116825, XrefRangeEnd = 116831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_Employees.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002635 RID: 9781 RVA: 0x000E8984 File Offset: 0x000E6B84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 116849, RefRangeEnd = 116850, XrefRangeStart = 116835, XrefRangeEnd = 116849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreAnyEmployeesAssignedBeds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_Employees.NativeMethodInfoPtr_AreAnyEmployeesAssignedBeds_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002636 RID: 9782 RVA: 0x000E89C0 File Offset: 0x000E6BC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 116861, RefRangeEnd = 116862, XrefRangeStart = 116850, XrefRangeEnd = 116861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreAnyEmployeesPaid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_Employees.NativeMethodInfoPtr_AreAnyEmployeesPaid_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002637 RID: 9783 RVA: 0x000E89FC File Offset: 0x000E6BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_Employees() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_Employees>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_Employees.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002638 RID: 9784 RVA: 0x00015314 File Offset: 0x00013514
		public Quest_Employees(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D18 RID: 3352
		// (get) Token: 0x06002639 RID: 9785 RVA: 0x000E8A38 File Offset: 0x000E6C38
		// (set) Token: 0x0600263A RID: 9786 RVA: 0x0001531D File Offset: 0x0001351D
		public unsafe EEmployeeType EmployeeType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_Employees.NativeFieldInfoPtr_EmployeeType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_Employees.NativeFieldInfoPtr_EmployeeType)) = value;
			}
		}

		// Token: 0x17000D19 RID: 3353
		// (get) Token: 0x0600263B RID: 9787 RVA: 0x000E8A60 File Offset: 0x000E6C60
		// (set) Token: 0x0600263C RID: 9788 RVA: 0x00015338 File Offset: 0x00013538
		public unsafe QuestEntry AssignBedEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_Employees.NativeFieldInfoPtr_AssignBedEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_Employees.NativeFieldInfoPtr_AssignBedEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D1A RID: 3354
		// (get) Token: 0x0600263D RID: 9789 RVA: 0x000E8A90 File Offset: 0x000E6C90
		// (set) Token: 0x0600263E RID: 9790 RVA: 0x00015357 File Offset: 0x00013557
		public unsafe QuestEntry PayEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_Employees.NativeFieldInfoPtr_PayEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_Employees.NativeFieldInfoPtr_PayEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001974 RID: 6516
		private static readonly IntPtr NativeFieldInfoPtr_EmployeeType;

		// Token: 0x04001975 RID: 6517
		private static readonly IntPtr NativeFieldInfoPtr_AssignBedEntry;

		// Token: 0x04001976 RID: 6518
		private static readonly IntPtr NativeFieldInfoPtr_PayEntry;

		// Token: 0x04001977 RID: 6519
		private static readonly IntPtr NativeMethodInfoPtr_GetEmployees_Public_Abstract_Virtual_New_List_1_Employee_0;

		// Token: 0x04001978 RID: 6520
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x04001979 RID: 6521
		private static readonly IntPtr NativeMethodInfoPtr_AreAnyEmployeesAssignedBeds_Protected_Boolean_0;

		// Token: 0x0400197A RID: 6522
		private static readonly IntPtr NativeMethodInfoPtr_AreAnyEmployeesPaid_Protected_Boolean_0;

		// Token: 0x0400197B RID: 6523
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
