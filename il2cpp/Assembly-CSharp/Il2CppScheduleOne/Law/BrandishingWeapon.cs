using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003D3 RID: 979
	[Serializable]
	public class BrandishingWeapon : Crime
	{
		// Token: 0x06004B88 RID: 19336 RVA: 0x0016CDC4 File Offset: 0x0016AFC4
		// Note: this type is marked as 'beforefieldinit'.
		static BrandishingWeapon()
		{
			Il2CppClassPointerStore<BrandishingWeapon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "BrandishingWeapon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BrandishingWeapon>.NativeClassPtr);
			BrandishingWeapon.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrandishingWeapon>.NativeClassPtr, "<CrimeName>k__BackingField");
			BrandishingWeapon.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrandishingWeapon>.NativeClassPtr, 100672649);
			BrandishingWeapon.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrandishingWeapon>.NativeClassPtr, 100672650);
			BrandishingWeapon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrandishingWeapon>.NativeClassPtr, 100672651);
		}

		// Token: 0x170016A4 RID: 5796
		// (get) Token: 0x06004B89 RID: 19337 RVA: 0x0016CE44 File Offset: 0x0016B044
		// (set) Token: 0x06004B8A RID: 19338 RVA: 0x0016CE88 File Offset: 0x0016B088
		public unsafe override string CrimeName
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BrandishingWeapon.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BrandishingWeapon.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B8B RID: 19339 RVA: 0x0016CED8 File Offset: 0x0016B0D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 164950, RefRangeEnd = 164952, XrefRangeStart = 164941, XrefRangeEnd = 164950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BrandishingWeapon() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BrandishingWeapon>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrandishingWeapon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B8C RID: 19340 RVA: 0x00024572 File Offset: 0x00022772
		public BrandishingWeapon(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016A3 RID: 5795
		// (get) Token: 0x06004B8D RID: 19341 RVA: 0x0016CF14 File Offset: 0x0016B114
		// (set) Token: 0x06004B8E RID: 19342 RVA: 0x0002457B File Offset: 0x0002277B
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrandishingWeapon.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrandishingWeapon.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040032E9 RID: 13033
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040032EA RID: 13034
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040032EB RID: 13035
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040032EC RID: 13036
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
