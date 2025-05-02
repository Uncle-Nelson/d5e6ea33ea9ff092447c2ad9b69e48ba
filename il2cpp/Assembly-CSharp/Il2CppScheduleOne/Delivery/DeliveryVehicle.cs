using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Vehicles;
using UnityEngine;

namespace Il2CppScheduleOne.Delivery
{
	// Token: 0x0200047C RID: 1148
	public class DeliveryVehicle : MonoBehaviour
	{
		// Token: 0x06006364 RID: 25444 RVA: 0x001C2F5C File Offset: 0x001C115C
		// Note: this type is marked as 'beforefieldinit'.
		static DeliveryVehicle()
		{
			Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Delivery", "DeliveryVehicle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr);
			DeliveryVehicle.NativeFieldInfoPtr__Vehicle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr, "<Vehicle>k__BackingField");
			DeliveryVehicle.NativeFieldInfoPtr__ActiveDelivery_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr, "<ActiveDelivery>k__BackingField");
			DeliveryVehicle.NativeFieldInfoPtr_GUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr, "GUID");
			DeliveryVehicle.NativeMethodInfoPtr_get_Vehicle_Public_get_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr, 100675902);
			DeliveryVehicle.NativeMethodInfoPtr_set_Vehicle_Private_set_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr, 100675903);
			DeliveryVehicle.NativeMethodInfoPtr_get_ActiveDelivery_Public_get_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr, 100675904);
			DeliveryVehicle.NativeMethodInfoPtr_set_ActiveDelivery_Private_set_Void_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr, 100675905);
			DeliveryVehicle.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr, 100675906);
			DeliveryVehicle.NativeMethodInfoPtr_Activate_Public_Void_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr, 100675907);
			DeliveryVehicle.NativeMethodInfoPtr_Deactivate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr, 100675908);
			DeliveryVehicle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr, 100675909);
		}

		// Token: 0x17001DF2 RID: 7666
		// (get) Token: 0x06006365 RID: 25445 RVA: 0x001C3068 File Offset: 0x001C1268
		// (set) Token: 0x06006366 RID: 25446 RVA: 0x001C30A8 File Offset: 0x001C12A8
		public unsafe LandVehicle Vehicle
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17399, RefRangeEnd = 17400, XrefRangeStart = 17399, XrefRangeEnd = 17400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryVehicle.NativeMethodInfoPtr_get_Vehicle_Public_get_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryVehicle.NativeMethodInfoPtr_set_Vehicle_Private_set_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001DF3 RID: 7667
		// (get) Token: 0x06006367 RID: 25447 RVA: 0x001C30EC File Offset: 0x001C12EC
		// (set) Token: 0x06006368 RID: 25448 RVA: 0x001C312C File Offset: 0x001C132C
		public unsafe DeliveryInstance ActiveDelivery
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19637, RefRangeEnd = 19640, XrefRangeStart = 19637, XrefRangeEnd = 19640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryVehicle.NativeMethodInfoPtr_get_ActiveDelivery_Public_get_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeliveryInstance>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19641, RefRangeEnd = 19644, XrefRangeStart = 19641, XrefRangeEnd = 19644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryVehicle.NativeMethodInfoPtr_set_ActiveDelivery_Private_set_Void_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006369 RID: 25449 RVA: 0x001C3170 File Offset: 0x001C1370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203577, XrefRangeEnd = 203583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryVehicle.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600636A RID: 25450 RVA: 0x001C31A4 File Offset: 0x001C13A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 203609, RefRangeEnd = 203610, XrefRangeStart = 203583, XrefRangeEnd = 203609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Activate(DeliveryInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryVehicle.NativeMethodInfoPtr_Activate_Public_Void_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600636B RID: 25451 RVA: 0x001C31E8 File Offset: 0x001C13E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 203631, RefRangeEnd = 203633, XrefRangeStart = 203610, XrefRangeEnd = 203631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryVehicle.NativeMethodInfoPtr_Deactivate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600636C RID: 25452 RVA: 0x001C321C File Offset: 0x001C141C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203633, XrefRangeEnd = 203637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryVehicle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryVehicle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600636D RID: 25453 RVA: 0x0002EFC5 File Offset: 0x0002D1C5
		public DeliveryVehicle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001DEF RID: 7663
		// (get) Token: 0x0600636E RID: 25454 RVA: 0x001C3258 File Offset: 0x001C1458
		// (set) Token: 0x0600636F RID: 25455 RVA: 0x0002EFCE File Offset: 0x0002D1CE
		public unsafe LandVehicle _Vehicle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryVehicle.NativeFieldInfoPtr__Vehicle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryVehicle.NativeFieldInfoPtr__Vehicle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DF0 RID: 7664
		// (get) Token: 0x06006370 RID: 25456 RVA: 0x001C3288 File Offset: 0x001C1488
		// (set) Token: 0x06006371 RID: 25457 RVA: 0x0002EFED File Offset: 0x0002D1ED
		public unsafe DeliveryInstance _ActiveDelivery_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryVehicle.NativeFieldInfoPtr__ActiveDelivery_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryVehicle.NativeFieldInfoPtr__ActiveDelivery_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DF1 RID: 7665
		// (get) Token: 0x06006372 RID: 25458 RVA: 0x001C32B8 File Offset: 0x001C14B8
		// (set) Token: 0x06006373 RID: 25459 RVA: 0x0002F00C File Offset: 0x0002D20C
		public unsafe string GUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryVehicle.NativeFieldInfoPtr_GUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryVehicle.NativeFieldInfoPtr_GUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040043D5 RID: 17365
		private static readonly IntPtr NativeFieldInfoPtr__Vehicle_k__BackingField;

		// Token: 0x040043D6 RID: 17366
		private static readonly IntPtr NativeFieldInfoPtr__ActiveDelivery_k__BackingField;

		// Token: 0x040043D7 RID: 17367
		private static readonly IntPtr NativeFieldInfoPtr_GUID;

		// Token: 0x040043D8 RID: 17368
		private static readonly IntPtr NativeMethodInfoPtr_get_Vehicle_Public_get_LandVehicle_0;

		// Token: 0x040043D9 RID: 17369
		private static readonly IntPtr NativeMethodInfoPtr_set_Vehicle_Private_set_Void_LandVehicle_0;

		// Token: 0x040043DA RID: 17370
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveDelivery_Public_get_DeliveryInstance_0;

		// Token: 0x040043DB RID: 17371
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveDelivery_Private_set_Void_DeliveryInstance_0;

		// Token: 0x040043DC RID: 17372
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040043DD RID: 17373
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Void_DeliveryInstance_0;

		// Token: 0x040043DE RID: 17374
		private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Public_Void_0;

		// Token: 0x040043DF RID: 17375
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
