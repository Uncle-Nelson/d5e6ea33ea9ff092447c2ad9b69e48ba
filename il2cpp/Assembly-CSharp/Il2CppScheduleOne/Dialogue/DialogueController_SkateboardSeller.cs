using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000434 RID: 1076
	public class DialogueController_SkateboardSeller : DialogueController
	{
		// Token: 0x06005E89 RID: 24201 RVA: 0x001B32BC File Offset: 0x001B14BC
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueController_SkateboardSeller()
		{
			Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueController_SkateboardSeller");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr);
			DialogueController_SkateboardSeller.NativeFieldInfoPtr_Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, "Options");
			DialogueController_SkateboardSeller.NativeFieldInfoPtr_chosenWeapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, "chosenWeapon");
			DialogueController_SkateboardSeller.NativeFieldInfoPtr_onPurchase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, "onPurchase");
			DialogueController_SkateboardSeller.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, 100675339);
			DialogueController_SkateboardSeller.NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, 100675340);
			DialogueController_SkateboardSeller.NativeMethodInfoPtr_ModifyChoiceList_Public_Virtual_Void_String_byref_List_1_DialogueChoiceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, 100675341);
			DialogueController_SkateboardSeller.NativeMethodInfoPtr_GetChoices_Private_List_1_DialogueChoiceData_List_1_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, 100675342);
			DialogueController_SkateboardSeller.NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, 100675343);
			DialogueController_SkateboardSeller.NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, 100675344);
			DialogueController_SkateboardSeller.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, 100675345);
		}

		// Token: 0x06005E8A RID: 24202 RVA: 0x001B33B4 File Offset: 0x001B15B4
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_SkateboardSeller.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E8B RID: 24203 RVA: 0x001B33E8 File Offset: 0x001B15E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197346, XrefRangeEnd = 197392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ChoiceCallback(string choiceLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_SkateboardSeller.NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E8C RID: 24204 RVA: 0x001B3438 File Offset: 0x001B1638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197392, XrefRangeEnd = 197407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(existingChoices);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_SkateboardSeller.NativeMethodInfoPtr_ModifyChoiceList_Public_Virtual_Void_String_byref_List_1_DialogueChoiceData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			existingChoices = ((intPtr4 == 0) ? null : new List<DialogueChoiceData>(intPtr4));
		}

		// Token: 0x06005E8D RID: 24205 RVA: 0x001B34AC File Offset: 0x001B16AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 197444, RefRangeEnd = 197445, XrefRangeStart = 197407, XrefRangeEnd = 197444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<DialogueChoiceData> GetChoices(List<DialogueController_SkateboardSeller.Option> options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_SkateboardSeller.NativeMethodInfoPtr_GetChoices_Private_List_1_DialogueChoiceData_List_1_Option_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<DialogueChoiceData>>(intPtr3) : null;
		}

		// Token: 0x06005E8E RID: 24206 RVA: 0x001B34FC File Offset: 0x001B16FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197445, XrefRangeEnd = 197470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_SkateboardSeller.NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005E8F RID: 24207 RVA: 0x001B3570 File Offset: 0x001B1770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197470, XrefRangeEnd = 197487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogueText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_SkateboardSeller.NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005E90 RID: 24208 RVA: 0x001B35D8 File Offset: 0x001B17D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197487, XrefRangeEnd = 197498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueController_SkateboardSeller() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_SkateboardSeller.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E91 RID: 24209 RVA: 0x0002C966 File Offset: 0x0002AB66
		public DialogueController_SkateboardSeller(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C6C RID: 7276
		// (get) Token: 0x06005E92 RID: 24210 RVA: 0x001B3614 File Offset: 0x001B1814
		// (set) Token: 0x06005E93 RID: 24211 RVA: 0x0002C96F File Offset: 0x0002AB6F
		public unsafe List<DialogueController_SkateboardSeller.Option> Options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.NativeFieldInfoPtr_Options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueController_SkateboardSeller.Option>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.NativeFieldInfoPtr_Options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C6D RID: 7277
		// (get) Token: 0x06005E94 RID: 24212 RVA: 0x001B3644 File Offset: 0x001B1844
		// (set) Token: 0x06005E95 RID: 24213 RVA: 0x0002C98E File Offset: 0x0002AB8E
		public unsafe DialogueController_SkateboardSeller.Option chosenWeapon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.NativeFieldInfoPtr_chosenWeapon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController_SkateboardSeller.Option>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.NativeFieldInfoPtr_chosenWeapon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C6E RID: 7278
		// (get) Token: 0x06005E96 RID: 24214 RVA: 0x001B3674 File Offset: 0x001B1874
		// (set) Token: 0x06005E97 RID: 24215 RVA: 0x0002C9AD File Offset: 0x0002ABAD
		public unsafe UnityEvent onPurchase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.NativeFieldInfoPtr_onPurchase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.NativeFieldInfoPtr_onPurchase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040040A7 RID: 16551
		private static readonly IntPtr NativeFieldInfoPtr_Options;

		// Token: 0x040040A8 RID: 16552
		private static readonly IntPtr NativeFieldInfoPtr_chosenWeapon;

		// Token: 0x040040A9 RID: 16553
		private static readonly IntPtr NativeFieldInfoPtr_onPurchase;

		// Token: 0x040040AA RID: 16554
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040040AB RID: 16555
		private static readonly IntPtr NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_Void_String_0;

		// Token: 0x040040AC RID: 16556
		private static readonly IntPtr NativeMethodInfoPtr_ModifyChoiceList_Public_Virtual_Void_String_byref_List_1_DialogueChoiceData_0;

		// Token: 0x040040AD RID: 16557
		private static readonly IntPtr NativeMethodInfoPtr_GetChoices_Private_List_1_DialogueChoiceData_List_1_Option_0;

		// Token: 0x040040AE RID: 16558
		private static readonly IntPtr NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0;

		// Token: 0x040040AF RID: 16559
		private static readonly IntPtr NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0;

		// Token: 0x040040B0 RID: 16560
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009FA RID: 2554
		[Serializable]
		public class Option : Object
		{
			// Token: 0x0600CE28 RID: 52776 RVA: 0x00319BC0 File Offset: 0x00317DC0
			// Note: this type is marked as 'beforefieldinit'.
			static Option()
			{
				Il2CppClassPointerStore<DialogueController_SkateboardSeller.Option>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, "Option");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_SkateboardSeller.Option>.NativeClassPtr);
				DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_SkateboardSeller.Option>.NativeClassPtr, "Name");
				DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_Price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_SkateboardSeller.Option>.NativeClassPtr, "Price");
				DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_IsAvailable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_SkateboardSeller.Option>.NativeClassPtr, "IsAvailable");
				DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_NotAvailableReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_SkateboardSeller.Option>.NativeClassPtr, "NotAvailableReason");
				DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_SkateboardSeller.Option>.NativeClassPtr, "Item");
				DialogueController_SkateboardSeller.Option.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_SkateboardSeller.Option>.NativeClassPtr, 100675346);
			}

			// Token: 0x0600CE29 RID: 52777 RVA: 0x00319C64 File Offset: 0x00317E64
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Option() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_SkateboardSeller.Option>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_SkateboardSeller.Option.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE2A RID: 52778 RVA: 0x0006447D File Offset: 0x0006267D
			public Option(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700402B RID: 16427
			// (get) Token: 0x0600CE2B RID: 52779 RVA: 0x00319CA0 File Offset: 0x00317EA0
			// (set) Token: 0x0600CE2C RID: 52780 RVA: 0x00064486 File Offset: 0x00062686
			public unsafe string Name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_Name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700402C RID: 16428
			// (get) Token: 0x0600CE2D RID: 52781 RVA: 0x00319CC8 File Offset: 0x00317EC8
			// (set) Token: 0x0600CE2E RID: 52782 RVA: 0x000644A5 File Offset: 0x000626A5
			public unsafe float Price
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_Price);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_Price)) = value;
				}
			}

			// Token: 0x1700402D RID: 16429
			// (get) Token: 0x0600CE2F RID: 52783 RVA: 0x00319CF0 File Offset: 0x00317EF0
			// (set) Token: 0x0600CE30 RID: 52784 RVA: 0x000644C0 File Offset: 0x000626C0
			public unsafe bool IsAvailable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_IsAvailable);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_IsAvailable)) = value;
				}
			}

			// Token: 0x1700402E RID: 16430
			// (get) Token: 0x0600CE31 RID: 52785 RVA: 0x00319D18 File Offset: 0x00317F18
			// (set) Token: 0x0600CE32 RID: 52786 RVA: 0x000644DB File Offset: 0x000626DB
			public unsafe string NotAvailableReason
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_NotAvailableReason);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_NotAvailableReason), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700402F RID: 16431
			// (get) Token: 0x0600CE33 RID: 52787 RVA: 0x00319D40 File Offset: 0x00317F40
			// (set) Token: 0x0600CE34 RID: 52788 RVA: 0x000644FA File Offset: 0x000626FA
			public unsafe ItemDefinition Item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_Item);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_Item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008B36 RID: 35638
			private static readonly IntPtr NativeFieldInfoPtr_Name;

			// Token: 0x04008B37 RID: 35639
			private static readonly IntPtr NativeFieldInfoPtr_Price;

			// Token: 0x04008B38 RID: 35640
			private static readonly IntPtr NativeFieldInfoPtr_IsAvailable;

			// Token: 0x04008B39 RID: 35641
			private static readonly IntPtr NativeFieldInfoPtr_NotAvailableReason;

			// Token: 0x04008B3A RID: 35642
			private static readonly IntPtr NativeFieldInfoPtr_Item;

			// Token: 0x04008B3B RID: 35643
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020009FB RID: 2555
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueController_SkateboardSeller+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x0600CE35 RID: 52789 RVA: 0x00319D70 File Offset: 0x00317F70
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<DialogueController_SkateboardSeller.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_SkateboardSeller.__c__DisplayClass5_0>.NativeClassPtr);
				DialogueController_SkateboardSeller.__c__DisplayClass5_0.NativeFieldInfoPtr_choiceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_SkateboardSeller.__c__DisplayClass5_0>.NativeClassPtr, "choiceLabel");
				DialogueController_SkateboardSeller.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_SkateboardSeller.__c__DisplayClass5_0>.NativeClassPtr, 100675347);
				DialogueController_SkateboardSeller.__c__DisplayClass5_0.NativeMethodInfoPtr__ChoiceCallback_b__0_Internal_Boolean_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_SkateboardSeller.__c__DisplayClass5_0>.NativeClassPtr, 100675348);
			}

			// Token: 0x0600CE36 RID: 52790 RVA: 0x00319DD8 File Offset: 0x00317FD8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_SkateboardSeller.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_SkateboardSeller.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE37 RID: 52791 RVA: 0x00319E14 File Offset: 0x00318014
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ChoiceCallback_b__0(DialogueController_SkateboardSeller.Option x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_SkateboardSeller.__c__DisplayClass5_0.NativeMethodInfoPtr__ChoiceCallback_b__0_Internal_Boolean_Option_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE38 RID: 52792 RVA: 0x00064519 File Offset: 0x00062719
			public __c__DisplayClass5_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004030 RID: 16432
			// (get) Token: 0x0600CE39 RID: 52793 RVA: 0x00319E64 File Offset: 0x00318064
			// (set) Token: 0x0600CE3A RID: 52794 RVA: 0x00064522 File Offset: 0x00062722
			public unsafe string choiceLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.__c__DisplayClass5_0.NativeFieldInfoPtr_choiceLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.__c__DisplayClass5_0.NativeFieldInfoPtr_choiceLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008B3C RID: 35644
			private static readonly IntPtr NativeFieldInfoPtr_choiceLabel;

			// Token: 0x04008B3D RID: 35645
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B3E RID: 35646
			private static readonly IntPtr NativeMethodInfoPtr__ChoiceCallback_b__0_Internal_Boolean_Option_0;
		}

		// Token: 0x020009FC RID: 2556
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueController_SkateboardSeller+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x0600CE3B RID: 52795 RVA: 0x00319E8C File Offset: 0x0031808C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<DialogueController_SkateboardSeller.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_SkateboardSeller.__c__DisplayClass8_0>.NativeClassPtr);
				DialogueController_SkateboardSeller.__c__DisplayClass8_0.NativeFieldInfoPtr_choiceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_SkateboardSeller.__c__DisplayClass8_0>.NativeClassPtr, "choiceLabel");
				DialogueController_SkateboardSeller.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_SkateboardSeller.__c__DisplayClass8_0>.NativeClassPtr, 100675349);
				DialogueController_SkateboardSeller.__c__DisplayClass8_0.NativeMethodInfoPtr__CheckChoice_b__0_Internal_Boolean_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_SkateboardSeller.__c__DisplayClass8_0>.NativeClassPtr, 100675350);
			}

			// Token: 0x0600CE3C RID: 52796 RVA: 0x00319EF4 File Offset: 0x003180F4
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_SkateboardSeller.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_SkateboardSeller.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE3D RID: 52797 RVA: 0x00319F30 File Offset: 0x00318130
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CheckChoice_b__0(DialogueController_SkateboardSeller.Option x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_SkateboardSeller.__c__DisplayClass8_0.NativeMethodInfoPtr__CheckChoice_b__0_Internal_Boolean_Option_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE3E RID: 52798 RVA: 0x00064541 File Offset: 0x00062741
			public __c__DisplayClass8_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004031 RID: 16433
			// (get) Token: 0x0600CE3F RID: 52799 RVA: 0x00319F80 File Offset: 0x00318180
			// (set) Token: 0x0600CE40 RID: 52800 RVA: 0x0006454A File Offset: 0x0006274A
			public unsafe string choiceLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.__c__DisplayClass8_0.NativeFieldInfoPtr_choiceLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.__c__DisplayClass8_0.NativeFieldInfoPtr_choiceLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008B3F RID: 35647
			private static readonly IntPtr NativeFieldInfoPtr_choiceLabel;

			// Token: 0x04008B40 RID: 35648
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B41 RID: 35649
			private static readonly IntPtr NativeMethodInfoPtr__CheckChoice_b__0_Internal_Boolean_Option_0;
		}
	}
}
