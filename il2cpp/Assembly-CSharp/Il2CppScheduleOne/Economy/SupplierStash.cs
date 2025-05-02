using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.NPCs.Relation;
using Il2CppScheduleOne.Storage;
using UnityEngine;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x0200041D RID: 1053
	public class SupplierStash : MonoBehaviour
	{
		// Token: 0x06005C6A RID: 23658 RVA: 0x001ABC2C File Offset: 0x001A9E2C
		// Note: this type is marked as 'beforefieldinit'.
		static SupplierStash()
		{
			Il2CppClassPointerStore<SupplierStash>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "SupplierStash");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr);
			SupplierStash.NativeFieldInfoPtr_locationDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, "locationDescription");
			SupplierStash.NativeFieldInfoPtr_Supplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, "Supplier");
			SupplierStash.NativeFieldInfoPtr_Storage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, "Storage");
			SupplierStash.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, "IntObj");
			SupplierStash.NativeFieldInfoPtr_Light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, "Light");
			SupplierStash.NativeFieldInfoPtr_StashPoI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, "StashPoI");
			SupplierStash.NativeFieldInfoPtr__CashAmount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, "<CashAmount>k__BackingField");
			SupplierStash.NativeMethodInfoPtr_get_CashAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, 100675084);
			SupplierStash.NativeMethodInfoPtr_set_CashAmount_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, 100675085);
			SupplierStash.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, 100675086);
			SupplierStash.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, 100675087);
			SupplierStash.NativeMethodInfoPtr_SupplierUnlocked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, 100675088);
			SupplierStash.NativeMethodInfoPtr_RecalculateCash_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, 100675089);
			SupplierStash.NativeMethodInfoPtr_Interacted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, 100675090);
			SupplierStash.NativeMethodInfoPtr_RemoveCash_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, 100675091);
			SupplierStash.NativeMethodInfoPtr_UpdateDeadDrop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, 100675092);
			SupplierStash.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, 100675093);
			SupplierStash.NativeMethodInfoPtr__Awake_b__10_0_Private_Void_EUnlockType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, 100675094);
		}

		// Token: 0x17001BD6 RID: 7126
		// (get) Token: 0x06005C6B RID: 23659 RVA: 0x001ABDC4 File Offset: 0x001A9FC4
		// (set) Token: 0x06005C6C RID: 23660 RVA: 0x001ABE00 File Offset: 0x001AA000
		public unsafe float CashAmount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierStash.NativeMethodInfoPtr_get_CashAmount_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierStash.NativeMethodInfoPtr_set_CashAmount_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005C6D RID: 23661 RVA: 0x001ABE40 File Offset: 0x001AA040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194915, XrefRangeEnd = 194976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SupplierStash.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C6E RID: 23662 RVA: 0x001ABE7C File Offset: 0x001AA07C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194976, XrefRangeEnd = 194991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SupplierStash.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C6F RID: 23663 RVA: 0x001ABEB8 File Offset: 0x001AA0B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194991, XrefRangeEnd = 195002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SupplierUnlocked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierStash.NativeMethodInfoPtr_SupplierUnlocked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C70 RID: 23664 RVA: 0x001ABEEC File Offset: 0x001AA0EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195016, RefRangeEnd = 195017, XrefRangeStart = 195002, XrefRangeEnd = 195016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateCash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierStash.NativeMethodInfoPtr_RecalculateCash_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C71 RID: 23665 RVA: 0x001ABF20 File Offset: 0x001AA120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195017, XrefRangeEnd = 195037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierStash.NativeMethodInfoPtr_Interacted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C72 RID: 23666 RVA: 0x001ABF54 File Offset: 0x001AA154
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195052, RefRangeEnd = 195053, XrefRangeStart = 195037, XrefRangeEnd = 195052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveCash(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierStash.NativeMethodInfoPtr_RemoveCash_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C73 RID: 23667 RVA: 0x001ABF94 File Offset: 0x001AA194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195053, XrefRangeEnd = 195054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDeadDrop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierStash.NativeMethodInfoPtr_UpdateDeadDrop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C74 RID: 23668 RVA: 0x001ABFC8 File Offset: 0x001AA1C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195054, XrefRangeEnd = 195059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SupplierStash() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierStash.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C75 RID: 23669 RVA: 0x001AC004 File Offset: 0x001AA204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__10_0(NPCRelationData.EUnlockType type, bool b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierStash.NativeMethodInfoPtr__Awake_b__10_0_Private_Void_EUnlockType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C76 RID: 23670 RVA: 0x0002B913 File Offset: 0x00029B13
		public SupplierStash(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001BCF RID: 7119
		// (get) Token: 0x06005C77 RID: 23671 RVA: 0x001AC050 File Offset: 0x001AA250
		// (set) Token: 0x06005C78 RID: 23672 RVA: 0x0002B91C File Offset: 0x00029B1C
		public unsafe string locationDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr_locationDescription);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr_locationDescription), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001BD0 RID: 7120
		// (get) Token: 0x06005C79 RID: 23673 RVA: 0x001AC078 File Offset: 0x001AA278
		// (set) Token: 0x06005C7A RID: 23674 RVA: 0x0002B93B File Offset: 0x00029B3B
		public unsafe Supplier Supplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr_Supplier);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Supplier>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr_Supplier), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BD1 RID: 7121
		// (get) Token: 0x06005C7B RID: 23675 RVA: 0x001AC0A8 File Offset: 0x001AA2A8
		// (set) Token: 0x06005C7C RID: 23676 RVA: 0x0002B95A File Offset: 0x00029B5A
		public unsafe StorageEntity Storage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr_Storage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr_Storage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BD2 RID: 7122
		// (get) Token: 0x06005C7D RID: 23677 RVA: 0x001AC0D8 File Offset: 0x001AA2D8
		// (set) Token: 0x06005C7E RID: 23678 RVA: 0x0002B979 File Offset: 0x00029B79
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BD3 RID: 7123
		// (get) Token: 0x06005C7F RID: 23679 RVA: 0x001AC108 File Offset: 0x001AA308
		// (set) Token: 0x06005C80 RID: 23680 RVA: 0x0002B998 File Offset: 0x00029B98
		public unsafe OptimizedLight Light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr_Light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OptimizedLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr_Light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BD4 RID: 7124
		// (get) Token: 0x06005C81 RID: 23681 RVA: 0x001AC138 File Offset: 0x001AA338
		// (set) Token: 0x06005C82 RID: 23682 RVA: 0x0002B9B7 File Offset: 0x00029BB7
		public unsafe POI StashPoI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr_StashPoI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<POI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr_StashPoI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BD5 RID: 7125
		// (get) Token: 0x06005C83 RID: 23683 RVA: 0x001AC168 File Offset: 0x001AA368
		// (set) Token: 0x06005C84 RID: 23684 RVA: 0x0002B9D6 File Offset: 0x00029BD6
		public unsafe float _CashAmount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr__CashAmount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr__CashAmount_k__BackingField)) = value;
			}
		}

		// Token: 0x04003F37 RID: 16183
		private static readonly IntPtr NativeFieldInfoPtr_locationDescription;

		// Token: 0x04003F38 RID: 16184
		private static readonly IntPtr NativeFieldInfoPtr_Supplier;

		// Token: 0x04003F39 RID: 16185
		private static readonly IntPtr NativeFieldInfoPtr_Storage;

		// Token: 0x04003F3A RID: 16186
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x04003F3B RID: 16187
		private static readonly IntPtr NativeFieldInfoPtr_Light;

		// Token: 0x04003F3C RID: 16188
		private static readonly IntPtr NativeFieldInfoPtr_StashPoI;

		// Token: 0x04003F3D RID: 16189
		private static readonly IntPtr NativeFieldInfoPtr__CashAmount_k__BackingField;

		// Token: 0x04003F3E RID: 16190
		private static readonly IntPtr NativeMethodInfoPtr_get_CashAmount_Public_get_Single_0;

		// Token: 0x04003F3F RID: 16191
		private static readonly IntPtr NativeMethodInfoPtr_set_CashAmount_Private_set_Void_Single_0;

		// Token: 0x04003F40 RID: 16192
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04003F41 RID: 16193
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04003F42 RID: 16194
		private static readonly IntPtr NativeMethodInfoPtr_SupplierUnlocked_Private_Void_0;

		// Token: 0x04003F43 RID: 16195
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateCash_Private_Void_0;

		// Token: 0x04003F44 RID: 16196
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Private_Void_0;

		// Token: 0x04003F45 RID: 16197
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCash_Public_Void_Single_0;

		// Token: 0x04003F46 RID: 16198
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDeadDrop_Private_Void_0;

		// Token: 0x04003F47 RID: 16199
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003F48 RID: 16200
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__10_0_Private_Void_EUnlockType_Boolean_0;
	}
}
