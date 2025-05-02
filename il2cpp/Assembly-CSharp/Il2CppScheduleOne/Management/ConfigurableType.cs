using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x02000391 RID: 913
	public static class ConfigurableType : Object
	{
		// Token: 0x060047CA RID: 18378 RVA: 0x00022BD0 File Offset: 0x00020DD0
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigurableType()
		{
			Il2CppClassPointerStore<ConfigurableType>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "ConfigurableType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigurableType>.NativeClassPtr);
			ConfigurableType.NativeMethodInfoPtr_GetTypeName_Public_Static_String_EConfigurableType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurableType>.NativeClassPtr, 100672170);
		}

		// Token: 0x060047CB RID: 18379 RVA: 0x0015FC98 File Offset: 0x0015DE98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 161473, RefRangeEnd = 161475, XrefRangeStart = 161456, XrefRangeEnd = 161473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetTypeName(EConfigurableType type)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurableType.NativeMethodInfoPtr_GetTypeName_Public_Static_String_EConfigurableType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060047CC RID: 18380 RVA: 0x00022C09 File Offset: 0x00020E09
		public ConfigurableType(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003062 RID: 12386
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeName_Public_Static_String_EConfigurableType_0;
	}
}
