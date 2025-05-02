using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006DC RID: 1756
	public class DryingRackUIElement : WorldspaceUIElement
	{
		// Token: 0x06009DD2 RID: 40402 RVA: 0x0027E81C File Offset: 0x0027CA1C
		// Note: this type is marked as 'beforefieldinit'.
		static DryingRackUIElement()
		{
			Il2CppClassPointerStore<DryingRackUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "DryingRackUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DryingRackUIElement>.NativeClassPtr);
			DryingRackUIElement.NativeFieldInfoPtr__AssignedRack_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackUIElement>.NativeClassPtr, "<AssignedRack>k__BackingField");
			DryingRackUIElement.NativeFieldInfoPtr_TargetQualityIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackUIElement>.NativeClassPtr, "TargetQualityIcon");
			DryingRackUIElement.NativeMethodInfoPtr_get_AssignedRack_Public_get_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackUIElement>.NativeClassPtr, 100682651);
			DryingRackUIElement.NativeMethodInfoPtr_set_AssignedRack_Protected_set_Void_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackUIElement>.NativeClassPtr, 100682652);
			DryingRackUIElement.NativeMethodInfoPtr_Initialize_Public_Void_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackUIElement>.NativeClassPtr, 100682653);
			DryingRackUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackUIElement>.NativeClassPtr, 100682654);
			DryingRackUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackUIElement>.NativeClassPtr, 100682655);
		}

		// Token: 0x1700309D RID: 12445
		// (get) Token: 0x06009DD3 RID: 40403 RVA: 0x0027E8D8 File Offset: 0x0027CAD8
		// (set) Token: 0x06009DD4 RID: 40404 RVA: 0x0027E918 File Offset: 0x0027CB18
		public unsafe DryingRack AssignedRack
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 16593, RefRangeEnd = 16594, XrefRangeStart = 16593, XrefRangeEnd = 16594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackUIElement.NativeMethodInfoPtr_get_AssignedRack_Public_get_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DryingRack>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 38376, RefRangeEnd = 38379, XrefRangeStart = 38376, XrefRangeEnd = 38379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackUIElement.NativeMethodInfoPtr_set_AssignedRack_Protected_set_Void_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009DD5 RID: 40405 RVA: 0x0027E95C File Offset: 0x0027CB5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279968, RefRangeEnd = 279969, XrefRangeStart = 279958, XrefRangeEnd = 279968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(DryingRack rack)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rack);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackUIElement.NativeMethodInfoPtr_Initialize_Public_Void_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DD6 RID: 40406 RVA: 0x0027E9A0 File Offset: 0x0027CBA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279969, XrefRangeEnd = 279979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DryingRackUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DD7 RID: 40407 RVA: 0x0027E9DC File Offset: 0x0027CBDC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DryingRackUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DryingRackUIElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DD8 RID: 40408 RVA: 0x0004D705 File Offset: 0x0004B905
		public DryingRackUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700309B RID: 12443
		// (get) Token: 0x06009DD9 RID: 40409 RVA: 0x0027EA18 File Offset: 0x0027CC18
		// (set) Token: 0x06009DDA RID: 40410 RVA: 0x0004D70E File Offset: 0x0004B90E
		public unsafe DryingRack _AssignedRack_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackUIElement.NativeFieldInfoPtr__AssignedRack_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DryingRack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackUIElement.NativeFieldInfoPtr__AssignedRack_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700309C RID: 12444
		// (get) Token: 0x06009DDB RID: 40411 RVA: 0x0027EA48 File Offset: 0x0027CC48
		// (set) Token: 0x06009DDC RID: 40412 RVA: 0x0004D72D File Offset: 0x0004B92D
		public unsafe Image TargetQualityIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackUIElement.NativeFieldInfoPtr_TargetQualityIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackUIElement.NativeFieldInfoPtr_TargetQualityIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040069F6 RID: 27126
		private static readonly IntPtr NativeFieldInfoPtr__AssignedRack_k__BackingField;

		// Token: 0x040069F7 RID: 27127
		private static readonly IntPtr NativeFieldInfoPtr_TargetQualityIcon;

		// Token: 0x040069F8 RID: 27128
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedRack_Public_get_DryingRack_0;

		// Token: 0x040069F9 RID: 27129
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedRack_Protected_set_Void_DryingRack_0;

		// Token: 0x040069FA RID: 27130
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_DryingRack_0;

		// Token: 0x040069FB RID: 27131
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x040069FC RID: 27132
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
