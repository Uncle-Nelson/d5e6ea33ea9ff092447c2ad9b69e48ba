using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.Storage;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x0200041B RID: 1051
	public class SupplierLocation : MonoBehaviour
	{
		// Token: 0x06005C48 RID: 23624 RVA: 0x001AB630 File Offset: 0x001A9830
		// Note: this type is marked as 'beforefieldinit'.
		static SupplierLocation()
		{
			Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "SupplierLocation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr);
			SupplierLocation.NativeFieldInfoPtr_AllLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, "AllLocations");
			SupplierLocation.NativeFieldInfoPtr__ActiveSupplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, "<ActiveSupplier>k__BackingField");
			SupplierLocation.NativeFieldInfoPtr_LocationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, "LocationName");
			SupplierLocation.NativeFieldInfoPtr_LocationDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, "LocationDescription");
			SupplierLocation.NativeFieldInfoPtr_GenericContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, "GenericContainer");
			SupplierLocation.NativeFieldInfoPtr_SupplierStandPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, "SupplierStandPoint");
			SupplierLocation.NativeFieldInfoPtr_DeliveryBays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, "DeliveryBays");
			SupplierLocation.NativeFieldInfoPtr_PoI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, "PoI");
			SupplierLocation.NativeFieldInfoPtr_configs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, "configs");
			SupplierLocation.NativeMethodInfoPtr_get_IsOccupied_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, 100675073);
			SupplierLocation.NativeMethodInfoPtr_get_ActiveSupplier_Public_get_Supplier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, 100675074);
			SupplierLocation.NativeMethodInfoPtr_set_ActiveSupplier_Private_set_Void_Supplier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, 100675075);
			SupplierLocation.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, 100675076);
			SupplierLocation.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, 100675077);
			SupplierLocation.NativeMethodInfoPtr_SetActiveSupplier_Public_Void_Supplier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, 100675078);
			SupplierLocation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, 100675079);
		}

		// Token: 0x17001BCC RID: 7116
		// (get) Token: 0x06005C49 RID: 23625 RVA: 0x001AB7A0 File Offset: 0x001A99A0
		public unsafe bool IsOccupied
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194831, XrefRangeEnd = 194835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierLocation.NativeMethodInfoPtr_get_IsOccupied_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001BCD RID: 7117
		// (get) Token: 0x06005C4A RID: 23626 RVA: 0x001AB7DC File Offset: 0x001A99DC
		// (set) Token: 0x06005C4B RID: 23627 RVA: 0x001AB81C File Offset: 0x001A9A1C
		public unsafe Supplier ActiveSupplier
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17399, RefRangeEnd = 17400, XrefRangeStart = 17399, XrefRangeEnd = 17400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierLocation.NativeMethodInfoPtr_get_ActiveSupplier_Public_get_Supplier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Supplier>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierLocation.NativeMethodInfoPtr_set_ActiveSupplier_Private_set_Void_Supplier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005C4C RID: 23628 RVA: 0x001AB860 File Offset: 0x001A9A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194835, XrefRangeEnd = 194860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierLocation.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C4D RID: 23629 RVA: 0x001AB894 File Offset: 0x001A9A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194860, XrefRangeEnd = 194868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierLocation.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C4E RID: 23630 RVA: 0x001AB8C8 File Offset: 0x001A9AC8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 194905, RefRangeEnd = 194908, XrefRangeStart = 194868, XrefRangeEnd = 194905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActiveSupplier(Supplier supplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(supplier);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierLocation.NativeMethodInfoPtr_SetActiveSupplier_Public_Void_Supplier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C4F RID: 23631 RVA: 0x001AB90C File Offset: 0x001A9B0C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SupplierLocation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierLocation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C50 RID: 23632 RVA: 0x0002B7D8 File Offset: 0x000299D8
		public SupplierLocation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001BC3 RID: 7107
		// (get) Token: 0x06005C51 RID: 23633 RVA: 0x001AB948 File Offset: 0x001A9B48
		// (set) Token: 0x06005C52 RID: 23634 RVA: 0x0002B7E1 File Offset: 0x000299E1
		public unsafe static List<SupplierLocation> AllLocations
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SupplierLocation.NativeFieldInfoPtr_AllLocations, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SupplierLocation>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SupplierLocation.NativeFieldInfoPtr_AllLocations, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BC4 RID: 7108
		// (get) Token: 0x06005C53 RID: 23635 RVA: 0x001AB970 File Offset: 0x001A9B70
		// (set) Token: 0x06005C54 RID: 23636 RVA: 0x0002B7F3 File Offset: 0x000299F3
		public unsafe Supplier _ActiveSupplier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr__ActiveSupplier_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Supplier>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr__ActiveSupplier_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BC5 RID: 7109
		// (get) Token: 0x06005C55 RID: 23637 RVA: 0x001AB9A0 File Offset: 0x001A9BA0
		// (set) Token: 0x06005C56 RID: 23638 RVA: 0x0002B812 File Offset: 0x00029A12
		public unsafe string LocationName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_LocationName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_LocationName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001BC6 RID: 7110
		// (get) Token: 0x06005C57 RID: 23639 RVA: 0x001AB9C8 File Offset: 0x001A9BC8
		// (set) Token: 0x06005C58 RID: 23640 RVA: 0x0002B831 File Offset: 0x00029A31
		public unsafe string LocationDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_LocationDescription);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_LocationDescription), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001BC7 RID: 7111
		// (get) Token: 0x06005C59 RID: 23641 RVA: 0x001AB9F0 File Offset: 0x001A9BF0
		// (set) Token: 0x06005C5A RID: 23642 RVA: 0x0002B850 File Offset: 0x00029A50
		public unsafe Transform GenericContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_GenericContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_GenericContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BC8 RID: 7112
		// (get) Token: 0x06005C5B RID: 23643 RVA: 0x001ABA20 File Offset: 0x001A9C20
		// (set) Token: 0x06005C5C RID: 23644 RVA: 0x0002B86F File Offset: 0x00029A6F
		public unsafe Transform SupplierStandPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_SupplierStandPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_SupplierStandPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BC9 RID: 7113
		// (get) Token: 0x06005C5D RID: 23645 RVA: 0x001ABA50 File Offset: 0x001A9C50
		// (set) Token: 0x06005C5E RID: 23646 RVA: 0x0002B88E File Offset: 0x00029A8E
		public unsafe Il2CppReferenceArray<WorldStorageEntity> DeliveryBays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_DeliveryBays);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WorldStorageEntity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_DeliveryBays), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BCA RID: 7114
		// (get) Token: 0x06005C5F RID: 23647 RVA: 0x001ABA80 File Offset: 0x001A9C80
		// (set) Token: 0x06005C60 RID: 23648 RVA: 0x0002B8AD File Offset: 0x00029AAD
		public unsafe POI PoI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_PoI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<POI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_PoI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BCB RID: 7115
		// (get) Token: 0x06005C61 RID: 23649 RVA: 0x001ABAB0 File Offset: 0x001A9CB0
		// (set) Token: 0x06005C62 RID: 23650 RVA: 0x0002B8CC File Offset: 0x00029ACC
		public unsafe Il2CppReferenceArray<SupplierLocationConfiguration> configs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_configs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SupplierLocationConfiguration>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_configs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003F23 RID: 16163
		private static readonly IntPtr NativeFieldInfoPtr_AllLocations;

		// Token: 0x04003F24 RID: 16164
		private static readonly IntPtr NativeFieldInfoPtr__ActiveSupplier_k__BackingField;

		// Token: 0x04003F25 RID: 16165
		private static readonly IntPtr NativeFieldInfoPtr_LocationName;

		// Token: 0x04003F26 RID: 16166
		private static readonly IntPtr NativeFieldInfoPtr_LocationDescription;

		// Token: 0x04003F27 RID: 16167
		private static readonly IntPtr NativeFieldInfoPtr_GenericContainer;

		// Token: 0x04003F28 RID: 16168
		private static readonly IntPtr NativeFieldInfoPtr_SupplierStandPoint;

		// Token: 0x04003F29 RID: 16169
		private static readonly IntPtr NativeFieldInfoPtr_DeliveryBays;

		// Token: 0x04003F2A RID: 16170
		private static readonly IntPtr NativeFieldInfoPtr_PoI;

		// Token: 0x04003F2B RID: 16171
		private static readonly IntPtr NativeFieldInfoPtr_configs;

		// Token: 0x04003F2C RID: 16172
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOccupied_Public_get_Boolean_0;

		// Token: 0x04003F2D RID: 16173
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveSupplier_Public_get_Supplier_0;

		// Token: 0x04003F2E RID: 16174
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveSupplier_Private_set_Void_Supplier_0;

		// Token: 0x04003F2F RID: 16175
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04003F30 RID: 16176
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04003F31 RID: 16177
		private static readonly IntPtr NativeMethodInfoPtr_SetActiveSupplier_Public_Void_Supplier_0;

		// Token: 0x04003F32 RID: 16178
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
