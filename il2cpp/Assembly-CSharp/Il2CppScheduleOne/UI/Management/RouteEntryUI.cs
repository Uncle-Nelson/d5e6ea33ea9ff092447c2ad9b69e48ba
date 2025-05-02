using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006CC RID: 1740
	public class RouteEntryUI : MonoBehaviour
	{
		// Token: 0x06009C44 RID: 40004 RVA: 0x002798C4 File Offset: 0x00277AC4
		// Note: this type is marked as 'beforefieldinit'.
		static RouteEntryUI()
		{
			Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "RouteEntryUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr);
			RouteEntryUI.NativeFieldInfoPtr__AssignedRoute_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, "<AssignedRoute>k__BackingField");
			RouteEntryUI.NativeFieldInfoPtr_SourceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, "SourceLabel");
			RouteEntryUI.NativeFieldInfoPtr_DestinationLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, "DestinationLabel");
			RouteEntryUI.NativeFieldInfoPtr_FilterIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, "FilterIcon");
			RouteEntryUI.NativeFieldInfoPtr_onDeleteClicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, "onDeleteClicked");
			RouteEntryUI.NativeFieldInfoPtr_settingSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, "settingSource");
			RouteEntryUI.NativeFieldInfoPtr_settingDestination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, "settingDestination");
			RouteEntryUI.NativeMethodInfoPtr_get_AssignedRoute_Public_get_AdvancedTransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, 100682481);
			RouteEntryUI.NativeMethodInfoPtr_set_AssignedRoute_Private_set_Void_AdvancedTransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, 100682482);
			RouteEntryUI.NativeMethodInfoPtr_AssignRoute_Public_Void_AdvancedTransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, 100682483);
			RouteEntryUI.NativeMethodInfoPtr_ClearRoute_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, 100682484);
			RouteEntryUI.NativeMethodInfoPtr_RefreshUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, 100682485);
			RouteEntryUI.NativeMethodInfoPtr_SourceClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, 100682486);
			RouteEntryUI.NativeMethodInfoPtr_DestinationClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, 100682487);
			RouteEntryUI.NativeMethodInfoPtr_FilterClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, 100682488);
			RouteEntryUI.NativeMethodInfoPtr_DeleteClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, 100682489);
			RouteEntryUI.NativeMethodInfoPtr_ObjectValid_Private_Boolean_ITransitEntity_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, 100682490);
			RouteEntryUI.NativeMethodInfoPtr_ObjectsSelected_Public_Void_List_1_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, 100682491);
			RouteEntryUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, 100682492);
		}

		// Token: 0x17003024 RID: 12324
		// (get) Token: 0x06009C45 RID: 40005 RVA: 0x00279A70 File Offset: 0x00277C70
		// (set) Token: 0x06009C46 RID: 40006 RVA: 0x00279AB0 File Offset: 0x00277CB0
		public unsafe AdvancedTransitRoute AssignedRoute
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17399, RefRangeEnd = 17400, XrefRangeStart = 17399, XrefRangeEnd = 17400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteEntryUI.NativeMethodInfoPtr_get_AssignedRoute_Public_get_AdvancedTransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AdvancedTransitRoute>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteEntryUI.NativeMethodInfoPtr_set_AssignedRoute_Private_set_Void_AdvancedTransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009C47 RID: 40007 RVA: 0x00279AF4 File Offset: 0x00277CF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 277467, RefRangeEnd = 277468, XrefRangeStart = 277456, XrefRangeEnd = 277467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignRoute(AdvancedTransitRoute route)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(route);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteEntryUI.NativeMethodInfoPtr_AssignRoute_Public_Void_AdvancedTransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C48 RID: 40008 RVA: 0x00279B38 File Offset: 0x00277D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearRoute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteEntryUI.NativeMethodInfoPtr_ClearRoute_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C49 RID: 40009 RVA: 0x00279B6C File Offset: 0x00277D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277468, XrefRangeEnd = 277478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteEntryUI.NativeMethodInfoPtr_RefreshUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C4A RID: 40010 RVA: 0x00279BA0 File Offset: 0x00277DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277478, XrefRangeEnd = 277522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SourceClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteEntryUI.NativeMethodInfoPtr_SourceClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C4B RID: 40011 RVA: 0x00279BD4 File Offset: 0x00277DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277522, XrefRangeEnd = 277566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestinationClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteEntryUI.NativeMethodInfoPtr_DestinationClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C4C RID: 40012 RVA: 0x00279C08 File Offset: 0x00277E08
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FilterClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteEntryUI.NativeMethodInfoPtr_FilterClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C4D RID: 40013 RVA: 0x00279C3C File Offset: 0x00277E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277566, XrefRangeEnd = 277567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteEntryUI.NativeMethodInfoPtr_DeleteClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C4E RID: 40014 RVA: 0x00279C70 File Offset: 0x00277E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277567, XrefRangeEnd = 277575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ObjectValid(ITransitEntity obj, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RouteEntryUI.NativeMethodInfoPtr_ObjectValid_Private_Boolean_ITransitEntity_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06009C4F RID: 40015 RVA: 0x00279CD8 File Offset: 0x00277ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277575, XrefRangeEnd = 277585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ObjectsSelected(List<ITransitEntity> objs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteEntryUI.NativeMethodInfoPtr_ObjectsSelected_Public_Void_List_1_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C50 RID: 40016 RVA: 0x00279D1C File Offset: 0x00277F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277585, XrefRangeEnd = 277591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RouteEntryUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteEntryUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C51 RID: 40017 RVA: 0x0004C996 File Offset: 0x0004AB96
		public RouteEntryUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700301D RID: 12317
		// (get) Token: 0x06009C52 RID: 40018 RVA: 0x00279D58 File Offset: 0x00277F58
		// (set) Token: 0x06009C53 RID: 40019 RVA: 0x0004C99F File Offset: 0x0004AB9F
		public unsafe AdvancedTransitRoute _AssignedRoute_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr__AssignedRoute_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdvancedTransitRoute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr__AssignedRoute_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700301E RID: 12318
		// (get) Token: 0x06009C54 RID: 40020 RVA: 0x00279D88 File Offset: 0x00277F88
		// (set) Token: 0x06009C55 RID: 40021 RVA: 0x0004C9BE File Offset: 0x0004ABBE
		public unsafe TextMeshProUGUI SourceLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_SourceLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_SourceLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700301F RID: 12319
		// (get) Token: 0x06009C56 RID: 40022 RVA: 0x00279DB8 File Offset: 0x00277FB8
		// (set) Token: 0x06009C57 RID: 40023 RVA: 0x0004C9DD File Offset: 0x0004ABDD
		public unsafe TextMeshProUGUI DestinationLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_DestinationLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_DestinationLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003020 RID: 12320
		// (get) Token: 0x06009C58 RID: 40024 RVA: 0x00279DE8 File Offset: 0x00277FE8
		// (set) Token: 0x06009C59 RID: 40025 RVA: 0x0004C9FC File Offset: 0x0004ABFC
		public unsafe Image FilterIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_FilterIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_FilterIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003021 RID: 12321
		// (get) Token: 0x06009C5A RID: 40026 RVA: 0x00279E18 File Offset: 0x00278018
		// (set) Token: 0x06009C5B RID: 40027 RVA: 0x0004CA1B File Offset: 0x0004AC1B
		public unsafe UnityEvent onDeleteClicked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_onDeleteClicked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_onDeleteClicked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003022 RID: 12322
		// (get) Token: 0x06009C5C RID: 40028 RVA: 0x00279E48 File Offset: 0x00278048
		// (set) Token: 0x06009C5D RID: 40029 RVA: 0x0004CA3A File Offset: 0x0004AC3A
		public unsafe bool settingSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_settingSource);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_settingSource)) = value;
			}
		}

		// Token: 0x17003023 RID: 12323
		// (get) Token: 0x06009C5E RID: 40030 RVA: 0x00279E70 File Offset: 0x00278070
		// (set) Token: 0x06009C5F RID: 40031 RVA: 0x0004CA55 File Offset: 0x0004AC55
		public unsafe bool settingDestination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_settingDestination);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_settingDestination)) = value;
			}
		}

		// Token: 0x040068F8 RID: 26872
		private static readonly IntPtr NativeFieldInfoPtr__AssignedRoute_k__BackingField;

		// Token: 0x040068F9 RID: 26873
		private static readonly IntPtr NativeFieldInfoPtr_SourceLabel;

		// Token: 0x040068FA RID: 26874
		private static readonly IntPtr NativeFieldInfoPtr_DestinationLabel;

		// Token: 0x040068FB RID: 26875
		private static readonly IntPtr NativeFieldInfoPtr_FilterIcon;

		// Token: 0x040068FC RID: 26876
		private static readonly IntPtr NativeFieldInfoPtr_onDeleteClicked;

		// Token: 0x040068FD RID: 26877
		private static readonly IntPtr NativeFieldInfoPtr_settingSource;

		// Token: 0x040068FE RID: 26878
		private static readonly IntPtr NativeFieldInfoPtr_settingDestination;

		// Token: 0x040068FF RID: 26879
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedRoute_Public_get_AdvancedTransitRoute_0;

		// Token: 0x04006900 RID: 26880
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedRoute_Private_set_Void_AdvancedTransitRoute_0;

		// Token: 0x04006901 RID: 26881
		private static readonly IntPtr NativeMethodInfoPtr_AssignRoute_Public_Void_AdvancedTransitRoute_0;

		// Token: 0x04006902 RID: 26882
		private static readonly IntPtr NativeMethodInfoPtr_ClearRoute_Public_Void_0;

		// Token: 0x04006903 RID: 26883
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Public_Void_0;

		// Token: 0x04006904 RID: 26884
		private static readonly IntPtr NativeMethodInfoPtr_SourceClicked_Public_Void_0;

		// Token: 0x04006905 RID: 26885
		private static readonly IntPtr NativeMethodInfoPtr_DestinationClicked_Public_Void_0;

		// Token: 0x04006906 RID: 26886
		private static readonly IntPtr NativeMethodInfoPtr_FilterClicked_Public_Void_0;

		// Token: 0x04006907 RID: 26887
		private static readonly IntPtr NativeMethodInfoPtr_DeleteClicked_Public_Void_0;

		// Token: 0x04006908 RID: 26888
		private static readonly IntPtr NativeMethodInfoPtr_ObjectValid_Private_Boolean_ITransitEntity_byref_String_0;

		// Token: 0x04006909 RID: 26889
		private static readonly IntPtr NativeMethodInfoPtr_ObjectsSelected_Public_Void_List_1_ITransitEntity_0;

		// Token: 0x0400690A RID: 26890
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
