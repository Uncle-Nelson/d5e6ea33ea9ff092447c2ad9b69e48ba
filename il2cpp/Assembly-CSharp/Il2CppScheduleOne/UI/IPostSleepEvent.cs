using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000659 RID: 1625
	public class IPostSleepEvent : Il2CppObjectBase
	{
		// Token: 0x06009119 RID: 37145 RVA: 0x00258404 File Offset: 0x00256604
		// Note: this type is marked as 'beforefieldinit'.
		static IPostSleepEvent()
		{
			Il2CppClassPointerStore<IPostSleepEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "IPostSleepEvent");
			IPostSleepEvent.NativeMethodInfoPtr_get_IsRunning_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPostSleepEvent>.NativeClassPtr, 100681268);
			IPostSleepEvent.NativeMethodInfoPtr_get_Order_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPostSleepEvent>.NativeClassPtr, 100681269);
			IPostSleepEvent.NativeMethodInfoPtr_StartEvent_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPostSleepEvent>.NativeClassPtr, 100681270);
		}

		// Token: 0x17002C74 RID: 11380
		// (get) Token: 0x0600911A RID: 37146 RVA: 0x00258468 File Offset: 0x00256668
		public unsafe virtual bool IsRunning
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPostSleepEvent.NativeMethodInfoPtr_get_IsRunning_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002C75 RID: 11381
		// (get) Token: 0x0600911B RID: 37147 RVA: 0x002584B0 File Offset: 0x002566B0
		public unsafe virtual int Order
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPostSleepEvent.NativeMethodInfoPtr_get_Order_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600911C RID: 37148 RVA: 0x002584F8 File Offset: 0x002566F8
		[CallerCount(0)]
		public unsafe virtual void StartEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPostSleepEvent.NativeMethodInfoPtr_StartEvent_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600911D RID: 37149 RVA: 0x00046205 File Offset: 0x00044405
		public IPostSleepEvent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04006215 RID: 25109
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRunning_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04006216 RID: 25110
		private static readonly IntPtr NativeMethodInfoPtr_get_Order_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04006217 RID: 25111
		private static readonly IntPtr NativeMethodInfoPtr_StartEvent_Public_Abstract_Virtual_New_Void_0;
	}
}
