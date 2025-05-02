using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x020003EA RID: 1002
	public class PlayerTeleporter : MonoBehaviour
	{
		// Token: 0x0600522D RID: 21037 RVA: 0x0018549C File Offset: 0x0018369C
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerTeleporter()
		{
			Il2CppClassPointerStore<PlayerTeleporter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "PlayerTeleporter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerTeleporter>.NativeClassPtr);
			PlayerTeleporter.NativeMethodInfoPtr_Teleport_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTeleporter>.NativeClassPtr, 100673586);
			PlayerTeleporter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTeleporter>.NativeClassPtr, 100673587);
		}

		// Token: 0x0600522E RID: 21038 RVA: 0x001854F4 File Offset: 0x001836F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177569, XrefRangeEnd = 177588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Teleport(Transform destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTeleporter.NativeMethodInfoPtr_Teleport_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600522F RID: 21039 RVA: 0x00185538 File Offset: 0x00183738
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerTeleporter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerTeleporter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTeleporter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005230 RID: 21040 RVA: 0x0002720B File Offset: 0x0002540B
		public PlayerTeleporter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040037BE RID: 14270
		private static readonly IntPtr NativeMethodInfoPtr_Teleport_Public_Void_Transform_0;

		// Token: 0x040037BF RID: 14271
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
