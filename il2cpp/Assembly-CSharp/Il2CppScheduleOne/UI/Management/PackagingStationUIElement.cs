using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006E0 RID: 1760
	public class PackagingStationUIElement : WorldspaceUIElement
	{
		// Token: 0x06009DFA RID: 40442 RVA: 0x0027F104 File Offset: 0x0027D304
		// Note: this type is marked as 'beforefieldinit'.
		static PackagingStationUIElement()
		{
			Il2CppClassPointerStore<PackagingStationUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "PackagingStationUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagingStationUIElement>.NativeClassPtr);
			PackagingStationUIElement.NativeFieldInfoPtr__AssignedStation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationUIElement>.NativeClassPtr, "<AssignedStation>k__BackingField");
			PackagingStationUIElement.NativeMethodInfoPtr_get_AssignedStation_Public_get_PackagingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationUIElement>.NativeClassPtr, 100682671);
			PackagingStationUIElement.NativeMethodInfoPtr_set_AssignedStation_Protected_set_Void_PackagingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationUIElement>.NativeClassPtr, 100682672);
			PackagingStationUIElement.NativeMethodInfoPtr_Initialize_Public_Void_PackagingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationUIElement>.NativeClassPtr, 100682673);
			PackagingStationUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationUIElement>.NativeClassPtr, 100682674);
			PackagingStationUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationUIElement>.NativeClassPtr, 100682675);
		}

		// Token: 0x170030A6 RID: 12454
		// (get) Token: 0x06009DFB RID: 40443 RVA: 0x0027F1AC File Offset: 0x0027D3AC
		// (set) Token: 0x06009DFC RID: 40444 RVA: 0x0027F1EC File Offset: 0x0027D3EC
		public unsafe PackagingStation AssignedStation
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 16593, RefRangeEnd = 16594, XrefRangeStart = 16593, XrefRangeEnd = 16594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationUIElement.NativeMethodInfoPtr_get_AssignedStation_Public_get_PackagingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PackagingStation>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 38376, RefRangeEnd = 38379, XrefRangeStart = 38376, XrefRangeEnd = 38379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationUIElement.NativeMethodInfoPtr_set_AssignedStation_Protected_set_Void_PackagingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009DFD RID: 40445 RVA: 0x0027F230 File Offset: 0x0027D430
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280060, RefRangeEnd = 280061, XrefRangeStart = 280050, XrefRangeEnd = 280060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(PackagingStation pack)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pack);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationUIElement.NativeMethodInfoPtr_Initialize_Public_Void_PackagingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DFE RID: 40446 RVA: 0x0027F274 File Offset: 0x0027D474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280061, XrefRangeEnd = 280067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagingStationUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DFF RID: 40447 RVA: 0x0027F2B0 File Offset: 0x0027D4B0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackagingStationUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagingStationUIElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E00 RID: 40448 RVA: 0x0004D7E3 File Offset: 0x0004B9E3
		public PackagingStationUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170030A5 RID: 12453
		// (get) Token: 0x06009E01 RID: 40449 RVA: 0x0027F2EC File Offset: 0x0027D4EC
		// (set) Token: 0x06009E02 RID: 40450 RVA: 0x0004D7EC File Offset: 0x0004B9EC
		public unsafe PackagingStation _AssignedStation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationUIElement.NativeFieldInfoPtr__AssignedStation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationUIElement.NativeFieldInfoPtr__AssignedStation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006A10 RID: 27152
		private static readonly IntPtr NativeFieldInfoPtr__AssignedStation_k__BackingField;

		// Token: 0x04006A11 RID: 27153
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedStation_Public_get_PackagingStation_0;

		// Token: 0x04006A12 RID: 27154
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedStation_Protected_set_Void_PackagingStation_0;

		// Token: 0x04006A13 RID: 27155
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_PackagingStation_0;

		// Token: 0x04006A14 RID: 27156
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x04006A15 RID: 27157
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
