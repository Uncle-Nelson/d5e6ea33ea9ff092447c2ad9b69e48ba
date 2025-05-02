using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000447 RID: 1095
	[Serializable]
	public class DialogueContainer : ScriptableObject
	{
		// Token: 0x06005F80 RID: 24448 RVA: 0x001B6898 File Offset: 0x001B4A98
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueContainer()
		{
			Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr);
			DialogueContainer.NativeFieldInfoPtr__allowExit_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, "<allowExit>k__BackingField");
			DialogueContainer.NativeFieldInfoPtr_NodeLinks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, "NodeLinks");
			DialogueContainer.NativeFieldInfoPtr_DialogueNodeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, "DialogueNodeData");
			DialogueContainer.NativeFieldInfoPtr_BranchNodeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, "BranchNodeData");
			DialogueContainer.NativeMethodInfoPtr_get_allowExit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, 100675477);
			DialogueContainer.NativeMethodInfoPtr_set_allowExit_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, 100675478);
			DialogueContainer.NativeMethodInfoPtr_get_AllowExit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, 100675479);
			DialogueContainer.NativeMethodInfoPtr_GetDialogueNodeByLabel_Public_DialogueNodeData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, 100675480);
			DialogueContainer.NativeMethodInfoPtr_GetBranchNodeByLabel_Public_BranchNodeData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, 100675481);
			DialogueContainer.NativeMethodInfoPtr_GetDialogueNodeByGUID_Public_DialogueNodeData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, 100675482);
			DialogueContainer.NativeMethodInfoPtr_GetBranchNodeByGUID_Public_BranchNodeData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, 100675483);
			DialogueContainer.NativeMethodInfoPtr_GetLink_Public_NodeLinkData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, 100675484);
			DialogueContainer.NativeMethodInfoPtr_SetAllowExit_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, 100675485);
			DialogueContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, 100675486);
		}

		// Token: 0x17001CAE RID: 7342
		// (get) Token: 0x06005F81 RID: 24449 RVA: 0x001B69E0 File Offset: 0x001B4BE0
		// (set) Token: 0x06005F82 RID: 24450 RVA: 0x001B6A1C File Offset: 0x001B4C1C
		public unsafe bool allowExit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.NativeMethodInfoPtr_get_allowExit_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.NativeMethodInfoPtr_set_allowExit_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001CAF RID: 7343
		// (get) Token: 0x06005F83 RID: 24451 RVA: 0x001B6A5C File Offset: 0x001B4C5C
		public unsafe bool AllowExit
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 198625, RefRangeEnd = 198626, XrefRangeStart = 198619, XrefRangeEnd = 198625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.NativeMethodInfoPtr_get_AllowExit_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005F84 RID: 24452 RVA: 0x001B6A98 File Offset: 0x001B4C98
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 198641, RefRangeEnd = 198649, XrefRangeStart = 198626, XrefRangeEnd = 198641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueNodeData GetDialogueNodeByLabel(string dialogueNodeLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueNodeLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.NativeMethodInfoPtr_GetDialogueNodeByLabel_Public_DialogueNodeData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogueNodeData>(intPtr3) : null;
		}

		// Token: 0x06005F85 RID: 24453 RVA: 0x001B6AE8 File Offset: 0x001B4CE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 198664, RefRangeEnd = 198666, XrefRangeStart = 198649, XrefRangeEnd = 198664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BranchNodeData GetBranchNodeByLabel(string branchLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(branchLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.NativeMethodInfoPtr_GetBranchNodeByLabel_Public_BranchNodeData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BranchNodeData>(intPtr3) : null;
		}

		// Token: 0x06005F86 RID: 24454 RVA: 0x001B6B38 File Offset: 0x001B4D38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 198681, RefRangeEnd = 198683, XrefRangeStart = 198666, XrefRangeEnd = 198681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueNodeData GetDialogueNodeByGUID(string dialogueNodeGUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueNodeGUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.NativeMethodInfoPtr_GetDialogueNodeByGUID_Public_DialogueNodeData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogueNodeData>(intPtr3) : null;
		}

		// Token: 0x06005F87 RID: 24455 RVA: 0x001B6B88 File Offset: 0x001B4D88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 198698, RefRangeEnd = 198700, XrefRangeStart = 198683, XrefRangeEnd = 198698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BranchNodeData GetBranchNodeByGUID(string branchGUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(branchGUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.NativeMethodInfoPtr_GetBranchNodeByGUID_Public_BranchNodeData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BranchNodeData>(intPtr3) : null;
		}

		// Token: 0x06005F88 RID: 24456 RVA: 0x001B6BD8 File Offset: 0x001B4DD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198700, XrefRangeEnd = 198715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NodeLinkData GetLink(string baseChoiceOrOptionGUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(baseChoiceOrOptionGUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.NativeMethodInfoPtr_GetLink_Public_NodeLinkData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NodeLinkData>(intPtr3) : null;
		}

		// Token: 0x06005F89 RID: 24457 RVA: 0x001B6C28 File Offset: 0x001B4E28
		[CallerCount(0)]
		public unsafe void SetAllowExit(bool allowed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref allowed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.NativeMethodInfoPtr_SetAllowExit_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F8A RID: 24458 RVA: 0x001B6C68 File Offset: 0x001B4E68
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 198737, RefRangeEnd = 198740, XrefRangeStart = 198715, XrefRangeEnd = 198737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueContainer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F8B RID: 24459 RVA: 0x0002D0BA File Offset: 0x0002B2BA
		public DialogueContainer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CAA RID: 7338
		// (get) Token: 0x06005F8C RID: 24460 RVA: 0x001B6CA4 File Offset: 0x001B4EA4
		// (set) Token: 0x06005F8D RID: 24461 RVA: 0x0002D0C3 File Offset: 0x0002B2C3
		public unsafe bool _allowExit_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.NativeFieldInfoPtr__allowExit_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.NativeFieldInfoPtr__allowExit_k__BackingField)) = value;
			}
		}

		// Token: 0x17001CAB RID: 7339
		// (get) Token: 0x06005F8E RID: 24462 RVA: 0x001B6CCC File Offset: 0x001B4ECC
		// (set) Token: 0x06005F8F RID: 24463 RVA: 0x0002D0DE File Offset: 0x0002B2DE
		public unsafe List<NodeLinkData> NodeLinks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.NativeFieldInfoPtr_NodeLinks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NodeLinkData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.NativeFieldInfoPtr_NodeLinks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CAC RID: 7340
		// (get) Token: 0x06005F90 RID: 24464 RVA: 0x001B6CFC File Offset: 0x001B4EFC
		// (set) Token: 0x06005F91 RID: 24465 RVA: 0x0002D0FD File Offset: 0x0002B2FD
		public unsafe List<DialogueNodeData> DialogueNodeData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.NativeFieldInfoPtr_DialogueNodeData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueNodeData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.NativeFieldInfoPtr_DialogueNodeData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CAD RID: 7341
		// (get) Token: 0x06005F92 RID: 24466 RVA: 0x001B6D2C File Offset: 0x001B4F2C
		// (set) Token: 0x06005F93 RID: 24467 RVA: 0x0002D11C File Offset: 0x0002B31C
		public unsafe List<BranchNodeData> BranchNodeData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.NativeFieldInfoPtr_BranchNodeData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BranchNodeData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.NativeFieldInfoPtr_BranchNodeData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004149 RID: 16713
		private static readonly IntPtr NativeFieldInfoPtr__allowExit_k__BackingField;

		// Token: 0x0400414A RID: 16714
		private static readonly IntPtr NativeFieldInfoPtr_NodeLinks;

		// Token: 0x0400414B RID: 16715
		private static readonly IntPtr NativeFieldInfoPtr_DialogueNodeData;

		// Token: 0x0400414C RID: 16716
		private static readonly IntPtr NativeFieldInfoPtr_BranchNodeData;

		// Token: 0x0400414D RID: 16717
		private static readonly IntPtr NativeMethodInfoPtr_get_allowExit_Public_get_Boolean_0;

		// Token: 0x0400414E RID: 16718
		private static readonly IntPtr NativeMethodInfoPtr_set_allowExit_Private_set_Void_Boolean_0;

		// Token: 0x0400414F RID: 16719
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowExit_Public_get_Boolean_0;

		// Token: 0x04004150 RID: 16720
		private static readonly IntPtr NativeMethodInfoPtr_GetDialogueNodeByLabel_Public_DialogueNodeData_String_0;

		// Token: 0x04004151 RID: 16721
		private static readonly IntPtr NativeMethodInfoPtr_GetBranchNodeByLabel_Public_BranchNodeData_String_0;

		// Token: 0x04004152 RID: 16722
		private static readonly IntPtr NativeMethodInfoPtr_GetDialogueNodeByGUID_Public_DialogueNodeData_String_0;

		// Token: 0x04004153 RID: 16723
		private static readonly IntPtr NativeMethodInfoPtr_GetBranchNodeByGUID_Public_BranchNodeData_String_0;

		// Token: 0x04004154 RID: 16724
		private static readonly IntPtr NativeMethodInfoPtr_GetLink_Public_NodeLinkData_String_0;

		// Token: 0x04004155 RID: 16725
		private static readonly IntPtr NativeMethodInfoPtr_SetAllowExit_Public_Void_Boolean_0;

		// Token: 0x04004156 RID: 16726
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A09 RID: 2569
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueContainer+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CE94 RID: 52884 RVA: 0x0031AF90 File Offset: 0x00319190
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass10_0>.NativeClassPtr);
				DialogueContainer.__c__DisplayClass10_0.NativeFieldInfoPtr_branchLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass10_0>.NativeClassPtr, "branchLabel");
				DialogueContainer.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass10_0>.NativeClassPtr, 100675487);
				DialogueContainer.__c__DisplayClass10_0.NativeMethodInfoPtr__GetBranchNodeByLabel_b__0_Internal_Boolean_BranchNodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass10_0>.NativeClassPtr, 100675488);
			}

			// Token: 0x0600CE95 RID: 52885 RVA: 0x0031AFF8 File Offset: 0x003191F8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE96 RID: 52886 RVA: 0x0031B034 File Offset: 0x00319234
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetBranchNodeByLabel_b__0(BranchNodeData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.__c__DisplayClass10_0.NativeMethodInfoPtr__GetBranchNodeByLabel_b__0_Internal_Boolean_BranchNodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE97 RID: 52887 RVA: 0x0006479E File Offset: 0x0006299E
			public __c__DisplayClass10_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004041 RID: 16449
			// (get) Token: 0x0600CE98 RID: 52888 RVA: 0x0031B084 File Offset: 0x00319284
			// (set) Token: 0x0600CE99 RID: 52889 RVA: 0x000647A7 File Offset: 0x000629A7
			public unsafe string branchLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.__c__DisplayClass10_0.NativeFieldInfoPtr_branchLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.__c__DisplayClass10_0.NativeFieldInfoPtr_branchLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008B6E RID: 35694
			private static readonly IntPtr NativeFieldInfoPtr_branchLabel;

			// Token: 0x04008B6F RID: 35695
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B70 RID: 35696
			private static readonly IntPtr NativeMethodInfoPtr__GetBranchNodeByLabel_b__0_Internal_Boolean_BranchNodeData_0;
		}

		// Token: 0x02000A0A RID: 2570
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueContainer+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CE9A RID: 52890 RVA: 0x0031B0AC File Offset: 0x003192AC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass11_0>.NativeClassPtr);
				DialogueContainer.__c__DisplayClass11_0.NativeFieldInfoPtr_dialogueNodeGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass11_0>.NativeClassPtr, "dialogueNodeGUID");
				DialogueContainer.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass11_0>.NativeClassPtr, 100675489);
				DialogueContainer.__c__DisplayClass11_0.NativeMethodInfoPtr__GetDialogueNodeByGUID_b__0_Internal_Boolean_DialogueNodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass11_0>.NativeClassPtr, 100675490);
			}

			// Token: 0x0600CE9B RID: 52891 RVA: 0x0031B114 File Offset: 0x00319314
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE9C RID: 52892 RVA: 0x0031B150 File Offset: 0x00319350
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetDialogueNodeByGUID_b__0(DialogueNodeData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.__c__DisplayClass11_0.NativeMethodInfoPtr__GetDialogueNodeByGUID_b__0_Internal_Boolean_DialogueNodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE9D RID: 52893 RVA: 0x000647C6 File Offset: 0x000629C6
			public __c__DisplayClass11_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004042 RID: 16450
			// (get) Token: 0x0600CE9E RID: 52894 RVA: 0x0031B1A0 File Offset: 0x003193A0
			// (set) Token: 0x0600CE9F RID: 52895 RVA: 0x000647CF File Offset: 0x000629CF
			public unsafe string dialogueNodeGUID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.__c__DisplayClass11_0.NativeFieldInfoPtr_dialogueNodeGUID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.__c__DisplayClass11_0.NativeFieldInfoPtr_dialogueNodeGUID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008B71 RID: 35697
			private static readonly IntPtr NativeFieldInfoPtr_dialogueNodeGUID;

			// Token: 0x04008B72 RID: 35698
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B73 RID: 35699
			private static readonly IntPtr NativeMethodInfoPtr__GetDialogueNodeByGUID_b__0_Internal_Boolean_DialogueNodeData_0;
		}

		// Token: 0x02000A0B RID: 2571
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueContainer+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CEA0 RID: 52896 RVA: 0x0031B1C8 File Offset: 0x003193C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass12_0>.NativeClassPtr);
				DialogueContainer.__c__DisplayClass12_0.NativeFieldInfoPtr_branchGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass12_0>.NativeClassPtr, "branchGUID");
				DialogueContainer.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass12_0>.NativeClassPtr, 100675491);
				DialogueContainer.__c__DisplayClass12_0.NativeMethodInfoPtr__GetBranchNodeByGUID_b__0_Internal_Boolean_BranchNodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass12_0>.NativeClassPtr, 100675492);
			}

			// Token: 0x0600CEA1 RID: 52897 RVA: 0x0031B230 File Offset: 0x00319430
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CEA2 RID: 52898 RVA: 0x0031B26C File Offset: 0x0031946C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetBranchNodeByGUID_b__0(BranchNodeData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.__c__DisplayClass12_0.NativeMethodInfoPtr__GetBranchNodeByGUID_b__0_Internal_Boolean_BranchNodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CEA3 RID: 52899 RVA: 0x000647EE File Offset: 0x000629EE
			public __c__DisplayClass12_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004043 RID: 16451
			// (get) Token: 0x0600CEA4 RID: 52900 RVA: 0x0031B2BC File Offset: 0x003194BC
			// (set) Token: 0x0600CEA5 RID: 52901 RVA: 0x000647F7 File Offset: 0x000629F7
			public unsafe string branchGUID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.__c__DisplayClass12_0.NativeFieldInfoPtr_branchGUID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.__c__DisplayClass12_0.NativeFieldInfoPtr_branchGUID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008B74 RID: 35700
			private static readonly IntPtr NativeFieldInfoPtr_branchGUID;

			// Token: 0x04008B75 RID: 35701
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B76 RID: 35702
			private static readonly IntPtr NativeMethodInfoPtr__GetBranchNodeByGUID_b__0_Internal_Boolean_BranchNodeData_0;
		}

		// Token: 0x02000A0C RID: 2572
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueContainer+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CEA6 RID: 52902 RVA: 0x0031B2E4 File Offset: 0x003194E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass13_0>.NativeClassPtr);
				DialogueContainer.__c__DisplayClass13_0.NativeFieldInfoPtr_baseChoiceOrOptionGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass13_0>.NativeClassPtr, "baseChoiceOrOptionGUID");
				DialogueContainer.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass13_0>.NativeClassPtr, 100675493);
				DialogueContainer.__c__DisplayClass13_0.NativeMethodInfoPtr__GetLink_b__0_Internal_Boolean_NodeLinkData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass13_0>.NativeClassPtr, 100675494);
			}

			// Token: 0x0600CEA7 RID: 52903 RVA: 0x0031B34C File Offset: 0x0031954C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CEA8 RID: 52904 RVA: 0x0031B388 File Offset: 0x00319588
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetLink_b__0(NodeLinkData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.__c__DisplayClass13_0.NativeMethodInfoPtr__GetLink_b__0_Internal_Boolean_NodeLinkData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CEA9 RID: 52905 RVA: 0x00064816 File Offset: 0x00062A16
			public __c__DisplayClass13_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004044 RID: 16452
			// (get) Token: 0x0600CEAA RID: 52906 RVA: 0x0031B3D8 File Offset: 0x003195D8
			// (set) Token: 0x0600CEAB RID: 52907 RVA: 0x0006481F File Offset: 0x00062A1F
			public unsafe string baseChoiceOrOptionGUID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.__c__DisplayClass13_0.NativeFieldInfoPtr_baseChoiceOrOptionGUID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.__c__DisplayClass13_0.NativeFieldInfoPtr_baseChoiceOrOptionGUID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008B77 RID: 35703
			private static readonly IntPtr NativeFieldInfoPtr_baseChoiceOrOptionGUID;

			// Token: 0x04008B78 RID: 35704
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B79 RID: 35705
			private static readonly IntPtr NativeMethodInfoPtr__GetLink_b__0_Internal_Boolean_NodeLinkData_0;
		}

		// Token: 0x02000A0D RID: 2573
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueContainer+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CEAC RID: 52908 RVA: 0x0031B400 File Offset: 0x00319600
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass9_0>.NativeClassPtr);
				DialogueContainer.__c__DisplayClass9_0.NativeFieldInfoPtr_dialogueNodeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass9_0>.NativeClassPtr, "dialogueNodeLabel");
				DialogueContainer.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass9_0>.NativeClassPtr, 100675495);
				DialogueContainer.__c__DisplayClass9_0.NativeMethodInfoPtr__GetDialogueNodeByLabel_b__0_Internal_Boolean_DialogueNodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass9_0>.NativeClassPtr, 100675496);
			}

			// Token: 0x0600CEAD RID: 52909 RVA: 0x0031B468 File Offset: 0x00319668
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CEAE RID: 52910 RVA: 0x0031B4A4 File Offset: 0x003196A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198603, XrefRangeEnd = 198619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetDialogueNodeByLabel_b__0(DialogueNodeData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.__c__DisplayClass9_0.NativeMethodInfoPtr__GetDialogueNodeByLabel_b__0_Internal_Boolean_DialogueNodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CEAF RID: 52911 RVA: 0x0006483E File Offset: 0x00062A3E
			public __c__DisplayClass9_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004045 RID: 16453
			// (get) Token: 0x0600CEB0 RID: 52912 RVA: 0x0031B4F4 File Offset: 0x003196F4
			// (set) Token: 0x0600CEB1 RID: 52913 RVA: 0x00064847 File Offset: 0x00062A47
			public unsafe string dialogueNodeLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.__c__DisplayClass9_0.NativeFieldInfoPtr_dialogueNodeLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.__c__DisplayClass9_0.NativeFieldInfoPtr_dialogueNodeLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008B7A RID: 35706
			private static readonly IntPtr NativeFieldInfoPtr_dialogueNodeLabel;

			// Token: 0x04008B7B RID: 35707
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B7C RID: 35708
			private static readonly IntPtr NativeMethodInfoPtr__GetDialogueNodeByLabel_b__0_Internal_Boolean_DialogueNodeData_0;
		}
	}
}
