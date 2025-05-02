using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006DF RID: 1759
	public class PackagerUIElement : WorldspaceUIElement
	{
		// Token: 0x06009DEF RID: 40431 RVA: 0x0027EEA8 File Offset: 0x0027D0A8
		// Note: this type is marked as 'beforefieldinit'.
		static PackagerUIElement()
		{
			Il2CppClassPointerStore<PackagerUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "PackagerUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagerUIElement>.NativeClassPtr);
			PackagerUIElement.NativeFieldInfoPtr_StationRects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagerUIElement>.NativeClassPtr, "StationRects");
			PackagerUIElement.NativeFieldInfoPtr__AssignedPackager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagerUIElement>.NativeClassPtr, "<AssignedPackager>k__BackingField");
			PackagerUIElement.NativeMethodInfoPtr_get_AssignedPackager_Public_get_Packager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerUIElement>.NativeClassPtr, 100682666);
			PackagerUIElement.NativeMethodInfoPtr_set_AssignedPackager_Protected_set_Void_Packager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerUIElement>.NativeClassPtr, 100682667);
			PackagerUIElement.NativeMethodInfoPtr_Initialize_Public_Void_Packager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerUIElement>.NativeClassPtr, 100682668);
			PackagerUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerUIElement>.NativeClassPtr, 100682669);
			PackagerUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerUIElement>.NativeClassPtr, 100682670);
		}

		// Token: 0x170030A4 RID: 12452
		// (get) Token: 0x06009DF0 RID: 40432 RVA: 0x0027EF64 File Offset: 0x0027D164
		// (set) Token: 0x06009DF1 RID: 40433 RVA: 0x0027EFA4 File Offset: 0x0027D1A4
		public unsafe Packager AssignedPackager
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagerUIElement.NativeMethodInfoPtr_get_AssignedPackager_Public_get_Packager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Packager>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagerUIElement.NativeMethodInfoPtr_set_AssignedPackager_Protected_set_Void_Packager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009DF2 RID: 40434 RVA: 0x0027EFE8 File Offset: 0x0027D1E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280024, RefRangeEnd = 280025, XrefRangeStart = 280013, XrefRangeEnd = 280024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Packager packager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(packager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagerUIElement.NativeMethodInfoPtr_Initialize_Public_Void_Packager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DF3 RID: 40435 RVA: 0x0027F02C File Offset: 0x0027D22C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280025, XrefRangeEnd = 280050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagerUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DF4 RID: 40436 RVA: 0x0027F068 File Offset: 0x0027D268
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackagerUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagerUIElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagerUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DF5 RID: 40437 RVA: 0x0004D79C File Offset: 0x0004B99C
		public PackagerUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170030A2 RID: 12450
		// (get) Token: 0x06009DF6 RID: 40438 RVA: 0x0027F0A4 File Offset: 0x0027D2A4
		// (set) Token: 0x06009DF7 RID: 40439 RVA: 0x0004D7A5 File Offset: 0x0004B9A5
		public unsafe Il2CppReferenceArray<RectTransform> StationRects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerUIElement.NativeFieldInfoPtr_StationRects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerUIElement.NativeFieldInfoPtr_StationRects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030A3 RID: 12451
		// (get) Token: 0x06009DF8 RID: 40440 RVA: 0x0027F0D4 File Offset: 0x0027D2D4
		// (set) Token: 0x06009DF9 RID: 40441 RVA: 0x0004D7C4 File Offset: 0x0004B9C4
		public unsafe Packager _AssignedPackager_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerUIElement.NativeFieldInfoPtr__AssignedPackager_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Packager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerUIElement.NativeFieldInfoPtr__AssignedPackager_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006A09 RID: 27145
		private static readonly IntPtr NativeFieldInfoPtr_StationRects;

		// Token: 0x04006A0A RID: 27146
		private static readonly IntPtr NativeFieldInfoPtr__AssignedPackager_k__BackingField;

		// Token: 0x04006A0B RID: 27147
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedPackager_Public_get_Packager_0;

		// Token: 0x04006A0C RID: 27148
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedPackager_Protected_set_Void_Packager_0;

		// Token: 0x04006A0D RID: 27149
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Packager_0;

		// Token: 0x04006A0E RID: 27150
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x04006A0F RID: 27151
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
