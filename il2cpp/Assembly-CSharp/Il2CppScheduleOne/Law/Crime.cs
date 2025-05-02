using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003C3 RID: 963
	[Serializable]
	public class Crime : Object
	{
		// Token: 0x06004B18 RID: 19224 RVA: 0x0016B644 File Offset: 0x00169844
		// Note: this type is marked as 'beforefieldinit'.
		static Crime()
		{
			Il2CppClassPointerStore<Crime>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "Crime");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Crime>.NativeClassPtr);
			Crime.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Crime>.NativeClassPtr, "<CrimeName>k__BackingField");
			Crime.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Crime>.NativeClassPtr, 100672601);
			Crime.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Crime>.NativeClassPtr, 100672602);
			Crime.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Crime>.NativeClassPtr, 100672603);
		}

		// Token: 0x17001684 RID: 5764
		// (get) Token: 0x06004B19 RID: 19225 RVA: 0x0016B6C4 File Offset: 0x001698C4
		// (set) Token: 0x06004B1A RID: 19226 RVA: 0x0016B708 File Offset: 0x00169908
		public unsafe virtual string CrimeName
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 17380, RefRangeEnd = 17390, XrefRangeStart = 17380, XrefRangeEnd = 17390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Crime.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29995, RefRangeEnd = 29997, XrefRangeStart = 29995, XrefRangeEnd = 29997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Crime.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B1B RID: 19227 RVA: 0x0016B758 File Offset: 0x00169958
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164785, RefRangeEnd = 164786, XrefRangeStart = 164780, XrefRangeEnd = 164785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Crime() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Crime>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Crime.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B1C RID: 19228 RVA: 0x000242F2 File Offset: 0x000224F2
		public Crime(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001683 RID: 5763
		// (get) Token: 0x06004B1D RID: 19229 RVA: 0x0016B794 File Offset: 0x00169994
		// (set) Token: 0x06004B1E RID: 19230 RVA: 0x000242FB File Offset: 0x000224FB
		public unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Crime.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Crime.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040032A9 RID: 12969
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040032AA RID: 12970
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_New_get_String_0;

		// Token: 0x040032AB RID: 12971
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_New_set_Void_String_0;

		// Token: 0x040032AC RID: 12972
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
