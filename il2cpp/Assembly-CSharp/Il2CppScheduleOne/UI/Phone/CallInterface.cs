using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ScriptableObjects;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Text.RegularExpressions;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone
{
	// Token: 0x020006A2 RID: 1698
	public class CallInterface : Singleton<CallInterface>
	{
		// Token: 0x0600979A RID: 38810 RVA: 0x0026BF74 File Offset: 0x0026A174
		// Note: this type is marked as 'beforefieldinit'.
		static CallInterface()
		{
			Il2CppClassPointerStore<CallInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone", "CallInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallInterface>.NativeClassPtr);
			CallInterface.NativeFieldInfoPtr_TIME_PER_CHAR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "TIME_PER_CHAR");
			CallInterface.NativeFieldInfoPtr__ActiveCallData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "<ActiveCallData>k__BackingField");
			CallInterface.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "<IsOpen>k__BackingField");
			CallInterface.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "Canvas");
			CallInterface.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "Container");
			CallInterface.NativeFieldInfoPtr_ProfilePicture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "ProfilePicture");
			CallInterface.NativeFieldInfoPtr_NameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "NameLabel");
			CallInterface.NativeFieldInfoPtr_MainText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "MainText");
			CallInterface.NativeFieldInfoPtr_ContinuePrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "ContinuePrompt");
			CallInterface.NativeFieldInfoPtr_OpenAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "OpenAnim");
			CallInterface.NativeFieldInfoPtr_TypewriterEffectSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "TypewriterEffectSound");
			CallInterface.NativeFieldInfoPtr_CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "CanvasGroup");
			CallInterface.NativeFieldInfoPtr_Highlight1Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "Highlight1Color");
			CallInterface.NativeFieldInfoPtr_currentCallStage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "currentCallStage");
			CallInterface.NativeFieldInfoPtr_slideRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "slideRoutine");
			CallInterface.NativeFieldInfoPtr_skipRollout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "skipRollout");
			CallInterface.NativeFieldInfoPtr_rolloutRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "rolloutRoutine");
			CallInterface.NativeFieldInfoPtr_highlight1Hex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "highlight1Hex");
			CallInterface.NativeFieldInfoPtr_CallCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "CallCompleted");
			CallInterface.NativeMethodInfoPtr_get_ActiveCallData_Public_get_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100682004);
			CallInterface.NativeMethodInfoPtr_set_ActiveCallData_Private_set_Void_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100682005);
			CallInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100682006);
			CallInterface.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100682007);
			CallInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100682008);
			CallInterface.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100682009);
			CallInterface.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100682010);
			CallInterface.NativeMethodInfoPtr_StartCall_Public_Void_PhoneCallData_CallerID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100682011);
			CallInterface.NativeMethodInfoPtr_EndCall_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100682012);
			CallInterface.NativeMethodInfoPtr_Close_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100682013);
			CallInterface.NativeMethodInfoPtr_Continue_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100682014);
			CallInterface.NativeMethodInfoPtr_ShowStage_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100682015);
			CallInterface.NativeMethodInfoPtr_ProcessText_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100682016);
			CallInterface.NativeMethodInfoPtr_GetVisibleText_Private_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100682017);
			CallInterface.NativeMethodInfoPtr_SetIsVisible_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100682018);
			CallInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100682019);
			CallInterface.NativeMethodInfoPtr__ProcessText_b__33_0_Private_String_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100682020);
		}

		// Token: 0x17002E92 RID: 11922
		// (get) Token: 0x0600979B RID: 38811 RVA: 0x0026C274 File Offset: 0x0026A474
		// (set) Token: 0x0600979C RID: 38812 RVA: 0x0026C2B4 File Offset: 0x0026A4B4
		public unsafe PhoneCallData ActiveCallData
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19637, RefRangeEnd = 19640, XrefRangeStart = 19637, XrefRangeEnd = 19640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_get_ActiveCallData_Public_get_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PhoneCallData>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19641, RefRangeEnd = 19644, XrefRangeStart = 19641, XrefRangeEnd = 19644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_set_ActiveCallData_Private_set_Void_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002E93 RID: 11923
		// (get) Token: 0x0600979D RID: 38813 RVA: 0x0026C2F8 File Offset: 0x0026A4F8
		// (set) Token: 0x0600979E RID: 38814 RVA: 0x0026C334 File Offset: 0x0026A534
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600979F RID: 38815 RVA: 0x0026C374 File Offset: 0x0026A574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271469, XrefRangeEnd = 271490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060097A0 RID: 38816 RVA: 0x0026C3B0 File Offset: 0x0026A5B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271490, XrefRangeEnd = 271514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060097A1 RID: 38817 RVA: 0x0026C3E4 File Offset: 0x0026A5E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271514, XrefRangeEnd = 271516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction exit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exit);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060097A2 RID: 38818 RVA: 0x0026C428 File Offset: 0x0026A628
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 271573, RefRangeEnd = 271574, XrefRangeStart = 271516, XrefRangeEnd = 271573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartCall(PhoneCallData data, CallerID caller, int startStage = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(caller);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startStage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_StartCall_Public_Void_PhoneCallData_CallerID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060097A3 RID: 38819 RVA: 0x0026C48C File Offset: 0x0026A68C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271574, XrefRangeEnd = 271587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndCall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_EndCall_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060097A4 RID: 38820 RVA: 0x0026C4C0 File Offset: 0x0026A6C0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 271635, RefRangeEnd = 271639, XrefRangeStart = 271587, XrefRangeEnd = 271635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_Close_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060097A5 RID: 38821 RVA: 0x0026C4F4 File Offset: 0x0026A6F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271639, XrefRangeEnd = 271655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Continue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_Continue_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060097A6 RID: 38822 RVA: 0x0026C528 File Offset: 0x0026A728
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 271670, RefRangeEnd = 271673, XrefRangeStart = 271655, XrefRangeEnd = 271670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowStage(int stageIndex, float initialDelay = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref stageIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialDelay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_ShowStage_Private_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060097A7 RID: 38823 RVA: 0x0026C574 File Offset: 0x0026A774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271673, XrefRangeEnd = 271699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ProcessText(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_ProcessText_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060097A8 RID: 38824 RVA: 0x0026C5BC File Offset: 0x0026A7BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271699, XrefRangeEnd = 271701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetVisibleText(int charactersShown, string fullText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref charactersShown;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fullText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_GetVisibleText_Private_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060097A9 RID: 38825 RVA: 0x0026C614 File Offset: 0x0026A814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271701, XrefRangeEnd = 271711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsVisible(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_SetIsVisible_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060097AA RID: 38826 RVA: 0x0026C654 File Offset: 0x0026A854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271711, XrefRangeEnd = 271714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060097AB RID: 38827 RVA: 0x0026C690 File Offset: 0x0026A890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271714, XrefRangeEnd = 271729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string _ProcessText_b__33_0(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr__ProcessText_b__33_0_Private_String_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060097AC RID: 38828 RVA: 0x00049B82 File Offset: 0x00047D82
		public CallInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E7F RID: 11903
		// (get) Token: 0x060097AD RID: 38829 RVA: 0x0026C6D8 File Offset: 0x0026A8D8
		// (set) Token: 0x060097AE RID: 38830 RVA: 0x00049B8B File Offset: 0x00047D8B
		public unsafe static float TIME_PER_CHAR
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CallInterface.NativeFieldInfoPtr_TIME_PER_CHAR, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CallInterface.NativeFieldInfoPtr_TIME_PER_CHAR, (void*)(&value));
			}
		}

		// Token: 0x17002E80 RID: 11904
		// (get) Token: 0x060097AF RID: 38831 RVA: 0x0026C6F4 File Offset: 0x0026A8F4
		// (set) Token: 0x060097B0 RID: 38832 RVA: 0x00049B99 File Offset: 0x00047D99
		public unsafe PhoneCallData _ActiveCallData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr__ActiveCallData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhoneCallData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr__ActiveCallData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E81 RID: 11905
		// (get) Token: 0x060097B1 RID: 38833 RVA: 0x0026C724 File Offset: 0x0026A924
		// (set) Token: 0x060097B2 RID: 38834 RVA: 0x00049BB8 File Offset: 0x00047DB8
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002E82 RID: 11906
		// (get) Token: 0x060097B3 RID: 38835 RVA: 0x0026C74C File Offset: 0x0026A94C
		// (set) Token: 0x060097B4 RID: 38836 RVA: 0x00049BD3 File Offset: 0x00047DD3
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E83 RID: 11907
		// (get) Token: 0x060097B5 RID: 38837 RVA: 0x0026C77C File Offset: 0x0026A97C
		// (set) Token: 0x060097B6 RID: 38838 RVA: 0x00049BF2 File Offset: 0x00047DF2
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E84 RID: 11908
		// (get) Token: 0x060097B7 RID: 38839 RVA: 0x0026C7AC File Offset: 0x0026A9AC
		// (set) Token: 0x060097B8 RID: 38840 RVA: 0x00049C11 File Offset: 0x00047E11
		public unsafe Image ProfilePicture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_ProfilePicture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_ProfilePicture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E85 RID: 11909
		// (get) Token: 0x060097B9 RID: 38841 RVA: 0x0026C7DC File Offset: 0x0026A9DC
		// (set) Token: 0x060097BA RID: 38842 RVA: 0x00049C30 File Offset: 0x00047E30
		public unsafe TextMeshProUGUI NameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_NameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_NameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E86 RID: 11910
		// (get) Token: 0x060097BB RID: 38843 RVA: 0x0026C80C File Offset: 0x0026AA0C
		// (set) Token: 0x060097BC RID: 38844 RVA: 0x00049C4F File Offset: 0x00047E4F
		public unsafe TextMeshProUGUI MainText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_MainText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_MainText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E87 RID: 11911
		// (get) Token: 0x060097BD RID: 38845 RVA: 0x0026C83C File Offset: 0x0026AA3C
		// (set) Token: 0x060097BE RID: 38846 RVA: 0x00049C6E File Offset: 0x00047E6E
		public unsafe RectTransform ContinuePrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_ContinuePrompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_ContinuePrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E88 RID: 11912
		// (get) Token: 0x060097BF RID: 38847 RVA: 0x0026C86C File Offset: 0x0026AA6C
		// (set) Token: 0x060097C0 RID: 38848 RVA: 0x00049C8D File Offset: 0x00047E8D
		public unsafe Animation OpenAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_OpenAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_OpenAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E89 RID: 11913
		// (get) Token: 0x060097C1 RID: 38849 RVA: 0x0026C89C File Offset: 0x0026AA9C
		// (set) Token: 0x060097C2 RID: 38850 RVA: 0x00049CAC File Offset: 0x00047EAC
		public unsafe AudioSourceController TypewriterEffectSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_TypewriterEffectSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_TypewriterEffectSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E8A RID: 11914
		// (get) Token: 0x060097C3 RID: 38851 RVA: 0x0026C8CC File Offset: 0x0026AACC
		// (set) Token: 0x060097C4 RID: 38852 RVA: 0x00049CCB File Offset: 0x00047ECB
		public unsafe CanvasGroup CanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_CanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E8B RID: 11915
		// (get) Token: 0x060097C5 RID: 38853 RVA: 0x0026C8FC File Offset: 0x0026AAFC
		// (set) Token: 0x060097C6 RID: 38854 RVA: 0x00049CEA File Offset: 0x00047EEA
		public unsafe Color Highlight1Color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_Highlight1Color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_Highlight1Color)) = value;
			}
		}

		// Token: 0x17002E8C RID: 11916
		// (get) Token: 0x060097C7 RID: 38855 RVA: 0x0026C924 File Offset: 0x0026AB24
		// (set) Token: 0x060097C8 RID: 38856 RVA: 0x00049D05 File Offset: 0x00047F05
		public unsafe int currentCallStage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_currentCallStage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_currentCallStage)) = value;
			}
		}

		// Token: 0x17002E8D RID: 11917
		// (get) Token: 0x060097C9 RID: 38857 RVA: 0x0026C94C File Offset: 0x0026AB4C
		// (set) Token: 0x060097CA RID: 38858 RVA: 0x00049D20 File Offset: 0x00047F20
		public unsafe Coroutine slideRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_slideRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_slideRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E8E RID: 11918
		// (get) Token: 0x060097CB RID: 38859 RVA: 0x0026C97C File Offset: 0x0026AB7C
		// (set) Token: 0x060097CC RID: 38860 RVA: 0x00049D3F File Offset: 0x00047F3F
		public unsafe bool skipRollout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_skipRollout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_skipRollout)) = value;
			}
		}

		// Token: 0x17002E8F RID: 11919
		// (get) Token: 0x060097CD RID: 38861 RVA: 0x0026C9A4 File Offset: 0x0026ABA4
		// (set) Token: 0x060097CE RID: 38862 RVA: 0x00049D5A File Offset: 0x00047F5A
		public unsafe Coroutine rolloutRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_rolloutRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_rolloutRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E90 RID: 11920
		// (get) Token: 0x060097CF RID: 38863 RVA: 0x0026C9D4 File Offset: 0x0026ABD4
		// (set) Token: 0x060097D0 RID: 38864 RVA: 0x00049D79 File Offset: 0x00047F79
		public unsafe string highlight1Hex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_highlight1Hex);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_highlight1Hex), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002E91 RID: 11921
		// (get) Token: 0x060097D1 RID: 38865 RVA: 0x0026C9FC File Offset: 0x0026ABFC
		// (set) Token: 0x060097D2 RID: 38866 RVA: 0x00049D98 File Offset: 0x00047F98
		public unsafe Action<PhoneCallData> CallCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_CallCompleted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<PhoneCallData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_CallCompleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006624 RID: 26148
		private static readonly IntPtr NativeFieldInfoPtr_TIME_PER_CHAR;

		// Token: 0x04006625 RID: 26149
		private static readonly IntPtr NativeFieldInfoPtr__ActiveCallData_k__BackingField;

		// Token: 0x04006626 RID: 26150
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04006627 RID: 26151
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04006628 RID: 26152
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006629 RID: 26153
		private static readonly IntPtr NativeFieldInfoPtr_ProfilePicture;

		// Token: 0x0400662A RID: 26154
		private static readonly IntPtr NativeFieldInfoPtr_NameLabel;

		// Token: 0x0400662B RID: 26155
		private static readonly IntPtr NativeFieldInfoPtr_MainText;

		// Token: 0x0400662C RID: 26156
		private static readonly IntPtr NativeFieldInfoPtr_ContinuePrompt;

		// Token: 0x0400662D RID: 26157
		private static readonly IntPtr NativeFieldInfoPtr_OpenAnim;

		// Token: 0x0400662E RID: 26158
		private static readonly IntPtr NativeFieldInfoPtr_TypewriterEffectSound;

		// Token: 0x0400662F RID: 26159
		private static readonly IntPtr NativeFieldInfoPtr_CanvasGroup;

		// Token: 0x04006630 RID: 26160
		private static readonly IntPtr NativeFieldInfoPtr_Highlight1Color;

		// Token: 0x04006631 RID: 26161
		private static readonly IntPtr NativeFieldInfoPtr_currentCallStage;

		// Token: 0x04006632 RID: 26162
		private static readonly IntPtr NativeFieldInfoPtr_slideRoutine;

		// Token: 0x04006633 RID: 26163
		private static readonly IntPtr NativeFieldInfoPtr_skipRollout;

		// Token: 0x04006634 RID: 26164
		private static readonly IntPtr NativeFieldInfoPtr_rolloutRoutine;

		// Token: 0x04006635 RID: 26165
		private static readonly IntPtr NativeFieldInfoPtr_highlight1Hex;

		// Token: 0x04006636 RID: 26166
		private static readonly IntPtr NativeFieldInfoPtr_CallCompleted;

		// Token: 0x04006637 RID: 26167
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveCallData_Public_get_PhoneCallData_0;

		// Token: 0x04006638 RID: 26168
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveCallData_Private_set_Void_PhoneCallData_0;

		// Token: 0x04006639 RID: 26169
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x0400663A RID: 26170
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x0400663B RID: 26171
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400663C RID: 26172
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400663D RID: 26173
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x0400663E RID: 26174
		private static readonly IntPtr NativeMethodInfoPtr_StartCall_Public_Void_PhoneCallData_CallerID_Int32_0;

		// Token: 0x0400663F RID: 26175
		private static readonly IntPtr NativeMethodInfoPtr_EndCall_Public_Void_0;

		// Token: 0x04006640 RID: 26176
		private static readonly IntPtr NativeMethodInfoPtr_Close_Private_Void_0;

		// Token: 0x04006641 RID: 26177
		private static readonly IntPtr NativeMethodInfoPtr_Continue_Public_Void_0;

		// Token: 0x04006642 RID: 26178
		private static readonly IntPtr NativeMethodInfoPtr_ShowStage_Private_Void_Int32_Single_0;

		// Token: 0x04006643 RID: 26179
		private static readonly IntPtr NativeMethodInfoPtr_ProcessText_Private_String_String_0;

		// Token: 0x04006644 RID: 26180
		private static readonly IntPtr NativeMethodInfoPtr_GetVisibleText_Private_String_Int32_String_0;

		// Token: 0x04006645 RID: 26181
		private static readonly IntPtr NativeMethodInfoPtr_SetIsVisible_Private_Void_Boolean_0;

		// Token: 0x04006646 RID: 26182
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006647 RID: 26183
		private static readonly IntPtr NativeMethodInfoPtr__ProcessText_b__33_0_Private_String_Match_0;

		// Token: 0x02000B68 RID: 2920
		[ObfuscatedName("ScheduleOne.UI.Phone.CallInterface+<>c__DisplayClass32_0")]
		public sealed class __c__DisplayClass32_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DAA3 RID: 55971 RVA: 0x0033D05C File Offset: 0x0033B25C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass32_0()
			{
				Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "<>c__DisplayClass32_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0>.NativeClassPtr);
				CallInterface.__c__DisplayClass32_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0>.NativeClassPtr, "<>4__this");
				CallInterface.__c__DisplayClass32_0.NativeFieldInfoPtr_initialDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0>.NativeClassPtr, "initialDelay");
				CallInterface.__c__DisplayClass32_0.NativeFieldInfoPtr_stageIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0>.NativeClassPtr, "stageIndex");
				CallInterface.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0>.NativeClassPtr, 100682021);
				CallInterface.__c__DisplayClass32_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0>.NativeClassPtr, 100682022);
			}

			// Token: 0x0600DAA4 RID: 55972 RVA: 0x0033D0EC File Offset: 0x0033B2EC
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass32_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DAA5 RID: 55973 RVA: 0x0033D128 File Offset: 0x0033B328
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271464, XrefRangeEnd = 271469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.__c__DisplayClass32_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DAA6 RID: 55974 RVA: 0x0006A772 File Offset: 0x00068972
			public __c__DisplayClass32_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043D0 RID: 17360
			// (get) Token: 0x0600DAA7 RID: 55975 RVA: 0x0033D168 File Offset: 0x0033B368
			// (set) Token: 0x0600DAA8 RID: 55976 RVA: 0x0006A77B File Offset: 0x0006897B
			public unsafe CallInterface __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallInterface>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043D1 RID: 17361
			// (get) Token: 0x0600DAA9 RID: 55977 RVA: 0x0033D198 File Offset: 0x0033B398
			// (set) Token: 0x0600DAAA RID: 55978 RVA: 0x0006A79A File Offset: 0x0006899A
			public unsafe float initialDelay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.NativeFieldInfoPtr_initialDelay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.NativeFieldInfoPtr_initialDelay)) = value;
				}
			}

			// Token: 0x170043D2 RID: 17362
			// (get) Token: 0x0600DAAB RID: 55979 RVA: 0x0033D1C0 File Offset: 0x0033B3C0
			// (set) Token: 0x0600DAAC RID: 55980 RVA: 0x0006A7B5 File Offset: 0x000689B5
			public unsafe int stageIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.NativeFieldInfoPtr_stageIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.NativeFieldInfoPtr_stageIndex)) = value;
				}
			}

			// Token: 0x040092BE RID: 37566
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040092BF RID: 37567
			private static readonly IntPtr NativeFieldInfoPtr_initialDelay;

			// Token: 0x040092C0 RID: 37568
			private static readonly IntPtr NativeFieldInfoPtr_stageIndex;

			// Token: 0x040092C1 RID: 37569
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040092C2 RID: 37570
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C7A RID: 3194
			[ObfuscatedName("ScheduleOne.UI.Phone.CallInterface+<>c__DisplayClass32_0+<<ShowStage>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E5F4 RID: 58868 RVA: 0x0035D7E4 File Offset: 0x0035B9E4
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique()
				{
					Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0>.NativeClassPtr, "<<ShowStage>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr);
					CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr, "<>1__state");
					CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr, "<>2__current");
					CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr, "<>4__this");
					CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr__stageText_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr, "<stageText>5__2");
					CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr__parsedLength_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr, "<parsedLength>5__3");
					CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr, "<i>5__4");
					CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr, 100682023);
					CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr, 100682024);
					CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr, 100682025);
					CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr, 100682026);
					CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr, 100682027);
					CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr, 100682028);
				}

				// Token: 0x0600E5F5 RID: 58869 RVA: 0x0035D900 File Offset: 0x0035BB00
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E5F6 RID: 58870 RVA: 0x0035D948 File Offset: 0x0035BB48
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E5F7 RID: 58871 RVA: 0x0035D97C File Offset: 0x0035BB7C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271423, XrefRangeEnd = 271459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004790 RID: 18320
				// (get) Token: 0x0600E5F8 RID: 58872 RVA: 0x0035D9B8 File Offset: 0x0035BBB8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E5F9 RID: 58873 RVA: 0x0035D9F8 File Offset: 0x0035BBF8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271459, XrefRangeEnd = 271464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004791 RID: 18321
				// (get) Token: 0x0600E5FA RID: 58874 RVA: 0x0035DA2C File Offset: 0x0035BC2C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E5FB RID: 58875 RVA: 0x00070355 File Offset: 0x0006E555
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x1700478A RID: 18314
				// (get) Token: 0x0600E5FC RID: 58876 RVA: 0x0035DA6C File Offset: 0x0035BC6C
				// (set) Token: 0x0600E5FD RID: 58877 RVA: 0x0007035E File Offset: 0x0006E55E
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700478B RID: 18315
				// (get) Token: 0x0600E5FE RID: 58878 RVA: 0x0035DA94 File Offset: 0x0035BC94
				// (set) Token: 0x0600E5FF RID: 58879 RVA: 0x00070379 File Offset: 0x0006E579
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700478C RID: 18316
				// (get) Token: 0x0600E600 RID: 58880 RVA: 0x0035DAC4 File Offset: 0x0035BCC4
				// (set) Token: 0x0600E601 RID: 58881 RVA: 0x00070398 File Offset: 0x0006E598
				public unsafe CallInterface.__c__DisplayClass32_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallInterface.__c__DisplayClass32_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700478D RID: 18317
				// (get) Token: 0x0600E602 RID: 58882 RVA: 0x0035DAF4 File Offset: 0x0035BCF4
				// (set) Token: 0x0600E603 RID: 58883 RVA: 0x000703B7 File Offset: 0x0006E5B7
				public unsafe string _stageText_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr__stageText_5__2);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr__stageText_5__2), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x1700478E RID: 18318
				// (get) Token: 0x0600E604 RID: 58884 RVA: 0x0035DB1C File Offset: 0x0035BD1C
				// (set) Token: 0x0600E605 RID: 58885 RVA: 0x000703D6 File Offset: 0x0006E5D6
				public unsafe int _parsedLength_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr__parsedLength_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr__parsedLength_5__3)) = value;
					}
				}

				// Token: 0x1700478F RID: 18319
				// (get) Token: 0x0600E606 RID: 58886 RVA: 0x0035DB44 File Offset: 0x0035BD44
				// (set) Token: 0x0600E607 RID: 58887 RVA: 0x000703F1 File Offset: 0x0006E5F1
				public unsafe int _i_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr__i_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr__i_5__4)) = value;
					}
				}

				// Token: 0x040099BA RID: 39354
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040099BB RID: 39355
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040099BC RID: 39356
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040099BD RID: 39357
				private static readonly IntPtr NativeFieldInfoPtr__stageText_5__2;

				// Token: 0x040099BE RID: 39358
				private static readonly IntPtr NativeFieldInfoPtr__parsedLength_5__3;

				// Token: 0x040099BF RID: 39359
				private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

				// Token: 0x040099C0 RID: 39360
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040099C1 RID: 39361
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040099C2 RID: 39362
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040099C3 RID: 39363
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040099C4 RID: 39364
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040099C5 RID: 39365
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
