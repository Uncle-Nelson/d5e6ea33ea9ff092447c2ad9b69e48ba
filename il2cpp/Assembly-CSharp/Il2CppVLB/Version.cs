using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppVLB
{
	// Token: 0x020000B6 RID: 182
	public static class Version : Object
	{
		// Token: 0x06000D92 RID: 3474 RVA: 0x0009C58C File Offset: 0x0009A78C
		// Note: this type is marked as 'beforefieldinit'.
		static Version()
		{
			Il2CppClassPointerStore<Version>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "Version");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Version>.NativeClassPtr);
			Version.NativeFieldInfoPtr_Current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Version>.NativeClassPtr, "Current");
			Version.NativeMethodInfoPtr_get_CurrentAsString_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100664976);
			Version.NativeMethodInfoPtr_GetVersionAsString_Private_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100664977);
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06000D93 RID: 3475 RVA: 0x0009C5F8 File Offset: 0x0009A7F8
		public unsafe static string CurrentAsString
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85006, XrefRangeEnd = 85016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_get_CurrentAsString_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x0009C624 File Offset: 0x0009A824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85016, XrefRangeEnd = 85026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetVersionAsString(int version)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref version;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_GetVersionAsString_Private_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x000088DB File Offset: 0x00006ADB
		public Version(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06000D96 RID: 3478 RVA: 0x0009C65C File Offset: 0x0009A85C
		// (set) Token: 0x06000D97 RID: 3479 RVA: 0x000088E4 File Offset: 0x00006AE4
		public unsafe static int Current
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Version.NativeFieldInfoPtr_Current, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Version.NativeFieldInfoPtr_Current, (void*)(&value));
			}
		}

		// Token: 0x0400092C RID: 2348
		private static readonly IntPtr NativeFieldInfoPtr_Current;

		// Token: 0x0400092D RID: 2349
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentAsString_Public_Static_get_String_0;

		// Token: 0x0400092E RID: 2350
		private static readonly IntPtr NativeMethodInfoPtr_GetVersionAsString_Private_Static_String_Int32_0;
	}
}
