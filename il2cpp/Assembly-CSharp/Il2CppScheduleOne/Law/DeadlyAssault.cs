using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003D0 RID: 976
	[Serializable]
	public class DeadlyAssault : Crime
	{
		// Token: 0x06004B73 RID: 19315 RVA: 0x0016C95C File Offset: 0x0016AB5C
		// Note: this type is marked as 'beforefieldinit'.
		static DeadlyAssault()
		{
			Il2CppClassPointerStore<DeadlyAssault>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "DeadlyAssault");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeadlyAssault>.NativeClassPtr);
			DeadlyAssault.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadlyAssault>.NativeClassPtr, "<CrimeName>k__BackingField");
			DeadlyAssault.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadlyAssault>.NativeClassPtr, 100672640);
			DeadlyAssault.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadlyAssault>.NativeClassPtr, 100672641);
			DeadlyAssault.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadlyAssault>.NativeClassPtr, 100672642);
		}

		// Token: 0x1700169E RID: 5790
		// (get) Token: 0x06004B74 RID: 19316 RVA: 0x0016C9DC File Offset: 0x0016ABDC
		// (set) Token: 0x06004B75 RID: 19317 RVA: 0x0016CA20 File Offset: 0x0016AC20
		public unsafe override string CrimeName
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeadlyAssault.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeadlyAssault.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B76 RID: 19318 RVA: 0x0016CA70 File Offset: 0x0016AC70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164920, RefRangeEnd = 164921, XrefRangeStart = 164911, XrefRangeEnd = 164920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeadlyAssault() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeadlyAssault>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadlyAssault.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B77 RID: 19319 RVA: 0x000244FA File Offset: 0x000226FA
		public DeadlyAssault(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700169D RID: 5789
		// (get) Token: 0x06004B78 RID: 19320 RVA: 0x0016CAAC File Offset: 0x0016ACAC
		// (set) Token: 0x06004B79 RID: 19321 RVA: 0x00024503 File Offset: 0x00022703
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadlyAssault.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadlyAssault.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040032DD RID: 13021
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040032DE RID: 13022
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040032DF RID: 13023
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040032E0 RID: 13024
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
