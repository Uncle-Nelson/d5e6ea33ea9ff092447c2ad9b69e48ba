using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003CA RID: 970
	[Serializable]
	public class DrugTrafficking : Crime
	{
		// Token: 0x06004B49 RID: 19273 RVA: 0x0016C08C File Offset: 0x0016A28C
		// Note: this type is marked as 'beforefieldinit'.
		static DrugTrafficking()
		{
			Il2CppClassPointerStore<DrugTrafficking>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "DrugTrafficking");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrugTrafficking>.NativeClassPtr);
			DrugTrafficking.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrugTrafficking>.NativeClassPtr, "<CrimeName>k__BackingField");
			DrugTrafficking.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrugTrafficking>.NativeClassPtr, 100672622);
			DrugTrafficking.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrugTrafficking>.NativeClassPtr, 100672623);
			DrugTrafficking.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrugTrafficking>.NativeClassPtr, 100672624);
		}

		// Token: 0x17001692 RID: 5778
		// (get) Token: 0x06004B4A RID: 19274 RVA: 0x0016C10C File Offset: 0x0016A30C
		// (set) Token: 0x06004B4B RID: 19275 RVA: 0x0016C150 File Offset: 0x0016A350
		public unsafe override string CrimeName
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DrugTrafficking.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DrugTrafficking.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B4C RID: 19276 RVA: 0x0016C1A0 File Offset: 0x0016A3A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164858, RefRangeEnd = 164859, XrefRangeStart = 164849, XrefRangeEnd = 164858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DrugTrafficking() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrugTrafficking>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrugTrafficking.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B4D RID: 19277 RVA: 0x0002440A File Offset: 0x0002260A
		public DrugTrafficking(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001691 RID: 5777
		// (get) Token: 0x06004B4E RID: 19278 RVA: 0x0016C1DC File Offset: 0x0016A3DC
		// (set) Token: 0x06004B4F RID: 19279 RVA: 0x00024413 File Offset: 0x00022613
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrugTrafficking.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrugTrafficking.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040032C5 RID: 12997
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040032C6 RID: 12998
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040032C7 RID: 12999
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040032C8 RID: 13000
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
