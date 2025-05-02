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
	// Token: 0x02000383 RID: 899
	public class BotanistConfiguration : EntityConfiguration
	{
		// Token: 0x06004666 RID: 18022 RVA: 0x0015A420 File Offset: 0x00158620
		// Note: this type is marked as 'beforefieldinit'.
		static BotanistConfiguration()
		{
			Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "BotanistConfiguration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr);
			BotanistConfiguration.NativeFieldInfoPtr_Bed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, "Bed");
			BotanistConfiguration.NativeFieldInfoPtr_Supplies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, "Supplies");
			BotanistConfiguration.NativeFieldInfoPtr_AssignedStations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, "AssignedStations");
			BotanistConfiguration.NativeFieldInfoPtr_AssignedPots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, "AssignedPots");
			BotanistConfiguration.NativeFieldInfoPtr_AssignedRacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, "AssignedRacks");
			BotanistConfiguration.NativeFieldInfoPtr__botanist_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, "<botanist>k__BackingField");
			BotanistConfiguration.NativeFieldInfoPtr__bedItem_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, "<bedItem>k__BackingField");
			BotanistConfiguration.NativeMethodInfoPtr_get_botanist_Public_get_Botanist_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, 100671982);
			BotanistConfiguration.NativeMethodInfoPtr_set_botanist_Protected_set_Void_Botanist_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, 100671983);
			BotanistConfiguration.NativeMethodInfoPtr_get_bedItem_Public_get_BedItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, 100671984);
			BotanistConfiguration.NativeMethodInfoPtr_set_bedItem_Private_set_Void_BedItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, 100671985);
			BotanistConfiguration.NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_Botanist_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, 100671986);
			BotanistConfiguration.NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, 100671987);
			BotanistConfiguration.NativeMethodInfoPtr_IsStationValid_Private_Boolean_BuildableItem_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, 100671988);
			BotanistConfiguration.NativeMethodInfoPtr_AssignedPotsChanged_Public_Void_List_1_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, 100671989);
			BotanistConfiguration.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, 100671990);
			BotanistConfiguration.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, 100671991);
			BotanistConfiguration.NativeMethodInfoPtr_BedChanged_Private_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, 100671992);
			BotanistConfiguration.NativeMethodInfoPtr___ctor_b__13_0_Private_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, 100671993);
			BotanistConfiguration.NativeMethodInfoPtr___ctor_b__13_1_Private_Void_List_1_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, 100671994);
		}

		// Token: 0x1700152C RID: 5420
		// (get) Token: 0x06004667 RID: 18023 RVA: 0x0015A5E0 File Offset: 0x001587E0
		// (set) Token: 0x06004668 RID: 18024 RVA: 0x0015A620 File Offset: 0x00158820
		public unsafe Botanist botanist
		{
			[CallerCount(40)]
			[CachedScanResults(RefRangeStart = 47274, RefRangeEnd = 47314, XrefRangeStart = 47274, XrefRangeEnd = 47314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistConfiguration.NativeMethodInfoPtr_get_botanist_Public_get_Botanist_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Botanist>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159130, XrefRangeEnd = 159131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistConfiguration.NativeMethodInfoPtr_set_botanist_Protected_set_Void_Botanist_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700152D RID: 5421
		// (get) Token: 0x06004669 RID: 18025 RVA: 0x0015A664 File Offset: 0x00158864
		// (set) Token: 0x0600466A RID: 18026 RVA: 0x0015A6A4 File Offset: 0x001588A4
		public unsafe BedItem bedItem
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 22951, RefRangeEnd = 22968, XrefRangeStart = 22951, XrefRangeEnd = 22968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistConfiguration.NativeMethodInfoPtr_get_bedItem_Public_get_BedItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BedItem>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159131, XrefRangeEnd = 159132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistConfiguration.NativeMethodInfoPtr_set_bedItem_Private_set_Void_BedItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600466B RID: 18027 RVA: 0x0015A6E8 File Offset: 0x001588E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 159258, RefRangeEnd = 159259, XrefRangeStart = 159132, XrefRangeEnd = 159258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BotanistConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, Botanist _botanist) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(replicator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(configurable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_botanist);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistConfiguration.NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_Botanist_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600466C RID: 18028 RVA: 0x0015A758 File Offset: 0x00158958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159259, XrefRangeEnd = 159310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BotanistConfiguration.NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600466D RID: 18029 RVA: 0x0015A794 File Offset: 0x00158994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159310, XrefRangeEnd = 159357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsStationValid(BuildableItem obj, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BotanistConfiguration.NativeMethodInfoPtr_IsStationValid_Private_Boolean_BuildableItem_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600466E RID: 18030 RVA: 0x0015A7FC File Offset: 0x001589FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159357, XrefRangeEnd = 159433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignedPotsChanged(List<BuildableItem> objects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistConfiguration.NativeMethodInfoPtr_AssignedPotsChanged_Public_Void_List_1_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600466F RID: 18031 RVA: 0x0015A840 File Offset: 0x00158A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159433, XrefRangeEnd = 159442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BotanistConfiguration.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004670 RID: 18032 RVA: 0x0015A888 File Offset: 0x00158A88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159442, XrefRangeEnd = 159450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BotanistConfiguration.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004671 RID: 18033 RVA: 0x0015A8CC File Offset: 0x00158ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159450, XrefRangeEnd = 159468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BedChanged(BuildableItem newItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newItem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistConfiguration.NativeMethodInfoPtr_BedChanged_Private_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004672 RID: 18034 RVA: 0x0015A910 File Offset: 0x00158B10
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 141891, RefRangeEnd = 141895, XrefRangeStart = 141891, XrefRangeEnd = 141895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__13_0(BuildableItem <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistConfiguration.NativeMethodInfoPtr___ctor_b__13_0_Private_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004673 RID: 18035 RVA: 0x0015A954 File Offset: 0x00158B54
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 141891, RefRangeEnd = 141895, XrefRangeStart = 141891, XrefRangeEnd = 141895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__13_1(List<BuildableItem> <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistConfiguration.NativeMethodInfoPtr___ctor_b__13_1_Private_Void_List_1_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004674 RID: 18036 RVA: 0x000222C6 File Offset: 0x000204C6
		public BotanistConfiguration(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001525 RID: 5413
		// (get) Token: 0x06004675 RID: 18037 RVA: 0x0015A998 File Offset: 0x00158B98
		// (set) Token: 0x06004676 RID: 18038 RVA: 0x000222CF File Offset: 0x000204CF
		public unsafe ObjectField Bed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfiguration.NativeFieldInfoPtr_Bed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfiguration.NativeFieldInfoPtr_Bed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001526 RID: 5414
		// (get) Token: 0x06004677 RID: 18039 RVA: 0x0015A9C8 File Offset: 0x00158BC8
		// (set) Token: 0x06004678 RID: 18040 RVA: 0x000222EE File Offset: 0x000204EE
		public unsafe ObjectField Supplies
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfiguration.NativeFieldInfoPtr_Supplies);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfiguration.NativeFieldInfoPtr_Supplies), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001527 RID: 5415
		// (get) Token: 0x06004679 RID: 18041 RVA: 0x0015A9F8 File Offset: 0x00158BF8
		// (set) Token: 0x0600467A RID: 18042 RVA: 0x0002230D File Offset: 0x0002050D
		public unsafe ObjectListField AssignedStations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfiguration.NativeFieldInfoPtr_AssignedStations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectListField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfiguration.NativeFieldInfoPtr_AssignedStations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001528 RID: 5416
		// (get) Token: 0x0600467B RID: 18043 RVA: 0x0015AA28 File Offset: 0x00158C28
		// (set) Token: 0x0600467C RID: 18044 RVA: 0x0002232C File Offset: 0x0002052C
		public unsafe List<Pot> AssignedPots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfiguration.NativeFieldInfoPtr_AssignedPots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Pot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfiguration.NativeFieldInfoPtr_AssignedPots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001529 RID: 5417
		// (get) Token: 0x0600467D RID: 18045 RVA: 0x0015AA58 File Offset: 0x00158C58
		// (set) Token: 0x0600467E RID: 18046 RVA: 0x0002234B File Offset: 0x0002054B
		public unsafe List<DryingRack> AssignedRacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfiguration.NativeFieldInfoPtr_AssignedRacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DryingRack>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfiguration.NativeFieldInfoPtr_AssignedRacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700152A RID: 5418
		// (get) Token: 0x0600467F RID: 18047 RVA: 0x0015AA88 File Offset: 0x00158C88
		// (set) Token: 0x06004680 RID: 18048 RVA: 0x0002236A File Offset: 0x0002056A
		public unsafe Botanist _botanist_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfiguration.NativeFieldInfoPtr__botanist_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Botanist>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfiguration.NativeFieldInfoPtr__botanist_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700152B RID: 5419
		// (get) Token: 0x06004681 RID: 18049 RVA: 0x0015AAB8 File Offset: 0x00158CB8
		// (set) Token: 0x06004682 RID: 18050 RVA: 0x00022389 File Offset: 0x00020589
		public unsafe BedItem _bedItem_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfiguration.NativeFieldInfoPtr__bedItem_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BedItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfiguration.NativeFieldInfoPtr__bedItem_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002F52 RID: 12114
		private static readonly IntPtr NativeFieldInfoPtr_Bed;

		// Token: 0x04002F53 RID: 12115
		private static readonly IntPtr NativeFieldInfoPtr_Supplies;

		// Token: 0x04002F54 RID: 12116
		private static readonly IntPtr NativeFieldInfoPtr_AssignedStations;

		// Token: 0x04002F55 RID: 12117
		private static readonly IntPtr NativeFieldInfoPtr_AssignedPots;

		// Token: 0x04002F56 RID: 12118
		private static readonly IntPtr NativeFieldInfoPtr_AssignedRacks;

		// Token: 0x04002F57 RID: 12119
		private static readonly IntPtr NativeFieldInfoPtr__botanist_k__BackingField;

		// Token: 0x04002F58 RID: 12120
		private static readonly IntPtr NativeFieldInfoPtr__bedItem_k__BackingField;

		// Token: 0x04002F59 RID: 12121
		private static readonly IntPtr NativeMethodInfoPtr_get_botanist_Public_get_Botanist_0;

		// Token: 0x04002F5A RID: 12122
		private static readonly IntPtr NativeMethodInfoPtr_set_botanist_Protected_set_Void_Botanist_0;

		// Token: 0x04002F5B RID: 12123
		private static readonly IntPtr NativeMethodInfoPtr_get_bedItem_Public_get_BedItem_0;

		// Token: 0x04002F5C RID: 12124
		private static readonly IntPtr NativeMethodInfoPtr_set_bedItem_Private_set_Void_BedItem_0;

		// Token: 0x04002F5D RID: 12125
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_Botanist_0;

		// Token: 0x04002F5E RID: 12126
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0;

		// Token: 0x04002F5F RID: 12127
		private static readonly IntPtr NativeMethodInfoPtr_IsStationValid_Private_Boolean_BuildableItem_byref_String_0;

		// Token: 0x04002F60 RID: 12128
		private static readonly IntPtr NativeMethodInfoPtr_AssignedPotsChanged_Public_Void_List_1_BuildableItem_0;

		// Token: 0x04002F61 RID: 12129
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0;

		// Token: 0x04002F62 RID: 12130
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x04002F63 RID: 12131
		private static readonly IntPtr NativeMethodInfoPtr_BedChanged_Private_Void_BuildableItem_0;

		// Token: 0x04002F64 RID: 12132
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__13_0_Private_Void_BuildableItem_0;

		// Token: 0x04002F65 RID: 12133
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__13_1_Private_Void_List_1_BuildableItem_0;
	}
}
