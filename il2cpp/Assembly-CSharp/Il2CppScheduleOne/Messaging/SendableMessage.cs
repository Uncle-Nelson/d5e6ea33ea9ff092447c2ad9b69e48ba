using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Messaging
{
	// Token: 0x02000378 RID: 888
	public class SendableMessage : Object
	{
		// Token: 0x060045B6 RID: 17846 RVA: 0x001575E0 File Offset: 0x001557E0
		// Note: this type is marked as 'beforefieldinit'.
		static SendableMessage()
		{
			Il2CppClassPointerStore<SendableMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Messaging", "SendableMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr);
			SendableMessage.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, "Text");
			SendableMessage.NativeFieldInfoPtr_ShouldShowCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, "ShouldShowCheck");
			SendableMessage.NativeFieldInfoPtr_IsValidCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, "IsValidCheck");
			SendableMessage.NativeFieldInfoPtr_onSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, "onSelected");
			SendableMessage.NativeFieldInfoPtr_onSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, "onSent");
			SendableMessage.NativeFieldInfoPtr_conversation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, "conversation");
			SendableMessage.NativeFieldInfoPtr_disableDefaultSendBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, "disableDefaultSendBehaviour");
			SendableMessage.NativeFieldInfoPtr_sentIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, "sentIDs");
			SendableMessage.NativeMethodInfoPtr__ctor_Public_Void_String_MSGConversation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, 100671866);
			SendableMessage.NativeMethodInfoPtr_ShouldShow_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, 100671867);
			SendableMessage.NativeMethodInfoPtr_IsValid_Public_Virtual_New_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, 100671868);
			SendableMessage.NativeMethodInfoPtr_Send_Public_Virtual_New_Void_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, 100671869);
		}

		// Token: 0x060045B7 RID: 17847 RVA: 0x00157700 File Offset: 0x00155900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157687, XrefRangeEnd = 157697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SendableMessage(string text, MSGConversation conversation) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conversation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendableMessage.NativeMethodInfoPtr__ctor_Public_Void_String_MSGConversation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045B8 RID: 17848 RVA: 0x00157760 File Offset: 0x00155960
		[CallerCount(0)]
		public unsafe virtual bool ShouldShow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SendableMessage.NativeMethodInfoPtr_ShouldShow_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060045B9 RID: 17849 RVA: 0x001577A8 File Offset: 0x001559A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157697, XrefRangeEnd = 157701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsValid(out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SendableMessage.NativeMethodInfoPtr_IsValid_Public_Virtual_New_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060045BA RID: 17850 RVA: 0x0015780C File Offset: 0x00155A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157701, XrefRangeEnd = 157717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Send(bool network, int id = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref network;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SendableMessage.NativeMethodInfoPtr_Send_Public_Virtual_New_Void_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045BB RID: 17851 RVA: 0x00021EFB File Offset: 0x000200FB
		public SendableMessage(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001508 RID: 5384
		// (get) Token: 0x060045BC RID: 17852 RVA: 0x00157864 File Offset: 0x00155A64
		// (set) Token: 0x060045BD RID: 17853 RVA: 0x00021F04 File Offset: 0x00020104
		public unsafe string Text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_Text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_Text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001509 RID: 5385
		// (get) Token: 0x060045BE RID: 17854 RVA: 0x0015788C File Offset: 0x00155A8C
		// (set) Token: 0x060045BF RID: 17855 RVA: 0x00021F23 File Offset: 0x00020123
		public unsafe SendableMessage.BoolCheck ShouldShowCheck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_ShouldShowCheck);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SendableMessage.BoolCheck>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_ShouldShowCheck), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700150A RID: 5386
		// (get) Token: 0x060045C0 RID: 17856 RVA: 0x001578BC File Offset: 0x00155ABC
		// (set) Token: 0x060045C1 RID: 17857 RVA: 0x00021F42 File Offset: 0x00020142
		public unsafe SendableMessage.ValidityCheck IsValidCheck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_IsValidCheck);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SendableMessage.ValidityCheck>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_IsValidCheck), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700150B RID: 5387
		// (get) Token: 0x060045C2 RID: 17858 RVA: 0x001578EC File Offset: 0x00155AEC
		// (set) Token: 0x060045C3 RID: 17859 RVA: 0x00021F61 File Offset: 0x00020161
		public unsafe Action onSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_onSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_onSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700150C RID: 5388
		// (get) Token: 0x060045C4 RID: 17860 RVA: 0x0015791C File Offset: 0x00155B1C
		// (set) Token: 0x060045C5 RID: 17861 RVA: 0x00021F80 File Offset: 0x00020180
		public unsafe Action onSent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_onSent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_onSent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700150D RID: 5389
		// (get) Token: 0x060045C6 RID: 17862 RVA: 0x0015794C File Offset: 0x00155B4C
		// (set) Token: 0x060045C7 RID: 17863 RVA: 0x00021F9F File Offset: 0x0002019F
		public unsafe MSGConversation conversation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_conversation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_conversation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700150E RID: 5390
		// (get) Token: 0x060045C8 RID: 17864 RVA: 0x0015797C File Offset: 0x00155B7C
		// (set) Token: 0x060045C9 RID: 17865 RVA: 0x00021FBE File Offset: 0x000201BE
		public unsafe bool disableDefaultSendBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_disableDefaultSendBehaviour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_disableDefaultSendBehaviour)) = value;
			}
		}

		// Token: 0x1700150F RID: 5391
		// (get) Token: 0x060045CA RID: 17866 RVA: 0x001579A4 File Offset: 0x00155BA4
		// (set) Token: 0x060045CB RID: 17867 RVA: 0x00021FD9 File Offset: 0x000201D9
		public unsafe List<int> sentIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_sentIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_sentIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002EC4 RID: 11972
		private static readonly IntPtr NativeFieldInfoPtr_Text;

		// Token: 0x04002EC5 RID: 11973
		private static readonly IntPtr NativeFieldInfoPtr_ShouldShowCheck;

		// Token: 0x04002EC6 RID: 11974
		private static readonly IntPtr NativeFieldInfoPtr_IsValidCheck;

		// Token: 0x04002EC7 RID: 11975
		private static readonly IntPtr NativeFieldInfoPtr_onSelected;

		// Token: 0x04002EC8 RID: 11976
		private static readonly IntPtr NativeFieldInfoPtr_onSent;

		// Token: 0x04002EC9 RID: 11977
		private static readonly IntPtr NativeFieldInfoPtr_conversation;

		// Token: 0x04002ECA RID: 11978
		private static readonly IntPtr NativeFieldInfoPtr_disableDefaultSendBehaviour;

		// Token: 0x04002ECB RID: 11979
		private static readonly IntPtr NativeFieldInfoPtr_sentIDs;

		// Token: 0x04002ECC RID: 11980
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_MSGConversation_0;

		// Token: 0x04002ECD RID: 11981
		private static readonly IntPtr NativeMethodInfoPtr_ShouldShow_Public_Virtual_New_Boolean_0;

		// Token: 0x04002ECE RID: 11982
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Virtual_New_Boolean_byref_String_0;

		// Token: 0x04002ECF RID: 11983
		private static readonly IntPtr NativeMethodInfoPtr_Send_Public_Virtual_New_Void_Boolean_Int32_0;

		// Token: 0x02000973 RID: 2419
		public sealed class BoolCheck : MulticastDelegate
		{
			// Token: 0x0600C9A9 RID: 51625 RVA: 0x0030CF4C File Offset: 0x0030B14C
			// Note: this type is marked as 'beforefieldinit'.
			static BoolCheck()
			{
				Il2CppClassPointerStore<SendableMessage.BoolCheck>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, "BoolCheck");
				SendableMessage.BoolCheck.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendableMessage.BoolCheck>.NativeClassPtr, 100671870);
				SendableMessage.BoolCheck.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_SendableMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendableMessage.BoolCheck>.NativeClassPtr, 100671871);
				SendableMessage.BoolCheck.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_SendableMessage_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendableMessage.BoolCheck>.NativeClassPtr, 100671872);
				SendableMessage.BoolCheck.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendableMessage.BoolCheck>.NativeClassPtr, 100671873);
			}

			// Token: 0x0600C9AA RID: 51626 RVA: 0x0030CFC0 File Offset: 0x0030B1C0
			[CallerCount(479)]
			[CachedScanResults(RefRangeStart = 135199, RefRangeEnd = 135678, XrefRangeStart = 135199, XrefRangeEnd = 135678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BoolCheck(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SendableMessage.BoolCheck>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendableMessage.BoolCheck.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C9AB RID: 51627 RVA: 0x0030D01C File Offset: 0x0030B21C
			[CallerCount(0)]
			public unsafe bool Invoke(SendableMessage message)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendableMessage.BoolCheck.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_SendableMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C9AC RID: 51628 RVA: 0x0030D06C File Offset: 0x0030B26C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 74827, RefRangeEnd = 74828, XrefRangeStart = 74827, XrefRangeEnd = 74828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(SendableMessage message, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendableMessage.BoolCheck.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_SendableMessage_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600C9AD RID: 51629 RVA: 0x0030D0E0 File Offset: 0x0030B2E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendableMessage.BoolCheck.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C9AE RID: 51630 RVA: 0x0006214C File Offset: 0x0006034C
			public BoolCheck(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600C9AF RID: 51631 RVA: 0x00062155 File Offset: 0x00060355
			public static implicit operator SendableMessage.BoolCheck(Func<SendableMessage, bool> A_0)
			{
				return DelegateSupport.ConvertDelegate<SendableMessage.BoolCheck>(A_0);
			}

			// Token: 0x0600C9B0 RID: 51632 RVA: 0x0006215D File Offset: 0x0006035D
			public static SendableMessage.BoolCheck operator +(SendableMessage.BoolCheck A_0, SendableMessage.BoolCheck A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<SendableMessage.BoolCheck>();
			}

			// Token: 0x0600C9B1 RID: 51633 RVA: 0x0006216B File Offset: 0x0006036B
			public static SendableMessage.BoolCheck operator -(SendableMessage.BoolCheck A_0, SendableMessage.BoolCheck A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<SendableMessage.BoolCheck>();
				}
				return result;
			}

			// Token: 0x0400887A RID: 34938
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400887B RID: 34939
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_SendableMessage_0;

			// Token: 0x0400887C RID: 34940
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_SendableMessage_AsyncCallback_Object_0;

			// Token: 0x0400887D RID: 34941
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0;
		}

		// Token: 0x02000974 RID: 2420
		public sealed class ValidityCheck : MulticastDelegate
		{
			// Token: 0x0600C9B2 RID: 51634 RVA: 0x0030D130 File Offset: 0x0030B330
			// Note: this type is marked as 'beforefieldinit'.
			static ValidityCheck()
			{
				Il2CppClassPointerStore<SendableMessage.ValidityCheck>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, "ValidityCheck");
				SendableMessage.ValidityCheck.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendableMessage.ValidityCheck>.NativeClassPtr, 100671874);
				SendableMessage.ValidityCheck.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_SendableMessage_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendableMessage.ValidityCheck>.NativeClassPtr, 100671875);
				SendableMessage.ValidityCheck.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_SendableMessage_byref_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendableMessage.ValidityCheck>.NativeClassPtr, 100671876);
				SendableMessage.ValidityCheck.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_String_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendableMessage.ValidityCheck>.NativeClassPtr, 100671877);
			}

			// Token: 0x0600C9B3 RID: 51635 RVA: 0x0030D1A4 File Offset: 0x0030B3A4
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 157681, RefRangeEnd = 157684, XrefRangeStart = 157672, XrefRangeEnd = 157681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValidityCheck(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SendableMessage.ValidityCheck>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendableMessage.ValidityCheck.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C9B4 RID: 51636 RVA: 0x0030D200 File Offset: 0x0030B400
			[CallerCount(0)]
			public unsafe bool Invoke(SendableMessage message, out string invalidReason)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SendableMessage.ValidityCheck.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_SendableMessage_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x0600C9B5 RID: 51637 RVA: 0x0030D268 File Offset: 0x0030B468
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157684, XrefRangeEnd = 157685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(SendableMessage message, out string invalidReason, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SendableMessage.ValidityCheck.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_SendableMessage_byref_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr4) : null;
			}

			// Token: 0x0600C9B6 RID: 51638 RVA: 0x0030D2F8 File Offset: 0x0030B4F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157685, XrefRangeEnd = 157687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool EndInvoke(out string invalidReason, IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SendableMessage.ValidityCheck.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_String_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x0600C9B7 RID: 51639 RVA: 0x0006217C File Offset: 0x0006037C
			public ValidityCheck(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400887E RID: 34942
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400887F RID: 34943
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_SendableMessage_byref_String_0;

			// Token: 0x04008880 RID: 34944
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_SendableMessage_byref_String_AsyncCallback_Object_0;

			// Token: 0x04008881 RID: 34945
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_String_IAsyncResult_0;
		}
	}
}
