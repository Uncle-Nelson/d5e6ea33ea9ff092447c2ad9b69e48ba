using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Dialogue;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000636 RID: 1590
	public class DialogueCanvas : Singleton<DialogueCanvas>
	{
		// Token: 0x06008C7A RID: 35962 RVA: 0x0024AC1C File Offset: 0x00248E1C
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueCanvas()
		{
			Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "DialogueCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr);
			DialogueCanvas.NativeFieldInfoPtr_TIME_PER_CHAR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "TIME_PER_CHAR");
			DialogueCanvas.NativeFieldInfoPtr_SkipNextRollout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "SkipNextRollout");
			DialogueCanvas.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "canvas");
			DialogueCanvas.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "Container");
			DialogueCanvas.NativeFieldInfoPtr_dialogueText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "dialogueText");
			DialogueCanvas.NativeFieldInfoPtr_continuePopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "continuePopup");
			DialogueCanvas.NativeFieldInfoPtr_dialogueChoices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "dialogueChoices");
			DialogueCanvas.NativeFieldInfoPtr_currentHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "currentHandler");
			DialogueCanvas.NativeFieldInfoPtr_currentNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "currentNode");
			DialogueCanvas.NativeFieldInfoPtr_spaceDownThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "spaceDownThisFrame");
			DialogueCanvas.NativeFieldInfoPtr_leftClickThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "leftClickThisFrame");
			DialogueCanvas.NativeFieldInfoPtr_overrideText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "overrideText");
			DialogueCanvas.NativeFieldInfoPtr_dialogueRollout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "dialogueRollout");
			DialogueCanvas.NativeFieldInfoPtr_choiceSelectionResidualCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "choiceSelectionResidualCoroutine");
			DialogueCanvas.NativeFieldInfoPtr_hasChoiceBeenSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "hasChoiceBeenSelected");
			DialogueCanvas.NativeMethodInfoPtr_get_isActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100680735);
			DialogueCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100680736);
			DialogueCanvas.NativeMethodInfoPtr_DisplayDialogueNode_Public_Void_DialogueHandler_DialogueNodeData_String_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100680737);
			DialogueCanvas.NativeMethodInfoPtr_OverrideText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100680738);
			DialogueCanvas.NativeMethodInfoPtr_StopTextOverride_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100680739);
			DialogueCanvas.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100680740);
			DialogueCanvas.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100680741);
			DialogueCanvas.NativeMethodInfoPtr_RolloutDialogue_Protected_IEnumerator_String_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100680742);
			DialogueCanvas.NativeMethodInfoPtr_ChoiceSelectionResidual_Private_IEnumerator_DialogueChoiceEntry_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100680743);
			DialogueCanvas.NativeMethodInfoPtr_StartDialogue_Private_Void_DialogueHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100680744);
			DialogueCanvas.NativeMethodInfoPtr_EndDialogue_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100680745);
			DialogueCanvas.NativeMethodInfoPtr_ChoiceSelected_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100680746);
			DialogueCanvas.NativeMethodInfoPtr_IsChoiceValid_Private_Boolean_Int32_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100680747);
			DialogueCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100680748);
			DialogueCanvas.NativeMethodInfoPtr__RolloutDialogue_b__21_0_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100680749);
		}

		// Token: 0x17002AEA RID: 10986
		// (get) Token: 0x06008C7B RID: 35963 RVA: 0x0024AEA4 File Offset: 0x002490A4
		public unsafe bool isActive
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 256888, RefRangeEnd = 256890, XrefRangeStart = 256884, XrefRangeEnd = 256888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_get_isActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06008C7C RID: 35964 RVA: 0x0024AEE0 File Offset: 0x002490E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256890, XrefRangeEnd = 256907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C7D RID: 35965 RVA: 0x0024AF1C File Offset: 0x0024911C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256923, RefRangeEnd = 256924, XrefRangeStart = 256907, XrefRangeEnd = 256923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisplayDialogueNode(DialogueHandler diag, DialogueNodeData node, string dialogueText, List<string> choices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(diag);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(node);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogueText);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(choices);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_DisplayDialogueNode_Public_Void_DialogueHandler_DialogueNodeData_String_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C7E RID: 35966 RVA: 0x0024AF98 File Offset: 0x00249198
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256930, RefRangeEnd = 256931, XrefRangeStart = 256924, XrefRangeEnd = 256930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideText(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_OverrideText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C7F RID: 35967 RVA: 0x0024AFDC File Offset: 0x002491DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256934, RefRangeEnd = 256935, XrefRangeStart = 256931, XrefRangeEnd = 256934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopTextOverride()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_StopTextOverride_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C80 RID: 35968 RVA: 0x0024B010 File Offset: 0x00249210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256935, XrefRangeEnd = 256944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C81 RID: 35969 RVA: 0x0024B044 File Offset: 0x00249244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256944, XrefRangeEnd = 256952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C82 RID: 35970 RVA: 0x0024B088 File Offset: 0x00249288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256952, XrefRangeEnd = 256959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator RolloutDialogue(string text, List<string> choices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(choices);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_RolloutDialogue_Protected_IEnumerator_String_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06008C83 RID: 35971 RVA: 0x0024B0EC File Offset: 0x002492EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256965, RefRangeEnd = 256966, XrefRangeStart = 256959, XrefRangeEnd = 256965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ChoiceSelectionResidual(DialogueChoiceEntry choice, float fadeTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(choice);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_ChoiceSelectionResidual_Private_IEnumerator_DialogueChoiceEntry_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06008C84 RID: 35972 RVA: 0x0024B14C File Offset: 0x0024934C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 257020, RefRangeEnd = 257021, XrefRangeStart = 256966, XrefRangeEnd = 257020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartDialogue(DialogueHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_StartDialogue_Private_Void_DialogueHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C85 RID: 35973 RVA: 0x0024B190 File Offset: 0x00249390
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 257052, RefRangeEnd = 257053, XrefRangeStart = 257021, XrefRangeEnd = 257052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_EndDialogue_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C86 RID: 35974 RVA: 0x0024B1C4 File Offset: 0x002493C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257053, XrefRangeEnd = 257080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChoiceSelected(int choiceIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref choiceIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_ChoiceSelected_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C87 RID: 35975 RVA: 0x0024B204 File Offset: 0x00249404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257080, XrefRangeEnd = 257088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsChoiceValid(int choiceIndex, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref choiceIndex;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_IsChoiceValid_Private_Boolean_Int32_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06008C88 RID: 35976 RVA: 0x0024B268 File Offset: 0x00249468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257088, XrefRangeEnd = 257101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C89 RID: 35977 RVA: 0x0024B2A4 File Offset: 0x002494A4
		[CallerCount(0)]
		public unsafe bool _RolloutDialogue_b__21_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr__RolloutDialogue_b__21_0_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008C8A RID: 35978 RVA: 0x000435D5 File Offset: 0x000417D5
		public DialogueCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002ADB RID: 10971
		// (get) Token: 0x06008C8B RID: 35979 RVA: 0x0024B2E0 File Offset: 0x002494E0
		// (set) Token: 0x06008C8C RID: 35980 RVA: 0x000435DE File Offset: 0x000417DE
		public unsafe static float TIME_PER_CHAR
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DialogueCanvas.NativeFieldInfoPtr_TIME_PER_CHAR, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DialogueCanvas.NativeFieldInfoPtr_TIME_PER_CHAR, (void*)(&value));
			}
		}

		// Token: 0x17002ADC RID: 10972
		// (get) Token: 0x06008C8D RID: 35981 RVA: 0x0024B2FC File Offset: 0x002494FC
		// (set) Token: 0x06008C8E RID: 35982 RVA: 0x000435EC File Offset: 0x000417EC
		public unsafe bool SkipNextRollout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_SkipNextRollout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_SkipNextRollout)) = value;
			}
		}

		// Token: 0x17002ADD RID: 10973
		// (get) Token: 0x06008C8F RID: 35983 RVA: 0x0024B324 File Offset: 0x00249524
		// (set) Token: 0x06008C90 RID: 35984 RVA: 0x00043607 File Offset: 0x00041807
		public unsafe Canvas canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ADE RID: 10974
		// (get) Token: 0x06008C91 RID: 35985 RVA: 0x0024B354 File Offset: 0x00249554
		// (set) Token: 0x06008C92 RID: 35986 RVA: 0x00043626 File Offset: 0x00041826
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ADF RID: 10975
		// (get) Token: 0x06008C93 RID: 35987 RVA: 0x0024B384 File Offset: 0x00249584
		// (set) Token: 0x06008C94 RID: 35988 RVA: 0x00043645 File Offset: 0x00041845
		public unsafe TextMeshProUGUI dialogueText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_dialogueText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_dialogueText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AE0 RID: 10976
		// (get) Token: 0x06008C95 RID: 35989 RVA: 0x0024B3B4 File Offset: 0x002495B4
		// (set) Token: 0x06008C96 RID: 35990 RVA: 0x00043664 File Offset: 0x00041864
		public unsafe GameObject continuePopup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_continuePopup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_continuePopup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AE1 RID: 10977
		// (get) Token: 0x06008C97 RID: 35991 RVA: 0x0024B3E4 File Offset: 0x002495E4
		// (set) Token: 0x06008C98 RID: 35992 RVA: 0x00043683 File Offset: 0x00041883
		public unsafe List<DialogueChoiceEntry> dialogueChoices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_dialogueChoices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueChoiceEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_dialogueChoices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AE2 RID: 10978
		// (get) Token: 0x06008C99 RID: 35993 RVA: 0x0024B414 File Offset: 0x00249614
		// (set) Token: 0x06008C9A RID: 35994 RVA: 0x000436A2 File Offset: 0x000418A2
		public unsafe DialogueHandler currentHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_currentHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_currentHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AE3 RID: 10979
		// (get) Token: 0x06008C9B RID: 35995 RVA: 0x0024B444 File Offset: 0x00249644
		// (set) Token: 0x06008C9C RID: 35996 RVA: 0x000436C1 File Offset: 0x000418C1
		public unsafe DialogueNodeData currentNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_currentNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueNodeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_currentNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AE4 RID: 10980
		// (get) Token: 0x06008C9D RID: 35997 RVA: 0x0024B474 File Offset: 0x00249674
		// (set) Token: 0x06008C9E RID: 35998 RVA: 0x000436E0 File Offset: 0x000418E0
		public unsafe bool spaceDownThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_spaceDownThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_spaceDownThisFrame)) = value;
			}
		}

		// Token: 0x17002AE5 RID: 10981
		// (get) Token: 0x06008C9F RID: 35999 RVA: 0x0024B49C File Offset: 0x0024969C
		// (set) Token: 0x06008CA0 RID: 36000 RVA: 0x000436FB File Offset: 0x000418FB
		public unsafe bool leftClickThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_leftClickThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_leftClickThisFrame)) = value;
			}
		}

		// Token: 0x17002AE6 RID: 10982
		// (get) Token: 0x06008CA1 RID: 36001 RVA: 0x0024B4C4 File Offset: 0x002496C4
		// (set) Token: 0x06008CA2 RID: 36002 RVA: 0x00043716 File Offset: 0x00041916
		public unsafe string overrideText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_overrideText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_overrideText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002AE7 RID: 10983
		// (get) Token: 0x06008CA3 RID: 36003 RVA: 0x0024B4EC File Offset: 0x002496EC
		// (set) Token: 0x06008CA4 RID: 36004 RVA: 0x00043735 File Offset: 0x00041935
		public unsafe Coroutine dialogueRollout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_dialogueRollout);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_dialogueRollout), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AE8 RID: 10984
		// (get) Token: 0x06008CA5 RID: 36005 RVA: 0x0024B51C File Offset: 0x0024971C
		// (set) Token: 0x06008CA6 RID: 36006 RVA: 0x00043754 File Offset: 0x00041954
		public unsafe Coroutine choiceSelectionResidualCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_choiceSelectionResidualCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_choiceSelectionResidualCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AE9 RID: 10985
		// (get) Token: 0x06008CA7 RID: 36007 RVA: 0x0024B54C File Offset: 0x0024974C
		// (set) Token: 0x06008CA8 RID: 36008 RVA: 0x00043773 File Offset: 0x00041973
		public unsafe bool hasChoiceBeenSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_hasChoiceBeenSelected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_hasChoiceBeenSelected)) = value;
			}
		}

		// Token: 0x04005F35 RID: 24373
		private static readonly IntPtr NativeFieldInfoPtr_TIME_PER_CHAR;

		// Token: 0x04005F36 RID: 24374
		private static readonly IntPtr NativeFieldInfoPtr_SkipNextRollout;

		// Token: 0x04005F37 RID: 24375
		private static readonly IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x04005F38 RID: 24376
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04005F39 RID: 24377
		private static readonly IntPtr NativeFieldInfoPtr_dialogueText;

		// Token: 0x04005F3A RID: 24378
		private static readonly IntPtr NativeFieldInfoPtr_continuePopup;

		// Token: 0x04005F3B RID: 24379
		private static readonly IntPtr NativeFieldInfoPtr_dialogueChoices;

		// Token: 0x04005F3C RID: 24380
		private static readonly IntPtr NativeFieldInfoPtr_currentHandler;

		// Token: 0x04005F3D RID: 24381
		private static readonly IntPtr NativeFieldInfoPtr_currentNode;

		// Token: 0x04005F3E RID: 24382
		private static readonly IntPtr NativeFieldInfoPtr_spaceDownThisFrame;

		// Token: 0x04005F3F RID: 24383
		private static readonly IntPtr NativeFieldInfoPtr_leftClickThisFrame;

		// Token: 0x04005F40 RID: 24384
		private static readonly IntPtr NativeFieldInfoPtr_overrideText;

		// Token: 0x04005F41 RID: 24385
		private static readonly IntPtr NativeFieldInfoPtr_dialogueRollout;

		// Token: 0x04005F42 RID: 24386
		private static readonly IntPtr NativeFieldInfoPtr_choiceSelectionResidualCoroutine;

		// Token: 0x04005F43 RID: 24387
		private static readonly IntPtr NativeFieldInfoPtr_hasChoiceBeenSelected;

		// Token: 0x04005F44 RID: 24388
		private static readonly IntPtr NativeMethodInfoPtr_get_isActive_Public_get_Boolean_0;

		// Token: 0x04005F45 RID: 24389
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04005F46 RID: 24390
		private static readonly IntPtr NativeMethodInfoPtr_DisplayDialogueNode_Public_Void_DialogueHandler_DialogueNodeData_String_List_1_String_0;

		// Token: 0x04005F47 RID: 24391
		private static readonly IntPtr NativeMethodInfoPtr_OverrideText_Public_Void_String_0;

		// Token: 0x04005F48 RID: 24392
		private static readonly IntPtr NativeMethodInfoPtr_StopTextOverride_Public_Void_0;

		// Token: 0x04005F49 RID: 24393
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04005F4A RID: 24394
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04005F4B RID: 24395
		private static readonly IntPtr NativeMethodInfoPtr_RolloutDialogue_Protected_IEnumerator_String_List_1_String_0;

		// Token: 0x04005F4C RID: 24396
		private static readonly IntPtr NativeMethodInfoPtr_ChoiceSelectionResidual_Private_IEnumerator_DialogueChoiceEntry_Single_0;

		// Token: 0x04005F4D RID: 24397
		private static readonly IntPtr NativeMethodInfoPtr_StartDialogue_Private_Void_DialogueHandler_0;

		// Token: 0x04005F4E RID: 24398
		private static readonly IntPtr NativeMethodInfoPtr_EndDialogue_Public_Void_0;

		// Token: 0x04005F4F RID: 24399
		private static readonly IntPtr NativeMethodInfoPtr_ChoiceSelected_Public_Void_Int32_0;

		// Token: 0x04005F50 RID: 24400
		private static readonly IntPtr NativeMethodInfoPtr_IsChoiceValid_Private_Boolean_Int32_byref_String_0;

		// Token: 0x04005F51 RID: 24401
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005F52 RID: 24402
		private static readonly IntPtr NativeMethodInfoPtr__RolloutDialogue_b__21_0_Private_Boolean_0;

		// Token: 0x02000B1C RID: 2844
		[ObfuscatedName("ScheduleOne.UI.DialogueCanvas+<ChoiceSelectionResidual>d__23")]
		public sealed class _ChoiceSelectionResidual_d__23 : Il2CppSystem.Object
		{
			// Token: 0x0600D71E RID: 55070 RVA: 0x00332CC0 File Offset: 0x00330EC0
			// Note: this type is marked as 'beforefieldinit'.
			static _ChoiceSelectionResidual_d__23()
			{
				Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__23>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "<ChoiceSelectionResidual>d__23");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__23>.NativeClassPtr);
				DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__23>.NativeClassPtr, "<>1__state");
				DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__23>.NativeClassPtr, "<>2__current");
				DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr_fadeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__23>.NativeClassPtr, "fadeTime");
				DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr_choice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__23>.NativeClassPtr, "choice");
				DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__23>.NativeClassPtr, "<>4__this");
				DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr__realFadeTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__23>.NativeClassPtr, "<realFadeTime>5__2");
				DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__23>.NativeClassPtr, "<i>5__3");
				DialogueCanvas._ChoiceSelectionResidual_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__23>.NativeClassPtr, 100680750);
				DialogueCanvas._ChoiceSelectionResidual_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__23>.NativeClassPtr, 100680751);
				DialogueCanvas._ChoiceSelectionResidual_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__23>.NativeClassPtr, 100680752);
				DialogueCanvas._ChoiceSelectionResidual_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__23>.NativeClassPtr, 100680753);
				DialogueCanvas._ChoiceSelectionResidual_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__23>.NativeClassPtr, 100680754);
				DialogueCanvas._ChoiceSelectionResidual_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__23>.NativeClassPtr, 100680755);
			}

			// Token: 0x0600D71F RID: 55071 RVA: 0x00332DF0 File Offset: 0x00330FF0
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ChoiceSelectionResidual_d__23(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__23>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D720 RID: 55072 RVA: 0x00332E38 File Offset: 0x00331038
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D721 RID: 55073 RVA: 0x00332E6C File Offset: 0x0033106C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256816, XrefRangeEnd = 256828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170042AB RID: 17067
			// (get) Token: 0x0600D722 RID: 55074 RVA: 0x00332EA8 File Offset: 0x003310A8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D723 RID: 55075 RVA: 0x00332EE8 File Offset: 0x003310E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256828, XrefRangeEnd = 256833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170042AC RID: 17068
			// (get) Token: 0x0600D724 RID: 55076 RVA: 0x00332F1C File Offset: 0x0033111C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D725 RID: 55077 RVA: 0x00068B3F File Offset: 0x00066D3F
			public _ChoiceSelectionResidual_d__23(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042A4 RID: 17060
			// (get) Token: 0x0600D726 RID: 55078 RVA: 0x00332F5C File Offset: 0x0033115C
			// (set) Token: 0x0600D727 RID: 55079 RVA: 0x00068B48 File Offset: 0x00066D48
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170042A5 RID: 17061
			// (get) Token: 0x0600D728 RID: 55080 RVA: 0x00332F84 File Offset: 0x00331184
			// (set) Token: 0x0600D729 RID: 55081 RVA: 0x00068B63 File Offset: 0x00066D63
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042A6 RID: 17062
			// (get) Token: 0x0600D72A RID: 55082 RVA: 0x00332FB4 File Offset: 0x003311B4
			// (set) Token: 0x0600D72B RID: 55083 RVA: 0x00068B82 File Offset: 0x00066D82
			public unsafe float fadeTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr_fadeTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr_fadeTime)) = value;
				}
			}

			// Token: 0x170042A7 RID: 17063
			// (get) Token: 0x0600D72C RID: 55084 RVA: 0x00332FDC File Offset: 0x003311DC
			// (set) Token: 0x0600D72D RID: 55085 RVA: 0x00068B9D File Offset: 0x00066D9D
			public unsafe DialogueChoiceEntry choice
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr_choice);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueChoiceEntry>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr_choice), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042A8 RID: 17064
			// (get) Token: 0x0600D72E RID: 55086 RVA: 0x0033300C File Offset: 0x0033120C
			// (set) Token: 0x0600D72F RID: 55087 RVA: 0x00068BBC File Offset: 0x00066DBC
			public unsafe DialogueCanvas __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueCanvas>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042A9 RID: 17065
			// (get) Token: 0x0600D730 RID: 55088 RVA: 0x0033303C File Offset: 0x0033123C
			// (set) Token: 0x0600D731 RID: 55089 RVA: 0x00068BDB File Offset: 0x00066DDB
			public unsafe float _realFadeTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr__realFadeTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr__realFadeTime_5__2)) = value;
				}
			}

			// Token: 0x170042AA RID: 17066
			// (get) Token: 0x0600D732 RID: 55090 RVA: 0x00333064 File Offset: 0x00331264
			// (set) Token: 0x0600D733 RID: 55091 RVA: 0x00068BF6 File Offset: 0x00066DF6
			public unsafe float _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x040090A3 RID: 37027
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040090A4 RID: 37028
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040090A5 RID: 37029
			private static readonly IntPtr NativeFieldInfoPtr_fadeTime;

			// Token: 0x040090A6 RID: 37030
			private static readonly IntPtr NativeFieldInfoPtr_choice;

			// Token: 0x040090A7 RID: 37031
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040090A8 RID: 37032
			private static readonly IntPtr NativeFieldInfoPtr__realFadeTime_5__2;

			// Token: 0x040090A9 RID: 37033
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x040090AA RID: 37034
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040090AB RID: 37035
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040090AC RID: 37036
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040090AD RID: 37037
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040090AE RID: 37038
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040090AF RID: 37039
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B1D RID: 2845
		[ObfuscatedName("ScheduleOne.UI.DialogueCanvas+<RolloutDialogue>d__21")]
		public sealed class _RolloutDialogue_d__21 : Il2CppSystem.Object
		{
			// Token: 0x0600D734 RID: 55092 RVA: 0x0033308C File Offset: 0x0033128C
			// Note: this type is marked as 'beforefieldinit'.
			static _RolloutDialogue_d__21()
			{
				Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "<RolloutDialogue>d__21");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr);
				DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr, "<>1__state");
				DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr, "<>2__current");
				DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr, "<>4__this");
				DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr, "text");
				DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr_choices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr, "choices");
				DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr__activeDialogueChoices_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr, "<activeDialogueChoices>5__2");
				DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr__rolloutTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr, "<rolloutTime>5__3");
				DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr, "<i>5__4");
				DialogueCanvas._RolloutDialogue_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr, 100680756);
				DialogueCanvas._RolloutDialogue_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr, 100680757);
				DialogueCanvas._RolloutDialogue_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr, 100680758);
				DialogueCanvas._RolloutDialogue_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr, 100680759);
				DialogueCanvas._RolloutDialogue_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr, 100680760);
				DialogueCanvas._RolloutDialogue_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr, 100680761);
			}

			// Token: 0x0600D735 RID: 55093 RVA: 0x003331D0 File Offset: 0x003313D0
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RolloutDialogue_d__21(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._RolloutDialogue_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D736 RID: 55094 RVA: 0x00333218 File Offset: 0x00331418
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._RolloutDialogue_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D737 RID: 55095 RVA: 0x0033324C File Offset: 0x0033144C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256833, XrefRangeEnd = 256879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._RolloutDialogue_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170042B5 RID: 17077
			// (get) Token: 0x0600D738 RID: 55096 RVA: 0x00333288 File Offset: 0x00331488
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._RolloutDialogue_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D739 RID: 55097 RVA: 0x003332C8 File Offset: 0x003314C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256879, XrefRangeEnd = 256884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._RolloutDialogue_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170042B6 RID: 17078
			// (get) Token: 0x0600D73A RID: 55098 RVA: 0x003332FC File Offset: 0x003314FC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._RolloutDialogue_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D73B RID: 55099 RVA: 0x00068C11 File Offset: 0x00066E11
			public _RolloutDialogue_d__21(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042AD RID: 17069
			// (get) Token: 0x0600D73C RID: 55100 RVA: 0x0033333C File Offset: 0x0033153C
			// (set) Token: 0x0600D73D RID: 55101 RVA: 0x00068C1A File Offset: 0x00066E1A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170042AE RID: 17070
			// (get) Token: 0x0600D73E RID: 55102 RVA: 0x00333364 File Offset: 0x00331564
			// (set) Token: 0x0600D73F RID: 55103 RVA: 0x00068C35 File Offset: 0x00066E35
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042AF RID: 17071
			// (get) Token: 0x0600D740 RID: 55104 RVA: 0x00333394 File Offset: 0x00331594
			// (set) Token: 0x0600D741 RID: 55105 RVA: 0x00068C54 File Offset: 0x00066E54
			public unsafe DialogueCanvas __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueCanvas>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042B0 RID: 17072
			// (get) Token: 0x0600D742 RID: 55106 RVA: 0x003333C4 File Offset: 0x003315C4
			// (set) Token: 0x0600D743 RID: 55107 RVA: 0x00068C73 File Offset: 0x00066E73
			public unsafe string text
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr_text);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170042B1 RID: 17073
			// (get) Token: 0x0600D744 RID: 55108 RVA: 0x003333EC File Offset: 0x003315EC
			// (set) Token: 0x0600D745 RID: 55109 RVA: 0x00068C92 File Offset: 0x00066E92
			public unsafe List<string> choices
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr_choices);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr_choices), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042B2 RID: 17074
			// (get) Token: 0x0600D746 RID: 55110 RVA: 0x0033341C File Offset: 0x0033161C
			// (set) Token: 0x0600D747 RID: 55111 RVA: 0x00068CB1 File Offset: 0x00066EB1
			public unsafe List<int> _activeDialogueChoices_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr__activeDialogueChoices_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr__activeDialogueChoices_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042B3 RID: 17075
			// (get) Token: 0x0600D748 RID: 55112 RVA: 0x0033344C File Offset: 0x0033164C
			// (set) Token: 0x0600D749 RID: 55113 RVA: 0x00068CD0 File Offset: 0x00066ED0
			public unsafe float _rolloutTime_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr__rolloutTime_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr__rolloutTime_5__3)) = value;
				}
			}

			// Token: 0x170042B4 RID: 17076
			// (get) Token: 0x0600D74A RID: 55114 RVA: 0x00333474 File Offset: 0x00331674
			// (set) Token: 0x0600D74B RID: 55115 RVA: 0x00068CEB File Offset: 0x00066EEB
			public unsafe float _i_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr__i_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr__i_5__4)) = value;
				}
			}

			// Token: 0x040090B0 RID: 37040
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040090B1 RID: 37041
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040090B2 RID: 37042
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040090B3 RID: 37043
			private static readonly IntPtr NativeFieldInfoPtr_text;

			// Token: 0x040090B4 RID: 37044
			private static readonly IntPtr NativeFieldInfoPtr_choices;

			// Token: 0x040090B5 RID: 37045
			private static readonly IntPtr NativeFieldInfoPtr__activeDialogueChoices_5__2;

			// Token: 0x040090B6 RID: 37046
			private static readonly IntPtr NativeFieldInfoPtr__rolloutTime_5__3;

			// Token: 0x040090B7 RID: 37047
			private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

			// Token: 0x040090B8 RID: 37048
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040090B9 RID: 37049
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040090BA RID: 37050
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040090BB RID: 37051
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040090BC RID: 37052
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040090BD RID: 37053
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
