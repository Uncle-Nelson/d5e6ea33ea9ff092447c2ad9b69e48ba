using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.Tools;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x0200077B RID: 1915
	public class ManorGate : Gate
	{
		// Token: 0x0600B57A RID: 46458 RVA: 0x002D1ED8 File Offset: 0x002D00D8
		// Note: this type is marked as 'beforefieldinit'.
		static ManorGate()
		{
			Il2CppClassPointerStore<ManorGate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "ManorGate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManorGate>.NativeClassPtr);
			ManorGate.NativeFieldInfoPtr_IntercomInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, "IntercomInt");
			ManorGate.NativeFieldInfoPtr_IntercomLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, "IntercomLight");
			ManorGate.NativeFieldInfoPtr_ExteriorVehicleDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, "ExteriorVehicleDetector");
			ManorGate.NativeFieldInfoPtr_ExteriorPlayerDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, "ExteriorPlayerDetector");
			ManorGate.NativeFieldInfoPtr_InteriorVehicleDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, "InteriorVehicleDetector");
			ManorGate.NativeFieldInfoPtr_InteriorPlayerDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, "InteriorPlayerDetector");
			ManorGate.NativeFieldInfoPtr_intercomActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, "intercomActive");
			ManorGate.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, 100685602);
			ManorGate.NativeMethodInfoPtr_UpdateDetection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, 100685603);
			ManorGate.NativeMethodInfoPtr_IntercomBuzzed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, 100685604);
			ManorGate.NativeMethodInfoPtr_SetEnterable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, 100685605);
			ManorGate.NativeMethodInfoPtr_ActivateIntercom_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, 100685606);
			ManorGate.NativeMethodInfoPtr_SetIntercomActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, 100685607);
			ManorGate.NativeMethodInfoPtr_UpdateIntercom_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, 100685608);
			ManorGate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, 100685609);
		}

		// Token: 0x0600B57B RID: 46459 RVA: 0x002D2034 File Offset: 0x002D0234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310414, XrefRangeEnd = 310422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManorGate.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B57C RID: 46460 RVA: 0x002D2070 File Offset: 0x002D0270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310422, XrefRangeEnd = 310426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDetection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManorGate.NativeMethodInfoPtr_UpdateDetection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B57D RID: 46461 RVA: 0x002D20A4 File Offset: 0x002D02A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310426, XrefRangeEnd = 310428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IntercomBuzzed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManorGate.NativeMethodInfoPtr_IntercomBuzzed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B57E RID: 46462 RVA: 0x002D20D8 File Offset: 0x002D02D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 310432, RefRangeEnd = 310433, XrefRangeStart = 310428, XrefRangeEnd = 310432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEnterable(bool enterable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enterable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManorGate.NativeMethodInfoPtr_SetEnterable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B57F RID: 46463 RVA: 0x002D2118 File Offset: 0x002D0318
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 310435, RefRangeEnd = 310438, XrefRangeStart = 310433, XrefRangeEnd = 310435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivateIntercom()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManorGate.NativeMethodInfoPtr_ActivateIntercom_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B580 RID: 46464 RVA: 0x002D214C File Offset: 0x002D034C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310438, XrefRangeEnd = 310440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIntercomActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManorGate.NativeMethodInfoPtr_SetIntercomActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B581 RID: 46465 RVA: 0x002D218C File Offset: 0x002D038C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310440, XrefRangeEnd = 310442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateIntercom()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManorGate.NativeMethodInfoPtr_UpdateIntercom_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B582 RID: 46466 RVA: 0x002D21C0 File Offset: 0x002D03C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManorGate() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManorGate>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManorGate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B583 RID: 46467 RVA: 0x00059125 File Offset: 0x00057325
		public ManorGate(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003844 RID: 14404
		// (get) Token: 0x0600B584 RID: 46468 RVA: 0x002D21FC File Offset: 0x002D03FC
		// (set) Token: 0x0600B585 RID: 46469 RVA: 0x0005912E File Offset: 0x0005732E
		public unsafe InteractableObject IntercomInt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_IntercomInt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_IntercomInt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003845 RID: 14405
		// (get) Token: 0x0600B586 RID: 46470 RVA: 0x002D222C File Offset: 0x002D042C
		// (set) Token: 0x0600B587 RID: 46471 RVA: 0x0005914D File Offset: 0x0005734D
		public unsafe Light IntercomLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_IntercomLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_IntercomLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003846 RID: 14406
		// (get) Token: 0x0600B588 RID: 46472 RVA: 0x002D225C File Offset: 0x002D045C
		// (set) Token: 0x0600B589 RID: 46473 RVA: 0x0005916C File Offset: 0x0005736C
		public unsafe VehicleDetector ExteriorVehicleDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_ExteriorVehicleDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_ExteriorVehicleDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003847 RID: 14407
		// (get) Token: 0x0600B58A RID: 46474 RVA: 0x002D228C File Offset: 0x002D048C
		// (set) Token: 0x0600B58B RID: 46475 RVA: 0x0005918B File Offset: 0x0005738B
		public unsafe PlayerDetector ExteriorPlayerDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_ExteriorPlayerDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_ExteriorPlayerDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003848 RID: 14408
		// (get) Token: 0x0600B58C RID: 46476 RVA: 0x002D22BC File Offset: 0x002D04BC
		// (set) Token: 0x0600B58D RID: 46477 RVA: 0x000591AA File Offset: 0x000573AA
		public unsafe VehicleDetector InteriorVehicleDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_InteriorVehicleDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_InteriorVehicleDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003849 RID: 14409
		// (get) Token: 0x0600B58E RID: 46478 RVA: 0x002D22EC File Offset: 0x002D04EC
		// (set) Token: 0x0600B58F RID: 46479 RVA: 0x000591C9 File Offset: 0x000573C9
		public unsafe PlayerDetector InteriorPlayerDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_InteriorPlayerDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_InteriorPlayerDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700384A RID: 14410
		// (get) Token: 0x0600B590 RID: 46480 RVA: 0x002D231C File Offset: 0x002D051C
		// (set) Token: 0x0600B591 RID: 46481 RVA: 0x000591E8 File Offset: 0x000573E8
		public unsafe bool intercomActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_intercomActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_intercomActive)) = value;
			}
		}

		// Token: 0x04007A4C RID: 31308
		private static readonly IntPtr NativeFieldInfoPtr_IntercomInt;

		// Token: 0x04007A4D RID: 31309
		private static readonly IntPtr NativeFieldInfoPtr_IntercomLight;

		// Token: 0x04007A4E RID: 31310
		private static readonly IntPtr NativeFieldInfoPtr_ExteriorVehicleDetector;

		// Token: 0x04007A4F RID: 31311
		private static readonly IntPtr NativeFieldInfoPtr_ExteriorPlayerDetector;

		// Token: 0x04007A50 RID: 31312
		private static readonly IntPtr NativeFieldInfoPtr_InteriorVehicleDetector;

		// Token: 0x04007A51 RID: 31313
		private static readonly IntPtr NativeFieldInfoPtr_InteriorPlayerDetector;

		// Token: 0x04007A52 RID: 31314
		private static readonly IntPtr NativeFieldInfoPtr_intercomActive;

		// Token: 0x04007A53 RID: 31315
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04007A54 RID: 31316
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDetection_Private_Void_0;

		// Token: 0x04007A55 RID: 31317
		private static readonly IntPtr NativeMethodInfoPtr_IntercomBuzzed_Public_Void_0;

		// Token: 0x04007A56 RID: 31318
		private static readonly IntPtr NativeMethodInfoPtr_SetEnterable_Public_Void_Boolean_0;

		// Token: 0x04007A57 RID: 31319
		private static readonly IntPtr NativeMethodInfoPtr_ActivateIntercom_Public_Void_0;

		// Token: 0x04007A58 RID: 31320
		private static readonly IntPtr NativeMethodInfoPtr_SetIntercomActive_Public_Void_Boolean_0;

		// Token: 0x04007A59 RID: 31321
		private static readonly IntPtr NativeMethodInfoPtr_UpdateIntercom_Private_Void_0;

		// Token: 0x04007A5A RID: 31322
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
