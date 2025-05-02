using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.Misc;
using Il2CppScheduleOne.NPCs.CharacterClasses;
using Il2CppScheduleOne.ScriptableObjects;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001C3 RID: 451
	public class Quest_TheDeepEnd : Quest
	{
		// Token: 0x06002699 RID: 9881 RVA: 0x000E9B40 File Offset: 0x000E7D40
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_TheDeepEnd()
		{
			Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_TheDeepEnd");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr);
			Quest_TheDeepEnd.NativeFieldInfoPtr_MEETING_REMINDER_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, "MEETING_REMINDER_TIME");
			Quest_TheDeepEnd.NativeFieldInfoPtr_KIDNAP_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, "KIDNAP_TIME");
			Quest_TheDeepEnd.NativeFieldInfoPtr_kidnapQueued = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, "kidnapQueued");
			Quest_TheDeepEnd.NativeFieldInfoPtr_meetingSetup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, "meetingSetup");
			Quest_TheDeepEnd.NativeFieldInfoPtr_Thomas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, "Thomas");
			Quest_TheDeepEnd.NativeFieldInfoPtr_Gate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, "Gate");
			Quest_TheDeepEnd.NativeFieldInfoPtr_Switch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, "Switch");
			Quest_TheDeepEnd.NativeFieldInfoPtr_MeetingTeleportPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, "MeetingTeleportPoint");
			Quest_TheDeepEnd.NativeFieldInfoPtr_PostMeetingCall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, "PostMeetingCall");
			Quest_TheDeepEnd.NativeFieldInfoPtr_PostMeetingTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, "PostMeetingTrigger");
			Quest_TheDeepEnd.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, 100667610);
			Quest_TheDeepEnd.NativeMethodInfoPtr_Begin_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, 100667611);
			Quest_TheDeepEnd.NativeMethodInfoPtr_SetupFirstMeeting_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, 100667612);
			Quest_TheDeepEnd.NativeMethodInfoPtr_ThomasDialogueNodeDisplayed_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, 100667613);
			Quest_TheDeepEnd.NativeMethodInfoPtr_HourPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, 100667614);
			Quest_TheDeepEnd.NativeMethodInfoPtr_BeforeSleep_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, 100667615);
			Quest_TheDeepEnd.NativeMethodInfoPtr_SleepFadeOut_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, 100667616);
			Quest_TheDeepEnd.NativeMethodInfoPtr_SetQuestEntryState_Public_Virtual_Void_Int32_EQuestState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, 100667617);
			Quest_TheDeepEnd.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, 100667618);
			Quest_TheDeepEnd.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, 100667619);
		}

		// Token: 0x0600269A RID: 9882 RVA: 0x000E9D00 File Offset: 0x000E7F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117278, XrefRangeEnd = 117325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_TheDeepEnd.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600269B RID: 9883 RVA: 0x000E9D3C File Offset: 0x000E7F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117325, XrefRangeEnd = 117327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin(bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_TheDeepEnd.NativeMethodInfoPtr_Begin_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600269C RID: 9884 RVA: 0x000E9D88 File Offset: 0x000E7F88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 117340, RefRangeEnd = 117342, XrefRangeStart = 117327, XrefRangeEnd = 117340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupFirstMeeting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.NativeMethodInfoPtr_SetupFirstMeeting_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600269D RID: 9885 RVA: 0x000E9DBC File Offset: 0x000E7FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117342, XrefRangeEnd = 117365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThomasDialogueNodeDisplayed(string nodeLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(nodeLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.NativeMethodInfoPtr_ThomasDialogueNodeDisplayed_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600269E RID: 9886 RVA: 0x000E9E00 File Offset: 0x000E8000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117365, XrefRangeEnd = 117391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HourPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.NativeMethodInfoPtr_HourPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600269F RID: 9887 RVA: 0x000E9E34 File Offset: 0x000E8034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117391, XrefRangeEnd = 117398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeforeSleep()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.NativeMethodInfoPtr_BeforeSleep_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026A0 RID: 9888 RVA: 0x000E9E68 File Offset: 0x000E8068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117398, XrefRangeEnd = 117411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SleepFadeOut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.NativeMethodInfoPtr_SleepFadeOut_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026A1 RID: 9889 RVA: 0x000E9E9C File Offset: 0x000E809C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117411, XrefRangeEnd = 117416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetQuestEntryState(int entryIndex, EQuestState state, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref entryIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_TheDeepEnd.NativeMethodInfoPtr_SetQuestEntryState_Public_Virtual_Void_Int32_EQuestState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026A2 RID: 9890 RVA: 0x000E9F04 File Offset: 0x000E8104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117416, XrefRangeEnd = 117420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_TheDeepEnd() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026A3 RID: 9891 RVA: 0x000E9F40 File Offset: 0x000E8140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117420, XrefRangeEnd = 117425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060026A4 RID: 9892 RVA: 0x00015631 File Offset: 0x00013831
		public Quest_TheDeepEnd(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D30 RID: 3376
		// (get) Token: 0x060026A5 RID: 9893 RVA: 0x000E9F80 File Offset: 0x000E8180
		// (set) Token: 0x060026A6 RID: 9894 RVA: 0x0001563A File Offset: 0x0001383A
		public unsafe static float MEETING_REMINDER_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Quest_TheDeepEnd.NativeFieldInfoPtr_MEETING_REMINDER_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Quest_TheDeepEnd.NativeFieldInfoPtr_MEETING_REMINDER_TIME, (void*)(&value));
			}
		}

		// Token: 0x17000D31 RID: 3377
		// (get) Token: 0x060026A7 RID: 9895 RVA: 0x000E9F9C File Offset: 0x000E819C
		// (set) Token: 0x060026A8 RID: 9896 RVA: 0x00015648 File Offset: 0x00013848
		public unsafe static float KIDNAP_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Quest_TheDeepEnd.NativeFieldInfoPtr_KIDNAP_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Quest_TheDeepEnd.NativeFieldInfoPtr_KIDNAP_TIME, (void*)(&value));
			}
		}

		// Token: 0x17000D32 RID: 3378
		// (get) Token: 0x060026A9 RID: 9897 RVA: 0x000E9FB8 File Offset: 0x000E81B8
		// (set) Token: 0x060026AA RID: 9898 RVA: 0x00015656 File Offset: 0x00013856
		public unsafe bool kidnapQueued
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_kidnapQueued);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_kidnapQueued)) = value;
			}
		}

		// Token: 0x17000D33 RID: 3379
		// (get) Token: 0x060026AB RID: 9899 RVA: 0x000E9FE0 File Offset: 0x000E81E0
		// (set) Token: 0x060026AC RID: 9900 RVA: 0x00015671 File Offset: 0x00013871
		public unsafe bool meetingSetup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_meetingSetup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_meetingSetup)) = value;
			}
		}

		// Token: 0x17000D34 RID: 3380
		// (get) Token: 0x060026AD RID: 9901 RVA: 0x000EA008 File Offset: 0x000E8208
		// (set) Token: 0x060026AE RID: 9902 RVA: 0x0001568C File Offset: 0x0001388C
		public unsafe Thomas Thomas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_Thomas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Thomas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_Thomas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D35 RID: 3381
		// (get) Token: 0x060026AF RID: 9903 RVA: 0x000EA038 File Offset: 0x000E8238
		// (set) Token: 0x060026B0 RID: 9904 RVA: 0x000156AB File Offset: 0x000138AB
		public unsafe ManorGate Gate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_Gate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManorGate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_Gate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D36 RID: 3382
		// (get) Token: 0x060026B1 RID: 9905 RVA: 0x000EA068 File Offset: 0x000E8268
		// (set) Token: 0x060026B2 RID: 9906 RVA: 0x000156CA File Offset: 0x000138CA
		public unsafe ModularSwitch Switch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_Switch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ModularSwitch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_Switch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D37 RID: 3383
		// (get) Token: 0x060026B3 RID: 9907 RVA: 0x000EA098 File Offset: 0x000E8298
		// (set) Token: 0x060026B4 RID: 9908 RVA: 0x000156E9 File Offset: 0x000138E9
		public unsafe Transform MeetingTeleportPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_MeetingTeleportPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_MeetingTeleportPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D38 RID: 3384
		// (get) Token: 0x060026B5 RID: 9909 RVA: 0x000EA0C8 File Offset: 0x000E82C8
		// (set) Token: 0x060026B6 RID: 9910 RVA: 0x00015708 File Offset: 0x00013908
		public unsafe PhoneCallData PostMeetingCall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_PostMeetingCall);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhoneCallData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_PostMeetingCall), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D39 RID: 3385
		// (get) Token: 0x060026B7 RID: 9911 RVA: 0x000EA0F8 File Offset: 0x000E82F8
		// (set) Token: 0x060026B8 RID: 9912 RVA: 0x00015727 File Offset: 0x00013927
		public unsafe SystemTriggerObject PostMeetingTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_PostMeetingTrigger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SystemTriggerObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_PostMeetingTrigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019AF RID: 6575
		private static readonly IntPtr NativeFieldInfoPtr_MEETING_REMINDER_TIME;

		// Token: 0x040019B0 RID: 6576
		private static readonly IntPtr NativeFieldInfoPtr_KIDNAP_TIME;

		// Token: 0x040019B1 RID: 6577
		private static readonly IntPtr NativeFieldInfoPtr_kidnapQueued;

		// Token: 0x040019B2 RID: 6578
		private static readonly IntPtr NativeFieldInfoPtr_meetingSetup;

		// Token: 0x040019B3 RID: 6579
		private static readonly IntPtr NativeFieldInfoPtr_Thomas;

		// Token: 0x040019B4 RID: 6580
		private static readonly IntPtr NativeFieldInfoPtr_Gate;

		// Token: 0x040019B5 RID: 6581
		private static readonly IntPtr NativeFieldInfoPtr_Switch;

		// Token: 0x040019B6 RID: 6582
		private static readonly IntPtr NativeFieldInfoPtr_MeetingTeleportPoint;

		// Token: 0x040019B7 RID: 6583
		private static readonly IntPtr NativeFieldInfoPtr_PostMeetingCall;

		// Token: 0x040019B8 RID: 6584
		private static readonly IntPtr NativeFieldInfoPtr_PostMeetingTrigger;

		// Token: 0x040019B9 RID: 6585
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040019BA RID: 6586
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Virtual_Void_Boolean_0;

		// Token: 0x040019BB RID: 6587
		private static readonly IntPtr NativeMethodInfoPtr_SetupFirstMeeting_Public_Void_0;

		// Token: 0x040019BC RID: 6588
		private static readonly IntPtr NativeMethodInfoPtr_ThomasDialogueNodeDisplayed_Private_Void_String_0;

		// Token: 0x040019BD RID: 6589
		private static readonly IntPtr NativeMethodInfoPtr_HourPass_Private_Void_0;

		// Token: 0x040019BE RID: 6590
		private static readonly IntPtr NativeMethodInfoPtr_BeforeSleep_Private_Void_0;

		// Token: 0x040019BF RID: 6591
		private static readonly IntPtr NativeMethodInfoPtr_SleepFadeOut_Private_Void_0;

		// Token: 0x040019C0 RID: 6592
		private static readonly IntPtr NativeMethodInfoPtr_SetQuestEntryState_Public_Virtual_Void_Int32_EQuestState_Boolean_0;

		// Token: 0x040019C1 RID: 6593
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040019C2 RID: 6594
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x020008D3 RID: 2259
		[ObfuscatedName("ScheduleOne.Quests.Quest_TheDeepEnd+<<ThomasDialogueNodeDisplayed>g__Wait|13_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600C42B RID: 50219 RVA: 0x002FCD64 File Offset: 0x002FAF64
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique()
			{
				Il2CppClassPointerStore<Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, "<<ThomasDialogueNodeDisplayed>g__Wait|13_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique>.NativeClassPtr);
				Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique>.NativeClassPtr, "<>1__state");
				Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique>.NativeClassPtr, "<>2__current");
				Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique>.NativeClassPtr, "<>4__this");
				Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique>.NativeClassPtr, 100667620);
				Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique>.NativeClassPtr, 100667621);
				Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique>.NativeClassPtr, 100667622);
				Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique>.NativeClassPtr, 100667623);
				Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique>.NativeClassPtr, 100667624);
				Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique>.NativeClassPtr, 100667625);
			}

			// Token: 0x0600C42C RID: 50220 RVA: 0x002FCE44 File Offset: 0x002FB044
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C42D RID: 50221 RVA: 0x002FCE8C File Offset: 0x002FB08C
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C42E RID: 50222 RVA: 0x002FCEC0 File Offset: 0x002FB0C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117243, XrefRangeEnd = 117264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003D3D RID: 15677
			// (get) Token: 0x0600C42F RID: 50223 RVA: 0x002FCEFC File Offset: 0x002FB0FC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C430 RID: 50224 RVA: 0x002FCF3C File Offset: 0x002FB13C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117264, XrefRangeEnd = 117269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003D3E RID: 15678
			// (get) Token: 0x0600C431 RID: 50225 RVA: 0x002FCF70 File Offset: 0x002FB170
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C432 RID: 50226 RVA: 0x0005F7BA File Offset: 0x0005D9BA
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D3A RID: 15674
			// (get) Token: 0x0600C433 RID: 50227 RVA: 0x002FCFB0 File Offset: 0x002FB1B0
			// (set) Token: 0x0600C434 RID: 50228 RVA: 0x0005F7C3 File Offset: 0x0005D9C3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003D3B RID: 15675
			// (get) Token: 0x0600C435 RID: 50229 RVA: 0x002FCFD8 File Offset: 0x002FB1D8
			// (set) Token: 0x0600C436 RID: 50230 RVA: 0x0005F7DE File Offset: 0x0005D9DE
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D3C RID: 15676
			// (get) Token: 0x0600C437 RID: 50231 RVA: 0x002FD008 File Offset: 0x002FB208
			// (set) Token: 0x0600C438 RID: 50232 RVA: 0x0005F7FD File Offset: 0x0005D9FD
			public unsafe Quest_TheDeepEnd __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quest_TheDeepEnd>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040084F4 RID: 34036
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040084F5 RID: 34037
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040084F6 RID: 34038
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040084F7 RID: 34039
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040084F8 RID: 34040
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040084F9 RID: 34041
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040084FA RID: 34042
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040084FB RID: 34043
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040084FC RID: 34044
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020008D4 RID: 2260
		[ObfuscatedName("ScheduleOne.Quests.Quest_TheDeepEnd+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600C439 RID: 50233 RVA: 0x002FD038 File Offset: 0x002FB238
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Quest_TheDeepEnd.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_TheDeepEnd.__c>.NativeClassPtr);
				Quest_TheDeepEnd.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd.__c>.NativeClassPtr, "<>9");
				Quest_TheDeepEnd.__c.NativeFieldInfoPtr___9__13_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd.__c>.NativeClassPtr, "<>9__13_1");
				Quest_TheDeepEnd.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd.__c>.NativeClassPtr, 100667627);
				Quest_TheDeepEnd.__c.NativeMethodInfoPtr__ThomasDialogueNodeDisplayed_b__13_1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd.__c>.NativeClassPtr, 100667628);
			}

			// Token: 0x0600C43A RID: 50234 RVA: 0x002FD0B4 File Offset: 0x002FB2B4
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_TheDeepEnd.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C43B RID: 50235 RVA: 0x002FD0F0 File Offset: 0x002FB2F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117269, XrefRangeEnd = 117278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ThomasDialogueNodeDisplayed_b__13_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.__c.NativeMethodInfoPtr__ThomasDialogueNodeDisplayed_b__13_1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C43C RID: 50236 RVA: 0x0005F81C File Offset: 0x0005DA1C
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D3F RID: 15679
			// (get) Token: 0x0600C43D RID: 50237 RVA: 0x002FD12C File Offset: 0x002FB32C
			// (set) Token: 0x0600C43E RID: 50238 RVA: 0x0005F825 File Offset: 0x0005DA25
			public unsafe static Quest_TheDeepEnd.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Quest_TheDeepEnd.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quest_TheDeepEnd.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Quest_TheDeepEnd.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D40 RID: 15680
			// (get) Token: 0x0600C43F RID: 50239 RVA: 0x002FD154 File Offset: 0x002FB354
			// (set) Token: 0x0600C440 RID: 50240 RVA: 0x0005F837 File Offset: 0x0005DA37
			public unsafe static Func<bool> __9__13_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Quest_TheDeepEnd.__c.NativeFieldInfoPtr___9__13_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Quest_TheDeepEnd.__c.NativeFieldInfoPtr___9__13_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040084FD RID: 34045
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040084FE RID: 34046
			private static readonly IntPtr NativeFieldInfoPtr___9__13_1;

			// Token: 0x040084FF RID: 34047
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008500 RID: 34048
			private static readonly IntPtr NativeMethodInfoPtr__ThomasDialogueNodeDisplayed_b__13_1_Internal_Boolean_0;
		}
	}
}
