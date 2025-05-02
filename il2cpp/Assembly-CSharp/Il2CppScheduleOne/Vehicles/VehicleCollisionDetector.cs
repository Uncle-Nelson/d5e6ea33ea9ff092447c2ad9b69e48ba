using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020004EB RID: 1259
	public class VehicleCollisionDetector : MonoBehaviour
	{
		// Token: 0x06006F37 RID: 28471 RVA: 0x001EAF70 File Offset: 0x001E9170
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleCollisionDetector()
		{
			Il2CppClassPointerStore<VehicleCollisionDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "VehicleCollisionDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleCollisionDetector>.NativeClassPtr);
			VehicleCollisionDetector.NativeFieldInfoPtr_onCollisionEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCollisionDetector>.NativeClassPtr, "onCollisionEnter");
			VehicleCollisionDetector.NativeMethodInfoPtr_OnCollisionEnter_Public_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCollisionDetector>.NativeClassPtr, 100677335);
			VehicleCollisionDetector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCollisionDetector>.NativeClassPtr, 100677336);
		}

		// Token: 0x06006F38 RID: 28472 RVA: 0x001EAFDC File Offset: 0x001E91DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220958, XrefRangeEnd = 220961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCollisionEnter(Collision collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCollisionDetector.NativeMethodInfoPtr_OnCollisionEnter_Public_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F39 RID: 28473 RVA: 0x001EB020 File Offset: 0x001E9220
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleCollisionDetector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleCollisionDetector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCollisionDetector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F3A RID: 28474 RVA: 0x00034A94 File Offset: 0x00032C94
		public VehicleCollisionDetector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002188 RID: 8584
		// (get) Token: 0x06006F3B RID: 28475 RVA: 0x001EB05C File Offset: 0x001E925C
		// (set) Token: 0x06006F3C RID: 28476 RVA: 0x00034A9D File Offset: 0x00032C9D
		public unsafe UnityEvent<Collision> onCollisionEnter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCollisionDetector.NativeFieldInfoPtr_onCollisionEnter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Collision>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCollisionDetector.NativeFieldInfoPtr_onCollisionEnter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004C0C RID: 19468
		private static readonly IntPtr NativeFieldInfoPtr_onCollisionEnter;

		// Token: 0x04004C0D RID: 19469
		private static readonly IntPtr NativeMethodInfoPtr_OnCollisionEnter_Public_Void_Collision_0;

		// Token: 0x04004C0E RID: 19470
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
