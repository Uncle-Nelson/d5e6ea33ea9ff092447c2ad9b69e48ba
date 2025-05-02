using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management.Presets;

namespace Il2CppScheduleOne.Management.Objects
{
	// Token: 0x020003B3 RID: 947
	public class ManageablePot : ManageableObject
	{
		// Token: 0x060049D5 RID: 18901 RVA: 0x001674F0 File Offset: 0x001656F0
		// Note: this type is marked as 'beforefieldinit'.
		static ManageablePot()
		{
			Il2CppClassPointerStore<ManageablePot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management.Objects", "ManageablePot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManageablePot>.NativeClassPtr);
			ManageablePot.NativeFieldInfoPtr_CurrentPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManageablePot>.NativeClassPtr, "CurrentPreset");
			ManageablePot.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManageablePot>.NativeClassPtr, 100672457);
			ManageablePot.NativeMethodInfoPtr_GetObjectType_Public_Virtual_ManageableObjectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManageablePot>.NativeClassPtr, 100672458);
			ManageablePot.NativeMethodInfoPtr_GetCurrentPreset_Public_Virtual_Preset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManageablePot>.NativeClassPtr, 100672459);
			ManageablePot.NativeMethodInfoPtr_SetPreset_Internal_Protected_Virtual_Void_Preset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManageablePot>.NativeClassPtr, 100672460);
			ManageablePot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManageablePot>.NativeClassPtr, 100672461);
		}

		// Token: 0x060049D6 RID: 18902 RVA: 0x00167598 File Offset: 0x00165798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163722, XrefRangeEnd = 163724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManageablePot.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049D7 RID: 18903 RVA: 0x001675D4 File Offset: 0x001657D4
		[CallerCount(65)]
		[CachedScanResults(RefRangeStart = 31227, RefRangeEnd = 31292, XrefRangeStart = 31227, XrefRangeEnd = 31292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ManageableObjectType GetObjectType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManageablePot.NativeMethodInfoPtr_GetObjectType_Public_Virtual_ManageableObjectType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060049D8 RID: 18904 RVA: 0x0016761C File Offset: 0x0016581C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 17399, RefRangeEnd = 17400, XrefRangeStart = 17399, XrefRangeEnd = 17400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Preset GetCurrentPreset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManageablePot.NativeMethodInfoPtr_GetCurrentPreset_Public_Virtual_Preset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Preset>(intPtr3) : null;
		}

		// Token: 0x060049D9 RID: 18905 RVA: 0x00167668 File Offset: 0x00165868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163724, XrefRangeEnd = 163744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetPreset_Internal(Preset newPreset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newPreset);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManageablePot.NativeMethodInfoPtr_SetPreset_Internal_Protected_Virtual_Void_Preset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049DA RID: 18906 RVA: 0x001676B8 File Offset: 0x001658B8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManageablePot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManageablePot>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManageablePot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049DB RID: 18907 RVA: 0x00023921 File Offset: 0x00021B21
		public ManageablePot(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001621 RID: 5665
		// (get) Token: 0x060049DC RID: 18908 RVA: 0x001676F4 File Offset: 0x001658F4
		// (set) Token: 0x060049DD RID: 18909 RVA: 0x0002392A File Offset: 0x00021B2A
		public unsafe PotPreset CurrentPreset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManageablePot.NativeFieldInfoPtr_CurrentPreset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotPreset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManageablePot.NativeFieldInfoPtr_CurrentPreset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031C9 RID: 12745
		private static readonly IntPtr NativeFieldInfoPtr_CurrentPreset;

		// Token: 0x040031CA RID: 12746
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040031CB RID: 12747
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectType_Public_Virtual_ManageableObjectType_0;

		// Token: 0x040031CC RID: 12748
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentPreset_Public_Virtual_Preset_0;

		// Token: 0x040031CD RID: 12749
		private static readonly IntPtr NativeMethodInfoPtr_SetPreset_Internal_Protected_Virtual_Void_Preset_0;

		// Token: 0x040031CE RID: 12750
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
