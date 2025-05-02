using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x02000571 RID: 1393
	public class PalletSlotDetector : MonoBehaviour
	{
		// Token: 0x06007AA7 RID: 31399 RVA: 0x00210490 File Offset: 0x0020E690
		// Note: this type is marked as 'beforefieldinit'.
		static PalletSlotDetector()
		{
			Il2CppClassPointerStore<PalletSlotDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "PalletSlotDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PalletSlotDetector>.NativeClassPtr);
			PalletSlotDetector.NativeFieldInfoPtr_pallet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalletSlotDetector>.NativeClassPtr, "pallet");
			PalletSlotDetector.NativeMethodInfoPtr_OnTriggerStay_Protected_Virtual_New_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalletSlotDetector>.NativeClassPtr, 100678658);
			PalletSlotDetector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalletSlotDetector>.NativeClassPtr, 100678659);
		}

		// Token: 0x06007AA8 RID: 31400 RVA: 0x002104FC File Offset: 0x0020E6FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234992, XrefRangeEnd = 234994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnTriggerStay(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PalletSlotDetector.NativeMethodInfoPtr_OnTriggerStay_Protected_Virtual_New_Void_Collider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007AA9 RID: 31401 RVA: 0x0021054C File Offset: 0x0020E74C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PalletSlotDetector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PalletSlotDetector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalletSlotDetector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007AAA RID: 31402 RVA: 0x0003A511 File Offset: 0x00038711
		public PalletSlotDetector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002519 RID: 9497
		// (get) Token: 0x06007AAB RID: 31403 RVA: 0x00210588 File Offset: 0x0020E788
		// (set) Token: 0x06007AAC RID: 31404 RVA: 0x0003A51A File Offset: 0x0003871A
		public unsafe Pallet pallet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalletSlotDetector.NativeFieldInfoPtr_pallet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pallet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalletSlotDetector.NativeFieldInfoPtr_pallet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400537B RID: 21371
		private static readonly IntPtr NativeFieldInfoPtr_pallet;

		// Token: 0x0400537C RID: 21372
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerStay_Protected_Virtual_New_Void_Collider_0;

		// Token: 0x0400537D RID: 21373
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
