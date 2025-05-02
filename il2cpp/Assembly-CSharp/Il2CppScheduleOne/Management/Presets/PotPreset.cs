using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management.Presets.Options;

namespace Il2CppScheduleOne.Management.Presets
{
	// Token: 0x020003AC RID: 940
	public class PotPreset : Preset
	{
		// Token: 0x0600497E RID: 18814 RVA: 0x001662B4 File Offset: 0x001644B4
		// Note: this type is marked as 'beforefieldinit'.
		static PotPreset()
		{
			Il2CppClassPointerStore<PotPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management.Presets", "PotPreset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotPreset>.NativeClassPtr);
			PotPreset.NativeFieldInfoPtr__DefaultPreset_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotPreset>.NativeClassPtr, "<DefaultPreset>k__BackingField");
			PotPreset.NativeFieldInfoPtr_Seeds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotPreset>.NativeClassPtr, "Seeds");
			PotPreset.NativeFieldInfoPtr_Additives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotPreset>.NativeClassPtr, "Additives");
			PotPreset.NativeMethodInfoPtr_get_DefaultPreset_Protected_Static_get_PotPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotPreset>.NativeClassPtr, 100672412);
			PotPreset.NativeMethodInfoPtr_set_DefaultPreset_Protected_Static_set_Void_PotPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotPreset>.NativeClassPtr, 100672413);
			PotPreset.NativeMethodInfoPtr_GetCopy_Public_Virtual_Preset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotPreset>.NativeClassPtr, 100672414);
			PotPreset.NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Preset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotPreset>.NativeClassPtr, 100672415);
			PotPreset.NativeMethodInfoPtr_InitializeOptions_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotPreset>.NativeClassPtr, 100672416);
			PotPreset.NativeMethodInfoPtr_GetDefaultPreset_Public_Static_PotPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotPreset>.NativeClassPtr, 100672417);
			PotPreset.NativeMethodInfoPtr_GetNewBlankPreset_Public_Static_PotPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotPreset>.NativeClassPtr, 100672418);
			PotPreset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotPreset>.NativeClassPtr, 100672419);
		}

		// Token: 0x1700160D RID: 5645
		// (get) Token: 0x0600497F RID: 18815 RVA: 0x001663C0 File Offset: 0x001645C0
		// (set) Token: 0x06004980 RID: 18816 RVA: 0x001663F4 File Offset: 0x001645F4
		public unsafe static PotPreset DefaultPreset
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163528, XrefRangeEnd = 163530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotPreset.NativeMethodInfoPtr_get_DefaultPreset_Protected_Static_get_PotPreset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PotPreset>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163530, XrefRangeEnd = 163534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotPreset.NativeMethodInfoPtr_set_DefaultPreset_Protected_Static_set_Void_PotPreset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004981 RID: 18817 RVA: 0x0016642C File Offset: 0x0016462C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163534, XrefRangeEnd = 163538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Preset GetCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotPreset.NativeMethodInfoPtr_GetCopy_Public_Virtual_Preset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Preset>(intPtr3) : null;
		}

		// Token: 0x06004982 RID: 18818 RVA: 0x00166478 File Offset: 0x00164678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163538, XrefRangeEnd = 163541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyTo(Preset other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotPreset.NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Preset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004983 RID: 18819 RVA: 0x001664C8 File Offset: 0x001646C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163541, XrefRangeEnd = 163562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotPreset.NativeMethodInfoPtr_InitializeOptions_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004984 RID: 18820 RVA: 0x00166504 File Offset: 0x00164704
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 163578, RefRangeEnd = 163579, XrefRangeStart = 163562, XrefRangeEnd = 163578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PotPreset GetDefaultPreset()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotPreset.NativeMethodInfoPtr_GetDefaultPreset_Public_Static_PotPreset_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PotPreset>(intPtr3) : null;
		}

		// Token: 0x06004985 RID: 18821 RVA: 0x00166538 File Offset: 0x00164738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163579, XrefRangeEnd = 163601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PotPreset GetNewBlankPreset()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotPreset.NativeMethodInfoPtr_GetNewBlankPreset_Public_Static_PotPreset_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PotPreset>(intPtr3) : null;
		}

		// Token: 0x06004986 RID: 18822 RVA: 0x0016656C File Offset: 0x0016476C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163601, XrefRangeEnd = 163602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PotPreset() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotPreset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotPreset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004987 RID: 18823 RVA: 0x000236A0 File Offset: 0x000218A0
		public PotPreset(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700160A RID: 5642
		// (get) Token: 0x06004988 RID: 18824 RVA: 0x001665A8 File Offset: 0x001647A8
		// (set) Token: 0x06004989 RID: 18825 RVA: 0x000236A9 File Offset: 0x000218A9
		public unsafe static PotPreset _DefaultPreset_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PotPreset.NativeFieldInfoPtr__DefaultPreset_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotPreset>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PotPreset.NativeFieldInfoPtr__DefaultPreset_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700160B RID: 5643
		// (get) Token: 0x0600498A RID: 18826 RVA: 0x001665D0 File Offset: 0x001647D0
		// (set) Token: 0x0600498B RID: 18827 RVA: 0x000236BB File Offset: 0x000218BB
		public unsafe ItemList Seeds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotPreset.NativeFieldInfoPtr_Seeds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotPreset.NativeFieldInfoPtr_Seeds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700160C RID: 5644
		// (get) Token: 0x0600498C RID: 18828 RVA: 0x00166600 File Offset: 0x00164800
		// (set) Token: 0x0600498D RID: 18829 RVA: 0x000236DA File Offset: 0x000218DA
		public unsafe ItemList Additives
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotPreset.NativeFieldInfoPtr_Additives);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotPreset.NativeFieldInfoPtr_Additives), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003192 RID: 12690
		private static readonly IntPtr NativeFieldInfoPtr__DefaultPreset_k__BackingField;

		// Token: 0x04003193 RID: 12691
		private static readonly IntPtr NativeFieldInfoPtr_Seeds;

		// Token: 0x04003194 RID: 12692
		private static readonly IntPtr NativeFieldInfoPtr_Additives;

		// Token: 0x04003195 RID: 12693
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultPreset_Protected_Static_get_PotPreset_0;

		// Token: 0x04003196 RID: 12694
		private static readonly IntPtr NativeMethodInfoPtr_set_DefaultPreset_Protected_Static_set_Void_PotPreset_0;

		// Token: 0x04003197 RID: 12695
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_Virtual_Preset_0;

		// Token: 0x04003198 RID: 12696
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Preset_0;

		// Token: 0x04003199 RID: 12697
		private static readonly IntPtr NativeMethodInfoPtr_InitializeOptions_Public_Virtual_Void_0;

		// Token: 0x0400319A RID: 12698
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultPreset_Public_Static_PotPreset_0;

		// Token: 0x0400319B RID: 12699
		private static readonly IntPtr NativeMethodInfoPtr_GetNewBlankPreset_Public_Static_PotPreset_0;

		// Token: 0x0400319C RID: 12700
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
