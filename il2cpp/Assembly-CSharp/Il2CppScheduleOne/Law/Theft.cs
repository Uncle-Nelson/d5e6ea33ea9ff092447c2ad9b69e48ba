using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003D2 RID: 978
	[Serializable]
	public class Theft : Crime
	{
		// Token: 0x06004B81 RID: 19329 RVA: 0x0016CC4C File Offset: 0x0016AE4C
		// Note: this type is marked as 'beforefieldinit'.
		static Theft()
		{
			Il2CppClassPointerStore<Theft>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "Theft");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Theft>.NativeClassPtr);
			Theft.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Theft>.NativeClassPtr, "<CrimeName>k__BackingField");
			Theft.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Theft>.NativeClassPtr, 100672646);
			Theft.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Theft>.NativeClassPtr, 100672647);
			Theft.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Theft>.NativeClassPtr, 100672648);
		}

		// Token: 0x170016A2 RID: 5794
		// (get) Token: 0x06004B82 RID: 19330 RVA: 0x0016CCCC File Offset: 0x0016AECC
		// (set) Token: 0x06004B83 RID: 19331 RVA: 0x0016CD10 File Offset: 0x0016AF10
		public unsafe override string CrimeName
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Theft.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Theft.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B84 RID: 19332 RVA: 0x0016CD60 File Offset: 0x0016AF60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164940, RefRangeEnd = 164941, XrefRangeStart = 164931, XrefRangeEnd = 164940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Theft() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Theft>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Theft.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B85 RID: 19333 RVA: 0x0002454A File Offset: 0x0002274A
		public Theft(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016A1 RID: 5793
		// (get) Token: 0x06004B86 RID: 19334 RVA: 0x0016CD9C File Offset: 0x0016AF9C
		// (set) Token: 0x06004B87 RID: 19335 RVA: 0x00024553 File Offset: 0x00022753
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Theft.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Theft.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040032E5 RID: 13029
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040032E6 RID: 13030
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040032E7 RID: 13031
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040032E8 RID: 13032
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
