using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.Messaging;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.Messages
{
	// Token: 0x020006AF RID: 1711
	public class DealWindowSelector : MonoBehaviour
	{
		// Token: 0x060099C2 RID: 39362 RVA: 0x002726F0 File Offset: 0x002708F0
		// Note: this type is marked as 'beforefieldinit'.
		static DealWindowSelector()
		{
			Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Messages", "DealWindowSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr);
			DealWindowSelector.NativeFieldInfoPtr_TIME_ARM_ROTATION_0000 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "TIME_ARM_ROTATION_0000");
			DealWindowSelector.NativeFieldInfoPtr_TIME_ARM_ROTATION_2400 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "TIME_ARM_ROTATION_2400");
			DealWindowSelector.NativeFieldInfoPtr_WINDOW_CUTOFF_MINS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "WINDOW_CUTOFF_MINS");
			DealWindowSelector.NativeFieldInfoPtr_OnSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "OnSelected");
			DealWindowSelector.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "<IsOpen>k__BackingField");
			DealWindowSelector.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "Container");
			DealWindowSelector.NativeFieldInfoPtr_MorningButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "MorningButton");
			DealWindowSelector.NativeFieldInfoPtr_AfternoonButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "AfternoonButton");
			DealWindowSelector.NativeFieldInfoPtr_NightButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "NightButton");
			DealWindowSelector.NativeFieldInfoPtr_LateNightButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "LateNightButton");
			DealWindowSelector.NativeFieldInfoPtr_CurrentTimeArm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "CurrentTimeArm");
			DealWindowSelector.NativeFieldInfoPtr_CurrentTimeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "CurrentTimeLabel");
			DealWindowSelector.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "callback");
			DealWindowSelector.NativeFieldInfoPtr_buttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "buttons");
			DealWindowSelector.NativeFieldInfoPtr_hintShown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "hintShown");
			DealWindowSelector.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100682254);
			DealWindowSelector.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100682255);
			DealWindowSelector.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100682256);
			DealWindowSelector.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100682257);
			DealWindowSelector.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100682258);
			DealWindowSelector.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_MSGConversation_Action_1_EDealWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100682259);
			DealWindowSelector.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100682260);
			DealWindowSelector.NativeMethodInfoPtr_UpdateTime_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100682261);
			DealWindowSelector.NativeMethodInfoPtr_UpdateWindowValidity_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100682262);
			DealWindowSelector.NativeMethodInfoPtr_Close_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100682263);
			DealWindowSelector.NativeMethodInfoPtr_ButtonClicked_Private_Void_EDealWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100682264);
			DealWindowSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100682265);
		}

		// Token: 0x17002F51 RID: 12113
		// (get) Token: 0x060099C3 RID: 39363 RVA: 0x0027293C File Offset: 0x00270B3C
		// (set) Token: 0x060099C4 RID: 39364 RVA: 0x00272978 File Offset: 0x00270B78
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060099C5 RID: 39365 RVA: 0x002729B8 File Offset: 0x00270BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274333, XrefRangeEnd = 274370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099C6 RID: 39366 RVA: 0x002729EC File Offset: 0x00270BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274370, XrefRangeEnd = 274372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099C7 RID: 39367 RVA: 0x00272A30 File Offset: 0x00270C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274372, XrefRangeEnd = 274373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099C8 RID: 39368 RVA: 0x00272A70 File Offset: 0x00270C70
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 274418, RefRangeEnd = 274425, XrefRangeStart = 274373, XrefRangeEnd = 274418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(bool open, MSGConversation conversation, Action<EDealWindow> callback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conversation);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_MSGConversation_Action_1_EDealWindow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099C9 RID: 39369 RVA: 0x00272AD4 File Offset: 0x00270CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274425, XrefRangeEnd = 274427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099CA RID: 39370 RVA: 0x00272B08 File Offset: 0x00270D08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 274438, RefRangeEnd = 274440, XrefRangeStart = 274427, XrefRangeEnd = 274438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr_UpdateTime_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099CB RID: 39371 RVA: 0x00272B3C File Offset: 0x00270D3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 274467, RefRangeEnd = 274469, XrefRangeStart = 274440, XrefRangeEnd = 274467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateWindowValidity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr_UpdateWindowValidity_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099CC RID: 39372 RVA: 0x00272B70 File Offset: 0x00270D70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274469, XrefRangeEnd = 274470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr_Close_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099CD RID: 39373 RVA: 0x00272BA4 File Offset: 0x00270DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274470, XrefRangeEnd = 274474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ButtonClicked(EDealWindow window)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref window;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr_ButtonClicked_Private_Void_EDealWindow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099CE RID: 39374 RVA: 0x00272BE4 File Offset: 0x00270DE4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DealWindowSelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099CF RID: 39375 RVA: 0x0004B06A File Offset: 0x0004926A
		public DealWindowSelector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002F42 RID: 12098
		// (get) Token: 0x060099D0 RID: 39376 RVA: 0x00272C20 File Offset: 0x00270E20
		// (set) Token: 0x060099D1 RID: 39377 RVA: 0x0004B073 File Offset: 0x00049273
		public unsafe static float TIME_ARM_ROTATION_0000
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DealWindowSelector.NativeFieldInfoPtr_TIME_ARM_ROTATION_0000, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DealWindowSelector.NativeFieldInfoPtr_TIME_ARM_ROTATION_0000, (void*)(&value));
			}
		}

		// Token: 0x17002F43 RID: 12099
		// (get) Token: 0x060099D2 RID: 39378 RVA: 0x00272C3C File Offset: 0x00270E3C
		// (set) Token: 0x060099D3 RID: 39379 RVA: 0x0004B081 File Offset: 0x00049281
		public unsafe static float TIME_ARM_ROTATION_2400
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DealWindowSelector.NativeFieldInfoPtr_TIME_ARM_ROTATION_2400, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DealWindowSelector.NativeFieldInfoPtr_TIME_ARM_ROTATION_2400, (void*)(&value));
			}
		}

		// Token: 0x17002F44 RID: 12100
		// (get) Token: 0x060099D4 RID: 39380 RVA: 0x00272C58 File Offset: 0x00270E58
		// (set) Token: 0x060099D5 RID: 39381 RVA: 0x0004B08F File Offset: 0x0004928F
		public unsafe static int WINDOW_CUTOFF_MINS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DealWindowSelector.NativeFieldInfoPtr_WINDOW_CUTOFF_MINS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DealWindowSelector.NativeFieldInfoPtr_WINDOW_CUTOFF_MINS, (void*)(&value));
			}
		}

		// Token: 0x17002F45 RID: 12101
		// (get) Token: 0x060099D6 RID: 39382 RVA: 0x00272C74 File Offset: 0x00270E74
		// (set) Token: 0x060099D7 RID: 39383 RVA: 0x0004B09D File Offset: 0x0004929D
		public unsafe UnityEvent<EDealWindow> OnSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_OnSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<EDealWindow>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_OnSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F46 RID: 12102
		// (get) Token: 0x060099D8 RID: 39384 RVA: 0x00272CA4 File Offset: 0x00270EA4
		// (set) Token: 0x060099D9 RID: 39385 RVA: 0x0004B0BC File Offset: 0x000492BC
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002F47 RID: 12103
		// (get) Token: 0x060099DA RID: 39386 RVA: 0x00272CCC File Offset: 0x00270ECC
		// (set) Token: 0x060099DB RID: 39387 RVA: 0x0004B0D7 File Offset: 0x000492D7
		public unsafe GameObject Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F48 RID: 12104
		// (get) Token: 0x060099DC RID: 39388 RVA: 0x00272CFC File Offset: 0x00270EFC
		// (set) Token: 0x060099DD RID: 39389 RVA: 0x0004B0F6 File Offset: 0x000492F6
		public unsafe WindowSelectorButton MorningButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_MorningButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WindowSelectorButton>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_MorningButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F49 RID: 12105
		// (get) Token: 0x060099DE RID: 39390 RVA: 0x00272D2C File Offset: 0x00270F2C
		// (set) Token: 0x060099DF RID: 39391 RVA: 0x0004B115 File Offset: 0x00049315
		public unsafe WindowSelectorButton AfternoonButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_AfternoonButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WindowSelectorButton>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_AfternoonButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F4A RID: 12106
		// (get) Token: 0x060099E0 RID: 39392 RVA: 0x00272D5C File Offset: 0x00270F5C
		// (set) Token: 0x060099E1 RID: 39393 RVA: 0x0004B134 File Offset: 0x00049334
		public unsafe WindowSelectorButton NightButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_NightButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WindowSelectorButton>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_NightButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F4B RID: 12107
		// (get) Token: 0x060099E2 RID: 39394 RVA: 0x00272D8C File Offset: 0x00270F8C
		// (set) Token: 0x060099E3 RID: 39395 RVA: 0x0004B153 File Offset: 0x00049353
		public unsafe WindowSelectorButton LateNightButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_LateNightButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WindowSelectorButton>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_LateNightButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F4C RID: 12108
		// (get) Token: 0x060099E4 RID: 39396 RVA: 0x00272DBC File Offset: 0x00270FBC
		// (set) Token: 0x060099E5 RID: 39397 RVA: 0x0004B172 File Offset: 0x00049372
		public unsafe RectTransform CurrentTimeArm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_CurrentTimeArm);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_CurrentTimeArm), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F4D RID: 12109
		// (get) Token: 0x060099E6 RID: 39398 RVA: 0x00272DEC File Offset: 0x00270FEC
		// (set) Token: 0x060099E7 RID: 39399 RVA: 0x0004B191 File Offset: 0x00049391
		public unsafe Text CurrentTimeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_CurrentTimeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_CurrentTimeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F4E RID: 12110
		// (get) Token: 0x060099E8 RID: 39400 RVA: 0x00272E1C File Offset: 0x0027101C
		// (set) Token: 0x060099E9 RID: 39401 RVA: 0x0004B1B0 File Offset: 0x000493B0
		public unsafe Action<EDealWindow> callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<EDealWindow>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F4F RID: 12111
		// (get) Token: 0x060099EA RID: 39402 RVA: 0x00272E4C File Offset: 0x0027104C
		// (set) Token: 0x060099EB RID: 39403 RVA: 0x0004B1CF File Offset: 0x000493CF
		public unsafe Il2CppReferenceArray<WindowSelectorButton> buttons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_buttons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WindowSelectorButton>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_buttons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F50 RID: 12112
		// (get) Token: 0x060099EC RID: 39404 RVA: 0x00272E7C File Offset: 0x0027107C
		// (set) Token: 0x060099ED RID: 39405 RVA: 0x0004B1EE File Offset: 0x000493EE
		public unsafe bool hintShown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_hintShown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_hintShown)) = value;
			}
		}

		// Token: 0x04006781 RID: 26497
		private static readonly IntPtr NativeFieldInfoPtr_TIME_ARM_ROTATION_0000;

		// Token: 0x04006782 RID: 26498
		private static readonly IntPtr NativeFieldInfoPtr_TIME_ARM_ROTATION_2400;

		// Token: 0x04006783 RID: 26499
		private static readonly IntPtr NativeFieldInfoPtr_WINDOW_CUTOFF_MINS;

		// Token: 0x04006784 RID: 26500
		private static readonly IntPtr NativeFieldInfoPtr_OnSelected;

		// Token: 0x04006785 RID: 26501
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04006786 RID: 26502
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006787 RID: 26503
		private static readonly IntPtr NativeFieldInfoPtr_MorningButton;

		// Token: 0x04006788 RID: 26504
		private static readonly IntPtr NativeFieldInfoPtr_AfternoonButton;

		// Token: 0x04006789 RID: 26505
		private static readonly IntPtr NativeFieldInfoPtr_NightButton;

		// Token: 0x0400678A RID: 26506
		private static readonly IntPtr NativeFieldInfoPtr_LateNightButton;

		// Token: 0x0400678B RID: 26507
		private static readonly IntPtr NativeFieldInfoPtr_CurrentTimeArm;

		// Token: 0x0400678C RID: 26508
		private static readonly IntPtr NativeFieldInfoPtr_CurrentTimeLabel;

		// Token: 0x0400678D RID: 26509
		private static readonly IntPtr NativeFieldInfoPtr_callback;

		// Token: 0x0400678E RID: 26510
		private static readonly IntPtr NativeFieldInfoPtr_buttons;

		// Token: 0x0400678F RID: 26511
		private static readonly IntPtr NativeFieldInfoPtr_hintShown;

		// Token: 0x04006790 RID: 26512
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04006791 RID: 26513
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x04006792 RID: 26514
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04006793 RID: 26515
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0;

		// Token: 0x04006794 RID: 26516
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0;

		// Token: 0x04006795 RID: 26517
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_MSGConversation_Action_1_EDealWindow_0;

		// Token: 0x04006796 RID: 26518
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04006797 RID: 26519
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTime_Private_Void_0;

		// Token: 0x04006798 RID: 26520
		private static readonly IntPtr NativeMethodInfoPtr_UpdateWindowValidity_Private_Void_0;

		// Token: 0x04006799 RID: 26521
		private static readonly IntPtr NativeMethodInfoPtr_Close_Private_Void_0;

		// Token: 0x0400679A RID: 26522
		private static readonly IntPtr NativeMethodInfoPtr_ButtonClicked_Private_Void_EDealWindow_0;

		// Token: 0x0400679B RID: 26523
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B7B RID: 2939
		[ObfuscatedName("ScheduleOne.UI.Phone.Messages.DealWindowSelector+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DB60 RID: 56160 RVA: 0x0033F120 File Offset: 0x0033D320
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<DealWindowSelector.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealWindowSelector.__c__DisplayClass18_0>.NativeClassPtr);
				DealWindowSelector.__c__DisplayClass18_0.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector.__c__DisplayClass18_0>.NativeClassPtr, "button");
				DealWindowSelector.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector.__c__DisplayClass18_0>.NativeClassPtr, "<>4__this");
				DealWindowSelector.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector.__c__DisplayClass18_0>.NativeClassPtr, 100682266);
				DealWindowSelector.__c__DisplayClass18_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector.__c__DisplayClass18_0>.NativeClassPtr, 100682267);
			}

			// Token: 0x0600DB61 RID: 56161 RVA: 0x0033F19C File Offset: 0x0033D39C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealWindowSelector.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB62 RID: 56162 RVA: 0x0033F1D8 File Offset: 0x0033D3D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274329, XrefRangeEnd = 274333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.__c__DisplayClass18_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB63 RID: 56163 RVA: 0x0006AD96 File Offset: 0x00068F96
			public __c__DisplayClass18_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700440A RID: 17418
			// (get) Token: 0x0600DB64 RID: 56164 RVA: 0x0033F20C File Offset: 0x0033D40C
			// (set) Token: 0x0600DB65 RID: 56165 RVA: 0x0006AD9F File Offset: 0x00068F9F
			public unsafe WindowSelectorButton button
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.__c__DisplayClass18_0.NativeFieldInfoPtr_button);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WindowSelectorButton>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.__c__DisplayClass18_0.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700440B RID: 17419
			// (get) Token: 0x0600DB66 RID: 56166 RVA: 0x0033F23C File Offset: 0x0033D43C
			// (set) Token: 0x0600DB67 RID: 56167 RVA: 0x0006ADBE File Offset: 0x00068FBE
			public unsafe DealWindowSelector __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DealWindowSelector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009325 RID: 37669
			private static readonly IntPtr NativeFieldInfoPtr_button;

			// Token: 0x04009326 RID: 37670
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009327 RID: 37671
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009328 RID: 37672
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__0_Internal_Void_0;
		}
	}
}
