using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Dialogue;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.NPCs.Behaviour;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Property;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Employees
{
	// Token: 0x02000409 RID: 1033
	public class Employee : NPC
	{
		// Token: 0x060057B9 RID: 22457 RVA: 0x00199344 File Offset: 0x00197544
		// Note: this type is marked as 'beforefieldinit'.
		static Employee()
		{
			Il2CppClassPointerStore<Employee>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Employees", "Employee");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Employee>.NativeClassPtr);
			Employee.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "DEBUG");
			Employee.NativeFieldInfoPtr__AssignedProperty_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "<AssignedProperty>k__BackingField");
			Employee.NativeFieldInfoPtr__EmployeeIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "<EmployeeIndex>k__BackingField");
			Employee.NativeFieldInfoPtr__PaidForToday_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "<PaidForToday>k__BackingField");
			Employee.NativeFieldInfoPtr__Fired_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "<Fired>k__BackingField");
			Employee.NativeFieldInfoPtr__IsMale_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "<IsMale>k__BackingField");
			Employee.NativeFieldInfoPtr__AppearanceIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "<AppearanceIndex>k__BackingField");
			Employee.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "Type");
			Employee.NativeFieldInfoPtr_SigningFee = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "SigningFee");
			Employee.NativeFieldInfoPtr_DailyWage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "DailyWage");
			Employee.NativeFieldInfoPtr_WaitOutside = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "WaitOutside");
			Employee.NativeFieldInfoPtr_MoveItemBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "MoveItemBehaviour");
			Employee.NativeFieldInfoPtr_BedNotAssignedDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "BedNotAssignedDialogue");
			Employee.NativeFieldInfoPtr_NotPaidDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "NotPaidDialogue");
			Employee.NativeFieldInfoPtr_WorkIssueDialogueTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "WorkIssueDialogueTemplate");
			Employee.NativeFieldInfoPtr_FireDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "FireDialogue");
			Employee.NativeFieldInfoPtr_WorkIssues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "WorkIssues");
			Employee.NativeFieldInfoPtr__TimeSinceLastWorked_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "<TimeSinceLastWorked>k__BackingField");
			Employee.NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "initialized");
			Employee.NativeFieldInfoPtr_syncVar____PaidForToday_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "syncVar___<PaidForToday>k__BackingField");
			Employee.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Employees.EmployeeAssembly-CSharp.dll_Excuted");
			Employee.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Employees.EmployeeAssembly-CSharp.dll_Excuted");
			Employee.NativeMethodInfoPtr_get_AssignedProperty_Public_get_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674348);
			Employee.NativeMethodInfoPtr_set_AssignedProperty_Protected_set_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674349);
			Employee.NativeMethodInfoPtr_get_EmployeeIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674350);
			Employee.NativeMethodInfoPtr_set_EmployeeIndex_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674351);
			Employee.NativeMethodInfoPtr_get_PaidForToday_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674352);
			Employee.NativeMethodInfoPtr_set_PaidForToday_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674353);
			Employee.NativeMethodInfoPtr_get_Fired_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674354);
			Employee.NativeMethodInfoPtr_set_Fired_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674355);
			Employee.NativeMethodInfoPtr_get_IsWaitingOutside_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674356);
			Employee.NativeMethodInfoPtr_get_IsMale_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674357);
			Employee.NativeMethodInfoPtr_set_IsMale_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674358);
			Employee.NativeMethodInfoPtr_get_AppearanceIndex_Protected_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674359);
			Employee.NativeMethodInfoPtr_set_AppearanceIndex_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674360);
			Employee.NativeMethodInfoPtr_get_EmployeeType_Public_get_EEmployeeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674361);
			Employee.NativeMethodInfoPtr_get_TimeSinceLastWorked_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674362);
			Employee.NativeMethodInfoPtr_set_TimeSinceLastWorked_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674363);
			Employee.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674364);
			Employee.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674365);
			Employee.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674366);
			Employee.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_NetworkConnection_String_String_String_String_String_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674367);
			Employee.NativeMethodInfoPtr_AssignProperty_Protected_Virtual_New_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674368);
			Employee.NativeMethodInfoPtr_InitializeInfo_Protected_Virtual_New_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674369);
			Employee.NativeMethodInfoPtr_InitializeAppearance_Protected_Virtual_New_Void_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674370);
			Employee.NativeMethodInfoPtr_CheckDialogueChoice_Protected_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674371);
			Employee.NativeMethodInfoPtr_SendFire_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674372);
			Employee.NativeMethodInfoPtr_ReceiveFire_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674373);
			Employee.NativeMethodInfoPtr_Fire_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674374);
			Employee.NativeMethodInfoPtr_CanWork_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674375);
			Employee.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674376);
			Employee.NativeMethodInfoPtr_UpdateBehaviour_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674377);
			Employee.NativeMethodInfoPtr_MarkIsWorking_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674378);
			Employee.NativeMethodInfoPtr_SetWaitOutside_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674379);
			Employee.NativeMethodInfoPtr_ShouldIdle_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674380);
			Employee.NativeMethodInfoPtr_ShouldNoticeGeneralCrime_Protected_Virtual_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674381);
			Employee.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674382);
			Employee.NativeMethodInfoPtr_OnSleepEnd_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674383);
			Employee.NativeMethodInfoPtr_SetIsPaid_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674384);
			Employee.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674385);
			Employee.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674386);
			Employee.NativeMethodInfoPtr_GetBed_Public_Virtual_New_BedItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674387);
			Employee.NativeMethodInfoPtr_IsPayAvailable_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674388);
			Employee.NativeMethodInfoPtr_RemoveDailyWage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674389);
			Employee.NativeMethodInfoPtr_GetWorkIssue_Public_Virtual_New_Boolean_byref_DialogueContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674390);
			Employee.NativeMethodInfoPtr_SetIdle_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674391);
			Employee.NativeMethodInfoPtr_LeavePropertyAndDespawn_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674392);
			Employee.NativeMethodInfoPtr_SubmitNoWorkReason_Public_Void_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674393);
			Employee.NativeMethodInfoPtr_ShouldShowNoWorkDialogue_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674394);
			Employee.NativeMethodInfoPtr_OnNotWorkingDialogue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674395);
			Employee.NativeMethodInfoPtr_ShouldShowFireDialogue_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674396);
			Employee.NativeMethodInfoPtr_TradeItems_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674397);
			Employee.NativeMethodInfoPtr_TradeItemsDone_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674398);
			Employee.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674399);
			Employee.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674400);
			Employee.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674401);
			Employee.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674402);
			Employee.NativeMethodInfoPtr_RpcWriter___Observers_Initialize_2260823878_Private_Void_NetworkConnection_String_String_String_String_String_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674403);
			Employee.NativeMethodInfoPtr_RpcLogic___Initialize_2260823878_Public_Virtual_New_Void_NetworkConnection_String_String_String_String_String_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674404);
			Employee.NativeMethodInfoPtr_RpcReader___Observers_Initialize_2260823878_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674405);
			Employee.NativeMethodInfoPtr_RpcWriter___Target_Initialize_2260823878_Private_Void_NetworkConnection_String_String_String_String_String_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674406);
			Employee.NativeMethodInfoPtr_RpcReader___Target_Initialize_2260823878_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674407);
			Employee.NativeMethodInfoPtr_RpcWriter___Server_SendFire_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674408);
			Employee.NativeMethodInfoPtr_RpcLogic___SendFire_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674409);
			Employee.NativeMethodInfoPtr_RpcReader___Server_SendFire_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674410);
			Employee.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveFire_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674411);
			Employee.NativeMethodInfoPtr_RpcLogic___ReceiveFire_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674412);
			Employee.NativeMethodInfoPtr_RpcReader___Observers_ReceiveFire_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674413);
			Employee.NativeMethodInfoPtr_RpcWriter___Observers_SubmitNoWorkReason_15643032_Private_Void_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674414);
			Employee.NativeMethodInfoPtr_RpcLogic___SubmitNoWorkReason_15643032_Public_Void_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674415);
			Employee.NativeMethodInfoPtr_RpcReader___Observers_SubmitNoWorkReason_15643032_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674416);
			Employee.NativeMethodInfoPtr_sync___get_value__PaidForToday_k__BackingField_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674417);
			Employee.NativeMethodInfoPtr_sync___set_value__PaidForToday_k__BackingField_Public_set_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674418);
			Employee.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Employees_Employee_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674419);
			Employee.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674420);
		}

		// Token: 0x17001A96 RID: 6806
		// (get) Token: 0x060057BA RID: 22458 RVA: 0x00199AE0 File Offset: 0x00197CE0
		// (set) Token: 0x060057BB RID: 22459 RVA: 0x00199B20 File Offset: 0x00197D20
		public unsafe Property AssignedProperty
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_get_AssignedProperty_Public_get_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Property>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_set_AssignedProperty_Protected_set_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001A97 RID: 6807
		// (get) Token: 0x060057BC RID: 22460 RVA: 0x00199B64 File Offset: 0x00197D64
		// (set) Token: 0x060057BD RID: 22461 RVA: 0x00199BA0 File Offset: 0x00197DA0
		public unsafe int EmployeeIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_get_EmployeeIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_set_EmployeeIndex_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001A98 RID: 6808
		// (get) Token: 0x060057BE RID: 22462 RVA: 0x00199BE0 File Offset: 0x00197DE0
		// (set) Token: 0x060057BF RID: 22463 RVA: 0x00199C1C File Offset: 0x00197E1C
		public unsafe bool PaidForToday
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 185164, RefRangeEnd = 185165, XrefRangeStart = 185164, XrefRangeEnd = 185164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_get_PaidForToday_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 185172, RefRangeEnd = 185175, XrefRangeStart = 185165, XrefRangeEnd = 185172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_set_PaidForToday_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001A99 RID: 6809
		// (get) Token: 0x060057C0 RID: 22464 RVA: 0x00199C5C File Offset: 0x00197E5C
		// (set) Token: 0x060057C1 RID: 22465 RVA: 0x00199C98 File Offset: 0x00197E98
		public unsafe bool Fired
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_get_Fired_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_set_Fired_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001A9A RID: 6810
		// (get) Token: 0x060057C2 RID: 22466 RVA: 0x00199CD8 File Offset: 0x00197ED8
		public unsafe bool IsWaitingOutside
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_get_IsWaitingOutside_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001A9B RID: 6811
		// (get) Token: 0x060057C3 RID: 22467 RVA: 0x00199D14 File Offset: 0x00197F14
		// (set) Token: 0x060057C4 RID: 22468 RVA: 0x00199D50 File Offset: 0x00197F50
		public unsafe bool IsMale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_get_IsMale_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_set_IsMale_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001A9C RID: 6812
		// (get) Token: 0x060057C5 RID: 22469 RVA: 0x00199D90 File Offset: 0x00197F90
		// (set) Token: 0x060057C6 RID: 22470 RVA: 0x00199DCC File Offset: 0x00197FCC
		public unsafe int AppearanceIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_get_AppearanceIndex_Protected_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_set_AppearanceIndex_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001A9D RID: 6813
		// (get) Token: 0x060057C7 RID: 22471 RVA: 0x00199E0C File Offset: 0x0019800C
		public unsafe EEmployeeType EmployeeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_get_EmployeeType_Public_get_EEmployeeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001A9E RID: 6814
		// (get) Token: 0x060057C8 RID: 22472 RVA: 0x00199E48 File Offset: 0x00198048
		// (set) Token: 0x060057C9 RID: 22473 RVA: 0x00199E84 File Offset: 0x00198084
		public unsafe int TimeSinceLastWorked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_get_TimeSinceLastWorked_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_set_TimeSinceLastWorked_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060057CA RID: 22474 RVA: 0x00199EC4 File Offset: 0x001980C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 185240, RefRangeEnd = 185241, XrefRangeStart = 185175, XrefRangeEnd = 185240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057CB RID: 22475 RVA: 0x00199F00 File Offset: 0x00198100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185241, XrefRangeEnd = 185250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057CC RID: 22476 RVA: 0x00199F3C File Offset: 0x0019813C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 185253, RefRangeEnd = 185257, XrefRangeStart = 185250, XrefRangeEnd = 185253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057CD RID: 22477 RVA: 0x00199F8C File Offset: 0x0019818C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185257, XrefRangeEnd = 185313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(NetworkConnection conn, string firstName, string lastName, string id, string guid, string propertyID, bool male, int appearanceIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(firstName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lastName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propertyID);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref male;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appearanceIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_NetworkConnection_String_String_String_String_String_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057CE RID: 22478 RVA: 0x0019A054 File Offset: 0x00198254
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 185320, RefRangeEnd = 185324, XrefRangeStart = 185313, XrefRangeEnd = 185320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AssignProperty(Property prop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(prop);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_AssignProperty_Protected_Virtual_New_Void_Property_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057CF RID: 22479 RVA: 0x0019A0A4 File Offset: 0x001982A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185324, XrefRangeEnd = 185337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeInfo(string firstName, string lastName, string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(firstName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lastName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_InitializeInfo_Protected_Virtual_New_Void_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057D0 RID: 22480 RVA: 0x0019A118 File Offset: 0x00198318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185337, XrefRangeEnd = 185367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeAppearance(bool male, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref male;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_InitializeAppearance_Protected_Virtual_New_Void_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057D1 RID: 22481 RVA: 0x0019A170 File Offset: 0x00198370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185367, XrefRangeEnd = 185387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CheckDialogueChoice(string choiceLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_CheckDialogueChoice_Protected_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057D2 RID: 22482 RVA: 0x0019A1C0 File Offset: 0x001983C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185387, XrefRangeEnd = 185405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendFire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_SendFire_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057D3 RID: 22483 RVA: 0x0019A1F4 File Offset: 0x001983F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185405, XrefRangeEnd = 185423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveFire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_ReceiveFire_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057D4 RID: 22484 RVA: 0x0019A228 File Offset: 0x00198428
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 185439, RefRangeEnd = 185443, XrefRangeStart = 185423, XrefRangeEnd = 185439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Fire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_Fire_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057D5 RID: 22485 RVA: 0x0019A264 File Offset: 0x00198464
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 185451, RefRangeEnd = 185455, XrefRangeStart = 185443, XrefRangeEnd = 185451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanWork()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_CanWork_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060057D6 RID: 22486 RVA: 0x0019A2A0 File Offset: 0x001984A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185455, XrefRangeEnd = 185484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe virtual void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057D7 RID: 22487 RVA: 0x0019A2DC File Offset: 0x001984DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 185523, RefRangeEnd = 185526, XrefRangeStart = 185484, XrefRangeEnd = 185523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateBehaviour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_UpdateBehaviour_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057D8 RID: 22488 RVA: 0x0019A318 File Offset: 0x00198518
		[CallerCount(0)]
		public unsafe void MarkIsWorking()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_MarkIsWorking_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057D9 RID: 22489 RVA: 0x0019A34C File Offset: 0x0019854C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 185528, RefRangeEnd = 185530, XrefRangeStart = 185526, XrefRangeEnd = 185528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWaitOutside(bool wait)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref wait;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_SetWaitOutside_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057DA RID: 22490 RVA: 0x0019A38C File Offset: 0x0019858C
		[CallerCount(183)]
		[CachedScanResults(RefRangeStart = 35953, RefRangeEnd = 36136, XrefRangeStart = 35953, XrefRangeEnd = 36136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldIdle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_ShouldIdle_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060057DB RID: 22491 RVA: 0x0019A3D4 File Offset: 0x001985D4
		[CallerCount(183)]
		[CachedScanResults(RefRangeStart = 35953, RefRangeEnd = 36136, XrefRangeStart = 35953, XrefRangeEnd = 36136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldNoticeGeneralCrime(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_ShouldNoticeGeneralCrime_Protected_Virtual_Boolean_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060057DC RID: 22492 RVA: 0x0019A42C File Offset: 0x0019862C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185530, XrefRangeEnd = 185534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057DD RID: 22493 RVA: 0x0019A468 File Offset: 0x00198668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185534, XrefRangeEnd = 185535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSleepEnd(int sleepTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sleepTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_OnSleepEnd_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057DE RID: 22494 RVA: 0x0019A4A8 File Offset: 0x001986A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 185536, RefRangeEnd = 185537, XrefRangeStart = 185535, XrefRangeEnd = 185536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsPaid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_SetIsPaid_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057DF RID: 22495 RVA: 0x0019A4DC File Offset: 0x001986DC
		[CallerCount(183)]
		[CachedScanResults(RefRangeStart = 35953, RefRangeEnd = 36136, XrefRangeStart = 35953, XrefRangeEnd = 36136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060057E0 RID: 22496 RVA: 0x0019A524 File Offset: 0x00198724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185537, XrefRangeEnd = 185546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060057E1 RID: 22497 RVA: 0x0019A568 File Offset: 0x00198768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185546, XrefRangeEnd = 185552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual BedItem GetBed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_GetBed_Public_Virtual_New_BedItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BedItem>(intPtr3) : null;
		}

		// Token: 0x060057E2 RID: 22498 RVA: 0x0019A5B4 File Offset: 0x001987B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 185557, RefRangeEnd = 185559, XrefRangeStart = 185552, XrefRangeEnd = 185557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPayAvailable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_IsPayAvailable_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060057E3 RID: 22499 RVA: 0x0019A5F0 File Offset: 0x001987F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185559, XrefRangeEnd = 185571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveDailyWage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RemoveDailyWage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057E4 RID: 22500 RVA: 0x0019A624 File Offset: 0x00198824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185571, XrefRangeEnd = 185605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetWorkIssue(out DialogueContainer notWorkingReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_GetWorkIssue_Public_Virtual_New_Boolean_byref_DialogueContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			notWorkingReason = ((intPtr4 == 0) ? null : new DialogueContainer(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060057E5 RID: 22501 RVA: 0x0019A690 File Offset: 0x00198890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185605, XrefRangeEnd = 185606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetIdle(bool idle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref idle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_SetIdle_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057E6 RID: 22502 RVA: 0x0019A6DC File Offset: 0x001988DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185606, XrefRangeEnd = 185612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LeavePropertyAndDespawn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_LeavePropertyAndDespawn_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057E7 RID: 22503 RVA: 0x0019A710 File Offset: 0x00198910
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 185637, RefRangeEnd = 185639, XrefRangeStart = 185612, XrefRangeEnd = 185637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SubmitNoWorkReason(string reason, string fix, int priority = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(reason);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fix);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_SubmitNoWorkReason_Public_Void_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057E8 RID: 22504 RVA: 0x0019A774 File Offset: 0x00198974
		[CallerCount(0)]
		public unsafe bool ShouldShowNoWorkDialogue(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_ShouldShowNoWorkDialogue_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060057E9 RID: 22505 RVA: 0x0019A7C0 File Offset: 0x001989C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185639, XrefRangeEnd = 185640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnNotWorkingDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_OnNotWorkingDialogue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057EA RID: 22506 RVA: 0x0019A7F4 File Offset: 0x001989F4
		[CallerCount(0)]
		public unsafe bool ShouldShowFireDialogue(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_ShouldShowFireDialogue_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060057EB RID: 22507 RVA: 0x0019A840 File Offset: 0x00198A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185640, XrefRangeEnd = 185662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TradeItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_TradeItems_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057EC RID: 22508 RVA: 0x0019A874 File Offset: 0x00198A74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185662, XrefRangeEnd = 185675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TradeItemsDone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_TradeItemsDone_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057ED RID: 22509 RVA: 0x0019A8A8 File Offset: 0x00198AA8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 185683, RefRangeEnd = 185687, XrefRangeStart = 185675, XrefRangeEnd = 185683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Employee() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Employee>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057EE RID: 22510 RVA: 0x0019A8E4 File Offset: 0x00198AE4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 185736, RefRangeEnd = 185740, XrefRangeStart = 185687, XrefRangeEnd = 185736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057EF RID: 22511 RVA: 0x0019A920 File Offset: 0x00198B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185740, XrefRangeEnd = 185741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057F0 RID: 22512 RVA: 0x0019A95C File Offset: 0x00198B5C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057F1 RID: 22513 RVA: 0x0019A998 File Offset: 0x00198B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185741, XrefRangeEnd = 185767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Initialize_2260823878(NetworkConnection conn, string firstName, string lastName, string id, string guid, string propertyID, bool male, int appearanceIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(firstName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lastName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propertyID);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref male;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appearanceIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcWriter___Observers_Initialize_2260823878_Private_Void_NetworkConnection_String_String_String_String_String_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057F2 RID: 22514 RVA: 0x0019AA54 File Offset: 0x00198C54
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 185801, RefRangeEnd = 185804, XrefRangeStart = 185767, XrefRangeEnd = 185801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___Initialize_2260823878(NetworkConnection conn, string firstName, string lastName, string id, string guid, string propertyID, bool male, int appearanceIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(firstName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lastName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propertyID);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref male;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appearanceIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_RpcLogic___Initialize_2260823878_Public_Virtual_New_Void_NetworkConnection_String_String_String_String_String_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057F3 RID: 22515 RVA: 0x0019AB1C File Offset: 0x00198D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185804, XrefRangeEnd = 185814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Initialize_2260823878(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcReader___Observers_Initialize_2260823878_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057F4 RID: 22516 RVA: 0x0019AB6C File Offset: 0x00198D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185814, XrefRangeEnd = 185831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_Initialize_2260823878(NetworkConnection conn, string firstName, string lastName, string id, string guid, string propertyID, bool male, int appearanceIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(firstName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lastName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propertyID);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref male;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appearanceIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcWriter___Target_Initialize_2260823878_Private_Void_NetworkConnection_String_String_String_String_String_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057F5 RID: 22517 RVA: 0x0019AC28 File Offset: 0x00198E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185831, XrefRangeEnd = 185841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_Initialize_2260823878(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcReader___Target_Initialize_2260823878_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057F6 RID: 22518 RVA: 0x0019AC78 File Offset: 0x00198E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendFire_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcWriter___Server_SendFire_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057F7 RID: 22519 RVA: 0x0019ACAC File Offset: 0x00198EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendFire_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcLogic___SendFire_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057F8 RID: 22520 RVA: 0x0019ACE0 File Offset: 0x00198EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185841, XrefRangeEnd = 185851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendFire_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcReader___Server_SendFire_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057F9 RID: 22521 RVA: 0x0019AD44 File Offset: 0x00198F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveFire_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveFire_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057FA RID: 22522 RVA: 0x0019AD78 File Offset: 0x00198F78
		[CallerCount(0)]
		public unsafe void RpcLogic___ReceiveFire_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcLogic___ReceiveFire_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057FB RID: 22523 RVA: 0x0019ADAC File Offset: 0x00198FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185851, XrefRangeEnd = 185852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveFire_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcReader___Observers_ReceiveFire_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057FC RID: 22524 RVA: 0x0019ADFC File Offset: 0x00198FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185852, XrefRangeEnd = 185865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SubmitNoWorkReason_15643032(string reason, string fix, int priority = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(reason);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fix);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcWriter___Observers_SubmitNoWorkReason_15643032_Private_Void_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057FD RID: 22525 RVA: 0x0019AE60 File Offset: 0x00199060
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 185880, RefRangeEnd = 185882, XrefRangeStart = 185865, XrefRangeEnd = 185880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SubmitNoWorkReason_15643032(string reason, string fix, int priority = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(reason);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fix);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcLogic___SubmitNoWorkReason_15643032_Public_Void_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057FE RID: 22526 RVA: 0x0019AEC4 File Offset: 0x001990C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185882, XrefRangeEnd = 185889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SubmitNoWorkReason_15643032(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcReader___Observers_SubmitNoWorkReason_15643032_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001A9F RID: 6815
		// (get) Token: 0x060057FF RID: 22527 RVA: 0x0019AF14 File Offset: 0x00199114
		// (set) Token: 0x06005800 RID: 22528 RVA: 0x0019AF50 File Offset: 0x00199150
		public unsafe bool SyncAccessor_<PaidForToday>k__BackingField
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 185164, RefRangeEnd = 185165, XrefRangeStart = 185164, XrefRangeEnd = 185165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_sync___get_value__PaidForToday_k__BackingField_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 185897, RefRangeEnd = 185898, XrefRangeStart = 185889, XrefRangeEnd = 185897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_sync___set_value__PaidForToday_k__BackingField_Public_set_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005801 RID: 22529 RVA: 0x0019AF9C File Offset: 0x0019919C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185898, XrefRangeEnd = 185901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_Employees_Employee(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Employees_Employee_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005802 RID: 22530 RVA: 0x0019B010 File Offset: 0x00199210
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 142072, RefRangeEnd = 142075, XrefRangeStart = 142072, XrefRangeEnd = 142075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005803 RID: 22531 RVA: 0x00029C8E File Offset: 0x00027E8E
		public Employee(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001A80 RID: 6784
		// (get) Token: 0x06005804 RID: 22532 RVA: 0x0019B04C File Offset: 0x0019924C
		// (set) Token: 0x06005805 RID: 22533 RVA: 0x00029C97 File Offset: 0x00027E97
		public unsafe bool DEBUG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_DEBUG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_DEBUG)) = value;
			}
		}

		// Token: 0x17001A81 RID: 6785
		// (get) Token: 0x06005806 RID: 22534 RVA: 0x0019B074 File Offset: 0x00199274
		// (set) Token: 0x06005807 RID: 22535 RVA: 0x00029CB2 File Offset: 0x00027EB2
		public unsafe Property _AssignedProperty_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__AssignedProperty_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__AssignedProperty_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A82 RID: 6786
		// (get) Token: 0x06005808 RID: 22536 RVA: 0x0019B0A4 File Offset: 0x001992A4
		// (set) Token: 0x06005809 RID: 22537 RVA: 0x00029CD1 File Offset: 0x00027ED1
		public unsafe int _EmployeeIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__EmployeeIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__EmployeeIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x17001A83 RID: 6787
		// (get) Token: 0x0600580A RID: 22538 RVA: 0x0019B0CC File Offset: 0x001992CC
		// (set) Token: 0x0600580B RID: 22539 RVA: 0x00029CEC File Offset: 0x00027EEC
		public unsafe bool _PaidForToday_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__PaidForToday_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__PaidForToday_k__BackingField)) = value;
			}
		}

		// Token: 0x17001A84 RID: 6788
		// (get) Token: 0x0600580C RID: 22540 RVA: 0x0019B0F4 File Offset: 0x001992F4
		// (set) Token: 0x0600580D RID: 22541 RVA: 0x00029D07 File Offset: 0x00027F07
		public unsafe bool _Fired_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__Fired_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__Fired_k__BackingField)) = value;
			}
		}

		// Token: 0x17001A85 RID: 6789
		// (get) Token: 0x0600580E RID: 22542 RVA: 0x0019B11C File Offset: 0x0019931C
		// (set) Token: 0x0600580F RID: 22543 RVA: 0x00029D22 File Offset: 0x00027F22
		public unsafe bool _IsMale_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__IsMale_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__IsMale_k__BackingField)) = value;
			}
		}

		// Token: 0x17001A86 RID: 6790
		// (get) Token: 0x06005810 RID: 22544 RVA: 0x0019B144 File Offset: 0x00199344
		// (set) Token: 0x06005811 RID: 22545 RVA: 0x00029D3D File Offset: 0x00027F3D
		public unsafe int _AppearanceIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__AppearanceIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__AppearanceIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x17001A87 RID: 6791
		// (get) Token: 0x06005812 RID: 22546 RVA: 0x0019B16C File Offset: 0x0019936C
		// (set) Token: 0x06005813 RID: 22547 RVA: 0x00029D58 File Offset: 0x00027F58
		public unsafe EEmployeeType Type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_Type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_Type)) = value;
			}
		}

		// Token: 0x17001A88 RID: 6792
		// (get) Token: 0x06005814 RID: 22548 RVA: 0x0019B194 File Offset: 0x00199394
		// (set) Token: 0x06005815 RID: 22549 RVA: 0x00029D73 File Offset: 0x00027F73
		public unsafe float SigningFee
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_SigningFee);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_SigningFee)) = value;
			}
		}

		// Token: 0x17001A89 RID: 6793
		// (get) Token: 0x06005816 RID: 22550 RVA: 0x0019B1BC File Offset: 0x001993BC
		// (set) Token: 0x06005817 RID: 22551 RVA: 0x00029D8E File Offset: 0x00027F8E
		public unsafe float DailyWage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_DailyWage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_DailyWage)) = value;
			}
		}

		// Token: 0x17001A8A RID: 6794
		// (get) Token: 0x06005818 RID: 22552 RVA: 0x0019B1E4 File Offset: 0x001993E4
		// (set) Token: 0x06005819 RID: 22553 RVA: 0x00029DA9 File Offset: 0x00027FA9
		public unsafe IdleBehaviour WaitOutside
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_WaitOutside);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IdleBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_WaitOutside), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A8B RID: 6795
		// (get) Token: 0x0600581A RID: 22554 RVA: 0x0019B214 File Offset: 0x00199414
		// (set) Token: 0x0600581B RID: 22555 RVA: 0x00029DC8 File Offset: 0x00027FC8
		public unsafe MoveItemBehaviour MoveItemBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_MoveItemBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveItemBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_MoveItemBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A8C RID: 6796
		// (get) Token: 0x0600581C RID: 22556 RVA: 0x0019B244 File Offset: 0x00199444
		// (set) Token: 0x0600581D RID: 22557 RVA: 0x00029DE7 File Offset: 0x00027FE7
		public unsafe DialogueContainer BedNotAssignedDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_BedNotAssignedDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_BedNotAssignedDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A8D RID: 6797
		// (get) Token: 0x0600581E RID: 22558 RVA: 0x0019B274 File Offset: 0x00199474
		// (set) Token: 0x0600581F RID: 22559 RVA: 0x00029E06 File Offset: 0x00028006
		public unsafe DialogueContainer NotPaidDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_NotPaidDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_NotPaidDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A8E RID: 6798
		// (get) Token: 0x06005820 RID: 22560 RVA: 0x0019B2A4 File Offset: 0x001994A4
		// (set) Token: 0x06005821 RID: 22561 RVA: 0x00029E25 File Offset: 0x00028025
		public unsafe DialogueContainer WorkIssueDialogueTemplate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_WorkIssueDialogueTemplate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_WorkIssueDialogueTemplate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A8F RID: 6799
		// (get) Token: 0x06005822 RID: 22562 RVA: 0x0019B2D4 File Offset: 0x001994D4
		// (set) Token: 0x06005823 RID: 22563 RVA: 0x00029E44 File Offset: 0x00028044
		public unsafe DialogueContainer FireDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_FireDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_FireDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A90 RID: 6800
		// (get) Token: 0x06005824 RID: 22564 RVA: 0x0019B304 File Offset: 0x00199504
		// (set) Token: 0x06005825 RID: 22565 RVA: 0x00029E63 File Offset: 0x00028063
		public unsafe List<Employee.NoWorkReason> WorkIssues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_WorkIssues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Employee.NoWorkReason>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_WorkIssues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A91 RID: 6801
		// (get) Token: 0x06005826 RID: 22566 RVA: 0x0019B334 File Offset: 0x00199534
		// (set) Token: 0x06005827 RID: 22567 RVA: 0x00029E82 File Offset: 0x00028082
		public unsafe int _TimeSinceLastWorked_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__TimeSinceLastWorked_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__TimeSinceLastWorked_k__BackingField)) = value;
			}
		}

		// Token: 0x17001A92 RID: 6802
		// (get) Token: 0x06005828 RID: 22568 RVA: 0x0019B35C File Offset: 0x0019955C
		// (set) Token: 0x06005829 RID: 22569 RVA: 0x00029E9D File Offset: 0x0002809D
		public unsafe bool initialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_initialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_initialized)) = value;
			}
		}

		// Token: 0x17001A93 RID: 6803
		// (get) Token: 0x0600582A RID: 22570 RVA: 0x0019B384 File Offset: 0x00199584
		// (set) Token: 0x0600582B RID: 22571 RVA: 0x00029EB8 File Offset: 0x000280B8
		public unsafe SyncVar<bool> syncVar____PaidForToday_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_syncVar____PaidForToday_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_syncVar____PaidForToday_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A94 RID: 6804
		// (get) Token: 0x0600582C RID: 22572 RVA: 0x0019B3B4 File Offset: 0x001995B4
		// (set) Token: 0x0600582D RID: 22573 RVA: 0x00029ED7 File Offset: 0x000280D7
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001A95 RID: 6805
		// (get) Token: 0x0600582E RID: 22574 RVA: 0x0019B3DC File Offset: 0x001995DC
		// (set) Token: 0x0600582F RID: 22575 RVA: 0x00029EF2 File Offset: 0x000280F2
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003BA7 RID: 15271
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x04003BA8 RID: 15272
		private static readonly IntPtr NativeFieldInfoPtr__AssignedProperty_k__BackingField;

		// Token: 0x04003BA9 RID: 15273
		private static readonly IntPtr NativeFieldInfoPtr__EmployeeIndex_k__BackingField;

		// Token: 0x04003BAA RID: 15274
		private static readonly IntPtr NativeFieldInfoPtr__PaidForToday_k__BackingField;

		// Token: 0x04003BAB RID: 15275
		private static readonly IntPtr NativeFieldInfoPtr__Fired_k__BackingField;

		// Token: 0x04003BAC RID: 15276
		private static readonly IntPtr NativeFieldInfoPtr__IsMale_k__BackingField;

		// Token: 0x04003BAD RID: 15277
		private static readonly IntPtr NativeFieldInfoPtr__AppearanceIndex_k__BackingField;

		// Token: 0x04003BAE RID: 15278
		private static readonly IntPtr NativeFieldInfoPtr_Type;

		// Token: 0x04003BAF RID: 15279
		private static readonly IntPtr NativeFieldInfoPtr_SigningFee;

		// Token: 0x04003BB0 RID: 15280
		private static readonly IntPtr NativeFieldInfoPtr_DailyWage;

		// Token: 0x04003BB1 RID: 15281
		private static readonly IntPtr NativeFieldInfoPtr_WaitOutside;

		// Token: 0x04003BB2 RID: 15282
		private static readonly IntPtr NativeFieldInfoPtr_MoveItemBehaviour;

		// Token: 0x04003BB3 RID: 15283
		private static readonly IntPtr NativeFieldInfoPtr_BedNotAssignedDialogue;

		// Token: 0x04003BB4 RID: 15284
		private static readonly IntPtr NativeFieldInfoPtr_NotPaidDialogue;

		// Token: 0x04003BB5 RID: 15285
		private static readonly IntPtr NativeFieldInfoPtr_WorkIssueDialogueTemplate;

		// Token: 0x04003BB6 RID: 15286
		private static readonly IntPtr NativeFieldInfoPtr_FireDialogue;

		// Token: 0x04003BB7 RID: 15287
		private static readonly IntPtr NativeFieldInfoPtr_WorkIssues;

		// Token: 0x04003BB8 RID: 15288
		private static readonly IntPtr NativeFieldInfoPtr__TimeSinceLastWorked_k__BackingField;

		// Token: 0x04003BB9 RID: 15289
		private static readonly IntPtr NativeFieldInfoPtr_initialized;

		// Token: 0x04003BBA RID: 15290
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____PaidForToday_k__BackingField;

		// Token: 0x04003BBB RID: 15291
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003BBC RID: 15292
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003BBD RID: 15293
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedProperty_Public_get_Property_0;

		// Token: 0x04003BBE RID: 15294
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedProperty_Protected_set_Void_Property_0;

		// Token: 0x04003BBF RID: 15295
		private static readonly IntPtr NativeMethodInfoPtr_get_EmployeeIndex_Public_get_Int32_0;

		// Token: 0x04003BC0 RID: 15296
		private static readonly IntPtr NativeMethodInfoPtr_set_EmployeeIndex_Protected_set_Void_Int32_0;

		// Token: 0x04003BC1 RID: 15297
		private static readonly IntPtr NativeMethodInfoPtr_get_PaidForToday_Public_get_Boolean_0;

		// Token: 0x04003BC2 RID: 15298
		private static readonly IntPtr NativeMethodInfoPtr_set_PaidForToday_Private_set_Void_Boolean_0;

		// Token: 0x04003BC3 RID: 15299
		private static readonly IntPtr NativeMethodInfoPtr_get_Fired_Public_get_Boolean_0;

		// Token: 0x04003BC4 RID: 15300
		private static readonly IntPtr NativeMethodInfoPtr_set_Fired_Private_set_Void_Boolean_0;

		// Token: 0x04003BC5 RID: 15301
		private static readonly IntPtr NativeMethodInfoPtr_get_IsWaitingOutside_Public_get_Boolean_0;

		// Token: 0x04003BC6 RID: 15302
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMale_Public_get_Boolean_0;

		// Token: 0x04003BC7 RID: 15303
		private static readonly IntPtr NativeMethodInfoPtr_set_IsMale_Private_set_Void_Boolean_0;

		// Token: 0x04003BC8 RID: 15304
		private static readonly IntPtr NativeMethodInfoPtr_get_AppearanceIndex_Protected_get_Int32_0;

		// Token: 0x04003BC9 RID: 15305
		private static readonly IntPtr NativeMethodInfoPtr_set_AppearanceIndex_Private_set_Void_Int32_0;

		// Token: 0x04003BCA RID: 15306
		private static readonly IntPtr NativeMethodInfoPtr_get_EmployeeType_Public_get_EEmployeeType_0;

		// Token: 0x04003BCB RID: 15307
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSinceLastWorked_Public_get_Int32_0;

		// Token: 0x04003BCC RID: 15308
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeSinceLastWorked_Private_set_Void_Int32_0;

		// Token: 0x04003BCD RID: 15309
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04003BCE RID: 15310
		private static readonly IntPtr NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0;

		// Token: 0x04003BCF RID: 15311
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04003BD0 RID: 15312
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_NetworkConnection_String_String_String_String_String_Boolean_Int32_0;

		// Token: 0x04003BD1 RID: 15313
		private static readonly IntPtr NativeMethodInfoPtr_AssignProperty_Protected_Virtual_New_Void_Property_0;

		// Token: 0x04003BD2 RID: 15314
		private static readonly IntPtr NativeMethodInfoPtr_InitializeInfo_Protected_Virtual_New_Void_String_String_String_0;

		// Token: 0x04003BD3 RID: 15315
		private static readonly IntPtr NativeMethodInfoPtr_InitializeAppearance_Protected_Virtual_New_Void_Boolean_Int32_0;

		// Token: 0x04003BD4 RID: 15316
		private static readonly IntPtr NativeMethodInfoPtr_CheckDialogueChoice_Protected_Virtual_New_Void_String_0;

		// Token: 0x04003BD5 RID: 15317
		private static readonly IntPtr NativeMethodInfoPtr_SendFire_Public_Void_0;

		// Token: 0x04003BD6 RID: 15318
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveFire_Private_Void_0;

		// Token: 0x04003BD7 RID: 15319
		private static readonly IntPtr NativeMethodInfoPtr_Fire_Protected_Virtual_New_Void_0;

		// Token: 0x04003BD8 RID: 15320
		private static readonly IntPtr NativeMethodInfoPtr_CanWork_Protected_Boolean_0;

		// Token: 0x04003BD9 RID: 15321
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0;

		// Token: 0x04003BDA RID: 15322
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBehaviour_Protected_Virtual_New_Void_0;

		// Token: 0x04003BDB RID: 15323
		private static readonly IntPtr NativeMethodInfoPtr_MarkIsWorking_Protected_Void_0;

		// Token: 0x04003BDC RID: 15324
		private static readonly IntPtr NativeMethodInfoPtr_SetWaitOutside_Private_Void_Boolean_0;

		// Token: 0x04003BDD RID: 15325
		private static readonly IntPtr NativeMethodInfoPtr_ShouldIdle_Protected_Virtual_New_Boolean_0;

		// Token: 0x04003BDE RID: 15326
		private static readonly IntPtr NativeMethodInfoPtr_ShouldNoticeGeneralCrime_Protected_Virtual_Boolean_Player_0;

		// Token: 0x04003BDF RID: 15327
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x04003BE0 RID: 15328
		private static readonly IntPtr NativeMethodInfoPtr_OnSleepEnd_Private_Void_Int32_0;

		// Token: 0x04003BE1 RID: 15329
		private static readonly IntPtr NativeMethodInfoPtr_SetIsPaid_Public_Void_0;

		// Token: 0x04003BE2 RID: 15330
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0;

		// Token: 0x04003BE3 RID: 15331
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x04003BE4 RID: 15332
		private static readonly IntPtr NativeMethodInfoPtr_GetBed_Public_Virtual_New_BedItem_0;

		// Token: 0x04003BE5 RID: 15333
		private static readonly IntPtr NativeMethodInfoPtr_IsPayAvailable_Public_Boolean_0;

		// Token: 0x04003BE6 RID: 15334
		private static readonly IntPtr NativeMethodInfoPtr_RemoveDailyWage_Public_Void_0;

		// Token: 0x04003BE7 RID: 15335
		private static readonly IntPtr NativeMethodInfoPtr_GetWorkIssue_Public_Virtual_New_Boolean_byref_DialogueContainer_0;

		// Token: 0x04003BE8 RID: 15336
		private static readonly IntPtr NativeMethodInfoPtr_SetIdle_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04003BE9 RID: 15337
		private static readonly IntPtr NativeMethodInfoPtr_LeavePropertyAndDespawn_Protected_Void_0;

		// Token: 0x04003BEA RID: 15338
		private static readonly IntPtr NativeMethodInfoPtr_SubmitNoWorkReason_Public_Void_String_String_Int32_0;

		// Token: 0x04003BEB RID: 15339
		private static readonly IntPtr NativeMethodInfoPtr_ShouldShowNoWorkDialogue_Private_Boolean_Boolean_0;

		// Token: 0x04003BEC RID: 15340
		private static readonly IntPtr NativeMethodInfoPtr_OnNotWorkingDialogue_Private_Void_0;

		// Token: 0x04003BED RID: 15341
		private static readonly IntPtr NativeMethodInfoPtr_ShouldShowFireDialogue_Private_Boolean_Boolean_0;

		// Token: 0x04003BEE RID: 15342
		private static readonly IntPtr NativeMethodInfoPtr_TradeItems_Private_Void_0;

		// Token: 0x04003BEF RID: 15343
		private static readonly IntPtr NativeMethodInfoPtr_TradeItemsDone_Private_Void_0;

		// Token: 0x04003BF0 RID: 15344
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003BF1 RID: 15345
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003BF2 RID: 15346
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003BF3 RID: 15347
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003BF4 RID: 15348
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Initialize_2260823878_Private_Void_NetworkConnection_String_String_String_String_String_Boolean_Int32_0;

		// Token: 0x04003BF5 RID: 15349
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Initialize_2260823878_Public_Virtual_New_Void_NetworkConnection_String_String_String_String_String_Boolean_Int32_0;

		// Token: 0x04003BF6 RID: 15350
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Initialize_2260823878_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003BF7 RID: 15351
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_Initialize_2260823878_Private_Void_NetworkConnection_String_String_String_String_String_Boolean_Int32_0;

		// Token: 0x04003BF8 RID: 15352
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_Initialize_2260823878_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003BF9 RID: 15353
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendFire_2166136261_Private_Void_0;

		// Token: 0x04003BFA RID: 15354
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendFire_2166136261_Public_Void_0;

		// Token: 0x04003BFB RID: 15355
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendFire_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003BFC RID: 15356
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveFire_2166136261_Private_Void_0;

		// Token: 0x04003BFD RID: 15357
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveFire_2166136261_Private_Void_0;

		// Token: 0x04003BFE RID: 15358
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveFire_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003BFF RID: 15359
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SubmitNoWorkReason_15643032_Private_Void_String_String_Int32_0;

		// Token: 0x04003C00 RID: 15360
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SubmitNoWorkReason_15643032_Public_Void_String_String_Int32_0;

		// Token: 0x04003C01 RID: 15361
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SubmitNoWorkReason_15643032_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003C02 RID: 15362
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__PaidForToday_k__BackingField_Public_get_Boolean_0;

		// Token: 0x04003C03 RID: 15363
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__PaidForToday_k__BackingField_Public_set_Void_Boolean_Boolean_0;

		// Token: 0x04003C04 RID: 15364
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Employees_Employee_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04003C05 RID: 15365
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x020009D0 RID: 2512
		public class NoWorkReason : Object
		{
			// Token: 0x0600CCC7 RID: 52423 RVA: 0x00315F64 File Offset: 0x00314164
			// Note: this type is marked as 'beforefieldinit'.
			static NoWorkReason()
			{
				Il2CppClassPointerStore<Employee.NoWorkReason>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Employee>.NativeClassPtr, "NoWorkReason");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Employee.NoWorkReason>.NativeClassPtr);
				Employee.NoWorkReason.NativeFieldInfoPtr_Reason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee.NoWorkReason>.NativeClassPtr, "Reason");
				Employee.NoWorkReason.NativeFieldInfoPtr_Fix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee.NoWorkReason>.NativeClassPtr, "Fix");
				Employee.NoWorkReason.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee.NoWorkReason>.NativeClassPtr, "Priority");
				Employee.NoWorkReason.NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee.NoWorkReason>.NativeClassPtr, 100674421);
			}

			// Token: 0x0600CCC8 RID: 52424 RVA: 0x00315FE0 File Offset: 0x003141E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185161, XrefRangeEnd = 185164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NoWorkReason(string reason, string fix, int priority) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Employee.NoWorkReason>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(reason);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fix);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NoWorkReason.NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CCC9 RID: 52425 RVA: 0x0006394C File Offset: 0x00061B4C
			public NoWorkReason(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FC9 RID: 16329
			// (get) Token: 0x0600CCCA RID: 52426 RVA: 0x0031604C File Offset: 0x0031424C
			// (set) Token: 0x0600CCCB RID: 52427 RVA: 0x00063955 File Offset: 0x00061B55
			public unsafe string Reason
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NoWorkReason.NativeFieldInfoPtr_Reason);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NoWorkReason.NativeFieldInfoPtr_Reason), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003FCA RID: 16330
			// (get) Token: 0x0600CCCC RID: 52428 RVA: 0x00316074 File Offset: 0x00314274
			// (set) Token: 0x0600CCCD RID: 52429 RVA: 0x00063974 File Offset: 0x00061B74
			public unsafe string Fix
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NoWorkReason.NativeFieldInfoPtr_Fix);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NoWorkReason.NativeFieldInfoPtr_Fix), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003FCB RID: 16331
			// (get) Token: 0x0600CCCE RID: 52430 RVA: 0x0031609C File Offset: 0x0031429C
			// (set) Token: 0x0600CCCF RID: 52431 RVA: 0x00063993 File Offset: 0x00061B93
			public unsafe int Priority
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NoWorkReason.NativeFieldInfoPtr_Priority);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NoWorkReason.NativeFieldInfoPtr_Priority)) = value;
				}
			}

			// Token: 0x04008A73 RID: 35443
			private static readonly IntPtr NativeFieldInfoPtr_Reason;

			// Token: 0x04008A74 RID: 35444
			private static readonly IntPtr NativeFieldInfoPtr_Fix;

			// Token: 0x04008A75 RID: 35445
			private static readonly IntPtr NativeFieldInfoPtr_Priority;

			// Token: 0x04008A76 RID: 35446
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_0;
		}
	}
}
