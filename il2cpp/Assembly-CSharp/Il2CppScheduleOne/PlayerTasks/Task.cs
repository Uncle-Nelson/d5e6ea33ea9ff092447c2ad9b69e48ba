using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x02000201 RID: 513
	public class Task : Il2CppSystem.Object
	{
		// Token: 0x06002A8A RID: 10890 RVA: 0x000F7354 File Offset: 0x000F5554
		// Note: this type is marked as 'beforefieldinit'.
		static Task()
		{
			Il2CppClassPointerStore<Task>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "Task");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Task>.NativeClassPtr);
			Task.NativeFieldInfoPtr_ClickDetectionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "ClickDetectionRange");
			Task.NativeFieldInfoPtr_ClickDetectionRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "ClickDetectionRadius");
			Task.NativeFieldInfoPtr_MultiGrabRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "MultiGrabRadius");
			Task.NativeFieldInfoPtr_MultiGrabForceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "MultiGrabForceMultiplier");
			Task.NativeFieldInfoPtr__TaskName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "<TaskName>k__BackingField");
			Task.NativeFieldInfoPtr__CurrentInstruction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "<CurrentInstruction>k__BackingField");
			Task.NativeFieldInfoPtr__TaskActive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "<TaskActive>k__BackingField");
			Task.NativeFieldInfoPtr_ClickDetectionEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "ClickDetectionEnabled");
			Task.NativeFieldInfoPtr_Outcome = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "Outcome");
			Task.NativeFieldInfoPtr_onTaskSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "onTaskSuccess");
			Task.NativeFieldInfoPtr_onTaskFail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "onTaskFail");
			Task.NativeFieldInfoPtr_onTaskStop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "onTaskStop");
			Task.NativeFieldInfoPtr_clickable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "clickable");
			Task.NativeFieldInfoPtr_draggable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "draggable");
			Task.NativeFieldInfoPtr_constraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "constraint");
			Task.NativeFieldInfoPtr_hitDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "hitDistance");
			Task.NativeFieldInfoPtr_relativeHitOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "relativeHitOffset");
			Task.NativeFieldInfoPtr_multiDraggingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "multiDraggingEnabled");
			Task.NativeFieldInfoPtr_multiGrabProjectionPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "multiGrabProjectionPlane");
			Task.NativeFieldInfoPtr_multiDragTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "multiDragTargets");
			Task.NativeFieldInfoPtr_isMultiDragging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "isMultiDragging");
			Task.NativeFieldInfoPtr_forcedClickables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "forcedClickables");
			Task.NativeMethodInfoPtr_get_TaskName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668070);
			Task.NativeMethodInfoPtr_set_TaskName_Protected_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668071);
			Task.NativeMethodInfoPtr_get_CurrentInstruction_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668072);
			Task.NativeMethodInfoPtr_set_CurrentInstruction_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668073);
			Task.NativeMethodInfoPtr_get_TaskActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668074);
			Task.NativeMethodInfoPtr_set_TaskActive_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668075);
			Task.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668076);
			Task.NativeMethodInfoPtr_StopTask_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668077);
			Task.NativeMethodInfoPtr_Success_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668078);
			Task.NativeMethodInfoPtr_Fail_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668079);
			Task.NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668080);
			Task.NativeMethodInfoPtr_UpdateCursor_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668081);
			Task.NativeMethodInfoPtr_LateUpdate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668082);
			Task.NativeMethodInfoPtr_GetMultiDragOrigin_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668083);
			Task.NativeMethodInfoPtr_FixedUpdate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668084);
			Task.NativeMethodInfoPtr_ForceStartClick_Public_Void_Clickable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668085);
			Task.NativeMethodInfoPtr_ForceEndClick_Public_Void_Clickable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668086);
			Task.NativeMethodInfoPtr_UpdateDraggablePhysics_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668087);
			Task.NativeMethodInfoPtr_GetClickable_Protected_Virtual_New_Clickable_byref_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668088);
			Task.NativeMethodInfoPtr_EnableMultiDragging_Protected_Void_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668089);
		}

		// Token: 0x17000E42 RID: 3650
		// (get) Token: 0x06002A8B RID: 10891 RVA: 0x000F76CC File Offset: 0x000F58CC
		// (set) Token: 0x06002A8C RID: 10892 RVA: 0x000F7710 File Offset: 0x000F5910
		public unsafe virtual string TaskName
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_get_TaskName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_set_TaskName_Protected_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000E43 RID: 3651
		// (get) Token: 0x06002A8D RID: 10893 RVA: 0x000F7760 File Offset: 0x000F5960
		// (set) Token: 0x06002A8E RID: 10894 RVA: 0x000F7798 File Offset: 0x000F5998
		public unsafe string CurrentInstruction
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17399, RefRangeEnd = 17400, XrefRangeStart = 17399, XrefRangeEnd = 17400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_CurrentInstruction_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_set_CurrentInstruction_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000E44 RID: 3652
		// (get) Token: 0x06002A8F RID: 10895 RVA: 0x000F77DC File Offset: 0x000F59DC
		// (set) Token: 0x06002A90 RID: 10896 RVA: 0x000F7818 File Offset: 0x000F5A18
		public unsafe bool TaskActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_TaskActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 37992, RefRangeEnd = 38015, XrefRangeStart = 37992, XrefRangeEnd = 38015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_set_TaskActive_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A91 RID: 10897 RVA: 0x000F7858 File Offset: 0x000F5A58
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 120688, RefRangeEnd = 120702, XrefRangeStart = 120652, XrefRangeEnd = 120688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A92 RID: 10898 RVA: 0x000F7894 File Offset: 0x000F5A94
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 120726, RefRangeEnd = 120739, XrefRangeStart = 120702, XrefRangeEnd = 120726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_StopTask_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A93 RID: 10899 RVA: 0x000F78D0 File Offset: 0x000F5AD0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 120743, RefRangeEnd = 120750, XrefRangeStart = 120739, XrefRangeEnd = 120743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Success()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_Success_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A94 RID: 10900 RVA: 0x000F790C File Offset: 0x000F5B0C
		[CallerCount(0)]
		public unsafe virtual void Fail()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_Fail_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A95 RID: 10901 RVA: 0x000F7948 File Offset: 0x000F5B48
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 120780, RefRangeEnd = 120794, XrefRangeStart = 120750, XrefRangeEnd = 120780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A96 RID: 10902 RVA: 0x000F7984 File Offset: 0x000F5B84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 120805, RefRangeEnd = 120806, XrefRangeStart = 120794, XrefRangeEnd = 120805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateCursor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_UpdateCursor_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A97 RID: 10903 RVA: 0x000F79C0 File Offset: 0x000F5BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120806, XrefRangeEnd = 120850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_LateUpdate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A98 RID: 10904 RVA: 0x000F79FC File Offset: 0x000F5BFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 120874, RefRangeEnd = 120876, XrefRangeStart = 120850, XrefRangeEnd = 120874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetMultiDragOrigin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_GetMultiDragOrigin_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A99 RID: 10905 RVA: 0x000F7A38 File Offset: 0x000F5C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120876, XrefRangeEnd = 120956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_FixedUpdate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A9A RID: 10906 RVA: 0x000F7A74 File Offset: 0x000F5C74
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 120964, RefRangeEnd = 120967, XrefRangeStart = 120956, XrefRangeEnd = 120964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForceStartClick(Clickable _clickable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_clickable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_ForceStartClick_Public_Void_Clickable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A9B RID: 10907 RVA: 0x000F7AB8 File Offset: 0x000F5CB8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 120974, RefRangeEnd = 120981, XrefRangeStart = 120967, XrefRangeEnd = 120974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForceEndClick(Clickable _clickable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_clickable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_ForceEndClick_Public_Void_Clickable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A9C RID: 10908 RVA: 0x000F7AFC File Offset: 0x000F5CFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 121029, RefRangeEnd = 121030, XrefRangeStart = 120981, XrefRangeEnd = 121029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDraggablePhysics()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_UpdateDraggablePhysics_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A9D RID: 10909 RVA: 0x000F7B30 File Offset: 0x000F5D30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121030, XrefRangeEnd = 121064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Clickable GetClickable(out RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_GetClickable_Protected_Virtual_New_Clickable_byref_RaycastHit_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr3) : null;
		}

		// Token: 0x06002A9E RID: 10910 RVA: 0x000F7B88 File Offset: 0x000F5D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121064, XrefRangeEnd = 121065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableMultiDragging(Transform projectionPlane, float radius = 0.08f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(projectionPlane);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_EnableMultiDragging_Protected_Void_Transform_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A9F RID: 10911 RVA: 0x0001711B File Offset: 0x0001531B
		public Task(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E2C RID: 3628
		// (get) Token: 0x06002AA0 RID: 10912 RVA: 0x000F7BD8 File Offset: 0x000F5DD8
		// (set) Token: 0x06002AA1 RID: 10913 RVA: 0x00017124 File Offset: 0x00015324
		public unsafe static float ClickDetectionRange
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_ClickDetectionRange, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_ClickDetectionRange, (void*)(&value));
			}
		}

		// Token: 0x17000E2D RID: 3629
		// (get) Token: 0x06002AA2 RID: 10914 RVA: 0x000F7BF4 File Offset: 0x000F5DF4
		// (set) Token: 0x06002AA3 RID: 10915 RVA: 0x00017132 File Offset: 0x00015332
		public unsafe float ClickDetectionRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_ClickDetectionRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_ClickDetectionRadius)) = value;
			}
		}

		// Token: 0x17000E2E RID: 3630
		// (get) Token: 0x06002AA4 RID: 10916 RVA: 0x000F7C1C File Offset: 0x000F5E1C
		// (set) Token: 0x06002AA5 RID: 10917 RVA: 0x0001714D File Offset: 0x0001534D
		public unsafe float MultiGrabRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_MultiGrabRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_MultiGrabRadius)) = value;
			}
		}

		// Token: 0x17000E2F RID: 3631
		// (get) Token: 0x06002AA6 RID: 10918 RVA: 0x000F7C44 File Offset: 0x000F5E44
		// (set) Token: 0x06002AA7 RID: 10919 RVA: 0x00017168 File Offset: 0x00015368
		public unsafe static float MultiGrabForceMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_MultiGrabForceMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_MultiGrabForceMultiplier, (void*)(&value));
			}
		}

		// Token: 0x17000E30 RID: 3632
		// (get) Token: 0x06002AA8 RID: 10920 RVA: 0x000F7C60 File Offset: 0x000F5E60
		// (set) Token: 0x06002AA9 RID: 10921 RVA: 0x00017176 File Offset: 0x00015376
		public unsafe string _TaskName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr__TaskName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr__TaskName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E31 RID: 3633
		// (get) Token: 0x06002AAA RID: 10922 RVA: 0x000F7C88 File Offset: 0x000F5E88
		// (set) Token: 0x06002AAB RID: 10923 RVA: 0x00017195 File Offset: 0x00015395
		public unsafe string _CurrentInstruction_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr__CurrentInstruction_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr__CurrentInstruction_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E32 RID: 3634
		// (get) Token: 0x06002AAC RID: 10924 RVA: 0x000F7CB0 File Offset: 0x000F5EB0
		// (set) Token: 0x06002AAD RID: 10925 RVA: 0x000171B4 File Offset: 0x000153B4
		public unsafe bool _TaskActive_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr__TaskActive_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr__TaskActive_k__BackingField)) = value;
			}
		}

		// Token: 0x17000E33 RID: 3635
		// (get) Token: 0x06002AAE RID: 10926 RVA: 0x000F7CD8 File Offset: 0x000F5ED8
		// (set) Token: 0x06002AAF RID: 10927 RVA: 0x000171CF File Offset: 0x000153CF
		public unsafe bool ClickDetectionEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_ClickDetectionEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_ClickDetectionEnabled)) = value;
			}
		}

		// Token: 0x17000E34 RID: 3636
		// (get) Token: 0x06002AB0 RID: 10928 RVA: 0x000F7D00 File Offset: 0x000F5F00
		// (set) Token: 0x06002AB1 RID: 10929 RVA: 0x000171EA File Offset: 0x000153EA
		public unsafe Task.EOutcome Outcome
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_Outcome);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_Outcome)) = value;
			}
		}

		// Token: 0x17000E35 RID: 3637
		// (get) Token: 0x06002AB2 RID: 10930 RVA: 0x000F7D28 File Offset: 0x000F5F28
		// (set) Token: 0x06002AB3 RID: 10931 RVA: 0x00017205 File Offset: 0x00015405
		public unsafe Action onTaskSuccess
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_onTaskSuccess);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_onTaskSuccess), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E36 RID: 3638
		// (get) Token: 0x06002AB4 RID: 10932 RVA: 0x000F7D58 File Offset: 0x000F5F58
		// (set) Token: 0x06002AB5 RID: 10933 RVA: 0x00017224 File Offset: 0x00015424
		public unsafe Action onTaskFail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_onTaskFail);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_onTaskFail), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E37 RID: 3639
		// (get) Token: 0x06002AB6 RID: 10934 RVA: 0x000F7D88 File Offset: 0x000F5F88
		// (set) Token: 0x06002AB7 RID: 10935 RVA: 0x00017243 File Offset: 0x00015443
		public unsafe Action onTaskStop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_onTaskStop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_onTaskStop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E38 RID: 3640
		// (get) Token: 0x06002AB8 RID: 10936 RVA: 0x000F7DB8 File Offset: 0x000F5FB8
		// (set) Token: 0x06002AB9 RID: 10937 RVA: 0x00017262 File Offset: 0x00015462
		public unsafe Clickable clickable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_clickable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_clickable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E39 RID: 3641
		// (get) Token: 0x06002ABA RID: 10938 RVA: 0x000F7DE8 File Offset: 0x000F5FE8
		// (set) Token: 0x06002ABB RID: 10939 RVA: 0x00017281 File Offset: 0x00015481
		public unsafe Draggable draggable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_draggable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_draggable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E3A RID: 3642
		// (get) Token: 0x06002ABC RID: 10940 RVA: 0x000F7E18 File Offset: 0x000F6018
		// (set) Token: 0x06002ABD RID: 10941 RVA: 0x000172A0 File Offset: 0x000154A0
		public unsafe DraggableConstraint constraint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_constraint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DraggableConstraint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_constraint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E3B RID: 3643
		// (get) Token: 0x06002ABE RID: 10942 RVA: 0x000F7E48 File Offset: 0x000F6048
		// (set) Token: 0x06002ABF RID: 10943 RVA: 0x000172BF File Offset: 0x000154BF
		public unsafe float hitDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_hitDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_hitDistance)) = value;
			}
		}

		// Token: 0x17000E3C RID: 3644
		// (get) Token: 0x06002AC0 RID: 10944 RVA: 0x000F7E70 File Offset: 0x000F6070
		// (set) Token: 0x06002AC1 RID: 10945 RVA: 0x000172DA File Offset: 0x000154DA
		public unsafe Vector3 relativeHitOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_relativeHitOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_relativeHitOffset)) = value;
			}
		}

		// Token: 0x17000E3D RID: 3645
		// (get) Token: 0x06002AC2 RID: 10946 RVA: 0x000F7E98 File Offset: 0x000F6098
		// (set) Token: 0x06002AC3 RID: 10947 RVA: 0x000172F5 File Offset: 0x000154F5
		public unsafe bool multiDraggingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_multiDraggingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_multiDraggingEnabled)) = value;
			}
		}

		// Token: 0x17000E3E RID: 3646
		// (get) Token: 0x06002AC4 RID: 10948 RVA: 0x000F7EC0 File Offset: 0x000F60C0
		// (set) Token: 0x06002AC5 RID: 10949 RVA: 0x00017310 File Offset: 0x00015510
		public unsafe Transform multiGrabProjectionPlane
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_multiGrabProjectionPlane);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_multiGrabProjectionPlane), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E3F RID: 3647
		// (get) Token: 0x06002AC6 RID: 10950 RVA: 0x000F7EF0 File Offset: 0x000F60F0
		// (set) Token: 0x06002AC7 RID: 10951 RVA: 0x0001732F File Offset: 0x0001552F
		public unsafe List<Draggable> multiDragTargets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_multiDragTargets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Draggable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_multiDragTargets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E40 RID: 3648
		// (get) Token: 0x06002AC8 RID: 10952 RVA: 0x000F7F20 File Offset: 0x000F6120
		// (set) Token: 0x06002AC9 RID: 10953 RVA: 0x0001734E File Offset: 0x0001554E
		public unsafe bool isMultiDragging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_isMultiDragging);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_isMultiDragging)) = value;
			}
		}

		// Token: 0x17000E41 RID: 3649
		// (get) Token: 0x06002ACA RID: 10954 RVA: 0x000F7F48 File Offset: 0x000F6148
		// (set) Token: 0x06002ACB RID: 10955 RVA: 0x00017369 File Offset: 0x00015569
		public unsafe List<Clickable> forcedClickables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_forcedClickables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Clickable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_forcedClickables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C3A RID: 7226
		private static readonly IntPtr NativeFieldInfoPtr_ClickDetectionRange;

		// Token: 0x04001C3B RID: 7227
		private static readonly IntPtr NativeFieldInfoPtr_ClickDetectionRadius;

		// Token: 0x04001C3C RID: 7228
		private static readonly IntPtr NativeFieldInfoPtr_MultiGrabRadius;

		// Token: 0x04001C3D RID: 7229
		private static readonly IntPtr NativeFieldInfoPtr_MultiGrabForceMultiplier;

		// Token: 0x04001C3E RID: 7230
		private static readonly IntPtr NativeFieldInfoPtr__TaskName_k__BackingField;

		// Token: 0x04001C3F RID: 7231
		private static readonly IntPtr NativeFieldInfoPtr__CurrentInstruction_k__BackingField;

		// Token: 0x04001C40 RID: 7232
		private static readonly IntPtr NativeFieldInfoPtr__TaskActive_k__BackingField;

		// Token: 0x04001C41 RID: 7233
		private static readonly IntPtr NativeFieldInfoPtr_ClickDetectionEnabled;

		// Token: 0x04001C42 RID: 7234
		private static readonly IntPtr NativeFieldInfoPtr_Outcome;

		// Token: 0x04001C43 RID: 7235
		private static readonly IntPtr NativeFieldInfoPtr_onTaskSuccess;

		// Token: 0x04001C44 RID: 7236
		private static readonly IntPtr NativeFieldInfoPtr_onTaskFail;

		// Token: 0x04001C45 RID: 7237
		private static readonly IntPtr NativeFieldInfoPtr_onTaskStop;

		// Token: 0x04001C46 RID: 7238
		private static readonly IntPtr NativeFieldInfoPtr_clickable;

		// Token: 0x04001C47 RID: 7239
		private static readonly IntPtr NativeFieldInfoPtr_draggable;

		// Token: 0x04001C48 RID: 7240
		private static readonly IntPtr NativeFieldInfoPtr_constraint;

		// Token: 0x04001C49 RID: 7241
		private static readonly IntPtr NativeFieldInfoPtr_hitDistance;

		// Token: 0x04001C4A RID: 7242
		private static readonly IntPtr NativeFieldInfoPtr_relativeHitOffset;

		// Token: 0x04001C4B RID: 7243
		private static readonly IntPtr NativeFieldInfoPtr_multiDraggingEnabled;

		// Token: 0x04001C4C RID: 7244
		private static readonly IntPtr NativeFieldInfoPtr_multiGrabProjectionPlane;

		// Token: 0x04001C4D RID: 7245
		private static readonly IntPtr NativeFieldInfoPtr_multiDragTargets;

		// Token: 0x04001C4E RID: 7246
		private static readonly IntPtr NativeFieldInfoPtr_isMultiDragging;

		// Token: 0x04001C4F RID: 7247
		private static readonly IntPtr NativeFieldInfoPtr_forcedClickables;

		// Token: 0x04001C50 RID: 7248
		private static readonly IntPtr NativeMethodInfoPtr_get_TaskName_Public_Virtual_New_get_String_0;

		// Token: 0x04001C51 RID: 7249
		private static readonly IntPtr NativeMethodInfoPtr_set_TaskName_Protected_Virtual_New_set_Void_String_0;

		// Token: 0x04001C52 RID: 7250
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentInstruction_Public_get_String_0;

		// Token: 0x04001C53 RID: 7251
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentInstruction_Protected_set_Void_String_0;

		// Token: 0x04001C54 RID: 7252
		private static readonly IntPtr NativeMethodInfoPtr_get_TaskActive_Public_get_Boolean_0;

		// Token: 0x04001C55 RID: 7253
		private static readonly IntPtr NativeMethodInfoPtr_set_TaskActive_Private_set_Void_Boolean_0;

		// Token: 0x04001C56 RID: 7254
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001C57 RID: 7255
		private static readonly IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_New_Void_0;

		// Token: 0x04001C58 RID: 7256
		private static readonly IntPtr NativeMethodInfoPtr_Success_Public_Virtual_New_Void_0;

		// Token: 0x04001C59 RID: 7257
		private static readonly IntPtr NativeMethodInfoPtr_Fail_Public_Virtual_New_Void_0;

		// Token: 0x04001C5A RID: 7258
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0;

		// Token: 0x04001C5B RID: 7259
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCursor_Protected_Virtual_New_Void_0;

		// Token: 0x04001C5C RID: 7260
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Public_Virtual_New_Void_0;

		// Token: 0x04001C5D RID: 7261
		private static readonly IntPtr NativeMethodInfoPtr_GetMultiDragOrigin_Private_Vector3_0;

		// Token: 0x04001C5E RID: 7262
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Public_Virtual_New_Void_0;

		// Token: 0x04001C5F RID: 7263
		private static readonly IntPtr NativeMethodInfoPtr_ForceStartClick_Public_Void_Clickable_0;

		// Token: 0x04001C60 RID: 7264
		private static readonly IntPtr NativeMethodInfoPtr_ForceEndClick_Public_Void_Clickable_0;

		// Token: 0x04001C61 RID: 7265
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDraggablePhysics_Private_Void_0;

		// Token: 0x04001C62 RID: 7266
		private static readonly IntPtr NativeMethodInfoPtr_GetClickable_Protected_Virtual_New_Clickable_byref_RaycastHit_0;

		// Token: 0x04001C63 RID: 7267
		private static readonly IntPtr NativeMethodInfoPtr_EnableMultiDragging_Protected_Void_Transform_Single_0;

		// Token: 0x020008DF RID: 2271
		[OriginalName("Assembly-CSharp.dll", "", "EOutcome")]
		public enum EOutcome
		{
			// Token: 0x0400852A RID: 34090
			Cancelled,
			// Token: 0x0400852B RID: 34091
			Success,
			// Token: 0x0400852C RID: 34092
			Fail
		}
	}
}
