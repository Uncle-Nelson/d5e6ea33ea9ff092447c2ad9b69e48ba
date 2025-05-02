using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.NPCs;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.ContactsApp
{
	// Token: 0x020006B6 RID: 1718
	public class ContactsDetailPanel : MonoBehaviour
	{
		// Token: 0x06009AE2 RID: 39650 RVA: 0x00275724 File Offset: 0x00273924
		// Note: this type is marked as 'beforefieldinit'.
		static ContactsDetailPanel()
		{
			Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.ContactsApp", "ContactsDetailPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr);
			ContactsDetailPanel.NativeFieldInfoPtr__SelectedNPC_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "<SelectedNPC>k__BackingField");
			ContactsDetailPanel.NativeFieldInfoPtr_DependenceColor_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "DependenceColor_Min");
			ContactsDetailPanel.NativeFieldInfoPtr_DependenceColor_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "DependenceColor_Max");
			ContactsDetailPanel.NativeFieldInfoPtr_LayoutGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "LayoutGroup");
			ContactsDetailPanel.NativeFieldInfoPtr_NameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "NameLabel");
			ContactsDetailPanel.NativeFieldInfoPtr_TypeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "TypeLabel");
			ContactsDetailPanel.NativeFieldInfoPtr_UnlockHintLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "UnlockHintLabel");
			ContactsDetailPanel.NativeFieldInfoPtr_RelationshipContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "RelationshipContainer");
			ContactsDetailPanel.NativeFieldInfoPtr_RelationshipScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "RelationshipScrollbar");
			ContactsDetailPanel.NativeFieldInfoPtr_RelationshipLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "RelationshipLabel");
			ContactsDetailPanel.NativeFieldInfoPtr_AddictionContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "AddictionContainer");
			ContactsDetailPanel.NativeFieldInfoPtr_AddictionScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "AddictionScrollbar");
			ContactsDetailPanel.NativeFieldInfoPtr_AddictionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "AddictionLabel");
			ContactsDetailPanel.NativeFieldInfoPtr_PropertiesContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "PropertiesContainer");
			ContactsDetailPanel.NativeFieldInfoPtr_PropertiesLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "PropertiesLabel");
			ContactsDetailPanel.NativeFieldInfoPtr_ShowOnMapButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "ShowOnMapButton");
			ContactsDetailPanel.NativeFieldInfoPtr_StandardsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "StandardsContainer");
			ContactsDetailPanel.NativeFieldInfoPtr_StandardsStar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "StandardsStar");
			ContactsDetailPanel.NativeFieldInfoPtr_StandardsLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "StandardsLabel");
			ContactsDetailPanel.NativeFieldInfoPtr_poi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, "poi");
			ContactsDetailPanel.NativeMethodInfoPtr_get_SelectedNPC_Public_get_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, 100682361);
			ContactsDetailPanel.NativeMethodInfoPtr_set_SelectedNPC_Protected_set_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, 100682362);
			ContactsDetailPanel.NativeMethodInfoPtr_Open_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, 100682363);
			ContactsDetailPanel.NativeMethodInfoPtr_ShowOnMap_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, 100682364);
			ContactsDetailPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr, 100682365);
		}

		// Token: 0x17002FC2 RID: 12226
		// (get) Token: 0x06009AE3 RID: 39651 RVA: 0x00275948 File Offset: 0x00273B48
		// (set) Token: 0x06009AE4 RID: 39652 RVA: 0x00275988 File Offset: 0x00273B88
		public unsafe NPC SelectedNPC
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17399, RefRangeEnd = 17400, XrefRangeStart = 17399, XrefRangeEnd = 17400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsDetailPanel.NativeMethodInfoPtr_get_SelectedNPC_Public_get_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsDetailPanel.NativeMethodInfoPtr_set_SelectedNPC_Protected_set_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009AE5 RID: 39653 RVA: 0x002759CC File Offset: 0x00273BCC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 275695, RefRangeEnd = 275701, XrefRangeStart = 275567, XrefRangeEnd = 275695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsDetailPanel.NativeMethodInfoPtr_Open_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009AE6 RID: 39654 RVA: 0x00275A10 File Offset: 0x00273C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275701, XrefRangeEnd = 275734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowOnMap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsDetailPanel.NativeMethodInfoPtr_ShowOnMap_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009AE7 RID: 39655 RVA: 0x00275A44 File Offset: 0x00273C44
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContactsDetailPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContactsDetailPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsDetailPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009AE8 RID: 39656 RVA: 0x0004BC77 File Offset: 0x00049E77
		public ContactsDetailPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002FAE RID: 12206
		// (get) Token: 0x06009AE9 RID: 39657 RVA: 0x00275A80 File Offset: 0x00273C80
		// (set) Token: 0x06009AEA RID: 39658 RVA: 0x0004BC80 File Offset: 0x00049E80
		public unsafe NPC _SelectedNPC_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr__SelectedNPC_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr__SelectedNPC_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FAF RID: 12207
		// (get) Token: 0x06009AEB RID: 39659 RVA: 0x00275AB0 File Offset: 0x00273CB0
		// (set) Token: 0x06009AEC RID: 39660 RVA: 0x0004BC9F File Offset: 0x00049E9F
		public unsafe Color DependenceColor_Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_DependenceColor_Min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_DependenceColor_Min)) = value;
			}
		}

		// Token: 0x17002FB0 RID: 12208
		// (get) Token: 0x06009AED RID: 39661 RVA: 0x00275AD8 File Offset: 0x00273CD8
		// (set) Token: 0x06009AEE RID: 39662 RVA: 0x0004BCBA File Offset: 0x00049EBA
		public unsafe Color DependenceColor_Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_DependenceColor_Max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_DependenceColor_Max)) = value;
			}
		}

		// Token: 0x17002FB1 RID: 12209
		// (get) Token: 0x06009AEF RID: 39663 RVA: 0x00275B00 File Offset: 0x00273D00
		// (set) Token: 0x06009AF0 RID: 39664 RVA: 0x0004BCD5 File Offset: 0x00049ED5
		public unsafe VerticalLayoutGroup LayoutGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_LayoutGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VerticalLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_LayoutGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FB2 RID: 12210
		// (get) Token: 0x06009AF1 RID: 39665 RVA: 0x00275B30 File Offset: 0x00273D30
		// (set) Token: 0x06009AF2 RID: 39666 RVA: 0x0004BCF4 File Offset: 0x00049EF4
		public unsafe Text NameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_NameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_NameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FB3 RID: 12211
		// (get) Token: 0x06009AF3 RID: 39667 RVA: 0x00275B60 File Offset: 0x00273D60
		// (set) Token: 0x06009AF4 RID: 39668 RVA: 0x0004BD13 File Offset: 0x00049F13
		public unsafe Text TypeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_TypeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_TypeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FB4 RID: 12212
		// (get) Token: 0x06009AF5 RID: 39669 RVA: 0x00275B90 File Offset: 0x00273D90
		// (set) Token: 0x06009AF6 RID: 39670 RVA: 0x0004BD32 File Offset: 0x00049F32
		public unsafe Text UnlockHintLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_UnlockHintLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_UnlockHintLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FB5 RID: 12213
		// (get) Token: 0x06009AF7 RID: 39671 RVA: 0x00275BC0 File Offset: 0x00273DC0
		// (set) Token: 0x06009AF8 RID: 39672 RVA: 0x0004BD51 File Offset: 0x00049F51
		public unsafe RectTransform RelationshipContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_RelationshipContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_RelationshipContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FB6 RID: 12214
		// (get) Token: 0x06009AF9 RID: 39673 RVA: 0x00275BF0 File Offset: 0x00273DF0
		// (set) Token: 0x06009AFA RID: 39674 RVA: 0x0004BD70 File Offset: 0x00049F70
		public unsafe Scrollbar RelationshipScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_RelationshipScrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_RelationshipScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FB7 RID: 12215
		// (get) Token: 0x06009AFB RID: 39675 RVA: 0x00275C20 File Offset: 0x00273E20
		// (set) Token: 0x06009AFC RID: 39676 RVA: 0x0004BD8F File Offset: 0x00049F8F
		public unsafe Text RelationshipLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_RelationshipLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_RelationshipLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FB8 RID: 12216
		// (get) Token: 0x06009AFD RID: 39677 RVA: 0x00275C50 File Offset: 0x00273E50
		// (set) Token: 0x06009AFE RID: 39678 RVA: 0x0004BDAE File Offset: 0x00049FAE
		public unsafe RectTransform AddictionContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_AddictionContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_AddictionContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FB9 RID: 12217
		// (get) Token: 0x06009AFF RID: 39679 RVA: 0x00275C80 File Offset: 0x00273E80
		// (set) Token: 0x06009B00 RID: 39680 RVA: 0x0004BDCD File Offset: 0x00049FCD
		public unsafe Scrollbar AddictionScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_AddictionScrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_AddictionScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FBA RID: 12218
		// (get) Token: 0x06009B01 RID: 39681 RVA: 0x00275CB0 File Offset: 0x00273EB0
		// (set) Token: 0x06009B02 RID: 39682 RVA: 0x0004BDEC File Offset: 0x00049FEC
		public unsafe Text AddictionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_AddictionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_AddictionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FBB RID: 12219
		// (get) Token: 0x06009B03 RID: 39683 RVA: 0x00275CE0 File Offset: 0x00273EE0
		// (set) Token: 0x06009B04 RID: 39684 RVA: 0x0004BE0B File Offset: 0x0004A00B
		public unsafe RectTransform PropertiesContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_PropertiesContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_PropertiesContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FBC RID: 12220
		// (get) Token: 0x06009B05 RID: 39685 RVA: 0x00275D10 File Offset: 0x00273F10
		// (set) Token: 0x06009B06 RID: 39686 RVA: 0x0004BE2A File Offset: 0x0004A02A
		public unsafe Text PropertiesLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_PropertiesLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_PropertiesLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FBD RID: 12221
		// (get) Token: 0x06009B07 RID: 39687 RVA: 0x00275D40 File Offset: 0x00273F40
		// (set) Token: 0x06009B08 RID: 39688 RVA: 0x0004BE49 File Offset: 0x0004A049
		public unsafe Button ShowOnMapButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_ShowOnMapButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_ShowOnMapButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FBE RID: 12222
		// (get) Token: 0x06009B09 RID: 39689 RVA: 0x00275D70 File Offset: 0x00273F70
		// (set) Token: 0x06009B0A RID: 39690 RVA: 0x0004BE68 File Offset: 0x0004A068
		public unsafe RectTransform StandardsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_StandardsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_StandardsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FBF RID: 12223
		// (get) Token: 0x06009B0B RID: 39691 RVA: 0x00275DA0 File Offset: 0x00273FA0
		// (set) Token: 0x06009B0C RID: 39692 RVA: 0x0004BE87 File Offset: 0x0004A087
		public unsafe Image StandardsStar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_StandardsStar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_StandardsStar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FC0 RID: 12224
		// (get) Token: 0x06009B0D RID: 39693 RVA: 0x00275DD0 File Offset: 0x00273FD0
		// (set) Token: 0x06009B0E RID: 39694 RVA: 0x0004BEA6 File Offset: 0x0004A0A6
		public unsafe Text StandardsLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_StandardsLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_StandardsLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FC1 RID: 12225
		// (get) Token: 0x06009B0F RID: 39695 RVA: 0x00275E00 File Offset: 0x00274000
		// (set) Token: 0x06009B10 RID: 39696 RVA: 0x0004BEC5 File Offset: 0x0004A0C5
		public unsafe POI poi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_poi);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<POI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsDetailPanel.NativeFieldInfoPtr_poi), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006829 RID: 26665
		private static readonly IntPtr NativeFieldInfoPtr__SelectedNPC_k__BackingField;

		// Token: 0x0400682A RID: 26666
		private static readonly IntPtr NativeFieldInfoPtr_DependenceColor_Min;

		// Token: 0x0400682B RID: 26667
		private static readonly IntPtr NativeFieldInfoPtr_DependenceColor_Max;

		// Token: 0x0400682C RID: 26668
		private static readonly IntPtr NativeFieldInfoPtr_LayoutGroup;

		// Token: 0x0400682D RID: 26669
		private static readonly IntPtr NativeFieldInfoPtr_NameLabel;

		// Token: 0x0400682E RID: 26670
		private static readonly IntPtr NativeFieldInfoPtr_TypeLabel;

		// Token: 0x0400682F RID: 26671
		private static readonly IntPtr NativeFieldInfoPtr_UnlockHintLabel;

		// Token: 0x04006830 RID: 26672
		private static readonly IntPtr NativeFieldInfoPtr_RelationshipContainer;

		// Token: 0x04006831 RID: 26673
		private static readonly IntPtr NativeFieldInfoPtr_RelationshipScrollbar;

		// Token: 0x04006832 RID: 26674
		private static readonly IntPtr NativeFieldInfoPtr_RelationshipLabel;

		// Token: 0x04006833 RID: 26675
		private static readonly IntPtr NativeFieldInfoPtr_AddictionContainer;

		// Token: 0x04006834 RID: 26676
		private static readonly IntPtr NativeFieldInfoPtr_AddictionScrollbar;

		// Token: 0x04006835 RID: 26677
		private static readonly IntPtr NativeFieldInfoPtr_AddictionLabel;

		// Token: 0x04006836 RID: 26678
		private static readonly IntPtr NativeFieldInfoPtr_PropertiesContainer;

		// Token: 0x04006837 RID: 26679
		private static readonly IntPtr NativeFieldInfoPtr_PropertiesLabel;

		// Token: 0x04006838 RID: 26680
		private static readonly IntPtr NativeFieldInfoPtr_ShowOnMapButton;

		// Token: 0x04006839 RID: 26681
		private static readonly IntPtr NativeFieldInfoPtr_StandardsContainer;

		// Token: 0x0400683A RID: 26682
		private static readonly IntPtr NativeFieldInfoPtr_StandardsStar;

		// Token: 0x0400683B RID: 26683
		private static readonly IntPtr NativeFieldInfoPtr_StandardsLabel;

		// Token: 0x0400683C RID: 26684
		private static readonly IntPtr NativeFieldInfoPtr_poi;

		// Token: 0x0400683D RID: 26685
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedNPC_Public_get_NPC_0;

		// Token: 0x0400683E RID: 26686
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectedNPC_Protected_set_Void_NPC_0;

		// Token: 0x0400683F RID: 26687
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_NPC_0;

		// Token: 0x04006840 RID: 26688
		private static readonly IntPtr NativeMethodInfoPtr_ShowOnMap_Public_Void_0;

		// Token: 0x04006841 RID: 26689
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
