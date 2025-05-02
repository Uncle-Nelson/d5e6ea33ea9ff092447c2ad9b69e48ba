using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200065D RID: 1629
	public class SleepCanvas : Singleton<SleepCanvas>
	{
		// Token: 0x0600915F RID: 37215 RVA: 0x00259094 File Offset: 0x00257294
		// Note: this type is marked as 'beforefieldinit'.
		static SleepCanvas()
		{
			Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "SleepCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr);
			SleepCanvas.NativeFieldInfoPtr_MaxSleepTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "MaxSleepTime");
			SleepCanvas.NativeFieldInfoPtr_MinSleepTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "MinSleepTime");
			SleepCanvas.NativeFieldInfoPtr__IsMenuOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "<IsMenuOpen>k__BackingField");
			SleepCanvas.NativeFieldInfoPtr__QueuedSleepMessage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "<QueuedSleepMessage>k__BackingField");
			SleepCanvas.NativeFieldInfoPtr_QueuedMessageDisplayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "QueuedMessageDisplayTime");
			SleepCanvas.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "Canvas");
			SleepCanvas.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "Container");
			SleepCanvas.NativeFieldInfoPtr_MenuContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "MenuContainer");
			SleepCanvas.NativeFieldInfoPtr_CurrentTimeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "CurrentTimeLabel");
			SleepCanvas.NativeFieldInfoPtr_IncreaseButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "IncreaseButton");
			SleepCanvas.NativeFieldInfoPtr_DecreaseButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "DecreaseButton");
			SleepCanvas.NativeFieldInfoPtr_EndTimeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "EndTimeLabel");
			SleepCanvas.NativeFieldInfoPtr_SleepButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "SleepButton");
			SleepCanvas.NativeFieldInfoPtr_SleepButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "SleepButtonLabel");
			SleepCanvas.NativeFieldInfoPtr_BlackOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "BlackOverlay");
			SleepCanvas.NativeFieldInfoPtr_SleepMessageLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "SleepMessageLabel");
			SleepCanvas.NativeFieldInfoPtr_SleepMessageGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "SleepMessageGroup");
			SleepCanvas.NativeFieldInfoPtr_TimeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "TimeLabel");
			SleepCanvas.NativeFieldInfoPtr_WakeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "WakeLabel");
			SleepCanvas.NativeFieldInfoPtr_WaitingForHostLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "WaitingForHostLabel");
			SleepCanvas.NativeFieldInfoPtr_onSleepFullyFaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "onSleepFullyFaded");
			SleepCanvas.NativeFieldInfoPtr_onSleepEndFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "onSleepEndFade");
			SleepCanvas.NativeFieldInfoPtr_queuedPostSleepEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "queuedPostSleepEvents");
			SleepCanvas.NativeMethodInfoPtr_get_IsMenuOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681302);
			SleepCanvas.NativeMethodInfoPtr_set_IsMenuOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681303);
			SleepCanvas.NativeMethodInfoPtr_get_QueuedSleepMessage_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681304);
			SleepCanvas.NativeMethodInfoPtr_set_QueuedSleepMessage_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681305);
			SleepCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681306);
			SleepCanvas.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681307);
			SleepCanvas.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681308);
			SleepCanvas.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681309);
			SleepCanvas.NativeMethodInfoPtr_AddPostSleepEvent_Public_Void_IPostSleepEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681310);
			SleepCanvas.NativeMethodInfoPtr_UpdateHourSetting_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681311);
			SleepCanvas.NativeMethodInfoPtr_UpdateTimeLabels_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681312);
			SleepCanvas.NativeMethodInfoPtr_UpdateSleepButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681313);
			SleepCanvas.NativeMethodInfoPtr_ChangeSleepAmount_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681314);
			SleepCanvas.NativeMethodInfoPtr_ClampWakeTime_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681315);
			SleepCanvas.NativeMethodInfoPtr_ClampTime_Private_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681316);
			SleepCanvas.NativeMethodInfoPtr_SleepButtonPressed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681317);
			SleepCanvas.NativeMethodInfoPtr_SleepStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681318);
			SleepCanvas.NativeMethodInfoPtr_LerpBlackOverlay_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681319);
			SleepCanvas.NativeMethodInfoPtr_QueueSleepMessage_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681320);
			SleepCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681321);
			SleepCanvas.NativeMethodInfoPtr__Awake_b__29_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681322);
			SleepCanvas.NativeMethodInfoPtr__Awake_b__29_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681323);
			SleepCanvas.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681324);
		}

		// Token: 0x17002CA2 RID: 11426
		// (get) Token: 0x06009160 RID: 37216 RVA: 0x0025945C File Offset: 0x0025765C
		// (set) Token: 0x06009161 RID: 37217 RVA: 0x00259498 File Offset: 0x00257698
		public unsafe bool IsMenuOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_get_IsMenuOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_set_IsMenuOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002CA3 RID: 11427
		// (get) Token: 0x06009162 RID: 37218 RVA: 0x002594D8 File Offset: 0x002576D8
		// (set) Token: 0x06009163 RID: 37219 RVA: 0x00259510 File Offset: 0x00257710
		public unsafe string QueuedSleepMessage
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19644, RefRangeEnd = 19658, XrefRangeStart = 19644, XrefRangeEnd = 19658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_get_QueuedSleepMessage_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 19659, RefRangeEnd = 19660, XrefRangeStart = 19659, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_set_QueuedSleepMessage_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009164 RID: 37220 RVA: 0x00259554 File Offset: 0x00257754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263278, XrefRangeEnd = 263331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SleepCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009165 RID: 37221 RVA: 0x00259590 File Offset: 0x00257790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263331, XrefRangeEnd = 263333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009166 RID: 37222 RVA: 0x002595D4 File Offset: 0x002577D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 263413, RefRangeEnd = 263416, XrefRangeStart = 263333, XrefRangeEnd = 263413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009167 RID: 37223 RVA: 0x00259614 File Offset: 0x00257814
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 263435, RefRangeEnd = 263436, XrefRangeStart = 263416, XrefRangeEnd = 263435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009168 RID: 37224 RVA: 0x00259648 File Offset: 0x00257848
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 263450, RefRangeEnd = 263452, XrefRangeStart = 263436, XrefRangeEnd = 263450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPostSleepEvent(IPostSleepEvent postSleepEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(postSleepEvent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_AddPostSleepEvent_Public_Void_IPostSleepEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009169 RID: 37225 RVA: 0x0025968C File Offset: 0x0025788C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263452, XrefRangeEnd = 263455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateHourSetting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_UpdateHourSetting_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600916A RID: 37226 RVA: 0x002596C0 File Offset: 0x002578C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263455, XrefRangeEnd = 263457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTimeLabels()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_UpdateTimeLabels_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600916B RID: 37227 RVA: 0x002596F4 File Offset: 0x002578F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263457, XrefRangeEnd = 263467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSleepButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_UpdateSleepButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600916C RID: 37228 RVA: 0x00259728 File Offset: 0x00257928
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 263478, RefRangeEnd = 263480, XrefRangeStart = 263467, XrefRangeEnd = 263478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeSleepAmount(int change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_ChangeSleepAmount_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600916D RID: 37229 RVA: 0x00259768 File Offset: 0x00257968
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 263489, RefRangeEnd = 263491, XrefRangeStart = 263480, XrefRangeEnd = 263489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ClampWakeTime(int time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_ClampWakeTime_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600916E RID: 37230 RVA: 0x002597B4 File Offset: 0x002579B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263491, XrefRangeEnd = 263493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ClampTime(int time, int startTime, int endTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_ClampTime_Private_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600916F RID: 37231 RVA: 0x0025981C File Offset: 0x00257A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263493, XrefRangeEnd = 263500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SleepButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_SleepButtonPressed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009170 RID: 37232 RVA: 0x00259850 File Offset: 0x00257A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263500, XrefRangeEnd = 263518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SleepStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_SleepStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009171 RID: 37233 RVA: 0x00259884 File Offset: 0x00257A84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 263531, RefRangeEnd = 263533, XrefRangeStart = 263518, XrefRangeEnd = 263531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LerpBlackOverlay(float transparency, float lerpTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref transparency;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lerpTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_LerpBlackOverlay_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009172 RID: 37234 RVA: 0x002598D0 File Offset: 0x00257AD0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 263554, RefRangeEnd = 263557, XrefRangeStart = 263533, XrefRangeEnd = 263554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueueSleepMessage(string message, float displayTime = 3f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref displayTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_QueueSleepMessage_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009173 RID: 37235 RVA: 0x00259920 File Offset: 0x00257B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263557, XrefRangeEnd = 263570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SleepCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009174 RID: 37236 RVA: 0x0025995C File Offset: 0x00257B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263570, XrefRangeEnd = 263571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__29_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr__Awake_b__29_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009175 RID: 37237 RVA: 0x00259990 File Offset: 0x00257B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263571, XrefRangeEnd = 263572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__29_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr__Awake_b__29_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009176 RID: 37238 RVA: 0x002599C4 File Offset: 0x00257BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263572, XrefRangeEnd = 263577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06009177 RID: 37239 RVA: 0x0004645F File Offset: 0x0004465F
		public SleepCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002C8B RID: 11403
		// (get) Token: 0x06009178 RID: 37240 RVA: 0x00259A04 File Offset: 0x00257C04
		// (set) Token: 0x06009179 RID: 37241 RVA: 0x00046468 File Offset: 0x00044668
		public unsafe static int MaxSleepTime
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(SleepCanvas.NativeFieldInfoPtr_MaxSleepTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SleepCanvas.NativeFieldInfoPtr_MaxSleepTime, (void*)(&value));
			}
		}

		// Token: 0x17002C8C RID: 11404
		// (get) Token: 0x0600917A RID: 37242 RVA: 0x00259A20 File Offset: 0x00257C20
		// (set) Token: 0x0600917B RID: 37243 RVA: 0x00046476 File Offset: 0x00044676
		public unsafe static int MinSleepTime
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(SleepCanvas.NativeFieldInfoPtr_MinSleepTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SleepCanvas.NativeFieldInfoPtr_MinSleepTime, (void*)(&value));
			}
		}

		// Token: 0x17002C8D RID: 11405
		// (get) Token: 0x0600917C RID: 37244 RVA: 0x00259A3C File Offset: 0x00257C3C
		// (set) Token: 0x0600917D RID: 37245 RVA: 0x00046484 File Offset: 0x00044684
		public unsafe bool _IsMenuOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr__IsMenuOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr__IsMenuOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002C8E RID: 11406
		// (get) Token: 0x0600917E RID: 37246 RVA: 0x00259A64 File Offset: 0x00257C64
		// (set) Token: 0x0600917F RID: 37247 RVA: 0x0004649F File Offset: 0x0004469F
		public unsafe string _QueuedSleepMessage_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr__QueuedSleepMessage_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr__QueuedSleepMessage_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002C8F RID: 11407
		// (get) Token: 0x06009180 RID: 37248 RVA: 0x00259A8C File Offset: 0x00257C8C
		// (set) Token: 0x06009181 RID: 37249 RVA: 0x000464BE File Offset: 0x000446BE
		public unsafe float QueuedMessageDisplayTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_QueuedMessageDisplayTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_QueuedMessageDisplayTime)) = value;
			}
		}

		// Token: 0x17002C90 RID: 11408
		// (get) Token: 0x06009182 RID: 37250 RVA: 0x00259AB4 File Offset: 0x00257CB4
		// (set) Token: 0x06009183 RID: 37251 RVA: 0x000464D9 File Offset: 0x000446D9
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C91 RID: 11409
		// (get) Token: 0x06009184 RID: 37252 RVA: 0x00259AE4 File Offset: 0x00257CE4
		// (set) Token: 0x06009185 RID: 37253 RVA: 0x000464F8 File Offset: 0x000446F8
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C92 RID: 11410
		// (get) Token: 0x06009186 RID: 37254 RVA: 0x00259B14 File Offset: 0x00257D14
		// (set) Token: 0x06009187 RID: 37255 RVA: 0x00046517 File Offset: 0x00044717
		public unsafe RectTransform MenuContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_MenuContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_MenuContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C93 RID: 11411
		// (get) Token: 0x06009188 RID: 37256 RVA: 0x00259B44 File Offset: 0x00257D44
		// (set) Token: 0x06009189 RID: 37257 RVA: 0x00046536 File Offset: 0x00044736
		public unsafe TextMeshProUGUI CurrentTimeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_CurrentTimeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_CurrentTimeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C94 RID: 11412
		// (get) Token: 0x0600918A RID: 37258 RVA: 0x00259B74 File Offset: 0x00257D74
		// (set) Token: 0x0600918B RID: 37259 RVA: 0x00046555 File Offset: 0x00044755
		public unsafe Button IncreaseButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_IncreaseButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_IncreaseButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C95 RID: 11413
		// (get) Token: 0x0600918C RID: 37260 RVA: 0x00259BA4 File Offset: 0x00257DA4
		// (set) Token: 0x0600918D RID: 37261 RVA: 0x00046574 File Offset: 0x00044774
		public unsafe Button DecreaseButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_DecreaseButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_DecreaseButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C96 RID: 11414
		// (get) Token: 0x0600918E RID: 37262 RVA: 0x00259BD4 File Offset: 0x00257DD4
		// (set) Token: 0x0600918F RID: 37263 RVA: 0x00046593 File Offset: 0x00044793
		public unsafe TextMeshProUGUI EndTimeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_EndTimeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_EndTimeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C97 RID: 11415
		// (get) Token: 0x06009190 RID: 37264 RVA: 0x00259C04 File Offset: 0x00257E04
		// (set) Token: 0x06009191 RID: 37265 RVA: 0x000465B2 File Offset: 0x000447B2
		public unsafe Button SleepButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_SleepButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_SleepButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C98 RID: 11416
		// (get) Token: 0x06009192 RID: 37266 RVA: 0x00259C34 File Offset: 0x00257E34
		// (set) Token: 0x06009193 RID: 37267 RVA: 0x000465D1 File Offset: 0x000447D1
		public unsafe TextMeshProUGUI SleepButtonLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_SleepButtonLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_SleepButtonLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C99 RID: 11417
		// (get) Token: 0x06009194 RID: 37268 RVA: 0x00259C64 File Offset: 0x00257E64
		// (set) Token: 0x06009195 RID: 37269 RVA: 0x000465F0 File Offset: 0x000447F0
		public unsafe Image BlackOverlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_BlackOverlay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_BlackOverlay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C9A RID: 11418
		// (get) Token: 0x06009196 RID: 37270 RVA: 0x00259C94 File Offset: 0x00257E94
		// (set) Token: 0x06009197 RID: 37271 RVA: 0x0004660F File Offset: 0x0004480F
		public unsafe TextMeshProUGUI SleepMessageLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_SleepMessageLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_SleepMessageLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C9B RID: 11419
		// (get) Token: 0x06009198 RID: 37272 RVA: 0x00259CC4 File Offset: 0x00257EC4
		// (set) Token: 0x06009199 RID: 37273 RVA: 0x0004662E File Offset: 0x0004482E
		public unsafe CanvasGroup SleepMessageGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_SleepMessageGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_SleepMessageGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C9C RID: 11420
		// (get) Token: 0x0600919A RID: 37274 RVA: 0x00259CF4 File Offset: 0x00257EF4
		// (set) Token: 0x0600919B RID: 37275 RVA: 0x0004664D File Offset: 0x0004484D
		public unsafe TextMeshProUGUI TimeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_TimeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_TimeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C9D RID: 11421
		// (get) Token: 0x0600919C RID: 37276 RVA: 0x00259D24 File Offset: 0x00257F24
		// (set) Token: 0x0600919D RID: 37277 RVA: 0x0004666C File Offset: 0x0004486C
		public unsafe TextMeshProUGUI WakeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_WakeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_WakeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C9E RID: 11422
		// (get) Token: 0x0600919E RID: 37278 RVA: 0x00259D54 File Offset: 0x00257F54
		// (set) Token: 0x0600919F RID: 37279 RVA: 0x0004668B File Offset: 0x0004488B
		public unsafe TextMeshProUGUI WaitingForHostLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_WaitingForHostLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_WaitingForHostLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C9F RID: 11423
		// (get) Token: 0x060091A0 RID: 37280 RVA: 0x00259D84 File Offset: 0x00257F84
		// (set) Token: 0x060091A1 RID: 37281 RVA: 0x000466AA File Offset: 0x000448AA
		public unsafe UnityEvent onSleepFullyFaded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_onSleepFullyFaded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_onSleepFullyFaded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CA0 RID: 11424
		// (get) Token: 0x060091A2 RID: 37282 RVA: 0x00259DB4 File Offset: 0x00257FB4
		// (set) Token: 0x060091A3 RID: 37283 RVA: 0x000466C9 File Offset: 0x000448C9
		public unsafe UnityEvent onSleepEndFade
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_onSleepEndFade);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_onSleepEndFade), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CA1 RID: 11425
		// (get) Token: 0x060091A4 RID: 37284 RVA: 0x00259DE4 File Offset: 0x00257FE4
		// (set) Token: 0x060091A5 RID: 37285 RVA: 0x000466E8 File Offset: 0x000448E8
		public unsafe List<IPostSleepEvent> queuedPostSleepEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_queuedPostSleepEvents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IPostSleepEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_queuedPostSleepEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400623F RID: 25151
		private static readonly IntPtr NativeFieldInfoPtr_MaxSleepTime;

		// Token: 0x04006240 RID: 25152
		private static readonly IntPtr NativeFieldInfoPtr_MinSleepTime;

		// Token: 0x04006241 RID: 25153
		private static readonly IntPtr NativeFieldInfoPtr__IsMenuOpen_k__BackingField;

		// Token: 0x04006242 RID: 25154
		private static readonly IntPtr NativeFieldInfoPtr__QueuedSleepMessage_k__BackingField;

		// Token: 0x04006243 RID: 25155
		private static readonly IntPtr NativeFieldInfoPtr_QueuedMessageDisplayTime;

		// Token: 0x04006244 RID: 25156
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04006245 RID: 25157
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006246 RID: 25158
		private static readonly IntPtr NativeFieldInfoPtr_MenuContainer;

		// Token: 0x04006247 RID: 25159
		private static readonly IntPtr NativeFieldInfoPtr_CurrentTimeLabel;

		// Token: 0x04006248 RID: 25160
		private static readonly IntPtr NativeFieldInfoPtr_IncreaseButton;

		// Token: 0x04006249 RID: 25161
		private static readonly IntPtr NativeFieldInfoPtr_DecreaseButton;

		// Token: 0x0400624A RID: 25162
		private static readonly IntPtr NativeFieldInfoPtr_EndTimeLabel;

		// Token: 0x0400624B RID: 25163
		private static readonly IntPtr NativeFieldInfoPtr_SleepButton;

		// Token: 0x0400624C RID: 25164
		private static readonly IntPtr NativeFieldInfoPtr_SleepButtonLabel;

		// Token: 0x0400624D RID: 25165
		private static readonly IntPtr NativeFieldInfoPtr_BlackOverlay;

		// Token: 0x0400624E RID: 25166
		private static readonly IntPtr NativeFieldInfoPtr_SleepMessageLabel;

		// Token: 0x0400624F RID: 25167
		private static readonly IntPtr NativeFieldInfoPtr_SleepMessageGroup;

		// Token: 0x04006250 RID: 25168
		private static readonly IntPtr NativeFieldInfoPtr_TimeLabel;

		// Token: 0x04006251 RID: 25169
		private static readonly IntPtr NativeFieldInfoPtr_WakeLabel;

		// Token: 0x04006252 RID: 25170
		private static readonly IntPtr NativeFieldInfoPtr_WaitingForHostLabel;

		// Token: 0x04006253 RID: 25171
		private static readonly IntPtr NativeFieldInfoPtr_onSleepFullyFaded;

		// Token: 0x04006254 RID: 25172
		private static readonly IntPtr NativeFieldInfoPtr_onSleepEndFade;

		// Token: 0x04006255 RID: 25173
		private static readonly IntPtr NativeFieldInfoPtr_queuedPostSleepEvents;

		// Token: 0x04006256 RID: 25174
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMenuOpen_Public_get_Boolean_0;

		// Token: 0x04006257 RID: 25175
		private static readonly IntPtr NativeMethodInfoPtr_set_IsMenuOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04006258 RID: 25176
		private static readonly IntPtr NativeMethodInfoPtr_get_QueuedSleepMessage_Public_get_String_0;

		// Token: 0x04006259 RID: 25177
		private static readonly IntPtr NativeMethodInfoPtr_set_QueuedSleepMessage_Protected_set_Void_String_0;

		// Token: 0x0400625A RID: 25178
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400625B RID: 25179
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x0400625C RID: 25180
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0;

		// Token: 0x0400625D RID: 25181
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x0400625E RID: 25182
		private static readonly IntPtr NativeMethodInfoPtr_AddPostSleepEvent_Public_Void_IPostSleepEvent_0;

		// Token: 0x0400625F RID: 25183
		private static readonly IntPtr NativeMethodInfoPtr_UpdateHourSetting_Private_Void_0;

		// Token: 0x04006260 RID: 25184
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTimeLabels_Private_Void_0;

		// Token: 0x04006261 RID: 25185
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSleepButton_Private_Void_0;

		// Token: 0x04006262 RID: 25186
		private static readonly IntPtr NativeMethodInfoPtr_ChangeSleepAmount_Private_Void_Int32_0;

		// Token: 0x04006263 RID: 25187
		private static readonly IntPtr NativeMethodInfoPtr_ClampWakeTime_Private_Int32_Int32_0;

		// Token: 0x04006264 RID: 25188
		private static readonly IntPtr NativeMethodInfoPtr_ClampTime_Private_Int32_Int32_Int32_Int32_0;

		// Token: 0x04006265 RID: 25189
		private static readonly IntPtr NativeMethodInfoPtr_SleepButtonPressed_Private_Void_0;

		// Token: 0x04006266 RID: 25190
		private static readonly IntPtr NativeMethodInfoPtr_SleepStart_Private_Void_0;

		// Token: 0x04006267 RID: 25191
		private static readonly IntPtr NativeMethodInfoPtr_LerpBlackOverlay_Private_Void_Single_Single_0;

		// Token: 0x04006268 RID: 25192
		private static readonly IntPtr NativeMethodInfoPtr_QueueSleepMessage_Public_Void_String_Single_0;

		// Token: 0x04006269 RID: 25193
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400626A RID: 25194
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__29_0_Private_Void_0;

		// Token: 0x0400626B RID: 25195
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__29_1_Private_Void_0;

		// Token: 0x0400626C RID: 25196
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000B43 RID: 2883
		[ObfuscatedName("ScheduleOne.UI.SleepCanvas+<<SleepStart>g__Sleep|41_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D902 RID: 55554 RVA: 0x00338278 File Offset: 0x00336478
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique()
			{
				Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "<<SleepStart>g__Sleep|41_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr);
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, "<>1__state");
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, "<>2__current");
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, "<>4__this");
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, "<>8__1");
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, "<>7__wrap1");
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, "<lerpTime>5__3");
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, "<i>5__4");
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, 100681325);
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, 100681326);
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, 100681327);
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, 100681328);
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, 100681329);
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, 100681330);
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, 100681331);
			}

			// Token: 0x0600D903 RID: 55555 RVA: 0x003383BC File Offset: 0x003365BC
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D904 RID: 55556 RVA: 0x00338404 File Offset: 0x00336604
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 262999, RefRangeEnd = 263000, XrefRangeStart = 262994, XrefRangeEnd = 262999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D905 RID: 55557 RVA: 0x00338438 File Offset: 0x00336638
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263000, XrefRangeEnd = 263231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D906 RID: 55558 RVA: 0x00338474 File Offset: 0x00336674
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 263234, RefRangeEnd = 263235, XrefRangeStart = 263231, XrefRangeEnd = 263234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700435A RID: 17242
			// (get) Token: 0x0600D907 RID: 55559 RVA: 0x003384A8 File Offset: 0x003366A8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D908 RID: 55560 RVA: 0x003384E8 File Offset: 0x003366E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263235, XrefRangeEnd = 263240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700435B RID: 17243
			// (get) Token: 0x0600D909 RID: 55561 RVA: 0x0033851C File Offset: 0x0033671C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D90A RID: 55562 RVA: 0x00069B6C File Offset: 0x00067D6C
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004353 RID: 17235
			// (get) Token: 0x0600D90B RID: 55563 RVA: 0x0033855C File Offset: 0x0033675C
			// (set) Token: 0x0600D90C RID: 55564 RVA: 0x00069B75 File Offset: 0x00067D75
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004354 RID: 17236
			// (get) Token: 0x0600D90D RID: 55565 RVA: 0x00338584 File Offset: 0x00336784
			// (set) Token: 0x0600D90E RID: 55566 RVA: 0x00069B90 File Offset: 0x00067D90
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004355 RID: 17237
			// (get) Token: 0x0600D90F RID: 55567 RVA: 0x003385B4 File Offset: 0x003367B4
			// (set) Token: 0x0600D910 RID: 55568 RVA: 0x00069BAF File Offset: 0x00067DAF
			public unsafe SleepCanvas __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SleepCanvas>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004356 RID: 17238
			// (get) Token: 0x0600D911 RID: 55569 RVA: 0x003385E4 File Offset: 0x003367E4
			// (set) Token: 0x0600D912 RID: 55570 RVA: 0x00069BCE File Offset: 0x00067DCE
			public unsafe SleepCanvas.__c__DisplayClass41_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SleepCanvas.__c__DisplayClass41_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004357 RID: 17239
			// (get) Token: 0x0600D913 RID: 55571 RVA: 0x00338614 File Offset: 0x00336814
			// (set) Token: 0x0600D914 RID: 55572 RVA: 0x00069BED File Offset: 0x00067DED
			public List<IPostSleepEvent>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___7__wrap1);
					return new List<IPostSleepEvent>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<IPostSleepEvent>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<IPostSleepEvent>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004358 RID: 17240
			// (get) Token: 0x0600D915 RID: 55573 RVA: 0x00338644 File Offset: 0x00336844
			// (set) Token: 0x0600D916 RID: 55574 RVA: 0x00069C1B File Offset: 0x00067E1B
			public unsafe float _lerpTime_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__3)) = value;
				}
			}

			// Token: 0x17004359 RID: 17241
			// (get) Token: 0x0600D917 RID: 55575 RVA: 0x0033866C File Offset: 0x0033686C
			// (set) Token: 0x0600D918 RID: 55576 RVA: 0x00069C36 File Offset: 0x00067E36
			public unsafe float _i_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr__i_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr__i_5__4)) = value;
				}
			}

			// Token: 0x040091CE RID: 37326
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040091CF RID: 37327
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040091D0 RID: 37328
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040091D1 RID: 37329
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x040091D2 RID: 37330
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040091D3 RID: 37331
			private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__3;

			// Token: 0x040091D4 RID: 37332
			private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

			// Token: 0x040091D5 RID: 37333
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040091D6 RID: 37334
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040091D7 RID: 37335
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040091D8 RID: 37336
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040091D9 RID: 37337
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040091DA RID: 37338
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040091DB RID: 37339
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B44 RID: 2884
		[ObfuscatedName("ScheduleOne.UI.SleepCanvas+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D919 RID: 55577 RVA: 0x00338694 File Offset: 0x00336894
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SleepCanvas.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SleepCanvas.__c>.NativeClassPtr);
				SleepCanvas.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c>.NativeClassPtr, "<>9");
				SleepCanvas.__c.NativeFieldInfoPtr___9__41_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c>.NativeClassPtr, "<>9__41_1");
				SleepCanvas.__c.NativeFieldInfoPtr___9__41_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c>.NativeClassPtr, "<>9__41_2");
				SleepCanvas.__c.NativeFieldInfoPtr___9__41_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c>.NativeClassPtr, "<>9__41_3");
				SleepCanvas.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c>.NativeClassPtr, 100681333);
				SleepCanvas.__c.NativeMethodInfoPtr__SleepStart_b__41_1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c>.NativeClassPtr, 100681334);
				SleepCanvas.__c.NativeMethodInfoPtr__SleepStart_b__41_2_Internal_Int32_IPostSleepEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c>.NativeClassPtr, 100681335);
				SleepCanvas.__c.NativeMethodInfoPtr__SleepStart_b__41_3_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c>.NativeClassPtr, 100681336);
			}

			// Token: 0x0600D91A RID: 55578 RVA: 0x00338760 File Offset: 0x00336960
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SleepCanvas.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D91B RID: 55579 RVA: 0x0033879C File Offset: 0x0033699C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263240, XrefRangeEnd = 263244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SleepStart_b__41_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c.NativeMethodInfoPtr__SleepStart_b__41_1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D91C RID: 55580 RVA: 0x003387D8 File Offset: 0x003369D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263244, XrefRangeEnd = 263248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _SleepStart_b__41_2(IPostSleepEvent x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c.NativeMethodInfoPtr__SleepStart_b__41_2_Internal_Int32_IPostSleepEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D91D RID: 55581 RVA: 0x00338828 File Offset: 0x00336A28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263248, XrefRangeEnd = 263252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SleepStart_b__41_3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c.NativeMethodInfoPtr__SleepStart_b__41_3_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D91E RID: 55582 RVA: 0x00069C51 File Offset: 0x00067E51
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700435C RID: 17244
			// (get) Token: 0x0600D91F RID: 55583 RVA: 0x00338864 File Offset: 0x00336A64
			// (set) Token: 0x0600D920 RID: 55584 RVA: 0x00069C5A File Offset: 0x00067E5A
			public unsafe static SleepCanvas.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SleepCanvas.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SleepCanvas.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SleepCanvas.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700435D RID: 17245
			// (get) Token: 0x0600D921 RID: 55585 RVA: 0x0033888C File Offset: 0x00336A8C
			// (set) Token: 0x0600D922 RID: 55586 RVA: 0x00069C6C File Offset: 0x00067E6C
			public unsafe static Func<bool> __9__41_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SleepCanvas.__c.NativeFieldInfoPtr___9__41_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SleepCanvas.__c.NativeFieldInfoPtr___9__41_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700435E RID: 17246
			// (get) Token: 0x0600D923 RID: 55587 RVA: 0x003388B4 File Offset: 0x00336AB4
			// (set) Token: 0x0600D924 RID: 55588 RVA: 0x00069C7E File Offset: 0x00067E7E
			public unsafe static Func<IPostSleepEvent, int> __9__41_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SleepCanvas.__c.NativeFieldInfoPtr___9__41_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IPostSleepEvent, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SleepCanvas.__c.NativeFieldInfoPtr___9__41_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700435F RID: 17247
			// (get) Token: 0x0600D925 RID: 55589 RVA: 0x003388DC File Offset: 0x00336ADC
			// (set) Token: 0x0600D926 RID: 55590 RVA: 0x00069C90 File Offset: 0x00067E90
			public unsafe static Func<bool> __9__41_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SleepCanvas.__c.NativeFieldInfoPtr___9__41_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SleepCanvas.__c.NativeFieldInfoPtr___9__41_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040091DC RID: 37340
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040091DD RID: 37341
			private static readonly IntPtr NativeFieldInfoPtr___9__41_1;

			// Token: 0x040091DE RID: 37342
			private static readonly IntPtr NativeFieldInfoPtr___9__41_2;

			// Token: 0x040091DF RID: 37343
			private static readonly IntPtr NativeFieldInfoPtr___9__41_3;

			// Token: 0x040091E0 RID: 37344
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040091E1 RID: 37345
			private static readonly IntPtr NativeMethodInfoPtr__SleepStart_b__41_1_Internal_Boolean_0;

			// Token: 0x040091E2 RID: 37346
			private static readonly IntPtr NativeMethodInfoPtr__SleepStart_b__41_2_Internal_Int32_IPostSleepEvent_0;

			// Token: 0x040091E3 RID: 37347
			private static readonly IntPtr NativeMethodInfoPtr__SleepStart_b__41_3_Internal_Boolean_0;
		}

		// Token: 0x02000B45 RID: 2885
		[ObfuscatedName("ScheduleOne.UI.SleepCanvas+<>c__DisplayClass41_0")]
		public sealed class __c__DisplayClass41_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D927 RID: 55591 RVA: 0x00338904 File Offset: 0x00336B04
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass41_0()
			{
				Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass41_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "<>c__DisplayClass41_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass41_0>.NativeClassPtr);
				SleepCanvas.__c__DisplayClass41_0.NativeFieldInfoPtr_pse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass41_0>.NativeClassPtr, "pse");
				SleepCanvas.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass41_0>.NativeClassPtr, 100681337);
				SleepCanvas.__c__DisplayClass41_0.NativeMethodInfoPtr__SleepStart_b__4_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass41_0>.NativeClassPtr, 100681338);
			}

			// Token: 0x0600D928 RID: 55592 RVA: 0x0033896C File Offset: 0x00336B6C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass41_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass41_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D929 RID: 55593 RVA: 0x003389A8 File Offset: 0x00336BA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263252, XrefRangeEnd = 263255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SleepStart_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c__DisplayClass41_0.NativeMethodInfoPtr__SleepStart_b__4_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D92A RID: 55594 RVA: 0x00069CA2 File Offset: 0x00067EA2
			public __c__DisplayClass41_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004360 RID: 17248
			// (get) Token: 0x0600D92B RID: 55595 RVA: 0x003389E4 File Offset: 0x00336BE4
			// (set) Token: 0x0600D92C RID: 55596 RVA: 0x00069CAB File Offset: 0x00067EAB
			public unsafe IPostSleepEvent pse
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass41_0.NativeFieldInfoPtr_pse);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPostSleepEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass41_0.NativeFieldInfoPtr_pse), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040091E4 RID: 37348
			private static readonly IntPtr NativeFieldInfoPtr_pse;

			// Token: 0x040091E5 RID: 37349
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040091E6 RID: 37350
			private static readonly IntPtr NativeMethodInfoPtr__SleepStart_b__4_Internal_Boolean_0;
		}

		// Token: 0x02000B46 RID: 2886
		[ObfuscatedName("ScheduleOne.UI.SleepCanvas+<>c__DisplayClass42_0")]
		public sealed class __c__DisplayClass42_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D92D RID: 55597 RVA: 0x00338A14 File Offset: 0x00336C14
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass42_0()
			{
				Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "<>c__DisplayClass42_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0>.NativeClassPtr);
				SleepCanvas.__c__DisplayClass42_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0>.NativeClassPtr, "<>4__this");
				SleepCanvas.__c__DisplayClass42_0.NativeFieldInfoPtr_transparency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0>.NativeClassPtr, "transparency");
				SleepCanvas.__c__DisplayClass42_0.NativeFieldInfoPtr_lerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0>.NativeClassPtr, "lerpTime");
				SleepCanvas.__c__DisplayClass42_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0>.NativeClassPtr, 100681339);
				SleepCanvas.__c__DisplayClass42_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0>.NativeClassPtr, 100681340);
			}

			// Token: 0x0600D92E RID: 55598 RVA: 0x00338AA4 File Offset: 0x00336CA4
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass42_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c__DisplayClass42_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D92F RID: 55599 RVA: 0x00338AE0 File Offset: 0x00336CE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263273, XrefRangeEnd = 263278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c__DisplayClass42_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D930 RID: 55600 RVA: 0x00069CCA File Offset: 0x00067ECA
			public __c__DisplayClass42_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004361 RID: 17249
			// (get) Token: 0x0600D931 RID: 55601 RVA: 0x00338B20 File Offset: 0x00336D20
			// (set) Token: 0x0600D932 RID: 55602 RVA: 0x00069CD3 File Offset: 0x00067ED3
			public unsafe SleepCanvas __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SleepCanvas>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004362 RID: 17250
			// (get) Token: 0x0600D933 RID: 55603 RVA: 0x00338B50 File Offset: 0x00336D50
			// (set) Token: 0x0600D934 RID: 55604 RVA: 0x00069CF2 File Offset: 0x00067EF2
			public unsafe float transparency
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.NativeFieldInfoPtr_transparency);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.NativeFieldInfoPtr_transparency)) = value;
				}
			}

			// Token: 0x17004363 RID: 17251
			// (get) Token: 0x0600D935 RID: 55605 RVA: 0x00338B78 File Offset: 0x00336D78
			// (set) Token: 0x0600D936 RID: 55606 RVA: 0x00069D0D File Offset: 0x00067F0D
			public unsafe float lerpTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.NativeFieldInfoPtr_lerpTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.NativeFieldInfoPtr_lerpTime)) = value;
				}
			}

			// Token: 0x040091E7 RID: 37351
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040091E8 RID: 37352
			private static readonly IntPtr NativeFieldInfoPtr_transparency;

			// Token: 0x040091E9 RID: 37353
			private static readonly IntPtr NativeFieldInfoPtr_lerpTime;

			// Token: 0x040091EA RID: 37354
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040091EB RID: 37355
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C78 RID: 3192
			[ObfuscatedName("ScheduleOne.UI.SleepCanvas+<>c__DisplayClass42_0+<<LerpBlackOverlay>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E5B9 RID: 58809 RVA: 0x0035CE60 File Offset: 0x0035B060
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique()
				{
					Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0>.NativeClassPtr, "<<LerpBlackOverlay>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr);
					SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr, "<>1__state");
					SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr, "<>2__current");
					SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr, "<>4__this");
					SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr__startColor_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr, "<startColor>5__2");
					SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr__endColor_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr, "<endColor>5__3");
					SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr, "<i>5__4");
					SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr, 100681341);
					SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr, 100681342);
					SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr, 100681343);
					SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr, 100681344);
					SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr, 100681345);
					SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr, 100681346);
				}

				// Token: 0x0600E5BA RID: 58810 RVA: 0x0035CF7C File Offset: 0x0035B17C
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E5BB RID: 58811 RVA: 0x0035CFC4 File Offset: 0x0035B1C4
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E5BC RID: 58812 RVA: 0x0035CFF8 File Offset: 0x0035B1F8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263255, XrefRangeEnd = 263268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004777 RID: 18295
				// (get) Token: 0x0600E5BD RID: 58813 RVA: 0x0035D034 File Offset: 0x0035B234
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E5BE RID: 58814 RVA: 0x0035D074 File Offset: 0x0035B274
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263268, XrefRangeEnd = 263273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004778 RID: 18296
				// (get) Token: 0x0600E5BF RID: 58815 RVA: 0x0035D0A8 File Offset: 0x0035B2A8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E5C0 RID: 58816 RVA: 0x000700E5 File Offset: 0x0006E2E5
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004771 RID: 18289
				// (get) Token: 0x0600E5C1 RID: 58817 RVA: 0x0035D0E8 File Offset: 0x0035B2E8
				// (set) Token: 0x0600E5C2 RID: 58818 RVA: 0x000700EE File Offset: 0x0006E2EE
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004772 RID: 18290
				// (get) Token: 0x0600E5C3 RID: 58819 RVA: 0x0035D110 File Offset: 0x0035B310
				// (set) Token: 0x0600E5C4 RID: 58820 RVA: 0x00070109 File Offset: 0x0006E309
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004773 RID: 18291
				// (get) Token: 0x0600E5C5 RID: 58821 RVA: 0x0035D140 File Offset: 0x0035B340
				// (set) Token: 0x0600E5C6 RID: 58822 RVA: 0x00070128 File Offset: 0x0006E328
				public unsafe SleepCanvas.__c__DisplayClass42_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<SleepCanvas.__c__DisplayClass42_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004774 RID: 18292
				// (get) Token: 0x0600E5C7 RID: 58823 RVA: 0x0035D170 File Offset: 0x0035B370
				// (set) Token: 0x0600E5C8 RID: 58824 RVA: 0x00070147 File Offset: 0x0006E347
				public unsafe Color _startColor_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr__startColor_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr__startColor_5__2)) = value;
					}
				}

				// Token: 0x17004775 RID: 18293
				// (get) Token: 0x0600E5C9 RID: 58825 RVA: 0x0035D198 File Offset: 0x0035B398
				// (set) Token: 0x0600E5CA RID: 58826 RVA: 0x00070162 File Offset: 0x0006E362
				public unsafe Color _endColor_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr__endColor_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr__endColor_5__3)) = value;
					}
				}

				// Token: 0x17004776 RID: 18294
				// (get) Token: 0x0600E5CB RID: 58827 RVA: 0x0035D1C0 File Offset: 0x0035B3C0
				// (set) Token: 0x0600E5CC RID: 58828 RVA: 0x0007017D File Offset: 0x0006E37D
				public unsafe float _i_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr__i_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr__i_5__4)) = value;
					}
				}

				// Token: 0x04009998 RID: 39320
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009999 RID: 39321
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400999A RID: 39322
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400999B RID: 39323
				private static readonly IntPtr NativeFieldInfoPtr__startColor_5__2;

				// Token: 0x0400999C RID: 39324
				private static readonly IntPtr NativeFieldInfoPtr__endColor_5__3;

				// Token: 0x0400999D RID: 39325
				private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

				// Token: 0x0400999E RID: 39326
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400999F RID: 39327
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040099A0 RID: 39328
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040099A1 RID: 39329
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040099A2 RID: 39330
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040099A3 RID: 39331
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
