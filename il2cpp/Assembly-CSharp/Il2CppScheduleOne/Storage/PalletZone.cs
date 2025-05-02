using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x02000572 RID: 1394
	public class PalletZone : MonoBehaviour
	{
		// Token: 0x06007AAD RID: 31405 RVA: 0x002105B8 File Offset: 0x0020E7B8
		// Note: this type is marked as 'beforefieldinit'.
		static PalletZone()
		{
			Il2CppClassPointerStore<PalletZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "PalletZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PalletZone>.NativeClassPtr);
			PalletZone.NativeFieldInfoPtr_pallets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalletZone>.NativeClassPtr, "pallets");
			PalletZone.NativeFieldInfoPtr_palletPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalletZone>.NativeClassPtr, "palletPrefab");
			PalletZone.NativeFieldInfoPtr_orderReceivedThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalletZone>.NativeClassPtr, "orderReceivedThisFrame");
			PalletZone.NativeMethodInfoPtr_get_isClear_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalletZone>.NativeClassPtr, 100678660);
			PalletZone.NativeMethodInfoPtr_OnTriggerStay_Protected_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalletZone>.NativeClassPtr, 100678661);
			PalletZone.NativeMethodInfoPtr_FixedUpdate_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalletZone>.NativeClassPtr, 100678662);
			PalletZone.NativeMethodInfoPtr_LateUpdate_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalletZone>.NativeClassPtr, 100678663);
			PalletZone.NativeMethodInfoPtr_GeneratePallet_Public_Pallet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalletZone>.NativeClassPtr, 100678664);
			PalletZone.NativeMethodInfoPtr_AreAllPalletsClear_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalletZone>.NativeClassPtr, 100678665);
			PalletZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalletZone>.NativeClassPtr, 100678666);
		}

		// Token: 0x1700251D RID: 9501
		// (get) Token: 0x06007AAE RID: 31406 RVA: 0x002106B0 File Offset: 0x0020E8B0
		public unsafe bool isClear
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234994, XrefRangeEnd = 235001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalletZone.NativeMethodInfoPtr_get_isClear_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06007AAF RID: 31407 RVA: 0x002106EC File Offset: 0x0020E8EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235001, XrefRangeEnd = 235014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerStay(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalletZone.NativeMethodInfoPtr_OnTriggerStay_Protected_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007AB0 RID: 31408 RVA: 0x00210730 File Offset: 0x0020E930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235014, XrefRangeEnd = 235016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalletZone.NativeMethodInfoPtr_FixedUpdate_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007AB1 RID: 31409 RVA: 0x00210764 File Offset: 0x0020E964
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 160599, RefRangeEnd = 160612, XrefRangeStart = 160599, XrefRangeEnd = 160612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalletZone.NativeMethodInfoPtr_LateUpdate_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007AB2 RID: 31410 RVA: 0x00210798 File Offset: 0x0020E998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235016, XrefRangeEnd = 235033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Pallet GeneratePallet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalletZone.NativeMethodInfoPtr_GeneratePallet_Public_Pallet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Pallet>(intPtr3) : null;
		}

		// Token: 0x06007AB3 RID: 31411 RVA: 0x002107D8 File Offset: 0x0020E9D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235033, XrefRangeEnd = 235039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreAllPalletsClear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalletZone.NativeMethodInfoPtr_AreAllPalletsClear_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007AB4 RID: 31412 RVA: 0x00210814 File Offset: 0x0020EA14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235039, XrefRangeEnd = 235047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PalletZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PalletZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalletZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007AB5 RID: 31413 RVA: 0x0003A539 File Offset: 0x00038739
		public PalletZone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700251A RID: 9498
		// (get) Token: 0x06007AB6 RID: 31414 RVA: 0x00210850 File Offset: 0x0020EA50
		// (set) Token: 0x06007AB7 RID: 31415 RVA: 0x0003A542 File Offset: 0x00038742
		public unsafe List<Pallet> pallets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalletZone.NativeFieldInfoPtr_pallets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Pallet>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalletZone.NativeFieldInfoPtr_pallets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700251B RID: 9499
		// (get) Token: 0x06007AB8 RID: 31416 RVA: 0x00210880 File Offset: 0x0020EA80
		// (set) Token: 0x06007AB9 RID: 31417 RVA: 0x0003A561 File Offset: 0x00038761
		public unsafe GameObject palletPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalletZone.NativeFieldInfoPtr_palletPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalletZone.NativeFieldInfoPtr_palletPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700251C RID: 9500
		// (get) Token: 0x06007ABA RID: 31418 RVA: 0x002108B0 File Offset: 0x0020EAB0
		// (set) Token: 0x06007ABB RID: 31419 RVA: 0x0003A580 File Offset: 0x00038780
		public unsafe bool orderReceivedThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalletZone.NativeFieldInfoPtr_orderReceivedThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalletZone.NativeFieldInfoPtr_orderReceivedThisFrame)) = value;
			}
		}

		// Token: 0x0400537E RID: 21374
		private static readonly IntPtr NativeFieldInfoPtr_pallets;

		// Token: 0x0400537F RID: 21375
		private static readonly IntPtr NativeFieldInfoPtr_palletPrefab;

		// Token: 0x04005380 RID: 21376
		private static readonly IntPtr NativeFieldInfoPtr_orderReceivedThisFrame;

		// Token: 0x04005381 RID: 21377
		private static readonly IntPtr NativeMethodInfoPtr_get_isClear_Public_get_Boolean_0;

		// Token: 0x04005382 RID: 21378
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerStay_Protected_Void_Collider_0;

		// Token: 0x04005383 RID: 21379
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Void_0;

		// Token: 0x04005384 RID: 21380
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Void_0;

		// Token: 0x04005385 RID: 21381
		private static readonly IntPtr NativeMethodInfoPtr_GeneratePallet_Public_Pallet_0;

		// Token: 0x04005386 RID: 21382
		private static readonly IntPtr NativeMethodInfoPtr_AreAllPalletsClear_Private_Boolean_0;

		// Token: 0x04005387 RID: 21383
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
