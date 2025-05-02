using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x0200039D RID: 925
	public class IUsable : Il2CppObjectBase
	{
		// Token: 0x06004892 RID: 18578 RVA: 0x00162FE8 File Offset: 0x001611E8
		// Note: this type is marked as 'beforefieldinit'.
		static IUsable()
		{
			Il2CppClassPointerStore<IUsable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "IUsable");
			IUsable.NativeMethodInfoPtr_get_IsInUse_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUsable>.NativeClassPtr, 100672288);
			IUsable.NativeMethodInfoPtr_get_NPCUserObject_Public_Abstract_Virtual_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUsable>.NativeClassPtr, 100672289);
			IUsable.NativeMethodInfoPtr_set_NPCUserObject_Public_Abstract_Virtual_New_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUsable>.NativeClassPtr, 100672290);
			IUsable.NativeMethodInfoPtr_get_PlayerUserObject_Public_Abstract_Virtual_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUsable>.NativeClassPtr, 100672291);
			IUsable.NativeMethodInfoPtr_set_PlayerUserObject_Public_Abstract_Virtual_New_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUsable>.NativeClassPtr, 100672292);
			IUsable.NativeMethodInfoPtr_SetPlayerUser_Public_Abstract_Virtual_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUsable>.NativeClassPtr, 100672293);
			IUsable.NativeMethodInfoPtr_SetNPCUser_Public_Abstract_Virtual_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUsable>.NativeClassPtr, 100672294);
		}

		// Token: 0x170015C7 RID: 5575
		// (get) Token: 0x06004893 RID: 18579 RVA: 0x0016309C File Offset: 0x0016129C
		public unsafe virtual bool IsInUse
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162524, XrefRangeEnd = 162531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUsable.NativeMethodInfoPtr_get_IsInUse_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170015C8 RID: 5576
		// (get) Token: 0x06004894 RID: 18580 RVA: 0x001630E4 File Offset: 0x001612E4
		// (set) Token: 0x06004895 RID: 18581 RVA: 0x00163130 File Offset: 0x00161330
		public unsafe virtual NetworkObject NPCUserObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUsable.NativeMethodInfoPtr_get_NPCUserObject_Public_Abstract_Virtual_New_get_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUsable.NativeMethodInfoPtr_set_NPCUserObject_Public_Abstract_Virtual_New_set_Void_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015C9 RID: 5577
		// (get) Token: 0x06004896 RID: 18582 RVA: 0x00163180 File Offset: 0x00161380
		// (set) Token: 0x06004897 RID: 18583 RVA: 0x001631CC File Offset: 0x001613CC
		public unsafe virtual NetworkObject PlayerUserObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUsable.NativeMethodInfoPtr_get_PlayerUserObject_Public_Abstract_Virtual_New_get_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUsable.NativeMethodInfoPtr_set_PlayerUserObject_Public_Abstract_Virtual_New_set_Void_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004898 RID: 18584 RVA: 0x0016321C File Offset: 0x0016141C
		[CallerCount(0)]
		public unsafe virtual void SetPlayerUser(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUsable.NativeMethodInfoPtr_SetPlayerUser_Public_Abstract_Virtual_New_Void_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004899 RID: 18585 RVA: 0x0016326C File Offset: 0x0016146C
		[CallerCount(0)]
		public unsafe virtual void SetNPCUser(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUsable.NativeMethodInfoPtr_SetNPCUser_Public_Abstract_Virtual_New_Void_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600489A RID: 18586 RVA: 0x00023012 File Offset: 0x00021212
		public IUsable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040030F3 RID: 12531
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInUse_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040030F4 RID: 12532
		private static readonly IntPtr NativeMethodInfoPtr_get_NPCUserObject_Public_Abstract_Virtual_New_get_NetworkObject_0;

		// Token: 0x040030F5 RID: 12533
		private static readonly IntPtr NativeMethodInfoPtr_set_NPCUserObject_Public_Abstract_Virtual_New_set_Void_NetworkObject_0;

		// Token: 0x040030F6 RID: 12534
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerUserObject_Public_Abstract_Virtual_New_get_NetworkObject_0;

		// Token: 0x040030F7 RID: 12535
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayerUserObject_Public_Abstract_Virtual_New_set_Void_NetworkObject_0;

		// Token: 0x040030F8 RID: 12536
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayerUser_Public_Abstract_Virtual_New_Void_NetworkObject_0;

		// Token: 0x040030F9 RID: 12537
		private static readonly IntPtr NativeMethodInfoPtr_SetNPCUser_Public_Abstract_Virtual_New_Void_NetworkObject_0;
	}
}
