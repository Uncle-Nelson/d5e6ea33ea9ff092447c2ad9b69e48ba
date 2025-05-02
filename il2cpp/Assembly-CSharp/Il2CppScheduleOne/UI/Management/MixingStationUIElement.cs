using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006DE RID: 1758
	public class MixingStationUIElement : WorldspaceUIElement
	{
		// Token: 0x06009DE6 RID: 40422 RVA: 0x0027EC90 File Offset: 0x0027CE90
		// Note: this type is marked as 'beforefieldinit'.
		static MixingStationUIElement()
		{
			Il2CppClassPointerStore<MixingStationUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "MixingStationUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixingStationUIElement>.NativeClassPtr);
			MixingStationUIElement.NativeFieldInfoPtr__AssignedStation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationUIElement>.NativeClassPtr, "<AssignedStation>k__BackingField");
			MixingStationUIElement.NativeMethodInfoPtr_get_AssignedStation_Public_get_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationUIElement>.NativeClassPtr, 100682661);
			MixingStationUIElement.NativeMethodInfoPtr_set_AssignedStation_Protected_set_Void_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationUIElement>.NativeClassPtr, 100682662);
			MixingStationUIElement.NativeMethodInfoPtr_Initialize_Public_Void_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationUIElement>.NativeClassPtr, 100682663);
			MixingStationUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationUIElement>.NativeClassPtr, 100682664);
			MixingStationUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationUIElement>.NativeClassPtr, 100682665);
		}

		// Token: 0x170030A1 RID: 12449
		// (get) Token: 0x06009DE7 RID: 40423 RVA: 0x0027ED38 File Offset: 0x0027CF38
		// (set) Token: 0x06009DE8 RID: 40424 RVA: 0x0027ED78 File Offset: 0x0027CF78
		public unsafe MixingStation AssignedStation
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 16593, RefRangeEnd = 16594, XrefRangeStart = 16593, XrefRangeEnd = 16594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationUIElement.NativeMethodInfoPtr_get_AssignedStation_Public_get_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MixingStation>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 38376, RefRangeEnd = 38379, XrefRangeStart = 38376, XrefRangeEnd = 38379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationUIElement.NativeMethodInfoPtr_set_AssignedStation_Protected_set_Void_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009DE9 RID: 40425 RVA: 0x0027EDBC File Offset: 0x0027CFBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280006, RefRangeEnd = 280007, XrefRangeStart = 279996, XrefRangeEnd = 280006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(MixingStation station)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(station);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationUIElement.NativeMethodInfoPtr_Initialize_Public_Void_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DEA RID: 40426 RVA: 0x0027EE00 File Offset: 0x0027D000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280007, XrefRangeEnd = 280013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MixingStationUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DEB RID: 40427 RVA: 0x0027EE3C File Offset: 0x0027D03C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixingStationUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixingStationUIElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DEC RID: 40428 RVA: 0x0004D774 File Offset: 0x0004B974
		public MixingStationUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170030A0 RID: 12448
		// (get) Token: 0x06009DED RID: 40429 RVA: 0x0027EE78 File Offset: 0x0027D078
		// (set) Token: 0x06009DEE RID: 40430 RVA: 0x0004D77D File Offset: 0x0004B97D
		public unsafe MixingStation _AssignedStation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationUIElement.NativeFieldInfoPtr__AssignedStation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MixingStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationUIElement.NativeFieldInfoPtr__AssignedStation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006A03 RID: 27139
		private static readonly IntPtr NativeFieldInfoPtr__AssignedStation_k__BackingField;

		// Token: 0x04006A04 RID: 27140
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedStation_Public_get_MixingStation_0;

		// Token: 0x04006A05 RID: 27141
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedStation_Protected_set_Void_MixingStation_0;

		// Token: 0x04006A06 RID: 27142
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_MixingStation_0;

		// Token: 0x04006A07 RID: 27143
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x04006A08 RID: 27144
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
