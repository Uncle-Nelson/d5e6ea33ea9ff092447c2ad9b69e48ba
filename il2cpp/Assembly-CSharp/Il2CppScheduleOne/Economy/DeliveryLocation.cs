using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.Quests;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x02000416 RID: 1046
	public class DeliveryLocation : MonoBehaviour
	{
		// Token: 0x06005B9D RID: 23453 RVA: 0x001A9024 File Offset: 0x001A7224
		// Note: this type is marked as 'beforefieldinit'.
		static DeliveryLocation()
		{
			Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "DeliveryLocation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr);
			DeliveryLocation.NativeFieldInfoPtr_LocationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, "LocationName");
			DeliveryLocation.NativeFieldInfoPtr_LocationDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, "LocationDescription");
			DeliveryLocation.NativeFieldInfoPtr_CustomerStandPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, "CustomerStandPoint");
			DeliveryLocation.NativeFieldInfoPtr_TeleportPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, "TeleportPoint");
			DeliveryLocation.NativeFieldInfoPtr_PoI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, "PoI");
			DeliveryLocation.NativeFieldInfoPtr_StaticGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, "StaticGUID");
			DeliveryLocation.NativeFieldInfoPtr_ScheduledContracts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, "ScheduledContracts");
			DeliveryLocation.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, "<GUID>k__BackingField");
			DeliveryLocation.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, 100674980);
			DeliveryLocation.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, 100674981);
			DeliveryLocation.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, 100674982);
			DeliveryLocation.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, 100674983);
			DeliveryLocation.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, 100674984);
			DeliveryLocation.NativeMethodInfoPtr_GetDescription_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, 100674985);
			DeliveryLocation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, 100674986);
		}

		// Token: 0x17001B9A RID: 7066
		// (get) Token: 0x06005B9E RID: 23454 RVA: 0x001A9180 File Offset: 0x001A7380
		// (set) Token: 0x06005B9F RID: 23455 RVA: 0x001A91BC File Offset: 0x001A73BC
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryLocation.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryLocation.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005BA0 RID: 23456 RVA: 0x001A91FC File Offset: 0x001A73FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193555, XrefRangeEnd = 193559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryLocation.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BA1 RID: 23457 RVA: 0x001A923C File Offset: 0x001A743C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193559, XrefRangeEnd = 193580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryLocation.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BA2 RID: 23458 RVA: 0x001A9270 File Offset: 0x001A7470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryLocation.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BA3 RID: 23459 RVA: 0x001A92A4 File Offset: 0x001A74A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 19637, RefRangeEnd = 19640, XrefRangeStart = 19637, XrefRangeEnd = 19640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetDescription()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryLocation.NativeMethodInfoPtr_GetDescription_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005BA4 RID: 23460 RVA: 0x001A92E8 File Offset: 0x001A74E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193580, XrefRangeEnd = 193595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryLocation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryLocation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BA5 RID: 23461 RVA: 0x0002B35E File Offset: 0x0002955E
		public DeliveryLocation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B92 RID: 7058
		// (get) Token: 0x06005BA6 RID: 23462 RVA: 0x001A9324 File Offset: 0x001A7524
		// (set) Token: 0x06005BA7 RID: 23463 RVA: 0x0002B367 File Offset: 0x00029567
		public unsafe string LocationName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_LocationName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_LocationName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001B93 RID: 7059
		// (get) Token: 0x06005BA8 RID: 23464 RVA: 0x001A934C File Offset: 0x001A754C
		// (set) Token: 0x06005BA9 RID: 23465 RVA: 0x0002B386 File Offset: 0x00029586
		public unsafe string LocationDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_LocationDescription);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_LocationDescription), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001B94 RID: 7060
		// (get) Token: 0x06005BAA RID: 23466 RVA: 0x001A9374 File Offset: 0x001A7574
		// (set) Token: 0x06005BAB RID: 23467 RVA: 0x0002B3A5 File Offset: 0x000295A5
		public unsafe Transform CustomerStandPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_CustomerStandPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_CustomerStandPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B95 RID: 7061
		// (get) Token: 0x06005BAC RID: 23468 RVA: 0x001A93A4 File Offset: 0x001A75A4
		// (set) Token: 0x06005BAD RID: 23469 RVA: 0x0002B3C4 File Offset: 0x000295C4
		public unsafe Transform TeleportPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_TeleportPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_TeleportPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B96 RID: 7062
		// (get) Token: 0x06005BAE RID: 23470 RVA: 0x001A93D4 File Offset: 0x001A75D4
		// (set) Token: 0x06005BAF RID: 23471 RVA: 0x0002B3E3 File Offset: 0x000295E3
		public unsafe POI PoI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_PoI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<POI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_PoI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B97 RID: 7063
		// (get) Token: 0x06005BB0 RID: 23472 RVA: 0x001A9404 File Offset: 0x001A7604
		// (set) Token: 0x06005BB1 RID: 23473 RVA: 0x0002B402 File Offset: 0x00029602
		public unsafe string StaticGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_StaticGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_StaticGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001B98 RID: 7064
		// (get) Token: 0x06005BB2 RID: 23474 RVA: 0x001A942C File Offset: 0x001A762C
		// (set) Token: 0x06005BB3 RID: 23475 RVA: 0x0002B421 File Offset: 0x00029621
		public unsafe List<Contract> ScheduledContracts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_ScheduledContracts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Contract>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_ScheduledContracts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B99 RID: 7065
		// (get) Token: 0x06005BB4 RID: 23476 RVA: 0x001A945C File Offset: 0x001A765C
		// (set) Token: 0x06005BB5 RID: 23477 RVA: 0x0002B440 File Offset: 0x00029640
		public unsafe Guid _GUID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x04003EA4 RID: 16036
		private static readonly IntPtr NativeFieldInfoPtr_LocationName;

		// Token: 0x04003EA5 RID: 16037
		private static readonly IntPtr NativeFieldInfoPtr_LocationDescription;

		// Token: 0x04003EA6 RID: 16038
		private static readonly IntPtr NativeFieldInfoPtr_CustomerStandPoint;

		// Token: 0x04003EA7 RID: 16039
		private static readonly IntPtr NativeFieldInfoPtr_TeleportPoint;

		// Token: 0x04003EA8 RID: 16040
		private static readonly IntPtr NativeFieldInfoPtr_PoI;

		// Token: 0x04003EA9 RID: 16041
		private static readonly IntPtr NativeFieldInfoPtr_StaticGUID;

		// Token: 0x04003EAA RID: 16042
		private static readonly IntPtr NativeFieldInfoPtr_ScheduledContracts;

		// Token: 0x04003EAB RID: 16043
		private static readonly IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x04003EAC RID: 16044
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x04003EAD RID: 16045
		private static readonly IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x04003EAE RID: 16046
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x04003EAF RID: 16047
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04003EB0 RID: 16048
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04003EB1 RID: 16049
		private static readonly IntPtr NativeMethodInfoPtr_GetDescription_Public_Virtual_New_String_0;

		// Token: 0x04003EB2 RID: 16050
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
