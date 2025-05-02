using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x02000419 RID: 1049
	public static class StandardsMethod : Object
	{
		// Token: 0x06005BBA RID: 23482 RVA: 0x001A9558 File Offset: 0x001A7758
		// Note: this type is marked as 'beforefieldinit'.
		static StandardsMethod()
		{
			Il2CppClassPointerStore<StandardsMethod>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "StandardsMethod");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StandardsMethod>.NativeClassPtr);
			StandardsMethod.NativeMethodInfoPtr_GetName_Public_Static_String_ECustomerStandard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardsMethod>.NativeClassPtr, 100674989);
			StandardsMethod.NativeMethodInfoPtr_GetCorrespondingQuality_Public_Static_EQuality_ECustomerStandard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardsMethod>.NativeClassPtr, 100674990);
		}

		// Token: 0x06005BBB RID: 23483 RVA: 0x001A95B0 File Offset: 0x001A77B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193603, RefRangeEnd = 193604, XrefRangeStart = 193596, XrefRangeEnd = 193603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetName(this ECustomerStandard property)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref property;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardsMethod.NativeMethodInfoPtr_GetName_Public_Static_String_ECustomerStandard_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005BBC RID: 23484 RVA: 0x001A95E8 File Offset: 0x001A77E8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 193604, RefRangeEnd = 193612, XrefRangeStart = 193604, XrefRangeEnd = 193604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EQuality GetCorrespondingQuality(this ECustomerStandard property)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref property;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardsMethod.NativeMethodInfoPtr_GetCorrespondingQuality_Public_Static_EQuality_ECustomerStandard_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005BBD RID: 23485 RVA: 0x0002B464 File Offset: 0x00029664
		public StandardsMethod(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003EBB RID: 16059
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Static_String_ECustomerStandard_0;

		// Token: 0x04003EBC RID: 16060
		private static readonly IntPtr NativeMethodInfoPtr_GetCorrespondingQuality_Public_Static_EQuality_ECustomerStandard_0;
	}
}
