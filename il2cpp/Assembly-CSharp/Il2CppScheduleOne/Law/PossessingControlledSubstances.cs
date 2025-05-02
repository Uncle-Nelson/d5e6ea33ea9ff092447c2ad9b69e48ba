using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003C4 RID: 964
	[Serializable]
	public class PossessingControlledSubstances : Crime
	{
		// Token: 0x06004B1F RID: 19231 RVA: 0x0016B7BC File Offset: 0x001699BC
		// Note: this type is marked as 'beforefieldinit'.
		static PossessingControlledSubstances()
		{
			Il2CppClassPointerStore<PossessingControlledSubstances>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "PossessingControlledSubstances");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PossessingControlledSubstances>.NativeClassPtr);
			PossessingControlledSubstances.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PossessingControlledSubstances>.NativeClassPtr, "<CrimeName>k__BackingField");
			PossessingControlledSubstances.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PossessingControlledSubstances>.NativeClassPtr, 100672604);
			PossessingControlledSubstances.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PossessingControlledSubstances>.NativeClassPtr, 100672605);
			PossessingControlledSubstances.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PossessingControlledSubstances>.NativeClassPtr, 100672606);
		}

		// Token: 0x17001686 RID: 5766
		// (get) Token: 0x06004B20 RID: 19232 RVA: 0x0016B83C File Offset: 0x00169A3C
		// (set) Token: 0x06004B21 RID: 19233 RVA: 0x0016B880 File Offset: 0x00169A80
		public unsafe override string CrimeName
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PossessingControlledSubstances.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PossessingControlledSubstances.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B22 RID: 19234 RVA: 0x0016B8D0 File Offset: 0x00169AD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164795, RefRangeEnd = 164796, XrefRangeStart = 164786, XrefRangeEnd = 164795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PossessingControlledSubstances() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PossessingControlledSubstances>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PossessingControlledSubstances.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B23 RID: 19235 RVA: 0x0002431A File Offset: 0x0002251A
		public PossessingControlledSubstances(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001685 RID: 5765
		// (get) Token: 0x06004B24 RID: 19236 RVA: 0x0016B90C File Offset: 0x00169B0C
		// (set) Token: 0x06004B25 RID: 19237 RVA: 0x00024323 File Offset: 0x00022523
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PossessingControlledSubstances.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PossessingControlledSubstances.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040032AD RID: 12973
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040032AE RID: 12974
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040032AF RID: 12975
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040032B0 RID: 12976
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
