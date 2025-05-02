using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppScheduleOne.UI.Phone.Messages;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Messaging
{
	// Token: 0x02000376 RID: 886
	[Serializable]
	public class MSGConversation : Il2CppSystem.Object
	{
		// Token: 0x0600452C RID: 17708 RVA: 0x0015582C File Offset: 0x00153A2C
		// Note: this type is marked as 'beforefieldinit'.
		static MSGConversation()
		{
			Il2CppClassPointerStore<MSGConversation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Messaging", "MSGConversation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr);
			MSGConversation.NativeFieldInfoPtr_MAX_MESSAGE_HISTORY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "MAX_MESSAGE_HISTORY");
			MSGConversation.NativeFieldInfoPtr_contactName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "contactName");
			MSGConversation.NativeFieldInfoPtr_sender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "sender");
			MSGConversation.NativeFieldInfoPtr__IsSenderKnown_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<IsSenderKnown>k__BackingField");
			MSGConversation.NativeFieldInfoPtr_messageHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "messageHistory");
			MSGConversation.NativeFieldInfoPtr_messageChainHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "messageChainHistory");
			MSGConversation.NativeFieldInfoPtr_bubbles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "bubbles");
			MSGConversation.NativeFieldInfoPtr_Sendables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "Sendables");
			MSGConversation.NativeFieldInfoPtr_read = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "read");
			MSGConversation.NativeFieldInfoPtr__index_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<index>k__BackingField");
			MSGConversation.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<isOpen>k__BackingField");
			MSGConversation.NativeFieldInfoPtr__rollingOut_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<rollingOut>k__BackingField");
			MSGConversation.NativeFieldInfoPtr__EntryVisible_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<EntryVisible>k__BackingField");
			MSGConversation.NativeFieldInfoPtr_Categories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "Categories");
			MSGConversation.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "entry");
			MSGConversation.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "container");
			MSGConversation.NativeFieldInfoPtr_bubbleContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "bubbleContainer");
			MSGConversation.NativeFieldInfoPtr_scrollRectContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "scrollRectContainer");
			MSGConversation.NativeFieldInfoPtr_scrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "scrollRect");
			MSGConversation.NativeFieldInfoPtr_entryPreviewText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "entryPreviewText");
			MSGConversation.NativeFieldInfoPtr_unreadDot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "unreadDot");
			MSGConversation.NativeFieldInfoPtr_slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "slider");
			MSGConversation.NativeFieldInfoPtr_sliderFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "sliderFill");
			MSGConversation.NativeFieldInfoPtr_responseContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "responseContainer");
			MSGConversation.NativeFieldInfoPtr_senderInterface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "senderInterface");
			MSGConversation.NativeFieldInfoPtr_uiCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "uiCreated");
			MSGConversation.NativeFieldInfoPtr_onMessageRendered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "onMessageRendered");
			MSGConversation.NativeFieldInfoPtr_onLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "onLoaded");
			MSGConversation.NativeFieldInfoPtr_onResponsesShown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "onResponsesShown");
			MSGConversation.NativeFieldInfoPtr_currentResponses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "currentResponses");
			MSGConversation.NativeFieldInfoPtr_responseRects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "responseRects");
			MSGConversation.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			MSGConversation.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			MSGConversation.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<HasChanged>k__BackingField");
			MSGConversation.NativeMethodInfoPtr_get_IsSenderKnown_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671776);
			MSGConversation.NativeMethodInfoPtr_set_IsSenderKnown_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671777);
			MSGConversation.NativeMethodInfoPtr_get_index_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671778);
			MSGConversation.NativeMethodInfoPtr_set_index_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671779);
			MSGConversation.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671780);
			MSGConversation.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671781);
			MSGConversation.NativeMethodInfoPtr_get_rollingOut_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671782);
			MSGConversation.NativeMethodInfoPtr_set_rollingOut_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671783);
			MSGConversation.NativeMethodInfoPtr_get_EntryVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671784);
			MSGConversation.NativeMethodInfoPtr_set_EntryVisible_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671785);
			MSGConversation.NativeMethodInfoPtr_get_AreResponsesActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671786);
			MSGConversation.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671787);
			MSGConversation.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671788);
			MSGConversation.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671789);
			MSGConversation.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671790);
			MSGConversation.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671791);
			MSGConversation.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671792);
			MSGConversation.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671793);
			MSGConversation.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671794);
			MSGConversation.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671795);
			MSGConversation.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671796);
			MSGConversation.NativeMethodInfoPtr__ctor_Public_Void_NPC_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671797);
			MSGConversation.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671798);
			MSGConversation.NativeMethodInfoPtr_SetCategories_Public_Void_List_1_EConversationCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671799);
			MSGConversation.NativeMethodInfoPtr_MoveToTop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671800);
			MSGConversation.NativeMethodInfoPtr_CreateUI_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671801);
			MSGConversation.NativeMethodInfoPtr_EnsureUIExists_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671802);
			MSGConversation.NativeMethodInfoPtr_RefreshPreviewText_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671803);
			MSGConversation.NativeMethodInfoPtr_RepositionEntry_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671804);
			MSGConversation.NativeMethodInfoPtr_SetIsKnown_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671805);
			MSGConversation.NativeMethodInfoPtr_EntryClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671806);
			MSGConversation.NativeMethodInfoPtr_SetOpen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671807);
			MSGConversation.NativeMethodInfoPtr_RenderMessage_Protected_Virtual_New_Void_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671808);
			MSGConversation.NativeMethodInfoPtr_SetEntryVisibility_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671809);
			MSGConversation.NativeMethodInfoPtr_SetRead_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671810);
			MSGConversation.NativeMethodInfoPtr_SendMessage_Public_Void_Message_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671811);
			MSGConversation.NativeMethodInfoPtr_SendMessageChain_Public_Void_MessageChain_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671812);
			MSGConversation.NativeMethodInfoPtr_GetSaveData_Public_MSGConversationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671813);
			MSGConversation.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671814);
			MSGConversation.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_MSGConversationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671815);
			MSGConversation.NativeMethodInfoPtr_SetSliderValue_Public_Void_Single_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671816);
			MSGConversation.NativeMethodInfoPtr_GetResponse_Public_Response_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671817);
			MSGConversation.NativeMethodInfoPtr_ShowResponses_Public_Void_List_1_Response_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671818);
			MSGConversation.NativeMethodInfoPtr_CreateResponseUI_Protected_Void_Response_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671819);
			MSGConversation.NativeMethodInfoPtr_RefreshResponseContainer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671820);
			MSGConversation.NativeMethodInfoPtr_ClearResponseUI_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671821);
			MSGConversation.NativeMethodInfoPtr_SetResponseContainerVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671822);
			MSGConversation.NativeMethodInfoPtr_ResponseChosen_Public_Void_Response_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671823);
			MSGConversation.NativeMethodInfoPtr_ClearResponses_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671824);
			MSGConversation.NativeMethodInfoPtr_CreateSendableMessage_Public_SendableMessage_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671825);
			MSGConversation.NativeMethodInfoPtr_SendPlayerMessage_Public_Void_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671826);
			MSGConversation.NativeMethodInfoPtr_RenderPlayerMessage_Public_Void_SendableMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671827);
			MSGConversation.NativeMethodInfoPtr_CheckSendLoop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671828);
			MSGConversation.NativeMethodInfoPtr_CanSendNewMessage_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671829);
			MSGConversation.NativeMethodInfoPtr__CreateUI_b__72_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671830);
			MSGConversation.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671831);
		}

		// Token: 0x170014F7 RID: 5367
		// (get) Token: 0x0600452D RID: 17709 RVA: 0x00155F64 File Offset: 0x00154164
		// (set) Token: 0x0600452E RID: 17710 RVA: 0x00155FA0 File Offset: 0x001541A0
		public unsafe bool IsSenderKnown
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35365, RefRangeEnd = 35366, XrefRangeStart = 35365, XrefRangeEnd = 35366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_IsSenderKnown_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_set_IsSenderKnown_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170014F8 RID: 5368
		// (get) Token: 0x0600452F RID: 17711 RVA: 0x00155FE0 File Offset: 0x001541E0
		// (set) Token: 0x06004530 RID: 17712 RVA: 0x0015601C File Offset: 0x0015421C
		public unsafe int index
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 48693, RefRangeEnd = 48695, XrefRangeStart = 48693, XrefRangeEnd = 48695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_index_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 48695, RefRangeEnd = 48696, XrefRangeStart = 48695, XrefRangeEnd = 48696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_set_index_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170014F9 RID: 5369
		// (get) Token: 0x06004531 RID: 17713 RVA: 0x0015605C File Offset: 0x0015425C
		// (set) Token: 0x06004532 RID: 17714 RVA: 0x00156098 File Offset: 0x00154298
		public unsafe bool isOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170014FA RID: 5370
		// (get) Token: 0x06004533 RID: 17715 RVA: 0x001560D8 File Offset: 0x001542D8
		// (set) Token: 0x06004534 RID: 17716 RVA: 0x00156114 File Offset: 0x00154314
		public unsafe bool rollingOut
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_rollingOut_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_set_rollingOut_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170014FB RID: 5371
		// (get) Token: 0x06004535 RID: 17717 RVA: 0x00156154 File Offset: 0x00154354
		// (set) Token: 0x06004536 RID: 17718 RVA: 0x00156190 File Offset: 0x00154390
		public unsafe bool EntryVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_EntryVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_set_EntryVisible_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170014FC RID: 5372
		// (get) Token: 0x06004537 RID: 17719 RVA: 0x001561D0 File Offset: 0x001543D0
		public unsafe bool AreResponsesActive
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156699, XrefRangeEnd = 156700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_AreResponsesActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170014FD RID: 5373
		// (get) Token: 0x06004538 RID: 17720 RVA: 0x0015620C File Offset: 0x0015440C
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156700, XrefRangeEnd = 156702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170014FE RID: 5374
		// (get) Token: 0x06004539 RID: 17721 RVA: 0x00156244 File Offset: 0x00154444
		public unsafe virtual string SaveFileName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 156704, RefRangeEnd = 156705, XrefRangeStart = 156702, XrefRangeEnd = 156704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170014FF RID: 5375
		// (get) Token: 0x0600453A RID: 17722 RVA: 0x0015627C File Offset: 0x0015447C
		public unsafe virtual Loader Loader
		{
			[CallerCount(65)]
			[CachedScanResults(RefRangeStart = 31227, RefRangeEnd = 31292, XrefRangeStart = 31227, XrefRangeEnd = 31292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x17001500 RID: 5376
		// (get) Token: 0x0600453B RID: 17723 RVA: 0x001562BC File Offset: 0x001544BC
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(183)]
			[CachedScanResults(RefRangeStart = 35953, RefRangeEnd = 36136, XrefRangeStart = 35953, XrefRangeEnd = 36136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001501 RID: 5377
		// (get) Token: 0x0600453C RID: 17724 RVA: 0x001562F8 File Offset: 0x001544F8
		// (set) Token: 0x0600453D RID: 17725 RVA: 0x00156338 File Offset: 0x00154538
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001502 RID: 5378
		// (get) Token: 0x0600453E RID: 17726 RVA: 0x0015637C File Offset: 0x0015457C
		// (set) Token: 0x0600453F RID: 17727 RVA: 0x001563BC File Offset: 0x001545BC
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156705, XrefRangeEnd = 156706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001503 RID: 5379
		// (get) Token: 0x06004540 RID: 17728 RVA: 0x00156400 File Offset: 0x00154600
		// (set) Token: 0x06004541 RID: 17729 RVA: 0x0015643C File Offset: 0x0015463C
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004542 RID: 17730 RVA: 0x0015647C File Offset: 0x0015467C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 156800, RefRangeEnd = 156801, XrefRangeStart = 156706, XrefRangeEnd = 156800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MSGConversation(NPC _npc, string _contactName) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_npc);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_contactName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr__ctor_Public_Void_NPC_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004543 RID: 17731 RVA: 0x001564DC File Offset: 0x001546DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156801, XrefRangeEnd = 156807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MSGConversation.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004544 RID: 17732 RVA: 0x00156518 File Offset: 0x00154718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCategories(List<EConversationCategory> cat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cat);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_SetCategories_Public_Void_List_1_EConversationCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004545 RID: 17733 RVA: 0x0015655C File Offset: 0x0015475C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 156824, RefRangeEnd = 156827, XrefRangeStart = 156807, XrefRangeEnd = 156824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveToTop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_MoveToTop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004546 RID: 17734 RVA: 0x00156590 File Offset: 0x00154790
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 156952, RefRangeEnd = 156958, XrefRangeStart = 156827, XrefRangeEnd = 156952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_CreateUI_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004547 RID: 17735 RVA: 0x001565C4 File Offset: 0x001547C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156958, XrefRangeEnd = 156959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureUIExists()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_EnsureUIExists_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004548 RID: 17736 RVA: 0x001565F8 File Offset: 0x001547F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 156967, RefRangeEnd = 156970, XrefRangeStart = 156959, XrefRangeEnd = 156967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshPreviewText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_RefreshPreviewText_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004549 RID: 17737 RVA: 0x0015662C File Offset: 0x0015482C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 156982, RefRangeEnd = 156984, XrefRangeStart = 156970, XrefRangeEnd = 156982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RepositionEntry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_RepositionEntry_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600454A RID: 17738 RVA: 0x00156660 File Offset: 0x00154860
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 157008, RefRangeEnd = 157011, XrefRangeStart = 156984, XrefRangeEnd = 157008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsKnown(bool known)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref known;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_SetIsKnown_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600454B RID: 17739 RVA: 0x001566A0 File Offset: 0x001548A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157011, XrefRangeEnd = 157012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EntryClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_EntryClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600454C RID: 17740 RVA: 0x001566D4 File Offset: 0x001548D4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 157042, RefRangeEnd = 157047, XrefRangeStart = 157012, XrefRangeEnd = 157042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_SetOpen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600454D RID: 17741 RVA: 0x00156714 File Offset: 0x00154914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157047, XrefRangeEnd = 157128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RenderMessage(Message m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MSGConversation.NativeMethodInfoPtr_RenderMessage_Protected_Virtual_New_Void_Message_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600454E RID: 17742 RVA: 0x00156764 File Offset: 0x00154964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157128, XrefRangeEnd = 157131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEntryVisibility(bool v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_SetEntryVisibility_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600454F RID: 17743 RVA: 0x001567A4 File Offset: 0x001549A4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 157162, RefRangeEnd = 157169, XrefRangeStart = 157131, XrefRangeEnd = 157162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRead(bool r)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref r;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_SetRead_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004550 RID: 17744 RVA: 0x001567E4 File Offset: 0x001549E4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 157214, RefRangeEnd = 157223, XrefRangeStart = 157169, XrefRangeEnd = 157214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendMessage(Message message, bool notify = true, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_SendMessage_Public_Void_Message_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004551 RID: 17745 RVA: 0x00156844 File Offset: 0x00154A44
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 157256, RefRangeEnd = 157277, XrefRangeStart = 157223, XrefRangeEnd = 157256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendMessageChain(MessageChain messages, float initialDelay = 0f, bool notify = true, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(messages);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialDelay;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_SendMessageChain_Public_Void_MessageChain_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004552 RID: 17746 RVA: 0x001568B0 File Offset: 0x00154AB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 157336, RefRangeEnd = 157338, XrefRangeStart = 157277, XrefRangeEnd = 157336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MSGConversationData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_GetSaveData_Public_MSGConversationData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MSGConversationData>(intPtr3) : null;
		}

		// Token: 0x06004553 RID: 17747 RVA: 0x001568F0 File Offset: 0x00154AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157338, XrefRangeEnd = 157340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MSGConversation.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004554 RID: 17748 RVA: 0x00156934 File Offset: 0x00154B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157340, XrefRangeEnd = 157394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Load(MSGConversationData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MSGConversation.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_MSGConversationData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004555 RID: 17749 RVA: 0x00156984 File Offset: 0x00154B84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 157400, RefRangeEnd = 157402, XrefRangeStart = 157394, XrefRangeEnd = 157400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderValue(float value, Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_SetSliderValue_Public_Void_Single_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004556 RID: 17750 RVA: 0x001569D0 File Offset: 0x00154BD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 157417, RefRangeEnd = 157418, XrefRangeStart = 157402, XrefRangeEnd = 157417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Response GetResponse(string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_GetResponse_Public_Response_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Response>(intPtr3) : null;
		}

		// Token: 0x06004557 RID: 17751 RVA: 0x00156A20 File Offset: 0x00154C20
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 157445, RefRangeEnd = 157449, XrefRangeStart = 157418, XrefRangeEnd = 157445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowResponses(List<Response> _responses, float showResponseDelay = 0f, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_responses);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref showResponseDelay;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_ShowResponses_Public_Void_List_1_Response_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004558 RID: 17752 RVA: 0x00156A80 File Offset: 0x00154C80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 157500, RefRangeEnd = 157501, XrefRangeStart = 157449, XrefRangeEnd = 157500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateResponseUI(Response r)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_CreateResponseUI_Protected_Void_Response_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004559 RID: 17753 RVA: 0x00156AC4 File Offset: 0x00154CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157501, XrefRangeEnd = 157521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshResponseContainer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_RefreshResponseContainer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600455A RID: 17754 RVA: 0x00156AF8 File Offset: 0x00154CF8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 157533, RefRangeEnd = 157537, XrefRangeStart = 157521, XrefRangeEnd = 157533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearResponseUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_ClearResponseUI_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600455B RID: 17755 RVA: 0x00156B2C File Offset: 0x00154D2C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 157547, RefRangeEnd = 157553, XrefRangeStart = 157537, XrefRangeEnd = 157547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetResponseContainerVisible(bool v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_SetResponseContainerVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600455C RID: 17756 RVA: 0x00156B6C File Offset: 0x00154D6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 157564, RefRangeEnd = 157566, XrefRangeStart = 157553, XrefRangeEnd = 157564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResponseChosen(Response r, bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_ResponseChosen_Public_Void_Response_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600455D RID: 17757 RVA: 0x00156BBC File Offset: 0x00154DBC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 157584, RefRangeEnd = 157589, XrefRangeStart = 157566, XrefRangeEnd = 157584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearResponses(bool network = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_ClearResponses_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600455E RID: 17758 RVA: 0x00156BFC File Offset: 0x00154DFC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 157608, RefRangeEnd = 157611, XrefRangeStart = 157589, XrefRangeEnd = 157608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SendableMessage CreateSendableMessage(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_CreateSendableMessage_Public_SendableMessage_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SendableMessage>(intPtr3) : null;
		}

		// Token: 0x0600455F RID: 17759 RVA: 0x00156C4C File Offset: 0x00154E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157611, XrefRangeEnd = 157615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendPlayerMessage(int sendableIndex, int sentIndex, bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sendableIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sentIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_SendPlayerMessage_Public_Void_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004560 RID: 17760 RVA: 0x00156CA8 File Offset: 0x00154EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157615, XrefRangeEnd = 157622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenderPlayerMessage(SendableMessage sendable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sendable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_RenderPlayerMessage_Public_Void_SendableMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004561 RID: 17761 RVA: 0x00156CEC File Offset: 0x00154EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157622, XrefRangeEnd = 157634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckSendLoop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_CheckSendLoop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004562 RID: 17762 RVA: 0x00156D20 File Offset: 0x00154F20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 157653, RefRangeEnd = 157655, XrefRangeStart = 157634, XrefRangeEnd = 157653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanSendNewMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_CanSendNewMessage_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004563 RID: 17763 RVA: 0x00156D5C File Offset: 0x00154F5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157655, XrefRangeEnd = 157658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _CreateUI_b__72_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr__CreateUI_b__72_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004564 RID: 17764 RVA: 0x00156D90 File Offset: 0x00154F90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157658, XrefRangeEnd = 157663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004565 RID: 17765 RVA: 0x00021A84 File Offset: 0x0001FC84
		public MSGConversation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014D5 RID: 5333
		// (get) Token: 0x06004566 RID: 17766 RVA: 0x00156DD0 File Offset: 0x00154FD0
		// (set) Token: 0x06004567 RID: 17767 RVA: 0x00021A8D File Offset: 0x0001FC8D
		public unsafe static int MAX_MESSAGE_HISTORY
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(MSGConversation.NativeFieldInfoPtr_MAX_MESSAGE_HISTORY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSGConversation.NativeFieldInfoPtr_MAX_MESSAGE_HISTORY, (void*)(&value));
			}
		}

		// Token: 0x170014D6 RID: 5334
		// (get) Token: 0x06004568 RID: 17768 RVA: 0x00156DEC File Offset: 0x00154FEC
		// (set) Token: 0x06004569 RID: 17769 RVA: 0x00021A9B File Offset: 0x0001FC9B
		public unsafe string contactName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_contactName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_contactName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170014D7 RID: 5335
		// (get) Token: 0x0600456A RID: 17770 RVA: 0x00156E14 File Offset: 0x00155014
		// (set) Token: 0x0600456B RID: 17771 RVA: 0x00021ABA File Offset: 0x0001FCBA
		public unsafe NPC sender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_sender);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_sender), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014D8 RID: 5336
		// (get) Token: 0x0600456C RID: 17772 RVA: 0x00156E44 File Offset: 0x00155044
		// (set) Token: 0x0600456D RID: 17773 RVA: 0x00021AD9 File Offset: 0x0001FCD9
		public unsafe bool _IsSenderKnown_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__IsSenderKnown_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__IsSenderKnown_k__BackingField)) = value;
			}
		}

		// Token: 0x170014D9 RID: 5337
		// (get) Token: 0x0600456E RID: 17774 RVA: 0x00156E6C File Offset: 0x0015506C
		// (set) Token: 0x0600456F RID: 17775 RVA: 0x00021AF4 File Offset: 0x0001FCF4
		public unsafe List<Message> messageHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_messageHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Message>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_messageHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014DA RID: 5338
		// (get) Token: 0x06004570 RID: 17776 RVA: 0x00156E9C File Offset: 0x0015509C
		// (set) Token: 0x06004571 RID: 17777 RVA: 0x00021B13 File Offset: 0x0001FD13
		public unsafe List<MessageChain> messageChainHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_messageChainHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MessageChain>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_messageChainHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014DB RID: 5339
		// (get) Token: 0x06004572 RID: 17778 RVA: 0x00156ECC File Offset: 0x001550CC
		// (set) Token: 0x06004573 RID: 17779 RVA: 0x00021B32 File Offset: 0x0001FD32
		public unsafe List<MessageBubble> bubbles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_bubbles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MessageBubble>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_bubbles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014DC RID: 5340
		// (get) Token: 0x06004574 RID: 17780 RVA: 0x00156EFC File Offset: 0x001550FC
		// (set) Token: 0x06004575 RID: 17781 RVA: 0x00021B51 File Offset: 0x0001FD51
		public unsafe List<SendableMessage> Sendables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_Sendables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SendableMessage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_Sendables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014DD RID: 5341
		// (get) Token: 0x06004576 RID: 17782 RVA: 0x00156F2C File Offset: 0x0015512C
		// (set) Token: 0x06004577 RID: 17783 RVA: 0x00021B70 File Offset: 0x0001FD70
		public unsafe bool read
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_read);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_read)) = value;
			}
		}

		// Token: 0x170014DE RID: 5342
		// (get) Token: 0x06004578 RID: 17784 RVA: 0x00156F54 File Offset: 0x00155154
		// (set) Token: 0x06004579 RID: 17785 RVA: 0x00021B8B File Offset: 0x0001FD8B
		public unsafe int _index_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__index_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__index_k__BackingField)) = value;
			}
		}

		// Token: 0x170014DF RID: 5343
		// (get) Token: 0x0600457A RID: 17786 RVA: 0x00156F7C File Offset: 0x0015517C
		// (set) Token: 0x0600457B RID: 17787 RVA: 0x00021BA6 File Offset: 0x0001FDA6
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x170014E0 RID: 5344
		// (get) Token: 0x0600457C RID: 17788 RVA: 0x00156FA4 File Offset: 0x001551A4
		// (set) Token: 0x0600457D RID: 17789 RVA: 0x00021BC1 File Offset: 0x0001FDC1
		public unsafe bool _rollingOut_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__rollingOut_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__rollingOut_k__BackingField)) = value;
			}
		}

		// Token: 0x170014E1 RID: 5345
		// (get) Token: 0x0600457E RID: 17790 RVA: 0x00156FCC File Offset: 0x001551CC
		// (set) Token: 0x0600457F RID: 17791 RVA: 0x00021BDC File Offset: 0x0001FDDC
		public unsafe bool _EntryVisible_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__EntryVisible_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__EntryVisible_k__BackingField)) = value;
			}
		}

		// Token: 0x170014E2 RID: 5346
		// (get) Token: 0x06004580 RID: 17792 RVA: 0x00156FF4 File Offset: 0x001551F4
		// (set) Token: 0x06004581 RID: 17793 RVA: 0x00021BF7 File Offset: 0x0001FDF7
		public unsafe List<EConversationCategory> Categories
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_Categories);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EConversationCategory>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_Categories), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014E3 RID: 5347
		// (get) Token: 0x06004582 RID: 17794 RVA: 0x00157024 File Offset: 0x00155224
		// (set) Token: 0x06004583 RID: 17795 RVA: 0x00021C16 File Offset: 0x0001FE16
		public unsafe RectTransform entry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_entry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014E4 RID: 5348
		// (get) Token: 0x06004584 RID: 17796 RVA: 0x00157054 File Offset: 0x00155254
		// (set) Token: 0x06004585 RID: 17797 RVA: 0x00021C35 File Offset: 0x0001FE35
		public unsafe RectTransform container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014E5 RID: 5349
		// (get) Token: 0x06004586 RID: 17798 RVA: 0x00157084 File Offset: 0x00155284
		// (set) Token: 0x06004587 RID: 17799 RVA: 0x00021C54 File Offset: 0x0001FE54
		public unsafe RectTransform bubbleContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_bubbleContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_bubbleContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014E6 RID: 5350
		// (get) Token: 0x06004588 RID: 17800 RVA: 0x001570B4 File Offset: 0x001552B4
		// (set) Token: 0x06004589 RID: 17801 RVA: 0x00021C73 File Offset: 0x0001FE73
		public unsafe RectTransform scrollRectContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_scrollRectContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_scrollRectContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014E7 RID: 5351
		// (get) Token: 0x0600458A RID: 17802 RVA: 0x001570E4 File Offset: 0x001552E4
		// (set) Token: 0x0600458B RID: 17803 RVA: 0x00021C92 File Offset: 0x0001FE92
		public unsafe ScrollRect scrollRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_scrollRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_scrollRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014E8 RID: 5352
		// (get) Token: 0x0600458C RID: 17804 RVA: 0x00157114 File Offset: 0x00155314
		// (set) Token: 0x0600458D RID: 17805 RVA: 0x00021CB1 File Offset: 0x0001FEB1
		public unsafe Text entryPreviewText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_entryPreviewText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_entryPreviewText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014E9 RID: 5353
		// (get) Token: 0x0600458E RID: 17806 RVA: 0x00157144 File Offset: 0x00155344
		// (set) Token: 0x0600458F RID: 17807 RVA: 0x00021CD0 File Offset: 0x0001FED0
		public unsafe RectTransform unreadDot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_unreadDot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_unreadDot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014EA RID: 5354
		// (get) Token: 0x06004590 RID: 17808 RVA: 0x00157174 File Offset: 0x00155374
		// (set) Token: 0x06004591 RID: 17809 RVA: 0x00021CEF File Offset: 0x0001FEEF
		public unsafe Slider slider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_slider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_slider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014EB RID: 5355
		// (get) Token: 0x06004592 RID: 17810 RVA: 0x001571A4 File Offset: 0x001553A4
		// (set) Token: 0x06004593 RID: 17811 RVA: 0x00021D0E File Offset: 0x0001FF0E
		public unsafe Image sliderFill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_sliderFill);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_sliderFill), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014EC RID: 5356
		// (get) Token: 0x06004594 RID: 17812 RVA: 0x001571D4 File Offset: 0x001553D4
		// (set) Token: 0x06004595 RID: 17813 RVA: 0x00021D2D File Offset: 0x0001FF2D
		public unsafe RectTransform responseContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_responseContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_responseContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014ED RID: 5357
		// (get) Token: 0x06004596 RID: 17814 RVA: 0x00157204 File Offset: 0x00155404
		// (set) Token: 0x06004597 RID: 17815 RVA: 0x00021D4C File Offset: 0x0001FF4C
		public unsafe MessageSenderInterface senderInterface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_senderInterface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessageSenderInterface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_senderInterface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014EE RID: 5358
		// (get) Token: 0x06004598 RID: 17816 RVA: 0x00157234 File Offset: 0x00155434
		// (set) Token: 0x06004599 RID: 17817 RVA: 0x00021D6B File Offset: 0x0001FF6B
		public unsafe bool uiCreated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_uiCreated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_uiCreated)) = value;
			}
		}

		// Token: 0x170014EF RID: 5359
		// (get) Token: 0x0600459A RID: 17818 RVA: 0x0015725C File Offset: 0x0015545C
		// (set) Token: 0x0600459B RID: 17819 RVA: 0x00021D86 File Offset: 0x0001FF86
		public unsafe Action onMessageRendered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_onMessageRendered);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_onMessageRendered), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014F0 RID: 5360
		// (get) Token: 0x0600459C RID: 17820 RVA: 0x0015728C File Offset: 0x0015548C
		// (set) Token: 0x0600459D RID: 17821 RVA: 0x00021DA5 File Offset: 0x0001FFA5
		public unsafe Action onLoaded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_onLoaded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_onLoaded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014F1 RID: 5361
		// (get) Token: 0x0600459E RID: 17822 RVA: 0x001572BC File Offset: 0x001554BC
		// (set) Token: 0x0600459F RID: 17823 RVA: 0x00021DC4 File Offset: 0x0001FFC4
		public unsafe Action onResponsesShown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_onResponsesShown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_onResponsesShown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014F2 RID: 5362
		// (get) Token: 0x060045A0 RID: 17824 RVA: 0x001572EC File Offset: 0x001554EC
		// (set) Token: 0x060045A1 RID: 17825 RVA: 0x00021DE3 File Offset: 0x0001FFE3
		public unsafe List<Response> currentResponses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_currentResponses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Response>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_currentResponses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014F3 RID: 5363
		// (get) Token: 0x060045A2 RID: 17826 RVA: 0x0015731C File Offset: 0x0015551C
		// (set) Token: 0x060045A3 RID: 17827 RVA: 0x00021E02 File Offset: 0x00020002
		public unsafe List<RectTransform> responseRects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_responseRects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_responseRects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014F4 RID: 5364
		// (get) Token: 0x060045A4 RID: 17828 RVA: 0x0015734C File Offset: 0x0015554C
		// (set) Token: 0x060045A5 RID: 17829 RVA: 0x00021E21 File Offset: 0x00020021
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014F5 RID: 5365
		// (get) Token: 0x060045A6 RID: 17830 RVA: 0x0015737C File Offset: 0x0015557C
		// (set) Token: 0x060045A7 RID: 17831 RVA: 0x00021E40 File Offset: 0x00020040
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014F6 RID: 5366
		// (get) Token: 0x060045A8 RID: 17832 RVA: 0x001573AC File Offset: 0x001555AC
		// (set) Token: 0x060045A9 RID: 17833 RVA: 0x00021E5F File Offset: 0x0002005F
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x04002E64 RID: 11876
		private static readonly IntPtr NativeFieldInfoPtr_MAX_MESSAGE_HISTORY;

		// Token: 0x04002E65 RID: 11877
		private static readonly IntPtr NativeFieldInfoPtr_contactName;

		// Token: 0x04002E66 RID: 11878
		private static readonly IntPtr NativeFieldInfoPtr_sender;

		// Token: 0x04002E67 RID: 11879
		private static readonly IntPtr NativeFieldInfoPtr__IsSenderKnown_k__BackingField;

		// Token: 0x04002E68 RID: 11880
		private static readonly IntPtr NativeFieldInfoPtr_messageHistory;

		// Token: 0x04002E69 RID: 11881
		private static readonly IntPtr NativeFieldInfoPtr_messageChainHistory;

		// Token: 0x04002E6A RID: 11882
		private static readonly IntPtr NativeFieldInfoPtr_bubbles;

		// Token: 0x04002E6B RID: 11883
		private static readonly IntPtr NativeFieldInfoPtr_Sendables;

		// Token: 0x04002E6C RID: 11884
		private static readonly IntPtr NativeFieldInfoPtr_read;

		// Token: 0x04002E6D RID: 11885
		private static readonly IntPtr NativeFieldInfoPtr__index_k__BackingField;

		// Token: 0x04002E6E RID: 11886
		private static readonly IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x04002E6F RID: 11887
		private static readonly IntPtr NativeFieldInfoPtr__rollingOut_k__BackingField;

		// Token: 0x04002E70 RID: 11888
		private static readonly IntPtr NativeFieldInfoPtr__EntryVisible_k__BackingField;

		// Token: 0x04002E71 RID: 11889
		private static readonly IntPtr NativeFieldInfoPtr_Categories;

		// Token: 0x04002E72 RID: 11890
		private static readonly IntPtr NativeFieldInfoPtr_entry;

		// Token: 0x04002E73 RID: 11891
		private static readonly IntPtr NativeFieldInfoPtr_container;

		// Token: 0x04002E74 RID: 11892
		private static readonly IntPtr NativeFieldInfoPtr_bubbleContainer;

		// Token: 0x04002E75 RID: 11893
		private static readonly IntPtr NativeFieldInfoPtr_scrollRectContainer;

		// Token: 0x04002E76 RID: 11894
		private static readonly IntPtr NativeFieldInfoPtr_scrollRect;

		// Token: 0x04002E77 RID: 11895
		private static readonly IntPtr NativeFieldInfoPtr_entryPreviewText;

		// Token: 0x04002E78 RID: 11896
		private static readonly IntPtr NativeFieldInfoPtr_unreadDot;

		// Token: 0x04002E79 RID: 11897
		private static readonly IntPtr NativeFieldInfoPtr_slider;

		// Token: 0x04002E7A RID: 11898
		private static readonly IntPtr NativeFieldInfoPtr_sliderFill;

		// Token: 0x04002E7B RID: 11899
		private static readonly IntPtr NativeFieldInfoPtr_responseContainer;

		// Token: 0x04002E7C RID: 11900
		private static readonly IntPtr NativeFieldInfoPtr_senderInterface;

		// Token: 0x04002E7D RID: 11901
		private static readonly IntPtr NativeFieldInfoPtr_uiCreated;

		// Token: 0x04002E7E RID: 11902
		private static readonly IntPtr NativeFieldInfoPtr_onMessageRendered;

		// Token: 0x04002E7F RID: 11903
		private static readonly IntPtr NativeFieldInfoPtr_onLoaded;

		// Token: 0x04002E80 RID: 11904
		private static readonly IntPtr NativeFieldInfoPtr_onResponsesShown;

		// Token: 0x04002E81 RID: 11905
		private static readonly IntPtr NativeFieldInfoPtr_currentResponses;

		// Token: 0x04002E82 RID: 11906
		private static readonly IntPtr NativeFieldInfoPtr_responseRects;

		// Token: 0x04002E83 RID: 11907
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x04002E84 RID: 11908
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x04002E85 RID: 11909
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04002E86 RID: 11910
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSenderKnown_Public_get_Boolean_0;

		// Token: 0x04002E87 RID: 11911
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSenderKnown_Protected_set_Void_Boolean_0;

		// Token: 0x04002E88 RID: 11912
		private static readonly IntPtr NativeMethodInfoPtr_get_index_Public_get_Int32_0;

		// Token: 0x04002E89 RID: 11913
		private static readonly IntPtr NativeMethodInfoPtr_set_index_Protected_set_Void_Int32_0;

		// Token: 0x04002E8A RID: 11914
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x04002E8B RID: 11915
		private static readonly IntPtr NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04002E8C RID: 11916
		private static readonly IntPtr NativeMethodInfoPtr_get_rollingOut_Public_get_Boolean_0;

		// Token: 0x04002E8D RID: 11917
		private static readonly IntPtr NativeMethodInfoPtr_set_rollingOut_Protected_set_Void_Boolean_0;

		// Token: 0x04002E8E RID: 11918
		private static readonly IntPtr NativeMethodInfoPtr_get_EntryVisible_Public_get_Boolean_0;

		// Token: 0x04002E8F RID: 11919
		private static readonly IntPtr NativeMethodInfoPtr_set_EntryVisible_Protected_set_Void_Boolean_0;

		// Token: 0x04002E90 RID: 11920
		private static readonly IntPtr NativeMethodInfoPtr_get_AreResponsesActive_Public_get_Boolean_0;

		// Token: 0x04002E91 RID: 11921
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04002E92 RID: 11922
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04002E93 RID: 11923
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04002E94 RID: 11924
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04002E95 RID: 11925
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04002E96 RID: 11926
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04002E97 RID: 11927
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04002E98 RID: 11928
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04002E99 RID: 11929
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04002E9A RID: 11930
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04002E9B RID: 11931
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NPC_String_0;

		// Token: 0x04002E9C RID: 11932
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04002E9D RID: 11933
		private static readonly IntPtr NativeMethodInfoPtr_SetCategories_Public_Void_List_1_EConversationCategory_0;

		// Token: 0x04002E9E RID: 11934
		private static readonly IntPtr NativeMethodInfoPtr_MoveToTop_Public_Void_0;

		// Token: 0x04002E9F RID: 11935
		private static readonly IntPtr NativeMethodInfoPtr_CreateUI_Protected_Void_0;

		// Token: 0x04002EA0 RID: 11936
		private static readonly IntPtr NativeMethodInfoPtr_EnsureUIExists_Private_Void_0;

		// Token: 0x04002EA1 RID: 11937
		private static readonly IntPtr NativeMethodInfoPtr_RefreshPreviewText_Protected_Void_0;

		// Token: 0x04002EA2 RID: 11938
		private static readonly IntPtr NativeMethodInfoPtr_RepositionEntry_Public_Void_0;

		// Token: 0x04002EA3 RID: 11939
		private static readonly IntPtr NativeMethodInfoPtr_SetIsKnown_Public_Void_Boolean_0;

		// Token: 0x04002EA4 RID: 11940
		private static readonly IntPtr NativeMethodInfoPtr_EntryClicked_Public_Void_0;

		// Token: 0x04002EA5 RID: 11941
		private static readonly IntPtr NativeMethodInfoPtr_SetOpen_Public_Void_Boolean_0;

		// Token: 0x04002EA6 RID: 11942
		private static readonly IntPtr NativeMethodInfoPtr_RenderMessage_Protected_Virtual_New_Void_Message_0;

		// Token: 0x04002EA7 RID: 11943
		private static readonly IntPtr NativeMethodInfoPtr_SetEntryVisibility_Public_Void_Boolean_0;

		// Token: 0x04002EA8 RID: 11944
		private static readonly IntPtr NativeMethodInfoPtr_SetRead_Public_Void_Boolean_0;

		// Token: 0x04002EA9 RID: 11945
		private static readonly IntPtr NativeMethodInfoPtr_SendMessage_Public_Void_Message_Boolean_Boolean_0;

		// Token: 0x04002EAA RID: 11946
		private static readonly IntPtr NativeMethodInfoPtr_SendMessageChain_Public_Void_MessageChain_Single_Boolean_Boolean_0;

		// Token: 0x04002EAB RID: 11947
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveData_Public_MSGConversationData_0;

		// Token: 0x04002EAC RID: 11948
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x04002EAD RID: 11949
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_New_Void_MSGConversationData_0;

		// Token: 0x04002EAE RID: 11950
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderValue_Public_Void_Single_Color_0;

		// Token: 0x04002EAF RID: 11951
		private static readonly IntPtr NativeMethodInfoPtr_GetResponse_Public_Response_String_0;

		// Token: 0x04002EB0 RID: 11952
		private static readonly IntPtr NativeMethodInfoPtr_ShowResponses_Public_Void_List_1_Response_Single_Boolean_0;

		// Token: 0x04002EB1 RID: 11953
		private static readonly IntPtr NativeMethodInfoPtr_CreateResponseUI_Protected_Void_Response_0;

		// Token: 0x04002EB2 RID: 11954
		private static readonly IntPtr NativeMethodInfoPtr_RefreshResponseContainer_Private_Void_0;

		// Token: 0x04002EB3 RID: 11955
		private static readonly IntPtr NativeMethodInfoPtr_ClearResponseUI_Protected_Void_0;

		// Token: 0x04002EB4 RID: 11956
		private static readonly IntPtr NativeMethodInfoPtr_SetResponseContainerVisible_Public_Void_Boolean_0;

		// Token: 0x04002EB5 RID: 11957
		private static readonly IntPtr NativeMethodInfoPtr_ResponseChosen_Public_Void_Response_Boolean_0;

		// Token: 0x04002EB6 RID: 11958
		private static readonly IntPtr NativeMethodInfoPtr_ClearResponses_Public_Void_Boolean_0;

		// Token: 0x04002EB7 RID: 11959
		private static readonly IntPtr NativeMethodInfoPtr_CreateSendableMessage_Public_SendableMessage_String_0;

		// Token: 0x04002EB8 RID: 11960
		private static readonly IntPtr NativeMethodInfoPtr_SendPlayerMessage_Public_Void_Int32_Int32_Boolean_0;

		// Token: 0x04002EB9 RID: 11961
		private static readonly IntPtr NativeMethodInfoPtr_RenderPlayerMessage_Public_Void_SendableMessage_0;

		// Token: 0x04002EBA RID: 11962
		private static readonly IntPtr NativeMethodInfoPtr_CheckSendLoop_Private_Void_0;

		// Token: 0x04002EBB RID: 11963
		private static readonly IntPtr NativeMethodInfoPtr_CanSendNewMessage_Private_Boolean_0;

		// Token: 0x04002EBC RID: 11964
		private static readonly IntPtr NativeMethodInfoPtr__CreateUI_b__72_0_Private_Void_0;

		// Token: 0x04002EBD RID: 11965
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x0200096C RID: 2412
		[ObfuscatedName("ScheduleOne.Messaging.MSGConversation+<<CheckSendLoop>g__Loop|99_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600C96A RID: 51562 RVA: 0x0030C3F0 File Offset: 0x0030A5F0
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique()
			{
				Il2CppClassPointerStore<MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<<CheckSendLoop>g__Loop|99_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique>.NativeClassPtr);
				MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique>.NativeClassPtr, "<>1__state");
				MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique>.NativeClassPtr, "<>2__current");
				MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique>.NativeClassPtr, "<>4__this");
				MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique>.NativeClassPtr, 100671832);
				MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique>.NativeClassPtr, 100671833);
				MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique>.NativeClassPtr, 100671834);
				MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique>.NativeClassPtr, 100671835);
				MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique>.NativeClassPtr, 100671836);
				MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique>.NativeClassPtr, 100671837);
			}

			// Token: 0x0600C96B RID: 51563 RVA: 0x0030C4D0 File Offset: 0x0030A6D0
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C96C RID: 51564 RVA: 0x0030C518 File Offset: 0x0030A718
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C96D RID: 51565 RVA: 0x0030C54C File Offset: 0x0030A74C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156592, XrefRangeEnd = 156604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003ED6 RID: 16086
			// (get) Token: 0x0600C96E RID: 51566 RVA: 0x0030C588 File Offset: 0x0030A788
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C96F RID: 51567 RVA: 0x0030C5C8 File Offset: 0x0030A7C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156604, XrefRangeEnd = 156609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003ED7 RID: 16087
			// (get) Token: 0x0600C970 RID: 51568 RVA: 0x0030C5FC File Offset: 0x0030A7FC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C971 RID: 51569 RVA: 0x00061F66 File Offset: 0x00060166
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003ED3 RID: 16083
			// (get) Token: 0x0600C972 RID: 51570 RVA: 0x0030C63C File Offset: 0x0030A83C
			// (set) Token: 0x0600C973 RID: 51571 RVA: 0x00061F6F File Offset: 0x0006016F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003ED4 RID: 16084
			// (get) Token: 0x0600C974 RID: 51572 RVA: 0x0030C664 File Offset: 0x0030A864
			// (set) Token: 0x0600C975 RID: 51573 RVA: 0x00061F8A File Offset: 0x0006018A
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003ED5 RID: 16085
			// (get) Token: 0x0600C976 RID: 51574 RVA: 0x0030C694 File Offset: 0x0030A894
			// (set) Token: 0x0600C977 RID: 51575 RVA: 0x00061FA9 File Offset: 0x000601A9
			public unsafe MSGConversation __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008858 RID: 34904
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008859 RID: 34905
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400885A RID: 34906
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400885B RID: 34907
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400885C RID: 34908
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400885D RID: 34909
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400885E RID: 34910
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400885F RID: 34911
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008860 RID: 34912
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200096D RID: 2413
		[ObfuscatedName("ScheduleOne.Messaging.MSGConversation+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600C978 RID: 51576 RVA: 0x0030C6C4 File Offset: 0x0030A8C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MSGConversation.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MSGConversation.__c>.NativeClassPtr);
				MSGConversation.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c>.NativeClassPtr, "<>9");
				MSGConversation.__c.NativeFieldInfoPtr___9__100_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c>.NativeClassPtr, "<>9__100_0");
				MSGConversation.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c>.NativeClassPtr, 100671839);
				MSGConversation.__c.NativeMethodInfoPtr__CanSendNewMessage_b__100_0_Internal_Boolean_SendableMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c>.NativeClassPtr, 100671840);
			}

			// Token: 0x0600C979 RID: 51577 RVA: 0x0030C740 File Offset: 0x0030A940
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSGConversation.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C97A RID: 51578 RVA: 0x0030C77C File Offset: 0x0030A97C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156609, XrefRangeEnd = 156610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CanSendNewMessage_b__100_0(SendableMessage x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c.NativeMethodInfoPtr__CanSendNewMessage_b__100_0_Internal_Boolean_SendableMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C97B RID: 51579 RVA: 0x00061FC8 File Offset: 0x000601C8
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003ED8 RID: 16088
			// (get) Token: 0x0600C97C RID: 51580 RVA: 0x0030C7CC File Offset: 0x0030A9CC
			// (set) Token: 0x0600C97D RID: 51581 RVA: 0x00061FD1 File Offset: 0x000601D1
			public unsafe static MSGConversation.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MSGConversation.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversation.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MSGConversation.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003ED9 RID: 16089
			// (get) Token: 0x0600C97E RID: 51582 RVA: 0x0030C7F4 File Offset: 0x0030A9F4
			// (set) Token: 0x0600C97F RID: 51583 RVA: 0x00061FE3 File Offset: 0x000601E3
			public unsafe static Func<SendableMessage, bool> __9__100_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MSGConversation.__c.NativeFieldInfoPtr___9__100_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SendableMessage, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MSGConversation.__c.NativeFieldInfoPtr___9__100_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008861 RID: 34913
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008862 RID: 34914
			private static readonly IntPtr NativeFieldInfoPtr___9__100_0;

			// Token: 0x04008863 RID: 34915
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008864 RID: 34916
			private static readonly IntPtr NativeMethodInfoPtr__CanSendNewMessage_b__100_0_Internal_Boolean_SendableMessage_0;
		}

		// Token: 0x0200096E RID: 2414
		[ObfuscatedName("ScheduleOne.Messaging.MSGConversation+<>c__DisplayClass82_0")]
		public sealed class __c__DisplayClass82_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C980 RID: 51584 RVA: 0x0030C81C File Offset: 0x0030AA1C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass82_0()
			{
				Il2CppClassPointerStore<MSGConversation.__c__DisplayClass82_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<>c__DisplayClass82_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass82_0>.NativeClassPtr);
				MSGConversation.__c__DisplayClass82_0.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass82_0>.NativeClassPtr, "message");
				MSGConversation.__c__DisplayClass82_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass82_0>.NativeClassPtr, 100671841);
				MSGConversation.__c__DisplayClass82_0.NativeMethodInfoPtr__SendMessage_b__0_Internal_Boolean_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass82_0>.NativeClassPtr, 100671842);
			}

			// Token: 0x0600C981 RID: 51585 RVA: 0x0030C884 File Offset: 0x0030AA84
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass82_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass82_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass82_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C982 RID: 51586 RVA: 0x0030C8C0 File Offset: 0x0030AAC0
			[CallerCount(0)]
			public unsafe bool _SendMessage_b__0(Message x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass82_0.NativeMethodInfoPtr__SendMessage_b__0_Internal_Boolean_Message_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C983 RID: 51587 RVA: 0x00061FF5 File Offset: 0x000601F5
			public __c__DisplayClass82_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EDA RID: 16090
			// (get) Token: 0x0600C984 RID: 51588 RVA: 0x0030C910 File Offset: 0x0030AB10
			// (set) Token: 0x0600C985 RID: 51589 RVA: 0x00061FFE File Offset: 0x000601FE
			public unsafe Message message
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass82_0.NativeFieldInfoPtr_message);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Message>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass82_0.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008865 RID: 34917
			private static readonly IntPtr NativeFieldInfoPtr_message;

			// Token: 0x04008866 RID: 34918
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008867 RID: 34919
			private static readonly IntPtr NativeMethodInfoPtr__SendMessage_b__0_Internal_Boolean_Message_0;
		}

		// Token: 0x0200096F RID: 2415
		[ObfuscatedName("ScheduleOne.Messaging.MSGConversation+<>c__DisplayClass83_0")]
		public sealed class __c__DisplayClass83_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C986 RID: 51590 RVA: 0x0030C940 File Offset: 0x0030AB40
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass83_0()
			{
				Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<>c__DisplayClass83_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0>.NativeClassPtr);
				MSGConversation.__c__DisplayClass83_0.NativeFieldInfoPtr_messages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0>.NativeClassPtr, "messages");
				MSGConversation.__c__DisplayClass83_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0>.NativeClassPtr, "<>4__this");
				MSGConversation.__c__DisplayClass83_0.NativeFieldInfoPtr_notify = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0>.NativeClassPtr, "notify");
				MSGConversation.__c__DisplayClass83_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0>.NativeClassPtr, 100671843);
				MSGConversation.__c__DisplayClass83_0.NativeMethodInfoPtr__SendMessageChain_b__0_Internal_Boolean_MessageChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0>.NativeClassPtr, 100671844);
				MSGConversation.__c__DisplayClass83_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_MessageChain_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0>.NativeClassPtr, 100671845);
			}

			// Token: 0x0600C987 RID: 51591 RVA: 0x0030C9E4 File Offset: 0x0030ABE4
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass83_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass83_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C988 RID: 51592 RVA: 0x0030CA20 File Offset: 0x0030AC20
			[CallerCount(0)]
			public unsafe bool _SendMessageChain_b__0(MessageChain x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass83_0.NativeMethodInfoPtr__SendMessageChain_b__0_Internal_Boolean_MessageChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C989 RID: 51593 RVA: 0x0030CA70 File Offset: 0x0030AC70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156660, XrefRangeEnd = 156666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_MessageChain_Single_PDM_0(MessageChain messageChain, float initialDelay)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(messageChain);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialDelay;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass83_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_MessageChain_Single_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600C98A RID: 51594 RVA: 0x0006201D File Offset: 0x0006021D
			public __c__DisplayClass83_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EDB RID: 16091
			// (get) Token: 0x0600C98B RID: 51595 RVA: 0x0030CAD0 File Offset: 0x0030ACD0
			// (set) Token: 0x0600C98C RID: 51596 RVA: 0x00062026 File Offset: 0x00060226
			public unsafe MessageChain messages
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.NativeFieldInfoPtr_messages);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessageChain>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.NativeFieldInfoPtr_messages), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EDC RID: 16092
			// (get) Token: 0x0600C98D RID: 51597 RVA: 0x0030CB00 File Offset: 0x0030AD00
			// (set) Token: 0x0600C98E RID: 51598 RVA: 0x00062045 File Offset: 0x00060245
			public unsafe MSGConversation __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EDD RID: 16093
			// (get) Token: 0x0600C98F RID: 51599 RVA: 0x0030CB30 File Offset: 0x0030AD30
			// (set) Token: 0x0600C990 RID: 51600 RVA: 0x00062064 File Offset: 0x00060264
			public unsafe bool notify
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.NativeFieldInfoPtr_notify);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.NativeFieldInfoPtr_notify)) = value;
				}
			}

			// Token: 0x04008868 RID: 34920
			private static readonly IntPtr NativeFieldInfoPtr_messages;

			// Token: 0x04008869 RID: 34921
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400886A RID: 34922
			private static readonly IntPtr NativeFieldInfoPtr_notify;

			// Token: 0x0400886B RID: 34923
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400886C RID: 34924
			private static readonly IntPtr NativeMethodInfoPtr__SendMessageChain_b__0_Internal_Boolean_MessageChain_0;

			// Token: 0x0400886D RID: 34925
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_MessageChain_Single_PDM_0;

			// Token: 0x02000C42 RID: 3138
			[ObfuscatedName("ScheduleOne.Messaging.MSGConversation+<>c__DisplayClass83_0+<<SendMessageChain>g__Routine|1>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E245 RID: 57925 RVA: 0x0035278C File Offset: 0x0035098C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique()
				{
					Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0>.NativeClassPtr, "<<SendMessageChain>g__Routine|1>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr);
					MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, "<>1__state");
					MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, "<>2__current");
					MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, "<>4__this");
					MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr_messageChain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, "messageChain");
					MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr_initialDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, "initialDelay");
					MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr__messageClasses_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, "<messageClasses>5__2");
					MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, "<i>5__3");
					MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, 100671846);
					MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, 100671847);
					MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, 100671848);
					MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, 100671849);
					MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, 100671850);
					MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, 100671851);
				}

				// Token: 0x0600E246 RID: 57926 RVA: 0x003528BC File Offset: 0x00350ABC
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E247 RID: 57927 RVA: 0x00352904 File Offset: 0x00350B04
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E248 RID: 57928 RVA: 0x00352938 File Offset: 0x00350B38
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156610, XrefRangeEnd = 156655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x1700462D RID: 17965
				// (get) Token: 0x0600E249 RID: 57929 RVA: 0x00352974 File Offset: 0x00350B74
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E24A RID: 57930 RVA: 0x003529B4 File Offset: 0x00350BB4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156655, XrefRangeEnd = 156660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x1700462E RID: 17966
				// (get) Token: 0x0600E24B RID: 57931 RVA: 0x003529E8 File Offset: 0x00350BE8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E24C RID: 57932 RVA: 0x0006E4E9 File Offset: 0x0006C6E9
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004626 RID: 17958
				// (get) Token: 0x0600E24D RID: 57933 RVA: 0x00352A28 File Offset: 0x00350C28
				// (set) Token: 0x0600E24E RID: 57934 RVA: 0x0006E4F2 File Offset: 0x0006C6F2
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004627 RID: 17959
				// (get) Token: 0x0600E24F RID: 57935 RVA: 0x00352A50 File Offset: 0x00350C50
				// (set) Token: 0x0600E250 RID: 57936 RVA: 0x0006E50D File Offset: 0x0006C70D
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004628 RID: 17960
				// (get) Token: 0x0600E251 RID: 57937 RVA: 0x00352A80 File Offset: 0x00350C80
				// (set) Token: 0x0600E252 RID: 57938 RVA: 0x0006E52C File Offset: 0x0006C72C
				public unsafe MSGConversation.__c__DisplayClass83_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversation.__c__DisplayClass83_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004629 RID: 17961
				// (get) Token: 0x0600E253 RID: 57939 RVA: 0x00352AB0 File Offset: 0x00350CB0
				// (set) Token: 0x0600E254 RID: 57940 RVA: 0x0006E54B File Offset: 0x0006C74B
				public unsafe MessageChain messageChain
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr_messageChain);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessageChain>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr_messageChain), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700462A RID: 17962
				// (get) Token: 0x0600E255 RID: 57941 RVA: 0x00352AE0 File Offset: 0x00350CE0
				// (set) Token: 0x0600E256 RID: 57942 RVA: 0x0006E56A File Offset: 0x0006C76A
				public unsafe float initialDelay
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr_initialDelay);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr_initialDelay)) = value;
					}
				}

				// Token: 0x1700462B RID: 17963
				// (get) Token: 0x0600E257 RID: 57943 RVA: 0x00352B08 File Offset: 0x00350D08
				// (set) Token: 0x0600E258 RID: 57944 RVA: 0x0006E585 File Offset: 0x0006C785
				public unsafe List<Message> _messageClasses_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr__messageClasses_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Message>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr__messageClasses_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700462C RID: 17964
				// (get) Token: 0x0600E259 RID: 57945 RVA: 0x00352B38 File Offset: 0x00350D38
				// (set) Token: 0x0600E25A RID: 57946 RVA: 0x0006E5A4 File Offset: 0x0006C7A4
				public unsafe int _i_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr__i_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr__i_5__3)) = value;
					}
				}

				// Token: 0x04009778 RID: 38776
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009779 RID: 38777
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400977A RID: 38778
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400977B RID: 38779
				private static readonly IntPtr NativeFieldInfoPtr_messageChain;

				// Token: 0x0400977C RID: 38780
				private static readonly IntPtr NativeFieldInfoPtr_initialDelay;

				// Token: 0x0400977D RID: 38781
				private static readonly IntPtr NativeFieldInfoPtr__messageClasses_5__2;

				// Token: 0x0400977E RID: 38782
				private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

				// Token: 0x0400977F RID: 38783
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009780 RID: 38784
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009781 RID: 38785
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009782 RID: 38786
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009783 RID: 38787
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009784 RID: 38788
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000970 RID: 2416
		[ObfuscatedName("ScheduleOne.Messaging.MSGConversation+<>c__DisplayClass88_0")]
		public sealed class __c__DisplayClass88_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C991 RID: 51601 RVA: 0x0030CB58 File Offset: 0x0030AD58
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass88_0()
			{
				Il2CppClassPointerStore<MSGConversation.__c__DisplayClass88_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<>c__DisplayClass88_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass88_0>.NativeClassPtr);
				MSGConversation.__c__DisplayClass88_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass88_0>.NativeClassPtr, "label");
				MSGConversation.__c__DisplayClass88_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass88_0>.NativeClassPtr, 100671852);
				MSGConversation.__c__DisplayClass88_0.NativeMethodInfoPtr__GetResponse_b__0_Internal_Boolean_Response_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass88_0>.NativeClassPtr, 100671853);
			}

			// Token: 0x0600C992 RID: 51602 RVA: 0x0030CBC0 File Offset: 0x0030ADC0
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass88_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass88_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass88_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C993 RID: 51603 RVA: 0x0030CBFC File Offset: 0x0030ADFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156666, XrefRangeEnd = 156668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetResponse_b__0(Response x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass88_0.NativeMethodInfoPtr__GetResponse_b__0_Internal_Boolean_Response_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C994 RID: 51604 RVA: 0x0006207F File Offset: 0x0006027F
			public __c__DisplayClass88_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EDE RID: 16094
			// (get) Token: 0x0600C995 RID: 51605 RVA: 0x0030CC4C File Offset: 0x0030AE4C
			// (set) Token: 0x0600C996 RID: 51606 RVA: 0x00062088 File Offset: 0x00060288
			public unsafe string label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass88_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass88_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400886E RID: 34926
			private static readonly IntPtr NativeFieldInfoPtr_label;

			// Token: 0x0400886F RID: 34927
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008870 RID: 34928
			private static readonly IntPtr NativeMethodInfoPtr__GetResponse_b__0_Internal_Boolean_Response_0;
		}

		// Token: 0x02000971 RID: 2417
		[ObfuscatedName("ScheduleOne.Messaging.MSGConversation+<>c__DisplayClass89_0")]
		public sealed class __c__DisplayClass89_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C997 RID: 51607 RVA: 0x0030CC74 File Offset: 0x0030AE74
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass89_0()
			{
				Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<>c__DisplayClass89_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0>.NativeClassPtr);
				MSGConversation.__c__DisplayClass89_0.NativeFieldInfoPtr_showResponseDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0>.NativeClassPtr, "showResponseDelay");
				MSGConversation.__c__DisplayClass89_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0>.NativeClassPtr, "<>4__this");
				MSGConversation.__c__DisplayClass89_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0>.NativeClassPtr, 100671854);
				MSGConversation.__c__DisplayClass89_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0>.NativeClassPtr, 100671855);
			}

			// Token: 0x0600C998 RID: 51608 RVA: 0x0030CCF0 File Offset: 0x0030AEF0
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass89_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass89_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C999 RID: 51609 RVA: 0x0030CD2C File Offset: 0x0030AF2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156678, XrefRangeEnd = 156683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass89_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600C99A RID: 51610 RVA: 0x000620A7 File Offset: 0x000602A7
			public __c__DisplayClass89_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EDF RID: 16095
			// (get) Token: 0x0600C99B RID: 51611 RVA: 0x0030CD6C File Offset: 0x0030AF6C
			// (set) Token: 0x0600C99C RID: 51612 RVA: 0x000620B0 File Offset: 0x000602B0
			public unsafe float showResponseDelay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass89_0.NativeFieldInfoPtr_showResponseDelay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass89_0.NativeFieldInfoPtr_showResponseDelay)) = value;
				}
			}

			// Token: 0x17003EE0 RID: 16096
			// (get) Token: 0x0600C99D RID: 51613 RVA: 0x0030CD94 File Offset: 0x0030AF94
			// (set) Token: 0x0600C99E RID: 51614 RVA: 0x000620CB File Offset: 0x000602CB
			public unsafe MSGConversation __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass89_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass89_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008871 RID: 34929
			private static readonly IntPtr NativeFieldInfoPtr_showResponseDelay;

			// Token: 0x04008872 RID: 34930
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008873 RID: 34931
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008874 RID: 34932
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C43 RID: 3139
			[ObfuscatedName("ScheduleOne.Messaging.MSGConversation+<>c__DisplayClass89_0+<<ShowResponses>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E25B RID: 57947 RVA: 0x00352B60 File Offset: 0x00350D60
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0>.NativeClassPtr, "<<ShowResponses>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100671856);
					MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100671857);
					MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100671858);
					MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100671859);
					MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100671860);
					MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100671861);
				}

				// Token: 0x0600E25C RID: 57948 RVA: 0x00352C40 File Offset: 0x00350E40
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E25D RID: 57949 RVA: 0x00352C88 File Offset: 0x00350E88
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E25E RID: 57950 RVA: 0x00352CBC File Offset: 0x00350EBC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156668, XrefRangeEnd = 156673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004632 RID: 17970
				// (get) Token: 0x0600E25F RID: 57951 RVA: 0x00352CF8 File Offset: 0x00350EF8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E260 RID: 57952 RVA: 0x00352D38 File Offset: 0x00350F38
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156673, XrefRangeEnd = 156678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004633 RID: 17971
				// (get) Token: 0x0600E261 RID: 57953 RVA: 0x00352D6C File Offset: 0x00350F6C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E262 RID: 57954 RVA: 0x0006E5BF File Offset: 0x0006C7BF
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x1700462F RID: 17967
				// (get) Token: 0x0600E263 RID: 57955 RVA: 0x00352DAC File Offset: 0x00350FAC
				// (set) Token: 0x0600E264 RID: 57956 RVA: 0x0006E5C8 File Offset: 0x0006C7C8
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004630 RID: 17968
				// (get) Token: 0x0600E265 RID: 57957 RVA: 0x00352DD4 File Offset: 0x00350FD4
				// (set) Token: 0x0600E266 RID: 57958 RVA: 0x0006E5E3 File Offset: 0x0006C7E3
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004631 RID: 17969
				// (get) Token: 0x0600E267 RID: 57959 RVA: 0x00352E04 File Offset: 0x00351004
				// (set) Token: 0x0600E268 RID: 57960 RVA: 0x0006E602 File Offset: 0x0006C802
				public unsafe MSGConversation.__c__DisplayClass89_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversation.__c__DisplayClass89_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009785 RID: 38789
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009786 RID: 38790
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009787 RID: 38791
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009788 RID: 38792
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009789 RID: 38793
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400978A RID: 38794
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400978B RID: 38795
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400978C RID: 38796
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400978D RID: 38797
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000972 RID: 2418
		[ObfuscatedName("ScheduleOne.Messaging.MSGConversation+<>c__DisplayClass90_0")]
		public sealed class __c__DisplayClass90_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C99F RID: 51615 RVA: 0x0030CDC4 File Offset: 0x0030AFC4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass90_0()
			{
				Il2CppClassPointerStore<MSGConversation.__c__DisplayClass90_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<>c__DisplayClass90_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass90_0>.NativeClassPtr);
				MSGConversation.__c__DisplayClass90_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass90_0>.NativeClassPtr, "<>4__this");
				MSGConversation.__c__DisplayClass90_0.NativeFieldInfoPtr_r = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass90_0>.NativeClassPtr, "r");
				MSGConversation.__c__DisplayClass90_0.NativeFieldInfoPtr_network = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass90_0>.NativeClassPtr, "network");
				MSGConversation.__c__DisplayClass90_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass90_0>.NativeClassPtr, 100671862);
				MSGConversation.__c__DisplayClass90_0.NativeMethodInfoPtr__CreateResponseUI_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass90_0>.NativeClassPtr, 100671863);
			}

			// Token: 0x0600C9A0 RID: 51616 RVA: 0x0030CE54 File Offset: 0x0030B054
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass90_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass90_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass90_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C9A1 RID: 51617 RVA: 0x0030CE90 File Offset: 0x0030B090
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156683, XrefRangeEnd = 156699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateResponseUI_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass90_0.NativeMethodInfoPtr__CreateResponseUI_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C9A2 RID: 51618 RVA: 0x000620EA File Offset: 0x000602EA
			public __c__DisplayClass90_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EE1 RID: 16097
			// (get) Token: 0x0600C9A3 RID: 51619 RVA: 0x0030CEC4 File Offset: 0x0030B0C4
			// (set) Token: 0x0600C9A4 RID: 51620 RVA: 0x000620F3 File Offset: 0x000602F3
			public unsafe MSGConversation __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass90_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass90_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EE2 RID: 16098
			// (get) Token: 0x0600C9A5 RID: 51621 RVA: 0x0030CEF4 File Offset: 0x0030B0F4
			// (set) Token: 0x0600C9A6 RID: 51622 RVA: 0x00062112 File Offset: 0x00060312
			public unsafe Response r
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass90_0.NativeFieldInfoPtr_r);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Response>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass90_0.NativeFieldInfoPtr_r), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EE3 RID: 16099
			// (get) Token: 0x0600C9A7 RID: 51623 RVA: 0x0030CF24 File Offset: 0x0030B124
			// (set) Token: 0x0600C9A8 RID: 51624 RVA: 0x00062131 File Offset: 0x00060331
			public unsafe bool network
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass90_0.NativeFieldInfoPtr_network);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass90_0.NativeFieldInfoPtr_network)) = value;
				}
			}

			// Token: 0x04008875 RID: 34933
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008876 RID: 34934
			private static readonly IntPtr NativeFieldInfoPtr_r;

			// Token: 0x04008877 RID: 34935
			private static readonly IntPtr NativeFieldInfoPtr_network;

			// Token: 0x04008878 RID: 34936
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008879 RID: 34937
			private static readonly IntPtr NativeMethodInfoPtr__CreateResponseUI_b__0_Internal_Void_0;
		}
	}
}
