using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Messaging;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.Messages
{
	// Token: 0x020006B3 RID: 1715
	public class MessageSenderInterface : MonoBehaviour
	{
		// Token: 0x06009A75 RID: 39541 RVA: 0x0027443C File Offset: 0x0027263C
		// Note: this type is marked as 'beforefieldinit'.
		static MessageSenderInterface()
		{
			Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Messages", "MessageSenderInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr);
			MessageSenderInterface.NativeFieldInfoPtr_Visibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "Visibility");
			MessageSenderInterface.NativeFieldInfoPtr_DockedMenuYPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "DockedMenuYPos");
			MessageSenderInterface.NativeFieldInfoPtr_ExpandedMenuYPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "ExpandedMenuYPos");
			MessageSenderInterface.NativeFieldInfoPtr_Menu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "Menu");
			MessageSenderInterface.NativeFieldInfoPtr_SendablesContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "SendablesContainer");
			MessageSenderInterface.NativeFieldInfoPtr_DockedUIElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "DockedUIElements");
			MessageSenderInterface.NativeFieldInfoPtr_ExpandedUIElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "ExpandedUIElements");
			MessageSenderInterface.NativeFieldInfoPtr_ComposeButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "ComposeButton");
			MessageSenderInterface.NativeFieldInfoPtr_CancelButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "CancelButtons");
			MessageSenderInterface.NativeFieldInfoPtr_sendableBubbles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "sendableBubbles");
			MessageSenderInterface.NativeFieldInfoPtr_sendableMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "sendableMap");
			MessageSenderInterface.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, 100682299);
			MessageSenderInterface.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, 100682300);
			MessageSenderInterface.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, 100682301);
			MessageSenderInterface.NativeMethodInfoPtr_SetVisibility_Public_Void_EVisibility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, 100682302);
			MessageSenderInterface.NativeMethodInfoPtr_UpdateSendables_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, 100682303);
			MessageSenderInterface.NativeMethodInfoPtr_AddSendable_Public_Void_SendableMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, 100682304);
			MessageSenderInterface.NativeMethodInfoPtr_SendableSelected_Protected_Virtual_New_Void_SendableMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, 100682305);
			MessageSenderInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, 100682306);
			MessageSenderInterface.NativeMethodInfoPtr__Awake_b__12_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, 100682307);
			MessageSenderInterface.NativeMethodInfoPtr__Awake_b__12_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, 100682308);
		}

		// Token: 0x06009A76 RID: 39542 RVA: 0x00274610 File Offset: 0x00272810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274872, XrefRangeEnd = 274887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageSenderInterface.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A77 RID: 39543 RVA: 0x00274644 File Offset: 0x00272844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274887, XrefRangeEnd = 274897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageSenderInterface.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A78 RID: 39544 RVA: 0x00274678 File Offset: 0x00272878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274897, XrefRangeEnd = 274899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction exit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exit);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageSenderInterface.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A79 RID: 39545 RVA: 0x002746BC File Offset: 0x002728BC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 274917, RefRangeEnd = 274923, XrefRangeStart = 274899, XrefRangeEnd = 274917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisibility(MessageSenderInterface.EVisibility visibility)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visibility;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageSenderInterface.NativeMethodInfoPtr_SetVisibility_Public_Void_EVisibility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A7A RID: 39546 RVA: 0x002746FC File Offset: 0x002728FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 274945, RefRangeEnd = 274947, XrefRangeStart = 274923, XrefRangeEnd = 274945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSendables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageSenderInterface.NativeMethodInfoPtr_UpdateSendables_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A7B RID: 39547 RVA: 0x00274730 File Offset: 0x00272930
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 274985, RefRangeEnd = 274987, XrefRangeStart = 274947, XrefRangeEnd = 274985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSendable(SendableMessage sendable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sendable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageSenderInterface.NativeMethodInfoPtr_AddSendable_Public_Void_SendableMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A7C RID: 39548 RVA: 0x00274774 File Offset: 0x00272974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274987, XrefRangeEnd = 274989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendableSelected(SendableMessage sendable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sendable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessageSenderInterface.NativeMethodInfoPtr_SendableSelected_Protected_Virtual_New_Void_SendableMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A7D RID: 39549 RVA: 0x002747C4 File Offset: 0x002729C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274989, XrefRangeEnd = 275004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageSenderInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageSenderInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A7E RID: 39550 RVA: 0x00274800 File Offset: 0x00272A00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275004, XrefRangeEnd = 275005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__12_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageSenderInterface.NativeMethodInfoPtr__Awake_b__12_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A7F RID: 39551 RVA: 0x00274834 File Offset: 0x00272A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275005, XrefRangeEnd = 275006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__12_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageSenderInterface.NativeMethodInfoPtr__Awake_b__12_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A80 RID: 39552 RVA: 0x0004B7F8 File Offset: 0x000499F8
		public MessageSenderInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002F88 RID: 12168
		// (get) Token: 0x06009A81 RID: 39553 RVA: 0x00274868 File Offset: 0x00272A68
		// (set) Token: 0x06009A82 RID: 39554 RVA: 0x0004B801 File Offset: 0x00049A01
		public unsafe MessageSenderInterface.EVisibility Visibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_Visibility);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_Visibility)) = value;
			}
		}

		// Token: 0x17002F89 RID: 12169
		// (get) Token: 0x06009A83 RID: 39555 RVA: 0x00274890 File Offset: 0x00272A90
		// (set) Token: 0x06009A84 RID: 39556 RVA: 0x0004B81C File Offset: 0x00049A1C
		public unsafe float DockedMenuYPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_DockedMenuYPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_DockedMenuYPos)) = value;
			}
		}

		// Token: 0x17002F8A RID: 12170
		// (get) Token: 0x06009A85 RID: 39557 RVA: 0x002748B8 File Offset: 0x00272AB8
		// (set) Token: 0x06009A86 RID: 39558 RVA: 0x0004B837 File Offset: 0x00049A37
		public unsafe float ExpandedMenuYPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_ExpandedMenuYPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_ExpandedMenuYPos)) = value;
			}
		}

		// Token: 0x17002F8B RID: 12171
		// (get) Token: 0x06009A87 RID: 39559 RVA: 0x002748E0 File Offset: 0x00272AE0
		// (set) Token: 0x06009A88 RID: 39560 RVA: 0x0004B852 File Offset: 0x00049A52
		public unsafe RectTransform Menu
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_Menu);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_Menu), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F8C RID: 12172
		// (get) Token: 0x06009A89 RID: 39561 RVA: 0x00274910 File Offset: 0x00272B10
		// (set) Token: 0x06009A8A RID: 39562 RVA: 0x0004B871 File Offset: 0x00049A71
		public unsafe RectTransform SendablesContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_SendablesContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_SendablesContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F8D RID: 12173
		// (get) Token: 0x06009A8B RID: 39563 RVA: 0x00274940 File Offset: 0x00272B40
		// (set) Token: 0x06009A8C RID: 39564 RVA: 0x0004B890 File Offset: 0x00049A90
		public unsafe Il2CppReferenceArray<RectTransform> DockedUIElements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_DockedUIElements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_DockedUIElements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F8E RID: 12174
		// (get) Token: 0x06009A8D RID: 39565 RVA: 0x00274970 File Offset: 0x00272B70
		// (set) Token: 0x06009A8E RID: 39566 RVA: 0x0004B8AF File Offset: 0x00049AAF
		public unsafe Il2CppReferenceArray<RectTransform> ExpandedUIElements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_ExpandedUIElements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_ExpandedUIElements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F8F RID: 12175
		// (get) Token: 0x06009A8F RID: 39567 RVA: 0x002749A0 File Offset: 0x00272BA0
		// (set) Token: 0x06009A90 RID: 39568 RVA: 0x0004B8CE File Offset: 0x00049ACE
		public unsafe Button ComposeButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_ComposeButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_ComposeButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F90 RID: 12176
		// (get) Token: 0x06009A91 RID: 39569 RVA: 0x002749D0 File Offset: 0x00272BD0
		// (set) Token: 0x06009A92 RID: 39570 RVA: 0x0004B8ED File Offset: 0x00049AED
		public unsafe Il2CppReferenceArray<Button> CancelButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_CancelButtons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Button>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_CancelButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F91 RID: 12177
		// (get) Token: 0x06009A93 RID: 39571 RVA: 0x00274A00 File Offset: 0x00272C00
		// (set) Token: 0x06009A94 RID: 39572 RVA: 0x0004B90C File Offset: 0x00049B0C
		public unsafe List<MessageBubble> sendableBubbles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_sendableBubbles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MessageBubble>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_sendableBubbles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F92 RID: 12178
		// (get) Token: 0x06009A95 RID: 39573 RVA: 0x00274A30 File Offset: 0x00272C30
		// (set) Token: 0x06009A96 RID: 39574 RVA: 0x0004B92B File Offset: 0x00049B2B
		public unsafe Dictionary<MessageBubble, SendableMessage> sendableMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_sendableMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<MessageBubble, SendableMessage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_sendableMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040067E8 RID: 26600
		private static readonly IntPtr NativeFieldInfoPtr_Visibility;

		// Token: 0x040067E9 RID: 26601
		private static readonly IntPtr NativeFieldInfoPtr_DockedMenuYPos;

		// Token: 0x040067EA RID: 26602
		private static readonly IntPtr NativeFieldInfoPtr_ExpandedMenuYPos;

		// Token: 0x040067EB RID: 26603
		private static readonly IntPtr NativeFieldInfoPtr_Menu;

		// Token: 0x040067EC RID: 26604
		private static readonly IntPtr NativeFieldInfoPtr_SendablesContainer;

		// Token: 0x040067ED RID: 26605
		private static readonly IntPtr NativeFieldInfoPtr_DockedUIElements;

		// Token: 0x040067EE RID: 26606
		private static readonly IntPtr NativeFieldInfoPtr_ExpandedUIElements;

		// Token: 0x040067EF RID: 26607
		private static readonly IntPtr NativeFieldInfoPtr_ComposeButton;

		// Token: 0x040067F0 RID: 26608
		private static readonly IntPtr NativeFieldInfoPtr_CancelButtons;

		// Token: 0x040067F1 RID: 26609
		private static readonly IntPtr NativeFieldInfoPtr_sendableBubbles;

		// Token: 0x040067F2 RID: 26610
		private static readonly IntPtr NativeFieldInfoPtr_sendableMap;

		// Token: 0x040067F3 RID: 26611
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x040067F4 RID: 26612
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040067F5 RID: 26613
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x040067F6 RID: 26614
		private static readonly IntPtr NativeMethodInfoPtr_SetVisibility_Public_Void_EVisibility_0;

		// Token: 0x040067F7 RID: 26615
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSendables_Public_Void_0;

		// Token: 0x040067F8 RID: 26616
		private static readonly IntPtr NativeMethodInfoPtr_AddSendable_Public_Void_SendableMessage_0;

		// Token: 0x040067F9 RID: 26617
		private static readonly IntPtr NativeMethodInfoPtr_SendableSelected_Protected_Virtual_New_Void_SendableMessage_0;

		// Token: 0x040067FA RID: 26618
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040067FB RID: 26619
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__12_0_Private_Void_0;

		// Token: 0x040067FC RID: 26620
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__12_1_Private_Void_0;

		// Token: 0x02000B80 RID: 2944
		[OriginalName("Assembly-CSharp.dll", "", "EVisibility")]
		public enum EVisibility
		{
			// Token: 0x04009339 RID: 37689
			Hidden,
			// Token: 0x0400933A RID: 37690
			Docked,
			// Token: 0x0400933B RID: 37691
			Expanded
		}

		// Token: 0x02000B81 RID: 2945
		[ObfuscatedName("ScheduleOne.UI.Phone.Messages.MessageSenderInterface+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DB7F RID: 56191 RVA: 0x0033F610 File Offset: 0x0033D810
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<MessageSenderInterface.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageSenderInterface.__c__DisplayClass17_0>.NativeClassPtr);
				MessageSenderInterface.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface.__c__DisplayClass17_0>.NativeClassPtr, "<>4__this");
				MessageSenderInterface.__c__DisplayClass17_0.NativeFieldInfoPtr_sendable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface.__c__DisplayClass17_0>.NativeClassPtr, "sendable");
				MessageSenderInterface.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface.__c__DisplayClass17_0>.NativeClassPtr, 100682309);
				MessageSenderInterface.__c__DisplayClass17_0.NativeMethodInfoPtr__AddSendable_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface.__c__DisplayClass17_0>.NativeClassPtr, 100682310);
			}

			// Token: 0x0600DB80 RID: 56192 RVA: 0x0033F68C File Offset: 0x0033D88C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageSenderInterface.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageSenderInterface.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB81 RID: 56193 RVA: 0x0033F6C8 File Offset: 0x0033D8C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274871, XrefRangeEnd = 274872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _AddSendable_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageSenderInterface.__c__DisplayClass17_0.NativeMethodInfoPtr__AddSendable_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB82 RID: 56194 RVA: 0x0006AE8C File Offset: 0x0006908C
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004412 RID: 17426
			// (get) Token: 0x0600DB83 RID: 56195 RVA: 0x0033F6FC File Offset: 0x0033D8FC
			// (set) Token: 0x0600DB84 RID: 56196 RVA: 0x0006AE95 File Offset: 0x00069095
			public unsafe MessageSenderInterface __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessageSenderInterface>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004413 RID: 17427
			// (get) Token: 0x0600DB85 RID: 56197 RVA: 0x0033F72C File Offset: 0x0033D92C
			// (set) Token: 0x0600DB86 RID: 56198 RVA: 0x0006AEB4 File Offset: 0x000690B4
			public unsafe SendableMessage sendable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.__c__DisplayClass17_0.NativeFieldInfoPtr_sendable);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SendableMessage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.__c__DisplayClass17_0.NativeFieldInfoPtr_sendable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400933C RID: 37692
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400933D RID: 37693
			private static readonly IntPtr NativeFieldInfoPtr_sendable;

			// Token: 0x0400933E RID: 37694
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400933F RID: 37695
			private static readonly IntPtr NativeMethodInfoPtr__AddSendable_b__0_Internal_Void_0;
		}
	}
}
