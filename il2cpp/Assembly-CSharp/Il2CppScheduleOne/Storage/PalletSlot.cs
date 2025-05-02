using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x02000570 RID: 1392
	public class PalletSlot : MonoBehaviour
	{
		// Token: 0x06007A96 RID: 31382 RVA: 0x0021010C File Offset: 0x0020E30C
		// Note: this type is marked as 'beforefieldinit'.
		static PalletSlot()
		{
			Il2CppClassPointerStore<PalletSlot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "PalletSlot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PalletSlot>.NativeClassPtr);
			PalletSlot.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalletSlot>.NativeClassPtr, "<GUID>k__BackingField");
			PalletSlot.NativeFieldInfoPtr__occupant_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalletSlot>.NativeClassPtr, "<occupant>k__BackingField");
			PalletSlot.NativeFieldInfoPtr_onPalletAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalletSlot>.NativeClassPtr, "onPalletAdded");
			PalletSlot.NativeFieldInfoPtr_onPalletRemoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalletSlot>.NativeClassPtr, "onPalletRemoved");
			PalletSlot.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalletSlot>.NativeClassPtr, 100678651);
			PalletSlot.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalletSlot>.NativeClassPtr, 100678652);
			PalletSlot.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalletSlot>.NativeClassPtr, 100678653);
			PalletSlot.NativeMethodInfoPtr_get_occupant_Public_get_Pallet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalletSlot>.NativeClassPtr, 100678654);
			PalletSlot.NativeMethodInfoPtr_set_occupant_Protected_set_Void_Pallet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalletSlot>.NativeClassPtr, 100678655);
			PalletSlot.NativeMethodInfoPtr_SetOccupant_Public_Void_Pallet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalletSlot>.NativeClassPtr, 100678656);
			PalletSlot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalletSlot>.NativeClassPtr, 100678657);
		}

		// Token: 0x17002517 RID: 9495
		// (get) Token: 0x06007A97 RID: 31383 RVA: 0x00210218 File Offset: 0x0020E418
		// (set) Token: 0x06007A98 RID: 31384 RVA: 0x00210254 File Offset: 0x0020E454
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalletSlot.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalletSlot.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007A99 RID: 31385 RVA: 0x00210294 File Offset: 0x0020E494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234980, XrefRangeEnd = 234984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalletSlot.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17002518 RID: 9496
		// (get) Token: 0x06007A9A RID: 31386 RVA: 0x002102D4 File Offset: 0x0020E4D4
		// (set) Token: 0x06007A9B RID: 31387 RVA: 0x00210314 File Offset: 0x0020E514
		public unsafe Pallet occupant
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19644, RefRangeEnd = 19658, XrefRangeStart = 19644, XrefRangeEnd = 19658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalletSlot.NativeMethodInfoPtr_get_occupant_Public_get_Pallet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Pallet>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 19659, RefRangeEnd = 19660, XrefRangeStart = 19659, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalletSlot.NativeMethodInfoPtr_set_occupant_Protected_set_Void_Pallet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007A9C RID: 31388 RVA: 0x00210358 File Offset: 0x0020E558
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 234990, RefRangeEnd = 234992, XrefRangeStart = 234984, XrefRangeEnd = 234990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOccupant(Pallet _occupant)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_occupant);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalletSlot.NativeMethodInfoPtr_SetOccupant_Public_Void_Pallet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A9D RID: 31389 RVA: 0x0021039C File Offset: 0x0020E59C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PalletSlot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PalletSlot>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalletSlot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A9E RID: 31390 RVA: 0x0003A490 File Offset: 0x00038690
		public PalletSlot(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002513 RID: 9491
		// (get) Token: 0x06007A9F RID: 31391 RVA: 0x002103D8 File Offset: 0x0020E5D8
		// (set) Token: 0x06007AA0 RID: 31392 RVA: 0x0003A499 File Offset: 0x00038699
		public unsafe Guid _GUID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalletSlot.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalletSlot.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x17002514 RID: 9492
		// (get) Token: 0x06007AA1 RID: 31393 RVA: 0x00210400 File Offset: 0x0020E600
		// (set) Token: 0x06007AA2 RID: 31394 RVA: 0x0003A4B4 File Offset: 0x000386B4
		public unsafe Pallet _occupant_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalletSlot.NativeFieldInfoPtr__occupant_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pallet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalletSlot.NativeFieldInfoPtr__occupant_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002515 RID: 9493
		// (get) Token: 0x06007AA3 RID: 31395 RVA: 0x00210430 File Offset: 0x0020E630
		// (set) Token: 0x06007AA4 RID: 31396 RVA: 0x0003A4D3 File Offset: 0x000386D3
		public unsafe Action onPalletAdded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalletSlot.NativeFieldInfoPtr_onPalletAdded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalletSlot.NativeFieldInfoPtr_onPalletAdded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002516 RID: 9494
		// (get) Token: 0x06007AA5 RID: 31397 RVA: 0x00210460 File Offset: 0x0020E660
		// (set) Token: 0x06007AA6 RID: 31398 RVA: 0x0003A4F2 File Offset: 0x000386F2
		public unsafe Action onPalletRemoved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalletSlot.NativeFieldInfoPtr_onPalletRemoved);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalletSlot.NativeFieldInfoPtr_onPalletRemoved), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005370 RID: 21360
		private static readonly IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x04005371 RID: 21361
		private static readonly IntPtr NativeFieldInfoPtr__occupant_k__BackingField;

		// Token: 0x04005372 RID: 21362
		private static readonly IntPtr NativeFieldInfoPtr_onPalletAdded;

		// Token: 0x04005373 RID: 21363
		private static readonly IntPtr NativeFieldInfoPtr_onPalletRemoved;

		// Token: 0x04005374 RID: 21364
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x04005375 RID: 21365
		private static readonly IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x04005376 RID: 21366
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x04005377 RID: 21367
		private static readonly IntPtr NativeMethodInfoPtr_get_occupant_Public_get_Pallet_0;

		// Token: 0x04005378 RID: 21368
		private static readonly IntPtr NativeMethodInfoPtr_set_occupant_Protected_set_Void_Pallet_0;

		// Token: 0x04005379 RID: 21369
		private static readonly IntPtr NativeMethodInfoPtr_SetOccupant_Public_Void_Pallet_0;

		// Token: 0x0400537A RID: 21370
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
