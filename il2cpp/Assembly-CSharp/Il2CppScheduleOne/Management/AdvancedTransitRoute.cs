using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x02000381 RID: 897
	public class AdvancedTransitRoute : TransitRoute
	{
		// Token: 0x0600460E RID: 17934 RVA: 0x00158548 File Offset: 0x00156748
		// Note: this type is marked as 'beforefieldinit'.
		static AdvancedTransitRoute()
		{
			Il2CppClassPointerStore<AdvancedTransitRoute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "AdvancedTransitRoute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdvancedTransitRoute>.NativeClassPtr);
			AdvancedTransitRoute.NativeFieldInfoPtr__Filter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTransitRoute>.NativeClassPtr, "<Filter>k__BackingField");
			AdvancedTransitRoute.NativeMethodInfoPtr_get_Filter_Public_get_ManagementItemFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTransitRoute>.NativeClassPtr, 100671902);
			AdvancedTransitRoute.NativeMethodInfoPtr_set_Filter_Private_set_Void_ManagementItemFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTransitRoute>.NativeClassPtr, 100671903);
			AdvancedTransitRoute.NativeMethodInfoPtr__ctor_Public_Void_ITransitEntity_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTransitRoute>.NativeClassPtr, 100671904);
			AdvancedTransitRoute.NativeMethodInfoPtr__ctor_Public_Void_AdvancedTransitRouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTransitRoute>.NativeClassPtr, 100671905);
			AdvancedTransitRoute.NativeMethodInfoPtr_GetItemReadyToMove_Public_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTransitRoute>.NativeClassPtr, 100671906);
			AdvancedTransitRoute.NativeMethodInfoPtr_GetData_Public_AdvancedTransitRouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTransitRoute>.NativeClassPtr, 100671907);
		}

		// Token: 0x17001521 RID: 5409
		// (get) Token: 0x0600460F RID: 17935 RVA: 0x00158604 File Offset: 0x00156804
		// (set) Token: 0x06004610 RID: 17936 RVA: 0x00158644 File Offset: 0x00156844
		public unsafe ManagementItemFilter Filter
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 19660, RefRangeEnd = 19667, XrefRangeStart = 19660, XrefRangeEnd = 19667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTransitRoute.NativeMethodInfoPtr_get_Filter_Public_get_ManagementItemFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ManagementItemFilter>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTransitRoute.NativeMethodInfoPtr_set_Filter_Private_set_Void_ManagementItemFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004611 RID: 17937 RVA: 0x00158688 File Offset: 0x00156888
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 157965, RefRangeEnd = 157967, XrefRangeStart = 157959, XrefRangeEnd = 157965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdvancedTransitRoute(ITransitEntity source, ITransitEntity destination) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdvancedTransitRoute>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTransitRoute.NativeMethodInfoPtr__ctor_Public_Void_ITransitEntity_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004612 RID: 17938 RVA: 0x001586E8 File Offset: 0x001568E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 158001, RefRangeEnd = 158002, XrefRangeStart = 157967, XrefRangeEnd = 158001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdvancedTransitRoute(AdvancedTransitRouteData data) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdvancedTransitRoute>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTransitRoute.NativeMethodInfoPtr__ctor_Public_Void_AdvancedTransitRouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004613 RID: 17939 RVA: 0x00158734 File Offset: 0x00156934
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 158025, RefRangeEnd = 158026, XrefRangeStart = 158002, XrefRangeEnd = 158025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemInstance GetItemReadyToMove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTransitRoute.NativeMethodInfoPtr_GetItemReadyToMove_Public_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06004614 RID: 17940 RVA: 0x00158774 File Offset: 0x00156974
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 158064, RefRangeEnd = 158067, XrefRangeStart = 158026, XrefRangeEnd = 158064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdvancedTransitRouteData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTransitRoute.NativeMethodInfoPtr_GetData_Public_AdvancedTransitRouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AdvancedTransitRouteData>(intPtr3) : null;
		}

		// Token: 0x06004615 RID: 17941 RVA: 0x00022240 File Offset: 0x00020440
		public AdvancedTransitRoute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001520 RID: 5408
		// (get) Token: 0x06004616 RID: 17942 RVA: 0x001587B4 File Offset: 0x001569B4
		// (set) Token: 0x06004617 RID: 17943 RVA: 0x00022249 File Offset: 0x00020449
		public unsafe ManagementItemFilter _Filter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTransitRoute.NativeFieldInfoPtr__Filter_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManagementItemFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTransitRoute.NativeFieldInfoPtr__Filter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002F02 RID: 12034
		private static readonly IntPtr NativeFieldInfoPtr__Filter_k__BackingField;

		// Token: 0x04002F03 RID: 12035
		private static readonly IntPtr NativeMethodInfoPtr_get_Filter_Public_get_ManagementItemFilter_0;

		// Token: 0x04002F04 RID: 12036
		private static readonly IntPtr NativeMethodInfoPtr_set_Filter_Private_set_Void_ManagementItemFilter_0;

		// Token: 0x04002F05 RID: 12037
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ITransitEntity_ITransitEntity_0;

		// Token: 0x04002F06 RID: 12038
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AdvancedTransitRouteData_0;

		// Token: 0x04002F07 RID: 12039
		private static readonly IntPtr NativeMethodInfoPtr_GetItemReadyToMove_Public_ItemInstance_0;

		// Token: 0x04002F08 RID: 12040
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_AdvancedTransitRouteData_0;
	}
}
