using System;
using Il2CppFishNet.Connection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x0200038A RID: 906
	public class EntityConfiguration : Object
	{
		// Token: 0x06004722 RID: 18210 RVA: 0x0015D2C4 File Offset: 0x0015B4C4
		// Note: this type is marked as 'beforefieldinit'.
		static EntityConfiguration()
		{
			Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "EntityConfiguration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr);
			EntityConfiguration.NativeFieldInfoPtr__Replicator_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, "<Replicator>k__BackingField");
			EntityConfiguration.NativeFieldInfoPtr__Configurable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, "<Configurable>k__BackingField");
			EntityConfiguration.NativeFieldInfoPtr_Fields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, "Fields");
			EntityConfiguration.NativeFieldInfoPtr_onChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, "onChanged");
			EntityConfiguration.NativeFieldInfoPtr__IsSelected_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, "<IsSelected>k__BackingField");
			EntityConfiguration.NativeMethodInfoPtr_get_Replicator_Public_get_ConfigurationReplicator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100672080);
			EntityConfiguration.NativeMethodInfoPtr_set_Replicator_Protected_set_Void_ConfigurationReplicator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100672081);
			EntityConfiguration.NativeMethodInfoPtr_get_Configurable_Public_get_IConfigurable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100672082);
			EntityConfiguration.NativeMethodInfoPtr_set_Configurable_Protected_set_Void_IConfigurable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100672083);
			EntityConfiguration.NativeMethodInfoPtr_get_IsSelected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100672084);
			EntityConfiguration.NativeMethodInfoPtr_set_IsSelected_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100672085);
			EntityConfiguration.NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100672086);
			EntityConfiguration.NativeMethodInfoPtr_InvokeChanged_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100672087);
			EntityConfiguration.NativeMethodInfoPtr_ReplicateField_Public_Void_ConfigField_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100672088);
			EntityConfiguration.NativeMethodInfoPtr_ReplicateAllFields_Public_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100672089);
			EntityConfiguration.NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100672090);
			EntityConfiguration.NativeMethodInfoPtr_Selected_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100672091);
			EntityConfiguration.NativeMethodInfoPtr_Deselected_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100672092);
			EntityConfiguration.NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100672093);
			EntityConfiguration.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100672094);
		}

		// Token: 0x17001560 RID: 5472
		// (get) Token: 0x06004723 RID: 18211 RVA: 0x0015D484 File Offset: 0x0015B684
		// (set) Token: 0x06004724 RID: 18212 RVA: 0x0015D4C4 File Offset: 0x0015B6C4
		public unsafe ConfigurationReplicator Replicator
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 17380, RefRangeEnd = 17390, XrefRangeStart = 17380, XrefRangeEnd = 17390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConfiguration.NativeMethodInfoPtr_get_Replicator_Public_get_ConfigurationReplicator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29995, RefRangeEnd = 29997, XrefRangeStart = 29995, XrefRangeEnd = 29997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConfiguration.NativeMethodInfoPtr_set_Replicator_Protected_set_Void_ConfigurationReplicator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001561 RID: 5473
		// (get) Token: 0x06004725 RID: 18213 RVA: 0x0015D508 File Offset: 0x0015B708
		// (set) Token: 0x06004726 RID: 18214 RVA: 0x0015D548 File Offset: 0x0015B748
		public unsafe IConfigurable Configurable
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConfiguration.NativeMethodInfoPtr_get_Configurable_Public_get_IConfigurable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IConfigurable>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConfiguration.NativeMethodInfoPtr_set_Configurable_Protected_set_Void_IConfigurable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001562 RID: 5474
		// (get) Token: 0x06004727 RID: 18215 RVA: 0x0015D58C File Offset: 0x0015B78C
		// (set) Token: 0x06004728 RID: 18216 RVA: 0x0015D5C8 File Offset: 0x0015B7C8
		public unsafe bool IsSelected
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConfiguration.NativeMethodInfoPtr_get_IsSelected_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConfiguration.NativeMethodInfoPtr_set_IsSelected_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004729 RID: 18217 RVA: 0x0015D608 File Offset: 0x0015B808
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 160570, RefRangeEnd = 160582, XrefRangeStart = 160553, XrefRangeEnd = 160570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityConfiguration(ConfigurationReplicator replicator, IConfigurable configurable) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(replicator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(configurable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConfiguration.NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600472A RID: 18218 RVA: 0x0015D668 File Offset: 0x0015B868
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 141891, RefRangeEnd = 141895, XrefRangeStart = 141891, XrefRangeEnd = 141895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConfiguration.NativeMethodInfoPtr_InvokeChanged_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600472B RID: 18219 RVA: 0x0015D69C File Offset: 0x0015B89C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160582, XrefRangeEnd = 160584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplicateField(ConfigField field, NetworkConnection conn = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConfiguration.NativeMethodInfoPtr_ReplicateField_Public_Void_ConfigField_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600472C RID: 18220 RVA: 0x0015D6F0 File Offset: 0x0015B8F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160584, XrefRangeEnd = 160599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplicateAllFields(NetworkConnection conn = null, bool replicateDefaults = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref replicateDefaults;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConfiguration.NativeMethodInfoPtr_ReplicateAllFields_Public_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600472D RID: 18221 RVA: 0x0015D740 File Offset: 0x0015B940
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityConfiguration.NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600472E RID: 18222 RVA: 0x0015D77C File Offset: 0x0015B97C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 77284, RefRangeEnd = 77293, XrefRangeStart = 77284, XrefRangeEnd = 77293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Selected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityConfiguration.NativeMethodInfoPtr_Selected_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600472F RID: 18223 RVA: 0x0015D7B8 File Offset: 0x0015B9B8
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 160599, RefRangeEnd = 160612, XrefRangeStart = 160599, XrefRangeEnd = 160599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Deselected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityConfiguration.NativeMethodInfoPtr_Deselected_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004730 RID: 18224 RVA: 0x0015D7F4 File Offset: 0x0015B9F4
		[CallerCount(183)]
		[CachedScanResults(RefRangeStart = 35953, RefRangeEnd = 36136, XrefRangeStart = 35953, XrefRangeEnd = 36136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityConfiguration.NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004731 RID: 18225 RVA: 0x0015D83C File Offset: 0x0015BA3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160612, XrefRangeEnd = 160614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityConfiguration.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004732 RID: 18226 RVA: 0x0002279F File Offset: 0x0002099F
		public EntityConfiguration(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700155B RID: 5467
		// (get) Token: 0x06004733 RID: 18227 RVA: 0x0015D880 File Offset: 0x0015BA80
		// (set) Token: 0x06004734 RID: 18228 RVA: 0x000227A8 File Offset: 0x000209A8
		public unsafe ConfigurationReplicator _Replicator_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConfiguration.NativeFieldInfoPtr__Replicator_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConfiguration.NativeFieldInfoPtr__Replicator_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700155C RID: 5468
		// (get) Token: 0x06004735 RID: 18229 RVA: 0x0015D8B0 File Offset: 0x0015BAB0
		// (set) Token: 0x06004736 RID: 18230 RVA: 0x000227C7 File Offset: 0x000209C7
		public unsafe IConfigurable _Configurable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConfiguration.NativeFieldInfoPtr__Configurable_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IConfigurable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConfiguration.NativeFieldInfoPtr__Configurable_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700155D RID: 5469
		// (get) Token: 0x06004737 RID: 18231 RVA: 0x0015D8E0 File Offset: 0x0015BAE0
		// (set) Token: 0x06004738 RID: 18232 RVA: 0x000227E6 File Offset: 0x000209E6
		public unsafe List<ConfigField> Fields
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConfiguration.NativeFieldInfoPtr_Fields);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ConfigField>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConfiguration.NativeFieldInfoPtr_Fields), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700155E RID: 5470
		// (get) Token: 0x06004739 RID: 18233 RVA: 0x0015D910 File Offset: 0x0015BB10
		// (set) Token: 0x0600473A RID: 18234 RVA: 0x00022805 File Offset: 0x00020A05
		public unsafe UnityEvent onChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConfiguration.NativeFieldInfoPtr_onChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConfiguration.NativeFieldInfoPtr_onChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700155F RID: 5471
		// (get) Token: 0x0600473B RID: 18235 RVA: 0x0015D940 File Offset: 0x0015BB40
		// (set) Token: 0x0600473C RID: 18236 RVA: 0x00022824 File Offset: 0x00020A24
		public unsafe bool _IsSelected_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConfiguration.NativeFieldInfoPtr__IsSelected_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConfiguration.NativeFieldInfoPtr__IsSelected_k__BackingField)) = value;
			}
		}

		// Token: 0x04002FDA RID: 12250
		private static readonly IntPtr NativeFieldInfoPtr__Replicator_k__BackingField;

		// Token: 0x04002FDB RID: 12251
		private static readonly IntPtr NativeFieldInfoPtr__Configurable_k__BackingField;

		// Token: 0x04002FDC RID: 12252
		private static readonly IntPtr NativeFieldInfoPtr_Fields;

		// Token: 0x04002FDD RID: 12253
		private static readonly IntPtr NativeFieldInfoPtr_onChanged;

		// Token: 0x04002FDE RID: 12254
		private static readonly IntPtr NativeFieldInfoPtr__IsSelected_k__BackingField;

		// Token: 0x04002FDF RID: 12255
		private static readonly IntPtr NativeMethodInfoPtr_get_Replicator_Public_get_ConfigurationReplicator_0;

		// Token: 0x04002FE0 RID: 12256
		private static readonly IntPtr NativeMethodInfoPtr_set_Replicator_Protected_set_Void_ConfigurationReplicator_0;

		// Token: 0x04002FE1 RID: 12257
		private static readonly IntPtr NativeMethodInfoPtr_get_Configurable_Public_get_IConfigurable_0;

		// Token: 0x04002FE2 RID: 12258
		private static readonly IntPtr NativeMethodInfoPtr_set_Configurable_Protected_set_Void_IConfigurable_0;

		// Token: 0x04002FE3 RID: 12259
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSelected_Public_get_Boolean_0;

		// Token: 0x04002FE4 RID: 12260
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSelected_Protected_set_Void_Boolean_0;

		// Token: 0x04002FE5 RID: 12261
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_0;

		// Token: 0x04002FE6 RID: 12262
		private static readonly IntPtr NativeMethodInfoPtr_InvokeChanged_Protected_Void_0;

		// Token: 0x04002FE7 RID: 12263
		private static readonly IntPtr NativeMethodInfoPtr_ReplicateField_Public_Void_ConfigField_NetworkConnection_0;

		// Token: 0x04002FE8 RID: 12264
		private static readonly IntPtr NativeMethodInfoPtr_ReplicateAllFields_Public_Void_NetworkConnection_Boolean_0;

		// Token: 0x04002FE9 RID: 12265
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0;

		// Token: 0x04002FEA RID: 12266
		private static readonly IntPtr NativeMethodInfoPtr_Selected_Public_Virtual_New_Void_0;

		// Token: 0x04002FEB RID: 12267
		private static readonly IntPtr NativeMethodInfoPtr_Deselected_Public_Virtual_New_Void_0;

		// Token: 0x04002FEC RID: 12268
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0;

		// Token: 0x04002FED RID: 12269
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;
	}
}
