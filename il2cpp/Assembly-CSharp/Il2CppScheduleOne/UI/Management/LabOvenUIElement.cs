using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006DD RID: 1757
	public class LabOvenUIElement : WorldspaceUIElement
	{
		// Token: 0x06009DDD RID: 40413 RVA: 0x0027EA78 File Offset: 0x0027CC78
		// Note: this type is marked as 'beforefieldinit'.
		static LabOvenUIElement()
		{
			Il2CppClassPointerStore<LabOvenUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "LabOvenUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabOvenUIElement>.NativeClassPtr);
			LabOvenUIElement.NativeFieldInfoPtr__AssignedOven_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenUIElement>.NativeClassPtr, "<AssignedOven>k__BackingField");
			LabOvenUIElement.NativeMethodInfoPtr_get_AssignedOven_Public_get_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenUIElement>.NativeClassPtr, 100682656);
			LabOvenUIElement.NativeMethodInfoPtr_set_AssignedOven_Protected_set_Void_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenUIElement>.NativeClassPtr, 100682657);
			LabOvenUIElement.NativeMethodInfoPtr_Initialize_Public_Void_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenUIElement>.NativeClassPtr, 100682658);
			LabOvenUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenUIElement>.NativeClassPtr, 100682659);
			LabOvenUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenUIElement>.NativeClassPtr, 100682660);
		}

		// Token: 0x1700309F RID: 12447
		// (get) Token: 0x06009DDE RID: 40414 RVA: 0x0027EB20 File Offset: 0x0027CD20
		// (set) Token: 0x06009DDF RID: 40415 RVA: 0x0027EB60 File Offset: 0x0027CD60
		public unsafe LabOven AssignedOven
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 16593, RefRangeEnd = 16594, XrefRangeStart = 16593, XrefRangeEnd = 16594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenUIElement.NativeMethodInfoPtr_get_AssignedOven_Public_get_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LabOven>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 38376, RefRangeEnd = 38379, XrefRangeStart = 38376, XrefRangeEnd = 38379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenUIElement.NativeMethodInfoPtr_set_AssignedOven_Protected_set_Void_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009DE0 RID: 40416 RVA: 0x0027EBA4 File Offset: 0x0027CDA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279989, RefRangeEnd = 279990, XrefRangeStart = 279979, XrefRangeEnd = 279989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(LabOven oven)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(oven);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenUIElement.NativeMethodInfoPtr_Initialize_Public_Void_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DE1 RID: 40417 RVA: 0x0027EBE8 File Offset: 0x0027CDE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279990, XrefRangeEnd = 279996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabOvenUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DE2 RID: 40418 RVA: 0x0027EC24 File Offset: 0x0027CE24
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabOvenUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabOvenUIElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DE3 RID: 40419 RVA: 0x0004D74C File Offset: 0x0004B94C
		public LabOvenUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700309E RID: 12446
		// (get) Token: 0x06009DE4 RID: 40420 RVA: 0x0027EC60 File Offset: 0x0027CE60
		// (set) Token: 0x06009DE5 RID: 40421 RVA: 0x0004D755 File Offset: 0x0004B955
		public unsafe LabOven _AssignedOven_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenUIElement.NativeFieldInfoPtr__AssignedOven_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabOven>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenUIElement.NativeFieldInfoPtr__AssignedOven_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040069FD RID: 27133
		private static readonly IntPtr NativeFieldInfoPtr__AssignedOven_k__BackingField;

		// Token: 0x040069FE RID: 27134
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedOven_Public_get_LabOven_0;

		// Token: 0x040069FF RID: 27135
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedOven_Protected_set_Void_LabOven_0;

		// Token: 0x04006A00 RID: 27136
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_LabOven_0;

		// Token: 0x04006A01 RID: 27137
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x04006A02 RID: 27138
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
