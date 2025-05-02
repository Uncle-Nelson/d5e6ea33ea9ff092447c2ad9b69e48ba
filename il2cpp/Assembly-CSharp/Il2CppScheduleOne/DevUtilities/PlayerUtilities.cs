using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000467 RID: 1127
	public static class PlayerUtilities : Object
	{
		// Token: 0x060061BF RID: 25023 RVA: 0x001BD7F0 File Offset: 0x001BB9F0
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerUtilities()
		{
			Il2CppClassPointerStore<PlayerUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "PlayerUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerUtilities>.NativeClassPtr);
			PlayerUtilities.NativeMethodInfoPtr_OpenMenu_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerUtilities>.NativeClassPtr, 100675711);
			PlayerUtilities.NativeMethodInfoPtr_CloseMenu_Public_Static_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerUtilities>.NativeClassPtr, 100675712);
		}

		// Token: 0x060061C0 RID: 25024 RVA: 0x001BD848 File Offset: 0x001BBA48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201364, XrefRangeEnd = 201388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OpenMenu()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerUtilities.NativeMethodInfoPtr_OpenMenu_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061C1 RID: 25025 RVA: 0x001BD870 File Offset: 0x001BBA70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201388, XrefRangeEnd = 201412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CloseMenu(bool reenableLookInstantly = false, bool reenableInventory = true)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref reenableLookInstantly;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reenableInventory;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerUtilities.NativeMethodInfoPtr_CloseMenu_Public_Static_Void_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061C2 RID: 25026 RVA: 0x0002E34A File Offset: 0x0002C54A
		public PlayerUtilities(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040042AB RID: 17067
		private static readonly IntPtr NativeMethodInfoPtr_OpenMenu_Public_Static_Void_0;

		// Token: 0x040042AC RID: 17068
		private static readonly IntPtr NativeMethodInfoPtr_CloseMenu_Public_Static_Void_Boolean_Boolean_0;
	}
}
