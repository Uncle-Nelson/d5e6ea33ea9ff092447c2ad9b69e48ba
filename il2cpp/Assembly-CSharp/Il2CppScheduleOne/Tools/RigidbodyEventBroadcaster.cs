using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200054B RID: 1355
	public class RigidbodyEventBroadcaster : MonoBehaviour
	{
		// Token: 0x060077B9 RID: 30649 RVA: 0x002070F8 File Offset: 0x002052F8
		// Note: this type is marked as 'beforefieldinit'.
		static RigidbodyEventBroadcaster()
		{
			Il2CppClassPointerStore<RigidbodyEventBroadcaster>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "RigidbodyEventBroadcaster");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RigidbodyEventBroadcaster>.NativeClassPtr);
			RigidbodyEventBroadcaster.NativeFieldInfoPtr_onTriggerEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyEventBroadcaster>.NativeClassPtr, "onTriggerEnter");
			RigidbodyEventBroadcaster.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidbodyEventBroadcaster>.NativeClassPtr, 100678367);
			RigidbodyEventBroadcaster.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidbodyEventBroadcaster>.NativeClassPtr, 100678368);
		}

		// Token: 0x060077BA RID: 30650 RVA: 0x00207164 File Offset: 0x00205364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232155, XrefRangeEnd = 232158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RigidbodyEventBroadcaster.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077BB RID: 30651 RVA: 0x002071A8 File Offset: 0x002053A8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RigidbodyEventBroadcaster() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RigidbodyEventBroadcaster>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RigidbodyEventBroadcaster.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077BC RID: 30652 RVA: 0x00038B32 File Offset: 0x00036D32
		public RigidbodyEventBroadcaster(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700242E RID: 9262
		// (get) Token: 0x060077BD RID: 30653 RVA: 0x002071E4 File Offset: 0x002053E4
		// (set) Token: 0x060077BE RID: 30654 RVA: 0x00038B3B File Offset: 0x00036D3B
		public unsafe UnityEvent<Collider> onTriggerEnter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RigidbodyEventBroadcaster.NativeFieldInfoPtr_onTriggerEnter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RigidbodyEventBroadcaster.NativeFieldInfoPtr_onTriggerEnter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040051AF RID: 20911
		private static readonly IntPtr NativeFieldInfoPtr_onTriggerEnter;

		// Token: 0x040051B0 RID: 20912
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0;

		// Token: 0x040051B1 RID: 20913
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
