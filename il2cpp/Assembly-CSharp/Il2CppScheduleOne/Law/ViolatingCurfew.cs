using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003CD RID: 973
	[Serializable]
	public class ViolatingCurfew : Crime
	{
		// Token: 0x06004B5E RID: 19294 RVA: 0x0016C4F4 File Offset: 0x0016A6F4
		// Note: this type is marked as 'beforefieldinit'.
		static ViolatingCurfew()
		{
			Il2CppClassPointerStore<ViolatingCurfew>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "ViolatingCurfew");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ViolatingCurfew>.NativeClassPtr);
			ViolatingCurfew.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViolatingCurfew>.NativeClassPtr, "<CrimeName>k__BackingField");
			ViolatingCurfew.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViolatingCurfew>.NativeClassPtr, 100672631);
			ViolatingCurfew.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViolatingCurfew>.NativeClassPtr, 100672632);
			ViolatingCurfew.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViolatingCurfew>.NativeClassPtr, 100672633);
		}

		// Token: 0x17001698 RID: 5784
		// (get) Token: 0x06004B5F RID: 19295 RVA: 0x0016C574 File Offset: 0x0016A774
		// (set) Token: 0x06004B60 RID: 19296 RVA: 0x0016C5B8 File Offset: 0x0016A7B8
		public unsafe override string CrimeName
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ViolatingCurfew.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ViolatingCurfew.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B61 RID: 19297 RVA: 0x0016C608 File Offset: 0x0016A808
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164888, RefRangeEnd = 164889, XrefRangeStart = 164879, XrefRangeEnd = 164888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ViolatingCurfew() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ViolatingCurfew>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViolatingCurfew.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B62 RID: 19298 RVA: 0x00024482 File Offset: 0x00022682
		public ViolatingCurfew(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001697 RID: 5783
		// (get) Token: 0x06004B63 RID: 19299 RVA: 0x0016C644 File Offset: 0x0016A844
		// (set) Token: 0x06004B64 RID: 19300 RVA: 0x0002448B File Offset: 0x0002268B
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViolatingCurfew.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViolatingCurfew.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040032D1 RID: 13009
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040032D2 RID: 13010
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040032D3 RID: 13011
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040032D4 RID: 13012
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
