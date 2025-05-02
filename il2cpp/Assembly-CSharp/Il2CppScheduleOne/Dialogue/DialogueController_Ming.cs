using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.Quests;
using Il2CppSystem;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000432 RID: 1074
	public class DialogueController_Ming : DialogueController
	{
		// Token: 0x06005E68 RID: 24168 RVA: 0x001B2BD0 File Offset: 0x001B0DD0
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueController_Ming()
		{
			Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueController_Ming");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr);
			DialogueController_Ming.NativeFieldInfoPtr_Property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, "Property");
			DialogueController_Ming.NativeFieldInfoPtr_Price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, "Price");
			DialogueController_Ming.NativeFieldInfoPtr_BuyDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, "BuyDialogue");
			DialogueController_Ming.NativeFieldInfoPtr_BuyText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, "BuyText");
			DialogueController_Ming.NativeFieldInfoPtr_RemindText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, "RemindText");
			DialogueController_Ming.NativeFieldInfoPtr_RemindLocationDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, "RemindLocationDialogue");
			DialogueController_Ming.NativeFieldInfoPtr_PurchaseRoomQuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, "PurchaseRoomQuests");
			DialogueController_Ming.NativeFieldInfoPtr_onPurchase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, "onPurchase");
			DialogueController_Ming.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, 100675325);
			DialogueController_Ming.NativeMethodInfoPtr_CanBuyRoom_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, 100675326);
			DialogueController_Ming.NativeMethodInfoPtr_ModifyChoiceText_Public_Virtual_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, 100675327);
			DialogueController_Ming.NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, 100675328);
			DialogueController_Ming.NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, 100675329);
			DialogueController_Ming.NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, 100675330);
			DialogueController_Ming.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, 100675331);
			DialogueController_Ming.NativeMethodInfoPtr__Start_b__8_0_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, 100675332);
		}

		// Token: 0x06005E69 RID: 24169 RVA: 0x001B2D40 File Offset: 0x001B0F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197223, XrefRangeEnd = 197261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Ming.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E6A RID: 24170 RVA: 0x001B2D7C File Offset: 0x001B0F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197261, XrefRangeEnd = 197266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanBuyRoom(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_Ming.NativeMethodInfoPtr_CanBuyRoom_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005E6B RID: 24171 RVA: 0x001B2DC8 File Offset: 0x001B0FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197266, XrefRangeEnd = 197278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ModifyChoiceText(string choiceLabel, string choiceText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(choiceText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Ming.NativeMethodInfoPtr_ModifyChoiceText_Public_Virtual_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005E6C RID: 24172 RVA: 0x001B2E30 File Offset: 0x001B1030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197278, XrefRangeEnd = 197292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogueText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Ming.NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005E6D RID: 24173 RVA: 0x001B2E98 File Offset: 0x001B1098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197292, XrefRangeEnd = 197304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Ming.NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005E6E RID: 24174 RVA: 0x001B2F0C File Offset: 0x001B110C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197304, XrefRangeEnd = 197321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ChoiceCallback(string choiceLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Ming.NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E6F RID: 24175 RVA: 0x001B2F5C File Offset: 0x001B115C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197321, XrefRangeEnd = 197333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueController_Ming() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_Ming.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E70 RID: 24176 RVA: 0x001B2F98 File Offset: 0x001B1198
		[CallerCount(0)]
		public unsafe bool _Start_b__8_0(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_Ming.NativeMethodInfoPtr__Start_b__8_0_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005E71 RID: 24177 RVA: 0x0002C841 File Offset: 0x0002AA41
		public DialogueController_Ming(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C63 RID: 7267
		// (get) Token: 0x06005E72 RID: 24178 RVA: 0x001B2FE4 File Offset: 0x001B11E4
		// (set) Token: 0x06005E73 RID: 24179 RVA: 0x0002C84A File Offset: 0x0002AA4A
		public unsafe Property Property
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_Property);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_Property), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C64 RID: 7268
		// (get) Token: 0x06005E74 RID: 24180 RVA: 0x001B3014 File Offset: 0x001B1214
		// (set) Token: 0x06005E75 RID: 24181 RVA: 0x0002C869 File Offset: 0x0002AA69
		public unsafe float Price
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_Price);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_Price)) = value;
			}
		}

		// Token: 0x17001C65 RID: 7269
		// (get) Token: 0x06005E76 RID: 24182 RVA: 0x001B303C File Offset: 0x001B123C
		// (set) Token: 0x06005E77 RID: 24183 RVA: 0x0002C884 File Offset: 0x0002AA84
		public unsafe DialogueContainer BuyDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_BuyDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_BuyDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C66 RID: 7270
		// (get) Token: 0x06005E78 RID: 24184 RVA: 0x001B306C File Offset: 0x001B126C
		// (set) Token: 0x06005E79 RID: 24185 RVA: 0x0002C8A3 File Offset: 0x0002AAA3
		public unsafe string BuyText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_BuyText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_BuyText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001C67 RID: 7271
		// (get) Token: 0x06005E7A RID: 24186 RVA: 0x001B3094 File Offset: 0x001B1294
		// (set) Token: 0x06005E7B RID: 24187 RVA: 0x0002C8C2 File Offset: 0x0002AAC2
		public unsafe string RemindText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_RemindText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_RemindText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001C68 RID: 7272
		// (get) Token: 0x06005E7C RID: 24188 RVA: 0x001B30BC File Offset: 0x001B12BC
		// (set) Token: 0x06005E7D RID: 24189 RVA: 0x0002C8E1 File Offset: 0x0002AAE1
		public unsafe DialogueContainer RemindLocationDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_RemindLocationDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_RemindLocationDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C69 RID: 7273
		// (get) Token: 0x06005E7E RID: 24190 RVA: 0x001B30EC File Offset: 0x001B12EC
		// (set) Token: 0x06005E7F RID: 24191 RVA: 0x0002C900 File Offset: 0x0002AB00
		public unsafe Il2CppReferenceArray<QuestEntry> PurchaseRoomQuests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_PurchaseRoomQuests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<QuestEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_PurchaseRoomQuests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C6A RID: 7274
		// (get) Token: 0x06005E80 RID: 24192 RVA: 0x001B311C File Offset: 0x001B131C
		// (set) Token: 0x06005E81 RID: 24193 RVA: 0x0002C91F File Offset: 0x0002AB1F
		public unsafe UnityEvent onPurchase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_onPurchase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_onPurchase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004093 RID: 16531
		private static readonly IntPtr NativeFieldInfoPtr_Property;

		// Token: 0x04004094 RID: 16532
		private static readonly IntPtr NativeFieldInfoPtr_Price;

		// Token: 0x04004095 RID: 16533
		private static readonly IntPtr NativeFieldInfoPtr_BuyDialogue;

		// Token: 0x04004096 RID: 16534
		private static readonly IntPtr NativeFieldInfoPtr_BuyText;

		// Token: 0x04004097 RID: 16535
		private static readonly IntPtr NativeFieldInfoPtr_RemindText;

		// Token: 0x04004098 RID: 16536
		private static readonly IntPtr NativeFieldInfoPtr_RemindLocationDialogue;

		// Token: 0x04004099 RID: 16537
		private static readonly IntPtr NativeFieldInfoPtr_PurchaseRoomQuests;

		// Token: 0x0400409A RID: 16538
		private static readonly IntPtr NativeFieldInfoPtr_onPurchase;

		// Token: 0x0400409B RID: 16539
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400409C RID: 16540
		private static readonly IntPtr NativeMethodInfoPtr_CanBuyRoom_Private_Boolean_Boolean_0;

		// Token: 0x0400409D RID: 16541
		private static readonly IntPtr NativeMethodInfoPtr_ModifyChoiceText_Public_Virtual_String_String_String_0;

		// Token: 0x0400409E RID: 16542
		private static readonly IntPtr NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0;

		// Token: 0x0400409F RID: 16543
		private static readonly IntPtr NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0;

		// Token: 0x040040A0 RID: 16544
		private static readonly IntPtr NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_Void_String_0;

		// Token: 0x040040A1 RID: 16545
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040040A2 RID: 16546
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__8_0_Private_Boolean_Boolean_0;

		// Token: 0x020009F9 RID: 2553
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueController_Ming+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600CE20 RID: 52768 RVA: 0x00319A68 File Offset: 0x00317C68
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DialogueController_Ming.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_Ming.__c>.NativeClassPtr);
				DialogueController_Ming.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Ming.__c>.NativeClassPtr, "<>9");
				DialogueController_Ming.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Ming.__c>.NativeClassPtr, "<>9__9_0");
				DialogueController_Ming.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Ming.__c>.NativeClassPtr, 100675334);
				DialogueController_Ming.__c.NativeMethodInfoPtr__CanBuyRoom_b__9_0_Internal_Boolean_QuestEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Ming.__c>.NativeClassPtr, 100675335);
			}

			// Token: 0x0600CE21 RID: 52769 RVA: 0x00319AE4 File Offset: 0x00317CE4
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_Ming.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_Ming.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE22 RID: 52770 RVA: 0x00319B20 File Offset: 0x00317D20
			[CallerCount(0)]
			public unsafe bool _CanBuyRoom_b__9_0(QuestEntry q)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(q);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_Ming.__c.NativeMethodInfoPtr__CanBuyRoom_b__9_0_Internal_Boolean_QuestEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE23 RID: 52771 RVA: 0x00064450 File Offset: 0x00062650
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004029 RID: 16425
			// (get) Token: 0x0600CE24 RID: 52772 RVA: 0x00319B70 File Offset: 0x00317D70
			// (set) Token: 0x0600CE25 RID: 52773 RVA: 0x00064459 File Offset: 0x00062659
			public unsafe static DialogueController_Ming.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogueController_Ming.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController_Ming.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogueController_Ming.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700402A RID: 16426
			// (get) Token: 0x0600CE26 RID: 52774 RVA: 0x00319B98 File Offset: 0x00317D98
			// (set) Token: 0x0600CE27 RID: 52775 RVA: 0x0006446B File Offset: 0x0006266B
			public unsafe static Func<QuestEntry, bool> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogueController_Ming.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<QuestEntry, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogueController_Ming.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008B32 RID: 35634
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008B33 RID: 35635
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x04008B34 RID: 35636
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B35 RID: 35637
			private static readonly IntPtr NativeMethodInfoPtr__CanBuyRoom_b__9_0_Internal_Boolean_QuestEntry_0;
		}
	}
}
