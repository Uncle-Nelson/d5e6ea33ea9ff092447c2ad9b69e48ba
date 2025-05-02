using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Doors
{
	// Token: 0x02000425 RID: 1061
	public class DoorSensor : MonoBehaviour
	{
		// Token: 0x06005D6B RID: 23915 RVA: 0x001AF5FC File Offset: 0x001AD7FC
		// Note: this type is marked as 'beforefieldinit'.
		static DoorSensor()
		{
			Il2CppClassPointerStore<DoorSensor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Doors", "DoorSensor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr);
			DoorSensor.NativeFieldInfoPtr_ActivationDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr, "ActivationDistance");
			DoorSensor.NativeFieldInfoPtr_DetectorSide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr, "DetectorSide");
			DoorSensor.NativeFieldInfoPtr_Door = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr, "Door");
			DoorSensor.NativeFieldInfoPtr_exclude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr, "exclude");
			DoorSensor.NativeFieldInfoPtr_collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr, "collider");
			DoorSensor.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr, 100675197);
			DoorSensor.NativeMethodInfoPtr_UpdateCollider_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr, 100675198);
			DoorSensor.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr, 100675199);
			DoorSensor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr, 100675200);
		}

		// Token: 0x06005D6C RID: 23916 RVA: 0x001AF6E0 File Offset: 0x001AD8E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196104, XrefRangeEnd = 196111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorSensor.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D6D RID: 23917 RVA: 0x001AF714 File Offset: 0x001AD914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196111, XrefRangeEnd = 196139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCollider()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorSensor.NativeMethodInfoPtr_UpdateCollider_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D6E RID: 23918 RVA: 0x001AF748 File Offset: 0x001AD948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196139, XrefRangeEnd = 196152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerStay(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorSensor.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D6F RID: 23919 RVA: 0x001AF78C File Offset: 0x001AD98C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196152, XrefRangeEnd = 196160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DoorSensor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorSensor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D70 RID: 23920 RVA: 0x0002C072 File Offset: 0x0002A272
		public DoorSensor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C1E RID: 7198
		// (get) Token: 0x06005D71 RID: 23921 RVA: 0x001AF7C8 File Offset: 0x001AD9C8
		// (set) Token: 0x06005D72 RID: 23922 RVA: 0x0002C07B File Offset: 0x0002A27B
		public unsafe static float ActivationDistance
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DoorSensor.NativeFieldInfoPtr_ActivationDistance, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DoorSensor.NativeFieldInfoPtr_ActivationDistance, (void*)(&value));
			}
		}

		// Token: 0x17001C1F RID: 7199
		// (get) Token: 0x06005D73 RID: 23923 RVA: 0x001AF7E4 File Offset: 0x001AD9E4
		// (set) Token: 0x06005D74 RID: 23924 RVA: 0x0002C089 File Offset: 0x0002A289
		public unsafe EDoorSide DetectorSide
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorSensor.NativeFieldInfoPtr_DetectorSide);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorSensor.NativeFieldInfoPtr_DetectorSide)) = value;
			}
		}

		// Token: 0x17001C20 RID: 7200
		// (get) Token: 0x06005D75 RID: 23925 RVA: 0x001AF80C File Offset: 0x001ADA0C
		// (set) Token: 0x06005D76 RID: 23926 RVA: 0x0002C0A4 File Offset: 0x0002A2A4
		public unsafe DoorController Door
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorSensor.NativeFieldInfoPtr_Door);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DoorController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorSensor.NativeFieldInfoPtr_Door), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C21 RID: 7201
		// (get) Token: 0x06005D77 RID: 23927 RVA: 0x001AF83C File Offset: 0x001ADA3C
		// (set) Token: 0x06005D78 RID: 23928 RVA: 0x0002C0C3 File Offset: 0x0002A2C3
		public unsafe List<Collider> exclude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorSensor.NativeFieldInfoPtr_exclude);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorSensor.NativeFieldInfoPtr_exclude), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C22 RID: 7202
		// (get) Token: 0x06005D79 RID: 23929 RVA: 0x001AF86C File Offset: 0x001ADA6C
		// (set) Token: 0x06005D7A RID: 23930 RVA: 0x0002C0E2 File Offset: 0x0002A2E2
		public unsafe Collider collider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorSensor.NativeFieldInfoPtr_collider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorSensor.NativeFieldInfoPtr_collider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003FF2 RID: 16370
		private static readonly IntPtr NativeFieldInfoPtr_ActivationDistance;

		// Token: 0x04003FF3 RID: 16371
		private static readonly IntPtr NativeFieldInfoPtr_DetectorSide;

		// Token: 0x04003FF4 RID: 16372
		private static readonly IntPtr NativeFieldInfoPtr_Door;

		// Token: 0x04003FF5 RID: 16373
		private static readonly IntPtr NativeFieldInfoPtr_exclude;

		// Token: 0x04003FF6 RID: 16374
		private static readonly IntPtr NativeFieldInfoPtr_collider;

		// Token: 0x04003FF7 RID: 16375
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04003FF8 RID: 16376
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCollider_Private_Void_0;

		// Token: 0x04003FF9 RID: 16377
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0;

		// Token: 0x04003FFA RID: 16378
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
