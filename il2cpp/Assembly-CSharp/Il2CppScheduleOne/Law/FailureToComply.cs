using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003CB RID: 971
	[Serializable]
	public class FailureToComply : Crime
	{
		// Token: 0x06004B50 RID: 19280 RVA: 0x0016C204 File Offset: 0x0016A404
		// Note: this type is marked as 'beforefieldinit'.
		static FailureToComply()
		{
			Il2CppClassPointerStore<FailureToComply>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "FailureToComply");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FailureToComply>.NativeClassPtr);
			FailureToComply.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FailureToComply>.NativeClassPtr, "<CrimeName>k__BackingField");
			FailureToComply.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FailureToComply>.NativeClassPtr, 100672625);
			FailureToComply.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FailureToComply>.NativeClassPtr, 100672626);
			FailureToComply.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FailureToComply>.NativeClassPtr, 100672627);
		}

		// Token: 0x17001694 RID: 5780
		// (get) Token: 0x06004B51 RID: 19281 RVA: 0x0016C284 File Offset: 0x0016A484
		// (set) Token: 0x06004B52 RID: 19282 RVA: 0x0016C2C8 File Offset: 0x0016A4C8
		public unsafe override string CrimeName
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FailureToComply.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FailureToComply.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B53 RID: 19283 RVA: 0x0016C318 File Offset: 0x0016A518
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164868, RefRangeEnd = 164869, XrefRangeStart = 164859, XrefRangeEnd = 164868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FailureToComply() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FailureToComply>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FailureToComply.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B54 RID: 19284 RVA: 0x00024432 File Offset: 0x00022632
		public FailureToComply(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001693 RID: 5779
		// (get) Token: 0x06004B55 RID: 19285 RVA: 0x0016C354 File Offset: 0x0016A554
		// (set) Token: 0x06004B56 RID: 19286 RVA: 0x0002443B File Offset: 0x0002263B
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FailureToComply.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FailureToComply.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040032C9 RID: 13001
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040032CA RID: 13002
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040032CB RID: 13003
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040032CC RID: 13004
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
