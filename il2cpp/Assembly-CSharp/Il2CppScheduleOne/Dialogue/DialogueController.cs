using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.VoiceOver;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x0200042D RID: 1069
	public class DialogueController : MonoBehaviour
	{
		// Token: 0x06005DFF RID: 24063 RVA: 0x001B120C File Offset: 0x001AF40C
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueController()
		{
			Il2CppClassPointerStore<DialogueController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController>.NativeClassPtr);
			DialogueController.NativeFieldInfoPtr_GREETING_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "GREETING_COOLDOWN");
			DialogueController.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "IntObj");
			DialogueController.NativeFieldInfoPtr_GenericDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "GenericDialogue");
			DialogueController.NativeFieldInfoPtr_DialogueEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "DialogueEnabled");
			DialogueController.NativeFieldInfoPtr_UseDialogueBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "UseDialogueBehaviour");
			DialogueController.NativeFieldInfoPtr_Choices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "Choices");
			DialogueController.NativeFieldInfoPtr_GreetingOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "GreetingOverrides");
			DialogueController.NativeFieldInfoPtr_OverrideContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "OverrideContainer");
			DialogueController.NativeFieldInfoPtr_npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "npc");
			DialogueController.NativeFieldInfoPtr_handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "handler");
			DialogueController.NativeFieldInfoPtr_lastGreetingTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "lastGreetingTime");
			DialogueController.NativeFieldInfoPtr_shownChoices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "shownChoices");
			DialogueController.NativeFieldInfoPtr_dialogueQueued = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "dialogueQueued");
			DialogueController.NativeFieldInfoPtr_cachedGreeting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "cachedGreeting");
			DialogueController.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675257);
			DialogueController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675258);
			DialogueController.NativeMethodInfoPtr_Hovered_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675259);
			DialogueController.NativeMethodInfoPtr_StartGenericDialogue_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675260);
			DialogueController.NativeMethodInfoPtr_Interacted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675261);
			DialogueController.NativeMethodInfoPtr_Unqueue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675262);
			DialogueController.NativeMethodInfoPtr_GetActiveGreeting_Private_String_byref_Boolean_byref_EVOLineType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675263);
			DialogueController.NativeMethodInfoPtr_GetActiveChoices_Private_List_1_DialogueChoice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675264);
			DialogueController.NativeMethodInfoPtr_GetCustomGreeting_Protected_Virtual_New_Boolean_byref_String_byref_Boolean_byref_EVOLineType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675265);
			DialogueController.NativeMethodInfoPtr_AddDialogueChoice_Public_Virtual_New_Int32_DialogueChoice_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675266);
			DialogueController.NativeMethodInfoPtr_AddGreetingOverride_Public_Virtual_New_Int32_GreetingOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675267);
			DialogueController.NativeMethodInfoPtr_CanStartDialogue_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675268);
			DialogueController.NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_New_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675269);
			DialogueController.NativeMethodInfoPtr_ModifyChoiceText_Public_Virtual_New_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675270);
			DialogueController.NativeMethodInfoPtr_ModifyChoiceList_Public_Virtual_New_Void_String_byref_List_1_DialogueChoiceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675271);
			DialogueController.NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675272);
			DialogueController.NativeMethodInfoPtr_CheckChoice_Public_Virtual_New_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675273);
			DialogueController.NativeMethodInfoPtr_SetOverrideContainer_Public_Void_DialogueContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675274);
			DialogueController.NativeMethodInfoPtr_ClearOverrideContainer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675275);
			DialogueController.NativeMethodInfoPtr_DecideBranch_Public_Virtual_New_Boolean_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675276);
			DialogueController.NativeMethodInfoPtr_SetDialogueEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675277);
			DialogueController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675278);
		}

		// Token: 0x06005E00 RID: 24064 RVA: 0x001B150C File Offset: 0x001AF70C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 196481, RefRangeEnd = 196486, XrefRangeStart = 196462, XrefRangeEnd = 196481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E01 RID: 24065 RVA: 0x001B1548 File Offset: 0x001AF748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196486, XrefRangeEnd = 196487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E02 RID: 24066 RVA: 0x001B157C File Offset: 0x001AF77C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196487, XrefRangeEnd = 196501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.NativeMethodInfoPtr_Hovered_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E03 RID: 24067 RVA: 0x001B15B0 File Offset: 0x001AF7B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 196502, RefRangeEnd = 196504, XrefRangeStart = 196501, XrefRangeEnd = 196502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartGenericDialogue(bool allowExit = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref allowExit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.NativeMethodInfoPtr_StartGenericDialogue_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E04 RID: 24068 RVA: 0x001B15F0 File Offset: 0x001AF7F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 196516, RefRangeEnd = 196517, XrefRangeStart = 196504, XrefRangeEnd = 196516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.NativeMethodInfoPtr_Interacted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E05 RID: 24069 RVA: 0x001B1624 File Offset: 0x001AF824
		[CallerCount(0)]
		public unsafe void Unqueue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.NativeMethodInfoPtr_Unqueue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E06 RID: 24070 RVA: 0x001B1658 File Offset: 0x001AF858
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 196530, RefRangeEnd = 196531, XrefRangeStart = 196517, XrefRangeEnd = 196530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetActiveGreeting(out bool playVO, out EVOLineType voLineType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &playVO;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &voLineType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.NativeMethodInfoPtr_GetActiveGreeting_Private_String_byref_Boolean_byref_EVOLineType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005E07 RID: 24071 RVA: 0x001B16AC File Offset: 0x001AF8AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 196573, RefRangeEnd = 196575, XrefRangeStart = 196531, XrefRangeEnd = 196573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<DialogueController.DialogueChoice> GetActiveChoices()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.NativeMethodInfoPtr_GetActiveChoices_Private_List_1_DialogueChoice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<DialogueController.DialogueChoice>>(intPtr3) : null;
		}

		// Token: 0x06005E08 RID: 24072 RVA: 0x001B16EC File Offset: 0x001AF8EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196575, XrefRangeEnd = 196590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetCustomGreeting(out string greeting, out bool playVO, out EVOLineType voLineType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &playVO;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &voLineType;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController.NativeMethodInfoPtr_GetCustomGreeting_Protected_Virtual_New_Boolean_byref_String_byref_Boolean_byref_EVOLineType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			greeting = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005E09 RID: 24073 RVA: 0x001B176C File Offset: 0x001AF96C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196590, XrefRangeEnd = 196596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int AddDialogueChoice(DialogueController.DialogueChoice data, int priority = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController.NativeMethodInfoPtr_AddDialogueChoice_Public_Virtual_New_Int32_DialogueChoice_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005E0A RID: 24074 RVA: 0x001B17D4 File Offset: 0x001AF9D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196596, XrefRangeEnd = 196602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int AddGreetingOverride(DialogueController.GreetingOverride data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController.NativeMethodInfoPtr_AddGreetingOverride_Public_Virtual_New_Int32_GreetingOverride_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005E0B RID: 24075 RVA: 0x001B182C File Offset: 0x001AFA2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 196615, RefRangeEnd = 196616, XrefRangeStart = 196602, XrefRangeEnd = 196615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanStartDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController.NativeMethodInfoPtr_CanStartDialogue_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005E0C RID: 24076 RVA: 0x001B1874 File Offset: 0x001AFA74
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 196626, RefRangeEnd = 196632, XrefRangeStart = 196616, XrefRangeEnd = 196626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogueText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController.NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_New_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005E0D RID: 24077 RVA: 0x001B18DC File Offset: 0x001AFADC
		[CallerCount(0)]
		public unsafe virtual string ModifyChoiceText(string choiceLabel, string choiceText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(choiceText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController.NativeMethodInfoPtr_ModifyChoiceText_Public_Virtual_New_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005E0E RID: 24078 RVA: 0x001B1944 File Offset: 0x001AFB44
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 196661, RefRangeEnd = 196664, XrefRangeStart = 196632, XrefRangeEnd = 196661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(existingChoices);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController.NativeMethodInfoPtr_ModifyChoiceList_Public_Virtual_New_Void_String_byref_List_1_DialogueChoiceData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			existingChoices = ((intPtr4 == 0) ? null : new List<DialogueChoiceData>(intPtr4));
		}

		// Token: 0x06005E0F RID: 24079 RVA: 0x001B19B8 File Offset: 0x001AFBB8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 196687, RefRangeEnd = 196692, XrefRangeStart = 196664, XrefRangeEnd = 196687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ChoiceCallback(string choiceLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController.NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E10 RID: 24080 RVA: 0x001B1A08 File Offset: 0x001AFC08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196692, XrefRangeEnd = 196713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController.NativeMethodInfoPtr_CheckChoice_Public_Virtual_New_Boolean_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005E11 RID: 24081 RVA: 0x001B1A7C File Offset: 0x001AFC7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOverrideContainer(DialogueContainer container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.NativeMethodInfoPtr_SetOverrideContainer_Public_Void_DialogueContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E12 RID: 24082 RVA: 0x001B1AC0 File Offset: 0x001AFCC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196713, XrefRangeEnd = 196714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearOverrideContainer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.NativeMethodInfoPtr_ClearOverrideContainer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E13 RID: 24083 RVA: 0x001B1AF4 File Offset: 0x001AFCF4
		[CallerCount(0)]
		public unsafe virtual bool DecideBranch(string branchLabel, out int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(branchLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController.NativeMethodInfoPtr_DecideBranch_Public_Virtual_New_Boolean_String_byref_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005E14 RID: 24084 RVA: 0x001B1B5C File Offset: 0x001AFD5C
		[CallerCount(0)]
		public unsafe void SetDialogueEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.NativeMethodInfoPtr_SetDialogueEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E15 RID: 24085 RVA: 0x001B1B9C File Offset: 0x001AFD9C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 196737, RefRangeEnd = 196745, XrefRangeStart = 196714, XrefRangeEnd = 196737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E16 RID: 24086 RVA: 0x0002C555 File Offset: 0x0002A755
		public DialogueController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C4A RID: 7242
		// (get) Token: 0x06005E17 RID: 24087 RVA: 0x001B1BD8 File Offset: 0x001AFDD8
		// (set) Token: 0x06005E18 RID: 24088 RVA: 0x0002C55E File Offset: 0x0002A75E
		public unsafe static float GREETING_COOLDOWN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DialogueController.NativeFieldInfoPtr_GREETING_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DialogueController.NativeFieldInfoPtr_GREETING_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x17001C4B RID: 7243
		// (get) Token: 0x06005E19 RID: 24089 RVA: 0x001B1BF4 File Offset: 0x001AFDF4
		// (set) Token: 0x06005E1A RID: 24090 RVA: 0x0002C56C File Offset: 0x0002A76C
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C4C RID: 7244
		// (get) Token: 0x06005E1B RID: 24091 RVA: 0x001B1C24 File Offset: 0x001AFE24
		// (set) Token: 0x06005E1C RID: 24092 RVA: 0x0002C58B File Offset: 0x0002A78B
		public unsafe DialogueContainer GenericDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_GenericDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_GenericDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C4D RID: 7245
		// (get) Token: 0x06005E1D RID: 24093 RVA: 0x001B1C54 File Offset: 0x001AFE54
		// (set) Token: 0x06005E1E RID: 24094 RVA: 0x0002C5AA File Offset: 0x0002A7AA
		public unsafe bool DialogueEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_DialogueEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_DialogueEnabled)) = value;
			}
		}

		// Token: 0x17001C4E RID: 7246
		// (get) Token: 0x06005E1F RID: 24095 RVA: 0x001B1C7C File Offset: 0x001AFE7C
		// (set) Token: 0x06005E20 RID: 24096 RVA: 0x0002C5C5 File Offset: 0x0002A7C5
		public unsafe bool UseDialogueBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_UseDialogueBehaviour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_UseDialogueBehaviour)) = value;
			}
		}

		// Token: 0x17001C4F RID: 7247
		// (get) Token: 0x06005E21 RID: 24097 RVA: 0x001B1CA4 File Offset: 0x001AFEA4
		// (set) Token: 0x06005E22 RID: 24098 RVA: 0x0002C5E0 File Offset: 0x0002A7E0
		public unsafe List<DialogueController.DialogueChoice> Choices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_Choices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueController.DialogueChoice>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_Choices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C50 RID: 7248
		// (get) Token: 0x06005E23 RID: 24099 RVA: 0x001B1CD4 File Offset: 0x001AFED4
		// (set) Token: 0x06005E24 RID: 24100 RVA: 0x0002C5FF File Offset: 0x0002A7FF
		public unsafe List<DialogueController.GreetingOverride> GreetingOverrides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_GreetingOverrides);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueController.GreetingOverride>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_GreetingOverrides), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C51 RID: 7249
		// (get) Token: 0x06005E25 RID: 24101 RVA: 0x001B1D04 File Offset: 0x001AFF04
		// (set) Token: 0x06005E26 RID: 24102 RVA: 0x0002C61E File Offset: 0x0002A81E
		public unsafe DialogueContainer OverrideContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_OverrideContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_OverrideContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C52 RID: 7250
		// (get) Token: 0x06005E27 RID: 24103 RVA: 0x001B1D34 File Offset: 0x001AFF34
		// (set) Token: 0x06005E28 RID: 24104 RVA: 0x0002C63D File Offset: 0x0002A83D
		public unsafe NPC npc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_npc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_npc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C53 RID: 7251
		// (get) Token: 0x06005E29 RID: 24105 RVA: 0x001B1D64 File Offset: 0x001AFF64
		// (set) Token: 0x06005E2A RID: 24106 RVA: 0x0002C65C File Offset: 0x0002A85C
		public unsafe DialogueHandler handler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_handler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_handler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C54 RID: 7252
		// (get) Token: 0x06005E2B RID: 24107 RVA: 0x001B1D94 File Offset: 0x001AFF94
		// (set) Token: 0x06005E2C RID: 24108 RVA: 0x0002C67B File Offset: 0x0002A87B
		public unsafe float lastGreetingTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_lastGreetingTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_lastGreetingTime)) = value;
			}
		}

		// Token: 0x17001C55 RID: 7253
		// (get) Token: 0x06005E2D RID: 24109 RVA: 0x001B1DBC File Offset: 0x001AFFBC
		// (set) Token: 0x06005E2E RID: 24110 RVA: 0x0002C696 File Offset: 0x0002A896
		public unsafe List<DialogueController.DialogueChoice> shownChoices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_shownChoices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueController.DialogueChoice>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_shownChoices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C56 RID: 7254
		// (get) Token: 0x06005E2F RID: 24111 RVA: 0x001B1DEC File Offset: 0x001AFFEC
		// (set) Token: 0x06005E30 RID: 24112 RVA: 0x0002C6B5 File Offset: 0x0002A8B5
		public unsafe bool dialogueQueued
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_dialogueQueued);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_dialogueQueued)) = value;
			}
		}

		// Token: 0x17001C57 RID: 7255
		// (get) Token: 0x06005E31 RID: 24113 RVA: 0x001B1E14 File Offset: 0x001B0014
		// (set) Token: 0x06005E32 RID: 24114 RVA: 0x0002C6D0 File Offset: 0x0002A8D0
		public unsafe string cachedGreeting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_cachedGreeting);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_cachedGreeting), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400404C RID: 16460
		private static readonly IntPtr NativeFieldInfoPtr_GREETING_COOLDOWN;

		// Token: 0x0400404D RID: 16461
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x0400404E RID: 16462
		private static readonly IntPtr NativeFieldInfoPtr_GenericDialogue;

		// Token: 0x0400404F RID: 16463
		private static readonly IntPtr NativeFieldInfoPtr_DialogueEnabled;

		// Token: 0x04004050 RID: 16464
		private static readonly IntPtr NativeFieldInfoPtr_UseDialogueBehaviour;

		// Token: 0x04004051 RID: 16465
		private static readonly IntPtr NativeFieldInfoPtr_Choices;

		// Token: 0x04004052 RID: 16466
		private static readonly IntPtr NativeFieldInfoPtr_GreetingOverrides;

		// Token: 0x04004053 RID: 16467
		private static readonly IntPtr NativeFieldInfoPtr_OverrideContainer;

		// Token: 0x04004054 RID: 16468
		private static readonly IntPtr NativeFieldInfoPtr_npc;

		// Token: 0x04004055 RID: 16469
		private static readonly IntPtr NativeFieldInfoPtr_handler;

		// Token: 0x04004056 RID: 16470
		private static readonly IntPtr NativeFieldInfoPtr_lastGreetingTime;

		// Token: 0x04004057 RID: 16471
		private static readonly IntPtr NativeFieldInfoPtr_shownChoices;

		// Token: 0x04004058 RID: 16472
		private static readonly IntPtr NativeFieldInfoPtr_dialogueQueued;

		// Token: 0x04004059 RID: 16473
		private static readonly IntPtr NativeFieldInfoPtr_cachedGreeting;

		// Token: 0x0400405A RID: 16474
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x0400405B RID: 16475
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400405C RID: 16476
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Private_Void_0;

		// Token: 0x0400405D RID: 16477
		private static readonly IntPtr NativeMethodInfoPtr_StartGenericDialogue_Public_Void_Boolean_0;

		// Token: 0x0400405E RID: 16478
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Private_Void_0;

		// Token: 0x0400405F RID: 16479
		private static readonly IntPtr NativeMethodInfoPtr_Unqueue_Private_Void_0;

		// Token: 0x04004060 RID: 16480
		private static readonly IntPtr NativeMethodInfoPtr_GetActiveGreeting_Private_String_byref_Boolean_byref_EVOLineType_0;

		// Token: 0x04004061 RID: 16481
		private static readonly IntPtr NativeMethodInfoPtr_GetActiveChoices_Private_List_1_DialogueChoice_0;

		// Token: 0x04004062 RID: 16482
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomGreeting_Protected_Virtual_New_Boolean_byref_String_byref_Boolean_byref_EVOLineType_0;

		// Token: 0x04004063 RID: 16483
		private static readonly IntPtr NativeMethodInfoPtr_AddDialogueChoice_Public_Virtual_New_Int32_DialogueChoice_Int32_0;

		// Token: 0x04004064 RID: 16484
		private static readonly IntPtr NativeMethodInfoPtr_AddGreetingOverride_Public_Virtual_New_Int32_GreetingOverride_0;

		// Token: 0x04004065 RID: 16485
		private static readonly IntPtr NativeMethodInfoPtr_CanStartDialogue_Public_Virtual_New_Boolean_0;

		// Token: 0x04004066 RID: 16486
		private static readonly IntPtr NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_New_String_String_String_0;

		// Token: 0x04004067 RID: 16487
		private static readonly IntPtr NativeMethodInfoPtr_ModifyChoiceText_Public_Virtual_New_String_String_String_0;

		// Token: 0x04004068 RID: 16488
		private static readonly IntPtr NativeMethodInfoPtr_ModifyChoiceList_Public_Virtual_New_Void_String_byref_List_1_DialogueChoiceData_0;

		// Token: 0x04004069 RID: 16489
		private static readonly IntPtr NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_New_Void_String_0;

		// Token: 0x0400406A RID: 16490
		private static readonly IntPtr NativeMethodInfoPtr_CheckChoice_Public_Virtual_New_Boolean_String_byref_String_0;

		// Token: 0x0400406B RID: 16491
		private static readonly IntPtr NativeMethodInfoPtr_SetOverrideContainer_Public_Void_DialogueContainer_0;

		// Token: 0x0400406C RID: 16492
		private static readonly IntPtr NativeMethodInfoPtr_ClearOverrideContainer_Public_Void_0;

		// Token: 0x0400406D RID: 16493
		private static readonly IntPtr NativeMethodInfoPtr_DecideBranch_Public_Virtual_New_Boolean_String_byref_Int32_0;

		// Token: 0x0400406E RID: 16494
		private static readonly IntPtr NativeMethodInfoPtr_SetDialogueEnabled_Public_Void_Boolean_0;

		// Token: 0x0400406F RID: 16495
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009F3 RID: 2547
		[Serializable]
		public class DialogueChoice : Il2CppSystem.Object
		{
			// Token: 0x0600CDE1 RID: 52705 RVA: 0x003190B0 File Offset: 0x003172B0
			// Note: this type is marked as 'beforefieldinit'.
			static DialogueChoice()
			{
				Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "DialogueChoice");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr);
				DialogueController.DialogueChoice.NativeFieldInfoPtr_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, "Enabled");
				DialogueController.DialogueChoice.NativeFieldInfoPtr_ChoiceText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, "ChoiceText");
				DialogueController.DialogueChoice.NativeFieldInfoPtr_Conversation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, "Conversation");
				DialogueController.DialogueChoice.NativeFieldInfoPtr_onChoosen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, "onChoosen");
				DialogueController.DialogueChoice.NativeFieldInfoPtr_shouldShowCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, "shouldShowCheck");
				DialogueController.DialogueChoice.NativeFieldInfoPtr_isValidCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, "isValidCheck");
				DialogueController.DialogueChoice.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, "Priority");
				DialogueController.DialogueChoice.NativeMethodInfoPtr_ShouldShow_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, 100675280);
				DialogueController.DialogueChoice.NativeMethodInfoPtr_IsValid_Public_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, 100675281);
				DialogueController.DialogueChoice.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, 100675282);
			}

			// Token: 0x0600CDE2 RID: 52706 RVA: 0x003191A4 File Offset: 0x003173A4
			[CallerCount(0)]
			public unsafe bool ShouldShow()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.DialogueChoice.NativeMethodInfoPtr_ShouldShow_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CDE3 RID: 52707 RVA: 0x003191E0 File Offset: 0x003173E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196434, XrefRangeEnd = 196437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool IsValid(out string invalidReason)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DialogueController.DialogueChoice.NativeMethodInfoPtr_IsValid_Public_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x0600CDE4 RID: 52708 RVA: 0x00319238 File Offset: 0x00317438
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 196443, RefRangeEnd = 196460, XrefRangeStart = 196437, XrefRangeEnd = 196443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DialogueChoice() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.DialogueChoice.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CDE5 RID: 52709 RVA: 0x000641E4 File Offset: 0x000623E4
			public DialogueChoice(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004015 RID: 16405
			// (get) Token: 0x0600CDE6 RID: 52710 RVA: 0x00319274 File Offset: 0x00317474
			// (set) Token: 0x0600CDE7 RID: 52711 RVA: 0x000641ED File Offset: 0x000623ED
			public unsafe bool Enabled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_Enabled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_Enabled)) = value;
				}
			}

			// Token: 0x17004016 RID: 16406
			// (get) Token: 0x0600CDE8 RID: 52712 RVA: 0x0031929C File Offset: 0x0031749C
			// (set) Token: 0x0600CDE9 RID: 52713 RVA: 0x00064208 File Offset: 0x00062408
			public unsafe string ChoiceText
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_ChoiceText);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_ChoiceText), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004017 RID: 16407
			// (get) Token: 0x0600CDEA RID: 52714 RVA: 0x003192C4 File Offset: 0x003174C4
			// (set) Token: 0x0600CDEB RID: 52715 RVA: 0x00064227 File Offset: 0x00062427
			public unsafe DialogueContainer Conversation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_Conversation);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_Conversation), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004018 RID: 16408
			// (get) Token: 0x0600CDEC RID: 52716 RVA: 0x003192F4 File Offset: 0x003174F4
			// (set) Token: 0x0600CDED RID: 52717 RVA: 0x00064246 File Offset: 0x00062446
			public unsafe UnityEvent onChoosen
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_onChoosen);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_onChoosen), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004019 RID: 16409
			// (get) Token: 0x0600CDEE RID: 52718 RVA: 0x00319324 File Offset: 0x00317524
			// (set) Token: 0x0600CDEF RID: 52719 RVA: 0x00064265 File Offset: 0x00062465
			public unsafe DialogueController.DialogueChoice.ShouldShowCheck shouldShowCheck
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_shouldShowCheck);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.DialogueChoice.ShouldShowCheck>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_shouldShowCheck), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700401A RID: 16410
			// (get) Token: 0x0600CDF0 RID: 52720 RVA: 0x00319354 File Offset: 0x00317554
			// (set) Token: 0x0600CDF1 RID: 52721 RVA: 0x00064284 File Offset: 0x00062484
			public unsafe DialogueController.DialogueChoice.IsChoiceValid isValidCheck
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_isValidCheck);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.DialogueChoice.IsChoiceValid>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_isValidCheck), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700401B RID: 16411
			// (get) Token: 0x0600CDF2 RID: 52722 RVA: 0x00319384 File Offset: 0x00317584
			// (set) Token: 0x0600CDF3 RID: 52723 RVA: 0x000642A3 File Offset: 0x000624A3
			public unsafe int Priority
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_Priority);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_Priority)) = value;
				}
			}

			// Token: 0x04008B13 RID: 35603
			private static readonly IntPtr NativeFieldInfoPtr_Enabled;

			// Token: 0x04008B14 RID: 35604
			private static readonly IntPtr NativeFieldInfoPtr_ChoiceText;

			// Token: 0x04008B15 RID: 35605
			private static readonly IntPtr NativeFieldInfoPtr_Conversation;

			// Token: 0x04008B16 RID: 35606
			private static readonly IntPtr NativeFieldInfoPtr_onChoosen;

			// Token: 0x04008B17 RID: 35607
			private static readonly IntPtr NativeFieldInfoPtr_shouldShowCheck;

			// Token: 0x04008B18 RID: 35608
			private static readonly IntPtr NativeFieldInfoPtr_isValidCheck;

			// Token: 0x04008B19 RID: 35609
			private static readonly IntPtr NativeFieldInfoPtr_Priority;

			// Token: 0x04008B1A RID: 35610
			private static readonly IntPtr NativeMethodInfoPtr_ShouldShow_Public_Boolean_0;

			// Token: 0x04008B1B RID: 35611
			private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_byref_String_0;

			// Token: 0x04008B1C RID: 35612
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x02000C53 RID: 3155
			public sealed class ShouldShowCheck : MulticastDelegate
			{
				// Token: 0x0600E34B RID: 58187 RVA: 0x00355A80 File Offset: 0x00353C80
				// Note: this type is marked as 'beforefieldinit'.
				static ShouldShowCheck()
				{
					Il2CppClassPointerStore<DialogueController.DialogueChoice.ShouldShowCheck>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, "ShouldShowCheck");
					DialogueController.DialogueChoice.ShouldShowCheck.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.DialogueChoice.ShouldShowCheck>.NativeClassPtr, 100675283);
					DialogueController.DialogueChoice.ShouldShowCheck.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.DialogueChoice.ShouldShowCheck>.NativeClassPtr, 100675284);
					DialogueController.DialogueChoice.ShouldShowCheck.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.DialogueChoice.ShouldShowCheck>.NativeClassPtr, 100675285);
					DialogueController.DialogueChoice.ShouldShowCheck.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.DialogueChoice.ShouldShowCheck>.NativeClassPtr, 100675286);
				}

				// Token: 0x0600E34C RID: 58188 RVA: 0x00355AF4 File Offset: 0x00353CF4
				[CallerCount(16)]
				[CachedScanResults(RefRangeStart = 196389, RefRangeEnd = 196405, XrefRangeStart = 196386, XrefRangeEnd = 196389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ShouldShowCheck(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController.DialogueChoice.ShouldShowCheck>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.DialogueChoice.ShouldShowCheck.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E34D RID: 58189 RVA: 0x00355B50 File Offset: 0x00353D50
				[CallerCount(0)]
				public unsafe bool Invoke(bool enabled)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref enabled;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.DialogueChoice.ShouldShowCheck.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600E34E RID: 58190 RVA: 0x00355B9C File Offset: 0x00353D9C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196405, XrefRangeEnd = 196409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(bool enabled, AsyncCallback callback, Il2CppSystem.Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref enabled;
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.DialogueChoice.ShouldShowCheck.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x0600E34F RID: 58191 RVA: 0x00355C0C File Offset: 0x00353E0C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.DialogueChoice.ShouldShowCheck.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600E350 RID: 58192 RVA: 0x0006ECB7 File Offset: 0x0006CEB7
				public ShouldShowCheck(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x0600E351 RID: 58193 RVA: 0x0006ECC0 File Offset: 0x0006CEC0
				public static implicit operator DialogueController.DialogueChoice.ShouldShowCheck(Func<bool, bool> A_0)
				{
					return DelegateSupport.ConvertDelegate<DialogueController.DialogueChoice.ShouldShowCheck>(A_0);
				}

				// Token: 0x0600E352 RID: 58194 RVA: 0x0006ECC8 File Offset: 0x0006CEC8
				public static DialogueController.DialogueChoice.ShouldShowCheck operator +(DialogueController.DialogueChoice.ShouldShowCheck A_0, DialogueController.DialogueChoice.ShouldShowCheck A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<DialogueController.DialogueChoice.ShouldShowCheck>();
				}

				// Token: 0x0600E353 RID: 58195 RVA: 0x0006ECD6 File Offset: 0x0006CED6
				public static DialogueController.DialogueChoice.ShouldShowCheck operator -(DialogueController.DialogueChoice.ShouldShowCheck A_0, DialogueController.DialogueChoice.ShouldShowCheck A_1)
				{
					Delegate result;
					Delegate @delegate = result = Delegate.Remove(A_0, A_1);
					if (@delegate != null)
					{
						result = @delegate.Cast<DialogueController.DialogueChoice.ShouldShowCheck>();
					}
					return result;
				}

				// Token: 0x0400981D RID: 38941
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x0400981E RID: 38942
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Boolean_0;

				// Token: 0x0400981F RID: 38943
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0;

				// Token: 0x04009820 RID: 38944
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0;
			}

			// Token: 0x02000C54 RID: 3156
			public sealed class IsChoiceValid : MulticastDelegate
			{
				// Token: 0x0600E354 RID: 58196 RVA: 0x00355C5C File Offset: 0x00353E5C
				// Note: this type is marked as 'beforefieldinit'.
				static IsChoiceValid()
				{
					Il2CppClassPointerStore<DialogueController.DialogueChoice.IsChoiceValid>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, "IsChoiceValid");
					DialogueController.DialogueChoice.IsChoiceValid.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.DialogueChoice.IsChoiceValid>.NativeClassPtr, 100675287);
					DialogueController.DialogueChoice.IsChoiceValid.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.DialogueChoice.IsChoiceValid>.NativeClassPtr, 100675288);
					DialogueController.DialogueChoice.IsChoiceValid.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.DialogueChoice.IsChoiceValid>.NativeClassPtr, 100675289);
					DialogueController.DialogueChoice.IsChoiceValid.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_String_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.DialogueChoice.IsChoiceValid>.NativeClassPtr, 100675290);
				}

				// Token: 0x0600E355 RID: 58197 RVA: 0x00355CD0 File Offset: 0x00353ED0
				[CallerCount(20)]
				[CachedScanResults(RefRangeStart = 196413, RefRangeEnd = 196433, XrefRangeStart = 196409, XrefRangeEnd = 196413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IsChoiceValid(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController.DialogueChoice.IsChoiceValid>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.DialogueChoice.IsChoiceValid.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E356 RID: 58198 RVA: 0x00355D2C File Offset: 0x00353F2C
				[CallerCount(0)]
				public unsafe bool Invoke(out string invalidReason)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr = 0;
					ptr2 = &intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DialogueController.DialogueChoice.IsChoiceValid.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}

				// Token: 0x0600E357 RID: 58199 RVA: 0x00355D84 File Offset: 0x00353F84
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196433, XrefRangeEnd = 196434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(out string invalidReason, AsyncCallback callback, Il2CppSystem.Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr = 0;
					ptr2 = &intPtr;
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DialogueController.DialogueChoice.IsChoiceValid.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
					IntPtr intPtr4 = intPtr2;
					return (intPtr4 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr4) : null;
				}

				// Token: 0x0600E358 RID: 58200 RVA: 0x00355E04 File Offset: 0x00354004
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool EndInvoke(out string invalidReason, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr = 0;
					ptr2 = &intPtr;
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DialogueController.DialogueChoice.IsChoiceValid.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_String_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}

				// Token: 0x0600E359 RID: 58201 RVA: 0x0006ECE7 File Offset: 0x0006CEE7
				public IsChoiceValid(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x04009821 RID: 38945
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04009822 RID: 38946
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_byref_String_0;

				// Token: 0x04009823 RID: 38947
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_String_AsyncCallback_Object_0;

				// Token: 0x04009824 RID: 38948
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_String_IAsyncResult_0;
			}
		}

		// Token: 0x020009F4 RID: 2548
		[Serializable]
		public class GreetingOverride : Il2CppSystem.Object
		{
			// Token: 0x0600CDF4 RID: 52724 RVA: 0x003193AC File Offset: 0x003175AC
			// Note: this type is marked as 'beforefieldinit'.
			static GreetingOverride()
			{
				Il2CppClassPointerStore<DialogueController.GreetingOverride>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "GreetingOverride");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController.GreetingOverride>.NativeClassPtr);
				DialogueController.GreetingOverride.NativeFieldInfoPtr_Greeting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.GreetingOverride>.NativeClassPtr, "Greeting");
				DialogueController.GreetingOverride.NativeFieldInfoPtr_ShouldShow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.GreetingOverride>.NativeClassPtr, "ShouldShow");
				DialogueController.GreetingOverride.NativeFieldInfoPtr_PlayVO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.GreetingOverride>.NativeClassPtr, "PlayVO");
				DialogueController.GreetingOverride.NativeFieldInfoPtr_VOType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.GreetingOverride>.NativeClassPtr, "VOType");
				DialogueController.GreetingOverride.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.GreetingOverride>.NativeClassPtr, 100675291);
			}

			// Token: 0x0600CDF5 RID: 52725 RVA: 0x0031943C File Offset: 0x0031763C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GreetingOverride() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController.GreetingOverride>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.GreetingOverride.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CDF6 RID: 52726 RVA: 0x000642BE File Offset: 0x000624BE
			public GreetingOverride(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700401C RID: 16412
			// (get) Token: 0x0600CDF7 RID: 52727 RVA: 0x00319478 File Offset: 0x00317678
			// (set) Token: 0x0600CDF8 RID: 52728 RVA: 0x000642C7 File Offset: 0x000624C7
			public unsafe string Greeting
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.GreetingOverride.NativeFieldInfoPtr_Greeting);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.GreetingOverride.NativeFieldInfoPtr_Greeting), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700401D RID: 16413
			// (get) Token: 0x0600CDF9 RID: 52729 RVA: 0x003194A0 File Offset: 0x003176A0
			// (set) Token: 0x0600CDFA RID: 52730 RVA: 0x000642E6 File Offset: 0x000624E6
			public unsafe bool ShouldShow
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.GreetingOverride.NativeFieldInfoPtr_ShouldShow);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.GreetingOverride.NativeFieldInfoPtr_ShouldShow)) = value;
				}
			}

			// Token: 0x1700401E RID: 16414
			// (get) Token: 0x0600CDFB RID: 52731 RVA: 0x003194C8 File Offset: 0x003176C8
			// (set) Token: 0x0600CDFC RID: 52732 RVA: 0x00064301 File Offset: 0x00062501
			public unsafe bool PlayVO
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.GreetingOverride.NativeFieldInfoPtr_PlayVO);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.GreetingOverride.NativeFieldInfoPtr_PlayVO)) = value;
				}
			}

			// Token: 0x1700401F RID: 16415
			// (get) Token: 0x0600CDFD RID: 52733 RVA: 0x003194F0 File Offset: 0x003176F0
			// (set) Token: 0x0600CDFE RID: 52734 RVA: 0x0006431C File Offset: 0x0006251C
			public unsafe EVOLineType VOType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.GreetingOverride.NativeFieldInfoPtr_VOType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.GreetingOverride.NativeFieldInfoPtr_VOType)) = value;
				}
			}

			// Token: 0x04008B1D RID: 35613
			private static readonly IntPtr NativeFieldInfoPtr_Greeting;

			// Token: 0x04008B1E RID: 35614
			private static readonly IntPtr NativeFieldInfoPtr_ShouldShow;

			// Token: 0x04008B1F RID: 35615
			private static readonly IntPtr NativeFieldInfoPtr_PlayVO;

			// Token: 0x04008B20 RID: 35616
			private static readonly IntPtr NativeFieldInfoPtr_VOType;

			// Token: 0x04008B21 RID: 35617
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020009F5 RID: 2549
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueController+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600CDFF RID: 52735 RVA: 0x00319518 File Offset: 0x00317718
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DialogueController.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController.__c>.NativeClassPtr);
				DialogueController.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.__c>.NativeClassPtr, "<>9");
				DialogueController.__c.NativeFieldInfoPtr___9__23_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.__c>.NativeClassPtr, "<>9__23_0");
				DialogueController.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.__c>.NativeClassPtr, 100675293);
				DialogueController.__c.NativeMethodInfoPtr__GetActiveChoices_b__23_0_Internal_Int32_DialogueChoice_DialogueChoice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.__c>.NativeClassPtr, 100675294);
			}

			// Token: 0x0600CE00 RID: 52736 RVA: 0x00319594 File Offset: 0x00317794
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE01 RID: 52737 RVA: 0x003195D0 File Offset: 0x003177D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196460, XrefRangeEnd = 196462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetActiveChoices_b__23_0(DialogueController.DialogueChoice a, DialogueController.DialogueChoice b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.__c.NativeMethodInfoPtr__GetActiveChoices_b__23_0_Internal_Int32_DialogueChoice_DialogueChoice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE02 RID: 52738 RVA: 0x00064337 File Offset: 0x00062537
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004020 RID: 16416
			// (get) Token: 0x0600CE03 RID: 52739 RVA: 0x00319630 File Offset: 0x00317830
			// (set) Token: 0x0600CE04 RID: 52740 RVA: 0x00064340 File Offset: 0x00062540
			public unsafe static DialogueController.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogueController.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogueController.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004021 RID: 16417
			// (get) Token: 0x0600CE05 RID: 52741 RVA: 0x00319658 File Offset: 0x00317858
			// (set) Token: 0x0600CE06 RID: 52742 RVA: 0x00064352 File Offset: 0x00062552
			public unsafe static Comparison<DialogueController.DialogueChoice> __9__23_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogueController.__c.NativeFieldInfoPtr___9__23_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<DialogueController.DialogueChoice>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogueController.__c.NativeFieldInfoPtr___9__23_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008B22 RID: 35618
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008B23 RID: 35619
			private static readonly IntPtr NativeFieldInfoPtr___9__23_0;

			// Token: 0x04008B24 RID: 35620
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B25 RID: 35621
			private static readonly IntPtr NativeMethodInfoPtr__GetActiveChoices_b__23_0_Internal_Int32_DialogueChoice_DialogueChoice_0;
		}
	}
}
