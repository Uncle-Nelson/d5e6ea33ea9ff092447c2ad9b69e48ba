using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Messaging;
using Il2CppScheduleOne.UI.Tooltips;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.Messages
{
	// Token: 0x020006B2 RID: 1714
	public class MessagesApp : App<MessagesApp>
	{
		// Token: 0x06009A29 RID: 39465 RVA: 0x00273710 File Offset: 0x00271910
		// Note: this type is marked as 'beforefieldinit'.
		static MessagesApp()
		{
			Il2CppClassPointerStore<MessagesApp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Messages", "MessagesApp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr);
			MessagesApp.NativeFieldInfoPtr_Conversations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "Conversations");
			MessagesApp.NativeFieldInfoPtr_ActiveConversations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "ActiveConversations");
			MessagesApp.NativeFieldInfoPtr_categoryInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "categoryInfos");
			MessagesApp.NativeFieldInfoPtr_conversationEntryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "conversationEntryContainer");
			MessagesApp.NativeFieldInfoPtr_conversationContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "conversationContainer");
			MessagesApp.NativeFieldInfoPtr_homePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "homePage");
			MessagesApp.NativeFieldInfoPtr_dialoguePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "dialoguePage");
			MessagesApp.NativeFieldInfoPtr_dialoguePageNameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "dialoguePageNameText");
			MessagesApp.NativeFieldInfoPtr_relationshipContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "relationshipContainer");
			MessagesApp.NativeFieldInfoPtr_relationshipScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "relationshipScrollbar");
			MessagesApp.NativeFieldInfoPtr_relationshipTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "relationshipTooltip");
			MessagesApp.NativeFieldInfoPtr_standardsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "standardsContainer");
			MessagesApp.NativeFieldInfoPtr_standardsStar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "standardsStar");
			MessagesApp.NativeFieldInfoPtr_standardsTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "standardsTooltip");
			MessagesApp.NativeFieldInfoPtr_iconContainerRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "iconContainerRect");
			MessagesApp.NativeFieldInfoPtr_iconImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "iconImage");
			MessagesApp.NativeFieldInfoPtr_BlankAvatarSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "BlankAvatarSprite");
			MessagesApp.NativeFieldInfoPtr_DealWindowSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "DealWindowSelector");
			MessagesApp.NativeFieldInfoPtr_PhoneShopInterface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "PhoneShopInterface");
			MessagesApp.NativeFieldInfoPtr_CounterofferInterface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "CounterofferInterface");
			MessagesApp.NativeFieldInfoPtr_ClearFilterButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "ClearFilterButton");
			MessagesApp.NativeFieldInfoPtr_CategoryButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "CategoryButtons");
			MessagesApp.NativeFieldInfoPtr_MessageReceivedSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "MessageReceivedSound");
			MessagesApp.NativeFieldInfoPtr_MessageSentSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "MessageSentSound");
			MessagesApp.NativeFieldInfoPtr_conversationEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "conversationEntryPrefab");
			MessagesApp.NativeFieldInfoPtr_conversationContainerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "conversationContainerPrefab");
			MessagesApp.NativeFieldInfoPtr_messageBubblePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "messageBubblePrefab");
			MessagesApp.NativeFieldInfoPtr_unreadConversations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "unreadConversations");
			MessagesApp.NativeFieldInfoPtr__currentConversation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "<currentConversation>k__BackingField");
			MessagesApp.NativeMethodInfoPtr_get_currentConversation_Public_get_MSGConversation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100682276);
			MessagesApp.NativeMethodInfoPtr_set_currentConversation_Private_set_Void_MSGConversation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100682277);
			MessagesApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100682278);
			MessagesApp.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100682279);
			MessagesApp.NativeMethodInfoPtr_Loaded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100682280);
			MessagesApp.NativeMethodInfoPtr_Clean_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100682281);
			MessagesApp.NativeMethodInfoPtr_CreateConversationUI_Public_Void_MSGConversation_byref_RectTransform_byref_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100682282);
			MessagesApp.NativeMethodInfoPtr_RepositionEntries_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100682283);
			MessagesApp.NativeMethodInfoPtr_ReturnButtonClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100682284);
			MessagesApp.NativeMethodInfoPtr_RefreshNotifications_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100682285);
			MessagesApp.NativeMethodInfoPtr_Exit_Public_Virtual_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100682286);
			MessagesApp.NativeMethodInfoPtr_SetCurrentConversation_Public_Void_MSGConversation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100682287);
			MessagesApp.NativeMethodInfoPtr_GetCategoryInfo_Public_CategoryInfo_EConversationCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100682288);
			MessagesApp.NativeMethodInfoPtr_FilterByCategory_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100682289);
			MessagesApp.NativeMethodInfoPtr_ClearFilter_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100682290);
			MessagesApp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100682291);
		}

		// Token: 0x17002F87 RID: 12167
		// (get) Token: 0x06009A2A RID: 39466 RVA: 0x00273AC4 File Offset: 0x00271CC4
		// (set) Token: 0x06009A2B RID: 39467 RVA: 0x00273B04 File Offset: 0x00271D04
		public unsafe MSGConversation currentConversation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_get_currentConversation_Public_get_MSGConversation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MSGConversation>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_set_currentConversation_Private_set_Void_MSGConversation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009A2C RID: 39468 RVA: 0x00273B48 File Offset: 0x00271D48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274563, XrefRangeEnd = 274605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessagesApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A2D RID: 39469 RVA: 0x00273B84 File Offset: 0x00271D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274605, XrefRangeEnd = 274625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessagesApp.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A2E RID: 39470 RVA: 0x00273BC0 File Offset: 0x00271DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274625, XrefRangeEnd = 274656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Loaded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_Loaded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A2F RID: 39471 RVA: 0x00273BF4 File Offset: 0x00271DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274656, XrefRangeEnd = 274664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clean()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_Clean_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A30 RID: 39472 RVA: 0x00273C28 File Offset: 0x00271E28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 274752, RefRangeEnd = 274753, XrefRangeStart = 274664, XrefRangeEnd = 274752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateConversationUI(MSGConversation c, out RectTransform entry, out RectTransform container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_CreateConversationUI_Public_Void_MSGConversation_byref_RectTransform_byref_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			entry = ((intPtr5 == 0) ? null : new RectTransform(intPtr5));
			IntPtr intPtr6 = intPtr2;
			container = ((intPtr6 == 0) ? null : new RectTransform(intPtr6));
		}

		// Token: 0x06009A31 RID: 39473 RVA: 0x00273CB0 File Offset: 0x00271EB0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 274774, RefRangeEnd = 274777, XrefRangeStart = 274753, XrefRangeEnd = 274774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RepositionEntries()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_RepositionEntries_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A32 RID: 39474 RVA: 0x00273CE4 File Offset: 0x00271EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274777, XrefRangeEnd = 274778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReturnButtonClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_ReturnButtonClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A33 RID: 39475 RVA: 0x00273D18 File Offset: 0x00271F18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 274789, RefRangeEnd = 274790, XrefRangeStart = 274778, XrefRangeEnd = 274789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshNotifications()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_RefreshNotifications_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A34 RID: 39476 RVA: 0x00273D4C File Offset: 0x00271F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274790, XrefRangeEnd = 274797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Exit(ExitAction exit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exit);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessagesApp.NativeMethodInfoPtr_Exit_Public_Virtual_Void_ExitAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A35 RID: 39477 RVA: 0x00273D9C File Offset: 0x00271F9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 274799, RefRangeEnd = 274800, XrefRangeStart = 274797, XrefRangeEnd = 274799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCurrentConversation(MSGConversation conversation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conversation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_SetCurrentConversation_Public_Void_MSGConversation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A36 RID: 39478 RVA: 0x00273DE0 File Offset: 0x00271FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274800, XrefRangeEnd = 274814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessagesApp.CategoryInfo GetCategoryInfo(EConversationCategory category)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref category;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_GetCategoryInfo_Public_CategoryInfo_EConversationCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MessagesApp.CategoryInfo>(intPtr3) : null;
		}

		// Token: 0x06009A37 RID: 39479 RVA: 0x00273E2C File Offset: 0x0027202C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274814, XrefRangeEnd = 274839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FilterByCategory(int category)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref category;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_FilterByCategory_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A38 RID: 39480 RVA: 0x00273E6C File Offset: 0x0027206C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274839, XrefRangeEnd = 274858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearFilter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_ClearFilter_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A39 RID: 39481 RVA: 0x00273EA0 File Offset: 0x002720A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274858, XrefRangeEnd = 274871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessagesApp() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A3A RID: 39482 RVA: 0x0004B486 File Offset: 0x00049686
		public MessagesApp(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002F6A RID: 12138
		// (get) Token: 0x06009A3B RID: 39483 RVA: 0x00273EDC File Offset: 0x002720DC
		// (set) Token: 0x06009A3C RID: 39484 RVA: 0x0004B48F File Offset: 0x0004968F
		public unsafe static List<MSGConversation> Conversations
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MessagesApp.NativeFieldInfoPtr_Conversations, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MSGConversation>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MessagesApp.NativeFieldInfoPtr_Conversations, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F6B RID: 12139
		// (get) Token: 0x06009A3D RID: 39485 RVA: 0x00273F04 File Offset: 0x00272104
		// (set) Token: 0x06009A3E RID: 39486 RVA: 0x0004B4A1 File Offset: 0x000496A1
		public unsafe static List<MSGConversation> ActiveConversations
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MessagesApp.NativeFieldInfoPtr_ActiveConversations, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MSGConversation>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MessagesApp.NativeFieldInfoPtr_ActiveConversations, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F6C RID: 12140
		// (get) Token: 0x06009A3F RID: 39487 RVA: 0x00273F2C File Offset: 0x0027212C
		// (set) Token: 0x06009A40 RID: 39488 RVA: 0x0004B4B3 File Offset: 0x000496B3
		public unsafe List<MessagesApp.CategoryInfo> categoryInfos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_categoryInfos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MessagesApp.CategoryInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_categoryInfos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F6D RID: 12141
		// (get) Token: 0x06009A41 RID: 39489 RVA: 0x00273F5C File Offset: 0x0027215C
		// (set) Token: 0x06009A42 RID: 39490 RVA: 0x0004B4D2 File Offset: 0x000496D2
		public unsafe RectTransform conversationEntryContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_conversationEntryContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_conversationEntryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F6E RID: 12142
		// (get) Token: 0x06009A43 RID: 39491 RVA: 0x00273F8C File Offset: 0x0027218C
		// (set) Token: 0x06009A44 RID: 39492 RVA: 0x0004B4F1 File Offset: 0x000496F1
		public unsafe RectTransform conversationContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_conversationContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_conversationContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F6F RID: 12143
		// (get) Token: 0x06009A45 RID: 39493 RVA: 0x00273FBC File Offset: 0x002721BC
		// (set) Token: 0x06009A46 RID: 39494 RVA: 0x0004B510 File Offset: 0x00049710
		public unsafe GameObject homePage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_homePage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_homePage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F70 RID: 12144
		// (get) Token: 0x06009A47 RID: 39495 RVA: 0x00273FEC File Offset: 0x002721EC
		// (set) Token: 0x06009A48 RID: 39496 RVA: 0x0004B52F File Offset: 0x0004972F
		public unsafe GameObject dialoguePage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_dialoguePage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_dialoguePage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F71 RID: 12145
		// (get) Token: 0x06009A49 RID: 39497 RVA: 0x0027401C File Offset: 0x0027221C
		// (set) Token: 0x06009A4A RID: 39498 RVA: 0x0004B54E File Offset: 0x0004974E
		public unsafe Text dialoguePageNameText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_dialoguePageNameText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_dialoguePageNameText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F72 RID: 12146
		// (get) Token: 0x06009A4B RID: 39499 RVA: 0x0027404C File Offset: 0x0027224C
		// (set) Token: 0x06009A4C RID: 39500 RVA: 0x0004B56D File Offset: 0x0004976D
		public unsafe RectTransform relationshipContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_relationshipContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_relationshipContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F73 RID: 12147
		// (get) Token: 0x06009A4D RID: 39501 RVA: 0x0027407C File Offset: 0x0027227C
		// (set) Token: 0x06009A4E RID: 39502 RVA: 0x0004B58C File Offset: 0x0004978C
		public unsafe Scrollbar relationshipScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_relationshipScrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_relationshipScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F74 RID: 12148
		// (get) Token: 0x06009A4F RID: 39503 RVA: 0x002740AC File Offset: 0x002722AC
		// (set) Token: 0x06009A50 RID: 39504 RVA: 0x0004B5AB File Offset: 0x000497AB
		public unsafe Tooltip relationshipTooltip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_relationshipTooltip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tooltip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_relationshipTooltip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F75 RID: 12149
		// (get) Token: 0x06009A51 RID: 39505 RVA: 0x002740DC File Offset: 0x002722DC
		// (set) Token: 0x06009A52 RID: 39506 RVA: 0x0004B5CA File Offset: 0x000497CA
		public unsafe RectTransform standardsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_standardsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_standardsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F76 RID: 12150
		// (get) Token: 0x06009A53 RID: 39507 RVA: 0x0027410C File Offset: 0x0027230C
		// (set) Token: 0x06009A54 RID: 39508 RVA: 0x0004B5E9 File Offset: 0x000497E9
		public unsafe Image standardsStar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_standardsStar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_standardsStar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F77 RID: 12151
		// (get) Token: 0x06009A55 RID: 39509 RVA: 0x0027413C File Offset: 0x0027233C
		// (set) Token: 0x06009A56 RID: 39510 RVA: 0x0004B608 File Offset: 0x00049808
		public unsafe Tooltip standardsTooltip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_standardsTooltip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tooltip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_standardsTooltip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F78 RID: 12152
		// (get) Token: 0x06009A57 RID: 39511 RVA: 0x0027416C File Offset: 0x0027236C
		// (set) Token: 0x06009A58 RID: 39512 RVA: 0x0004B627 File Offset: 0x00049827
		public unsafe RectTransform iconContainerRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_iconContainerRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_iconContainerRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F79 RID: 12153
		// (get) Token: 0x06009A59 RID: 39513 RVA: 0x0027419C File Offset: 0x0027239C
		// (set) Token: 0x06009A5A RID: 39514 RVA: 0x0004B646 File Offset: 0x00049846
		public unsafe Image iconImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_iconImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_iconImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F7A RID: 12154
		// (get) Token: 0x06009A5B RID: 39515 RVA: 0x002741CC File Offset: 0x002723CC
		// (set) Token: 0x06009A5C RID: 39516 RVA: 0x0004B665 File Offset: 0x00049865
		public unsafe Sprite BlankAvatarSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_BlankAvatarSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_BlankAvatarSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F7B RID: 12155
		// (get) Token: 0x06009A5D RID: 39517 RVA: 0x002741FC File Offset: 0x002723FC
		// (set) Token: 0x06009A5E RID: 39518 RVA: 0x0004B684 File Offset: 0x00049884
		public unsafe DealWindowSelector DealWindowSelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_DealWindowSelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DealWindowSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_DealWindowSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F7C RID: 12156
		// (get) Token: 0x06009A5F RID: 39519 RVA: 0x0027422C File Offset: 0x0027242C
		// (set) Token: 0x06009A60 RID: 39520 RVA: 0x0004B6A3 File Offset: 0x000498A3
		public unsafe PhoneShopInterface PhoneShopInterface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_PhoneShopInterface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhoneShopInterface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_PhoneShopInterface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F7D RID: 12157
		// (get) Token: 0x06009A61 RID: 39521 RVA: 0x0027425C File Offset: 0x0027245C
		// (set) Token: 0x06009A62 RID: 39522 RVA: 0x0004B6C2 File Offset: 0x000498C2
		public unsafe CounterofferInterface CounterofferInterface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_CounterofferInterface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CounterofferInterface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_CounterofferInterface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F7E RID: 12158
		// (get) Token: 0x06009A63 RID: 39523 RVA: 0x0027428C File Offset: 0x0027248C
		// (set) Token: 0x06009A64 RID: 39524 RVA: 0x0004B6E1 File Offset: 0x000498E1
		public unsafe RectTransform ClearFilterButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_ClearFilterButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_ClearFilterButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F7F RID: 12159
		// (get) Token: 0x06009A65 RID: 39525 RVA: 0x002742BC File Offset: 0x002724BC
		// (set) Token: 0x06009A66 RID: 39526 RVA: 0x0004B700 File Offset: 0x00049900
		public unsafe Il2CppReferenceArray<Button> CategoryButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_CategoryButtons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Button>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_CategoryButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F80 RID: 12160
		// (get) Token: 0x06009A67 RID: 39527 RVA: 0x002742EC File Offset: 0x002724EC
		// (set) Token: 0x06009A68 RID: 39528 RVA: 0x0004B71F File Offset: 0x0004991F
		public unsafe AudioSourceController MessageReceivedSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_MessageReceivedSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_MessageReceivedSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F81 RID: 12161
		// (get) Token: 0x06009A69 RID: 39529 RVA: 0x0027431C File Offset: 0x0027251C
		// (set) Token: 0x06009A6A RID: 39530 RVA: 0x0004B73E File Offset: 0x0004993E
		public unsafe AudioSourceController MessageSentSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_MessageSentSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_MessageSentSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F82 RID: 12162
		// (get) Token: 0x06009A6B RID: 39531 RVA: 0x0027434C File Offset: 0x0027254C
		// (set) Token: 0x06009A6C RID: 39532 RVA: 0x0004B75D File Offset: 0x0004995D
		public unsafe GameObject conversationEntryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_conversationEntryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_conversationEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F83 RID: 12163
		// (get) Token: 0x06009A6D RID: 39533 RVA: 0x0027437C File Offset: 0x0027257C
		// (set) Token: 0x06009A6E RID: 39534 RVA: 0x0004B77C File Offset: 0x0004997C
		public unsafe GameObject conversationContainerPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_conversationContainerPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_conversationContainerPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F84 RID: 12164
		// (get) Token: 0x06009A6F RID: 39535 RVA: 0x002743AC File Offset: 0x002725AC
		// (set) Token: 0x06009A70 RID: 39536 RVA: 0x0004B79B File Offset: 0x0004999B
		public unsafe GameObject messageBubblePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_messageBubblePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_messageBubblePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F85 RID: 12165
		// (get) Token: 0x06009A71 RID: 39537 RVA: 0x002743DC File Offset: 0x002725DC
		// (set) Token: 0x06009A72 RID: 39538 RVA: 0x0004B7BA File Offset: 0x000499BA
		public unsafe List<MSGConversation> unreadConversations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_unreadConversations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MSGConversation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_unreadConversations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F86 RID: 12166
		// (get) Token: 0x06009A73 RID: 39539 RVA: 0x0027440C File Offset: 0x0027260C
		// (set) Token: 0x06009A74 RID: 39540 RVA: 0x0004B7D9 File Offset: 0x000499D9
		public unsafe MSGConversation _currentConversation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr__currentConversation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr__currentConversation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040067BB RID: 26555
		private static readonly IntPtr NativeFieldInfoPtr_Conversations;

		// Token: 0x040067BC RID: 26556
		private static readonly IntPtr NativeFieldInfoPtr_ActiveConversations;

		// Token: 0x040067BD RID: 26557
		private static readonly IntPtr NativeFieldInfoPtr_categoryInfos;

		// Token: 0x040067BE RID: 26558
		private static readonly IntPtr NativeFieldInfoPtr_conversationEntryContainer;

		// Token: 0x040067BF RID: 26559
		private static readonly IntPtr NativeFieldInfoPtr_conversationContainer;

		// Token: 0x040067C0 RID: 26560
		private static readonly IntPtr NativeFieldInfoPtr_homePage;

		// Token: 0x040067C1 RID: 26561
		private static readonly IntPtr NativeFieldInfoPtr_dialoguePage;

		// Token: 0x040067C2 RID: 26562
		private static readonly IntPtr NativeFieldInfoPtr_dialoguePageNameText;

		// Token: 0x040067C3 RID: 26563
		private static readonly IntPtr NativeFieldInfoPtr_relationshipContainer;

		// Token: 0x040067C4 RID: 26564
		private static readonly IntPtr NativeFieldInfoPtr_relationshipScrollbar;

		// Token: 0x040067C5 RID: 26565
		private static readonly IntPtr NativeFieldInfoPtr_relationshipTooltip;

		// Token: 0x040067C6 RID: 26566
		private static readonly IntPtr NativeFieldInfoPtr_standardsContainer;

		// Token: 0x040067C7 RID: 26567
		private static readonly IntPtr NativeFieldInfoPtr_standardsStar;

		// Token: 0x040067C8 RID: 26568
		private static readonly IntPtr NativeFieldInfoPtr_standardsTooltip;

		// Token: 0x040067C9 RID: 26569
		private static readonly IntPtr NativeFieldInfoPtr_iconContainerRect;

		// Token: 0x040067CA RID: 26570
		private static readonly IntPtr NativeFieldInfoPtr_iconImage;

		// Token: 0x040067CB RID: 26571
		private static readonly IntPtr NativeFieldInfoPtr_BlankAvatarSprite;

		// Token: 0x040067CC RID: 26572
		private static readonly IntPtr NativeFieldInfoPtr_DealWindowSelector;

		// Token: 0x040067CD RID: 26573
		private static readonly IntPtr NativeFieldInfoPtr_PhoneShopInterface;

		// Token: 0x040067CE RID: 26574
		private static readonly IntPtr NativeFieldInfoPtr_CounterofferInterface;

		// Token: 0x040067CF RID: 26575
		private static readonly IntPtr NativeFieldInfoPtr_ClearFilterButton;

		// Token: 0x040067D0 RID: 26576
		private static readonly IntPtr NativeFieldInfoPtr_CategoryButtons;

		// Token: 0x040067D1 RID: 26577
		private static readonly IntPtr NativeFieldInfoPtr_MessageReceivedSound;

		// Token: 0x040067D2 RID: 26578
		private static readonly IntPtr NativeFieldInfoPtr_MessageSentSound;

		// Token: 0x040067D3 RID: 26579
		private static readonly IntPtr NativeFieldInfoPtr_conversationEntryPrefab;

		// Token: 0x040067D4 RID: 26580
		private static readonly IntPtr NativeFieldInfoPtr_conversationContainerPrefab;

		// Token: 0x040067D5 RID: 26581
		private static readonly IntPtr NativeFieldInfoPtr_messageBubblePrefab;

		// Token: 0x040067D6 RID: 26582
		private static readonly IntPtr NativeFieldInfoPtr_unreadConversations;

		// Token: 0x040067D7 RID: 26583
		private static readonly IntPtr NativeFieldInfoPtr__currentConversation_k__BackingField;

		// Token: 0x040067D8 RID: 26584
		private static readonly IntPtr NativeMethodInfoPtr_get_currentConversation_Public_get_MSGConversation_0;

		// Token: 0x040067D9 RID: 26585
		private static readonly IntPtr NativeMethodInfoPtr_set_currentConversation_Private_set_Void_MSGConversation_0;

		// Token: 0x040067DA RID: 26586
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040067DB RID: 26587
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x040067DC RID: 26588
		private static readonly IntPtr NativeMethodInfoPtr_Loaded_Private_Void_0;

		// Token: 0x040067DD RID: 26589
		private static readonly IntPtr NativeMethodInfoPtr_Clean_Private_Void_0;

		// Token: 0x040067DE RID: 26590
		private static readonly IntPtr NativeMethodInfoPtr_CreateConversationUI_Public_Void_MSGConversation_byref_RectTransform_byref_RectTransform_0;

		// Token: 0x040067DF RID: 26591
		private static readonly IntPtr NativeMethodInfoPtr_RepositionEntries_Public_Void_0;

		// Token: 0x040067E0 RID: 26592
		private static readonly IntPtr NativeMethodInfoPtr_ReturnButtonClicked_Public_Void_0;

		// Token: 0x040067E1 RID: 26593
		private static readonly IntPtr NativeMethodInfoPtr_RefreshNotifications_Public_Void_0;

		// Token: 0x040067E2 RID: 26594
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Virtual_Void_ExitAction_0;

		// Token: 0x040067E3 RID: 26595
		private static readonly IntPtr NativeMethodInfoPtr_SetCurrentConversation_Public_Void_MSGConversation_0;

		// Token: 0x040067E4 RID: 26596
		private static readonly IntPtr NativeMethodInfoPtr_GetCategoryInfo_Public_CategoryInfo_EConversationCategory_0;

		// Token: 0x040067E5 RID: 26597
		private static readonly IntPtr NativeMethodInfoPtr_FilterByCategory_Public_Void_Int32_0;

		// Token: 0x040067E6 RID: 26598
		private static readonly IntPtr NativeMethodInfoPtr_ClearFilter_Public_Void_0;

		// Token: 0x040067E7 RID: 26599
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B7D RID: 2941
		[Serializable]
		public class CategoryInfo : Il2CppSystem.Object
		{
			// Token: 0x0600DB68 RID: 56168 RVA: 0x0033F26C File Offset: 0x0033D46C
			// Note: this type is marked as 'beforefieldinit'.
			static CategoryInfo()
			{
				Il2CppClassPointerStore<MessagesApp.CategoryInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "CategoryInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessagesApp.CategoryInfo>.NativeClassPtr);
				MessagesApp.CategoryInfo.NativeFieldInfoPtr_Category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp.CategoryInfo>.NativeClassPtr, "Category");
				MessagesApp.CategoryInfo.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp.CategoryInfo>.NativeClassPtr, "Name");
				MessagesApp.CategoryInfo.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp.CategoryInfo>.NativeClassPtr, "Color");
				MessagesApp.CategoryInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp.CategoryInfo>.NativeClassPtr, 100682293);
			}

			// Token: 0x0600DB69 RID: 56169 RVA: 0x0033F2E8 File Offset: 0x0033D4E8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CategoryInfo() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessagesApp.CategoryInfo>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.CategoryInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB6A RID: 56170 RVA: 0x0006ADDD File Offset: 0x00068FDD
			public CategoryInfo(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700440C RID: 17420
			// (get) Token: 0x0600DB6B RID: 56171 RVA: 0x0033F324 File Offset: 0x0033D524
			// (set) Token: 0x0600DB6C RID: 56172 RVA: 0x0006ADE6 File Offset: 0x00068FE6
			public unsafe EConversationCategory Category
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.CategoryInfo.NativeFieldInfoPtr_Category);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.CategoryInfo.NativeFieldInfoPtr_Category)) = value;
				}
			}

			// Token: 0x1700440D RID: 17421
			// (get) Token: 0x0600DB6D RID: 56173 RVA: 0x0033F34C File Offset: 0x0033D54C
			// (set) Token: 0x0600DB6E RID: 56174 RVA: 0x0006AE01 File Offset: 0x00069001
			public unsafe string Name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.CategoryInfo.NativeFieldInfoPtr_Name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.CategoryInfo.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700440E RID: 17422
			// (get) Token: 0x0600DB6F RID: 56175 RVA: 0x0033F374 File Offset: 0x0033D574
			// (set) Token: 0x0600DB70 RID: 56176 RVA: 0x0006AE20 File Offset: 0x00069020
			public unsafe Color Color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.CategoryInfo.NativeFieldInfoPtr_Color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.CategoryInfo.NativeFieldInfoPtr_Color)) = value;
				}
			}

			// Token: 0x0400932D RID: 37677
			private static readonly IntPtr NativeFieldInfoPtr_Category;

			// Token: 0x0400932E RID: 37678
			private static readonly IntPtr NativeFieldInfoPtr_Name;

			// Token: 0x0400932F RID: 37679
			private static readonly IntPtr NativeFieldInfoPtr_Color;

			// Token: 0x04009330 RID: 37680
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000B7E RID: 2942
		[ObfuscatedName("ScheduleOne.UI.Phone.Messages.MessagesApp+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DB71 RID: 56177 RVA: 0x0033F39C File Offset: 0x0033D59C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MessagesApp.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessagesApp.__c>.NativeClassPtr);
				MessagesApp.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp.__c>.NativeClassPtr, "<>9");
				MessagesApp.__c.NativeFieldInfoPtr___9__35_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp.__c>.NativeClassPtr, "<>9__35_0");
				MessagesApp.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp.__c>.NativeClassPtr, 100682295);
				MessagesApp.__c.NativeMethodInfoPtr__Loaded_b__35_0_Internal_Int32_MSGConversation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp.__c>.NativeClassPtr, 100682296);
			}

			// Token: 0x0600DB72 RID: 56178 RVA: 0x0033F418 File Offset: 0x0033D618
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessagesApp.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB73 RID: 56179 RVA: 0x0033F454 File Offset: 0x0033D654
			[CallerCount(0)]
			public unsafe int _Loaded_b__35_0(MSGConversation x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.__c.NativeMethodInfoPtr__Loaded_b__35_0_Internal_Int32_MSGConversation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DB74 RID: 56180 RVA: 0x0006AE3B File Offset: 0x0006903B
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700440F RID: 17423
			// (get) Token: 0x0600DB75 RID: 56181 RVA: 0x0033F4A4 File Offset: 0x0033D6A4
			// (set) Token: 0x0600DB76 RID: 56182 RVA: 0x0006AE44 File Offset: 0x00069044
			public unsafe static MessagesApp.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MessagesApp.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessagesApp.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MessagesApp.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004410 RID: 17424
			// (get) Token: 0x0600DB77 RID: 56183 RVA: 0x0033F4CC File Offset: 0x0033D6CC
			// (set) Token: 0x0600DB78 RID: 56184 RVA: 0x0006AE56 File Offset: 0x00069056
			public unsafe static Func<MSGConversation, int> __9__35_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MessagesApp.__c.NativeFieldInfoPtr___9__35_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MSGConversation, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MessagesApp.__c.NativeFieldInfoPtr___9__35_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009331 RID: 37681
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009332 RID: 37682
			private static readonly IntPtr NativeFieldInfoPtr___9__35_0;

			// Token: 0x04009333 RID: 37683
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009334 RID: 37684
			private static readonly IntPtr NativeMethodInfoPtr__Loaded_b__35_0_Internal_Int32_MSGConversation_0;
		}

		// Token: 0x02000B7F RID: 2943
		[ObfuscatedName("ScheduleOne.UI.Phone.Messages.MessagesApp+<>c__DisplayClass43_0")]
		public sealed class __c__DisplayClass43_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DB79 RID: 56185 RVA: 0x0033F4F4 File Offset: 0x0033D6F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass43_0()
			{
				Il2CppClassPointerStore<MessagesApp.__c__DisplayClass43_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "<>c__DisplayClass43_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessagesApp.__c__DisplayClass43_0>.NativeClassPtr);
				MessagesApp.__c__DisplayClass43_0.NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp.__c__DisplayClass43_0>.NativeClassPtr, "category");
				MessagesApp.__c__DisplayClass43_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp.__c__DisplayClass43_0>.NativeClassPtr, 100682297);
				MessagesApp.__c__DisplayClass43_0.NativeMethodInfoPtr__GetCategoryInfo_b__0_Internal_Boolean_CategoryInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp.__c__DisplayClass43_0>.NativeClassPtr, 100682298);
			}

			// Token: 0x0600DB7A RID: 56186 RVA: 0x0033F55C File Offset: 0x0033D75C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass43_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessagesApp.__c__DisplayClass43_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.__c__DisplayClass43_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB7B RID: 56187 RVA: 0x0033F598 File Offset: 0x0033D798
			[CallerCount(0)]
			public unsafe bool _GetCategoryInfo_b__0(MessagesApp.CategoryInfo x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.__c__DisplayClass43_0.NativeMethodInfoPtr__GetCategoryInfo_b__0_Internal_Boolean_CategoryInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DB7C RID: 56188 RVA: 0x0006AE68 File Offset: 0x00069068
			public __c__DisplayClass43_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004411 RID: 17425
			// (get) Token: 0x0600DB7D RID: 56189 RVA: 0x0033F5E8 File Offset: 0x0033D7E8
			// (set) Token: 0x0600DB7E RID: 56190 RVA: 0x0006AE71 File Offset: 0x00069071
			public unsafe EConversationCategory category
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.__c__DisplayClass43_0.NativeFieldInfoPtr_category);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.__c__DisplayClass43_0.NativeFieldInfoPtr_category)) = value;
				}
			}

			// Token: 0x04009335 RID: 37685
			private static readonly IntPtr NativeFieldInfoPtr_category;

			// Token: 0x04009336 RID: 37686
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009337 RID: 37687
			private static readonly IntPtr NativeMethodInfoPtr__GetCategoryInfo_b__0_Internal_Boolean_CategoryInfo_0;
		}
	}
}
