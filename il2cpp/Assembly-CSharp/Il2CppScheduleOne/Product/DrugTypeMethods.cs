using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x0200059C RID: 1436
	public static class DrugTypeMethods : Il2CppSystem.Object
	{
		// Token: 0x06007DFA RID: 32250 RVA: 0x0021B8BC File Offset: 0x00219ABC
		// Note: this type is marked as 'beforefieldinit'.
		static DrugTypeMethods()
		{
			Il2CppClassPointerStore<DrugTypeMethods>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "DrugTypeMethods");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrugTypeMethods>.NativeClassPtr);
			DrugTypeMethods.NativeMethodInfoPtr_GetName_Public_Static_String_EDrugType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrugTypeMethods>.NativeClassPtr, 100679048);
			DrugTypeMethods.NativeMethodInfoPtr_GetColor_Public_Static_Color_EDrugType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrugTypeMethods>.NativeClassPtr, 100679049);
		}

		// Token: 0x06007DFB RID: 32251 RVA: 0x0021B914 File Offset: 0x00219B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238688, XrefRangeEnd = 238689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetName(this EDrugType property)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref property;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrugTypeMethods.NativeMethodInfoPtr_GetName_Public_Static_String_EDrugType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06007DFC RID: 32252 RVA: 0x0021B94C File Offset: 0x00219B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238689, XrefRangeEnd = 238690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color GetColor(this EDrugType property)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref property;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrugTypeMethods.NativeMethodInfoPtr_GetColor_Public_Static_Color_EDrugType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007DFD RID: 32253 RVA: 0x0003BE1A File Offset: 0x0003A01A
		public DrugTypeMethods(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040055B0 RID: 21936
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Static_String_EDrugType_0;

		// Token: 0x040055B1 RID: 21937
		private static readonly IntPtr NativeMethodInfoPtr_GetColor_Public_Static_Color_EDrugType_0;
	}
}
