using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x0200042E RID: 1070
	public class DialogueController_ArmsDealer : DialogueController
	{
		// Token: 0x06005E33 RID: 24115 RVA: 0x001B1E3C File Offset: 0x001B003C
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueController_ArmsDealer()
		{
			Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueController_ArmsDealer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr);
			DialogueController_ArmsDealer.NativeFieldInfoPtr_MeleeWeapons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, "MeleeWeapons");
			DialogueController_ArmsDealer.NativeFieldInfoPtr_RangedWeapons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, "RangedWeapons");
			DialogueController_ArmsDealer.NativeFieldInfoPtr_Ammo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, "Ammo");
			DialogueController_ArmsDealer.NativeFieldInfoPtr_allWeapons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, "allWeapons");
			DialogueController_ArmsDealer.NativeFieldInfoPtr_chosenWeapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, "chosenWeapon");
			DialogueController_ArmsDealer.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, 100675295);
			DialogueController_ArmsDealer.NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, 100675296);
			DialogueController_ArmsDealer.NativeMethodInfoPtr_ModifyChoiceList_Public_Virtual_Void_String_byref_List_1_DialogueChoiceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, 100675297);
			DialogueController_ArmsDealer.NativeMethodInfoPtr_GetWeaponChoices_Private_List_1_DialogueChoiceData_List_1_WeaponOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, 100675298);
			DialogueController_ArmsDealer.NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, 100675299);
			DialogueController_ArmsDealer.NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, 100675300);
			DialogueController_ArmsDealer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, 100675301);
		}

		// Token: 0x06005E34 RID: 24116 RVA: 0x001B1F5C File Offset: 0x001B015C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196745, XrefRangeEnd = 196760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_ArmsDealer.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E35 RID: 24117 RVA: 0x001B1F90 File Offset: 0x001B0190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196760, XrefRangeEnd = 196794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ChoiceCallback(string choiceLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_ArmsDealer.NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E36 RID: 24118 RVA: 0x001B1FE0 File Offset: 0x001B01E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196794, XrefRangeEnd = 196815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(existingChoices);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_ArmsDealer.NativeMethodInfoPtr_ModifyChoiceList_Public_Virtual_Void_String_byref_List_1_DialogueChoiceData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			existingChoices = ((intPtr4 == 0) ? null : new List<DialogueChoiceData>(intPtr4));
		}

		// Token: 0x06005E37 RID: 24119 RVA: 0x001B2054 File Offset: 0x001B0254
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 196852, RefRangeEnd = 196855, XrefRangeStart = 196815, XrefRangeEnd = 196852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<DialogueChoiceData> GetWeaponChoices(List<DialogueController_ArmsDealer.WeaponOption> options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_ArmsDealer.NativeMethodInfoPtr_GetWeaponChoices_Private_List_1_DialogueChoiceData_List_1_WeaponOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<DialogueChoiceData>>(intPtr3) : null;
		}

		// Token: 0x06005E38 RID: 24120 RVA: 0x001B20A4 File Offset: 0x001B02A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196855, XrefRangeEnd = 196885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_ArmsDealer.NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005E39 RID: 24121 RVA: 0x001B2118 File Offset: 0x001B0318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196885, XrefRangeEnd = 196902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogueText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_ArmsDealer.NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005E3A RID: 24122 RVA: 0x001B2180 File Offset: 0x001B0380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196902, XrefRangeEnd = 196906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueController_ArmsDealer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_ArmsDealer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E3B RID: 24123 RVA: 0x0002C6EF File Offset: 0x0002A8EF
		public DialogueController_ArmsDealer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C58 RID: 7256
		// (get) Token: 0x06005E3C RID: 24124 RVA: 0x001B21BC File Offset: 0x001B03BC
		// (set) Token: 0x06005E3D RID: 24125 RVA: 0x0002C6F8 File Offset: 0x0002A8F8
		public unsafe List<DialogueController_ArmsDealer.WeaponOption> MeleeWeapons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.NativeFieldInfoPtr_MeleeWeapons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueController_ArmsDealer.WeaponOption>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.NativeFieldInfoPtr_MeleeWeapons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C59 RID: 7257
		// (get) Token: 0x06005E3E RID: 24126 RVA: 0x001B21EC File Offset: 0x001B03EC
		// (set) Token: 0x06005E3F RID: 24127 RVA: 0x0002C717 File Offset: 0x0002A917
		public unsafe List<DialogueController_ArmsDealer.WeaponOption> RangedWeapons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.NativeFieldInfoPtr_RangedWeapons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueController_ArmsDealer.WeaponOption>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.NativeFieldInfoPtr_RangedWeapons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C5A RID: 7258
		// (get) Token: 0x06005E40 RID: 24128 RVA: 0x001B221C File Offset: 0x001B041C
		// (set) Token: 0x06005E41 RID: 24129 RVA: 0x0002C736 File Offset: 0x0002A936
		public unsafe List<DialogueController_ArmsDealer.WeaponOption> Ammo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.NativeFieldInfoPtr_Ammo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueController_ArmsDealer.WeaponOption>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.NativeFieldInfoPtr_Ammo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C5B RID: 7259
		// (get) Token: 0x06005E42 RID: 24130 RVA: 0x001B224C File Offset: 0x001B044C
		// (set) Token: 0x06005E43 RID: 24131 RVA: 0x0002C755 File Offset: 0x0002A955
		public unsafe List<DialogueController_ArmsDealer.WeaponOption> allWeapons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.NativeFieldInfoPtr_allWeapons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueController_ArmsDealer.WeaponOption>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.NativeFieldInfoPtr_allWeapons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C5C RID: 7260
		// (get) Token: 0x06005E44 RID: 24132 RVA: 0x001B227C File Offset: 0x001B047C
		// (set) Token: 0x06005E45 RID: 24133 RVA: 0x0002C774 File Offset: 0x0002A974
		public unsafe DialogueController_ArmsDealer.WeaponOption chosenWeapon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.NativeFieldInfoPtr_chosenWeapon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController_ArmsDealer.WeaponOption>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.NativeFieldInfoPtr_chosenWeapon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004070 RID: 16496
		private static readonly IntPtr NativeFieldInfoPtr_MeleeWeapons;

		// Token: 0x04004071 RID: 16497
		private static readonly IntPtr NativeFieldInfoPtr_RangedWeapons;

		// Token: 0x04004072 RID: 16498
		private static readonly IntPtr NativeFieldInfoPtr_Ammo;

		// Token: 0x04004073 RID: 16499
		private static readonly IntPtr NativeFieldInfoPtr_allWeapons;

		// Token: 0x04004074 RID: 16500
		private static readonly IntPtr NativeFieldInfoPtr_chosenWeapon;

		// Token: 0x04004075 RID: 16501
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004076 RID: 16502
		private static readonly IntPtr NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_Void_String_0;

		// Token: 0x04004077 RID: 16503
		private static readonly IntPtr NativeMethodInfoPtr_ModifyChoiceList_Public_Virtual_Void_String_byref_List_1_DialogueChoiceData_0;

		// Token: 0x04004078 RID: 16504
		private static readonly IntPtr NativeMethodInfoPtr_GetWeaponChoices_Private_List_1_DialogueChoiceData_List_1_WeaponOption_0;

		// Token: 0x04004079 RID: 16505
		private static readonly IntPtr NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0;

		// Token: 0x0400407A RID: 16506
		private static readonly IntPtr NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0;

		// Token: 0x0400407B RID: 16507
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009F6 RID: 2550
		[Serializable]
		public class WeaponOption : Object
		{
			// Token: 0x0600CE07 RID: 52743 RVA: 0x00319680 File Offset: 0x00317880
			// Note: this type is marked as 'beforefieldinit'.
			static WeaponOption()
			{
				Il2CppClassPointerStore<DialogueController_ArmsDealer.WeaponOption>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, "WeaponOption");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_ArmsDealer.WeaponOption>.NativeClassPtr);
				DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer.WeaponOption>.NativeClassPtr, "Name");
				DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_Price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer.WeaponOption>.NativeClassPtr, "Price");
				DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_IsAvailable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer.WeaponOption>.NativeClassPtr, "IsAvailable");
				DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_NotAvailableReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer.WeaponOption>.NativeClassPtr, "NotAvailableReason");
				DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer.WeaponOption>.NativeClassPtr, "Item");
				DialogueController_ArmsDealer.WeaponOption.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer.WeaponOption>.NativeClassPtr, 100675302);
			}

			// Token: 0x0600CE08 RID: 52744 RVA: 0x00319724 File Offset: 0x00317924
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WeaponOption() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_ArmsDealer.WeaponOption>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_ArmsDealer.WeaponOption.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE09 RID: 52745 RVA: 0x00064364 File Offset: 0x00062564
			public WeaponOption(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004022 RID: 16418
			// (get) Token: 0x0600CE0A RID: 52746 RVA: 0x00319760 File Offset: 0x00317960
			// (set) Token: 0x0600CE0B RID: 52747 RVA: 0x0006436D File Offset: 0x0006256D
			public unsafe string Name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_Name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004023 RID: 16419
			// (get) Token: 0x0600CE0C RID: 52748 RVA: 0x00319788 File Offset: 0x00317988
			// (set) Token: 0x0600CE0D RID: 52749 RVA: 0x0006438C File Offset: 0x0006258C
			public unsafe float Price
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_Price);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_Price)) = value;
				}
			}

			// Token: 0x17004024 RID: 16420
			// (get) Token: 0x0600CE0E RID: 52750 RVA: 0x003197B0 File Offset: 0x003179B0
			// (set) Token: 0x0600CE0F RID: 52751 RVA: 0x000643A7 File Offset: 0x000625A7
			public unsafe bool IsAvailable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_IsAvailable);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_IsAvailable)) = value;
				}
			}

			// Token: 0x17004025 RID: 16421
			// (get) Token: 0x0600CE10 RID: 52752 RVA: 0x003197D8 File Offset: 0x003179D8
			// (set) Token: 0x0600CE11 RID: 52753 RVA: 0x000643C2 File Offset: 0x000625C2
			public unsafe string NotAvailableReason
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_NotAvailableReason);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_NotAvailableReason), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004026 RID: 16422
			// (get) Token: 0x0600CE12 RID: 52754 RVA: 0x00319800 File Offset: 0x00317A00
			// (set) Token: 0x0600CE13 RID: 52755 RVA: 0x000643E1 File Offset: 0x000625E1
			public unsafe StorableItemDefinition Item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_Item);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorableItemDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_Item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008B26 RID: 35622
			private static readonly IntPtr NativeFieldInfoPtr_Name;

			// Token: 0x04008B27 RID: 35623
			private static readonly IntPtr NativeFieldInfoPtr_Price;

			// Token: 0x04008B28 RID: 35624
			private static readonly IntPtr NativeFieldInfoPtr_IsAvailable;

			// Token: 0x04008B29 RID: 35625
			private static readonly IntPtr NativeFieldInfoPtr_NotAvailableReason;

			// Token: 0x04008B2A RID: 35626
			private static readonly IntPtr NativeFieldInfoPtr_Item;

			// Token: 0x04008B2B RID: 35627
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020009F7 RID: 2551
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueController_ArmsDealer+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Object
		{
			// Token: 0x0600CE14 RID: 52756 RVA: 0x00319830 File Offset: 0x00317A30
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<DialogueController_ArmsDealer.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_ArmsDealer.__c__DisplayClass10_0>.NativeClassPtr);
				DialogueController_ArmsDealer.__c__DisplayClass10_0.NativeFieldInfoPtr_choiceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer.__c__DisplayClass10_0>.NativeClassPtr, "choiceLabel");
				DialogueController_ArmsDealer.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer.__c__DisplayClass10_0>.NativeClassPtr, 100675303);
				DialogueController_ArmsDealer.__c__DisplayClass10_0.NativeMethodInfoPtr__CheckChoice_b__0_Internal_Boolean_WeaponOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer.__c__DisplayClass10_0>.NativeClassPtr, 100675304);
			}

			// Token: 0x0600CE15 RID: 52757 RVA: 0x00319898 File Offset: 0x00317A98
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_ArmsDealer.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_ArmsDealer.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE16 RID: 52758 RVA: 0x003198D4 File Offset: 0x00317AD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CheckChoice_b__0(DialogueController_ArmsDealer.WeaponOption x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_ArmsDealer.__c__DisplayClass10_0.NativeMethodInfoPtr__CheckChoice_b__0_Internal_Boolean_WeaponOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE17 RID: 52759 RVA: 0x00064400 File Offset: 0x00062600
			public __c__DisplayClass10_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004027 RID: 16423
			// (get) Token: 0x0600CE18 RID: 52760 RVA: 0x00319924 File Offset: 0x00317B24
			// (set) Token: 0x0600CE19 RID: 52761 RVA: 0x00064409 File Offset: 0x00062609
			public unsafe string choiceLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.__c__DisplayClass10_0.NativeFieldInfoPtr_choiceLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.__c__DisplayClass10_0.NativeFieldInfoPtr_choiceLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008B2C RID: 35628
			private static readonly IntPtr NativeFieldInfoPtr_choiceLabel;

			// Token: 0x04008B2D RID: 35629
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B2E RID: 35630
			private static readonly IntPtr NativeMethodInfoPtr__CheckChoice_b__0_Internal_Boolean_WeaponOption_0;
		}

		// Token: 0x020009F8 RID: 2552
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueController_ArmsDealer+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x0600CE1A RID: 52762 RVA: 0x0031994C File Offset: 0x00317B4C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<DialogueController_ArmsDealer.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_ArmsDealer.__c__DisplayClass7_0>.NativeClassPtr);
				DialogueController_ArmsDealer.__c__DisplayClass7_0.NativeFieldInfoPtr_choiceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer.__c__DisplayClass7_0>.NativeClassPtr, "choiceLabel");
				DialogueController_ArmsDealer.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer.__c__DisplayClass7_0>.NativeClassPtr, 100675305);
				DialogueController_ArmsDealer.__c__DisplayClass7_0.NativeMethodInfoPtr__ChoiceCallback_b__0_Internal_Boolean_WeaponOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer.__c__DisplayClass7_0>.NativeClassPtr, 100675306);
			}

			// Token: 0x0600CE1B RID: 52763 RVA: 0x003199B4 File Offset: 0x00317BB4
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_ArmsDealer.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_ArmsDealer.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE1C RID: 52764 RVA: 0x003199F0 File Offset: 0x00317BF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ChoiceCallback_b__0(DialogueController_ArmsDealer.WeaponOption x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_ArmsDealer.__c__DisplayClass7_0.NativeMethodInfoPtr__ChoiceCallback_b__0_Internal_Boolean_WeaponOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE1D RID: 52765 RVA: 0x00064428 File Offset: 0x00062628
			public __c__DisplayClass7_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004028 RID: 16424
			// (get) Token: 0x0600CE1E RID: 52766 RVA: 0x00319A40 File Offset: 0x00317C40
			// (set) Token: 0x0600CE1F RID: 52767 RVA: 0x00064431 File Offset: 0x00062631
			public unsafe string choiceLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.__c__DisplayClass7_0.NativeFieldInfoPtr_choiceLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.__c__DisplayClass7_0.NativeFieldInfoPtr_choiceLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008B2F RID: 35631
			private static readonly IntPtr NativeFieldInfoPtr_choiceLabel;

			// Token: 0x04008B30 RID: 35632
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B31 RID: 35633
			private static readonly IntPtr NativeMethodInfoPtr__ChoiceCallback_b__0_Internal_Boolean_WeaponOption_0;
		}
	}
}
