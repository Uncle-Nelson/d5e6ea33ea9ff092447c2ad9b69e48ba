using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003C8 RID: 968
	[Serializable]
	public class Evading : Crime
	{
		// Token: 0x06004B3B RID: 19259 RVA: 0x0016BD9C File Offset: 0x00169F9C
		// Note: this type is marked as 'beforefieldinit'.
		static Evading()
		{
			Il2CppClassPointerStore<Evading>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "Evading");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Evading>.NativeClassPtr);
			Evading.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Evading>.NativeClassPtr, "<CrimeName>k__BackingField");
			Evading.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Evading>.NativeClassPtr, 100672616);
			Evading.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Evading>.NativeClassPtr, 100672617);
			Evading.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Evading>.NativeClassPtr, 100672618);
		}

		// Token: 0x1700168E RID: 5774
		// (get) Token: 0x06004B3C RID: 19260 RVA: 0x0016BE1C File Offset: 0x0016A01C
		// (set) Token: 0x06004B3D RID: 19261 RVA: 0x0016BE60 File Offset: 0x0016A060
		public unsafe override string CrimeName
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Evading.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Evading.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B3E RID: 19262 RVA: 0x0016BEB0 File Offset: 0x0016A0B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164835, RefRangeEnd = 164836, XrefRangeStart = 164826, XrefRangeEnd = 164835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Evading() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Evading>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Evading.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B3F RID: 19263 RVA: 0x000243BA File Offset: 0x000225BA
		public Evading(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700168D RID: 5773
		// (get) Token: 0x06004B40 RID: 19264 RVA: 0x0016BEEC File Offset: 0x0016A0EC
		// (set) Token: 0x06004B41 RID: 19265 RVA: 0x000243C3 File Offset: 0x000225C3
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Evading.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Evading.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040032BD RID: 12989
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040032BE RID: 12990
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040032BF RID: 12991
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040032C0 RID: 12992
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
