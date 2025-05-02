using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ConstructableScripts;
using Il2CppScheduleOne.EntityFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200045F RID: 1119
	public class ObjectSelector : Singleton<ObjectSelector>
	{
		// Token: 0x0600611C RID: 24860 RVA: 0x001BB6B8 File Offset: 0x001B98B8
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectSelector()
		{
			Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "ObjectSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr);
			ObjectSelector.NativeFieldInfoPtr_detectionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "detectionRange");
			ObjectSelector.NativeFieldInfoPtr_detectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "detectionMask");
			ObjectSelector.NativeFieldInfoPtr__isSelecting_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "<isSelecting>k__BackingField");
			ObjectSelector.NativeFieldInfoPtr_allowedTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "allowedTypes");
			ObjectSelector.NativeFieldInfoPtr_selectedObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "selectedObjects");
			ObjectSelector.NativeFieldInfoPtr_selectedConstructables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "selectedConstructables");
			ObjectSelector.NativeFieldInfoPtr_onClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "onClose");
			ObjectSelector.NativeFieldInfoPtr_selectionLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "selectionLimit");
			ObjectSelector.NativeFieldInfoPtr_exitOnSelectionLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "exitOnSelectionLimit");
			ObjectSelector.NativeFieldInfoPtr_hoveredBuildable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "hoveredBuildable");
			ObjectSelector.NativeFieldInfoPtr_hoveredConstructable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "hoveredConstructable");
			ObjectSelector.NativeFieldInfoPtr_outlinedObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "outlinedObjects");
			ObjectSelector.NativeFieldInfoPtr_outlinedConstructables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "outlinedConstructables");
			ObjectSelector.NativeMethodInfoPtr_get_isSelecting_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100675646);
			ObjectSelector.NativeMethodInfoPtr_set_isSelecting_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100675647);
			ObjectSelector.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100675648);
			ObjectSelector.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100675649);
			ObjectSelector.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100675650);
			ObjectSelector.NativeMethodInfoPtr_GetHoveredBuildable_Private_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100675651);
			ObjectSelector.NativeMethodInfoPtr_GetHoveredConstructable_Private_Constructable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100675652);
			ObjectSelector.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100675653);
			ObjectSelector.NativeMethodInfoPtr_StartSelecting_Public_Void_String_List_1_Type_byref_List_1_BuildableItem_byref_List_1_Constructable_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100675654);
			ObjectSelector.NativeMethodInfoPtr_StopSelecting_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100675655);
			ObjectSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100675656);
		}

		// Token: 0x17001D41 RID: 7489
		// (get) Token: 0x0600611D RID: 24861 RVA: 0x001BB8C8 File Offset: 0x001B9AC8
		// (set) Token: 0x0600611E RID: 24862 RVA: 0x001BB904 File Offset: 0x001B9B04
		public unsafe bool isSelecting
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_get_isSelecting_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_set_isSelecting_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600611F RID: 24863 RVA: 0x001BB944 File Offset: 0x001B9B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200309, XrefRangeEnd = 200322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectSelector.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006120 RID: 24864 RVA: 0x001BB980 File Offset: 0x001B9B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200322, XrefRangeEnd = 200427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectSelector.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006121 RID: 24865 RVA: 0x001BB9BC File Offset: 0x001B9BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200427, XrefRangeEnd = 200487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectSelector.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006122 RID: 24866 RVA: 0x001BB9F8 File Offset: 0x001B9BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200487, XrefRangeEnd = 200504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildableItem GetHoveredBuildable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_GetHoveredBuildable_Private_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BuildableItem>(intPtr3) : null;
		}

		// Token: 0x06006123 RID: 24867 RVA: 0x001BBA38 File Offset: 0x001B9C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200504, XrefRangeEnd = 200521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Constructable GetHoveredConstructable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_GetHoveredConstructable_Private_Constructable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Constructable>(intPtr3) : null;
		}

		// Token: 0x06006124 RID: 24868 RVA: 0x001BBA78 File Offset: 0x001B9C78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200521, XrefRangeEnd = 200522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006125 RID: 24869 RVA: 0x001BBABC File Offset: 0x001B9CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200522, XrefRangeEnd = 200562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartSelecting(string selectionTitle, List<Type> _typeRestriction, ref List<BuildableItem> initialSelection_Objects, ref List<Constructable> initalSelection_Constructables, int _selectionLimit, bool _exitOnSelectionLimit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(selectionTitle);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_typeRestriction);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(initialSelection_Objects);
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(initalSelection_Constructables);
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _selectionLimit;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _exitOnSelectionLimit;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_StartSelecting_Public_Void_String_List_1_Type_byref_List_1_BuildableItem_byref_List_1_Constructable_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			initialSelection_Objects = ((intPtr5 == 0) ? null : new List<BuildableItem>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			initalSelection_Constructables = ((intPtr6 == 0) ? null : new List<Constructable>(intPtr6));
		}

		// Token: 0x06006126 RID: 24870 RVA: 0x001BBB80 File Offset: 0x001B9D80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 200589, RefRangeEnd = 200590, XrefRangeStart = 200562, XrefRangeEnd = 200589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopSelecting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_StopSelecting_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006127 RID: 24871 RVA: 0x001BBBB4 File Offset: 0x001B9DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200590, XrefRangeEnd = 200617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectSelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006128 RID: 24872 RVA: 0x0002DE1D File Offset: 0x0002C01D
		public ObjectSelector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D34 RID: 7476
		// (get) Token: 0x06006129 RID: 24873 RVA: 0x001BBBF0 File Offset: 0x001B9DF0
		// (set) Token: 0x0600612A RID: 24874 RVA: 0x0002DE26 File Offset: 0x0002C026
		public unsafe float detectionRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_detectionRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_detectionRange)) = value;
			}
		}

		// Token: 0x17001D35 RID: 7477
		// (get) Token: 0x0600612B RID: 24875 RVA: 0x001BBC18 File Offset: 0x001B9E18
		// (set) Token: 0x0600612C RID: 24876 RVA: 0x0002DE41 File Offset: 0x0002C041
		public unsafe LayerMask detectionMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_detectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_detectionMask)) = value;
			}
		}

		// Token: 0x17001D36 RID: 7478
		// (get) Token: 0x0600612D RID: 24877 RVA: 0x001BBC40 File Offset: 0x001B9E40
		// (set) Token: 0x0600612E RID: 24878 RVA: 0x0002DE5C File Offset: 0x0002C05C
		public unsafe bool _isSelecting_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr__isSelecting_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr__isSelecting_k__BackingField)) = value;
			}
		}

		// Token: 0x17001D37 RID: 7479
		// (get) Token: 0x0600612F RID: 24879 RVA: 0x001BBC68 File Offset: 0x001B9E68
		// (set) Token: 0x06006130 RID: 24880 RVA: 0x0002DE77 File Offset: 0x0002C077
		public unsafe List<Type> allowedTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_allowedTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_allowedTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D38 RID: 7480
		// (get) Token: 0x06006131 RID: 24881 RVA: 0x001BBC98 File Offset: 0x001B9E98
		// (set) Token: 0x06006132 RID: 24882 RVA: 0x0002DE96 File Offset: 0x0002C096
		public unsafe List<BuildableItem> selectedObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_selectedObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BuildableItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_selectedObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D39 RID: 7481
		// (get) Token: 0x06006133 RID: 24883 RVA: 0x001BBCC8 File Offset: 0x001B9EC8
		// (set) Token: 0x06006134 RID: 24884 RVA: 0x0002DEB5 File Offset: 0x0002C0B5
		public unsafe List<Constructable> selectedConstructables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_selectedConstructables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Constructable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_selectedConstructables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D3A RID: 7482
		// (get) Token: 0x06006135 RID: 24885 RVA: 0x001BBCF8 File Offset: 0x001B9EF8
		// (set) Token: 0x06006136 RID: 24886 RVA: 0x0002DED4 File Offset: 0x0002C0D4
		public unsafe Action onClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_onClose);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_onClose), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D3B RID: 7483
		// (get) Token: 0x06006137 RID: 24887 RVA: 0x001BBD28 File Offset: 0x001B9F28
		// (set) Token: 0x06006138 RID: 24888 RVA: 0x0002DEF3 File Offset: 0x0002C0F3
		public unsafe int selectionLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_selectionLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_selectionLimit)) = value;
			}
		}

		// Token: 0x17001D3C RID: 7484
		// (get) Token: 0x06006139 RID: 24889 RVA: 0x001BBD50 File Offset: 0x001B9F50
		// (set) Token: 0x0600613A RID: 24890 RVA: 0x0002DF0E File Offset: 0x0002C10E
		public unsafe bool exitOnSelectionLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_exitOnSelectionLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_exitOnSelectionLimit)) = value;
			}
		}

		// Token: 0x17001D3D RID: 7485
		// (get) Token: 0x0600613B RID: 24891 RVA: 0x001BBD78 File Offset: 0x001B9F78
		// (set) Token: 0x0600613C RID: 24892 RVA: 0x0002DF29 File Offset: 0x0002C129
		public unsafe BuildableItem hoveredBuildable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_hoveredBuildable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuildableItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_hoveredBuildable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D3E RID: 7486
		// (get) Token: 0x0600613D RID: 24893 RVA: 0x001BBDA8 File Offset: 0x001B9FA8
		// (set) Token: 0x0600613E RID: 24894 RVA: 0x0002DF48 File Offset: 0x0002C148
		public unsafe Constructable hoveredConstructable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_hoveredConstructable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Constructable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_hoveredConstructable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D3F RID: 7487
		// (get) Token: 0x0600613F RID: 24895 RVA: 0x001BBDD8 File Offset: 0x001B9FD8
		// (set) Token: 0x06006140 RID: 24896 RVA: 0x0002DF67 File Offset: 0x0002C167
		public unsafe List<BuildableItem> outlinedObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_outlinedObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BuildableItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_outlinedObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D40 RID: 7488
		// (get) Token: 0x06006141 RID: 24897 RVA: 0x001BBE08 File Offset: 0x001BA008
		// (set) Token: 0x06006142 RID: 24898 RVA: 0x0002DF86 File Offset: 0x0002C186
		public unsafe List<Constructable> outlinedConstructables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_outlinedConstructables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Constructable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_outlinedConstructables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004246 RID: 16966
		private static readonly IntPtr NativeFieldInfoPtr_detectionRange;

		// Token: 0x04004247 RID: 16967
		private static readonly IntPtr NativeFieldInfoPtr_detectionMask;

		// Token: 0x04004248 RID: 16968
		private static readonly IntPtr NativeFieldInfoPtr__isSelecting_k__BackingField;

		// Token: 0x04004249 RID: 16969
		private static readonly IntPtr NativeFieldInfoPtr_allowedTypes;

		// Token: 0x0400424A RID: 16970
		private static readonly IntPtr NativeFieldInfoPtr_selectedObjects;

		// Token: 0x0400424B RID: 16971
		private static readonly IntPtr NativeFieldInfoPtr_selectedConstructables;

		// Token: 0x0400424C RID: 16972
		private static readonly IntPtr NativeFieldInfoPtr_onClose;

		// Token: 0x0400424D RID: 16973
		private static readonly IntPtr NativeFieldInfoPtr_selectionLimit;

		// Token: 0x0400424E RID: 16974
		private static readonly IntPtr NativeFieldInfoPtr_exitOnSelectionLimit;

		// Token: 0x0400424F RID: 16975
		private static readonly IntPtr NativeFieldInfoPtr_hoveredBuildable;

		// Token: 0x04004250 RID: 16976
		private static readonly IntPtr NativeFieldInfoPtr_hoveredConstructable;

		// Token: 0x04004251 RID: 16977
		private static readonly IntPtr NativeFieldInfoPtr_outlinedObjects;

		// Token: 0x04004252 RID: 16978
		private static readonly IntPtr NativeFieldInfoPtr_outlinedConstructables;

		// Token: 0x04004253 RID: 16979
		private static readonly IntPtr NativeMethodInfoPtr_get_isSelecting_Public_get_Boolean_0;

		// Token: 0x04004254 RID: 16980
		private static readonly IntPtr NativeMethodInfoPtr_set_isSelecting_Protected_set_Void_Boolean_0;

		// Token: 0x04004255 RID: 16981
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04004256 RID: 16982
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04004257 RID: 16983
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04004258 RID: 16984
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredBuildable_Private_BuildableItem_0;

		// Token: 0x04004259 RID: 16985
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredConstructable_Private_Constructable_0;

		// Token: 0x0400425A RID: 16986
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x0400425B RID: 16987
		private static readonly IntPtr NativeMethodInfoPtr_StartSelecting_Public_Void_String_List_1_Type_byref_List_1_BuildableItem_byref_List_1_Constructable_Int32_Boolean_0;

		// Token: 0x0400425C RID: 16988
		private static readonly IntPtr NativeMethodInfoPtr_StopSelecting_Public_Void_0;

		// Token: 0x0400425D RID: 16989
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
