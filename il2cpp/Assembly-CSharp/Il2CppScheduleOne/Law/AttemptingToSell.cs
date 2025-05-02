using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003CE RID: 974
	[Serializable]
	public class AttemptingToSell : Crime
	{
		// Token: 0x06004B65 RID: 19301 RVA: 0x0016C66C File Offset: 0x0016A86C
		// Note: this type is marked as 'beforefieldinit'.
		static AttemptingToSell()
		{
			Il2CppClassPointerStore<AttemptingToSell>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "AttemptingToSell");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttemptingToSell>.NativeClassPtr);
			AttemptingToSell.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttemptingToSell>.NativeClassPtr, "<CrimeName>k__BackingField");
			AttemptingToSell.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttemptingToSell>.NativeClassPtr, 100672634);
			AttemptingToSell.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttemptingToSell>.NativeClassPtr, 100672635);
			AttemptingToSell.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttemptingToSell>.NativeClassPtr, 100672636);
		}

		// Token: 0x1700169A RID: 5786
		// (get) Token: 0x06004B66 RID: 19302 RVA: 0x0016C6EC File Offset: 0x0016A8EC
		// (set) Token: 0x06004B67 RID: 19303 RVA: 0x0016C730 File Offset: 0x0016A930
		public unsafe override string CrimeName
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttemptingToSell.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttemptingToSell.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B68 RID: 19304 RVA: 0x0016C780 File Offset: 0x0016A980
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164898, RefRangeEnd = 164899, XrefRangeStart = 164889, XrefRangeEnd = 164898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttemptingToSell() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttemptingToSell>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttemptingToSell.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B69 RID: 19305 RVA: 0x000244AA File Offset: 0x000226AA
		public AttemptingToSell(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001699 RID: 5785
		// (get) Token: 0x06004B6A RID: 19306 RVA: 0x0016C7BC File Offset: 0x0016A9BC
		// (set) Token: 0x06004B6B RID: 19307 RVA: 0x000244B3 File Offset: 0x000226B3
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttemptingToSell.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttemptingToSell.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040032D5 RID: 13013
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040032D6 RID: 13014
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040032D7 RID: 13015
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040032D8 RID: 13016
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
