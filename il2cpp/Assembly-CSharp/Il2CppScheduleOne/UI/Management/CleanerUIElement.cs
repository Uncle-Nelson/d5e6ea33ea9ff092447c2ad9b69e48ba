using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006DB RID: 1755
	public class CleanerUIElement : WorldspaceUIElement
	{
		// Token: 0x06009DC7 RID: 40391 RVA: 0x0027E5C0 File Offset: 0x0027C7C0
		// Note: this type is marked as 'beforefieldinit'.
		static CleanerUIElement()
		{
			Il2CppClassPointerStore<CleanerUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "CleanerUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CleanerUIElement>.NativeClassPtr);
			CleanerUIElement.NativeFieldInfoPtr_StationsIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanerUIElement>.NativeClassPtr, "StationsIcons");
			CleanerUIElement.NativeFieldInfoPtr__AssignedCleaner_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanerUIElement>.NativeClassPtr, "<AssignedCleaner>k__BackingField");
			CleanerUIElement.NativeMethodInfoPtr_get_AssignedCleaner_Public_get_Cleaner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerUIElement>.NativeClassPtr, 100682646);
			CleanerUIElement.NativeMethodInfoPtr_set_AssignedCleaner_Protected_set_Void_Cleaner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerUIElement>.NativeClassPtr, 100682647);
			CleanerUIElement.NativeMethodInfoPtr_Initialize_Public_Void_Cleaner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerUIElement>.NativeClassPtr, 100682648);
			CleanerUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerUIElement>.NativeClassPtr, 100682649);
			CleanerUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerUIElement>.NativeClassPtr, 100682650);
		}

		// Token: 0x1700309A RID: 12442
		// (get) Token: 0x06009DC8 RID: 40392 RVA: 0x0027E67C File Offset: 0x0027C87C
		// (set) Token: 0x06009DC9 RID: 40393 RVA: 0x0027E6BC File Offset: 0x0027C8BC
		public unsafe Cleaner AssignedCleaner
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerUIElement.NativeMethodInfoPtr_get_AssignedCleaner_Public_get_Cleaner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Cleaner>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerUIElement.NativeMethodInfoPtr_set_AssignedCleaner_Protected_set_Void_Cleaner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009DCA RID: 40394 RVA: 0x0027E700 File Offset: 0x0027C900
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279944, RefRangeEnd = 279945, XrefRangeStart = 279933, XrefRangeEnd = 279944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Cleaner cleaner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cleaner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerUIElement.NativeMethodInfoPtr_Initialize_Public_Void_Cleaner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DCB RID: 40395 RVA: 0x0027E744 File Offset: 0x0027C944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279945, XrefRangeEnd = 279958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CleanerUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DCC RID: 40396 RVA: 0x0027E780 File Offset: 0x0027C980
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CleanerUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CleanerUIElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DCD RID: 40397 RVA: 0x0004D6BE File Offset: 0x0004B8BE
		public CleanerUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003098 RID: 12440
		// (get) Token: 0x06009DCE RID: 40398 RVA: 0x0027E7BC File Offset: 0x0027C9BC
		// (set) Token: 0x06009DCF RID: 40399 RVA: 0x0004D6C7 File Offset: 0x0004B8C7
		public unsafe Il2CppReferenceArray<Image> StationsIcons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerUIElement.NativeFieldInfoPtr_StationsIcons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Image>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerUIElement.NativeFieldInfoPtr_StationsIcons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003099 RID: 12441
		// (get) Token: 0x06009DD0 RID: 40400 RVA: 0x0027E7EC File Offset: 0x0027C9EC
		// (set) Token: 0x06009DD1 RID: 40401 RVA: 0x0004D6E6 File Offset: 0x0004B8E6
		public unsafe Cleaner _AssignedCleaner_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerUIElement.NativeFieldInfoPtr__AssignedCleaner_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cleaner>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerUIElement.NativeFieldInfoPtr__AssignedCleaner_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040069EF RID: 27119
		private static readonly IntPtr NativeFieldInfoPtr_StationsIcons;

		// Token: 0x040069F0 RID: 27120
		private static readonly IntPtr NativeFieldInfoPtr__AssignedCleaner_k__BackingField;

		// Token: 0x040069F1 RID: 27121
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedCleaner_Public_get_Cleaner_0;

		// Token: 0x040069F2 RID: 27122
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedCleaner_Protected_set_Void_Cleaner_0;

		// Token: 0x040069F3 RID: 27123
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Cleaner_0;

		// Token: 0x040069F4 RID: 27124
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x040069F5 RID: 27125
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
