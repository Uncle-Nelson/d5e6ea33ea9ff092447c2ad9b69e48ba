using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.NPCs.Schedules;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.UI.Handover;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace Il2CppScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x02000336 RID: 822
	public class Thomas : NPC
	{
		// Token: 0x06003C98 RID: 15512 RVA: 0x001357D8 File Offset: 0x001339D8
		// Note: this type is marked as 'beforefieldinit'.
		static Thomas()
		{
			Il2CppClassPointerStore<Thomas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.CharacterClasses", "Thomas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Thomas>.NativeClassPtr);
			Thomas.NativeFieldInfoPtr_CARTEL_CONTRACT_QUANTITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thomas>.NativeClassPtr, "CARTEL_CONTRACT_QUANTITY");
			Thomas.NativeFieldInfoPtr_CARTEL_CONTRACT_PAYMENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thomas>.NativeClassPtr, "CARTEL_CONTRACT_PAYMENT");
			Thomas.NativeFieldInfoPtr_FirstMeetingEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thomas>.NativeClassPtr, "FirstMeetingEvent");
			Thomas.NativeFieldInfoPtr_HandoverEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thomas>.NativeClassPtr, "HandoverEvent");
			Thomas.NativeFieldInfoPtr_onCartelContractReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thomas>.NativeClassPtr, "onCartelContractReceived");
			Thomas.NativeFieldInfoPtr__MeetingReminderSent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thomas>.NativeClassPtr, "<MeetingReminderSent>k__BackingField");
			Thomas.NativeFieldInfoPtr__HandoverReminderSent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thomas>.NativeClassPtr, "<HandoverReminderSent>k__BackingField");
			Thomas.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thomas>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.ThomasAssembly-CSharp.dll_Excuted");
			Thomas.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thomas>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.ThomasAssembly-CSharp.dll_Excuted");
			Thomas.NativeMethodInfoPtr_get_MeetingReminderSent_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670358);
			Thomas.NativeMethodInfoPtr_set_MeetingReminderSent_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670359);
			Thomas.NativeMethodInfoPtr_get_HandoverReminderSent_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670360);
			Thomas.NativeMethodInfoPtr_set_HandoverReminderSent_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670361);
			Thomas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670362);
			Thomas.NativeMethodInfoPtr_SetFirstMeetingEventActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670363);
			Thomas.NativeMethodInfoPtr_SetHandoverEventActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670364);
			Thomas.NativeMethodInfoPtr_SendMeetingReminder_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670365);
			Thomas.NativeMethodInfoPtr_SendHandoverReminder_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670366);
			Thomas.NativeMethodInfoPtr_InitialMeetingComplete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670367);
			Thomas.NativeMethodInfoPtr_DialogueChoiceCallback_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670368);
			Thomas.NativeMethodInfoPtr_ProcessItemHandover_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670369);
			Thomas.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670370);
			Thomas.NativeMethodInfoPtr_Load_Public_Virtual_Void_NPCData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670371);
			Thomas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670372);
			Thomas.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670373);
			Thomas.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670374);
			Thomas.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670375);
			Thomas.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670376);
		}

		// Token: 0x170012E4 RID: 4836
		// (get) Token: 0x06003C99 RID: 15513 RVA: 0x00135A38 File Offset: 0x00133C38
		// (set) Token: 0x06003C9A RID: 15514 RVA: 0x00135A74 File Offset: 0x00133C74
		public unsafe bool MeetingReminderSent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_get_MeetingReminderSent_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_set_MeetingReminderSent_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170012E5 RID: 4837
		// (get) Token: 0x06003C9B RID: 15515 RVA: 0x00135AB4 File Offset: 0x00133CB4
		// (set) Token: 0x06003C9C RID: 15516 RVA: 0x00135AF0 File Offset: 0x00133CF0
		public unsafe bool HandoverReminderSent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_get_HandoverReminderSent_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_set_HandoverReminderSent_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003C9D RID: 15517 RVA: 0x00135B30 File Offset: 0x00133D30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143023, XrefRangeEnd = 143034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Thomas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C9E RID: 15518 RVA: 0x00135B6C File Offset: 0x00133D6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 143037, RefRangeEnd = 143038, XrefRangeStart = 143034, XrefRangeEnd = 143037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFirstMeetingEventActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_SetFirstMeetingEventActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C9F RID: 15519 RVA: 0x00135BAC File Offset: 0x00133DAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 143041, RefRangeEnd = 143043, XrefRangeStart = 143038, XrefRangeEnd = 143041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHandoverEventActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_SetHandoverEventActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CA0 RID: 15520 RVA: 0x00135BEC File Offset: 0x00133DEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 143055, RefRangeEnd = 143056, XrefRangeStart = 143043, XrefRangeEnd = 143055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendMeetingReminder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_SendMeetingReminder_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CA1 RID: 15521 RVA: 0x00135C20 File Offset: 0x00133E20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 143073, RefRangeEnd = 143074, XrefRangeStart = 143056, XrefRangeEnd = 143073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendHandoverReminder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_SendHandoverReminder_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CA2 RID: 15522 RVA: 0x00135C54 File Offset: 0x00133E54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 143078, RefRangeEnd = 143079, XrefRangeStart = 143074, XrefRangeEnd = 143078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitialMeetingComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_InitialMeetingComplete_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CA3 RID: 15523 RVA: 0x00135C88 File Offset: 0x00133E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143079, XrefRangeEnd = 143142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DialogueChoiceCallback(string choiceLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_DialogueChoiceCallback_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CA4 RID: 15524 RVA: 0x00135CCC File Offset: 0x00133ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143142, XrefRangeEnd = 143155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessItemHandover(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, float price)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref outcome;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref price;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_ProcessItemHandover_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CA5 RID: 15525 RVA: 0x00135D2C File Offset: 0x00133F2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143155, XrefRangeEnd = 143160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Thomas.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003CA6 RID: 15526 RVA: 0x00135D70 File Offset: 0x00133F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143160, XrefRangeEnd = 143169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(NPCData data, string containerPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(containerPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Thomas.NativeMethodInfoPtr_Load_Public_Virtual_Void_NPCData_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CA7 RID: 15527 RVA: 0x00135DD0 File Offset: 0x00133FD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Thomas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Thomas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CA8 RID: 15528 RVA: 0x00135E0C File Offset: 0x0013400C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143169, XrefRangeEnd = 143170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Thomas.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CA9 RID: 15529 RVA: 0x00135E48 File Offset: 0x00134048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143170, XrefRangeEnd = 143171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Thomas.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CAA RID: 15530 RVA: 0x00135E84 File Offset: 0x00134084
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Thomas.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CAB RID: 15531 RVA: 0x00135EC0 File Offset: 0x001340C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 142072, RefRangeEnd = 142075, XrefRangeStart = 142072, XrefRangeEnd = 142075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Thomas.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CAC RID: 15532 RVA: 0x0001EBAF File Offset: 0x0001CDAF
		public Thomas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170012DB RID: 4827
		// (get) Token: 0x06003CAD RID: 15533 RVA: 0x00135EFC File Offset: 0x001340FC
		// (set) Token: 0x06003CAE RID: 15534 RVA: 0x0001EBB8 File Offset: 0x0001CDB8
		public unsafe static int CARTEL_CONTRACT_QUANTITY
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Thomas.NativeFieldInfoPtr_CARTEL_CONTRACT_QUANTITY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Thomas.NativeFieldInfoPtr_CARTEL_CONTRACT_QUANTITY, (void*)(&value));
			}
		}

		// Token: 0x170012DC RID: 4828
		// (get) Token: 0x06003CAF RID: 15535 RVA: 0x00135F18 File Offset: 0x00134118
		// (set) Token: 0x06003CB0 RID: 15536 RVA: 0x0001EBC6 File Offset: 0x0001CDC6
		public unsafe static float CARTEL_CONTRACT_PAYMENT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Thomas.NativeFieldInfoPtr_CARTEL_CONTRACT_PAYMENT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Thomas.NativeFieldInfoPtr_CARTEL_CONTRACT_PAYMENT, (void*)(&value));
			}
		}

		// Token: 0x170012DD RID: 4829
		// (get) Token: 0x06003CB1 RID: 15537 RVA: 0x00135F34 File Offset: 0x00134134
		// (set) Token: 0x06003CB2 RID: 15538 RVA: 0x0001EBD4 File Offset: 0x0001CDD4
		public unsafe NPCEvent_LocationDialogue FirstMeetingEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr_FirstMeetingEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCEvent_LocationDialogue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr_FirstMeetingEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012DE RID: 4830
		// (get) Token: 0x06003CB3 RID: 15539 RVA: 0x00135F64 File Offset: 0x00134164
		// (set) Token: 0x06003CB4 RID: 15540 RVA: 0x0001EBF3 File Offset: 0x0001CDF3
		public unsafe NPCEvent_LocationDialogue HandoverEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr_HandoverEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCEvent_LocationDialogue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr_HandoverEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012DF RID: 4831
		// (get) Token: 0x06003CB5 RID: 15541 RVA: 0x00135F94 File Offset: 0x00134194
		// (set) Token: 0x06003CB6 RID: 15542 RVA: 0x0001EC12 File Offset: 0x0001CE12
		public unsafe UnityEvent onCartelContractReceived
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr_onCartelContractReceived);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr_onCartelContractReceived), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012E0 RID: 4832
		// (get) Token: 0x06003CB7 RID: 15543 RVA: 0x00135FC4 File Offset: 0x001341C4
		// (set) Token: 0x06003CB8 RID: 15544 RVA: 0x0001EC31 File Offset: 0x0001CE31
		public unsafe bool _MeetingReminderSent_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr__MeetingReminderSent_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr__MeetingReminderSent_k__BackingField)) = value;
			}
		}

		// Token: 0x170012E1 RID: 4833
		// (get) Token: 0x06003CB9 RID: 15545 RVA: 0x00135FEC File Offset: 0x001341EC
		// (set) Token: 0x06003CBA RID: 15546 RVA: 0x0001EC4C File Offset: 0x0001CE4C
		public unsafe bool _HandoverReminderSent_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr__HandoverReminderSent_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr__HandoverReminderSent_k__BackingField)) = value;
			}
		}

		// Token: 0x170012E2 RID: 4834
		// (get) Token: 0x06003CBB RID: 15547 RVA: 0x00136014 File Offset: 0x00134214
		// (set) Token: 0x06003CBC RID: 15548 RVA: 0x0001EC67 File Offset: 0x0001CE67
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170012E3 RID: 4835
		// (get) Token: 0x06003CBD RID: 15549 RVA: 0x0013603C File Offset: 0x0013423C
		// (set) Token: 0x06003CBE RID: 15550 RVA: 0x0001EC82 File Offset: 0x0001CE82
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040027F5 RID: 10229
		private static readonly IntPtr NativeFieldInfoPtr_CARTEL_CONTRACT_QUANTITY;

		// Token: 0x040027F6 RID: 10230
		private static readonly IntPtr NativeFieldInfoPtr_CARTEL_CONTRACT_PAYMENT;

		// Token: 0x040027F7 RID: 10231
		private static readonly IntPtr NativeFieldInfoPtr_FirstMeetingEvent;

		// Token: 0x040027F8 RID: 10232
		private static readonly IntPtr NativeFieldInfoPtr_HandoverEvent;

		// Token: 0x040027F9 RID: 10233
		private static readonly IntPtr NativeFieldInfoPtr_onCartelContractReceived;

		// Token: 0x040027FA RID: 10234
		private static readonly IntPtr NativeFieldInfoPtr__MeetingReminderSent_k__BackingField;

		// Token: 0x040027FB RID: 10235
		private static readonly IntPtr NativeFieldInfoPtr__HandoverReminderSent_k__BackingField;

		// Token: 0x040027FC RID: 10236
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040027FD RID: 10237
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040027FE RID: 10238
		private static readonly IntPtr NativeMethodInfoPtr_get_MeetingReminderSent_Public_get_Boolean_0;

		// Token: 0x040027FF RID: 10239
		private static readonly IntPtr NativeMethodInfoPtr_set_MeetingReminderSent_Protected_set_Void_Boolean_0;

		// Token: 0x04002800 RID: 10240
		private static readonly IntPtr NativeMethodInfoPtr_get_HandoverReminderSent_Public_get_Boolean_0;

		// Token: 0x04002801 RID: 10241
		private static readonly IntPtr NativeMethodInfoPtr_set_HandoverReminderSent_Protected_set_Void_Boolean_0;

		// Token: 0x04002802 RID: 10242
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04002803 RID: 10243
		private static readonly IntPtr NativeMethodInfoPtr_SetFirstMeetingEventActive_Public_Void_Boolean_0;

		// Token: 0x04002804 RID: 10244
		private static readonly IntPtr NativeMethodInfoPtr_SetHandoverEventActive_Public_Void_Boolean_0;

		// Token: 0x04002805 RID: 10245
		private static readonly IntPtr NativeMethodInfoPtr_SendMeetingReminder_Public_Void_0;

		// Token: 0x04002806 RID: 10246
		private static readonly IntPtr NativeMethodInfoPtr_SendHandoverReminder_Public_Void_0;

		// Token: 0x04002807 RID: 10247
		private static readonly IntPtr NativeMethodInfoPtr_InitialMeetingComplete_Public_Void_0;

		// Token: 0x04002808 RID: 10248
		private static readonly IntPtr NativeMethodInfoPtr_DialogueChoiceCallback_Private_Void_String_0;

		// Token: 0x04002809 RID: 10249
		private static readonly IntPtr NativeMethodInfoPtr_ProcessItemHandover_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_0;

		// Token: 0x0400280A RID: 10250
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x0400280B RID: 10251
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_NPCData_String_0;

		// Token: 0x0400280C RID: 10252
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400280D RID: 10253
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400280E RID: 10254
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400280F RID: 10255
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002810 RID: 10256
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
