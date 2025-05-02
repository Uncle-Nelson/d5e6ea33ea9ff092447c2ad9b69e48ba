using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Trash
{
	// Token: 0x0200051F RID: 1311
	public class TrashContainerCollider : MonoBehaviour
	{
		// Token: 0x060074D2 RID: 29906 RVA: 0x001FD128 File Offset: 0x001FB328
		// Note: this type is marked as 'beforefieldinit'.
		static TrashContainerCollider()
		{
			Il2CppClassPointerStore<TrashContainerCollider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Trash", "TrashContainerCollider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashContainerCollider>.NativeClassPtr);
			TrashContainerCollider.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerCollider>.NativeClassPtr, "Container");
			TrashContainerCollider.NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerCollider>.NativeClassPtr, 100677986);
			TrashContainerCollider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerCollider>.NativeClassPtr, 100677987);
		}

		// Token: 0x060074D3 RID: 29907 RVA: 0x001FD194 File Offset: 0x001FB394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228357, XrefRangeEnd = 228366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerCollider.NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074D4 RID: 29908 RVA: 0x001FD1D8 File Offset: 0x001FB3D8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashContainerCollider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContainerCollider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerCollider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074D5 RID: 29909 RVA: 0x000376F8 File Offset: 0x000358F8
		public TrashContainerCollider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002363 RID: 9059
		// (get) Token: 0x060074D6 RID: 29910 RVA: 0x001FD214 File Offset: 0x001FB414
		// (set) Token: 0x060074D7 RID: 29911 RVA: 0x00037701 File Offset: 0x00035901
		public unsafe TrashContainer Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerCollider.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerCollider.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004FC9 RID: 20425
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04004FCA RID: 20426
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0;

		// Token: 0x04004FCB RID: 20427
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
