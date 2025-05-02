using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020004E5 RID: 1253
	public class PlayerPusher : MonoBehaviour
	{
		// Token: 0x06006EB5 RID: 28341 RVA: 0x001E98E4 File Offset: 0x001E7AE4
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerPusher()
		{
			Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "PlayerPusher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr);
			PlayerPusher.NativeFieldInfoPtr_veh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr, "veh");
			PlayerPusher.NativeFieldInfoPtr_MinSpeedToPush = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr, "MinSpeedToPush");
			PlayerPusher.NativeFieldInfoPtr_MaxPushSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr, "MaxPushSpeed");
			PlayerPusher.NativeFieldInfoPtr_MinPushForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr, "MinPushForce");
			PlayerPusher.NativeFieldInfoPtr_MaxPushForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr, "MaxPushForce");
			PlayerPusher.NativeFieldInfoPtr_collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr, "collider");
			PlayerPusher.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr, 100677297);
			PlayerPusher.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr, 100677298);
			PlayerPusher.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr, 100677299);
			PlayerPusher.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr, 100677300);
		}

		// Token: 0x06006EB6 RID: 28342 RVA: 0x001E99DC File Offset: 0x001E7BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220468, XrefRangeEnd = 220481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPusher.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EB7 RID: 28343 RVA: 0x001E9A10 File Offset: 0x001E7C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220481, XrefRangeEnd = 220484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPusher.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EB8 RID: 28344 RVA: 0x001E9A44 File Offset: 0x001E7C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220484, XrefRangeEnd = 220517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerStay(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPusher.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EB9 RID: 28345 RVA: 0x001E9A88 File Offset: 0x001E7C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220517, XrefRangeEnd = 220518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerPusher() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPusher.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EBA RID: 28346 RVA: 0x0003462B File Offset: 0x0003282B
		public PlayerPusher(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700215E RID: 8542
		// (get) Token: 0x06006EBB RID: 28347 RVA: 0x001E9AC4 File Offset: 0x001E7CC4
		// (set) Token: 0x06006EBC RID: 28348 RVA: 0x00034634 File Offset: 0x00032834
		public unsafe LandVehicle veh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPusher.NativeFieldInfoPtr_veh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPusher.NativeFieldInfoPtr_veh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700215F RID: 8543
		// (get) Token: 0x06006EBD RID: 28349 RVA: 0x001E9AF4 File Offset: 0x001E7CF4
		// (set) Token: 0x06006EBE RID: 28350 RVA: 0x00034653 File Offset: 0x00032853
		public unsafe float MinSpeedToPush
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPusher.NativeFieldInfoPtr_MinSpeedToPush);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPusher.NativeFieldInfoPtr_MinSpeedToPush)) = value;
			}
		}

		// Token: 0x17002160 RID: 8544
		// (get) Token: 0x06006EBF RID: 28351 RVA: 0x001E9B1C File Offset: 0x001E7D1C
		// (set) Token: 0x06006EC0 RID: 28352 RVA: 0x0003466E File Offset: 0x0003286E
		public unsafe float MaxPushSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPusher.NativeFieldInfoPtr_MaxPushSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPusher.NativeFieldInfoPtr_MaxPushSpeed)) = value;
			}
		}

		// Token: 0x17002161 RID: 8545
		// (get) Token: 0x06006EC1 RID: 28353 RVA: 0x001E9B44 File Offset: 0x001E7D44
		// (set) Token: 0x06006EC2 RID: 28354 RVA: 0x00034689 File Offset: 0x00032889
		public unsafe float MinPushForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPusher.NativeFieldInfoPtr_MinPushForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPusher.NativeFieldInfoPtr_MinPushForce)) = value;
			}
		}

		// Token: 0x17002162 RID: 8546
		// (get) Token: 0x06006EC3 RID: 28355 RVA: 0x001E9B6C File Offset: 0x001E7D6C
		// (set) Token: 0x06006EC4 RID: 28356 RVA: 0x000346A4 File Offset: 0x000328A4
		public unsafe float MaxPushForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPusher.NativeFieldInfoPtr_MaxPushForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPusher.NativeFieldInfoPtr_MaxPushForce)) = value;
			}
		}

		// Token: 0x17002163 RID: 8547
		// (get) Token: 0x06006EC5 RID: 28357 RVA: 0x001E9B94 File Offset: 0x001E7D94
		// (set) Token: 0x06006EC6 RID: 28358 RVA: 0x000346BF File Offset: 0x000328BF
		public unsafe Collider collider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPusher.NativeFieldInfoPtr_collider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPusher.NativeFieldInfoPtr_collider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004BBF RID: 19391
		private static readonly IntPtr NativeFieldInfoPtr_veh;

		// Token: 0x04004BC0 RID: 19392
		private static readonly IntPtr NativeFieldInfoPtr_MinSpeedToPush;

		// Token: 0x04004BC1 RID: 19393
		private static readonly IntPtr NativeFieldInfoPtr_MaxPushSpeed;

		// Token: 0x04004BC2 RID: 19394
		private static readonly IntPtr NativeFieldInfoPtr_MinPushForce;

		// Token: 0x04004BC3 RID: 19395
		private static readonly IntPtr NativeFieldInfoPtr_MaxPushForce;

		// Token: 0x04004BC4 RID: 19396
		private static readonly IntPtr NativeFieldInfoPtr_collider;

		// Token: 0x04004BC5 RID: 19397
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004BC6 RID: 19398
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04004BC7 RID: 19399
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0;

		// Token: 0x04004BC8 RID: 19400
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
