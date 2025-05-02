using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.PlayerTasks;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000669 RID: 1641
	public class TaskManagerUI : Singleton<TaskManagerUI>
	{
		// Token: 0x060092A5 RID: 37541 RVA: 0x0025D074 File Offset: 0x0025B274
		// Note: this type is marked as 'beforefieldinit'.
		static TaskManagerUI()
		{
			Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "TaskManagerUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr);
			TaskManagerUI.NativeFieldInfoPtr_textShown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr, "textShown");
			TaskManagerUI.NativeFieldInfoPtr_inputPromptUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr, "inputPromptUI");
			TaskManagerUI.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr, "canvas");
			TaskManagerUI.NativeFieldInfoPtr_multiGrabIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr, "multiGrabIndicator");
			TaskManagerUI.NativeFieldInfoPtr_PackagingStationMK2TutorialDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr, "PackagingStationMK2TutorialDone");
			TaskManagerUI.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr, 100681502);
			TaskManagerUI.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr, 100681503);
			TaskManagerUI.NativeMethodInfoPtr_UpdateInstructionLabel_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr, 100681504);
			TaskManagerUI.NativeMethodInfoPtr_TaskStarted_Private_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr, 100681505);
			TaskManagerUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr, 100681506);
		}

		// Token: 0x060092A6 RID: 37542 RVA: 0x0025D16C File Offset: 0x0025B36C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265015, XrefRangeEnd = 265021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskManagerUI.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092A7 RID: 37543 RVA: 0x0025D1A8 File Offset: 0x0025B3A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265021, XrefRangeEnd = 265046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskManagerUI.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092A8 RID: 37544 RVA: 0x0025D1E4 File Offset: 0x0025B3E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265046, XrefRangeEnd = 265062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateInstructionLabel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskManagerUI.NativeMethodInfoPtr_UpdateInstructionLabel_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092A9 RID: 37545 RVA: 0x0025D220 File Offset: 0x0025B420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265062, XrefRangeEnd = 265087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TaskStarted(Task task)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskManagerUI.NativeMethodInfoPtr_TaskStarted_Private_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092AA RID: 37546 RVA: 0x0025D264 File Offset: 0x0025B464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265087, XrefRangeEnd = 265090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskManagerUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskManagerUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092AB RID: 37547 RVA: 0x00046F87 File Offset: 0x00045187
		public TaskManagerUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002CF2 RID: 11506
		// (get) Token: 0x060092AC RID: 37548 RVA: 0x0025D2A0 File Offset: 0x0025B4A0
		// (set) Token: 0x060092AD RID: 37549 RVA: 0x00046F90 File Offset: 0x00045190
		public unsafe bool textShown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManagerUI.NativeFieldInfoPtr_textShown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManagerUI.NativeFieldInfoPtr_textShown)) = value;
			}
		}

		// Token: 0x17002CF3 RID: 11507
		// (get) Token: 0x060092AE RID: 37550 RVA: 0x0025D2C8 File Offset: 0x0025B4C8
		// (set) Token: 0x060092AF RID: 37551 RVA: 0x00046FAB File Offset: 0x000451AB
		public unsafe GenericUIScreen inputPromptUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManagerUI.NativeFieldInfoPtr_inputPromptUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericUIScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManagerUI.NativeFieldInfoPtr_inputPromptUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CF4 RID: 11508
		// (get) Token: 0x060092B0 RID: 37552 RVA: 0x0025D2F8 File Offset: 0x0025B4F8
		// (set) Token: 0x060092B1 RID: 37553 RVA: 0x00046FCA File Offset: 0x000451CA
		public unsafe Canvas canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManagerUI.NativeFieldInfoPtr_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManagerUI.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CF5 RID: 11509
		// (get) Token: 0x060092B2 RID: 37554 RVA: 0x0025D328 File Offset: 0x0025B528
		// (set) Token: 0x060092B3 RID: 37555 RVA: 0x00046FE9 File Offset: 0x000451E9
		public unsafe RectTransform multiGrabIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManagerUI.NativeFieldInfoPtr_multiGrabIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManagerUI.NativeFieldInfoPtr_multiGrabIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CF6 RID: 11510
		// (get) Token: 0x060092B4 RID: 37556 RVA: 0x0025D358 File Offset: 0x0025B558
		// (set) Token: 0x060092B5 RID: 37557 RVA: 0x00047008 File Offset: 0x00045208
		public unsafe GenericUIScreen PackagingStationMK2TutorialDone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManagerUI.NativeFieldInfoPtr_PackagingStationMK2TutorialDone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericUIScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManagerUI.NativeFieldInfoPtr_PackagingStationMK2TutorialDone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006311 RID: 25361
		private static readonly IntPtr NativeFieldInfoPtr_textShown;

		// Token: 0x04006312 RID: 25362
		private static readonly IntPtr NativeFieldInfoPtr_inputPromptUI;

		// Token: 0x04006313 RID: 25363
		private static readonly IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x04006314 RID: 25364
		private static readonly IntPtr NativeFieldInfoPtr_multiGrabIndicator;

		// Token: 0x04006315 RID: 25365
		private static readonly IntPtr NativeFieldInfoPtr_PackagingStationMK2TutorialDone;

		// Token: 0x04006316 RID: 25366
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04006317 RID: 25367
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04006318 RID: 25368
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInstructionLabel_Protected_Virtual_New_Void_0;

		// Token: 0x04006319 RID: 25369
		private static readonly IntPtr NativeMethodInfoPtr_TaskStarted_Private_Void_Task_0;

		// Token: 0x0400631A RID: 25370
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
