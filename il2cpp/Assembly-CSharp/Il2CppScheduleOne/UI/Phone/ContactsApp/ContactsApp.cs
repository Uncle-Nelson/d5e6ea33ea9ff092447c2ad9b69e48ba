using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.UI.Relations;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.ContactsApp
{
	// Token: 0x020006B5 RID: 1717
	public class ContactsApp : App<ContactsApp>
	{
		// Token: 0x06009AB0 RID: 39600 RVA: 0x00274E98 File Offset: 0x00273098
		// Note: this type is marked as 'beforefieldinit'.
		static ContactsApp()
		{
			Il2CppClassPointerStore<ContactsApp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.ContactsApp", "ContactsApp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr);
			ContactsApp.NativeFieldInfoPtr_SelectedRegion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "SelectedRegion");
			ContactsApp.NativeFieldInfoPtr_RegionDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "RegionDict");
			ContactsApp.NativeFieldInfoPtr_CirclesContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "CirclesContainer");
			ContactsApp.NativeFieldInfoPtr_DemoCirclesContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "DemoCirclesContainer");
			ContactsApp.NativeFieldInfoPtr_TutorialCirclesContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "TutorialCirclesContainer");
			ContactsApp.NativeFieldInfoPtr_ConnectionsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "ConnectionsContainer");
			ContactsApp.NativeFieldInfoPtr_ContentRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "ContentRect");
			ContactsApp.NativeFieldInfoPtr_SelectionIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "SelectionIndicator");
			ContactsApp.NativeFieldInfoPtr_DetailPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "DetailPanel");
			ContactsApp.NativeFieldInfoPtr_RegionUIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "RegionUIs");
			ContactsApp.NativeFieldInfoPtr_RegionSelectionContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "RegionSelectionContainer");
			ContactsApp.NativeFieldInfoPtr_RegionSelectionIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "RegionSelectionIndicator");
			ContactsApp.NativeFieldInfoPtr_LockedRegionContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "LockedRegionContainer");
			ContactsApp.NativeFieldInfoPtr_RegionRankRequirementLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "RegionRankRequirementLabel");
			ContactsApp.NativeFieldInfoPtr_SelectedRegionIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "SelectedRegionIcon");
			ContactsApp.NativeFieldInfoPtr_ConnectionPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "ConnectionPrefab");
			ContactsApp.NativeFieldInfoPtr_RelationCircles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "RelationCircles");
			ContactsApp.NativeFieldInfoPtr_contentMoveRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "contentMoveRoutine");
			ContactsApp.NativeFieldInfoPtr_connections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "connections");
			ContactsApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, 100682326);
			ContactsApp.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, 100682327);
			ContactsApp.NativeMethodInfoPtr_GetRelationCircle_Private_RelationCircle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, 100682328);
			ContactsApp.NativeMethodInfoPtr_CircleClicked_Private_Void_RelationCircle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, 100682329);
			ContactsApp.NativeMethodInfoPtr_Select_Private_Void_RelationCircle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, 100682330);
			ContactsApp.NativeMethodInfoPtr_SetSelectedRegion_Public_Void_EMapRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, 100682331);
			ContactsApp.NativeMethodInfoPtr_ZoomToRect_Private_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, 100682332);
			ContactsApp.NativeMethodInfoPtr_StopContentMove_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, 100682333);
			ContactsApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, 100682334);
			ContactsApp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, 100682335);
		}

		// Token: 0x06009AB1 RID: 39601 RVA: 0x0027510C File Offset: 0x0027330C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275146, XrefRangeEnd = 275419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContactsApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009AB2 RID: 39602 RVA: 0x00275148 File Offset: 0x00273348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275419, XrefRangeEnd = 275443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContactsApp.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009AB3 RID: 39603 RVA: 0x00275184 File Offset: 0x00273384
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 275458, RefRangeEnd = 275460, XrefRangeStart = 275443, XrefRangeEnd = 275458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RelationCircle GetRelationCircle(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.NativeMethodInfoPtr_GetRelationCircle_Private_RelationCircle_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RelationCircle>(intPtr3) : null;
		}

		// Token: 0x06009AB4 RID: 39604 RVA: 0x002751D4 File Offset: 0x002733D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275460, XrefRangeEnd = 275464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CircleClicked(RelationCircle circ)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(circ);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.NativeMethodInfoPtr_CircleClicked_Private_Void_RelationCircle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009AB5 RID: 39605 RVA: 0x00275218 File Offset: 0x00273418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Select(RelationCircle circ)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(circ);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.NativeMethodInfoPtr_Select_Private_Void_RelationCircle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009AB6 RID: 39606 RVA: 0x0027525C File Offset: 0x0027345C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 275497, RefRangeEnd = 275499, XrefRangeStart = 275464, XrefRangeEnd = 275497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelectedRegion(EMapRegion region)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref region;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.NativeMethodInfoPtr_SetSelectedRegion_Public_Void_EMapRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009AB7 RID: 39607 RVA: 0x0027529C File Offset: 0x0027349C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 275514, RefRangeEnd = 275521, XrefRangeStart = 275499, XrefRangeEnd = 275514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ZoomToRect(RectTransform rect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.NativeMethodInfoPtr_ZoomToRect_Private_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009AB8 RID: 39608 RVA: 0x002752E0 File Offset: 0x002734E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275521, XrefRangeEnd = 275522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopContentMove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.NativeMethodInfoPtr_StopContentMove_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009AB9 RID: 39609 RVA: 0x00275314 File Offset: 0x00273514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275522, XrefRangeEnd = 275540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContactsApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009ABA RID: 39610 RVA: 0x00275360 File Offset: 0x00273560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275540, XrefRangeEnd = 275567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContactsApp() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009ABB RID: 39611 RVA: 0x0004BA25 File Offset: 0x00049C25
		public ContactsApp(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002F9B RID: 12187
		// (get) Token: 0x06009ABC RID: 39612 RVA: 0x0027539C File Offset: 0x0027359C
		// (set) Token: 0x06009ABD RID: 39613 RVA: 0x0004BA2E File Offset: 0x00049C2E
		public unsafe EMapRegion SelectedRegion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_SelectedRegion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_SelectedRegion)) = value;
			}
		}

		// Token: 0x17002F9C RID: 12188
		// (get) Token: 0x06009ABE RID: 39614 RVA: 0x002753C4 File Offset: 0x002735C4
		// (set) Token: 0x06009ABF RID: 39615 RVA: 0x0004BA49 File Offset: 0x00049C49
		public unsafe Dictionary<EMapRegion, ContactsApp.RegionUI> RegionDict
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RegionDict);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<EMapRegion, ContactsApp.RegionUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RegionDict), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F9D RID: 12189
		// (get) Token: 0x06009AC0 RID: 39616 RVA: 0x002753F4 File Offset: 0x002735F4
		// (set) Token: 0x06009AC1 RID: 39617 RVA: 0x0004BA68 File Offset: 0x00049C68
		public unsafe RectTransform CirclesContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_CirclesContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_CirclesContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F9E RID: 12190
		// (get) Token: 0x06009AC2 RID: 39618 RVA: 0x00275424 File Offset: 0x00273624
		// (set) Token: 0x06009AC3 RID: 39619 RVA: 0x0004BA87 File Offset: 0x00049C87
		public unsafe RectTransform DemoCirclesContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_DemoCirclesContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_DemoCirclesContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F9F RID: 12191
		// (get) Token: 0x06009AC4 RID: 39620 RVA: 0x00275454 File Offset: 0x00273654
		// (set) Token: 0x06009AC5 RID: 39621 RVA: 0x0004BAA6 File Offset: 0x00049CA6
		public unsafe RectTransform TutorialCirclesContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_TutorialCirclesContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_TutorialCirclesContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FA0 RID: 12192
		// (get) Token: 0x06009AC6 RID: 39622 RVA: 0x00275484 File Offset: 0x00273684
		// (set) Token: 0x06009AC7 RID: 39623 RVA: 0x0004BAC5 File Offset: 0x00049CC5
		public unsafe RectTransform ConnectionsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_ConnectionsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_ConnectionsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FA1 RID: 12193
		// (get) Token: 0x06009AC8 RID: 39624 RVA: 0x002754B4 File Offset: 0x002736B4
		// (set) Token: 0x06009AC9 RID: 39625 RVA: 0x0004BAE4 File Offset: 0x00049CE4
		public unsafe RectTransform ContentRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_ContentRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_ContentRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FA2 RID: 12194
		// (get) Token: 0x06009ACA RID: 39626 RVA: 0x002754E4 File Offset: 0x002736E4
		// (set) Token: 0x06009ACB RID: 39627 RVA: 0x0004BB03 File Offset: 0x00049D03
		public unsafe RectTransform SelectionIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_SelectionIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_SelectionIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FA3 RID: 12195
		// (get) Token: 0x06009ACC RID: 39628 RVA: 0x00275514 File Offset: 0x00273714
		// (set) Token: 0x06009ACD RID: 39629 RVA: 0x0004BB22 File Offset: 0x00049D22
		public unsafe ContactsDetailPanel DetailPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_DetailPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContactsDetailPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_DetailPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FA4 RID: 12196
		// (get) Token: 0x06009ACE RID: 39630 RVA: 0x00275544 File Offset: 0x00273744
		// (set) Token: 0x06009ACF RID: 39631 RVA: 0x0004BB41 File Offset: 0x00049D41
		public unsafe Il2CppReferenceArray<ContactsApp.RegionUI> RegionUIs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RegionUIs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ContactsApp.RegionUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RegionUIs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FA5 RID: 12197
		// (get) Token: 0x06009AD0 RID: 39632 RVA: 0x00275574 File Offset: 0x00273774
		// (set) Token: 0x06009AD1 RID: 39633 RVA: 0x0004BB60 File Offset: 0x00049D60
		public unsafe RectTransform RegionSelectionContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RegionSelectionContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RegionSelectionContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FA6 RID: 12198
		// (get) Token: 0x06009AD2 RID: 39634 RVA: 0x002755A4 File Offset: 0x002737A4
		// (set) Token: 0x06009AD3 RID: 39635 RVA: 0x0004BB7F File Offset: 0x00049D7F
		public unsafe RectTransform RegionSelectionIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RegionSelectionIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RegionSelectionIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FA7 RID: 12199
		// (get) Token: 0x06009AD4 RID: 39636 RVA: 0x002755D4 File Offset: 0x002737D4
		// (set) Token: 0x06009AD5 RID: 39637 RVA: 0x0004BB9E File Offset: 0x00049D9E
		public unsafe RectTransform LockedRegionContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_LockedRegionContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_LockedRegionContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FA8 RID: 12200
		// (get) Token: 0x06009AD6 RID: 39638 RVA: 0x00275604 File Offset: 0x00273804
		// (set) Token: 0x06009AD7 RID: 39639 RVA: 0x0004BBBD File Offset: 0x00049DBD
		public unsafe Text RegionRankRequirementLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RegionRankRequirementLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RegionRankRequirementLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FA9 RID: 12201
		// (get) Token: 0x06009AD8 RID: 39640 RVA: 0x00275634 File Offset: 0x00273834
		// (set) Token: 0x06009AD9 RID: 39641 RVA: 0x0004BBDC File Offset: 0x00049DDC
		public unsafe Image SelectedRegionIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_SelectedRegionIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_SelectedRegionIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FAA RID: 12202
		// (get) Token: 0x06009ADA RID: 39642 RVA: 0x00275664 File Offset: 0x00273864
		// (set) Token: 0x06009ADB RID: 39643 RVA: 0x0004BBFB File Offset: 0x00049DFB
		public unsafe GameObject ConnectionPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_ConnectionPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_ConnectionPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FAB RID: 12203
		// (get) Token: 0x06009ADC RID: 39644 RVA: 0x00275694 File Offset: 0x00273894
		// (set) Token: 0x06009ADD RID: 39645 RVA: 0x0004BC1A File Offset: 0x00049E1A
		public unsafe List<RelationCircle> RelationCircles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RelationCircles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RelationCircle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RelationCircles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FAC RID: 12204
		// (get) Token: 0x06009ADE RID: 39646 RVA: 0x002756C4 File Offset: 0x002738C4
		// (set) Token: 0x06009ADF RID: 39647 RVA: 0x0004BC39 File Offset: 0x00049E39
		public unsafe Coroutine contentMoveRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_contentMoveRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_contentMoveRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FAD RID: 12205
		// (get) Token: 0x06009AE0 RID: 39648 RVA: 0x002756F4 File Offset: 0x002738F4
		// (set) Token: 0x06009AE1 RID: 39649 RVA: 0x0004BC58 File Offset: 0x00049E58
		public unsafe List<Tuple<NPC, NPC>> connections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_connections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Tuple<NPC, NPC>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_connections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400680C RID: 26636
		private static readonly IntPtr NativeFieldInfoPtr_SelectedRegion;

		// Token: 0x0400680D RID: 26637
		private static readonly IntPtr NativeFieldInfoPtr_RegionDict;

		// Token: 0x0400680E RID: 26638
		private static readonly IntPtr NativeFieldInfoPtr_CirclesContainer;

		// Token: 0x0400680F RID: 26639
		private static readonly IntPtr NativeFieldInfoPtr_DemoCirclesContainer;

		// Token: 0x04006810 RID: 26640
		private static readonly IntPtr NativeFieldInfoPtr_TutorialCirclesContainer;

		// Token: 0x04006811 RID: 26641
		private static readonly IntPtr NativeFieldInfoPtr_ConnectionsContainer;

		// Token: 0x04006812 RID: 26642
		private static readonly IntPtr NativeFieldInfoPtr_ContentRect;

		// Token: 0x04006813 RID: 26643
		private static readonly IntPtr NativeFieldInfoPtr_SelectionIndicator;

		// Token: 0x04006814 RID: 26644
		private static readonly IntPtr NativeFieldInfoPtr_DetailPanel;

		// Token: 0x04006815 RID: 26645
		private static readonly IntPtr NativeFieldInfoPtr_RegionUIs;

		// Token: 0x04006816 RID: 26646
		private static readonly IntPtr NativeFieldInfoPtr_RegionSelectionContainer;

		// Token: 0x04006817 RID: 26647
		private static readonly IntPtr NativeFieldInfoPtr_RegionSelectionIndicator;

		// Token: 0x04006818 RID: 26648
		private static readonly IntPtr NativeFieldInfoPtr_LockedRegionContainer;

		// Token: 0x04006819 RID: 26649
		private static readonly IntPtr NativeFieldInfoPtr_RegionRankRequirementLabel;

		// Token: 0x0400681A RID: 26650
		private static readonly IntPtr NativeFieldInfoPtr_SelectedRegionIcon;

		// Token: 0x0400681B RID: 26651
		private static readonly IntPtr NativeFieldInfoPtr_ConnectionPrefab;

		// Token: 0x0400681C RID: 26652
		private static readonly IntPtr NativeFieldInfoPtr_RelationCircles;

		// Token: 0x0400681D RID: 26653
		private static readonly IntPtr NativeFieldInfoPtr_contentMoveRoutine;

		// Token: 0x0400681E RID: 26654
		private static readonly IntPtr NativeFieldInfoPtr_connections;

		// Token: 0x0400681F RID: 26655
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04006820 RID: 26656
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04006821 RID: 26657
		private static readonly IntPtr NativeMethodInfoPtr_GetRelationCircle_Private_RelationCircle_String_0;

		// Token: 0x04006822 RID: 26658
		private static readonly IntPtr NativeMethodInfoPtr_CircleClicked_Private_Void_RelationCircle_0;

		// Token: 0x04006823 RID: 26659
		private static readonly IntPtr NativeMethodInfoPtr_Select_Private_Void_RelationCircle_0;

		// Token: 0x04006824 RID: 26660
		private static readonly IntPtr NativeMethodInfoPtr_SetSelectedRegion_Public_Void_EMapRegion_0;

		// Token: 0x04006825 RID: 26661
		private static readonly IntPtr NativeMethodInfoPtr_ZoomToRect_Private_Void_RectTransform_0;

		// Token: 0x04006826 RID: 26662
		private static readonly IntPtr NativeMethodInfoPtr_StopContentMove_Private_Void_0;

		// Token: 0x04006827 RID: 26663
		private static readonly IntPtr NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0;

		// Token: 0x04006828 RID: 26664
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B83 RID: 2947
		[Serializable]
		public class RegionUI : Il2CppSystem.Object
		{
			// Token: 0x0600DB8F RID: 56207 RVA: 0x0033F8AC File Offset: 0x0033DAAC
			// Note: this type is marked as 'beforefieldinit'.
			static RegionUI()
			{
				Il2CppClassPointerStore<ContactsApp.RegionUI>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "RegionUI");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactsApp.RegionUI>.NativeClassPtr);
				ContactsApp.RegionUI.NativeFieldInfoPtr_Region = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.RegionUI>.NativeClassPtr, "Region");
				ContactsApp.RegionUI.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.RegionUI>.NativeClassPtr, "Button");
				ContactsApp.RegionUI.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.RegionUI>.NativeClassPtr, "Container");
				ContactsApp.RegionUI.NativeFieldInfoPtr_ConnectionsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.RegionUI>.NativeClassPtr, "ConnectionsContainer");
				ContactsApp.RegionUI.NativeFieldInfoPtr__npcs_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.RegionUI>.NativeClassPtr, "<npcs>k__BackingField");
				ContactsApp.RegionUI.NativeMethodInfoPtr_get_npcs_Public_get_List_1_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.RegionUI>.NativeClassPtr, 100682336);
				ContactsApp.RegionUI.NativeMethodInfoPtr_set_npcs_Public_set_Void_List_1_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.RegionUI>.NativeClassPtr, 100682337);
				ContactsApp.RegionUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.RegionUI>.NativeClassPtr, 100682338);
			}

			// Token: 0x1700441B RID: 17435
			// (get) Token: 0x0600DB90 RID: 56208 RVA: 0x0033F978 File Offset: 0x0033DB78
			// (set) Token: 0x0600DB91 RID: 56209 RVA: 0x0033F9B8 File Offset: 0x0033DBB8
			public unsafe List<NPC> npcs
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 19644, RefRangeEnd = 19658, XrefRangeStart = 19644, XrefRangeEnd = 19658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.RegionUI.NativeMethodInfoPtr_get_npcs_Public_get_List_1_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr3) : null;
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 19659, RefRangeEnd = 19660, XrefRangeStart = 19659, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.RegionUI.NativeMethodInfoPtr_set_npcs_Public_set_Void_List_1_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600DB92 RID: 56210 RVA: 0x0033F9FC File Offset: 0x0033DBFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275082, XrefRangeEnd = 275090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RegionUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContactsApp.RegionUI>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.RegionUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB93 RID: 56211 RVA: 0x0006AF16 File Offset: 0x00069116
			public RegionUI(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004416 RID: 17430
			// (get) Token: 0x0600DB94 RID: 56212 RVA: 0x0033FA38 File Offset: 0x0033DC38
			// (set) Token: 0x0600DB95 RID: 56213 RVA: 0x0006AF1F File Offset: 0x0006911F
			public unsafe EMapRegion Region
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.RegionUI.NativeFieldInfoPtr_Region);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.RegionUI.NativeFieldInfoPtr_Region)) = value;
				}
			}

			// Token: 0x17004417 RID: 17431
			// (get) Token: 0x0600DB96 RID: 56214 RVA: 0x0033FA60 File Offset: 0x0033DC60
			// (set) Token: 0x0600DB97 RID: 56215 RVA: 0x0006AF3A File Offset: 0x0006913A
			public unsafe Button Button
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.RegionUI.NativeFieldInfoPtr_Button);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.RegionUI.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004418 RID: 17432
			// (get) Token: 0x0600DB98 RID: 56216 RVA: 0x0033FA90 File Offset: 0x0033DC90
			// (set) Token: 0x0600DB99 RID: 56217 RVA: 0x0006AF59 File Offset: 0x00069159
			public unsafe RectTransform Container
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.RegionUI.NativeFieldInfoPtr_Container);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.RegionUI.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004419 RID: 17433
			// (get) Token: 0x0600DB9A RID: 56218 RVA: 0x0033FAC0 File Offset: 0x0033DCC0
			// (set) Token: 0x0600DB9B RID: 56219 RVA: 0x0006AF78 File Offset: 0x00069178
			public unsafe RectTransform ConnectionsContainer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.RegionUI.NativeFieldInfoPtr_ConnectionsContainer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.RegionUI.NativeFieldInfoPtr_ConnectionsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700441A RID: 17434
			// (get) Token: 0x0600DB9C RID: 56220 RVA: 0x0033FAF0 File Offset: 0x0033DCF0
			// (set) Token: 0x0600DB9D RID: 56221 RVA: 0x0006AF97 File Offset: 0x00069197
			public unsafe List<NPC> _npcs_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.RegionUI.NativeFieldInfoPtr__npcs_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.RegionUI.NativeFieldInfoPtr__npcs_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009344 RID: 37700
			private static readonly IntPtr NativeFieldInfoPtr_Region;

			// Token: 0x04009345 RID: 37701
			private static readonly IntPtr NativeFieldInfoPtr_Button;

			// Token: 0x04009346 RID: 37702
			private static readonly IntPtr NativeFieldInfoPtr_Container;

			// Token: 0x04009347 RID: 37703
			private static readonly IntPtr NativeFieldInfoPtr_ConnectionsContainer;

			// Token: 0x04009348 RID: 37704
			private static readonly IntPtr NativeFieldInfoPtr__npcs_k__BackingField;

			// Token: 0x04009349 RID: 37705
			private static readonly IntPtr NativeMethodInfoPtr_get_npcs_Public_get_List_1_NPC_0;

			// Token: 0x0400934A RID: 37706
			private static readonly IntPtr NativeMethodInfoPtr_set_npcs_Public_set_Void_List_1_NPC_0;

			// Token: 0x0400934B RID: 37707
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000B84 RID: 2948
		[ObfuscatedName("ScheduleOne.UI.Phone.ContactsApp.ContactsApp+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DB9E RID: 56222 RVA: 0x0033FB20 File Offset: 0x0033DD20
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_0>.NativeClassPtr);
				ContactsApp.__c__DisplayClass20_0.NativeFieldInfoPtr_cacheReg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_0>.NativeClassPtr, "cacheReg");
				ContactsApp.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_0>.NativeClassPtr, "<>4__this");
				ContactsApp.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_0>.NativeClassPtr, 100682339);
				ContactsApp.__c__DisplayClass20_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_0>.NativeClassPtr, 100682340);
			}

			// Token: 0x0600DB9F RID: 56223 RVA: 0x0033FB9C File Offset: 0x0033DD9C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBA0 RID: 56224 RVA: 0x0033FBD8 File Offset: 0x0033DDD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275090, XrefRangeEnd = 275092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass20_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBA1 RID: 56225 RVA: 0x0006AFB6 File Offset: 0x000691B6
			public __c__DisplayClass20_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700441C RID: 17436
			// (get) Token: 0x0600DBA2 RID: 56226 RVA: 0x0033FC0C File Offset: 0x0033DE0C
			// (set) Token: 0x0600DBA3 RID: 56227 RVA: 0x0006AFBF File Offset: 0x000691BF
			public unsafe ContactsApp.RegionUI cacheReg
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_0.NativeFieldInfoPtr_cacheReg);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContactsApp.RegionUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_0.NativeFieldInfoPtr_cacheReg), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700441D RID: 17437
			// (get) Token: 0x0600DBA4 RID: 56228 RVA: 0x0033FC3C File Offset: 0x0033DE3C
			// (set) Token: 0x0600DBA5 RID: 56229 RVA: 0x0006AFDE File Offset: 0x000691DE
			public unsafe ContactsApp __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContactsApp>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400934C RID: 37708
			private static readonly IntPtr NativeFieldInfoPtr_cacheReg;

			// Token: 0x0400934D RID: 37709
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400934E RID: 37710
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400934F RID: 37711
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__0_Internal_Void_0;
		}

		// Token: 0x02000B85 RID: 2949
		[ObfuscatedName("ScheduleOne.UI.Phone.ContactsApp.ContactsApp+<>c__DisplayClass20_1")]
		public sealed class __c__DisplayClass20_1 : Il2CppSystem.Object
		{
			// Token: 0x0600DBA6 RID: 56230 RVA: 0x0033FC6C File Offset: 0x0033DE6C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_1()
			{
				Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "<>c__DisplayClass20_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_1>.NativeClassPtr);
				ContactsApp.__c__DisplayClass20_1.NativeFieldInfoPtr_rel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_1>.NativeClassPtr, "rel");
				ContactsApp.__c__DisplayClass20_1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_1>.NativeClassPtr, "<>4__this");
				ContactsApp.__c__DisplayClass20_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_1>.NativeClassPtr, 100682341);
				ContactsApp.__c__DisplayClass20_1.NativeMethodInfoPtr__Start_b__1_Internal_Boolean_RegionUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_1>.NativeClassPtr, 100682342);
			}

			// Token: 0x0600DBA7 RID: 56231 RVA: 0x0033FCE8 File Offset: 0x0033DEE8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass20_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBA8 RID: 56232 RVA: 0x0033FD24 File Offset: 0x0033DF24
			[CallerCount(0)]
			public unsafe bool _Start_b__1(ContactsApp.RegionUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass20_1.NativeMethodInfoPtr__Start_b__1_Internal_Boolean_RegionUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DBA9 RID: 56233 RVA: 0x0006AFFD File Offset: 0x000691FD
			public __c__DisplayClass20_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700441E RID: 17438
			// (get) Token: 0x0600DBAA RID: 56234 RVA: 0x0033FD74 File Offset: 0x0033DF74
			// (set) Token: 0x0600DBAB RID: 56235 RVA: 0x0006B006 File Offset: 0x00069206
			public unsafe RelationCircle rel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_1.NativeFieldInfoPtr_rel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RelationCircle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_1.NativeFieldInfoPtr_rel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700441F RID: 17439
			// (get) Token: 0x0600DBAC RID: 56236 RVA: 0x0033FDA4 File Offset: 0x0033DFA4
			// (set) Token: 0x0600DBAD RID: 56237 RVA: 0x0006B025 File Offset: 0x00069225
			public unsafe ContactsApp __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContactsApp>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009350 RID: 37712
			private static readonly IntPtr NativeFieldInfoPtr_rel;

			// Token: 0x04009351 RID: 37713
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009352 RID: 37714
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009353 RID: 37715
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__1_Internal_Boolean_RegionUI_0;
		}

		// Token: 0x02000B86 RID: 2950
		[ObfuscatedName("ScheduleOne.UI.Phone.ContactsApp.ContactsApp+<>c__DisplayClass20_2")]
		public sealed class __c__DisplayClass20_2 : Il2CppSystem.Object
		{
			// Token: 0x0600DBAE RID: 56238 RVA: 0x0033FDD4 File Offset: 0x0033DFD4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_2()
			{
				Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "<>c__DisplayClass20_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_2>.NativeClassPtr);
				ContactsApp.__c__DisplayClass20_2.NativeFieldInfoPtr_other = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_2>.NativeClassPtr, "other");
				ContactsApp.__c__DisplayClass20_2.NativeFieldInfoPtr_field_Public___c__DisplayClass20_1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_2>.NativeClassPtr, "CS$<>8__locals1");
				ContactsApp.__c__DisplayClass20_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_2>.NativeClassPtr, 100682343);
				ContactsApp.__c__DisplayClass20_2.NativeMethodInfoPtr__Start_b__2_Internal_Boolean_Tuple_2_NPC_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_2>.NativeClassPtr, 100682344);
				ContactsApp.__c__DisplayClass20_2.NativeMethodInfoPtr__Start_b__3_Internal_Boolean_Tuple_2_NPC_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_2>.NativeClassPtr, 100682345);
			}

			// Token: 0x0600DBAF RID: 56239 RVA: 0x0033FE64 File Offset: 0x0033E064
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass20_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBB0 RID: 56240 RVA: 0x0033FEA0 File Offset: 0x0033E0A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275092, XrefRangeEnd = 275098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Start_b__2(Tuple<NPC, NPC> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass20_2.NativeMethodInfoPtr__Start_b__2_Internal_Boolean_Tuple_2_NPC_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DBB1 RID: 56241 RVA: 0x0033FEF0 File Offset: 0x0033E0F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275098, XrefRangeEnd = 275104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Start_b__3(Tuple<NPC, NPC> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass20_2.NativeMethodInfoPtr__Start_b__3_Internal_Boolean_Tuple_2_NPC_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DBB2 RID: 56242 RVA: 0x0006B044 File Offset: 0x00069244
			public __c__DisplayClass20_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004420 RID: 17440
			// (get) Token: 0x0600DBB3 RID: 56243 RVA: 0x0033FF40 File Offset: 0x0033E140
			// (set) Token: 0x0600DBB4 RID: 56244 RVA: 0x0006B04D File Offset: 0x0006924D
			public unsafe NPC other
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_2.NativeFieldInfoPtr_other);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_2.NativeFieldInfoPtr_other), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004421 RID: 17441
			// (get) Token: 0x0600DBB5 RID: 56245 RVA: 0x0033FF70 File Offset: 0x0033E170
			// (set) Token: 0x0600DBB6 RID: 56246 RVA: 0x0006B06C File Offset: 0x0006926C
			public unsafe ContactsApp.__c__DisplayClass20_1 field_Public___c__DisplayClass20_1_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_2.NativeFieldInfoPtr_field_Public___c__DisplayClass20_1_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContactsApp.__c__DisplayClass20_1>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_2.NativeFieldInfoPtr_field_Public___c__DisplayClass20_1_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009354 RID: 37716
			private static readonly IntPtr NativeFieldInfoPtr_other;

			// Token: 0x04009355 RID: 37717
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass20_1_0;

			// Token: 0x04009356 RID: 37718
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009357 RID: 37719
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__2_Internal_Boolean_Tuple_2_NPC_NPC_0;

			// Token: 0x04009358 RID: 37720
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__3_Internal_Boolean_Tuple_2_NPC_NPC_0;
		}

		// Token: 0x02000B87 RID: 2951
		[ObfuscatedName("ScheduleOne.UI.Phone.ContactsApp.ContactsApp+<>c__DisplayClass20_3")]
		public sealed class __c__DisplayClass20_3 : Il2CppSystem.Object
		{
			// Token: 0x0600DBB7 RID: 56247 RVA: 0x0033FFA0 File Offset: 0x0033E1A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_3()
			{
				Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "<>c__DisplayClass20_3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_3>.NativeClassPtr);
				ContactsApp.__c__DisplayClass20_3.NativeFieldInfoPtr_otherCirc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_3>.NativeClassPtr, "otherCirc");
				ContactsApp.__c__DisplayClass20_3.NativeFieldInfoPtr_cacheRel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_3>.NativeClassPtr, "cacheRel");
				ContactsApp.__c__DisplayClass20_3.NativeFieldInfoPtr_field_Public___c__DisplayClass20_2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_3>.NativeClassPtr, "CS$<>8__locals2");
				ContactsApp.__c__DisplayClass20_3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_3>.NativeClassPtr, 100682346);
				ContactsApp.__c__DisplayClass20_3.NativeMethodInfoPtr__Start_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_3>.NativeClassPtr, 100682347);
				ContactsApp.__c__DisplayClass20_3.NativeMethodInfoPtr__Start_b__5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_3>.NativeClassPtr, 100682348);
			}

			// Token: 0x0600DBB8 RID: 56248 RVA: 0x00340044 File Offset: 0x0033E244
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_3() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_3>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass20_3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBB9 RID: 56249 RVA: 0x00340080 File Offset: 0x0033E280
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275104, XrefRangeEnd = 275106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass20_3.NativeMethodInfoPtr__Start_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBBA RID: 56250 RVA: 0x003400B4 File Offset: 0x0033E2B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275106, XrefRangeEnd = 275108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass20_3.NativeMethodInfoPtr__Start_b__5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBBB RID: 56251 RVA: 0x0006B08B File Offset: 0x0006928B
			public __c__DisplayClass20_3(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004422 RID: 17442
			// (get) Token: 0x0600DBBC RID: 56252 RVA: 0x003400E8 File Offset: 0x0033E2E8
			// (set) Token: 0x0600DBBD RID: 56253 RVA: 0x0006B094 File Offset: 0x00069294
			public unsafe RelationCircle otherCirc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_3.NativeFieldInfoPtr_otherCirc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RelationCircle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_3.NativeFieldInfoPtr_otherCirc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004423 RID: 17443
			// (get) Token: 0x0600DBBE RID: 56254 RVA: 0x00340118 File Offset: 0x0033E318
			// (set) Token: 0x0600DBBF RID: 56255 RVA: 0x0006B0B3 File Offset: 0x000692B3
			public unsafe RelationCircle cacheRel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_3.NativeFieldInfoPtr_cacheRel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RelationCircle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_3.NativeFieldInfoPtr_cacheRel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004424 RID: 17444
			// (get) Token: 0x0600DBC0 RID: 56256 RVA: 0x00340148 File Offset: 0x0033E348
			// (set) Token: 0x0600DBC1 RID: 56257 RVA: 0x0006B0D2 File Offset: 0x000692D2
			public unsafe ContactsApp.__c__DisplayClass20_2 field_Public___c__DisplayClass20_2_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_3.NativeFieldInfoPtr_field_Public___c__DisplayClass20_2_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContactsApp.__c__DisplayClass20_2>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_3.NativeFieldInfoPtr_field_Public___c__DisplayClass20_2_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009359 RID: 37721
			private static readonly IntPtr NativeFieldInfoPtr_otherCirc;

			// Token: 0x0400935A RID: 37722
			private static readonly IntPtr NativeFieldInfoPtr_cacheRel;

			// Token: 0x0400935B RID: 37723
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass20_2_0;

			// Token: 0x0400935C RID: 37724
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400935D RID: 37725
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__4_Internal_Void_0;

			// Token: 0x0400935E RID: 37726
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__5_Internal_Void_0;
		}

		// Token: 0x02000B88 RID: 2952
		[ObfuscatedName("ScheduleOne.UI.Phone.ContactsApp.ContactsApp+<>c__DisplayClass20_4")]
		public sealed class __c__DisplayClass20_4 : Il2CppSystem.Object
		{
			// Token: 0x0600DBC2 RID: 56258 RVA: 0x00340178 File Offset: 0x0033E378
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_4()
			{
				Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "<>c__DisplayClass20_4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_4>.NativeClassPtr);
				ContactsApp.__c__DisplayClass20_4.NativeFieldInfoPtr_circ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_4>.NativeClassPtr, "circ");
				ContactsApp.__c__DisplayClass20_4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_4>.NativeClassPtr, "<>4__this");
				ContactsApp.__c__DisplayClass20_4.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_4>.NativeClassPtr, 100682349);
				ContactsApp.__c__DisplayClass20_4.NativeMethodInfoPtr__Start_b__6_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_4>.NativeClassPtr, 100682350);
			}

			// Token: 0x0600DBC3 RID: 56259 RVA: 0x003401F4 File Offset: 0x0033E3F4
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_4() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_4>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass20_4.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBC4 RID: 56260 RVA: 0x00340230 File Offset: 0x0033E430
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275108, XrefRangeEnd = 275112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__6()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass20_4.NativeMethodInfoPtr__Start_b__6_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBC5 RID: 56261 RVA: 0x0006B0F1 File Offset: 0x000692F1
			public __c__DisplayClass20_4(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004425 RID: 17445
			// (get) Token: 0x0600DBC6 RID: 56262 RVA: 0x00340264 File Offset: 0x0033E464
			// (set) Token: 0x0600DBC7 RID: 56263 RVA: 0x0006B0FA File Offset: 0x000692FA
			public unsafe RelationCircle circ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_4.NativeFieldInfoPtr_circ);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RelationCircle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_4.NativeFieldInfoPtr_circ), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004426 RID: 17446
			// (get) Token: 0x0600DBC8 RID: 56264 RVA: 0x00340294 File Offset: 0x0033E494
			// (set) Token: 0x0600DBC9 RID: 56265 RVA: 0x0006B119 File Offset: 0x00069319
			public unsafe ContactsApp __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContactsApp>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400935F RID: 37727
			private static readonly IntPtr NativeFieldInfoPtr_circ;

			// Token: 0x04009360 RID: 37728
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009361 RID: 37729
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009362 RID: 37730
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__6_Internal_Void_0;
		}

		// Token: 0x02000B89 RID: 2953
		[ObfuscatedName("ScheduleOne.UI.Phone.ContactsApp.ContactsApp+<>c__DisplayClass22_0")]
		public sealed class __c__DisplayClass22_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DBCA RID: 56266 RVA: 0x003402C4 File Offset: 0x0033E4C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass22_0()
			{
				Il2CppClassPointerStore<ContactsApp.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "<>c__DisplayClass22_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass22_0>.NativeClassPtr);
				ContactsApp.__c__DisplayClass22_0.NativeFieldInfoPtr_npcID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass22_0>.NativeClassPtr, "npcID");
				ContactsApp.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass22_0>.NativeClassPtr, 100682351);
				ContactsApp.__c__DisplayClass22_0.NativeMethodInfoPtr__GetRelationCircle_b__0_Internal_Boolean_RelationCircle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass22_0>.NativeClassPtr, 100682352);
			}

			// Token: 0x0600DBCB RID: 56267 RVA: 0x0034032C File Offset: 0x0033E52C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass22_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBCC RID: 56268 RVA: 0x00340368 File Offset: 0x0033E568
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275112, XrefRangeEnd = 275116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetRelationCircle_b__0(RelationCircle x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass22_0.NativeMethodInfoPtr__GetRelationCircle_b__0_Internal_Boolean_RelationCircle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DBCD RID: 56269 RVA: 0x0006B138 File Offset: 0x00069338
			public __c__DisplayClass22_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004427 RID: 17447
			// (get) Token: 0x0600DBCE RID: 56270 RVA: 0x003403B8 File Offset: 0x0033E5B8
			// (set) Token: 0x0600DBCF RID: 56271 RVA: 0x0006B141 File Offset: 0x00069341
			public unsafe string npcID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass22_0.NativeFieldInfoPtr_npcID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass22_0.NativeFieldInfoPtr_npcID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009363 RID: 37731
			private static readonly IntPtr NativeFieldInfoPtr_npcID;

			// Token: 0x04009364 RID: 37732
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009365 RID: 37733
			private static readonly IntPtr NativeMethodInfoPtr__GetRelationCircle_b__0_Internal_Boolean_RelationCircle_0;
		}

		// Token: 0x02000B8A RID: 2954
		[ObfuscatedName("ScheduleOne.UI.Phone.ContactsApp.ContactsApp+<>c__DisplayClass26_0")]
		public sealed class __c__DisplayClass26_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DBD0 RID: 56272 RVA: 0x003403E0 File Offset: 0x0033E5E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_0()
			{
				Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "<>c__DisplayClass26_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0>.NativeClassPtr);
				ContactsApp.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0>.NativeClassPtr, "<>4__this");
				ContactsApp.__c__DisplayClass26_0.NativeFieldInfoPtr_endPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0>.NativeClassPtr, "endPos");
				ContactsApp.__c__DisplayClass26_0.NativeFieldInfoPtr_startScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0>.NativeClassPtr, "startScale");
				ContactsApp.__c__DisplayClass26_0.NativeFieldInfoPtr_endScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0>.NativeClassPtr, "endScale");
				ContactsApp.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0>.NativeClassPtr, 100682353);
				ContactsApp.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0>.NativeClassPtr, 100682354);
			}

			// Token: 0x0600DBD1 RID: 56273 RVA: 0x00340484 File Offset: 0x0033E684
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBD2 RID: 56274 RVA: 0x003404C0 File Offset: 0x0033E6C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275141, XrefRangeEnd = 275146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DBD3 RID: 56275 RVA: 0x0006B160 File Offset: 0x00069360
			public __c__DisplayClass26_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004428 RID: 17448
			// (get) Token: 0x0600DBD4 RID: 56276 RVA: 0x00340500 File Offset: 0x0033E700
			// (set) Token: 0x0600DBD5 RID: 56277 RVA: 0x0006B169 File Offset: 0x00069369
			public unsafe ContactsApp __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContactsApp>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004429 RID: 17449
			// (get) Token: 0x0600DBD6 RID: 56278 RVA: 0x00340530 File Offset: 0x0033E730
			// (set) Token: 0x0600DBD7 RID: 56279 RVA: 0x0006B188 File Offset: 0x00069388
			public unsafe Vector2 endPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.NativeFieldInfoPtr_endPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.NativeFieldInfoPtr_endPos)) = value;
				}
			}

			// Token: 0x1700442A RID: 17450
			// (get) Token: 0x0600DBD8 RID: 56280 RVA: 0x00340558 File Offset: 0x0033E758
			// (set) Token: 0x0600DBD9 RID: 56281 RVA: 0x0006B1A3 File Offset: 0x000693A3
			public unsafe float startScale
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.NativeFieldInfoPtr_startScale);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.NativeFieldInfoPtr_startScale)) = value;
				}
			}

			// Token: 0x1700442B RID: 17451
			// (get) Token: 0x0600DBDA RID: 56282 RVA: 0x00340580 File Offset: 0x0033E780
			// (set) Token: 0x0600DBDB RID: 56283 RVA: 0x0006B1BE File Offset: 0x000693BE
			public unsafe float endScale
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.NativeFieldInfoPtr_endScale);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.NativeFieldInfoPtr_endScale)) = value;
				}
			}

			// Token: 0x04009366 RID: 37734
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009367 RID: 37735
			private static readonly IntPtr NativeFieldInfoPtr_endPos;

			// Token: 0x04009368 RID: 37736
			private static readonly IntPtr NativeFieldInfoPtr_startScale;

			// Token: 0x04009369 RID: 37737
			private static readonly IntPtr NativeFieldInfoPtr_endScale;

			// Token: 0x0400936A RID: 37738
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400936B RID: 37739
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C7F RID: 3199
			[ObfuscatedName("ScheduleOne.UI.Phone.ContactsApp.ContactsApp+<>c__DisplayClass26_0+<<ZoomToRect>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E652 RID: 58962 RVA: 0x0035E8D8 File Offset: 0x0035CAD8
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique()
				{
					Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0>.NativeClassPtr, "<<ZoomToRect>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr);
					ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr, "<>1__state");
					ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr, "<>2__current");
					ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr, "<>4__this");
					ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr__startPos_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr, "<startPos>5__2");
					ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr, "<lerpTime>5__3");
					ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr, "<i>5__4");
					ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr, 100682355);
					ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr, 100682356);
					ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr, 100682357);
					ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr, 100682358);
					ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr, 100682359);
					ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr, 100682360);
				}

				// Token: 0x0600E653 RID: 58963 RVA: 0x0035E9F4 File Offset: 0x0035CBF4
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E654 RID: 58964 RVA: 0x0035EA3C File Offset: 0x0035CC3C
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E655 RID: 58965 RVA: 0x0035EA70 File Offset: 0x0035CC70
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275116, XrefRangeEnd = 275136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170047B5 RID: 18357
				// (get) Token: 0x0600E656 RID: 58966 RVA: 0x0035EAAC File Offset: 0x0035CCAC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E657 RID: 58967 RVA: 0x0035EAEC File Offset: 0x0035CCEC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275136, XrefRangeEnd = 275141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170047B6 RID: 18358
				// (get) Token: 0x0600E658 RID: 58968 RVA: 0x0035EB20 File Offset: 0x0035CD20
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E659 RID: 58969 RVA: 0x00070687 File Offset: 0x0006E887
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170047AF RID: 18351
				// (get) Token: 0x0600E65A RID: 58970 RVA: 0x0035EB60 File Offset: 0x0035CD60
				// (set) Token: 0x0600E65B RID: 58971 RVA: 0x00070690 File Offset: 0x0006E890
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170047B0 RID: 18352
				// (get) Token: 0x0600E65C RID: 58972 RVA: 0x0035EB88 File Offset: 0x0035CD88
				// (set) Token: 0x0600E65D RID: 58973 RVA: 0x000706AB File Offset: 0x0006E8AB
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047B1 RID: 18353
				// (get) Token: 0x0600E65E RID: 58974 RVA: 0x0035EBB8 File Offset: 0x0035CDB8
				// (set) Token: 0x0600E65F RID: 58975 RVA: 0x000706CA File Offset: 0x0006E8CA
				public unsafe ContactsApp.__c__DisplayClass26_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContactsApp.__c__DisplayClass26_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047B2 RID: 18354
				// (get) Token: 0x0600E660 RID: 58976 RVA: 0x0035EBE8 File Offset: 0x0035CDE8
				// (set) Token: 0x0600E661 RID: 58977 RVA: 0x000706E9 File Offset: 0x0006E8E9
				public unsafe Vector2 _startPos_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr__startPos_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr__startPos_5__2)) = value;
					}
				}

				// Token: 0x170047B3 RID: 18355
				// (get) Token: 0x0600E662 RID: 58978 RVA: 0x0035EC10 File Offset: 0x0035CE10
				// (set) Token: 0x0600E663 RID: 58979 RVA: 0x00070704 File Offset: 0x0006E904
				public unsafe float _lerpTime_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__3)) = value;
					}
				}

				// Token: 0x170047B4 RID: 18356
				// (get) Token: 0x0600E664 RID: 58980 RVA: 0x0035EC38 File Offset: 0x0035CE38
				// (set) Token: 0x0600E665 RID: 58981 RVA: 0x0007071F File Offset: 0x0006E91F
				public unsafe float _i_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr__i_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr__i_5__4)) = value;
					}
				}

				// Token: 0x040099F3 RID: 39411
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040099F4 RID: 39412
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040099F5 RID: 39413
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040099F6 RID: 39414
				private static readonly IntPtr NativeFieldInfoPtr__startPos_5__2;

				// Token: 0x040099F7 RID: 39415
				private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__3;

				// Token: 0x040099F8 RID: 39416
				private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

				// Token: 0x040099F9 RID: 39417
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040099FA RID: 39418
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040099FB RID: 39419
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040099FC RID: 39420
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040099FD RID: 39421
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040099FE RID: 39422
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
