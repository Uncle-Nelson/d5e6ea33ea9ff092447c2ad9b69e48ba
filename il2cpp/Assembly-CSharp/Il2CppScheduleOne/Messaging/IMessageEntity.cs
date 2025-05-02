using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Messaging
{
	// Token: 0x02000373 RID: 883
	public class IMessageEntity : Il2CppObjectBase
	{
		// Token: 0x060044D3 RID: 17619 RVA: 0x001538F4 File Offset: 0x00151AF4
		// Note: this type is marked as 'beforefieldinit'.
		static IMessageEntity()
		{
			Il2CppClassPointerStore<IMessageEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Messaging", "IMessageEntity");
			IMessageEntity.NativeMethodInfoPtr_get_MsgConversation_Public_Abstract_Virtual_New_get_MSGConversation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMessageEntity>.NativeClassPtr, 100671698);
			IMessageEntity.NativeMethodInfoPtr_set_MsgConversation_Public_Abstract_Virtual_New_set_Void_MSGConversation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMessageEntity>.NativeClassPtr, 100671699);
			IMessageEntity.NativeMethodInfoPtr_add_onResponseChosen_Public_Abstract_Virtual_New_add_Void_ResponseCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMessageEntity>.NativeClassPtr, 100671700);
			IMessageEntity.NativeMethodInfoPtr_remove_onResponseChosen_Public_Abstract_Virtual_New_rem_Void_ResponseCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMessageEntity>.NativeClassPtr, 100671701);
		}

		// Token: 0x170014CD RID: 5325
		// (get) Token: 0x060044D4 RID: 17620 RVA: 0x0015396C File Offset: 0x00151B6C
		// (set) Token: 0x060044D5 RID: 17621 RVA: 0x001539B8 File Offset: 0x00151BB8
		public unsafe virtual MSGConversation MsgConversation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMessageEntity.NativeMethodInfoPtr_get_MsgConversation_Public_Abstract_Virtual_New_get_MSGConversation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MSGConversation>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMessageEntity.NativeMethodInfoPtr_set_MsgConversation_Public_Abstract_Virtual_New_set_Void_MSGConversation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060044D6 RID: 17622 RVA: 0x00153A08 File Offset: 0x00151C08
		[CallerCount(0)]
		public unsafe virtual void add_onResponseChosen(ResponseCallback value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMessageEntity.NativeMethodInfoPtr_add_onResponseChosen_Public_Abstract_Virtual_New_add_Void_ResponseCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044D7 RID: 17623 RVA: 0x00153A58 File Offset: 0x00151C58
		[CallerCount(0)]
		public unsafe virtual void remove_onResponseChosen(ResponseCallback value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMessageEntity.NativeMethodInfoPtr_remove_onResponseChosen_Public_Abstract_Virtual_New_rem_Void_ResponseCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044D8 RID: 17624 RVA: 0x000219A4 File Offset: 0x0001FBA4
		public IMessageEntity(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04002E18 RID: 11800
		private static readonly IntPtr NativeMethodInfoPtr_get_MsgConversation_Public_Abstract_Virtual_New_get_MSGConversation_0;

		// Token: 0x04002E19 RID: 11801
		private static readonly IntPtr NativeMethodInfoPtr_set_MsgConversation_Public_Abstract_Virtual_New_set_Void_MSGConversation_0;

		// Token: 0x04002E1A RID: 11802
		private static readonly IntPtr NativeMethodInfoPtr_add_onResponseChosen_Public_Abstract_Virtual_New_add_Void_ResponseCallback_0;

		// Token: 0x04002E1B RID: 11803
		private static readonly IntPtr NativeMethodInfoPtr_remove_onResponseChosen_Public_Abstract_Virtual_New_rem_Void_ResponseCallback_0;
	}
}
