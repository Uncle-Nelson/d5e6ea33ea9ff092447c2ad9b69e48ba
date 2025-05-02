using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.UI;
using Il2CppScheduleOne.VoiceOver;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x0200043C RID: 1084
	public class DialogueHandler : MonoBehaviour
	{
		// Token: 0x06005ED4 RID: 24276 RVA: 0x001B41D8 File Offset: 0x001B23D8
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueHandler()
		{
			Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr);
			DialogueHandler.NativeFieldInfoPtr_TimePerChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "TimePerChar");
			DialogueHandler.NativeFieldInfoPtr_WorldspaceDialogueMinDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "WorldspaceDialogueMinDuration");
			DialogueHandler.NativeFieldInfoPtr_WorldspaceDialogueMaxDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "WorldspaceDialogueMaxDuration");
			DialogueHandler.NativeFieldInfoPtr_activeDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "activeDialogue");
			DialogueHandler.NativeFieldInfoPtr_activeDialogueNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "activeDialogueNode");
			DialogueHandler.NativeFieldInfoPtr__IsPlaying_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "<IsPlaying>k__BackingField");
			DialogueHandler.NativeFieldInfoPtr_Database = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "Database");
			DialogueHandler.NativeFieldInfoPtr_LookPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "LookPosition");
			DialogueHandler.NativeFieldInfoPtr_WorldspaceRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "WorldspaceRend");
			DialogueHandler.NativeFieldInfoPtr__NPC_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "<NPC>k__BackingField");
			DialogueHandler.NativeFieldInfoPtr_VOEmitter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "VOEmitter");
			DialogueHandler.NativeFieldInfoPtr_CurrentChoices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "CurrentChoices");
			DialogueHandler.NativeFieldInfoPtr_DialogueEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "DialogueEvents");
			DialogueHandler.NativeFieldInfoPtr_onConversationStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "onConversationStart");
			DialogueHandler.NativeFieldInfoPtr_onDialogueNodeDisplayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "onDialogueNodeDisplayed");
			DialogueHandler.NativeFieldInfoPtr_onDialogueChoiceChosen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "onDialogueChoiceChosen");
			DialogueHandler.NativeFieldInfoPtr_overrideText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "overrideText");
			DialogueHandler.NativeFieldInfoPtr_dialogueContainers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "dialogueContainers");
			DialogueHandler.NativeFieldInfoPtr_TempLinks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "TempLinks");
			DialogueHandler.NativeFieldInfoPtr_skipNextDialogueBehaviourEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "skipNextDialogueBehaviourEnd");
			DialogueHandler.NativeFieldInfoPtr__runtimeModules_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "<runtimeModules>k__BackingField");
			DialogueHandler.NativeFieldInfoPtr_passChecked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "passChecked");
			DialogueHandler.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675372);
			DialogueHandler.NativeMethodInfoPtr_set_IsPlaying_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675373);
			DialogueHandler.NativeMethodInfoPtr_get_NPC_Public_get_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675374);
			DialogueHandler.NativeMethodInfoPtr_set_NPC_Protected_set_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675375);
			DialogueHandler.NativeMethodInfoPtr_get_canvas_Private_get_DialogueCanvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675376);
			DialogueHandler.NativeMethodInfoPtr_get_runtimeModules_Public_get_List_1_DialogueModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675377);
			DialogueHandler.NativeMethodInfoPtr_set_runtimeModules_Private_set_Void_List_1_DialogueModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675378);
			DialogueHandler.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675379);
			DialogueHandler.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675380);
			DialogueHandler.NativeMethodInfoPtr_InitializeDialogue_Public_Void_DialogueContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675381);
			DialogueHandler.NativeMethodInfoPtr_InitializeDialogue_Public_Void_DialogueContainer_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675382);
			DialogueHandler.NativeMethodInfoPtr_InitializeDialogue_Public_Void_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675383);
			DialogueHandler.NativeMethodInfoPtr_CanBeginConversation_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675384);
			DialogueHandler.NativeMethodInfoPtr_OverrideShownDialogue_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675385);
			DialogueHandler.NativeMethodInfoPtr_StopOverride_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675386);
			DialogueHandler.NativeMethodInfoPtr_EndDialogue_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675387);
			DialogueHandler.NativeMethodInfoPtr_SkipNextDialogueBehaviourEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675388);
			DialogueHandler.NativeMethodInfoPtr_FinalizeDialogueNode_Protected_Virtual_New_DialogueNodeData_DialogueNodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675389);
			DialogueHandler.NativeMethodInfoPtr_ShowNode_Public_Void_DialogueNodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675390);
			DialogueHandler.NativeMethodInfoPtr_EvaluateBranch_Private_Void_BranchNodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675391);
			DialogueHandler.NativeMethodInfoPtr_ChoiceSelected_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675392);
			DialogueHandler.NativeMethodInfoPtr_ContinueSubmitted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675393);
			DialogueHandler.NativeMethodInfoPtr_CheckChoice_Public_Virtual_New_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675394);
			DialogueHandler.NativeMethodInfoPtr_ShouldChoiceBeShown_Public_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675395);
			DialogueHandler.NativeMethodInfoPtr_CheckBranch_Protected_Virtual_New_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675396);
			DialogueHandler.NativeMethodInfoPtr_ModifyDialogueText_Protected_Virtual_New_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675397);
			DialogueHandler.NativeMethodInfoPtr_ModifyChoiceText_Protected_Virtual_New_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675398);
			DialogueHandler.NativeMethodInfoPtr_ChoiceCallback_Protected_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675399);
			DialogueHandler.NativeMethodInfoPtr_DialogueCallback_Protected_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675400);
			DialogueHandler.NativeMethodInfoPtr_ModifyChoiceList_Protected_Virtual_New_Void_String_byref_List_1_DialogueChoiceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675401);
			DialogueHandler.NativeMethodInfoPtr_CreateTempLink_Protected_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675402);
			DialogueHandler.NativeMethodInfoPtr_GetLink_Private_NodeLinkData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675403);
			DialogueHandler.NativeMethodInfoPtr_Hovered_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675404);
			DialogueHandler.NativeMethodInfoPtr_Interacted_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675405);
			DialogueHandler.NativeMethodInfoPtr_PlayReaction_Local_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675406);
			DialogueHandler.NativeMethodInfoPtr_PlayReaction_Networked_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675407);
			DialogueHandler.NativeMethodInfoPtr_PlayReaction_Public_Virtual_New_Void_String_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675408);
			DialogueHandler.NativeMethodInfoPtr_HideWorldspaceDialogue_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675409);
			DialogueHandler.NativeMethodInfoPtr_ShowWorldspaceDialogue_Public_Virtual_New_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675410);
			DialogueHandler.NativeMethodInfoPtr_ShowWorldspaceDialogue_5s_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675411);
			DialogueHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675412);
		}

		// Token: 0x17001C94 RID: 7316
		// (get) Token: 0x06005ED5 RID: 24277 RVA: 0x001B46F4 File Offset: 0x001B28F4
		// (set) Token: 0x06005ED6 RID: 24278 RVA: 0x001B4730 File Offset: 0x001B2930
		public unsafe bool IsPlaying
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35365, RefRangeEnd = 35366, XrefRangeStart = 35365, XrefRangeEnd = 35366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35366, RefRangeEnd = 35368, XrefRangeStart = 35366, XrefRangeEnd = 35368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_set_IsPlaying_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001C95 RID: 7317
		// (get) Token: 0x06005ED7 RID: 24279 RVA: 0x001B4770 File Offset: 0x001B2970
		// (set) Token: 0x06005ED8 RID: 24280 RVA: 0x001B47B0 File Offset: 0x001B29B0
		public unsafe NPC NPC
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35358, RefRangeEnd = 35359, XrefRangeStart = 35358, XrefRangeEnd = 35359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_get_NPC_Public_get_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_set_NPC_Protected_set_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001C96 RID: 7318
		// (get) Token: 0x06005ED9 RID: 24281 RVA: 0x001B47F4 File Offset: 0x001B29F4
		public unsafe DialogueCanvas canvas
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 197738, RefRangeEnd = 197740, XrefRangeStart = 197735, XrefRangeEnd = 197738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_get_canvas_Private_get_DialogueCanvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogueCanvas>(intPtr3) : null;
			}
		}

		// Token: 0x17001C97 RID: 7319
		// (get) Token: 0x06005EDA RID: 24282 RVA: 0x001B4834 File Offset: 0x001B2A34
		// (set) Token: 0x06005EDB RID: 24283 RVA: 0x001B4874 File Offset: 0x001B2A74
		public unsafe List<DialogueModule> runtimeModules
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_get_runtimeModules_Public_get_List_1_DialogueModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<DialogueModule>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_set_runtimeModules_Private_set_Void_List_1_DialogueModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005EDC RID: 24284 RVA: 0x001B48B8 File Offset: 0x001B2AB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 197764, RefRangeEnd = 197766, XrefRangeStart = 197740, XrefRangeEnd = 197764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EDD RID: 24285 RVA: 0x001B48F4 File Offset: 0x001B2AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197766, XrefRangeEnd = 197801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EDE RID: 24286 RVA: 0x001B4930 File Offset: 0x001B2B30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 197804, RefRangeEnd = 197806, XrefRangeStart = 197801, XrefRangeEnd = 197804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeDialogue(DialogueContainer container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_InitializeDialogue_Public_Void_DialogueContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EDF RID: 24287 RVA: 0x001B4974 File Offset: 0x001B2B74
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 197836, RefRangeEnd = 197840, XrefRangeStart = 197806, XrefRangeEnd = 197836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeDialogue(DialogueContainer dialogueContainer, bool enableDialogueBehaviour = true, string entryNodeLabel = "ENTRY")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dialogueContainer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableDialogueBehaviour;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(entryNodeLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_InitializeDialogue_Public_Void_DialogueContainer_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EE0 RID: 24288 RVA: 0x001B49D8 File Offset: 0x001B2BD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 197862, RefRangeEnd = 197863, XrefRangeStart = 197840, XrefRangeEnd = 197862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeDialogue(string dialogueContainerName, bool enableDialogueBehaviour = true, string entryNodeLabel = "ENTRY")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueContainerName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableDialogueBehaviour;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(entryNodeLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_InitializeDialogue_Public_Void_String_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EE1 RID: 24289 RVA: 0x001B4A3C File Offset: 0x001B2C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197863, XrefRangeEnd = 197868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanBeginConversation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_CanBeginConversation_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005EE2 RID: 24290 RVA: 0x001B4A84 File Offset: 0x001B2C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197868, XrefRangeEnd = 197872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideShownDialogue(string _overrideText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_overrideText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_OverrideShownDialogue_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EE3 RID: 24291 RVA: 0x001B4AC8 File Offset: 0x001B2CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197872, XrefRangeEnd = 197880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopOverride()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_StopOverride_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EE4 RID: 24292 RVA: 0x001B4AFC File Offset: 0x001B2CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197880, XrefRangeEnd = 197904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EndDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_EndDialogue_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EE5 RID: 24293 RVA: 0x001B4B38 File Offset: 0x001B2D38
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 197904, RefRangeEnd = 197908, XrefRangeStart = 197904, XrefRangeEnd = 197904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkipNextDialogueBehaviourEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_SkipNextDialogueBehaviourEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EE6 RID: 24294 RVA: 0x001B4B6C File Offset: 0x001B2D6C
		[CallerCount(0)]
		public unsafe virtual DialogueNodeData FinalizeDialogueNode(DialogueNodeData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_FinalizeDialogueNode_Protected_Virtual_New_DialogueNodeData_DialogueNodeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogueNodeData>(intPtr3) : null;
		}

		// Token: 0x06005EE7 RID: 24295 RVA: 0x001B4BC8 File Offset: 0x001B2DC8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 197963, RefRangeEnd = 197969, XrefRangeStart = 197908, XrefRangeEnd = 197963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowNode(DialogueNodeData node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_ShowNode_Public_Void_DialogueNodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EE8 RID: 24296 RVA: 0x001B4C0C File Offset: 0x001B2E0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 197990, RefRangeEnd = 197992, XrefRangeStart = 197969, XrefRangeEnd = 197990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EvaluateBranch(BranchNodeData node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_EvaluateBranch_Private_Void_BranchNodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EE9 RID: 24297 RVA: 0x001B4C50 File Offset: 0x001B2E50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 198001, RefRangeEnd = 198002, XrefRangeStart = 197992, XrefRangeEnd = 198001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChoiceSelected(int choiceIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref choiceIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_ChoiceSelected_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EEA RID: 24298 RVA: 0x001B4C90 File Offset: 0x001B2E90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 198005, RefRangeEnd = 198006, XrefRangeStart = 198002, XrefRangeEnd = 198005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ContinueSubmitted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_ContinueSubmitted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EEB RID: 24299 RVA: 0x001B4CC4 File Offset: 0x001B2EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198006, XrefRangeEnd = 198013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_CheckChoice_Public_Virtual_New_Boolean_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005EEC RID: 24300 RVA: 0x001B4D38 File Offset: 0x001B2F38
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 30138, RefRangeEnd = 30158, XrefRangeStart = 30138, XrefRangeEnd = 30158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldChoiceBeShown(string choiceLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_ShouldChoiceBeShown_Public_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005EED RID: 24301 RVA: 0x001B4D90 File Offset: 0x001B2F90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198013, XrefRangeEnd = 198031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int CheckBranch(string branchLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(branchLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_CheckBranch_Protected_Virtual_New_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005EEE RID: 24302 RVA: 0x001B4DE8 File Offset: 0x001B2FE8
		[CallerCount(0)]
		public unsafe virtual string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogueText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_ModifyDialogueText_Protected_Virtual_New_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005EEF RID: 24303 RVA: 0x001B4E50 File Offset: 0x001B3050
		[CallerCount(0)]
		public unsafe virtual string ModifyChoiceText(string choiceLabel, string choiceText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(choiceText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_ModifyChoiceText_Protected_Virtual_New_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005EF0 RID: 24304 RVA: 0x001B4EB8 File Offset: 0x001B30B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198031, XrefRangeEnd = 198034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ChoiceCallback(string choiceLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_ChoiceCallback_Protected_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EF1 RID: 24305 RVA: 0x001B4F08 File Offset: 0x001B3108
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 198047, RefRangeEnd = 198049, XrefRangeStart = 198034, XrefRangeEnd = 198047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DialogueCallback(string dialogueLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_DialogueCallback_Protected_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EF2 RID: 24306 RVA: 0x001B4F58 File Offset: 0x001B3158
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(existingChoices);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_ModifyChoiceList_Protected_Virtual_New_Void_String_byref_List_1_DialogueChoiceData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			existingChoices = ((intPtr4 == 0) ? null : new List<DialogueChoiceData>(intPtr4));
		}

		// Token: 0x06005EF3 RID: 24307 RVA: 0x001B4FCC File Offset: 0x001B31CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198049, XrefRangeEnd = 198059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateTempLink(string baseNodeGUID, string baseOptionGUID, string targetNodeGUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(baseNodeGUID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(baseOptionGUID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetNodeGUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_CreateTempLink_Protected_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EF4 RID: 24308 RVA: 0x001B5034 File Offset: 0x001B3234
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 198089, RefRangeEnd = 198092, XrefRangeStart = 198059, XrefRangeEnd = 198089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NodeLinkData GetLink(string baseChoiceOrOptionGUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(baseChoiceOrOptionGUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_GetLink_Private_NodeLinkData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NodeLinkData>(intPtr3) : null;
		}

		// Token: 0x06005EF5 RID: 24309 RVA: 0x001B5084 File Offset: 0x001B3284
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_Hovered_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EF6 RID: 24310 RVA: 0x001B50C0 File Offset: 0x001B32C0
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_Interacted_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EF7 RID: 24311 RVA: 0x001B50FC File Offset: 0x001B32FC
		[CallerCount(0)]
		public unsafe virtual void PlayReaction_Local(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_PlayReaction_Local_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EF8 RID: 24312 RVA: 0x001B514C File Offset: 0x001B334C
		[CallerCount(0)]
		public unsafe virtual void PlayReaction_Networked(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_PlayReaction_Networked_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EF9 RID: 24313 RVA: 0x001B519C File Offset: 0x001B339C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198092, XrefRangeEnd = 198098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PlayReaction(string key, float duration, bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_PlayReaction_Public_Virtual_New_Void_String_Single_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EFA RID: 24314 RVA: 0x001B5208 File Offset: 0x001B3408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198098, XrefRangeEnd = 198100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HideWorldspaceDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_HideWorldspaceDialogue_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EFB RID: 24315 RVA: 0x001B5244 File Offset: 0x001B3444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198100, XrefRangeEnd = 198102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ShowWorldspaceDialogue(string text, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_ShowWorldspaceDialogue_Public_Virtual_New_Void_String_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EFC RID: 24316 RVA: 0x001B52A0 File Offset: 0x001B34A0
		[CallerCount(0)]
		public unsafe virtual void ShowWorldspaceDialogue_5s(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_ShowWorldspaceDialogue_5s_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EFD RID: 24317 RVA: 0x001B52F0 File Offset: 0x001B34F0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 198134, RefRangeEnd = 198139, XrefRangeStart = 198102, XrefRangeEnd = 198134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueHandler() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EFE RID: 24318 RVA: 0x0002CBB0 File Offset: 0x0002ADB0
		public DialogueHandler(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C7E RID: 7294
		// (get) Token: 0x06005EFF RID: 24319 RVA: 0x001B532C File Offset: 0x001B352C
		// (set) Token: 0x06005F00 RID: 24320 RVA: 0x0002CBB9 File Offset: 0x0002ADB9
		public unsafe static float TimePerChar
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DialogueHandler.NativeFieldInfoPtr_TimePerChar, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DialogueHandler.NativeFieldInfoPtr_TimePerChar, (void*)(&value));
			}
		}

		// Token: 0x17001C7F RID: 7295
		// (get) Token: 0x06005F01 RID: 24321 RVA: 0x001B5348 File Offset: 0x001B3548
		// (set) Token: 0x06005F02 RID: 24322 RVA: 0x0002CBC7 File Offset: 0x0002ADC7
		public unsafe static float WorldspaceDialogueMinDuration
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DialogueHandler.NativeFieldInfoPtr_WorldspaceDialogueMinDuration, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DialogueHandler.NativeFieldInfoPtr_WorldspaceDialogueMinDuration, (void*)(&value));
			}
		}

		// Token: 0x17001C80 RID: 7296
		// (get) Token: 0x06005F03 RID: 24323 RVA: 0x001B5364 File Offset: 0x001B3564
		// (set) Token: 0x06005F04 RID: 24324 RVA: 0x0002CBD5 File Offset: 0x0002ADD5
		public unsafe static float WorldspaceDialogueMaxDuration
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DialogueHandler.NativeFieldInfoPtr_WorldspaceDialogueMaxDuration, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DialogueHandler.NativeFieldInfoPtr_WorldspaceDialogueMaxDuration, (void*)(&value));
			}
		}

		// Token: 0x17001C81 RID: 7297
		// (get) Token: 0x06005F05 RID: 24325 RVA: 0x001B5380 File Offset: 0x001B3580
		// (set) Token: 0x06005F06 RID: 24326 RVA: 0x0002CBE3 File Offset: 0x0002ADE3
		public unsafe static DialogueContainer activeDialogue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DialogueHandler.NativeFieldInfoPtr_activeDialogue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DialogueHandler.NativeFieldInfoPtr_activeDialogue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C82 RID: 7298
		// (get) Token: 0x06005F07 RID: 24327 RVA: 0x001B53A8 File Offset: 0x001B35A8
		// (set) Token: 0x06005F08 RID: 24328 RVA: 0x0002CBF5 File Offset: 0x0002ADF5
		public unsafe static DialogueNodeData activeDialogueNode
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DialogueHandler.NativeFieldInfoPtr_activeDialogueNode, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueNodeData>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DialogueHandler.NativeFieldInfoPtr_activeDialogueNode, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C83 RID: 7299
		// (get) Token: 0x06005F09 RID: 24329 RVA: 0x001B53D0 File Offset: 0x001B35D0
		// (set) Token: 0x06005F0A RID: 24330 RVA: 0x0002CC07 File Offset: 0x0002AE07
		public unsafe bool _IsPlaying_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr__IsPlaying_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr__IsPlaying_k__BackingField)) = value;
			}
		}

		// Token: 0x17001C84 RID: 7300
		// (get) Token: 0x06005F0B RID: 24331 RVA: 0x001B53F8 File Offset: 0x001B35F8
		// (set) Token: 0x06005F0C RID: 24332 RVA: 0x0002CC22 File Offset: 0x0002AE22
		public unsafe DialogueDatabase Database
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_Database);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueDatabase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_Database), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C85 RID: 7301
		// (get) Token: 0x06005F0D RID: 24333 RVA: 0x001B5428 File Offset: 0x001B3628
		// (set) Token: 0x06005F0E RID: 24334 RVA: 0x0002CC41 File Offset: 0x0002AE41
		public unsafe Transform LookPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_LookPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_LookPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C86 RID: 7302
		// (get) Token: 0x06005F0F RID: 24335 RVA: 0x001B5458 File Offset: 0x001B3658
		// (set) Token: 0x06005F10 RID: 24336 RVA: 0x0002CC60 File Offset: 0x0002AE60
		public unsafe WorldspaceDialogueRenderer WorldspaceRend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_WorldspaceRend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspaceDialogueRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_WorldspaceRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C87 RID: 7303
		// (get) Token: 0x06005F11 RID: 24337 RVA: 0x001B5488 File Offset: 0x001B3688
		// (set) Token: 0x06005F12 RID: 24338 RVA: 0x0002CC7F File Offset: 0x0002AE7F
		public unsafe NPC _NPC_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr__NPC_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr__NPC_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C88 RID: 7304
		// (get) Token: 0x06005F13 RID: 24339 RVA: 0x001B54B8 File Offset: 0x001B36B8
		// (set) Token: 0x06005F14 RID: 24340 RVA: 0x0002CC9E File Offset: 0x0002AE9E
		public unsafe VOEmitter VOEmitter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_VOEmitter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VOEmitter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_VOEmitter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C89 RID: 7305
		// (get) Token: 0x06005F15 RID: 24341 RVA: 0x001B54E8 File Offset: 0x001B36E8
		// (set) Token: 0x06005F16 RID: 24342 RVA: 0x0002CCBD File Offset: 0x0002AEBD
		public unsafe List<DialogueChoiceData> CurrentChoices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_CurrentChoices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueChoiceData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_CurrentChoices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C8A RID: 7306
		// (get) Token: 0x06005F17 RID: 24343 RVA: 0x001B5518 File Offset: 0x001B3718
		// (set) Token: 0x06005F18 RID: 24344 RVA: 0x0002CCDC File Offset: 0x0002AEDC
		public unsafe Il2CppReferenceArray<DialogueEvent> DialogueEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_DialogueEvents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogueEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_DialogueEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C8B RID: 7307
		// (get) Token: 0x06005F19 RID: 24345 RVA: 0x001B5548 File Offset: 0x001B3748
		// (set) Token: 0x06005F1A RID: 24346 RVA: 0x0002CCFB File Offset: 0x0002AEFB
		public unsafe UnityEvent onConversationStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_onConversationStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_onConversationStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C8C RID: 7308
		// (get) Token: 0x06005F1B RID: 24347 RVA: 0x001B5578 File Offset: 0x001B3778
		// (set) Token: 0x06005F1C RID: 24348 RVA: 0x0002CD1A File Offset: 0x0002AF1A
		public unsafe UnityEvent<string> onDialogueNodeDisplayed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_onDialogueNodeDisplayed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_onDialogueNodeDisplayed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C8D RID: 7309
		// (get) Token: 0x06005F1D RID: 24349 RVA: 0x001B55A8 File Offset: 0x001B37A8
		// (set) Token: 0x06005F1E RID: 24350 RVA: 0x0002CD39 File Offset: 0x0002AF39
		public unsafe UnityEvent<string> onDialogueChoiceChosen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_onDialogueChoiceChosen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_onDialogueChoiceChosen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C8E RID: 7310
		// (get) Token: 0x06005F1F RID: 24351 RVA: 0x001B55D8 File Offset: 0x001B37D8
		// (set) Token: 0x06005F20 RID: 24352 RVA: 0x0002CD58 File Offset: 0x0002AF58
		public unsafe string overrideText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_overrideText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_overrideText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001C8F RID: 7311
		// (get) Token: 0x06005F21 RID: 24353 RVA: 0x001B5600 File Offset: 0x001B3800
		// (set) Token: 0x06005F22 RID: 24354 RVA: 0x0002CD77 File Offset: 0x0002AF77
		public unsafe List<DialogueContainer> dialogueContainers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_dialogueContainers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueContainer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_dialogueContainers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C90 RID: 7312
		// (get) Token: 0x06005F23 RID: 24355 RVA: 0x001B5630 File Offset: 0x001B3830
		// (set) Token: 0x06005F24 RID: 24356 RVA: 0x0002CD96 File Offset: 0x0002AF96
		public unsafe List<NodeLinkData> TempLinks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_TempLinks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NodeLinkData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_TempLinks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C91 RID: 7313
		// (get) Token: 0x06005F25 RID: 24357 RVA: 0x001B5660 File Offset: 0x001B3860
		// (set) Token: 0x06005F26 RID: 24358 RVA: 0x0002CDB5 File Offset: 0x0002AFB5
		public unsafe bool skipNextDialogueBehaviourEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_skipNextDialogueBehaviourEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_skipNextDialogueBehaviourEnd)) = value;
			}
		}

		// Token: 0x17001C92 RID: 7314
		// (get) Token: 0x06005F27 RID: 24359 RVA: 0x001B5688 File Offset: 0x001B3888
		// (set) Token: 0x06005F28 RID: 24360 RVA: 0x0002CDD0 File Offset: 0x0002AFD0
		public unsafe List<DialogueModule> _runtimeModules_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr__runtimeModules_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueModule>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr__runtimeModules_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C93 RID: 7315
		// (get) Token: 0x06005F29 RID: 24361 RVA: 0x001B56B8 File Offset: 0x001B38B8
		// (set) Token: 0x06005F2A RID: 24362 RVA: 0x0002CDEF File Offset: 0x0002AFEF
		public unsafe bool passChecked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_passChecked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_passChecked)) = value;
			}
		}

		// Token: 0x040040D1 RID: 16593
		private static readonly IntPtr NativeFieldInfoPtr_TimePerChar;

		// Token: 0x040040D2 RID: 16594
		private static readonly IntPtr NativeFieldInfoPtr_WorldspaceDialogueMinDuration;

		// Token: 0x040040D3 RID: 16595
		private static readonly IntPtr NativeFieldInfoPtr_WorldspaceDialogueMaxDuration;

		// Token: 0x040040D4 RID: 16596
		private static readonly IntPtr NativeFieldInfoPtr_activeDialogue;

		// Token: 0x040040D5 RID: 16597
		private static readonly IntPtr NativeFieldInfoPtr_activeDialogueNode;

		// Token: 0x040040D6 RID: 16598
		private static readonly IntPtr NativeFieldInfoPtr__IsPlaying_k__BackingField;

		// Token: 0x040040D7 RID: 16599
		private static readonly IntPtr NativeFieldInfoPtr_Database;

		// Token: 0x040040D8 RID: 16600
		private static readonly IntPtr NativeFieldInfoPtr_LookPosition;

		// Token: 0x040040D9 RID: 16601
		private static readonly IntPtr NativeFieldInfoPtr_WorldspaceRend;

		// Token: 0x040040DA RID: 16602
		private static readonly IntPtr NativeFieldInfoPtr__NPC_k__BackingField;

		// Token: 0x040040DB RID: 16603
		private static readonly IntPtr NativeFieldInfoPtr_VOEmitter;

		// Token: 0x040040DC RID: 16604
		private static readonly IntPtr NativeFieldInfoPtr_CurrentChoices;

		// Token: 0x040040DD RID: 16605
		private static readonly IntPtr NativeFieldInfoPtr_DialogueEvents;

		// Token: 0x040040DE RID: 16606
		private static readonly IntPtr NativeFieldInfoPtr_onConversationStart;

		// Token: 0x040040DF RID: 16607
		private static readonly IntPtr NativeFieldInfoPtr_onDialogueNodeDisplayed;

		// Token: 0x040040E0 RID: 16608
		private static readonly IntPtr NativeFieldInfoPtr_onDialogueChoiceChosen;

		// Token: 0x040040E1 RID: 16609
		private static readonly IntPtr NativeFieldInfoPtr_overrideText;

		// Token: 0x040040E2 RID: 16610
		private static readonly IntPtr NativeFieldInfoPtr_dialogueContainers;

		// Token: 0x040040E3 RID: 16611
		private static readonly IntPtr NativeFieldInfoPtr_TempLinks;

		// Token: 0x040040E4 RID: 16612
		private static readonly IntPtr NativeFieldInfoPtr_skipNextDialogueBehaviourEnd;

		// Token: 0x040040E5 RID: 16613
		private static readonly IntPtr NativeFieldInfoPtr__runtimeModules_k__BackingField;

		// Token: 0x040040E6 RID: 16614
		private static readonly IntPtr NativeFieldInfoPtr_passChecked;

		// Token: 0x040040E7 RID: 16615
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0;

		// Token: 0x040040E8 RID: 16616
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPlaying_Private_set_Void_Boolean_0;

		// Token: 0x040040E9 RID: 16617
		private static readonly IntPtr NativeMethodInfoPtr_get_NPC_Public_get_NPC_0;

		// Token: 0x040040EA RID: 16618
		private static readonly IntPtr NativeMethodInfoPtr_set_NPC_Protected_set_Void_NPC_0;

		// Token: 0x040040EB RID: 16619
		private static readonly IntPtr NativeMethodInfoPtr_get_canvas_Private_get_DialogueCanvas_0;

		// Token: 0x040040EC RID: 16620
		private static readonly IntPtr NativeMethodInfoPtr_get_runtimeModules_Public_get_List_1_DialogueModule_0;

		// Token: 0x040040ED RID: 16621
		private static readonly IntPtr NativeMethodInfoPtr_set_runtimeModules_Private_set_Void_List_1_DialogueModule_0;

		// Token: 0x040040EE RID: 16622
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040040EF RID: 16623
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x040040F0 RID: 16624
		private static readonly IntPtr NativeMethodInfoPtr_InitializeDialogue_Public_Void_DialogueContainer_0;

		// Token: 0x040040F1 RID: 16625
		private static readonly IntPtr NativeMethodInfoPtr_InitializeDialogue_Public_Void_DialogueContainer_Boolean_String_0;

		// Token: 0x040040F2 RID: 16626
		private static readonly IntPtr NativeMethodInfoPtr_InitializeDialogue_Public_Void_String_Boolean_String_0;

		// Token: 0x040040F3 RID: 16627
		private static readonly IntPtr NativeMethodInfoPtr_CanBeginConversation_Public_Virtual_New_Boolean_0;

		// Token: 0x040040F4 RID: 16628
		private static readonly IntPtr NativeMethodInfoPtr_OverrideShownDialogue_Public_Void_String_0;

		// Token: 0x040040F5 RID: 16629
		private static readonly IntPtr NativeMethodInfoPtr_StopOverride_Public_Void_0;

		// Token: 0x040040F6 RID: 16630
		private static readonly IntPtr NativeMethodInfoPtr_EndDialogue_Public_Virtual_New_Void_0;

		// Token: 0x040040F7 RID: 16631
		private static readonly IntPtr NativeMethodInfoPtr_SkipNextDialogueBehaviourEnd_Public_Void_0;

		// Token: 0x040040F8 RID: 16632
		private static readonly IntPtr NativeMethodInfoPtr_FinalizeDialogueNode_Protected_Virtual_New_DialogueNodeData_DialogueNodeData_0;

		// Token: 0x040040F9 RID: 16633
		private static readonly IntPtr NativeMethodInfoPtr_ShowNode_Public_Void_DialogueNodeData_0;

		// Token: 0x040040FA RID: 16634
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateBranch_Private_Void_BranchNodeData_0;

		// Token: 0x040040FB RID: 16635
		private static readonly IntPtr NativeMethodInfoPtr_ChoiceSelected_Public_Void_Int32_0;

		// Token: 0x040040FC RID: 16636
		private static readonly IntPtr NativeMethodInfoPtr_ContinueSubmitted_Public_Void_0;

		// Token: 0x040040FD RID: 16637
		private static readonly IntPtr NativeMethodInfoPtr_CheckChoice_Public_Virtual_New_Boolean_String_byref_String_0;

		// Token: 0x040040FE RID: 16638
		private static readonly IntPtr NativeMethodInfoPtr_ShouldChoiceBeShown_Public_Virtual_New_Boolean_String_0;

		// Token: 0x040040FF RID: 16639
		private static readonly IntPtr NativeMethodInfoPtr_CheckBranch_Protected_Virtual_New_Int32_String_0;

		// Token: 0x04004100 RID: 16640
		private static readonly IntPtr NativeMethodInfoPtr_ModifyDialogueText_Protected_Virtual_New_String_String_String_0;

		// Token: 0x04004101 RID: 16641
		private static readonly IntPtr NativeMethodInfoPtr_ModifyChoiceText_Protected_Virtual_New_String_String_String_0;

		// Token: 0x04004102 RID: 16642
		private static readonly IntPtr NativeMethodInfoPtr_ChoiceCallback_Protected_Virtual_New_Void_String_0;

		// Token: 0x04004103 RID: 16643
		private static readonly IntPtr NativeMethodInfoPtr_DialogueCallback_Protected_Virtual_New_Void_String_0;

		// Token: 0x04004104 RID: 16644
		private static readonly IntPtr NativeMethodInfoPtr_ModifyChoiceList_Protected_Virtual_New_Void_String_byref_List_1_DialogueChoiceData_0;

		// Token: 0x04004105 RID: 16645
		private static readonly IntPtr NativeMethodInfoPtr_CreateTempLink_Protected_Void_String_String_String_0;

		// Token: 0x04004106 RID: 16646
		private static readonly IntPtr NativeMethodInfoPtr_GetLink_Private_NodeLinkData_String_0;

		// Token: 0x04004107 RID: 16647
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Virtual_New_Void_0;

		// Token: 0x04004108 RID: 16648
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Virtual_New_Void_0;

		// Token: 0x04004109 RID: 16649
		private static readonly IntPtr NativeMethodInfoPtr_PlayReaction_Local_Public_Virtual_New_Void_String_0;

		// Token: 0x0400410A RID: 16650
		private static readonly IntPtr NativeMethodInfoPtr_PlayReaction_Networked_Public_Virtual_New_Void_String_0;

		// Token: 0x0400410B RID: 16651
		private static readonly IntPtr NativeMethodInfoPtr_PlayReaction_Public_Virtual_New_Void_String_Single_Boolean_0;

		// Token: 0x0400410C RID: 16652
		private static readonly IntPtr NativeMethodInfoPtr_HideWorldspaceDialogue_Public_Virtual_New_Void_0;

		// Token: 0x0400410D RID: 16653
		private static readonly IntPtr NativeMethodInfoPtr_ShowWorldspaceDialogue_Public_Virtual_New_Void_String_Single_0;

		// Token: 0x0400410E RID: 16654
		private static readonly IntPtr NativeMethodInfoPtr_ShowWorldspaceDialogue_5s_Public_Virtual_New_Void_String_0;

		// Token: 0x0400410F RID: 16655
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009FE RID: 2558
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueHandler+<>c__DisplayClass35_0")]
		public sealed class __c__DisplayClass35_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CE47 RID: 52807 RVA: 0x0031A0C4 File Offset: 0x003182C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass35_0()
			{
				Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "<>c__DisplayClass35_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0>.NativeClassPtr);
				DialogueHandler.__c__DisplayClass35_0.NativeFieldInfoPtr_npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0>.NativeClassPtr, "npc");
				DialogueHandler.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0>.NativeClassPtr, "<>4__this");
				DialogueHandler.__c__DisplayClass35_0.NativeFieldInfoPtr_dialogueContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0>.NativeClassPtr, "dialogueContainer");
				DialogueHandler.__c__DisplayClass35_0.NativeFieldInfoPtr_entryNodeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0>.NativeClassPtr, "entryNodeLabel");
				DialogueHandler.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0>.NativeClassPtr, 100675413);
				DialogueHandler.__c__DisplayClass35_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0>.NativeClassPtr, 100675414);
				DialogueHandler.__c__DisplayClass35_0.NativeMethodInfoPtr_Method_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0>.NativeClassPtr, 100675415);
			}

			// Token: 0x0600CE48 RID: 52808 RVA: 0x0031A17C File Offset: 0x0031837C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass35_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE49 RID: 52809 RVA: 0x0031A1B8 File Offset: 0x003183B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197695, XrefRangeEnd = 197700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass35_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600CE4A RID: 52810 RVA: 0x0031A1F8 File Offset: 0x003183F8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 197729, RefRangeEnd = 197730, XrefRangeStart = 197700, XrefRangeEnd = 197729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass35_0.NativeMethodInfoPtr_Method_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE4B RID: 52811 RVA: 0x0006458D File Offset: 0x0006278D
			public __c__DisplayClass35_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004033 RID: 16435
			// (get) Token: 0x0600CE4C RID: 52812 RVA: 0x0031A22C File Offset: 0x0031842C
			// (set) Token: 0x0600CE4D RID: 52813 RVA: 0x00064596 File Offset: 0x00062796
			public unsafe NPC npc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass35_0.NativeFieldInfoPtr_npc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass35_0.NativeFieldInfoPtr_npc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004034 RID: 16436
			// (get) Token: 0x0600CE4E RID: 52814 RVA: 0x0031A25C File Offset: 0x0031845C
			// (set) Token: 0x0600CE4F RID: 52815 RVA: 0x000645B5 File Offset: 0x000627B5
			public unsafe DialogueHandler __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueHandler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004035 RID: 16437
			// (get) Token: 0x0600CE50 RID: 52816 RVA: 0x0031A28C File Offset: 0x0031848C
			// (set) Token: 0x0600CE51 RID: 52817 RVA: 0x000645D4 File Offset: 0x000627D4
			public unsafe DialogueContainer dialogueContainer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass35_0.NativeFieldInfoPtr_dialogueContainer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass35_0.NativeFieldInfoPtr_dialogueContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004036 RID: 16438
			// (get) Token: 0x0600CE52 RID: 52818 RVA: 0x0031A2BC File Offset: 0x003184BC
			// (set) Token: 0x0600CE53 RID: 52819 RVA: 0x000645F3 File Offset: 0x000627F3
			public unsafe string entryNodeLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass35_0.NativeFieldInfoPtr_entryNodeLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass35_0.NativeFieldInfoPtr_entryNodeLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008B45 RID: 35653
			private static readonly IntPtr NativeFieldInfoPtr_npc;

			// Token: 0x04008B46 RID: 35654
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008B47 RID: 35655
			private static readonly IntPtr NativeFieldInfoPtr_dialogueContainer;

			// Token: 0x04008B48 RID: 35656
			private static readonly IntPtr NativeFieldInfoPtr_entryNodeLabel;

			// Token: 0x04008B49 RID: 35657
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B4A RID: 35658
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04008B4B RID: 35659
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_0;

			// Token: 0x02000C55 RID: 3157
			[ObfuscatedName("ScheduleOne.Dialogue.DialogueHandler+<>c__DisplayClass35_0+<<InitializeDialogue>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E35A RID: 58202 RVA: 0x00355E6C File Offset: 0x0035406C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0>.NativeClassPtr, "<<InitializeDialogue>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675416);
					DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675417);
					DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675418);
					DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675419);
					DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675420);
					DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675421);
				}

				// Token: 0x0600E35B RID: 58203 RVA: 0x00355F4C File Offset: 0x0035414C
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E35C RID: 58204 RVA: 0x00355F94 File Offset: 0x00354194
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E35D RID: 58205 RVA: 0x00355FC8 File Offset: 0x003541C8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197685, XrefRangeEnd = 197690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x1700468A RID: 18058
				// (get) Token: 0x0600E35E RID: 58206 RVA: 0x00356004 File Offset: 0x00354204
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E35F RID: 58207 RVA: 0x00356044 File Offset: 0x00354244
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197690, XrefRangeEnd = 197695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x1700468B RID: 18059
				// (get) Token: 0x0600E360 RID: 58208 RVA: 0x00356078 File Offset: 0x00354278
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E361 RID: 58209 RVA: 0x0006ECF0 File Offset: 0x0006CEF0
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004687 RID: 18055
				// (get) Token: 0x0600E362 RID: 58210 RVA: 0x003560B8 File Offset: 0x003542B8
				// (set) Token: 0x0600E363 RID: 58211 RVA: 0x0006ECF9 File Offset: 0x0006CEF9
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004688 RID: 18056
				// (get) Token: 0x0600E364 RID: 58212 RVA: 0x003560E0 File Offset: 0x003542E0
				// (set) Token: 0x0600E365 RID: 58213 RVA: 0x0006ED14 File Offset: 0x0006CF14
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004689 RID: 18057
				// (get) Token: 0x0600E366 RID: 58214 RVA: 0x00356110 File Offset: 0x00354310
				// (set) Token: 0x0600E367 RID: 58215 RVA: 0x0006ED33 File Offset: 0x0006CF33
				public unsafe DialogueHandler.__c__DisplayClass35_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueHandler.__c__DisplayClass35_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009825 RID: 38949
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009826 RID: 38950
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009827 RID: 38951
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009828 RID: 38952
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009829 RID: 38953
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400982A RID: 38954
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400982B RID: 38955
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400982C RID: 38956
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400982D RID: 38957
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x020009FF RID: 2559
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueHandler+<>c__DisplayClass36_0")]
		public sealed class __c__DisplayClass36_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CE54 RID: 52820 RVA: 0x0031A2E4 File Offset: 0x003184E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass36_0()
			{
				Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass36_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "<>c__DisplayClass36_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass36_0>.NativeClassPtr);
				DialogueHandler.__c__DisplayClass36_0.NativeFieldInfoPtr_dialogueContainerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass36_0>.NativeClassPtr, "dialogueContainerName");
				DialogueHandler.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass36_0>.NativeClassPtr, 100675422);
				DialogueHandler.__c__DisplayClass36_0.NativeMethodInfoPtr__InitializeDialogue_b__0_Internal_Boolean_DialogueContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass36_0>.NativeClassPtr, 100675423);
			}

			// Token: 0x0600CE55 RID: 52821 RVA: 0x0031A34C File Offset: 0x0031854C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass36_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass36_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE56 RID: 52822 RVA: 0x0031A388 File Offset: 0x00318588
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197730, XrefRangeEnd = 197735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _InitializeDialogue_b__0(DialogueContainer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass36_0.NativeMethodInfoPtr__InitializeDialogue_b__0_Internal_Boolean_DialogueContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE57 RID: 52823 RVA: 0x00064612 File Offset: 0x00062812
			public __c__DisplayClass36_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004037 RID: 16439
			// (get) Token: 0x0600CE58 RID: 52824 RVA: 0x0031A3D8 File Offset: 0x003185D8
			// (set) Token: 0x0600CE59 RID: 52825 RVA: 0x0006461B File Offset: 0x0006281B
			public unsafe string dialogueContainerName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass36_0.NativeFieldInfoPtr_dialogueContainerName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass36_0.NativeFieldInfoPtr_dialogueContainerName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008B4C RID: 35660
			private static readonly IntPtr NativeFieldInfoPtr_dialogueContainerName;

			// Token: 0x04008B4D RID: 35661
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B4E RID: 35662
			private static readonly IntPtr NativeMethodInfoPtr__InitializeDialogue_b__0_Internal_Boolean_DialogueContainer_0;
		}

		// Token: 0x02000A00 RID: 2560
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueHandler+<>c__DisplayClass57_0")]
		public sealed class __c__DisplayClass57_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CE5A RID: 52826 RVA: 0x0031A400 File Offset: 0x00318600
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass57_0()
			{
				Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass57_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "<>c__DisplayClass57_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass57_0>.NativeClassPtr);
				DialogueHandler.__c__DisplayClass57_0.NativeFieldInfoPtr_baseChoiceOrOptionGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass57_0>.NativeClassPtr, "baseChoiceOrOptionGUID");
				DialogueHandler.__c__DisplayClass57_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass57_0>.NativeClassPtr, 100675424);
				DialogueHandler.__c__DisplayClass57_0.NativeMethodInfoPtr__GetLink_b__0_Internal_Boolean_NodeLinkData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass57_0>.NativeClassPtr, 100675425);
			}

			// Token: 0x0600CE5B RID: 52827 RVA: 0x0031A468 File Offset: 0x00318668
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass57_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass57_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass57_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE5C RID: 52828 RVA: 0x0031A4A4 File Offset: 0x003186A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetLink_b__0(NodeLinkData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass57_0.NativeMethodInfoPtr__GetLink_b__0_Internal_Boolean_NodeLinkData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE5D RID: 52829 RVA: 0x0006463A File Offset: 0x0006283A
			public __c__DisplayClass57_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004038 RID: 16440
			// (get) Token: 0x0600CE5E RID: 52830 RVA: 0x0031A4F4 File Offset: 0x003186F4
			// (set) Token: 0x0600CE5F RID: 52831 RVA: 0x00064643 File Offset: 0x00062843
			public unsafe string baseChoiceOrOptionGUID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass57_0.NativeFieldInfoPtr_baseChoiceOrOptionGUID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass57_0.NativeFieldInfoPtr_baseChoiceOrOptionGUID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008B4F RID: 35663
			private static readonly IntPtr NativeFieldInfoPtr_baseChoiceOrOptionGUID;

			// Token: 0x04008B50 RID: 35664
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B51 RID: 35665
			private static readonly IntPtr NativeMethodInfoPtr__GetLink_b__0_Internal_Boolean_NodeLinkData_0;
		}
	}
}
