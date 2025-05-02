using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003D1 RID: 977
	[Serializable]
	public class Vandalism : Crime
	{
		// Token: 0x06004B7A RID: 19322 RVA: 0x0016CAD4 File Offset: 0x0016ACD4
		// Note: this type is marked as 'beforefieldinit'.
		static Vandalism()
		{
			Il2CppClassPointerStore<Vandalism>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "Vandalism");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vandalism>.NativeClassPtr);
			Vandalism.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vandalism>.NativeClassPtr, "<CrimeName>k__BackingField");
			Vandalism.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vandalism>.NativeClassPtr, 100672643);
			Vandalism.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vandalism>.NativeClassPtr, 100672644);
			Vandalism.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vandalism>.NativeClassPtr, 100672645);
		}

		// Token: 0x170016A0 RID: 5792
		// (get) Token: 0x06004B7B RID: 19323 RVA: 0x0016CB54 File Offset: 0x0016AD54
		// (set) Token: 0x06004B7C RID: 19324 RVA: 0x0016CB98 File Offset: 0x0016AD98
		public unsafe override string CrimeName
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Vandalism.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Vandalism.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B7D RID: 19325 RVA: 0x0016CBE8 File Offset: 0x0016ADE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164930, RefRangeEnd = 164931, XrefRangeStart = 164921, XrefRangeEnd = 164930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vandalism() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vandalism>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vandalism.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B7E RID: 19326 RVA: 0x00024522 File Offset: 0x00022722
		public Vandalism(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700169F RID: 5791
		// (get) Token: 0x06004B7F RID: 19327 RVA: 0x0016CC24 File Offset: 0x0016AE24
		// (set) Token: 0x06004B80 RID: 19328 RVA: 0x0002452B File Offset: 0x0002272B
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vandalism.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vandalism.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040032E1 RID: 13025
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040032E2 RID: 13026
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040032E3 RID: 13027
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040032E4 RID: 13028
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
