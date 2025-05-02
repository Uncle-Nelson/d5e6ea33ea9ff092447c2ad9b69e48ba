using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppScheduleOne.Combat
{
	// Token: 0x02000493 RID: 1171
	public class IDamageable : Il2CppObjectBase
	{
		// Token: 0x06006546 RID: 25926 RVA: 0x001C94C0 File Offset: 0x001C76C0
		// Note: this type is marked as 'beforefieldinit'.
		static IDamageable()
		{
			Il2CppClassPointerStore<IDamageable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Combat", "IDamageable");
			IDamageable.NativeMethodInfoPtr_SendImpact_Public_Abstract_Virtual_New_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDamageable>.NativeClassPtr, 100676115);
			IDamageable.NativeMethodInfoPtr_ReceiveImpact_Public_Abstract_Virtual_New_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDamageable>.NativeClassPtr, 100676116);
		}

		// Token: 0x06006547 RID: 25927 RVA: 0x001C9510 File Offset: 0x001C7710
		[CallerCount(0)]
		public unsafe virtual void SendImpact(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDamageable.NativeMethodInfoPtr_SendImpact_Public_Abstract_Virtual_New_Void_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006548 RID: 25928 RVA: 0x001C9560 File Offset: 0x001C7760
		[CallerCount(0)]
		public unsafe virtual void ReceiveImpact(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDamageable.NativeMethodInfoPtr_ReceiveImpact_Public_Abstract_Virtual_New_Void_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006549 RID: 25929 RVA: 0x0002FE50 File Offset: 0x0002E050
		public IDamageable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400451C RID: 17692
		private static readonly IntPtr NativeMethodInfoPtr_SendImpact_Public_Abstract_Virtual_New_Void_Impact_0;

		// Token: 0x0400451D RID: 17693
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveImpact_Public_Abstract_Virtual_New_Void_Impact_0;
	}
}
