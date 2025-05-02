using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x02000399 RID: 921
	public class RouteListField : ConfigField
	{
		// Token: 0x06004843 RID: 18499 RVA: 0x0016175C File Offset: 0x0015F95C
		// Note: this type is marked as 'beforefieldinit'.
		static RouteListField()
		{
			Il2CppClassPointerStore<RouteListField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "RouteListField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RouteListField>.NativeClassPtr);
			RouteListField.NativeFieldInfoPtr_Routes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteListField>.NativeClassPtr, "Routes");
			RouteListField.NativeFieldInfoPtr_MaxRoutes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteListField>.NativeClassPtr, "MaxRoutes");
			RouteListField.NativeFieldInfoPtr_onListChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteListField>.NativeClassPtr, "onListChanged");
			RouteListField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListField>.NativeClassPtr, 100672225);
			RouteListField.NativeMethodInfoPtr_SetList_Public_Void_List_1_AdvancedTransitRoute_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListField>.NativeClassPtr, 100672226);
			RouteListField.NativeMethodInfoPtr_Replicate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListField>.NativeClassPtr, 100672227);
			RouteListField.NativeMethodInfoPtr_AddItem_Public_Void_AdvancedTransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListField>.NativeClassPtr, 100672228);
			RouteListField.NativeMethodInfoPtr_RemoveItem_Public_Void_AdvancedTransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListField>.NativeClassPtr, 100672229);
			RouteListField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListField>.NativeClassPtr, 100672230);
			RouteListField.NativeMethodInfoPtr_GetData_Public_RouteListData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListField>.NativeClassPtr, 100672231);
			RouteListField.NativeMethodInfoPtr_Load_Public_Void_RouteListData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListField>.NativeClassPtr, 100672232);
		}

		// Token: 0x06004844 RID: 18500 RVA: 0x00161868 File Offset: 0x0015FA68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161982, XrefRangeEnd = 161997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RouteListField(EntityConfiguration parentConfig) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RouteListField>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentConfig);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004845 RID: 18501 RVA: 0x001618B4 File Offset: 0x0015FAB4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 162014, RefRangeEnd = 162019, XrefRangeStart = 161997, XrefRangeEnd = 162014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetList(List<AdvancedTransitRoute> list, bool network, bool bypassSequenceCheck = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bypassSequenceCheck;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListField.NativeMethodInfoPtr_SetList_Public_Void_List_1_AdvancedTransitRoute_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004846 RID: 18502 RVA: 0x00161914 File Offset: 0x0015FB14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 162026, RefRangeEnd = 162027, XrefRangeStart = 162019, XrefRangeEnd = 162026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Replicate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListField.NativeMethodInfoPtr_Replicate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004847 RID: 18503 RVA: 0x00161948 File Offset: 0x0015FB48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 162044, RefRangeEnd = 162045, XrefRangeStart = 162027, XrefRangeEnd = 162044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddItem(AdvancedTransitRoute item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListField.NativeMethodInfoPtr_AddItem_Public_Void_AdvancedTransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004848 RID: 18504 RVA: 0x0016198C File Offset: 0x0015FB8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 162058, RefRangeEnd = 162060, XrefRangeStart = 162045, XrefRangeEnd = 162058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveItem(AdvancedTransitRoute item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListField.NativeMethodInfoPtr_RemoveItem_Public_Void_AdvancedTransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004849 RID: 18505 RVA: 0x001619D0 File Offset: 0x0015FBD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162060, XrefRangeEnd = 162061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsValueDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RouteListField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600484A RID: 18506 RVA: 0x00161A18 File Offset: 0x0015FC18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162061, XrefRangeEnd = 162082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RouteListData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListField.NativeMethodInfoPtr_GetData_Public_RouteListData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RouteListData>(intPtr3) : null;
		}

		// Token: 0x0600484B RID: 18507 RVA: 0x00161A58 File Offset: 0x0015FC58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 162168, RefRangeEnd = 162169, XrefRangeStart = 162082, XrefRangeEnd = 162168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(RouteListData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListField.NativeMethodInfoPtr_Load_Public_Void_RouteListData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600484C RID: 18508 RVA: 0x00022F38 File Offset: 0x00021138
		public RouteListField(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170015AB RID: 5547
		// (get) Token: 0x0600484D RID: 18509 RVA: 0x00161A9C File Offset: 0x0015FC9C
		// (set) Token: 0x0600484E RID: 18510 RVA: 0x00022F41 File Offset: 0x00021141
		public unsafe List<AdvancedTransitRoute> Routes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListField.NativeFieldInfoPtr_Routes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AdvancedTransitRoute>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListField.NativeFieldInfoPtr_Routes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015AC RID: 5548
		// (get) Token: 0x0600484F RID: 18511 RVA: 0x00161ACC File Offset: 0x0015FCCC
		// (set) Token: 0x06004850 RID: 18512 RVA: 0x00022F60 File Offset: 0x00021160
		public unsafe int MaxRoutes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListField.NativeFieldInfoPtr_MaxRoutes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListField.NativeFieldInfoPtr_MaxRoutes)) = value;
			}
		}

		// Token: 0x170015AD RID: 5549
		// (get) Token: 0x06004851 RID: 18513 RVA: 0x00161AF4 File Offset: 0x0015FCF4
		// (set) Token: 0x06004852 RID: 18514 RVA: 0x00022F7B File Offset: 0x0002117B
		public unsafe UnityEvent<List<AdvancedTransitRoute>> onListChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListField.NativeFieldInfoPtr_onListChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<List<AdvancedTransitRoute>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListField.NativeFieldInfoPtr_onListChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040030B2 RID: 12466
		private static readonly IntPtr NativeFieldInfoPtr_Routes;

		// Token: 0x040030B3 RID: 12467
		private static readonly IntPtr NativeFieldInfoPtr_MaxRoutes;

		// Token: 0x040030B4 RID: 12468
		private static readonly IntPtr NativeFieldInfoPtr_onListChanged;

		// Token: 0x040030B5 RID: 12469
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0;

		// Token: 0x040030B6 RID: 12470
		private static readonly IntPtr NativeMethodInfoPtr_SetList_Public_Void_List_1_AdvancedTransitRoute_Boolean_Boolean_0;

		// Token: 0x040030B7 RID: 12471
		private static readonly IntPtr NativeMethodInfoPtr_Replicate_Public_Void_0;

		// Token: 0x040030B8 RID: 12472
		private static readonly IntPtr NativeMethodInfoPtr_AddItem_Public_Void_AdvancedTransitRoute_0;

		// Token: 0x040030B9 RID: 12473
		private static readonly IntPtr NativeMethodInfoPtr_RemoveItem_Public_Void_AdvancedTransitRoute_0;

		// Token: 0x040030BA RID: 12474
		private static readonly IntPtr NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0;

		// Token: 0x040030BB RID: 12475
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_RouteListData_0;

		// Token: 0x040030BC RID: 12476
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_RouteListData_0;
	}
}
