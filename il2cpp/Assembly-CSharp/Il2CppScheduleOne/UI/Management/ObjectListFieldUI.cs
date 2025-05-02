using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Management;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006CA RID: 1738
	public class ObjectListFieldUI : MonoBehaviour
	{
		// Token: 0x06009C14 RID: 39956 RVA: 0x00278F60 File Offset: 0x00277160
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectListFieldUI()
		{
			Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "ObjectListFieldUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr);
			ObjectListFieldUI.NativeFieldInfoPtr__Fields_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, "<Fields>k__BackingField");
			ObjectListFieldUI.NativeFieldInfoPtr_FieldText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, "FieldText");
			ObjectListFieldUI.NativeFieldInfoPtr_InstructionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, "InstructionText");
			ObjectListFieldUI.NativeFieldInfoPtr_ExtendedInstructionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, "ExtendedInstructionText");
			ObjectListFieldUI.NativeFieldInfoPtr_FieldLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, "FieldLabel");
			ObjectListFieldUI.NativeFieldInfoPtr_NoneSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, "NoneSelected");
			ObjectListFieldUI.NativeFieldInfoPtr_MultipleSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, "MultipleSelected");
			ObjectListFieldUI.NativeFieldInfoPtr_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, "Entries");
			ObjectListFieldUI.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, "Button");
			ObjectListFieldUI.NativeFieldInfoPtr_EditIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, "EditIcon");
			ObjectListFieldUI.NativeFieldInfoPtr_NoMultiEdit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, "NoMultiEdit");
			ObjectListFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_ObjectListField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, 100682463);
			ObjectListFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_ObjectListField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, 100682464);
			ObjectListFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_ObjectListField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, 100682465);
			ObjectListFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_List_1_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, 100682466);
			ObjectListFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, 100682467);
			ObjectListFieldUI.NativeMethodInfoPtr_Clicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, 100682468);
			ObjectListFieldUI.NativeMethodInfoPtr_ObjectValid_Private_Boolean_BuildableItem_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, 100682469);
			ObjectListFieldUI.NativeMethodInfoPtr_ObjectsSelected_Public_Void_List_1_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, 100682470);
			ObjectListFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, 100682471);
		}

		// Token: 0x17003018 RID: 12312
		// (get) Token: 0x06009C15 RID: 39957 RVA: 0x00279120 File Offset: 0x00277320
		// (set) Token: 0x06009C16 RID: 39958 RVA: 0x00279160 File Offset: 0x00277360
		public unsafe List<ObjectListField> Fields
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17399, RefRangeEnd = 17400, XrefRangeStart = 17399, XrefRangeEnd = 17400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_ObjectListField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ObjectListField>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_ObjectListField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009C17 RID: 39959 RVA: 0x002791A4 File Offset: 0x002773A4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 277208, RefRangeEnd = 277212, XrefRangeStart = 277171, XrefRangeEnd = 277208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Bind(List<ObjectListField> field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_ObjectListField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C18 RID: 39960 RVA: 0x002791E8 File Offset: 0x002773E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 277267, RefRangeEnd = 277268, XrefRangeStart = 277212, XrefRangeEnd = 277267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh(List<BuildableItem> newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newVal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_List_1_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C19 RID: 39961 RVA: 0x0027922C File Offset: 0x0027742C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 277278, RefRangeEnd = 277280, XrefRangeStart = 277268, XrefRangeEnd = 277278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreFieldsUniform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009C1A RID: 39962 RVA: 0x00279268 File Offset: 0x00277468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277280, XrefRangeEnd = 277318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListFieldUI.NativeMethodInfoPtr_Clicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C1B RID: 39963 RVA: 0x0027929C File Offset: 0x0027749C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277318, XrefRangeEnd = 277329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ObjectValid(BuildableItem obj, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ObjectListFieldUI.NativeMethodInfoPtr_ObjectValid_Private_Boolean_BuildableItem_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06009C1C RID: 39964 RVA: 0x00279304 File Offset: 0x00277504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277329, XrefRangeEnd = 277353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ObjectsSelected(List<BuildableItem> objs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListFieldUI.NativeMethodInfoPtr_ObjectsSelected_Public_Void_List_1_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C1D RID: 39965 RVA: 0x00279348 File Offset: 0x00277548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277353, XrefRangeEnd = 277372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectListFieldUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C1E RID: 39966 RVA: 0x0004C7D2 File Offset: 0x0004A9D2
		public ObjectListFieldUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700300D RID: 12301
		// (get) Token: 0x06009C1F RID: 39967 RVA: 0x00279384 File Offset: 0x00277584
		// (set) Token: 0x06009C20 RID: 39968 RVA: 0x0004C7DB File Offset: 0x0004A9DB
		public unsafe List<ObjectListField> _Fields_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr__Fields_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ObjectListField>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr__Fields_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700300E RID: 12302
		// (get) Token: 0x06009C21 RID: 39969 RVA: 0x002793B4 File Offset: 0x002775B4
		// (set) Token: 0x06009C22 RID: 39970 RVA: 0x0004C7FA File Offset: 0x0004A9FA
		public unsafe string FieldText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_FieldText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_FieldText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700300F RID: 12303
		// (get) Token: 0x06009C23 RID: 39971 RVA: 0x002793DC File Offset: 0x002775DC
		// (set) Token: 0x06009C24 RID: 39972 RVA: 0x0004C819 File Offset: 0x0004AA19
		public unsafe string InstructionText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_InstructionText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_InstructionText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003010 RID: 12304
		// (get) Token: 0x06009C25 RID: 39973 RVA: 0x00279404 File Offset: 0x00277604
		// (set) Token: 0x06009C26 RID: 39974 RVA: 0x0004C838 File Offset: 0x0004AA38
		public unsafe string ExtendedInstructionText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_ExtendedInstructionText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_ExtendedInstructionText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003011 RID: 12305
		// (get) Token: 0x06009C27 RID: 39975 RVA: 0x0027942C File Offset: 0x0027762C
		// (set) Token: 0x06009C28 RID: 39976 RVA: 0x0004C857 File Offset: 0x0004AA57
		public unsafe TextMeshProUGUI FieldLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_FieldLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_FieldLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003012 RID: 12306
		// (get) Token: 0x06009C29 RID: 39977 RVA: 0x0027945C File Offset: 0x0027765C
		// (set) Token: 0x06009C2A RID: 39978 RVA: 0x0004C876 File Offset: 0x0004AA76
		public unsafe GameObject NoneSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_NoneSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_NoneSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003013 RID: 12307
		// (get) Token: 0x06009C2B RID: 39979 RVA: 0x0027948C File Offset: 0x0027768C
		// (set) Token: 0x06009C2C RID: 39980 RVA: 0x0004C895 File Offset: 0x0004AA95
		public unsafe GameObject MultipleSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_MultipleSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_MultipleSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003014 RID: 12308
		// (get) Token: 0x06009C2D RID: 39981 RVA: 0x002794BC File Offset: 0x002776BC
		// (set) Token: 0x06009C2E RID: 39982 RVA: 0x0004C8B4 File Offset: 0x0004AAB4
		public unsafe Il2CppReferenceArray<RectTransform> Entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_Entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_Entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003015 RID: 12309
		// (get) Token: 0x06009C2F RID: 39983 RVA: 0x002794EC File Offset: 0x002776EC
		// (set) Token: 0x06009C30 RID: 39984 RVA: 0x0004C8D3 File Offset: 0x0004AAD3
		public unsafe Button Button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_Button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003016 RID: 12310
		// (get) Token: 0x06009C31 RID: 39985 RVA: 0x0027951C File Offset: 0x0027771C
		// (set) Token: 0x06009C32 RID: 39986 RVA: 0x0004C8F2 File Offset: 0x0004AAF2
		public unsafe GameObject EditIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_EditIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_EditIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003017 RID: 12311
		// (get) Token: 0x06009C33 RID: 39987 RVA: 0x0027954C File Offset: 0x0027774C
		// (set) Token: 0x06009C34 RID: 39988 RVA: 0x0004C911 File Offset: 0x0004AB11
		public unsafe GameObject NoMultiEdit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_NoMultiEdit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_NoMultiEdit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040068DA RID: 26842
		private static readonly IntPtr NativeFieldInfoPtr__Fields_k__BackingField;

		// Token: 0x040068DB RID: 26843
		private static readonly IntPtr NativeFieldInfoPtr_FieldText;

		// Token: 0x040068DC RID: 26844
		private static readonly IntPtr NativeFieldInfoPtr_InstructionText;

		// Token: 0x040068DD RID: 26845
		private static readonly IntPtr NativeFieldInfoPtr_ExtendedInstructionText;

		// Token: 0x040068DE RID: 26846
		private static readonly IntPtr NativeFieldInfoPtr_FieldLabel;

		// Token: 0x040068DF RID: 26847
		private static readonly IntPtr NativeFieldInfoPtr_NoneSelected;

		// Token: 0x040068E0 RID: 26848
		private static readonly IntPtr NativeFieldInfoPtr_MultipleSelected;

		// Token: 0x040068E1 RID: 26849
		private static readonly IntPtr NativeFieldInfoPtr_Entries;

		// Token: 0x040068E2 RID: 26850
		private static readonly IntPtr NativeFieldInfoPtr_Button;

		// Token: 0x040068E3 RID: 26851
		private static readonly IntPtr NativeFieldInfoPtr_EditIcon;

		// Token: 0x040068E4 RID: 26852
		private static readonly IntPtr NativeFieldInfoPtr_NoMultiEdit;

		// Token: 0x040068E5 RID: 26853
		private static readonly IntPtr NativeMethodInfoPtr_get_Fields_Public_get_List_1_ObjectListField_0;

		// Token: 0x040068E6 RID: 26854
		private static readonly IntPtr NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_ObjectListField_0;

		// Token: 0x040068E7 RID: 26855
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Void_List_1_ObjectListField_0;

		// Token: 0x040068E8 RID: 26856
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Private_Void_List_1_BuildableItem_0;

		// Token: 0x040068E9 RID: 26857
		private static readonly IntPtr NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0;

		// Token: 0x040068EA RID: 26858
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Public_Void_0;

		// Token: 0x040068EB RID: 26859
		private static readonly IntPtr NativeMethodInfoPtr_ObjectValid_Private_Boolean_BuildableItem_byref_String_0;

		// Token: 0x040068EC RID: 26860
		private static readonly IntPtr NativeMethodInfoPtr_ObjectsSelected_Public_Void_List_1_BuildableItem_0;

		// Token: 0x040068ED RID: 26861
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
