using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x0200059F RID: 1439
	public static class PropertyMethods : Il2CppSystem.Object
	{
		// Token: 0x06007E03 RID: 32259 RVA: 0x0021BA48 File Offset: 0x00219C48
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyMethods()
		{
			Il2CppClassPointerStore<PropertyMethods>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "PropertyMethods");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyMethods>.NativeClassPtr);
			PropertyMethods.NativeMethodInfoPtr_GetName_Public_Static_String_EProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyMethods>.NativeClassPtr, 100679051);
			PropertyMethods.NativeMethodInfoPtr_GetDescription_Public_Static_String_EProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyMethods>.NativeClassPtr, 100679052);
			PropertyMethods.NativeMethodInfoPtr_GetColor_Public_Static_Color_EProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyMethods>.NativeClassPtr, 100679053);
		}

		// Token: 0x06007E04 RID: 32260 RVA: 0x0021BAB4 File Offset: 0x00219CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238690, XrefRangeEnd = 238691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetName(this EProperty property)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref property;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyMethods.NativeMethodInfoPtr_GetName_Public_Static_String_EProperty_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06007E05 RID: 32261 RVA: 0x0021BAEC File Offset: 0x00219CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238691, XrefRangeEnd = 238692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetDescription(this EProperty property)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref property;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyMethods.NativeMethodInfoPtr_GetDescription_Public_Static_String_EProperty_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06007E06 RID: 32262 RVA: 0x0021BB24 File Offset: 0x00219D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238692, XrefRangeEnd = 238693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color GetColor(this EProperty property)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref property;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyMethods.NativeMethodInfoPtr_GetColor_Public_Static_Color_EProperty_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007E07 RID: 32263 RVA: 0x0003BE47 File Offset: 0x0003A047
		public PropertyMethods(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040055C6 RID: 21958
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Static_String_EProperty_0;

		// Token: 0x040055C7 RID: 21959
		private static readonly IntPtr NativeMethodInfoPtr_GetDescription_Public_Static_String_EProperty_0;

		// Token: 0x040055C8 RID: 21960
		private static readonly IntPtr NativeMethodInfoPtr_GetColor_Public_Static_Color_EProperty_0;
	}
}
