using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020003A7 RID: 935
	public class TransitRoute : Object
	{
		// Token: 0x06004937 RID: 18743 RVA: 0x00165280 File Offset: 0x00163480
		// Note: this type is marked as 'beforefieldinit'.
		static TransitRoute()
		{
			Il2CppClassPointerStore<TransitRoute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "TransitRoute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr);
			TransitRoute.NativeFieldInfoPtr__Source_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, "<Source>k__BackingField");
			TransitRoute.NativeFieldInfoPtr__Destination_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, "<Destination>k__BackingField");
			TransitRoute.NativeFieldInfoPtr_visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, "visuals");
			TransitRoute.NativeFieldInfoPtr_onSourceChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, "onSourceChange");
			TransitRoute.NativeFieldInfoPtr_onDestinationChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, "onDestinationChange");
			TransitRoute.NativeMethodInfoPtr_get_Source_Public_get_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, 100672372);
			TransitRoute.NativeMethodInfoPtr_set_Source_Protected_set_Void_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, 100672373);
			TransitRoute.NativeMethodInfoPtr_get_Destination_Public_get_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, 100672374);
			TransitRoute.NativeMethodInfoPtr_set_Destination_Protected_set_Void_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, 100672375);
			TransitRoute.NativeMethodInfoPtr__ctor_Public_Void_ITransitEntity_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, 100672376);
			TransitRoute.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, 100672377);
			TransitRoute.NativeMethodInfoPtr_SetVisualsActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, 100672378);
			TransitRoute.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, 100672379);
			TransitRoute.NativeMethodInfoPtr_SetSource_Public_Virtual_New_Void_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, 100672380);
			TransitRoute.NativeMethodInfoPtr_AreEntitiesNonNull_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, 100672381);
			TransitRoute.NativeMethodInfoPtr_SetDestination_Public_Virtual_New_Void_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, 100672382);
			TransitRoute.NativeMethodInfoPtr_ValidateEntities_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, 100672383);
		}

		// Token: 0x170015FD RID: 5629
		// (get) Token: 0x06004938 RID: 18744 RVA: 0x00165404 File Offset: 0x00163604
		// (set) Token: 0x06004939 RID: 18745 RVA: 0x00165444 File Offset: 0x00163644
		public unsafe ITransitEntity Source
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 17380, RefRangeEnd = 17390, XrefRangeStart = 17380, XrefRangeEnd = 17390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitRoute.NativeMethodInfoPtr_get_Source_Public_get_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ITransitEntity>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29995, RefRangeEnd = 29997, XrefRangeStart = 29995, XrefRangeEnd = 29997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitRoute.NativeMethodInfoPtr_set_Source_Protected_set_Void_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015FE RID: 5630
		// (get) Token: 0x0600493A RID: 18746 RVA: 0x00165488 File Offset: 0x00163688
		// (set) Token: 0x0600493B RID: 18747 RVA: 0x001654C8 File Offset: 0x001636C8
		public unsafe ITransitEntity Destination
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitRoute.NativeMethodInfoPtr_get_Destination_Public_get_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ITransitEntity>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitRoute.NativeMethodInfoPtr_set_Destination_Protected_set_Void_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600493C RID: 18748 RVA: 0x0016550C File Offset: 0x0016370C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 163144, RefRangeEnd = 163148, XrefRangeStart = 163123, XrefRangeEnd = 163144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransitRoute(ITransitEntity source, ITransitEntity destination) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitRoute.NativeMethodInfoPtr__ctor_Public_Void_ITransitEntity_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600493D RID: 18749 RVA: 0x0016556C File Offset: 0x0016376C
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 163171, RefRangeEnd = 163187, XrefRangeStart = 163148, XrefRangeEnd = 163171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitRoute.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600493E RID: 18750 RVA: 0x001655A0 File Offset: 0x001637A0
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 163212, RefRangeEnd = 163228, XrefRangeStart = 163187, XrefRangeEnd = 163212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisualsActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitRoute.NativeMethodInfoPtr_SetVisualsActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600493F RID: 18751 RVA: 0x001655E0 File Offset: 0x001637E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 163253, RefRangeEnd = 163254, XrefRangeStart = 163228, XrefRangeEnd = 163253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitRoute.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004940 RID: 18752 RVA: 0x00165614 File Offset: 0x00163814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163254, XrefRangeEnd = 163255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetSource(ITransitEntity source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TransitRoute.NativeMethodInfoPtr_SetSource_Public_Virtual_New_Void_ITransitEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004941 RID: 18753 RVA: 0x00165664 File Offset: 0x00163864
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 163256, RefRangeEnd = 163259, XrefRangeStart = 163255, XrefRangeEnd = 163256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreEntitiesNonNull()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitRoute.NativeMethodInfoPtr_AreEntitiesNonNull_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004942 RID: 18754 RVA: 0x001656A0 File Offset: 0x001638A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163259, XrefRangeEnd = 163260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetDestination(ITransitEntity destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TransitRoute.NativeMethodInfoPtr_SetDestination_Public_Virtual_New_Void_ITransitEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004943 RID: 18755 RVA: 0x001656F0 File Offset: 0x001638F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 163265, RefRangeEnd = 163267, XrefRangeStart = 163260, XrefRangeEnd = 163265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateEntities()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitRoute.NativeMethodInfoPtr_ValidateEntities_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004944 RID: 18756 RVA: 0x000234E0 File Offset: 0x000216E0
		public TransitRoute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170015F8 RID: 5624
		// (get) Token: 0x06004945 RID: 18757 RVA: 0x00165724 File Offset: 0x00163924
		// (set) Token: 0x06004946 RID: 18758 RVA: 0x000234E9 File Offset: 0x000216E9
		public unsafe ITransitEntity _Source_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitRoute.NativeFieldInfoPtr__Source_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITransitEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitRoute.NativeFieldInfoPtr__Source_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015F9 RID: 5625
		// (get) Token: 0x06004947 RID: 18759 RVA: 0x00165754 File Offset: 0x00163954
		// (set) Token: 0x06004948 RID: 18760 RVA: 0x00023508 File Offset: 0x00021708
		public unsafe ITransitEntity _Destination_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitRoute.NativeFieldInfoPtr__Destination_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITransitEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitRoute.NativeFieldInfoPtr__Destination_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015FA RID: 5626
		// (get) Token: 0x06004949 RID: 18761 RVA: 0x00165784 File Offset: 0x00163984
		// (set) Token: 0x0600494A RID: 18762 RVA: 0x00023527 File Offset: 0x00021727
		public unsafe TransitLineVisuals visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitRoute.NativeFieldInfoPtr_visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TransitLineVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitRoute.NativeFieldInfoPtr_visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015FB RID: 5627
		// (get) Token: 0x0600494B RID: 18763 RVA: 0x001657B4 File Offset: 0x001639B4
		// (set) Token: 0x0600494C RID: 18764 RVA: 0x00023546 File Offset: 0x00021746
		public unsafe Action<ITransitEntity> onSourceChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitRoute.NativeFieldInfoPtr_onSourceChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ITransitEntity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitRoute.NativeFieldInfoPtr_onSourceChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015FC RID: 5628
		// (get) Token: 0x0600494D RID: 18765 RVA: 0x001657E4 File Offset: 0x001639E4
		// (set) Token: 0x0600494E RID: 18766 RVA: 0x00023565 File Offset: 0x00021765
		public unsafe Action<ITransitEntity> onDestinationChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitRoute.NativeFieldInfoPtr_onDestinationChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ITransitEntity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitRoute.NativeFieldInfoPtr_onDestinationChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003162 RID: 12642
		private static readonly IntPtr NativeFieldInfoPtr__Source_k__BackingField;

		// Token: 0x04003163 RID: 12643
		private static readonly IntPtr NativeFieldInfoPtr__Destination_k__BackingField;

		// Token: 0x04003164 RID: 12644
		private static readonly IntPtr NativeFieldInfoPtr_visuals;

		// Token: 0x04003165 RID: 12645
		private static readonly IntPtr NativeFieldInfoPtr_onSourceChange;

		// Token: 0x04003166 RID: 12646
		private static readonly IntPtr NativeFieldInfoPtr_onDestinationChange;

		// Token: 0x04003167 RID: 12647
		private static readonly IntPtr NativeMethodInfoPtr_get_Source_Public_get_ITransitEntity_0;

		// Token: 0x04003168 RID: 12648
		private static readonly IntPtr NativeMethodInfoPtr_set_Source_Protected_set_Void_ITransitEntity_0;

		// Token: 0x04003169 RID: 12649
		private static readonly IntPtr NativeMethodInfoPtr_get_Destination_Public_get_ITransitEntity_0;

		// Token: 0x0400316A RID: 12650
		private static readonly IntPtr NativeMethodInfoPtr_set_Destination_Protected_set_Void_ITransitEntity_0;

		// Token: 0x0400316B RID: 12651
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ITransitEntity_ITransitEntity_0;

		// Token: 0x0400316C RID: 12652
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;

		// Token: 0x0400316D RID: 12653
		private static readonly IntPtr NativeMethodInfoPtr_SetVisualsActive_Public_Void_Boolean_0;

		// Token: 0x0400316E RID: 12654
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400316F RID: 12655
		private static readonly IntPtr NativeMethodInfoPtr_SetSource_Public_Virtual_New_Void_ITransitEntity_0;

		// Token: 0x04003170 RID: 12656
		private static readonly IntPtr NativeMethodInfoPtr_AreEntitiesNonNull_Public_Boolean_0;

		// Token: 0x04003171 RID: 12657
		private static readonly IntPtr NativeMethodInfoPtr_SetDestination_Public_Virtual_New_Void_ITransitEntity_0;

		// Token: 0x04003172 RID: 12658
		private static readonly IntPtr NativeMethodInfoPtr_ValidateEntities_Private_Void_0;
	}
}
