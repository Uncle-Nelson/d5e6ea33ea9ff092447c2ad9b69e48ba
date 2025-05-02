using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x0200058B RID: 1419
	public class ItemModule : MonoBehaviour
	{
		// Token: 0x06007CEF RID: 31983 RVA: 0x002185D4 File Offset: 0x002167D4
		// Note: this type is marked as 'beforefieldinit'.
		static ItemModule()
		{
			Il2CppClassPointerStore<ItemModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "ItemModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemModule>.NativeClassPtr);
			ItemModule.NativeFieldInfoPtr__Item_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemModule>.NativeClassPtr, "<Item>k__BackingField");
			ItemModule.NativeFieldInfoPtr__IsModuleActive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemModule>.NativeClassPtr, "<IsModuleActive>k__BackingField");
			ItemModule.NativeMethodInfoPtr_get_Item_Public_get_StationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemModule>.NativeClassPtr, 100678947);
			ItemModule.NativeMethodInfoPtr_set_Item_Protected_set_Void_StationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemModule>.NativeClassPtr, 100678948);
			ItemModule.NativeMethodInfoPtr_get_IsModuleActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemModule>.NativeClassPtr, 100678949);
			ItemModule.NativeMethodInfoPtr_set_IsModuleActive_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemModule>.NativeClassPtr, 100678950);
			ItemModule.NativeMethodInfoPtr_ActivateModule_Public_Virtual_New_Void_StationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemModule>.NativeClassPtr, 100678951);
			ItemModule.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemModule>.NativeClassPtr, 100678952);
		}

		// Token: 0x170025CB RID: 9675
		// (get) Token: 0x06007CF0 RID: 31984 RVA: 0x002186A4 File Offset: 0x002168A4
		// (set) Token: 0x06007CF1 RID: 31985 RVA: 0x002186E4 File Offset: 0x002168E4
		public unsafe StationItem Item
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17399, RefRangeEnd = 17400, XrefRangeStart = 17399, XrefRangeEnd = 17400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemModule.NativeMethodInfoPtr_get_Item_Public_get_StationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StationItem>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemModule.NativeMethodInfoPtr_set_Item_Protected_set_Void_StationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170025CC RID: 9676
		// (get) Token: 0x06007CF2 RID: 31986 RVA: 0x00218728 File Offset: 0x00216928
		// (set) Token: 0x06007CF3 RID: 31987 RVA: 0x00218764 File Offset: 0x00216964
		public unsafe bool IsModuleActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemModule.NativeMethodInfoPtr_get_IsModuleActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 37992, RefRangeEnd = 38015, XrefRangeStart = 37992, XrefRangeEnd = 38015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemModule.NativeMethodInfoPtr_set_IsModuleActive_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007CF4 RID: 31988 RVA: 0x002187A4 File Offset: 0x002169A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237794, XrefRangeEnd = 237795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ActivateModule(StationItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemModule.NativeMethodInfoPtr_ActivateModule_Public_Virtual_New_Void_StationItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CF5 RID: 31989 RVA: 0x002187F4 File Offset: 0x002169F4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemModule() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemModule.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CF6 RID: 31990 RVA: 0x0003B52C File Offset: 0x0003972C
		public ItemModule(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170025C9 RID: 9673
		// (get) Token: 0x06007CF7 RID: 31991 RVA: 0x00218830 File Offset: 0x00216A30
		// (set) Token: 0x06007CF8 RID: 31992 RVA: 0x0003B535 File Offset: 0x00039735
		public unsafe StationItem _Item_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemModule.NativeFieldInfoPtr__Item_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemModule.NativeFieldInfoPtr__Item_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025CA RID: 9674
		// (get) Token: 0x06007CF9 RID: 31993 RVA: 0x00218860 File Offset: 0x00216A60
		// (set) Token: 0x06007CFA RID: 31994 RVA: 0x0003B554 File Offset: 0x00039754
		public unsafe bool _IsModuleActive_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemModule.NativeFieldInfoPtr__IsModuleActive_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemModule.NativeFieldInfoPtr__IsModuleActive_k__BackingField)) = value;
			}
		}

		// Token: 0x04005508 RID: 21768
		private static readonly IntPtr NativeFieldInfoPtr__Item_k__BackingField;

		// Token: 0x04005509 RID: 21769
		private static readonly IntPtr NativeFieldInfoPtr__IsModuleActive_k__BackingField;

		// Token: 0x0400550A RID: 21770
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_StationItem_0;

		// Token: 0x0400550B RID: 21771
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Protected_set_Void_StationItem_0;

		// Token: 0x0400550C RID: 21772
		private static readonly IntPtr NativeMethodInfoPtr_get_IsModuleActive_Public_get_Boolean_0;

		// Token: 0x0400550D RID: 21773
		private static readonly IntPtr NativeMethodInfoPtr_set_IsModuleActive_Protected_set_Void_Boolean_0;

		// Token: 0x0400550E RID: 21774
		private static readonly IntPtr NativeMethodInfoPtr_ActivateModule_Public_Virtual_New_Void_StationItem_0;

		// Token: 0x0400550F RID: 21775
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
