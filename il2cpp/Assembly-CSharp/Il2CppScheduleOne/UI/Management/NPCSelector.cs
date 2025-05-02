using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.NPCs;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006D1 RID: 1745
	public class NPCSelector : MonoBehaviour
	{
		// Token: 0x06009CDC RID: 40156 RVA: 0x0027B720 File Offset: 0x00279920
		// Note: this type is marked as 'beforefieldinit'.
		static NPCSelector()
		{
			Il2CppClassPointerStore<NPCSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "NPCSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr);
			NPCSelector.NativeFieldInfoPtr_SELECTION_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, "SELECTION_RANGE");
			NPCSelector.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, "<IsOpen>k__BackingField");
			NPCSelector.NativeFieldInfoPtr_DetectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, "DetectionMask");
			NPCSelector.NativeFieldInfoPtr_HoverOutlineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, "HoverOutlineColor");
			NPCSelector.NativeFieldInfoPtr_TypeRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, "TypeRequirement");
			NPCSelector.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, "callback");
			NPCSelector.NativeFieldInfoPtr_hoveredNPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, "hoveredNPC");
			NPCSelector.NativeFieldInfoPtr_highlightedNPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, "highlightedNPC");
			NPCSelector.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, 100682554);
			NPCSelector.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, 100682555);
			NPCSelector.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, 100682556);
			NPCSelector.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_String_Type_Action_1_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, 100682557);
			NPCSelector.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, 100682558);
			NPCSelector.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, 100682559);
			NPCSelector.NativeMethodInfoPtr_GetHoveredNPC_Private_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, 100682560);
			NPCSelector.NativeMethodInfoPtr_IsNPCTypeValid_Public_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, 100682561);
			NPCSelector.NativeMethodInfoPtr_NPCClicked_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, 100682562);
			NPCSelector.NativeMethodInfoPtr_ClipboardClosed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, 100682563);
			NPCSelector.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, 100682564);
			NPCSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, 100682565);
		}

		// Token: 0x17003054 RID: 12372
		// (get) Token: 0x06009CDD RID: 40157 RVA: 0x0027B8E0 File Offset: 0x00279AE0
		// (set) Token: 0x06009CDE RID: 40158 RVA: 0x0027B91C File Offset: 0x00279B1C
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35365, RefRangeEnd = 35366, XrefRangeStart = 35365, XrefRangeEnd = 35366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSelector.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35366, RefRangeEnd = 35368, XrefRangeStart = 35366, XrefRangeEnd = 35368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSelector.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009CDF RID: 40159 RVA: 0x0027B95C File Offset: 0x00279B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278714, XrefRangeEnd = 278736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSelector.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009CE0 RID: 40160 RVA: 0x0027B990 File Offset: 0x00279B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278736, XrefRangeEnd = 278761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Open(string selectionTitle, Type typeRequirement, Action<NPC> _callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(selectionTitle);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeRequirement);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSelector.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_String_Type_Action_1_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009CE1 RID: 40161 RVA: 0x0027BA04 File Offset: 0x00279C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278761, XrefRangeEnd = 278799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close(bool returnToClipboard)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref returnToClipboard;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSelector.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009CE2 RID: 40162 RVA: 0x0027BA50 File Offset: 0x00279C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278799, XrefRangeEnd = 278834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSelector.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009CE3 RID: 40163 RVA: 0x0027BA84 File Offset: 0x00279C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278834, XrefRangeEnd = 278840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPC GetHoveredNPC()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSelector.NativeMethodInfoPtr_GetHoveredNPC_Private_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr3) : null;
		}

		// Token: 0x06009CE4 RID: 40164 RVA: 0x0027BAC4 File Offset: 0x00279CC4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 278845, RefRangeEnd = 278849, XrefRangeStart = 278840, XrefRangeEnd = 278845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsNPCTypeValid(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSelector.NativeMethodInfoPtr_IsNPCTypeValid_Public_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009CE5 RID: 40165 RVA: 0x0027BB14 File Offset: 0x00279D14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278849, XrefRangeEnd = 278850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NPCClicked(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSelector.NativeMethodInfoPtr_NPCClicked_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009CE6 RID: 40166 RVA: 0x0027BB58 File Offset: 0x00279D58
		[CallerCount(0)]
		public unsafe void ClipboardClosed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSelector.NativeMethodInfoPtr_ClipboardClosed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009CE7 RID: 40167 RVA: 0x0027BB8C File Offset: 0x00279D8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278850, XrefRangeEnd = 278851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction exitAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exitAction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSelector.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009CE8 RID: 40168 RVA: 0x0027BBD0 File Offset: 0x00279DD0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCSelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009CE9 RID: 40169 RVA: 0x0004CE9F File Offset: 0x0004B09F
		public NPCSelector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700304C RID: 12364
		// (get) Token: 0x06009CEA RID: 40170 RVA: 0x0027BC0C File Offset: 0x00279E0C
		// (set) Token: 0x06009CEB RID: 40171 RVA: 0x0004CEA8 File Offset: 0x0004B0A8
		public unsafe static float SELECTION_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCSelector.NativeFieldInfoPtr_SELECTION_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCSelector.NativeFieldInfoPtr_SELECTION_RANGE, (void*)(&value));
			}
		}

		// Token: 0x1700304D RID: 12365
		// (get) Token: 0x06009CEC RID: 40172 RVA: 0x0027BC28 File Offset: 0x00279E28
		// (set) Token: 0x06009CED RID: 40173 RVA: 0x0004CEB6 File Offset: 0x0004B0B6
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSelector.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSelector.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x1700304E RID: 12366
		// (get) Token: 0x06009CEE RID: 40174 RVA: 0x0027BC50 File Offset: 0x00279E50
		// (set) Token: 0x06009CEF RID: 40175 RVA: 0x0004CED1 File Offset: 0x0004B0D1
		public unsafe LayerMask DetectionMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSelector.NativeFieldInfoPtr_DetectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSelector.NativeFieldInfoPtr_DetectionMask)) = value;
			}
		}

		// Token: 0x1700304F RID: 12367
		// (get) Token: 0x06009CF0 RID: 40176 RVA: 0x0027BC78 File Offset: 0x00279E78
		// (set) Token: 0x06009CF1 RID: 40177 RVA: 0x0004CEEC File Offset: 0x0004B0EC
		public unsafe Color HoverOutlineColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSelector.NativeFieldInfoPtr_HoverOutlineColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSelector.NativeFieldInfoPtr_HoverOutlineColor)) = value;
			}
		}

		// Token: 0x17003050 RID: 12368
		// (get) Token: 0x06009CF2 RID: 40178 RVA: 0x0027BCA0 File Offset: 0x00279EA0
		// (set) Token: 0x06009CF3 RID: 40179 RVA: 0x0004CF07 File Offset: 0x0004B107
		public unsafe Type TypeRequirement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSelector.NativeFieldInfoPtr_TypeRequirement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSelector.NativeFieldInfoPtr_TypeRequirement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003051 RID: 12369
		// (get) Token: 0x06009CF4 RID: 40180 RVA: 0x0027BCD0 File Offset: 0x00279ED0
		// (set) Token: 0x06009CF5 RID: 40181 RVA: 0x0004CF26 File Offset: 0x0004B126
		public unsafe Action<NPC> callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSelector.NativeFieldInfoPtr_callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<NPC>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSelector.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003052 RID: 12370
		// (get) Token: 0x06009CF6 RID: 40182 RVA: 0x0027BD00 File Offset: 0x00279F00
		// (set) Token: 0x06009CF7 RID: 40183 RVA: 0x0004CF45 File Offset: 0x0004B145
		public unsafe NPC hoveredNPC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSelector.NativeFieldInfoPtr_hoveredNPC);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSelector.NativeFieldInfoPtr_hoveredNPC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003053 RID: 12371
		// (get) Token: 0x06009CF8 RID: 40184 RVA: 0x0027BD30 File Offset: 0x00279F30
		// (set) Token: 0x06009CF9 RID: 40185 RVA: 0x0004CF64 File Offset: 0x0004B164
		public unsafe NPC highlightedNPC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSelector.NativeFieldInfoPtr_highlightedNPC);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSelector.NativeFieldInfoPtr_highlightedNPC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400695C RID: 26972
		private static readonly IntPtr NativeFieldInfoPtr_SELECTION_RANGE;

		// Token: 0x0400695D RID: 26973
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x0400695E RID: 26974
		private static readonly IntPtr NativeFieldInfoPtr_DetectionMask;

		// Token: 0x0400695F RID: 26975
		private static readonly IntPtr NativeFieldInfoPtr_HoverOutlineColor;

		// Token: 0x04006960 RID: 26976
		private static readonly IntPtr NativeFieldInfoPtr_TypeRequirement;

		// Token: 0x04006961 RID: 26977
		private static readonly IntPtr NativeFieldInfoPtr_callback;

		// Token: 0x04006962 RID: 26978
		private static readonly IntPtr NativeFieldInfoPtr_hoveredNPC;

		// Token: 0x04006963 RID: 26979
		private static readonly IntPtr NativeFieldInfoPtr_highlightedNPC;

		// Token: 0x04006964 RID: 26980
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04006965 RID: 26981
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04006966 RID: 26982
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04006967 RID: 26983
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_New_Void_String_Type_Action_1_NPC_0;

		// Token: 0x04006968 RID: 26984
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04006969 RID: 26985
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400696A RID: 26986
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredNPC_Private_NPC_0;

		// Token: 0x0400696B RID: 26987
		private static readonly IntPtr NativeMethodInfoPtr_IsNPCTypeValid_Public_Boolean_NPC_0;

		// Token: 0x0400696C RID: 26988
		private static readonly IntPtr NativeMethodInfoPtr_NPCClicked_Public_Void_NPC_0;

		// Token: 0x0400696D RID: 26989
		private static readonly IntPtr NativeMethodInfoPtr_ClipboardClosed_Private_Void_0;

		// Token: 0x0400696E RID: 26990
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x0400696F RID: 26991
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
