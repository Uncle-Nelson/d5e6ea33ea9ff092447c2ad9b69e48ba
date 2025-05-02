using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003D4 RID: 980
	[Serializable]
	public class DischargeFirearm : Crime
	{
		// Token: 0x06004B8F RID: 19343 RVA: 0x0016CF3C File Offset: 0x0016B13C
		// Note: this type is marked as 'beforefieldinit'.
		static DischargeFirearm()
		{
			Il2CppClassPointerStore<DischargeFirearm>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "DischargeFirearm");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DischargeFirearm>.NativeClassPtr);
			DischargeFirearm.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DischargeFirearm>.NativeClassPtr, "<CrimeName>k__BackingField");
			DischargeFirearm.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DischargeFirearm>.NativeClassPtr, 100672652);
			DischargeFirearm.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DischargeFirearm>.NativeClassPtr, 100672653);
			DischargeFirearm.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DischargeFirearm>.NativeClassPtr, 100672654);
		}

		// Token: 0x170016A6 RID: 5798
		// (get) Token: 0x06004B90 RID: 19344 RVA: 0x0016CFBC File Offset: 0x0016B1BC
		// (set) Token: 0x06004B91 RID: 19345 RVA: 0x0016D000 File Offset: 0x0016B200
		public unsafe override string CrimeName
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DischargeFirearm.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DischargeFirearm.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B92 RID: 19346 RVA: 0x0016D050 File Offset: 0x0016B250
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 164961, RefRangeEnd = 164963, XrefRangeStart = 164952, XrefRangeEnd = 164961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DischargeFirearm() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DischargeFirearm>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DischargeFirearm.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B93 RID: 19347 RVA: 0x0002459A File Offset: 0x0002279A
		public DischargeFirearm(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016A5 RID: 5797
		// (get) Token: 0x06004B94 RID: 19348 RVA: 0x0016D08C File Offset: 0x0016B28C
		// (set) Token: 0x06004B95 RID: 19349 RVA: 0x000245A3 File Offset: 0x000227A3
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DischargeFirearm.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DischargeFirearm.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040032ED RID: 13037
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040032EE RID: 13038
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040032EF RID: 13039
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040032F0 RID: 13040
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
