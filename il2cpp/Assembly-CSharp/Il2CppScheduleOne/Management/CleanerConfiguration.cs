using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x02000388 RID: 904
	public class CleanerConfiguration : EntityConfiguration
	{
		// Token: 0x060046ED RID: 18157 RVA: 0x0015C554 File Offset: 0x0015A754
		// Note: this type is marked as 'beforefieldinit'.
		static CleanerConfiguration()
		{
			Il2CppClassPointerStore<CleanerConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "CleanerConfiguration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CleanerConfiguration>.NativeClassPtr);
			CleanerConfiguration.NativeFieldInfoPtr_Bed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanerConfiguration>.NativeClassPtr, "Bed");
			CleanerConfiguration.NativeFieldInfoPtr_Bins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanerConfiguration>.NativeClassPtr, "Bins");
			CleanerConfiguration.NativeFieldInfoPtr__cleaner_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanerConfiguration>.NativeClassPtr, "<cleaner>k__BackingField");
			CleanerConfiguration.NativeFieldInfoPtr__binItems_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanerConfiguration>.NativeClassPtr, "<binItems>k__BackingField");
			CleanerConfiguration.NativeFieldInfoPtr__bedItem_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanerConfiguration>.NativeClassPtr, "<bedItem>k__BackingField");
			CleanerConfiguration.NativeMethodInfoPtr_get_cleaner_Public_get_Cleaner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerConfiguration>.NativeClassPtr, 100672051);
			CleanerConfiguration.NativeMethodInfoPtr_set_cleaner_Protected_set_Void_Cleaner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerConfiguration>.NativeClassPtr, 100672052);
			CleanerConfiguration.NativeMethodInfoPtr_get_binItems_Public_get_List_1_TrashContainerItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerConfiguration>.NativeClassPtr, 100672053);
			CleanerConfiguration.NativeMethodInfoPtr_set_binItems_Private_set_Void_List_1_TrashContainerItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerConfiguration>.NativeClassPtr, 100672054);
			CleanerConfiguration.NativeMethodInfoPtr_get_bedItem_Public_get_BedItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerConfiguration>.NativeClassPtr, 100672055);
			CleanerConfiguration.NativeMethodInfoPtr_set_bedItem_Private_set_Void_BedItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerConfiguration>.NativeClassPtr, 100672056);
			CleanerConfiguration.NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_Cleaner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerConfiguration>.NativeClassPtr, 100672057);
			CleanerConfiguration.NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerConfiguration>.NativeClassPtr, 100672058);
			CleanerConfiguration.NativeMethodInfoPtr_IsObjValid_Private_Boolean_BuildableItem_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerConfiguration>.NativeClassPtr, 100672059);
			CleanerConfiguration.NativeMethodInfoPtr_AssignedBinsChanged_Public_Void_List_1_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerConfiguration>.NativeClassPtr, 100672060);
			CleanerConfiguration.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerConfiguration>.NativeClassPtr, 100672061);
			CleanerConfiguration.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerConfiguration>.NativeClassPtr, 100672062);
			CleanerConfiguration.NativeMethodInfoPtr_BedChanged_Private_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerConfiguration>.NativeClassPtr, 100672063);
			CleanerConfiguration.NativeMethodInfoPtr___ctor_b__14_0_Private_Void_List_1_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerConfiguration>.NativeClassPtr, 100672064);
		}

		// Token: 0x17001551 RID: 5457
		// (get) Token: 0x060046EE RID: 18158 RVA: 0x0015C700 File Offset: 0x0015A900
		// (set) Token: 0x060046EF RID: 18159 RVA: 0x0015C740 File Offset: 0x0015A940
		public unsafe Cleaner cleaner
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerConfiguration.NativeMethodInfoPtr_get_cleaner_Public_get_Cleaner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerConfiguration.NativeMethodInfoPtr_set_cleaner_Protected_set_Void_Cleaner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001552 RID: 5458
		// (get) Token: 0x060046F0 RID: 18160 RVA: 0x0015C784 File Offset: 0x0015A984
		// (set) Token: 0x060046F1 RID: 18161 RVA: 0x0015C7C4 File Offset: 0x0015A9C4
		public unsafe List<TrashContainerItem> binItems
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 16593, RefRangeEnd = 16594, XrefRangeStart = 16593, XrefRangeEnd = 16594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerConfiguration.NativeMethodInfoPtr_get_binItems_Public_get_List_1_TrashContainerItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TrashContainerItem>>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 38376, RefRangeEnd = 38379, XrefRangeStart = 38376, XrefRangeEnd = 38379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerConfiguration.NativeMethodInfoPtr_set_binItems_Private_set_Void_List_1_TrashContainerItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001553 RID: 5459
		// (get) Token: 0x060046F2 RID: 18162 RVA: 0x0015C808 File Offset: 0x0015AA08
		// (set) Token: 0x060046F3 RID: 18163 RVA: 0x0015C848 File Offset: 0x0015AA48
		public unsafe BedItem bedItem
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerConfiguration.NativeMethodInfoPtr_get_bedItem_Public_get_BedItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BedItem>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerConfiguration.NativeMethodInfoPtr_set_bedItem_Private_set_Void_BedItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060046F4 RID: 18164 RVA: 0x0015C88C File Offset: 0x0015AA8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 160361, RefRangeEnd = 160362, XrefRangeStart = 160284, XrefRangeEnd = 160361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CleanerConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, Cleaner _cleaner) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CleanerConfiguration>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(replicator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(configurable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_cleaner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerConfiguration.NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_Cleaner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046F5 RID: 18165 RVA: 0x0015C8FC File Offset: 0x0015AAFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160362, XrefRangeEnd = 160364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CleanerConfiguration.NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046F6 RID: 18166 RVA: 0x0015C938 File Offset: 0x0015AB38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160364, XrefRangeEnd = 160376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsObjValid(BuildableItem obj, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CleanerConfiguration.NativeMethodInfoPtr_IsObjValid_Private_Boolean_BuildableItem_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060046F7 RID: 18167 RVA: 0x0015C9A0 File Offset: 0x0015ABA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160376, XrefRangeEnd = 160407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignedBinsChanged(List<BuildableItem> objects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerConfiguration.NativeMethodInfoPtr_AssignedBinsChanged_Public_Void_List_1_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046F8 RID: 18168 RVA: 0x0015C9E4 File Offset: 0x0015ABE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160407, XrefRangeEnd = 160412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CleanerConfiguration.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060046F9 RID: 18169 RVA: 0x0015CA2C File Offset: 0x0015AC2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160412, XrefRangeEnd = 160419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CleanerConfiguration.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060046FA RID: 18170 RVA: 0x0015CA70 File Offset: 0x0015AC70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160419, XrefRangeEnd = 160437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BedChanged(BuildableItem newItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newItem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerConfiguration.NativeMethodInfoPtr_BedChanged_Private_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046FB RID: 18171 RVA: 0x0015CAB4 File Offset: 0x0015ACB4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 141891, RefRangeEnd = 141895, XrefRangeStart = 141891, XrefRangeEnd = 141895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__14_0(List<BuildableItem> <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerConfiguration.NativeMethodInfoPtr___ctor_b__14_0_Private_Void_List_1_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046FC RID: 18172 RVA: 0x00022657 File Offset: 0x00020857
		public CleanerConfiguration(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700154C RID: 5452
		// (get) Token: 0x060046FD RID: 18173 RVA: 0x0015CAF8 File Offset: 0x0015ACF8
		// (set) Token: 0x060046FE RID: 18174 RVA: 0x00022660 File Offset: 0x00020860
		public unsafe ObjectField Bed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerConfiguration.NativeFieldInfoPtr_Bed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerConfiguration.NativeFieldInfoPtr_Bed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700154D RID: 5453
		// (get) Token: 0x060046FF RID: 18175 RVA: 0x0015CB28 File Offset: 0x0015AD28
		// (set) Token: 0x06004700 RID: 18176 RVA: 0x0002267F File Offset: 0x0002087F
		public unsafe ObjectListField Bins
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerConfiguration.NativeFieldInfoPtr_Bins);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectListField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerConfiguration.NativeFieldInfoPtr_Bins), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700154E RID: 5454
		// (get) Token: 0x06004701 RID: 18177 RVA: 0x0015CB58 File Offset: 0x0015AD58
		// (set) Token: 0x06004702 RID: 18178 RVA: 0x0002269E File Offset: 0x0002089E
		public unsafe Cleaner _cleaner_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerConfiguration.NativeFieldInfoPtr__cleaner_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cleaner>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerConfiguration.NativeFieldInfoPtr__cleaner_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700154F RID: 5455
		// (get) Token: 0x06004703 RID: 18179 RVA: 0x0015CB88 File Offset: 0x0015AD88
		// (set) Token: 0x06004704 RID: 18180 RVA: 0x000226BD File Offset: 0x000208BD
		public unsafe List<TrashContainerItem> _binItems_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerConfiguration.NativeFieldInfoPtr__binItems_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TrashContainerItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerConfiguration.NativeFieldInfoPtr__binItems_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001550 RID: 5456
		// (get) Token: 0x06004705 RID: 18181 RVA: 0x0015CBB8 File Offset: 0x0015ADB8
		// (set) Token: 0x06004706 RID: 18182 RVA: 0x000226DC File Offset: 0x000208DC
		public unsafe BedItem _bedItem_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerConfiguration.NativeFieldInfoPtr__bedItem_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BedItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerConfiguration.NativeFieldInfoPtr__bedItem_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002FB3 RID: 12211
		private static readonly IntPtr NativeFieldInfoPtr_Bed;

		// Token: 0x04002FB4 RID: 12212
		private static readonly IntPtr NativeFieldInfoPtr_Bins;

		// Token: 0x04002FB5 RID: 12213
		private static readonly IntPtr NativeFieldInfoPtr__cleaner_k__BackingField;

		// Token: 0x04002FB6 RID: 12214
		private static readonly IntPtr NativeFieldInfoPtr__binItems_k__BackingField;

		// Token: 0x04002FB7 RID: 12215
		private static readonly IntPtr NativeFieldInfoPtr__bedItem_k__BackingField;

		// Token: 0x04002FB8 RID: 12216
		private static readonly IntPtr NativeMethodInfoPtr_get_cleaner_Public_get_Cleaner_0;

		// Token: 0x04002FB9 RID: 12217
		private static readonly IntPtr NativeMethodInfoPtr_set_cleaner_Protected_set_Void_Cleaner_0;

		// Token: 0x04002FBA RID: 12218
		private static readonly IntPtr NativeMethodInfoPtr_get_binItems_Public_get_List_1_TrashContainerItem_0;

		// Token: 0x04002FBB RID: 12219
		private static readonly IntPtr NativeMethodInfoPtr_set_binItems_Private_set_Void_List_1_TrashContainerItem_0;

		// Token: 0x04002FBC RID: 12220
		private static readonly IntPtr NativeMethodInfoPtr_get_bedItem_Public_get_BedItem_0;

		// Token: 0x04002FBD RID: 12221
		private static readonly IntPtr NativeMethodInfoPtr_set_bedItem_Private_set_Void_BedItem_0;

		// Token: 0x04002FBE RID: 12222
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_Cleaner_0;

		// Token: 0x04002FBF RID: 12223
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0;

		// Token: 0x04002FC0 RID: 12224
		private static readonly IntPtr NativeMethodInfoPtr_IsObjValid_Private_Boolean_BuildableItem_byref_String_0;

		// Token: 0x04002FC1 RID: 12225
		private static readonly IntPtr NativeMethodInfoPtr_AssignedBinsChanged_Public_Void_List_1_BuildableItem_0;

		// Token: 0x04002FC2 RID: 12226
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0;

		// Token: 0x04002FC3 RID: 12227
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x04002FC4 RID: 12228
		private static readonly IntPtr NativeMethodInfoPtr_BedChanged_Private_Void_BuildableItem_0;

		// Token: 0x04002FC5 RID: 12229
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__14_0_Private_Void_List_1_BuildableItem_0;
	}
}
