using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003CC RID: 972
	[Serializable]
	public class TransportingIllicitItems : Crime
	{
		// Token: 0x06004B57 RID: 19287 RVA: 0x0016C37C File Offset: 0x0016A57C
		// Note: this type is marked as 'beforefieldinit'.
		static TransportingIllicitItems()
		{
			Il2CppClassPointerStore<TransportingIllicitItems>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "TransportingIllicitItems");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransportingIllicitItems>.NativeClassPtr);
			TransportingIllicitItems.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransportingIllicitItems>.NativeClassPtr, "<CrimeName>k__BackingField");
			TransportingIllicitItems.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransportingIllicitItems>.NativeClassPtr, 100672628);
			TransportingIllicitItems.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransportingIllicitItems>.NativeClassPtr, 100672629);
			TransportingIllicitItems.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransportingIllicitItems>.NativeClassPtr, 100672630);
		}

		// Token: 0x17001696 RID: 5782
		// (get) Token: 0x06004B58 RID: 19288 RVA: 0x0016C3FC File Offset: 0x0016A5FC
		// (set) Token: 0x06004B59 RID: 19289 RVA: 0x0016C440 File Offset: 0x0016A640
		public unsafe override string CrimeName
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TransportingIllicitItems.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TransportingIllicitItems.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B5A RID: 19290 RVA: 0x0016C490 File Offset: 0x0016A690
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164878, RefRangeEnd = 164879, XrefRangeStart = 164869, XrefRangeEnd = 164878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransportingIllicitItems() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransportingIllicitItems>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransportingIllicitItems.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B5B RID: 19291 RVA: 0x0002445A File Offset: 0x0002265A
		public TransportingIllicitItems(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001695 RID: 5781
		// (get) Token: 0x06004B5C RID: 19292 RVA: 0x0016C4CC File Offset: 0x0016A6CC
		// (set) Token: 0x06004B5D RID: 19293 RVA: 0x00024463 File Offset: 0x00022663
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransportingIllicitItems.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransportingIllicitItems.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040032CD RID: 13005
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040032CE RID: 13006
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040032CF RID: 13007
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040032D0 RID: 13008
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
